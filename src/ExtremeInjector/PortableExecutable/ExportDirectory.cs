using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class ExportDirectory
{
	public List<string> items = new List<string>();

	public List<ExportedSymbol> items2 = new List<ExportedSymbol>();

	[CompilerGenerated]
	internal uint characteristics;

	[CompilerGenerated]
	internal uint timeDateStamp;

	[CompilerGenerated]
	internal ushort majorVersion;

	[CompilerGenerated]
	internal ushort minorVersion;

	[CompilerGenerated]
	internal uint nameRva;

	[CompilerGenerated]
	internal uint ordinalBase;

	[CompilerGenerated]
	internal uint numberOfFunctions;

	[CompilerGenerated]
	internal uint numberOfNames;

	[CompilerGenerated]
	internal uint addressOfFunctions;

	[CompilerGenerated]
	internal uint addressOfNames;

	[CompilerGenerated]
	internal uint addressOfNameOrdinals;

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

	[SpecialName]
	[CompilerGenerated]
	public void SetNameRva(uint uintValue)
	{
		nameRva = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetOrdinalBase()
	{
		return ordinalBase;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetOrdinalBase(uint uintValue)
	{
		ordinalBase = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetNumberOfFunctions()
	{
		return numberOfFunctions;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfFunctions(uint uintValue)
	{
		numberOfFunctions = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetNumberOfNames()
	{
		return numberOfNames;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfNames(uint uintValue)
	{
		numberOfNames = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetAddressOfFunctions()
	{
		return addressOfFunctions;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfFunctions(uint uintValue)
	{
		addressOfFunctions = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetAddressOfNames()
	{
		return addressOfNames;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfNames(uint uintValue)
	{
		addressOfNames = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetAddressOfNameOrdinals()
	{
		return addressOfNameOrdinals;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfNameOrdinals(uint uintValue)
	{
		addressOfNameOrdinals = uintValue;
	}

	internal ExportDirectory(BoundsCheckedBinaryReader boundsCheckedBinaryReader, PeImage peImage, DataDirectory dataDirectory)
	{
		this.SetCharacteristics(boundsCheckedBinaryReader.ReadUInt32());
		this.SetTimeDateStamp(boundsCheckedBinaryReader.ReadUInt32());
		this.SetMajorVersion(boundsCheckedBinaryReader.ReadUInt16());
		this.SetMinorVersion(boundsCheckedBinaryReader.ReadUInt16());
		this.SetNameRva(boundsCheckedBinaryReader.ReadUInt32());
		this.SetOrdinalBase(boundsCheckedBinaryReader.ReadUInt32());
		this.SetNumberOfFunctions(boundsCheckedBinaryReader.ReadUInt32());
		this.SetNumberOfNames(boundsCheckedBinaryReader.ReadUInt32());
		this.SetAddressOfFunctions(boundsCheckedBinaryReader.ReadUInt32());
		this.SetAddressOfNames(boundsCheckedBinaryReader.ReadUInt32());
		this.SetAddressOfNameOrdinals(boundsCheckedBinaryReader.ReadUInt32());
		long num = RecoveredRuntime.MapRvaToFileOffset(peImage, this.GetAddressOfNames());
		long num2 = RecoveredRuntime.MapRvaToFileOffset(peImage, this.GetAddressOfNameOrdinals());
		long num3 = RecoveredRuntime.MapRvaToFileOffset(peImage, this.GetAddressOfFunctions());
		if (num != -1L && num2 != -1L && num3 != -1L && boundsCheckedBinaryReader.IsValidOffset(num) && boundsCheckedBinaryReader.IsValidOffset(num2) && boundsCheckedBinaryReader.IsValidOffset(num3))
		{
			RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
			bool[] array = new bool[this.GetNumberOfFunctions()];
			for (uint num4 = 0u; num4 < this.GetNumberOfNames(); num4 += 1u)
			{
				RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num + (long)((ulong)(num4 * 4u)));
				long num5 = RecoveredRuntime.MapRvaToFileOffset(peImage, boundsCheckedBinaryReader.ReadUInt32());
				if (num5 != -1L && boundsCheckedBinaryReader.IsValidOffset(num5))
				{
					RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num5);
					string text = RecoveredRuntime.ReadNullTerminatedAsciiString(boundsCheckedBinaryReader);
					this.items.Add(text);
					RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num2 + (long)((ulong)(num4 * 2u)));
					ushort num6 = boundsCheckedBinaryReader.ReadUInt16();
					RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num3 + (long)(num6 * 4));
					uint num7 = boundsCheckedBinaryReader.ReadUInt32();
					ForwardedExport @class = null;
					long num8 = -1L;
					if (num7 >= dataDirectory.GetVirtualAddress() && num7 < dataDirectory.GetVirtualAddress() + dataDirectory.GetSize())
					{
						num8 = boundsCheckedBinaryReader.BaseStream.Position;
						long long_ = RecoveredRuntime.MapRvaToFileOffset(peImage, num7);
						RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, long_);
						@class = new ForwardedExport();
						string text2 = RecoveredRuntime.ReadNullTerminatedAsciiString(boundsCheckedBinaryReader);
						@class.SetModuleName(text2.Substring(0, text2.LastIndexOf('.')) + EncodedStringTable.DecodeString(10075));
						int num9 = text2.LastIndexOf('.') + 1;
						string text3 = text2.Substring(num9, text2.Length - num9);
						if (text2.Contains(EncodedStringTable.DecodeString(10084)))
						{
							@class.SetOrdinal(ushort.Parse(text3.Substring(1)));
						}
						else
						{
							@class.SetName(text3);
							@class.SetIsOrdinal(true);
						}
					}
					if (num8 != -1L)
					{
						RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num8);
					}
					array[(int)num6] = true;
					ExportedSymbol class2 = new ExportedSymbol();
					class2.SetHasName(true);
					class2.SetName(text);
					class2.SetOrdinal((ushort)((uint)num6 + this.GetOrdinalBase()));
					class2.SetAddressRva(num7);
					class2.SetForwarder(@class);
					ExportedSymbol item = class2;
					this.items2.Add(item);
				}
			}
			for (uint num10 = 0u; num10 < this.GetNumberOfFunctions(); num10 += 1u)
			{
				if (!array[(int)num10])
				{
					RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num3 + (long)((ulong)(num10 * 4u)));
					uint num11 = boundsCheckedBinaryReader.ReadUInt32();
					ExportedSymbol class3 = new ExportedSymbol();
					class3.SetOrdinal((ushort)(num10 + this.GetOrdinalBase()));
					class3.SetAddressRva(num11);
					ExportedSymbol item2 = class3;
					this.items2.Add(item2);
				}
			}
			return;
		}
	}
}
