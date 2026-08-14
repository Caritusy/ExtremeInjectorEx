using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

public static class AsmJitApi
{
	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate void DestroyAssemblerThisCall(ref AsmJitAssemblerState assemblerState, IntPtr address);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void DestroyAssemblerCdecl(ref AsmJitAssemblerState assemblerState, IntPtr address);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void EmitInstructionThisCall(ref AsmJitAssemblerState assemblerState, AsmJitInstructionId instructionId);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void EmitOneOperandInstructionThisCall(ref AsmJitAssemblerState assemblerState, AsmJitInstructionId instructionId, [In] AsmJitOperand operand);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void EmitTwoOperandInstructionThisCall(ref AsmJitAssemblerState assemblerState, AsmJitInstructionId instructionId, [In] AsmJitOperand operand, [In] AsmJitOperand operand2);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void EmitThreeOperandInstructionThisCall(ref AsmJitAssemblerState assemblerState, AsmJitInstructionId instructionId, [In] AsmJitOperand operand, [In] AsmJitOperand operand2, [In] AsmJitOperand operand3);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void EmitInstructionCdecl(ref AsmJitAssemblerState assemblerState, AsmJitInstructionId instructionId);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void EmitOneOperandInstructionCdecl(ref AsmJitAssemblerState assemblerState, AsmJitInstructionId instructionId, [In] AsmJitOperand operand);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void EmitTwoOperandInstructionCdecl(ref AsmJitAssemblerState assemblerState, AsmJitInstructionId instructionId, [In] AsmJitOperand operand, [In] AsmJitOperand operand2);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void EmitThreeOperandInstructionCdecl(ref AsmJitAssemblerState assemblerState, AsmJitInstructionId instructionId, [In] AsmJitOperand operand, [In] AsmJitOperand operand2, [In] AsmJitOperand operand3);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr GetAssemblerOffsetThisCall(ref AsmJitAssemblerState assemblerState);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr GetAssemblerOffsetCdecl(ref AsmJitAssemblerState assemblerState);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate IntPtr GetAssemblerPointerThisCall(ref AsmJitAssemblerState assemblerState, IntPtr address);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr GetAssemblerPointerCdecl(ref AsmJitAssemblerState assemblerState, IntPtr address);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate IntPtr RelocateCodeThisCall(ref AsmJitAssemblerState assemblerState, IntPtr address, IntPtr address2);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr RelocateCodeCdecl(ref AsmJitAssemblerState assemblerState, IntPtr address, IntPtr address2);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void EmbedDataThisCall(ref AsmJitAssemblerState assemblerState, [In][MarshalAs(UnmanagedType.AsAny)] object instance, IntPtr address);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void EmbedDataCdecl(ref AsmJitAssemblerState assemblerState, [In][MarshalAs(UnmanagedType.AsAny)] object instance, IntPtr address);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr CreateBaseVariableMemoryOperand([In][Out] AsmJitMemoryOperand memoryOperand, AsmJitVariable variable, uint uintValue);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr CreateVariableMemoryOperand([In][Out] AsmJitMemoryOperand memoryOperand, AsmJitVariable variable, uint uintValue, IntPtr address);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr CreateIndexedVariableMemoryOperand([In][Out] AsmJitMemoryOperand memoryOperand, AsmJitVariable variable, uint uintValue, AsmJitGpVariable gpVariable, uint uintValue2, IntPtr address);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void EmitJumpThisCall(ref AsmJitAssemblerState assemblerState, AsmJitInstructionId instructionId, [In] AsmJitLabel label, AsmJitJumpHint jumpHint);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void EmitJumpCdecl(ref AsmJitAssemblerState assemblerState, AsmJitInstructionId instructionId, [In] AsmJitLabel label, AsmJitJumpHint jumpHint);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate IntPtr CreateLabelThisCall(ref AsmJitAssemblerState assemblerState, [In][Out] AsmJitLabel label);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr CreateLabelCdecl(ref AsmJitAssemblerState assemblerState, [In][Out] AsmJitLabel label);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate void BindLabelThisCall(ref AsmJitAssemblerState assemblerState, [In] AsmJitLabel label);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void BindLabelCdecl(ref AsmJitAssemblerState assemblerState, [In] AsmJitLabel label);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr CreateLabelMemoryOperand([In][Out] AsmJitMemoryOperand memoryOperand, [In] AsmJitLabel label, IntPtr address, uint uintValue);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr CreateRegisterIndexedLabelMemoryOperand([In][Out] AsmJitMemoryOperand memoryOperand, [In] AsmJitLabel label, [In] AsmJitGpRegister gpRegister, uint uintValue, IntPtr address, uint uintValue2);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr CreateVariableIndexedLabelMemoryOperand([In][Out] AsmJitMemoryOperand memoryOperand, [In] AsmJitLabel label, [In] AsmJitGpVariable gpVariable, uint uintValue, IntPtr address, uint uintValue2);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr CreateAbsoluteMemoryOperand([In][Out] AsmJitMemoryOperand memoryOperand, [In] IntPtr address, IntPtr address2, AsmJitSegmentPrefix segmentPrefix, uint uintValue);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr CreateRegisterIndexedAbsoluteMemoryOperand([In][Out] AsmJitMemoryOperand memoryOperand, [In] IntPtr address, [In] AsmJitGpRegister gpRegister, uint uintValue, IntPtr address2, AsmJitSegmentPrefix segmentPrefix, uint uintValue2);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr CreateVariableIndexedAbsoluteMemoryOperand([In][Out] AsmJitMemoryOperand memoryOperand, [In] IntPtr address, [In] AsmJitGpVariable gpVariable, uint uintValue, IntPtr address2, AsmJitSegmentPrefix segmentPrefix, uint uintValue2);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr CreateRegisterMemoryOperand([In][Out] AsmJitMemoryOperand memoryOperand, [In] AsmJitGpRegister gpRegister, IntPtr address, uint uintValue);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr CreateVariableMemoryOperandBase([In][Out] AsmJitMemoryOperand memoryOperand, [In] AsmJitGpVariable gpVariable, IntPtr address, uint uintValue);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr CreateRegisterPairMemoryOperand([In][Out] AsmJitMemoryOperand memoryOperand, [In] AsmJitGpRegister gpRegister, [In] AsmJitGpRegister gpRegister2, uint uintValue, IntPtr address, uint uintValue2);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr CreateVariablePairMemoryOperand([In][Out] AsmJitMemoryOperand memoryOperand, [In] AsmJitGpVariable gpVariable, [In] AsmJitGpVariable gpVariable2, uint uintValue, IntPtr address, uint uintValue2);

	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	[SuppressUnmanagedCodeSecurity]
	public delegate void AlignAssemblerThisCall(ref AsmJitAssemblerState assemblerState, uint uintValue);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void AlignAssemblerCdecl(ref AsmJitAssemblerState assemblerState, uint uintValue);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[SuppressUnmanagedCodeSecurity]
	public delegate IntPtr GetNativeApiPointer();

