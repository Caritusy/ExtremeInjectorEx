using System;

public sealed class ListEntry64 : RemoteListEntry
{
	static ListEntry64()
	{
		RemotePlatformStructure.Register64BitLayout<ListEntry64>(new RemoteFieldLayout[2]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr))
		});
	}

	internal ListEntry64(IntPtr address, IntPtr address2)
		: base(address, address2, flag: false)
	{
	}

	public override RemoteListEntry GetForwardEntry()
	{
		if (!(GetForwardLink() != IntPtr.Zero))
		{
			return null;
		}
		return new ListEntry64(GetForwardLink(), GetProcessHandle());
	}

	public override RemoteListEntry GetBackwardEntry()
	{
		if (!(GetBackwardLink() != IntPtr.Zero))
		{
			return null;
		}
		return new ListEntry64(GetBackwardLink(), GetProcessHandle());
	}
}
