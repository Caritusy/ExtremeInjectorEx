using System;
using System.Collections.Generic;
using System.IO;

public class PeImageReader : BoundsCheckedBinaryReader
{
	protected readonly PeImage peImage;

	protected PeImageReader(Stream stream, bool flag, PeImageLayout peImageLayout)
		: base(stream)
	{
		peImage = new PeImage(stream, flag, peImageLayout);
	}

	protected PeImageReader(Stream stream, string text, bool flag, PeImageLayout peImageLayout)
		: base(stream)
	{
		PeImage @class = new PeImage(stream, flag, peImageLayout);
		@class.SetFilePath(Path.GetFullPath(text));
		@class.SetFileName(Path.GetFileName(text));
		peImage = @class;
	}

	protected virtual bool TryRead()
	{
		if (this.TryReadHeaders())
		{
			this.ReadDirectories();
			return true;
		}
		return false;
	}

	protected virtual bool TryReadHeaders()
	{
		long imageStart = BaseStream.Position;
		DosHeader dosHeader = null;
		if (!RecoveredRuntime.TryReadDosHeader(ref dosHeader, this))
		{
			return false;
		}

		peImage.SetDosHeader(dosHeader);
		BaseStream.Position = imageStart + dosHeader.GetPeHeaderOffset();

		PeHeaders peHeaders = null;
		if (!RecoveredRuntime.TryReadPeHeaders(ref peHeaders, this))
		{
			return false;
		}

		peImage.SetHeaders(peHeaders);
		var sections = new List<PeSectionHeader>(peHeaders.GetCoffHeader().GetNumberOfSections());
		peImage.SetSections(sections);
		for (int index = 0; index < peHeaders.GetCoffHeader().GetNumberOfSections(); index++)
		{
			sections.Add(new PeSectionHeader(this));
		}

		return true;
	}

	protected virtual void ReadDirectories()
	{
		this.peImage.SetImports(RecoveredRuntime.ReadImportDirectory(this.peImage, this));
		this.peImage.SetDelayImports(RecoveredRuntime.ReadDelayImportDirectory(this, this.peImage));
		this.peImage.SetExports(RecoveredRuntime.ReadExportDirectory(this.peImage, this));
		this.peImage.SetBaseRelocations(RecoveredRuntime.ReadBaseRelocationDirectory(this.peImage, this));
		this.peImage.SetResources(RecoveredRuntime.ReadResourceDirectory(this.peImage, this));
		this.peImage.SetDebugDirectory(RecoveredRuntime.ReadDebugDirectory(this.peImage, this));
		this.peImage.SetTlsDirectory(RecoveredRuntime.ReadTlsDirectory(this.peImage, this));
		this.peImage.SetLoadConfigurationDirectory(RecoveredRuntime.ReadLoadConfigurationDirectory(this, this.peImage));
		this.peImage.SetExceptionDirectory(RecoveredRuntime.ReadExceptionDirectory(this.peImage, this));
		this.peImage.SetClrHeader(RecoveredRuntime.ReadClrHeader(this.peImage, this));
	}

	public static PeImage ReadFullImage(Stream stream, bool flag, PeImageLayout peImageLayout)
	{
		PeImageReader @class = new PeImageReader(stream, flag, peImageLayout);
		if (!@class.TryRead())
		{
			return null;
		}
		return @class.peImage;
	}

	public static PeImage ReadFullImage(Stream stream, string text, bool flag, PeImageLayout peImageLayout)
	{
		PeImageReader @class = new PeImageReader(stream, text, flag, peImageLayout);
		if (!@class.TryRead())
		{
			return null;
		}
		return @class.peImage;
	}

}
