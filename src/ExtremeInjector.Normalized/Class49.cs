using System;
using System.Runtime.InteropServices;

public static class Class49
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Delegate0(IntPtr intptr_0);

	internal static Class123 class123_0;

	public static readonly bool bool_0;

	internal static readonly Struct20 struct20_0;

	internal static readonly Struct21 struct21_0;

	internal static Delegate0 delegate0_0;

	public static readonly uint uint_0;

	public static Class63 class63_0;

	public static Class63 class63_1;

	public static Class63 class63_2;

	public static Class63 class63_3;

	public static Class63 class63_4;

	public static Class63 class63_5;

	public static Class63 class63_6;

	public static Class63 class63_7;

	public static Class63 class63_8;

	public static Class63 class63_9;

	public static Class63 class63_10;

	public static Class63 class63_11;

	public static Class63 class63_12;

	public static Class63 class63_13;

	public static Class63 class63_14;

	public static Class63 class63_15;

	public static Class63 class63_16;

	public static Class63 class63_17;

	public static Class63 class63_18;

	public static Class63 class63_19;

	public static Class63 class63_20;

	public static Class63 class63_21;

	public static Class63 class63_22;

	public static Class63 class63_23;

	public static Class63 class63_24;

	public static Class63 class63_25;

	public static Class63 class63_26;

	public static Class63 class63_27;

	public static Class63 class63_28;

	public static Class63 class63_29;

	public static Class63 class63_30;

	public static Class63 class63_31;

	public static Class63 class63_32;

	public static Class63 class63_33;

	public static Class63 class63_34;

	public static Class63 class63_35;

	public static Class63 class63_36;

	public static Class63 class63_37;

	public static Class63 class63_38;

	public static Class63 class63_39;

	public static Class63 class63_40;

	public static Class63 class63_41;

	public static Class63 class63_42;

	public static Class63 class63_43;

	public static Class63 class63_44;

	public static Class63 class63_45;

	public static Class63 class63_46;

	public static Class63 class63_47;

	public static Class63 class63_48;

	public static Class63 class63_49;

	public static Class63 class63_50;

	public static Class63 class63_51;

	public static Class63 class63_52;

	public static Class63 class63_53;

	public static Class63 class63_54;

	public static Class63 class63_55;

	public static Class63 class63_56;

	public static Class63 class63_57;

	public static Class63 class63_58;

	public static Class63 class63_59;

	public static Class63 class63_60;

	public static Class63 class63_61;

	public static Class63 class63_62;

	public static Class63 class63_63;

	public static Class63 class63_64;

	public static Class63 class63_65;

	public static Class63 class63_66;

	public static Class63 class63_67;

	public static Class63 class63_68;

	public static Class63 class63_69;

	public static Class63 class63_70;

	public static Class63 class63_71;

	public static Class63 class63_72;

	public static Class63 class63_73;

	public static Class63 class63_74;

	public static Class63 class63_75;

	public static Class63 class63_76;

	public static Class64 class64_0;

	public static Class64 class64_1;

	public static Class64 class64_2;

	public static Class64 class64_3;

	public static Class64 class64_4;

	public static Class64 class64_5;

	public static Class64 class64_6;

	public static Class64 class64_7;

	public static Class65 class65_0;

	public static Class65 class65_1;

	public static Class65 class65_2;

	public static Class65 class65_3;

	public static Class65 class65_4;

	public static Class65 class65_5;

	public static Class65 class65_6;

	public static Class65 class65_7;

	public static Class65 class65_8;

	public static Class65 class65_9;

	public static Class65 class65_10;

	public static Class65 class65_11;

	public static Class65 class65_12;

	public static Class65 class65_13;

	public static Class65 class65_14;

	public static Class65 class65_15;

	static Class49()
	{
		bool_0 = IntPtr.Size == 8;
		while (true)
		{
			int num = -338111611;
			while (true)
			{
				uint num2;
				byte[] byte_;
				switch ((num2 = (uint)(num ^ -1610115625)) % 7)
				{
				case 6u:
					byte_ = Class171.smethod_286();
					goto IL_0017;
				case 4u:
					Class171.smethod_305();
					num = (int)((num2 * 1454651786) ^ 0x430F2AEF);
					continue;
				case 3u:
					if (!bool_0)
					{
						num = ((int)num2 * -583088004) ^ 0x1E9B8A37;
						continue;
					}
					byte_ = Class171.smethod_303();
					goto IL_0017;
				case 2u:
					uint_0 = uint.MaxValue;
					num = (int)(num2 * 1573111401) ^ -1559793364;
					continue;
				case 1u:
					struct20_0 = default(Struct20);
					struct21_0 = default(Struct21);
					num = ((int)num2 * -1589860852) ^ -1054105514;
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
					return;
					IL_0017:
					class123_0 = new Class123(byte_, bool_0: true);
					num = -426189986;
					continue;
				}
				break;
			}
		}
	}
}
