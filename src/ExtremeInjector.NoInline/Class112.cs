using System;

public sealed class Class112 : Class96
{
	internal static int int_2;

	static Class112()
	{
		if (!Class127.bool_5)
		{
			goto IL_000a;
		}
		int num = 2;
		goto IL_002b;
		IL_002a:
		num = 1;
		goto IL_002b;
		IL_002b:
		int_2 = num;
		int num2 = 201796385;
		goto IL_000f;
		IL_000f:
		switch ((uint)(num2 ^ 0x5009204C) % 3u)
		{
		case 0u:
			break;
		case 2u:
			goto IL_002a;
		default:
			Class96.smethod_6<Class112>(new Class168[3]
			{
				Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
				Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
				Class171.smethod_194(smethod_11(typeof(uint).TypeHandle), int_2)
			});
			return;
		}
		goto IL_000a;
		IL_000a:
		num2 = 2064503646;
		goto IL_000f;
	}

	public Class112(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_3, bool_2: true)
	{
		method_18(intptr_2);
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
