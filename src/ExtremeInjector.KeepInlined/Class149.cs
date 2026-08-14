using System.Collections.Generic;
using System.IO;

public sealed class Class149 : Class148
{
	internal Class149(Class5 class5_0, Class154 class154_0)
	{
		uint uint_ = default(uint);
		uint num5 = default(uint);
		List<Class164> ienumerable_ = default(List<Class164>);
		long num3 = default(long);
		long position = default(long);
		string text = default(string);
		long num7 = default(long);
		while (true)
		{
			int num = -218151579;
			while (true)
			{
				uint num2;
				int num6;
				switch ((num2 = (uint)(num ^ -2005067522)) % 21)
				{
				case 20u:
				{
					uint num4 = class5_0.ReadUInt32();
					uint_ = class5_0.ReadUInt32();
					Class171.smethod_217(class5_0, 8);
					num5 = class5_0.ReadUInt32();
					if (num4 != 0)
					{
						num = -1572069179;
						continue;
					}
					num6 = (int)(num5 - class154_0.method_6().method_3().imethod_17());
					goto IL_0046;
				}
				case 19u:
					ienumerable_ = Class171.smethod_162(class5_0, this, class154_0);
					num = (int)((num2 * 261873551) ^ 0x1E727D74);
					continue;
				case 18u:
					Class171.smethod_157(class5_0, num3);
					num = ((int)num2 * -1075521554) ^ -71612391;
					continue;
				case 17u:
					num6 = (int)num5;
					goto IL_0046;
				case 16u:
					Class171.smethod_157(class5_0, position);
					num = -2125535480;
					continue;
				case 15u:
					num3 = Class171.smethod_135(class154_0, num5);
					num = ((int)num2 * -180754170) ^ -954673433;
					continue;
				case 14u:
					gclass0_0[text].AddRange(Class171.smethod_412(text, ienumerable_, this));
					num = ((int)num2 * -1996935720) ^ -925238987;
					continue;
				case 13u:
					Class171.smethod_157(class5_0, num7);
					num = ((int)num2 * -1001612891) ^ 0x1466CD48;
					continue;
				case 12u:
					num = ((int)num2 * -625814704) ^ -1011025019;
					continue;
				case 11u:
					num = ((!class5_0.imethod_0(num3)) ? 1371805544 : 194879996) ^ (int)(num2 * 641368292);
					continue;
				case 9u:
					num = (class5_0.imethod_0(num7) ? (-1937903147) : (-1819096362)) ^ (int)(num2 * 1238390751);
					continue;
				case 8u:
					num7 = Class171.smethod_135(class154_0, uint_);
					num = (int)((num2 * 1640284739) ^ 0x11A3AA21);
					continue;
				case 7u:
					gclass0_0.imethod_0(text, new List<string>(Class171.smethod_412(text, ienumerable_, this)));
					num = -1518140740;
					continue;
				case 6u:
					num = ((num3 == -1L) ? 1003874172 : 714216600) ^ ((int)num2 * -1816408943);
					continue;
				case 5u:
					num = ((num7 == -1L) ? 1678945404 : 1920623651) ^ (int)(num2 * 490064160);
					continue;
				case 4u:
					num = ((!gclass0_0.imethod_6(text)) ? (-986402917) : (-1776977515)) ^ ((int)num2 * -2075410241);
					continue;
				case 2u:
					Class171.smethod_217(class5_0, 12);
					position = class5_0.BaseStream.Position;
					num = (int)((num2 * 729185275) ^ 0x7FEA226);
					continue;
				case 1u:
					text = Class171.smethod_404(class5_0);
					num = ((int)num2 * -1295727977) ^ -1135815491;
					continue;
				case 0u:
					num = (int)((num2 * 1888667547) ^ 0x70B0E3C5);
					continue;
				default:
					return;
				case 10u:
					break;
				case 3u:
					return;
					IL_0046:
					num5 = (uint)num6;
					num = ((num5 != 0) ? (-39825176) : (-1272076612));
					continue;
				}
				break;
			}
		}
	}

	internal static uint smethod_4(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static Stream smethod_5(BinaryReader binaryReader_0)
	{
		return binaryReader_0.BaseStream;
	}

	internal static long smethod_6(Stream stream_0)
	{
		return stream_0.Position;
	}
}
