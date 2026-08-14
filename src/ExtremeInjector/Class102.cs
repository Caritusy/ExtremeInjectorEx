using System;

internal sealed class Class102 : Class100
{
	static Class102()
	{
		Class96.smethod_1<Class102>(new Class168[2]
		{
			Class171.smethod_310(typeof(IntPtr)),
			Class171.smethod_310(typeof(IntPtr))
		});
	}

	internal Class102(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
	{
	}

	public override Class100 Class100_002E_202A_202C_202E_200F_202C_206C_200C_202D_202A_206E_200F_200C_202D_202C_202B_200C_206B_200D_206C_206F_206E_206D_206F_200D_200E_206A_202A_202B_202B_206B_200C_202D_202E_206D_202E_206E_200C_202E_200E_202E()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		return new Class102(vmethod_7(), method_2());
	}

	public override Class100 Class100_002E_200F_200C_202D_206D_200D_206C_200F_206F_202B_206C_202B_206C_206E_206F_200F_202C_202E_202A_202C_202E_202B_206B_200D_200E_202E_206C_206E_202D_202D_202B_206C_202B_206E_206B_206D_200D_206F_202D_200D_202C_202E()
	{
		if (!(vmethod_9() != IntPtr.Zero))
		{
			return null;
		}
		return new Class102(vmethod_9(), method_2());
	}
}
