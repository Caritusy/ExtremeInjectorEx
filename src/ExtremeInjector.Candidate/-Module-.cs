using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;

internal class _003CModule_003E
{
	public struct Struct0
	{
		internal uint uint_0;

		internal void method_0()
		{
			uint_0 = 1024u;
		}

		internal uint method_1(Class0 class0_0)
		{
			uint num = (class0_0.uint_1 >> 11) * uint_0;
			while (true)
			{
				int num2 = -1482665512;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ -561030677)) % 14)
					{
					case 13u:
						class0_0.uint_0 = (class0_0.uint_0 << 8) | (byte)class0_0.stream_0.ReadByte();
						num2 = (int)(num3 * 782264802) ^ -670693456;
						continue;
					case 11u:
					{
						int num8;
						int num9;
						if (class0_0.uint_0 >= num)
						{
							num8 = -1278109904;
							num9 = -1278109904;
						}
						else
						{
							num8 = -1490340055;
							num9 = -1490340055;
						}
						num2 = num8 ^ (int)(num3 * 185027884);
						continue;
					}
					case 10u:
						class0_0.uint_0 -= num;
						num2 = ((int)num3 * -844632580) ^ -1057274537;
						continue;
					case 9u:
						class0_0.uint_1 <<= 8;
						num2 = ((int)num3 * -810143152) ^ -1946398797;
						continue;
					case 8u:
						uint_0 -= uint_0 >> 5;
						num2 = ((int)num3 * -286112980) ^ -1923396915;
						continue;
					case 7u:
						class0_0.uint_1 -= num;
						num2 = -1686703431;
						continue;
					case 6u:
						class0_0.uint_1 <<= 8;
						num2 = ((int)num3 * -1939396155) ^ -615803802;
						continue;
					case 5u:
					{
						int num6;
						int num7;
						if (class0_0.uint_1 >= 16777216)
						{
							num6 = -627254481;
							num7 = -627254481;
						}
						else
						{
							num6 = -230819871;
							num7 = -230819871;
						}
						num2 = num6 ^ (int)(num3 * 1589862973);
						continue;
					}
					case 4u:
					{
						int num4;
						int num5;
						if (class0_0.uint_1 >= 16777216)
						{
							num4 = -1465563911;
							num5 = -1465563911;
						}
						else
						{
							num4 = -1826388386;
							num5 = -1826388386;
						}
						num2 = num4 ^ (int)(num3 * 818304679);
						continue;
					}
					case 3u:
						class0_0.uint_0 = (class0_0.uint_0 << 8) | (byte)class0_0.stream_0.ReadByte();
						num2 = ((int)num3 * -83092176) ^ -438518859;
						continue;
					case 2u:
						class0_0.uint_1 = num;
						uint_0 += 2048 - uint_0 >> 5;
						num2 = ((int)num3 * -1855129892) ^ 0x4D022C98;
						continue;
					case 0u:
						break;
					case 1u:
						return 0u;
					default:
						return 1u;
					}
					break;
				}
			}
		}
	}

	public struct Struct1
	{
		internal readonly Struct0[] struct0_0;

		internal readonly int int_0;

		internal Struct1(int int_1)
		{
			int_0 = int_1;
			struct0_0 = new Struct0[1 << int_1];
		}

		internal void method_0()
		{
			uint num = 1u;
			while (true)
			{
				int num2;
				int num3;
				if (num >= 1 << int_0)
				{
					num2 = -165194433;
					num3 = -165194433;
				}
				else
				{
					num2 = -1045090369;
					num3 = -1045090369;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ -1595099347)) % 5)
					{
					case 4u:
						struct0_0[num].method_0();
						num2 = -170203815;
						continue;
					case 2u:
						num++;
						num2 = ((int)num4 * -2084685499) ^ 0x43B5B3E7;
						continue;
					case 0u:
						num2 = -1045090369;
						continue;
					default:
						return;
					case 1u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}

		internal uint method_1(Class0 class0_0)
		{
			uint num = 1u;
			int num2 = int_0;
			while (true)
			{
				int num3 = -864641978;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num3 ^ -2142626707)) % 6)
					{
					case 5u:
						num = (num << 1) + struct0_0[num].method_1(class0_0);
						num3 = -1933271591;
						continue;
					case 4u:
						num2--;
						num3 = (int)(num4 * 2076212624) ^ -922970573;
						continue;
					case 1u:
						num3 = ((int)num4 * -1851776481) ^ 0x1AB87446;
						continue;
					case 0u:
					{
						int num5;
						if (num2 > 0)
						{
							num3 = -1800143092;
							num5 = -1800143092;
						}
						else
						{
							num3 = -1122563594;
							num5 = -1122563594;
						}
						continue;
					}
					case 2u:
						break;
					default:
						return num - (uint)(1 << int_0);
					}
					break;
				}
			}
		}

		internal uint method_2(Class0 class0_0)
		{
			uint num = 1u;
			uint num2 = 0u;
			int num3 = 0;
			uint num7 = default(uint);
			while (true)
			{
				int num4;
				int num5;
				if (num3 < int_0)
				{
					num4 = -281944708;
					num5 = -281944708;
				}
				else
				{
					num4 = -420650930;
					num5 = -420650930;
				}
				while (true)
				{
					uint num6;
					switch ((num6 = (uint)(num4 ^ -662547698)) % 6)
					{
					case 5u:
						num += num7;
						num2 |= num7 << num3;
						num3++;
						num4 = (int)(num6 * 1830743773) ^ -401392596;
						continue;
					case 4u:
						num7 = struct0_0[num].method_1(class0_0);
						num4 = -1205533436;
						continue;
					case 3u:
						num4 = -281944708;
						continue;
					case 2u:
						num <<= 1;
						num4 = ((int)num6 * -1140198338) ^ -1129283723;
						continue;
					case 1u:
						break;
					default:
						return num2;
					}
					break;
				}
			}
		}

		internal static uint smethod_0(Struct0[] struct0_1, uint uint_0, Class0 class0_0, int int_1)
		{
			uint num = 1u;
			uint num2 = 0u;
			int num6 = default(int);
			uint num5 = default(uint);
			while (true)
			{
				int num3 = 1538976348;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num3 ^ 0x4AEB94BA)) % 8)
					{
					case 6u:
						num6 = 0;
						num3 = ((int)num4 * -490148988) ^ -1401186058;
						continue;
					case 5u:
						num += num5;
						num2 |= num5 << num6;
						num6++;
						num3 = (int)((num4 * 176167312) ^ 0x385DF35B);
						continue;
					case 4u:
						num3 = (int)((num4 * 299963937) ^ 0x49B19BDF);
						continue;
					case 3u:
						num <<= 1;
						num3 = (int)(num4 * 1066836187) ^ -1632868666;
						continue;
					case 1u:
					{
						int num7;
						if (num6 < int_1)
						{
							num3 = 1575767410;
							num7 = 1575767410;
						}
						else
						{
							num3 = 1058496680;
							num7 = 1058496680;
						}
						continue;
					}
					case 0u:
						num5 = struct0_1[uint_0 + num].method_1(class0_0);
						num3 = 817707265;
						continue;
					case 7u:
						break;
					default:
						return num2;
					}
					break;
				}
			}
		}
	}

	public class Class0
	{
		internal uint uint_0;

		internal uint uint_1;

		internal Stream stream_0;

		internal void method_0(Stream stream_1)
		{
			stream_0 = stream_1;
			int num3 = default(int);
			while (true)
			{
				int num = -1732760144;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -452011378)) % 8)
					{
					case 6u:
						uint_0 = 0u;
						num = ((int)num2 * -1282323443) ^ -766242148;
						continue;
					case 5u:
						num3 = 0;
						num = ((int)num2 * -644163719) ^ 0x1B6E5B69;
						continue;
					case 4u:
						uint_1 = uint.MaxValue;
						num = ((int)num2 * -487275483) ^ -1987477449;
						continue;
					case 3u:
					{
						int num4;
						if (num3 >= 5)
						{
							num = -1006976626;
							num4 = -1006976626;
						}
						else
						{
							num = -189035201;
							num4 = -189035201;
						}
						continue;
					}
					case 2u:
						num = (int)(num2 * 365611904) ^ -1412079539;
						continue;
					case 1u:
						uint_0 = (uint_0 << 8) | (byte)stream_0.ReadByte();
						num3++;
						num = -1467916467;
						continue;
					default:
						return;
					case 7u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}

		internal void method_1()
		{
			stream_0 = null;
		}

		internal void method_2()
		{
			while (true)
			{
				int num;
				int num2;
				if (uint_1 < 16777216)
				{
					num = -1765376218;
					num2 = -1765376218;
				}
				else
				{
					num = -1403435843;
					num2 = -1403435843;
				}
				while (true)
				{
					switch ((uint)(num ^ -526729413) % 4u)
					{
					case 3u:
						num = -1765376218;
						continue;
					case 1u:
						uint_0 = (uint_0 << 8) | (byte)stream_0.ReadByte();
						uint_1 <<= 8;
						num = -2077651469;
						continue;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}

		internal uint method_3(int int_0)
		{
			uint num = uint_1;
			int num7 = default(int);
			uint num4 = default(uint);
			uint num5 = default(uint);
			uint num6 = default(uint);
			while (true)
			{
				int num2 = 1037090477;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x23E679C0)) % 14)
					{
					case 13u:
					{
						int num10;
						if (num7 > 0)
						{
							num2 = 1127736123;
							num10 = 1127736123;
						}
						else
						{
							num2 = 2099884953;
							num10 = 2099884953;
						}
						continue;
					}
					case 12u:
						num4 = 0u;
						num7 = int_0;
						num2 = ((int)num3 * -1901188992) ^ -122513367;
						continue;
					case 11u:
						num5 = (num5 << 8) | (byte)stream_0.ReadByte();
						num <<= 8;
						num2 = (int)(num3 * 1001686) ^ -136200854;
						continue;
					case 9u:
						num >>= 1;
						num2 = 655143809;
						continue;
					case 8u:
					{
						int num8;
						int num9;
						if (num >= 16777216)
						{
							num8 = -860186966;
							num9 = -860186966;
						}
						else
						{
							num8 = -52126715;
							num9 = -52126715;
						}
						num2 = num8 ^ ((int)num3 * -619387647);
						continue;
					}
					case 7u:
						num5 = uint_0;
						num2 = (int)(num3 * 658534868) ^ -1254034608;
						continue;
					case 6u:
						num7--;
						num2 = 1105004111;
						continue;
					case 5u:
						uint_1 = num;
						num2 = ((int)num3 * -153540702) ^ -1763791646;
						continue;
					case 4u:
						num4 = (num4 << 1) | (1 - num6);
						num2 = (int)((num3 * 1126207310) ^ 0x32B7961E);
						continue;
					case 3u:
						num2 = ((int)num3 * -2024415622) ^ -89621179;
						continue;
					case 1u:
						num6 = num5 - num >> 31;
						num5 -= num & (num6 - 1);
						num2 = (int)(num3 * 134028520) ^ -66563058;
						continue;
					case 0u:
						uint_0 = num5;
						num2 = (int)((num3 * 1346957901) ^ 0x6B767202);
						continue;
					case 2u:
						break;
					default:
						return num4;
					}
					break;
				}
			}
		}

		internal Class0()
		{
		}
	}

	public class Class1
	{
		public class Class2
		{
			internal readonly Struct1[] struct1_0 = new Struct1[16];

			internal readonly Struct1[] struct1_1 = new Struct1[16];

			internal Struct0 struct0_0 = default(Struct0);

			internal Struct0 struct0_1 = default(Struct0);

			internal Struct1 struct1_2 = new Struct1(8);

			internal uint uint_0;

			internal void method_0(uint uint_1)
			{
				uint num = uint_0;
				while (true)
				{
					int num2;
					int num3;
					if (num < uint_1)
					{
						num2 = -797387834;
						num3 = -797387834;
					}
					else
					{
						num2 = -233945094;
						num3 = -233945094;
					}
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num2 ^ -352424823)) % 6)
						{
						case 5u:
							uint_0 = uint_1;
							num2 = (int)(num4 * 884197342) ^ -1732369979;
							continue;
						case 4u:
						{
							ref Struct1 reference2 = ref struct1_1[num];
							reference2 = new Struct1(3);
							num++;
							num2 = (int)((num4 * 492387694) ^ 0x5EA049C6);
							continue;
						}
						case 3u:
						{
							ref Struct1 reference = ref struct1_0[num];
							reference = new Struct1(3);
							num2 = -815493333;
							continue;
						}
						case 2u:
							num2 = -797387834;
							continue;
						default:
							return;
						case 1u:
							break;
						case 0u:
							return;
						}
						break;
					}
				}
			}

			internal void method_1()
			{
				struct0_0.method_0();
				uint num3 = default(uint);
				while (true)
				{
					int num = -1841094755;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1847890553)) % 7)
						{
						case 5u:
							num3 = 0u;
							num = (int)((num2 * 706123138) ^ 0x182B61AE);
							continue;
						case 4u:
							num = ((int)num2 * -999431762) ^ -825857402;
							continue;
						case 3u:
						{
							int num4;
							if (num3 < uint_0)
							{
								num = -830622758;
								num4 = -830622758;
							}
							else
							{
								num = -101296835;
								num4 = -101296835;
							}
							continue;
						}
						case 2u:
							struct0_1.method_0();
							num = ((int)num2 * -1909258561) ^ -1521699136;
							continue;
						case 1u:
							struct1_0[num3].method_0();
							struct1_1[num3].method_0();
							num3++;
							num = -136394704;
							continue;
						case 6u:
							break;
						default:
							struct1_2.method_0();
							return;
						}
						break;
					}
				}
			}

			internal uint method_2(Class0 class0_0, uint uint_1)
			{
				if (struct0_0.method_1(class0_0) == 0)
				{
					goto IL_0020;
				}
				goto IL_00af;
				IL_0020:
				int num = -914802962;
				goto IL_0073;
				IL_0073:
				uint num3 = default(uint);
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1893361839)) % 7)
					{
					case 6u:
						break;
					case 2u:
						num3 += 8;
						num3 += struct1_2.method_1(class0_0);
						num = -1075930321;
						continue;
					case 1u:
						num = (int)(num2 * 1222964019) ^ -1361667440;
						continue;
					case 0u:
						num3 += struct1_1[uint_1].method_1(class0_0);
						num = ((int)num2 * -126805751) ^ -520810783;
						continue;
					case 5u:
						goto IL_00af;
					default:
						return num3;
					case 4u:
						return struct1_0[uint_1].method_1(class0_0);
					}
					break;
				}
				goto IL_0020;
				IL_00af:
				num3 = 8u;
				int num4;
				if (struct0_1.method_1(class0_0) == 0)
				{
					num = -1609372964;
					num4 = -1609372964;
				}
				else
				{
					num = -985488212;
					num4 = -985488212;
				}
				goto IL_0073;
			}

			internal Class2()
			{
			}
		}

		public class Class3
		{
			public struct Struct2
			{
				internal Struct0[] struct0_0;

				internal void method_0()
				{
					struct0_0 = new Struct0[768];
				}

				internal void method_1()
				{
					int num = 0;
					while (true)
					{
						int num2;
						int num3;
						if (num >= 768)
						{
							num2 = 728531120;
							num3 = 728531120;
						}
						else
						{
							num2 = 1830197561;
							num3 = 1830197561;
						}
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num2 ^ 0x6306E2AC)) % 5)
							{
							case 2u:
								struct0_0[num].method_0();
								num2 = 1716901106;
								continue;
							case 1u:
								num++;
								num2 = (int)((num4 * 1562895348) ^ 0x54D0D83B);
								continue;
							case 0u:
								num2 = 1830197561;
								continue;
							default:
								return;
							case 3u:
								break;
							case 4u:
								return;
							}
							break;
						}
					}
				}

				internal byte method_2(Class0 class0_0)
				{
					uint num = 1u;
					while (true)
					{
						int num2 = -60627530;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)(num2 ^ -1094990177)) % 4)
							{
							case 3u:
							{
								int num4;
								int num5;
								if (num < 256)
								{
									num4 = -1125201750;
									num5 = -1125201750;
								}
								else
								{
									num4 = -2009338857;
									num5 = -2009338857;
								}
								num2 = num4 ^ (int)(num3 * 1574279700);
								continue;
							}
							case 1u:
								num = (num << 1) | struct0_0[num].method_1(class0_0);
								num2 = -853109564;
								continue;
							case 2u:
								break;
							default:
								return (byte)num;
							}
							break;
						}
					}
				}

				internal byte method_3(Class0 class0_0, byte byte_0)
				{
					uint num = 1u;
					uint num7 = default(uint);
					uint num6 = default(uint);
					while (true)
					{
						int num2 = 1922335340;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)(num2 ^ 0x3874DDF7)) % 10)
							{
							case 9u:
							{
								int num5;
								if (num < 256)
								{
									num2 = 259318676;
									num5 = 259318676;
								}
								else
								{
									num2 = 690103299;
									num5 = 690103299;
								}
								continue;
							}
							case 7u:
								byte_0 <<= 1;
								num7 = struct0_0[(1 + num6 << 8) + num].method_1(class0_0);
								num = (num << 1) | num7;
								num2 = ((int)num3 * -316735394) ^ -1522371530;
								continue;
							case 6u:
								num2 = ((int)num3 * -1577906800) ^ -1202066321;
								continue;
							case 5u:
							{
								int num8;
								int num9;
								if (num6 != num7)
								{
									num8 = -324980810;
									num9 = -324980810;
								}
								else
								{
									num8 = -1060089890;
									num9 = -1060089890;
								}
								num2 = num8 ^ (int)(num3 * 1972060313);
								continue;
							}
							case 3u:
								num6 = (uint)((byte_0 >> 7) & 1);
								num2 = 1423518192;
								continue;
							case 2u:
							{
								int num4;
								if (num < 256)
								{
									num2 = 1922335340;
									num4 = 1922335340;
								}
								else
								{
									num2 = 1516245295;
									num4 = 1516245295;
								}
								continue;
							}
							case 1u:
								num = (num << 1) | struct0_0[num].method_1(class0_0);
								num2 = 489190566;
								continue;
							case 0u:
								num2 = (int)((num3 * 1983271454) ^ 0x504A052A);
								continue;
							case 4u:
								break;
							default:
								return (byte)num;
							}
							break;
						}
					}
				}
			}

			internal Struct2[] struct2_0;

			internal int int_0;

			internal int int_1;

			internal uint uint_0;

			internal void method_0(int int_2, int int_3)
			{
				if (struct2_0 != null)
				{
					goto IL_003a;
				}
				goto IL_0166;
				IL_003a:
				int num = -190740277;
				goto IL_0120;
				IL_0120:
				uint num3 = default(uint);
				uint num4 = default(uint);
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1237201894)) % 13)
					{
					case 12u:
					{
						int num7;
						int num8;
						if (int_1 != int_3)
						{
							num7 = -1215430410;
							num8 = -1215430410;
						}
						else
						{
							num7 = -1647888010;
							num8 = -1647888010;
						}
						num = num7 ^ (int)(num2 * 595648171);
						continue;
					}
					case 10u:
						break;
					case 9u:
						num3 = 0u;
						num = (int)(num2 * 73114855) ^ -766495291;
						continue;
					case 8u:
						int_1 = int_3;
						num4 = (uint)(1 << int_1 + int_0);
						num = (int)(num2 * 677528127) ^ -858257779;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (int_0 != int_2)
						{
							num5 = -1310479785;
							num6 = -1310479785;
						}
						else
						{
							num5 = -205925375;
							num6 = -205925375;
						}
						num = num5 ^ ((int)num2 * -629160426);
						continue;
					}
					case 5u:
						goto IL_00ae;
					case 4u:
						num = (int)(num2 * 1395705167) ^ -1874184488;
						continue;
					case 2u:
						struct2_0 = new Struct2[num4];
						num = (int)(num2 * 1795199909) ^ -1051077288;
						continue;
					case 1u:
						struct2_0[num3].method_0();
						num = -1532549820;
						continue;
					case 0u:
						num3++;
						num = (int)(num2 * 1055825112) ^ -36487834;
						continue;
					default:
						return;
					case 3u:
						goto IL_0166;
					case 7u:
						return;
					case 11u:
						return;
					}
					break;
					IL_00ae:
					int num9;
					if (num3 >= num4)
					{
						num = -1640221460;
						num9 = -1640221460;
					}
					else
					{
						num = -914601657;
						num9 = -914601657;
					}
				}
				goto IL_003a;
				IL_0166:
				int_0 = int_2;
				uint_0 = (uint)((1 << int_2) - 1);
				num = -319527772;
				goto IL_0120;
			}

			internal void method_1()
			{
				uint num = (uint)(1 << int_1 + int_0);
				uint num2 = 0u;
				while (true)
				{
					int num3 = 1564945476;
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num3 ^ 0x53A6E1B5)) % 6)
						{
						case 5u:
						{
							int num5;
							if (num2 >= num)
							{
								num3 = 468490712;
								num5 = 468490712;
							}
							else
							{
								num3 = 169880687;
								num5 = 169880687;
							}
							continue;
						}
						case 4u:
							struct2_0[num2].method_1();
							num3 = 1558354531;
							continue;
						case 1u:
							num3 = ((int)num4 * -1482296666) ^ 0xF63BD5C;
							continue;
						case 0u:
							num2++;
							num3 = ((int)num4 * -1538497572) ^ 0x774BCCF2;
							continue;
						default:
							return;
						case 2u:
							break;
						case 3u:
							return;
						}
						break;
					}
				}
			}

			internal uint method_2(uint uint_1, byte byte_0)
			{
				return ((uint_1 & uint_0) << int_1) + (uint)(byte_0 >> 8 - int_1);
			}

			internal byte method_3(Class0 class0_0, uint uint_1, byte byte_0)
			{
				return struct2_0[method_2(uint_1, byte_0)].method_2(class0_0);
			}

			internal byte method_4(Class0 class0_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return struct2_0[method_2(uint_1, byte_0)].method_3(class0_0, byte_1);
			}

			internal Class3()
			{
			}
		}

		internal readonly Struct0[] struct0_0 = new Struct0[192];

		internal readonly Struct0[] struct0_1 = new Struct0[192];

		internal readonly Struct0[] struct0_2 = new Struct0[12];

		internal readonly Struct0[] struct0_3 = new Struct0[12];

		internal readonly Struct0[] struct0_4 = new Struct0[12];

		internal readonly Struct0[] struct0_5 = new Struct0[12];

		internal readonly Class2 class2_0 = new Class2();

		internal readonly Class3 class3_0 = new Class3();

		internal readonly Class4 class4_0 = new Class4();

		internal readonly Struct0[] struct0_6 = new Struct0[114];

		internal readonly Struct1[] struct1_0 = new Struct1[4];

		internal readonly Class0 class0_0 = new Class0();

		internal readonly Class2 class2_1 = new Class2();

		internal bool bool_0;

		internal uint uint_0;

		internal uint uint_1;

		internal Struct1 struct1_1 = new Struct1(4);

		internal uint uint_2;

		internal Class1()
		{
			int num3 = default(int);
			while (true)
			{
				int num = 600614466;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x6A85ABE0)) % 7)
					{
					case 6u:
						uint_0 = uint.MaxValue;
						num3 = 0;
						num = (int)(num2 * 1555453221) ^ -303309956;
						continue;
					case 5u:
					{
						int num4;
						if (num3 < 4L)
						{
							num = 1077001280;
							num4 = 1077001280;
						}
						else
						{
							num = 1339467794;
							num4 = 1339467794;
						}
						continue;
					}
					case 3u:
					{
						ref Struct1 reference = ref struct1_0[num3];
						reference = new Struct1(6);
						num = 503589266;
						continue;
					}
					case 1u:
						num = (int)(num2 * 194810056) ^ -1290725123;
						continue;
					case 0u:
						num3++;
						num = ((int)num2 * -1028375637) ^ -176340757;
						continue;
					default:
						return;
					case 4u:
						break;
					case 2u:
						return;
					}
					break;
				}
			}
		}

		internal void method_0(uint uint_3)
		{
			if (uint_0 == uint_3)
			{
				return;
			}
			uint uint_4 = default(uint);
			while (true)
			{
				int num = 2110839870;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x509E4C37)) % 5)
					{
					case 3u:
						class4_0.method_0(uint_4);
						num = (int)(num2 * 714414128) ^ -496028594;
						continue;
					case 2u:
						uint_4 = Math.Max(uint_1, 4096u);
						num = ((int)num2 * -1912216509) ^ 0x3CC262D5;
						continue;
					case 1u:
						uint_0 = uint_3;
						uint_1 = Math.Max(uint_0, 1u);
						num = (int)(num2 * 354795731) ^ -1163555448;
						continue;
					default:
						return;
					case 4u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}

		internal void method_1(int int_0, int int_1)
		{
			class3_0.method_0(int_0, int_1);
		}

		internal void method_2(int int_0)
		{
			uint num = (uint)(1 << int_0);
			class2_0.method_0(num);
			class2_1.method_0(num);
			while (true)
			{
				int num2 = 552644696;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x678B76A4)) % 3)
					{
					case 2u:
						goto IL_0021;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0021:
					uint_2 = num - 1;
					num2 = ((int)num3 * -1478886059) ^ 0x72EFED8;
				}
			}
		}

		internal void method_3(Stream stream_0, Stream stream_1)
		{
			class0_0.method_0(stream_0);
			class4_0.method_1(stream_1, bool_0);
			uint num = 0u;
			uint num8 = default(uint);
			uint num5 = default(uint);
			while (true)
			{
				int num2;
				int num3;
				if (num < 12)
				{
					num2 = -714459888;
					num3 = -714459888;
				}
				else
				{
					num2 = -1277945897;
					num3 = -1277945897;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ -1008674607)) % 22)
					{
					case 21u:
						struct0_1[num8].method_0();
						num2 = ((int)num4 * -1540943649) ^ 0x72D54B2A;
						continue;
					case 20u:
						struct1_1.method_0();
						num2 = ((int)num4 * -842206476) ^ 0x38EE6D3;
						continue;
					case 19u:
						class2_0.method_1();
						num2 = ((int)num4 * -21363847) ^ -354019433;
						continue;
					case 18u:
						num = 0u;
						num2 = (int)(num4 * 314572390) ^ -1039179043;
						continue;
					case 17u:
						num++;
						num2 = ((int)num4 * -1810248889) ^ 0xBC53E7A;
						continue;
					case 16u:
						class3_0.method_1();
						num2 = ((int)num4 * -2036359302) ^ 0x60670763;
						continue;
					case 15u:
						struct0_6[num].method_0();
						num2 = -899262504;
						continue;
					case 14u:
					{
						int num9;
						if (num < 114)
						{
							num2 = -1496137992;
							num9 = -1496137992;
						}
						else
						{
							num2 = -653096770;
							num9 = -653096770;
						}
						continue;
					}
					case 12u:
						num5++;
						num2 = (int)((num4 * 194213881) ^ 0x2EB34A73);
						continue;
					case 11u:
						struct0_2[num].method_0();
						num2 = (int)((num4 * 1249551394) ^ 0x41D2772C);
						continue;
					case 9u:
						class2_1.method_1();
						num2 = ((int)num4 * -818036306) ^ 0x65943D25;
						continue;
					case 8u:
						num++;
						num2 = (int)(num4 * 62659238) ^ -569375707;
						continue;
					case 7u:
						num = 0u;
						num2 = (int)(num4 * 1927906152) ^ -510076787;
						continue;
					case 6u:
						num8 = (num << 4) + num5;
						struct0_0[num8].method_0();
						num2 = -750041396;
						continue;
					case 5u:
						num2 = -714459888;
						continue;
					case 4u:
					{
						int num7;
						if (num5 > uint_2)
						{
							num2 = -1718996138;
							num7 = -1718996138;
						}
						else
						{
							num2 = -1415254865;
							num7 = -1415254865;
						}
						continue;
					}
					case 3u:
						struct0_3[num].method_0();
						struct0_4[num].method_0();
						struct0_5[num].method_0();
						num++;
						num2 = ((int)num4 * -1442820834) ^ 0x5229BC0C;
						continue;
					case 2u:
					{
						int num6;
						if (num >= 4)
						{
							num2 = -1503653788;
							num6 = -1503653788;
						}
						else
						{
							num2 = -489366501;
							num6 = -489366501;
						}
						continue;
					}
					case 1u:
						num5 = 0u;
						num2 = -386344821;
						continue;
					case 0u:
						struct1_0[num].method_0();
						num2 = -812934269;
						continue;
					default:
						return;
					case 13u:
						break;
					case 10u:
						return;
					}
					break;
				}
			}
		}

		internal void method_4(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			method_3(stream_0, stream_1);
			Struct3 @struct = default(Struct3);
			uint num7 = default(uint);
			uint num6 = default(uint);
			uint num5 = default(uint);
			uint num15 = default(uint);
			ulong num4 = default(ulong);
			int num8 = default(int);
			uint num14 = default(uint);
			uint num24 = default(uint);
			uint num3 = default(uint);
			uint num16 = default(uint);
			ulong num9 = default(ulong);
			byte byte_3 = default(byte);
			byte byte_2 = default(byte);
			byte byte_ = default(byte);
			while (true)
			{
				int num = -1337619577;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -407382515)) % 58)
					{
					case 57u:
					{
						int num25;
						int num26;
						if (num7 < 4)
						{
							num25 = 2067794981;
							num26 = 2067794981;
						}
						else
						{
							num25 = 1359427326;
							num26 = 1359427326;
						}
						num = num25 ^ ((int)num2 * -328131802);
						continue;
					}
					case 56u:
						num6 += struct1_1.method_2(class0_0);
						num = (int)((num2 * 526361586) ^ 0x640CAADE);
						continue;
					case 55u:
					{
						int num19;
						if (struct0_5[@struct.uint_0].method_1(class0_0) != 0)
						{
							num = -1809211252;
							num19 = -1809211252;
						}
						else
						{
							num = -1248632687;
							num19 = -1248632687;
						}
						continue;
					}
					case 54u:
						num5 = 0u;
						num = (int)((num2 * 1017489376) ^ 0x7C336152);
						continue;
					case 53u:
						num15 = (uint)(int)num4 & uint_2;
						num = -988239852;
						continue;
					case 52u:
						num4++;
						num = (int)(num2 * 1124941110) ^ -1625159907;
						continue;
					case 51u:
						num8 = (int)((num7 >> 1) - 1);
						num = (int)((num2 * 1914911841) ^ 0x1CB30ED5);
						continue;
					case 50u:
						class4_0.method_2();
						num = (int)((num2 * 303187424) ^ 0x687330F);
						continue;
					case 49u:
					{
						int num12;
						int num13;
						if (num6 >= uint_1)
						{
							num12 = 1189937676;
							num13 = 1189937676;
						}
						else
						{
							num12 = 898526258;
							num13 = 898526258;
						}
						num = num12 ^ ((int)num2 * -640790325);
						continue;
					}
					case 48u:
						@struct.method_2();
						num7 = struct1_0[smethod_0(num14)].method_1(class0_0);
						num = ((int)num2 * -1461993096) ^ 0x39DE63C2;
						continue;
					case 47u:
						num24 = num5;
						num = -1231133269;
						continue;
					case 46u:
						num24 = num3;
						num = ((int)num2 * -541851995) ^ 0x4B517AD8;
						continue;
					case 45u:
					{
						int num31;
						if (num6 >= num4)
						{
							num = -929479895;
							num31 = -929479895;
						}
						else
						{
							num = -1862143550;
							num31 = -1862143550;
						}
						continue;
					}
					case 44u:
						num = ((int)num2 * -203944997) ^ -1585394592;
						continue;
					case 43u:
					{
						int num28;
						if (struct0_4[@struct.uint_0].method_1(class0_0) != 0)
						{
							num = -876616826;
							num28 = -876616826;
						}
						else
						{
							num = -594536348;
							num28 = -594536348;
						}
						continue;
					}
					case 42u:
						class4_0.method_4(num6, num14);
						num4 += num14;
						num = -1395830287;
						continue;
					case 41u:
						num24 = num16;
						num = ((int)num2 * -704797486) ^ -1632884353;
						continue;
					case 40u:
					{
						int num20;
						int num21;
						if (struct0_3[@struct.uint_0].method_1(class0_0) == 0)
						{
							num20 = 911504967;
							num21 = 911504967;
						}
						else
						{
							num20 = 889312694;
							num21 = 889312694;
						}
						num = num20 ^ (int)(num2 * 630858724);
						continue;
					}
					case 39u:
						num4 = 0uL;
						num9 = (ulong)long_1;
						num = ((int)num2 * -1113113823) ^ -2123151994;
						continue;
					case 38u:
					{
						int num35;
						if (num4 < num9)
						{
							num = -1645303706;
							num35 = -1645303706;
						}
						else
						{
							num = -1385511912;
							num35 = -1385511912;
						}
						continue;
					}
					case 37u:
						num14 = 2 + class2_0.method_2(class0_0, num15);
						num = (int)((num2 * 42193682) ^ 0x323B2429);
						continue;
					case 36u:
						@struct.method_4();
						num = ((int)num2 * -1272930093) ^ -468038409;
						continue;
					case 35u:
						byte_3 = class4_0.method_6(0u);
						num = ((int)num2 * -261316813) ^ -526608919;
						continue;
					case 34u:
						class4_0.method_5(class4_0.method_6(num6));
						num = (int)((num2 * 540858692) ^ 0x6A6C357A);
						continue;
					case 33u:
						num16 = 0u;
						num = (int)((num2 * 99336276) ^ 0x2A51DE89);
						continue;
					case 31u:
						num5 = num3;
						num = -1381916856;
						continue;
					case 30u:
						num6 = num24;
						num = (int)((num2 * 842694813) ^ 0x29E452EE);
						continue;
					case 29u:
						struct0_0[@struct.uint_0 << 4].method_1(class0_0);
						@struct.method_1();
						num = (int)(num2 * 1770392019) ^ -426935866;
						continue;
					case 28u:
						byte_2 = class3_0.method_4(class0_0, (uint)num4, byte_3, class4_0.method_6(num6));
						num = (int)((num2 * 1019543528) ^ 0x676837D7);
						continue;
					case 27u:
						num3 = num16;
						num = -16007331;
						continue;
					case 26u:
						byte_ = class3_0.method_3(class0_0, 0u, 0);
						num = (int)(num2 * 298170400) ^ -863198324;
						continue;
					case 25u:
						num4++;
						num = ((int)num2 * -1072017999) ^ 0xF7C0FBE;
						continue;
					case 24u:
						byte_2 = class3_0.method_3(class0_0, (uint)num4, byte_3);
						num = -1349348971;
						continue;
					case 23u:
						num3 = num16;
						num = (int)((num2 * 156918821) ^ 0x5F486910);
						continue;
					case 22u:
						num16 = num6;
						num = ((int)num2 * -1138113436) ^ 0x614DF080;
						continue;
					case 21u:
					{
						int num34;
						if (struct0_2[@struct.uint_0].method_1(class0_0) != 1)
						{
							num = -1507761882;
							num34 = -1507761882;
						}
						else
						{
							num = -1493144817;
							num34 = -1493144817;
						}
						continue;
					}
					case 20u:
					{
						int num32;
						int num33;
						if (struct0_1[(@struct.uint_0 << 4) + num15].method_1(class0_0) != 0)
						{
							num32 = -965113850;
							num33 = -965113850;
						}
						else
						{
							num32 = -1827742711;
							num33 = -1827742711;
						}
						num = num32 ^ (int)(num2 * 2075313238);
						continue;
					}
					case 19u:
					{
						int num29;
						int num30;
						if (!@struct.method_5())
						{
							num29 = -885941737;
							num30 = -885941737;
						}
						else
						{
							num29 = -379561225;
							num30 = -379561225;
						}
						num = num29 ^ (int)(num2 * 1010133382);
						continue;
					}
					case 18u:
					{
						int num27;
						if (num6 == uint.MaxValue)
						{
							num = -1385511912;
							num27 = -1385511912;
						}
						else
						{
							num = -1141232361;
							num27 = -1141232361;
						}
						continue;
					}
					case 17u:
					{
						int num22;
						int num23;
						if (num7 < 14)
						{
							num22 = -1728445105;
							num23 = -1728445105;
						}
						else
						{
							num22 = -1100147191;
							num23 = -1100147191;
						}
						num = num22 ^ (int)(num2 * 902177399);
						continue;
					}
					case 16u:
						class4_0.method_5(byte_2);
						@struct.method_1();
						num = -1082992433;
						continue;
					case 14u:
						num = ((int)num2 * -1453548756) ^ 0x478B6C66;
						continue;
					case 13u:
					{
						int num17;
						int num18;
						if (struct0_0[(@struct.uint_0 << 4) + num15].method_1(class0_0) != 0)
						{
							num17 = -1353592326;
							num18 = -1353592326;
						}
						else
						{
							num17 = -1343914652;
							num18 = -1343914652;
						}
						num = num17 ^ (int)(num2 * 2048643258);
						continue;
					}
					case 12u:
						num = ((int)num2 * -1924364751) ^ 0x751BFA4F;
						continue;
					case 11u:
						num6 = (2 | (num7 & 1)) << num8;
						num = ((int)num2 * -1336482945) ^ 0x345E33A7;
						continue;
					case 10u:
						@struct.method_0();
						num6 = 0u;
						num = ((int)num2 * -651831807) ^ -964793602;
						continue;
					case 9u:
						num6 += class0_0.method_3(num8 - 4) << 4;
						num = -979525319;
						continue;
					case 8u:
						num16 = num6;
						num = -689014503;
						continue;
					case 7u:
						num14 = class2_1.method_2(class0_0, num15) + 2;
						@struct.method_3();
						num = -740364383;
						continue;
					case 6u:
					{
						int num10;
						int num11;
						if (num4 >= num9)
						{
							num10 = -83414135;
							num11 = -83414135;
						}
						else
						{
							num10 = -2081556342;
							num11 = -2081556342;
						}
						num = num10 ^ (int)(num2 * 442085078);
						continue;
					}
					case 5u:
						class4_0.method_3();
						num = -1000160411;
						continue;
					case 4u:
						num6 = num7;
						num = -1168481802;
						continue;
					case 3u:
						num6 += Struct1.smethod_0(struct0_6, num6 - num7 - 1, class0_0, num8);
						num = (int)(num2 * 1529313188) ^ -643422389;
						continue;
					case 2u:
						num5 = num3;
						num = (int)(num2 * 2028717812) ^ -324100500;
						continue;
					case 1u:
						class4_0.method_5(byte_);
						num4++;
						num = (int)((num2 * 927754581) ^ 0x5DB29A64);
						continue;
					case 0u:
						num3 = 0u;
						num = (int)((num2 * 903893584) ^ 0x12436725);
						continue;
					case 15u:
						break;
					default:
						class0_0.method_1();
						return;
					}
					break;
				}
			}
		}

		internal void method_5(byte[] byte_0)
		{
			int int_ = byte_0[0] % 9;
			uint num6 = default(uint);
			int int_3 = default(int);
			int num5 = default(int);
			int int_2 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = 1468090495;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x57BA2E26)) % 11)
					{
					case 10u:
						num6 = 0u;
						num = ((int)num2 * -1127778501) ^ -1584426345;
						continue;
					case 9u:
						int_3 = num5 % 5;
						num = ((int)num2 * -919059956) ^ -62378822;
						continue;
					case 8u:
						int_2 = num5 / 5;
						num = ((int)num2 * -517398619) ^ -1989801024;
						continue;
					case 7u:
						num3++;
						num = ((int)num2 * -1145869148) ^ 0x31AB817C;
						continue;
					case 6u:
						method_0(num6);
						method_1(int_3, int_);
						num = ((int)num2 * -808704091) ^ 0x31F617F2;
						continue;
					case 4u:
						num6 += (uint)(byte_0[1 + num3] << num3 * 8);
						num = 979499674;
						continue;
					case 2u:
						num5 = byte_0[0] / 9;
						num = ((int)num2 * -1893516666) ^ 0xF8033D6;
						continue;
					case 1u:
						num3 = 0;
						num = (int)(num2 * 962567508) ^ -410736576;
						continue;
					case 0u:
					{
						int num4;
						if (num3 >= 4)
						{
							num = 1603928250;
							num4 = 1603928250;
						}
						else
						{
							num = 1030447791;
							num4 = 1030447791;
						}
						continue;
					}
					case 3u:
						break;
					default:
						method_2(int_2);
						return;
					}
					break;
				}
			}
		}

		internal static uint smethod_0(uint uint_3)
		{
			uint_3 -= 2;
			if (uint_3 < 4)
			{
				return uint_3;
			}
			return 3u;
		}
	}

	public class Class4
	{
		internal byte[] byte_0;

		internal uint uint_0;

		internal Stream stream_0;

		internal uint uint_1;

		internal uint uint_2;

		internal void method_0(uint uint_3)
		{
			if (uint_2 != uint_3)
			{
				goto IL_0009;
			}
			goto IL_006c;
			IL_0009:
			int num = 685192165;
			goto IL_0047;
			IL_0047:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4B94A685)) % 5)
				{
				case 2u:
					break;
				case 1u:
					byte_0 = new byte[uint_3];
					num = (int)((num2 * 2146410385) ^ 0x693A72DA);
					continue;
				case 0u:
					uint_0 = 0u;
					uint_1 = 0u;
					num = (int)(num2 * 1515285787) ^ -1229791540;
					continue;
				default:
					return;
				case 3u:
					goto IL_006c;
				case 4u:
					return;
				}
				break;
			}
			goto IL_0009;
			IL_006c:
			uint_2 = uint_3;
			num = 2100117882;
			goto IL_0047;
		}

		internal void method_1(Stream stream_1, bool bool_0)
		{
			method_2();
			while (true)
			{
				int num = 1346625645;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x347FE2E3)) % 5)
					{
					case 4u:
						stream_0 = stream_1;
						num = ((int)num2 * -1426997398) ^ -1817875224;
						continue;
					case 2u:
						uint_1 = 0u;
						uint_0 = 0u;
						num = (int)((num2 * 1365847987) ^ 0x1C1998BE);
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if (bool_0)
						{
							num3 = 1250891794;
							num4 = 1250891794;
						}
						else
						{
							num3 = 1652117821;
							num4 = 1652117821;
						}
						num = num3 ^ ((int)num2 * -539458905);
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

		internal void method_2()
		{
			method_3();
			while (true)
			{
				int num = 1012151136;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x219FC8B1)) % 4)
					{
					case 2u:
						Buffer.BlockCopy(new byte[byte_0.Length], 0, byte_0, 0, byte_0.Length);
						num = (int)((num2 * 1476207457) ^ 0x75F9A063);
						continue;
					case 1u:
						stream_0 = null;
						num = (int)((num2 * 176098173) ^ 0x76CF9C0A);
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

		internal void method_3()
		{
			uint num = uint_0 - uint_1;
			if (num == 0)
			{
				goto IL_0020;
			}
			goto IL_006c;
			IL_0020:
			int num2 = -557627916;
			goto IL_003b;
			IL_003b:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -405864337)) % 5)
				{
				case 4u:
					break;
				case 1u:
					uint_0 = 0u;
					num2 = (int)(num3 * 1013125888) ^ -1750625193;
					continue;
				case 0u:
					goto IL_006c;
				default:
					uint_1 = uint_0;
					return;
				case 3u:
					return;
				}
				break;
			}
			goto IL_0020;
			IL_006c:
			stream_0.Write(byte_0, (int)uint_1, (int)num);
			int num4;
			if (uint_0 < uint_2)
			{
				num2 = -2117063849;
				num4 = -2117063849;
			}
			else
			{
				num2 = -1659043254;
				num4 = -1659043254;
			}
			goto IL_003b;
		}

		internal void method_4(uint uint_3, uint uint_4)
		{
			uint num = uint_0 - uint_3 - 1;
			if (num >= uint_2)
			{
				goto IL_00d9;
			}
			goto IL_012f;
			IL_00d9:
			int num2 = 1522374204;
			goto IL_00ea;
			IL_00ea:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x2FF3F740)) % 9)
				{
				case 7u:
					break;
				case 6u:
					num = 0u;
					num2 = ((int)num3 * -402364887) ^ -342425420;
					continue;
				case 5u:
					num += uint_2;
					num2 = ((int)num3 * -2114653781) ^ -144472460;
					continue;
				case 4u:
					method_3();
					num2 = (int)(num3 * 392034071) ^ -101852385;
					continue;
				case 3u:
					goto IL_00b7;
				case 2u:
					goto end_IL_00ea;
				case 0u:
					uint_4--;
					num2 = 2083741600;
					continue;
				default:
					return;
				case 1u:
					goto IL_012f;
				case 8u:
					return;
				}
				byte_0[uint_0++] = byte_0[num++];
				int num4;
				if (uint_0 >= uint_2)
				{
					num2 = 1752681955;
					num4 = 1752681955;
				}
				else
				{
					num2 = 172380858;
					num4 = 172380858;
				}
				continue;
				IL_00b7:
				int num5;
				if (num >= uint_2)
				{
					num2 = 796758003;
					num5 = 796758003;
				}
				else
				{
					num2 = 505652767;
					num5 = 505652767;
				}
				continue;
				end_IL_00ea:
				break;
			}
			goto IL_00d9;
			IL_012f:
			int num6;
			if (uint_4 == 0)
			{
				num2 = 527043648;
				num6 = 527043648;
			}
			else
			{
				num2 = 368457801;
				num6 = 368457801;
			}
			goto IL_00ea;
		}

		internal void method_5(byte byte_1)
		{
			byte_0[uint_0++] = byte_1;
			while (true)
			{
				int num = 187488161;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x2F227780)) % 4)
					{
					case 3u:
						method_3();
						num = (int)(num2 * 1654264936) ^ -1967612268;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (uint_0 >= uint_2)
						{
							num3 = -1594807339;
							num4 = -1594807339;
						}
						else
						{
							num3 = -1849486298;
							num4 = -1849486298;
						}
						num = num3 ^ ((int)num2 * -1045278742);
						continue;
					}
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}

		internal byte method_6(uint uint_3)
		{
			uint num = uint_0 - uint_3 - 1;
			if (num >= uint_2)
			{
				while (true)
				{
					int num2 = -15603262;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ -1039702623)) % 3)
						{
						case 1u:
							num += uint_2;
							num2 = (int)(num3 * 2111331112) ^ -1726411691;
							continue;
						case 2u:
							break;
						default:
							goto end_IL_0049;
						}
						break;
					}
					continue;
					end_IL_0049:
					break;
				}
			}
			return byte_0[num];
		}

		internal Class4()
		{
		}
	}

	public struct Struct3
	{
		internal uint uint_0;

		internal void method_0()
		{
			uint_0 = 0u;
		}

		internal void method_1()
		{
			if (uint_0 < 4)
			{
				goto IL_002d;
			}
			goto IL_0088;
			IL_002d:
			int num = 82721790;
			goto IL_004f;
			IL_004f:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1C89A3AE)) % 7)
				{
				case 6u:
					uint_0 -= 6u;
					num = 367667521;
					continue;
				case 3u:
					break;
				case 2u:
					uint_0 -= 3u;
					num = ((int)num2 * -1159247612) ^ -2110553976;
					continue;
				default:
					return;
				case 5u:
					goto IL_0088;
				case 0u:
					return;
				case 1u:
					uint_0 = 0u;
					return;
				case 4u:
					return;
				}
				break;
			}
			goto IL_002d;
			IL_0088:
			int num3;
			if (uint_0 >= 10)
			{
				num = 1476411834;
				num3 = 1476411834;
			}
			else
			{
				num = 1376997659;
				num3 = 1376997659;
			}
			goto IL_004f;
		}

		internal void method_2()
		{
			uint_0 = ((uint_0 < 7) ? 7u : 10u);
		}

		internal void method_3()
		{
			uint_0 = ((uint_0 < 7) ? 8u : 11u);
		}

		internal void method_4()
		{
			uint_0 = ((uint_0 < 7) ? 9u : 11u);
		}

		internal bool method_5()
		{
			return uint_0 < 7;
		}
	}

	[StructLayout(LayoutKind.Explicit, Size = 512)]
	public struct Struct4
	{
	}

	internal static byte[] byte_0;

	internal static Struct4 struct4_0/* Not supported: data(A8 85 AA 74 54 FB A6 4E 03 25 A1 5E 1E CF AF 7C 7A 4C 56 E6 04 CC D2 05 4A A0 59 62 34 FC AA 8C 48 29 1D F6 A9 59 37 B3 D6 B4 81 3D 60 2F 18 D2 8C D3 60 CB 5D 70 B3 64 2B 93 DE 94 63 FB AA CA E9 02 77 6B DD E1 DA 30 A7 84 33 F2 87 B1 25 EE CC 36 62 D1 E3 54 D4 76 3A A3 B9 EA F5 40 57 E6 82 9B A8 50 3F 91 34 8C 01 78 C5 7E DE 90 E4 82 03 64 27 B9 70 2B E2 97 34 FA B9 76 AC F3 C9 EC B2 C6 DC 45 D1 D8 59 ED 41 3E 7B B1 99 AE B4 F3 92 DE A6 97 AC E8 CA 87 68 4F BC 4D 3F 13 31 F8 68 07 F6 71 37 A5 CA 84 A9 FB 67 C7 EF FA 93 49 4B 7C 1C 1C ED 40 E9 C6 7A 83 A9 89 0B DD FC DF 44 F6 F2 5D C1 51 8B 8A 8C 11 36 F7 E0 E4 C7 B2 6E AD 78 14 FC DF 6D 6A 62 80 30 85 84 F9 0A 83 7E F8 F2 4E F8 3B 23 61 B7 47 48 5E E3 4E 2E 45 83 D9 75 DB 3F C8 2D ED 02 A0 F4 C5 88 00 C4 39 88 07 3A 82 2D 55 7C 19 2A D4 EB 0D 1E 95 9D D8 55 29 EF 8A FD E1 E6 6F 1B DE 60 37 BB 90 E5 56 C1 5F 2A C3 34 37 F3 8F 8F 87 E3 0D D8 BF 9D CF 36 7B FE E7 5C 73 7D 27 8B C9 BB 42 46 D6 17 46 61 57 D5 D1 1F DF 8D 7A 4A 62 7F 04 1C 80 21 D7 14 85 72 88 68 3C 20 CA EE 8D 6E AE 43 09 8E 13 16 37 38 4A 72 7B 11 C2 FF 84 F0 F5 79 C7 4E B6 42 35 E8 F2 7C 30 9E 79 F4 EF 61 48 5A 89 97 DC EF F4 5D 94 AB 46 9B AA F8 59 F7 3E 0C 20 10 78 96 05 44 47 23 C4 5A 69 EB 88 B0 C5 EE 6A 9E 20 FC 15 AA BF 5E 24 55 79 20 C3 9B F6 7A 91 05 A7 53 47 1B 05 3C 7B F4 C2 80 F5 34 A8 BD 3C E7 25 83 CD 7F AF B6 E0 86 56 9B 0F AA 8B 46 06 DA 60 BF 23 5C 0D 55 40 11 5F E4 8E 2D 65 5F 99 69 64 1F 6E 87 33 9F 63 9B 81 52 E2 9B F6 7A 91 05 A7 53 47 1B 05 3C 7B F4 C2 80 F5 34 A8 BD 3C E7 25) */;

	static _003CModule_003E()
	{
		GClass7.smethod_0();
		smethod_1();
		while (true)
		{
			int num = -2032088137;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2055460935)) % 3)
				{
				case 1u:
					goto IL_000c;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000c:
				Class171.smethod_28();
				Class171.smethod_190();
				num = ((int)num2 * -2078845404) ^ 0x2DE1661;
			}
		}
	}

	internal static byte[] smethod_0(byte[] byte_1)
	{
		MemoryStream memoryStream = new MemoryStream(byte_1);
		int num4 = default(int);
		Class1 @class = default(Class1);
		byte[] buffer = default(byte[]);
		long num3 = default(long);
		MemoryStream stream_ = default(MemoryStream);
		byte[] array = default(byte[]);
		while (true)
		{
			int num = 83875857;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x17D0DB64)) % 13)
				{
				case 12u:
				{
					int num6;
					if (num4 >= 8)
					{
						num = 1420452137;
						num6 = 1420452137;
					}
					else
					{
						num = 602391595;
						num6 = 602391595;
					}
					continue;
				}
				case 10u:
					@class.method_5(buffer);
					num3 = 0L;
					num = ((int)num2 * -348752593) ^ -628989981;
					continue;
				case 8u:
					buffer = new byte[5];
					num = ((int)num2 * -1470371784) ^ 0x3AA2A04C;
					continue;
				case 7u:
					num = (int)((num2 * 1281832558) ^ 0x12C1DE31);
					continue;
				case 6u:
					memoryStream.Read(buffer, 0, 5);
					num = (int)((num2 * 1917943549) ^ 0x40943B29);
					continue;
				case 5u:
					@class = new Class1();
					num = ((int)num2 * -442210329) ^ 0x4B3D03D9;
					continue;
				case 4u:
					num4++;
					num = ((int)num2 * -2045305445) ^ 0x3EB33091;
					continue;
				case 3u:
				{
					int num5 = memoryStream.ReadByte();
					num3 |= (long)((ulong)(byte)num5 << 8 * num4);
					num = 277001426;
					continue;
				}
				case 2u:
				{
					long long_ = memoryStream.Length - 13L;
					@class.method_4(memoryStream, stream_, long_, num3);
					num = ((int)num2 * -1595612353) ^ -807152236;
					continue;
				}
				case 1u:
					num4 = 0;
					num = (int)((num2 * 591382081) ^ 0x6DAA6CC7);
					continue;
				case 0u:
					array = new byte[(int)num3];
					stream_ = new MemoryStream(array, writable: true);
					num = ((int)num2 * -1648618480) ^ -1705044582;
					continue;
				case 9u:
					break;
				default:
					return array;
				}
				break;
			}
		}
	}

	internal static void smethod_1()
	{
		uint num = 128u;
		uint num12 = default(uint);
		int num10 = default(int);
		uint[] array = default(uint[]);
		uint[] array2 = default(uint[]);
		byte[] array3 = default(byte[]);
		int num6 = default(int);
		uint num5 = default(uint);
		int num7 = default(int);
		uint[] array4 = default(uint[]);
		int num8 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = -1038203879;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -303148808)) % 39)
				{
				case 38u:
					num12 ^= num12 << 25;
					num2 = ((int)num3 * -367555477) ^ 0x5F819FF1;
					continue;
				case 37u:
					num10++;
					num2 = ((int)num3 * -996478885) ^ -857810974;
					continue;
				case 36u:
					array[0] = array[0] ^ array2[0];
					num2 = (int)((num3 * 1189142098) ^ 0x41B17A3C);
					continue;
				case 35u:
					byte_0 = smethod_0(array3);
					num2 = ((int)num3 * -74345989) ^ 0x4DF0F623;
					continue;
				case 34u:
					num12 ^= num12 >> 12;
					num2 = -1786695588;
					continue;
				case 33u:
					num12 = 581480289u;
					num2 = (int)((num3 * 909371414) ^ 0x42EB74F);
					continue;
				case 31u:
					array[15] = array[15] ^ array2[15];
					num6 = 0;
					num2 = ((int)num3 * -1169373188) ^ 0xE133A8B;
					continue;
				case 30u:
					array2[num6] ^= num5;
					num2 = ((int)num3 * -1008568464) ^ 0x1DE2A681;
					continue;
				case 29u:
					num7 = 0;
					num2 = (int)(num3 * 1529477198) ^ -1560878547;
					continue;
				case 28u:
					array4 = new uint[128]
					{
						1957332392u, 1319566164u, 1587619075u, 2091896606u, 3864415354u, 97700868u, 1650040906u, 2360015924u, 4129106248u, 3006749097u,
						1031910614u, 3524800352u, 3412120460u, 1689481309u, 2497614635u, 3400203107u, 1802961641u, 819651037u, 4063462567u, 3995447687u,
						3512874700u, 1993626851u, 3938034490u, 3864477941u, 1353227138u, 2352255295u, 2126870529u, 2196017374u, 3106366467u, 2548181872u,
						1991899700u, 3972658092u, 1172096690u, 3982088401u, 2977644097u, 4088704665u, 2544295570u, 2278221996u, 1304186728u, 4163965759u,
						1911949160u, 2227873079u, 3345480617u, 1234434799u, 471628875u, 3337175277u, 2309587834u, 3757890827u, 1576203844u, 2324386241u,
						4147515788u, 2999444704u, 343453038u, 1785585660u, 2234548322u, 2198534532u, 1324546174u, 1629699064u, 1581795255u, 1160662755u,
						3681933699u, 3979200575u, 3321143298u, 969146504u, 2184841096u, 427578669u, 233559082u, 3634205982u, 2330929493u, 1877402109u,
						929095195u, 1457885371u, 3274334145u, 2415081268u, 233015183u, 3483221976u, 3892214582u, 662532956u, 1119603083u, 1175967302u,
						3520419681u, 2056118047u, 75457098u, 3609296924u, 2289206548u, 3391110248u, 2926480878u, 328075587u, 1245198102u, 3255925618u,
						4126180607u, 3058616185u, 4075304258u, 2040410236u, 1214377972u, 3700918618u, 2489185519u, 2862302891u, 1056397816u, 2014322700u,
						1195640214u, 1767556131u, 3316680939u, 547252974u, 3215595004u, 2035623006u, 4137403168u, 2802159994u, 85673811u, 3270802236u,
						2822043008u, 635911357u, 2944388483u, 1451679926u, 2343178139u, 1624901190u, 224142271u, 1594966101u, 1697484516u, 1684642143u,
						864513567u, 2174444447u, 4137411154u, 2802159994u, 85673811u, 3270802236u, 2822043008u, 635911357u
					};
					num2 = (int)(num3 * 1933173989) ^ -377767329;
					continue;
				case 27u:
					num12 = (array2[num10] = num12 ^ (num12 >> 27));
					num2 = ((int)num3 * -1802803075) ^ -790263158;
					continue;
				case 26u:
					num8++;
					num2 = (int)((num3 * 1965282890) ^ 0x28901CD4);
					continue;
				case 25u:
				{
					int num14;
					if (num10 >= 16)
					{
						num2 = -706133209;
						num14 = -706133209;
					}
					else
					{
						num2 = -1458891360;
						num14 = -1458891360;
					}
					continue;
				}
				case 24u:
					num8 = 0;
					num2 = -558388382;
					continue;
				case 23u:
				{
					int num13;
					if (num6 < 16)
					{
						num2 = -1739190959;
						num13 = -1739190959;
					}
					else
					{
						num2 = -503973680;
						num13 = -503973680;
					}
					continue;
				}
				case 22u:
					num2 = ((int)num3 * -610769461) ^ -558746923;
					continue;
				case 21u:
				{
					int num11;
					if (num7 >= num)
					{
						num2 = -380146827;
						num11 = -380146827;
					}
					else
					{
						num2 = -960477214;
						num11 = -960477214;
					}
					continue;
				}
				case 20u:
					array[6] = array[6] ^ array2[6];
					num2 = ((int)num3 * -1325084261) ^ 0x4F85C6FE;
					continue;
				case 19u:
					array[13] = array[13] ^ array2[13];
					array[14] = array[14] ^ array2[14];
					num2 = ((int)num3 * -803764440) ^ 0x56438E46;
					continue;
				case 18u:
					array[9] = array[9] ^ array2[9];
					num2 = ((int)num3 * -105536113) ^ 0x2F7BF167;
					continue;
				case 17u:
					array[11] = array[11] ^ array2[11];
					array[12] = array[12] ^ array2[12];
					num2 = ((int)num3 * -527054386) ^ 0x22729F50;
					continue;
				case 16u:
					num10 = 0;
					num2 = (int)((num3 * 634248665) ^ 0x1D716D0A);
					continue;
				case 15u:
					array2 = new uint[16];
					num2 = (int)(num3 * 697322692) ^ -743431567;
					continue;
				case 14u:
				{
					int num9;
					if (num8 < 16)
					{
						num2 = -1337576814;
						num9 = -1337576814;
					}
					else
					{
						num2 = -1654029732;
						num9 = -1654029732;
					}
					continue;
				}
				case 13u:
					array[10] = array[10] ^ array2[10];
					num2 = ((int)num3 * -1949034865) ^ 0xB346FEF;
					continue;
				case 12u:
					array[num8] = array4[num7 + num8];
					num2 = -1386141177;
					continue;
				case 11u:
					num5 = array[num6];
					array3[num4++] = (byte)num5;
					num2 = -1660879826;
					continue;
				case 10u:
					num4 = 0;
					num2 = ((int)num3 * -1001876630) ^ -2095929055;
					continue;
				case 9u:
					array[7] = array[7] ^ array2[7];
					array[8] = array[8] ^ array2[8];
					num2 = (int)((num3 * 2145942063) ^ 0x6C0C59D8);
					continue;
				case 7u:
					num7 += 16;
					num2 = ((int)num3 * -446735836) ^ 0x22D7FFE4;
					continue;
				case 6u:
					array[1] = array[1] ^ array2[1];
					array[2] = array[2] ^ array2[2];
					array[3] = array[3] ^ array2[3];
					array[4] = array[4] ^ array2[4];
					num2 = (int)(num3 * 2022687963) ^ -400780800;
					continue;
				case 5u:
					array3[num4++] = (byte)(num5 >> 16);
					num2 = ((int)num3 * -949279133) ^ 0x39D85AB1;
					continue;
				case 4u:
					array = new uint[16];
					array3 = new byte[num * 4];
					num2 = ((int)num3 * -413807125) ^ -1228121775;
					continue;
				case 3u:
					num6++;
					num2 = ((int)num3 * -912557069) ^ -2116348585;
					continue;
				case 2u:
					array3[num4++] = (byte)(num5 >> 24);
					num2 = (int)((num3 * 757087650) ^ 0x75BAC1E3);
					continue;
				case 1u:
					array3[num4++] = (byte)(num5 >> 8);
					num2 = (int)(num3 * 1606387807) ^ -1539481250;
					continue;
				case 0u:
					array[5] = array[5] ^ array2[5];
					num2 = ((int)num3 * -1735690534) ^ 0x79049636;
					continue;
				default:
					return;
				case 32u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	internal static T smethod_2<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 319591615) ^ 0x626FF7BE;
		uint num = uint_0 >> 30;
		T[] array = default(T[]);
		int count = default(int);
		int num7 = default(int);
		Array array2 = default(Array);
		T result = default(T);
		while (true)
		{
			int num2 = 2104689040;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x3F83DFA6)) % 13)
				{
				case 12u:
					num2 = (int)(num3 * 418364452) ^ -2050695770;
					continue;
				case 11u:
					Buffer.BlockCopy(byte_0, (int)uint_0, array, 0, System.Runtime.CompilerServices.Unsafe.SizeOf<T>());
					num2 = ((int)num3 * -200390942) ^ 0x7511EE7E;
					continue;
				case 10u:
					count = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					num2 = ((int)num3 * -766260534) ^ -466677878;
					continue;
				case 9u:
				{
					num7 = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					int length = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
					num2 = ((int)num3 * -1289920387) ^ 0x3248D6B8;
					continue;
				}
				case 7u:
					Buffer.BlockCopy(byte_0, (int)uint_0, array2, 0, num7 - 4);
					result = (T)(object)array2;
					num2 = ((int)num3 * -1804498415) ^ -1488710886;
					continue;
				case 6u:
				{
					int num8;
					if ((long)num == 2L)
					{
						num2 = 1637823455;
						num8 = 1637823455;
					}
					else
					{
						num2 = 1372364673;
						num8 = 1372364673;
					}
					continue;
				}
				case 5u:
					array = new T[1];
					num2 = ((int)num3 * -1913375468) ^ 0x3D00D957;
					continue;
				case 4u:
				{
					result = default(T);
					uint_0 &= 0x3FFFFFFF;
					uint_0 <<= 2;
					int num5;
					int num6;
					if ((long)num != 0L)
					{
						num5 = 1222715999;
						num6 = 1222715999;
					}
					else
					{
						num5 = 575826946;
						num6 = 575826946;
					}
					num2 = num5 ^ ((int)num3 * -949515245);
					continue;
				}
				case 3u:
					result = (T)(object)string.Intern(Encoding.UTF8.GetString(byte_0, (int)uint_0, count));
					num2 = (int)((num3 * 439078781) ^ 0x752846D);
					continue;
				case 1u:
					result = array[0];
					num2 = (int)((num3 * 12615277) ^ 0x116F24A0);
					continue;
				case 0u:
				{
					int num4;
					if ((long)num == 1L)
					{
						num2 = 559924768;
						num4 = 559924768;
					}
					else
					{
						num2 = 378930538;
						num4 = 378930538;
					}
					continue;
				}
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	internal static T smethod_3<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 119080739) ^ 0xB9668836u;
		T[] array2 = default(T[]);
		T result = default(T);
		Array array = default(Array);
		int count = default(int);
		uint num4 = default(uint);
		int num3 = default(int);
		while (true)
		{
			int num = -1363992508;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -48073947)) % 16)
				{
				case 15u:
					array2 = new T[1];
					Buffer.BlockCopy(byte_0, (int)uint_0, array2, 0, System.Runtime.CompilerServices.Unsafe.SizeOf<T>());
					num = ((int)num2 * -2147045856) ^ -1937608147;
					continue;
				case 12u:
					uint_0 <<= 2;
					num = ((int)num2 * -621262069) ^ -1343341437;
					continue;
				case 11u:
					result = (T)(object)array;
					num = (int)((num2 * 1415169289) ^ 0x61EA2F5B);
					continue;
				case 10u:
					count = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					num = ((int)num2 * -290336298) ^ -774935008;
					continue;
				case 9u:
					result = (T)(object)string.Intern(Encoding.UTF8.GetString(byte_0, (int)uint_0, count));
					num = (int)(num2 * 1342680284) ^ -316184676;
					continue;
				case 8u:
					result = array2[0];
					num = ((int)num2 * -555389148) ^ 0x4730AC58;
					continue;
				case 7u:
				{
					int num8;
					if ((long)num4 == 2L)
					{
						num = -628212486;
						num8 = -628212486;
					}
					else
					{
						num = -1990350943;
						num8 = -1990350943;
					}
					continue;
				}
				case 6u:
					result = default(T);
					uint_0 &= 0x3FFFFFFF;
					num = ((int)num2 * -2082478041) ^ 0x47520FE3;
					continue;
				case 5u:
					num = ((int)num2 * -114047512) ^ 0x5B392F70;
					continue;
				case 4u:
				{
					int num7;
					if ((long)num4 != 3L)
					{
						num = -1690778376;
						num7 = -1690778376;
					}
					else
					{
						num = -114213515;
						num7 = -114213515;
					}
					continue;
				}
				case 3u:
					Buffer.BlockCopy(byte_0, (int)uint_0, array, 0, num3 - 4);
					num = ((int)num2 * -1800054209) ^ -148827357;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if ((long)num4 != 1L)
					{
						num5 = -1899808518;
						num6 = -1899808518;
					}
					else
					{
						num5 = -1866089945;
						num6 = -1866089945;
					}
					num = num5 ^ (int)(num2 * 1040644932);
					continue;
				}
				case 1u:
					num4 = uint_0 >> 30;
					num = ((int)num2 * -1266712988) ^ 0x7B6A3187;
					continue;
				case 0u:
				{
					num3 = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					int length = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					array = Array.CreateInstance(typeof(T).GetElementType(), length);
					num = (int)(num2 * 1144900225) ^ -2039567098;
					continue;
				}
				case 14u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	internal static T smethod_4<T>(uint uint_0)
	{
		uint_0 = (uint)(((int)uint_0 * -236364275) ^ 0x4733CC0C);
		int count = default(int);
		uint num3 = default(uint);
		T result = default(T);
		T[] array2 = default(T[]);
		int num7 = default(int);
		int length = default(int);
		Array array = default(Array);
		while (true)
		{
			int num = -225525275;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2033139848)) % 16)
				{
				case 15u:
					uint_0 <<= 2;
					num = (int)(num2 * 1566060702) ^ -70163336;
					continue;
				case 14u:
					count = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					num = (int)(num2 * 813746646) ^ -2131280736;
					continue;
				case 13u:
					num3 = uint_0 >> 30;
					result = default(T);
					uint_0 &= 0x3FFFFFFF;
					num = ((int)num2 * -2074029314) ^ -1271519;
					continue;
				case 12u:
					result = (T)(object)string.Intern(Encoding.UTF8.GetString(byte_0, (int)uint_0, count));
					num = ((int)num2 * -1374138969) ^ 0x3FB8C15F;
					continue;
				case 10u:
					result = array2[0];
					num = (int)((num2 * 60784189) ^ 0x2FF2AFEF);
					continue;
				case 9u:
					array2 = new T[1];
					Buffer.BlockCopy(byte_0, (int)uint_0, array2, 0, System.Runtime.CompilerServices.Unsafe.SizeOf<T>());
					num = (int)(num2 * 1689533281) ^ -626732373;
					continue;
				case 8u:
				{
					int num8;
					if ((long)num3 == 0L)
					{
						num = -85534273;
						num8 = -85534273;
					}
					else
					{
						num = -391071837;
						num8 = -391071837;
					}
					continue;
				}
				case 7u:
					num7 = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					length = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					num = (int)(num2 * 455720360) ^ -212592394;
					continue;
				case 6u:
					array = Array.CreateInstance(typeof(T).GetElementType(), length);
					Buffer.BlockCopy(byte_0, (int)uint_0, array, 0, num7 - 4);
					num = (int)((num2 * 270900228) ^ 0x8D83DD1);
					continue;
				case 5u:
					num = (int)(num2 * 1481134200) ^ -2115070341;
					continue;
				case 4u:
				{
					int num6;
					if ((long)num3 != 1L)
					{
						num = -1978190192;
						num6 = -1978190192;
					}
					else
					{
						num = -1976241823;
						num6 = -1976241823;
					}
					continue;
				}
				case 3u:
					num = (int)(num2 * 1899503450) ^ -1451549299;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if ((long)num3 != 3L)
					{
						num4 = -595726370;
						num5 = -595726370;
					}
					else
					{
						num4 = -663127100;
						num5 = -663127100;
					}
					num = num4 ^ ((int)num2 * -128543543);
					continue;
				}
				case 1u:
					result = (T)(object)array;
					num = (int)((num2 * 1202731083) ^ 0x1CAB3338);
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	internal static T smethod_5<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 938235797) ^ 0x6B143145;
		uint num3 = default(uint);
		Array array2 = default(Array);
		int length = default(int);
		T result = default(T);
		int num7 = default(int);
		while (true)
		{
			int num = 309777911;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x64A8931E)) % 15)
				{
				case 14u:
				{
					int num6;
					if ((long)num3 != 2L)
					{
						num = 1549440828;
						num6 = 1549440828;
					}
					else
					{
						num = 578997478;
						num6 = 578997478;
					}
					continue;
				}
				case 13u:
					num3 = uint_0 >> 30;
					num = (int)(num2 * 64366174) ^ -211531556;
					continue;
				case 12u:
					num = (int)(num2 * 1866578013) ^ -1085115600;
					continue;
				case 11u:
				{
					int num8;
					if ((long)num3 != 3L)
					{
						num = 785948;
						num8 = 785948;
					}
					else
					{
						num = 590279660;
						num8 = 590279660;
					}
					continue;
				}
				case 9u:
					array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
					num = ((int)num2 * -1008495083) ^ -161300101;
					continue;
				case 8u:
				{
					int count = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					result = (T)(object)string.Intern(Encoding.UTF8.GetString(byte_0, (int)uint_0, count));
					num = (int)(num2 * 1765967801) ^ -2038960710;
					continue;
				}
				case 7u:
					result = default(T);
					num = ((int)num2 * -1368445227) ^ -2080396822;
					continue;
				case 5u:
					num7 = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					length = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					num = (int)(num2 * 229401068) ^ -479157249;
					continue;
				case 4u:
					Buffer.BlockCopy(byte_0, (int)uint_0, array2, 0, num7 - 4);
					result = (T)(object)array2;
					num = ((int)num2 * -1096709213) ^ -1188856148;
					continue;
				case 3u:
				{
					T[] array = new T[1];
					Buffer.BlockCopy(byte_0, (int)uint_0, array, 0, System.Runtime.CompilerServices.Unsafe.SizeOf<T>());
					result = array[0];
					num = ((int)num2 * -2044176226) ^ 0x4B37153E;
					continue;
				}
				case 2u:
					uint_0 &= 0x3FFFFFFF;
					num = (int)((num2 * 399251689) ^ 0x6E7F9335);
					continue;
				case 1u:
				{
					uint_0 <<= 2;
					int num4;
					int num5;
					if ((long)num3 == 0L)
					{
						num4 = -785236726;
						num5 = -785236726;
					}
					else
					{
						num4 = -1105255177;
						num5 = -1105255177;
					}
					num = num4 ^ ((int)num2 * -2055893936);
					continue;
				}
				case 0u:
					num = (int)((num2 * 1974259005) ^ 0x399BFBDC);
					continue;
				case 10u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	internal static T smethod_6<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 1979878659) ^ 0x66B4C8EC;
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 0x3FFFFFFF;
		Array array2 = default(Array);
		T[] array = default(T[]);
		int length = default(int);
		int num4 = default(int);
		int count = default(int);
		while (true)
		{
			int num2 = -947709337;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1152731815)) % 18)
				{
				case 17u:
					num2 = (int)(num3 * 392289306) ^ -744583729;
					continue;
				case 16u:
					uint_0 <<= 2;
					num2 = (int)(num3 * 1386945789) ^ -1189447478;
					continue;
				case 15u:
				{
					int num6;
					if ((long)num != 2L)
					{
						num2 = -1298802895;
						num6 = -1298802895;
					}
					else
					{
						num2 = -561386887;
						num6 = -561386887;
					}
					continue;
				}
				case 13u:
				{
					int num7;
					int num8;
					if ((long)num != 3L)
					{
						num7 = 71150165;
						num8 = 71150165;
					}
					else
					{
						num7 = 719864777;
						num8 = 719864777;
					}
					num2 = num7 ^ ((int)num3 * -387768235);
					continue;
				}
				case 12u:
					result = (T)(object)array2;
					num2 = ((int)num3 * -1824200518) ^ 0x5635BC65;
					continue;
				case 10u:
					array = new T[1];
					num2 = ((int)num3 * -1239555787) ^ -3122323;
					continue;
				case 9u:
					num2 = (int)(num3 * 142071794) ^ -201581193;
					continue;
				case 8u:
					length = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					num2 = ((int)num3 * -88869405) ^ 0x7588CFE4;
					continue;
				case 7u:
					result = array[0];
					num2 = (int)((num3 * 1466185745) ^ 0x3EA55BF3);
					continue;
				case 6u:
					num4 = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					num2 = ((int)num3 * -575163344) ^ -1616570005;
					continue;
				case 5u:
					count = byte_0[uint_0++] | (byte_0[uint_0++] << 8) | (byte_0[uint_0++] << 16) | (byte_0[uint_0++] << 24);
					num2 = ((int)num3 * -1615198869) ^ -776853620;
					continue;
				case 4u:
					result = (T)(object)string.Intern(Encoding.UTF8.GetString(byte_0, (int)uint_0, count));
					num2 = ((int)num3 * -1052153187) ^ -1603862980;
					continue;
				case 3u:
				{
					int num5;
					if ((long)num == 1L)
					{
						num2 = -885776363;
						num5 = -885776363;
					}
					else
					{
						num2 = -908551498;
						num5 = -908551498;
					}
					continue;
				}
				case 2u:
					Buffer.BlockCopy(byte_0, (int)uint_0, array2, 0, num4 - 4);
					num2 = ((int)num3 * -1128537617) ^ 0x41050F9;
					continue;
				case 1u:
					array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
					num2 = (int)(num3 * 984759928) ^ -88552833;
					continue;
				case 0u:
					Buffer.BlockCopy(byte_0, (int)uint_0, array, 0, System.Runtime.CompilerServices.Unsafe.SizeOf<T>());
					num2 = ((int)num3 * -1195227427) ^ -1809995664;
					continue;
				case 11u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}
}
