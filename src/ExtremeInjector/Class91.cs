using System;

internal sealed class Class91 : Class84
{
	public Class91(GClass2 gclass2_1)
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
				method_8(gclass2_1.method_0());
				num = ((int)num2 * -2103905919) ^ 0x519A9F65;
			}
		}
	}

	void Class82._202A_202C_202E_200F_202C_206C_200C_202D_202A_206E_200F_200C_202D_202C_202B_200C_206B_200D_206C_206F_206E_206D_206F_200D_200E_206A_202A_202B_202B_206B_200C_202D_202E_206D_202E_206E_200C_202E_200E_202E()
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
				{
					int num3;
					int num4;
					if (method_0() != -1)
					{
						num3 = 561539542;
						num4 = 561539542;
					}
					else
					{
						num3 = 251262215;
						num4 = 251262215;
					}
					num = num3 ^ ((int)num2 * -837905127);
					continue;
				}
				case 1u:
					method_3(Class171.OpenProcess(Class124.Enum32.flag_2 | Class124.Enum32.flag_3 | Class124.Enum32.flag_4 | Class124.Enum32.flag_5 | Class124.Enum32.flag_9, false, method_0()));
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
