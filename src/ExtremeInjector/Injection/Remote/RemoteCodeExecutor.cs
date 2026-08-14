using System;

public sealed class RemoteCodeExecutor : RemoteCodeExecutorBase
{
	public RemoteCodeExecutor(RemoteProcess remoteProcess)
		: base(remoteProcess)
	{
		base.EnsureAttachedToProcess(remoteProcess.ProcessId);
	}

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.ProcessAccessRights.CreateThread | NativeTypes.ProcessAccessRights.VirtualMemoryOperation | NativeTypes.ProcessAccessRights.VirtualMemoryRead | NativeTypes.ProcessAccessRights.VirtualMemoryWrite | NativeTypes.ProcessAccessRights.QueryInformation, false, base.GetProcessId()));
		}
	}
}
