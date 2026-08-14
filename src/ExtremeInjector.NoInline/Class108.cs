using System;
using System.Runtime.CompilerServices;

public sealed class Class108 : Class106
{
	static Class108()
	{
		Class96.smethod_7<Class108>(new Class168[16]
		{
			Class171.smethod_316(smethod_11(typeof(Class105).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class105).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class105).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class116).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class116).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(short).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(short).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class102).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class99).TypeHandle))
		});
	}

	internal Class108(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
	{
	}

	[SpecialName]
	public override Class103 method_07EE()
	{
		Class105 @class = new Class105(Class171.smethod_223(this, 0), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override Class103 method_07EF()
	{
		Class105 @class = new Class105(Class171.smethod_223(this, 1), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override Class103 method_07F0()
	{
		Class105 @class = new Class105(Class171.smethod_223(this, 2), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override IntPtr method_07F1()
	{
		return method_21<IntPtr>(3);
	}

	[SpecialName]
	public override short method_07F2()
	{
		return method_21<short>(9);
	}

	[SpecialName]
	public override Class100 method_07F3()
	{
		Class102 @class = new Class102(Class171.smethod_223(this, 11), method_2());
		@class.method_7(method_6());
		return @class;
	}

	[SpecialName]
	public override IntPtr method_07F4()
	{
		return method_21<IntPtr>(15);
	}

	public override Class97 method_07F5()
	{
		Class99 @class = new Class99(method_07F4(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
