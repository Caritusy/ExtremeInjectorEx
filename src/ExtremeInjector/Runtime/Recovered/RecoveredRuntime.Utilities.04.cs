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

	internal static bool smethod_747(string string_0, string string_1)
	{
		return string_0.Contains(string_1);
	}

	internal static int smethod_749(Stream stream_0)
	{
		return stream_0.ReadByte();
	}

	internal static bool smethod_750(string string_0)
	{
		return Path.IsPathRooted(string_0);
	}

	internal static RegistryKey smethod_751(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.OpenSubKey(string_0);
	}

	internal static string[] smethod_752(RegistryKey registryKey_0)
	{
		return registryKey_0.GetValueNames();
	}

	internal static object smethod_753(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.GetValue(string_0);
	}

	internal static void smethod_754(RegistryKey registryKey_0)
	{
		registryKey_0.Close();
	}

	internal static string smethod_755()
	{
		return Environment.CurrentDirectory;
	}

	internal static ArgumentException smethod_756(string string_0, string string_1)
	{
		return new ArgumentException(string_0, string_1);
	}

	internal static byte[] smethod_757(double double_0)
	{
		return BitConverter.GetBytes(double_0);
	}

	internal static long smethod_758(byte[] byte_0, int int_0)
	{
		return BitConverter.ToInt64(byte_0, int_0);
	}
}
