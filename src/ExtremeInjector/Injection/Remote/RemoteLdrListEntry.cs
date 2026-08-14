using System;

public abstract class RemoteLdrListEntry : RemoteListEntry
{
	public abstract RemoteLdrDataTableEntry GetModuleEntry();

	protected RemoteLdrListEntry(IntPtr intptr_2, IntPtr intptr_3, bool bool_2)
		: base(intptr_2, intptr_3, bool_2)
	{
	}
}
