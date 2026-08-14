using System;
using System.Runtime.CompilerServices;

public sealed class PeHeaderEraser : RemoteMemoryAccessor, IDisposable
{
	[CompilerGenerated]
	internal RemoteProcess gclass2_0;

	[SpecialName]
	[CompilerGenerated]
	public RemoteProcess method_17()
	{
		return gclass2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_18(RemoteProcess gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	public PeHeaderEraser(RemoteProcess gclass2_1)
	{
		method_18(gclass2_1);
	}

	protected override void method_04C6()
	{
		if (base.method_2() == IntPtr.Zero && base.method_0() != -1)
		{
			base.method_3(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, base.method_0()));
		}
	}

	public void method_19(IntPtr intptr_1)
	{
		if (!base.method_8(this.method_17().ProcessId))
		{
			throw new UnauthorizedAccessException(EncodedStringTable.smethod_0(9714));
		}
		NativeTypes.Struct47 @struct;
		if (NativeTypes.VirtualQueryEx(base.method_2(), intptr_1, out @struct, (uint)NativeTypes.int_0) == 0)
		{
			throw new AccessViolationException(EncodedStringTable.smethod_0(9791));
		}
		NativeTypes.Enum34 enum34_;
		if (!this.vmethod_3(intptr_1, @struct.intptr_2.ToInt64(), NativeTypes.Enum34.flag_6, out enum34_))
		{
			throw new AccessViolationException(EncodedStringTable.smethod_0(9876));
		}
		byte[] array = new byte[@struct.intptr_2.ToInt64()];
		PlatformInfo.random_0.NextBytes(array);
		if (!base.method_16<byte>(intptr_1, array))
		{
			throw new AccessViolationException(EncodedStringTable.smethod_0(9949));
		}
		if (!base.method_14(intptr_1, @struct.intptr_2.ToInt64(), enum34_))
		{
			throw new AccessViolationException(EncodedStringTable.smethod_0(9998));
		}
	}

	void IDisposable.Dispose()
	{
		RecoveredRuntime.smethod_388(this);
	}

	internal static UnauthorizedAccessException smethod_6(string string_0)
	{
		return new UnauthorizedAccessException(string_0);
	}

	internal static AccessViolationException smethod_7(string string_0)
	{
		return new AccessViolationException(string_0);
	}
}
