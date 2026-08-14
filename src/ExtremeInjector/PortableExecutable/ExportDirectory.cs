using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class ExportDirectory
{
	public List<string> list_0 = new List<string>();

	public List<ExportedSymbol> list_1 = new List<ExportedSymbol>();

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
	internal uint uint_5;

	[CompilerGenerated]
	internal uint uint_6;

	[CompilerGenerated]
	internal uint uint_7;

	[CompilerGenerated]
	internal uint uint_8;

	[SpecialName]
	[CompilerGenerated]
	public void SetCharacteristics(uint uint_9)
	{
		uint_0 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetTimeDateStamp(uint uint_9)
	{
		uint_1 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorVersion(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorVersion(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNameRva(uint uint_9)
	{
		uint_2 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetOrdinalBase()
	{
		return uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetOrdinalBase(uint uint_9)
	{
		uint_3 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetNumberOfFunctions()
	{
		return uint_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfFunctions(uint uint_9)
	{
		uint_4 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetNumberOfNames()
	{
		return uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfNames(uint uint_9)
	{
		uint_5 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetAddressOfFunctions()
	{
		return uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfFunctions(uint uint_9)
	{
		uint_6 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetAddressOfNames()
	{
		return uint_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfNames(uint uint_9)
	{
		uint_7 = uint_9;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetAddressOfNameOrdinals()
	{
		return uint_8;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfNameOrdinals(uint uint_9)
	{
		uint_8 = uint_9;
	}

	internal ExportDirectory(BoundsCheckedBinaryReader class5_0, PeImage class154_0, DataDirectory class157_0)
	{
		this.SetCharacteristics(class5_0.ReadUInt32());
		this.SetTimeDateStamp(class5_0.ReadUInt32());
		this.SetMajorVersion(class5_0.ReadUInt16());
		this.SetMinorVersion(class5_0.ReadUInt16());
		this.SetNameRva(class5_0.ReadUInt32());
		this.SetOrdinalBase(class5_0.ReadUInt32());
		this.SetNumberOfFunctions(class5_0.ReadUInt32());
		this.SetNumberOfNames(class5_0.ReadUInt32());
		this.SetAddressOfFunctions(class5_0.ReadUInt32());
		this.SetAddressOfNames(class5_0.ReadUInt32());
		this.SetAddressOfNameOrdinals(class5_0.ReadUInt32());
		long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, this.GetAddressOfNames());
		long num2 = RecoveredRuntime.MapRvaToFileOffset(class154_0, this.GetAddressOfNameOrdinals());
		long num3 = RecoveredRuntime.MapRvaToFileOffset(class154_0, this.GetAddressOfFunctions());
		if (num != -1L && num2 != -1L && num3 != -1L && class5_0.IsValidOffset(num) && class5_0.IsValidOffset(num2) && class5_0.IsValidOffset(num3))
		{
			RecoveredRuntime.SeekReader(class5_0, num);
			bool[] array = new bool[this.GetNumberOfFunctions()];
			for (uint num4 = 0u; num4 < this.GetNumberOfNames(); num4 += 1u)
			{
				RecoveredRuntime.SeekReader(class5_0, num + (long)((ulong)(num4 * 4u)));
				long num5 = RecoveredRuntime.MapRvaToFileOffset(class154_0, class5_0.ReadUInt32());
				if (num5 != -1L && class5_0.IsValidOffset(num5))
				{
					RecoveredRuntime.SeekReader(class5_0, num5);
					string text = RecoveredRuntime.ReadNullTerminatedAsciiString(class5_0);
					this.list_0.Add(text);
					RecoveredRuntime.SeekReader(class5_0, num2 + (long)((ulong)(num4 * 2u)));
					ushort num6 = class5_0.ReadUInt16();
					RecoveredRuntime.SeekReader(class5_0, num3 + (long)(num6 * 4));
					uint num7 = class5_0.ReadUInt32();
					ForwardedExport @class = null;
					long num8 = -1L;
					if (num7 >= class157_0.GetVirtualAddress() && num7 < class157_0.GetVirtualAddress() + class157_0.GetSize())
					{
						num8 = class5_0.BaseStream.Position;
						long long_ = RecoveredRuntime.MapRvaToFileOffset(class154_0, num7);
						RecoveredRuntime.SeekReader(class5_0, long_);
						@class = new ForwardedExport();
						string text2 = RecoveredRuntime.ReadNullTerminatedAsciiString(class5_0);
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
						RecoveredRuntime.SeekReader(class5_0, num8);
					}
					array[(int)num6] = true;
					ExportedSymbol class2 = new ExportedSymbol();
					class2.SetHasName(true);
					class2.SetName(text);
					class2.SetOrdinal((ushort)((uint)num6 + this.GetOrdinalBase()));
					class2.SetAddressRva(num7);
					class2.SetForwarder(@class);
					ExportedSymbol item = class2;
					this.list_1.Add(item);
				}
			}
			for (uint num10 = 0u; num10 < this.GetNumberOfFunctions(); num10 += 1u)
			{
				if (!array[(int)num10])
				{
					RecoveredRuntime.SeekReader(class5_0, num3 + (long)((ulong)(num10 * 4u)));
					uint num11 = class5_0.ReadUInt32();
					ExportedSymbol class3 = new ExportedSymbol();
					class3.SetOrdinal((ushort)(num10 + this.GetOrdinalBase()));
					class3.SetAddressRva(num11);
					ExportedSymbol item2 = class3;
					this.list_1.Add(item2);
				}
			}
			return;
		}
	}
}
