using System.Runtime.CompilerServices;

public sealed class ResourceDirectory
{
	internal long long_0;

	internal uint uint_0;

	internal BoundsCheckedBinaryReader class5_0;

	[CompilerGenerated]
	internal ResourceDirectoryNode class138_0;

	[SpecialName]
	[CompilerGenerated]
	public ResourceDirectoryNode method_0()
	{
		return class138_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(ResourceDirectoryNode class138_1)
	{
		class138_0 = class138_1;
	}

	internal ResourceDirectory(BoundsCheckedBinaryReader class5_1, long long_1, uint uint_1)
	{
		class5_0 = class5_1;
		long_0 = long_1;
		uint_0 = uint_1;
		method_1(new ResourceDirectoryNode("root", this, (long_0 <= 0L) ? (-1) : 0));
	}
}
