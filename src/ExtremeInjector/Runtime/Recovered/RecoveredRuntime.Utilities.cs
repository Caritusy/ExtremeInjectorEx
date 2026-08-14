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

	internal static long FindPatternOffset(PeScrambler peScrambler, byte[] bytes, long longValue)
	{
		peScrambler.peImage.GetStream().Position = longValue;
		long num = peScrambler.peImage.GetStream().Length - (long)bytes.Length;
		int num2 = 1048576;
		BinaryReader binaryReader = new BinaryReader(peScrambler.peImage.GetStream());
		while (peScrambler.peImage.GetStream().Position < num)
		{
			if (peScrambler.peImage.GetStream().Position + (long)num2 >= peScrambler.peImage.GetStream().Length)
			{
				num2 = (int)(peScrambler.peImage.GetStream().Length - peScrambler.peImage.GetStream().Position);
			}
			int num3 = RecoveredRuntime.FindByteSequenceOptimized(binaryReader.ReadBytes(num2), bytes, 0);
			if (num3 != -1)
			{
				return peScrambler.peImage.GetStream().Position - (long)num2 + (long)num3;
			}
			peScrambler.peImage.GetStream().Position -= (long)(bytes.Length - 1);
		}
		return -1L;
	}

	internal static void EditModuleOptions(MainForm.ModuleRow moduleRow)
	{
		ShowModuleOptions(moduleRow.Entry);
		ApplicationSettings.Save();
	}

	internal static IEnumerable<ResourceDirectoryNode> EnumerateResourceNodes(ResourceDirectoryNode resourceDirectoryNode)
	{
		return new PeScrambler.ResourceDirectoryTraversal(-2)
		{
			resourceDirectoryNode3 = resourceDirectoryNode
		};
	}

	internal unsafe static int FindByteSequence(byte[] bytes, byte[] bytes2, int intValue)
	{
		return IndexOfBytes(bytes, bytes2, intValue);
}

	internal static int GetAvailableDeflateWindowBytes(DeflateDecoder.DeflateOutputWindow deflateOutputWindow)
	{
		return 32768 - deflateOutputWindow.intValue2;
	}

	internal unsafe static int FindMaskedByteSequence(int intValue, string text, string text2, byte[] bytes)
	{
		return IndexOfMaskedByteString(bytes, text, text2, intValue);
}

	internal static void InitializeRuntimeResolvers()
	{
		try
		{
			InitializeEmbeddedAssemblyResolver();
		}
		catch (Exception)
		{
		}
	}
}
