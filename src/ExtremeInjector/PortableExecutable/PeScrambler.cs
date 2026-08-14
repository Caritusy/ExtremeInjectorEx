using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

public sealed class PeScrambler : IDisposable
{
	public delegate T ValueFactory<out T>();

	public sealed class SectionRemap
	{
		[CompilerGenerated]
		internal uint contentOffset;

		[CompilerGenerated]
		internal uint virtualAddressDelta;

		[CompilerGenerated]
		internal PeSectionHeader modifiedSection;

		[CompilerGenerated]
		internal PeSectionHeader originalSection;

		[SpecialName]
		[CompilerGenerated]
		public uint GetContentOffset()
		{
			return contentOffset;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetContentOffset(uint uintValue)
		{
			contentOffset = uintValue;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetVirtualAddressDelta(uint uintValue)
		{
			virtualAddressDelta = uintValue;
		}

		[SpecialName]
		[CompilerGenerated]
		public PeSectionHeader GetModifiedSection()
		{
			return modifiedSection;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetModifiedSection(PeSectionHeader peSectionHeader)
		{
			modifiedSection = peSectionHeader;
		}

		[SpecialName]
		[CompilerGenerated]
		public PeSectionHeader GetOriginalSection()
		{
			return originalSection;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetOriginalSection(PeSectionHeader peSectionHeader)
		{
			originalSection = peSectionHeader;
		}

		public SectionRemap(PeSectionHeader peSectionHeader, uint uintValue, uint uintValue2)
		{
			this.SetOriginalSection(peSectionHeader);
			this.SetVirtualAddressDelta(uintValue);
			this.SetContentOffset(uintValue2);
			PeSectionHeader gclass = new PeSectionHeader();
			gclass.SetCharacteristics(peSectionHeader.GetCharacteristics());
			gclass.SetName(peSectionHeader.GetName());
			gclass.SetNumberOfLineNumbers(peSectionHeader.GetNumberOfLineNumbers());
			gclass.SetNumberOfRelocations(peSectionHeader.GetNumberOfRelocations());
			gclass.SetPointerToLineNumbers(peSectionHeader.GetPointerToLineNumbers());
			gclass.SetPointerToRawData(peSectionHeader.GetPointerToRawData());
			gclass.SetPointerToRelocations(peSectionHeader.GetPointerToRelocations());
			gclass.SetSizeOfRawData(peSectionHeader.GetSizeOfRawData());
			gclass.SetVirtualAddress(peSectionHeader.GetVirtualAddress() + uintValue);
			gclass.SetVirtualSize(peSectionHeader.GetVirtualSize());
			this.SetModifiedSection(gclass);
			if (this.GetModifiedSection().GetVirtualSize() != 0u && this.GetModifiedSection().GetSizeOfRawData() != 0u)
			{
				PeSectionHeader gclass2 = this.GetModifiedSection();
				gclass2.SetVirtualSize(gclass2.GetVirtualSize() + uintValue2);
			}
			if (this.GetModifiedSection().GetSizeOfRawData() != 0u)
			{
				PeSectionHeader gclass3 = this.GetModifiedSection();
				gclass3.SetSizeOfRawData(gclass3.GetSizeOfRawData() + uintValue2);
			}
		}
	}

	[CompilerGenerated]
	public sealed class SourceSectionMatcher
	{
		public string text;

		internal bool MatchesSectionName(PeSectionHeader peSectionHeader)
		{
			return peSectionHeader.GetName() == text;
		}
	}

	[CompilerGenerated]
	public sealed class DestinationSectionMatcher
	{
		public string text;

		internal bool MatchesSectionName(PeSectionHeader peSectionHeader)
		{
			return peSectionHeader.GetName() == text;
		}
	}

	[Serializable]
	[CompilerGenerated]
	public sealed class ScramblerCallbackCache
	{
		public static readonly ScramblerCallbackCache _003C_003E9 = new ScramblerCallbackCache();

		public static Converter<ulong, uint> _003C_003E9__36_0;

		public static Func<SectionRemap, PeSectionHeader> _003C_003E9__53_0;

		internal uint ToUInt32(ulong ulongValue)
		{
			return (uint)ulongValue;
		}

		internal PeSectionHeader GetModifiedSection(SectionRemap sectionRemap)
		{
			return sectionRemap.GetModifiedSection();
		}
	}

	[CompilerGenerated]
	public sealed class ResourceDirectoryTraversal : IEnumerable<ResourceDirectoryNode>, IEnumerator<ResourceDirectoryNode>, IDisposable, IEnumerator, IEnumerable
	{
		internal int intValue;

		internal ResourceDirectoryNode resourceDirectoryNode;

		internal int intValue2;

		internal ResourceDirectoryNode resourceDirectoryNode2;

		public ResourceDirectoryNode resourceDirectoryNode3;

		internal Stack<ResourceDirectoryNode> items;

		internal ResourceDirectoryNode resourceDirectoryNode4;

		ResourceDirectoryNode IEnumerator<ResourceDirectoryNode>.Current => resourceDirectoryNode;

		object IEnumerator.Current => resourceDirectoryNode;

		public ResourceDirectoryTraversal(int intValue3)
		{
			intValue = intValue3;
			intValue2 = Thread.CurrentThread.ManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		bool IEnumerator.MoveNext()
		{
			int num = this.intValue;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.intValue = -1;
				foreach (ResourceDirectoryNode item in this.resourceDirectoryNode4.GetSubdirectories())
				{
					this.items.Push(item);
				}
				this.resourceDirectoryNode4 = null;
			}
			else
			{
				this.intValue = -1;
				this.items = new Stack<ResourceDirectoryNode>();
				this.items.Push(this.resourceDirectoryNode2);
			}
			if (this.items.Count > 0)
			{
				this.resourceDirectoryNode4 = this.items.Pop();
				this.resourceDirectoryNode = this.resourceDirectoryNode4;
				this.intValue = 1;
				return true;
			}
			return false;
		}

		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		IEnumerator<ResourceDirectoryNode> IEnumerable<ResourceDirectoryNode>.GetEnumerator()
		{
			ResourceDirectoryTraversal enumerator;
			if (this.intValue == -2 && this.intValue2 == Thread.CurrentThread.ManagedThreadId)
			{
				this.intValue = 0;
				enumerator = this;
			}
			else
			{
				enumerator = new ResourceDirectoryTraversal(0);
			}

			enumerator.resourceDirectoryNode2 = this.resourceDirectoryNode3;
			return enumerator;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<ResourceDirectoryNode>)this).GetEnumerator();
		}
	}

	internal readonly PeImage peImage;

	internal readonly Random random = new Random();

	internal readonly BinaryWriter binaryWriter;

	internal readonly PeScrambleOptions peScrambleOptions;

	public PeScrambler(PeImage peImage2, PeScrambleOptions peScrambleOptions2)
	{
		MemoryStream memoryStream = new MemoryStream();
		peImage2.GetStream().Position = 0L;
        BinaryExtensions.CopyTo(peImage2.GetStream(), memoryStream);
		memoryStream.Position = 0L;
		peImage = PeImageReader.ReadFullImage(memoryStream, flag: true, PeImageLayout.File);
		binaryWriter = new BinaryWriter(peImage.GetStream());
		peScrambleOptions = peScrambleOptions2;
	}

	internal void StripSectionAlignmentFlags()
	{
		foreach (PeSectionHeader gclass in this.peImage.GetSections())
		{
			gclass.SetCharacteristics(gclass.GetCharacteristics() & ~(SectionCharacteristics.Code | SectionCharacteristics.InitializedData | SectionCharacteristics.UninitializedData));
		}
	}

	internal void RandomizeSectionNames()
	{
		RecoveredRuntime.ClearClrIlOnlyFlag(this);
		foreach (PeSectionHeader gclass in this.peImage.GetSections())
		{
			string string_ = RecoveredRuntime.GenerateRandomSectionName(this);
			string text = RecoveredRuntime.GenerateRandomSectionName(this);
			while (this.peImage.GetSections().FindIndex((PeSectionHeader peSectionHeader) => peSectionHeader.GetName() == text) != -1)
			{
				text = RecoveredRuntime.GenerateRandomSectionName(this);
			}
			gclass.SetName(string_);
		}
	}

	internal void InsertHeaderPadding()
	{
		uint num = 0u;
		foreach (PeSectionHeader gclass in this.peImage.GetSections())
		{
			if (gclass.GetPointerToRawData() != 0u)
			{
				if (num == 0u)
				{
					byte[] buffer;
					using (Stream stream = RecoveredRuntime.CopyImageRange(this.peImage, (long)((ulong)gclass.GetPointerToRawData()), (int)(this.peImage.GetStream().Length - (long)((ulong)gclass.GetPointerToRawData()))))
					{
						using (BinaryReader binaryReader = new BinaryReader(stream))
						{
							buffer = binaryReader.ReadBytes((int)stream.Length);
						}
					}
					num = this.random.NextUInt32(5u, 40u) * this.peImage.GetHeaders().GetOptionalHeader().GetFileAlignment();
					RecoveredRuntime.FillImageRangeWithRandomBytes(this, (long)((ulong)gclass.GetPointerToRawData()), (long)((ulong)num));
					this.peImage.GetStream().Position = (long)((ulong)(gclass.GetPointerToRawData() + num));
					this.binaryWriter.Write(buffer);
				}
				PeSectionHeader gclass2 = gclass;
				gclass2.SetPointerToRawData(gclass2.GetPointerToRawData() + num);
			}
		}
	}

	internal void RemoveCodePadding()
	{
		foreach (PeSectionHeader gclass in this.peImage.GetSections())
		{
			if (gclass.GetPointerToRawData() != 0u && gclass.GetSizeOfRawData() != 0u && gclass.GetVirtualSize() != 0u && (gclass.GetCharacteristics() & SectionCharacteristics.Execute) == SectionCharacteristics.Execute)
			{
				using (Stream stream = RecoveredRuntime.CopyImageRange(this.peImage, (long)((ulong)gclass.GetPointerToRawData()), (int)gclass.GetSizeOfRawData()))
				{
					using (BinaryReader binaryReader = new BinaryReader(stream))
					{
						this.peImage.GetStream().Position = (long)((ulong)gclass.GetPointerToRawData());
						byte[] array = binaryReader.ReadBytes((int)gclass.GetSizeOfRawData());
						int num = 0;
						Dictionary<long, int> dictionary = new Dictionary<long, int>();
						for (int i = 0; i < array.Length; i++)
						{
							if (i % 16 != 0)
							{
								int num2 = 0;
								while (i + num2 < array.Length && array[i + num2++] == 204)
								{
									num++;
								}
								if (num >= 6 && (i + num) % 16 == 0)
								{
									dictionary.Add((long)((ulong)gclass.GetPointerToRawData() + (ulong)((long)i)), num);
								}
								i += num;
								num = 0;
							}
						}
						foreach (KeyValuePair<long, int> keyValuePair in dictionary)
						{
							RecoveredRuntime.FillImageRangeWithRandomBytes(this, keyValuePair.Key, (long)keyValuePair.Value);
						}
					}
				}
			}
		}
	}

	void IDisposable.Dispose()
	{
		binaryWriter.Close();
		peImage.Dispose();
	}

	internal void AddDecoySections()
	{
		RecoveredRuntime.ClearClrIlOnlyFlag(this);
		bool flag = this.peScrambleOptions.MoveRelocationTable && this.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[5].GetVirtualAddress() != 0u && this.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[5].GetSize() > 0u;
		bool flag2 = this.peScrambleOptions.CreateNewEntryPoint && RecoveredRuntime.Is32BitImage(this.peImage) && this.peImage.GetHeaders().GetOptionalHeader().GetAddressOfEntryPoint() > 0u;
		int num = 1;
		if (flag)
		{
			num++;
		}
		if (flag2)
		{
			num++;
		}
		int num2 = this.random.Next(num, 10);
		int num3 = num2 * 40;
		uint num4 = uint.MaxValue;
		foreach (PeSectionHeader gclass in this.peImage.GetSections())
		{
			if (gclass.GetPointerToRawData() != 0u && gclass.GetPointerToRawData() < num4)
			{
				num4 = gclass.GetPointerToRawData();
			}
		}
		if (num4 == 4294967295u)
		{
			return;
		}
		uint num5 = (uint)((ulong)(this.peImage.GetDosHeader().GetPeHeaderOffset() + 24u + (uint)this.peImage.GetHeaders().GetCoffHeader().GetSizeOfOptionalHeader()) + (ulong)((long)(this.peImage.GetSections().Count * 40)));
		uint num6 = num4;
		uint num7 = num4 - num5;
		while ((ulong)num7 < (ulong)((long)num3))
		{
			num6 += this.peImage.GetHeaders().GetOptionalHeader().GetSectionAlignment();
			num7 += this.peImage.GetHeaders().GetOptionalHeader().GetSectionAlignment();
		}
		byte[] buffer;
		using (Stream stream = RecoveredRuntime.CopyImageRange(this.peImage, (long)((ulong)num4), (int)(this.peImage.GetStream().Length - (long)((ulong)num4))))
		{
			using (BinaryReader binaryReader = new BinaryReader(stream))
			{
				buffer = binaryReader.ReadBytes((int)stream.Length);
			}
		}
		RecoveredRuntime.ZeroFillImageRange(this, (long)((ulong)num5), (long)((ulong)(num6 - num5)));
		this.peImage.GetStream().Position = (long)((ulong)num6);
		this.binaryWriter.Write(buffer);
		uint num8 = 0u;
		uint num9 = 0u;
		foreach (PeSectionHeader gclass2 in this.peImage.GetSections())
		{
			if (gclass2.GetPointerToRawData() != 0u)
			{
				PeSectionHeader gclass3 = gclass2;
				gclass3.SetPointerToRawData(gclass3.GetPointerToRawData() + (num6 - num4));
			}
			if (gclass2.GetPointerToRawData() + gclass2.GetSizeOfRawData() > num8)
			{
				num8 = gclass2.GetPointerToRawData() + gclass2.GetSizeOfRawData();
				num9 = gclass2.GetVirtualAddress() + gclass2.GetVirtualSize();
			}
		}
		buffer = new byte[0];
		if ((ulong)num8 < (ulong)this.peImage.GetStream().Length)
		{
			using (Stream stream2 = RecoveredRuntime.CopyImageRange(this.peImage, (long)((ulong)num8), (int)(this.peImage.GetStream().Length - (long)((ulong)num8))))
			{
				using (BinaryReader binaryReader2 = new BinaryReader(stream2))
				{
					buffer = binaryReader2.ReadBytes((int)stream2.Length);
				}
			}
		}
		uint uint_ = this.peImage.GetHeaders().GetOptionalHeader().GetSectionAlignment();
		num9 = RecoveredRuntime.AlignUp(uint_, num9);
		int num10 = this.random.Next(num2);
		int num11 = -1;
		while (flag && (num11 == -1 || num11 == num10))
		{
			num11 = this.random.Next(num2);
		}
		int num12 = -1;
		while (flag2 && (num12 == -1 || num12 == num11 || num12 == num10))
		{
			num12 = this.random.Next(num2);
		}
		for (int i = 0; i < num2; i++)
		{
			string text = RecoveredRuntime.GenerateRandomSectionName(this);
			while (this.peImage.GetSections().FindIndex((PeSectionHeader peSectionHeader) => peSectionHeader.GetName() == text) != -1)
			{
				text = RecoveredRuntime.GenerateRandomSectionName(this);
			}
			PeSectionHeader gclass4 = new PeSectionHeader();
			gclass4.SetName(text);
			gclass4.SetCharacteristics(SectionCharacteristics.Read);
			gclass4.SetPointerToRawData(num8);
			gclass4.SetVirtualSize(this.random.NextUInt32(10u, 100u) * 50u);
			gclass4.SetVirtualAddress(num9);
			PeSectionHeader gclass5 = gclass4;
			uint uintValue = this.peImage.GetHeaders().GetOptionalHeader().GetFileAlignment();
			uint num14 = RecoveredRuntime.AlignUp(uint_, gclass5.GetVirtualSize());
			gclass5.SetSizeOfRawData(RecoveredRuntime.AlignUp(uintValue, num14));
			SectionCharacteristics[] array = new SectionCharacteristics[]
			{
				(SectionCharacteristics)2147483648u,
				SectionCharacteristics.Execute,
				SectionCharacteristics.Discardable,
				SectionCharacteristics.InitializedData
			};
			for (int j = 0; j < this.random.Next(array.Length); j++)
			{
				SectionCharacteristics @enum = array[this.random.Next(array.Length)];
				if ((gclass5.GetCharacteristics() & @enum) == @enum)
				{
					j--;
				}
				else
				{
					PeSectionHeader gclass6 = gclass5;
					gclass6.SetCharacteristics(gclass6.GetCharacteristics() | @enum);
				}
			}
			RecoveredRuntime.FillImageRangeWithRandomBytes(this, (long)((ulong)gclass5.GetPointerToRawData()), (long)((ulong)gclass5.GetSizeOfRawData()));
			if (this.peScrambleOptions.CreateFakeDebugDirectory && num10 == i)
			{
				RecoveredRuntime.WriteFakeDebugDirectory(gclass5, this);
			}
			if (flag && num11 == i)
			{
				RecoveredRuntime.MoveBaseRelocationDirectory(this, gclass5);
			}
			if (flag2 && num12 == i)
			{
				RecoveredRuntime.CreateDecoyEntryPoint(this, gclass5);
			}
			this.peImage.GetSections().Add(gclass5);
			num8 += gclass5.GetSizeOfRawData();
			num9 += num14;
		}
		PeSectionHeader gclass7 = this.peImage.GetSections()[this.peImage.GetSections().Count - 1];
		this.peImage.GetHeaders().GetOptionalHeader().SetSizeOfImage(RecoveredRuntime.AlignUp(uint_, gclass7.GetVirtualAddress() + gclass7.GetVirtualSize()));
		this.peImage.GetHeaders().GetCoffHeader().SetNumberOfSections((ushort)this.peImage.GetSections().Count);
		this.peImage.GetStream().Position = (long)((ulong)num8);
		this.binaryWriter.Write(buffer);
	}

	internal void BuildTlsCallbackSection(PeSectionHeader peSectionHeader)
	{
		peSectionHeader.SetCharacteristics((SectionCharacteristics)3758096384u);
		RecoveredRuntime.FillImageRangeWithRandomBytes(this, (long)((ulong)peSectionHeader.GetPointerToRawData()), (long)((ulong)peSectionHeader.GetSizeOfRawData()));
		DataDirectory @class = this.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[9];
		List<uint> list = new List<uint>();
		uint num = (uint)this.peImage.GetHeaders().GetOptionalHeader().GetImageBase();
		uint num2 = num + peSectionHeader.GetVirtualAddress();
		uint num3;
		uint num4;
		uint num5;
		uint num6;
		uint value;
		uint value2;
		if (this.peImage.GetTlsDirectory() == null)
		{
			num3 = num + peSectionHeader.GetVirtualAddress() + 24u;
			num4 = num3 + this.random.NextUInt32(1u, 5u) * 4u;
			num5 = num4 + this.random.NextUInt32(1u, 5u) * 4u;
			num6 = num5 + this.random.NextUInt32(1u, 5u) * 4u;
			uint num7 = 0u;
			value = 0u;
			value2 = num7;
			num2 = num6 + this.random.NextUInt32(2u, 5u) * 4u;
		}
		else
		{
			num3 = (uint)this.peImage.GetTlsDirectory().GetStartAddressOfRawData();
			num4 = (uint)this.peImage.GetTlsDirectory().GetEndAddressOfRawData();
			num5 = (uint)this.peImage.GetTlsDirectory().GetAddressOfIndex();
			num6 = num + peSectionHeader.GetVirtualAddress() + 24u;
			value2 = this.peImage.GetTlsDirectory().GetSizeOfZeroFill();
			value = this.peImage.GetTlsDirectory().GetCharacteristics();
			list.AddRange(Array.ConvertAll<ulong, uint>(this.peImage.GetTlsDirectory().items.ToArray(), (ulong ulongValue) => (uint)ulongValue));
		}
		list.Add(num2);
		this.peImage.GetStream().Position = (long)((ulong)(peSectionHeader.GetPointerToRawData() + (num2 - num - peSectionHeader.GetVirtualAddress())));
		this.binaryWriter.Write(new byte[]
		{
			144,
			144,
			144,
			194,
			12,
			0
		});
		@class.SetVirtualAddress(peSectionHeader.GetVirtualAddress());
		@class.SetSize(24u);
		this.peImage.GetStream().Position = (long)((ulong)peSectionHeader.GetPointerToRawData());
		this.binaryWriter.Write(num3);
		this.binaryWriter.Write(num4);
		this.binaryWriter.Write(num5);
		this.binaryWriter.Write(num6);
		this.binaryWriter.Write(value2);
		this.binaryWriter.Write(value);
		this.peImage.GetStream().Position = (long)((ulong)(peSectionHeader.GetPointerToRawData() + (num6 - num - peSectionHeader.GetVirtualAddress())));
		foreach (uint value3 in list)
		{
			this.binaryWriter.Write(value3);
		}
		this.binaryWriter.Write(0);
	}

	internal static T GenerateDifferentValue<T>(T value, ValueFactory<T> valueFactory)
	{
		T result = valueFactory();
		while (result.Equals(value))
		{
			result = valueFactory();
		}
		return result;
	}

	internal List<SectionRemap> CreateSectionRemap()
	{
		List<PeScrambler.SectionRemap> list = new List<PeScrambler.SectionRemap>();
		uint num = this.random.NextUInt32(1u, 10u);
		uint num2 = num * this.peImage.GetHeaders().GetOptionalHeader().GetSectionAlignment();
		uint num3 = RecoveredRuntime.Is32BitImage(this.peImage) ? (this.random.NextUInt32(1u, num + 1u) * this.peImage.GetHeaders().GetOptionalHeader().GetFileAlignment()) : 0u;
		uint num4 = 0u;
		uint num5 = this.peImage.GetSections()[0].GetVirtualAddress() + num2;
		foreach (PeSectionHeader gclass in this.peImage.GetSections())
		{
			PeScrambler.SectionRemap @class = new PeScrambler.SectionRemap(gclass, num2, num3);
			@class.GetModifiedSection().SetVirtualAddress(num5);
			uint uint_ = num5 + @class.GetModifiedSection().GetVirtualSize();
			uint uintValue = this.peImage.GetHeaders().GetOptionalHeader().GetSectionAlignment();
			num5 = RecoveredRuntime.AlignUp(uintValue, uint_);
			if (gclass.GetSizeOfRawData() != 0u)
			{
				PeSectionHeader gclass2 = @class.GetModifiedSection();
				gclass2.SetPointerToRawData(gclass2.GetPointerToRawData() + num4);
				num4 += num3;
			}
			list.Add(@class);
		}
		List<PeScrambler.SectionRemap> list2 = list;
		int index = 0;
		PeSectionHeader gclass3 = new PeSectionHeader();
		gclass3.SetCharacteristics(SectionCharacteristics.Read);
		gclass3.SetVirtualAddress(this.peImage.GetSections()[0].GetVirtualAddress());
		gclass3.SetVirtualSize(num2);
		gclass3.SetName(RecoveredRuntime.GenerateRandomSectionName(this));
		list2.Insert(index, new PeScrambler.SectionRemap(gclass3, 0u, 0u));
		return list;
	}

	internal void RemapImportDirectory(List<SectionRemap> items)
	{
		if (this.peImage.GetImports() == null)
		{
			return;
		}
		BinaryWriter binaryWriter = new BinaryWriter(this.peImage.GetStream());
		this.peImage.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(this.peImage, this.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[1].GetVirtualAddress());
		foreach (ImportDescriptor @class in this.peImage.GetImports().items)
		{
			binaryWriter.Write(RecoveredRuntime.RemapRva(items, @class.GetOriginalFirstThunk()));
			this.peImage.GetStream().Position += 8L;
			binaryWriter.Write(RecoveredRuntime.RemapRva(items, @class.GetNameRva()));
			binaryWriter.Write(RecoveredRuntime.RemapRva(items, @class.GetFirstThunk()));
			long position = this.peImage.GetStream().Position;
			this.peImage.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(this.peImage, @class.GetOriginalFirstThunk());
			foreach (ImportedSymbol class2 in @class.GetOriginalThunkSymbols())
			{
				if (!class2.GetIsOrdinal())
				{
					if (!RecoveredRuntime.Is32BitImage(this.peImage))
					{
						BinaryWriter binaryWriter2 = binaryWriter;
						ulong num;
						class2.SetThunkValue(num = (ulong)RecoveredRuntime.RemapRva(items, (uint)class2.GetThunkValue()));
						binaryWriter2.Write(num);
					}
					else
					{
						BinaryWriter binaryWriter3 = binaryWriter;
						ulong num;
						class2.SetThunkValue(num = (ulong)RecoveredRuntime.RemapRva(items, (uint)class2.GetThunkValue()));
						binaryWriter3.Write((uint)num);
					}
				}
				else
				{
					this.peImage.GetStream().Position += (RecoveredRuntime.Is32BitImage(this.peImage) ? 4L : 8L);
				}
			}
			if (@class.GetFirstThunk() != @class.GetOriginalFirstThunk())
			{
				this.peImage.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(this.peImage, @class.GetFirstThunk());
				foreach (ImportedSymbol class3 in @class.GetFirstThunkSymbols())
				{
					if (!class3.GetIsOrdinal())
					{
						if (RecoveredRuntime.Is32BitImage(this.peImage))
						{
							BinaryWriter binaryWriter4 = binaryWriter;
							ulong num;
							class3.SetThunkValue(num = (ulong)RecoveredRuntime.RemapRva(items, (uint)class3.GetThunkValue()));
							binaryWriter4.Write((uint)num);
						}
						else
						{
							BinaryWriter binaryWriter5 = binaryWriter;
							ulong num;
							class3.SetThunkValue(num = (ulong)RecoveredRuntime.RemapRva(items, (uint)class3.GetThunkValue()));
							binaryWriter5.Write(num);
						}
					}
					else
					{
						this.peImage.GetStream().Position += (RecoveredRuntime.Is32BitImage(this.peImage) ? 4L : 8L);
					}
				}
			}
			@class.SetOriginalFirstThunk(RecoveredRuntime.RemapRva(items, @class.GetOriginalFirstThunk()));
			@class.SetNameRva(RecoveredRuntime.RemapRva(items, @class.GetNameRva()));
			@class.SetFirstThunk(RecoveredRuntime.RemapRva(items, @class.GetFirstThunk()));
			this.peImage.GetStream().Position = position;
		}
	}

	internal void RemapExceptionDirectory(List<SectionRemap> items)
	{
		if (this.peImage.GetExceptionDirectory() == null)
		{
			return;
		}
		BinaryWriter binaryWriter = new BinaryWriter(this.peImage.GetStream());
		this.peImage.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(this.peImage, this.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[3].GetVirtualAddress());
		foreach (RuntimeFunctionEntry @class in this.peImage.GetExceptionDirectory().items)
		{
			BinaryWriter binaryWriter2 = binaryWriter;
			uint value;
			@class.SetBeginAddress(value = RecoveredRuntime.RemapRva(items, @class.GetBeginAddress()));
			binaryWriter2.Write(value);
			BinaryWriter binaryWriter3 = binaryWriter;
			@class.SetEndAddress(value = RecoveredRuntime.RemapRva(items, @class.GetEndAddress()));
			binaryWriter3.Write(value);
			BinaryWriter binaryWriter4 = binaryWriter;
			@class.SetUnwindInfoAddress(value = RecoveredRuntime.RemapRva(items, @class.GetUnwindInfoAddress()));
			binaryWriter4.Write(value);
		}
	}

	internal void RemapBaseRelocations(List<SectionRemap> items)
	{
		if (this.peImage.GetBaseRelocations() == null)
		{
			return;
		}
		BinaryReader binaryReader = new BinaryReader(this.peImage.GetStream());
		BinaryWriter binaryWriter = new BinaryWriter(this.peImage.GetStream());
		long num = RecoveredRuntime.MapRvaToFileOffset(this.peImage, this.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[5].GetVirtualAddress());
		ulong num2 = this.peImage.GetHeaders().GetOptionalHeader().GetImageBase();
		foreach (BaseRelocationBlock @class in this.peImage.GetBaseRelocations().items)
		{
			this.peImage.GetStream().Position = num;
			binaryWriter.Write(RecoveredRuntime.RemapRva(items, @class.GetPageRva()));
			foreach (BaseRelocationEntry class2 in @class.items)
			{
				this.peImage.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(this.peImage, @class.GetPageRva() + class2.GetOffset());
				if (class2.GetRelocationType() == BaseRelocationType.HighLow)
				{
					uint num3 = binaryReader.ReadUInt32();
					this.peImage.GetStream().Position -= 4L;
					binaryWriter.Write((uint)num2 + RecoveredRuntime.RemapRva(items, num3 - (uint)num2));
				}
				else if (class2.GetRelocationType() == BaseRelocationType.Dir64)
				{
					ulong num4 = binaryReader.ReadUInt64();
					this.peImage.GetStream().Position -= 8L;
					binaryWriter.Write(num2 + (ulong)RecoveredRuntime.RemapRva(items, (uint)(num4 - num2)));
				}
			}
			@class.SetPageRva(RecoveredRuntime.RemapRva(items, @class.GetPageRva()));
			num += (long)((ulong)@class.GetBlockSize());
		}
	}

}
