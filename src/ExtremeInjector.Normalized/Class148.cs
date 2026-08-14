using System;
using System.Collections.Generic;

public class Class148
{
	public GClass0<string, List<string>> gclass0_0 = new GClass0<string, List<string>>(StringComparer.OrdinalIgnoreCase);

	public List<Class160> list_0 = new List<Class160>();

	protected List<string> this[string string_0] => gclass0_0[string_0];

	public Class148()
	{
	}

	internal Class148(Class5 class5_0, Class154 class154_0)
	{
		Class160 @class = default(Class160);
		long position = default(long);
		List<Class164> collection = default(List<Class164>);
		string text = default(string);
		long num3 = default(long);
		long num7 = default(long);
		while (true)
		{
			int num = -1962300342;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -174726434)) % 27)
				{
				case 26u:
					@class.method_1(class5_0.ReadUInt32());
					num = ((int)num2 * -212443749) ^ -2083822355;
					continue;
				case 25u:
					position = class5_0.BaseStream.Position;
					num = (int)((num2 * 1062885165) ^ 0x4FCBF728);
					continue;
				case 24u:
				{
					collection = Class171.smethod_161(class5_0, this, class154_0);
					@class.method_8().AddRange(collection);
					int num5;
					int num6;
					if (@class.method_0() == @class.method_6())
					{
						num5 = -1512329624;
						num6 = -1512329624;
					}
					else
					{
						num5 = -2085410740;
						num6 = -2085410740;
					}
					num = num5 ^ (int)(num2 * 1960013493);
					continue;
				}
				case 23u:
					@class.method_2(class5_0.ReadUInt32());
					@class.method_3(class5_0.ReadUInt32());
					num = (int)(num2 * 966981632) ^ -221179670;
					continue;
				case 22u:
					text = Class171.smethod_396(class5_0);
					@class.method_13(text);
					Class171.smethod_156(class5_0, num3);
					num = (int)(num2 * 1536381042) ^ -823420306;
					continue;
				case 21u:
				{
					int num16;
					int num17;
					if (!class5_0.imethod_0(num7))
					{
						num16 = 674905396;
						num17 = 674905396;
					}
					else
					{
						num16 = 1419870831;
						num17 = 1419870831;
					}
					num = num16 ^ (int)(num2 * 2076752282);
					continue;
				}
				case 20u:
				{
					int num14;
					int num15;
					if (num3 == -1L)
					{
						num14 = 1354765408;
						num15 = 1354765408;
					}
					else
					{
						num14 = 1344741135;
						num15 = 1344741135;
					}
					num = num14 ^ ((int)num2 * -1328813551);
					continue;
				}
				case 18u:
					num7 = Class171.smethod_134(class154_0, @class.method_4());
					num = ((int)num2 * -1420778911) ^ -1647313493;
					continue;
				case 17u:
				{
					int num9;
					int num10;
					if (num7 == -1L)
					{
						num9 = -473347619;
						num10 = -473347619;
					}
					else
					{
						num9 = -6000526;
						num10 = -6000526;
					}
					num = num9 ^ ((int)num2 * -1373515419);
					continue;
				}
				case 16u:
				{
					@class.method_5(class5_0.ReadUInt32());
					@class.method_7(class5_0.ReadUInt32());
					int num18;
					int num19;
					if (@class.method_0() == 0)
					{
						num18 = 708437211;
						num19 = 708437211;
					}
					else
					{
						num18 = 138174256;
						num19 = 138174256;
					}
					num = num18 ^ ((int)num2 * -1036837450);
					continue;
				}
				case 14u:
				{
					int num12;
					int num13;
					if (!class5_0.imethod_0(num3))
					{
						num12 = 1792550379;
						num13 = 1792550379;
					}
					else
					{
						num12 = 1107266464;
						num13 = 1107266464;
					}
					num = num12 ^ (int)(num2 * 1216664307);
					continue;
				}
				case 13u:
					@class.method_10().AddRange(Class171.smethod_161(class5_0, this, class154_0));
					num = (int)((num2 * 1002909013) ^ 0x2F39881C);
					continue;
				case 12u:
				{
					int num11;
					if (!gclass0_0.imethod_6(text))
					{
						num = -424430119;
						num11 = -424430119;
					}
					else
					{
						num = -649131201;
						num11 = -649131201;
					}
					continue;
				}
				case 11u:
					@class.method_10().AddRange(collection);
					num = (int)(num2 * 1639900574) ^ -22486031;
					continue;
				case 10u:
					@class.method_1(@class.method_6());
					num = (int)((num2 * 1506895680) ^ 0x554B6188);
					continue;
				case 9u:
					gclass0_0[text].AddRange(Class171.smethod_404(text, (IEnumerable<Class164>)@class.method_8(), this));
					num = ((int)num2 * -1556872968) ^ -377113697;
					continue;
				case 8u:
				{
					num3 = Class171.smethod_134(class154_0, @class.method_6());
					Class171.smethod_156(class5_0, num3);
					int num8;
					if (num3 == -1L)
					{
						num = -775515405;
						num8 = -775515405;
					}
					else
					{
						num = -1403968019;
						num8 = -1403968019;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -2102108517) ^ 0x673C902E;
					continue;
				case 6u:
					Class171.smethod_156(class5_0, num7);
					num = ((int)num2 * -560561428) ^ -286978101;
					continue;
				case 5u:
					num = ((int)num2 * -1805944501) ^ 0xC95CBAB;
					continue;
				case 4u:
					@class = new Class160();
					num = -63279095;
					continue;
				case 3u:
					list_0.Add(@class);
					Class171.smethod_156(class5_0, position);
					num = -1951820067;
					continue;
				case 2u:
				{
					int num4;
					if (@class.method_0() == 0)
					{
						num = -546281438;
						num4 = -546281438;
					}
					else
					{
						num = -945391017;
						num4 = -945391017;
					}
					continue;
				}
				case 1u:
					gclass0_0.imethod_0(text, new List<string>(Class171.smethod_404(text, (IEnumerable<Class164>)@class.method_8(), this)));
					num = -784129433;
					continue;
				case 0u:
					num3 = Class171.smethod_134(class154_0, @class.method_0());
					num = ((int)num2 * -1945295150) ^ 0x42B178CD;
					continue;
				default:
					return;
				case 15u:
					break;
				case 19u:
					return;
				}
				break;
			}
		}
	}
}
