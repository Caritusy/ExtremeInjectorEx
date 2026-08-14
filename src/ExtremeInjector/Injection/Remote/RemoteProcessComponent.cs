using System;
using System.Runtime.CompilerServices;

public abstract class RemoteProcessComponent : RemoteMemoryAccessor, IDisposable
{
	[CompilerGenerated]
	internal bool bool_1;

	[CompilerGenerated]
	internal RemoteProcess gclass2_0;

	[SpecialName]
	[CompilerGenerated]
	public bool GetHideRemoteThreadFromDebugger()
	{
		return bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetHideRemoteThreadFromDebugger(bool bool_2)
	{
		bool_1 = bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	protected internal RemoteProcess GetRemoteProcess()
	{
		return gclass2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected internal void SetRemoteProcess(RemoteProcess gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	protected RemoteProcessComponent(RemoteProcess gclass2_1)
	{
		this.SetRemoteProcess(gclass2_1);
		base.SetAutoProtectMemory(false);
	}

	void IDisposable.Dispose()
	{
		RecoveredRuntime.CloseRemoteMemoryAccessor(this);
	}
}
