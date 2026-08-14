using System;
using System.Runtime.CompilerServices;

public abstract class RemoteListEntry : RemotePlatformStructure
{
	[SpecialName]
	public virtual IntPtr GetForwardLink()
	{
		return ReadField<IntPtr>(0);
	}

	[SpecialName]
	public virtual void SetForwardLink(IntPtr address)
	{
		WriteField(0, address);
	}

	[SpecialName]
	public virtual IntPtr GetBackwardLink()
	{
		return ReadField<IntPtr>(1);
	}

	[SpecialName]
	public virtual void SetBackwardLink(IntPtr address)
	{
		WriteField(1, address);
	}

	public abstract RemoteListEntry GetForwardEntry();

	public abstract RemoteListEntry GetBackwardEntry();

	protected RemoteListEntry(IntPtr address, IntPtr address2, bool flag)
		: base(address2, flag)
	{
		SetAddress(address);
	}
}
