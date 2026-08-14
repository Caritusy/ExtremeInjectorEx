using System.IO;
using System.Runtime.CompilerServices;

public sealed class LoadConfigurationDirectory
{
	[CompilerGenerated]
	internal uint size;

	[CompilerGenerated]
	internal uint timeDateStamp;

	[CompilerGenerated]
	internal ushort majorVersion;

	[CompilerGenerated]
	internal ushort minorVersion;

	[CompilerGenerated]
	internal uint globalFlagsClear;

	[CompilerGenerated]
	internal uint globalFlagsSet;

	[CompilerGenerated]
	internal uint criticalSectionDefaultTimeout;

	[CompilerGenerated]
	internal ulong deCommitFreeBlockThreshold;

	[CompilerGenerated]
	internal ulong deCommitTotalFreeThreshold;

	[CompilerGenerated]
	internal ulong lockPrefixTable;

	[CompilerGenerated]
	internal ulong maximumAllocationSize;

	[CompilerGenerated]
	internal ulong virtualMemoryThreshold;

	[CompilerGenerated]
	internal ulong processAffinityMask;

	[CompilerGenerated]
	internal uint processHeapFlags;

	[CompilerGenerated]
	internal ushort csdVersion;

	[CompilerGenerated]
	internal ushort dependentLoadFlags;

	[CompilerGenerated]
	internal ulong editList;

	[CompilerGenerated]
	internal ulong securityCookie;

	[CompilerGenerated]
	internal ulong seHandlerTable;

	[CompilerGenerated]
	internal ulong seHandlerCount;

	[SpecialName]
	[CompilerGenerated]
	public void SetSize(uint uintValue)
	{
		size = uintValue;
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

	[SpecialName]
	[CompilerGenerated]
	public void SetGlobalFlagsClear(uint uintValue)
	{
		globalFlagsClear = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetGlobalFlagsSet(uint uintValue)
	{
		globalFlagsSet = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCriticalSectionDefaultTimeout(uint uintValue)
	{
		criticalSectionDefaultTimeout = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDeCommitFreeBlockThreshold(ulong ulongValue)
	{
		deCommitFreeBlockThreshold = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDeCommitTotalFreeThreshold(ulong ulongValue)
	{
		deCommitTotalFreeThreshold = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetLockPrefixTable(ulong ulongValue)
	{
		lockPrefixTable = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMaximumAllocationSize(ulong ulongValue)
	{
		maximumAllocationSize = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetVirtualMemoryThreshold(ulong ulongValue)
	{
		virtualMemoryThreshold = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetProcessAffinityMask(ulong ulongValue)
	{
		processAffinityMask = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetProcessHeapFlags(uint uintValue)
	{
		processHeapFlags = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCsdVersion(ushort ushortValue)
	{
		csdVersion = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDependentLoadFlags(ushort ushortValue)
	{
		dependentLoadFlags = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetEditList(ulong ulongValue)
	{
		editList = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSecurityCookie(ulong ulongValue)
	{
		securityCookie = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSeHandlerTable(ulong ulongValue)
	{
		seHandlerTable = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSeHandlerCount(ulong ulongValue)
	{
		seHandlerCount = ulongValue;
	}

	internal LoadConfigurationDirectory(BoundsCheckedBinaryReader boundsCheckedBinaryReader, PeImage peImage)
	{
		SetSize(boundsCheckedBinaryReader.ReadUInt32());
		SetTimeDateStamp(boundsCheckedBinaryReader.ReadUInt32());
		SetMajorVersion(boundsCheckedBinaryReader.ReadUInt16());
		SetMinorVersion(boundsCheckedBinaryReader.ReadUInt16());
		SetGlobalFlagsClear(boundsCheckedBinaryReader.ReadUInt32());
		SetGlobalFlagsSet(boundsCheckedBinaryReader.ReadUInt32());
		SetCriticalSectionDefaultTimeout(boundsCheckedBinaryReader.ReadUInt32());
		if (RecoveredRuntime.Is32BitImage(peImage))
		{
			SetDeCommitFreeBlockThreshold(boundsCheckedBinaryReader.ReadUInt32());
			SetDeCommitTotalFreeThreshold(boundsCheckedBinaryReader.ReadUInt32());
			SetLockPrefixTable(boundsCheckedBinaryReader.ReadUInt32());
			SetMaximumAllocationSize(boundsCheckedBinaryReader.ReadUInt32());
			SetVirtualMemoryThreshold(boundsCheckedBinaryReader.ReadUInt32());
			SetProcessHeapFlags(boundsCheckedBinaryReader.ReadUInt32());
			SetProcessAffinityMask(boundsCheckedBinaryReader.ReadUInt32());
		}
		else
		{
			SetDeCommitFreeBlockThreshold(boundsCheckedBinaryReader.ReadUInt64());
			SetDeCommitTotalFreeThreshold(boundsCheckedBinaryReader.ReadUInt64());
			SetLockPrefixTable(boundsCheckedBinaryReader.ReadUInt64());
			SetMaximumAllocationSize(boundsCheckedBinaryReader.ReadUInt64());
			SetVirtualMemoryThreshold(boundsCheckedBinaryReader.ReadUInt64());
			SetProcessAffinityMask(boundsCheckedBinaryReader.ReadUInt64());
			SetProcessHeapFlags(boundsCheckedBinaryReader.ReadUInt32());
		}
		SetCsdVersion(boundsCheckedBinaryReader.ReadUInt16());
		SetDependentLoadFlags(boundsCheckedBinaryReader.ReadUInt16());
		if (RecoveredRuntime.Is32BitImage(peImage))
		{
			SetEditList(boundsCheckedBinaryReader.ReadUInt32());
			SetSecurityCookie(boundsCheckedBinaryReader.ReadUInt32());
			SetSeHandlerTable(boundsCheckedBinaryReader.ReadUInt32());
			SetSeHandlerCount(boundsCheckedBinaryReader.ReadUInt32());
		}
		else
		{
			SetEditList(boundsCheckedBinaryReader.ReadUInt64());
			SetSecurityCookie(boundsCheckedBinaryReader.ReadUInt64());
			SetSeHandlerTable(boundsCheckedBinaryReader.ReadUInt64());
			SetSeHandlerCount(boundsCheckedBinaryReader.ReadUInt64());
		}
	}
}
