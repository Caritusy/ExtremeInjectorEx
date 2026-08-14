using System;
using System.Runtime.CompilerServices;

public sealed class Class111 : Class109
{
	static Class111()
	{
		Class96.smethod_7<Class111>(new Class168[7]
		{
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class105).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class105).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class105).TypeHandle))
		});
	}

	internal Class111(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_3, bool_2: false)
	{
		Class171.smethod_400(intptr_2, this);
	}

	[SpecialName]
	public override Class103 method_080D()
	{
		Class105 @class = new Class105(Class171.smethod_223(this, 3), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
