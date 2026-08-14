using System;

public sealed class RemoteCodeExecutor : RemoteCodeExecutorBase
{
	public RemoteCodeExecutor(RemoteProcess gclass2_1)
		: base(gclass2_1)
	{
		while (true)
		{
			int num = 1947898580;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7C9AA638)) % 3)
				{
				case 1u:
					goto IL_0009;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0009:
				method_8(gclass2_1.ProcessId);
				num = ((int)num2 * -2103905919) ^ 0x519A9F65;
			}
		}
	}

	protected override void method_04C6()
	{
		if (!(method_2() == IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = -1359599617;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2052264671)) % 4)
				{
				case 2u:
					num = ((method_0() == -1) ? 251262215 : 561539542) ^ ((int)num2 * -837905127);
					continue;
				case 1u:
					method_3(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_2 | NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, bool_0: false, method_0()));
					num = (int)(num2 * 119316102) ^ -1053404609;
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}
}
