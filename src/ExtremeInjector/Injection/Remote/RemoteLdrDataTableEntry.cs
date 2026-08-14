using System;
using System.Runtime.CompilerServices;

public abstract class RemoteLdrDataTableEntry : RemotePlatformStructure
{
	protected RemoteLdrDataTableEntry(IntPtr intptr_2, IntPtr intptr_3, bool bool_2)
		: base(intptr_3, bool_2)
	{
		SetAddress(intptr_2);
	}

	[SpecialName]
	public abstract RemoteLdrListEntry GetLoadOrderLinks();

	[SpecialName]
	public abstract RemoteLdrListEntry GetMemoryOrderLinks();

	[SpecialName]
	public abstract RemoteLdrListEntry GetInitializationOrderLinks();

	[SpecialName]
	public abstract IntPtr GetModuleBase();

	[SpecialName]
	public abstract short GetLoadCount();

	[SpecialName]
	public abstract RemoteListEntry GetHashLinks();

	[SpecialName]
	public abstract IntPtr GetDependencyNodeAddress();

	public abstract RemoteLdrDdagNode GetDependencyNode();
}