	[CompilerGenerated]
	internal static DestroyAssemblerThisCall destroyAssemblerThisCall;

	[CompilerGenerated]
	internal static DestroyAssemblerCdecl destroyAssemblerCdecl;

	[CompilerGenerated]
	internal static EmitInstructionThisCall emitInstructionThisCall;

	[CompilerGenerated]
	internal static EmitOneOperandInstructionThisCall emitOneOperandInstructionThisCall;

	[CompilerGenerated]
	internal static EmitTwoOperandInstructionThisCall emitTwoOperandInstructionThisCall;

	[CompilerGenerated]
	internal static EmitThreeOperandInstructionThisCall emitThreeOperandInstructionThisCall;

	[CompilerGenerated]
	internal static EmitInstructionCdecl emitInstructionCdecl;

	[CompilerGenerated]
	internal static EmitOneOperandInstructionCdecl emitOneOperandInstructionCdecl;

	[CompilerGenerated]
	internal static EmitTwoOperandInstructionCdecl emitTwoOperandInstructionCdecl;

	[CompilerGenerated]
	internal static EmitThreeOperandInstructionCdecl emitThreeOperandInstructionCdecl;

	[CompilerGenerated]
	internal static GetAssemblerOffsetThisCall getAssemblerOffsetThisCall;

	[CompilerGenerated]
	internal static GetAssemblerOffsetCdecl getAssemblerOffsetCdecl;

	[CompilerGenerated]
	internal static GetAssemblerPointerThisCall getAssemblerPointerThisCall;

	[CompilerGenerated]
	internal static GetAssemblerPointerCdecl getAssemblerPointerCdecl;

