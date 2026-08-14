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

	public static string DecodeString(int int_1)
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
		if (EncodedStringTable.string_0 == _003CModule_003E.DecodeConstantWithKeyB<string>(1753162200u))
		{
			EncodedStringTable.bool_0 = true;
			EncodedStringTable.dictionary_0 = new Dictionary<int, string>();
		}
		EncodedStringTable.int_0 = Convert.ToInt32(EncodedStringTable.string_1);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(_003CModule_003E.DecodeConstantWithKeyD<string>(460238251u)))
		{
			int num = Convert.ToInt32(manifestResourceStream.Length);
			byte[] buffer = new byte[num];
			manifestResourceStream.Read(buffer, 0, num);
			EncodedStringTable.byte_0 = RecoveredRuntime.DecompressEmbeddedData(buffer);
			buffer = null;
			manifestResourceStream.Close();
		}
	}

}
