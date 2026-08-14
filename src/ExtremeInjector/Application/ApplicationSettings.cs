using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Linq;

[DataContract(Name = "ApplicationSettings", Namespace = "")]
public sealed class ApplicationSettings
{
	public const string DefaultFileName = "settings.xml";
	public const string SettingsFolderName = "ExtremeInjectorEx";
	internal const string SettingsDirectoryOverrideKey = "ExtremeInjectorEx.SettingsDirectoryOverride";

	private static readonly object FileSync = new object();

	public static string DefaultSettingsDirectory => Path.Combine(
		Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
		SettingsFolderName);

	public static string SettingsDirectory
	{
		get
		{
			string overridePath = AppDomain.CurrentDomain.GetData(SettingsDirectoryOverrideKey) as string;
			return string.IsNullOrWhiteSpace(overridePath)
				? DefaultSettingsDirectory
				: Path.GetFullPath(overridePath);
		}
	}

	public static string DefaultPath => Path.Combine(SettingsDirectory, DefaultFileName);

	[DataMember(Name = "ProcessName")]
	public string ProcessName { get; set; }

	[DataMember(Name = "Modules")]
	public List<ModuleEntry> Modules { get; set; }

	[DataMember(Name = "Warnings")]
	public WarningPreferences Warnings { get; set; }

	[DataMember(Name = "Options")]
	public InjectionOptions Options { get; set; }

	[DataMember(Name = "LastUpdateCheck")]
	public DateTime LastUpdateCheck { get; set; }

	public static ApplicationSettings Current { get; set; }

	static ApplicationSettings()
	{
		Current = LoadDefault();
	}

	public ApplicationSettings()
	{
		InitializeDefaults();
	}

	public static ApplicationSettings Load(string path)
	{
		if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
		{
			return new ApplicationSettings();
		}

		lock (FileSync)
		{
			try
			{
				var document = XDocument.Load(path);
				NormalizeLegacyContractNames(document);

				var serializer = new DataContractSerializer(typeof(ApplicationSettings));
				using (var reader = document.CreateReader())
				{
					return (ApplicationSettings)serializer.ReadObject(reader, verifyObjectName: false);
				}
			}
			catch (Exception)
			{
				return new ApplicationSettings();
			}
		}
	}

	public static void Save()
	{
		Save(DefaultPath);
	}

	public static void Save(string path)
	{
		if (string.IsNullOrWhiteSpace(path))
		{
			throw new ArgumentException("A settings path is required.", nameof(path));
		}

		lock (FileSync)
		{
			WriteAtomically(Current, Path.GetFullPath(path));
		}
	}

	private static ApplicationSettings LoadDefault()
	{
		if (File.Exists(DefaultPath))
		{
			return Load(DefaultPath);
		}

		foreach (string legacyPath in GetLegacyPaths())
		{
			if (!File.Exists(legacyPath) || PathsEqual(legacyPath, DefaultPath))
			{
				continue;
			}

			ApplicationSettings migrated = Load(legacyPath);
			try
			{
				lock (FileSync)
				{
					WriteAtomically(migrated, DefaultPath);
				}
			}
			catch (IOException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}

			return migrated;
		}

		return new ApplicationSettings();
	}

	private static IEnumerable<string> GetLegacyPaths()
	{
		yield return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DefaultFileName);
		yield return Path.GetFullPath(DefaultFileName);
	}

	private static bool PathsEqual(string left, string right)
	{
		return string.Equals(
			Path.GetFullPath(left).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar),
			Path.GetFullPath(right).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar),
			StringComparison.OrdinalIgnoreCase);
	}

	private static void WriteAtomically(ApplicationSettings settings, string path)
	{
		string directory = Path.GetDirectoryName(path);
		if (!string.IsNullOrEmpty(directory))
		{
			Directory.CreateDirectory(directory);
		}

		string temporaryPath = path + ".tmp";
		string backupPath = path + ".bak";
		var serializer = new DataContractSerializer(typeof(ApplicationSettings));
		var writerSettings = new XmlWriterSettings { Indent = true };

		try
		{
			using (var writer = XmlWriter.Create(temporaryPath, writerSettings))
			{
				serializer.WriteObject(writer, settings);
			}

			if (File.Exists(path))
			{
				File.Replace(temporaryPath, path, backupPath, ignoreMetadataErrors: true);
			}
			else
			{
				File.Move(temporaryPath, path);
			}
		}
		finally
		{
			if (File.Exists(temporaryPath))
			{
				File.Delete(temporaryPath);
			}
		}
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext context)
	{
		InitializeDefaults();
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context)
	{
		Modules = Modules ?? new List<ModuleEntry>();
		Warnings = Warnings ?? new WarningPreferences();
		Options = Options ?? new InjectionOptions();
	}

	private void InitializeDefaults()
	{
		Modules = new List<ModuleEntry>();
		Warnings = new WarningPreferences();
		Options = new InjectionOptions();
	}

	private static void NormalizeLegacyContractNames(XDocument document)
	{
		var root = document.Root;
		if (root == null)
		{
			return;
		}

		root.Name = "ApplicationSettings";
		var modulesNode = FindChild(root, "Modules");
		if (modulesNode == null)
		{
			return;
		}

		foreach (var moduleNode in modulesNode.Elements())
		{
			moduleNode.Name = "ModuleEntry";
			var parametersNode = FindChild(moduleNode, "Parameters");
			if (parametersNode == null)
			{
				continue;
			}

			foreach (var parameterNode in parametersNode.Elements())
			{
				parameterNode.Name = "ExportParameter";
			}
		}
	}

	private static XElement FindChild(XContainer parent, string localName)
	{
		foreach (var child in parent.Elements())
		{
			if (child.Name.LocalName == localName)
			{
				return child;
			}
		}

		return null;
	}
}
