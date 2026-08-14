using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

public static class Class124
{
	[Flags]
	public enum Enum20 : uint
	{
		flag_0 = 0u,
		flag_1 = 1u,
		flag_2 = 2u,
		flag_3 = 8u
	}

	public delegate bool Delegate46(IntPtr intptr_0, IntPtr intptr_1);

	public struct Struct37(int int_4, int int_5, int int_6, int int_7)
	{
		public int int_0 = int_4;

		public int int_1 = int_5;

		public int int_2 = int_6;

		public int int_3 = int_7;

		public Struct37(Rectangle rectangle_0)
			: this(rectangle_0.Left, rectangle_0.Top, rectangle_0.Right, rectangle_0.Bottom)
		{
		}

		[SpecialName]
		public int method_0()
		{
			return int_3 - int_1;
		}

		[SpecialName]
		public int method_1()
		{
			return int_2 - int_0;
		}

		[SpecialName]
		public static Rectangle smethod_0(Struct37 struct37_0)
		{
			return new Rectangle(struct37_0.int_0, struct37_0.int_1, struct37_0.method_1(), struct37_0.method_0());
		}

		public bool method_2(Struct37 struct37_0)
		{
			if (struct37_0.int_0 == int_0)
			{
				while (true)
				{
					int num = -1945785622;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -74350438)) % 5)
						{
						case 4u:
							num = ((struct37_0.int_2 == int_2) ? (-1112347804) : (-948725576)) ^ (int)(num2 * 1503376939);
							continue;
						case 1u:
							num = ((struct37_0.int_1 == int_1) ? 1564629800 : 1685639838) ^ ((int)num2 * -416148990);
							continue;
						case 3u:
							break;
						case 2u:
							return struct37_0.int_3 == int_3;
						default:
							goto end_IL_0097;
						}
						break;
					}
					continue;
					end_IL_0097:
					break;
				}
			}
			return false;
		}

		public override bool Equals(object obj)
		{
			if (obj is Struct37)
			{
				goto IL_0017;
			}
			goto IL_004b;
			IL_0017:
			int num = 693705274;
			goto IL_001c;
			IL_001c:
			switch ((uint)(num ^ 0x48F58E83) % 5u)
			{
			case 4u:
				break;
			case 1u:
				goto IL_004b;
			case 0u:
				return method_2(new Struct37((Rectangle)obj));
			case 2u:
				return method_2((Struct37)obj);
			default:
				return false;
			}
			goto IL_0017;
			IL_004b:
			num = ((obj is Rectangle) ? 94785859 : 1646166766);
			goto IL_001c;
		}

		public override int GetHashCode()
		{
			return smethod_0(this).GetHashCode();
		}

		public override string ToString()
		{
			return smethod_2(smethod_1(), Class178.smethod_0(31210), new object[4] { int_0, int_1, int_2, int_3 });
		}

		internal static CultureInfo smethod_1()
		{
			return CultureInfo.CurrentCulture;
		}

		internal static string smethod_2(IFormatProvider iformatProvider_0, string string_0, object[] object_0)
		{
			return string.Format(iformatProvider_0, string_0, object_0);
		}
	}

	public struct Struct38
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;

		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;

		public byte byte_0;

		public byte byte_1;
	}

	public struct Struct39
	{
		public uint uint_0;

		public uint uint_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		internal long[] long_0;

		public long long_1;

		public long long_2;

		public long long_3;

		public Struct43 struct43_0;

		public uint uint_2;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public uint uint_3;

		public uint uint_4;

		public IntPtr intptr_2;

		public Struct42 struct42_0;

		public IntPtr intptr_3;

		public Struct41 struct41_0;
	}

	public struct Struct40
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public uint uint_0;

		public IntPtr intptr_0;

		public Struct48 struct48_0;

		public uint uint_1;

		public int int_0;

		public uint uint_2;

		public uint uint_3;

		public Enum23 enum23_0;
	}

	public struct Struct41
	{
		public ulong ulong_0;

		public ulong ulong_1;

		public ulong ulong_2;

		public ulong ulong_3;

		public ulong ulong_4;

		public ulong ulong_5;
	}

	public struct Struct42
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public uint uint_0;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public IntPtr intptr_4;

		public IntPtr intptr_5;

		public IntPtr intptr_6;

		public IntPtr intptr_7;

		public IntPtr intptr_8;

		public IntPtr intptr_9;
	}

	public struct Struct43
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public IntPtr intptr_0;

		public override string ToString()
		{
			return smethod_0(intptr_0, ushort_0 / 2);
		}

		internal static string smethod_0(IntPtr intptr_1, int int_0)
		{
			return Marshal.PtrToStringUni(intptr_1, int_0);
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct44
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct45
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public UIntPtr uintptr_0;

		public IntPtr intptr_4;
	}

	public struct Struct46
	{
		public IntPtr intptr_0;

		public uint uint_0;

		public IntPtr intptr_1;
	}

	public struct Struct47
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public Enum34 enum34_0;

		public IntPtr intptr_2;

		public Enum29 enum29_0;

		public Enum34 enum34_1;

		public Enum30 enum30_0;
	}

	public struct Struct48
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;
	}

	public struct Struct49
	{
		public uint uint_0;

		public IntPtr intptr_0;

		public Struct48 struct48_0;

		public IntPtr intptr_1;

		public uint uint_1;

		public uint uint_2;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
	public struct Struct50
	{
		public int int_0;

		public uint uint_0;

		public string string_0;

		public ushort ushort_0;

		public short short_0;

		public string string_1;

		public string string_2;

		public string string_3;

		public IntPtr intptr_0;
	}

	public struct Struct51
	{
		public int int_0;

		public uint uint_0;

		public uint uint_1;

		public ushort ushort_0;

		public short short_0;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;
	}

	public struct Struct52
	{
		public int int_0;

		public uint uint_0;

		public IntPtr intptr_0;

		public ushort ushort_0;

		public short short_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public IntPtr intptr_4;
	}

	public struct Struct53
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] byte_0;

		public uint uint_7;
	}

	public struct Struct54
	{
		public Enum21 enum21_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public Struct53 struct53_0;

		public uint uint_6;

		public uint uint_7;

		public uint uint_8;

		public uint uint_9;

		public uint uint_10;

		public uint uint_11;

		public uint uint_12;

		public uint uint_13;

		public uint uint_14;

		public uint uint_15;

		public uint uint_16;

		public uint uint_17;

		public uint uint_18;

		public uint uint_19;

		public uint uint_20;

		public uint uint_21;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] byte_0;
	}

	public struct Struct55
	{
		public ulong ulong_0;

		public ulong ulong_1;

		public ulong ulong_2;

		public ulong ulong_3;

		public ulong ulong_4;

		public ulong ulong_5;

		public Enum22 enum22_0;

		public uint uint_0;

		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;

		public ushort ushort_3;

		public ushort ushort_4;

		public ushort ushort_5;

		public uint uint_1;

		public ulong ulong_6;

		public ulong ulong_7;

		public ulong ulong_8;

		public ulong ulong_9;

		public ulong ulong_10;

		public ulong ulong_11;

		public ulong ulong_12;

		public ulong ulong_13;

		public ulong ulong_14;

		public ulong ulong_15;

		public ulong ulong_16;

		public ulong ulong_17;

		public ulong ulong_18;

		public ulong ulong_19;

		public ulong ulong_20;

		public ulong ulong_21;

		public ulong ulong_22;

		public ulong ulong_23;

		public ulong ulong_24;

		public ulong ulong_25;

		public ulong ulong_26;

		public ulong ulong_27;

		public ulong ulong_28;

		public Struct58 struct58_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
		public Struct56[] struct56_0;

		public ulong ulong_29;

		public ulong ulong_30;

		public ulong ulong_31;

		public ulong ulong_32;

		public ulong ulong_33;

		public ulong ulong_34;
	}

	public struct Struct56
	{
		public ulong ulong_0;

		public long long_0;
	}

	public struct Struct57
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public Struct56[] struct56_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public Struct56[] struct56_1;

		public Struct56 struct56_2;

		public Struct56 struct56_3;

		public Struct56 struct56_4;

		public Struct56 struct56_5;

		public Struct56 struct56_6;

		public Struct56 struct56_7;

		public Struct56 struct56_8;

		public Struct56 struct56_9;

		public Struct56 struct56_10;

		public Struct56 struct56_11;

		public Struct56 struct56_12;

		public Struct56 struct56_13;

		public Struct56 struct56_14;

		public Struct56 struct56_15;

		public Struct56 struct56_16;

		public Struct56 struct56_17;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 96)]
		internal byte[] byte_0;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct Struct58
	{
		[FieldOffset(0)]
		public Struct57 struct57_0;
	}

	[Flags]
	public enum Enum21 : uint
	{
		flag_0 = 0x10000u,
		flag_1 = flag_0,
		flag_2 = 0x10001u,
		flag_3 = 0x10002u,
		flag_4 = 0x10004u,
		flag_5 = 0x10008u,
		flag_6 = 0x10010u,
		flag_7 = 0x10020u,
		flag_8 = 0x10007u,
		flag_9 = 0x1003Fu,
		flag_10 = 0x10040u
	}

	[Flags]
	public enum Enum22 : uint
	{
		flag_0 = 0x100000u,
		flag_1 = 0x100001u,
		flag_2 = 0x100002u,
		flag_3 = 0x100004u,
		flag_4 = 0x100008u,
		flag_5 = 0x100010u,
		flag_6 = 0x100007u,
		flag_7 = 0x10001Fu,
		flag_8 = 0x100020u
	}

	public enum Enum23 : uint
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10,
		const_11,
		const_12,
		const_13,
		const_14,
		const_15,
		const_16,
		const_17,
		const_18,
		const_19,
		const_20,
		const_21,
		const_22,
		const_23,
		const_24,
		const_25,
		const_26,
		const_27,
		const_28,
		const_29,
		const_30,
		const_31,
		const_32,
		const_33,
		const_34,
		const_35,
		const_36,
		const_37
	}

	public enum Enum24
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10,
		const_11,
		const_12,
		const_13,
		const_14,
		const_15,
		const_16,
		const_17,
		const_18,
		const_19,
		const_20,
		const_21,
		const_22,
		const_23,
		const_24,
		const_25,
		const_26,
		const_27,
		const_28,
		const_29,
		const_30,
		const_31,
		const_32,
		const_33,
		const_34,
		const_35,
		const_36,
		const_37,
		const_38,
		const_39,
		const_40,
		const_41,
		const_42,
		const_43,
		const_44,
		const_45,
		const_46,
		const_47,
		const_48,
		const_49,
		const_50,
		const_51,
		const_52,
		const_53,
		const_54,
		const_55,
		const_56,
		const_57,
		const_58,
		const_59,
		const_60,
		const_61,
		const_62,
		const_63,
		const_64,
		const_65,
		const_66,
		const_67,
		const_68,
		const_69,
		const_70,
		const_71,
		const_72,
		const_73,
		const_74,
		const_75,
		const_76,
		const_77,
		const_78,
		const_79,
		const_80,
		const_81,
		const_82
	}

	public enum Enum25
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10,
		const_11,
		const_12,
		const_13,
		const_14,
		const_15,
		const_16,
		const_17
	}

	public enum Enum26
	{
		const_0 = 23,
		const_1 = 9,
		const_2 = 21,
		const_3 = 5,
		const_4 = 0,
		const_5 = 7,
		const_6 = 12,
		const_7 = 17,
		const_8 = 8,
		const_9 = 20,
		const_10 = 27,
		const_11 = 2,
		const_12 = 13,
		const_13 = 10,
		const_14 = 11,
		const_15 = 14,
		const_16 = 22,
		const_17 = 18,
		const_18 = 1,
		const_19 = 6,
		const_20 = 4,
		const_21 = 16,
		const_22 = 3,
		const_23 = 15,
		const_24 = 26,
		const_25 = 19
	}

	[Flags]
	public enum Enum27 : uint
	{
		flag_0 = 1u,
		flag_1 = 2u,
		flag_2 = 4u,
		flag_3 = 8u,
		flag_4 = 0x10u,
		flag_5 = flag_0 | flag_1 | flag_2 | flag_3,
		flag_6 = 0x80000000u,
		flag_7 = 0x40000000u
	}

	public enum Enum28 : uint
	{
		const_0 = 0x4000u,
		const_1 = 0x8000u
	}

	public enum Enum29 : uint
	{
		const_0 = 4096u,
		const_1 = 65536u,
		const_2 = 8192u
	}

	public enum Enum30 : uint
	{
		const_0 = 16777216u,
		const_1 = 262144u,
		const_2 = 131072u
	}

	[Flags]
	public enum Enum31 : uint
	{
		flag_0 = 1u,
		flag_1 = 2u,
		flag_2 = 8u,
		flag_3 = 0x10u,
		flag_4 = 0x20u,
		flag_5 = 0x40u,
		flag_6 = 0x80u,
		flag_7 = 0x100u,
		flag_8 = 0x200u,
		flag_9 = 0x800u,
		flag_10 = 0x100000u
	}

	[Flags]
	public enum Enum32 : uint
	{
		flag_0 = 0x1F0FFFu,
		flag_1 = 1u,
		flag_2 = 2u,
		flag_3 = 8u,
		flag_4 = 0x10u,
		flag_5 = 0x20u,
		flag_6 = 0x40u,
		flag_7 = 0x100u,
		flag_8 = 0x200u,
		flag_9 = 0x400u,
		flag_10 = 0x1000u,
		flag_11 = 0x100000u
	}

	[Flags]
	public enum Enum33 : uint
	{
		flag_0 = 0x1000u,
		flag_1 = 0x2000u,
		flag_2 = 0x80000u,
		flag_3 = 0x20000000u,
		flag_4 = 0x400000u,
		flag_5 = 0x100000u,
		flag_6 = 0x200000u
	}

	[Flags]
	public enum Enum34 : uint
	{
		flag_0 = 0x10u,
		flag_1 = 0x20u,
		flag_2 = 0x40u,
		flag_3 = 0x80u,
		flag_4 = 1u,
		flag_5 = 2u,
		flag_6 = 4u,
		flag_7 = 8u,
		flag_8 = 0x100u,
		flag_9 = 0x200u,
		flag_10 = 0x400u
	}

	public static readonly IntPtr intptr_0 = (IntPtr)(-1);

	public static readonly int int_0 = smethod_1(smethod_0(typeof(Struct47).TypeHandle));

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	public static extern int VirtualQueryEx(IntPtr intptr_1, IntPtr intptr_2, out Struct47 struct47_0, uint uint_0);

	internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int smethod_1(Type type_0)
	{
		return Marshal.SizeOf(type_0);
	}
}
