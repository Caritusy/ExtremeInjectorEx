using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using ExtremeInjector;

internal static class CliApplication
{
	private const int Success = 0;
	private const int InvalidArguments = 1;
	private const int TargetNotFound = 2;
	private const int AmbiguousTarget = 3;
	private const int InvalidModule = 4;
	private const int AdministratorRequired = 5;
	private const int InjectionFailed = 6;
	private const int SettingsInUse = 7;
	private const int Canceled = 8;

	internal static bool IsCliRequest(string[] args)
	{
		return args.Any(argument =>
			string.Equals(argument, "-c", StringComparison.OrdinalIgnoreCase) ||
			string.Equals(argument, "--cli", StringComparison.OrdinalIgnoreCase));
	}

	internal static int Run(string[] args)
	{
		try
		{
			PrepareSettingsSource(args);
			UiText.Configure(ApplicationSettings.Current.Language);
			CliCommand command = Parse(args);
			UiText.Configure(ApplicationSettings.Current.Language);
			if (command.ShowHelp)
			{
				WriteHelp();
				return Success;
			}

			if (command.SaveSettings)
			{
				int saveResult = SaveSettings(command);
				if (saveResult != Success || !command.HasInjectionTarget)
				{
					return saveResult;
				}
			}

			if (!command.HasInjectionTarget)
			{
				return Fail(InvalidArguments, UiText.Get("Cli.Error.TargetRequired"));
			}

			RemoteProcess process = ResolveProcess(command, out int resolutionExitCode);
			if (process == null)
			{
				return resolutionExitCode;
			}

			Console.WriteLine(UiText.Format("Cli.SelectedProcess", process.Name, process.ProcessId));
			if (!IsAdministrator())
			{
				return Fail(AdministratorRequired, UiText.Get("Cli.Error.AdminRequired"));
			}

			List<ModuleEntry> modules = command.ModulesSpecified
				? command.Modules.Where(module => module.Enabled).ToList()
				: ApplicationSettings.Current.Modules.Where(module => module.Enabled).ToList();
			if (modules.Count == 0)
			{
				return Fail(InvalidModule, UiText.Get("Cli.Error.DllRequired"));
			}

			foreach (ModuleEntry module in modules)
			{
				if (string.IsNullOrWhiteSpace(module.Path) || !File.Exists(module.Path))
				{
					return Fail(InvalidModule, UiText.Format("Cli.Error.DllNotFound", module.Path ?? string.Empty));
				}
			}

			RecoveredRuntime.smethod_341();
			return InjectModules(process, modules, ApplicationSettings.Current.Options);
		}
		catch (CliUsageException exception)
		{
			return Fail(InvalidArguments, UiText.Format("Cli.Error.Argument", exception.Message));
		}
		catch (Exception exception)
		{
			return Fail(InjectionFailed, UiText.Format("Cli.Error.Unexpected", exception.Message));
		}
	}

	private static void WriteHelp()
	{
		string help = UiText.Get("Cli.Help");
		string settingsPathHelp = UiText.Get("Cli.SettingsPathHelp");
		const string helpOption = "  -h, --help";
		int insertionPoint = help.LastIndexOf(helpOption, StringComparison.Ordinal);
		Console.WriteLine(insertionPoint >= 0
			? help.Insert(insertionPoint, settingsPathHelp + Environment.NewLine)
			: help + Environment.NewLine + settingsPathHelp);
	}

	private static int SaveSettings(CliCommand command)
	{
		using (SingleInstanceCoordinator instance = SingleInstanceCoordinator.Acquire())
		{
			if (!instance.IsPrimary)
			{
				return Fail(SettingsInUse, UiText.Get("Cli.Error.SettingsInUse"));
			}

			if (command.ModulesSpecified)
			{
				ApplicationSettings.Current.Modules = command.Modules;
			}

			if (!string.IsNullOrWhiteSpace(command.ProcessName))
			{
				ApplicationSettings.Current.ProcessName = command.ProcessName;
			}

			if (string.IsNullOrWhiteSpace(command.SettingsPath))
			{
				ApplicationSettings.Save();
			}
			else
			{
				ApplicationSettings.Save(command.SettingsPath);
			}
			Console.WriteLine(UiText.Get("Cli.SettingsSaved"));
			return Success;
		}
	}

