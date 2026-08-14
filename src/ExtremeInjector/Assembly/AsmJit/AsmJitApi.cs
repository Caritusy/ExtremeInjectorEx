using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

public static class AsmJitApi
{
	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate void Delegate1(ref AsmJitAssemblerState struct19_0, IntPtr intptr_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void Delegate2(ref AsmJitAssemblerState struct19_0, IntPtr intptr_0);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void Delegate3(ref AsmJitAssemblerState struct19_0, AsmJitInstructionId enum7_0);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void Delegate4(ref AsmJitAssemblerState struct19_0, AsmJitInstructionId enum7_0, [In] AsmJitOperand class56_0);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void Delegate5(ref AsmJitAssemblerState struct19_0, AsmJitInstructionId enum7_0, [In] AsmJitOperand class56_0, [In] AsmJitOperand class56_1);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void Delegate6(ref AsmJitAssemblerState struct19_0, AsmJitInstructionId enum7_0, [In] AsmJitOperand class56_0, [In] AsmJitOperand class56_1, [In] AsmJitOperand class56_2);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Delegate7(ref AsmJitAssemblerState struct19_0, AsmJitInstructionId enum7_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Delegate8(ref AsmJitAssemblerState struct19_0, AsmJitInstructionId enum7_0, [In] AsmJitOperand class56_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Delegate9(ref AsmJitAssemblerState struct19_0, AsmJitInstructionId enum7_0, [In] AsmJitOperand class56_0, [In] AsmJitOperand class56_1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void Delegate10(ref AsmJitAssemblerState struct19_0, AsmJitInstructionId enum7_0, [In] AsmJitOperand class56_0, [In] AsmJitOperand class56_1, [In] AsmJitOperand class56_2);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr Delegate11(ref AsmJitAssemblerState struct19_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr Delegate12(ref AsmJitAssemblerState struct19_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate IntPtr Delegate13(ref AsmJitAssemblerState struct19_0, IntPtr intptr_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr Delegate14(ref AsmJitAssemblerState struct19_0, IntPtr intptr_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate IntPtr Delegate15(ref AsmJitAssemblerState struct19_0, IntPtr intptr_0, IntPtr intptr_1);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr Delegate16(ref AsmJitAssemblerState struct19_0, IntPtr intptr_0, IntPtr intptr_1);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void Delegate17(ref AsmJitAssemblerState struct19_0, [In][MarshalAs(UnmanagedType.AsAny)] object object_0, IntPtr intptr_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Delegate18(ref AsmJitAssemblerState struct19_0, [In][MarshalAs(UnmanagedType.AsAny)] object object_0, IntPtr intptr_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr Delegate19([In][Out] AsmJitMemoryOperand class59_0, AsmJitVariable class60_0, uint uint_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr Delegate20([In][Out] AsmJitMemoryOperand class59_0, AsmJitVariable class60_0, uint uint_0, IntPtr intptr_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr Delegate21([In][Out] AsmJitMemoryOperand class59_0, AsmJitVariable class60_0, uint uint_0, AsmJitGpVariable class61_0, uint uint_1, IntPtr intptr_0);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void Delegate22(ref AsmJitAssemblerState struct19_0, AsmJitInstructionId enum7_0, [In] AsmJitLabel class58_0, AsmJitJumpHint enum12_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Delegate23(ref AsmJitAssemblerState struct19_0, AsmJitInstructionId enum7_0, [In] AsmJitLabel class58_0, AsmJitJumpHint enum12_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate IntPtr Delegate24(ref AsmJitAssemblerState struct19_0, [In][Out] AsmJitLabel class58_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr Delegate25(ref AsmJitAssemblerState struct19_0, [In][Out] AsmJitLabel class58_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate void Delegate26(ref AsmJitAssemblerState struct19_0, [In] AsmJitLabel class58_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void Delegate27(ref AsmJitAssemblerState struct19_0, [In] AsmJitLabel class58_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr Delegate28([In][Out] AsmJitMemoryOperand class59_0, [In] AsmJitLabel class58_0, IntPtr intptr_0, uint uint_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr Delegate29([In][Out] AsmJitMemoryOperand class59_0, [In] AsmJitLabel class58_0, [In] AsmJitGpRegister class63_0, uint uint_0, IntPtr intptr_0, uint uint_1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr Delegate30([In][Out] AsmJitMemoryOperand class59_0, [In] AsmJitLabel class58_0, [In] AsmJitGpVariable class61_0, uint uint_0, IntPtr intptr_0, uint uint_1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr Delegate31([In][Out] AsmJitMemoryOperand class59_0, [In] IntPtr intptr_0, IntPtr intptr_1, AsmJitSegmentPrefix enum10_0, uint uint_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr Delegate32([In][Out] AsmJitMemoryOperand class59_0, [In] IntPtr intptr_0, [In] AsmJitGpRegister class63_0, uint uint_0, IntPtr intptr_1, AsmJitSegmentPrefix enum10_0, uint uint_1);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr Delegate33([In][Out] AsmJitMemoryOperand class59_0, [In] IntPtr intptr_0, [In] AsmJitGpVariable class61_0, uint uint_0, IntPtr intptr_1, AsmJitSegmentPrefix enum10_0, uint uint_1);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr Delegate34([In][Out] AsmJitMemoryOperand class59_0, [In] AsmJitGpRegister class63_0, IntPtr intptr_0, uint uint_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr Delegate35([In][Out] AsmJitMemoryOperand class59_0, [In] AsmJitGpVariable class61_0, IntPtr intptr_0, uint uint_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr Delegate36([In][Out] AsmJitMemoryOperand class59_0, [In] AsmJitGpRegister class63_0, [In] AsmJitGpRegister class63_1, uint uint_0, IntPtr intptr_0, uint uint_1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr Delegate37([In][Out] AsmJitMemoryOperand class59_0, [In] AsmJitGpVariable class61_0, [In] AsmJitGpVariable class61_1, uint uint_0, IntPtr intptr_0, uint uint_1);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void Delegate38(ref AsmJitAssemblerState struct19_0, uint uint_0);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Delegate39(ref AsmJitAssemblerState struct19_0, uint uint_0);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr Delegate40();

	[CompilerGenerated]
	internal static Delegate1 delegate1_0;

	[CompilerGenerated]
	internal static Delegate2 delegate2_0;

	[CompilerGenerated]
	internal static Delegate3 delegate3_0;

	[CompilerGenerated]
	internal static Delegate4 delegate4_0;

	[CompilerGenerated]
	internal static Delegate5 delegate5_0;

	[CompilerGenerated]
	internal static Delegate6 delegate6_0;

	[CompilerGenerated]
	internal static Delegate7 delegate7_0;

	[CompilerGenerated]
	internal static Delegate8 delegate8_0;

	[CompilerGenerated]
	internal static Delegate9 delegate9_0;

	[CompilerGenerated]
	internal static Delegate10 delegate10_0;

	[CompilerGenerated]
	internal static Delegate11 delegate11_0;

	[CompilerGenerated]
	internal static Delegate12 delegate12_0;

	[CompilerGenerated]
	internal static Delegate13 delegate13_0;

	[CompilerGenerated]
	internal static Delegate14 delegate14_0;

	[CompilerGenerated]
	internal static Delegate15 delegate15_0;

	[CompilerGenerated]
	internal static Delegate16 delegate16_0;

	[CompilerGenerated]
	internal static Delegate17 delegate17_0;

	[CompilerGenerated]
	internal static Delegate18 delegate18_0;

	[CompilerGenerated]
	internal static Delegate19 delegate19_0;

	[CompilerGenerated]
	internal static Delegate20 delegate20_0;

	[CompilerGenerated]
	internal static Delegate21 delegate21_0;

	[CompilerGenerated]
	internal static Delegate22 delegate22_0;

	[CompilerGenerated]
	internal static Delegate23 delegate23_0;

	[CompilerGenerated]
	internal static Delegate22 delegate22_1;

	[CompilerGenerated]
	internal static Delegate23 delegate23_1;

	[CompilerGenerated]
	internal static Delegate24 delegate24_0;

	[CompilerGenerated]
	internal static Delegate25 delegate25_0;

	[CompilerGenerated]
	internal static Delegate26 delegate26_0;

	[CompilerGenerated]
	internal static Delegate27 delegate27_0;

	[CompilerGenerated]
	internal static Delegate28 delegate28_0;

	[CompilerGenerated]
	internal static Delegate30 delegate30_0;

	[CompilerGenerated]
	internal static Delegate29 delegate29_0;

	[CompilerGenerated]
	internal static Delegate31 delegate31_0;

	[CompilerGenerated]
	internal static Delegate33 delegate33_0;

	[CompilerGenerated]
	internal static Delegate32 delegate32_0;

	[CompilerGenerated]
	internal static Delegate35 delegate35_0;

	[CompilerGenerated]
	internal static Delegate37 delegate37_0;

	[CompilerGenerated]
	internal static Delegate34 delegate34_0;

	[CompilerGenerated]
	internal static Delegate36 delegate36_0;

	[CompilerGenerated]
	internal static Delegate38 delegate38_0;

	[CompilerGenerated]
	internal static Delegate39 delegate39_0;

	[CompilerGenerated]
	internal static Delegate40 delegate40_0;

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate1 smethod_0()
	{
		return delegate1_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_1(Delegate1 delegate1_1)
	{
		delegate1_0 = delegate1_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate2 smethod_2()
	{
		return delegate2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_3(Delegate2 delegate2_1)
	{
		delegate2_0 = delegate2_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate3 smethod_4()
	{
		return delegate3_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_5(Delegate3 delegate3_1)
	{
		delegate3_0 = delegate3_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate4 smethod_6()
	{
		return delegate4_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_7(Delegate4 delegate4_1)
	{
		delegate4_0 = delegate4_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate5 smethod_8()
	{
		return delegate5_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_9(Delegate5 delegate5_1)
	{
		delegate5_0 = delegate5_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_10(Delegate6 delegate6_1)
	{
		delegate6_0 = delegate6_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate7 smethod_11()
	{
		return delegate7_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_12(Delegate7 delegate7_1)
	{
		delegate7_0 = delegate7_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate8 smethod_13()
	{
		return delegate8_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_14(Delegate8 delegate8_1)
	{
		delegate8_0 = delegate8_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate9 smethod_15()
	{
		return delegate9_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_16(Delegate9 delegate9_1)
	{
		delegate9_0 = delegate9_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_17(Delegate10 delegate10_1)
	{
		delegate10_0 = delegate10_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate11 smethod_18()
	{
		return delegate11_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_19(Delegate11 delegate11_1)
	{
		delegate11_0 = delegate11_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate12 smethod_20()
	{
		return delegate12_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_21(Delegate12 delegate12_1)
	{
		delegate12_0 = delegate12_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_22(Delegate13 delegate13_1)
	{
		delegate13_0 = delegate13_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_23(Delegate14 delegate14_1)
	{
		delegate14_0 = delegate14_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate15 smethod_24()
	{
		return delegate15_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_25(Delegate15 delegate15_1)
	{
		delegate15_0 = delegate15_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate16 smethod_26()
	{
		return delegate16_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_27(Delegate16 delegate16_1)
	{
		delegate16_0 = delegate16_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate17 smethod_28()
	{
		return delegate17_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_29(Delegate17 delegate17_1)
	{
		delegate17_0 = delegate17_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate18 smethod_30()
	{
		return delegate18_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_31(Delegate18 delegate18_1)
	{
		delegate18_0 = delegate18_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_32(Delegate19 delegate19_1)
	{
		delegate19_0 = delegate19_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_33(Delegate20 delegate20_1)
	{
		delegate20_0 = delegate20_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_34(Delegate21 delegate21_1)
	{
		delegate21_0 = delegate21_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate22 smethod_35()
	{
		return delegate22_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_36(Delegate22 delegate22_2)
	{
		delegate22_0 = delegate22_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate23 smethod_37()
	{
		return delegate23_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_38(Delegate23 delegate23_2)
	{
		delegate23_0 = delegate23_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate22 smethod_39()
	{
		return delegate22_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_40(Delegate22 delegate22_2)
	{
		delegate22_1 = delegate22_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate23 smethod_41()
	{
		return delegate23_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_42(Delegate23 delegate23_2)
	{
		delegate23_1 = delegate23_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate24 smethod_43()
	{
		return delegate24_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_44(Delegate24 delegate24_1)
	{
		delegate24_0 = delegate24_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate25 smethod_45()
	{
		return delegate25_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_46(Delegate25 delegate25_1)
	{
		delegate25_0 = delegate25_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate26 smethod_47()
	{
		return delegate26_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_48(Delegate26 delegate26_1)
	{
		delegate26_0 = delegate26_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate27 smethod_49()
	{
		return delegate27_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_50(Delegate27 delegate27_1)
	{
		delegate27_0 = delegate27_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate28 smethod_51()
	{
		return delegate28_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_52(Delegate28 delegate28_1)
	{
		delegate28_0 = delegate28_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_53(Delegate30 delegate30_1)
	{
		delegate30_0 = delegate30_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_54(Delegate29 delegate29_1)
	{
		delegate29_0 = delegate29_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_55(Delegate31 delegate31_1)
	{
		delegate31_0 = delegate31_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_56(Delegate33 delegate33_1)
	{
		delegate33_0 = delegate33_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_57(Delegate32 delegate32_1)
	{
		delegate32_0 = delegate32_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_58(Delegate35 delegate35_1)
	{
		delegate35_0 = delegate35_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_59(Delegate37 delegate37_1)
	{
		delegate37_0 = delegate37_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate34 smethod_60()
	{
		return delegate34_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_61(Delegate34 delegate34_1)
	{
		delegate34_0 = delegate34_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_62(Delegate36 delegate36_1)
	{
		delegate36_0 = delegate36_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate38 smethod_63()
	{
		return delegate38_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_64(Delegate38 delegate38_1)
	{
		delegate38_0 = delegate38_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Delegate39 smethod_65()
	{
		return delegate39_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_66(Delegate39 delegate39_1)
	{
		delegate39_0 = delegate39_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void smethod_67(Delegate40 delegate40_1)
	{
		delegate40_0 = delegate40_1;
	}

	static AsmJitApi()
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.smethod_3(AsmJitNative.smethod_0<AsmJitApi.Delegate2>(EncodedStringTable.smethod_0(4502)));
			AsmJitApi.smethod_12(AsmJitNative.smethod_0<AsmJitApi.Delegate7>(EncodedStringTable.smethod_0(4567)));
			AsmJitApi.smethod_14(AsmJitNative.smethod_0<AsmJitApi.Delegate8>(EncodedStringTable.smethod_0(4632)));
			AsmJitApi.smethod_16(AsmJitNative.smethod_0<AsmJitApi.Delegate9>(EncodedStringTable.smethod_0(4717)));
			AsmJitApi.smethod_17(AsmJitNative.smethod_0<AsmJitApi.Delegate10>(EncodedStringTable.smethod_0(4802)));
			AsmJitApi.smethod_21(AsmJitNative.smethod_0<AsmJitApi.Delegate12>(EncodedStringTable.smethod_0(4891)));
			AsmJitApi.smethod_23(AsmJitNative.smethod_0<AsmJitApi.Delegate14>(EncodedStringTable.smethod_0(4944)));
			AsmJitApi.smethod_27(AsmJitNative.smethod_0<AsmJitApi.Delegate16>(EncodedStringTable.smethod_0(5005)));
			AsmJitApi.smethod_31(AsmJitNative.smethod_0<AsmJitApi.Delegate18>(EncodedStringTable.smethod_0(5070)));
			AsmJitApi.smethod_32(AsmJitNative.smethod_0<AsmJitApi.Delegate19>(EncodedStringTable.smethod_0(5127)));
			AsmJitApi.smethod_33(AsmJitNative.smethod_0<AsmJitApi.Delegate20>(EncodedStringTable.smethod_0(5196)));
			AsmJitApi.smethod_34(AsmJitNative.smethod_0<AsmJitApi.Delegate21>(EncodedStringTable.smethod_0(5265)));
			AsmJitApi.smethod_38(AsmJitNative.smethod_0<AsmJitApi.Delegate23>(EncodedStringTable.smethod_0(5354)));
			AsmJitApi.smethod_42(AsmJitNative.smethod_0<AsmJitApi.Delegate23>(EncodedStringTable.smethod_0(5427)));
			AsmJitApi.smethod_46(AsmJitNative.smethod_0<AsmJitApi.Delegate25>(EncodedStringTable.smethod_0(5508)));
			AsmJitApi.smethod_50(AsmJitNative.smethod_0<AsmJitApi.Delegate27>(EncodedStringTable.smethod_0(5577)));
			AsmJitApi.smethod_52(AsmJitNative.smethod_0<AsmJitApi.Delegate28>(EncodedStringTable.smethod_0(5642)));
			AsmJitApi.smethod_53(AsmJitNative.smethod_0<AsmJitApi.Delegate30>(EncodedStringTable.smethod_0(5711)));
			AsmJitApi.smethod_54(AsmJitNative.smethod_0<AsmJitApi.Delegate29>(EncodedStringTable.smethod_0(5796)));
			AsmJitApi.smethod_55(AsmJitNative.smethod_0<AsmJitApi.Delegate31>(EncodedStringTable.smethod_0(5881)));
			AsmJitApi.smethod_56(AsmJitNative.smethod_0<AsmJitApi.Delegate33>(EncodedStringTable.smethod_0(5938)));
			AsmJitApi.smethod_57(AsmJitNative.smethod_0<AsmJitApi.Delegate32>(EncodedStringTable.smethod_0(6011)));
			AsmJitApi.smethod_58(AsmJitNative.smethod_0<AsmJitApi.Delegate35>(EncodedStringTable.smethod_0(6084)));
			AsmJitApi.smethod_59(AsmJitNative.smethod_0<AsmJitApi.Delegate37>(EncodedStringTable.smethod_0(6153)));
			AsmJitApi.smethod_61(AsmJitNative.smethod_0<AsmJitApi.Delegate34>(EncodedStringTable.smethod_0(6226)));
			AsmJitApi.smethod_62(AsmJitNative.smethod_0<AsmJitApi.Delegate36>(EncodedStringTable.smethod_0(6295)));
			AsmJitApi.smethod_66(AsmJitNative.smethod_0<AsmJitApi.Delegate39>(EncodedStringTable.smethod_0(6368)));
			AsmJitApi.smethod_67(AsmJitNative.smethod_0<AsmJitApi.Delegate40>(EncodedStringTable.smethod_0(6421)));
			return;
		}
		AsmJitApi.smethod_1(AsmJitNative.smethod_0<AsmJitApi.Delegate1>(EncodedStringTable.smethod_0(6474)));
		AsmJitApi.smethod_5(AsmJitNative.smethod_0<AsmJitApi.Delegate3>(EncodedStringTable.smethod_0(6539)));
		AsmJitApi.smethod_7(AsmJitNative.smethod_0<AsmJitApi.Delegate4>(EncodedStringTable.smethod_0(6604)));
		AsmJitApi.smethod_9(AsmJitNative.smethod_0<AsmJitApi.Delegate5>(EncodedStringTable.smethod_0(6685)));
		AsmJitApi.smethod_10(AsmJitNative.smethod_0<AsmJitApi.Delegate6>(EncodedStringTable.smethod_0(6770)));
		AsmJitApi.smethod_19(AsmJitNative.smethod_0<AsmJitApi.Delegate11>(EncodedStringTable.smethod_0(6855)));
		AsmJitApi.smethod_22(AsmJitNative.smethod_0<AsmJitApi.Delegate13>(EncodedStringTable.smethod_0(6904)));
		AsmJitApi.smethod_25(AsmJitNative.smethod_0<AsmJitApi.Delegate15>(EncodedStringTable.smethod_0(6961)));
		AsmJitApi.smethod_29(AsmJitNative.smethod_0<AsmJitApi.Delegate17>(EncodedStringTable.smethod_0(7022)));
		AsmJitApi.smethod_32(AsmJitNative.smethod_0<AsmJitApi.Delegate19>(EncodedStringTable.smethod_0(7075)));
		AsmJitApi.smethod_33(AsmJitNative.smethod_0<AsmJitApi.Delegate20>(EncodedStringTable.smethod_0(7140)));
		AsmJitApi.smethod_34(AsmJitNative.smethod_0<AsmJitApi.Delegate21>(EncodedStringTable.smethod_0(7209)));
		AsmJitApi.smethod_36(AsmJitNative.smethod_0<AsmJitApi.Delegate22>(EncodedStringTable.smethod_0(7294)));
		AsmJitApi.smethod_40(AsmJitNative.smethod_0<AsmJitApi.Delegate22>(EncodedStringTable.smethod_0(7363)));
		AsmJitApi.smethod_44(AsmJitNative.smethod_0<AsmJitApi.Delegate24>(EncodedStringTable.smethod_0(7440)));
		AsmJitApi.smethod_48(AsmJitNative.smethod_0<AsmJitApi.Delegate26>(EncodedStringTable.smethod_0(7505)));
		AsmJitApi.smethod_52(AsmJitNative.smethod_0<AsmJitApi.Delegate28>(EncodedStringTable.smethod_0(7566)));
		AsmJitApi.smethod_53(AsmJitNative.smethod_0<AsmJitApi.Delegate30>(EncodedStringTable.smethod_0(7631)));
		AsmJitApi.smethod_54(AsmJitNative.smethod_0<AsmJitApi.Delegate29>(EncodedStringTable.smethod_0(7712)));
		AsmJitApi.smethod_55(AsmJitNative.smethod_0<AsmJitApi.Delegate31>(EncodedStringTable.smethod_0(7793)));
		AsmJitApi.smethod_56(AsmJitNative.smethod_0<AsmJitApi.Delegate33>(EncodedStringTable.smethod_0(7846)));
		AsmJitApi.smethod_57(AsmJitNative.smethod_0<AsmJitApi.Delegate32>(EncodedStringTable.smethod_0(7915)));
		AsmJitApi.smethod_58(AsmJitNative.smethod_0<AsmJitApi.Delegate35>(EncodedStringTable.smethod_0(7984)));
		AsmJitApi.smethod_59(AsmJitNative.smethod_0<AsmJitApi.Delegate37>(EncodedStringTable.smethod_0(8049)));
		AsmJitApi.smethod_61(AsmJitNative.smethod_0<AsmJitApi.Delegate34>(EncodedStringTable.smethod_0(8118)));
		AsmJitApi.smethod_62(AsmJitNative.smethod_0<AsmJitApi.Delegate36>(EncodedStringTable.smethod_0(8183)));
		AsmJitApi.smethod_64(AsmJitNative.smethod_0<AsmJitApi.Delegate38>(EncodedStringTable.smethod_0(8252)));
		AsmJitApi.smethod_67(AsmJitNative.smethod_0<AsmJitApi.Delegate40>(EncodedStringTable.smethod_0(8301)));
	}
}
