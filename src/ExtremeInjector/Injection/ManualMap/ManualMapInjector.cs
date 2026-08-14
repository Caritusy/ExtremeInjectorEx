using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public sealed class ManualMapInjector(RemoteProcess gclass2_1) : DllInjector(gclass2_1)
{
	[Flags]
	public enum Enum44
	{
		flag_0 = 1,
		flag_1 = 2,
		flag_2 = 4,
		flag_3 = 8,
		flag_4 = 0x10,
		flag_5 = 0x20,
		flag_6 = 0x40,
		flag_7 = 0x80
	}

	public sealed class Class172
	{
		[CompilerGenerated]
		internal PeImage class154_0;

		[CompilerGenerated]
		internal IntPtr intptr_0;

		[CompilerGenerated]
		internal string string_0;

		[CompilerGenerated]
		internal string string_1;

		[CompilerGenerated]
		internal Enum44 enum44_0;

		[CompilerGenerated]
		internal IntPtr intptr_1;

		[CompilerGenerated]
		internal IntPtr intptr_2;

		[CompilerGenerated]
		internal List<int> list_0;

		[SpecialName]
		[CompilerGenerated]
		public PeImage method_0()
		{
			return class154_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(PeImage class154_1)
		{
			class154_0 = class154_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public IntPtr method_2()
		{
			return intptr_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_3(IntPtr intptr_3)
		{
			intptr_0 = intptr_3;
		}

		[SpecialName]
		[CompilerGenerated]
		public string method_4()
		{
			return string_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_5(string string_2)
		{
			string_0 = string_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public string method_6()
		{
			return string_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_7(string string_2)
		{
			string_1 = string_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public Enum44 method_8()
		{
			return enum44_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_9(Enum44 enum44_1)
		{
			enum44_0 = enum44_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public IntPtr method_10()
		{
			return intptr_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_11(IntPtr intptr_3)
		{
			intptr_1 = intptr_3;
		}

		[SpecialName]
		[CompilerGenerated]
		public IntPtr method_12()
		{
			return intptr_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_13(IntPtr intptr_3)
		{
			intptr_2 = intptr_3;
		}

		[SpecialName]
		[CompilerGenerated]
		public List<int> method_14()
		{
			return list_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_15(List<int> list_1)
		{
			list_0 = list_1;
		}

		public Class172()
		{
			IntPtr intptr_;
			method_13(intptr_ = NativeTypes.intptr_0);
			method_11(intptr_);
			method_15(new List<int>());
		}
	}

	[CompilerGenerated]
	internal bool bool_2;

	[CompilerGenerated]
	internal bool bool_3;

	[CompilerGenerated]
	internal bool bool_4;

	[CompilerGenerated]
	internal bool bool_5;

	[CompilerGenerated]
	internal bool bool_6;

	[CompilerGenerated]
	internal Exception exception_0;

	internal static readonly NativeTypes.Enum34[][][] enum34_0 = new NativeTypes.Enum34[2][][]
	{
		new NativeTypes.Enum34[2][]
		{
			new NativeTypes.Enum34[2]
			{
				NativeTypes.Enum34.flag_4,
				NativeTypes.Enum34.flag_7
			},
			new NativeTypes.Enum34[2]
			{
				NativeTypes.Enum34.flag_5,
				NativeTypes.Enum34.flag_6
			}
		},
		new NativeTypes.Enum34[2][]
		{
			new NativeTypes.Enum34[2]
			{
				NativeTypes.Enum34.flag_0,
				NativeTypes.Enum34.flag_3
			},
			new NativeTypes.Enum34[2]
			{
				NativeTypes.Enum34.flag_1,
				NativeTypes.Enum34.flag_2
			}
		}
	};

	internal List<Class172> list_0 = new List<Class172>();

	[SpecialName]
	[CompilerGenerated]
	public bool method_24()
	{
		return bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_25(bool bool_7)
	{
		bool_2 = bool_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_26()
	{
		return bool_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_27(bool bool_7)
	{
		bool_3 = bool_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_28()
	{
		return bool_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_29(bool bool_7)
	{
		bool_4 = bool_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_30()
	{
		return bool_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_31(bool bool_7)
	{
		bool_5 = bool_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_32()
	{
		return bool_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_33(bool bool_7)
	{
		bool_6 = bool_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public Exception method_34()
	{
		return exception_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_35(Exception exception_1)
	{
		exception_0 = exception_1;
	}

	protected override void method_04C6()
	{
		if (base.method_2() == IntPtr.Zero && base.method_0() != -1)
		{
			base.method_3(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_2 | NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, base.method_0()));
		}
	}

	public override IntPtr Inject(string string_0)
	{
		this.method_35(null);
		if (!Path.IsPathRooted(string_0))
		{
			string_0 = Path.GetFullPath(string_0);
		}
		ManualMapInjector.Enum44 enum44_ = RecoveredRuntime.smethod_206(this);
		return this.method_36(string_0, enum44_);
	}

	internal IntPtr method_36(string string_0, Enum44 enum44_0)
	{
		if (!File.Exists(string_0))
		{
			RecoveredRuntime.smethod_259(this);
			throw new FileNotFoundException(EncodedStringTable.smethod_0(28151) + string_0 + EncodedStringTable.smethod_0(3656));
		}
		if (!base.method_8(base.method_19().ProcessId))
		{
			RecoveredRuntime.smethod_259(this);
			throw new UnauthorizedAccessException(EncodedStringTable.smethod_0(12662));
		}
		if (!base.method_19().IsDepEnabled)
		{
			enum44_0 |= ManualMapInjector.Enum44.flag_1;
		}
		IntPtr intPtr = this.method_38(string_0, enum44_0);
		if (!(intPtr == IntPtr.Zero))
		{
			foreach (ManualMapInjector.Class172 @class in this.list_0)
			{
				if (!this.method_37(@class, 1u))
				{
					RecoveredRuntime.smethod_368(@class);
					return IntPtr.Zero;
				}
				if (this.method_26())
				{
					uint num = @class.method_0().method_6().method_3().imethod_31();
					if (!this.vmethod_5(@class.method_2(), (long)((ulong)num), NativeTypes.Enum28.const_1))
					{
						base.method_14(@class.method_2(), (long)((ulong)num), NativeTypes.Enum34.flag_4);
					}
					RecoveredRuntime.smethod_368(@class);
				}
				else
				{
					RecoveredRuntime.smethod_368(@class);
				}
			}
			this.list_0.Clear();
			return intPtr;
		}
		RecoveredRuntime.smethod_259(this);
		return IntPtr.Zero;
	}

	internal bool method_37(Class172 class172_0, uint uint_0)
	{
		ProcessModuleInfo gclass = RecoveredRuntime.smethod_42(base.method_19())[EncodedStringTable.smethod_0(8549)];
		if (gclass != null)
		{
			IntPtr intptr_ = RecoveredRuntime.smethod_225(gclass, EncodedStringTable.smethod_0(29026), false);
			IntPtr intptr_2 = RecoveredRuntime.smethod_225(gclass, EncodedStringTable.smethod_0(29067), false);
			AsmJitAssembler @class = new AsmJitAssembler();
			RemoteAssembler class47_ = new RemoteAssembler(@class, base.method_19());
			AsmJitLabel class58_ = RecoveredRuntime.smethod_48(@class);
			AsmJitGpRegister class2 = RecoveredRuntime.smethod_427(base.method_19()) ? AsmJitRuntime.class63_37 : AsmJitRuntime.class63_53;
			RecoveredRuntime.smethod_15(class47_);
			if (class172_0.method_12() != NativeTypes.intptr_0)
			{
				RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(intptr_), CallingConvention.StdCall, new object[]
				{
					IntPtr.Zero,
					class172_0.method_12(),
					RecoveredRuntime.smethod_84(class47_, class58_)
				});
			}
			uint num = class172_0.method_0().method_6().method_3().imethod_11();
			if (uint_0 != 1u && uint_0 != 2u)
			{
				if (num != 0u)
				{
					RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(class172_0.method_2().smethod_9((long)((ulong)num))), CallingConvention.StdCall, new object[]
					{
						class172_0.method_2(),
						uint_0,
						IntPtr.Zero
					});
				}
				foreach (int callback in class172_0.method_14())
				{
					RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(class172_0.method_2().smethod_8(callback)), CallingConvention.StdCall, new object[]
					{
						class172_0.method_2(),
						uint_0,
						IntPtr.Zero
					});
				}
			}
			else
			{
				foreach (int callback in class172_0.method_14())
				{
					RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(class172_0.method_2().smethod_8(callback)), CallingConvention.StdCall, new object[]
					{
						class172_0.method_2(),
						uint_0,
						IntPtr.Zero
					});
				}
				if (num != 0u)
				{
					RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(class172_0.method_2().smethod_9((long)((ulong)num))), CallingConvention.StdCall, new object[]
					{
						class172_0.method_2(),
						uint_0,
						IntPtr.Zero
					});
				}
			}
			if (class172_0.method_12() != NativeTypes.intptr_0)
			{
				RecoveredRuntime.smethod_429(@class, class2, RecoveredRuntime.smethod_221(class47_, class58_, 0L));
				RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(intptr_2), CallingConvention.StdCall, new object[]
				{
					IntPtr.Zero,
					class2
				});
			}
			RecoveredRuntime.smethod_226(class47_, -1);
			RecoveredRuntime.smethod_227(class47_);
			RecoveredRuntime.smethod_36(@class, class58_);
			RecoveredRuntime.smethod_336(class47_);
			return RecoveredRuntime.smethod_239(@class, this) || RecoveredRuntime.smethod_128(this, new AccessViolationException(EncodedStringTable.smethod_0(29108)));
		}
		return RecoveredRuntime.smethod_128(this, new FileNotFoundException(EncodedStringTable.smethod_0(12731)));
	}

	internal IntPtr method_38(string string_0, Enum44 enum44_0)
	{
		ManualMapInjector.Class172 @class = new ManualMapInjector.Class172();
		@class.method_5(string_0);
		@class.method_7(Path.GetFileName(string_0));
		@class.method_9(enum44_0);
		@class.method_3(RecoveredRuntime.smethod_42(base.method_19()).method_0(string_0));
		ManualMapInjector.Class172 class2 = @class;
		if (class2.method_2() != IntPtr.Zero)
		{
			return class2.method_2();
		}
		try
		{
			class2.method_1(RecoveredRuntime.smethod_81(PeImageLayout.const_0, string_0));
			if (class2.method_0() == null)
			{
				return IntPtr.Zero;
			}
		}
		catch (Exception)
		{
			return IntPtr.Zero;
		}
		class2.method_3(base.method_15((IntPtr)((long)class2.method_0().method_6().method_3().imethod_17()), (long)((ulong)class2.method_0().method_6().method_3().imethod_29()), NativeTypes.Enum34.flag_2));
		if (class2.method_2() == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		PeImage class3 = class2.method_0();
		IntPtr intptr_ = class2.method_2();
		RecoveredRuntime.smethod_242(this, class2);
		if ((enum44_0 & ManualMapInjector.Enum44.flag_6) == (ManualMapInjector.Enum44)0 && !RecoveredRuntime.smethod_26(this, class2))
		{
			RecoveredRuntime.smethod_368(class2);
			this.vmethod_6(class2.method_2());
			return IntPtr.Zero;
		}
		if (!this.method_44(class2) || !this.method_43(class2))
		{
			RecoveredRuntime.smethod_368(class2);
			this.vmethod_6(class2.method_2());
			return IntPtr.Zero;
		}
		RecoveredRuntime.smethod_266(RecoveredRuntime.smethod_42(base.method_19()), class3, intptr_, RecoveredRuntime.smethod_427(base.method_19()));
		if (!this.method_42(class2, class3.method_10()))
		{
			RecoveredRuntime.smethod_283(intptr_, RecoveredRuntime.smethod_42(base.method_19()));
			RecoveredRuntime.smethod_368(class2);
			this.vmethod_6(class2.method_2());
			return IntPtr.Zero;
		}
		if ((enum44_0 & ManualMapInjector.Enum44.flag_7) == (ManualMapInjector.Enum44)0 && class3.method_12() != null && !this.method_42(class2, class3.method_12()))
		{
			RecoveredRuntime.smethod_283(intptr_, RecoveredRuntime.smethod_42(base.method_19()));
			RecoveredRuntime.smethod_368(class2);
			this.vmethod_6(class2.method_2());
			return IntPtr.Zero;
		}
		if (!this.method_41(class2))
		{
			RecoveredRuntime.smethod_283(intptr_, RecoveredRuntime.smethod_42(base.method_19()));
			RecoveredRuntime.smethod_368(class2);
			this.vmethod_6(class2.method_2());
			return IntPtr.Zero;
		}
		if ((enum44_0 & ManualMapInjector.Enum44.flag_1) != (ManualMapInjector.Enum44)0 || RecoveredRuntime.smethod_424(this, class2))
		{
			this.method_39(class2);
			this.list_0.Add(class2);
			return class2.method_2();
		}
		RecoveredRuntime.smethod_283(intptr_, RecoveredRuntime.smethod_42(base.method_19()));
		RecoveredRuntime.smethod_368(class2);
		this.vmethod_6(class2.method_2());
		return IntPtr.Zero;
	}

	internal void method_39(Class172 class172_0)
	{
		if (class172_0.method_0().method_20() == null)
		{
			return;
		}
		using (List<ulong>.Enumerator enumerator = class172_0.method_0().method_20().list_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				int item = (int)(enumerator.Current - class172_0.method_0().method_6().method_3().imethod_17());
				class172_0.method_14().Add(item);
			}
		}
	}

	internal bool method_40()
	{
		if (!PlatformInfo.bool_1)
		{
			return true;
		}
		ProcessModuleInfo gclass = RecoveredRuntime.smethod_42(base.method_19())[EncodedStringTable.smethod_0(8549)];
		if (gclass == null)
		{
			return RecoveredRuntime.smethod_128(this, new FileNotFoundException(EncodedStringTable.smethod_0(12731)));
		}
		IntPtr intPtr = RecoveredRuntime.smethod_225(gclass, EncodedStringTable.smethod_0(29169), false);
		if (intPtr == IntPtr.Zero)
		{
			return RecoveredRuntime.smethod_128(this, new MissingMethodException(EncodedStringTable.smethod_0(29182)));
		}
		byte[] array = base.method_10<byte>(intPtr, 300);
		int num = RecoveredRuntime.smethod_419(array, EncodedStringTable.smethod_0(29239), EncodedStringTable.smethod_0(29260), 0);
		if (num == -1)
		{
			return RecoveredRuntime.smethod_128(this, new InvalidOperationException(EncodedStringTable.smethod_0(29277)));
		}
		num += 2;
		int num2 = base.method_11<int>(intPtr.smethod_8(num));
		IntPtr intPtr2 = intPtr.smethod_8(num + num2 + 4);
		array = base.method_10<byte>(intPtr2, 2);
		if (!RecoveredRuntime.smethod_340(EncodedStringTable.smethod_0(29350), 0, array))
		{
			return RecoveredRuntime.smethod_128(this, new InvalidOperationException(EncodedStringTable.smethod_0(29359)));
		}
		array = base.method_10<byte>(intPtr2, 200);
		if ((num = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(29424), 0)) == -1)
		{
			return RecoveredRuntime.smethod_128(this, new InvalidOperationException(EncodedStringTable.smethod_0(29359)));
		}
		if (num == 0)
		{
			return true;
		}
		array = base.method_10<byte>(intPtr2.smethod_8(num), 50);
		if ((num = RecoveredRuntime.smethod_419(array, EncodedStringTable.smethod_0(29429), EncodedStringTable.smethod_0(29438), 0)) == -1)
		{
			return RecoveredRuntime.smethod_128(this, new InvalidOperationException(EncodedStringTable.smethod_0(29443)));
		}
		ushort value = BitConverter.ToUInt16(array, num + 1);
		NativeTypes.Enum34 @enum;
		if (!this.vmethod_3(intPtr2, 5L, NativeTypes.Enum34.flag_2, out @enum))
		{
			return RecoveredRuntime.smethod_128(this, new AccessViolationException(EncodedStringTable.smethod_0(29512)));
		}
		byte[] array2 = new byte[]
		{
			176,
			1,
			194,
			0,
			0
		};
		Array.Copy(BitConverter.GetBytes(value), 0, array2, 3, 2);
		bool flag = base.method_16<byte>(intPtr2, array2);
		return base.method_14(intPtr2, 5L, @enum) || !flag || RecoveredRuntime.smethod_128(this, new AccessViolationException(EncodedStringTable.smethod_0(29589)));
	}

	internal bool method_41(Class172 class172_0)
	{
		try
		{
			ManualMapProtectionService.Apply(this, class172_0);
			return true;
		}
		catch (Exception exception)
		{
			return RecoveredRuntime.smethod_128(this, exception);
		}
	}

	internal bool ProtectMappedRange(IntPtr address, long length, NativeTypes.Enum34 protection)
	{
		return method_14(address, length, protection);
	}

	internal bool DecommitMappedRange(IntPtr address, long length)
	{
		return vmethod_5(address, length, NativeTypes.Enum28.const_0);
	}

	internal bool FlushMappedImage(IntPtr imageBase, uint imageSize)
	{
		return RecoveredRuntime.FlushInstructionCache(method_2(), imageBase, (UIntPtr)imageSize);
	}

	internal bool method_42(Class172 class172_0, ImportDirectory class148_0)
	{
		if (class148_0 == null)
		{
			return true;
		}
		int i = 0;
		while (i < class148_0.list_0.Count)
		{
			ImportDescriptor @class = class148_0.list_0[i];
			string text = @class.method_12();
			IntPtr intPtr = RecoveredRuntime.smethod_67(class172_0, this, text);
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			ProcessModuleInfo gclass = RecoveredRuntime.smethod_196(RecoveredRuntime.smethod_42(base.method_19()), intPtr);
			if (gclass != null)
			{
				IntPtr intPtr2 = class172_0.method_2().smethod_9((long)((ulong)@class.method_6()));
				foreach (ImportedSymbol class2 in @class.method_8())
				{
					IntPtr intPtr3 = class2.method_7() ? RecoveredRuntime.smethod_248(gclass, class2.method_2(), false) : RecoveredRuntime.smethod_225(gclass, class2.method_4(), false);
					if (intPtr3 == IntPtr.Zero)
					{
						return RecoveredRuntime.smethod_128(this, new MissingMethodException(EncodedStringTable.smethod_0(29808) + (class2.method_7() ? class2.method_2().ToString() : class2.method_4()) + EncodedStringTable.smethod_0(29853) + text));
					}
					if (!(RecoveredRuntime.smethod_427(base.method_19()) ? base.method_13<uint>(intPtr2, (uint)((int)intPtr3)) : base.method_13<IntPtr>(intPtr2, intPtr3)))
					{
						return RecoveredRuntime.smethod_128(this, new AccessViolationException(EncodedStringTable.smethod_0(29882)));
					}
					intPtr2 = intPtr2.smethod_8(RecoveredRuntime.smethod_73(base.method_19()));
				}
				i++;
				continue;
			}
			return RecoveredRuntime.smethod_128(this, new Exception(EncodedStringTable.smethod_0(29755) + text));
		}
		return true;
	}

	internal bool method_43(Class172 class172_0)
	{
		PeImage @class = class172_0.method_0();
		IntPtr intPtr = class172_0.method_2();
		long num = intPtr.ToInt64() - (long)@class.method_6().method_3().imethod_17();
		if (num == 0L)
		{
			return true;
		}
		if (@class.method_16() == null && (IntPtr)((long)class172_0.method_0().method_6().method_3().imethod_17()) != intPtr)
		{
			return RecoveredRuntime.smethod_128(this, new InvalidOperationException(EncodedStringTable.smethod_0(29963) + class172_0.method_6()));
		}
		if (@class.method_16() != null)
		{
			foreach (BaseRelocationBlock class2 in @class.method_16().list_0)
			{
				foreach (BaseRelocationEntry class3 in class2.list_0)
				{
					if (class3.method_2() != BaseRelocationType.Absolute)
					{
						IntPtr intptr_ = intPtr.smethod_9((long)((ulong)(class2.method_0() + class3.method_0())));
						if (class3.method_2() != BaseRelocationType.HighLow)
						{
							if (class3.method_2() != BaseRelocationType.Dir64)
							{
								return RecoveredRuntime.smethod_128(this, new InvalidOperationException(EncodedStringTable.smethod_0(30129) + class3.method_2()));
							}
							IntPtr intptr_2 = base.method_11<IntPtr>(intptr_);
							if (!base.method_13<IntPtr>(intptr_, intptr_2.smethod_9(num)))
							{
								return RecoveredRuntime.smethod_128(this, new AccessViolationException(EncodedStringTable.smethod_0(30068)));
							}
						}
						else
						{
							uint num2 = base.method_11<uint>(intptr_);
							if (!base.method_13<uint>(intptr_, (uint)((ulong)num2 + (ulong)num)))
							{
								return RecoveredRuntime.smethod_128(this, new AccessViolationException(EncodedStringTable.smethod_0(30068)));
							}
						}
					}
				}
			}
			return true;
		}
		return true;
	}

	internal bool method_44(Class172 class172_0)
	{
		IntPtr intPtr = class172_0.method_2();
		PeImage @class = class172_0.method_0();
		if (!base.method_16<byte>(intPtr, RecoveredRuntime.smethod_8((long)((ulong)@class.method_6().method_3().imethod_31()), @class, 0L)))
		{
			return RecoveredRuntime.smethod_128(this, new AccessViolationException(EncodedStringTable.smethod_0(30194)));
		}
		if (!base.method_14(intPtr, (long)((ulong)@class.method_6().method_3().imethod_31()), NativeTypes.Enum34.flag_5))
		{
			return RecoveredRuntime.smethod_128(this, new AccessViolationException(EncodedStringTable.smethod_0(30255)));
		}
		foreach (PeSectionHeader gclass in @class.method_8())
		{
			if ((gclass.method_18() & (SectionCharacteristics)3758096384u) != (SectionCharacteristics)0u && (gclass.method_18() & SectionCharacteristics.flag_28) == (SectionCharacteristics)0u)
			{
				IntPtr intptr_ = intPtr.smethod_9((long)((ulong)gclass.method_4()));
				long long_ = (long)((ulong)gclass.method_8());
				long long_2 = (long)((ulong)gclass.method_6());
				if (!base.method_16<byte>(intptr_, RecoveredRuntime.smethod_8(long_2, @class, long_)))
				{
					return RecoveredRuntime.smethod_128(this, new AccessViolationException(EncodedStringTable.smethod_0(30316)));
				}
			}
		}
		return true;
	}

	internal static byte[] smethod_7(PeImage class154_0)
	{
		if (class154_0.method_23() == null)
		{
			return null;
		}
		foreach (ResourceDirectoryNode @class in class154_0.method_23().method_0().method_6())
		{
			if (RecoveredRuntime.smethod_89(@class) && @class.method_2() == 24 && @class.method_6().Count == 1 && @class.method_6()[0].method_4().Count == 1)
			{
				ResourceDataEntry class2 = @class.method_6()[0].method_4()[0];
				long num = RecoveredRuntime.smethod_135(class154_0, class2.method_4());
				if (num != -1L)
				{
					byte[] array = new byte[class2.method_6()];
					using (Stream stream = RecoveredRuntime.smethod_264(class154_0, num, (int)class2.method_6()))
					{
						stream.Read(array, 0, array.Length);
					}
					return array;
				}
			}
		}
		return null;
	}

	internal static bool smethod_8(string string_0)
	{
		return Path.IsPathRooted(string_0);
	}

	internal static string smethod_9(string string_0)
	{
		return Path.GetFullPath(string_0);
	}

	internal static bool smethod_10(string string_0)
	{
		return File.Exists(string_0);
	}

	internal static string smethod_11(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	internal static FileNotFoundException smethod_12(string string_0)
	{
		return new FileNotFoundException(string_0);
	}

	internal static UnauthorizedAccessException smethod_13(string string_0)
	{
		return new UnauthorizedAccessException(string_0);
	}

	internal static AccessViolationException smethod_14(string string_0)
	{
		return new AccessViolationException(string_0);
	}

	internal static string smethod_15(string string_0)
	{
		return Path.GetFileName(string_0);
	}

	internal static MissingMethodException smethod_16(string string_0)
	{
		return new MissingMethodException(string_0);
	}

	internal static InvalidOperationException smethod_17(string string_0)
	{
		return new InvalidOperationException(string_0);
	}

	internal static ushort smethod_18(byte[] byte_0, int int_1)
	{
		return BitConverter.ToUInt16(byte_0, int_1);
	}

	internal static void smethod_19(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	internal static byte[] smethod_20(ushort ushort_0)
	{
		return BitConverter.GetBytes(ushort_0);
	}

	internal static void smethod_21(Array array_0, int int_1, Array array_1, int int_2, int int_3)
	{
		Array.Copy(array_0, int_1, array_1, int_2, int_3);
	}

	internal static string smethod_22(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	internal static Exception smethod_23(string string_0)
	{
		return new Exception(string_0);
	}

	internal static int smethod_24(Stream stream_0, byte[] byte_0, int int_1, int int_2)
	{
		return stream_0.Read(byte_0, int_1, int_2);
	}

	internal static void smethod_25(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
