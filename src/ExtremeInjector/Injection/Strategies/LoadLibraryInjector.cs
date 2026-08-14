using System;
using System.IO;
using System.Text;

public sealed class LoadLibraryInjector : DllInjector
{
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

		byte[] encodedPath = Encoding.Unicode.GetBytes(modulePath + "\0");
		IntPtr remotePath = RecoveredRuntime.AllocateRemoteMemory(this, encodedPath.Length, NativeTypes.MemoryProtection.ReadWrite);
		if (remotePath == IntPtr.Zero)
		{
			throw new AccessViolationException("Unable to allocate memory for the injection path.");
		}

		try
		{
			if (!WriteArray(remotePath, encodedPath))
			{
				throw new AccessViolationException("Unable to write memory for the injection path.");
			}

			IntPtr remoteThread = RecoveredRuntime.StartRemoteThread(this, loadLibraryAddress, remotePath);
			if (remoteThread == IntPtr.Zero)
			{
				throw new AccessViolationException("Unable to create thread in the specified process.");
			}

			try
			{
				RecoveredRuntime.WaitForRemoteThread(this, remoteThread, -1);
			}
			finally
			{
				RecoveredRuntime.CloseRemoteHandle(this, remoteThread);
			}
		}
		finally
		{
			ReleaseMemory(remotePath);
		}

		return RecoveredRuntime.CaptureProcessModules(process).GetModuleBase(Path.GetFileName(modulePath));
	}
}
