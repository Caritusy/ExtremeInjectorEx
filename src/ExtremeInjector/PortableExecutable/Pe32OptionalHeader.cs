using System.Runtime.CompilerServices;

public sealed class Pe32OptionalHeader : IPeOptionalHeader
{
	[CompilerGenerated]
	internal ushort magic;

	[CompilerGenerated]
	internal byte majorLinkerVersion;

	[CompilerGenerated]
	internal byte minorLinkerVersion;

	[CompilerGenerated]
	internal uint sizeOfCode;

	[CompilerGenerated]
	internal uint sizeOfInitializedData;

	[CompilerGenerated]
	internal uint sizeOfUninitializedData;

	[CompilerGenerated]
	internal uint addressOfEntryPoint;

	[CompilerGenerated]
	internal uint baseOfCode;

	[CompilerGenerated]
	internal uint baseOfData;

	[CompilerGenerated]
	internal ulong imageBase;

	[CompilerGenerated]
	internal uint sectionAlignment;

	[CompilerGenerated]
	internal uint fileAlignment;

	[CompilerGenerated]
	internal ushort majorOperatingSystemVersion;

	[CompilerGenerated]
	internal ushort minorOperatingSystemVersion;

	[CompilerGenerated]
	internal ushort majorImageVersion;

	[CompilerGenerated]
	internal ushort minorImageVersion;

	[CompilerGenerated]
	internal ushort majorSubsystemVersion;

	[CompilerGenerated]
	internal ushort minorSubsystemVersion;

	[CompilerGenerated]
	internal uint win32VersionValue;

	[CompilerGenerated]
	internal uint sizeOfImage;

	[CompilerGenerated]
	internal uint sizeOfHeaders;

	[CompilerGenerated]
	internal uint checksum;

	[CompilerGenerated]
	internal Subsystem subsystem;

	[CompilerGenerated]
	internal DllCharacteristics dllCharacteristics;

	[CompilerGenerated]
	internal ulong sizeOfStackReserve;

	[CompilerGenerated]
	internal ulong sizeOfStackCommit;

	[CompilerGenerated]
	internal ulong sizeOfHeapReserve;

	[CompilerGenerated]
	internal ulong sizeOfHeapCommit;

	[CompilerGenerated]
	internal uint loaderFlags;

	[CompilerGenerated]
	internal uint numberOfRvaAndSizes;

	[CompilerGenerated]
	internal DataDirectory[] dataDirectories;

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMagic()
	{
		return magic;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMagic(ushort ushortValue)
	{
		magic = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public byte GetMajorLinkerVersion()
	{
		return majorLinkerVersion;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorLinkerVersion(byte byteValue)
	{
		majorLinkerVersion = byteValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public byte GetMinorLinkerVersion()
	{
		return minorLinkerVersion;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorLinkerVersion(byte byteValue)
	{
		minorLinkerVersion = byteValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfCode()
	{
		return sizeOfCode;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfCode(uint uintValue)
	{
		sizeOfCode = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfInitializedData()
	{
		return sizeOfInitializedData;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfInitializedData(uint uintValue)
	{
		sizeOfInitializedData = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfUninitializedData()
	{
		return sizeOfUninitializedData;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfUninitializedData(uint uintValue)
	{
		sizeOfUninitializedData = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetAddressOfEntryPoint()
	{
		return addressOfEntryPoint;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfEntryPoint(uint uintValue)
	{
		addressOfEntryPoint = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetBaseOfCode()
	{
		return baseOfCode;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetBaseOfCode(uint uintValue)
	{
		baseOfCode = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetBaseOfData()
	{
		return baseOfData;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetBaseOfData(uint uintValue)
	{
		baseOfData = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetImageBase()
	{
		return imageBase;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetImageBase(ulong ulongValue)
	{
		imageBase = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSectionAlignment()
	{
		return sectionAlignment;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSectionAlignment(uint uintValue)
	{
		sectionAlignment = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetFileAlignment()
	{
		return fileAlignment;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetFileAlignment(uint uintValue)
	{
		fileAlignment = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMajorOperatingSystemVersion()
	{
		return majorOperatingSystemVersion;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorOperatingSystemVersion(ushort ushortValue)
	{
		majorOperatingSystemVersion = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMinorOperatingSystemVersion()
	{
		return minorOperatingSystemVersion;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorOperatingSystemVersion(ushort ushortValue)
	{
		minorOperatingSystemVersion = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMajorImageVersion()
	{
		return majorImageVersion;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorImageVersion(ushort ushortValue)
	{
		majorImageVersion = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMinorImageVersion()
	{
		return minorImageVersion;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorImageVersion(ushort ushortValue)
	{
		minorImageVersion = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMajorSubsystemVersion()
	{
		return majorSubsystemVersion;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorSubsystemVersion(ushort ushortValue)
	{
		majorSubsystemVersion = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMinorSubsystemVersion()
	{
		return minorSubsystemVersion;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorSubsystemVersion(ushort ushortValue)
	{
		minorSubsystemVersion = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetWin32VersionValue()
	{
		return win32VersionValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetWin32VersionValue(uint uintValue)
	{
		win32VersionValue = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfImage()
	{
		return sizeOfImage;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfImage(uint uintValue)
	{
		sizeOfImage = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfHeaders()
	{
		return sizeOfHeaders;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfHeaders(uint uintValue)
	{
		sizeOfHeaders = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetChecksum()
	{
		return checksum;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetChecksum(uint uintValue)
	{
		checksum = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public Subsystem GetSubsystem()
	{
		return subsystem;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSubsystem(Subsystem subsystem2)
	{
		subsystem = subsystem2;
	}

	[SpecialName]
	[CompilerGenerated]
	public DllCharacteristics GetDllCharacteristics()
	{
		return dllCharacteristics;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDllCharacteristics(DllCharacteristics dllCharacteristics2)
	{
		dllCharacteristics = dllCharacteristics2;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetSizeOfStackReserve()
	{
		return sizeOfStackReserve;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfStackReserve(ulong ulongValue)
	{
		sizeOfStackReserve = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetSizeOfStackCommit()
	{
		return sizeOfStackCommit;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfStackCommit(ulong ulongValue)
	{
		sizeOfStackCommit = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetSizeOfHeapReserve()
	{
		return sizeOfHeapReserve;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfHeapReserve(ulong ulongValue)
	{
		sizeOfHeapReserve = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetSizeOfHeapCommit()
	{
		return sizeOfHeapCommit;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfHeapCommit(ulong ulongValue)
	{
		sizeOfHeapCommit = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetLoaderFlags()
	{
		return loaderFlags;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetLoaderFlags(uint uintValue)
	{
		loaderFlags = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetNumberOfRvaAndSizes()
	{
		return numberOfRvaAndSizes;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfRvaAndSizes(uint uintValue)
	{
		numberOfRvaAndSizes = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public DataDirectory[] GetDataDirectories()
	{
		return dataDirectories;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDataDirectories(DataDirectory[] dataDirectoryArray)
	{
		dataDirectories = dataDirectoryArray;
	}

	public Pe32OptionalHeader()
	{
		SetDataDirectories(new DataDirectory[16]);
	}
}
