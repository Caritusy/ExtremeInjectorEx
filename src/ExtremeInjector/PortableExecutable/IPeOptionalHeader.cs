using System.Runtime.CompilerServices;

public interface IPeOptionalHeader
{
	[SpecialName]
	ushort GetMagic();

	[SpecialName]
	byte GetMajorLinkerVersion();

	[SpecialName]
	void SetMajorLinkerVersion(byte byte_0);

	[SpecialName]
	byte GetMinorLinkerVersion();

	[SpecialName]
	void SetMinorLinkerVersion(byte byte_0);

	[SpecialName]
	uint GetSizeOfCode();

	[SpecialName]
	void SetSizeOfCode(uint uint_0);

	[SpecialName]
	uint GetSizeOfInitializedData();

	[SpecialName]
	void SetSizeOfInitializedData(uint uint_0);

	[SpecialName]
	uint GetSizeOfUninitializedData();

	[SpecialName]
	void SetSizeOfUninitializedData(uint uint_0);

	[SpecialName]
	uint GetAddressOfEntryPoint();

	[SpecialName]
	void SetAddressOfEntryPoint(uint uint_0);

	[SpecialName]
	uint GetBaseOfCode();

	[SpecialName]
	void SetBaseOfCode(uint uint_0);

	[SpecialName]
	uint GetBaseOfData();

	[SpecialName]
	void SetBaseOfData(uint uint_0);

	[SpecialName]
	ulong GetImageBase();

	[SpecialName]
	uint GetSectionAlignment();

	[SpecialName]
	uint GetFileAlignment();

	[SpecialName]
	ushort GetMajorOperatingSystemVersion();

	[SpecialName]
	ushort GetMinorOperatingSystemVersion();

	[SpecialName]
	ushort GetMajorImageVersion();

	[SpecialName]
	void SetMajorImageVersion(ushort ushort_0);

	[SpecialName]
	ushort GetMinorImageVersion();

	[SpecialName]
	void SetMinorImageVersion(ushort ushort_0);

	[SpecialName]
	ushort GetMajorSubsystemVersion();

	[SpecialName]
	ushort GetMinorSubsystemVersion();

	[SpecialName]
	uint GetWin32VersionValue();

	[SpecialName]
	uint GetSizeOfImage();

	[SpecialName]
	void SetSizeOfImage(uint uint_0);

	[SpecialName]
	uint GetSizeOfHeaders();

	[SpecialName]
	uint GetChecksum();

	[SpecialName]
	void SetChecksum(uint uint_0);

	[SpecialName]
	Subsystem GetSubsystem();

	[SpecialName]
	DllCharacteristics GetDllCharacteristics();

	[SpecialName]
	void SetDllCharacteristics(DllCharacteristics enum38_0);

	[SpecialName]
	ulong GetSizeOfStackReserve();

	[SpecialName]
	void SetSizeOfStackReserve(ulong ulong_0);

	[SpecialName]
	ulong GetSizeOfStackCommit();

	[SpecialName]
	void SetSizeOfStackCommit(ulong ulong_0);

	[SpecialName]
	ulong GetSizeOfHeapReserve();

	[SpecialName]
	void SetSizeOfHeapReserve(ulong ulong_0);

	[SpecialName]
	ulong GetSizeOfHeapCommit();

	[SpecialName]
	void SetSizeOfHeapCommit(ulong ulong_0);

	[SpecialName]
	uint GetLoaderFlags();

	[SpecialName]
	void SetLoaderFlags(uint uint_0);

	[SpecialName]
	uint GetNumberOfRvaAndSizes();

	[SpecialName]
	void SetNumberOfRvaAndSizes(uint uint_0);

	[SpecialName]
	DataDirectory[] GetDataDirectories();
}
