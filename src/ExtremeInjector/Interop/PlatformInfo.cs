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
		public static readonly int int_0 = RecoveredRuntime.SizeOfNativeType(typeof(T));
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
	}

	public static string ConvertDevicePathToDosPath(string string_4)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		for (int i = 65; i <= 90; i++)
		{
			if (RecoveredRuntime.QueryDosDevice(((char)i).ToString() + EncodedStringTable.DecodeString(9709), stringBuilder, stringBuilder.Capacity) != 0u)
			{
				string text = stringBuilder.ToString();
				if (string_4.StartsWith(text, StringComparison.OrdinalIgnoreCase))
				{
					return ((char)i).ToString() + EncodedStringTable.DecodeString(9709) + string_4.Substring(text.Length, string_4.Length - text.Length);
				}
			}
		}
		return string.Empty;
	}

	public static int SizeOf<T>()
	{
		return Class128<T>.int_0;
	}

	public static T GetRandomElement<T>(this T[] gparam_0)
	{
		return gparam_0[random_0.Next(gparam_0.Length)];
	}

	public static int GetRandomIndex<T>(this T[] gparam_0)
	{
		return random_0.Next(gparam_0.Length);
	}

	public static void Shuffle<T>(this IList<T> ilist_0)
	{
		int i = ilist_0.Count;
		while (i > 1)
		{
			i--;
			int index = PlatformInfo.random_0.Next(i + 1);
			T value = ilist_0[index];
			ilist_0[index] = ilist_0[i];
			ilist_0[i] = value;
		}
	}
}