	private static RemoteProcess ResolveProcess(CliCommand command, out int exitCode)
	{
		exitCode = TargetNotFound;
		if (command.ProcessId.HasValue)
		{
			try
			{
				using (Process nativeProcess = Process.GetProcessById(command.ProcessId.Value))
				{
					RemoteProcess process = CreateProcessReference(nativeProcess);
					if (process == null)
					{
						Fail(TargetNotFound, UiText.Format("Cli.Error.PidNotFound", command.ProcessId.Value));
					}
					return process;
				}
			}
			catch (ArgumentException)
			{
				Fail(TargetNotFound, UiText.Format("Cli.Error.PidNotFound", command.ProcessId.Value));
				return null;
			}
		}

		DateTime? deadline = command.WaitTimeoutSeconds > 0
			? DateTime.UtcNow.AddSeconds(command.WaitTimeoutSeconds)
			: (DateTime?)null;
		bool waitForProcess = ApplicationSettings.Current.Options.AutoInject;
		bool announcedWait = false;
		bool canceled = false;
		ConsoleCancelEventHandler cancelHandler = delegate(object sender, ConsoleCancelEventArgs eventArgs)
		{
			eventArgs.Cancel = true;
			canceled = true;
		};
		Console.CancelKeyPress += cancelHandler;
		try
		{
			while (true)
			{
				Process[] matches = GetMatchingProcesses(command.ProcessName);
				try
				{
					if (matches.Length == 1)
					{
						RemoteProcess process = CreateProcessReference(matches[0]);
						if (process == null)
						{
							Fail(TargetNotFound, UiText.Format("Cli.Error.ProcessNotFound", command.ProcessName));
						}
						return process;
					}

					if (matches.Length > 1)
					{
						PrintAmbiguousProcesses(command.ProcessName, matches);
						exitCode = AmbiguousTarget;
						return null;
					}
				}
				finally
				{
					foreach (Process match in matches)
					{
						match.Dispose();
					}
				}

				if (!waitForProcess)
				{
					Fail(TargetNotFound, UiText.Format("Cli.Error.ProcessNotFound", command.ProcessName));
					return null;
				}

				if (canceled)
				{
					exitCode = Canceled;
					Fail(Canceled, UiText.Get("Cli.Canceled"));
					return null;
				}

				if (deadline.HasValue && DateTime.UtcNow >= deadline.Value)
				{
					Fail(TargetNotFound, UiText.Format("Cli.Error.WaitTimedOut", command.ProcessName));
					return null;
				}

				if (!announcedWait)
				{
					Console.WriteLine(UiText.Format("Cli.WaitingForProcess", command.ProcessName));
					announcedWait = true;
				}
				Thread.Sleep(500);
			}
		}
		finally
		{
			Console.CancelKeyPress -= cancelHandler;
		}
	}

