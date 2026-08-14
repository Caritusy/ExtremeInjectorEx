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
	public virtual void SetForwardLink(IntPtr intptr_2)
	{
		WriteField(0, intptr_2);
	}

	[SpecialName]
	public virtual IntPtr GetBackwardLink()
	{
		return ReadField<IntPtr>(1);
	}

	[SpecialName]
	public virtual void SetBackwardLink(IntPtr intptr_2)
	{
		WriteField(1, intptr_2);
	}

	public abstract RemoteListEntry GetForwardEntry();

	public abstract RemoteListEntry GetBackwardEntry();

	protected RemoteListEntry(IntPtr intptr_2, IntPtr intptr_3, bool bool_2)
		: base(intptr_3, bool_2)
	{
		SetAddress(intptr_2);
	}
}