	[CompilerGenerated]
	internal static RelocateCodeThisCall relocateCodeThisCall;

	[CompilerGenerated]
	internal static RelocateCodeCdecl relocateCodeCdecl;

	[CompilerGenerated]
	internal static EmbedDataThisCall embedDataThisCall;

	[CompilerGenerated]
	internal static EmbedDataCdecl embedDataCdecl;

	[CompilerGenerated]
	internal static CreateBaseVariableMemoryOperand createBaseVariableMemoryOperand;

	[CompilerGenerated]
	internal static CreateVariableMemoryOperand createVariableMemoryOperand;

	[CompilerGenerated]
	internal static CreateIndexedVariableMemoryOperand createIndexedVariableMemoryOperand;

	[CompilerGenerated]
	internal static EmitJumpThisCall emitJumpThisCall;

	[CompilerGenerated]
	internal static EmitJumpCdecl emitJumpCdecl;

	[CompilerGenerated]
	internal static EmitJumpThisCall emitJumpThisCall2;

	[CompilerGenerated]
	internal static EmitJumpCdecl emitJumpCdecl2;

	[CompilerGenerated]
	internal static CreateLabelThisCall createLabelThisCall;

	[CompilerGenerated]
	internal static CreateLabelCdecl createLabelCdecl;

	[CompilerGenerated]
	internal static BindLabelThisCall bindLabelThisCall;

	[CompilerGenerated]
	internal static BindLabelCdecl bindLabelCdecl;

	[CompilerGenerated]
	internal static CreateLabelMemoryOperand createLabelMemoryOperand;

	[CompilerGenerated]
	internal static CreateVariableIndexedLabelMemoryOperand createVariableIndexedLabelMemoryOperand;

	[CompilerGenerated]
	internal static CreateRegisterIndexedLabelMemoryOperand createRegisterIndexedLabelMemoryOperand;

	[CompilerGenerated]
	internal static CreateAbsoluteMemoryOperand createAbsoluteMemoryOperand;

	[CompilerGenerated]
	internal static CreateVariableIndexedAbsoluteMemoryOperand createVariableIndexedAbsoluteMemoryOperand;

	[CompilerGenerated]
	internal static CreateRegisterIndexedAbsoluteMemoryOperand createRegisterIndexedAbsoluteMemoryOperand;

	[CompilerGenerated]
	internal static CreateVariableMemoryOperandBase createVariableMemoryOperandBase;

	[CompilerGenerated]
	internal static CreateVariablePairMemoryOperand createVariablePairMemoryOperand;

	[CompilerGenerated]
	internal static CreateRegisterMemoryOperand createRegisterMemoryOperand;

	[CompilerGenerated]
	internal static CreateRegisterPairMemoryOperand createRegisterPairMemoryOperand;

	[CompilerGenerated]
	internal static AlignAssemblerThisCall alignAssemblerThisCall;

	[CompilerGenerated]
	internal static AlignAssemblerCdecl alignAssemblerCdecl;

	[CompilerGenerated]
	internal static GetNativeApiPointer getNativeApiPointer;

