using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class ProcessWindowInfo
{
	[CompilerGenerated]
	public sealed class Class78
	{
		public List<ProcessWindowInfo> list_0;

		internal bool method_0(IntPtr intptr_0, IntPtr intptr_1)
		{
			ProcessWindowInfo @class = new ProcessWindowInfo(intptr_0);
			if (RecoveredRuntime.smethod_151(@class))
			{
				this.list_0.Add(@class);
			}
			return true;
		}
	}

	[CompilerGenerated]
	internal IntPtr intptr_0;

	[CompilerGenerated]
	internal int int_0;

	[CompilerGenerated]
	internal int int_1;

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_0()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(IntPtr intptr_1)
	{
		intptr_0 = intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public int method_2()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(int int_2)
	{
		int_0 = int_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_4(int int_2)
	{
		int_1 = int_2;
	}

	internal ProcessWindowInfo(IntPtr intptr_1)
	{
		method_1(intptr_1);
	}
}
