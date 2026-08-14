using System;
using System.Runtime.CompilerServices;

public sealed class Class118 : Class117
{
	static Class118()
	{
		Class96.smethod_1<Class118>(new Class168[65]
		{
			Class171.smethod_310(typeof(byte)),
			Class171.smethod_310(typeof(byte)),
			Class171.smethod_310(typeof(byte)),
			Class171.smethod_186(typeof(byte), 4),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_192(typeof(uint), 2),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(long)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(ushort)),
			Class171.smethod_310(typeof(ushort)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(uint)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_192(typeof(IntPtr), 30),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_192(typeof(uint), 32),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(ulong)),
			Class171.smethod_310(typeof(ulong)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(Class116)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr))
		});
	}

	public Class118(GClass2 gclass2_1)
		: base(gclass2_1, bool_2: false)
	{
		method_033E();
	}

	public Class118(GClass2 gclass2_1, IntPtr intptr_2)
		: base(gclass2_1, bool_2: false)
	{
		method_3(intptr_2);
	}

	[SpecialName]
	public IntPtr method_0612()
	{
		return method_21<IntPtr>(6);
	}

	[SpecialName]
	public IntPtr method_0613()
	{
		return method_21<IntPtr>(17);
	}

	public Class109 method_0614()
	{
		if (!(method_060C() != IntPtr.Zero))
		{
			return null;
		}
		Class111 @class = new Class111(method_060C(), method_2());
		@class.method_7(method_6());
		return @class;
	}
}
