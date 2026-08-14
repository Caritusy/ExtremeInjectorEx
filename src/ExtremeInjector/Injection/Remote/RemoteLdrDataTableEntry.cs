using System;
using System.Runtime.CompilerServices;

public abstract class RemoteLdrDataTableEntry : RemotePlatformStructure
{
	protected RemoteLdrDataTableEntry(IntPtr intptr_2, IntPtr intptr_3, bool bool_2)
		: base(intptr_3, bool_2)
	{
		method_18(intptr_2);
	}

	[SpecialName]
	public abstract RemoteLdrListEntry method_07EE();

	[SpecialName]
	public abstract RemoteLdrListEntry method_07EF();

	[SpecialName]
	public abstract RemoteLdrListEntry method_07F0();

	[SpecialName]
	public abstract IntPtr method_07F1();

	[SpecialName]
	public abstract short method_07F2();

	[SpecialName]
	public abstract RemoteListEntry method_07F3();

	[SpecialName]
	public abstract IntPtr method_07F4();

	public abstract RemoteLdrDdagNode method_07F5();
}
