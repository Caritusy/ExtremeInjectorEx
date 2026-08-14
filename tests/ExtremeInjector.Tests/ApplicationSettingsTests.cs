using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtremeInjector.Tests;

[TestClass]
[DoNotParallelize]
public sealed class ApplicationSettingsTests
{
	[TestMethod]
	public void DefaultsAreSafeAndComplete()
	{
		var settings = new ApplicationSettings();

		Assert.IsNotNull(settings.Modules);
		Assert.IsNotNull(settings.Options);
		Assert.IsNotNull(settings.Options.Advanced);
		Assert.IsNotNull(settings.Options.Scramble);
		Assert.IsNotNull(settings.Warnings);
		Assert.AreEqual(LanguagePreference.System, settings.Language);
		Assert.IsTrue(settings.RandomizeWindowTitle);
		Assert.AreEqual(InjectionMethod.StandardInjection, settings.Options.Method);
	}

	[TestMethod]
	public void SaveAndLoadPreserveUserConfiguration()
	{
		string directory = Path.Combine(Path.GetTempPath(), "ExtremeInjectorEx.Tests", Guid.NewGuid().ToString("N"));
		string path = Path.Combine(directory, "settings.xml");
		ApplicationSettings previous = ApplicationSettings.Current;

		try
		{
			var settings = new ApplicationSettings
			{
				ProcessName = "sample.exe",
				Language = LanguagePreference.SimplifiedChinese,
				RandomizeWindowTitle = false
			};
			settings.Options.Method = InjectionMethod.ManualMap;
			settings.Options.DelayBeforeInjection = 125;
			settings.Options.Scramble.ApplyPreset(global::ScramblePreset.Standard);
			settings.Modules.Add(new ModuleEntry
			{
				Path = @"D:\Modules\Sample.dll",
				Enabled = true,
				CallingConvention = CallingConvention.StdCall
			});

			ApplicationSettings.Current = settings;
			ApplicationSettings.Save(path);

			ApplicationSettings loaded = ApplicationSettings.Load(path);
			Assert.AreEqual("sample.exe", loaded.ProcessName);
			Assert.AreEqual(LanguagePreference.SimplifiedChinese, loaded.Language);
			Assert.IsFalse(loaded.RandomizeWindowTitle);
			Assert.AreEqual(InjectionMethod.ManualMap, loaded.Options.Method);
			Assert.AreEqual(125, loaded.Options.DelayBeforeInjection);
			Assert.AreEqual(global::ScramblePreset.Standard, loaded.Options.Scramble.Detect());
			Assert.AreEqual(1, loaded.Modules.Count);
			Assert.AreEqual(@"D:\Modules\Sample.dll", loaded.Modules[0].Path);
			Assert.IsTrue(loaded.Modules[0].Enabled);
		}
		finally
		{
			ApplicationSettings.Current = previous;
			if (Directory.Exists(directory))
			{
				Directory.Delete(directory, recursive: true);
			}
		}
	}

	[TestMethod]
	public void InvalidSettingsFallBackToDefaults()
	{
		string path = Path.Combine(Path.GetTempPath(), "ExtremeInjectorEx.Tests." + Guid.NewGuid().ToString("N") + ".xml");
		try
		{
			File.WriteAllText(path, "<not-valid-settings>");
			ApplicationSettings loaded = ApplicationSettings.Load(path);

			Assert.IsNotNull(loaded.Options);
			Assert.IsNotNull(loaded.Modules);
			Assert.AreEqual(LanguagePreference.System, loaded.Language);
			Assert.IsTrue(loaded.RandomizeWindowTitle);
		}
		finally
		{
			if (File.Exists(path))
			{
				File.Delete(path);
			}
		}
	}
}
