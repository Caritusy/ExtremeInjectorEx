using System;

public struct Struct18
{
	public IntPtr intptr_0;

	public IntPtr intptr_1;

	public IntPtr intptr_2;

	public void method_0()
	{
		if (intptr_0 == IntPtr.Zero)
		{
			goto IL_0012;
		}
		goto IL_0068;
		IL_0012:
		int num = 852013586;
		goto IL_0043;
		IL_0043:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x3C6572A5)) % 5)
			{
			case 4u:
				break;
			case 1u:
				intptr_0 = (intptr_1 = (intptr_2 = IntPtr.Zero));
				num = ((int)num2 * -1356083858) ^ 0x50AA661F;
				continue;
			default:
				return;
			case 3u:
				goto IL_0068;
			case 0u:
				return;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0012;
		IL_0068:
		Class171.smethod_189(intptr_0);
		num = 236511487;
		goto IL_0043;
	}
}
