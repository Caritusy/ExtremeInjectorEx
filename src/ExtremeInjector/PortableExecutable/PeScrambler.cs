using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

public sealed class PeScrambler : IDisposable
{
	public delegate T Delegate48<out T>();

	public sealed class Class132
	{
		[CompilerGenerated]
		internal uint uint_0;

		[CompilerGenerated]
		internal uint uint_1;

		[CompilerGenerated]
		internal PeSectionHeader gclass5_0;

		[CompilerGenerated]
		internal PeSectionHeader gclass5_1;

		[SpecialName]
		[CompilerGenerated]
		public uint GetContentOffset()
		{
			return uint_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetContentOffset(uint uint_2)
		{
			uint_0 = uint_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetVirtualAddressDelta(uint uint_2)
		{
			uint_1 = uint_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public PeSectionHeader GetModifiedSection()
		{
			return gclass5_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetModifiedSection(PeSectionHeader gclass5_2)
		{
			gclass5_0 = gclass5_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public PeSectionHeader GetOriginalSection()
		{
			return gclass5_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public void SetOriginalSection(PeSectionHeader gclass5_2)
		{
			gclass5_1 = gclass5_2;
		}

		public Class132(PeSectionHeader gclass5_2, uint uint_2, uint uint_3)
		{
			this.SetOriginalSection(gclass5_2);
			this.SetVirtualAddressDelta(uint_2);
			this.SetContentOffset(uint_3);
			PeSectionHeader gclass = new PeSectionHeader();
			gclass.SetCharacteristics(gclass5_2.GetCharacteristics());
			gclass.SetName(gclass5_2.GetName());
			gclass.SetNumberOfLineNumbers(gclass5_2.GetNumberOfLineNumbers());
			gclass.SetNumberOfRelocations(gclass5_2.GetNumberOfRelocations());
			gclass.SetPointerToLineNumbers(gclass5_2.GetPointerToLineNumbers());
			gclass.SetPointerToRawData(gclass5_2.GetPointerToRawData());
			gclass.SetPointerToRelocations(gclass5_2.GetPointerToRelocations());
			gclass.SetSizeOfRawData(gclass5_2.GetSizeOfRawData());
			gclass.SetVirtualAddress(gclass5_2.GetVirtualAddress() + uint_2);
			gclass.SetVirtualSize(gclass5_2.GetVirtualSize());
			this.SetModifiedSection(gclass);
			if (this.GetModifiedSection().GetVirtualSize() != 0u && this.GetModifiedSection().GetSizeOfRawData() != 0u)
			{
				PeSectionHeader gclass2 = this.GetModifiedSection();
				gclass2.SetVirtualSize(gclass2.GetVirtualSize() + uint_3);
			}
			if (this.GetModifiedSection().GetSizeOfRawData() != 0u)
			{
				PeSectionHeader gclass3 = this.GetModifiedSection();
				gclass3.SetSizeOfRawData(gclass3.GetSizeOfRawData() + uint_3);
			}
		}
	}

	[CompilerGenerated]
	public sealed class Class133
	{
		public string string_0;

		internal bool MatchesSectionName(PeSectionHeader gclass5_0)
		{
			return gclass5_0.GetName() == string_0;
		}
	}

	[CompilerGenerated]
	public sealed class Class134
	{
		public string string_0;

		internal bool MatchesSectionName(PeSectionHeader gclass5_0)
		{
			return gclass5_0.GetName() == string_0;
		}
	}

	[Serializable]
	[CompilerGenerated]
	public sealed class Class135
	{
		public static readonly Class135 _003C_003E9 = new Class135();

		public static Converter<ulong, uint> _003C_003E9__36_0;

		public static Func<Class132, PeSectionHeader> _003C_003E9__53_0;

		internal uint ToUInt32(ulong ulong_0)
		{
			return (uint)ulong_0;
		}

		internal PeSectionHeader GetModifiedSection(Class132 class132_0)
		{
			return class132_0.GetModifiedSection();
		}
	}

	[CompilerGenerated]
	public sealed class Class136 : IEnumerable<ResourceDirectoryNode>, IEnumerator<ResourceDirectoryNode>, IDisposable, IEnumerator, IEnumerable
	{
		internal int int_0;

		internal ResourceDirectoryNode class138_0;

		internal int int_1;

		internal ResourceDirectoryNode class138_1;

		public ResourceDirectoryNode class138_2;

		internal Stack<ResourceDirectoryNode> stack_0;

		internal ResourceDirectoryNode class138_3;

		ResourceDirectoryNode IEnumerator<ResourceDirectoryNode>.Current => class138_0;

		object IEnumerator.Current => class138_0;

		public Class136(int int_2)
		{
			int_0 = int_2;
			int_1 = Thread.CurrentThread.ManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		bool IEnumerator.MoveNext()
		{
			int num = this.int_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.int_0 = -1;
				foreach (ResourceDirectoryNode item in this.class138_3.GetSubdirectories())
				{
					this.stack_0.Push(item);
				}
				this.class138_3 = null;
			}
			else
			{
				this.int_0 = -1;
				this.stack_0 = new Stack<ResourceDirectoryNode>();
				this.stack_0.Push(this.class138_1);
			}
			if (this.stack_0.Count > 0)
			{
				this.class138_3 = this.stack_0.Pop();
				this.class138_0 = this.class138_3;
				this.int_0 = 1;
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
			Class136 enumerator;
			if (this.int_0 == -2 && this.int_1 == Thread.CurrentThread.ManagedThreadId)
			{
				this.int_0 = 0;
				enumerator = this;
			}
			else
			{
				enumerator = new Class136(0);
			}

			enumerator.class138_1 = this.class138_2;
			return enumerator;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<ResourceDirectoryNode>)this).GetEnumerator();
		}
	}

	internal readonly PeImage class154_0;

	internal readonly Random random_0 = new Random();

	internal readonly BinaryWriter binaryWriter_0;

	internal readonly PeScrambleOptions class131_0;

	public PeScrambler(PeImage class154_1, PeScrambleOptions class131_1)
	{
		MemoryStream memoryStream = new MemoryStream();
		class154_1.GetStream().Position = 0L;
        BinaryExtensions.CopyTo(class154_1.GetStream(), memoryStream);
		memoryStream.Position = 0L;
		class154_0 = PeImageReader.ReadFullImage(memoryStream, bool_0: true, PeImageLayout.const_0);
		binaryWriter_0 = new BinaryWriter(class154_0.GetStream());
		class131_0 = class131_1;
	}

	internal void StripSectionAlignmentFlags()
	{
		foreach (PeSectionHeader gclass in this.class154_0.GetSections())
		{
			gclass.SetCharacteristics(gclass.GetCharacteristics() & ~(SectionCharacteristics.flag_1 | SectionCharacteristics.flag_2 | SectionCharacteristics.flag_3));
		}
	}

	internal void RandomizeSectionNames()
	{
		RecoveredRuntime.ClearClrIlOnlyFlag(this);
		foreach (PeSectionHeader gclass in this.class154_0.GetSections())
		{
			string string_ = RecoveredRuntime.GenerateRandomSectionName(this);
			string string_0 = RecoveredRuntime.GenerateRandomSectionName(this);
			while (this.class154_0.GetSections().FindIndex((PeSectionHeader gclass5_0) => gclass5_0.GetName() == string_0) != -1)
			{
				string_0 = RecoveredRuntime.GenerateRandomSectionName(this);
			}
			gclass.SetName(string_);
		}
	}

	internal void InsertHeaderPadding()
	{
		uint num = 0u;
		foreach (PeSectionHeader gclass in this.class154_0.GetSections())
		{
			if (gclass.GetPointerToRawData() != 0u)
			{
				if (num == 0u)
				{
					byte[] buffer;
					using (Stream stream = RecoveredRuntime.CopyImageRange(this.class154_0, (long)((ulong)gclass.GetPointerToRawData()), (int)(this.class154_0.GetStream().Length - (long)((ulong)gclass.GetPointerToRawData()))))
					{
						using (BinaryReader binaryReader = new BinaryReader(stream))
						{
							buffer = binaryReader.ReadBytes((int)stream.Length);
						}
					}
					num = this.random_0.NextUInt32(5u, 40u) * this.class154_0.GetHeaders().GetOptionalHeader().GetFileAlignment();
					RecoveredRuntime.FillImageRangeWithRandomBytes(this, (long)((ulong)gclass.GetPointerToRawData()), (long)((ulong)num));
					this.class154_0.GetStream().Position = (long)((ulong)(gclass.GetPointerToRawData() + num));
					this.binaryWriter_0.Write(buffer);
				}
				PeSectionHeader gclass2 = gclass;
				gclass2.SetPointerToRawData(gclass2.GetPointerToRawData() + num);
			}
		}
	}

	internal void RemoveCodePadding()
	{
		foreach (PeSectionHeader gclass in this.class154_0.GetSections())
		{
			if (gclass.GetPointerToRawData() != 0u && gclass.GetSizeOfRawData() != 0u && gclass.GetVirtualSize() != 0u && (gclass.GetCharacteristics() & SectionCharacteristics.flag_32) == SectionCharacteristics.flag_32)
			{
				using (Stream stream = RecoveredRuntime.CopyImageRange(this.class154_0, (long)((ulong)gclass.GetPointerToRawData()), (int)gclass.GetSizeOfRawData()))
				{
					using (BinaryReader binaryReader = new BinaryReader(stream))
					{
						this.class154_0.GetStream().Position = (long)((ulong)gclass.GetPointerToRawData());
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
		binaryWriter_0.Close();
		class154_0.Dispose();
	}

	internal void AddDecoySections()
	{
		RecoveredRuntime.ClearClrIlOnlyFlag(this);
		bool flag = this.class131_0.MoveRelocationTable && this.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[5].GetVirtualAddress() != 0u && this.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[5].GetSize() > 0u;
		bool flag2 = this.class131_0.CreateNewEntryPoint && RecoveredRuntime.Is32BitImage(this.class154_0) && this.class154_0.GetHeaders().GetOptionalHeader().GetAddressOfEntryPoint() > 0u;
		int num = 1;
		if (flag)
		{
			num++;
		}
		if (flag2)
		{
			num++;
		}
		int num2 = this.random_0.Next(num, 10);
		int num3 = num2 * 40;
		uint num4 = uint.MaxValue;
		foreach (PeSectionHeader gclass in this.class154_0.GetSections())
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
		uint num5 = (uint)((ulong)(this.class154_0.GetDosHeader().GetPeHeaderOffset() + 24u + (uint)this.class154_0.GetHeaders().GetCoffHeader().GetSizeOfOptionalHeader()) + (ulong)((long)(this.class154_0.GetSections().Count * 40)));
		uint num6 = num4;
		uint num7 = num4 - num5;
		while ((ulong)num7 < (ulong)((long)num3))
		{
			num6 += this.class154_0.GetHeaders().GetOptionalHeader().GetSectionAlignment();
			num7 += this.class154_0.GetHeaders().GetOptionalHeader().GetSectionAlignment();
		}
		byte[] buffer;
		using (Stream stream = RecoveredRuntime.CopyImageRange(this.class154_0, (long)((ulong)num4), (int)(this.class154_0.GetStream().Length - (long)((ulong)num4))))
		{
			using (BinaryReader binaryReader = new BinaryReader(stream))
			{
				buffer = binaryReader.ReadBytes((int)stream.Length);
			}
		}
		RecoveredRuntime.ZeroFillImageRange(this, (long)((ulong)num5), (long)((ulong)(num6 - num5)));
		this.class154_0.GetStream().Position = (long)((ulong)num6);
		this.binaryWriter_0.Write(buffer);
		uint num8 = 0u;
		uint num9 = 0u;
		foreach (PeSectionHeader gclass2 in this.class154_0.GetSections())
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
		if ((ulong)num8 < (ulong)this.class154_0.GetStream().Length)
		{
			using (Stream stream2 = RecoveredRuntime.CopyImageRange(this.class154_0, (long)((ulong)num8), (int)(this.class154_0.GetStream().Length - (long)((ulong)num8))))
			{
				using (BinaryReader binaryReader2 = new BinaryReader(stream2))
				{
					buffer = binaryReader2.ReadBytes((int)stream2.Length);
				}
			}
		}
		uint uint_ = this.class154_0.GetHeaders().GetOptionalHeader().GetSectionAlignment();
		num9 = RecoveredRuntime.AlignUp(uint_, num9);
		int num10 = this.random_0.Next(num2);
		int num11 = -1;
		while (flag && (num11 == -1 || num11 == num10))
		{
			num11 = this.random_0.Next(num2);
		}
		int num12 = -1;
		while (flag2 && (num12 == -1 || num12 == num11 || num12 == num10))
		{
			num12 = this.random_0.Next(num2);
		}
		for (int i = 0; i < num2; i++)
		{
			string string_0 = RecoveredRuntime.GenerateRandomSectionName(this);
			while (this.class154_0.GetSections().FindIndex((PeSectionHeader gclass5_0) => gclass5_0.GetName() == string_0) != -1)
			{
				string_0 = RecoveredRuntime.GenerateRandomSectionName(this);
			}
			PeSectionHeader gclass4 = new PeSectionHeader();
			gclass4.SetName(string_0);
			gclass4.SetCharacteristics(SectionCharacteristics.flag_33);
			gclass4.SetPointerToRawData(num8);
			gclass4.SetVirtualSize(this.random_0.NextUInt32(10u, 100u) * 50u);
			gclass4.SetVirtualAddress(num9);
			PeSectionHeader gclass5 = gclass4;
			uint uint_2 = this.class154_0.GetHeaders().GetOptionalHeader().GetFileAlignment();
			uint num14 = RecoveredRuntime.AlignUp(uint_, gclass5.GetVirtualSize());
			gclass5.SetSizeOfRawData(RecoveredRuntime.AlignUp(uint_2, num14));
			SectionCharacteristics[] array = new SectionCharacteristics[]
			{
				(SectionCharacteristics)2147483648u,
				SectionCharacteristics.flag_32,
				SectionCharacteristics.flag_28,
				SectionCharacteristics.flag_2
			};
			for (int j = 0; j < this.random_0.Next(array.Length); j++)
			{
				SectionCharacteristics @enum = array[this.random_0.Next(array.Length)];
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
			if (this.class131_0.CreateFakeDebugDirectory && num10 == i)
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
			this.class154_0.GetSections().Add(gclass5);
			num8 += gclass5.GetSizeOfRawData();
			num9 += num14;
		}
		PeSectionHeader gclass7 = this.class154_0.GetSections()[this.class154_0.GetSections().Count - 1];
		this.class154_0.GetHeaders().GetOptionalHeader().SetSizeOfImage(RecoveredRuntime.AlignUp(uint_, gclass7.GetVirtualAddress() + gclass7.GetVirtualSize()));
		this.class154_0.GetHeaders().GetCoffHeader().SetNumberOfSections((ushort)this.class154_0.GetSections().Count);
		this.class154_0.GetStream().Position = (long)((ulong)num8);
		this.binaryWriter_0.Write(buffer);
	}

	internal void BuildTlsCallbackSection(PeSectionHeader gclass5_0)
	{
		gclass5_0.SetCharacteristics((SectionCharacteristics)3758096384u);
		RecoveredRuntime.FillImageRangeWithRandomBytes(this, (long)((ulong)gclass5_0.GetPointerToRawData()), (long)((ulong)gclass5_0.GetSizeOfRawData()));
		DataDirectory @class = this.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[9];
		List<uint> list = new List<uint>();
		uint num = (uint)this.class154_0.GetHeaders().GetOptionalHeader().GetImageBase();
		uint num2 = num + gclass5_0.GetVirtualAddress();
		uint num3;
		uint num4;
		uint num5;
		uint num6;
		uint value;
		uint value2;
		if (this.class154_0.GetTlsDirectory() == null)
		{
			num3 = num + gclass5_0.GetVirtualAddress() + 24u;
			num4 = num3 + this.random_0.NextUInt32(1u, 5u) * 4u;
			num5 = num4 + this.random_0.NextUInt32(1u, 5u) * 4u;
			num6 = num5 + this.random_0.NextUInt32(1u, 5u) * 4u;
			uint num7 = 0u;
			value = 0u;
			value2 = num7;
			num2 = num6 + this.random_0.NextUInt32(2u, 5u) * 4u;
		}
		else
		{
			num3 = (uint)this.class154_0.GetTlsDirectory().GetStartAddressOfRawData();
			num4 = (uint)this.class154_0.GetTlsDirectory().GetEndAddressOfRawData();
			num5 = (uint)this.class154_0.GetTlsDirectory().GetAddressOfIndex();
			num6 = num + gclass5_0.GetVirtualAddress() + 24u;
			value2 = this.class154_0.GetTlsDirectory().GetSizeOfZeroFill();
			value = this.class154_0.GetTlsDirectory().GetCharacteristics();
			list.AddRange(Array.ConvertAll<ulong, uint>(this.class154_0.GetTlsDirectory().list_0.ToArray(), (ulong ulong_0) => (uint)ulong_0));
		}
		list.Add(num2);
		this.class154_0.GetStream().Position = (long)((ulong)(gclass5_0.GetPointerToRawData() + (num2 - num - gclass5_0.GetVirtualAddress())));
		this.binaryWriter_0.Write(new byte[]
		{
			144,
			144,
			144,
			194,
			12,
			0
		});
		@class.SetVirtualAddress(gclass5_0.GetVirtualAddress());
		@class.SetSize(24u);
		this.class154_0.GetStream().Position = (long)((ulong)gclass5_0.GetPointerToRawData());
		this.binaryWriter_0.Write(num3);
		this.binaryWriter_0.Write(num4);
		this.binaryWriter_0.Write(num5);
		this.binaryWriter_0.Write(num6);
		this.binaryWriter_0.Write(value2);
		this.binaryWriter_0.Write(value);
		this.class154_0.GetStream().Position = (long)((ulong)(gclass5_0.GetPointerToRawData() + (num6 - num - gclass5_0.GetVirtualAddress())));
		foreach (uint value3 in list)
		{
			this.binaryWriter_0.Write(value3);
		}
		this.binaryWriter_0.Write(0);
	}

	internal static T GenerateDifferentValue<T>(T gparam_0, Delegate48<T> delegate48_0)
	{
		T result = delegate48_0();
		while (result.Equals(gparam_0))
		{
			result = delegate48_0();
		}
		return result;
	}

	internal List<Class132> CreateSectionRemap()
	{
		List<PeScrambler.Class132> list = new List<PeScrambler.Class132>();
		uint num = this.random_0.NextUInt32(1u, 10u);
		uint num2 = num * this.class154_0.GetHeaders().GetOptionalHeader().GetSectionAlignment();
		uint num3 = RecoveredRuntime.Is32BitImage(this.class154_0) ? (this.random_0.NextUInt32(1u, num + 1u) * this.class154_0.GetHeaders().GetOptionalHeader().GetFileAlignment()) : 0u;
		uint num4 = 0u;
		uint num5 = this.class154_0.GetSections()[0].GetVirtualAddress() + num2;
		foreach (PeSectionHeader gclass in this.class154_0.GetSections())
		{
			PeScrambler.Class132 @class = new PeScrambler.Class132(gclass, num2, num3);
			@class.GetModifiedSection().SetVirtualAddress(num5);
			uint uint_ = num5 + @class.GetModifiedSection().GetVirtualSize();
			uint uint_2 = this.class154_0.GetHeaders().GetOptionalHeader().GetSectionAlignment();
			num5 = RecoveredRuntime.AlignUp(uint_2, uint_);
			if (gclass.GetSizeOfRawData() != 0u)
			{
				PeSectionHeader gclass2 = @class.GetModifiedSection();
				gclass2.SetPointerToRawData(gclass2.GetPointerToRawData() + num4);
				num4 += num3;
			}
			list.Add(@class);
		}
		List<PeScrambler.Class132> list2 = list;
		int index = 0;
		PeSectionHeader gclass3 = new PeSectionHeader();
		gclass3.SetCharacteristics(SectionCharacteristics.flag_33);
		gclass3.SetVirtualAddress(this.class154_0.GetSections()[0].GetVirtualAddress());
		gclass3.SetVirtualSize(num2);
		gclass3.SetName(RecoveredRuntime.GenerateRandomSectionName(this));
		list2.Insert(index, new PeScrambler.Class132(gclass3, 0u, 0u));
		return list;
	}

	internal void RemapImportDirectory(List<Class132> list_0)
	{
		if (this.class154_0.GetImports() == null)
		{
			return;
		}
		BinaryWriter binaryWriter = new BinaryWriter(this.class154_0.GetStream());
		this.class154_0.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(this.class154_0, this.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[1].GetVirtualAddress());
		foreach (ImportDescriptor @class in this.class154_0.GetImports().list_0)
		{
			binaryWriter.Write(RecoveredRuntime.RemapRva(list_0, @class.GetOriginalFirstThunk()));
			this.class154_0.GetStream().Position += 8L;
			binaryWriter.Write(RecoveredRuntime.RemapRva(list_0, @class.GetNameRva()));
			binaryWriter.Write(RecoveredRuntime.RemapRva(list_0, @class.GetFirstThunk()));
			long position = this.class154_0.GetStream().Position;
			this.class154_0.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(this.class154_0, @class.GetOriginalFirstThunk());
			foreach (ImportedSymbol class2 in @class.GetOriginalThunkSymbols())
			{
				if (!class2.GetIsOrdinal())
				{
					if (!RecoveredRuntime.Is32BitImage(this.class154_0))
					{
						BinaryWriter binaryWriter2 = binaryWriter;
						ulong num;
						class2.SetThunkValue(num = (ulong)RecoveredRuntime.RemapRva(list_0, (uint)class2.GetThunkValue()));
						binaryWriter2.Write(num);
					}
					else
					{
						BinaryWriter binaryWriter3 = binaryWriter;
						ulong num;
						class2.SetThunkValue(num = (ulong)RecoveredRuntime.RemapRva(list_0, (uint)class2.GetThunkValue()));
						binaryWriter3.Write((uint)num);
					}
				}
				else
				{
					this.class154_0.GetStream().Position += (RecoveredRuntime.Is32BitImage(this.class154_0) ? 4L : 8L);
				}
			}
			if (@class.GetFirstThunk() != @class.GetOriginalFirstThunk())
			{
				this.class154_0.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(this.class154_0, @class.GetFirstThunk());
				foreach (ImportedSymbol class3 in @class.GetFirstThunkSymbols())
				{
					if (!class3.GetIsOrdinal())
					{
						if (RecoveredRuntime.Is32BitImage(this.class154_0))
						{
							BinaryWriter binaryWriter4 = binaryWriter;
							ulong num;
							class3.SetThunkValue(num = (ulong)RecoveredRuntime.RemapRva(list_0, (uint)class3.GetThunkValue()));
							binaryWriter4.Write((uint)num);
						}
						else
						{
							BinaryWriter binaryWriter5 = binaryWriter;
							ulong num;
							class3.SetThunkValue(num = (ulong)RecoveredRuntime.RemapRva(list_0, (uint)class3.GetThunkValue()));
							binaryWriter5.Write(num);
						}
					}
					else
					{
						this.class154_0.GetStream().Position += (RecoveredRuntime.Is32BitImage(this.class154_0) ? 4L : 8L);
					}
				}
			}
			@class.SetOriginalFirstThunk(RecoveredRuntime.RemapRva(list_0, @class.GetOriginalFirstThunk()));
			@class.SetNameRva(RecoveredRuntime.RemapRva(list_0, @class.GetNameRva()));
			@class.SetFirstThunk(RecoveredRuntime.RemapRva(list_0, @class.GetFirstThunk()));
			this.class154_0.GetStream().Position = position;
		}
	}

	internal void RemapExceptionDirectory(List<Class132> list_0)
	{
		if (this.class154_0.GetExceptionDirectory() == null)
		{
			return;
		}
		BinaryWriter binaryWriter = new BinaryWriter(this.class154_0.GetStream());
		this.class154_0.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(this.class154_0, this.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[3].GetVirtualAddress());
		foreach (RuntimeFunctionEntry @class in this.class154_0.GetExceptionDirectory().list_0)
		{
			BinaryWriter binaryWriter2 = binaryWriter;
			uint value;
			@class.SetBeginAddress(value = RecoveredRuntime.RemapRva(list_0, @class.GetBeginAddress()));
			binaryWriter2.Write(value);
			BinaryWriter binaryWriter3 = binaryWriter;
			@class.SetEndAddress(value = RecoveredRuntime.RemapRva(list_0, @class.GetEndAddress()));
			binaryWriter3.Write(value);
			BinaryWriter binaryWriter4 = binaryWriter;
			@class.SetUnwindInfoAddress(value = RecoveredRuntime.RemapRva(list_0, @class.GetUnwindInfoAddress()));
			binaryWriter4.Write(value);
		}
	}

	internal void RemapBaseRelocations(List<Class132> list_0)
	{
		if (this.class154_0.GetBaseRelocations() == null)
		{
			return;
		}
		BinaryReader binaryReader = new BinaryReader(this.class154_0.GetStream());
		BinaryWriter binaryWriter = new BinaryWriter(this.class154_0.GetStream());
		long num = RecoveredRuntime.MapRvaToFileOffset(this.class154_0, this.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[5].GetVirtualAddress());
		ulong num2 = this.class154_0.GetHeaders().GetOptionalHeader().GetImageBase();
		foreach (BaseRelocationBlock @class in this.class154_0.GetBaseRelocations().list_0)
		{
			this.class154_0.GetStream().Position = num;
			binaryWriter.Write(RecoveredRuntime.RemapRva(list_0, @class.GetPageRva()));
			foreach (BaseRelocationEntry class2 in @class.list_0)
			{
				this.class154_0.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(this.class154_0, @class.GetPageRva() + class2.GetOffset());
				if (class2.GetRelocationType() == BaseRelocationType.HighLow)
				{
					uint num3 = binaryReader.ReadUInt32();
					this.class154_0.GetStream().Position -= 4L;
					binaryWriter.Write((uint)num2 + RecoveredRuntime.RemapRva(list_0, num3 - (uint)num2));
				}
				else if (class2.GetRelocationType() == BaseRelocationType.Dir64)
				{
					ulong num4 = binaryReader.ReadUInt64();
					this.class154_0.GetStream().Position -= 8L;
					binaryWriter.Write(num2 + (ulong)RecoveredRuntime.RemapRva(list_0, (uint)(num4 - num2)));
				}
			}
			@class.SetPageRva(RecoveredRuntime.RemapRva(list_0, @class.GetPageRva()));
			num += (long)((ulong)@class.GetBlockSize());
		}
	}

}
