using System;
using System.Runtime.CompilerServices;

public sealed class Class107 : Class106
{
	static Class107()
	{
		Class96.smethod_0<Class107>(new Class168[16]
		{
			Class171.smethod_310(typeof(Class104)),
			Class171.smethod_310(typeof(Class104)),
			Class171.smethod_310(typeof(Class104)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(Class115)),
			Class171.smethod_310(typeof(Class115)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(short)),
			Class171.smethod_310(typeof(short)),
			Class171.smethod_310(typeof(Class101)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(Class98))
		});
	}

	internal Class107(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: true)
	{
	}

	[SpecialName]
	public override Class103 method_05E1()
	{
		Class104 @class = new Class104(Class171.smethod_218((Class96)this, 0), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public Class103 method_05E1_05EC()
	{
		Class104 @class = new Class104(Class171.smethod_218((Class96)this, 1), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public Class103 method_05E1_05ED()
	{
		Class104 @class = new Class104(Class171.smethod_218((Class96)this, 2), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override IntPtr method_05E4()
	{
		return (IntPtr)method_21<uint>(3);
	}

	[SpecialName]
	public override short method_05E5()
	{
		return method_21<short>(9);
	}

	[SpecialName]
	public override Class100 method_05E6()
	{
		Class101 @class = new Class101(Class171.smethod_218((Class96)this, 11), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public IntPtr method_05E4_05F1()
	{
		return (IntPtr)method_21<uint>(15);
	}

	public override Class97 method_05E8()
	{
		Class98 @class = new Class98(method_05E7(), method_2());
		@class.method_7(method_6());
		return @class;
	}
}
