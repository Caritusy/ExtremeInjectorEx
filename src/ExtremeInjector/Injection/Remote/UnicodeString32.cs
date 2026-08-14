using System;

public sealed class UnicodeString32 : RemoteUnicodeString
{
	static UnicodeString32()
	{
		RemotePlatformStructure.Register32BitLayout<UnicodeString32>(new RemoteFieldLayout[3]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ushort)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ushort)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint))
		});
	}
}
