using System.Runtime.CompilerServices;

public sealed class Pe64OptionalHeader : IPeOptionalHeader
{
	[CompilerGenerated]
	internal ushort ushort_0;

	[CompilerGenerated]
	internal byte byte_0;

	[CompilerGenerated]
	internal byte byte_1;

	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	[CompilerGenerated]
	internal uint uint_2;

	[CompilerGenerated]
	internal uint uint_3;

	[CompilerGenerated]
	internal uint uint_4;

	[CompilerGenerated]
	internal uint uint_5;

	[CompilerGenerated]
	internal ulong ulong_0;

	[CompilerGenerated]
	internal uint uint_6;

	[CompilerGenerated]
	internal uint uint_7;

	[CompilerGenerated]
	internal ushort ushort_1;

	[CompilerGenerated]
	internal ushort ushort_2;

	[CompilerGenerated]
	internal ushort ushort_3;

	[CompilerGenerated]
	internal ushort ushort_4;

	[CompilerGenerated]
	internal ushort ushort_5;

	[CompilerGenerated]
	internal ushort ushort_6;

	[CompilerGenerated]
	internal uint uint_8;

	[CompilerGenerated]
	internal uint uint_9;

	[CompilerGenerated]
	internal uint uint_10;

	[CompilerGenerated]
	internal uint uint_11;

	[CompilerGenerated]
	internal Subsystem enum42_0;

	[CompilerGenerated]
	internal DllCharacteristics enum38_0;

	[CompilerGenerated]
	internal ulong ulong_1;

	[CompilerGenerated]
	internal ulong ulong_2;

	[CompilerGenerated]
	internal ulong ulong_3;

	[CompilerGenerated]
	internal ulong ulong_4;

	[CompilerGenerated]
	internal uint uint_12;

	[CompilerGenerated]
	internal uint uint_13;

	[CompilerGenerated]
	internal DataDirectory[] class157_0;

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMagic()
	{
		return ushort_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMagic(ushort ushort_7)
	{
		ushort_0 = ushort_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public byte GetMajorLinkerVersion()
	{
		return byte_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorLinkerVersion(byte byte_2)
	{
		byte_0 = byte_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public byte GetMinorLinkerVersion()
	{
		return byte_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorLinkerVersion(byte byte_2)
	{
		byte_1 = byte_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfCode()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfCode(uint uint_14)
	{
		uint_0 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfInitializedData()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfInitializedData(uint uint_14)
	{
		uint_1 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfUninitializedData()
	{
		return uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfUninitializedData(uint uint_14)
	{
		uint_2 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetAddressOfEntryPoint()
	{
		return uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfEntryPoint(uint uint_14)
	{
		uint_3 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetBaseOfCode()
	{
		return uint_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetBaseOfCode(uint uint_14)
	{
		uint_4 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetBaseOfData()
	{
		return uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetBaseOfData(uint uint_14)
	{
		uint_5 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetImageBase()
	{
		return ulong_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetImageBase(ulong ulong_5)
	{
		ulong_0 = ulong_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSectionAlignment()
	{
		return uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSectionAlignment(uint uint_14)
	{
		uint_6 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetFileAlignment()
	{
		return uint_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetFileAlignment(uint uint_14)
	{
		uint_7 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMajorOperatingSystemVersion()
	{
		return ushort_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorOperatingSystemVersion(ushort ushort_7)
	{
		ushort_1 = ushort_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMinorOperatingSystemVersion()
	{
		return ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorOperatingSystemVersion(ushort ushort_7)
	{
		ushort_2 = ushort_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMajorImageVersion()
	{
		return ushort_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorImageVersion(ushort ushort_7)
	{
		ushort_3 = ushort_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMinorImageVersion()
	{
		return ushort_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorImageVersion(ushort ushort_7)
	{
		ushort_4 = ushort_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMajorSubsystemVersion()
	{
		return ushort_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorSubsystemVersion(ushort ushort_7)
	{
		ushort_5 = ushort_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetMinorSubsystemVersion()
	{
		return ushort_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorSubsystemVersion(ushort ushort_7)
	{
		ushort_6 = ushort_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetWin32VersionValue()
	{
		return uint_8;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetWin32VersionValue(uint uint_14)
	{
		uint_8 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfImage()
	{
		return uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfImage(uint uint_14)
	{
		uint_9 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfHeaders()
	{
		return uint_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfHeaders(uint uint_14)
	{
		uint_10 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetChecksum()
	{
		return uint_11;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetChecksum(uint uint_14)
	{
		uint_11 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public Subsystem GetSubsystem()
	{
		return enum42_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSubsystem(Subsystem enum42_1)
	{
		enum42_0 = enum42_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public DllCharacteristics GetDllCharacteristics()
	{
		return enum38_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDllCharacteristics(DllCharacteristics enum38_1)
	{
		enum38_0 = enum38_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetSizeOfStackReserve()
	{
		return ulong_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfStackReserve(ulong ulong_5)
	{
		ulong_1 = ulong_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetSizeOfStackCommit()
	{
		return ulong_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfStackCommit(ulong ulong_5)
	{
		ulong_2 = ulong_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetSizeOfHeapReserve()
	{
		return ulong_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfHeapReserve(ulong ulong_5)
	{
		ulong_3 = ulong_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetSizeOfHeapCommit()
	{
		return ulong_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfHeapCommit(ulong ulong_5)
	{
		ulong_4 = ulong_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetLoaderFlags()
	{
		return uint_12;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetLoaderFlags(uint uint_14)
	{
		uint_12 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetNumberOfRvaAndSizes()
	{
		return uint_13;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfRvaAndSizes(uint uint_14)
	{
		uint_13 = uint_14;
	}

	[SpecialName]
	[CompilerGenerated]
	public DataDirectory[] GetDataDirectories()
	{
		return class157_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDataDirectories(DataDirectory[] class157_1)
	{
		class157_0 = class157_1;
	}

	public Pe64OptionalHeader()
	{
		SetDataDirectories(new DataDirectory[16]);
	}
}
