using System;
using System.IO;

if (args.Length != 1)
{
	Console.Error.WriteLine("Usage: SettingsContractVerifier <settings.xml>");
	return 2;
}

var sourcePath = Path.GetFullPath(args[0]);
var settings = ApplicationSettings.Load(sourcePath);
if (settings.Modules.Count == 0)
{
	Console.Error.WriteLine("The settings file loaded without any module entries.");
	return 3;
}

var temporaryPath = Path.Combine(
	Path.GetTempPath(),
	$"ExtremeInjector.Settings.{Guid.NewGuid():N}.xml");

try
{
	ApplicationSettings.Current = settings;
	ApplicationSettings.Save(temporaryPath);
	var roundTripped = ApplicationSettings.Load(temporaryPath);

	if (roundTripped.ProcessName != settings.ProcessName ||
		roundTripped.Modules.Count != settings.Modules.Count ||
		roundTripped.Options.Method != settings.Options.Method)
	{
		Console.Error.WriteLine("The clean settings contract did not round-trip correctly.");
		return 4;
	}

	Console.WriteLine($"Process: {roundTripped.ProcessName}");
	Console.WriteLine($"Modules: {roundTripped.Modules.Count}");
	Console.WriteLine($"Method: {roundTripped.Options.Method}");
	Console.WriteLine($"Scramble preset: {roundTripped.Options.Scramble.Detect()}");
	return 0;
}
finally
{
	if (File.Exists(temporaryPath))
	{
		File.Delete(temporaryPath);
	}
}
