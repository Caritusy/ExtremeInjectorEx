using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

public sealed class EncodedStringTable
{
	internal static readonly string text = null;

	internal static readonly string text2 = null;

	internal static readonly byte[] bytes;

	internal static readonly Dictionary<int, string> dictionary;

	internal static readonly object instance = null;

	internal static readonly bool flag;

	internal static readonly int intValue;

	public static string DecodeString(int intValue2)
	{
		intValue2 -= EncodedStringTable.intValue;
		if (EncodedStringTable.flag)
		{
			lock (EncodedStringTable.instance)
			{
				string text;
				EncodedStringTable.dictionary.TryGetValue(intValue2, out text);
				if (text != null)
				{
					return text;
				}
			}
		}
		int num = 0;
		int index = intValue2;
		int num2 = (int)EncodedStringTable.bytes[index++];
		if ((num2 & 128) != 0)
		{
			if ((num2 & 64) == 0)
			{
				num = ((num2 & 63) << 8) + (int)EncodedStringTable.bytes[index++];
			}
			else
			{
				num = ((num2 & 31) << 24) + ((int)EncodedStringTable.bytes[index++] << 16) + ((int)EncodedStringTable.bytes[index++] << 8) + (int)EncodedStringTable.bytes[index++];
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
			byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(EncodedStringTable.bytes, index, num));
			string text2 = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
			if (EncodedStringTable.flag)
			{
				try
				{
					lock (EncodedStringTable.instance)
					{
						EncodedStringTable.dictionary.Add(intValue2, text2);
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
		if (EncodedStringTable.text == _003CModule_003E.DecodeConstantWithKeyB<string>(1753162200u))
		{
			EncodedStringTable.flag = true;
			EncodedStringTable.dictionary = new Dictionary<int, string>();
		}
		EncodedStringTable.intValue = Convert.ToInt32(EncodedStringTable.text2);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(_003CModule_003E.DecodeConstantWithKeyD<string>(460238251u)))
		{
			int num = Convert.ToInt32(manifestResourceStream.Length);
			byte[] buffer = new byte[num];
			manifestResourceStream.Read(buffer, 0, num);
			EncodedStringTable.bytes = RecoveredRuntime.DecompressEmbeddedData(buffer);
			buffer = null;
			manifestResourceStream.Close();
		}
	}

}