	static AsmJitApi()
	{
		if (AsmJitRuntime.flag)
		{
			AsmJitApi.destroyAssemblerCdecl=AsmJitNative.ResolveDelegate<AsmJitApi.DestroyAssemblerCdecl>(EncodedStringTable.DecodeString(4502));
			AsmJitApi.emitInstructionCdecl=AsmJitNative.ResolveDelegate<AsmJitApi.EmitInstructionCdecl>(EncodedStringTable.DecodeString(4567));
			AsmJitApi.emitOneOperandInstructionCdecl=AsmJitNative.ResolveDelegate<AsmJitApi.EmitOneOperandInstructionCdecl>(EncodedStringTable.DecodeString(4632));
			AsmJitApi.emitTwoOperandInstructionCdecl=AsmJitNative.ResolveDelegate<AsmJitApi.EmitTwoOperandInstructionCdecl>(EncodedStringTable.DecodeString(4717));
			AsmJitApi.emitThreeOperandInstructionCdecl=AsmJitNative.ResolveDelegate<AsmJitApi.EmitThreeOperandInstructionCdecl>(EncodedStringTable.DecodeString(4802));
			AsmJitApi.getAssemblerOffsetCdecl=AsmJitNative.ResolveDelegate<AsmJitApi.GetAssemblerOffsetCdecl>(EncodedStringTable.DecodeString(4891));
			AsmJitApi.getAssemblerPointerCdecl=AsmJitNative.ResolveDelegate<AsmJitApi.GetAssemblerPointerCdecl>(EncodedStringTable.DecodeString(4944));
			AsmJitApi.relocateCodeCdecl=AsmJitNative.ResolveDelegate<AsmJitApi.RelocateCodeCdecl>(EncodedStringTable.DecodeString(5005));
			AsmJitApi.embedDataCdecl=AsmJitNative.ResolveDelegate<AsmJitApi.EmbedDataCdecl>(EncodedStringTable.DecodeString(5070));
			AsmJitApi.createBaseVariableMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateBaseVariableMemoryOperand>(EncodedStringTable.DecodeString(5127));
			AsmJitApi.createVariableMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateVariableMemoryOperand>(EncodedStringTable.DecodeString(5196));
			AsmJitApi.createIndexedVariableMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateIndexedVariableMemoryOperand>(EncodedStringTable.DecodeString(5265));
			AsmJitApi.emitJumpCdecl=AsmJitNative.ResolveDelegate<AsmJitApi.EmitJumpCdecl>(EncodedStringTable.DecodeString(5354));
			AsmJitApi.emitJumpCdecl2=AsmJitNative.ResolveDelegate<AsmJitApi.EmitJumpCdecl>(EncodedStringTable.DecodeString(5427));
			AsmJitApi.createLabelCdecl=AsmJitNative.ResolveDelegate<AsmJitApi.CreateLabelCdecl>(EncodedStringTable.DecodeString(5508));
			AsmJitApi.bindLabelCdecl=AsmJitNative.ResolveDelegate<AsmJitApi.BindLabelCdecl>(EncodedStringTable.DecodeString(5577));
			AsmJitApi.createLabelMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateLabelMemoryOperand>(EncodedStringTable.DecodeString(5642));
			AsmJitApi.createVariableIndexedLabelMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateVariableIndexedLabelMemoryOperand>(EncodedStringTable.DecodeString(5711));
			AsmJitApi.createRegisterIndexedLabelMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateRegisterIndexedLabelMemoryOperand>(EncodedStringTable.DecodeString(5796));
			AsmJitApi.createAbsoluteMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateAbsoluteMemoryOperand>(EncodedStringTable.DecodeString(5881));
			AsmJitApi.createVariableIndexedAbsoluteMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateVariableIndexedAbsoluteMemoryOperand>(EncodedStringTable.DecodeString(5938));
			AsmJitApi.createRegisterIndexedAbsoluteMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateRegisterIndexedAbsoluteMemoryOperand>(EncodedStringTable.DecodeString(6011));
			AsmJitApi.createVariableMemoryOperandBase=AsmJitNative.ResolveDelegate<AsmJitApi.CreateVariableMemoryOperandBase>(EncodedStringTable.DecodeString(6084));
			AsmJitApi.createVariablePairMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateVariablePairMemoryOperand>(EncodedStringTable.DecodeString(6153));
			AsmJitApi.createRegisterMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateRegisterMemoryOperand>(EncodedStringTable.DecodeString(6226));
			AsmJitApi.createRegisterPairMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateRegisterPairMemoryOperand>(EncodedStringTable.DecodeString(6295));
			AsmJitApi.alignAssemblerCdecl=AsmJitNative.ResolveDelegate<AsmJitApi.AlignAssemblerCdecl>(EncodedStringTable.DecodeString(6368));
			AsmJitApi.getNativeApiPointer=AsmJitNative.ResolveDelegate<AsmJitApi.GetNativeApiPointer>(EncodedStringTable.DecodeString(6421));
			return;
		}
		AsmJitApi.destroyAssemblerThisCall=AsmJitNative.ResolveDelegate<AsmJitApi.DestroyAssemblerThisCall>(EncodedStringTable.DecodeString(6474));
		AsmJitApi.emitInstructionThisCall=AsmJitNative.ResolveDelegate<AsmJitApi.EmitInstructionThisCall>(EncodedStringTable.DecodeString(6539));
		AsmJitApi.emitOneOperandInstructionThisCall=AsmJitNative.ResolveDelegate<AsmJitApi.EmitOneOperandInstructionThisCall>(EncodedStringTable.DecodeString(6604));
		AsmJitApi.emitTwoOperandInstructionThisCall=AsmJitNative.ResolveDelegate<AsmJitApi.EmitTwoOperandInstructionThisCall>(EncodedStringTable.DecodeString(6685));
		AsmJitApi.emitThreeOperandInstructionThisCall=AsmJitNative.ResolveDelegate<AsmJitApi.EmitThreeOperandInstructionThisCall>(EncodedStringTable.DecodeString(6770));
		AsmJitApi.getAssemblerOffsetThisCall=AsmJitNative.ResolveDelegate<AsmJitApi.GetAssemblerOffsetThisCall>(EncodedStringTable.DecodeString(6855));
		AsmJitApi.getAssemblerPointerThisCall=AsmJitNative.ResolveDelegate<AsmJitApi.GetAssemblerPointerThisCall>(EncodedStringTable.DecodeString(6904));
		AsmJitApi.relocateCodeThisCall=AsmJitNative.ResolveDelegate<AsmJitApi.RelocateCodeThisCall>(EncodedStringTable.DecodeString(6961));
		AsmJitApi.embedDataThisCall=AsmJitNative.ResolveDelegate<AsmJitApi.EmbedDataThisCall>(EncodedStringTable.DecodeString(7022));
		AsmJitApi.createBaseVariableMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateBaseVariableMemoryOperand>(EncodedStringTable.DecodeString(7075));
		AsmJitApi.createVariableMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateVariableMemoryOperand>(EncodedStringTable.DecodeString(7140));
		AsmJitApi.createIndexedVariableMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateIndexedVariableMemoryOperand>(EncodedStringTable.DecodeString(7209));
		AsmJitApi.emitJumpThisCall=AsmJitNative.ResolveDelegate<AsmJitApi.EmitJumpThisCall>(EncodedStringTable.DecodeString(7294));
		AsmJitApi.emitJumpThisCall2=AsmJitNative.ResolveDelegate<AsmJitApi.EmitJumpThisCall>(EncodedStringTable.DecodeString(7363));
		AsmJitApi.createLabelThisCall=AsmJitNative.ResolveDelegate<AsmJitApi.CreateLabelThisCall>(EncodedStringTable.DecodeString(7440));
		AsmJitApi.bindLabelThisCall=AsmJitNative.ResolveDelegate<AsmJitApi.BindLabelThisCall>(EncodedStringTable.DecodeString(7505));
		AsmJitApi.createLabelMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateLabelMemoryOperand>(EncodedStringTable.DecodeString(7566));
		AsmJitApi.createVariableIndexedLabelMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateVariableIndexedLabelMemoryOperand>(EncodedStringTable.DecodeString(7631));
		AsmJitApi.createRegisterIndexedLabelMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateRegisterIndexedLabelMemoryOperand>(EncodedStringTable.DecodeString(7712));
		AsmJitApi.createAbsoluteMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateAbsoluteMemoryOperand>(EncodedStringTable.DecodeString(7793));
		AsmJitApi.createVariableIndexedAbsoluteMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateVariableIndexedAbsoluteMemoryOperand>(EncodedStringTable.DecodeString(7846));
		AsmJitApi.createRegisterIndexedAbsoluteMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateRegisterIndexedAbsoluteMemoryOperand>(EncodedStringTable.DecodeString(7915));
		AsmJitApi.createVariableMemoryOperandBase=AsmJitNative.ResolveDelegate<AsmJitApi.CreateVariableMemoryOperandBase>(EncodedStringTable.DecodeString(7984));
		AsmJitApi.createVariablePairMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateVariablePairMemoryOperand>(EncodedStringTable.DecodeString(8049));
		AsmJitApi.createRegisterMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateRegisterMemoryOperand>(EncodedStringTable.DecodeString(8118));
		AsmJitApi.createRegisterPairMemoryOperand=AsmJitNative.ResolveDelegate<AsmJitApi.CreateRegisterPairMemoryOperand>(EncodedStringTable.DecodeString(8183));
		AsmJitApi.alignAssemblerThisCall=AsmJitNative.ResolveDelegate<AsmJitApi.AlignAssemblerThisCall>(EncodedStringTable.DecodeString(8252));
		AsmJitApi.getNativeApiPointer=AsmJitNative.ResolveDelegate<AsmJitApi.GetNativeApiPointer>(EncodedStringTable.DecodeString(8301));
	}
}
