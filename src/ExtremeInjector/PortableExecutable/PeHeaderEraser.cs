using System;
using System.Runtime.CompilerServices;

public sealed class PeHeaderEraser : RemoteMemoryAccessor, IDisposable
{
	[CompilerGenerated]
	internal RemoteProcess gclass2_0;

	[SpecialName]
	[CompilerGenerated]
	public RemoteProcess GetRemoteProcess()
	{
		return gclass2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetRemoteProcess(RemoteProcess gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	public PeHeaderEraser(RemoteProcess gclass2_1)
	{
		SetRemoteProcess(gclass2_1);
	}

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, base.GetProcessId()));
		}
	}

	public void EraseAt(IntPtr intptr_1)
	{
		if (!base.EnsureAttachedToProcess(this.GetRemoteProcess().ProcessId))
		{
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(9714));
		}
		NativeTypes.Struct47 @struct;
		if (NativeTypes.VirtualQueryEx(base.GetProcessHandle(), intptr_1, out @struct, (uint)NativeTypes.int_0) == 0)
		{
			throw new AccessViolationException(EncodedStringTable.DecodeString(9791));
		}
		NativeTypes.Enum34 enum34_;
		if (!this.ProtectMemoryCore(intptr_1, @struct.intptr_2.ToInt64(), NativeTypes.Enum34.flag_6, out enum34_))
		{
			throw new AccessViolationException(EncodedStringTable.DecodeString(9876));
		}
		byte[] array = new byte[@struct.intptr_2.ToInt64()];
		PlatformInfo.random_0.NextBytes(array);
		if (!base.WriteArray<byte>(intptr_1, array))
		{
			throw new AccessViolationException(EncodedStringTable.DecodeString(9949));
		}
		if (!base.ProtectMemory(intptr_1, @struct.intptr_2.ToInt64(), enum34_))
		{
			throw new AccessViolationException(EncodedStringTable.DecodeString(9998));
		}
	}

	void IDisposable.Dispose()
	{
		RecoveredRuntime.CloseRemoteMemoryAccessor(this);
	}
}
