using System;
using System.Runtime.CompilerServices;

public abstract class RemoteProcessComponent : RemoteMemoryAccessor, IDisposable
{
	[CompilerGenerated]
	internal bool hideRemoteThreadFromDebugger;

	[CompilerGenerated]
	internal RemoteProcess remoteProcess;

	[SpecialName]
	[CompilerGenerated]
	public bool GetHideRemoteThreadFromDebugger()
	{
		return hideRemoteThreadFromDebugger;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetHideRemoteThreadFromDebugger(bool flag)
	{
		hideRemoteThreadFromDebugger = flag;
	}

	[SpecialName]
	[CompilerGenerated]
	protected internal RemoteProcess GetRemoteProcess()
	{
		return remoteProcess;
	}

	[SpecialName]
	[CompilerGenerated]
	protected internal void SetRemoteProcess(RemoteProcess remoteProcess2)
	{
		remoteProcess = remoteProcess2;
	}

	protected RemoteProcessComponent(RemoteProcess remoteProcess2)
	{
		this.SetRemoteProcess(remoteProcess2);
		base.SetAutoProtectMemory(false);
	}

	void IDisposable.Dispose()
	{
		RecoveredRuntime.CloseRemoteMemoryAccessor(this);
	}
}
