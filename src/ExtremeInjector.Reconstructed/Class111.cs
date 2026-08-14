using System;
using System.Runtime.CompilerServices;

public sealed class Class111 : Class109
{
	static Class111()
	{
		Class96.smethod_1<Class111>(new Class168[7]
		{
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(Class105)),
			Class171.smethod_310(typeof(Class105)),
			Class171.smethod_310(typeof(Class105))
		});
	}

	internal Class111(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_3, bool_2: false)
	{
		Class171.smethod_392(intptr_2, (Class109)this);
	}

	[SpecialName]
	public override Class103 method_05FE()
	{
		Class105 @class = new Class105(Class171.smethod_218((Class96)this, 3), method_2());
		@class.method_7(method_6());
		return @class;
	}
}
