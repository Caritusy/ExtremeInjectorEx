using System;
using System.Runtime.CompilerServices;

public abstract class RemotePebLdrData : RemotePlatformStructure
{
	protected RemotePebLdrData(IntPtr address, bool flag)
		: base(address, flag)
	{
	}

	[SpecialName]
	public abstract RemoteLdrListEntry GetLoadOrderModuleList();
}
