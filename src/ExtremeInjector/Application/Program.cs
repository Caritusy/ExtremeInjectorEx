using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

public static class Program
{
	private const string GuiHostArgument = "--extreme-injector-gui-host";

	internal static bool UsesExternalSettings { get; set; }

	[STAThread]
	internal static void Main(string[] args)
	{
		SingleFileAssemblyResolver.Register();
		if (CliApplication.IsCliRequest(args))
		{
			CliConsole.Initialize();
			Environment.ExitCode = CliApplication.Run(args);
			return;
		}

		bool isGuiHost = RemoveGuiHostArgument(args, out string[] guiArguments);
		if (!isGuiHost && SingleInstanceCoordinator.TryActivateExisting())
		{
			return;
		}

		if (!isGuiHost && TryStartGuiHost(guiArguments))
		{
			return;
		}

		CliConsole.DetachForGui();
		if (SingleInstanceCoordinator.TryActivateExisting())
		{
			return;
		}

		if (!IsAdministrator() && TryRestartAsAdministrator(guiArguments))
		{
			return;
		}

		using (SingleInstanceCoordinator instance = SingleInstanceCoordinator.Acquire())
		{
			if (!instance.IsPrimary)
			{
				return;
			}

			LoadExternalSettings(guiArguments);
			UiText.Configure(ApplicationSettings.Current.Language);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			using (var mainForm = new MainForm())
			{
				instance.AttachMainWindow(mainForm);
				Application.Run(mainForm);
			}
		}
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
	private static bool TryRestartAsAdministrator(string[] args)
	{
		var startInfo = new ProcessStartInfo(Assembly.GetExecutingAssembly().Location)
		{
			Arguments = BuildArgumentLine(AppendGuiHostArgument(args)),
			Verb = "runas",
			UseShellExecute = true,
			WindowStyle = ProcessWindowStyle.Hidden
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

	private static bool TryStartGuiHost(string[] args)
	{
		var startInfo = new ProcessStartInfo(Assembly.GetExecutingAssembly().Location)
		{
			Arguments = BuildArgumentLine(AppendGuiHostArgument(args)),
			CreateNoWindow = true,
			UseShellExecute = false,
			WorkingDirectory = Environment.CurrentDirectory
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

	private static bool RemoveGuiHostArgument(string[] args, out string[] remainingArguments)
	{
		var remaining = new List<string>(args.Length);
		bool found = false;
		foreach (string argument in args)
		{
			if (string.Equals(argument, GuiHostArgument, StringComparison.Ordinal))
			{
				found = true;
				continue;
			}
			remaining.Add(argument);
		}

		remainingArguments = remaining.ToArray();
		return found;
	}

	private static string[] AppendGuiHostArgument(string[] args)
	{
		var arguments = new string[args.Length + 1];
		Array.Copy(args, arguments, args.Length);
		arguments[arguments.Length - 1] = GuiHostArgument;
		return arguments;
	}

	private static string BuildArgumentLine(IEnumerable<string> args)
	{
		var argumentLine = new StringBuilder();
		foreach (string argument in args)
		{
			if (argumentLine.Length != 0)
			{
				argumentLine.Append(' ');
			}
			argumentLine.Append(QuoteArgument(argument));
		}
		return argumentLine.ToString();
	}

	private static string QuoteArgument(string argument)
	{
		if (!string.IsNullOrEmpty(argument) &&
			argument.IndexOfAny(new[] { ' ', '\t', '\n', '\v', '"' }) < 0)
		{
			return argument;
		}

		var quoted = new StringBuilder("\"");
		int backslashes = 0;
		foreach (char character in argument ?? string.Empty)
		{
			if (character == '\\')
			{
				backslashes++;
				continue;
			}

			if (character == '"')
			{
				quoted.Append('\\', (backslashes * 2) + 1);
				quoted.Append('"');
				backslashes = 0;
				continue;
			}

			quoted.Append('\\', backslashes);
			backslashes = 0;
			quoted.Append(character);
		}

		quoted.Append('\\', backslashes * 2);
		quoted.Append('"');
		return quoted.ToString();
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
