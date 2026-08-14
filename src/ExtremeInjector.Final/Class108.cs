using System;
using System.Runtime.CompilerServices;

public sealed class Class108 : Class106
{
	static Class108()
	{
		Class96.smethod_1<Class108>(new Class168[16]
		{
			Class171.smethod_310(typeof(Class105)),
			Class171.smethod_310(typeof(Class105)),
			Class171.smethod_310(typeof(Class105)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(Class116)),
			Class171.smethod_310(typeof(Class116)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(short)),
			Class171.smethod_310(typeof(short)),
			Class171.smethod_310(typeof(Class102)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(Class99))
		});
	}

	internal Class108(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
	{
	}

	[SpecialName]
	public override Class103 method_05E1()
	{
		Class105 @class = new Class105(Class171.smethod_218((Class96)this, 0), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public Class103 method_05E1_05F6()
	{
		Class105 @class = new Class105(Class171.smethod_218((Class96)this, 1), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public Class103 method_05E1_05F7()
	{
		Class105 @class = new Class105(Class171.smethod_218((Class96)this, 2), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override IntPtr method_05E4()
	{
		return method_21<IntPtr>(3);
	}

	[SpecialName]
	public override short method_05E5()
	{
		return method_21<short>(9);
	}

	[SpecialName]
	public override Class100 method_05E6()
	{
		Class102 @class = new Class102(Class171.smethod_218((Class96)this, 11), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public IntPtr method_05E4_05FB()
	{
		return method_21<IntPtr>(15);
	}

	public override Class97 method_05E8()
	{
		Class99 @class = new Class99(method_05E7(), method_2());
		@class.method_7(method_6());
		return @class;
	}
}
