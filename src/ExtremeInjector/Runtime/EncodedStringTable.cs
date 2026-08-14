using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

public sealed class EncodedStringTable
{
	internal static readonly string string_0;

	internal static readonly string string_1;

	internal static readonly byte[] byte_0;

	internal static readonly Dictionary<int, string> dictionary_0;

	internal static readonly object object_0;

	internal static readonly bool bool_0;

	internal static readonly int int_0;

	public static string smethod_0(int int_1)
	{
		int_1 -= EncodedStringTable.int_0;
		if (EncodedStringTable.bool_0)
		{
			lock (EncodedStringTable.object_0)
			{
				string text;
				EncodedStringTable.dictionary_0.TryGetValue(int_1, out text);
				if (text != null)
				{
					return text;
				}
			}
		}
		int num = 0;
		int index = int_1;
		int num2 = (int)EncodedStringTable.byte_0[index++];
		if ((num2 & 128) != 0)
		{
			if ((num2 & 64) == 0)
			{
				num = ((num2 & 63) << 8) + (int)EncodedStringTable.byte_0[index++];
			}
			else
			{
				num = ((num2 & 31) << 24) + ((int)EncodedStringTable.byte_0[index++] << 16) + ((int)EncodedStringTable.byte_0[index++] << 8) + (int)EncodedStringTable.byte_0[index++];
			}
		}
		else
		{
			num = num2;
			if (num == 0)
			{
				return string.Empty;
			}
		}
		string result;
		try
		{
			byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(EncodedStringTable.byte_0, index, num));
			string text2 = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
			if (EncodedStringTable.bool_0)
			{
				try
				{
					lock (EncodedStringTable.object_0)
					{
						EncodedStringTable.dictionary_0.Add(int_1, text2);
					}
				}
				catch
				{
				}
			}
			result = text2;
		}
		catch
		{
			result = null;
		}
		return result;
	}

	static EncodedStringTable()
	{
		if (EncodedStringTable.string_0 == _003CModule_003E.smethod_3<string>(1753162200u))
		{
			EncodedStringTable.bool_0 = true;
			EncodedStringTable.dictionary_0 = new Dictionary<int, string>();
		}
		EncodedStringTable.int_0 = Convert.ToInt32(EncodedStringTable.string_1);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(_003CModule_003E.smethod_5<string>(460238251u)))
		{
			int num = Convert.ToInt32(manifestResourceStream.Length);
			byte[] buffer = new byte[num];
			manifestResourceStream.Read(buffer, 0, num);
			EncodedStringTable.byte_0 = RecoveredRuntime.smethod_394(buffer);
			buffer = null;
			manifestResourceStream.Close();
		}
	}

	internal static void smethod_1(object object_1)
	{
		Monitor.Enter(object_1);
	}

	internal static void smethod_2(object object_1)
	{
		Monitor.Exit(object_1);
	}

	internal static Encoding smethod_3()
	{
		return Encoding.UTF8;
	}

	internal static string smethod_4(Encoding encoding_0, byte[] byte_1, int int_1, int int_2)
	{
		return encoding_0.GetString(byte_1, int_1, int_2);
	}

	internal static byte[] smethod_5(string string_2)
	{
		return Convert.FromBase64String(string_2);
	}

	internal static string smethod_6(string string_2)
	{
		return string.Intern(string_2);
	}

	internal static object smethod_7()
	{
		return new object();
	}

	internal static bool smethod_8(string string_2, string string_3)
	{
		return string_2 == string_3;
	}

	internal static int smethod_9(string string_2)
	{
		return Convert.ToInt32(string_2);
	}

	internal static Assembly smethod_10()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static Stream smethod_11(Assembly assembly_0, string string_2)
	{
		return assembly_0.GetManifestResourceStream(string_2);
	}

	internal static long smethod_12(Stream stream_0)
	{
		return stream_0.Length;
	}

	internal static int smethod_13(long long_0)
	{
		return Convert.ToInt32(long_0);
	}

	internal static int smethod_14(Stream stream_0, byte[] byte_1, int int_1, int int_2)
	{
		return stream_0.Read(byte_1, int_1, int_2);
	}

	internal static void smethod_15(Stream stream_0)
	{
		stream_0.Close();
	}

	internal static void smethod_16(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
