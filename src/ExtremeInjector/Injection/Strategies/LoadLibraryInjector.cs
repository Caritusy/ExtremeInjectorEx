using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public sealed class LoadLibraryInjector : DllInjector
{
	private const uint RemoteExecutionTimeoutMilliseconds = 30_000;
	private const uint WaitObject0 = 0;
	private const uint WaitTimeout = 0x102;

	private const NativeTypes.ProcessAccessRights InjectionProcessAccess =
		NativeTypes.ProcessAccessRights.CreateThread |
		NativeTypes.ProcessAccessRights.VirtualMemoryOperation |
		NativeTypes.ProcessAccessRights.VirtualMemoryRead |
		NativeTypes.ProcessAccessRights.VirtualMemoryWrite |
		NativeTypes.ProcessAccessRights.QueryInformation;

	public LoadLibraryInjector(RemoteProcess process)
		: base(process)
	{
	}

	protected override void EnsureProcessHandle()
	{
		if (GetProcessHandle() != IntPtr.Zero || GetProcessId() == -1)
		{
			return;
		}

		SetProcessHandle(RecoveredRuntime.OpenProcess(InjectionProcessAccess, flag: false, GetProcessId()));
	}

	public override IntPtr Inject(string modulePath)
	{
		if (!Path.IsPathRooted(modulePath))
		{
			modulePath = Path.GetFullPath(modulePath);
		}
		if (!File.Exists(modulePath))
		{
			throw new FileNotFoundException("Unable to find the module to inject.", modulePath);
		}

		RemoteProcess process = GetRemoteProcess();
		if (!EnsureAttachedToProcess(process.ProcessId))
		{
			throw new UnauthorizedAccessException("Unable to open the specified process for injection.");
		}

		ProcessModuleInfo kernel32 = RecoveredRuntime.CaptureProcessModules(process)["kernel32.dll"]
			?? throw new FileNotFoundException("Unable to find kernel32.dll in the specified process.");
		IntPtr loadLibraryAddress = RecoveredRuntime.ResolveExportByName(kernel32, "LoadLibraryW", flag: false);
		if (loadLibraryAddress == IntPtr.Zero)
		{
			throw new MissingMethodException("Unable to find the LoadLibraryW function inside the specified process.");
		}

		IntPtr getLastErrorAddress = RecoveredRuntime.ResolveExportByName(kernel32, "GetLastError", flag: false);
		if (getLastErrorAddress == IntPtr.Zero)
		{
			throw new MissingMethodException("Unable to find the GetLastError function inside the specified process.");
		}

		IntPtr remoteCode = BuildLoaderStub(
			loadLibraryAddress,
			getLastErrorAddress,
			modulePath,
			out int moduleResultOffset,
			out int errorResultOffset,
			out int codeSize);
		IntPtr remoteThread = IntPtr.Zero;
		bool executionCompleted = false;
		try
		{
			if (!RecoveredRuntime.FlushInstructionCache(GetProcessHandle(), remoteCode, (UIntPtr)(uint)codeSize))
			{
				throw new Win32Exception(
					Marshal.GetLastWin32Error(),
					"Unable to flush the LoadLibraryW remote execution stub from the instruction cache.");
			}

			remoteThread = RecoveredRuntime.StartRemoteThread(this, remoteCode, IntPtr.Zero);
			if (remoteThread == IntPtr.Zero)
			{
				throw new Win32Exception(
					Marshal.GetLastWin32Error(),
					"Unable to create the LoadLibraryW remote execution thread.");
			}

			uint waitResult = RecoveredRuntime.WaitForSingleObject(remoteThread, RemoteExecutionTimeoutMilliseconds);
			if (waitResult == WaitTimeout)
			{
				throw new RemoteExecutionTimeoutException(
					"Timed out while waiting for LoadLibraryW. The remote allocation was retained because the thread may still be running.");
			}
			if (waitResult != WaitObject0)
			{
				throw new RemoteExecutionTimeoutException(
					"Waiting for LoadLibraryW failed. The remote allocation was retained because the execution state is unknown.",
					new Win32Exception(Marshal.GetLastWin32Error()));
			}

			executionCompleted = true;
			if (RecoveredRuntime.HasProcessExited(process))
			{
				throw new InvalidOperationException("The target process exited while LoadLibraryW was running.");
			}

			IntPtr moduleBase = RecoveredRuntime.Is32BitProcess(process)
				? new IntPtr(unchecked((long)Read<uint>(remoteCode.Add(moduleResultOffset))))
				: Read<IntPtr>(remoteCode.Add(moduleResultOffset));
			int loaderError = Read<int>(remoteCode.Add(errorResultOffset));
			if (moduleBase == IntPtr.Zero)
			{
				Win32Exception loaderException = loaderError == 0
					? null
					: new Win32Exception(loaderError);
				string errorDetail = loaderException?.Message ??
					"LoadLibraryW returned NULL without setting a Windows error.";
				throw new DllNotFoundException(
					$"LoadLibraryW failed to load '{modulePath}' with Windows error {loaderError}: {errorDetail}",
					loaderException);
			}

			return moduleBase;
		}
		finally
		{
			if (remoteThread != IntPtr.Zero)
			{
				RecoveredRuntime.CloseRemoteHandle(this, remoteThread);
			}
			if (executionCompleted || remoteThread == IntPtr.Zero)
			{
				ReleaseMemory(remoteCode);
			}
		}
	}

	internal IntPtr BuildLoaderStub(
		IntPtr loadLibraryAddress,
		IntPtr getLastErrorAddress,
		string modulePath,
		out int moduleResultOffset,
		out int errorResultOffset,
		out int codeSize)
	{
		AsmJitAssembler assembler = new AsmJitAssembler();
		RemoteAssembler remoteAssembler = new RemoteAssembler(assembler, GetRemoteProcess());
		AsmJitLabel moduleResult = RecoveredRuntime.CreateLabel(assembler);
		AsmJitLabel errorResult = RecoveredRuntime.CreateLabel(assembler);
		AsmJitLabel pathData = RecoveredRuntime.CreateLabel(assembler);

		RecoveredRuntime.EmitRemoteCallPrologue(remoteAssembler);
		RecoveredRuntime.EmitRemoteCall(
			remoteAssembler,
			new AsmJitImmediate(loadLibraryAddress),
			CallingConvention.StdCall,
			new object[] { RecoveredRuntime.CreateLabelReference(remoteAssembler, pathData) });
		RecoveredRuntime.EmitMoveRegisterToMemory(
			assembler,
			RecoveredRuntime.CreatePointerLabelMemory(remoteAssembler, moduleResult, 0L),
			RecoveredRuntime.Is32BitProcess(GetRemoteProcess()) ? AsmJitRuntime.gpRegister38 : AsmJitRuntime.gpRegister54);
		RecoveredRuntime.EmitRemoteCall(
			remoteAssembler,
			new AsmJitImmediate(getLastErrorAddress),
			CallingConvention.StdCall,
			Array.Empty<object>());
		RecoveredRuntime.EmitMoveRegisterToMemory(
			assembler,
			RecoveredRuntime.CreateDwordLabelMemoryForProcess(0L, remoteAssembler, errorResult),
			AsmJitRuntime.gpRegister38);
		RecoveredRuntime.EmitRemoteCallEpilogue(remoteAssembler, -1);

		RecoveredRuntime.AlignRemoteData(remoteAssembler);
		RecoveredRuntime.BindLabel(assembler, moduleResult);
		moduleResultOffset = RecoveredRuntime.GetAssemblerOffset(assembler);
		RecoveredRuntime.EmbedNullPointer(remoteAssembler);

		RecoveredRuntime.AlignRemoteData(remoteAssembler);
		RecoveredRuntime.BindLabel(assembler, errorResult);
		errorResultOffset = RecoveredRuntime.GetAssemblerOffset(assembler);
		RecoveredRuntime.EmbedInt32(assembler, 0);

		RecoveredRuntime.AlignRemoteData(remoteAssembler);
		RecoveredRuntime.BindLabel(assembler, pathData);
		RecoveredRuntime.EmbedBytes(assembler, Encoding.Unicode.GetBytes(modulePath + "\0"));
		codeSize = RecoveredRuntime.GetAssemblerOffset(assembler);

		IntPtr remoteCode = RecoveredRuntime.AssembleRemoteCode(assembler, this);
		if (remoteCode == IntPtr.Zero)
		{
			throw new AccessViolationException("Unable to allocate or write the LoadLibraryW remote execution stub.");
		}
		return remoteCode;
	}
}
