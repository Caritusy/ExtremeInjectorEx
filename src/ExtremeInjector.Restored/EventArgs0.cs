using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class EventArgs0 : EventArgs
{
	[CompilerGenerated]
	internal IntPtr intptr_0;

	[CompilerGenerated]
	internal List<string> list_0;

	[CompilerGenerated]
	internal int int_0;

	[CompilerGenerated]
	internal int int_1;

	[SpecialName]
	[CompilerGenerated]
	public void method_0(IntPtr intptr_1)
	{
		intptr_0 = intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<string> method_1()
	{
		return list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_2(List<string> list_1)
	{
		list_0 = list_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(int int_2)
	{
		int_0 = int_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_4(int int_2)
	{
		int_1 = int_2;
	}

	public EventArgs0()
	{
		method_2(new List<string>());
	}
}
