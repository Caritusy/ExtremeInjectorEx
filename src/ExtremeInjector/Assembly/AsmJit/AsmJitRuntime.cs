using System;
using System.Runtime.InteropServices;

public static class AsmJitRuntime
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Delegate0(IntPtr intptr_0);

	internal static NativeLibraryImage class123_0;

	public static readonly bool bool_0;

	internal static readonly AsmJitUninitializedOperandTag struct20_0;

	internal static Delegate0 delegate0_0;

	public static readonly uint uint_0;

	public static AsmJitGpRegister class63_0;

	public static AsmJitGpRegister class63_1;

	public static AsmJitGpRegister class63_2;

	public static AsmJitGpRegister class63_3;

	public static AsmJitGpRegister class63_4;

	public static AsmJitGpRegister class63_5;

	public static AsmJitGpRegister class63_6;

	public static AsmJitGpRegister class63_7;

	public static AsmJitGpRegister class63_8;

	public static AsmJitGpRegister class63_9;

	public static AsmJitGpRegister class63_10;

	public static AsmJitGpRegister class63_11;

	public static AsmJitGpRegister class63_12;

	public static AsmJitGpRegister class63_13;

	public static AsmJitGpRegister class63_14;

	public static AsmJitGpRegister class63_15;

	public static AsmJitGpRegister class63_16;

	public static AsmJitGpRegister class63_17;

	public static AsmJitGpRegister class63_18;

	public static AsmJitGpRegister class63_19;

	public static AsmJitGpRegister class63_20;

	public static AsmJitGpRegister class63_21;

	public static AsmJitGpRegister class63_22;

	public static AsmJitGpRegister class63_23;

	public static AsmJitGpRegister class63_24;

	public static AsmJitGpRegister class63_25;

	public static AsmJitGpRegister class63_26;

	public static AsmJitGpRegister class63_27;

	public static AsmJitGpRegister class63_28;

	public static AsmJitGpRegister class63_29;

	public static AsmJitGpRegister class63_30;

	public static AsmJitGpRegister class63_31;

	public static AsmJitGpRegister class63_32;

	public static AsmJitGpRegister class63_33;

	public static AsmJitGpRegister class63_34;

	public static AsmJitGpRegister class63_35;

	public static AsmJitGpRegister class63_36;

	public static AsmJitGpRegister class63_37;

	public static AsmJitGpRegister class63_38;

	public static AsmJitGpRegister class63_39;

	public static AsmJitGpRegister class63_40;

	public static AsmJitGpRegister class63_41;

	public static AsmJitGpRegister class63_42;

	public static AsmJitGpRegister class63_43;

	public static AsmJitGpRegister class63_44;

	public static AsmJitGpRegister class63_45;

	public static AsmJitGpRegister class63_46;

	public static AsmJitGpRegister class63_47;

	public static AsmJitGpRegister class63_48;

	public static AsmJitGpRegister class63_49;

	public static AsmJitGpRegister class63_50;

	public static AsmJitGpRegister class63_51;

	public static AsmJitGpRegister class63_52;

	public static AsmJitGpRegister class63_53;

	public static AsmJitGpRegister class63_54;

	public static AsmJitGpRegister class63_55;

	public static AsmJitGpRegister class63_56;

	public static AsmJitGpRegister class63_57;

	public static AsmJitGpRegister class63_58;

	public static AsmJitGpRegister class63_59;

	public static AsmJitGpRegister class63_60;

	public static AsmJitGpRegister class63_61;

	public static AsmJitGpRegister class63_62;

	public static AsmJitGpRegister class63_63;

	public static AsmJitGpRegister class63_64;

	public static AsmJitGpRegister class63_65;

	public static AsmJitGpRegister class63_66;

	public static AsmJitGpRegister class63_67;

	public static AsmJitGpRegister class63_68;

	public static AsmJitGpRegister class63_69;

	public static AsmJitGpRegister class63_70;

	public static AsmJitGpRegister class63_71;

	public static AsmJitGpRegister class63_72;

	public static AsmJitGpRegister class63_73;

	public static AsmJitGpRegister class63_74;

	public static AsmJitGpRegister class63_75;

	public static AsmJitGpRegister class63_76;

	public static AsmJitMmxRegister class64_0;

	public static AsmJitMmxRegister class64_1;

	public static AsmJitMmxRegister class64_2;

	public static AsmJitMmxRegister class64_3;

	public static AsmJitMmxRegister class64_4;

	public static AsmJitMmxRegister class64_5;

	public static AsmJitMmxRegister class64_6;

	public static AsmJitMmxRegister class64_7;

	public static AsmJitXmmRegister class65_0;

	public static AsmJitXmmRegister class65_1;

	public static AsmJitXmmRegister class65_2;

	public static AsmJitXmmRegister class65_3;

	public static AsmJitXmmRegister class65_4;

	public static AsmJitXmmRegister class65_5;

	public static AsmJitXmmRegister class65_6;

	public static AsmJitXmmRegister class65_7;

	public static AsmJitXmmRegister class65_8;

	public static AsmJitXmmRegister class65_9;

	public static AsmJitXmmRegister class65_10;

	public static AsmJitXmmRegister class65_11;

	public static AsmJitXmmRegister class65_12;

	public static AsmJitXmmRegister class65_13;

	public static AsmJitXmmRegister class65_14;

	public static AsmJitXmmRegister class65_15;

	static AsmJitRuntime()
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
					byte_ = RecoveredRuntime.smethod_292();
					goto IL_0017;
				case 4u:
					RecoveredRuntime.smethod_311();
					num = (int)((num2 * 1454651786) ^ 0x430F2AEF);
					continue;
				case 3u:
					if (!bool_0)
					{
						num = ((int)num2 * -583088004) ^ 0x1E9B8A37;
						continue;
					}
					byte_ = RecoveredRuntime.smethod_309();
					goto IL_0017;
				case 2u:
					uint_0 = uint.MaxValue;
					num = (int)(num2 * 1573111401) ^ -1559793364;
					continue;
				case 1u:
					struct20_0 = default(AsmJitUninitializedOperandTag);
					num = ((int)num2 * -1589860852) ^ -1054105514;
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
					return;
					IL_0017:
					class123_0 = new NativeLibraryImage(byte_, bool_0: true);
					num = -426189986;
					continue;
				}
				break;
			}
		}
	}
}
