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

	public LdrDdagNode64(IntPtr address, IntPtr address2)
		: base(address, address2, flag: false)
	{
	}
}
