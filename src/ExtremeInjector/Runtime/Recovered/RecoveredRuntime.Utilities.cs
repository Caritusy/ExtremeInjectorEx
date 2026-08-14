using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ExtremeInjector;
using Microsoft.Win32;

public sealed partial class RecoveredRuntime
{
	private static int IndexOfBytes(byte[] buffer, byte[] pattern, int startIndex)
	{
		if (buffer == null || pattern == null || startIndex < 0 || startIndex > buffer.Length)
		{
			return -1;
		}
		if (pattern.Length == 0)
		{
			return startIndex;
		}
		int lastStart = buffer.Length - pattern.Length;
		for (int i = startIndex; i <= lastStart; i++)
		{
			int j = 0;
			while (j < pattern.Length && buffer[i + j] == pattern[j])
			{
				j++;
			}
			if (j == pattern.Length)
			{
				return i;
			}
		}
		return -1;
	}

	private static int IndexOfByteString(byte[] buffer, string pattern, int startIndex)
	{
		if (pattern == null)
		{
			return -1;
		}
		byte[] bytes = new byte[pattern.Length];
		for (int i = 0; i < pattern.Length; i++)
		{
			bytes[i] = (byte)pattern[i];
		}
		return IndexOfBytes(buffer, bytes, startIndex);
	}

	private static int IndexOfMaskedByteString(byte[] buffer, string pattern, string mask, int startIndex)
	{
		if (buffer == null || pattern == null || mask == null || pattern.Length != mask.Length ||
			startIndex < 0 || startIndex > buffer.Length)
		{
			return -1;
		}
		if (pattern.Length == 0)
		{
			return startIndex;
		}
		int lastStart = buffer.Length - pattern.Length;
		for (int i = startIndex; i <= lastStart; i++)
		{
			int j = 0;
			while (j < pattern.Length && (mask[j] == '?' || buffer[i + j] == (byte)pattern[j]))
			{
				j++;
			}
			if (j == pattern.Length)
			{
				return i;
			}
		}
		return -1;
	}

	internal static long smethod_1(PeScrambler gclass4_0, byte[] byte_0, long long_0)
	{
		gclass4_0.class154_0.method_28().Position = long_0;
		long num = gclass4_0.class154_0.method_28().Length - (long)byte_0.Length;
		int num2 = 1048576;
		BinaryReader binaryReader = new BinaryReader(gclass4_0.class154_0.method_28());
		while (gclass4_0.class154_0.method_28().Position < num)
		{
			if (gclass4_0.class154_0.method_28().Position + (long)num2 >= gclass4_0.class154_0.method_28().Length)
			{
				num2 = (int)(gclass4_0.class154_0.method_28().Length - gclass4_0.class154_0.method_28().Position);
			}
			int num3 = RecoveredRuntime.smethod_123(binaryReader.ReadBytes(num2), byte_0, 0);
			if (num3 != -1)
			{
				return gclass4_0.class154_0.method_28().Position - (long)num2 + (long)num3;
			}
			gclass4_0.class154_0.method_28().Position -= (long)(byte_0.Length - 1);
		}
		return -1L;
	}

	internal static void EditModuleOptions(MainForm.ModuleRow class21_0)
	{
		smethod_172(class21_0.Entry);
		ApplicationSettings.Save();
	}

	internal static IEnumerable<ResourceDirectoryNode> smethod_9(ResourceDirectoryNode class138_0)
	{
		return new PeScrambler.Class136(-2)
		{
			class138_2 = class138_0
		};
	}

	internal unsafe static int smethod_12(byte[] byte_0, byte[] byte_1, int int_0)
	{
		return IndexOfBytes(byte_0, byte_1, int_0);
}

	internal static int smethod_14(DeflateDecoder.Class182 class182_0)
	{
		return 32768 - class182_0.int_1;
	}

	internal unsafe static int smethod_17(int int_0, string string_0, string string_1, byte[] byte_0)
	{
		return IndexOfMaskedByteString(byte_0, string_0, string_1, int_0);
}

	internal static void smethod_28()
	{
		try
		{
			smethod_326();
		}
		catch (Exception)
		{
		}
	}
}
