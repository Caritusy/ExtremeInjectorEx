using System;
using System.Runtime.CompilerServices;

public sealed class Class94 : Class82, IDisposable
{
	[CompilerGenerated]
	internal GClass2 gclass2_0;

	[SpecialName]
	[CompilerGenerated]
	public GClass2 method_17()
	{
		return gclass2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_18(GClass2 gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	public Class94(GClass2 gclass2_1)
	{
		method_18(gclass2_1);
	}

	protected override void method_033E()
	{
		if (!(method_2() == IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = 764915726;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x50EC3E33)) % 4)
				{
				case 3u:
					method_3(Class171.OpenProcess(Class124.Enum32.flag_3 | Class124.Enum32.flag_4 | Class124.Enum32.flag_5 | Class124.Enum32.flag_9, false, method_0()));
					num = (int)((num2 * 2085512465) ^ 0x414CF626);
					continue;
				case 1u:
					num = ((method_0() != -1) ? 1784714201 : 197703356) ^ ((int)num2 * -1495590799);
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void method_19(IntPtr intptr_1)
	{
		if (!method_8(method_17().method_0()))
		{
			goto IL_0028;
		}
		goto IL_0134;
		IL_0028:
		int num = -1673395766;
		goto IL_00e3;
		IL_00e3:
		byte[] array = default(byte[]);
		Class124.Struct47 struct47_ = default(Class124.Struct47);
		Class124.Enum34 enum34_ = default(Class124.Enum34);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1200711924)) % 12)
			{
			case 11u:
				break;
			case 9u:
				num = ((!method_16(intptr_1, array)) ? 773293450 : 1046269784) ^ (int)(num2 * 1431763197);
				continue;
			case 8u:
				goto IL_0060;
			case 5u:
				array = new byte[struct47_.intptr_2.ToInt64()];
				Class127.random_0.NextBytes(array);
				num = -269411495;
				continue;
			case 1u:
				goto IL_00b6;
			default:
				return;
			case 7u:
				goto IL_0134;
			case 0u:
				throw new AccessViolationException(Class178.smethod_0(9791));
			case 2u:
				throw new UnauthorizedAccessException(Class178.smethod_0(9714));
			case 3u:
				throw new AccessViolationException(Class178.smethod_0(9949));
			case 6u:
				throw new AccessViolationException(Class178.smethod_0(9998));
			case 10u:
				throw new AccessViolationException(Class178.smethod_0(9876));
			case 4u:
				return;
			}
			break;
			IL_00b6:
			num = (method_14(intptr_1, struct47_.intptr_2.ToInt64(), enum34_) ? (-2142069128) : (-1669067430));
			continue;
			IL_0060:
			num = ((!vmethod_3(intptr_1, struct47_.intptr_2.ToInt64(), Class124.Enum34.flag_6, out enum34_)) ? (-1673415234) : (-86638083));
		}
		goto IL_0028;
		IL_0134:
		num = ((Class124.VirtualQueryEx(method_2(), intptr_1, out struct47_, (uint)Class124.int_0) == 0) ? (-651772932) : (-1944830856));
		goto IL_00e3;
	}

	void IDisposable.Dispose()
	{
		Class171.smethod_382((Class82)this);
	}
}
