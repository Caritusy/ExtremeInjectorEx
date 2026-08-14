using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public abstract class Class82
{
	[CompilerGenerated]
	internal int int_0;

	[CompilerGenerated]
	internal IntPtr intptr_0;

	[CompilerGenerated]
	internal bool bool_0;

	[CompilerGenerated]
	internal Interface4 interface4_0;

	[SpecialName]
	[CompilerGenerated]
	public int method_0()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(int int_1)
	{
		int_0 = int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_2()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(IntPtr intptr_1)
	{
		intptr_0 = intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	protected bool method_4()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void method_5(bool bool_1)
	{
		bool_0 = bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Interface4 method_6()
	{
		return interface4_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(Interface4 interface4_1)
	{
		interface4_0 = interface4_1;
	}

	protected Class82()
	{
	}

	protected Class82(int int_1)
	{
		method_1(int_1);
	}

	protected Class82(IntPtr intptr_1)
	{
		method_1(-1);
		method_3(intptr_1);
	}

	protected internal bool method_8(int int_1)
	{
		if (method_0() == int_1)
		{
			goto IL_0063;
		}
		goto IL_00ad;
		IL_0063:
		int num = 1595839285;
		goto IL_0075;
		IL_0075:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x70DF9FF)) % 6)
			{
			case 5u:
				Class171.smethod_382(this);
				num = (int)(num2 * 1667698859) ^ -134411775;
				continue;
			case 4u:
				num = ((!(method_2() == IntPtr.Zero)) ? (-1635608137) : (-2036786163)) ^ (int)(num2 * 368427887);
				continue;
			case 3u:
				break;
			case 1u:
				method_033E();
				num = 1586999841;
				continue;
			case 2u:
				goto IL_00ad;
			default:
				return method_2() != IntPtr.Zero;
			}
			break;
		}
		goto IL_0063;
		IL_00ad:
		method_1(int_1);
		num = ((method_2() != IntPtr.Zero) ? 1598794518 : 622590882);
		goto IL_0075;
	}

	protected virtual void method_033E()
	{
		if (method_6() != null)
		{
			goto IL_009c;
		}
		goto IL_00dd;
		IL_009c:
		int num = 1433952686;
		goto IL_00a1;
		IL_00a1:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x60560DFA)) % 7)
			{
			case 5u:
				num = ((method_0() != -1) ? (-615405581) : (-2129007163)) ^ ((int)num2 * -100998560);
				continue;
			case 3u:
				method_3(method_6().imethod_0(method_2(), method_0()));
				num = (int)((num2 * 1327041644) ^ 0x45ED885E);
				continue;
			case 1u:
				method_3(Class171.OpenProcess(Class124.Enum32.flag_3 | Class124.Enum32.flag_4 | Class124.Enum32.flag_5 | Class124.Enum32.flag_9, false, method_0()));
				num = (int)(num2 * 1242210235) ^ -2046732586;
				continue;
			case 0u:
				break;
			default:
				return;
			case 6u:
				goto IL_00dd;
			case 2u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_009c;
		IL_00dd:
		num = ((method_2() == IntPtr.Zero) ? 1752110752 : 1047156741);
		goto IL_00a1;
	}

	protected virtual void vmethod_0(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0, out UIntPtr uintptr_1)
	{
		if (method_6() != null)
		{
			goto IL_003f;
		}
		goto IL_00a8;
		IL_003f:
		int num = -385783800;
		goto IL_0068;
		IL_0068:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1200976450)) % 8)
			{
			case 6u:
				method_6().imethod_1(method_2(), intptr_1, intptr_2, uintptr_0, out uintptr_1);
				num = ((int)num2 * -2098037020) ^ -1123213011;
				continue;
			case 5u:
				break;
			case 0u:
				goto IL_0046;
			default:
				return;
			case 1u:
				goto IL_00a8;
			case 2u:
				throw new AccessViolationException(Class178.smethod_0(10098));
			case 3u:
				return;
			case 4u:
				throw new AccessViolationException(Class178.smethod_0(10167));
			case 7u:
				return;
			}
			break;
			IL_0046:
			num = ((uintptr_0 != uintptr_1) ? (-1070701670) : (-1686700527));
		}
		goto IL_003f;
		IL_00a8:
		num = (Class171.ReadProcessMemory(method_2(), intptr_1, intptr_2, uintptr_0, out uintptr_1) ? (-2031890754) : (-881388508));
		goto IL_0068;
	}

	protected void method_9(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0)
	{
		vmethod_0(intptr_1, intptr_2, uintptr_0, out var _);
	}

	protected internal unsafe T[] method_10<T>(IntPtr intptr_1, int int_1)
	{
		method_033E();
		Type typeFromHandle = typeof(T);
		int num3 = default(int);
		IntPtr intPtr = default(IntPtr);
		int num5 = default(int);
		T[] array2 = default(T[]);
		int num4 = default(int);
		while (true)
		{
			int num = 470244359;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6EE7003A)) % 13)
				{
				case 12u:
					num = ((num3 >= int_1) ? 616256653 : 2143025834);
					continue;
				case 11u:
					num = (((object)typeFromHandle == typeof(byte)) ? 333265105 : 1419965326) ^ (int)(num2 * 2080664007);
					continue;
				case 10u:
					method_9(intptr_1, intPtr, (UIntPtr)(ulong)num5);
					num = (int)((num2 * 152518604) ^ 0x7800FDCB);
					continue;
				case 9u:
					array2[num3] = (T)Marshal.PtrToStructure(intPtr.smethod_8(num3 * num4), typeFromHandle);
					num = 1359727763;
					continue;
				case 7u:
					num3++;
					num = (int)((num2 * 1530757104) ^ 0x60252A10);
					continue;
				case 6u:
					num5 = num4 * int_1;
					intPtr = Marshal.AllocHGlobal(num5);
					num = ((int)num2 * -1162596833) ^ 0x57D6A179;
					continue;
				case 4u:
					array2 = new T[int_1];
					num3 = 0;
					num = (int)(num2 * 824991062) ^ -1804981015;
					continue;
				case 3u:
					num = ((int)num2 * -2145533749) ^ 0x1192D62F;
					continue;
				case 2u:
					Marshal.FreeHGlobal(intPtr);
					num = ((int)num2 * -1883766700) ^ -2038812260;
					continue;
				case 1u:
					num4 = Class127.smethod_1<T>();
					num = 348449136;
					continue;
				case 0u:
					break;
				default:
					return array2;
				case 8u:
				{
					byte[] array = new byte[int_1];
					fixed (byte* ptr = array)
					{
						method_9(intptr_1, (IntPtr)ptr, (UIntPtr)(ulong)int_1);
					}
					return (T[])(object)array;
				}
				}
				break;
			}
		}
	}

	protected internal T method_11<T>(IntPtr intptr_1)
	{
		return (T)method_12(typeof(T), intptr_1);
	}

	protected object method_12(Type type_0, IntPtr intptr_1)
	{
		method_033E();
		IntPtr intPtr = default(IntPtr);
		int num3 = default(int);
		while (true)
		{
			int num = 1167510435;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x377E4EA4)) % 5)
				{
				case 4u:
					method_9(intptr_1, intPtr, (UIntPtr)(ulong)num3);
					num = ((int)num2 * -1993257576) ^ 0x216C11A0;
					continue;
				case 3u:
					intPtr = Marshal.AllocHGlobal(num3);
					num = ((int)num2 * -1702563931) ^ -1967131956;
					continue;
				case 1u:
					num3 = Class171.smethod_226(type_0);
					num = (int)(num2 * 1922045043) ^ -1565877597;
					continue;
				case 2u:
					break;
				default:
				{
					object result = Marshal.PtrToStructure(intPtr, type_0);
					Marshal.FreeHGlobal(intPtr);
					return result;
				}
				}
				break;
			}
		}
	}

	protected internal bool method_13<T>(IntPtr intptr_1, T gparam_0)
	{
		method_033E();
		int num = Class127.smethod_1<T>();
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr((object)gparam_0, intPtr, false);
		bool result = vmethod_2(intPtr, intptr_1, (UIntPtr)(ulong)num);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	protected virtual bool vmethod_1(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0)
	{
		if (method_6() != null)
		{
			return method_6().imethod_2(method_2(), intptr_1, intptr_2, uintptr_0);
		}
		UIntPtr uintptr_1;
		return Class171.WriteProcessMemory(method_2(), intptr_2, intptr_1, uintptr_0, out uintptr_1);
	}

	protected virtual bool vmethod_2(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0)
	{
		bool result;
		if (!(result = vmethod_1(intptr_1, intptr_2, uintptr_0)))
		{
			Class124.Enum34 enum34_ = default(Class124.Enum34);
			while (true)
			{
				int num = -1839300980;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -227389281)) % 8)
					{
					case 7u:
						num = (vmethod_3(intptr_2, (long)(ulong)uintptr_0, Class124.Enum34.flag_2, out enum34_) ? (-1329699852) : (-1499714597)) ^ ((int)num2 * -1791973513);
						continue;
					case 6u:
						num = ((!method_14(intptr_2, (long)(ulong)uintptr_0, enum34_)) ? 1519582070 : 1165967935) ^ ((int)num2 * -343055114);
						continue;
					case 4u:
						result = true;
						num = -1226050898;
						continue;
					case 3u:
						num = ((!method_4()) ? 1221249108 : 1369587770) ^ (int)(num2 * 2000711774);
						continue;
					case 2u:
						num = ((!vmethod_1(intptr_1, intptr_2, uintptr_0)) ? 1278191302 : 864391181) ^ ((int)num2 * -1944854566);
						continue;
					case 0u:
						break;
					case 5u:
						throw new AccessViolationException(Class178.smethod_0(10244));
					default:
						goto end_IL_010a;
					}
					break;
				}
				continue;
				end_IL_010a:
				break;
			}
		}
		return result;
	}

	protected virtual bool vmethod_3(IntPtr intptr_1, long long_0, Class124.Enum34 enum34_0, out Class124.Enum34 enum34_1)
	{
		if (method_6() != null)
		{
			return method_6().imethod_3(method_2(), intptr_1, long_0, enum34_0, out enum34_1);
		}
		return Class171.VirtualProtectEx(method_2(), intptr_1, (UIntPtr)(ulong)long_0, enum34_0, out enum34_1);
	}

	protected bool method_14(IntPtr intptr_1, long long_0, Class124.Enum34 enum34_0)
	{
		Class124.Enum34 enum34_1;
		return vmethod_3(intptr_1, long_0, enum34_0, out enum34_1);
	}

	protected virtual IntPtr vmethod_4(IntPtr intptr_1, long long_0, Class124.Enum34 enum34_0)
	{
		if (method_6() != null)
		{
			return method_6().imethod_4(method_2(), intptr_1, long_0, enum34_0);
		}
		return Class171.VirtualAllocEx(method_2(), intptr_1, (UIntPtr)(ulong)long_0, Class124.Enum33.flag_0 | Class124.Enum33.flag_1, enum34_0);
	}

	protected internal IntPtr method_15(IntPtr intptr_1, long long_0, Class124.Enum34 enum34_0)
	{
		IntPtr result;
		if ((result = vmethod_4(intptr_1, long_0, enum34_0)) == IntPtr.Zero)
		{
			while (true)
			{
				int num = -1530995422;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -350052097)) % 4)
					{
					case 1u:
						num = ((!(intptr_1 != IntPtr.Zero)) ? (-1014807711) : (-849098780)) ^ ((int)num2 * -1330390856);
						continue;
					case 0u:
						break;
					case 3u:
						return method_15(IntPtr.Zero, long_0, enum34_0);
					default:
						goto end_IL_0066;
					}
					break;
				}
				continue;
				end_IL_0066:
				break;
			}
		}
		return result;
	}

	protected virtual bool vmethod_5(IntPtr intptr_1, long long_0, Class124.Enum28 enum28_0)
	{
		if (method_6() != null)
		{
			return method_6().imethod_5(method_2(), intptr_1, long_0, enum28_0);
		}
		return Class171.VirtualFreeEx(method_2(), intptr_1, (UIntPtr)(ulong)long_0, enum28_0);
	}

	protected virtual bool vmethod_6(IntPtr intptr_1)
	{
		return Class171.VirtualFreeEx(method_2(), intptr_1, UIntPtr.Zero, Class124.Enum28.const_1);
	}

	protected internal unsafe bool method_16<T>(IntPtr intptr_1, T[] gparam_0)
	{
		//The blocks IL_000f, IL_0025, IL_002c, IL_0038, IL_0048, IL_0061, IL_008a, IL_0097, IL_00a3, IL_00ad, IL_00bc, IL_00d2, IL_00de, IL_00e8, IL_00f7, IL_0110, IL_012b, IL_014f, IL_0155, IL_0161, IL_016b, IL_0177, IL_017c, IL_0188, IL_0193, IL_01ea, IL_01f1, IL_01f3, IL_020d are reachable both inside and outside the pinned region starting at IL_007e. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		method_033E();
		int num = gparam_0.Length;
		int num6 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		int num5 = default(int);
		int num7 = default(int);
		IntPtr intPtr = default(IntPtr);
		ref byte reference = default(ref byte);
		while (true)
		{
			int num2 = -882941663;
			while (true)
			{
				uint num4;
				uint num3 = (num4 = (uint)(num2 ^ -1379078069));
				byte[] array3;
				int num9;
				int num10;
				int num8;
				bool result;
				switch (num3 % 17)
				{
				case 16u:
					num6 = 0;
					num2 = (int)(num4 * 1947204945) ^ -2033342606;
					continue;
				case 15u:
					array3 = (array2 = array);
					num2 = ((array3 == null) ? (-1570812199) : (-2081574380));
					continue;
				case 13u:
					num6++;
					num2 = ((int)num4 * -1266125014) ^ 0x436232DB;
					continue;
				case 12u:
					num5 = num7 * num;
					intPtr = Marshal.AllocHGlobal(num5);
					num2 = -1799240452;
					continue;
				case 10u:
					while (true)
					{
						fixed (byte* ptr = &array2[0])
						{
							num2 = -1494994142;
							while (true)
							{
								num3 = (num4 = (uint)(num2 ^ -1379078069));
								switch (num3 % 17)
								{
								case 10u:
									break;
								case 16u:
									num6 = 0;
									num2 = (int)(num4 * 1947204945) ^ -2033342606;
									continue;
								case 15u:
									array3 = (array2 = array);
									num2 = ((array3 == null) ? (-1570812199) : (-2081574380));
									continue;
								case 13u:
									num6++;
									num2 = ((int)num4 * -1266125014) ^ 0x436232DB;
									continue;
								case 12u:
									num5 = num7 * num;
									intPtr = Marshal.AllocHGlobal(num5);
									num2 = -1799240452;
									continue;
								case 9u:
									array = (byte[])(object)gparam_0;
									num9 = ((array.Length == 0) ? (-1459438386) : (-373945946));
									num2 = num9 ^ (int)(num4 * 274691061);
									continue;
								case 8u:
									num10 = (((object)typeof(T) == typeof(byte)) ? (-1460862255) : (-2080354030));
									num2 = num10 ^ (int)(num4 * 343084068);
									continue;
								case 7u:
									num7 = Class127.smethod_1<T>();
									num2 = (int)(num4 * 116412275) ^ -1759863052;
									continue;
								case 6u:
									num2 = ((int)num4 * -741860927) ^ 0x1494E811;
									continue;
								case 5u:
									goto end_IL_0076;
								case 3u:
									Marshal.StructureToPtr((object)gparam_0[num6], intPtr.smethod_8(num6 * num7), false);
									num2 = -447535127;
									continue;
								case 2u:
									num8 = ((array2.Length != 0) ? (-289155997) : (-1614559470));
									num2 = num8 ^ ((int)num4 * -2134579179);
									continue;
								case 1u:
									num2 = ((num6 >= num) ? (-1324649672) : (-420788303));
									continue;
								case 4u:
									num2 = -882941663;
									continue;
								case 0u:
									return true;
								case 11u:
									return vmethod_2((IntPtr)ptr, intptr_1, (UIntPtr)(ulong)array.Length);
								default:
									result = vmethod_2(intPtr, intptr_1, (UIntPtr)(ulong)num5);
									Marshal.FreeHGlobal(intPtr);
									return result;
								}
								break;
							}
						}
						continue;
						end_IL_0076:
						break;
					}
					goto case 5u;
				case 9u:
					array = (byte[])(object)gparam_0;
					num9 = ((array.Length == 0) ? (-1459438386) : (-373945946));
					num2 = num9 ^ (int)(num4 * 274691061);
					continue;
				case 8u:
					num10 = (((object)typeof(T) == typeof(byte)) ? (-1460862255) : (-2080354030));
					num2 = num10 ^ (int)(num4 * 343084068);
					continue;
				case 7u:
					num7 = Class127.smethod_1<T>();
					num2 = (int)(num4 * 116412275) ^ -1759863052;
					continue;
				case 6u:
					num2 = ((int)num4 * -741860927) ^ 0x1494E811;
					continue;
				case 5u:
					reference = ref *(byte*)null;
					num2 = -1494994142;
					continue;
				case 3u:
					Marshal.StructureToPtr((object)gparam_0[num6], intPtr.smethod_8(num6 * num7), false);
					num2 = -447535127;
					continue;
				case 2u:
					num8 = ((array2.Length != 0) ? (-289155997) : (-1614559470));
					num2 = num8 ^ ((int)num4 * -2134579179);
					continue;
				case 1u:
					num2 = ((num6 >= num) ? (-1324649672) : (-420788303));
					continue;
				case 4u:
					break;
				case 0u:
					return true;
				case 11u:
					return vmethod_2((IntPtr)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), intptr_1, (UIntPtr)(ulong)array.Length);
				default:
					result = vmethod_2(intPtr, intptr_1, (UIntPtr)(ulong)num5);
					Marshal.FreeHGlobal(intPtr);
					return result;
				}
				break;
			}
		}
	}
}
