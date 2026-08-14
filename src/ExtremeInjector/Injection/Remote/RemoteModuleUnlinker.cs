using System;
using System.Runtime.CompilerServices;

public sealed class RemoteModuleUnlinker
{
	[CompilerGenerated]
	public sealed class Class130
	{
		public IntPtr intptr_0;

		internal bool MatchesModuleBase(ProcessModuleInfo gclass1_0)
		{
			return gclass1_0.GetModuleBase() == intptr_0;
		}
	}

	[CompilerGenerated]
	internal RemoteProcess gclass2_0;

	[SpecialName]
	[CompilerGenerated]
	public RemoteProcess GetRemoteProcess()
	{
		return gclass2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetRemoteProcess(RemoteProcess gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	public RemoteModuleUnlinker(RemoteProcess gclass2_1)
	{
		SetRemoteProcess(gclass2_1);
	}
}
