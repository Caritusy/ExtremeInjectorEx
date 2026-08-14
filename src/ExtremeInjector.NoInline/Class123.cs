using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public sealed class Class123
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate45(IntPtr intptr_0, uint uint_0, IntPtr intptr_1);

	internal readonly Class154 class154_0;

	internal byte[] byte_0;

	internal Delegate45 delegate45_0;

	internal readonly List<Delegate45> list_0 = new List<Delegate45>();

	internal readonly List<IntPtr> list_1 = new List<IntPtr>();

	[CompilerGenerated]
	internal IntPtr intptr_0;

	internal static readonly Class124.Enum34[][][] enum34_0 = new Class124.Enum34[2][][]
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

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_0()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(IntPtr intptr_1)
	{
		intptr_0 = intptr_1;
	}

	public Class123(Class154 class154_1, bool bool_0)
	{
		class154_0 = class154_1;
		if (class154_0 == null)
		{
			throw smethod_0(Class178.smethod_0(9050));
		}
		if ((Class171.smethod_19(class154_0) && IntPtr.Size != 4) || (!Class171.smethod_19(class154_0) && IntPtr.Size != 8))
		{
			throw smethod_0(Class178.smethod_0(9143));
		}
		method_3(bool_0);
	}

	public Class123(byte[] byte_1, bool bool_0)
		: this(Class171.smethod_356(byte_1, Enum39.const_0), bool_0)
	{
		class154_0.System_002EIDisposable_002EDispose();
	}

	public IntPtr method_2(string string_0)
	{
		if (class154_0.method_14() != null)
		{
			Class152 current = default(Class152);
			while (true)
			{
				int num = 742339305;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x51123B6A)) % 4)
					{
					case 3u:
						num = ((method_0() == IntPtr.Zero) ? 579862374 : 530239405) ^ ((int)num2 * -1074237390);
						continue;
					case 0u:
						break;
					default:
					{
						using (List<Class152>.Enumerator enumerator = class154_0.method_14().list_1.GetEnumerator())
						{
							while (true)
							{
								IL_013c:
								int num3 = (enumerator.MoveNext() ? 500455428 : 1379727625);
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x51123B6A)) % 7)
									{
									case 6u:
										num3 = ((!current.method_0()) ? (-1009009155) : (-504729417)) ^ ((int)num2 * -1625997932);
										continue;
									case 5u:
										current = enumerator.Current;
										num3 = 1555048588;
										continue;
									case 3u:
										num3 = 500455428;
										continue;
									case 2u:
										num3 = ((!smethod_1(current.method_4(), string_0)) ? 2130847947 : 1251945299) ^ ((int)num2 * -1862742474);
										continue;
									default:
										goto end_IL_0100;
									case 1u:
										break;
									case 0u:
										return method_0().smethod_9(current.method_6());
									case 4u:
										goto end_IL_0100;
									}
									goto IL_013c;
									continue;
									end_IL_0100:
									break;
								}
								break;
							}
						}
						return IntPtr.Zero;
					}
					case 2u:
						goto end_IL_0064;
					}
					break;
				}
				continue;
				end_IL_0064:
				break;
			}
		}
		return IntPtr.Zero;
	}

	internal void method_3(bool bool_0)
	{
		method_1(Class171.VirtualAlloc((IntPtr)(long)class154_0.method_6().method_3().imethod_17(), (UIntPtr)class154_0.method_6().method_3().imethod_29(), Class124.Enum33.flag_0 | Class124.Enum33.flag_1, Class124.Enum34.flag_6));
		int num3 = default(int);
		IntPtr intPtr = default(IntPtr);
		Delegate45 @delegate = default(Delegate45);
		IntPtr intptr_ = default(IntPtr);
		IntPtr ptr = default(IntPtr);
		while (true)
		{
			int num = 260601254;
			while (true)
			{
				int num5;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x117FFDAA)) % 6)
				{
				case 5u:
					method_1(Class171.VirtualAlloc(IntPtr.Zero, (UIntPtr)class154_0.method_6().method_3().imethod_29(), Class124.Enum33.flag_0 | Class124.Enum33.flag_1, Class124.Enum34.flag_6));
					num = ((int)num2 * -340455340) ^ 0x7EDC680E;
					continue;
				case 4u:
					if (bool_0)
					{
						num = 805512371;
						continue;
					}
					goto IL_01a9;
				case 3u:
					num3 = (int)(class154_0.method_4().method_0() + class154_0.method_6().method_3().imethod_31());
					num = (int)((num2 * 635183290) ^ 0x299F427B);
					continue;
				case 2u:
					num = ((method_0() == IntPtr.Zero) ? 1455457057 : 1970392274) ^ (int)(num2 * 1419251504);
					continue;
				case 0u:
					break;
				default:
					{
						Stream stream = Class171.smethod_264(class154_0, 0L, num3);
						try
						{
							byte[] array = new byte[num3];
							smethod_2(stream, array, 0, num3);
							smethod_3(array, 0, method_0(), array.Length);
						}
						finally
						{
							if (stream != null)
							{
								while (true)
								{
									IL_01a1:
									int num4 = 1983548963;
									while (true)
									{
										switch ((num2 = (uint)(num4 ^ 0x117FFDAA)) % 3)
										{
										case 1u:
											goto IL_016f;
										default:
											goto end_IL_0183;
										case 2u:
											break;
										case 0u:
											goto end_IL_0183;
										}
										goto IL_01a1;
										IL_016f:
										smethod_4(stream);
										num4 = ((int)num2 * -1808670385) ^ 0x8F77CCB;
										continue;
										end_IL_0183:
										break;
									}
									break;
								}
							}
						}
						goto IL_01a9;
					}
					IL_02a5:
					while (true)
					{
						switch ((num2 = (uint)(num5 ^ 0x117FFDAA)) % 8)
						{
						case 7u:
							intPtr = method_0().smethod_11((IntPtr)(long)class154_0.method_6().method_3().imethod_17());
							num5 = ((!(intPtr != IntPtr.Zero)) ? (-585005110) : (-1120154205)) ^ (int)(num2 * 1045305611);
							continue;
						case 6u:
							num5 = ((class154_0.method_12() != null) ? 846817551 : 70638956) ^ (int)(num2 * 452207053);
							continue;
						case 4u:
							method_7(intPtr);
							num5 = (int)((num2 * 1431207292) ^ 0x6A15C72F);
							continue;
						case 3u:
							method_5(class154_0.method_12());
							num5 = ((int)num2 * -1361479710) ^ -1427740548;
							continue;
						case 2u:
							break;
						case 0u:
							method_4();
							if (class154_0.method_20() != null)
							{
								num5 = 1777164387;
								continue;
							}
							goto IL_0444;
						case 5u:
							goto IL_02d7;
						default:
							{
								using (List<ulong>.Enumerator enumerator = class154_0.method_20().list_0.GetEnumerator())
								{
									while (true)
									{
										IL_03f6:
										int num6 = ((!enumerator.MoveNext()) ? 1472455921 : 1469868183);
										while (true)
										{
											switch ((num2 = (uint)(num6 ^ 0x117FFDAA)) % 7)
											{
											case 6u:
												num6 = ((!@delegate(method_0(), 1u, IntPtr.Zero)) ? (-1357459098) : (-1913119951)) ^ ((int)num2 * -2087430669);
												continue;
											case 5u:
											{
												long long_ = (long)(enumerator.Current - class154_0.method_6().method_3().imethod_17());
												intptr_ = method_0().smethod_9(long_);
												@delegate = (Delegate45)smethod_6(intptr_, smethod_5(typeof(Delegate45).TypeHandle));
												num6 = 282984025;
												continue;
											}
											case 4u:
												num6 = 1469868183;
												continue;
											case 3u:
												list_0.Add(@delegate);
												num6 = 1560941743;
												continue;
											default:
												goto end_IL_03b9;
											case 1u:
												break;
											case 2u:
												throw new Exception(Class178.smethod_0(9232) + intptr_.ToString(Class178.smethod_0(2077)) + Class178.smethod_0(9277));
											case 0u:
												goto end_IL_03b9;
											}
											goto IL_03f6;
											continue;
											end_IL_03b9:
											break;
										}
										break;
									}
								}
								goto IL_0444;
							}
							IL_0444:
							if (class154_0.method_6().method_3().imethod_11() == 0)
							{
								return;
							}
							while (true)
							{
								int num7 = 327313796;
								while (true)
								{
									switch ((num2 = (uint)(num7 ^ 0x117FFDAA)) % 6)
									{
									case 4u:
										delegate45_0 = (Delegate45)Marshal.GetDelegateForFunctionPointer(ptr, typeof(Delegate45));
										num7 = ((int)num2 * -1138151904) ^ 0x2D0B3C1A;
										continue;
									case 2u:
										ptr = method_0().smethod_9(class154_0.method_6().method_3().imethod_11());
										num7 = (int)((num2 * 1803130763) ^ 0x25923F1A);
										continue;
									case 0u:
										num7 = (delegate45_0(method_0(), 1u, IntPtr.Zero) ? 1728218715 : 496342275) ^ (int)(num2 * 611274671);
										continue;
									default:
										return;
									case 3u:
										break;
									case 5u:
										throw new Exception(Class178.smethod_0(9302));
									case 1u:
										return;
									}
									break;
								}
							}
						}
						break;
					}
					goto IL_0283;
					IL_0283:
					num5 = 62016085;
					goto IL_02a5;
					IL_02d7:
					method_5(class154_0.method_10());
					num5 = 2120980932;
					goto IL_02a5;
					IL_01a9:
					method_8();
					if (class154_0.method_16() != null)
					{
						goto IL_0283;
					}
					goto IL_02d7;
				}
				break;
			}
		}
	}

	internal void method_4()
	{
		using List<GClass5>.Enumerator enumerator = class154_0.method_8().GetEnumerator();
		IntPtr intPtr = default(IntPtr);
		GClass5 current = default(GClass5);
		Class124.Enum34 @enum = default(Class124.Enum34);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = ((!enumerator.MoveNext()) ? (-1402551245) : (-1596922742));
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1213338732)) % 16)
				{
				case 15u:
				{
					num = (Class171.VirtualProtect(intPtr, (UIntPtr)current.method_2(), @enum, out var _) ? (-589755059) : (-1977212153));
					continue;
				}
				case 14u:
					current = enumerator.Current;
					num = -527340158;
					continue;
				case 13u:
					num = (int)(num2 * 1653250439) ^ -65422842;
					continue;
				case 12u:
					@enum |= Class124.Enum34.flag_9;
					num = (int)(num2 * 1488485688) ^ -2016374197;
					continue;
				case 11u:
					flag2 = (current.method_18() & Enum41.flag_32) == Enum41.flag_32;
					num = (int)((num2 * 265695382) ^ 0x48EFD9FC);
					continue;
				case 10u:
					@enum = enum34_0[flag2 ? 1 : 0][flag ? 1 : 0][flag3 ? 1 : 0];
					num = -160958575;
					continue;
				case 8u:
					num = -1596922742;
					continue;
				case 6u:
					intPtr = method_0().smethod_9(current.method_4());
					num = ((int)num2 * -1500544271) ^ -177199533;
					continue;
				case 5u:
					num = (((current.method_18() & Enum41.flag_29) == Enum41.flag_29) ? 367274172 : 21435023) ^ ((int)num2 * -1919896556);
					continue;
				case 4u:
					flag3 = ((uint)current.method_18() & 0x80000000u) == 2147483648u;
					num = -2077752044;
					continue;
				case 2u:
					Class171.VirtualFree(intPtr, (UIntPtr)current.method_2(), Class124.Enum28.const_0);
					num = (int)(num2 * 1710128443) ^ -1352362481;
					continue;
				case 1u:
					num = (((current.method_18() & Enum41.flag_28) == Enum41.flag_28) ? 89184410 : 1989304220) ^ ((int)num2 * -1708357636);
					continue;
				case 0u:
					flag = (current.method_18() & Enum41.flag_33) == Enum41.flag_33;
					num = ((int)num2 * -74747938) ^ 0x550FEB7F;
					continue;
				default:
					return;
				case 9u:
					break;
				case 3u:
					throw smethod_8(smethod_7(Class178.smethod_0(9359), current.method_0(), Class178.smethod_0(9428)));
				case 7u:
					return;
				}
				break;
			}
		}
	}

	internal void method_5(Class148 class148_0)
	{
		if (byte_0 == null)
		{
			goto IL_0407;
		}
		goto IL_0462;
		IL_0407:
		int num = 1804930605;
		goto IL_040c;
		IL_040c:
		IntPtr intPtr2 = default(IntPtr);
		Class160 @class = default(Class160);
		Class164 current = default(Class164);
		IntPtr ptr = default(IntPtr);
		IntPtr procAddress = default(IntPtr);
		string text2 = default(string);
		string text = default(string);
		int num3 = default(int);
		string string_ = default(string);
		IntPtr intPtr = default(IntPtr);
		Class124.Struct50 struct50_ = default(Class124.Struct50);
		Class124.Struct50 @struct = default(Class124.Struct50);
		IntPtr intptr_ = default(IntPtr);
		while (true)
		{
			int num4;
			uint num2;
			switch ((num2 = (uint)(num ^ 0x1873A9D2)) % 16)
			{
			case 15u:
				byte_0 = method_6();
				num = (int)((num2 * 268824538) ^ 0xA8782A5);
				continue;
			default:
			{
				list_1.Add(intPtr2);
				using (List<Class164>.Enumerator enumerator = @class.method_8().GetEnumerator())
				{
					while (true)
					{
						IL_0181:
						int num5 = (enumerator.MoveNext() ? 1390609119 : 1747258426);
						while (true)
						{
							string text3;
							switch ((num2 = (uint)(num5 ^ 0x1873A9D2)) % 10)
							{
							case 9u:
								if (!current.method_7())
								{
									num5 = ((int)num2 * -885374630) ^ 0x5558B184;
									continue;
								}
								text3 = ((char)current.method_2()).ToString();
								goto IL_008c;
							case 7u:
								current = enumerator.Current;
								num5 = 1702176539;
								continue;
							case 6u:
								Marshal.WriteIntPtr(ptr, procAddress);
								num5 = 331797833;
								continue;
							case 4u:
								text3 = current.method_4();
								goto IL_008c;
							case 3u:
								num5 = (current.method_7() ? 1829536513 : 1653773924) ^ (int)(num2 * 259235203);
								continue;
							case 2u:
								num5 = 1390609119;
								continue;
							case 1u:
								ptr = ptr.smethod_8(IntPtr.Size);
								num5 = (int)((num2 * 1862926143) ^ 0x39A1D363);
								continue;
							default:
								goto end_IL_0137;
							case 8u:
								break;
							case 5u:
								throw new MissingMethodException(Class178.smethod_0(9531) + text2 + Class178.smethod_0(9572) + text + Class178.smethod_0(9428));
							case 0u:
								goto end_IL_0137;
								IL_008c:
								text2 = text3;
								procAddress = Class171.GetProcAddress(intPtr2, text2);
								num5 = ((procAddress == IntPtr.Zero) ? 1950460853 : 1264182964);
								continue;
							}
							goto IL_0181;
							continue;
							end_IL_0137:
							break;
						}
						break;
					}
				}
				num3++;
				goto IL_028a;
			}
			case 7u:
				@class = class148_0.list_0[num3];
				num = 1920705278;
				continue;
			case 13u:
				smethod_12(string_);
				num = (int)((num2 * 1798582805) ^ 0x1A4ADEF7);
				continue;
			case 12u:
				ptr = method_0().smethod_9(@class.method_6());
				text = @class.method_12();
				intPtr2 = Class171.LoadLibrary(text);
				num = (int)(num2 * 135139657) ^ -1901204117;
				continue;
			case 11u:
				intPtr = Class171.CreateActCtx(ref struct50_);
				num = (int)(num2 * 1445532307) ^ -2063136879;
				continue;
			case 10u:
				struct50_ = @struct;
				num = (int)(num2 * 779891160) ^ -1566938295;
				continue;
			case 9u:
				string_ = smethod_9();
				smethod_10(string_, byte_0);
				@struct = new Class124.Struct50
				{
					int_0 = smethod_11(smethod_5(typeof(Class124.Struct50).TypeHandle))
				};
				num = ((int)num2 * -160655409) ^ 0x340D383D;
				continue;
			case 8u:
				@struct.string_0 = string_;
				num = (int)(num2 * 863650284) ^ -1560012040;
				continue;
			case 5u:
				num = ((intPtr2 == IntPtr.Zero) ? 650602354 : 2004080394) ^ ((int)num2 * -128713954);
				continue;
			case 4u:
				num3 = 0;
				goto IL_0233;
			case 3u:
				num = ((byte_0 == null) ? (-1390388946) : (-1091420621)) ^ (int)(num2 * 1970447688);
				continue;
			case 2u:
				Class171.ActivateActCtx(intPtr, out intptr_);
				num = (int)(num2 * 64338315) ^ -399179831;
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0462;
			case 6u:
				{
					throw smethod_13(smethod_7(Class178.smethod_0(9433), text, Class178.smethod_0(9470)));
				}
				IL_028a:
				num4 = 1738503077;
				goto IL_025d;
				IL_0233:
				if (num3 >= class148_0.list_0.Count)
				{
					num4 = 558247891;
					goto IL_025d;
				}
				goto case 7u;
				IL_025d:
				while (true)
				{
					switch ((num2 = (uint)(num4 ^ 0x1873A9D2)) % 6)
					{
					case 5u:
						num4 = ((!(intPtr != Class124.intptr_0)) ? (-1703510730) : (-1010767337)) ^ ((int)num2 * -745611041);
						continue;
					case 2u:
						Class171.DeactivateActCtx(0, intptr_);
						num4 = (int)(num2 * 932969794) ^ -425408292;
						continue;
					case 1u:
						break;
					case 0u:
						Class171.ReleaseActCtx(intPtr);
						num4 = ((int)num2 * -575237789) ^ 0x7552C507;
						continue;
					default:
						return;
					case 4u:
						goto IL_028a;
					case 3u:
						return;
					}
					break;
				}
				goto IL_0233;
			}
			break;
		}
		goto IL_0407;
		IL_0462:
		intPtr = Class124.intptr_0;
		intptr_ = IntPtr.Zero;
		num = 321463233;
		goto IL_040c;
	}

	internal byte[] method_6()
	{
		if (class154_0.method_23() == null)
		{
			return null;
		}
		using (List<Class138>.Enumerator enumerator = class154_0.method_23().method_0().method_6()
			.GetEnumerator())
		{
			byte[] array = default(byte[]);
			Class139 @class = default(Class139);
			long num3 = default(long);
			while (true)
			{
				IL_018a:
				if (enumerator.MoveNext())
				{
					while (true)
					{
						Class138 current = enumerator.Current;
						if (!Class171.smethod_89(current))
						{
							break;
						}
						int num = -2087601535;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num ^ -963708238)) % 8)
							{
							case 6u:
								num = -878729869;
								continue;
							case 5u:
								break;
							case 4u:
								goto IL_006f;
							case 3u:
								goto IL_00b8;
							case 2u:
								array = new byte[@class.method_6()];
								num = ((int)num2 * -1602372209) ^ -281955517;
								continue;
							case 0u:
								goto IL_00f2;
							case 1u:
								goto end_IL_0119;
							default:
							{
								Stream stream = Class171.smethod_264(class154_0, num3, (int)@class.method_6());
								try
								{
									smethod_2(stream, array, 0, array.Length);
								}
								finally
								{
									if (stream != null)
									{
										while (true)
										{
											IL_01f5:
											int num4 = -162609231;
											while (true)
											{
												switch ((num2 = (uint)(num4 ^ -963708238)) % 3)
												{
												case 1u:
													goto IL_01c2;
												default:
													goto end_IL_01d7;
												case 2u:
													break;
												case 0u:
													goto end_IL_01d7;
												}
												goto IL_01f5;
												IL_01c2:
												smethod_4(stream);
												num4 = (int)(num2 * 1800163400) ^ -136476875;
												continue;
												end_IL_01d7:
												break;
											}
											break;
										}
									}
								}
								return array;
							}
							}
							if (current.method_6().Count != 1)
							{
								goto end_IL_014b;
							}
							num = (int)(num2 * 299644177) ^ -254995441;
							continue;
							IL_00f2:
							if (current.method_6()[0].method_4().Count != 1)
							{
								goto end_IL_014b;
							}
							num = ((int)num2 * -472058656) ^ 0x2ABE97A6;
							continue;
							IL_006f:
							@class = current.method_6()[0].method_4()[0];
							num3 = Class171.smethod_135(class154_0, @class.method_4());
							if (num3 == -1L)
							{
								goto end_IL_014b;
							}
							num = ((int)num2 * -766553490) ^ -1967358600;
							continue;
							IL_00b8:
							if (current.method_2() != 24)
							{
								goto end_IL_014b;
							}
							num = ((int)num2 * -1886874506) ^ 0x189FEA75;
							continue;
							end_IL_0119:
							break;
						}
						continue;
						end_IL_014b:
						break;
					}
					continue;
				}
				int num5 = -778180213;
				while (true)
				{
					switch ((uint)(num5 ^ -963708238) % 3u)
					{
					case 0u:
						goto IL_0167;
					default:
						goto end_IL_016c;
					case 2u:
						break;
					case 1u:
						goto end_IL_016c;
					}
					goto IL_018a;
					IL_0167:
					num5 = -2110580705;
					continue;
					end_IL_016c:
					break;
				}
				break;
			}
		}
		return null;
	}

	internal void method_7(IntPtr intptr_1)
	{
		using List<Class145>.Enumerator enumerator = class154_0.method_16().list_0.GetEnumerator();
		Class144 current2 = default(Class144);
		while (enumerator.MoveNext())
		{
			Class145 current;
			while (true)
			{
				current = enumerator.Current;
				int num = 167717031;
				while (true)
				{
					switch ((uint)(num ^ 0x7A4CEEF7) % 3u)
					{
					case 0u:
						num = 2120892504;
						continue;
					case 1u:
						break;
					default:
						goto end_IL_003f;
					}
					break;
				}
				continue;
				end_IL_003f:
				break;
			}
			using List<Class144>.Enumerator enumerator2 = current.list_0.GetEnumerator();
			while (true)
			{
				IL_014d:
				int num2 = (enumerator2.MoveNext() ? 518109338 : 1306731277);
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x7A4CEEF7)) % 7)
					{
					case 4u:
					{
						IntPtr intptr_2 = method_0().smethod_9(current.method_0() + current2.method_0());
						IntPtr intPtr = smethod_14(intptr_2);
						smethod_15(intptr_2, intPtr.smethod_10(intptr_1));
						num2 = 215852847;
						continue;
					}
					case 3u:
						current2 = enumerator2.Current;
						num2 = 766207216;
						continue;
					case 2u:
						num2 = ((current2.method_2() == GEnum0.Dir64) ? 1455383491 : 2138725752) ^ (int)(num3 * 1819977700);
						continue;
					case 1u:
						num2 = ((current2.method_2() == GEnum0.HighLow) ? (-636323674) : (-1863859338)) ^ ((int)num3 * -591222589);
						continue;
					case 0u:
						num2 = 518109338;
						continue;
					default:
						goto end_IL_0110;
					case 6u:
						break;
					case 5u:
						goto end_IL_0110;
					}
					goto IL_014d;
					continue;
					end_IL_0110:
					break;
				}
				break;
			}
		}
	}

	internal void method_8()
	{
		using List<GClass5>.Enumerator enumerator = class154_0.method_8().GetEnumerator();
		IntPtr intPtr = default(IntPtr);
		while (enumerator.MoveNext())
		{
			while (true)
			{
				GClass5 current = enumerator.Current;
				int num = 760558970;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x30D910E)) % 6)
					{
					case 4u:
						intPtr = Class171.VirtualAlloc(method_0().smethod_9(current.method_4()), (UIntPtr)current.method_2(), Class124.Enum33.flag_0, Class124.Enum34.flag_6);
						num = (int)(num2 * 2126619850) ^ -1641845279;
						continue;
					case 2u:
						num = 875269217;
						continue;
					case 0u:
						num = ((current.method_6() == 0) ? 190063708 : 445410953) ^ (int)(num2 * 960640415);
						continue;
					case 5u:
						break;
					default:
						goto IL_00b9;
					case 3u:
						goto IL_0199;
					}
					break;
				}
				continue;
				IL_00b9:
				IntPtr intptr_ = Class171.VirtualAlloc(method_0().smethod_9(current.method_4()), (UIntPtr)current.method_6(), Class124.Enum33.flag_0, Class124.Enum34.flag_6);
				Stream stream = Class171.smethod_264(class154_0, current.method_8(), (int)current.method_6());
				try
				{
					byte[] array = new byte[current.method_6()];
					while (true)
					{
						IL_0151:
						int num3 = 1047257093;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num3 ^ 0x30D910E)) % 3)
							{
							case 2u:
								goto IL_010a;
							default:
								goto end_IL_0133;
							case 0u:
								break;
							case 1u:
								goto end_IL_0133;
							}
							goto IL_0151;
							IL_010a:
							smethod_2(stream, array, 0, array.Length);
							smethod_3(array, 0, intptr_, array.Length);
							num3 = (int)(num2 * 1251475833) ^ -1605609777;
							continue;
							end_IL_0133:
							break;
						}
						break;
					}
				}
				finally
				{
					if (stream != null)
					{
						while (true)
						{
							IL_0191:
							int num4 = 1264855615;
							while (true)
							{
								uint num2;
								switch ((num2 = (uint)(num4 ^ 0x30D910E)) % 3)
								{
								case 2u:
									goto IL_015f;
								default:
									goto end_IL_0173;
								case 0u:
									break;
								case 1u:
									goto end_IL_0173;
								}
								goto IL_0191;
								IL_015f:
								smethod_4(stream);
								num4 = (int)(num2 * 1757051259) ^ -349019271;
								continue;
								end_IL_0173:
								break;
							}
							break;
						}
					}
				}
				break;
				IL_0199:
				long long_ = current.method_2();
				Class171.smethod_361(long_, intPtr, 0);
				break;
			}
		}
	}

	internal static BadImageFormatException smethod_0(string string_0)
	{
		return new BadImageFormatException(string_0);
	}

	internal static bool smethod_1(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	internal static int smethod_2(Stream stream_0, byte[] byte_1, int int_0, int int_1)
	{
		return stream_0.Read(byte_1, int_0, int_1);
	}

	internal static void smethod_3(byte[] byte_1, int int_0, IntPtr intptr_1, int int_1)
	{
		Marshal.Copy(byte_1, int_0, intptr_1, int_1);
	}

	internal static void smethod_4(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static Type smethod_5(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static Delegate smethod_6(IntPtr intptr_1, Type type_0)
	{
		return Marshal.GetDelegateForFunctionPointer(intptr_1, type_0);
	}

	internal static string smethod_7(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	internal static AccessViolationException smethod_8(string string_0)
	{
		return new AccessViolationException(string_0);
	}

	internal static string smethod_9()
	{
		return Path.GetTempFileName();
	}

	internal static void smethod_10(string string_0, byte[] byte_1)
	{
		File.WriteAllBytes(string_0, byte_1);
	}

	internal static int smethod_11(Type type_0)
	{
		return Marshal.SizeOf(type_0);
	}

	internal static void smethod_12(string string_0)
	{
		File.Delete(string_0);
	}

	internal static DllNotFoundException smethod_13(string string_0)
	{
		return new DllNotFoundException(string_0);
	}

	internal static IntPtr smethod_14(IntPtr intptr_1)
	{
		return Marshal.ReadIntPtr(intptr_1);
	}

	internal static void smethod_15(IntPtr intptr_1, IntPtr intptr_2)
	{
		Marshal.WriteIntPtr(intptr_1, intptr_2);
	}
}
