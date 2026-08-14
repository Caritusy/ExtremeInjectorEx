using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class ResourceDirectoryNode : ResourceIdentifier
{
	internal long long_0;

	internal ResourceDirectory class166_0;

	[CompilerGenerated]
	internal List<ResourceDataEntry> list_0;

	[CompilerGenerated]
	internal List<ResourceDirectoryNode> list_1;

	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	[CompilerGenerated]
	internal ushort ushort_0;

	[CompilerGenerated]
	internal ushort ushort_1;

	[SpecialName]
	[CompilerGenerated]
	public List<ResourceDataEntry> method_4()
	{
		return list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_5(List<ResourceDataEntry> list_2)
	{
		list_0 = list_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<ResourceDirectoryNode> method_6()
	{
		return list_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_7(List<ResourceDirectoryNode> list_2)
	{
		list_1 = list_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_8(uint uint_2)
	{
		uint_0 = uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_9(uint uint_2)
	{
		uint_1 = uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_10(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_11(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	public ResourceDirectoryNode(int int_1, ResourceDirectory class166_1, long long_1)
		: base(int_1)
	{
		RecoveredRuntime.smethod_101(long_1, class166_1, this);
	}

	public ResourceDirectoryNode(string string_1, ResourceDirectory class166_1, long long_1)
		: base(string_1)
	{
		RecoveredRuntime.smethod_101(long_1, class166_1, this);
	}
}
