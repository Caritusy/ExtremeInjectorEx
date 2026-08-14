using System;
using System.Runtime.CompilerServices;

public abstract class RemotePeb : RemotePlatformStructure
{
	protected internal RemoteProcess remoteProcess;

	internal RemotePeb(RemoteProcess remoteProcess2, bool flag)
		: base(remoteProcess2.ProcessId, flag)
	{
		remoteProcess = remoteProcess2;
	}

	[SpecialName]
	public abstract IntPtr GetLoaderDataAddress();

	[SpecialName]
	public abstract IntPtr GetApiSetMapAddress();

	public abstract RemotePebLdrData GetLoaderData();
}
