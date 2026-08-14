using System;
using System.Collections.Generic;
using System.IO;

public class PeImageReader : BoundsCheckedBinaryReader
{
	protected readonly PeImage class154_0;

	protected PeImageReader(Stream stream_0, bool bool_0, PeImageLayout enum39_0)
		: base(stream_0)
	{
		class154_0 = new PeImage(stream_0, bool_0, enum39_0);
	}

	protected PeImageReader(Stream stream_0, string string_0, bool bool_0, PeImageLayout enum39_0)
		: base(stream_0)
	{
		PeImage @class = new PeImage(stream_0, bool_0, enum39_0);
		@class.SetFilePath(Path.GetFullPath(string_0));
		@class.SetFileName(Path.GetFileName(string_0));
		class154_0 = @class;
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

		class154_0.SetDosHeader(dosHeader);
		BaseStream.Position = imageStart + dosHeader.GetPeHeaderOffset();

		PeHeaders peHeaders = null;
		if (!RecoveredRuntime.TryReadPeHeaders(ref peHeaders, this))
		{
			return false;
		}

		class154_0.SetHeaders(peHeaders);
		var sections = new List<PeSectionHeader>(peHeaders.GetCoffHeader().GetNumberOfSections());
		class154_0.SetSections(sections);
		for (int index = 0; index < peHeaders.GetCoffHeader().GetNumberOfSections(); index++)
		{
			sections.Add(new PeSectionHeader(this));
		}

		return true;
	}

	protected virtual void ReadDirectories()
	{
		this.class154_0.SetImports(RecoveredRuntime.ReadImportDirectory(this.class154_0, this));
		this.class154_0.SetDelayImports(RecoveredRuntime.ReadDelayImportDirectory(this, this.class154_0));
		this.class154_0.SetExports(RecoveredRuntime.ReadExportDirectory(this.class154_0, this));
		this.class154_0.SetBaseRelocations(RecoveredRuntime.ReadBaseRelocationDirectory(this.class154_0, this));
		this.class154_0.SetResources(RecoveredRuntime.ReadResourceDirectory(this.class154_0, this));
		this.class154_0.SetDebugDirectory(RecoveredRuntime.ReadDebugDirectory(this.class154_0, this));
		this.class154_0.SetTlsDirectory(RecoveredRuntime.ReadTlsDirectory(this.class154_0, this));
		this.class154_0.SetLoadConfigurationDirectory(RecoveredRuntime.ReadLoadConfigurationDirectory(this, this.class154_0));
		this.class154_0.SetExceptionDirectory(RecoveredRuntime.ReadExceptionDirectory(this.class154_0, this));
		this.class154_0.SetClrHeader(RecoveredRuntime.ReadClrHeader(this.class154_0, this));
	}

	public static PeImage ReadFullImage(Stream stream_0, bool bool_0, PeImageLayout enum39_0)
	{
		PeImageReader @class = new PeImageReader(stream_0, bool_0, enum39_0);
		if (!@class.TryRead())
		{
			return null;
		}
		return @class.class154_0;
	}

	public static PeImage ReadFullImage(Stream stream_0, string string_0, bool bool_0, PeImageLayout enum39_0)
	{
		PeImageReader @class = new PeImageReader(stream_0, string_0, bool_0, enum39_0);
		if (!@class.TryRead())
		{
			return null;
		}
		return @class.class154_0;
	}

}
