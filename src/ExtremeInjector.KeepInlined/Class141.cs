using System.Collections.Generic;
using System.IO;

public sealed class Class141
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
					num = ((num3 >= class157_0.method_2() / 12) ? 1488877304 : 869688144);
					continue;
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

	internal static uint smethod_0(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}
}
