using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal sealed class Class89(GClass2 gclass2_1) : Class85(gclass2_1)
{
	[Flags]
	internal enum Enum44
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

	internal sealed class Class172
	{
		[CompilerGenerated]
		private Class154 class154_0;

		[CompilerGenerated]
		private IntPtr intptr_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private Enum44 enum44_0;

		[CompilerGenerated]
		private IntPtr intptr_1;

		[CompilerGenerated]
		private IntPtr intptr_2;

		[CompilerGenerated]
		private List<int> list_0;

		[SpecialName]
		[CompilerGenerated]
		public Class154 method_0()
		{
			return class154_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(Class154 class154_1)
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
			method_13(intptr_ = Class124.intptr_0);
			method_11(intptr_);
			method_15(new List<int>());
		}
	}

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private bool bool_4;

	[CompilerGenerated]
	private bool bool_5;

	[CompilerGenerated]
	private bool bool_6;

	[CompilerGenerated]
	private Exception exception_0;

	private static readonly Class124.Enum34[][][] enum34_0 = new Class124.Enum34[2][][]
	{
		new Class124.Enum34[2][]
		{
			new Class124.Enum34[2]
			{
				Class124.Enum34.flag_4,
				Class124.Enum34.flag_7
			},
			new Class124.Enum34[2]
			{
				Class124.Enum34.flag_5,
				Class124.Enum34.flag_6
			}
		},
		new Class124.Enum34[2][]
		{
			new Class124.Enum34[2]
			{
				Class124.Enum34.flag_0,
				Class124.Enum34.flag_3
			},
			new Class124.Enum34[2]
			{
				Class124.Enum34.flag_1,
				Class124.Enum34.flag_2
			}
		}
	};

	private List<Class172> list_0 = new List<Class172>();

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

	void Class82._202A_202C_202E_200F_202C_206C_200C_202D_202A_206E_200F_200C_202D_202C_202B_200C_206B_200D_206C_206F_206E_206D_206F_200D_200E_206A_202A_202B_202B_206B_200C_202D_202E_206D_202E_206E_200C_202E_200E_202E()
	{
		if (!(method_2() == IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = -1718859445;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1742126974)) % 4)
				{
				case 2u:
					method_3(Class171.OpenProcess(Class124.Enum32.flag_2 | Class124.Enum32.flag_3 | Class124.Enum32.flag_4 | Class124.Enum32.flag_5 | Class124.Enum32.flag_9, false, method_0()));
					num = ((int)num2 * -682151606) ^ 0x8AE777D;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (method_0() != -1)
					{
						num3 = -1583252809;
						num4 = -1583252809;
					}
					else
					{
						num3 = -800075002;
						num4 = -800075002;
					}
					num = num3 ^ ((int)num2 * -144452505);
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public override IntPtr Class85_002E_202A_202C_202E_200F_202C_206C_200C_202D_202A_206E_200F_200C_202D_202C_202B_200C_206B_200D_206C_206F_206E_206D_206F_200D_200E_206A_202A_202B_202B_206B_200C_202D_202E_206D_202E_206E_200C_202E_200E_202E(string string_0)
	{
		method_35(null);
		while (true)
		{
			int num = 1556468339;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x62904270)) % 4)
				{
				case 3u:
				{
					int num3;
					int num4;
					if (!Path.IsPathRooted(string_0))
					{
						num3 = 1076402313;
						num4 = 1076402313;
					}
					else
					{
						num3 = 1136735320;
						num4 = 1136735320;
					}
					num = num3 ^ ((int)num2 * -619153625);
					continue;
				}
				case 0u:
					string_0 = Path.GetFullPath(string_0);
					num = (int)(num2 * 5249066) ^ -1613509163;
					continue;
				case 2u:
					break;
				default:
				{
					Enum44 enum44_ = Class171.smethod_203(this);
					return method_36(string_0, enum44_);
				}
				}
				break;
			}
		}
	}

	internal IntPtr method_36(string string_0, Enum44 enum44_0)
	{
		if (!File.Exists(string_0))
		{
			goto IL_00c9;
		}
		goto IL_0120;
		IL_00c9:
		int num = 159227120;
		goto IL_00ce;
		IL_00ce:
		IntPtr intPtr = default(IntPtr);
		Class172 current = default(Class172);
		uint num5 = default(uint);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x4BDDCD23)) % 12)
			{
			case 11u:
				Class171.smethod_253(this);
				num = ((int)num2 * -485448136) ^ -354350331;
				continue;
			case 9u:
			{
				int num10;
				int num11;
				if (!(intPtr == IntPtr.Zero))
				{
					num10 = -802413571;
					num11 = -802413571;
				}
				else
				{
					num10 = -1380293248;
					num11 = -1380293248;
				}
				num = num10 ^ ((int)num2 * -1096632156);
				continue;
			}
			case 8u:
				break;
			case 5u:
				enum44_0 |= Enum44.flag_1;
				num = (int)(num2 * 1631966601) ^ -639238880;
				continue;
			case 3u:
				Class171.smethod_253(this);
				num = ((int)num2 * -641618709) ^ 0x4D8416C1;
				continue;
			case 2u:
				intPtr = method_38(string_0, enum44_0);
				num = 2019553606;
				continue;
			case 0u:
				goto end_IL_00ce;
			case 1u:
				goto IL_0120;
			case 4u:
				Class171.smethod_253(this);
				throw new UnauthorizedAccessException(Class178.smethod_0(12662));
			case 6u:
				throw new FileNotFoundException(Class178.smethod_0(28151) + string_0 + Class178.smethod_0(3656));
			case 7u:
				return IntPtr.Zero;
			default:
			{
				using (List<Class172>.Enumerator enumerator = list_0.GetEnumerator())
				{
					while (true)
					{
						IL_0309:
						int num3;
						int num4;
						if (enumerator.MoveNext())
						{
							num3 = 833894598;
							num4 = 833894598;
						}
						else
						{
							num3 = 1602783565;
							num4 = 1602783565;
						}
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ 0x4BDDCD23)) % 13)
							{
							case 12u:
								Class171.smethod_362(current);
								num3 = 1447037803;
								continue;
							case 11u:
							{
								current = enumerator.Current;
								int num9;
								if (!method_37(current, 1u))
								{
									num3 = 567051229;
									num9 = 567051229;
								}
								else
								{
									num3 = 919052904;
									num9 = 919052904;
								}
								continue;
							}
							case 10u:
								num5 = current.method_0().method_6().method_3()
									.imethod_31();
								num3 = 1374071572;
								continue;
							case 8u:
								Class171.smethod_362(current);
								num3 = (int)((num2 * 795551140) ^ 0x7F0D433D);
								continue;
							case 7u:
								Class171.smethod_362(current);
								num3 = ((int)num2 * -1215610200) ^ 0x593997CF;
								continue;
							case 6u:
							{
								int num7;
								int num8;
								if (vmethod_5(current.method_2(), num5, Class124.Enum28.const_1))
								{
									num7 = 1391529703;
									num8 = 1391529703;
								}
								else
								{
									num7 = 2064366254;
									num8 = 2064366254;
								}
								num3 = num7 ^ ((int)num2 * -1196381893);
								continue;
							}
							case 5u:
								num3 = ((int)num2 * -1670466838) ^ -1807908653;
								continue;
							case 3u:
							{
								int num6;
								if (method_26())
								{
									num3 = 2019983947;
									num6 = 2019983947;
								}
								else
								{
									num3 = 1941739171;
									num6 = 1941739171;
								}
								continue;
							}
							case 2u:
								method_14(current.method_2(), num5, Class124.Enum34.flag_4);
								num3 = (int)(num2 * 1381193347) ^ -529916630;
								continue;
							case 0u:
								num3 = 833894598;
								continue;
							default:
								goto end_IL_02b3;
							case 1u:
								break;
							case 4u:
								return IntPtr.Zero;
							case 9u:
								goto end_IL_02b3;
							}
							goto IL_0309;
							continue;
							end_IL_02b3:
							break;
						}
						break;
					}
				}
				list_0.Clear();
				return intPtr;
			}
			}
			int num12;
			if (method_19().method_8())
			{
				num = 693834845;
				num12 = 693834845;
			}
			else
			{
				num = 1530193526;
				num12 = 1530193526;
			}
			continue;
			end_IL_00ce:
			break;
		}
		goto IL_00c9;
		IL_0120:
		int num13;
		if (method_8(method_19().method_0()))
		{
			num = 1798152687;
			num13 = 1798152687;
		}
		else
		{
			num = 470025023;
			num13 = 470025023;
		}
		goto IL_00ce;
	}

	private bool method_37(Class172 class172_0, uint uint_0)
	{
		GClass1 gClass = Class171.smethod_42(method_19())[Class178.smethod_0(8549)];
		Class47 class47_ = default(Class47);
		Class53 class2 = default(Class53);
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		uint num5 = default(uint);
		Class58 class58_ = default(Class58);
		int current = default(int);
		int current2 = default(int);
		Class63 class3 = default(Class63);
		while (true)
		{
			int num = 1467190173;
			while (true)
			{
				Class63 @class;
				int num6;
				int num7;
				uint num2;
				int num16;
				switch ((num2 = (uint)(num ^ 0x4108F07C)) % 14)
				{
				case 13u:
					class47_ = new Class47(class2, method_19());
					num = (int)((num2 * 1734046344) ^ 0x1C973897);
					continue;
				case 12u:
					intPtr = Class171.smethod_220(gClass, Class178.smethod_0(29026), false);
					num = 1163373165;
					continue;
				case 11u:
					intPtr2 = Class171.smethod_220(gClass, Class178.smethod_0(29067), false);
					class2 = new Class53();
					num = ((int)num2 * -573522026) ^ -1894090325;
					continue;
				case 9u:
					num5 = class172_0.method_0().method_6().method_3()
						.imethod_11();
					num = 296884208;
					continue;
				case 8u:
					if (uint_0 == 2)
					{
						num = ((int)num2 * -1444732430) ^ -1253944123;
						continue;
					}
					goto IL_03c6;
				case 7u:
					class58_ = Class171.smethod_48(class2);
					if (!Class171.smethod_418(method_19()))
					{
						num = (int)((num2 * 1091060793) ^ 0x499A9CE5);
						continue;
					}
					@class = Class49.class63_37;
					goto IL_00f0;
				case 5u:
				{
					int num14;
					int num15;
					if (gClass != null)
					{
						num14 = -1249210998;
						num15 = -1249210998;
					}
					else
					{
						num14 = -1747203964;
						num15 = -1747203964;
					}
					num = num14 ^ (int)(num2 * 461281686);
					continue;
				}
				case 4u:
				{
					int num10;
					int num11;
					if (uint_0 == 1)
					{
						num10 = -620834003;
						num11 = -620834003;
					}
					else
					{
						num10 = -1721532012;
						num11 = -1721532012;
					}
					num = num10 ^ ((int)num2 * -1444748226);
					continue;
				}
				case 2u:
					Class171.smethod_54(class47_, new Class57(intPtr), CallingConvention.StdCall, new object[3]
					{
						IntPtr.Zero,
						class172_0.method_12(),
						Class171.smethod_84(class47_, class58_)
					});
					num = (int)((num2 * 193503655) ^ 0x4910069D);
					continue;
				case 1u:
				{
					Class171.smethod_15(class47_);
					int num8;
					int num9;
					if (class172_0.method_12() != Class124.intptr_0)
					{
						num8 = 1450307234;
						num9 = 1450307234;
					}
					else
					{
						num8 = 713740719;
						num9 = 713740719;
					}
					num = num8 ^ ((int)num2 * -1710996980);
					continue;
				}
				case 0u:
					@class = Class49.class63_53;
					goto IL_00f0;
				case 10u:
					break;
				default:
				{
					using (List<int>.Enumerator enumerator = class172_0.method_14().GetEnumerator())
					{
						while (true)
						{
							IL_02ed:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 954437792;
								num4 = 954437792;
							}
							else
							{
								num3 = 837571851;
								num4 = 837571851;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x4108F07C)) % 5)
								{
								case 4u:
									current = enumerator.Current;
									num3 = 588730324;
									continue;
								case 3u:
									Class171.smethod_54(class47_, new Class57(class172_0.method_2().smethod_8(current)), CallingConvention.StdCall, new object[3]
									{
										class172_0.method_2(),
										uint_0,
										IntPtr.Zero
									});
									num3 = (int)(num2 * 725443593) ^ -1814478149;
									continue;
								case 0u:
									num3 = 837571851;
									continue;
								default:
									goto end_IL_02b8;
								case 1u:
									break;
								case 2u:
									goto end_IL_02b8;
								}
								goto IL_02ed;
								continue;
								end_IL_02b8:
								break;
							}
							break;
						}
					}
					if (num5 != 0)
					{
						goto IL_038c;
					}
					goto IL_04f0;
				}
				case 6u:
					{
						return Class171.smethod_127(this, (Exception)new FileNotFoundException(Class178.smethod_0(12731)));
					}
					IL_03c6:
					if (num5 != 0)
					{
						num6 = 93345072;
						num7 = 93345072;
					}
					else
					{
						num6 = 1856381312;
						num7 = 1856381312;
					}
					goto IL_0391;
					IL_0391:
					while (true)
					{
						switch ((num2 = (uint)(num6 ^ 0x4108F07C)) % 5)
						{
						case 1u:
							Class171.smethod_54(class47_, new Class57(class172_0.method_2().smethod_9(num5)), CallingConvention.StdCall, new object[3]
							{
								class172_0.method_2(),
								uint_0,
								IntPtr.Zero
							});
							num6 = (int)((num2 * 1851157704) ^ 0x422312E0);
							continue;
						case 0u:
							break;
						case 3u:
							goto IL_03c6;
						default:
							goto IL_03cf;
						case 4u:
							goto IL_04ab;
						}
						break;
					}
					goto IL_038c;
					IL_03cf:
					using (List<int>.Enumerator enumerator = class172_0.method_14().GetEnumerator())
					{
						while (true)
						{
							IL_048d:
							int num12;
							int num13;
							if (enumerator.MoveNext())
							{
								num12 = 2030320853;
								num13 = 2030320853;
							}
							else
							{
								num12 = 1947439343;
								num13 = 1947439343;
							}
							while (true)
							{
								switch ((num2 = (uint)(num12 ^ 0x4108F07C)) % 5)
								{
								case 2u:
									Class171.smethod_54(class47_, new Class57(class172_0.method_2().smethod_8(current2)), CallingConvention.StdCall, new object[3]
									{
										class172_0.method_2(),
										uint_0,
										IntPtr.Zero
									});
									num12 = ((int)num2 * -2068500670) ^ 0x6E57551D;
									continue;
								case 1u:
									current2 = enumerator.Current;
									num12 = 1755597929;
									continue;
								case 0u:
									num12 = 2030320853;
									continue;
								default:
									goto end_IL_0458;
								case 4u:
									break;
								case 3u:
									goto end_IL_0458;
								}
								goto IL_048d;
								continue;
								end_IL_0458:
								break;
							}
							break;
						}
					}
					goto IL_04f0;
					IL_04f0:
					if (class172_0.method_12() != Class124.intptr_0)
					{
						goto IL_0539;
					}
					goto IL_05cc;
					IL_04ab:
					Class171.smethod_54(class47_, new Class57(class172_0.method_2().smethod_9(num5)), CallingConvention.StdCall, new object[3]
					{
						class172_0.method_2(),
						uint_0,
						IntPtr.Zero
					});
					goto IL_04f0;
					IL_059e:
					while (true)
					{
						switch ((num2 = (uint)(num16 ^ 0x4108F07C)) % 7)
						{
						case 3u:
						{
							Class171.smethod_330(class47_);
							int num17;
							int num18;
							if (!Class171.smethod_233(class2, (Class84)this))
							{
								num17 = -828128323;
								num18 = -828128323;
							}
							else
							{
								num17 = -1088384881;
								num18 = -1088384881;
							}
							num16 = num17 ^ (int)(num2 * 1699594358);
							continue;
						}
						case 2u:
							break;
						case 1u:
							Class171.smethod_420(class2, class3, Class171.smethod_216(class47_, class58_, 0L));
							num16 = (int)(num2 * 362296245) ^ -749364924;
							continue;
						case 0u:
							Class171.smethod_54(class47_, new Class57(intPtr2), CallingConvention.StdCall, new object[2]
							{
								IntPtr.Zero,
								class3
							});
							num16 = (int)(num2 * 1776136150) ^ -329999452;
							continue;
						case 4u:
							goto IL_05cc;
						case 5u:
							return Class171.smethod_127(this, (Exception)new AccessViolationException(Class178.smethod_0(29108)));
						default:
							return true;
						}
						break;
					}
					goto IL_0539;
					IL_0539:
					num16 = 1258566350;
					goto IL_059e;
					IL_05cc:
					Class171.smethod_221(class47_, -1);
					Class171.smethod_222(class47_);
					Class171.smethod_36(class2, class58_);
					num16 = 193420669;
					goto IL_059e;
					IL_038c:
					num6 = 130058957;
					goto IL_0391;
					IL_00f0:
					class3 = @class;
					num = 821399327;
					continue;
				}
				break;
			}
		}
	}

	private IntPtr method_38(string string_0, Enum44 enum44_0)
	{
		Class172 @class = new Class172();
		@class.method_5(string_0);
		@class.method_7(Path.GetFileName(string_0));
		@class.method_9(enum44_0);
		@class.method_3(Class171.smethod_42(method_19()).method_0(string_0));
		Class172 class2 = @class;
		if (class2.method_2() != IntPtr.Zero)
		{
			uint num = 382718365u;
			return class2.method_2();
		}
		IntPtr zero = default(IntPtr);
		try
		{
			class2.method_1(Class171.smethod_81(Enum39.const_0, string_0));
			if (class2.method_0() == null)
			{
				while (true)
				{
					IL_00a5:
					int num2 = -33347235;
					while (true)
					{
						uint num;
						switch ((num = (uint)(num2 ^ -1042987440)) % 4)
						{
						case 1u:
							goto IL_006f;
						default:
							goto end_IL_0083;
						case 2u:
							break;
						case 3u:
							goto end_IL_0083;
						case 0u:
							goto IL_05b9;
						}
						goto IL_00a5;
						IL_006f:
						zero = IntPtr.Zero;
						num2 = ((int)num * -1711130483) ^ 0x5ECEE9C5;
						continue;
						end_IL_0083:
						break;
					}
					break;
				}
			}
		}
		catch (Exception)
		{
			while (true)
			{
				IL_00e8:
				int num3 = -551019599;
				while (true)
				{
					uint num;
					switch ((num = (uint)(num3 ^ -1042987440)) % 3)
					{
					case 1u:
						goto IL_00b6;
					case 0u:
						break;
					default:
						goto end_IL_00ca;
					}
					goto IL_00e8;
					IL_00b6:
					zero = IntPtr.Zero;
					num3 = (int)((num * 579371985) ^ 0x9DBEF8);
					continue;
					end_IL_00ca:
					break;
				}
				break;
			}
			goto IL_05b9;
		}
		class2.method_3(method_15((IntPtr)(long)class2.method_0().method_6().method_3()
			.imethod_17(), class2.method_0().method_6().method_3()
			.imethod_29(), Class124.Enum34.flag_2));
		if (class2.method_2() == IntPtr.Zero)
		{
			goto IL_02bf;
		}
		goto IL_055d;
		IL_055d:
		Class154 class3 = class2.method_0();
		int num4 = -229771868;
		goto IL_04c2;
		IL_05b9:
		return zero;
		IL_02bf:
		num4 = -851680982;
		goto IL_04c2;
		IL_04c2:
		IntPtr intPtr = default(IntPtr);
		while (true)
		{
			uint num;
			switch ((num = (uint)(num4 ^ -1042987440)) % 34)
			{
			case 33u:
				Class171.smethod_362(class2);
				vmethod_6(class2.method_2());
				num4 = (int)((num * 2143295290) ^ 0x563DDFD9);
				continue;
			case 31u:
				vmethod_6(class2.method_2());
				num4 = ((int)num * -1935166305) ^ -641905839;
				continue;
			case 29u:
			{
				int num15;
				int num16;
				if (method_42(class2, class3.method_12()))
				{
					num15 = -1664068696;
					num16 = -1664068696;
				}
				else
				{
					num15 = -250230122;
					num16 = -250230122;
				}
				num4 = num15 ^ (int)(num * 610485445);
				continue;
			}
			case 26u:
				Class171.smethod_277(intPtr, Class171.smethod_42(method_19()));
				Class171.smethod_362(class2);
				vmethod_6(class2.method_2());
				num4 = ((int)num * -1018561785) ^ 0x331B61D8;
				continue;
			case 25u:
				Class171.smethod_277(intPtr, Class171.smethod_42(method_19()));
				num4 = (int)((num * 1945491709) ^ 0x4A07FCF2);
				continue;
			case 23u:
				Class171.smethod_277(intPtr, Class171.smethod_42(method_19()));
				Class171.smethod_362(class2);
				num4 = ((int)num * -1393160223) ^ -1225184593;
				continue;
			case 22u:
			{
				int num11;
				int num12;
				if (Class171.smethod_415(this, class2))
				{
					num11 = 479293003;
					num12 = 479293003;
				}
				else
				{
					num11 = 1923964314;
					num12 = 1923964314;
				}
				num4 = num11 ^ ((int)num * -60552625);
				continue;
			}
			case 21u:
				Class171.smethod_362(class2);
				num4 = ((int)num * -285758260) ^ -458700207;
				continue;
			case 18u:
			{
				int num7;
				int num8;
				if (class3.method_12() != null)
				{
					num7 = 745627659;
					num8 = 745627659;
				}
				else
				{
					num7 = 893049727;
					num8 = 893049727;
				}
				num4 = num7 ^ (int)(num * 1208724829);
				continue;
			}
			case 17u:
				break;
			case 16u:
				Class171.smethod_362(class2);
				vmethod_6(class2.method_2());
				num4 = ((int)num * -960094940) ^ 0x42186934;
				continue;
			case 15u:
				method_39(class2);
				list_0.Add(class2);
				num4 = -760983283;
				continue;
			case 14u:
				intPtr = class2.method_2();
				num4 = (int)(num * 1849695286) ^ -1959872038;
				continue;
			case 13u:
				goto IL_0326;
			case 12u:
				goto IL_034b;
			case 11u:
			{
				int num13;
				int num14;
				if (!method_43(class2))
				{
					num13 = 802325481;
					num14 = 802325481;
				}
				else
				{
					num13 = 1848864948;
					num14 = 1848864948;
				}
				num4 = num13 ^ (int)(num * 2102417716);
				continue;
			}
			case 10u:
			{
				int num9;
				int num10;
				if ((enum44_0 & Enum44.flag_6) == 0)
				{
					num9 = -1516150211;
					num10 = -1516150211;
				}
				else
				{
					num9 = -244097158;
					num10 = -244097158;
				}
				num4 = num9 ^ (int)(num * 593095829);
				continue;
			}
			case 9u:
				goto IL_03c9;
			case 8u:
				goto IL_03ee;
			case 5u:
			{
				int num5;
				int num6;
				if (Class171.smethod_26(this, class2))
				{
					num5 = -2100527148;
					num6 = -2100527148;
				}
				else
				{
					num5 = -814727356;
					num6 = -814727356;
				}
				num4 = num5 ^ ((int)num * -378999848);
				continue;
			}
			case 4u:
				Class171.smethod_236(this, class2);
				num4 = ((int)num * -988759986) ^ -1107812318;
				continue;
			case 3u:
				Class171.smethod_362(class2);
				num4 = -1701709923;
				continue;
			case 2u:
				Class171.smethod_277(intPtr, Class171.smethod_42(method_19()));
				num4 = (int)(num * 748845492) ^ -818542019;
				continue;
			case 1u:
				goto IL_04a6;
			case 20u:
				goto IL_055d;
			case 0u:
				return IntPtr.Zero;
			case 6u:
				return IntPtr.Zero;
			case 7u:
				vmethod_6(class2.method_2());
				return IntPtr.Zero;
			case 19u:
				return IntPtr.Zero;
			case 24u:
				vmethod_6(class2.method_2());
				return IntPtr.Zero;
			case 27u:
				return class2.method_2();
			case 28u:
				return IntPtr.Zero;
			case 32u:
				return IntPtr.Zero;
			default:
				goto IL_05b9;
			}
			break;
			IL_04a6:
			int num17;
			if ((enum44_0 & Enum44.flag_1) == 0)
			{
				num4 = -963272580;
				num17 = -963272580;
			}
			else
			{
				num4 = -475672097;
				num17 = -475672097;
			}
			continue;
			IL_0326:
			int num18;
			if (!method_41(class2))
			{
				num4 = -99976598;
				num18 = -99976598;
			}
			else
			{
				num4 = -357767959;
				num18 = -357767959;
			}
			continue;
			IL_03c9:
			int num19;
			if ((enum44_0 & Enum44.flag_7) != 0)
			{
				num4 = -1827786231;
				num19 = -1827786231;
			}
			else
			{
				num4 = -52254786;
				num19 = -52254786;
			}
			continue;
			IL_03ee:
			Class171.smethod_260(Class171.smethod_42(method_19()), class3, intPtr, Class171.smethod_418(method_19()));
			int num20;
			if (method_42(class2, class3.method_10()))
			{
				num4 = -1620842279;
				num20 = -1620842279;
			}
			else
			{
				num4 = -2042553665;
				num20 = -2042553665;
			}
			continue;
			IL_034b:
			int num21;
			if (method_44(class2))
			{
				num4 = -1691864591;
				num21 = -1691864591;
			}
			else
			{
				num4 = -1229863331;
				num21 = -1229863331;
			}
		}
		goto IL_02bf;
	}

	private void method_39(Class172 class172_0)
	{
		if (class172_0.method_0().method_20() == null)
		{
			uint num = 71084995u;
			return;
		}
		using List<ulong>.Enumerator enumerator = class172_0.method_0().method_20().list_0.GetEnumerator();
		int item = default(int);
		while (true)
		{
			int num2;
			int num3;
			if (!enumerator.MoveNext())
			{
				num2 = -861787138;
				num3 = -861787138;
			}
			else
			{
				num2 = -1107799974;
				num3 = -1107799974;
			}
			while (true)
			{
				uint num;
				switch ((num = (uint)(num2 ^ -1427845750)) % 5)
				{
				case 2u:
					class172_0.method_14().Add(item);
					num2 = (int)((num * 537995965) ^ 0x15E8D45E);
					continue;
				case 1u:
					item = (int)(enumerator.Current - class172_0.method_0().method_6().method_3()
						.imethod_17());
					num2 = -1162206898;
					continue;
				case 0u:
					num2 = -1107799974;
					continue;
				default:
					return;
				case 4u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	internal bool method_40()
	{
		if (!Class127.bool_1)
		{
			goto IL_0090;
		}
		goto IL_039c;
		IL_0090:
		int num = -756889607;
		goto IL_030a;
		IL_030a:
		byte[] array = default(byte[]);
		IntPtr intPtr = default(IntPtr);
		int num3 = default(int);
		IntPtr intptr_ = default(IntPtr);
		GClass1 gClass = default(GClass1);
		ushort value = default(ushort);
		byte[] array2 = default(byte[]);
		bool flag = default(bool);
		Class124.Enum34 enum34_ = default(Class124.Enum34);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -413377720)) % 31)
			{
			case 30u:
			{
				int num12;
				int num13;
				if (Class171.smethod_334(Class178.smethod_0(29350), 0, array))
				{
					num12 = -469689408;
					num13 = -469689408;
				}
				else
				{
					num12 = -95892414;
					num13 = -95892414;
				}
				num = num12 ^ (int)(num2 * 1775755729);
				continue;
			}
			case 29u:
			{
				int num10;
				int num11;
				if (intPtr == IntPtr.Zero)
				{
					num10 = 695052357;
					num11 = 695052357;
				}
				else
				{
					num10 = 790992114;
					num11 = 790992114;
				}
				num = num10 ^ (int)(num2 * 466392648);
				continue;
			}
			case 27u:
				array = method_10<byte>(intPtr, 300);
				num = -1539153528;
				continue;
			case 26u:
				break;
			case 25u:
			{
				int num17;
				int num18;
				if ((num3 = Class171.smethod_411(array, Class178.smethod_0(29429), Class178.smethod_0(29438), 0)) == -1)
				{
					num17 = -2119293287;
					num18 = -2119293287;
				}
				else
				{
					num17 = -214482323;
					num18 = -214482323;
				}
				num = num17 ^ ((int)num2 * -149492349);
				continue;
			}
			case 23u:
			{
				int num16 = method_11<int>(intPtr.smethod_8(num3));
				intptr_ = intPtr.smethod_8(num3 + num16 + 4);
				num = ((int)num2 * -1268288535) ^ 0x6247E9E4;
				continue;
			}
			case 22u:
				intPtr = Class171.smethod_220(gClass, Class178.smethod_0(29169), false);
				num = -1345636675;
				continue;
			case 21u:
			{
				num3 = Class171.smethod_411(array, Class178.smethod_0(29239), Class178.smethod_0(29260), 0);
				int num6;
				int num7;
				if (num3 != -1)
				{
					num6 = -1657666647;
					num7 = -1657666647;
				}
				else
				{
					num6 = -1974539873;
					num7 = -1974539873;
				}
				num = num6 ^ ((int)num2 * -731399899);
				continue;
			}
			case 20u:
				goto IL_0170;
			case 19u:
				array = method_10<byte>(intptr_.smethod_8(num3), 50);
				num = -81188416;
				continue;
			case 15u:
				array = method_10<byte>(intptr_, 2);
				num = (int)(num2 * 123420433) ^ -455294339;
				continue;
			case 14u:
				Array.Copy(BitConverter.GetBytes(value), 0, array2, 3, 2);
				flag = method_16(intptr_, array2);
				num = (int)(num2 * 790971697) ^ -1875299524;
				continue;
			case 13u:
			{
				int num14;
				int num15;
				if (!(!method_14(intptr_, 5L, enum34_) & flag))
				{
					num14 = 1879349564;
					num15 = 1879349564;
				}
				else
				{
					num14 = 432312116;
					num15 = 432312116;
				}
				num = num14 ^ ((int)num2 * -1510845786);
				continue;
			}
			case 11u:
				goto IL_0237;
			case 9u:
			{
				int num8;
				int num9;
				if (gClass != null)
				{
					num8 = -225454318;
					num9 = -225454318;
				}
				else
				{
					num8 = -558937600;
					num9 = -558937600;
				}
				num = num8 ^ ((int)num2 * -66484376);
				continue;
			}
			case 8u:
				array2 = new byte[5] { 176, 1, 194, 0, 0 };
				num = -237273941;
				continue;
			case 5u:
			{
				int num4;
				int num5;
				if (!vmethod_3(intptr_, 5L, Class124.Enum34.flag_2, out enum34_))
				{
					num4 = -511304162;
					num5 = -511304162;
				}
				else
				{
					num4 = -823306021;
					num5 = -823306021;
				}
				num = num4 ^ ((int)num2 * -803023544);
				continue;
			}
			case 3u:
				value = BitConverter.ToUInt16(array, num3 + 1);
				num = -78619695;
				continue;
			case 2u:
				num3 += 2;
				num = -1930905534;
				continue;
			case 10u:
				goto IL_039c;
			case 0u:
				return Class171.smethod_127(this, (Exception)new AccessViolationException(Class178.smethod_0(29512)));
			case 1u:
				return Class171.smethod_127(this, (Exception)new FileNotFoundException(Class178.smethod_0(12731)));
			case 4u:
				return Class171.smethod_127(this, (Exception)new InvalidOperationException(Class178.smethod_0(29443)));
			case 6u:
				return Class171.smethod_127(this, (Exception)new AccessViolationException(Class178.smethod_0(29589)));
			case 7u:
				return Class171.smethod_127(this, (Exception)new InvalidOperationException(Class178.smethod_0(29359)));
			default:
				return true;
			case 16u:
				return Class171.smethod_127(this, (Exception)new InvalidOperationException(Class178.smethod_0(29359)));
			case 17u:
				return true;
			case 18u:
				return true;
			case 24u:
				return Class171.smethod_127(this, (Exception)new InvalidOperationException(Class178.smethod_0(29277)));
			case 28u:
				return Class171.smethod_127(this, (Exception)new MissingMethodException(Class178.smethod_0(29182)));
			}
			break;
			IL_0237:
			array = method_10<byte>(intptr_, 200);
			int num19;
			if ((num3 = Class171.smethod_372(array, Class178.smethod_0(29424), 0)) != -1)
			{
				num = -1486477485;
				num19 = -1486477485;
			}
			else
			{
				num = -1443517686;
				num19 = -1443517686;
			}
			continue;
			IL_0170:
			int num20;
			if (num3 == 0)
			{
				num = -856657273;
				num20 = -856657273;
			}
			else
			{
				num = -887351136;
				num20 = -887351136;
			}
		}
		goto IL_0090;
		IL_039c:
		gClass = Class171.smethod_42(method_19())[Class178.smethod_0(8549)];
		num = -2098262684;
		goto IL_030a;
	}

	private bool method_41(Class172 class172_0)
	{
		using (List<GClass5>.Enumerator enumerator = class172_0.method_0().method_8().GetEnumerator())
		{
			bool flag2 = default(bool);
			GClass5 current = default(GClass5);
			IntPtr intptr_ = default(IntPtr);
			bool flag = default(bool);
			Class124.Enum34 @enum = default(Class124.Enum34);
			bool flag3 = default(bool);
			bool result = default(bool);
			while (true)
			{
				IL_0262:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1741969559;
					num2 = -1741969559;
				}
				else
				{
					num = -925910286;
					num2 = -925910286;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -8459342)) % 16)
					{
					case 15u:
						flag2 = (current.method_18() & Enum41.flag_33) == Enum41.flag_33;
						num = (int)(num3 * 807694239) ^ -1016930706;
						continue;
					case 14u:
						vmethod_5(intptr_, current.method_2(), Class124.Enum28.const_0);
						num = (int)((num3 * 906952057) ^ 0x10297798);
						continue;
					case 13u:
						flag = (current.method_18() & Enum41.flag_32) == Enum41.flag_32;
						num = (int)(num3 * 1134934001) ^ -633157044;
						continue;
					case 12u:
					{
						int num7;
						int num8;
						if ((current.method_18() & Enum41.flag_29) != Enum41.flag_29)
						{
							num7 = 847916211;
							num8 = 847916211;
						}
						else
						{
							num7 = 574515112;
							num8 = 574515112;
						}
						num = num7 ^ (int)(num3 * 355543068);
						continue;
					}
					case 11u:
						current = enumerator.Current;
						num = -849530780;
						continue;
					case 10u:
						@enum |= Class124.Enum34.flag_9;
						num = ((int)num3 * -1237545686) ^ -675191161;
						continue;
					case 9u:
					{
						int num5;
						int num6;
						if ((current.method_18() & Enum41.flag_28) == Enum41.flag_28)
						{
							num5 = -655357699;
							num6 = -655357699;
						}
						else
						{
							num5 = -1604231813;
							num6 = -1604231813;
						}
						num = num5 ^ (int)(num3 * 520874985);
						continue;
					}
					case 8u:
						flag3 = ((uint)current.method_18() & 0x80000000u) == 2147483648u;
						num = -1629580627;
						continue;
					case 7u:
						num = -1741969559;
						continue;
					case 6u:
						intptr_ = class172_0.method_2().smethod_9(current.method_4());
						num = (int)(num3 * 1217916844) ^ -398216861;
						continue;
					case 5u:
						result = Class171.smethod_127(this, (Exception)new AccessViolationException(Class178.smethod_0(29678)));
						num = ((int)num3 * -584472487) ^ -1127142435;
						continue;
					case 3u:
						@enum = enum34_0[flag ? 1 : 0][flag2 ? 1 : 0][flag3 ? 1 : 0];
						num = -1134878834;
						continue;
					case 1u:
					{
						int num4;
						if (method_14(intptr_, current.method_2(), @enum))
						{
							num = -1193518202;
							num4 = -1193518202;
						}
						else
						{
							num = -1777807385;
							num4 = -1777807385;
						}
						continue;
					}
					default:
						goto end_IL_0200;
					case 4u:
						break;
					case 0u:
						goto end_IL_0200;
					case 2u:
						return result;
					}
					goto IL_0262;
					continue;
					end_IL_0200:
					break;
				}
				break;
			}
		}
		return true;
	}

	private bool method_42(Class172 class172_0, Class148 class148_0)
	{
		if (class148_0 == null)
		{
			goto IL_0025;
		}
		goto IL_036f;
		IL_0025:
		int num = -1131034367;
		goto IL_0325;
		IL_0325:
		GClass1 gClass = default(GClass1);
		IntPtr intPtr = default(IntPtr);
		string text = default(string);
		Class160 @class = default(Class160);
		int num12 = default(int);
		Class164 current = default(Class164);
		IntPtr intPtr3 = default(IntPtr);
		bool result = default(bool);
		while (true)
		{
			int num7;
			uint num2;
			switch ((num2 = (uint)(num ^ -699919528)) % 13)
			{
			case 10u:
				gClass = Class171.smethod_194(Class171.smethod_42(method_19()), intPtr);
				num = -492946928;
				continue;
			case 8u:
				break;
			case 7u:
				text = @class.method_12();
				num = (int)(num2 * 165718756) ^ -15078399;
				continue;
			case 6u:
				intPtr = Class171.smethod_67(class172_0, this, text);
				num = ((int)num2 * -1452842132) ^ 0x67314A7A;
				continue;
			case 4u:
			{
				int num5;
				int num6;
				if (gClass != null)
				{
					num5 = 151565714;
					num6 = 151565714;
				}
				else
				{
					num5 = 1228331751;
					num6 = 1228331751;
				}
				num = num5 ^ (int)(num2 * 1941633808);
				continue;
			}
			case 3u:
				goto IL_00bf;
			case 0u:
				@class = class148_0.list_0[num12];
				num = -376020530;
				continue;
			default:
			{
				IntPtr intptr_ = class172_0.method_2().smethod_9(@class.method_6());
				using (List<Class164>.Enumerator enumerator = @class.method_8().GetEnumerator())
				{
					while (true)
					{
						IL_02c7:
						int num8;
						int num9;
						if (!enumerator.MoveNext())
						{
							num8 = -1605664243;
							num9 = -1605664243;
						}
						else
						{
							num8 = -873746203;
							num9 = -873746203;
						}
						while (true)
						{
							IntPtr intPtr2;
							bool num10;
							int num11;
							switch ((num2 = (uint)(num8 ^ -699919528)) % 13)
							{
							case 12u:
								intPtr2 = Class171.smethod_220(gClass, current.method_4(), false);
								goto IL_012a;
							case 11u:
								if (!Class171.smethod_418(method_19()))
								{
									num8 = -2016572106;
									continue;
								}
								num10 = method_13(intptr_, (uint)(int)intPtr3);
								goto IL_017c;
							case 4u:
								intptr_ = intptr_.smethod_8(Class171.smethod_73(method_19()));
								num8 = -1860770309;
								continue;
							case 10u:
								num10 = method_13(intptr_, intPtr3);
								goto IL_017c;
							case 8u:
								if (!current.method_7())
								{
									num8 = (int)((num2 * 2956953) ^ 0x50267163);
									continue;
								}
								intPtr2 = Class171.smethod_242(gClass, current.method_2(), false);
								goto IL_012a;
							case 7u:
								num8 = -873746203;
								continue;
							case 5u:
								result = Class171.smethod_127(this, (Exception)new MissingMethodException(Class178.smethod_0(29808) + (current.method_7() ? current.method_2().ToString() : current.method_4()) + Class178.smethod_0(29853) + text));
								num8 = -1311108833;
								continue;
							case 3u:
								current = enumerator.Current;
								num8 = -819663490;
								continue;
							case 2u:
								result = Class171.smethod_127(this, (Exception)new AccessViolationException(Class178.smethod_0(29882)));
								num8 = (int)(num2 * 1135360424) ^ -14813825;
								continue;
							default:
								goto end_IL_0271;
							case 0u:
								break;
							case 9u:
								goto end_IL_0271;
							case 1u:
							case 6u:
								goto IL_0378;
								IL_017c:
								if (!num10)
								{
									num8 = -2092823376;
									continue;
								}
								goto case 4u;
								IL_012a:
								intPtr3 = intPtr2;
								if (intPtr3 == IntPtr.Zero)
								{
									num8 = -1613958869;
									num11 = -1613958869;
								}
								else
								{
									num8 = -1993952888;
									num11 = -1993952888;
								}
								continue;
							}
							goto IL_02c7;
							continue;
							end_IL_0271:
							break;
						}
						break;
					}
				}
				num12++;
				goto IL_0095;
			}
			case 1u:
			{
				int num3;
				int num4;
				if (!(intPtr == IntPtr.Zero))
				{
					num3 = -699387568;
					num4 = -699387568;
				}
				else
				{
					num3 = -239331803;
					num4 = -239331803;
				}
				num = num3 ^ ((int)num2 * -684956771);
				continue;
			}
			case 11u:
				goto IL_036f;
			case 5u:
				return Class171.smethod_127(this, new Exception(Class178.smethod_0(29755) + text));
			case 9u:
				return false;
			case 12u:
				{
					return true;
				}
				IL_0095:
				num7 = -154102922;
				goto IL_009a;
				IL_00bf:
				if (num12 >= class148_0.list_0.Count)
				{
					num7 = -315626311;
					goto IL_009a;
				}
				goto case 0u;
				IL_009a:
				switch ((num2 = (uint)(num7 ^ -699919528)) % 4)
				{
				case 3u:
					break;
				case 2u:
					goto IL_00bf;
				default:
					goto IL_0378;
				case 1u:
					return true;
				}
				goto IL_0095;
				IL_0378:
				return result;
			}
			break;
		}
		goto IL_0025;
		IL_036f:
		num12 = 0;
		num = -632994727;
		goto IL_0325;
	}

	private bool method_43(Class172 class172_0)
	{
		Class154 @class = class172_0.method_0();
		IntPtr intPtr = default(IntPtr);
		long num12 = default(long);
		Class144 current2 = default(Class144);
		bool result = default(bool);
		IntPtr intptr_ = default(IntPtr);
		uint num6 = default(uint);
		IntPtr intPtr2 = default(IntPtr);
		while (true)
		{
			int num = -543966768;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -165970232)) % 9)
				{
				case 7u:
				{
					int num22;
					if (@class.method_16() != null)
					{
						num = -754724018;
						num22 = -754724018;
					}
					else
					{
						num = -1784093735;
						num22 = -1784093735;
					}
					continue;
				}
				case 4u:
				{
					intPtr = class172_0.method_2();
					num12 = intPtr.ToInt64() - (long)@class.method_6().method_3().imethod_17();
					int num20;
					int num21;
					if (num12 == 0L)
					{
						num20 = 725627249;
						num21 = 725627249;
					}
					else
					{
						num20 = 760597766;
						num21 = 760597766;
					}
					num = num20 ^ ((int)num2 * -2076648213);
					continue;
				}
				case 3u:
				{
					int num17;
					if (@class.method_16() != null)
					{
						num = -1881604087;
						num17 = -1881604087;
					}
					else
					{
						num = -1478719464;
						num17 = -1478719464;
					}
					continue;
				}
				case 2u:
				{
					int num18;
					int num19;
					if ((IntPtr)(long)class172_0.method_0().method_6().method_3()
						.imethod_17() != intPtr)
					{
						num18 = -498164345;
						num19 = -498164345;
					}
					else
					{
						num18 = -906947383;
						num19 = -906947383;
					}
					num = num18 ^ ((int)num2 * -1032578308);
					continue;
				}
				case 6u:
					break;
				case 0u:
					return Class171.smethod_127(this, (Exception)new InvalidOperationException(Class178.smethod_0(29963) + class172_0.method_6()));
				case 1u:
					return true;
				default:
				{
					using (List<Class145>.Enumerator enumerator = @class.method_16().list_0.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Class145 current;
							while (true)
							{
								current = enumerator.Current;
								int num3 = -4293042;
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -165970232)) % 3)
									{
									case 0u:
										num3 = -970555263;
										continue;
									case 1u:
										break;
									default:
										goto end_IL_0173;
									}
									break;
								}
								continue;
								end_IL_0173:
								break;
							}
							using List<Class144>.Enumerator enumerator2 = current.list_0.GetEnumerator();
							while (true)
							{
								IL_03cd:
								int num4;
								int num5;
								if (!enumerator2.MoveNext())
								{
									num4 = -1810788980;
									num5 = -1810788980;
								}
								else
								{
									num4 = -2064236879;
									num5 = -2064236879;
								}
								while (true)
								{
									switch ((num2 = (uint)(num4 ^ -165970232)) % 17)
									{
									case 16u:
										num4 = -2064236879;
										continue;
									case 15u:
									{
										int num9;
										int num10;
										if (current2.method_2() != GEnum0.HighLow)
										{
											num9 = -688749705;
											num10 = -688749705;
										}
										else
										{
											num9 = -34732558;
											num10 = -34732558;
										}
										num4 = num9 ^ ((int)num2 * -281585318);
										continue;
									}
									case 14u:
										result = Class171.smethod_127(this, (Exception)new AccessViolationException(Class178.smethod_0(30068)));
										num4 = (int)((num2 * 1905284176) ^ 0x14A17FAC);
										continue;
									case 13u:
									{
										int num13;
										int num14;
										if (!method_13(intptr_, (uint)(num6 + num12)))
										{
											num13 = -642660513;
											num14 = -642660513;
										}
										else
										{
											num13 = -1129834661;
											num14 = -1129834661;
										}
										num4 = num13 ^ (int)(num2 * 1601362693);
										continue;
									}
									case 12u:
										intPtr2 = method_11<IntPtr>(intptr_);
										num4 = ((int)num2 * -1503781881) ^ 0x5B994C6;
										continue;
									case 10u:
										result = Class171.smethod_127(this, (Exception)new InvalidOperationException(Class178.smethod_0(30129) + current2.method_2()));
										num4 = -411687850;
										continue;
									case 9u:
										current2 = enumerator2.Current;
										num4 = -258372151;
										continue;
									case 8u:
									{
										int num15;
										int num16;
										if (!method_13(intptr_, intPtr2.smethod_9(num12)))
										{
											num15 = -1446101933;
											num16 = -1446101933;
										}
										else
										{
											num15 = -1680210709;
											num16 = -1680210709;
										}
										num4 = num15 ^ (int)(num2 * 1900833731);
										continue;
									}
									case 7u:
									{
										int num11;
										if (current2.method_2() == GEnum0.Dir64)
										{
											num4 = -1778240592;
											num11 = -1778240592;
										}
										else
										{
											num4 = -1539028563;
											num11 = -1539028563;
										}
										continue;
									}
									case 6u:
									{
										int num7;
										int num8;
										if (current2.method_2() == GEnum0.Absolute)
										{
											num7 = 1766826656;
											num8 = 1766826656;
										}
										else
										{
											num7 = 1220837657;
											num8 = 1220837657;
										}
										num4 = num7 ^ (int)(num2 * 998742553);
										continue;
									}
									case 4u:
										num6 = method_11<uint>(intptr_);
										num4 = ((int)num2 * -415314055) ^ -1652361318;
										continue;
									case 3u:
										intptr_ = intPtr.smethod_9(current.method_0() + current2.method_0());
										num4 = (int)((num2 * 2126337800) ^ 0x3A894025);
										continue;
									default:
										goto end_IL_0367;
									case 5u:
										break;
									case 1u:
										result = Class171.smethod_127(this, (Exception)new AccessViolationException(Class178.smethod_0(30068)));
										goto IL_0426;
									case 11u:
										goto end_IL_0367;
									case 0u:
									case 2u:
										goto IL_0426;
									}
									goto IL_03cd;
									continue;
									end_IL_0367:
									break;
								}
								break;
							}
						}
					}
					return true;
				}
				case 8u:
					{
						return true;
					}
					IL_0426:
					return result;
				}
				break;
			}
		}
	}

	private bool method_44(Class172 class172_0)
	{
		IntPtr intptr_ = class172_0.method_2();
		Class154 @class = class172_0.method_0();
		GClass5 current = default(GClass5);
		while (true)
		{
			int num = 960955484;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x46521905)) % 6)
				{
				case 5u:
				{
					int num11;
					int num12;
					if (!method_16(intptr_, Class171.smethod_8((long)@class.method_6().method_3().imethod_31(), @class, 0L)))
					{
						num11 = 1492710215;
						num12 = 1492710215;
					}
					else
					{
						num11 = 1705303002;
						num12 = 1705303002;
					}
					num = num11 ^ ((int)num2 * -1485933316);
					continue;
				}
				case 1u:
				{
					int num13;
					if (!method_14(intptr_, @class.method_6().method_3().imethod_31(), Class124.Enum34.flag_5))
					{
						num = 358399375;
						num13 = 358399375;
					}
					else
					{
						num = 2123527904;
						num13 = 2123527904;
					}
					continue;
				}
				case 4u:
					break;
				case 0u:
					return Class171.smethod_127(this, (Exception)new AccessViolationException(Class178.smethod_0(30255)));
				case 2u:
					return Class171.smethod_127(this, (Exception)new AccessViolationException(Class178.smethod_0(30194)));
				default:
				{
					using (List<GClass5>.Enumerator enumerator = @class.method_8().GetEnumerator())
					{
						while (true)
						{
							IL_021a:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 361259423;
								num4 = 361259423;
							}
							else
							{
								num3 = 232625301;
								num4 = 232625301;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x46521905)) % 8)
								{
								case 7u:
									num3 = 361259423;
									continue;
								case 6u:
								{
									IntPtr intptr_2 = intptr_.smethod_9(current.method_4());
									long long_ = current.method_8();
									long long_2 = current.method_6();
									int num7;
									int num8;
									if (method_16(intptr_2, Class171.smethod_8(long_2, @class, long_)))
									{
										num7 = -2068298885;
										num8 = -2068298885;
									}
									else
									{
										num7 = -1180333206;
										num8 = -1180333206;
									}
									num3 = num7 ^ ((int)num2 * -395549553);
									continue;
								}
								case 3u:
								{
									int num9;
									int num10;
									if (((uint)current.method_18() & 0xE0000000u) != 0)
									{
										num9 = -1552759242;
										num10 = -1552759242;
									}
									else
									{
										num9 = -248082589;
										num10 = -248082589;
									}
									num3 = num9 ^ ((int)num2 * -1108527810);
									continue;
								}
								case 2u:
									current = enumerator.Current;
									num3 = 1687962814;
									continue;
								case 1u:
								{
									int num5;
									int num6;
									if ((current.method_18() & Enum41.flag_28) == 0)
									{
										num5 = -1533146314;
										num6 = -1533146314;
									}
									else
									{
										num5 = -201570668;
										num6 = -201570668;
									}
									num3 = num5 ^ (int)(num2 * 617325413);
									continue;
								}
								default:
									goto end_IL_01d9;
								case 4u:
									break;
								case 0u:
									goto end_IL_01d9;
								case 5u:
									return Class171.smethod_127(this, (Exception)new AccessViolationException(Class178.smethod_0(30316)));
								}
								goto IL_021a;
								continue;
								end_IL_01d9:
								break;
							}
							break;
						}
					}
					return true;
				}
				}
				break;
			}
		}
	}

	internal static byte[] smethod_0(Class154 class154_0)
	{
		if (class154_0.method_23() == null)
		{
			uint num = 1502427055u;
			return null;
		}
		using (List<Class138>.Enumerator enumerator = class154_0.method_23().method_0().method_6()
			.GetEnumerator())
		{
			byte[] array = default(byte[]);
			Class139 @class = default(Class139);
			long num3 = default(long);
			byte[] result = default(byte[]);
			while (true)
			{
				IL_0211:
				uint num;
				if (enumerator.MoveNext())
				{
					while (true)
					{
						Class138 current = enumerator.Current;
						int num2 = 502567489;
						while (true)
						{
							switch ((num = (uint)(num2 ^ 0xA11363C)) % 10)
							{
							case 8u:
								break;
							case 7u:
								array = new byte[@class.method_6()];
								num2 = (int)((num * 1415951716) ^ 0x32EEE12F);
								continue;
							case 6u:
								goto IL_006f;
							case 4u:
								num2 = 538610373;
								continue;
							case 3u:
								@class = current.method_6()[0].method_4()[0];
								num3 = Class171.smethod_134(class154_0, @class.method_4());
								num2 = (int)(num * 1828265339) ^ -261597633;
								continue;
							case 2u:
								goto IL_00dd;
							case 1u:
								goto IL_00fa;
							case 0u:
								goto IL_0115;
							case 5u:
								goto end_IL_0134;
							default:
								goto end_IL_016f;
							}
							if (num3 != -1L)
							{
								num2 = ((int)num * -424429248) ^ 0xEDB09DF;
								continue;
							}
							goto IL_0211;
							IL_0115:
							if (current.method_6().Count == 1)
							{
								num2 = (int)((num * 1451034283) ^ 0x64B717E6);
								continue;
							}
							goto IL_0211;
							IL_006f:
							if (current.method_6()[0].method_4().Count == 1)
							{
								num2 = ((int)num * -1399707217) ^ 0x3C57A683;
								continue;
							}
							goto IL_0211;
							IL_00fa:
							if (Class171.smethod_89((Class137)current))
							{
								num2 = ((int)num * -389736534) ^ 0x7318E2BA;
								continue;
							}
							goto IL_0211;
							IL_00dd:
							if (current.method_2() == 24)
							{
								num2 = ((int)num * -529200830) ^ -1001006262;
								continue;
							}
							goto IL_0211;
							continue;
							end_IL_0134:
							break;
						}
						continue;
						end_IL_016f:
						break;
					}
					Stream stream = Class171.smethod_258(class154_0, num3, (int)@class.method_6());
					try
					{
						stream.Read(array, 0, array.Length);
					}
					finally
					{
						if (stream != null)
						{
							while (true)
							{
								IL_01d7:
								int num4 = 1718788360;
								while (true)
								{
									switch ((num = (uint)(num4 ^ 0xA11363C)) % 3)
									{
									case 2u:
										goto IL_01a4;
									default:
										goto end_IL_01b9;
									case 0u:
										break;
									case 1u:
										goto end_IL_01b9;
									}
									goto IL_01d7;
									IL_01a4:
									((IDisposable)stream).Dispose();
									num4 = ((int)num * -572982365) ^ 0x50FA2AF1;
									continue;
									end_IL_01b9:
									break;
								}
								break;
							}
						}
					}
					result = array;
					goto IL_01e3;
				}
				int num5 = 523135499;
				goto IL_01e8;
				IL_01e3:
				num5 = 1437810170;
				goto IL_01e8;
				IL_01e8:
				switch ((num = (uint)(num5 ^ 0xA11363C)) % 4)
				{
				case 0u:
					break;
				default:
					goto end_IL_0211;
				case 1u:
					continue;
				case 3u:
					goto end_IL_0211;
				case 2u:
					return result;
				}
				goto IL_01e3;
				continue;
				end_IL_0211:
				break;
			}
		}
		return null;
	}
}
