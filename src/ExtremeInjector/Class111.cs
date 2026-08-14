using System;
using System.Runtime.CompilerServices;

internal sealed class Class111 : Class109
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
	public override Class103 Class109_002E_202A_202C_202E_200F_202C_206C_200C_202D_202A_206E_200F_200C_202D_202C_202B_200C_206B_200D_206C_206F_206E_206D_206F_200D_200E_206A_202A_202B_202B_206B_200C_202D_202E_206D_202E_206E_200C_202E_200E_202E()
	{
		Class105 @class = new Class105(Class171.smethod_218((Class96)this, 3), method_2());
		@class.method_7(method_6());
		return @class;
	}
}
