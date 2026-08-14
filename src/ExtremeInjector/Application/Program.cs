using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

public static class Program
{
	internal static bool UsesExternalSettings { get; set; }

	[STAThread]
	internal static void Main(string[] args)
	{
		SingleFileAssemblyResolver.Register();

		if (!IsAdministrator() && TryRestartAsAdministrator())
		{
			return;
		}

		LoadExternalSettings(args);
		UiText.Configure(ApplicationSettings.Current.Language);

		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		Application.Run(new MainForm());
	}

	// 注入操作需要访问目标进程，入口在启动 UI 前完成提权。
	private static bool IsAdministrator()
	{
		using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
		{
			return new WindowsPrincipal(identity).IsInRole(WindowsBuiltInRole.Administrator);
		}
	}

	// 使用 Windows 的 runas 动词重新启动当前程序。
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

	// 兼容旧版反向 Base64 编码的外部配置路径参数。
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
