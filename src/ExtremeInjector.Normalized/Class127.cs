using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class Class127
{
	public delegate void Delegate47(IntPtr intptr_0, IntPtr intptr_1, uint uint_0);

	public static class Class128<T>
	{
		public static readonly int int_0 = Class171.smethod_18(Class128<T>._200F_200C_206E_202E_206F_202A_206B_202D_202C_202B_206C_202A_200D_206E_202A_202E_200B_202A_202B_202B_200F_206D_202C_206B_200B_202D_206C_200F_206C_202C_202E_206A_206C_206A_202C_202C_206F_202E_206C_202E_202E(typeof(T).TypeHandle));
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

	private static Delegate47 delegate47_0;

	private static Delegate47 delegate47_1;

	private static Delegate47 delegate47_2;

	private static Delegate47 delegate47_3;

	static Class127()
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
					random_1 = new Class126<RNGCryptoServiceProvider>();
					num = ((int)num2 * -1385003535) ^ 0x3E79236D;
					continue;
				case 12u:
					bool_1 = Class171.smethod_289(0, (ushort)0, 6, -1);
					bool_2 = Class171.smethod_289(1, (ushort)0, 6, -1);
					num = ((int)num2 * -734284144) ^ -1913130437;
					continue;
				case 11u:
					bool_11 = Class171.smethod_289(1, (ushort)0, 10, -1);
					string_0 = Class171.smethod_262();
					string_1 = Path.Combine(string_0, Class178.smethod_0(9674));
					num = ((int)num2 * -1596869225) ^ -1691147287;
					continue;
				case 10u:
					dictionary_0 = new Dictionary<Type, int>();
					num = ((int)num2 * -149697368) ^ 0x75F5A7BF;
					continue;
				case 9u:
					bool_3 = Class171.smethod_289(1, (ushort)2, 5, -1);
					num = (int)((num2 * 461316453) ^ 0x11261B4C);
					continue;
				case 8u:
					string_2 = Path.Combine(string_0, Class178.smethod_0(9687));
					string_3 = Path.Combine(string_0, Class178.smethod_0(9700));
					num = ((int)num2 * -1065768862) ^ -162682761;
					continue;
				case 7u:
					bool_4 = Class171.smethod_289(1, (ushort)3, 5, -1);
					num = (int)((num2 * 1941506399) ^ 0x455E538D);
					continue;
				case 6u:
					bool_6 = Class171.smethod_289(3, (ushort)0, 6, -1);
					bool_7 = Class171.smethod_289(0, (ushort)0, 10, -1);
					bool_8 = Class171.smethod_289(0, (ushort)0, 10, 14393);
					num = ((int)num2 * -1165024855) ^ 0xFDD34F7;
					continue;
				case 5u:
					delegate47_1 = Class171.smethod_270(1);
					delegate47_2 = Class171.smethod_270(2);
					num = (int)(num2 * 2006310185) ^ -1609768697;
					continue;
				case 3u:
					delegate47_0 = Class171.smethod_270(-1);
					num = ((int)num2 * -251384883) ^ 0x4B12ABB6;
					continue;
				case 1u:
					bool_9 = Class171.smethod_289(0, (ushort)0, 10, 15063);
					bool_10 = Class171.smethod_289(0, (ushort)0, 10, 16299);
					num = ((int)num2 * -380392191) ^ -131118160;
					continue;
				case 0u:
					bool_5 = Class171.smethod_289(2, (ushort)0, 6, -1);
					num = (int)((num2 * 801173293) ^ 0x3F38FAEC);
					continue;
				case 4u:
					break;
				default:
					delegate47_3 = Class171.smethod_270(4);
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
				{
					int num7;
					if (num > 90)
					{
						num2 = -1426309202;
						num7 = -1426309202;
					}
					else
					{
						num2 = -144746047;
						num7 = -144746047;
					}
					continue;
				}
				case 7u:
				{
					int num5;
					int num6;
					if (string_4.StartsWith(text, StringComparison.OrdinalIgnoreCase))
					{
						num5 = -1257430776;
						num6 = -1257430776;
					}
					else
					{
						num5 = -1324767620;
						num6 = -1324767620;
					}
					num2 = num5 ^ ((int)num3 * -2382358);
					continue;
				}
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
				{
					int num4;
					if (Class171.QueryDosDevice((char)num + Class178.smethod_0(9709), stringBuilder, stringBuilder.Capacity) == 0)
					{
						num2 = -1118227608;
						num4 = -1118227608;
					}
					else
					{
						num2 = -573336900;
						num4 = -573336900;
					}
					continue;
				}
				case 4u:
					break;
				default:
					return string.Empty;
				case 6u:
					return (char)num + Class178.smethod_0(9709) + string_4.Substring(text.Length, string_4.Length - text.Length);
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
				{
					int num4;
					if (num > 1)
					{
						num2 = -1131731149;
						num4 = -1131731149;
					}
					else
					{
						num2 = -1373145505;
						num4 = -1373145505;
					}
					continue;
				}
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
}
