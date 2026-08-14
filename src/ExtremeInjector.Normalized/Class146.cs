using System.Collections.Generic;

public sealed class Class146
{
	public List<Class145> list_0 = new List<Class145>();

	public Class146()
	{
		list_0 = new List<Class145>();
	}

	public Class146(Class5 class5_0, Class154 class154_0)
	{
		ushort num6 = default(ushort);
		Class145 @class = default(Class145);
		int num3 = default(int);
		uint num9 = default(uint);
		uint num10 = default(uint);
		uint num4 = default(uint);
		while (true)
		{
			int num = -73171738;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -121081396)) % 14)
				{
				case 13u:
					num6 = class5_0.ReadUInt16();
					num = -1902201657;
					continue;
				case 11u:
				{
					List<Class144> list = @class.list_0;
					Class144 class2 = new Class144();
					class2.method_1((uint)(num6 & 0xFFF));
					class2.method_3((GEnum0)(num6 >> 12));
					list.Add(class2);
					num3++;
					num = ((int)num2 * -727828643) ^ -1558907608;
					continue;
				}
				case 10u:
					num9 = 0u;
					num10 = class154_0.method_6().method_3().imethod_49()[5].method_2();
					num = ((int)num2 * -1599751320) ^ -1520397118;
					continue;
				case 9u:
					num3 = 0;
					num = (int)(num2 * 374391501) ^ -265174047;
					continue;
				case 8u:
					list_0.Add(@class);
					num = ((int)num2 * -1973024639) ^ -1493228291;
					continue;
				case 7u:
				{
					Class145 class3 = new Class145();
					class3.method_1(class5_0.ReadUInt32());
					class3.method_3(class5_0.ReadUInt32());
					@class = class3;
					num = -192910608;
					continue;
				}
				case 6u:
					num = ((int)num2 * -1358561075) ^ -2143286207;
					continue;
				case 5u:
				{
					num4 = (@class.method_2() - 8) / 2;
					int num12;
					int num13;
					if (class5_0.BaseStream.Position + num4 * 2 < class5_0.BaseStream.Length)
					{
						num12 = -93028423;
						num13 = -93028423;
					}
					else
					{
						num12 = -1408135488;
						num13 = -1408135488;
					}
					num = num12 ^ ((int)num2 * -1308753918);
					continue;
				}
				case 4u:
				{
					int num11;
					if (num9 >= num10)
					{
						num = -2092781190;
						num11 = -2092781190;
					}
					else
					{
						num = -1966585975;
						num11 = -1966585975;
					}
					continue;
				}
				case 3u:
					num9 += @class.method_2();
					num = (int)((num2 * 629857798) ^ 0x7A21DBEC);
					continue;
				case 2u:
				{
					int num7;
					int num8;
					if (@class.method_2() == 0)
					{
						num7 = -1212477662;
						num8 = -1212477662;
					}
					else
					{
						num7 = -1363718071;
						num8 = -1363718071;
					}
					num = num7 ^ ((int)num2 * -1598161782);
					continue;
				}
				case 1u:
				{
					int num5;
					if (num3 < num4)
					{
						num = -1452744895;
						num5 = -1452744895;
					}
					else
					{
						num = -947255480;
						num5 = -947255480;
					}
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 12u:
					return;
				}
				break;
			}
		}
	}
}
