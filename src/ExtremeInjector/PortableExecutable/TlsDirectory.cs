using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class TlsDirectory
{
	[CompilerGenerated]
	internal ulong ulong_0;

	[CompilerGenerated]
	internal ulong ulong_1;

	[CompilerGenerated]
	internal ulong ulong_2;

	[CompilerGenerated]
	internal ulong ulong_3;

	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	public List<ulong> list_0 = new List<ulong>();

	[SpecialName]
	[CompilerGenerated]
	public ulong GetStartAddressOfRawData()
	{
		return ulong_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetStartAddressOfRawData(ulong ulong_4)
	{
		ulong_0 = ulong_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetEndAddressOfRawData()
	{
		return ulong_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetEndAddressOfRawData(ulong ulong_4)
	{
		ulong_1 = ulong_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetAddressOfIndex()
	{
		return ulong_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfIndex(ulong ulong_4)
	{
		ulong_2 = ulong_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong GetAddressOfCallbacks()
	{
		return ulong_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfCallbacks(ulong ulong_4)
	{
		ulong_3 = ulong_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfZeroFill()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfZeroFill(uint uint_2)
	{
		uint_0 = uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetCharacteristics()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCharacteristics(uint uint_2)
	{
		uint_1 = uint_2;
	}

	internal TlsDirectory(BoundsCheckedBinaryReader class5_0, PeImage class154_0)
	{
		SetStartAddressOfRawData(RecoveredRuntime.Is32BitImage(class154_0) ? class5_0.ReadUInt32() : class5_0.ReadUInt64());
		SetEndAddressOfRawData(RecoveredRuntime.Is32BitImage(class154_0) ? class5_0.ReadUInt32() : class5_0.ReadUInt64());
		SetAddressOfIndex(RecoveredRuntime.Is32BitImage(class154_0) ? class5_0.ReadUInt32() : class5_0.ReadUInt64());
		SetAddressOfCallbacks(RecoveredRuntime.Is32BitImage(class154_0) ? class5_0.ReadUInt32() : class5_0.ReadUInt64());
		SetSizeOfZeroFill(class5_0.ReadUInt32());
		SetCharacteristics(class5_0.ReadUInt32());
		long num = RecoveredRuntime.MapVirtualAddressToFileOffset(class154_0, GetAddressOfCallbacks());
		if (num != -1L)
		{
			RecoveredRuntime.SeekReader(class5_0, num);
			ulong item;
			while ((item = ((!RecoveredRuntime.Is32BitImage(class154_0)) ? class5_0.ReadUInt64() : class5_0.ReadUInt32())) != 0L)
			{
				list_0.Add(item);
			}
		}
	}
}
