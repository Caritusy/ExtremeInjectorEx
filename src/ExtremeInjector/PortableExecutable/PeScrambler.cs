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
		public uint method_0()
		{
			return uint_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(uint uint_2)
		{
			uint_0 = uint_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_2(uint uint_2)
		{
			uint_1 = uint_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public PeSectionHeader method_3()
		{
			return gclass5_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_4(PeSectionHeader gclass5_2)
		{
			gclass5_0 = gclass5_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public PeSectionHeader method_5()
		{
			return gclass5_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_6(PeSectionHeader gclass5_2)
		{
			gclass5_1 = gclass5_2;
		}

		public Class132(PeSectionHeader gclass5_2, uint uint_2, uint uint_3)
		{
			this.method_6(gclass5_2);
			this.method_2(uint_2);
			this.method_1(uint_3);
			PeSectionHeader gclass = new PeSectionHeader();
			gclass.method_19(gclass5_2.method_18());
			gclass.method_1(gclass5_2.method_0());
			gclass.method_17(gclass5_2.method_16());
			gclass.method_15(gclass5_2.method_14());
			gclass.method_13(gclass5_2.method_12());
			gclass.method_9(gclass5_2.method_8());
			gclass.method_11(gclass5_2.method_10());
			gclass.method_7(gclass5_2.method_6());
			gclass.method_5(gclass5_2.method_4() + uint_2);
			gclass.method_3(gclass5_2.method_2());
			this.method_4(gclass);
			if (this.method_3().method_2() != 0u && this.method_3().method_6() != 0u)
			{
				PeSectionHeader gclass2 = this.method_3();
				gclass2.method_3(gclass2.method_2() + uint_3);
			}
			if (this.method_3().method_6() != 0u)
			{
				PeSectionHeader gclass3 = this.method_3();
				gclass3.method_7(gclass3.method_6() + uint_3);
			}
		}
	}

	[CompilerGenerated]
	public sealed class Class133
	{
		public string string_0;

		internal bool method_0(PeSectionHeader gclass5_0)
		{
			return gclass5_0.method_0() == string_0;
		}

		internal static bool smethod_0(string string_1, string string_2)
		{
			return string_1 == string_2;
		}
	}

	[CompilerGenerated]
	public sealed class Class134
	{
		public string string_0;

		internal bool method_0(PeSectionHeader gclass5_0)
		{
			return gclass5_0.method_0() == string_0;
		}

		internal static bool smethod_0(string string_1, string string_2)
		{
			return string_1 == string_2;
		}
	}

	[Serializable]
	[CompilerGenerated]
	public sealed class Class135
	{
		public static readonly Class135 _003C_003E9 = new Class135();

		public static Converter<ulong, uint> _003C_003E9__36_0;

		public static Func<Class132, PeSectionHeader> _003C_003E9__53_0;

		internal uint method_0(ulong ulong_0)
		{
			return (uint)ulong_0;
		}

		internal PeSectionHeader method_1(Class132 class132_0)
		{
			return class132_0.method_3();
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
				foreach (ResourceDirectoryNode item in this.class138_3.method_6())
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

		internal static Thread smethod_0()
		{
			return Thread.CurrentThread;
		}

		internal static int smethod_1(Thread thread_0)
		{
			return thread_0.ManagedThreadId;
		}

		internal static NotSupportedException smethod_2()
		{
			return new NotSupportedException();
		}
	}

	internal readonly PeImage class154_0;

	internal readonly Random random_0 = new Random();

	internal readonly BinaryWriter binaryWriter_0;

	internal readonly PeScrambleOptions class131_0;

	public PeScrambler(PeImage class154_1, PeScrambleOptions class131_1)
	{
		MemoryStream memoryStream = new MemoryStream();
		class154_1.method_28().Position = 0L;
		class154_1.method_28().smethod_6(memoryStream);
		memoryStream.Position = 0L;
		class154_0 = PeImageReader.smethod_4(memoryStream, bool_0: true, PeImageLayout.const_0);
		binaryWriter_0 = new BinaryWriter(class154_0.method_28());
		class131_0 = class131_1;
	}

	internal void method_0()
	{
		foreach (PeSectionHeader gclass in this.class154_0.method_8())
		{
			gclass.method_19(gclass.method_18() & ~(SectionCharacteristics.flag_1 | SectionCharacteristics.flag_2 | SectionCharacteristics.flag_3));
		}
	}

	internal void method_1()
	{
		RecoveredRuntime.smethod_107(this);
		foreach (PeSectionHeader gclass in this.class154_0.method_8())
		{
			string string_ = RecoveredRuntime.smethod_273(this);
			string string_0 = RecoveredRuntime.smethod_273(this);
			while (this.class154_0.method_8().FindIndex((PeSectionHeader gclass5_0) => gclass5_0.method_0() == string_0) != -1)
			{
				string_0 = RecoveredRuntime.smethod_273(this);
			}
			gclass.method_1(string_);
		}
	}

	internal void method_2()
	{
		uint num = 0u;
		foreach (PeSectionHeader gclass in this.class154_0.method_8())
		{
			if (gclass.method_8() != 0u)
			{
				if (num == 0u)
				{
					byte[] buffer;
					using (Stream stream = RecoveredRuntime.smethod_264(this.class154_0, (long)((ulong)gclass.method_8()), (int)(this.class154_0.method_28().Length - (long)((ulong)gclass.method_8()))))
					{
						using (BinaryReader binaryReader = new BinaryReader(stream))
						{
							buffer = binaryReader.ReadBytes((int)stream.Length);
						}
					}
					num = this.random_0.smethod_1(5u, 40u) * this.class154_0.method_6().method_3().imethod_19();
					RecoveredRuntime.smethod_437(this, (long)((ulong)gclass.method_8()), (long)((ulong)num));
					this.class154_0.method_28().Position = (long)((ulong)(gclass.method_8() + num));
					this.binaryWriter_0.Write(buffer);
				}
				PeSectionHeader gclass2 = gclass;
				gclass2.method_9(gclass2.method_8() + num);
			}
		}
	}

	internal void method_3()
	{
		foreach (PeSectionHeader gclass in this.class154_0.method_8())
		{
			if (gclass.method_8() != 0u && gclass.method_6() != 0u && gclass.method_2() != 0u && (gclass.method_18() & SectionCharacteristics.flag_32) == SectionCharacteristics.flag_32)
			{
				using (Stream stream = RecoveredRuntime.smethod_264(this.class154_0, (long)((ulong)gclass.method_8()), (int)gclass.method_6()))
				{
					using (BinaryReader binaryReader = new BinaryReader(stream))
					{
						this.class154_0.method_28().Position = (long)((ulong)gclass.method_8());
						byte[] array = binaryReader.ReadBytes((int)gclass.method_6());
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
									dictionary.Add((long)((ulong)gclass.method_8() + (ulong)((long)i)), num);
								}
								i += num;
								num = 0;
							}
						}
						foreach (KeyValuePair<long, int> keyValuePair in dictionary)
						{
							RecoveredRuntime.smethod_437(this, keyValuePair.Key, (long)keyValuePair.Value);
						}
					}
				}
			}
		}
	}

	void IDisposable.Dispose()
	{
		binaryWriter_0.Close();
		class154_0.System_002EIDisposable_002EDispose();
	}

	internal void method_4()
	{
		RecoveredRuntime.smethod_107(this);
		bool flag = this.class131_0.method_14() && this.class154_0.method_6().method_3().imethod_49()[5].method_0() != 0u && this.class154_0.method_6().method_3().imethod_49()[5].method_2() > 0u;
		bool flag2 = this.class131_0.method_20() && RecoveredRuntime.smethod_19(this.class154_0) && this.class154_0.method_6().method_3().imethod_11() > 0u;
		bool flag3 = RecoveredRuntime.smethod_19(this.class154_0) && this.class131_0.method_22();
		int num = 1;
		if (flag)
		{
			num++;
		}
		if (flag2)
		{
			num++;
		}
		if (flag3)
		{
			num++;
		}
		int num2 = this.random_0.Next(num, 10);
		int num3 = num2 * 40;
		uint num4 = uint.MaxValue;
		foreach (PeSectionHeader gclass in this.class154_0.method_8())
		{
			if (gclass.method_8() != 0u && gclass.method_8() < num4)
			{
				num4 = gclass.method_8();
			}
		}
		if (num4 == 4294967295u)
		{
			return;
		}
		uint num5 = (uint)((ulong)(this.class154_0.method_4().method_0() + 24u + (uint)this.class154_0.method_6().method_1().method_10()) + (ulong)((long)(this.class154_0.method_8().Count * 40)));
		uint num6 = num4;
		uint num7 = num4 - num5;
		while ((ulong)num7 < (ulong)((long)num3))
		{
			num6 += this.class154_0.method_6().method_3().imethod_18();
			num7 += this.class154_0.method_6().method_3().imethod_18();
		}
		byte[] buffer;
		using (Stream stream = RecoveredRuntime.smethod_264(this.class154_0, (long)((ulong)num4), (int)(this.class154_0.method_28().Length - (long)((ulong)num4))))
		{
			using (BinaryReader binaryReader = new BinaryReader(stream))
			{
				buffer = binaryReader.ReadBytes((int)stream.Length);
			}
		}
		RecoveredRuntime.smethod_377(this, (long)((ulong)num5), (long)((ulong)(num6 - num5)));
		this.class154_0.method_28().Position = (long)((ulong)num6);
		this.binaryWriter_0.Write(buffer);
		uint num8 = 0u;
		uint num9 = 0u;
		foreach (PeSectionHeader gclass2 in this.class154_0.method_8())
		{
			if (gclass2.method_8() != 0u)
			{
				PeSectionHeader gclass3 = gclass2;
				gclass3.method_9(gclass3.method_8() + (num6 - num4));
			}
			if (gclass2.method_8() + gclass2.method_6() > num8)
			{
				num8 = gclass2.method_8() + gclass2.method_6();
				num9 = gclass2.method_4() + gclass2.method_2();
			}
		}
		buffer = new byte[0];
		if ((ulong)num8 < (ulong)this.class154_0.method_28().Length)
		{
			using (Stream stream2 = RecoveredRuntime.smethod_264(this.class154_0, (long)((ulong)num8), (int)(this.class154_0.method_28().Length - (long)((ulong)num8))))
			{
				using (BinaryReader binaryReader2 = new BinaryReader(stream2))
				{
					buffer = binaryReader2.ReadBytes((int)stream2.Length);
				}
			}
		}
		uint uint_ = this.class154_0.method_6().method_3().imethod_18();
		num9 = RecoveredRuntime.smethod_201(uint_, num9);
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
		int num13 = -1;
		while (flag3 && (num13 == -1 || num13 == num11 || num13 == num10 || num13 == num12))
		{
			num13 = this.random_0.Next(num2);
		}
		for (int i = 0; i < num2; i++)
		{
			string string_0 = RecoveredRuntime.smethod_273(this);
			while (this.class154_0.method_8().FindIndex((PeSectionHeader gclass5_0) => gclass5_0.method_0() == string_0) != -1)
			{
				string_0 = RecoveredRuntime.smethod_273(this);
			}
			PeSectionHeader gclass4 = new PeSectionHeader();
			gclass4.method_1(string_0);
			gclass4.method_19(SectionCharacteristics.flag_33);
			gclass4.method_9(num8);
			gclass4.method_3(this.random_0.smethod_1(10u, 100u) * 50u);
			gclass4.method_5(num9);
			PeSectionHeader gclass5 = gclass4;
			uint uint_2 = this.class154_0.method_6().method_3().imethod_19();
			uint num14 = RecoveredRuntime.smethod_201(uint_, gclass5.method_2());
			gclass5.method_7(RecoveredRuntime.smethod_201(uint_2, num14));
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
				if ((gclass5.method_18() & @enum) == @enum)
				{
					j--;
				}
				else
				{
					PeSectionHeader gclass6 = gclass5;
					gclass6.method_19(gclass6.method_18() | @enum);
				}
			}
			RecoveredRuntime.smethod_437(this, (long)((ulong)gclass5.method_8()), (long)((ulong)gclass5.method_6()));
			if (this.class131_0.method_6() && num10 == i)
			{
				RecoveredRuntime.smethod_41(gclass5, this);
			}
			if (flag && num11 == i)
			{
				RecoveredRuntime.smethod_304(this, gclass5);
			}
			if (flag2 && num12 == i)
			{
				RecoveredRuntime.smethod_284(this, gclass5);
			}
			if (flag3 && num13 == i)
			{
				this.method_5(gclass5);
			}
			this.class154_0.method_8().Add(gclass5);
			num8 += gclass5.method_6();
			num9 += num14;
		}
		PeSectionHeader gclass7 = this.class154_0.method_8()[this.class154_0.method_8().Count - 1];
		this.class154_0.method_6().method_3().imethod_30(RecoveredRuntime.smethod_201(uint_, gclass7.method_4() + gclass7.method_2()));
		this.class154_0.method_6().method_1().method_3((ushort)this.class154_0.method_8().Count);
		this.class154_0.method_28().Position = (long)((ulong)num8);
		this.binaryWriter_0.Write(buffer);
	}

	internal void method_5(PeSectionHeader gclass5_0)
	{
		gclass5_0.method_19((SectionCharacteristics)3758096384u);
		RecoveredRuntime.smethod_437(this, (long)((ulong)gclass5_0.method_8()), (long)((ulong)gclass5_0.method_6()));
		DataDirectory @class = this.class154_0.method_6().method_3().imethod_49()[9];
		List<uint> list = new List<uint>();
		uint num = (uint)this.class154_0.method_6().method_3().imethod_17();
		uint num2 = num + gclass5_0.method_4();
		uint num3;
		uint num4;
		uint num5;
		uint num6;
		uint value;
		uint value2;
		if (this.class154_0.method_20() == null)
		{
			num3 = num + gclass5_0.method_4() + 24u;
			num4 = num3 + this.random_0.smethod_1(1u, 5u) * 4u;
			num5 = num4 + this.random_0.smethod_1(1u, 5u) * 4u;
			num6 = num5 + this.random_0.smethod_1(1u, 5u) * 4u;
			uint num7 = 0u;
			value = 0u;
			value2 = num7;
			num2 = num6 + this.random_0.smethod_1(2u, 5u) * 4u;
		}
		else
		{
			num3 = (uint)this.class154_0.method_20().method_0();
			num4 = (uint)this.class154_0.method_20().method_2();
			num5 = (uint)this.class154_0.method_20().method_4();
			num6 = num + gclass5_0.method_4() + 24u;
			value2 = this.class154_0.method_20().method_8();
			value = this.class154_0.method_20().method_10();
			list.AddRange(Array.ConvertAll<ulong, uint>(this.class154_0.method_20().list_0.ToArray(), (ulong ulong_0) => (uint)ulong_0));
		}
		list.Add(num2);
		this.class154_0.method_28().Position = (long)((ulong)(gclass5_0.method_8() + (num2 - num - gclass5_0.method_4())));
		this.binaryWriter_0.Write(new byte[]
		{
			144,
			144,
			144,
			194,
			12,
			0
		});
		@class.method_1(gclass5_0.method_4());
		@class.method_3(24u);
		this.class154_0.method_28().Position = (long)((ulong)gclass5_0.method_8());
		this.binaryWriter_0.Write(num3);
		this.binaryWriter_0.Write(num4);
		this.binaryWriter_0.Write(num5);
		this.binaryWriter_0.Write(num6);
		this.binaryWriter_0.Write(value2);
		this.binaryWriter_0.Write(value);
		this.class154_0.method_28().Position = (long)((ulong)(gclass5_0.method_8() + (num6 - num - gclass5_0.method_4())));
		foreach (uint value3 in list)
		{
			this.binaryWriter_0.Write(value3);
		}
		this.binaryWriter_0.Write(0);
	}

	internal static T smethod_0<T>(T gparam_0, Delegate48<T> delegate48_0)
	{
		T result = delegate48_0();
		while (result.Equals(gparam_0))
		{
			result = delegate48_0();
		}
		return result;
	}

	internal List<Class132> method_6()
	{
		List<PeScrambler.Class132> list = new List<PeScrambler.Class132>();
		uint num = this.random_0.smethod_1(1u, 10u);
		uint num2 = num * this.class154_0.method_6().method_3().imethod_18();
		uint num3 = RecoveredRuntime.smethod_19(this.class154_0) ? (this.random_0.smethod_1(1u, num + 1u) * this.class154_0.method_6().method_3().imethod_19()) : 0u;
		uint num4 = 0u;
		uint num5 = this.class154_0.method_8()[0].method_4() + num2;
		foreach (PeSectionHeader gclass in this.class154_0.method_8())
		{
			PeScrambler.Class132 @class = new PeScrambler.Class132(gclass, num2, num3);
			@class.method_3().method_5(num5);
			uint uint_ = num5 + @class.method_3().method_2();
			uint uint_2 = this.class154_0.method_6().method_3().imethod_18();
			num5 = RecoveredRuntime.smethod_201(uint_2, uint_);
			if (gclass.method_6() != 0u)
			{
				PeSectionHeader gclass2 = @class.method_3();
				gclass2.method_9(gclass2.method_8() + num4);
				num4 += num3;
			}
			list.Add(@class);
		}
		List<PeScrambler.Class132> list2 = list;
		int index = 0;
		PeSectionHeader gclass3 = new PeSectionHeader();
		gclass3.method_19(SectionCharacteristics.flag_33);
		gclass3.method_5(this.class154_0.method_8()[0].method_4());
		gclass3.method_3(num2);
		gclass3.method_1(RecoveredRuntime.smethod_273(this));
		list2.Insert(index, new PeScrambler.Class132(gclass3, 0u, 0u));
		return list;
	}

	internal void method_7(List<Class132> list_0)
	{
		if (this.class154_0.method_10() == null)
		{
			return;
		}
		BinaryWriter binaryWriter = new BinaryWriter(this.class154_0.method_28());
		this.class154_0.method_28().Position = RecoveredRuntime.smethod_135(this.class154_0, this.class154_0.method_6().method_3().imethod_49()[1].method_0());
		foreach (ImportDescriptor @class in this.class154_0.method_10().list_0)
		{
			binaryWriter.Write(RecoveredRuntime.smethod_33(list_0, @class.method_0()));
			this.class154_0.method_28().Position += 8L;
			binaryWriter.Write(RecoveredRuntime.smethod_33(list_0, @class.method_4()));
			binaryWriter.Write(RecoveredRuntime.smethod_33(list_0, @class.method_6()));
			long position = this.class154_0.method_28().Position;
			this.class154_0.method_28().Position = RecoveredRuntime.smethod_135(this.class154_0, @class.method_0());
			foreach (ImportedSymbol class2 in @class.method_8())
			{
				if (!class2.method_7())
				{
					if (!RecoveredRuntime.smethod_19(this.class154_0))
					{
						BinaryWriter binaryWriter2 = binaryWriter;
						ulong num;
						class2.method_1(num = (ulong)RecoveredRuntime.smethod_33(list_0, (uint)class2.method_0()));
						binaryWriter2.Write(num);
					}
					else
					{
						BinaryWriter binaryWriter3 = binaryWriter;
						ulong num;
						class2.method_1(num = (ulong)RecoveredRuntime.smethod_33(list_0, (uint)class2.method_0()));
						binaryWriter3.Write((uint)num);
					}
				}
				else
				{
					this.class154_0.method_28().Position += (RecoveredRuntime.smethod_19(this.class154_0) ? 4L : 8L);
				}
			}
			if (@class.method_6() != @class.method_0())
			{
				this.class154_0.method_28().Position = RecoveredRuntime.smethod_135(this.class154_0, @class.method_6());
				foreach (ImportedSymbol class3 in @class.method_10())
				{
					if (!class3.method_7())
					{
						if (RecoveredRuntime.smethod_19(this.class154_0))
						{
							BinaryWriter binaryWriter4 = binaryWriter;
							ulong num;
							class3.method_1(num = (ulong)RecoveredRuntime.smethod_33(list_0, (uint)class3.method_0()));
							binaryWriter4.Write((uint)num);
						}
						else
						{
							BinaryWriter binaryWriter5 = binaryWriter;
							ulong num;
							class3.method_1(num = (ulong)RecoveredRuntime.smethod_33(list_0, (uint)class3.method_0()));
							binaryWriter5.Write(num);
						}
					}
					else
					{
						this.class154_0.method_28().Position += (RecoveredRuntime.smethod_19(this.class154_0) ? 4L : 8L);
					}
				}
			}
			@class.method_1(RecoveredRuntime.smethod_33(list_0, @class.method_0()));
			@class.method_5(RecoveredRuntime.smethod_33(list_0, @class.method_4()));
			@class.method_7(RecoveredRuntime.smethod_33(list_0, @class.method_6()));
			this.class154_0.method_28().Position = position;
		}
	}

	internal void method_8(List<Class132> list_0)
	{
		if (this.class154_0.method_25() == null)
		{
			return;
		}
		BinaryWriter binaryWriter = new BinaryWriter(this.class154_0.method_28());
		this.class154_0.method_28().Position = RecoveredRuntime.smethod_135(this.class154_0, this.class154_0.method_6().method_3().imethod_49()[3].method_0());
		foreach (RuntimeFunctionEntry @class in this.class154_0.method_25().list_0)
		{
			BinaryWriter binaryWriter2 = binaryWriter;
			uint value;
			@class.method_1(value = RecoveredRuntime.smethod_33(list_0, @class.method_0()));
			binaryWriter2.Write(value);
			BinaryWriter binaryWriter3 = binaryWriter;
			@class.method_3(value = RecoveredRuntime.smethod_33(list_0, @class.method_2()));
			binaryWriter3.Write(value);
			BinaryWriter binaryWriter4 = binaryWriter;
			@class.method_5(value = RecoveredRuntime.smethod_33(list_0, @class.method_4()));
			binaryWriter4.Write(value);
		}
	}

	internal void method_9(List<Class132> list_0)
	{
		if (this.class154_0.method_16() == null)
		{
			return;
		}
		BinaryReader binaryReader = new BinaryReader(this.class154_0.method_28());
		BinaryWriter binaryWriter = new BinaryWriter(this.class154_0.method_28());
		long num = RecoveredRuntime.smethod_135(this.class154_0, this.class154_0.method_6().method_3().imethod_49()[5].method_0());
		ulong num2 = this.class154_0.method_6().method_3().imethod_17();
		foreach (BaseRelocationBlock @class in this.class154_0.method_16().list_0)
		{
			this.class154_0.method_28().Position = num;
			binaryWriter.Write(RecoveredRuntime.smethod_33(list_0, @class.method_0()));
			foreach (BaseRelocationEntry class2 in @class.list_0)
			{
				this.class154_0.method_28().Position = RecoveredRuntime.smethod_135(this.class154_0, @class.method_0() + class2.method_0());
				if (class2.method_2() == BaseRelocationType.HighLow)
				{
					uint num3 = binaryReader.ReadUInt32();
					this.class154_0.method_28().Position -= 4L;
					binaryWriter.Write((uint)num2 + RecoveredRuntime.smethod_33(list_0, num3 - (uint)num2));
				}
				else if (class2.method_2() == BaseRelocationType.Dir64)
				{
					ulong num4 = binaryReader.ReadUInt64();
					this.class154_0.method_28().Position -= 8L;
					binaryWriter.Write(num2 + (ulong)RecoveredRuntime.smethod_33(list_0, (uint)(num4 - num2)));
				}
			}
			@class.method_1(RecoveredRuntime.smethod_33(list_0, @class.method_0()));
			num += (long)((ulong)@class.method_2());
		}
	}

	[CompilerGenerated]
	internal int method_10()
	{
		return random_0.Next(53);
	}

	[CompilerGenerated]
	internal uint method_11()
	{
		return random_0.smethod_0();
	}

	[CompilerGenerated]
	internal uint method_12()
	{
		return random_0.smethod_0();
	}

	[CompilerGenerated]
	internal uint method_13()
	{
		return random_0.smethod_0();
	}

	[CompilerGenerated]
	internal uint method_14()
	{
		return random_0.smethod_0();
	}

	[CompilerGenerated]
	internal uint method_15()
	{
		return random_0.smethod_0();
	}

	[CompilerGenerated]
	internal uint method_16()
	{
		return random_0.smethod_0();
	}

	[CompilerGenerated]
	internal uint method_17()
	{
		return random_0.smethod_0();
	}

	internal static Random smethod_1()
	{
		return new Random();
	}

	internal static MemoryStream smethod_2()
	{
		return new MemoryStream();
	}

	internal static void smethod_3(Stream stream_0, long long_0)
	{
		stream_0.Position = long_0;
	}

	internal static BinaryWriter smethod_4(Stream stream_0)
	{
		return new BinaryWriter(stream_0);
	}

	internal static long smethod_5(Stream stream_0)
	{
		return stream_0.Length;
	}

	internal static BinaryReader smethod_6(Stream stream_0)
	{
		return new BinaryReader(stream_0);
	}

	internal static byte[] smethod_7(BinaryReader binaryReader_0, int int_0)
	{
		return binaryReader_0.ReadBytes(int_0);
	}

	internal static void smethod_8(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static void smethod_9(BinaryWriter binaryWriter_1, byte[] byte_0)
	{
		binaryWriter_1.Write(byte_0);
	}

	internal static void smethod_10(BinaryWriter binaryWriter_1)
	{
		binaryWriter_1.Close();
	}

	internal static int smethod_11(Random random_1, int int_0, int int_1)
	{
		return random_1.Next(int_0, int_1);
	}

	internal static int smethod_12(Random random_1, int int_0)
	{
		return random_1.Next(int_0);
	}

	internal static void smethod_13(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	internal static void smethod_14(BinaryWriter binaryWriter_1, uint uint_0)
	{
		binaryWriter_1.Write(uint_0);
	}

	internal static void smethod_15(BinaryWriter binaryWriter_1, int int_0)
	{
		binaryWriter_1.Write(int_0);
	}

	internal static long smethod_16(Stream stream_0)
	{
		return stream_0.Position;
	}

	internal static void smethod_17(BinaryWriter binaryWriter_1, ulong ulong_0)
	{
		binaryWriter_1.Write(ulong_0);
	}

	internal static uint smethod_18(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static ulong smethod_19(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt64();
	}
}
