using System;

public sealed class Class102 : Class100
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

	public Class100 method_05D2()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		return new Class102(vmethod_7(), method_2());
	}

	public Class100 method_05D3()
	{
		if (!(vmethod_9() != IntPtr.Zero))
		{
			return null;
		}
		return new Class102(vmethod_9(), method_2());
	}
}
