using System;
using System.Runtime.CompilerServices;

public sealed class Class107 : Class106
{
	static Class107()
	{
		Class96.smethod_6<Class107>(new Class168[16]
		{
			Class171.smethod_316(typeof(Class104)),
			Class171.smethod_316(typeof(Class104)),
			Class171.smethod_316(typeof(Class104)),
			Class171.smethod_316(typeof(uint)),
			Class171.smethod_316(typeof(uint)),
			Class171.smethod_316(typeof(uint)),
			Class171.smethod_316(typeof(Class115)),
			Class171.smethod_316(typeof(Class115)),
			Class171.smethod_316(typeof(uint)),
			Class171.smethod_316(typeof(short)),
			Class171.smethod_316(typeof(short)),
			Class171.smethod_316(typeof(Class101)),
			Class171.smethod_316(typeof(uint)),
			Class171.smethod_316(typeof(uint)),
			Class171.smethod_316(typeof(uint)),
			Class171.smethod_316(typeof(Class98))
		});
	}

	internal Class107(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: true)
	{
	}

	[SpecialName]
	public override Class103 method_07EE()
	{
		Class104 @class = new Class104(Class171.smethod_223(this, 0), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override Class103 method_07EF()
	{
		Class104 @class = new Class104(Class171.smethod_223(this, 1), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override Class103 method_07F0()
	{
		Class104 @class = new Class104(Class171.smethod_223(this, 2), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override IntPtr method_07F1()
	{
		return (IntPtr)method_21<uint>(3);
	}

	[SpecialName]
	public override short method_07F2()
	{
		return method_21<short>(9);
	}

	[SpecialName]
	public override Class100 method_07F3()
	{
		Class101 @class = new Class101(Class171.smethod_223(this, 11), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override IntPtr method_07F4()
	{
		return (IntPtr)method_21<uint>(15);
	}

	public override Class97 method_07F5()
	{
		Class98 @class = new Class98(method_07F4(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
