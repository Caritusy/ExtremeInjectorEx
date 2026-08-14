using System.IO;

public sealed class PeExportReader : PeImageReader
{
	internal PeExportReader(Stream stream_0, bool bool_0, PeImageLayout enum39_0)
		: base(stream_0, bool_0, enum39_0)
	{
	}

	internal PeExportReader(Stream stream_0, string string_0, bool bool_0, PeImageLayout enum39_0)
		: base(stream_0, string_0, bool_0, enum39_0)
	{
	}

	protected override void ReadDirectories()
	{
		class154_0.SetExports(RecoveredRuntime.ReadExportDirectory(class154_0, this));
	}

	public static PeImage ReadExports(Stream stream, bool ownsStream, PeImageLayout layout)
	{
		var reader = new PeExportReader(stream, ownsStream, layout);
		return reader.TryRead() ? reader.class154_0 : null;
	}

	public static PeImage ReadExports(Stream stream, string path, bool ownsStream, PeImageLayout layout)
	{
		var reader = new PeExportReader(stream, path, ownsStream, layout);
		return reader.TryRead() ? reader.class154_0 : null;
	}
}
