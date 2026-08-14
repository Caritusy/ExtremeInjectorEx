using System.IO;

internal static class Class179
{
	internal sealed class Class180
	{
		internal static readonly int[] int_0 = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		internal static readonly int[] int_1 = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		internal static readonly int[] int_2 = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		internal static readonly int[] int_3;

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		internal bool bool_0;

		internal Class181 class181_0;

		internal Class182 class182_0;

		internal Class184 class184_0;

		internal Class183 class183_0;

		internal Class183 class183_1;

		public Class180(byte[] byte_0)
		{
			class181_0 = new Class181();
			class182_0 = new Class182();
			int_4 = 2;
			Class171.smethod_245(byte_0.Length, byte_0, 0, class181_0);
		}

		static Class180()
		{
			while (true)
			{
				int num = 196633568;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x64962AE6)) % 3)
					{
					case 2u:
						goto IL_0047;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0047:
					int_3 = new int[30]
					{
						0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
						4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
						9, 9, 10, 10, 11, 11, 12, 12, 13, 13
					};
					num = (int)((num2 * 356489799) ^ 0x3ED44919);
				}
			}
		}
	}

	internal sealed class Class181
	{
		internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;
	}

	internal sealed class Class182
	{
		internal byte[] byte_0 = new byte[32768];

		internal int int_0;

		internal int int_1;
	}

	internal sealed class Class183
	{
		internal short[] short_0;

		public static readonly Class183 class183_0;

		public static readonly Class183 class183_1;

		static Class183()
		{
			byte[] array = new byte[288];
			int num3 = default(int);
			while (true)
			{
				int num = -44714076;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -122681445)) % 19)
					{
					case 18u:
						num = (int)((num2 * 717392306) ^ 0x3F58EA17);
						continue;
					case 17u:
						class183_1 = new Class183(array);
						num = ((int)num2 * -1644774681) ^ 0x7747EE3D;
						continue;
					case 16u:
					{
						int num8;
						if (num3 < 32)
						{
							num = -1850357592;
							num8 = -1850357592;
						}
						else
						{
							num = -1896313086;
							num8 = -1896313086;
						}
						continue;
					}
					case 15u:
						num3 = 0;
						num = (int)(num2 * 978643551) ^ -425427479;
						continue;
					case 14u:
						array[num3++] = 5;
						num = -1070852979;
						continue;
					case 13u:
					{
						int num5;
						if (num3 < 288)
						{
							num = -696200526;
							num5 = -696200526;
						}
						else
						{
							num = -1582026306;
							num5 = -1582026306;
						}
						continue;
					}
					case 12u:
						array[num3++] = 8;
						num = -944120731;
						continue;
					case 11u:
						array[num3++] = 7;
						num = -253884022;
						continue;
					case 10u:
					{
						int num7;
						if (num3 >= 256)
						{
							num = -2006843215;
							num7 = -2006843215;
						}
						else
						{
							num = -1383922859;
							num7 = -1383922859;
						}
						continue;
					}
					case 9u:
						array[num3++] = 9;
						num = -1473003053;
						continue;
					case 8u:
					{
						int num6;
						if (num3 >= 280)
						{
							num = -1549096097;
							num6 = -1549096097;
						}
						else
						{
							num = -893665810;
							num6 = -893665810;
						}
						continue;
					}
					case 7u:
						class183_0 = new Class183(array);
						array = new byte[32];
						num3 = 0;
						num = (int)(num2 * 1417364489) ^ -929500189;
						continue;
					case 6u:
						array[num3++] = 8;
						num = -660242296;
						continue;
					case 5u:
					{
						int num4;
						if (num3 < 144)
						{
							num = -712009787;
							num4 = -712009787;
						}
						else
						{
							num = -130873303;
							num4 = -130873303;
						}
						continue;
					}
					case 3u:
						num = (int)((num2 * 946577588) ^ 0x171E25B5);
						continue;
					case 2u:
						num = (int)((num2 * 1455581191) ^ 0x80FA6FE);
						continue;
					case 1u:
						num = (int)(num2 * 1333452591) ^ -99684548;
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

		public Class183(byte[] byte_0)
		{
			while (true)
			{
				int num = -791406439;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1193664697)) % 3)
					{
					case 2u:
						goto IL_0008;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0008:
					Class171.smethod_243(byte_0, this);
					num = ((int)num2 * -494103307) ^ 0x2ED9B360;
				}
			}
		}
	}

	internal sealed class Class184
	{
		internal static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		internal static readonly int[] int_1 = new int[3] { 2, 3, 7 };

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal Class183 class183_0;

		internal int int_2;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal byte byte_2;

		internal int int_8;

		internal static readonly int[] int_9 = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};
	}

	internal sealed class Class185
	{
		private static readonly int[] int_0;

		internal static readonly byte[] byte_0;

		private static readonly short[] short_0;

		private static readonly byte[] byte_1;

		private static readonly short[] short_1;

		private static readonly byte[] byte_2;

		static Class185()
		{
			int_0 = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
			byte_0 = new byte[16]
			{
				0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
				5, 13, 3, 11, 7, 15
			};
			short_0 = new short[286];
			int num3 = default(int);
			while (true)
			{
				int num = 574486690;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x5B5CAD55)) % 20)
					{
					case 19u:
						num = (int)((num2 * 2144360451) ^ 0x1A742894);
						continue;
					case 18u:
						short_0[num3] = Class171.smethod_316(-256 + num3 << 9);
						num = 1543603441;
						continue;
					case 17u:
						short_1[num3] = Class171.smethod_316(num3 << 11);
						byte_2[num3] = 5;
						num = 1914358248;
						continue;
					case 16u:
					{
						int num7;
						if (num3 < 280)
						{
							num = 765201019;
							num7 = 765201019;
						}
						else
						{
							num = 387500689;
							num7 = 387500689;
						}
						continue;
					}
					case 15u:
						byte_1 = new byte[286];
						num3 = 0;
						num = ((int)num2 * -840187333) ^ 0x2EC319D6;
						continue;
					case 14u:
						num = ((int)num2 * -864566418) ^ -1795961378;
						continue;
					case 13u:
						short_0[num3] = Class171.smethod_316(48 + num3 << 8);
						byte_1[num3++] = 8;
						num = 1423022746;
						continue;
					case 12u:
					{
						int num8;
						if (num3 >= 286)
						{
							num = 1976658626;
							num8 = 1976658626;
						}
						else
						{
							num = 1620162425;
							num8 = 1620162425;
						}
						continue;
					}
					case 11u:
					{
						int num6;
						if (num3 < 256)
						{
							num = 1275307187;
							num6 = 1275307187;
						}
						else
						{
							num = 1316187446;
							num6 = 1316187446;
						}
						continue;
					}
					case 10u:
					{
						int num5;
						if (num3 < 30)
						{
							num = 2017040136;
							num5 = 2017040136;
						}
						else
						{
							num = 708634571;
							num5 = 708634571;
						}
						continue;
					}
					case 8u:
						num = ((int)num2 * -1376209442) ^ 0x16A6AF81;
						continue;
					case 7u:
						short_1 = new short[30];
						byte_2 = new byte[30];
						num3 = 0;
						num = ((int)num2 * -1974345022) ^ -2103560595;
						continue;
					case 5u:
						num3++;
						num = ((int)num2 * -1533683786) ^ 0x5052E15D;
						continue;
					case 4u:
						short_0[num3] = Class171.smethod_316(-88 + num3 << 8);
						byte_1[num3++] = 8;
						num = 1814634617;
						continue;
					case 3u:
					{
						int num4;
						if (num3 >= 144)
						{
							num = 1196581596;
							num4 = 1196581596;
						}
						else
						{
							num = 1352333268;
							num4 = 1352333268;
						}
						continue;
					}
					case 2u:
						short_0[num3] = Class171.smethod_316(256 + num3 << 7);
						byte_1[num3++] = 9;
						num = 822905662;
						continue;
					case 1u:
						num = ((int)num2 * -2073674641) ^ -961899687;
						continue;
					case 0u:
						byte_1[num3++] = 7;
						num = ((int)num2 * -546446449) ^ 0x429FCF21;
						continue;
					default:
						return;
					case 9u:
						break;
					case 6u:
						return;
					}
					break;
				}
			}
		}
	}

	internal sealed class Stream1 : MemoryStream
	{
		public Stream1(byte[] byte_0)
			: base(byte_0, writable: false)
		{
		}
	}
}
