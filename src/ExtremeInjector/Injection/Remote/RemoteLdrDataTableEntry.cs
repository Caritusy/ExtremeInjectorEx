using System;
using System.Runtime.CompilerServices;

public abstract class RemoteLdrDataTableEntry : RemotePlatformStructure
{
	protected RemoteLdrDataTableEntry(IntPtr address, IntPtr address2, bool flag)
		: base(address2, flag)
	{
		SetAddress(address);
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
