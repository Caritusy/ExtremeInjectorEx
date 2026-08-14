using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class PlatformInfo
{
	public delegate void Delegate47(IntPtr intptr_0, IntPtr intptr_1, uint uint_0);

	public static class Class128<T>
	{
		public static readonly int int_0 = RecoveredRuntime.smethod_18(smethod_0(typeof(T).TypeHandle));

		internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}
	}

	public static readonly bool bool_0;

	internal static Dictionary<Type, int> dictionary_0;

	public static readonly Random random_0;

	public static readonly Random random_1;

	public static readonly bool bool_1;

	public static readonly bool bool_2;

	public static readonly bool bool_3;

	public static readonly bool bool_4;

	public static readonly bool bool_5;

	public static readonly bool bool_6;

	public static readonly bool bool_7;

	public static readonly bool bool_8;

	public static readonly bool bool_9;

	public static readonly bool bool_10;

	public static readonly bool bool_11;

	public static readonly string string_0;

	public static readonly string string_1;

	public static readonly string string_2;

	public static readonly string string_3;

	internal static Delegate47 delegate47_0;

	internal static Delegate47 delegate47_1;

	internal static Delegate47 delegate47_2;

	internal static Delegate47 delegate47_3;

	static PlatformInfo()
	{
		bool_0 = IntPtr.Size == 8;
		while (true)
		{
			int num = 785762824;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7A4C9924)) % 14)
				{
				case 13u:
					random_0 = new Random();
					random_1 = new CryptoRandom<RNGCryptoServiceProvider>();
					num = ((int)num2 * -1385003535) ^ 0x3E79236D;
					continue;
				case 12u:
					bool_1 = RecoveredRuntime.smethod_295(0, 0, 6, -1);
					bool_2 = RecoveredRuntime.smethod_295(1, 0, 6, -1);
					num = ((int)num2 * -734284144) ^ -1913130437;
					continue;
				case 11u:
					bool_11 = RecoveredRuntime.smethod_295(1, 0, 10, -1);
					string_0 = RecoveredRuntime.smethod_268();
					string_1 = Path.Combine(string_0, "System32");
					num = ((int)num2 * -1596869225) ^ -1691147287;
					continue;
				case 10u:
					dictionary_0 = new Dictionary<Type, int>();
					num = ((int)num2 * -149697368) ^ 0x75F5A7BF;
					continue;
				case 9u:
					bool_3 = RecoveredRuntime.smethod_295(1, 2, 5, -1);
					num = (int)((num2 * 461316453) ^ 0x11261B4C);
					continue;
				case 8u:
					string_2 = Path.Combine(string_0, "SysWOW64");
					string_3 = Path.Combine(string_0, "System");
					num = ((int)num2 * -1065768862) ^ -162682761;
					continue;
				case 7u:
					bool_4 = RecoveredRuntime.smethod_295(1, 3, 5, -1);
					num = (int)((num2 * 1941506399) ^ 0x455E538D);
					continue;
				case 6u:
					bool_6 = RecoveredRuntime.smethod_295(3, 0, 6, -1);
					bool_7 = RecoveredRuntime.smethod_295(0, 0, 10, -1);
					bool_8 = RecoveredRuntime.smethod_295(0, 0, 10, 14393);
					num = ((int)num2 * -1165024855) ^ 0xFDD34F7;
					continue;
				case 5u:
					delegate47_1 = RecoveredRuntime.smethod_276(1);
					delegate47_2 = RecoveredRuntime.smethod_276(2);
					num = (int)(num2 * 2006310185) ^ -1609768697;
					continue;
				case 3u:
					delegate47_0 = RecoveredRuntime.smethod_276(-1);
					num = ((int)num2 * -251384883) ^ 0x4B12ABB6;
					continue;
				case 1u:
					bool_9 = RecoveredRuntime.smethod_295(0, 0, 10, 15063);
					bool_10 = RecoveredRuntime.smethod_295(0, 0, 10, 16299);
					num = ((int)num2 * -380392191) ^ -131118160;
					continue;
				case 0u:
					bool_5 = RecoveredRuntime.smethod_295(2, 0, 6, -1);
					num = (int)((num2 * 801173293) ^ 0x3F38FAEC);
					continue;
				case 4u:
					break;
				default:
					delegate47_3 = RecoveredRuntime.smethod_276(4);
					return;
				}
				break;
			}
		}
	}

	public static string smethod_0(string string_4)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		int num = 65;
		string text = default(string);
		while (true)
		{
			int num2 = -148992939;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -809952565)) % 9)
				{
				case 8u:
					num2 = ((num <= 90) ? (-144746047) : (-1426309202));
					continue;
				case 7u:
					num2 = ((!string_4.StartsWith(text, StringComparison.OrdinalIgnoreCase)) ? (-1324767620) : (-1257430776)) ^ ((int)num3 * -2382358);
					continue;
				case 3u:
					num2 = (int)(num3 * 965295887) ^ -538819705;
					continue;
				case 2u:
					num++;
					num2 = -2020411707;
					continue;
				case 1u:
					text = stringBuilder.ToString();
					num2 = (int)(num3 * 1426971958) ^ -2098007821;
					continue;
				case 0u:
					num2 = ((RecoveredRuntime.QueryDosDevice((char)num + ":", stringBuilder, stringBuilder.Capacity) != 0) ? (-573336900) : (-1118227608));
					continue;
				case 4u:
					break;
				default:
					return string.Empty;
				case 6u:
					return (char)num + ":" + string_4.Substring(text.Length, string_4.Length - text.Length);
				}
				break;
			}
		}
	}

	public static int smethod_1<T>()
	{
		return Class128<T>.int_0;
	}

	public static T smethod_2<T>(this T[] gparam_0)
	{
		return gparam_0[random_0.Next(gparam_0.Length)];
	}

	public static int smethod_3<T>(this T[] gparam_0)
	{
		return random_0.Next(gparam_0.Length);
	}

	public static void smethod_4<T>(this IList<T> ilist_0)
	{
		int num = ilist_0.Count;
		while (true)
		{
			int num2 = -1022698819;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -611829558)) % 6)
				{
				case 5u:
					num--;
					num2 = -1520639442;
					continue;
				case 4u:
				{
					int index = random_0.Next(num + 1);
					T value = ilist_0[index];
					ilist_0[index] = ilist_0[num];
					ilist_0[num] = value;
					num2 = ((int)num3 * -158741573) ^ 0x5F1E826A;
					continue;
				}
				case 2u:
					num2 = ((num <= 1) ? (-1373145505) : (-1131731149));
					continue;
				case 1u:
					num2 = ((int)num3 * -710185996) ^ -1377262454;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	internal static Random smethod_5()
	{
		return new Random();
	}

	internal static string smethod_6(string string_4, string string_5)
	{
		return Path.Combine(string_4, string_5);
	}

	internal static StringBuilder smethod_7(int int_0)
	{
		return new StringBuilder(int_0);
	}

	internal static int smethod_8(Random random_2, int int_0)
	{
		return random_2.Next(int_0);
	}
}
