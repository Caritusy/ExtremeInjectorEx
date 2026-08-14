using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public sealed class LdrLoadDllInjector : DllInjector
{
	public LdrLoadDllInjector(RemoteProcess gclass2_1)
		: base(gclass2_1)
	{
	}

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_2 | NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, base.GetProcessId()));
		}
	}

	public override IntPtr Inject(string string_0)
	{
		if (!Path.IsPathRooted(string_0))
		{
			string_0 = Path.GetFullPath(string_0);
		}
		if (!File.Exists(string_0))
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(28151) + string_0 + EncodedStringTable.DecodeString(3656));
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
		int int_2;
		IntPtr intPtr2 = this.BuildLoaderStub(intPtr, string_0, out int_, out int_2);
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
		uint num = base.Read<uint>(intPtr2.Add(int_2));
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

	internal IntPtr BuildLoaderStub(IntPtr intptr_1, string string_0, out int int_1, out int int_2)
	{
		IntPtr intPtr = RecoveredRuntime.AllocateRemoteMemory(this, 4096L, NativeTypes.Enum34.flag_2);
		if (intPtr == IntPtr.Zero)
		{
			throw new AccessViolationException(EncodedStringTable.DecodeString(28957));
		}
		AsmJitAssembler @class = new AsmJitAssembler();
		RemoteAssembler class2 = new RemoteAssembler(@class, base.GetRemoteProcess());
		class2.SetRandomizeArgumentSetup(true);
		RemoteAssembler class47_ = class2;
		AsmJitLabel class58_ = RecoveredRuntime.CreateLabel(@class);
		AsmJitLabel class58_2 = RecoveredRuntime.CreateLabel(@class);
		AsmJitLabel class58_3 = RecoveredRuntime.CreateLabel(@class);
		RecoveredRuntime.EmitRemoteCallPrologue(class47_);
		RecoveredRuntime.EmitRemoteCall(class47_, new AsmJitImmediate(intptr_1), CallingConvention.StdCall, new object[]
		{
			IntPtr.Zero,
			IntPtr.Zero,
			RecoveredRuntime.CreateLabelReference(class47_, class58_2),
			RecoveredRuntime.CreateLabelReference(class47_, class58_)
		});
		if (RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()))
		{
			AsmJitAssembler class3 = @class;
			class3.struct19_0.uint_2 = (class3.struct19_0.uint_2 | 8u);
		}
		RecoveredRuntime.EmitMoveRegisterToMemory(@class, RecoveredRuntime.CreateDwordLabelMemory(class58_3, 0L), AsmJitRuntime.class63_37);
		RecoveredRuntime.EmitRemoteCallEpilogue(class47_, -1);
		RecoveredRuntime.AlignRemoteData(class47_);
		RecoveredRuntime.BindLabel(@class, class58_);
		int_1 = RecoveredRuntime.GetAssemblerOffset(@class);
		RecoveredRuntime.EmbedNullPointer(class47_);
		RecoveredRuntime.AlignRemoteData(class47_);
		RecoveredRuntime.BindLabel(@class, class58_3);
		int_2 = RecoveredRuntime.GetAssemblerOffset(@class);
		RecoveredRuntime.EmbedUInt32(@class, 0u);
		RecoveredRuntime.AlignRemoteData(class47_);
		IntPtr intptr_2 = intPtr.Add(RecoveredRuntime.GetAssemblerOffset(@class));
		byte[] bytes = Encoding.Unicode.GetBytes(string_0 + EncodedStringTable.DecodeString(12219));
		RecoveredRuntime.EmbedBytes(@class, bytes);
		RecoveredRuntime.AlignRemoteData(class47_);
		RecoveredRuntime.BindLabel(@class, class58_2);
		RecoveredRuntime.EmbedUInt16(@class, (ushort)(bytes.Length - 2));
		RecoveredRuntime.EmbedUInt16(@class, (ushort)bytes.Length);
		RecoveredRuntime.AlignRemoteData(class47_);
		RecoveredRuntime.EmbedPlatformPointer(class47_, intptr_2);
		if (!(RecoveredRuntime.AssembleRemoteCode(intPtr, @class, this) == IntPtr.Zero))
		{
			return intPtr;
		}
		this.ReleaseMemory(intPtr);
		throw new InvalidOperationException(EncodedStringTable.DecodeString(28571));
	}
}
