using System;

public sealed class Class102 : Class100
{
	static Class102()
	{
		Class96.smethod_7<Class102>(new Class168[2]
		{
			Class171.smethod_316(typeof(IntPtr)),
			Class171.smethod_316(typeof(IntPtr))
		});
	}

	internal Class102(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
	{
	}

	public override Class100 method_07D2()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		return new Class102(vmethod_7(), method_2());
	}

	public override Class100 method_07D3()
	{
		if (!(vmethod_9() != IntPtr.Zero))
		{
			return null;
		}
		return new Class102(vmethod_9(), method_2());
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
