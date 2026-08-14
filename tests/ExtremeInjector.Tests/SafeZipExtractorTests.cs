using System;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtremeInjector.Tests;

[TestClass]
public sealed class SafeZipExtractorTests
{
	[TestMethod]
	public void ExtractCreatesFilesInsideDestination()
	{
		byte[] archive = CreateArchive(("nested/example.txt", "expected"));
		string destination = CreateTemporaryDirectory();

		try
		{
			SafeZipExtractor.Extract(archive, destination);

			Assert.AreEqual("expected", File.ReadAllText(Path.Combine(destination, "nested", "example.txt")));
		}
		finally
		{
			Directory.Delete(destination, recursive: true);
		}
	}

	[TestMethod]
	public void ExtractRejectsPathTraversalBeforeWritingFiles()
	{
		byte[] archive = CreateArchive(("safe.txt", "safe"), ("../escaped.txt", "escaped"));
		string destination = CreateTemporaryDirectory();
		string escapedPath = Path.GetFullPath(Path.Combine(destination, "..", "escaped.txt"));

		try
		{
			Assert.ThrowsExactly<InvalidDataException>(() => SafeZipExtractor.Extract(archive, destination));
			Assert.IsFalse(File.Exists(Path.Combine(destination, "safe.txt")));
			Assert.IsFalse(File.Exists(escapedPath));
		}
		finally
		{
			Directory.Delete(destination, recursive: true);
			if (File.Exists(escapedPath))
			{
				File.Delete(escapedPath);
			}
		}
	}

	[TestMethod]
	public void ExtractRejectsAlternateDataStreamPaths()
	{
		byte[] archive = CreateArchive(("example.txt:payload", "unexpected"));
		string destination = CreateTemporaryDirectory();

		try
		{
			Assert.ThrowsExactly<InvalidDataException>(() => SafeZipExtractor.Extract(archive, destination));
		}
		finally
		{
			Directory.Delete(destination, recursive: true);
		}
	}

	private static byte[] CreateArchive(params (string Name, string Content)[] entries)
	{
		using var stream = new MemoryStream();
		using (var archive = new ZipArchive(stream, ZipArchiveMode.Create, leaveOpen: true))
		{
			foreach ((string name, string content) in entries)
			{
				ZipArchiveEntry entry = archive.CreateEntry(name);
				using var writer = new StreamWriter(entry.Open());
				writer.Write(content);
			}
		}
		return stream.ToArray();
	}

	private static string CreateTemporaryDirectory()
	{
		string path = Path.Combine(Path.GetTempPath(), "ExtremeInjectorEx.Tests", Guid.NewGuid().ToString("N"));
		Directory.CreateDirectory(path);
		return path;
	}
}
