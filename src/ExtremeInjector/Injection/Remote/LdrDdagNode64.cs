using System;

public sealed class LdrDdagNode64 : RemoteLdrDdagNode
{
	static LdrDdagNode64()
	{
		RemotePlatformStructure.Register64BitLayout<LdrDdagNode64>(new RemoteFieldLayout[5]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(LdrListEntry64)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint))
		});
	}

	public LdrDdagNode64(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
	{
	}
}
