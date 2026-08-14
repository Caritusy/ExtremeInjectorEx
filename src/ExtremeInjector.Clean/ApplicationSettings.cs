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

	public static ApplicationSettings Current { get; set; } = Load(DefaultFileName);

	public ApplicationSettings()
	{
		InitializeDefaults();
	}

	public static ApplicationSettings Load(string path)
	{
		if (!File.Exists(path))
		{
			return new ApplicationSettings();
		}

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

	public static void Save()
	{
		Save(DefaultFileName);
	}

	public static void Save(string path)
	{
		var serializer = new DataContractSerializer(typeof(ApplicationSettings));
		var writerSettings = new XmlWriterSettings { Indent = true };
		using (var writer = XmlWriter.Create(path, writerSettings))
		{
			serializer.WriteObject(writer, Current);
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
