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

	static AsmJitApi()
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.delegate2_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate2>(EncodedStringTable.DecodeString(4502));
			AsmJitApi.delegate7_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate7>(EncodedStringTable.DecodeString(4567));
			AsmJitApi.delegate8_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate8>(EncodedStringTable.DecodeString(4632));
			AsmJitApi.delegate9_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate9>(EncodedStringTable.DecodeString(4717));
			AsmJitApi.delegate10_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate10>(EncodedStringTable.DecodeString(4802));
			AsmJitApi.delegate12_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate12>(EncodedStringTable.DecodeString(4891));
			AsmJitApi.delegate14_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate14>(EncodedStringTable.DecodeString(4944));
			AsmJitApi.delegate16_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate16>(EncodedStringTable.DecodeString(5005));
			AsmJitApi.delegate18_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate18>(EncodedStringTable.DecodeString(5070));
			AsmJitApi.delegate19_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate19>(EncodedStringTable.DecodeString(5127));
			AsmJitApi.delegate20_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate20>(EncodedStringTable.DecodeString(5196));
			AsmJitApi.delegate21_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate21>(EncodedStringTable.DecodeString(5265));
			AsmJitApi.delegate23_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate23>(EncodedStringTable.DecodeString(5354));
			AsmJitApi.delegate23_1=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate23>(EncodedStringTable.DecodeString(5427));
			AsmJitApi.delegate25_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate25>(EncodedStringTable.DecodeString(5508));
			AsmJitApi.delegate27_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate27>(EncodedStringTable.DecodeString(5577));
			AsmJitApi.delegate28_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate28>(EncodedStringTable.DecodeString(5642));
			AsmJitApi.delegate30_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate30>(EncodedStringTable.DecodeString(5711));
			AsmJitApi.delegate29_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate29>(EncodedStringTable.DecodeString(5796));
			AsmJitApi.delegate31_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate31>(EncodedStringTable.DecodeString(5881));
			AsmJitApi.delegate33_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate33>(EncodedStringTable.DecodeString(5938));
			AsmJitApi.delegate32_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate32>(EncodedStringTable.DecodeString(6011));
			AsmJitApi.delegate35_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate35>(EncodedStringTable.DecodeString(6084));
			AsmJitApi.delegate37_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate37>(EncodedStringTable.DecodeString(6153));
			AsmJitApi.delegate34_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate34>(EncodedStringTable.DecodeString(6226));
			AsmJitApi.delegate36_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate36>(EncodedStringTable.DecodeString(6295));
			AsmJitApi.delegate39_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate39>(EncodedStringTable.DecodeString(6368));
			AsmJitApi.delegate40_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate40>(EncodedStringTable.DecodeString(6421));
			return;
		}
		AsmJitApi.delegate1_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate1>(EncodedStringTable.DecodeString(6474));
		AsmJitApi.delegate3_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate3>(EncodedStringTable.DecodeString(6539));
		AsmJitApi.delegate4_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate4>(EncodedStringTable.DecodeString(6604));
		AsmJitApi.delegate5_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate5>(EncodedStringTable.DecodeString(6685));
		AsmJitApi.delegate6_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate6>(EncodedStringTable.DecodeString(6770));
		AsmJitApi.delegate11_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate11>(EncodedStringTable.DecodeString(6855));
		AsmJitApi.delegate13_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate13>(EncodedStringTable.DecodeString(6904));
		AsmJitApi.delegate15_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate15>(EncodedStringTable.DecodeString(6961));
		AsmJitApi.delegate17_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate17>(EncodedStringTable.DecodeString(7022));
		AsmJitApi.delegate19_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate19>(EncodedStringTable.DecodeString(7075));
		AsmJitApi.delegate20_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate20>(EncodedStringTable.DecodeString(7140));
		AsmJitApi.delegate21_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate21>(EncodedStringTable.DecodeString(7209));
		AsmJitApi.delegate22_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate22>(EncodedStringTable.DecodeString(7294));
		AsmJitApi.delegate22_1=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate22>(EncodedStringTable.DecodeString(7363));
		AsmJitApi.delegate24_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate24>(EncodedStringTable.DecodeString(7440));
		AsmJitApi.delegate26_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate26>(EncodedStringTable.DecodeString(7505));
		AsmJitApi.delegate28_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate28>(EncodedStringTable.DecodeString(7566));
		AsmJitApi.delegate30_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate30>(EncodedStringTable.DecodeString(7631));
		AsmJitApi.delegate29_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate29>(EncodedStringTable.DecodeString(7712));
		AsmJitApi.delegate31_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate31>(EncodedStringTable.DecodeString(7793));
		AsmJitApi.delegate33_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate33>(EncodedStringTable.DecodeString(7846));
		AsmJitApi.delegate32_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate32>(EncodedStringTable.DecodeString(7915));
		AsmJitApi.delegate35_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate35>(EncodedStringTable.DecodeString(7984));
		AsmJitApi.delegate37_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate37>(EncodedStringTable.DecodeString(8049));
		AsmJitApi.delegate34_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate34>(EncodedStringTable.DecodeString(8118));
		AsmJitApi.delegate36_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate36>(EncodedStringTable.DecodeString(8183));
		AsmJitApi.delegate38_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate38>(EncodedStringTable.DecodeString(8252));
		AsmJitApi.delegate40_0=AsmJitNative.ResolveDelegate<AsmJitApi.Delegate40>(EncodedStringTable.DecodeString(8301));
	}
}
