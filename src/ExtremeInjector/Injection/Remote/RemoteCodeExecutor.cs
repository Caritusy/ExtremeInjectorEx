using System;

public sealed class RemoteCodeExecutor : RemoteCodeExecutorBase
{
	public RemoteCodeExecutor(RemoteProcess gclass2_1)
		: base(gclass2_1)
	{
		base.method_8(gclass2_1.ProcessId);
	}

	protected override void method_04C6()
	{
		if (base.method_2() == IntPtr.Zero && base.method_0() != -1)
		{
			base.method_3(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_2 | NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, base.method_0()));
		}
	}
}
