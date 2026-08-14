using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

public sealed class EmbeddedAssemblyResolver
{
	public struct AssemblyIdentity
	{
		public string name = string.Empty;

		public Version version = null;

		public string culture = string.Empty;

		public string publicKeyToken = string.Empty;

		public string ToDisplayName(bool includeVersion)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.name);
			if (includeVersion && this.version != null)
			{
				stringBuilder.Append(_003CModule_003E.DecodeConstantWithKeyD<string>(2088884392u));
				stringBuilder.Append(this.version);
			}
			stringBuilder.Append(_003CModule_003E.DecodeConstantWithKeyE<string>(3582041215u));
			stringBuilder.Append((this.culture.Length == 0) ? _003CModule_003E.DecodeConstantWithKeyC<string>(4180971965u) : this.culture);
			stringBuilder.Append(_003CModule_003E.DecodeConstantWithKeyA<string>(2500547674u));
			stringBuilder.Append((this.publicKeyToken.Length == 0) ? _003CModule_003E.DecodeConstantWithKeyE<string>(868523558u) : this.publicKeyToken);
			return stringBuilder.ToString();
		}

		public AssemblyIdentity(string text4)
		{
			string[] array = text4.Split(',');
			foreach (string text in array)
			{
				string text2 = text.Trim();
				if (text2.StartsWith(global::_003CModule_003E.DecodeConstantWithKeyC<string>(892207196u)))
				{
					version = new Version(text2.Substring(8));
				}
				else if (text2.StartsWith(global::_003CModule_003E.DecodeConstantWithKeyB<string>(1971849447u)))
				{
					text2 = text2.Substring(8);
					if (text2 == global::_003CModule_003E.DecodeConstantWithKeyB<string>(3198505089u))
					{
						text2 = string.Empty;
					}
				}
				else if (text2.StartsWith(global::_003CModule_003E.DecodeConstantWithKeyB<string>(1226974768u)))
				{
					publicKeyToken = text2.Substring(15);
					if (publicKeyToken == global::_003CModule_003E.DecodeConstantWithKeyE<string>(868523558u))
					{
						publicKeyToken = string.Empty;
					}
				}
				else
				{
					name = text2;
				}
			}
		}

	}

	internal const string text = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

	internal const int intValue = 4;

	internal static Dictionary<string, Assembly> dictionary = new Dictionary<string, Assembly>();

	internal static bool flag
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
