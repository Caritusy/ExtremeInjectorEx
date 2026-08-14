using System.IO;
using System.Runtime.CompilerServices;

public sealed class LoadConfigurationDirectory
{
	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	[CompilerGenerated]
	internal ushort ushort_0;

	[CompilerGenerated]
	internal ushort ushort_1;

	[CompilerGenerated]
	internal uint uint_2;

	[CompilerGenerated]
	internal uint uint_3;

	[CompilerGenerated]
	internal uint uint_4;

	[CompilerGenerated]
	internal ulong ulong_0;

	[CompilerGenerated]
	internal ulong ulong_1;

	[CompilerGenerated]
	internal ulong ulong_2;

	[CompilerGenerated]
	internal ulong ulong_3;

	[CompilerGenerated]
	internal ulong ulong_4;

	[CompilerGenerated]
	internal ulong ulong_5;

	[CompilerGenerated]
	internal uint uint_5;

	[CompilerGenerated]
	internal ushort ushort_2;

	[CompilerGenerated]
	internal ushort ushort_3;

	[CompilerGenerated]
	internal ulong ulong_6;

	[CompilerGenerated]
	internal ulong ulong_7;

	[CompilerGenerated]
	internal ulong ulong_8;

	[CompilerGenerated]
	internal ulong ulong_9;

	[SpecialName]
	[CompilerGenerated]
	public void SetSize(uint uint_6)
	{
		uint_0 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetTimeDateStamp(uint uint_6)
	{
		uint_1 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorVersion(ushort ushort_4)
	{
		ushort_0 = ushort_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorVersion(ushort ushort_4)
	{
		ushort_1 = ushort_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetGlobalFlagsClear(uint uint_6)
	{
		uint_2 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetGlobalFlagsSet(uint uint_6)
	{
		uint_3 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCriticalSectionDefaultTimeout(uint uint_6)
	{
		uint_4 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDeCommitFreeBlockThreshold(ulong ulong_10)
	{
		ulong_0 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDeCommitTotalFreeThreshold(ulong ulong_10)
	{
		ulong_1 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetLockPrefixTable(ulong ulong_10)
	{
		ulong_2 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMaximumAllocationSize(ulong ulong_10)
	{
		ulong_3 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetVirtualMemoryThreshold(ulong ulong_10)
	{
		ulong_4 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetProcessAffinityMask(ulong ulong_10)
	{
		ulong_5 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetProcessHeapFlags(uint uint_6)
	{
		uint_5 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCsdVersion(ushort ushort_4)
	{
		ushort_2 = ushort_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDependentLoadFlags(ushort ushort_4)
	{
		ushort_3 = ushort_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetEditList(ulong ulong_10)
	{
		ulong_6 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSecurityCookie(ulong ulong_10)
	{
		ulong_7 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSeHandlerTable(ulong ulong_10)
	{
		ulong_8 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSeHandlerCount(ulong ulong_10)
	{
		ulong_9 = ulong_10;
	}

	internal LoadConfigurationDirectory(BoundsCheckedBinaryReader class5_0, PeImage class154_0)
	{
		SetSize(class5_0.ReadUInt32());
		SetTimeDateStamp(class5_0.ReadUInt32());
		SetMajorVersion(class5_0.ReadUInt16());
		SetMinorVersion(class5_0.ReadUInt16());
		SetGlobalFlagsClear(class5_0.ReadUInt32());
		SetGlobalFlagsSet(class5_0.ReadUInt32());
		SetCriticalSectionDefaultTimeout(class5_0.ReadUInt32());
		if (RecoveredRuntime.Is32BitImage(class154_0))
		{
			SetDeCommitFreeBlockThreshold(class5_0.ReadUInt32());
			SetDeCommitTotalFreeThreshold(class5_0.ReadUInt32());
			SetLockPrefixTable(class5_0.ReadUInt32());
			SetMaximumAllocationSize(class5_0.ReadUInt32());
			SetVirtualMemoryThreshold(class5_0.ReadUInt32());
			SetProcessHeapFlags(class5_0.ReadUInt32());
			SetProcessAffinityMask(class5_0.ReadUInt32());
		}
		else
		{
			SetDeCommitFreeBlockThreshold(class5_0.ReadUInt64());
			SetDeCommitTotalFreeThreshold(class5_0.ReadUInt64());
			SetLockPrefixTable(class5_0.ReadUInt64());
			SetMaximumAllocationSize(class5_0.ReadUInt64());
			SetVirtualMemoryThreshold(class5_0.ReadUInt64());
			SetProcessAffinityMask(class5_0.ReadUInt64());
			SetProcessHeapFlags(class5_0.ReadUInt32());
		}
		SetCsdVersion(class5_0.ReadUInt16());
		SetDependentLoadFlags(class5_0.ReadUInt16());
		if (RecoveredRuntime.Is32BitImage(class154_0))
		{
			SetEditList(class5_0.ReadUInt32());
			SetSecurityCookie(class5_0.ReadUInt32());
			SetSeHandlerTable(class5_0.ReadUInt32());
			SetSeHandlerCount(class5_0.ReadUInt32());
		}
		else
		{
			SetEditList(class5_0.ReadUInt64());
			SetSecurityCookie(class5_0.ReadUInt64());
			SetSeHandlerTable(class5_0.ReadUInt64());
			SetSeHandlerCount(class5_0.ReadUInt64());
		}
	}
}
