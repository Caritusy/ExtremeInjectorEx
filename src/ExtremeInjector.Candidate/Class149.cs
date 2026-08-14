using System.Collections.Generic;

public sealed class Class149 : Class148
{
	internal Class149(Class5 class5_0, Class154 class154_0)
	{
		uint uint_ = default(uint);
		uint num9 = default(uint);
		List<Class164> ienumerable_ = default(List<Class164>);
		long num5 = default(long);
		long position = default(long);
		string text = default(string);
		long num11 = default(long);
		while (true)
		{
			int num = -218151579;
			while (true)
			{
				uint num2;
				int num10;
				int num14;
				switch ((num2 = (uint)(num ^ -2005067522)) % 21)
				{
				case 20u:
				{
					uint num8 = class5_0.ReadUInt32();
					uint_ = class5_0.ReadUInt32();
					Class171.smethod_212(class5_0, 8);
					num9 = class5_0.ReadUInt32();
					if (num8 != 0)
					{
						num = -1572069179;
						continue;
					}
					num10 = (int)(num9 - class154_0.method_6().method_3().imethod_17());
					goto IL_0046;
				}
				case 19u:
					ienumerable_ = Class171.smethod_161(class5_0, (Class148)this, class154_0);
					num = (int)((num2 * 261873551) ^ 0x1E727D74);
					continue;
				case 18u:
					Class171.smethod_156(class5_0, num5);
					num = ((int)num2 * -1075521554) ^ -71612391;
					continue;
				case 17u:
					num10 = (int)num9;
					goto IL_0046;
				case 16u:
					Class171.smethod_156(class5_0, position);
					num = -2125535480;
					continue;
				case 15u:
					num5 = Class171.smethod_134(class154_0, num9);
					num = ((int)num2 * -180754170) ^ -954673433;
					continue;
				case 14u:
					gclass0_0[text].AddRange(Class171.smethod_404(text, (IEnumerable<Class164>)ienumerable_, (Class148)this));
					num = ((int)num2 * -1996935720) ^ -925238987;
					continue;
				case 13u:
					Class171.smethod_156(class5_0, num11);
					num = ((int)num2 * -1001612891) ^ 0x1466CD48;
					continue;
				case 12u:
					num = ((int)num2 * -625814704) ^ -1011025019;
					continue;
				case 11u:
				{
					int num6;
					int num7;
					if (class5_0.imethod_0(num5))
					{
						num6 = 194879996;
						num7 = 194879996;
					}
					else
					{
						num6 = 1371805544;
						num7 = 1371805544;
					}
					num = num6 ^ (int)(num2 * 641368292);
					continue;
				}
				case 9u:
				{
					int num17;
					int num18;
					if (!class5_0.imethod_0(num11))
					{
						num17 = -1819096362;
						num18 = -1819096362;
					}
					else
					{
						num17 = -1937903147;
						num18 = -1937903147;
					}
					num = num17 ^ (int)(num2 * 1238390751);
					continue;
				}
				case 8u:
					num11 = Class171.smethod_134(class154_0, uint_);
					num = (int)((num2 * 1640284739) ^ 0x11A3AA21);
					continue;
				case 7u:
					gclass0_0.imethod_0(text, new List<string>(Class171.smethod_404(text, (IEnumerable<Class164>)ienumerable_, (Class148)this)));
					num = -1518140740;
					continue;
				case 6u:
				{
					int num15;
					int num16;
					if (num5 != -1L)
					{
						num15 = 714216600;
						num16 = 714216600;
					}
					else
					{
						num15 = 1003874172;
						num16 = 1003874172;
					}
					num = num15 ^ ((int)num2 * -1816408943);
					continue;
				}
				case 5u:
				{
					int num12;
					int num13;
					if (num11 != -1L)
					{
						num12 = 1920623651;
						num13 = 1920623651;
					}
					else
					{
						num12 = 1678945404;
						num13 = 1678945404;
					}
					num = num12 ^ (int)(num2 * 490064160);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (gclass0_0.imethod_6(text))
					{
						num3 = -1776977515;
						num4 = -1776977515;
					}
					else
					{
						num3 = -986402917;
						num4 = -986402917;
					}
					num = num3 ^ ((int)num2 * -2075410241);
					continue;
				}
				case 2u:
					Class171.smethod_212(class5_0, 12);
					position = class5_0.BaseStream.Position;
					num = (int)((num2 * 729185275) ^ 0x7FEA226);
					continue;
				case 1u:
					text = Class171.smethod_396(class5_0);
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
					num9 = (uint)num10;
					if (num9 == 0)
					{
						num = -1272076612;
						num14 = -1272076612;
					}
					else
					{
						num = -39825176;
						num14 = -39825176;
					}
					continue;
				}
				break;
			}
		}
	}
}
