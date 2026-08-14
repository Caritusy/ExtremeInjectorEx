using System;

public sealed class LdrDdagNode32 : RemoteLdrDdagNode
{
	static LdrDdagNode32()
	{
		RemotePlatformStructure.smethod_6<LdrDdagNode32>(new RemoteFieldLayout[5]
		{
			RecoveredRuntime.smethod_316(typeof(LdrListEntry32)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint))
		});
	}

	public LdrDdagNode32(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: true)
	{
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
