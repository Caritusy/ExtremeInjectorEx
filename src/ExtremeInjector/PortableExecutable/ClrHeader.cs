using System.IO;
using System.Runtime.CompilerServices;

public sealed class ClrHeader
{
	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal ushort ushort_0;

	[CompilerGenerated]
	internal ushort ushort_1;

	[CompilerGenerated]
	internal DataDirectory class157_0;

	[CompilerGenerated]
	internal CorFlags enum35_0;

	[CompilerGenerated]
	internal uint uint_1;

	[CompilerGenerated]
	internal DataDirectory class157_1;

	[CompilerGenerated]
	internal DataDirectory class157_2;

	[CompilerGenerated]
	internal DataDirectory class157_3;

	[CompilerGenerated]
	internal DataDirectory class157_4;

	[CompilerGenerated]
	internal DataDirectory class157_5;

	[CompilerGenerated]
	internal DataDirectory class157_6;

	[SpecialName]
	[CompilerGenerated]
	public uint GetHeaderSize()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetHeaderSize(uint uint_2)
	{
		uint_0 = uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorRuntimeVersion(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorRuntimeVersion(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMetadataDirectory(DataDirectory class157_7)
	{
		class157_0 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetFlags(CorFlags enum35_1)
	{
		enum35_0 = enum35_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetEntryPointToken(uint uint_2)
	{
		uint_1 = uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetResourcesDirectory(DataDirectory class157_7)
	{
		class157_1 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetStrongNameSignatureDirectory(DataDirectory class157_7)
	{
		class157_2 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCodeManagerTableDirectory(DataDirectory class157_7)
	{
		class157_3 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetVTableFixupsDirectory(DataDirectory class157_7)
	{
		class157_4 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetExportAddressTableJumpsDirectory(DataDirectory class157_7)
	{
		class157_5 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetManagedNativeHeaderDirectory(DataDirectory class157_7)
	{
		class157_6 = class157_7;
	}

	public ClrHeader()
	{
	}

	internal ClrHeader(BoundsCheckedBinaryReader class5_0)
	{
		this.SetHeaderSize(class5_0.ReadUInt32());
		this.SetMajorRuntimeVersion(class5_0.ReadUInt16());
		this.SetMinorRuntimeVersion(class5_0.ReadUInt16());
		this.SetMetadataDirectory(new DataDirectory(class5_0));
		this.SetFlags((CorFlags)class5_0.ReadUInt32());
		this.SetEntryPointToken(class5_0.ReadUInt32());
		this.SetResourcesDirectory(new DataDirectory(class5_0));
		this.SetStrongNameSignatureDirectory(new DataDirectory(class5_0));
		this.SetCodeManagerTableDirectory(new DataDirectory(class5_0));
		this.SetVTableFixupsDirectory(new DataDirectory(class5_0));
		this.SetExportAddressTableJumpsDirectory(new DataDirectory(class5_0));
		this.SetManagedNativeHeaderDirectory(new DataDirectory(class5_0));
	}
}
