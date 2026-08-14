using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class TlsDirectory
{
	[CompilerGenerated]
	internal ulong startAddressOfRawData;

	[CompilerGenerated]
	internal ulong endAddressOfRawData;

	[CompilerGenerated]
	internal ulong addressOfIndex;

	[CompilerGenerated]
	internal ulong addressOfCallbacks;

	[CompilerGenerated]
	internal uint sizeOfZeroFill;

	[CompilerGenerated]
	internal uint characteristics;

	public List<ulong> items = new List<ulong>();

	[SpecialName]
	[CompilerGenerated]
	public ulong GetStartAddressOfRawData()
	{
		return startAddressOfRawData;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetStartAddressOfRawData(ulong ulongValue)
	{
		startAddressOfRawData = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetEndAddressOfRawData()
	{
		return endAddressOfRawData;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetEndAddressOfRawData(ulong ulongValue)
	{
		endAddressOfRawData = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetAddressOfIndex()
	{
		return addressOfIndex;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfIndex(ulong ulongValue)
	{
		addressOfIndex = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetAddressOfCallbacks()
	{
		return addressOfCallbacks;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfCallbacks(ulong ulongValue)
	{
		addressOfCallbacks = ulongValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfZeroFill()
	{
		return sizeOfZeroFill;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfZeroFill(uint uintValue)
	{
		sizeOfZeroFill = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetCharacteristics()
	{
		return characteristics;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCharacteristics(uint uintValue)
	{
		characteristics = uintValue;
	}

	internal TlsDirectory(BoundsCheckedBinaryReader boundsCheckedBinaryReader, PeImage peImage)
	{
		SetStartAddressOfRawData(RecoveredRuntime.Is32BitImage(peImage) ? boundsCheckedBinaryReader.ReadUInt32() : boundsCheckedBinaryReader.ReadUInt64());
		SetEndAddressOfRawData(RecoveredRuntime.Is32BitImage(peImage) ? boundsCheckedBinaryReader.ReadUInt32() : boundsCheckedBinaryReader.ReadUInt64());
		SetAddressOfIndex(RecoveredRuntime.Is32BitImage(peImage) ? boundsCheckedBinaryReader.ReadUInt32() : boundsCheckedBinaryReader.ReadUInt64());
		SetAddressOfCallbacks(RecoveredRuntime.Is32BitImage(peImage) ? boundsCheckedBinaryReader.ReadUInt32() : boundsCheckedBinaryReader.ReadUInt64());
		SetSizeOfZeroFill(boundsCheckedBinaryReader.ReadUInt32());
		SetCharacteristics(boundsCheckedBinaryReader.ReadUInt32());
		long num = RecoveredRuntime.MapVirtualAddressToFileOffset(peImage, GetAddressOfCallbacks());
		if (num != -1L)
		{
			RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
			ulong item;
			while ((item = ((!RecoveredRuntime.Is32BitImage(peImage)) ? boundsCheckedBinaryReader.ReadUInt64() : boundsCheckedBinaryReader.ReadUInt32())) != 0L)
			{
				items.Add(item);
			}
		}
	}
}
