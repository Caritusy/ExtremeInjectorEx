using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

public sealed class EmbeddedAssemblyResolver
{
	public struct Struct79
	{
		public string string_0 = string.Empty;

		public Version version_0 = null;

		public string string_1 = string.Empty;

		public string string_2 = string.Empty;

		public string ToDisplayName(bool includeVersion)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.string_0);
			if (includeVersion && this.version_0 != null)
			{
				stringBuilder.Append(_003CModule_003E.DecodeConstantWithKeyD<string>(2088884392u));
				stringBuilder.Append(this.version_0);
			}
			stringBuilder.Append(_003CModule_003E.DecodeConstantWithKeyE<string>(3582041215u));
			stringBuilder.Append((this.string_1.Length == 0) ? _003CModule_003E.DecodeConstantWithKeyC<string>(4180971965u) : this.string_1);
			stringBuilder.Append(_003CModule_003E.DecodeConstantWithKeyA<string>(2500547674u));
			stringBuilder.Append((this.string_2.Length == 0) ? _003CModule_003E.DecodeConstantWithKeyE<string>(868523558u) : this.string_2);
			return stringBuilder.ToString();
		}

		public Struct79(string string_3)
		{
			string[] array = string_3.Split(',');
			foreach (string text in array)
			{
				string text2 = text.Trim();
				if (text2.StartsWith(global::_003CModule_003E.DecodeConstantWithKeyC<string>(892207196u)))
				{
					version_0 = new Version(text2.Substring(8));
				}
				else if (text2.StartsWith(global::_003CModule_003E.DecodeConstantWithKeyB<string>(1971849447u)))
				{
					string_1 = text2.Substring(8);
					if (string_1 == global::_003CModule_003E.DecodeConstantWithKeyB<string>(3198505089u))
					{
						string_1 = string.Empty;
					}
				}
				else if (text2.StartsWith(global::_003CModule_003E.DecodeConstantWithKeyB<string>(1226974768u)))
				{
					string_2 = text2.Substring(15);
					if (string_2 == global::_003CModule_003E.DecodeConstantWithKeyE<string>(868523558u))
					{
						string_2 = string.Empty;
					}
				}
				else
				{
					string_0 = text2;
				}
			}
		}

	}

	internal const string string_0 = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

	internal const int int_0 = 4;

	internal static Dictionary<string, Assembly> dictionary_0 = new Dictionary<string, Assembly>();

	internal static bool Boolean_0
	{
		get
		{
			try
			{
				string a = Process.GetCurrentProcess().MainModule.ModuleName.ToLower();
				if (a == _003CModule_003E.DecodeConstantWithKeyE<string>(2162436899u))
				{
					return true;
				}
				if (a == _003CModule_003E.DecodeConstantWithKeyB<string>(348880682u))
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}
	}

}
