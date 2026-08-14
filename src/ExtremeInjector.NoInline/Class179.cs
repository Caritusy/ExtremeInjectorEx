using System;
using System.IO;
using System.Runtime.CompilerServices;

public static class Class179
{
	public sealed class Class180
	{
		internal static readonly int[] int_0;

		internal static readonly int[] int_1;

		internal static readonly int[] int_2;

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
			Class171.smethod_251(byte_0.Length, byte_0, 0, class181_0);
		}

		static Class180()
		{
			int[] array_ = new int[29];
			smethod_0(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int_0 = array_;
			int[] array_2 = new int[29];
			smethod_0(array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int_1 = array_2;
			int[] array_3 = new int[30];
			smethod_0(array_3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int_2 = array_3;
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
					int[] array_4 = new int[30];
					smethod_0(array_4, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
					int_3 = array_4;
					num = (int)((num2 * 356489799) ^ 0x3ED44919);
				}
			}
		}

		internal static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}
	}

	public sealed class Class181
	{
		internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;
	}

	public sealed class Class182
	{
		internal byte[] byte_0 = new byte[32768];

		internal int int_0;

		internal int int_1;
	}

	public sealed class Class183
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
						num = ((num3 >= 32) ? (-1896313086) : (-1850357592));
						continue;
					case 15u:
						num3 = 0;
						num = (int)(num2 * 978643551) ^ -425427479;
						continue;
					case 14u:
						array[num3++] = 5;
						num = -1070852979;
						continue;
					case 13u:
						num = ((num3 >= 288) ? (-1582026306) : (-696200526));
						continue;
					case 12u:
						array[num3++] = 8;
						num = -944120731;
						continue;
					case 11u:
						array[num3++] = 7;
						num = -253884022;
						continue;
					case 10u:
						num = ((num3 < 256) ? (-1383922859) : (-2006843215));
						continue;
					case 9u:
						array[num3++] = 9;
						num = -1473003053;
						continue;
					case 8u:
						num = ((num3 < 280) ? (-893665810) : (-1549096097));
						continue;
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
						num = ((num3 >= 144) ? (-130873303) : (-712009787));
						continue;
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
					Class171.smethod_249(byte_0, this);
					num = ((int)num2 * -494103307) ^ 0x2ED9B360;
				}
			}
		}
	}

	public sealed class Class184
	{
		internal static readonly int[] int_0;

		internal static readonly int[] int_1;

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

		internal static readonly int[] int_9;

		static Class184()
		{
			int[] array_ = new int[3];
			smethod_0(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int_0 = array_;
			int[] array_2 = new int[3];
			smethod_0(array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int_1 = array_2;
			int[] array_3 = new int[19];
			smethod_0(array_3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int_9 = array_3;
		}

		internal static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}
	}

	public sealed class Class185
	{
		internal static readonly int[] int_0;

		internal static readonly byte[] byte_0;

		internal static readonly short[] short_0;

		internal static readonly byte[] byte_1;

		internal static readonly short[] short_1;

		internal static readonly byte[] byte_2;

		static Class185()
		{
			int[] array_ = new int[19];
			smethod_0(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			int_0 = array_;
			byte[] array_2 = new byte[16];
			smethod_0(array_2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte_0 = array_2;
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
						short_0[num3] = Class171.smethod_322(-256 + num3 << 9);
						num = 1543603441;
						continue;
					case 17u:
						short_1[num3] = Class171.smethod_322(num3 << 11);
						byte_2[num3] = 5;
						num = 1914358248;
						continue;
					case 16u:
						num = ((num3 >= 280) ? 387500689 : 765201019);
						continue;
					case 15u:
						byte_1 = new byte[286];
						num3 = 0;
						num = ((int)num2 * -840187333) ^ 0x2EC319D6;
						continue;
					case 14u:
						num = ((int)num2 * -864566418) ^ -1795961378;
						continue;
					case 13u:
						short_0[num3] = Class171.smethod_322(48 + num3 << 8);
						byte_1[num3++] = 8;
						num = 1423022746;
						continue;
					case 12u:
						num = ((num3 < 286) ? 1620162425 : 1976658626);
						continue;
					case 11u:
						num = ((num3 >= 256) ? 1316187446 : 1275307187);
						continue;
					case 10u:
						num = ((num3 >= 30) ? 708634571 : 2017040136);
						continue;
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
						short_0[num3] = Class171.smethod_322(-88 + num3 << 8);
						byte_1[num3++] = 8;
						num = 1814634617;
						continue;
					case 3u:
						num = ((num3 < 144) ? 1352333268 : 1196581596);
						continue;
					case 2u:
						short_0[num3] = Class171.smethod_322(256 + num3 << 7);
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

		internal static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}
	}

	public sealed class Stream1 : MemoryStream
	{
		public Stream1(byte[] byte_0)
			: base(byte_0, writable: false)
		{
		}
	}
}
