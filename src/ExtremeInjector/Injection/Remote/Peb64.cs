using System;
using System.Runtime.CompilerServices;

public sealed class Peb64 : RemotePeb
{
	static Peb64()
	{
		RemotePlatformStructure.Register64BitLayout<Peb64>(new RemoteFieldLayout[65]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(byte)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(byte)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(byte)),
			RecoveredRuntime.CreatePaddedRemoteFieldLayout(typeof(byte), 4),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteArrayFieldLayout(typeof(uint), 2),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(long)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ushort)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ushort)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteArrayFieldLayout(typeof(IntPtr), 30),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteArrayFieldLayout(typeof(uint), 32),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ulong)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ulong)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(UnicodeString64)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(IntPtr))
		});
	}

	public Peb64(RemoteProcess remoteProcess)
		: base(remoteProcess, flag: false)
	{
		EnsureProcessHandle();
	}

	public Peb64(RemoteProcess remoteProcess, IntPtr address)
		: base(remoteProcess, flag: false)
	{
		SetProcessHandle(address);
	}

	[SpecialName]
	public override IntPtr GetLoaderDataAddress()
	{
		return ReadField<IntPtr>(6);
	}

	[SpecialName]
	public override IntPtr GetApiSetMapAddress()
	{
		return ReadField<IntPtr>(17);
	}

	public override RemotePebLdrData GetLoaderData()
	{
		if (!(GetLoaderDataAddress() != IntPtr.Zero))
		{
			return null;
		}
		PebLdrData64 @class = new PebLdrData64(GetLoaderDataAddress(), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}
}
