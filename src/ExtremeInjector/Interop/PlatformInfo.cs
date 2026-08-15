using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
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

	internal static Dictionary<Type, int> dictionary = new Dictionary<Type, int>();

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

	internal static MemoryCopyRoutine memoryCopyRoutine = null;

	internal static MemoryCopyRoutine memoryCopyRoutine2 = null;

	internal static MemoryCopyRoutine memoryCopyRoutine3 = null;

	internal static MemoryCopyRoutine memoryCopyRoutine4 = null;

	static PlatformInfo()
	{
		flag = IntPtr.Size == 8;
		randomElement = new Random();
		random = new CryptoRandom<RNGCryptoServiceProvider>();

		NativeTypes.OsVersionInfoEx version = GetOperatingSystemVersion();
		flag2 = IsVersionAtLeast(version, major: 6, minor: 0);
		flag3 = IsVersionAtLeast(version, major: 6, minor: 1);
		flag4 = IsVersionAtLeast(version, major: 5, minor: 1, servicePackMajor: 2);
		flag5 = IsVersionAtLeast(version, major: 5, minor: 1, servicePackMajor: 3);
		flag6 = IsVersionAtLeast(version, major: 6, minor: 2);
		flag7 = IsVersionAtLeast(version, major: 6, minor: 3);
		flag8 = IsVersionAtLeast(version, major: 10, minor: 0);
		flag9 = IsVersionAtLeast(version, major: 10, minor: 0, build: 14393);
		flag10 = IsVersionAtLeast(version, major: 10, minor: 0, build: 15063);
		flag11 = IsVersionAtLeast(version, major: 10, minor: 0, build: 16299);
		flag12 = IsVersionAtLeast(version, major: 10, minor: 1);

		text = GetWindowsDirectory();
		text2 = Path.Combine(text, "System32");
		text3 = Path.Combine(text, "SysWOW64");
		text4 = Path.Combine(text, "System");
	}

	private static NativeTypes.OsVersionInfoEx GetOperatingSystemVersion()
	{
		var version = new NativeTypes.OsVersionInfoEx
		{
			intValue = Marshal.SizeOf(typeof(NativeTypes.OsVersionInfoEx))
		};
		if (RecoveredRuntime.RtlGetVersion(ref version) == 0)
		{
			return version;
		}

		Version fallback = Environment.OSVersion.Version;
		version.intValue2 = fallback.Major;
		version.intValue3 = fallback.Minor;
		version.intValue4 = fallback.Build;
		return version;
	}

	private static bool IsVersionAtLeast(
		NativeTypes.OsVersionInfoEx current,
		int major,
		int minor,
		int build = -1,
		ushort servicePackMajor = 0)
	{
		if (current.intValue2 != major)
		{
			return current.intValue2 > major;
		}

		if (current.intValue3 != minor)
		{
			return current.intValue3 > minor;
		}

		if (build >= 0 && current.intValue4 != build)
		{
			return current.intValue4 > build;
		}

		return current.ushortValue >= servicePackMajor;
	}

	private static string GetWindowsDirectory()
	{
		var path = new StringBuilder(260);
		if (RecoveredRuntime.GetWindowsDirectory(path, path.Capacity) != 0)
		{
			return path.ToString();
		}

		string fallback = Environment.GetEnvironmentVariable("windir");
		if (string.IsNullOrWhiteSpace(fallback))
		{
			throw new InvalidOperationException("Windows did not report its installation directory.");
		}

		return fallback;
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
