using System.IO;

public sealed class PeImportReader : PeImageReader
{
	internal PeImportReader(Stream stream, string text, bool flag, PeImageLayout peImageLayout)
		: base(stream, text, flag, peImageLayout)
	{
	}

	protected override void ReadDirectories()
	{
		peImage.SetImports(RecoveredRuntime.ReadImportDirectory(peImage, this));
	}

	public static PeImage ReadImports(Stream stream, string text, bool flag, PeImageLayout peImageLayout)
	{
		PeImportReader @class = new PeImportReader(stream, text, flag, peImageLayout);
		if (!@class.TryRead())
		{
			return null;
		}
		return @class.peImage;
	}
}
