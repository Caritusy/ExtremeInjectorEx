using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtremeInjector.Tests;

[TestClass]
public sealed class PortableExecutableTests
{
	[TestMethod]
	public void ReaderParsesTheBuiltApplicationImage()
	{
		string path = typeof(ApplicationSettings).Assembly.Location;
		using FileStream stream = File.OpenRead(path);
		using PeImage image = PeImageReader.ReadFullImage(stream, path, flag: false, PeImageLayout.File);

		Assert.IsNotNull(image);
		Assert.AreEqual(Path.GetFileName(path), image.GetFileName());
		Assert.IsNotNull(image.GetDosHeader());
		Assert.IsNotNull(image.GetHeaders());
		Assert.IsNotNull(image.GetHeaders().GetCoffHeader());
		Assert.IsNotNull(image.GetHeaders().GetOptionalHeader());
		Assert.IsTrue(image.GetSections().Count > 0);
	}

	[TestMethod]
	public void ReaderRejectsNonPeInput()
	{
		using var stream = new MemoryStream(new byte[128]);

		PeImage image = PeImageReader.ReadFullImage(stream, flag: false, PeImageLayout.File);

		Assert.IsNull(image);
	}
}