	private static Process[] GetMatchingProcesses(string processName)
	{
		string normalizedName = Path.GetFileName(processName.Trim());
		if (normalizedName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
		{
			normalizedName = normalizedName.Substring(0, normalizedName.Length - 4);
		}

		return Process.GetProcessesByName(normalizedName)
			.Where(IsRunning)
			.OrderBy(process => process.Id)
			.ToArray();
	}

	private static bool IsRunning(Process process)
	{
		try
		{
			return !process.HasExited;
		}
		catch
		{
			return false;
		}
	}

	private static RemoteProcess CreateProcessReference(Process nativeProcess)
	{
		RemoteProcess process = RecoveredRuntime.smethod_47(nativeProcess.Id);
		if (process != null)
		{
			return process;
		}

		if (!IsAdministrator())
		{
			return new RemoteProcess((uint)nativeProcess.Id)
			{
				Name = nativeProcess.ProcessName + ".exe"
			};
		}

		return null;
	}

	private static void PrintAmbiguousProcesses(string processName, Process[] matches)
	{
		Console.Error.WriteLine(UiText.Format("Cli.Error.AmbiguousProcess", processName));
		for (int index = 0; index < matches.Length; index++)
		{
			Process match = matches[index];
			string title = GetWindowTitle(match);
			Console.Error.WriteLine("[" + index + "] " + title + " (" + match.Id + ")");
		}
		Console.Error.WriteLine(UiText.Get("Cli.Error.UsePid"));
	}

	private static string GetWindowTitle(Process process)
	{
		try
		{
			string title = process.MainWindowTitle;
			return string.IsNullOrWhiteSpace(title) ? process.ProcessName + ".exe" : title;
		}
		catch
		{
			return UiText.Get("Common.UnknownProcess");
		}
	}

	private static int InjectModules(RemoteProcess process, List<ModuleEntry> modules, InjectionOptions options)
	{
		ScramblePreset scramblePreset = options.Scramble.Detect();
		bool allSucceeded = true;
		foreach (ModuleEntry module in modules)
		{
			if (options.DelayBeforeInjection > 0)
			{
				Thread.Sleep(options.DelayBeforeInjection);
			}

			Console.WriteLine(UiText.Format("Cli.Injecting", Path.GetFileName(module.Path)));
			IntPtr moduleBase = IntPtr.Zero;
			bool reportedError = false;
			bool succeeded = RecoveredRuntime.InjectModule(
				ref moduleBase,
				process,
				options,
				scramblePreset,
				module.Path,
				message =>
				{
					reportedError = true;
					Console.Error.WriteLine(message);
				},
				(message, exception) =>
				{
					reportedError = true;
					Console.Error.WriteLine(message);
					Console.Error.WriteLine(exception.Message);
				});

			if (succeeded && !string.IsNullOrWhiteSpace(module.ExportName))
			{
				try
				{
					succeeded = RecoveredRuntime.InvokeExport(module, moduleBase, process);
					if (succeeded)
					{
						Console.WriteLine(UiText.Format("Cli.ExportInvoked", module.ExportName));
					}
				}
				catch (Exception exception)
				{
					reportedError = true;
					Console.Error.WriteLine(UiText.Format("Cli.Error.Export", module.ExportName, exception.Message));
					succeeded = false;
				}
			}

			if (succeeded)
			{
				Console.WriteLine(UiText.Format("Cli.Injected", Path.GetFileName(module.Path), moduleBase.ToInt64().ToString("X")));
			}
			else if (!reportedError)
			{
				Console.Error.WriteLine(UiText.Format("Cli.Error.InjectionFailed", Path.GetFileName(module.Path)));
			}

			allSucceeded &= succeeded && !reportedError;
			if (options.DelayBetweenModules > 0 && !ReferenceEquals(module, modules[modules.Count - 1]))
			{
				Thread.Sleep(options.DelayBetweenModules);
			}
		}

		Console.WriteLine(UiText.Get(allSucceeded ? "Cli.Completed" : "Cli.CompletedWithErrors"));
		return allSucceeded ? Success : InjectionFailed;
	}

	private static CliCommand Parse(string[] rawArguments)
	{
		string[] args = rawArguments;
		var command = new CliCommand();
		ModuleEntry currentModule = null;
		if (args.Length == 0)
		{
			command.ShowHelp = true;
			return command;
		}

		for (int index = 0; index < args.Length; index++)
		{
			string option = args[index].ToLowerInvariant();
			switch (option)
			{
				case "-c":
				case "--cli":
					break;
				case "-h":
				case "--help":
					command.ShowHelp = true;
					break;
				case "--pid":
					command.ProcessId = ParsePositiveInt(NextValue(args, ref index, option), option);
					break;
				case "--process":
					command.ProcessName = NextValue(args, ref index, option);
					break;
				case "--dll":
					currentModule = new ModuleEntry
					{
						Path = Path.GetFullPath(NextValue(args, ref index, option)),
						Enabled = true,
						CallingConvention = CallingConvention.StdCall,
						Parameters = new List<ExportParameter>()
					};
					command.Modules.Add(currentModule);
					command.ModulesSpecified = true;
					break;
				case "--clear-dlls":
					command.Modules.Clear();
					command.ModulesSpecified = true;
					currentModule = null;
					break;
				case "--enable-dll":
					RequireCurrentModule(currentModule, option).Enabled = true;
					break;
				case "--disable-dll":
					RequireCurrentModule(currentModule, option).Enabled = false;
					break;
				case "--export":
					RequireCurrentModule(currentModule, option).ExportName = NextValue(args, ref index, option);
					break;
				case "--calling-convention":
					RequireCurrentModule(currentModule, option).CallingConvention = ParseCallingConvention(NextValue(args, ref index, option));
					break;
				case "--arg":
					RequireCurrentModule(currentModule, option).Parameters.Add(ParseExportParameter(NextValue(args, ref index, option)));
					break;
				case "--method":
					ApplicationSettings.Current.Options.Method = ParseInjectionMethod(NextValue(args, ref index, option));
					break;
				case "--scramble":
					ApplicationSettings.Current.Options.Scramble.ApplyPreset(ParseScramblePreset(NextValue(args, ref index, option)));
					break;
				case "--delay-before":
					ApplicationSettings.Current.Options.DelayBeforeInjection = ParseNonNegativeInt(NextValue(args, ref index, option), option);
					break;
				case "--delay-between":
					ApplicationSettings.Current.Options.DelayBetweenModules = ParseNonNegativeInt(NextValue(args, ref index, option), option);
					break;
				case "--wait-timeout":
					command.WaitTimeoutSeconds = ParseNonNegativeInt(NextValue(args, ref index, option), option);
					break;
				case "--language":
					ApplicationSettings.Current.Language = ParseLanguage(NextValue(args, ref index, option));
					UiText.Configure(ApplicationSettings.Current.Language);
					break;
				case "--primary-color":
					ApplicationSettings.Current.Options.BackgroundColor1 = ParseColor(NextValue(args, ref index, option), option);
					break;
				case "--secondary-color":
					ApplicationSettings.Current.Options.BackgroundColor2 = ParseColor(NextValue(args, ref index, option), option);
					break;
				case "--text-color":
					ApplicationSettings.Current.Options.TextColor = ParseColor(NextValue(args, ref index, option), option);
					break;
				case "--save-settings":
					command.SaveSettings = true;
					break;
				case "--settings":
					command.SettingsPath = Path.GetFullPath(NextValue(args, ref index, option));
					break;
				case "--reset-settings":
					ApplicationSettings.Current = new ApplicationSettings();
					UiText.Configure(ApplicationSettings.Current.Language);
					break;
				case "--reset-warnings":
					ApplicationSettings.Current.Warnings = new WarningPreferences();
					break;
				case "--ack-ldrp-warning":
					ApplicationSettings.Current.Warnings.LdrpLoadDllAcknowledged = true;
					break;
				case "--unack-ldrp-warning":
					ApplicationSettings.Current.Warnings.LdrpLoadDllAcknowledged = false;
					break;
				case "--ack-manual-map-warning":
					ApplicationSettings.Current.Warnings.ManualMapAcknowledged = true;
					break;
				case "--unack-manual-map-warning":
					ApplicationSettings.Current.Warnings.ManualMapAcknowledged = false;
					break;
				case "--ack-scramble-warning":
					ApplicationSettings.Current.Warnings.ScrambleAcknowledged = true;
					break;
				case "--unack-scramble-warning":
					ApplicationSettings.Current.Warnings.ScrambleAcknowledged = false;
					break;
				default:
					if (!TryApplyBooleanOption(option))
					{
						throw new CliUsageException(UiText.Format("Cli.Error.UnknownOption", args[index]));
					}
					break;
			}
		}

		if (command.ProcessId.HasValue && !string.IsNullOrWhiteSpace(command.ProcessName))
		{
			throw new CliUsageException(UiText.Get("Cli.Error.TargetMutuallyExclusive"));
		}
		return command;
	}

	private static void PrepareSettingsSource(string[] rawArguments)
	{
		for (int index = 0; index < rawArguments.Length; index++)
		{
			if (!string.Equals(rawArguments[index], "--settings", StringComparison.OrdinalIgnoreCase))
			{
				continue;
			}

			if (index + 1 >= rawArguments.Length)
			{
				return;
			}

			ApplicationSettings.Current = ApplicationSettings.Load(Path.GetFullPath(rawArguments[index + 1]));
			index++;
		}
	}

	private static bool TryApplyBooleanOption(string option)
	{
		InjectionOptions injection = ApplicationSettings.Current.Options;
		AdvancedInjectionOptions advanced = injection.Advanced;
		InjectorScrambleOptions scramble = injection.Scramble;
		switch (option)
		{
			case "--auto-inject": injection.AutoInject = true; return true;
			case "--no-auto-inject": injection.AutoInject = false; return true;
			case "--close-on-inject": injection.CloseOnInject = true; return true;
			case "--no-close-on-inject": injection.CloseOnInject = false; return true;
			case "--stealth": injection.StealthInject = true; return true;
			case "--no-stealth": injection.StealthInject = false; return true;
			case "--erase-pe": injection.ErasePeHeaders = true; return true;
			case "--no-erase-pe": injection.ErasePeHeaders = false; return true;
			case "--hide-module": injection.HideModule = true; return true;
			case "--no-hide-module": injection.HideModule = false; return true;
			case "--hide-from-debugger": advanced.HideFromDebugger = true; return true;
			case "--no-hide-from-debugger": advanced.HideFromDebugger = false; return true;
			case "--resolve-imports": advanced.ManualResolveImports = true; return true;
			case "--no-resolve-imports": advanced.ManualResolveImports = false; return true;
			case "--disable-exceptions": advanced.DisableExceptionSupport = true; return true;
			case "--enable-exceptions": advanced.DisableExceptionSupport = false; return true;
			case "--disable-seh-validation": advanced.DisableSehValidation = true; return true;
			case "--enable-seh-validation": advanced.DisableSehValidation = false; return true;
			case "--random-title": ApplicationSettings.Current.RandomizeWindowTitle = true; return true;
			case "--no-random-title": ApplicationSettings.Current.RandomizeWindowTitle = false; return true;
			case "--scramble-header-fields": scramble.ScrambleHeaderFields = true; return true;
			case "--no-scramble-header-fields": scramble.ScrambleHeaderFields = false; return true;
			case "--remove-useless-data": scramble.RemoveUselessData = true; return true;
			case "--keep-useless-data": scramble.RemoveUselessData = false; return true;
			case "--insert-sections": scramble.InsertExtraSections = true; return true;
			case "--no-insert-sections": scramble.InsertExtraSections = false; return true;
			case "--shift-section-data": scramble.ShiftSectionData = true; return true;
			case "--no-shift-section-data": scramble.ShiftSectionData = false; return true;
			case "--modify-code": scramble.ModifyAssemblyCode = true; return true;
			case "--no-modify-code": scramble.ModifyAssemblyCode = false; return true;
			case "--rename-sections": scramble.RenameSections = true; return true;
			case "--no-rename-sections": scramble.RenameSections = false; return true;
			case "--new-entry-point": scramble.CreateNewEntryPoint = true; return true;
			case "--no-new-entry-point": scramble.CreateNewEntryPoint = false; return true;
			case "--modify-imports": scramble.ModifyImportTable = true; return true;
			case "--no-modify-imports": scramble.ModifyImportTable = false; return true;
			case "--remove-debug-data": scramble.RemoveDebugData = true; return true;
			case "--keep-debug-data": scramble.RemoveDebugData = false; return true;
			case "--move-relocations": scramble.MoveRelocationTable = true; return true;
			case "--no-move-relocations": scramble.MoveRelocationTable = false; return true;
			case "--fake-debug-directory": scramble.CreateFakeDebugDirectory = true; return true;
			case "--no-fake-debug-directory": scramble.CreateFakeDebugDirectory = false; return true;
			case "--strip-section-flags": scramble.StripSectionCharacteristics = true; return true;
			case "--keep-section-flags": scramble.StripSectionCharacteristics = false; return true;
			case "--shift-section-memory": scramble.ShiftSectionMemory = true; return true;
			case "--no-shift-section-memory": scramble.ShiftSectionMemory = false; return true;
			default: return false;
		}
	}

	private static ModuleEntry RequireCurrentModule(ModuleEntry module, string option)
	{
		if (module == null)
		{
			throw new CliUsageException(UiText.Format("Cli.Error.OptionRequiresDll", option));
		}
		return module;
	}

	private static string NextValue(string[] args, ref int index, string option)
	{
		if (++index >= args.Length)
		{
			throw new CliUsageException(UiText.Format("Cli.Error.MissingValue", option));
		}
		return args[index];
	}

	private static int ParsePositiveInt(string value, string option)
	{
		if (!int.TryParse(value, out int result) || result <= 0)
		{
			throw new CliUsageException(UiText.Format("Cli.Error.PositiveInteger", option));
		}
		return result;
	}

	private static int ParseNonNegativeInt(string value, string option)
	{
		if (!int.TryParse(value, out int result) || result < 0)
		{
			throw new CliUsageException(UiText.Format("Cli.Error.NonNegativeInteger", option));
		}
		return result;
	}

	private static InjectionMethod ParseInjectionMethod(string value)
	{
		switch (value.ToLowerInvariant())
		{
			case "standard": return InjectionMethod.StandardInjection;
			case "thread-hijacking": return InjectionMethod.ThreadHijacking;
			case "ldr-load-dll":
			case "ldrp-load-dll": return InjectionMethod.LdrpLoadDll;
			case "ldrp-load-dll-stub": return InjectionMethod.LdrpLoadDllStub;
			case "manual-map": return InjectionMethod.ManualMap;
			default: throw new CliUsageException(UiText.Format("Cli.Error.InvalidMethod", value));
		}
	}

	private static ScramblePreset ParseScramblePreset(string value)
	{
		if (Enum.TryParse(value, ignoreCase: true, out ScramblePreset preset) &&
			Enum.IsDefined(typeof(ScramblePreset), preset))
		{
			return preset;
		}
		throw new CliUsageException(UiText.Format("Cli.Error.InvalidScramble", value));
	}

	private static LanguagePreference ParseLanguage(string value)
	{
		switch (value.ToLowerInvariant())
		{
			case "system": return LanguagePreference.System;
			case "en":
			case "en-us":
			case "english": return LanguagePreference.English;
			case "zh":
			case "zh-cn":
			case "chinese": return LanguagePreference.SimplifiedChinese;
			default: throw new CliUsageException(UiText.Format("Cli.Error.InvalidLanguage", value));
		}
	}

	private static CallingConvention ParseCallingConvention(string value)
	{
		switch (value.ToLowerInvariant())
		{
			case "stdcall": return CallingConvention.StdCall;
			case "fastcall": return CallingConvention.FastCall;
			case "cdecl": return CallingConvention.Cdecl;
			default: throw new CliUsageException(UiText.Format("Cli.Error.InvalidConvention", value));
		}
	}

	private static ExportParameter ParseExportParameter(string value)
	{
		int separator = value.IndexOf(':');
		if (separator <= 0)
		{
			throw new CliUsageException(UiText.Get("Cli.Error.InvalidArgumentValue"));
		}

		string type = value.Substring(0, separator).ToLowerInvariant();
		string parameterValue = value.Substring(separator + 1);
		ExportParameterType parameterType;
		switch (type)
		{
			case "ansi":
			case "lpcstr": parameterType = ExportParameterType.AnsiString; break;
			case "unicode":
			case "lpcwstr": parameterType = ExportParameterType.UnicodeString; break;
			case "byte": parameterType = ExportParameterType.Byte; break;
			case "word":
			case "uint16": parameterType = ExportParameterType.UInt16; break;
			case "dword":
			case "uint32": parameterType = ExportParameterType.UInt32; break;
			case "qword":
			case "uint64": parameterType = ExportParameterType.UInt64; break;
			case "float":
			case "single": parameterType = ExportParameterType.Single; break;
			default: throw new CliUsageException(UiText.Format("Cli.Error.InvalidArgumentType", type));
		}

		return new ExportParameter { Type = parameterType, Value = parameterValue };
	}

	private static Color ParseColor(string value, string option)
	{
		try
		{
			Color color = ColorTranslator.FromHtml(value);
			if (color.IsEmpty)
			{
				throw new ArgumentException();
			}
			return color;
		}
		catch
		{
			throw new CliUsageException(UiText.Format("Cli.Error.InvalidColor", option, value));
		}
	}

	private static bool IsAdministrator()
	{
		using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
		{
			return new WindowsPrincipal(identity).IsInRole(WindowsBuiltInRole.Administrator);
		}
	}

	private static int Fail(int exitCode, string message)
	{
		Console.Error.WriteLine(message);
		return exitCode;
	}

	private sealed class CliCommand
	{
		internal bool ShowHelp;
		internal bool SaveSettings;
		internal string SettingsPath;
		internal int? ProcessId;
		internal string ProcessName;
		internal int WaitTimeoutSeconds;
		internal bool ModulesSpecified;
		internal readonly List<ModuleEntry> Modules = new List<ModuleEntry>();

		internal bool HasInjectionTarget => ProcessId.HasValue || !string.IsNullOrWhiteSpace(ProcessName);
	}

	private sealed class CliUsageException : Exception
	{
		internal CliUsageException(string message) : base(message)
		{
		}
	}
}
