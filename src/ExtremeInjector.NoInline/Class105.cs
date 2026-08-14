using System;

public sealed class Class105 : Class103
{
	static Class105()
	{
		Class96.smethod_7<Class105>(new Class168[2]
		{
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle))
		});
	}

	internal Class105(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
	{
	}

	public override Class106 method_07DF()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		Class108 @class = new Class108(vmethod_7(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	public override Class100 method_07D2()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		Class102 @class = new Class102(vmethod_7(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	public override Class100 method_07D3()
	{
		if (!(vmethod_9() != IntPtr.Zero))
		{
			return null;
		}
		Class102 @class = new Class102(vmethod_9(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
