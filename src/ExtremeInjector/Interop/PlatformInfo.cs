using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class PlatformInfo
{
	public delegate void MemoryCopyRoutine(IntPtr address, IntPtr address2, uint uintValue);

	public static class NativeTypeSizeCache<T>
	{
		public static readonly int intValue = RecoveredRuntime.SizeOfNativeType(typeof(T));
	}

	public static readonly bool flag;

	internal static Dictionary<Type, int> dictionary;

	public static readonly Random randomElement;

	public static readonly Random random;

	public static readonly bool flag2;

	public static readonly bool flag3;

	public static readonly bool flag4;

	public static readonly bool flag5;

	public static readonly bool flag6;

	public static readonly bool flag7;

	public static readonly bool flag8;

	public static readonly bool flag9;

	public static readonly bool flag10;

	public static readonly bool flag11;

	public static readonly bool flag12;

	public static readonly string text;

	public static readonly string text2;

	public static readonly string text3;

	public static readonly string text4;

	internal static MemoryCopyRoutine memoryCopyRoutine;

	internal static MemoryCopyRoutine memoryCopyRoutine2;

	internal static MemoryCopyRoutine memoryCopyRoutine3;

	internal static MemoryCopyRoutine memoryCopyRoutine4;

	static PlatformInfo()
	{
	}

	public static string ConvertDevicePathToDosPath(string text5)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		for (int i = 65; i <= 90; i++)
		{
			if (RecoveredRuntime.QueryDosDevice(((char)i).ToString() + EncodedStringTable.DecodeString(9709), stringBuilder, stringBuilder.Capacity) != 0u)
			{
				string text = stringBuilder.ToString();
				if (text5.StartsWith(text, StringComparison.OrdinalIgnoreCase))
				{
					return ((char)i).ToString() + EncodedStringTable.DecodeString(9709) + text5.Substring(text.Length, text5.Length - text.Length);
				}
			}
		}
		return string.Empty;
	}

	public static int SizeOf<T>()
	{
		return NativeTypeSizeCache<T>.intValue;
	}

	public static T GetRandomElement<T>(this T[] valueArray)
	{
		return valueArray[randomElement.Next(valueArray.Length)];
	}

	public static int GetRandomIndex<T>(this T[] valueArray)
	{
		return randomElement.Next(valueArray.Length);
	}

	public static void Shuffle<T>(this IList<T> items)
	{
		int i = items.Count;
		while (i > 1)
		{
			i--;
			int index = PlatformInfo.randomElement.Next(i + 1);
			T value = items[index];
			items[index] = items[i];
			items[i] = value;
		}
	}
}
