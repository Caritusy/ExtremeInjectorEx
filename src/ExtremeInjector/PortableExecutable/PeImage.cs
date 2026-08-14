using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class PeImage : IDisposable
{
	public interface Interface3
	{
		long MapRvaToFileOffset(PeImage class154_0, uint uint_0);
	}

	public sealed class Class155 : Interface3
	{
		public long MapRvaToFileOffset(PeImage class154_0, uint uint_0)
		{
			foreach (PeSectionHeader gclass in class154_0.GetSections())
			{
				if (uint_0 >= gclass.GetVirtualAddress() && uint_0 < gclass.GetVirtualAddress() + gclass.GetSizeOfRawData())
				{
					return (long)((ulong)(uint_0 - gclass.GetVirtualAddress() + gclass.GetPointerToRawData()));
				}
			}
			return -1L;
		}
	}

	public sealed class Class156 : Interface3
	{
		public long MapRvaToFileOffset(PeImage class154_0, uint uint_0)
		{
			return uint_0;
		}
	}

	[CompilerGenerated]
	internal string string_0;

	[CompilerGenerated]
	internal string string_1;

	[CompilerGenerated]
	internal DosHeader class158_0;

	[CompilerGenerated]
	internal PeHeaders class161_0;

	[CompilerGenerated]
	internal List<PeSectionHeader> list_0;

	[CompilerGenerated]
	internal ImportDirectory class148_0;

	[CompilerGenerated]
	internal DelayImportDirectory class149_0;

	[CompilerGenerated]
	internal ExportDirectory class151_0;

	[CompilerGenerated]
	internal BaseRelocationDirectory class146_0;

	[CompilerGenerated]
	internal DebugDirectoryEntry class147_0;

	[CompilerGenerated]
	internal TlsDirectory class167_0;

	[CompilerGenerated]
	internal LoadConfigurationDirectory class143_0;

	[CompilerGenerated]
	internal ResourceDirectory class166_0;

	[CompilerGenerated]
	internal ExceptionDirectory class141_0;

	[CompilerGenerated]
	internal ClrHeader class142_0;

	[CompilerGenerated]
	internal Stream stream_0;

	[CompilerGenerated]
	internal PeImageLayout enum39_0;

	internal readonly bool bool_0;

	internal readonly Interface3 interface3_0;

	[SpecialName]
	[CompilerGenerated]
	public string GetFilePath()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetFilePath(string string_2)
	{
		string_0 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string GetFileName()
	{
		return string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetFileName(string string_2)
	{
		string_1 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public DosHeader GetDosHeader()
	{
		return class158_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDosHeader(DosHeader class158_1)
	{
		class158_0 = class158_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public PeHeaders GetHeaders()
	{
		return class161_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetHeaders(PeHeaders class161_1)
	{
		class161_0 = class161_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<PeSectionHeader> GetSections()
	{
		return list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSections(List<PeSectionHeader> list_1)
	{
		list_0 = list_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ImportDirectory GetImports()
	{
		return class148_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetImports(ImportDirectory class148_1)
	{
		class148_0 = class148_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public DelayImportDirectory GetDelayImports()
	{
		return class149_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDelayImports(DelayImportDirectory class149_1)
	{
		class149_0 = class149_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ExportDirectory GetExports()
	{
		return class151_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetExports(ExportDirectory class151_1)
	{
		class151_0 = class151_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public BaseRelocationDirectory GetBaseRelocations()
	{
		return class146_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetBaseRelocations(BaseRelocationDirectory class146_1)
	{
		class146_0 = class146_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public DebugDirectoryEntry GetDebugDirectory()
	{
		return class147_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDebugDirectory(DebugDirectoryEntry class147_1)
	{
		class147_0 = class147_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public TlsDirectory GetTlsDirectory()
	{
		return class167_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetTlsDirectory(TlsDirectory class167_1)
	{
		class167_0 = class167_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetLoadConfigurationDirectory(LoadConfigurationDirectory class143_1)
	{
		class143_0 = class143_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ResourceDirectory GetResources()
	{
		return class166_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetResources(ResourceDirectory class166_1)
	{
		class166_0 = class166_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ExceptionDirectory GetExceptionDirectory()
	{
		return class141_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetExceptionDirectory(ExceptionDirectory class141_1)
	{
		class141_0 = class141_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetClrHeader(ClrHeader class142_1)
	{
		class142_0 = class142_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Stream GetStream()
	{
		return stream_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetStream(Stream stream_1)
	{
		stream_0 = stream_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetLayout(PeImageLayout enum39_1)
	{
		enum39_0 = enum39_1;
	}

	public PeImage(Stream stream_1, PeImageLayout enum39_1)
	{
		this.SetLayout(enum39_1);
		this.SetStream(stream_1);
		if (enum39_1 != PeImageLayout.const_0)
		{
			this.interface3_0 = new PeImage.Class156();
			return;
		}
		this.interface3_0 = new PeImage.Class155();
	}

	public PeImage(Stream stream_1, bool bool_1, PeImageLayout enum39_1)
		: this(stream_1, enum39_1)
	{
		bool_0 = bool_1;
	}

	public void Dispose()
	{
		if (this.bool_0 && this.GetStream() != null)
		{
			this.GetStream().Dispose();
			this.SetStream(null);
		}

		GC.SuppressFinalize(this);
	}
}
