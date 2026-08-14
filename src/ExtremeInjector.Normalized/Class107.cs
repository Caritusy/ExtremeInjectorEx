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
	public Class103 method_05EB()
	{
		Class104 @class = new Class104(Class171.smethod_218((Class96)this, 0), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public Class103 method_05EC()
	{
		Class104 @class = new Class104(Class171.smethod_218((Class96)this, 1), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public Class103 method_05ED()
	{
		Class104 @class = new Class104(Class171.smethod_218((Class96)this, 2), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public IntPtr method_05EE()
	{
		return (IntPtr)method_21<uint>(3);
	}

	[SpecialName]
	public short method_05EF()
	{
		return method_21<short>(9);
	}

	[SpecialName]
	public Class100 method_05F0()
	{
		Class101 @class = new Class101(Class171.smethod_218((Class96)this, 11), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public IntPtr method_05F1()
	{
		return (IntPtr)method_21<uint>(15);
	}

	public Class97 method_05F2()
	{
		Class98 @class = new Class98(method_05E7(), method_2());
		@class.method_7(method_6());
		return @class;
	}
}
