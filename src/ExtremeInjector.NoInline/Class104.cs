using System;

public sealed class Class104 : Class103
{
	static Class104()
	{
		Class96.smethod_6<Class104>(new Class168[2]
		{
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle))
		});
	}

	internal Class104(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: true)
	{
	}

	public override Class106 method_07DF()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		Class107 @class = new Class107(vmethod_7(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	public override Class100 method_07D2()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		Class101 @class = new Class101(vmethod_7(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	public override Class100 method_07D3()
	{
		if (!(vmethod_9() != IntPtr.Zero))
		{
			return null;
		}
		Class101 @class = new Class101(vmethod_9(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
