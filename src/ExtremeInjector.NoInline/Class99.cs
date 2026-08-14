using System;

public sealed class Class99 : Class97
{
	static Class99()
	{
		Class96.smethod_7<Class99>(new Class168[5]
		{
			Class171.smethod_316(smethod_11(typeof(Class105).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle))
		});
	}

	public Class99(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
	{
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
