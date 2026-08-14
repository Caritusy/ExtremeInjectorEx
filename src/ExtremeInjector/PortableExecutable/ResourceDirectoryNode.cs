using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class ResourceDirectoryNode : ResourceIdentifier
{
	internal long longValue;

	internal ResourceDirectory resourceDirectory;

	[CompilerGenerated]
	internal List<ResourceDataEntry> dataEntries;

	[CompilerGenerated]
	internal List<ResourceDirectoryNode> subdirectories;

	[CompilerGenerated]
	internal uint characteristics;

	[CompilerGenerated]
	internal uint timeDateStamp;

	[CompilerGenerated]
	internal ushort majorVersion;

	[CompilerGenerated]
	internal ushort minorVersion;

	[SpecialName]
	[CompilerGenerated]
	public List<ResourceDataEntry> GetDataEntries()
	{
		return dataEntries;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetDataEntries(List<ResourceDataEntry> items)
	{
		dataEntries = items;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<ResourceDirectoryNode> GetSubdirectories()
	{
		return subdirectories;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetSubdirectories(List<ResourceDirectoryNode> items)
	{
		subdirectories = items;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCharacteristics(uint uintValue)
	{
		characteristics = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetTimeDateStamp(uint uintValue)
	{
		timeDateStamp = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorVersion(ushort ushortValue)
	{
		majorVersion = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorVersion(ushort ushortValue)
	{
		minorVersion = ushortValue;
	}

	public ResourceDirectoryNode(int intValue, ResourceDirectory resourceDirectory2, long longValue2)
		: base(intValue)
	{
		RecoveredRuntime.InitializeResourceDirectoryNode(longValue2, resourceDirectory2, this);
	}

	public ResourceDirectoryNode(string text, ResourceDirectory resourceDirectory2, long longValue2)
		: base(text)
	{
		RecoveredRuntime.InitializeResourceDirectoryNode(longValue2, resourceDirectory2, this);
	}
}
