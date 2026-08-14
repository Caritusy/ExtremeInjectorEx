using System;

public struct Struct17
{
	public IntPtr intptr_0;

	public IntPtr intptr_1;

	public IntPtr intptr_2;

	public IntPtr intptr_3;

	public IntPtr intptr_4;

	public void method_0()
	{
		if (intptr_0 == IntPtr.Zero)
		{
			goto IL_0049;
		}
		goto IL_0073;
		IL_0049:
		int num = 1104305670;
		goto IL_004e;
		IL_004e:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x58874133)) % 5)
			{
			case 1u:
				intptr_0 = (intptr_1 = (intptr_2 = (intptr_3 = IntPtr.Zero)));
				num = (int)((num2 * 680241615) ^ 0x68E85C56);
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_0073;
			case 2u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0049;
		IL_0073:
		Class171.smethod_189(intptr_0);
		num = 180395799;
		goto IL_004e;
	}
}
