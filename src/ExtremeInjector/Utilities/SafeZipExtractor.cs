using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

internal static class SafeZipExtractor
{
	private const int MaximumEntryCount = 4096;
	private const long MaximumExpandedBytes = 1024L * 1024L * 1024L;

	private sealed class ExtractionEntry
	{
		internal ZipArchiveEntry ArchiveEntry { get; }

		internal string DestinationPath { get; }

		internal bool IsDirectory { get; }

		internal ExtractionEntry(ZipArchiveEntry archiveEntry, string destinationPath, bool isDirectory)
		{
			ArchiveEntry = archiveEntry;
			DestinationPath = destinationPath;
			IsDirectory = isDirectory;
		}
	}

	internal static void Extract(byte[] archiveBytes, string destinationDirectory)
	{
		if (archiveBytes == null)
		{
			throw new ArgumentNullException(nameof(archiveBytes));
		}
		if (string.IsNullOrWhiteSpace(destinationDirectory))
		{
			throw new ArgumentException("A destination directory is required.", nameof(destinationDirectory));
		}

		string destinationRoot = Path.GetFullPath(destinationDirectory);
		string destinationPrefix = destinationRoot.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
			+ Path.DirectorySeparatorChar;

		using var archiveStream = new MemoryStream(archiveBytes, writable: false);
		using var archive = new ZipArchive(archiveStream, ZipArchiveMode.Read, leaveOpen: false);
		if (archive.Entries.Count > MaximumEntryCount)
		{
			throw new InvalidDataException($"The archive contains more than {MaximumEntryCount} entries.");
		}

		var entries = new List<ExtractionEntry>(archive.Entries.Count);
		long expandedBytes = 0;
		foreach (ZipArchiveEntry archiveEntry in archive.Entries)
		{
			string normalizedName = archiveEntry.FullName
				.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar)
				.Replace('/', Path.DirectorySeparatorChar);
			if (string.IsNullOrWhiteSpace(normalizedName))
			{
				continue;
			}
			if (normalizedName.IndexOf(':') >= 0)
			{
				throw new InvalidDataException($"Archive entry contains a disallowed path separator: {archiveEntry.FullName}");
			}

			string destinationPath = Path.GetFullPath(Path.Combine(destinationRoot, normalizedName));
			if (!destinationPath.StartsWith(destinationPrefix, StringComparison.OrdinalIgnoreCase))
			{
				throw new InvalidDataException($"Archive entry escapes the destination directory: {archiveEntry.FullName}");
			}
			EnsureNoReparsePoints(destinationRoot, destinationPath);

			bool isDirectory = archiveEntry.FullName.EndsWith("/", StringComparison.Ordinal)
				|| archiveEntry.FullName.EndsWith("\\", StringComparison.Ordinal);
			if (!isDirectory)
			{
				expandedBytes = checked(expandedBytes + archiveEntry.Length);
				if (expandedBytes > MaximumExpandedBytes)
				{
					throw new InvalidDataException("The archive exceeds the permitted expanded size.");
				}
			}

			entries.Add(new ExtractionEntry(archiveEntry, destinationPath, isDirectory));
		}

		Directory.CreateDirectory(destinationRoot);
		foreach (ExtractionEntry entry in entries)
		{
			if (entry.IsDirectory)
			{
				Directory.CreateDirectory(entry.DestinationPath);
				continue;
			}

			string parentDirectory = Path.GetDirectoryName(entry.DestinationPath);
			if (!string.IsNullOrEmpty(parentDirectory))
			{
				Directory.CreateDirectory(parentDirectory);
			}

			using Stream input = entry.ArchiveEntry.Open();
			using var output = new FileStream(entry.DestinationPath, FileMode.Create, FileAccess.Write, FileShare.None);
			input.CopyTo(output);
		}
	}

	private static void EnsureNoReparsePoints(string destinationRoot, string destinationPath)
	{
		string relativePath = destinationPath.Substring(destinationRoot.Length)
			.TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
		string currentPath = destinationRoot;
		foreach (string segment in relativePath.Split(new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries))
		{
			currentPath = Path.Combine(currentPath, segment);
			if ((Directory.Exists(currentPath) || File.Exists(currentPath))
				&& (File.GetAttributes(currentPath) & FileAttributes.ReparsePoint) != 0)
			{
				throw new InvalidDataException($"Archive extraction cannot traverse a reparse point: {currentPath}");
			}
		}
	}
}
