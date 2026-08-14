using System.Collections.Generic;

namespace ns1;

public static class GClass10
{
	internal static Dictionary<int, string> dictionary_0 = new Dictionary<int, string>();

	public static string smethod_0(string string_0, byte byte_0, int int_0)
	{
		if (dictionary_0.ContainsKey(int_0))
		{
			return dictionary_0[int_0];
		}
		char[] array = string_0.ToCharArray();
		for (int i = 0; i < string_0.Length; i++)
		{
			array[i] = (char)(array[i] ^ byte_0);
		}
		string text = new string(array);
		dictionary_0.Add(int_0, text);
		return text;
	}
}
