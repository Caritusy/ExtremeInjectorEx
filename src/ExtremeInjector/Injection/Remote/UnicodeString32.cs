using System;

public sealed class UnicodeString32 : RemoteUnicodeString
{
	static UnicodeString32()
	{
		RemotePlatformStructure.smethod_6<UnicodeString32>(new RemoteFieldLayout[3]
		{
			RecoveredRuntime.smethod_316(typeof(ushort)),
			RecoveredRuntime.smethod_316(typeof(ushort)),
			RecoveredRuntime.smethod_316(typeof(uint))
		});
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
