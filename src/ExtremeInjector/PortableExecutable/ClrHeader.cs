using System.IO;
using System.Runtime.CompilerServices;

public sealed class ClrHeader
{
	[CompilerGenerated]
	internal uint headerSize;

	[CompilerGenerated]
	internal ushort majorRuntimeVersion;

	[CompilerGenerated]
	internal ushort minorRuntimeVersion;

	[CompilerGenerated]
	internal DataDirectory metadataDirectory;

	[CompilerGenerated]
	internal CorFlags flags;

	[CompilerGenerated]
	internal uint entryPointToken;

	[CompilerGenerated]
	internal DataDirectory resourcesDirectory;

	[CompilerGenerated]
	internal DataDirectory strongNameSignatureDirectory;

	[CompilerGenerated]
	internal DataDirectory codeManagerTableDirectory;

	[CompilerGenerated]
	internal DataDirectory vTableFixupsDirectory;

	[CompilerGenerated]
	internal DataDirectory exportAddressTableJumpsDirectory;

	[CompilerGenerated]
	internal DataDirectory managedNativeHeaderDirectory;

	[SpecialName]
	[CompilerGenerated]
	public uint GetHeaderSize()
	{
		return headerSize;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetHeaderSize(uint uintValue)
	{
		headerSize = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorRuntimeVersion(ushort ushortValue)
	{
		majorRuntimeVersion = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorRuntimeVersion(ushort ushortValue)
	{
		minorRuntimeVersion = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMetadataDirectory(DataDirectory dataDirectory)
	{
		metadataDirectory = dataDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetFlags(CorFlags corFlags)
	{
		flags = corFlags;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetEntryPointToken(uint uintValue)
	{
		entryPointToken = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetResourcesDirectory(DataDirectory dataDirectory)
	{
		resourcesDirectory = dataDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetStrongNameSignatureDirectory(DataDirectory dataDirectory)
	{
		strongNameSignatureDirectory = dataDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCodeManagerTableDirectory(DataDirectory dataDirectory)
	{
		codeManagerTableDirectory = dataDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetVTableFixupsDirectory(DataDirectory dataDirectory)
	{
		vTableFixupsDirectory = dataDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetExportAddressTableJumpsDirectory(DataDirectory dataDirectory)
	{
		exportAddressTableJumpsDirectory = dataDirectory;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetManagedNativeHeaderDirectory(DataDirectory dataDirectory)
	{
		managedNativeHeaderDirectory = dataDirectory;
	}

	public ClrHeader()
	{
	}

	internal ClrHeader(BoundsCheckedBinaryReader boundsCheckedBinaryReader)
	{
		this.SetHeaderSize(boundsCheckedBinaryReader.ReadUInt32());
		this.SetMajorRuntimeVersion(boundsCheckedBinaryReader.ReadUInt16());
		this.SetMinorRuntimeVersion(boundsCheckedBinaryReader.ReadUInt16());
		this.SetMetadataDirectory(new DataDirectory(boundsCheckedBinaryReader));
		this.SetFlags((CorFlags)boundsCheckedBinaryReader.ReadUInt32());
		this.SetEntryPointToken(boundsCheckedBinaryReader.ReadUInt32());
		this.SetResourcesDirectory(new DataDirectory(boundsCheckedBinaryReader));
		this.SetStrongNameSignatureDirectory(new DataDirectory(boundsCheckedBinaryReader));
		this.SetCodeManagerTableDirectory(new DataDirectory(boundsCheckedBinaryReader));
		this.SetVTableFixupsDirectory(new DataDirectory(boundsCheckedBinaryReader));
		this.SetExportAddressTableJumpsDirectory(new DataDirectory(boundsCheckedBinaryReader));
		this.SetManagedNativeHeaderDirectory(new DataDirectory(boundsCheckedBinaryReader));
	}
}
