using System.Runtime.CompilerServices;

public interface IPeOptionalHeader
{
	[SpecialName]
	ushort GetMagic();

	[SpecialName]
	byte GetMajorLinkerVersion();

	[SpecialName]
	void SetMajorLinkerVersion(byte byteValue);

	[SpecialName]
	byte GetMinorLinkerVersion();

	[SpecialName]
	void SetMinorLinkerVersion(byte byteValue);

	[SpecialName]
	uint GetSizeOfCode();

	[SpecialName]
	void SetSizeOfCode(uint uintValue);

	[SpecialName]
	uint GetSizeOfInitializedData();

	[SpecialName]
	void SetSizeOfInitializedData(uint uintValue);

	[SpecialName]
	uint GetSizeOfUninitializedData();

	[SpecialName]
	void SetSizeOfUninitializedData(uint uintValue);

	[SpecialName]
	uint GetAddressOfEntryPoint();

	[SpecialName]
	void SetAddressOfEntryPoint(uint uintValue);

	[SpecialName]
	uint GetBaseOfCode();

	[SpecialName]
	void SetBaseOfCode(uint uintValue);

	[SpecialName]
	uint GetBaseOfData();

	[SpecialName]
	void SetBaseOfData(uint uintValue);

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
	void SetMajorImageVersion(ushort ushortValue);

	[SpecialName]
	ushort GetMinorImageVersion();

	[SpecialName]
	void SetMinorImageVersion(ushort ushortValue);

	[SpecialName]
	ushort GetMajorSubsystemVersion();

	[SpecialName]
	ushort GetMinorSubsystemVersion();

	[SpecialName]
	uint GetWin32VersionValue();

	[SpecialName]
	uint GetSizeOfImage();

	[SpecialName]
	void SetSizeOfImage(uint uintValue);

	[SpecialName]
	uint GetSizeOfHeaders();

	[SpecialName]
	uint GetChecksum();

	[SpecialName]
	void SetChecksum(uint uintValue);

	[SpecialName]
	Subsystem GetSubsystem();

	[SpecialName]
	DllCharacteristics GetDllCharacteristics();

	[SpecialName]
	void SetDllCharacteristics(DllCharacteristics dllCharacteristics);

	[SpecialName]
	ulong GetSizeOfStackReserve();

	[SpecialName]
	void SetSizeOfStackReserve(ulong ulongValue);

	[SpecialName]
	ulong GetSizeOfStackCommit();

	[SpecialName]
	void SetSizeOfStackCommit(ulong ulongValue);

	[SpecialName]
	ulong GetSizeOfHeapReserve();

	[SpecialName]
	void SetSizeOfHeapReserve(ulong ulongValue);

	[SpecialName]
	ulong GetSizeOfHeapCommit();

	[SpecialName]
	void SetSizeOfHeapCommit(ulong ulongValue);

	[SpecialName]
	uint GetLoaderFlags();

	[SpecialName]
	void SetLoaderFlags(uint uintValue);

	[SpecialName]
	uint GetNumberOfRvaAndSizes();

	[SpecialName]
	void SetNumberOfRvaAndSizes(uint uintValue);

	[SpecialName]
	DataDirectory[] GetDataDirectories();
}
