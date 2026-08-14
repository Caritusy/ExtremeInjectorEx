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

	public LdrDdagNode32(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: true)
	{
	}
}
