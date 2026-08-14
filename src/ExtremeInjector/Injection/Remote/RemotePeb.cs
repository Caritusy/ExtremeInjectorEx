using System;
using System.Runtime.CompilerServices;

public abstract class RemotePeb : RemotePlatformStructure
{
	protected internal RemoteProcess gclass2_0;

	internal RemotePeb(RemoteProcess gclass2_1, bool bool_2)
		: base(gclass2_1.ProcessId, bool_2)
	{
		gclass2_0 = gclass2_1;
	}

	[SpecialName]
	public abstract IntPtr GetLoaderDataAddress();

	[SpecialName]
	public abstract IntPtr GetApiSetMapAddress();

	public abstract RemotePebLdrData GetLoaderData();
}
