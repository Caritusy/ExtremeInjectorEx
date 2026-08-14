using System;

public sealed class Class104 : Class103
{
	static Class104()
	{
		Class96.smethod_0<Class104>(new Class168[2]
		{
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint))
		});
	}

	internal Class104(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: true)
	{
	}

	public Class106 method_05D8()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		Class107 @class = new Class107(vmethod_7(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	public Class100 method_05D9()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		Class101 @class = new Class101(vmethod_7(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	public Class100 method_05DA()
	{
		if (!(vmethod_9() != IntPtr.Zero))
		{
			return null;
		}
		Class101 @class = new Class101(vmethod_9(), method_2());
		@class.method_7(method_6());
		return @class;
	}
}
