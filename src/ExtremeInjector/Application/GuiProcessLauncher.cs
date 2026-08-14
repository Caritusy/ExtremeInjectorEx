using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;
using System.Text;

internal static class GuiProcessLauncher
{
	private const string HostArgument = "--extreme-injector-gui-host";

	internal static bool IsAdministrator()
	{
		using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
		{
			return new WindowsPrincipal(identity).IsInRole(WindowsBuiltInRole.Administrator);
		}
	}

	internal static bool TryRestartAsAdministrator(string[] args)
	{
		return TryStart(new ProcessStartInfo(Assembly.GetExecutingAssembly().Location)
		{
			Arguments = BuildArgumentLine(AppendHostArgument(args)),
			Verb = "runas",
			UseShellExecute = true,
			WindowStyle = ProcessWindowStyle.Hidden
		});
	}

	internal static bool TryStartHost(string[] args)
	{
		return TryStart(new ProcessStartInfo(Assembly.GetExecutingAssembly().Location)
		{
			Arguments = BuildArgumentLine(AppendHostArgument(args)),
			CreateNoWindow = true,
			UseShellExecute = false,
			WorkingDirectory = Environment.CurrentDirectory
		});
	}

	internal static bool RemoveHostArgument(string[] args, out string[] remainingArguments)
	{
		var remaining = new List<string>(args.Length);
		bool found = false;
		foreach (string argument in args)
		{
			if (string.Equals(argument, HostArgument, StringComparison.Ordinal))
			{
				found = true;
				continue;
			}

			remaining.Add(argument);
		}

		remainingArguments = remaining.ToArray();
		return found;
	}

	private static bool TryStart(ProcessStartInfo startInfo)
	{
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

	private static string[] AppendHostArgument(string[] args)
	{
		var arguments = new string[args.Length + 1];
		Array.Copy(args, arguments, args.Length);
		arguments[arguments.Length - 1] = HostArgument;
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
}
