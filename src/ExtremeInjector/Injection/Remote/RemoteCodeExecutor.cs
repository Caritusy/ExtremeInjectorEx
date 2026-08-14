using System;

public sealed class RemoteCodeExecutor : RemoteCodeExecutorBase
{
	public RemoteCodeExecutor(RemoteProcess gclass2_1)
		: base(gclass2_1)
	{
		base.EnsureAttachedToProcess(gclass2_1.ProcessId);
	}

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_2 | NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, base.GetProcessId()));
		}
	}
}
