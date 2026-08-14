using System;

public sealed class LdrDdagNode32 : RemoteLdrDdagNode
{
	static LdrDdagNode32()
	{
		RemotePlatformStructure.Register32BitLayout<LdrDdagNode32>(new RemoteFieldLayout[5]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry32)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint))
		});
	}

	public LdrDdagNode32(IntPtr address, IntPtr address2)
		: base(address, address2, flag: true)
	{
	}
}
