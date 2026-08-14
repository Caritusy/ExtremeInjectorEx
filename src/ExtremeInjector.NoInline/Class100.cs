using System;
using System.Runtime.CompilerServices;

public abstract class Class100 : Class96
{
	[SpecialName]
	public virtual IntPtr vmethod_7()
	{
		return method_21<IntPtr>(0);
	}

	[SpecialName]
	public virtual void vmethod_8(IntPtr intptr_2)
	{
		method_22(0, intptr_2);
	}

	[SpecialName]
	public virtual IntPtr vmethod_9()
	{
		return method_21<IntPtr>(1);
	}

	[SpecialName]
	public virtual void vmethod_10(IntPtr intptr_2)
	{
		method_22(1, intptr_2);
	}

	public abstract Class100 method_07D2();

	public abstract Class100 method_07D3();

	protected Class100(IntPtr intptr_2, IntPtr intptr_3, bool bool_2)
		: base(intptr_3, bool_2)
	{
		method_18(intptr_2);
	}
}
