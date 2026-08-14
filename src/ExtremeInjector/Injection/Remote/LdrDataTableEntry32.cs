using System;
using System.Runtime.CompilerServices;

public sealed class LdrDataTableEntry32 : RemoteLdrDataTableEntry
{
	static LdrDataTableEntry32()
	{
		RemotePlatformStructure.Register32BitLayout<LdrDataTableEntry32>(new RemoteFieldLayout[16]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry32)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry32)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry32)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(UnicodeString32)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(UnicodeString32)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(short)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(short)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ListEntry32)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrDdagNode32))
		});
	}

	internal LdrDataTableEntry32(IntPtr address, IntPtr address2)
		: base(address, address2, flag: true)
	{
	}

	[SpecialName]
	public override RemoteLdrListEntry GetLoadOrderLinks()
	{
		LdrListEntry32 @class = new LdrListEntry32(RecoveredRuntime.GetRemoteFieldAddress(this, 0), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}

	[SpecialName]
	public override RemoteLdrListEntry GetMemoryOrderLinks()
	{
		LdrListEntry32 @class = new LdrListEntry32(RecoveredRuntime.GetRemoteFieldAddress(this, 1), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}

	[SpecialName]
	public override RemoteLdrListEntry GetInitializationOrderLinks()
	{
		LdrListEntry32 @class = new LdrListEntry32(RecoveredRuntime.GetRemoteFieldAddress(this, 2), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}

	[SpecialName]
	public override IntPtr GetModuleBase()
	{
		return (IntPtr)ReadField<uint>(3);
	}

	[SpecialName]
	public override short GetLoadCount()
	{
		return ReadField<short>(9);
	}

	[SpecialName]
	public override RemoteListEntry GetHashLinks()
	{
		ListEntry32 @class = new ListEntry32(RecoveredRuntime.GetRemoteFieldAddress(this, 11), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}

	[SpecialName]
	public override IntPtr GetDependencyNodeAddress()
	{
		return (IntPtr)ReadField<uint>(15);
	}

	public override RemoteLdrDdagNode GetDependencyNode()
	{
		LdrDdagNode32 @class = new LdrDdagNode32(GetDependencyNodeAddress(), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}
}
