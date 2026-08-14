using System;
using System.Runtime.CompilerServices;

public sealed class Class118 : Class117
{
	static Class118()
	{
		Class96.smethod_7<Class118>(new Class168[65]
		{
			Class171.smethod_316(smethod_11(typeof(byte).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(byte).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(byte).TypeHandle)),
			Class171.smethod_187(smethod_11(typeof(byte).TypeHandle), 4),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_194(smethod_11(typeof(uint).TypeHandle), 2),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(long).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(ushort).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(ushort).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(uint).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_194(smethod_11(typeof(IntPtr).TypeHandle), 30),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_194(smethod_11(typeof(uint).TypeHandle), 32),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(ulong).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(ulong).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(Class116).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle)),
			Class171.smethod_316(smethod_11(typeof(IntPtr).TypeHandle))
		});
	}

	public Class118(GClass2 gclass2_1)
		: base(gclass2_1, bool_2: false)
	{
		method_04C6();
	}

	public Class118(GClass2 gclass2_1, IntPtr intptr_2)
		: base(gclass2_1, bool_2: false)
	{
		method_3(intptr_2);
	}

	[SpecialName]
	public override IntPtr method_0821()
	{
		return method_21<IntPtr>(6);
	}

	[SpecialName]
	public override IntPtr method_0822()
	{
		return method_21<IntPtr>(17);
	}

	public override Class109 method_0823()
	{
		if (!(method_0821() != IntPtr.Zero))
		{
			return null;
		}
		Class111 @class = new Class111(method_0821(), method_2());
		@class.method_7(method_6());
		return @class;
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
