using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static class Class169
{
	internal struct Struct59
	{
		public uint uint_0;

		public uint uint_1;

		private uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;
	}

	internal struct Struct60
	{
		public uint uint_0;

		public uint uint_1;
	}

	internal struct Struct61
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		private uint uint_6;

		private uint uint_7;
	}

	internal struct Struct62
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;
	}

	internal struct Struct63
	{
		public uint uint_0;

		public uint uint_1;
	}

	internal struct Struct64
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;
	}

	internal struct Struct65
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;
	}

	internal struct Struct66
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;
	}

	internal struct Struct67
	{
		public uint uint_0;
	}

	internal struct Struct68
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;
	}

	internal struct Struct69
	{
		public uint uint_0;

		public uint uint_1;
	}

	[CompilerGenerated]
	internal sealed class Class170
	{
		public string string_0;

		internal bool method_0(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return string_0.IndexOf(keyValuePair_0.Key) != -1;
		}
	}

	internal static Dictionary<string, List<string>> dictionary_0;

	static Class169()
	{
		dictionary_0 = new Dictionary<string, List<string>>();
		try
		{
			if (!Class127.bool_2)
			{
				goto IL_0144;
			}
			goto IL_01b9;
			IL_0144:
			int num = 349269374;
			goto IL_0167;
			IL_0167:
			IntPtr intPtr = default(IntPtr);
			GClass2 gclass2_ = default(GClass2);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4C198557)) % 16)
				{
				case 15u:
					break;
				case 14u:
					Class171.smethod_340(intPtr);
					num = (int)((num2 * 133978026) ^ 0x7F1745CB);
					continue;
				case 12u:
					goto IL_0080;
				case 11u:
					goto IL_00a3;
				case 10u:
					Class171.smethod_119(intPtr);
					num = (int)(num2 * 1784602965) ^ -189528296;
					continue;
				case 8u:
					goto IL_00c3;
				case 7u:
				{
					int num3;
					int num4;
					if (Class171.smethod_183(intPtr))
					{
						num3 = 263686937;
						num4 = 263686937;
					}
					else
					{
						num3 = 2127447680;
						num4 = 2127447680;
					}
					num = num3 ^ (int)(num2 * 1001523022);
					continue;
				}
				case 6u:
					goto IL_010f;
				case 4u:
					Class171.smethod_235(intPtr);
					num = ((int)num2 * -949187477) ^ -198061526;
					continue;
				case 3u:
					goto end_IL_0167;
				case 1u:
					num = ((int)num2 * -766021260) ^ -733024530;
					continue;
				case 0u:
					num = (int)(num2 * 1317096156) ^ -494846310;
					continue;
				default:
					return;
				case 2u:
					goto IL_01b9;
				case 5u:
					return;
				case 9u:
					return;
				case 13u:
					return;
				}
				if (!Class171.smethod_418(gclass2_))
				{
					num = (int)(num2 * 979097383) ^ -448170699;
					continue;
				}
				object obj = Class171.smethod_249(gclass2_);
				goto IL_0039;
				IL_010f:
				int num5;
				if (!Class127.bool_2)
				{
					num = 2116528346;
					num5 = 2116528346;
				}
				else
				{
					num = 1986895341;
					num5 = 1986895341;
				}
				continue;
				IL_0080:
				int num6;
				if (Class127.bool_7)
				{
					num = 1836794611;
					num6 = 1836794611;
				}
				else
				{
					num = 436100847;
					num6 = 436100847;
				}
				continue;
				IL_0039:
				intPtr = ((Class117)obj).Class117_002E_200F_200C_202D_206D_200D_206C_200F_206F_202B_206C_202B_206C_206E_206F_200F_202C_202E_202A_202C_202E_202B_206B_200D_200E_202E_206C_206E_202D_202D_202B_206C_202B_206E_206B_206D_200D_206F_202D_200D_202C_202E();
				int num7;
				if (!(intPtr == IntPtr.Zero))
				{
					num = 2042119616;
					num7 = 2042119616;
				}
				else
				{
					num = 121932162;
					num7 = 121932162;
				}
				continue;
				IL_00c3:
				int num8;
				if (!Class127.bool_6)
				{
					num = 190208129;
					num8 = 190208129;
				}
				else
				{
					num = 1270059529;
					num8 = 1270059529;
				}
				continue;
				IL_00a3:
				obj = Class171.smethod_363(gclass2_);
				goto IL_0039;
				continue;
				end_IL_0167:
				break;
			}
			goto IL_0144;
			IL_01b9:
			gclass2_ = Class171.smethod_206();
			num = 1429077992;
			goto IL_0167;
		}
		catch
		{
		}
	}

	internal static U[] smethod_0<T, U>(IntPtr intptr_0) where T : struct where U : struct
	{
		int num = typeof(T).smethod_7();
		IntPtr intPtr = intptr_0.smethod_8(num - 4);
		U[] array = default(U[]);
		int num6 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = -1176202962;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1907594869)) % 13)
				{
				case 12u:
					array[num6] = (U)Marshal.PtrToStructure(intPtr2, typeof(U));
					num2 = -285090992;
					continue;
				case 11u:
				{
					intPtr2 = intptr_0.smethod_8(num4 * num6);
					int num9;
					if (!Class171.smethod_183(intPtr2))
					{
						num2 = -167464756;
						num9 = -167464756;
					}
					else
					{
						num2 = -1137399727;
						num9 = -1137399727;
					}
					continue;
				}
				case 10u:
				{
					int num10;
					if (num6 < num5)
					{
						num2 = -668948579;
						num10 = -668948579;
					}
					else
					{
						num2 = -1343833363;
						num10 = -1343833363;
					}
					continue;
				}
				case 6u:
					num6 = 0;
					num2 = (int)(num3 * 1769655649) ^ -1909233994;
					continue;
				case 5u:
				{
					int num7;
					int num8;
					if (Class171.smethod_183(intPtr))
					{
						num7 = 178372332;
						num8 = 178372332;
					}
					else
					{
						num7 = 1277327886;
						num8 = 1277327886;
					}
					num2 = num7 ^ ((int)num3 * -1223382523);
					continue;
				}
				case 4u:
					num6++;
					num2 = ((int)num3 * -1767482405) ^ -1483248001;
					continue;
				case 3u:
					num5 = Marshal.ReadInt32(intPtr);
					intptr_0 = intptr_0.smethod_8(num);
					num2 = -1062384333;
					continue;
				case 1u:
					array = new U[num5];
					num2 = ((int)num3 * -1472543404) ^ 0x17D2FE9B;
					continue;
				case 0u:
					num4 = typeof(U).smethod_7();
					num2 = ((int)num3 * -730041885) ^ -2122295869;
					continue;
				case 8u:
					break;
				case 2u:
					return new U[0];
				case 7u:
					return new U[0];
				default:
					return array;
				}
				break;
			}
		}
	}
}
