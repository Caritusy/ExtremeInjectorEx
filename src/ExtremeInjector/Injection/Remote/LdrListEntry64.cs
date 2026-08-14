using System;

public sealed class LdrListEntry64 : RemoteLdrListEntry
{
	static LdrListEntry64()
	{
		RemotePlatformStructure.Register64BitLayout<LdrListEntry64>(new RemoteFieldLayout[2]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr))
		});
	}

	internal LdrListEntry64(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
	{
	}

	public override RemoteLdrDataTableEntry GetModuleEntry()
	{
		if (!(GetForwardLink() != IntPtr.Zero))
		{
			return null;
		}
		LdrDataTableEntry64 @class = new LdrDataTableEntry64(GetForwardLink(), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}

	public override RemoteListEntry GetForwardEntry()
	{
		if (!(GetForwardLink() != IntPtr.Zero))
		{
			return null;
		}
		ListEntry64 @class = new ListEntry64(GetForwardLink(), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}

	public override RemoteListEntry GetBackwardEntry()
	{
		if (!(GetBackwardLink() != IntPtr.Zero))
		{
			return null;
		}
		ListEntry64 @class = new ListEntry64(GetBackwardLink(), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}
}
