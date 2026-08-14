using System.IO;

public sealed class PeImportReader : PeImageReader
{
	internal PeImportReader(Stream stream_0, string string_0, bool bool_0, PeImageLayout enum39_0)
		: base(stream_0, string_0, bool_0, enum39_0)
	{
	}

	protected override void ReadDirectories()
	{
		class154_0.SetImports(RecoveredRuntime.ReadImportDirectory(class154_0, this));
	}

	public static PeImage ReadImports(Stream stream_0, string string_0, bool bool_0, PeImageLayout enum39_0)
	{
		PeImportReader @class = new PeImportReader(stream_0, string_0, bool_0, enum39_0);
		if (!@class.TryRead())
		{
			return null;
		}
		return @class.class154_0;
	}
}
