using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class PeImage : IDisposable
{
	public interface IRvaToFileOffsetMapper
	{
		long MapRvaToFileOffset(PeImage peImage, uint uintValue);
	}

	public sealed class FileLayoutRvaMapper : IRvaToFileOffsetMapper
	{
		public long MapRvaToFileOffset(PeImage peImage, uint uintValue)
		{
			foreach (PeSectionHeader gclass in peImage.GetSections())
			{
				if (uintValue >= gclass.GetVirtualAddress() && uintValue < gclass.GetVirtualAddress() + gclass.GetSizeOfRawData())
				{
					return (long)((ulong)(uintValue - gclass.GetVirtualAddress() + gclass.GetPointerToRawData()));
				}
			}
			return -1L;
		}
	}

	public sealed class MemoryLayoutRvaMapper : IRvaToFileOffsetMapper
	{
		public long MapRvaToFileOffset(PeImage peImage, uint uintValue)
		{
			return uintValue;
		}
	}

	[CompilerGenerated]
	internal string filePath;

	[CompilerGenerated]
	internal string fileName;

	[CompilerGenerated]
	internal DosHeader dosHeader;

	[CompilerGenerated]
	internal PeHeaders headers;

	[CompilerGenerated]
	internal List<PeSectionHeader> sections;

	[CompilerGenerated]
	internal ImportDirectory imports;

	[CompilerGenerated]
	internal DelayImportDirectory delayImports;

	[CompilerGenerated]
	internal ExportDirectory exports;

	[CompilerGenerated]
	internal BaseRelocationDirectory baseRelocations;

	[CompilerGenerated]
	internal DebugDirectoryEntry debugDirectory;

	[CompilerGenerated]
	internal TlsDirectory tlsDirectory;

	[CompilerGenerated]
	internal LoadConfigurationDirectory loadConfigurationDirectory;

	[CompilerGenerated]
	internal ResourceDirectory resources;

	[CompilerGenerated]
	internal ExceptionDirectory exceptionDirectory;

	[CompilerGenerated]
	internal ClrHeader clrHeader;

	[CompilerGenerated]
	internal Stream stream;

	[CompilerGenerated]
	internal PeImageLayout layout;

	internal readonly bool flag;

	internal readonly IRvaToFileOffsetMapper rvaMapper;

	[SpecialName]
	[CompilerGenerated]
	public string GetFilePath()
	{
		return filePath;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetFilePath(string text)
	{
		filePath = text;
	}

	[SpecialName]
	[CompilerGenerated]
	public string GetFileName()
	{
		return fileName;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetFileName(string text)
	{
		fileName = text;
	}

	[SpecialName]
	[CompilerGenerated]
	public DosHeader GetDosHeader()
	{
		return dosHeader;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDosHeader(DosHeader dosHeader2)
	{
		dosHeader = dosHeader2;
	}

	[SpecialName]
	[CompilerGenerated]
	public PeHeaders GetHeaders()
	{
		return headers;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetHeaders(PeHeaders peHeaders)
	{
		headers = peHeaders;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<PeSectionHeader> GetSections()
	{
		return sections;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSections(List<PeSectionHeader> items)
	{
		sections = items;
	}

	[SpecialName]
	[CompilerGenerated]
	public ImportDirectory GetImports()
	{
		return imports;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetImports(ImportDirectory importDirectory)
	{
		imports = importDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public DelayImportDirectory GetDelayImports()
	{
		return delayImports;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDelayImports(DelayImportDirectory delayImportDirectory)
	{
		delayImports = delayImportDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public ExportDirectory GetExports()
	{
		return exports;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetExports(ExportDirectory exportDirectory)
	{
		exports = exportDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public BaseRelocationDirectory GetBaseRelocations()
	{
		return baseRelocations;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetBaseRelocations(BaseRelocationDirectory baseRelocationDirectory)
	{
		baseRelocations = baseRelocationDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public DebugDirectoryEntry GetDebugDirectory()
	{
		return debugDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDebugDirectory(DebugDirectoryEntry debugDirectoryEntry)
	{
		debugDirectory = debugDirectoryEntry;
	}

	[SpecialName]
	[CompilerGenerated]
	public TlsDirectory GetTlsDirectory()
	{
		return tlsDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetTlsDirectory(TlsDirectory tlsDirectory2)
	{
		tlsDirectory = tlsDirectory2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetLoadConfigurationDirectory(LoadConfigurationDirectory loadConfigurationDirectory2)
	{
		loadConfigurationDirectory = loadConfigurationDirectory2;
	}

	[SpecialName]
	[CompilerGenerated]
	public ResourceDirectory GetResources()
	{
		return resources;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetResources(ResourceDirectory resourceDirectory)
	{
		resources = resourceDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public ExceptionDirectory GetExceptionDirectory()
	{
		return exceptionDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetExceptionDirectory(ExceptionDirectory exceptionDirectory2)
	{
		exceptionDirectory = exceptionDirectory2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetClrHeader(ClrHeader clrHeader2)
	{
		clrHeader = clrHeader2;
	}

	[SpecialName]
	[CompilerGenerated]
	public Stream GetStream()
	{
		return stream;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetStream(Stream stream2)
	{
		stream = stream2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetLayout(PeImageLayout peImageLayout)
	{
		layout = peImageLayout;
	}

	public PeImage(Stream stream2, PeImageLayout peImageLayout)
	{
		this.SetLayout(peImageLayout);
		this.SetStream(stream2);
		if (peImageLayout != PeImageLayout.File)
		{
			this.rvaMapper = new PeImage.MemoryLayoutRvaMapper();
			return;
		}
		this.rvaMapper = new PeImage.FileLayoutRvaMapper();
	}

	public PeImage(Stream stream2, bool flag2, PeImageLayout peImageLayout)
		: this(stream2, peImageLayout)
	{
		flag = flag2;
	}

	public void Dispose()
	{
		if (this.flag && this.GetStream() != null)
		{
			this.GetStream().Dispose();
			this.SetStream(null);
		}

		GC.SuppressFinalize(this);
	}
}
