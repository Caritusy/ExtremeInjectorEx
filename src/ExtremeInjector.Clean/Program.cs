using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

public static class Program
{
	internal static bool UsesExternalSettings { get; set; }

	[STAThread]
	internal static void Main(string[] args)
	{
		Class171.smethod_359();

		if (!Class171.smethod_272() && Class171.smethod_69() && TryRestartAsAdministrator())
		{
			return;
		}

		LoadExternalSettings(args);

		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		Application.Run(new MainForm());
	}

	private static bool TryRestartAsAdministrator()
	{
		var startInfo = new ProcessStartInfo(Assembly.GetExecutingAssembly().Location)
		{
			Verb = "runas",
			UseShellExecute = true
		};

		try
		{
			Process.Start(startInfo);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static void LoadExternalSettings(string[] args)
	{
		if (args.Length != 1)
		{
			return;
		}

		UsesExternalSettings = true;
		try
		{
			var encodedPath = args[0].ToCharArray();
			Array.Reverse(encodedPath);
			var path = Encoding.UTF8.GetString(Convert.FromBase64String(new string(encodedPath)));
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
