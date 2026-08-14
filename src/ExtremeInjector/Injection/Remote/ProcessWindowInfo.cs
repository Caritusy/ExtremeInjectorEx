using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class ProcessWindowInfo
{
	[CompilerGenerated]
	public sealed class Class78
	{
		public List<ProcessWindowInfo> list_0;

		internal bool CollectWindow(IntPtr intptr_0, IntPtr intptr_1)
		{
			ProcessWindowInfo @class = new ProcessWindowInfo(intptr_0);
			if (RecoveredRuntime.PopulateWindowIdentifiers(@class))
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
	public IntPtr GetHandle()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetHandle(IntPtr intptr_1)
	{
		intptr_0 = intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public int GetProcessId()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetProcessId(int int_2)
	{
		int_0 = int_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetThreadId(int int_2)
	{
		int_1 = int_2;
	}

	internal ProcessWindowInfo(IntPtr intptr_1)
	{
		SetHandle(intptr_1);
	}
}
