using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public sealed class LdrLoadDllInjector : DllInjector
{
	public LdrLoadDllInjector(RemoteProcess remoteProcess)
		: base(remoteProcess)
	{
	}

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.ProcessAccessRights.CreateThread | NativeTypes.ProcessAccessRights.VirtualMemoryOperation | NativeTypes.ProcessAccessRights.VirtualMemoryRead | NativeTypes.ProcessAccessRights.VirtualMemoryWrite | NativeTypes.ProcessAccessRights.QueryInformation, false, base.GetProcessId()));
		}
	}

	public override IntPtr Inject(string text)
	{
		if (!Path.IsPathRooted(text))
		{
			text = Path.GetFullPath(text);
		}
		if (!File.Exists(text))
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(28151) + text + EncodedStringTable.DecodeString(3656));
		}
		if (!base.EnsureAttachedToProcess(base.GetRemoteProcess().ProcessId))
		{
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(12662));
		}
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess())[EncodedStringTable.DecodeString(8549)];
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(12731));
		}
		IntPtr intPtr = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(28220), false);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(EncodedStringTable.DecodeString(28237));
		}
		int int_;
		int intValue;
		IntPtr intPtr2 = this.BuildLoaderStub(intPtr, text, out int_, out intValue);
		IntPtr intPtr3 = RecoveredRuntime.StartRemoteThread(this, intPtr2, IntPtr.Zero);
		if (intPtr3 == IntPtr.Zero)
		{
			this.ReleaseMemory(intPtr2);
			throw new AccessViolationException(EncodedStringTable.DecodeString(12914));
		}
		RecoveredRuntime.WaitForRemoteThread(this, intPtr3, -1);
		if (RecoveredRuntime.HasProcessExited(base.GetRemoteProcess()))
		{
			this.ReleaseMemory(intPtr2);
			throw new Exception(EncodedStringTable.DecodeString(28330));
		}
		uint num = base.Read<uint>(intPtr2.Add(intValue));
		if (num != 0u)
		{
			this.ReleaseMemory(intPtr2);
			throw new Exception(EncodedStringTable.DecodeString(28411) + num.ToString(EncodedStringTable.DecodeString(28492)) + EncodedStringTable.DecodeString(3656), RecoveredRuntime.CreateWin32ExceptionFromNtStatus(num, this));
		}
		IntPtr result = RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()) ? ((IntPtr)((long)((ulong)base.Read<uint>(intPtr2.Add(int_))))) : base.Read<IntPtr>(intPtr2.Add(int_));
		this.ReleaseMemory(intPtr2);
		RecoveredRuntime.CloseRemoteHandle(this, intPtr3);
		return result;
	}

	internal IntPtr BuildLoaderStub(IntPtr address, string text, out int intValue, out int intValue2)
	{
		IntPtr intPtr = RecoveredRuntime.AllocateRemoteMemory(this, 4096L, NativeTypes.MemoryProtection.ExecuteReadWrite);
		if (intPtr == IntPtr.Zero)
		{
			throw new AccessViolationException(EncodedStringTable.DecodeString(28957));
		}
		AsmJitAssembler @class = new AsmJitAssembler();
		RemoteAssembler class2 = new RemoteAssembler(@class, base.GetRemoteProcess());
		class2.SetRandomizeArgumentSetup(true);
		RemoteAssembler class47_ = class2;
		AsmJitLabel class58_ = RecoveredRuntime.CreateLabel(@class);
		AsmJitLabel label = RecoveredRuntime.CreateLabel(@class);
		AsmJitLabel label2 = RecoveredRuntime.CreateLabel(@class);
		RecoveredRuntime.EmitRemoteCallPrologue(class47_);
		RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(address), CallingConvention.StdCall, new object[]
		{
			IntPtr.Zero,
			IntPtr.Zero,
			RecoveredRuntime.CreateLabelReference(class47_, label),
			RecoveredRuntime.CreateLabelReference(class47_, class58_)
		});
		if (RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()))
		{
			AsmJitAssembler class3 = @class;
			class3.assemblerState.uintValue3 = (class3.assemblerState.uintValue3 | 8u);
		}
		RecoveredRuntime.EmitMoveRegisterToMemory(@class, RecoveredRuntime.CreateDwordLabelMemory(label2, 0L), AsmJitRuntime.gpRegister38);
		RecoveredRuntime.EmitRemoteCallEpilogue(class47_, -1);
		RecoveredRuntime.AlignRemoteData(class47_);
		RecoveredRuntime.BindLabel(@class, class58_);
		intValue = RecoveredRuntime.GetAssemblerOffset(@class);
		RecoveredRuntime.EmbedNullPointer(class47_);
		RecoveredRuntime.AlignRemoteData(class47_);
		RecoveredRuntime.BindLabel(@class, label2);
		intValue2 = RecoveredRuntime.GetAssemblerOffset(@class);
		RecoveredRuntime.EmbedUInt32(@class, 0u);
		RecoveredRuntime.AlignRemoteData(class47_);
		IntPtr address2 = intPtr.Add(RecoveredRuntime.GetAssemblerOffset(@class));
		byte[] bytes = Encoding.Unicode.GetBytes(text + EncodedStringTable.DecodeString(12219));
		RecoveredRuntime.EmbedBytes(@class, bytes);
		RecoveredRuntime.AlignRemoteData(class47_);
		RecoveredRuntime.BindLabel(@class, label);
		RecoveredRuntime.EmbedUInt16(@class, (ushort)(bytes.Length - 2));
		RecoveredRuntime.EmbedUInt16(@class, (ushort)bytes.Length);
		RecoveredRuntime.AlignRemoteData(class47_);
		RecoveredRuntime.EmbedPlatformPointer(class47_, address2);
		if (!(RecoveredRuntime.AssembleRemoteCode(intPtr, @class, this) == IntPtr.Zero))
		{
			return intPtr;
		}
		this.ReleaseMemory(intPtr);
		throw new InvalidOperationException(EncodedStringTable.DecodeString(28571));
	}
}
