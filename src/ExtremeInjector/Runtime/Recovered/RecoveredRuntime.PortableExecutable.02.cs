using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ExtremeInjector;
using Microsoft.Win32;

public sealed partial class RecoveredRuntime
{

	internal static void smethod_284(PeScrambler gclass4_0, PeSectionHeader gclass5_0)
	{
		gclass5_0.method_19(SectionCharacteristics.flag_32 | SectionCharacteristics.flag_33 | SectionCharacteristics.flag_34);
		gclass4_0.class154_0.method_28().Position = gclass5_0.method_8();
		int num3 = default(int);
		bool flag = default(bool);
		uint num9 = default(uint);
		int num13 = default(int);
		long num7 = default(long);
		long position2 = default(long);
		int num4 = default(int);
		int num5 = default(int);
		byte[] buffer = default(byte[]);
		int num8 = default(int);
		int num10 = default(int);
		int num15 = default(int);
		int num11 = default(int);
		long num6 = default(long);
		int num16 = default(int);
		int num12 = default(int);
		long position = default(long);
		while (true)
		{
			int num = 305058695;
			while (true)
			{
				uint num2;
				int num14;
				switch ((num2 = (uint)(num ^ 0x2EC38574)) % 221)
				{
				case 220u:
					num = ((num3 < 15) ? 1686229034 : 1229093046);
					continue;
				case 219u:
					num = (int)((num2 * 378020019) ^ 0x646AEAA6);
					continue;
				case 218u:
					gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 516586338;
					continue;
				case 216u:
					gclass4_0.binaryWriter_0.Write((byte)61);
					gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 352292013;
					continue;
				case 215u:
					gclass4_0.binaryWriter_0.Write((byte)81);
					num = 1733674643;
					continue;
				case 214u:
					num = ((int)num2 * -595445714) ^ 0x6A7E3523;
					continue;
				case 213u:
					goto IL_00f2;
				case 212u:
					gclass4_0.binaryWriter_0.Write((byte)93);
					num = ((int)num2 * -1889548336) ^ -640656859;
					continue;
				case 211u:
					gclass4_0.binaryWriter_0.Write(PeScrambler.smethod_0((byte)96, (PeScrambler.Delegate48<byte>)smethod_166));
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 199, 7 });
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 7, 233 });
					num = ((int)num2 * -1224632176) ^ -105429906;
					continue;
				case 210u:
					gclass4_0.binaryWriter_0.Write((byte)233);
					num = (int)((num2 * 1074061146) ^ 0x3AA5D369);
					continue;
				case 209u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 192, 6 });
					num = 1899535561;
					continue;
				case 208u:
					gclass4_0.binaryWriter_0.Write((byte)117);
					num = 2085162869;
					continue;
				case 207u:
					num = (int)(num2 * 967311111) ^ -203969100;
					continue;
				case 206u:
					goto IL_022f;
				case 205u:
					goto IL_024f;
				case 204u:
					goto IL_0275;
				case 203u:
					goto IL_0295;
				case 202u:
					gclass4_0.class154_0.method_6().method_3().imethod_12(gclass5_0.method_4());
					num = (int)((num2 * 627548287) ^ 0x640E422E);
					continue;
				case 201u:
					num14 = gclass4_0.random_0.Next(1, num13);
					goto IL_02f1;
				case 200u:
					gclass4_0.class154_0.method_28().Position -= num7 + 1L;
					num = (int)((num2 * 1727907532) ^ 0x4E057183);
					continue;
				case 199u:
					num = ((num3 <= 30) ? (-6535356) : (-787062281)) ^ (int)(num2 * 862239932);
					continue;
				case 198u:
					goto IL_037d;
				case 197u:
					gclass4_0.binaryWriter_0.Write((byte)190);
					gclass4_0.binaryWriter_0.Write(num9);
					num = (int)((num2 * 14813109) ^ 0x2BF1E0F2);
					continue;
				case 196u:
					num = ((int)num2 * -884719291) ^ 0x154FBB58;
					continue;
				case 195u:
					num = (int)((num2 * 1173518897) ^ 0x72467F99);
					continue;
				case 194u:
					gclass4_0.binaryWriter_0.Write(num9);
					num = (int)((num2 * 1936693761) ^ 0x74C6ACA);
					continue;
				case 193u:
					goto IL_040a;
				case 192u:
					goto IL_0424;
				case 191u:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 255 });
					num = (int)((num2 * 349300742) ^ 0x57007858);
					continue;
				case 190u:
					goto IL_0478;
				case 189u:
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = (int)(num2 * 1815301175) ^ -485293696;
					continue;
				case 188u:
					gclass4_0.binaryWriter_0.Write((byte)233);
					num13 = (int)(gclass4_0.class154_0.method_28().Position - position2 - 30L);
					num = ((int)num2 * -227216085) ^ 0x660856DD;
					continue;
				case 187u:
					goto IL_0503;
				case 186u:
					num = ((int)num2 * -530719548) ^ 0x264E10A6;
					continue;
				case 185u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 7, 96 });
					num = (int)(num2 * 1708650183) ^ -21216774;
					continue;
				case 184u:
					num = ((num4 < 15) ? (-770264460) : (-1738635243)) ^ (int)(num2 * 1046728068);
					continue;
				case 183u:
					num = (int)((num2 * 390353747) ^ 0x1CF2201A);
					continue;
				case 182u:
					goto IL_05ab;
				case 181u:
					num5 = 0;
					num = ((int)num2 * -1045951476) ^ 0x2CBFA7E3;
					continue;
				case 180u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 2, 233 });
					num = ((int)num2 * -2096866926) ^ -420189005;
					continue;
				case 179u:
					goto IL_0610;
				case 178u:
					gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 516586338;
					continue;
				case 177u:
					goto IL_066b;
				case 176u:
					goto IL_068b;
				case 175u:
					goto IL_06ab;
				case 174u:
					gclass4_0.binaryWriter_0.Write(buffer);
					num = (int)(num2 * 1704521744) ^ -1963012049;
					continue;
				case 173u:
					num = ((int)num2 * -2089321290) ^ -1551517659;
					continue;
				case 172u:
					goto IL_0708;
				case 171u:
					num = ((int)num2 * -881437792) ^ -1699535389;
					continue;
				case 170u:
					num = ((num3 < 15) ? 1363434541 : 1452231447) ^ (int)(num2 * 1046200270);
					continue;
				case 169u:
					flag = gclass4_0.random_0.Next(2) == 1;
					num = ((int)num2 * -64570790) ^ -590354875;
					continue;
				case 168u:
					num9 = gclass4_0.random_0.smethod_0();
					num = 1359180453;
					continue;
				case 167u:
					num = ((int)num2 * -1103271214) ^ 0x7495465D;
					continue;
				case 166u:
					num = (int)((num2 * 1453342971) ^ 0xC8DE6DD);
					continue;
				case 165u:
					goto IL_07c6;
				case 164u:
					num8 = gclass4_0.random_0.Next(7);
					num = ((int)num2 * -1995143659) ^ -251124306;
					continue;
				case 163u:
					goto IL_0807;
				case 162u:
					goto IL_083b;
				case 161u:
					goto IL_085b;
				case 160u:
					num = (int)(num2 * 1258101779) ^ -185532408;
					continue;
				case 159u:
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = ((int)num2 * -1452208755) ^ 0x37025D3A;
					continue;
				case 158u:
					goto IL_08b1;
				case 157u:
					num = ((int)num2 * -1907795451) ^ 0x67E97B16;
					continue;
				case 156u:
					gclass4_0.binaryWriter_0.Write((byte)189);
					num = (int)(num2 * 802842557) ^ -165762734;
					continue;
				case 155u:
					num = (int)(num2 * 559511136) ^ -1361062333;
					continue;
				case 154u:
					gclass4_0.binaryWriter_0.Write((byte)num7);
					gclass4_0.class154_0.method_28().Position += num7;
					num = ((int)num2 * -676465071) ^ -632224180;
					continue;
				case 153u:
					gclass4_0.binaryWriter_0.Write((byte)195);
					num = (int)((num2 * 644856095) ^ 0x79321AC5);
					continue;
				case 152u:
					num = ((int)num2 * -424415677) ^ 0xD865AD1;
					continue;
				case 151u:
					num = ((int)num2 * -1291021938) ^ -677498445;
					continue;
				case 150u:
					position2 = gclass4_0.class154_0.method_28().Position;
					gclass4_0.binaryWriter_0.Write((byte)233);
					gclass4_0.binaryWriter_0.Write(0);
					num = ((int)num2 * -1962027042) ^ -1005481196;
					continue;
				case 149u:
					gclass4_0.binaryWriter_0.Write((int)(gclass4_0.class154_0.method_6().method_3().imethod_11() - gclass5_0.method_4() - 5 - num10));
					num13 = (int)(gclass5_0.method_2() - (gclass4_0.class154_0.method_28().Position - position2) - 30L);
					num = (int)(num2 * 1969700806) ^ -131591895;
					continue;
				case 148u:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 251 });
					num = (int)((num2 * 2021970831) ^ 0x7356BC62);
					continue;
				case 147u:
					num = ((int)num2 * -382986518) ^ -296715301;
					continue;
				case 146u:
					num3 = num4;
					num5++;
					num = 1063215034;
					continue;
				case 145u:
					goto IL_0aa7;
				case 144u:
					num = ((int)num2 * -764754816) ^ 0x6FBD4E43;
					continue;
				case 143u:
					goto IL_0ade;
				case 142u:
					num15 = gclass4_0.random_0.Next(1, num13);
					gclass4_0.binaryWriter_0.Write(num15);
					num = 1056626222;
					continue;
				case 141u:
					num10 = (int)(gclass4_0.class154_0.method_28().Position - position2);
					gclass4_0.binaryWriter_0.Write(PeScrambler.smethod_0((byte)233, (PeScrambler.Delegate48<byte>)smethod_166));
					num = 2089643215;
					continue;
				case 140u:
					num = (int)((num2 * 1159913728) ^ 0x7365CEC3);
					continue;
				case 139u:
					num = ((int)num2 * -1498274518) ^ -766816087;
					continue;
				case 138u:
					num11 = gclass4_0.random_0.Next(18, (int)(gclass5_0.method_2() - num6 + 18L));
					num = (int)(num2 * 6921156) ^ -101081110;
					continue;
				case 137u:
					goto IL_0be3;
				case 136u:
					num = (int)(num2 * 542166685) ^ -1465015129;
					continue;
				case 135u:
					num = ((int)num2 * -529483792) ^ 0x2279C0D3;
					continue;
				case 134u:
					goto IL_0c29;
				case 133u:
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = (int)(num2 * 2002970017) ^ -661440136;
					continue;
				case 132u:
					gclass4_0.class154_0.method_28().Position = position2 + 1L;
					gclass4_0.binaryWriter_0.Write(num10 - 23);
					num = 988831160;
					continue;
				case 131u:
					goto IL_0caf;
				case 130u:
					goto IL_0cc6;
				case 129u:
					num16 = gclass4_0.random_0.Next((int)gclass5_0.method_2() / 50, (int)gclass5_0.method_2() / 25);
					buffer = new byte[num16];
					gclass4_0.random_0.NextBytes(buffer);
					num = ((int)num2 * -2102074103) ^ -716178468;
					continue;
				case 128u:
					num = (int)(num2 * 1939669207) ^ -1448921687;
					continue;
				case 127u:
					buffer = new byte[num15];
					num = ((int)num2 * -241734486) ^ -726035502;
					continue;
				case 126u:
					num = (int)(num2 * 1968336229) ^ -755438860;
					continue;
				case 125u:
					goto IL_0d73;
				case 124u:
					gclass4_0.binaryWriter_0.Write(PeScrambler.smethod_0((byte)96, (PeScrambler.Delegate48<byte>)smethod_166));
					num = ((int)num2 * -815560105) ^ 0x664E03E5;
					continue;
				case 123u:
					gclass4_0.binaryWriter_0.Write(num9);
					num = ((int)num2 * -264521640) ^ -755865030;
					continue;
				case 122u:
					goto IL_0dec;
				case 121u:
					goto IL_0e06;
				case 120u:
					num = ((int)num2 * -1077335159) ^ -1281048182;
					continue;
				case 119u:
					goto IL_0e39;
				case 118u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 0, 96 });
					gclass4_0.binaryWriter_0.Write(PeScrambler.smethod_0((byte)96, (PeScrambler.Delegate48<byte>)smethod_166));
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 192, 7 });
					num = ((int)num2 * -603294904) ^ 0x603C1A07;
					continue;
				case 117u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 3, 96 });
					num = ((int)num2 * -2016482386) ^ -454935534;
					continue;
				case 116u:
					num = (int)(num2 * 1758685134) ^ -1160381176;
					continue;
				case 115u:
					gclass4_0.binaryWriter_0.Write(num9);
					num = ((int)num2 * -128756104) ^ 0x44457E5D;
					continue;
				case 114u:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 254 });
					num = (int)(num2 * 1925997889) ^ -1741353795;
					continue;
				case 113u:
					num = (int)((num2 * 1102082436) ^ 0x8FE11BF);
					continue;
				case 112u:
					goto IL_0f7d;
				case 111u:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 253 });
					num = ((int)num2 * -334565549) ^ -166286659;
					continue;
				case 110u:
					goto IL_0fdc;
				case 109u:
					num = ((int)num2 * -1179464546) ^ 0x2F8E1182;
					continue;
				case 108u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 2, 96 });
					gclass4_0.binaryWriter_0.Write(PeScrambler.smethod_0((byte)96, (PeScrambler.Delegate48<byte>)smethod_166));
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 194, 7 });
					num = ((int)num2 * -306576431) ^ 0x32BE898C;
					continue;
				case 107u:
					num = (int)((num2 * 1911873910) ^ 0x3C85AF5B);
					continue;
				case 106u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 139, 20, 36 });
					num = 482868246;
					continue;
				case 105u:
					num = (int)((num2 * 637971787) ^ 0x2F564C3A);
					continue;
				case 104u:
					gclass4_0.binaryWriter_0.Write((int)(gclass5_0.method_4() + 5 + num16 - (gclass5_0.method_4() + num10 + 5L)));
					gclass4_0.class154_0.method_28().Position += num11 - 18;
					switch (num12)
					{
					case 2:
						break;
					default:
						goto IL_1135;
					case 0:
						goto IL_1148;
					case 1:
						goto IL_116e;
					case 3:
						goto IL_1194;
					case 4:
						goto IL_11ba;
					}
					goto case 106u;
				case 46u:
					goto IL_1148;
				case 48u:
					goto IL_116e;
				case 32u:
					goto IL_1194;
				case 93u:
					goto IL_11ba;
				case 103u:
					num = (int)(num2 * 978092314) ^ -313458219;
					continue;
				case 102u:
					gclass4_0.binaryWriter_0.Write((byte)88);
					num = (int)((num2 * 135953848) ^ 0xC1E9B6A);
					continue;
				case 101u:
					num = ((num3 > 30) ? 1842268660 : 245437001) ^ ((int)num2 * -506391089);
					continue;
				case 100u:
					goto IL_124d;
				case 99u:
					num = ((int)num2 * -1104150545) ^ -1458267190;
					continue;
				case 98u:
					num4 = gclass4_0.random_0.Next(15, 31);
					num = ((int)num2 * -936797130) ^ -1742564989;
					continue;
				case 97u:
					if (num13 >= 0)
					{
						num = ((int)num2 * -1923346361) ^ 0xF98F672;
						continue;
					}
					num14 = 0;
					goto IL_02f1;
				case 96u:
					gclass4_0.binaryWriter_0.Write((byte)89);
					num = (int)(num2 * 484663467) ^ -1183175794;
					continue;
				case 95u:
					num = (flag ? 519778500 : 1302648361);
					continue;
				case 94u:
					num = ((int)num2 * -1146368755) ^ -613784753;
					continue;
				case 92u:
					goto IL_1325;
				case 91u:
					gclass4_0.binaryWriter_0.Write((byte)195);
					num = ((int)num2 * -90060275) ^ 0x1A740585;
					continue;
				case 90u:
					goto IL_136c;
				case 89u:
					goto IL_1392;
				case 88u:
					gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 1120404196;
					continue;
				case 87u:
					num = (int)(num2 * 359654114) ^ -915876332;
					continue;
				case 86u:
					num = ((int)num2 * -176775374) ^ -158793163;
					continue;
				case 85u:
					num = (int)(num2 * 670289437) ^ -271968048;
					continue;
				case 84u:
					num = ((int)num2 * -781214535) ^ 0x6BF54CDD;
					continue;
				case 83u:
					num = ((int)num2 * -1498924529) ^ -318244760;
					continue;
				case 82u:
					num = ((int)num2 * -1838916759) ^ -271813513;
					continue;
				case 81u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 1, 233 });
					num = ((int)num2 * -70816932) ^ -1983179234;
					continue;
				case 80u:
					num = ((num4 <= 45) ? (-534896338) : (-2107584804)) ^ (int)(num2 * 913917175);
					continue;
				case 79u:
					goto IL_14a5;
				case 78u:
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = (int)((num2 * 1009670288) ^ 0x4D6A81B2);
					continue;
				case 77u:
					num = ((num3 > 45) ? (-439038158) : (-2078598137)) ^ (int)(num2 * 1739698323);
					continue;
				case 76u:
					gclass4_0.binaryWriter_0.Write(num9);
					num = (int)((num2 * 772551642) ^ 0x171794D6);
					continue;
				case 75u:
					num = ((int)num2 * -79949315) ^ -224515549;
					continue;
				case 74u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 195, 7 });
					num = (int)((num2 * 1136029018) ^ 0x3CB1CAE6);
					continue;
				case 73u:
					num = (int)((num2 * 780591959) ^ 0x26B099D1);
					continue;
				case 72u:
					goto IL_1595;
				case 71u:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 249 });
					gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 161606325;
					continue;
				case 70u:
					goto IL_1611;
				case 69u:
					gclass4_0.binaryWriter_0.Write((byte)94);
					num = ((int)num2 * -230312221) ^ 0xD99A396;
					continue;
				case 68u:
					gclass4_0.binaryWriter_0.Write(num9);
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 250 });
					gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 457319644;
					continue;
				case 67u:
					goto IL_16b7;
				case 66u:
					goto IL_16f8;
				case 65u:
					goto IL_1723;
				case 64u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 0, 233 });
					num = (int)((num2 * 1193206714) ^ 0x77CEEDC6);
					continue;
				case 63u:
					gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 516586338;
					continue;
				case 62u:
					goto IL_179d;
				case 61u:
					num = ((num13 < 0) ? (-164001094) : (-959208304)) ^ (int)(num2 * 604857919);
					continue;
				case 60u:
					gclass4_0.binaryWriter_0.Write((byte)184);
					num = ((int)num2 * -1886643111) ^ -1130372139;
					continue;
				case 59u:
					gclass4_0.binaryWriter_0.Write((byte)95);
					num = ((int)num2 * -1826285317) ^ -1436682269;
					continue;
				case 58u:
					goto IL_1835;
				case 57u:
					num = ((int)num2 * -289767636) ^ 0x7F4A7343;
					continue;
				case 56u:
					num = ((int)num2 * -213756742) ^ 0x1AD823B7;
					continue;
				case 55u:
					num = (int)((num2 * 1924600756) ^ 0xDDB7CF6);
					continue;
				case 54u:
					num = ((int)num2 * -1946070003) ^ 0x196BD72E;
					continue;
				case 53u:
					num = ((num5 < gclass4_0.random_0.Next((int)(gclass5_0.method_2() / 10), (int)(gclass5_0.method_2() / 8))) ? 700303845 : 1735233297);
					continue;
				case 52u:
					num3 = -1;
					num = ((int)num2 * -84917066) ^ 0x177AD86E;
					continue;
				case 51u:
					gclass4_0.binaryWriter_0.Write((byte)232);
					num = ((int)num2 * -379217128) ^ 0x79214FD4;
					continue;
				case 50u:
					num13 = 2;
					num = (int)(num2 * 1598022106) ^ -1947642038;
					continue;
				case 49u:
					goto IL_1936;
				case 47u:
					num = (int)(num2 * 1460566507) ^ -929350941;
					continue;
				case 45u:
					num = ((num4 >= 39) ? 1316240462 : 1686229034);
					continue;
				case 44u:
					gclass4_0.binaryWriter_0.Write((byte)195);
					num = (int)((num2 * 766263518) ^ 0x158E34CD);
					continue;
				case 43u:
					gclass4_0.random_0.NextBytes(buffer);
					num = ((int)num2 * -48200879) ^ 0x7EF37F5C;
					continue;
				case 42u:
					num = ((int)num2 * -1923694133) ^ -226312361;
					continue;
				case 41u:
					gclass4_0.binaryWriter_0.Write(num11);
					num12 = gclass4_0.random_0.Next(5);
					switch (num12)
					{
					case 0:
						break;
					case 4:
						goto IL_024f;
					case 3:
						goto IL_136c;
					default:
						goto IL_1a16;
					case 1:
						goto IL_1a29;
					case 2:
						goto IL_1aa5;
					}
					goto case 209u;
				case 4u:
					goto IL_1a29;
				case 9u:
					goto IL_1aa5;
				case 40u:
					goto IL_1acb;
				case 39u:
					goto IL_1afb;
				case 38u:
					num = (int)((num2 * 527836293) ^ 0x169EBA1E);
					continue;
				case 37u:
					num = ((int)num2 * -1822041019) ^ -453979335;
					continue;
				case 36u:
					gclass4_0.binaryWriter_0.Write((byte)gclass4_0.random_0.Next(2, 128));
					gclass4_0.binaryWriter_0.Write((byte)97);
					num10 = (int)(gclass4_0.class154_0.method_28().Position - position2);
					num = 1838090966;
					continue;
				case 35u:
					gclass4_0.binaryWriter_0.Write(buffer);
					num = ((int)num2 * -1791121218) ^ 0x15563351;
					continue;
				case 34u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 3, 233 });
					num = ((int)num2 * -494382531) ^ 0x28C0E326;
					continue;
				case 33u:
					gclass4_0.binaryWriter_0.Write((byte)186);
					num = (int)(num2 * 621253200) ^ -433800949;
					continue;
				case 31u:
					num4 = PeScrambler.smethod_0(num3, () => gclass4_0.random_0.Next(53));
					num = 497918434;
					continue;
				case 30u:
					num4 = gclass4_0.random_0.Next(53);
					num = 1005466653;
					continue;
				case 29u:
					position = gclass4_0.class154_0.method_28().Position;
					switch (num4)
					{
					case 32:
						break;
					case 50:
						goto IL_00f2;
					case 19:
						goto IL_022f;
					case 21:
						goto IL_0275;
					case 25:
						goto IL_0295;
					case 36:
						goto IL_037d;
					case 7:
						goto IL_040a;
					case 18:
						goto IL_0424;
					case 30:
						goto IL_0478;
					case 11:
						goto IL_0503;
					case 17:
						goto IL_05ab;
					case 48:
						goto IL_0610;
					case 15:
						goto IL_066b;
					case 16:
						goto IL_068b;
					case 43:
						goto IL_06ab;
					case 29:
						goto IL_0708;
					case 23:
						goto IL_07c6;
					case 24:
						goto IL_083b;
					case 0:
						goto IL_085b;
					case 33:
						goto IL_0aa7;
					case 52:
						goto IL_0ade;
					case 22:
						goto IL_0be3;
					case 12:
						goto IL_0c29;
					case 31:
						goto IL_0caf;
					case 10:
						goto IL_0cc6;
					case 8:
						goto IL_0d73;
					case 2:
						goto IL_0dec;
					case 26:
						goto IL_0e06;
					case 6:
						goto IL_0e39;
					case 44:
						goto IL_0f7d;
					case 45:
						goto IL_0fdc;
					case 3:
						goto IL_124d;
					case 35:
						goto IL_1325;
					case 13:
						goto IL_14a5;
					case 39:
						goto IL_1595;
					case 9:
						goto IL_1611;
					case 49:
						goto IL_16b7;
					case 51:
						goto IL_16f8;
					case 46:
						goto IL_1723;
					case 41:
						goto IL_179d;
					case 40:
						goto IL_1835;
					case 20:
						goto IL_1936;
					case 1:
						goto IL_1acb;
					case 4:
						goto IL_1afb;
					default:
						goto IL_1d2f;
					case 5:
						goto IL_1d39;
					case 14:
						goto IL_1d69;
					case 27:
						goto IL_1d91;
					case 28:
						goto IL_1db1;
					case 34:
						goto IL_1dd1;
					case 37:
						goto IL_1df5;
					case 38:
						goto IL_1e0c;
					case 42:
						goto IL_1e23;
					case 47:
						goto IL_1e4e;
					}
					goto case 215u;
				case 27u:
					goto IL_1d39;
				case 5u:
					goto IL_1d69;
				case 11u:
					goto IL_1d91;
				case 6u:
					goto IL_1db1;
				case 28u:
					goto IL_1dd1;
				case 7u:
					goto IL_1df5;
				case 16u:
					goto IL_1e0c;
				case 18u:
					goto IL_1e23;
				case 23u:
					goto IL_1e4e;
				case 26u:
					num = ((int)num2 * -273305275) ^ 0x6DBEAA44;
					continue;
				case 25u:
					switch (num8)
					{
					case 5:
						break;
					case 6:
						goto IL_0807;
					case 1:
						goto IL_08b1;
					case 2:
						goto IL_1392;
					default:
						goto IL_1ec5;
					case 0:
						goto IL_1ed8;
					case 3:
						goto IL_1eef;
					case 4:
						goto IL_1f16;
					}
					goto case 168u;
				case 10u:
					goto IL_1ed8;
				case 14u:
					goto IL_1eef;
				case 0u:
					goto IL_1f16;
				case 24u:
					num = (int)((num2 * 1175045322) ^ 0x7A30F98B);
					continue;
				case 22u:
					num7 = gclass4_0.class154_0.method_28().Position - position;
					num = 855152025;
					continue;
				case 21u:
					num = ((int)num2 * -1447756720) ^ -2139990349;
					continue;
				case 20u:
					num = (int)(num2 * 589469835) ^ -21083709;
					continue;
				case 19u:
					gclass4_0.binaryWriter_0.Write((byte)116);
					num = ((int)num2 * -615290808) ^ 0x7A93658E;
					continue;
				case 17u:
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = ((int)num2 * -1038425756) ^ -1522088395;
					continue;
				case 15u:
					num6 = gclass4_0.class154_0.method_28().Position - gclass5_0.method_8();
					num = ((int)num2 * -174527814) ^ 0x4BA48288;
					continue;
				case 13u:
					num = ((num3 >= 39) ? 744360995 : 551314375);
					continue;
				case 12u:
					num = ((num4 > 30) ? (-1446200345) : (-1859856553)) ^ (int)(num2 * 1631605499);
					continue;
				case 8u:
					num = ((num3 != -1) ? 1976152531 : 1686229034);
					continue;
				case 3u:
					num = (int)(num2 * 1884568933) ^ -924737143;
					continue;
				case 1u:
					gclass4_0.binaryWriter_0.Write((byte)195);
					num = (int)(num2 * 1950835675) ^ -806446463;
					continue;
				default:
					return;
				case 217u:
					break;
				case 2u:
					return;
					IL_00f2:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 197 });
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1462547698;
					continue;
					IL_0610:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 194 });
					num = 1346854063;
					continue;
					IL_05ab:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 114, 0 });
					num = 410557396;
					continue;
					IL_1f16:
					num9 = gclass4_0.random_0.smethod_0();
					num = 3561116;
					continue;
					IL_1eef:
					num9 = gclass4_0.random_0.smethod_0();
					gclass4_0.binaryWriter_0.Write((byte)187);
					num = 3376223;
					continue;
					IL_1ed8:
					num9 = gclass4_0.random_0.smethod_0();
					num = 305096990;
					continue;
					IL_1ec5:
					num = ((int)num2 * -643469374) ^ 0x71CA4C75;
					continue;
					IL_1e4e:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 193 });
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1958555918;
					continue;
					IL_1e23:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 219 });
					num = 436537672;
					continue;
					IL_1e0c:
					gclass4_0.binaryWriter_0.Write((byte)87);
					num = 1546059053;
					continue;
					IL_1df5:
					gclass4_0.binaryWriter_0.Write((byte)86);
					num = 1471824075;
					continue;
					IL_1dd1:
					gclass4_0.binaryWriter_0.Write((byte)83);
					gclass4_0.binaryWriter_0.Write((byte)91);
					num = 1137758403;
					continue;
					IL_1db1:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 125, 0 });
					num = 1964534240;
					continue;
					IL_1d91:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 124, 0 });
					num = 1792764093;
					continue;
					IL_1d69:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 255 });
					num = 1412264438;
					continue;
					IL_1d39:
					gclass4_0.binaryWriter_0.Write((byte)189);
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1188458100;
					continue;
					IL_1d2f:
					num = 456428813;
					continue;
					IL_1afb:
					gclass4_0.binaryWriter_0.Write((byte)187);
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1263548425;
					continue;
					IL_1acb:
					gclass4_0.binaryWriter_0.Write((byte)184);
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1137758403;
					continue;
					IL_1aa5:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 194, 6 });
					num = 31990827;
					continue;
					IL_1a29:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 193, 6 });
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 1, 96 });
					gclass4_0.binaryWriter_0.Write(PeScrambler.smethod_0((byte)96, (PeScrambler.Delegate48<byte>)smethod_166));
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 193, 7 });
					num = 215853252;
					continue;
					IL_1a16:
					num = (int)(num2 * 919280634) ^ -717987036;
					continue;
					IL_1936:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 117, 0 });
					num = 1137758403;
					continue;
					IL_1835:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 201 });
					num = 1412008783;
					continue;
					IL_179d:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 210 });
					num = 798553809;
					continue;
					IL_0503:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 219 });
					num = 1623874145;
					continue;
					IL_1723:
					gclass4_0.binaryWriter_0.Write((byte)5);
					num = 1784154990;
					continue;
					IL_16f8:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 198 });
					num = 449174633;
					continue;
					IL_16b7:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 195 });
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 51231112;
					continue;
					IL_0424:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 115, 0 });
					num = 904988517;
					continue;
					IL_0478:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 127, 0 });
					num = 1107002620;
					continue;
					IL_1611:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 201 });
					num = 1137758403;
					continue;
					IL_040a:
					gclass4_0.binaryWriter_0.Write((byte)191);
					num = 1280905986;
					continue;
					IL_1595:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 192 });
					num = 97560293;
					continue;
					IL_037d:
					gclass4_0.binaryWriter_0.Write((byte)85);
					num = 1805410727;
					continue;
					IL_14a5:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 246 });
					num = 2012189460;
					continue;
					IL_1392:
					num9 = gclass4_0.random_0.smethod_0();
					num = 2127398237;
					continue;
					IL_136c:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 195, 6 });
					num = 1032748925;
					continue;
					IL_1325:
					gclass4_0.binaryWriter_0.Write((byte)84);
					gclass4_0.binaryWriter_0.Write((byte)92);
					num = 1987388939;
					continue;
					IL_02f1:
					num15 = num14;
					buffer = new byte[num15];
					gclass4_0.random_0.NextBytes(buffer);
					gclass4_0.binaryWriter_0.Write(buffer);
					num = 74389284;
					continue;
					IL_0295:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 122, 0 });
					num = 1489154986;
					continue;
					IL_0275:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 118, 0 });
					num = 1696512839;
					continue;
					IL_124d:
					gclass4_0.binaryWriter_0.Write((byte)186);
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 243166376;
					continue;
					IL_022f:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 116, 0 });
					num = 1146262003;
					continue;
					IL_024f:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 199, 6 });
					num = 515504599;
					continue;
					IL_11ba:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 139, 60, 36 });
					gclass4_0.binaryWriter_0.Write((byte)195);
					num = 1495017047;
					continue;
					IL_1194:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 139, 28, 36 });
					num = 150413617;
					continue;
					IL_116e:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 139, 12, 36 });
					num = 1932517367;
					continue;
					IL_1148:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 139, 4, 36 });
					num = 1512137255;
					continue;
					IL_1135:
					num = ((int)num2 * -226357130) ^ 0x6D288831;
					continue;
					IL_0fdc:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 255 });
					num = 1874612891;
					continue;
					IL_0f7d:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 246 });
					num = 1697160656;
					continue;
					IL_0e39:
					gclass4_0.binaryWriter_0.Write((byte)190);
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1908395651;
					continue;
					IL_0e06:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 123, 0 });
					num = 1546110467;
					continue;
					IL_0dec:
					gclass4_0.binaryWriter_0.Write((byte)185);
					num = 1701317269;
					continue;
					IL_0d73:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 192 });
					num = 1387697096;
					continue;
					IL_0cc6:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 210 });
					num = 1137758403;
					continue;
					IL_0caf:
					gclass4_0.binaryWriter_0.Write((byte)80);
					num = 464933626;
					continue;
					IL_0c29:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 237 });
					num = 1137758403;
					continue;
					IL_0be3:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 119, 0 });
					num = 1137758403;
					continue;
					IL_0ade:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 199 });
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1137758403;
					continue;
					IL_0aa7:
					gclass4_0.binaryWriter_0.Write((byte)82);
					gclass4_0.binaryWriter_0.Write((byte)90);
					num = 1137758403;
					continue;
					IL_08b1:
					num9 = gclass4_0.random_0.smethod_0();
					gclass4_0.binaryWriter_0.Write((byte)185);
					num = 1697763964;
					continue;
					IL_085b:
					gclass4_0.binaryWriter_0.Write((byte)144);
					num = 2055170547;
					continue;
					IL_083b:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 121, 0 });
					num = 1612015647;
					continue;
					IL_0807:
					num9 = gclass4_0.random_0.smethod_0();
					gclass4_0.binaryWriter_0.Write((byte)191);
					gclass4_0.binaryWriter_0.Write(num9);
					num = 152124170;
					continue;
					IL_07c6:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 120, 0 });
					num = 318679494;
					continue;
					IL_0708:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 126, 0 });
					num = 1137758403;
					continue;
					IL_06ab:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 237 });
					num = 1317661814;
					continue;
					IL_068b:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 113, 0 });
					num = 1137758403;
					continue;
					IL_066b:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 112, 0 });
					num = 1137758403;
					continue;
				}
				break;
			}
		}
	}

	internal static DelayImportDirectory smethod_293(BoundsCheckedBinaryReader class5_0, PeImage class154_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[13];
		long num3 = default(long);
		while (true)
		{
			int num = 1105769676;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x646B2F26)) % 11)
				{
				case 7u:
					num = (class5_0.imethod_0(num3) ? 216788385 : 711710922) ^ (int)(num2 * 370115479);
					continue;
				case 6u:
					num = ((@class.method_0() != 0) ? (-2067324191) : (-860182254)) ^ (int)(num2 * 50459695);
					continue;
				case 5u:
					num = ((@class.method_2() == 0) ? 581536003 : 1338120806) ^ (int)(num2 * 236926359);
					continue;
				case 4u:
					num3 = smethod_135(class154_0, @class.method_0());
					num = ((num3 != -1L) ? 1539903923 : 757067817);
					continue;
				case 1u:
					smethod_157(class5_0, num3);
					num = 943535746;
					continue;
				case 0u:
					num = ((!class5_0.imethod_0(num3 + @class.method_2())) ? 1341497845 : 1965542859);
					continue;
				case 2u:
					break;
				case 3u:
					return null;
				case 8u:
					return null;
				case 9u:
					return null;
				default:
					return new DelayImportDirectory(class5_0, class154_0);
				}
				break;
			}
		}
	}

	internal static void smethod_299(string string_0, PeImage class154_0)
	{
		FileStream fileStream = File.OpenWrite(string_0);
		try
		{
			fileStream.SetLength(0L);
			smethod_315(fileStream, class154_0);
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_0054:
					int num = -1819976338;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1676823146)) % 3)
						{
						case 1u:
							goto IL_0024;
						default:
							goto end_IL_0037;
						case 0u:
							break;
						case 2u:
							goto end_IL_0037;
						}
						goto IL_0054;
						IL_0024:
						((IDisposable)fileStream).Dispose();
						num = (int)((num2 * 1955297604) ^ 0x42B2FA9D);
						continue;
						end_IL_0037:
						break;
					}
					break;
				}
			}
		}
	}

	internal static ExceptionDirectory smethod_303(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[3];
		if (@class.method_0() != 0)
		{
			long num3 = default(long);
			while (true)
			{
				int num = -467057641;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -152289335)) % 11)
					{
					case 10u:
						num = (class5_0.imethod_0(num3) ? 124199343 : 1491147542) ^ ((int)num2 * -1373069411);
						continue;
					case 9u:
						num = ((num3 == -1L) ? (-1236182841) : (-268214864)) ^ ((int)num2 * -1771252321);
						continue;
					case 6u:
						smethod_157(class5_0, num3);
						num = -126246791;
						continue;
					case 4u:
						num3 = smethod_135(class154_0, @class.method_0());
						num = -570129132;
						continue;
					case 3u:
						break;
					case 1u:
						num = ((@class.method_2() == 0) ? (-1003845395) : (-344224114)) ^ ((int)num2 * -638297019);
						continue;
					case 2u:
						goto end_IL_00f0;
					case 0u:
						return null;
					case 5u:
						return null;
					default:
						return new ExceptionDirectory(class5_0, @class);
					case 8u:
						goto end_IL_012e;
					}
					num = ((!class5_0.imethod_0(num3 + @class.method_2())) ? (-61759745) : (-1563533534));
					continue;
					end_IL_00f0:
					break;
				}
				continue;
				end_IL_012e:
				break;
			}
		}
		return null;
	}

	internal static void smethod_304(PeScrambler gclass4_0, PeSectionHeader gclass5_0)
	{
		DataDirectory @class = gclass4_0.class154_0.method_6().method_3().imethod_49()[5];
		long num3 = default(long);
		while (true)
		{
			int num = -152657987;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -899836390)) % 8)
				{
				case 7u:
					num3 = smethod_135(gclass4_0.class154_0, @class.method_0());
					num = ((num3 != -1L) ? (-906701358) : (-2103103676)) ^ (int)(num2 * 414575614);
					continue;
				case 6u:
					num = ((gclass5_0.method_6() >= @class.method_2()) ? (-1344455681) : (-1572494749));
					continue;
				case 2u:
					num = ((gclass5_0.method_2() < @class.method_2()) ? (-773437646) : (-101927620));
					continue;
				case 0u:
					gclass5_0.method_3(@class.method_2());
					num = ((int)num2 * -1737160970) ^ -1656399540;
					continue;
				case 3u:
					break;
				case 1u:
					return;
				case 4u:
					return;
				default:
				{
					Stream stream = smethod_264(gclass4_0.class154_0, num3, (int)@class.method_2());
					byte[] buffer;
					try
					{
						BinaryReader binaryReader = new BinaryReader(stream);
						try
						{
							buffer = binaryReader.ReadBytes((int)@class.method_2());
						}
						finally
						{
							if (binaryReader != null)
							{
								while (true)
								{
									IL_0167:
									int num4 = -395880518;
									while (true)
									{
										switch ((num2 = (uint)(num4 ^ -899836390)) % 3)
										{
										case 1u:
											goto IL_0134;
										default:
											goto end_IL_0149;
										case 0u:
											break;
										case 2u:
											goto end_IL_0149;
										}
										goto IL_0167;
										IL_0134:
										((IDisposable)binaryReader).Dispose();
										num4 = (int)(num2 * 8803862) ^ -1497674065;
										continue;
										end_IL_0149:
										break;
									}
									break;
								}
							}
						}
					}
					finally
					{
						if (stream != null)
						{
							while (true)
							{
								IL_01a6:
								int num5 = -83504449;
								while (true)
								{
									switch ((num2 = (uint)(num5 ^ -899836390)) % 3)
									{
									case 1u:
										goto IL_0174;
									default:
										goto end_IL_0188;
									case 0u:
										break;
									case 2u:
										goto end_IL_0188;
									}
									goto IL_01a6;
									IL_0174:
									((IDisposable)stream).Dispose();
									num5 = (int)((num2 * 1188710185) ^ 0x50009237);
									continue;
									end_IL_0188:
									break;
								}
								break;
							}
						}
					}
					smethod_437(gclass4_0, num3, @class.method_2());
					while (true)
					{
						int num6 = -861841388;
						while (true)
						{
							switch ((num2 = (uint)(num6 ^ -899836390)) % 5)
							{
							case 3u:
								gclass4_0.class154_0.method_28().Position = gclass5_0.method_8();
								num6 = (int)((num2 * 1693851815) ^ 0x14A5EE35);
								continue;
							case 2u:
								@class.method_1(gclass5_0.method_4());
								num6 = ((int)num2 * -861353426) ^ 0x28DB0D24;
								continue;
							case 1u:
								gclass4_0.binaryWriter_0.Write(buffer);
								num6 = (int)(num2 * 1831048437) ^ -1144824703;
								continue;
							default:
								return;
							case 0u:
								break;
							case 4u:
								return;
							}
							break;
						}
					}
				}
				}
				break;
			}
		}
	}

	internal static ClrHeader smethod_312(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[14];
		if (@class.method_0() != 0)
		{
			long num3 = default(long);
			ClrHeader class2 = default(ClrHeader);
			while (true)
			{
				int num = -880956597;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1024140605)) % 12)
					{
					case 10u:
						num = ((num3 != -1L) ? 438485269 : 807005922) ^ (int)(num2 * 1268579210);
						continue;
					case 8u:
						num = ((@class.method_2() == 0) ? 1423101048 : 698370342) ^ (int)(num2 * 1503502788);
						continue;
					case 6u:
						num = (class5_0.imethod_0(num3) ? 898834489 : 1401334154) ^ (int)(num2 * 324214650);
						continue;
					case 2u:
						break;
					case 1u:
						num3 = smethod_135(class154_0, @class.method_0());
						num = -471873075;
						continue;
					case 0u:
						goto IL_00e8;
					case 4u:
						goto end_IL_0117;
					case 5u:
						return class2;
					case 7u:
						return null;
					case 9u:
						return null;
					default:
						return null;
					case 3u:
						goto end_IL_0159;
					}
					num = (class5_0.imethod_0(num3 + @class.method_2()) ? (-607341605) : (-1717547100));
					continue;
					IL_00e8:
					smethod_157(class5_0, num3);
					class2 = new ClrHeader(class5_0);
					num = ((class2.method_0() >= 72) ? (-982574482) : (-396135420));
					continue;
					end_IL_0117:
					break;
				}
				continue;
				end_IL_0159:
				break;
			}
		}
		return null;
	}

	internal static void smethod_315(Stream stream_0, PeImage class154_0)
	{
		smethod_76(stream_0, new PeImageWriter(class154_0));
	}

	internal static void ScrambleModule(string sourcePath, string destinationPath)
	{
		InjectorScrambleOptions options = ApplicationSettings.Current.Options.Scramble;
		PeScrambleOptions transformOptions = new PeScrambleOptions();
		transformOptions.method_21(options.CreateNewEntryPoint);
		transformOptions.method_3(options.InsertExtraSections);
		transformOptions.method_11(options.ModifyAssemblyCode);
		transformOptions.method_1(options.ScrambleHeaderFields);
		transformOptions.method_19(options.ModifyImportTable);
		transformOptions.method_17(options.RenameSections);
		transformOptions.method_15(options.MoveRelocationTable);
		transformOptions.method_5(options.RemoveDebugData);
		transformOptions.method_9(options.ShiftSectionData);
		transformOptions.method_13(options.RemoveUselessData);
		transformOptions.method_7(options.CreateFakeDebugDirectory);
		transformOptions.method_24(options.ShiftSectionMemory);
		transformOptions.method_26(options.StripSectionCharacteristics);

		try
		{
			using (PeImage module = smethod_81(PeImageLayout.const_0, sourcePath))
			using (PeScrambler scrambler = new PeScrambler(module, transformOptions))
			{
				smethod_95(scrambler);
				smethod_367(destinationPath, scrambler);
			}
		}
		catch
		{
			File.Copy(sourcePath, destinationPath, overwrite: true);
		}
	}

	internal static void smethod_330(SettingsForm gform2_0)
	{
		InjectionOptions class14_ = ApplicationSettings.Current.Options;
		class14_.Method = (InjectionMethod)gform2_0.comboBox_0.SelectedIndex;
		class14_.TextColor = gform2_0.panel_2.BackColor;
		class14_.BackgroundColor1 = gform2_0.panel_1.BackColor;
		class14_.BackgroundColor2 = gform2_0.panel_0.BackColor;
		class14_.AutoInject = gform2_0.checkBox_2.Checked;
		class14_.StealthInject = gform2_0.checkBox_0.Checked;
		class14_.CloseOnInject = gform2_0.checkBox_1.Checked;
		class14_.DelayBetweenModules = (int)gform2_0.numericUpDown_0.Value;
		class14_.DelayBeforeInjection = (int)gform2_0.numericUpDown_1.Value;
		class14_.ErasePeHeaders = gform2_0.checkBox_4.Checked;
		class14_.HideModule = gform2_0.checkBox_3.Checked;
		while (true)
		{
			int num = -1681404562;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1580424416)) % 3)
				{
				case 2u:
					goto IL_00d0;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_00d0:
				ApplicationSettings.Save();
				num = (int)((num2 * 1317291613) ^ 0x79221AD5);
			}
		}
	}

	internal static void smethod_333(PeImageWriter class165_0)
	{
		class165_0.stream_0.Position = 60L;
		class165_0.binaryWriter_0.Write(class165_0.class154_0.method_4().method_0());
	}

	internal static void AddModuleToGrid(bool bool_0, ModuleEntry class16_0, bool bool_1, MainForm mainForm, string string_0)
	{
		if (!File.Exists(string_0))
		{
			return;
		}
		try
		{
			string_0 = Path.GetFullPath(string_0);
			IEnumerator enumerator = ((IEnumerable)mainForm.moduleGrid.Rows).GetEnumerator();
			try
			{
				while (true)
				{
					IL_00b3:
					int num = ((!enumerator.MoveNext()) ? 1805172656 : 1770609057);
					while (true)
					{
						switch ((uint)(num ^ 0x866414E) % 5u)
						{
						case 4u:
							num = ((!GetModulePath((MainForm.ModuleRow)((DataGridViewRow)enumerator.Current).Tag).Equals(string_0, StringComparison.OrdinalIgnoreCase)) ? 799792168 : 2026028820);
							continue;
						case 2u:
							num = 1770609057;
							continue;
						default:
							goto end_IL_0081;
						case 3u:
							break;
						case 0u:
							return;
						case 1u:
							goto end_IL_0081;
						}
						goto IL_00b3;
						continue;
						end_IL_0081:
						break;
					}
					break;
				}
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					while (true)
					{
						IL_0105:
						int num2 = 672721271;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)(num2 ^ 0x866414E)) % 3)
							{
							case 2u:
								goto IL_00d3;
							default:
								goto end_IL_00e7;
							case 0u:
								break;
							case 1u:
								goto end_IL_00e7;
							}
							goto IL_0105;
							IL_00d3:
							disposable.Dispose();
							num2 = ((int)num3 * -2088883914) ^ 0x7C4CD845;
							continue;
							end_IL_00e7:
							break;
						}
						break;
					}
				}
			}
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			try
			{
				PeImage @class = PeImportReader.smethod_13(fileStream, string_0, bool_0: false, PeImageLayout.const_0);
				while (true)
				{
					int num4 = 238007801;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num4 ^ 0x866414E)) % 5)
						{
						case 2u:
							num4 = (((@class.method_6().method_1().method_12() & CoffCharacteristics.flag_12) == 0) ? 50222542 : 1402057418) ^ ((int)num3 * -1580869357);
							continue;
						case 1u:
							num4 = ((@class != null) ? (-2016711633) : (-1977205797)) ^ (int)(num3 * 1911030097);
							continue;
						case 0u:
							break;
						default:
						{
							try
							{
								smethod_261(@class, mainForm);
							}
							catch
							{
							}
							int index = mainForm.moduleGrid.Rows.Add(bool_0, Path.GetFileName(string_0));
							MainForm.ModuleRow class2 = new MainForm.ModuleRow(class16_0);
							SetModulePath(class2, string_0);
							MainForm.ModuleRow class3 = class2;
							while (true)
							{
								int num5 = 1051019898;
								while (true)
								{
									switch ((num3 = (uint)(num5 ^ 0x866414E)) % 7)
									{
									case 6u:
									ApplicationSettings.Current.Modules.Add(class3.Entry);
										num5 = (int)(num3 * 215100400) ^ -1017146116;
										continue;
									case 4u:
										mainForm.moduleGrid.Rows[index].Cells[1].ToolTipText = string_0;
										num5 = ((int)num3 * -2092943264) ^ 0x6D42C324;
										continue;
									case 2u:
										mainForm.moduleGrid.Rows[index].Cells[2].ToolTipText = "Advanced Options";
										num5 = (int)(num3 * 1574833161) ^ -1295596495;
										continue;
									case 1u:
										mainForm.moduleGrid.Rows[index].Tag = class3;
										num5 = ((int)num3 * -582582098) ^ -1659388458;
										continue;
									case 0u:
										num5 = ((class16_0 != null) ? 624043475 : 1252711972) ^ ((int)num3 * -1268485357);
										continue;
									default:
										return;
									case 5u:
										break;
									case 3u:
										return;
									}
									break;
								}
							}
						}
						case 4u:
							throw new Exception();
						}
						break;
					}
				}
			}
			finally
			{
				if (fileStream != null)
				{
					while (true)
					{
						IL_035b:
						int num6 = 1354921154;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)(num6 ^ 0x866414E)) % 3)
							{
							case 1u:
								goto IL_0329;
							default:
								goto end_IL_033d;
							case 0u:
								break;
							case 2u:
								goto end_IL_033d;
							}
							goto IL_035b;
							IL_0329:
							((IDisposable)fileStream).Dispose();
							num6 = ((int)num3 * -1141373183) ^ -1625511716;
							continue;
							end_IL_033d:
							break;
						}
						break;
					}
				}
			}
		}
		catch (Exception)
		{
			if (!bool_1)
			{
				return;
			}
			while (true)
			{
				int num7 = 2073976462;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num7 ^ 0x866414E)) % 3)
					{
					case 1u:
						goto IL_036b;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_036b:
					MessageBox.Show(mainForm, UiText.Format("Message.InvalidDll", Path.GetFileName(string_0)), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					num7 = (int)((num3 * 1653663462) ^ 0xFD3EC92);
				}
			}
		}
	}

	internal static void smethod_351(PeImage class154_0, string string_0, MainForm mainForm)
	{
		if (!string_0.StartsWith("d3dx9_", StringComparison.OrdinalIgnoreCase))
		{
			goto IL_0013;
		}
		goto IL_005b;
		IL_0013:
		int num = 27987631;
		goto IL_0035;
		IL_0035:
		bool flag = default(bool);
		string text = default(string);
		while (true)
		{
			uint num2;
			int num5;
			switch ((num2 = (uint)(num ^ 0x1D1C86DA)) % 5)
			{
			case 2u:
				break;
			case 1u:
				flag = false;
				if (!string.IsNullOrEmpty(text))
				{
					num = (int)(num2 * 1832645345) ^ -489196750;
					continue;
				}
				goto IL_01af;
			case 0u:
				goto IL_005b;
			default:
			{
				FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
				try
				{
					PeImage @class = PeImportReader.smethod_13(fileStream, text, bool_0: false, PeImageLayout.const_0);
					if (@class != null)
					{
						while (true)
						{
							IL_00e5:
							int num3 = 1351701593;
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x1D1C86DA)) % 4)
								{
								case 3u:
									num3 = ((smethod_19(@class) == smethod_19(class154_0)) ? 1380639935 : 1780575410) ^ (int)(num2 * 1533017144);
									continue;
								case 0u:
									flag = true;
									num3 = (int)(num2 * 1607094741) ^ -1289095721;
									continue;
								default:
									goto end_IL_00c3;
								case 2u:
									break;
								case 1u:
									goto end_IL_00c3;
								}
								goto IL_00e5;
								continue;
								end_IL_00c3:
								break;
							}
							break;
						}
					}
				}
				catch
				{
				}
				finally
				{
					if (fileStream != null)
					{
						while (true)
						{
							IL_0128:
							int num4 = 1346330096;
							while (true)
							{
								switch ((num2 = (uint)(num4 ^ 0x1D1C86DA)) % 3)
								{
								case 1u:
									goto IL_00f6;
								default:
									goto end_IL_010a;
								case 2u:
									break;
								case 0u:
									goto end_IL_010a;
								}
								goto IL_0128;
								IL_00f6:
								((IDisposable)fileStream).Dispose();
								num4 = ((int)num2 * -1449903721) ^ -1939687126;
								continue;
								end_IL_010a:
								break;
							}
							break;
						}
					}
				}
				if (!flag)
				{
					goto IL_0142;
				}
				goto IL_01af;
			}
			case 4u:
				return;
				IL_017d:
				while (true)
				{
					switch ((num2 = (uint)(num5 ^ 0x1D1C86DA)) % 5)
					{
					case 3u:
						break;
					case 2u:
					{
						DependencyInstallerForm form = new DependencyInstallerForm();
						smethod_29(form, "https://www.microsoft.com/download/details.aspx?id=35", null, "dxwebsetup.exe");
						form.ShowDialog();
						num5 = ((int)num2 * -1141238744) ^ -883323518;
						continue;
					}
					default:
						return;
					case 4u:
						goto IL_01af;
					case 0u:
						return;
					case 1u:
						return;
					}
					break;
				}
				goto IL_0142;
				IL_0142:
				num5 = 1385465660;
				goto IL_017d;
				IL_01af:
				num5 = ((!smethod_337(mainForm, class154_0.method_2(), string_0, text, bool_0: false, "DirectX 9 Runtime")) ? 48219170 : 313244286);
				goto IL_017d;
			}
			break;
		}
		goto IL_0013;
		IL_005b:
		text = smethod_353(class154_0, string_0);
		num = 1524527465;
		goto IL_0035;
	}

	internal static string smethod_353(PeImage class154_0, string string_0)
	{
		DependencySearchFlags @enum = DependencySearchFlags.flag_2;
		while (true)
		{
			int num = 1175017275;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6D4493FF)) % 5)
				{
				case 4u:
					num = ((!smethod_19(class154_0)) ? (-1419343748) : (-1837335309)) ^ ((int)num2 * -1788736988);
					continue;
				case 2u:
					num = (PlatformInfo.bool_0 ? 655891556 : 538708284) ^ ((int)num2 * -1864979649);
					continue;
				case 0u:
					@enum |= DependencySearchFlags.flag_4;
					num = ((int)num2 * -1830141192) ^ 0x612BCD80;
					continue;
				case 3u:
					break;
				default:
					return smethod_440(string_0, class154_0.method_0(), Path.GetDirectoryName(class154_0.method_0()), @enum, 0, NativeTypes.intptr_0);
				}
				break;
			}
		}
	}

	internal static ExportDirectory smethod_355(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[0];
		long num3 = default(long);
		while (true)
		{
			int num = -274187130;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -120413867)) % 11)
				{
				case 8u:
					num = ((@class.method_2() != 0) ? (-806693079) : (-187132842)) ^ ((int)num2 * -470844222);
					continue;
				case 7u:
					num = ((!class5_0.imethod_0(num3)) ? (-861703003) : (-1435815887)) ^ ((int)num2 * -1802387263);
					continue;
				case 4u:
					num3 = smethod_135(class154_0, @class.method_0());
					num = ((num3 == -1L) ? (-337136209) : (-734873377));
					continue;
				case 3u:
					num = ((@class.method_0() == 0) ? 2102982174 : 401629721) ^ (int)(num2 * 864765072);
					continue;
				case 1u:
					smethod_157(class5_0, num3);
					num = -1390291925;
					continue;
				case 0u:
					num = (class5_0.imethod_0(num3 + @class.method_2()) ? (-440098115) : (-354068212));
					continue;
				case 5u:
					break;
				case 2u:
					return null;
				case 6u:
					return null;
				default:
					return new ExportDirectory(class5_0, class154_0, @class);
				case 10u:
					return null;
				}
				break;
			}
		}
	}

	internal static PeImage smethod_356(byte[] byte_0, PeImageLayout enum39_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(byte_0, 0, byte_0.Length);
		memoryStream.Position = 0L;
		return PeImageReader.smethod_4(memoryStream, bool_0: true, enum39_0);
	}

	internal static void smethod_357(NativeLoaderHooks gclass3_0)
	{
		ProcessModuleInfo obj = smethod_42(gclass3_0.method_19())["ntdll.dll"] ?? throw new FileNotFoundException("Unable to find ntdll.dll in the specified process.");
		PeSectionHeader gClass = smethod_215(obj).method_8().FirstOrDefault(NativeLoaderHooks.Class81._003C_003E9.method_0);
		if (gClass == null)
		{
			throw new InvalidOperationException("Unable to find .text section in ntdll.dll.");
		}
		IntPtr intPtr = obj.method_0().smethod_9(gClass.method_4());
		int num3 = default(int);
		int num6 = default(int);
		byte[] array = default(byte[]);
		int num9 = default(int);
		int num7 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num = 851219918;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3490C0D2)) % 55)
				{
				case 54u:
					gclass3_0.method_25(intPtr.smethod_8(num3 - 11));
					num = (int)((num2 * 227321854) ^ 0x7A574A73);
					continue;
				case 52u:
					num = (((num6 = smethod_378(array, "3öF;Æt8", 0)) != -1) ? 1923214703 : 2092156269);
					continue;
				case 51u:
					num = ((!PlatformInfo.bool_5) ? 936006074 : 837290064);
					continue;
				case 50u:
					num = (PlatformInfo.bool_10 ? 434688131 : 1389502858) ^ (int)(num2 * 1527842253);
					continue;
				case 49u:
					gclass3_0.method_25(intPtr.smethod_8(num3 - 11));
					num = ((int)num2 * -349505268) ^ 0x51C15C8A;
					continue;
				case 48u:
					num9 = smethod_378(array, "\u008BÎ3uü\u0083á\u001F", 0);
					num = (int)((num2 * 1889273624) ^ 0x729A14E9);
					continue;
				case 47u:
					num7 = smethod_419(array, "ÿv ÿv\u0018h\0\0\0\0è", "xxxxxxx????x", 0);
					num = 1071567378;
					continue;
				case 46u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num3 + 34));
					num = ((int)num2 * -64888673) ^ -1370265380;
					continue;
				case 45u:
					gclass3_0.method_25(intPtr.smethod_8(num7));
					num = ((int)num2 * -1726273584) ^ -2034604416;
					continue;
				case 44u:
					gclass3_0.method_29(intPtr.smethod_8(num6 - 28));
					num = (int)(num2 * 356566862) ^ -1601499525;
					continue;
				case 43u:
					num3 = smethod_378(array, "\u0083}\b\0\u008B5", 0);
					num = 1373680172;
					continue;
				case 41u:
					num = ((num3 != -1) ? 1835698538 : 564180149) ^ ((int)num2 * -1572475500);
					continue;
				case 40u:
					num3 = smethod_378(array, "SVW\u008BÚ\u008BùP", 0);
					num = ((num3 != -1) ? (-1129492958) : (-2074163028)) ^ (int)(num2 * 764350436);
					continue;
				case 39u:
					num = ((num6 == -1) ? 2126440277 : 1267128781) ^ (int)(num2 * 1385862655);
					continue;
				case 38u:
					array = gclass3_0.method_10<byte>(intPtr, (int)gClass.method_2());
					num = (int)((num2 * 1127789992) ^ 0x6C426FFF);
					continue;
				case 37u:
					num = ((num4 != -1) ? (-1054690571) : (-1526407274)) ^ ((int)num2 * -1011254638);
					continue;
				case 36u:
					gclass3_0.method_25(intPtr.smethod_8(num9 - 33));
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num6 - 27));
					num = (int)((num2 * 1137226933) ^ 0x167A4F5C);
					continue;
				case 35u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num5 + 7));
					num = ((int)num2 * -1760841405) ^ 0x6DC339A9;
					continue;
				case 34u:
					num5 = smethod_419(array, "ÿv ÿv\u0018h\0\0\0\0è", "xxxxxxx????x", 0);
					num = ((num5 == -1) ? 1481446509 : 1615714529);
					continue;
				case 33u:
					num4 = smethod_378(array, "u$\u0085öu\b", 0);
					num = ((num4 != -1) ? 2069075449 : 1481446509);
					continue;
				case 32u:
					num7 = smethod_378(array, "\u008BÿU\u008BìVj\u0001", 0);
					num = ((num7 != -1) ? (-1519574589) : (-1391973668)) ^ (int)(num2 * 1660718010);
					continue;
				case 31u:
					num4 = smethod_378(array, "SVW\u008DEø\u008Bú", 0);
					num = (int)(num2 * 524217384) ^ -1186105186;
					continue;
				case 30u:
					num = ((!PlatformInfo.bool_6) ? 120978087 : 1538451030);
					continue;
				case 28u:
					gclass3_0.method_25(intPtr.smethod_8(num8));
					num = ((int)num2 * -228798737) ^ 0x65F32C8C;
					continue;
				case 27u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num6 + 76));
					num = (int)(num2 * 62208088) ^ -341760323;
					continue;
				case 26u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num3 + 35));
					num = 1179705983;
					continue;
				case 24u:
					num = ((num7 != -1) ? (-1479015943) : (-9594515)) ^ (int)(num2 * 73059868);
					continue;
				case 23u:
					num6 = smethod_378(array, "u$\u0085öu\b", 0);
					num = ((num6 != -1) ? 1954067657 : 1481446509);
					continue;
				case 22u:
					num = (PlatformInfo.bool_1 ? 1419513255 : 814239343);
					continue;
				case 21u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num3 + 29));
					num = ((int)num2 * -239791782) ^ 0x659DF115;
					continue;
				case 20u:
					num8 = smethod_378(array, "\u008BÿU\u008BìQQSW\u008B}\b\u008DEø", 0);
					num = ((int)num2 * -1752328663) ^ -1119223462;
					continue;
				case 19u:
					num = (PlatformInfo.bool_7 ? (-479868745) : (-897251406)) ^ (int)(num2 * 1135005401);
					continue;
				case 18u:
					num4 = smethod_378(array, "3öF;Æ", 0);
					num = ((num4 != -1) ? 280915289 : 1766567068);
					continue;
				case 16u:
					num = ((num8 != -1) ? (-1838771688) : (-532949945)) ^ (int)(num2 * 1773374985);
					continue;
				case 15u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num7 + 7));
					num = ((int)num2 * -715443621) ^ -2106495708;
					continue;
				case 14u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num8 + 38));
					num = (int)(num2 * 2066392950) ^ -308319497;
					continue;
				case 13u:
					num = ((!smethod_427(gclass3_0.method_19())) ? 1928972409 : 410146951) ^ (int)(num2 * 223421028);
					continue;
				case 11u:
					gclass3_0.method_25(intPtr.smethod_8(num6 - 11));
					num = ((int)num2 * -1495254023) ^ -1532682233;
					continue;
				case 10u:
					num6 = smethod_378(array, "\u008DEð\u0089UøP\u008DUô", 0);
					num = ((int)num2 * -1280152801) ^ -745343995;
					continue;
				case 9u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num4 - 27));
					num = (int)((num2 * 938562021) ^ 0x36CE94CB);
					continue;
				case 8u:
					gclass3_0.method_25(intPtr.smethod_8(num4 - 8));
					num = ((int)num2 * -1977044827) ^ 0x41974115;
					continue;
				case 7u:
					num3 = smethod_378(array, "\u008DEô\u0089UøP\u008DUü", 0);
					num = ((num3 != -1) ? 1485944174 : 1179705983);
					continue;
				case 6u:
					num = ((num9 != -1) ? (-582515898) : (-966619148)) ^ (int)(num2 * 710772147);
					continue;
				case 5u:
					num = (PlatformInfo.bool_0 ? 2131262248 : 1027690505) ^ (int)(num2 * 616521830);
					continue;
				case 4u:
					num = ((!PlatformInfo.bool_3) ? 1481446509 : 837958612);
					continue;
				case 3u:
					num = (PlatformInfo.bool_9 ? 1192923823 : 1366852313);
					continue;
				case 1u:
					gclass3_0.method_25(intPtr.smethod_8(num5));
					num = ((int)num2 * -1547794217) ^ -636468245;
					continue;
				case 0u:
					num5 = smethod_378(array, "\u008BÿU\u008BìVh", 0);
					num = ((num5 != -1) ? (-1268597137) : (-1428386662)) ^ ((int)num2 * -551098937);
					continue;
				default:
					return;
				case 42u:
					break;
				case 2u:
					return;
				case 12u:
					return;
				case 17u:
					gclass3_0.method_29(intPtr.smethod_8(num4 - 28));
					return;
				case 25u:
					return;
				case 29u:
					gclass3_0.method_29(intPtr.smethod_8(num3 - 18));
					return;
				case 53u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_368(ManualMapInjector.Class172 class172_0)
	{
		if (class172_0.method_0() != null)
		{
			goto IL_006f;
		}
		goto IL_00ac;
		IL_006f:
		int num = 1500114108;
		goto IL_0074;
		IL_0074:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x3AB426BB)) % 6)
			{
			case 5u:
				class172_0.method_11(NativeTypes.intptr_0);
				num = ((int)num2 * -564228611) ^ -1326974839;
				continue;
			case 2u:
				ReleaseActCtx(class172_0.method_10());
				num = ((int)num2 * -2033650173) ^ 0x28CE4D76;
				continue;
			case 1u:
				class172_0.method_0().System_002EIDisposable_002EDispose();
				class172_0.method_1(null);
				num = (int)((num2 * 2020730459) ^ 0x18DAAB98);
				continue;
			case 0u:
				break;
			default:
				return;
			case 4u:
				goto IL_00ac;
			case 3u:
				return;
			}
			break;
		}
		goto IL_006f;
		IL_00ac:
		num = ((!(class172_0.method_10() != NativeTypes.intptr_0)) ? 767526302 : 808903105);
		goto IL_0074;
	}

	internal static void smethod_376(PeScrambler gclass4_0)
	{
		List<PeSectionHeader> list = gclass4_0.class154_0.method_8();
		PeSectionHeader gClass = default(PeSectionHeader);
		int num3 = default(int);
		while (true)
		{
			int num = 1558284299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5DFEA358)) % 11)
				{
				case 10u:
					gClass.method_3(list[num3 + 1].method_4() - gClass.method_4());
					num = (int)(num2 * 2113012642) ^ -1591758169;
					continue;
				case 9u:
				{
					PeSectionHeader gClass2 = gClass;
					uint uint_ = gClass.method_2();
					uint uint_2 = gclass4_0.class154_0.method_6().method_3().imethod_18();
					gClass2.method_3(smethod_201(uint_2, uint_));
					num = ((int)num2 * -1697498223) ^ 0x754DC144;
					continue;
				}
				case 8u:
					num3++;
					num = 1843147128;
					continue;
				case 6u:
					num = ((gClass.method_4() + gClass.method_2() > list[num3 + 1].method_4()) ? (-1095057371) : (-1169030035)) ^ (int)(num2 * 1523433520);
					continue;
				case 4u:
					num = ((num3 >= list.Count) ? 2005377368 : 134943772);
					continue;
				case 3u:
					num = (int)(num2 * 584251732) ^ -1588287768;
					continue;
				case 2u:
					gClass = list[num3];
					num = 591226640;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1189916463) ^ -1482094641;
					continue;
				case 0u:
					num = ((num3 >= list.Count - 1) ? (-308845427) : (-686485939)) ^ ((int)num2 * -334268812);
					continue;
				default:
					return;
				case 5u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_382(PeScrambler gclass4_0)
	{
		smethod_437(gclass4_0, 2L, 58L);
		gclass4_0.class154_0.method_6().method_1().method_7(gclass4_0.random_0.smethod_0());
		gclass4_0.class154_0.method_6().method_1().method_9(gclass4_0.random_0.smethod_0());
		uint[] array = default(uint[]);
		uint num3 = default(uint);
		int num4 = default(int);
		while (true)
		{
			int num = -1299007203;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1434317088)) % 31)
				{
				case 30u:
					gclass4_0.class154_0.method_6().method_3().imethod_25(gclass4_0.random_0.smethod_2());
					gclass4_0.class154_0.method_6().method_3().imethod_6(gclass4_0.random_0.smethod_0());
					gclass4_0.class154_0.method_6().method_3().imethod_8(gclass4_0.random_0.smethod_0());
					num = (int)(num2 * 1083667578) ^ -295606493;
					continue;
				case 29u:
					num = ((gclass4_0.class154_0.method_6().method_1().method_10() == 240) ? (-1241739389) : (-75834312)) ^ (int)(num2 * 607226421);
					continue;
				case 28u:
					gclass4_0.class154_0.method_6().method_3().imethod_23(gclass4_0.random_0.smethod_2());
					num = ((int)num2 * -790302517) ^ -1202805667;
					continue;
				case 27u:
					gclass4_0.class154_0.method_6().method_3().imethod_38(gclass4_0.random_0.smethod_0());
					num = (int)(num2 * 1545773803) ^ -1210247788;
					continue;
				case 26u:
					array = new uint[5] { 1u, 2u, 4u, 8u, 16384u };
					num = -312329292;
					continue;
				case 25u:
				{
					CoffHeader @class = gclass4_0.class154_0.method_6().method_1();
					@class.method_13(@class.method_12() | (CoffCharacteristics.flag_4 | CoffCharacteristics.flag_6 | CoffCharacteristics.flag_14));
					gclass4_0.class154_0.method_6().method_3().imethod_2(0);
					num = ((int)num2 * -1848355930) ^ 0x1585490F;
					continue;
				}
				case 24u:
					num = (smethod_19(gclass4_0.class154_0) ? (-911722814) : (-348777830)) ^ (int)(num2 * 955067557);
					continue;
				case 22u:
					num3 = array[gclass4_0.random_0.Next(array.Length)];
					num = -199494738;
					continue;
				case 21u:
					gclass4_0.class154_0.method_6().method_3().imethod_40(gclass4_0.random_0.smethod_0());
					num = ((int)num2 * -1053912724) ^ 0x6B6DCF89;
					continue;
				case 20u:
					gclass4_0.class154_0.method_6().method_3().imethod_10(gclass4_0.random_0.smethod_0());
					gclass4_0.class154_0.method_6().method_3().imethod_14(gclass4_0.random_0.smethod_0());
					num = ((int)num2 * -235018941) ^ 0x5E783B8E;
					continue;
				case 19u:
					gclass4_0.class154_0.method_6().method_3().imethod_48(gclass4_0.random_0.smethod_1(10u, 17u));
					num = ((int)num2 * -878366889) ^ -665122718;
					continue;
				case 18u:
					num = (smethod_235(gclass4_0) ? (-1437512395) : (-418544195));
					continue;
				case 17u:
					gclass4_0.class154_0.method_6().method_3().imethod_46(gclass4_0.random_0.smethod_0());
					num = (int)((num2 * 735301873) ^ 0x66D7FDCA);
					continue;
				case 15u:
					num4 = 0;
					num = ((int)num2 * -521476824) ^ -1048210322;
					continue;
				case 14u:
					gclass4_0.class154_0.method_6().method_3().imethod_4(0);
					num = ((int)num2 * -1337422160) ^ -1693273374;
					continue;
				case 13u:
					gclass4_0.class154_0.method_6().method_3().imethod_44(gclass4_0.random_0.smethod_0());
					num = (int)((num2 * 23268398) ^ 0x49843285);
					continue;
				case 12u:
					gclass4_0.class154_0.method_6().method_3().imethod_16(gclass4_0.random_0.smethod_0());
					num = (int)((num2 * 374712267) ^ 0x336DCCD8);
					continue;
				case 11u:
					num4++;
					num = -939397810;
					continue;
				case 10u:
					num = ((gclass4_0.class154_0.method_6().method_1().method_10() != 224) ? 709855760 : 1856947121) ^ ((int)num2 * -957139191);
					continue;
				case 9u:
					gclass4_0.class154_0.method_6().method_3().imethod_48(15u);
					num = ((int)num2 * -1232029053) ^ -603153393;
					continue;
				case 8u:
					num4--;
					num = -1312661524;
					continue;
				case 7u:
					num = ((num4 >= gclass4_0.random_0.Next(1, array.Length)) ? (-173224425) : (-1214782869));
					continue;
				case 6u:
					num = ((((uint)gclass4_0.class154_0.method_6().method_3().imethod_35() & num3) == num3) ? (-911423502) : (-305799945)) ^ (int)(num2 * 819580154);
					continue;
				case 5u:
				{
					IPeOptionalHeader @interface = gclass4_0.class154_0.method_6().method_3();
					@interface.imethod_36((DllCharacteristics)((int)@interface.imethod_35() | (int)num3));
					num = ((int)num2 * -1970128942) ^ -178414966;
					continue;
				}
				case 4u:
					num = (((gclass4_0.class154_0.method_6().method_1().method_12() & CoffCharacteristics.flag_12) == CoffCharacteristics.flag_12) ? 592724392 : 2073821414) ^ (int)(num2 * 1302161583);
					continue;
				case 3u:
					num = (smethod_19(gclass4_0.class154_0) ? (-418544195) : (-499125519));
					continue;
				case 2u:
					num = (int)(num2 * 981966488) ^ -1525064419;
					continue;
				case 1u:
					gclass4_0.class154_0.method_6().method_3().imethod_42(gclass4_0.random_0.smethod_0());
					num = (int)((num2 * 323379280) ^ 0x78367205);
					continue;
				case 0u:
					gclass4_0.class154_0.method_6().method_1().method_5(gclass4_0.random_0.smethod_0());
					num = (int)((num2 * 1255285139) ^ 0x3036C4DE);
					continue;
				default:
					return;
				case 23u:
					break;
				case 16u:
					return;
				}
				break;
			}
		}
	}

	internal static ResourceDirectory smethod_389(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[2];
		if (@class.method_0() != 0)
		{
			long num3 = default(long);
			while (true)
			{
				int num = 859986465;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x37794B80)) % 9)
					{
					case 8u:
						break;
					case 7u:
						num = ((@class.method_2() != 0) ? 48567019 : 710211152) ^ ((int)num2 * -164523125);
						continue;
					case 3u:
						goto IL_007e;
					case 0u:
						num = ((!class5_0.imethod_0(num3)) ? 1263054894 : 1881548291) ^ ((int)num2 * -402477833);
						continue;
					case 5u:
						goto end_IL_00c8;
					default:
						return new ResourceDirectory(class5_0, num3, @class.method_2());
					case 4u:
						return null;
					case 6u:
						return null;
					case 2u:
						goto end_IL_00fe;
					}
					num3 = smethod_135(class154_0, @class.method_0());
					num = ((num3 != -1L) ? 981242901 : 21259501);
					continue;
					IL_007e:
					num = (class5_0.imethod_0(num3) ? 78853978 : 371388783);
					continue;
					end_IL_00c8:
					break;
				}
				continue;
				end_IL_00fe:
				break;
			}
		}
		return null;
	}

	internal static bool smethod_398(BoundsCheckedBinaryReader class5_0, uint uint_0, out Pe64OptionalHeader class163_0)
	{
		class163_0 = null;
		const uint fixedHeaderSize = 112;
		long start = class5_0.BaseStream.Position;
		if (uint_0 < fixedHeaderSize || start < 0 || start + uint_0 > class5_0.BaseStream.Length)
		{
			return false;
		}

		var header = new Pe64OptionalHeader();
		header.vmethod_0(class5_0.ReadUInt16());
		if (header.imethod_0() != 0x020B)
		{
			return false;
		}

		header.imethod_2(class5_0.ReadByte());
		header.imethod_4(class5_0.ReadByte());
		header.imethod_6(class5_0.ReadUInt32());
		header.imethod_8(class5_0.ReadUInt32());
		header.imethod_10(class5_0.ReadUInt32());
		header.imethod_12(class5_0.ReadUInt32());
		header.imethod_14(class5_0.ReadUInt32());
		header.vmethod_1(class5_0.ReadUInt64());
		header.vmethod_2(class5_0.ReadUInt32());
		header.vmethod_3(class5_0.ReadUInt32());
		header.vmethod_4(class5_0.ReadUInt16());
		header.vmethod_5(class5_0.ReadUInt16());
		header.imethod_23(class5_0.ReadUInt16());
		header.imethod_25(class5_0.ReadUInt16());
		header.vmethod_6(class5_0.ReadUInt16());
		header.vmethod_7(class5_0.ReadUInt16());
		header.vmethod_8(class5_0.ReadUInt32());
		header.imethod_30(class5_0.ReadUInt32());
		header.vmethod_9(class5_0.ReadUInt32());
		header.imethod_33(class5_0.ReadUInt32());
		header.vmethod_10((Subsystem)class5_0.ReadUInt16());
		header.imethod_36((DllCharacteristics)class5_0.ReadUInt16());
		header.imethod_38(class5_0.ReadUInt64());
		header.imethod_40(class5_0.ReadUInt64());
		header.imethod_42(class5_0.ReadUInt64());
		header.imethod_44(class5_0.ReadUInt64());
		header.imethod_46(class5_0.ReadUInt32());
		header.imethod_48(class5_0.ReadUInt32());

		DataDirectory[] directories = header.imethod_49();
		uint availableDirectoryCount = (uint_0 - fixedHeaderSize) / 8U;
		int directoryCount = (int)Math.Min((uint)directories.Length, Math.Min(header.imethod_47(), availableDirectoryCount));
		for (int index = 0; index < directories.Length; index++)
		{
			directories[index] = index < directoryCount ? new DataDirectory(class5_0) : new DataDirectory();
		}

		class5_0.BaseStream.Position = start + uint_0;
		class163_0 = header;
		return true;
	}

	internal static IEnumerable<string> smethod_412(string string_0, IEnumerable<ImportedSymbol> ienumerable_0, ImportDirectory class148_0)
	{
		return new ImportDirectory.Class150(-2)
		{
			string_2 = string_0,
			ienumerable_1 = ienumerable_0
		};
	}

	internal static void smethod_415(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_18() == null)
		{
			goto IL_0022;
		}
		goto IL_0119;
		IL_0022:
		int num = 896468174;
		goto IL_00d0;
		IL_00d0:
		DataDirectory @class = default(DataDirectory);
		long long_ = default(long);
		long num3 = default(long);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x34491F95)) % 10)
			{
			case 9u:
				break;
			case 5u:
				@class.method_3(0u);
				num = ((int)num2 * -612143623) ^ 0x15C3A58C;
				continue;
			case 4u:
				smethod_437(gclass4_0, long_, 28L);
				num = (int)(num2 * 207459978) ^ -1819665512;
				continue;
			case 2u:
				smethod_437(gclass4_0, num3, gclass4_0.class154_0.method_18().method_5());
				num = 467334697;
				continue;
			case 1u:
				@class.method_1(0u);
				num = (int)(num2 * 2090806702) ^ -865100096;
				continue;
			case 0u:
				@class = gclass4_0.class154_0.method_6().method_3().imethod_49()[6];
				long_ = smethod_135(gclass4_0.class154_0, @class.method_0());
				num = ((int)num2 * -1841234019) ^ 0x7DC134F9;
				continue;
			default:
				return;
			case 8u:
				goto IL_0119;
			case 3u:
				return;
			case 6u:
				return;
			case 7u:
				return;
			}
			break;
		}
		goto IL_0022;
		IL_0119:
		num3 = smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_18().method_7());
		num = ((num3 == -1L) ? 1506590824 : 1465303589);
		goto IL_00d0;
	}

	internal static void smethod_420(List<PeScrambler.Class132> list_0, PeScrambler gclass4_0)
	{
		IPeOptionalHeader @interface = gclass4_0.class154_0.method_6().method_3();
		PeScrambler.Class132 class2 = default(PeScrambler.Class132);
		int num4 = default(int);
		BinaryWriter binaryWriter = default(BinaryWriter);
		byte[] buffer2 = default(byte[]);
		DataDirectory @class = default(DataDirectory);
		PeImage class154_ = default(PeImage);
		long long_2 = default(long);
		byte[] buffer = default(byte[]);
		DataDirectory[] array = default(DataDirectory[]);
		int num3 = default(int);
		PeScrambler.Class132 class3 = default(PeScrambler.Class132);
		while (true)
		{
			int num = -1980561080;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -774756408)) % 30)
				{
				case 29u:
					class2 = list_0[num4];
					num = ((class2.method_5().method_6() != 0) ? (-1843705321) : (-1038856157));
					continue;
				case 28u:
					num = ((@interface.imethod_11() == 0) ? (-1839953667) : (-1237628823));
					continue;
				case 27u:
					binaryWriter.Write(buffer2);
					num = (int)((num2 * 816257153) ^ 0x61C5CCC0);
					continue;
				case 26u:
					num = ((@class.method_0() == 0) ? (-1400829966) : (-1558057830)) ^ (int)(num2 * 2021526257);
					continue;
				case 25u:
					binaryWriter = new BinaryWriter(gclass4_0.class154_0.method_28());
					num4 = list_0.Count - 1;
					num = (int)(num2 * 1958191617) ^ -909672725;
					continue;
				case 23u:
					@interface.imethod_12(smethod_33(list_0, @interface.imethod_11()));
					num = ((int)num2 * -1592269532) ^ 0x24713F59;
					continue;
				case 22u:
				{
					long long_ = class2.method_5().method_6();
					buffer2 = smethod_8(long_, class154_, long_2);
					gclass4_0.class154_0.method_28().Position = class2.method_5().method_8();
					buffer = new byte[class2.method_5().method_6()];
					num = ((int)num2 * -493662001) ^ -441296928;
					continue;
				}
				case 21u:
					@class = array[num3];
					num = -925901808;
					continue;
				case 20u:
					@interface.imethod_16(smethod_33(list_0, @interface.imethod_15()));
					num = (int)(num2 * 1167791939) ^ -1338095310;
					continue;
				case 19u:
					binaryWriter.Write(buffer);
					num = (int)(num2 * 519586440) ^ -689152113;
					continue;
				case 18u:
					num = ((int)num2 * -496881695) ^ -894225868;
					continue;
				case 16u:
					array = @interface.imethod_49();
					num3 = 0;
					num = ((int)num2 * -139698581) ^ -632302168;
					continue;
				case 15u:
					class154_ = gclass4_0.class154_0;
					num = ((int)num2 * -1147650423) ^ -1458182813;
					continue;
				case 14u:
					long_2 = class2.method_5().method_8();
					num = (int)(num2 * 150433868) ^ -602061966;
					continue;
				case 13u:
				{
					uint uint_ = class3.method_3().method_4() + class3.method_3().method_2();
					uint uint_2 = @interface.imethod_18();
					@interface.imethod_30(smethod_201(uint_2, uint_));
					num = ((int)num2 * -857950790) ^ 0x3145DB76;
					continue;
				}
				case 12u:
					gclass4_0.random_0.NextBytes(buffer);
					num = ((int)num2 * -1806807504) ^ 0x892CF57;
					continue;
				case 11u:
					num = ((@interface.imethod_15() == 0) ? (-899804182) : (-851191936));
					continue;
				case 10u:
					num = ((@interface.imethod_13() != 0) ? (-496216951) : (-565610941)) ^ (int)(num2 * 1980255938);
					continue;
				case 9u:
					class3 = list_0.Last();
					num = -997280841;
					continue;
				case 8u:
					@class.method_1(smethod_33(list_0, @class.method_0()));
					num = ((int)num2 * -682934549) ^ -1053842044;
					continue;
				case 7u:
					@interface.imethod_14(smethod_33(list_0, @interface.imethod_13()));
					num = (int)(num2 * 1260050670) ^ -30092499;
					continue;
				case 6u:
					num = (int)(num2 * 1581547319) ^ -1417852195;
					continue;
				case 5u:
					gclass4_0.class154_0.method_28().Position = class2.method_3().method_8() + class2.method_0();
					num = ((int)num2 * -241555325) ^ -262827626;
					continue;
				case 4u:
					gclass4_0.class154_0.method_28().SetLength(class3.method_3().method_8() + class3.method_3().method_6());
					num = ((int)num2 * -36291185) ^ -1042720319;
					continue;
				case 3u:
					num = ((num4 < 0) ? (-1707549190) : (-1507950011));
					continue;
				case 2u:
					num = ((num3 >= array.Length) ? (-1225408072) : (-821638215));
					continue;
				case 1u:
					num4--;
					num = -1164100053;
					continue;
				case 0u:
					num3++;
					num = -812829700;
					continue;
				case 17u:
					break;
				default:
					gclass4_0.class154_0.method_9(list_0.Select(PeScrambler.Class135._003C_003E9.method_1).ToList());
					return;
				}
				break;
			}
		}
	}
}
