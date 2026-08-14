using System;
using System.IO;
using System.Text;

internal static class ExternalSettingsLoader
{
	internal static void LoadLegacyArgument(string[] args)
	{
		if (args.Length != 1)
		{
			return;
		}

		ApplicationRuntimeState.UsesExternalSettings = true;
		try
		{
			char[] encodedPath = args[0].ToCharArray();
			Array.Reverse(encodedPath);
			string path = Encoding.UTF8.GetString(Convert.FromBase64String(new string(encodedPath)));
			if (File.Exists(path))
			{
				ApplicationSettings.Current = ApplicationSettings.Load(path);
			}
		}
		catch (FormatException)
		{
		}
	}
}
