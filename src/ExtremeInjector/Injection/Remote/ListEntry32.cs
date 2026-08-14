using System;

public sealed class ListEntry32 : RemoteListEntry
{
	static ListEntry32()
	{
		RemotePlatformStructure.Register32BitLayout<ListEntry32>(new RemoteFieldLayout[2]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint))
		});
	}

	internal ListEntry32(IntPtr address, IntPtr address2)
		: base(address, address2, flag: true)
	{
	}

	public override RemoteListEntry GetForwardEntry()
	{
		if (!(GetForwardLink() != IntPtr.Zero))
		{
			return null;
		}
		return new ListEntry32(GetForwardLink(), GetProcessHandle());
	}

	public override RemoteListEntry GetBackwardEntry()
	{
		if (!(GetBackwardLink() != IntPtr.Zero))
		{
			return null;
		}
		return new ListEntry32(GetBackwardLink(), GetProcessHandle());
	}
}
