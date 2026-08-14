using System;
using System.Runtime.CompilerServices;

public abstract class Class95 : Class82
{
	[CompilerGenerated]
	internal IntPtr intptr_1;

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_17()
	{
		return intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	protected internal void method_18(IntPtr intptr_2)
	{
		intptr_1 = intptr_2;
	}

	protected Class95(int int_1)
		: base(int_1)
	{
	}

	protected Class95(IntPtr intptr_2)
		: base(intptr_2)
	{
	}

	protected T method_19<T>(int int_1)
	{
		return method_11<T>(method_17().smethod_8(int_1));
	}

	protected void method_20<T>(T gparam_0, int int_1)
	{
		method_13(method_17().smethod_8(int_1), gparam_0);
	}
}
