using System;

public sealed class LdrDdagNode64 : RemoteLdrDdagNode
{
	static LdrDdagNode64()
	{
		RemotePlatformStructure.smethod_7<LdrDdagNode64>(new RemoteFieldLayout[5]
		{
			RecoveredRuntime.smethod_316(typeof(LdrListEntry64)),
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint)),
			RecoveredRuntime.smethod_316(typeof(uint))
		});
	}

	public LdrDdagNode64(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
	{
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
