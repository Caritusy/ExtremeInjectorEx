using System;
using System.Runtime.CompilerServices;

public abstract class RemotePebLdrData : RemotePlatformStructure
{
	protected RemotePebLdrData(IntPtr intptr_2, bool bool_2)
		: base(intptr_2, bool_2)
	{
	}

	[SpecialName]
	public abstract RemoteLdrListEntry GetLoadOrderModuleList();
}
