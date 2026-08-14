using System;
using System.Runtime.CompilerServices;

public sealed class Class119 : Class117
{
	static Class119()
	{
		Class96.smethod_6<Class119>(new Class168[65]
		{
			Class171.smethod_316(smethod_11(typeof(byte).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(byte).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(byte).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(byte).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_194(smethod_11(typeof(uint).TypeHandle), 2),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(ulong).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(long).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(ushort).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(ushort).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_194(smethod_11(typeof(uint).TypeHandle), 34),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_194(smethod_11(typeof(uint).TypeHandle), 32),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(ulong).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(ulong).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class115).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle))
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
				method_04C6();
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
	public override IntPtr method_0821()
	{
		return (IntPtr)method_21<uint>(6);
	}

	[SpecialName]
	public override IntPtr method_0822()
	{
		return (IntPtr)method_21<uint>(17);
	}

	public override Class109 method_0823()
	{
		if (!(method_0821() != IntPtr.Zero))
		{
			return null;
		}
		Class110 @class = new Class110(method_0821(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
