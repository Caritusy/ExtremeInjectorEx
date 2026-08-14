using System;

public sealed class UnicodeString64 : RemoteUnicodeString
{
	static UnicodeString64()
	{
		RemotePlatformStructure.smethod_7<UnicodeString64>(new RemoteFieldLayout[3]
		{
			RecoveredRuntime.smethod_316(typeof(ushort)),
			RecoveredRuntime.smethod_316(typeof(ushort)),
			RecoveredRuntime.smethod_316(typeof(IntPtr))
		});
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
