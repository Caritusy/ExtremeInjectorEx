using System;
using System.Runtime.CompilerServices;

public sealed class Class110 : Class109
{
	static Class110()
	{
		Class96.smethod_6<Class110>(new Class168[7]
		{
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class104).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class104).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class104).TypeHandle))
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
				Class171.smethod_400(intptr_2, this);
				num = (int)((num2 * 1832721797) ^ 0x7ED55F0E);
			}
		}
	}

	[SpecialName]
	public override Class103 method_080D()
	{
		Class104 @class = new Class104(Class171.smethod_223(this, 3), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
