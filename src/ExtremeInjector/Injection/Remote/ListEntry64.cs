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

	internal ListEntry64(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
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
