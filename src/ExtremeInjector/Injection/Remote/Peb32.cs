using System;
using System.Runtime.CompilerServices;

public sealed class Peb32 : RemotePeb
{
	static Peb32()
	{
		RemotePlatformStructure.Register32BitLayout<Peb32>(new RemoteFieldLayout[65]
		{
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(byte)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(byte)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(byte)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(byte)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteArrayFieldLayout(typeof(uint), 2),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ulong)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(long)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ushort)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ushort)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteArrayFieldLayout(typeof(uint), 34),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteArrayFieldLayout(typeof(uint), 32),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ulong)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(ulong)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(UnicodeString32)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint)),
			RecoveredRuntime.CreateRemoteFieldLayout(typeof(uint))
		});
	}

	public Peb32(RemoteProcess remoteProcess)
		: base(remoteProcess, flag: true)
	{
		this.EnsureProcessHandle();
	}

	public Peb32(RemoteProcess remoteProcess, IntPtr address)
		: base(remoteProcess, flag: true)
	{
		SetProcessHandle(address);
	}

	[SpecialName]
	public override IntPtr GetLoaderDataAddress()
	{
		return (IntPtr)ReadField<uint>(6);
	}

	[SpecialName]
	public override IntPtr GetApiSetMapAddress()
	{
		return (IntPtr)ReadField<uint>(17);
	}

	public override RemotePebLdrData GetLoaderData()
	{
		if (!(GetLoaderDataAddress() != IntPtr.Zero))
		{
			return null;
		}
		PebLdrData32 @class = new PebLdrData32(GetLoaderDataAddress(), GetProcessHandle());
		@class.SetMemoryApi(GetMemoryApi());
		return @class;
	}
}
