using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public static class Class169
{
	public struct Struct59
	{
		public uint uint_0;

		public uint uint_1;

		internal uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;
	}

	public struct Struct60
	{
		public uint uint_0;

		public uint uint_1;
	}

	public struct Struct61
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		internal uint uint_6;

		internal uint uint_7;
	}

	public struct Struct62
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;
	}

	public struct Struct63
	{
		public uint uint_0;

		public uint uint_1;
	}

	public struct Struct64
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;
	}

	public struct Struct65
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;
	}

	public struct Struct66
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;
	}

	public struct Struct67
	{
		public uint uint_0;
	}

	public struct Struct68
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;
	}

	public struct Struct69
	{
		public uint uint_0;

		public uint uint_1;
	}

	[CompilerGenerated]
	public sealed class Class170
	{
		public string string_0;

		internal bool method_0(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return smethod_0(string_0, keyValuePair_0.Key) != -1;
		}

		internal static int smethod_0(string string_1, string string_2)
		{
			return string_1.IndexOf(string_2);
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
					Class171.smethod_346(intPtr);
					num = (int)((num2 * 133978026) ^ 0x7F1745CB);
					continue;
				case 12u:
					goto IL_0080;
				case 11u:
					goto IL_00a3;
				case 10u:
					Class171.smethod_120(intPtr);
					num = (int)(num2 * 1784602965) ^ -189528296;
					continue;
				case 8u:
					goto IL_00c3;
				case 7u:
					num = ((!Class171.smethod_184(intPtr)) ? 2127447680 : 263686937) ^ (int)(num2 * 1001523022);
					continue;
				case 6u:
					goto IL_010f;
				case 4u:
					Class171.smethod_241(intPtr);
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
				if (!Class171.smethod_427(gclass2_))
				{
					num = (int)(num2 * 979097383) ^ -448170699;
					continue;
				}
				object obj = Class171.smethod_255(gclass2_);
				goto IL_0039;
				IL_010f:
				num = (Class127.bool_2 ? 1986895341 : 2116528346);
				continue;
				IL_0080:
				num = ((!Class127.bool_7) ? 436100847 : 1836794611);
				continue;
				IL_0039:
				intPtr = ((Class117)obj).method_0822();
				num = ((intPtr == IntPtr.Zero) ? 121932162 : 2042119616);
				continue;
				IL_00c3:
				num = (Class127.bool_6 ? 1270059529 : 190208129);
				continue;
				IL_00a3:
				obj = Class171.smethod_369(gclass2_);
				goto IL_0039;
				continue;
				end_IL_0167:
				break;
			}
			goto IL_0144;
			IL_01b9:
			gclass2_ = Class171.smethod_211();
			num = 1429077992;
			goto IL_0167;
		}
		catch
		{
		}
	}

	internal static U[] smethod_0<T, U>(IntPtr intptr_0) where T : struct where U : struct
	{
		int num = smethod_1(typeof(T).TypeHandle).smethod_7();
		IntPtr intptr_1 = intptr_0.smethod_8(num - 4);
		U[] array = default(U[]);
		int num6 = default(int);
		IntPtr intptr_2 = default(IntPtr);
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
					array[num6] = (U)smethod_3(intptr_2, smethod_1(typeof(U).TypeHandle));
					num2 = -285090992;
					continue;
				case 11u:
					intptr_2 = intptr_0.smethod_8(num4 * num6);
					num2 = (Class171.smethod_184(intptr_2) ? (-1137399727) : (-167464756));
					continue;
				case 10u:
					num2 = ((num6 >= num5) ? (-1343833363) : (-668948579));
					continue;
				case 6u:
					num6 = 0;
					num2 = (int)(num3 * 1769655649) ^ -1909233994;
					continue;
				case 5u:
					num2 = ((!Class171.smethod_184(intptr_1)) ? 1277327886 : 178372332) ^ ((int)num3 * -1223382523);
					continue;
				case 4u:
					num6++;
					num2 = ((int)num3 * -1767482405) ^ -1483248001;
					continue;
				case 3u:
					num5 = smethod_2(intptr_1);
					intptr_0 = intptr_0.smethod_8(num);
					num2 = -1062384333;
					continue;
				case 1u:
					array = new U[num5];
					num2 = ((int)num3 * -1472543404) ^ 0x17D2FE9B;
					continue;
				case 0u:
					num4 = smethod_1(typeof(U).TypeHandle).smethod_7();
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

	internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int smethod_2(IntPtr intptr_0)
	{
		return Marshal.ReadInt32(intptr_0);
	}

	internal static object smethod_3(IntPtr intptr_0, Type type_0)
	{
		return Marshal.PtrToStructure(intptr_0, type_0);
	}
}
