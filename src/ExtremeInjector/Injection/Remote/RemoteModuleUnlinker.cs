using System;
using System.Runtime.CompilerServices;

public sealed class RemoteModuleUnlinker
{
	[CompilerGenerated]
	public sealed class ModuleBaseMatcher
	{
		public IntPtr address;

		internal bool MatchesModuleBase(ProcessModuleInfo processModuleInfo)
		{
			return processModuleInfo.GetModuleBase() == address;
		}
	}

	[CompilerGenerated]
	internal RemoteProcess remoteProcess;

	[SpecialName]
	[CompilerGenerated]
	public RemoteProcess GetRemoteProcess()
	{
		return remoteProcess;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetRemoteProcess(RemoteProcess remoteProcess2)
	{
		remoteProcess = remoteProcess2;
	}

	public RemoteModuleUnlinker(RemoteProcess remoteProcess2)
	{
		SetRemoteProcess(remoteProcess2);
	}
}
