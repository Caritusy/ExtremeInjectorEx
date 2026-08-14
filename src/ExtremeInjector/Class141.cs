using System.Collections.Generic;

internal sealed class Class141
{
	public List<Class140> list_0 = new List<Class140>();

	internal Class141(Class5 class5_0, Class157 class157_0)
	{
		int num3 = default(int);
		while (true)
		{
			int num = 242485588;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1DE05702)) % 5)
				{
				case 4u:
				{
					List<Class140> list = list_0;
					Class140 @class = new Class140();
					@class.method_1(class5_0.ReadUInt32());
					@class.method_3(class5_0.ReadUInt32());
					@class.method_5(class5_0.ReadUInt32());
					list.Add(@class);
					num3++;
					num = 1941850285;
					continue;
				}
				case 2u:
					num3 = 0;
					num = ((int)num2 * -1080091077) ^ -736650881;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < class157_0.method_2() / 12)
					{
						num = 869688144;
						num4 = 869688144;
					}
					else
					{
						num = 1488877304;
						num4 = 1488877304;
					}
					continue;
				}
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}
}
