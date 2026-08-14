using System;
using System.Runtime.CompilerServices;

public sealed class RemoteModuleUnlinker
{
	[CompilerGenerated]
	public sealed class Class130
	{
		public IntPtr intptr_0;

		internal bool method_0(ProcessModuleInfo gclass1_0)
		{
			return gclass1_0.method_0() == intptr_0;
		}
	}

	[CompilerGenerated]
	internal RemoteProcess gclass2_0;

	[SpecialName]
	[CompilerGenerated]
	public RemoteProcess method_0()
	{
		return gclass2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(RemoteProcess gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	public RemoteModuleUnlinker(RemoteProcess gclass2_1)
	{
		method_1(gclass2_1);
	}
}
