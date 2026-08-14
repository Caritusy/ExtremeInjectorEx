using System;
using System.Runtime.CompilerServices;

public sealed class Class119 : Class117
{
	static Class119()
	{
		Class96.smethod_0<Class119>(new Class168[65]
		{
			Class171.smethod_310(typeof(byte)),
			Class171.smethod_310(typeof(byte)),
			Class171.smethod_310(typeof(byte)),
			Class171.smethod_310(typeof(byte)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_192(typeof(uint), 2),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(ulong)),
			Class171.smethod_310(typeof(long)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(ushort)),
			Class171.smethod_310(typeof(ushort)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_192(typeof(uint), 34),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_192(typeof(uint), 32),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(ulong)),
			Class171.smethod_310(typeof(ulong)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(Class115)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint))
		});
	}

	public Class119(GClass2 gclass2_1)
		: base(gclass2_1, bool_2: true)
	{
		while (true)
		{
			int num = 898515389;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x585DEA23)) % 3)
				{
				case 1u:
					goto IL_000a;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000a:
				method_033E();
				num = ((int)num2 * -7703666) ^ -759674467;
			}
		}
	}

	public Class119(GClass2 gclass2_1, IntPtr intptr_2)
		: base(gclass2_1, bool_2: true)
	{
		method_3(intptr_2);
	}

	[SpecialName]
	public override IntPtr method_060C()
	{
		return (IntPtr)method_21<uint>(6);
	}

	[SpecialName]
	public override IntPtr method_060D()
	{
		return (IntPtr)method_21<uint>(17);
	}

	public override Class109 method_060E()
	{
		if (!(method_060C() != IntPtr.Zero))
		{
			return null;
		}
		Class110 @class = new Class110(method_060C(), method_2());
		@class.method_7(method_6());
		return @class;
	}
}
