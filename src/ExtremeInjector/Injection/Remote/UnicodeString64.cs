using System;

public sealed class UnicodeString64 : RemoteUnicodeString
{
	static UnicodeString64()
	{
		RemotePlatformStructure.Register64BitLayout<UnicodeString64>(new RemoteFieldLayout[3]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ushort)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ushort)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr))
		});
	}
}
