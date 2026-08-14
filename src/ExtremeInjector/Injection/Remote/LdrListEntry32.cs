using System;

public sealed class LdrListEntry32 : RemoteLdrListEntry
{
	static LdrListEntry32()
	{
		RemotePlatformStructure.Register32BitLayout<LdrListEntry32>(new RemoteFieldLayout[2]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint))
		});
	}

	internal LdrListEntry32(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: true)
	{
	}

	public override RemoteLdrDataTableEntry GetModuleEntry()
	{
		if (!(GetForwardLink() != IntPtr.Zero))
		{
			return null;
		}
		LdrDataTableEntry32 @class = new LdrDataTableEntry32(GetForwardLink(), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}

	public override RemoteListEntry GetForwardEntry()
	{
		if (!(GetForwardLink() != IntPtr.Zero))
		{
			return null;
		}
		ListEntry32 @class = new ListEntry32(GetForwardLink(), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}

	public override RemoteListEntry GetBackwardEntry()
	{
		if (!(GetBackwardLink() != IntPtr.Zero))
		{
			return null;
		}
		ListEntry32 @class = new ListEntry32(GetBackwardLink(), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}
}
