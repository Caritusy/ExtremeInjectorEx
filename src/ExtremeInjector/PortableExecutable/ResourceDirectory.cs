using System.Runtime.CompilerServices;

public sealed class ResourceDirectory
{
	internal long longValue;

	internal uint uintValue;

	internal BoundsCheckedBinaryReader boundsCheckedBinaryReader;

	[CompilerGenerated]
	internal ResourceDirectoryNode root;

	[SpecialName]
	[CompilerGenerated]
	public ResourceDirectoryNode GetRoot()
	{
		return root;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetRoot(ResourceDirectoryNode resourceDirectoryNode)
	{
		root = resourceDirectoryNode;
	}

	internal ResourceDirectory(BoundsCheckedBinaryReader boundsCheckedBinaryReader2, long longValue2, uint uintValue2)
	{
		boundsCheckedBinaryReader = boundsCheckedBinaryReader2;
		longValue = longValue2;
		uintValue = uintValue2;
		SetRoot(new ResourceDirectoryNode("root", this, (longValue <= 0L) ? (-1) : 0));
	}
}
