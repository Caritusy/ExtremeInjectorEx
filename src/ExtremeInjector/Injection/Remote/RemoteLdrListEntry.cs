using System;

public abstract class RemoteLdrListEntry : RemoteListEntry
{
	public abstract RemoteLdrDataTableEntry GetModuleEntry();

	protected RemoteLdrListEntry(IntPtr address, IntPtr address2, bool flag)
		: base(address, address2, flag)
	{
	}
}
