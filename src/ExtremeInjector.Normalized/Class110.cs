using System;
using System.Runtime.CompilerServices;

public sealed class Class110 : Class109
{
	static Class110()
	{
		Class96.smethod_0<Class110>(new Class168[7]
		{
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(Class104)),
			Class171.smethod_310(typeof(Class104)),
			Class171.smethod_310(typeof(Class104))
		});
	}

	internal Class110(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_3, bool_2: true)
	{
		while (true)
		{
			int num = 1779142458;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x563FA0FD)) % 3)
				{
				case 1u:
					goto IL_000a;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000a:
				Class171.smethod_392(intptr_2, (Class109)this);
				num = (int)((num2 * 1832721797) ^ 0x7ED55F0E);
			}
		}
	}

	[SpecialName]
	public Class103 method_0601()
	{
		Class104 @class = new Class104(Class171.smethod_218((Class96)this, 3), method_2());
		@class.method_7(method_6());
		return @class;
	}
}
