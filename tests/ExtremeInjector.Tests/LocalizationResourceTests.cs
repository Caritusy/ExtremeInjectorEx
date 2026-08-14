using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtremeInjector.Tests;

[TestClass]
public sealed class LocalizationResourceTests
{
	[TestMethod]
	public void EnglishAndChineseResourcesHaveIdenticalNonEmptyKeys()
	{
		Dictionary<string, string> english = LoadResource("Strings.en.resx");
		Dictionary<string, string> chinese = LoadResource("Strings.zh-CN.resx");

		CollectionAssert.AreEquivalent(english.Keys.ToArray(), chinese.Keys.ToArray());
		Assert.IsFalse(english.Values.Any(string.IsNullOrWhiteSpace), "English resources contain an empty value.");
		Assert.IsFalse(chinese.Values.Any(string.IsNullOrWhiteSpace), "Chinese resources contain an empty value.");
	}

	private static Dictionary<string, string> LoadResource(string fileName)
	{
		string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Localization", fileName);
		XDocument document = XDocument.Load(path);
		return document.Root!
			.Elements("data")
			.ToDictionary(
				element => (string)element.Attribute("name")!,
				element => (string)element.Element("value") ?? string.Empty,
				StringComparer.Ordinal);
	}
}
