using System.IO;

public sealed class PeExportReader : PeImageReader
{
	internal PeExportReader(Stream stream, bool flag, PeImageLayout peImageLayout)
		: base(stream, flag, peImageLayout)
	{
	}

	internal PeExportReader(Stream stream, string text, bool flag, PeImageLayout peImageLayout)
		: base(stream, text, flag, peImageLayout)
	{
	}

	protected override void ReadDirectories()
	{
		peImage.SetExports(RecoveredRuntime.ReadExportDirectory(peImage, this));
	}

	public static PeImage ReadExports(Stream stream, bool ownsStream, PeImageLayout layout)
	{
		var reader = new PeExportReader(stream, ownsStream, layout);
		return reader.TryRead() ? reader.peImage : null;
	}

	public static PeImage ReadExports(Stream stream, string path, bool ownsStream, PeImageLayout layout)
	{
		var reader = new PeExportReader(stream, path, ownsStream, layout);
		return reader.TryRead() ? reader.peImage : null;
	}
}
