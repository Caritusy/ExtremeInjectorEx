using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ExtremeInjector;
using Microsoft.Win32;

public sealed partial class RecoveredRuntime
{

	internal static void EmitRemoteCallPrologue(RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			RecoveredRuntime.EmitPushRegister(class47_0.class53_0, AsmJitRuntime.class63_42);
			RecoveredRuntime.EmitMoveRegisterToRegister(class47_0.class53_0, AsmJitRuntime.class63_42, AsmJitRuntime.class63_41);
			return;
		}
		if (class47_0.bool_1)
		{
			class47_0.class58_1 = RecoveredRuntime.CreateLabel(class47_0.class53_0);
			AsmJitAssembler class53_ = class47_0.class53_0;
			class53_.struct19_0.uint_2 = (class53_.struct19_0.uint_2 | 8u);
			RecoveredRuntime.EmitMoveRegisterToMemory(class47_0.class53_0, RecoveredRuntime.CreateDwordLabelMemory(class47_0.class58_1, 0L), AsmJitRuntime.class63_41);
			AsmJitAssembler class53_2 = class47_0.class53_0;
			AsmJitGpRegister class63_ = AsmJitRuntime.class63_41;
			AsmJitImmediate class57_ = RecoveredRuntime.CreateImmediate(4294967280u);
			RecoveredRuntime.EmitAndRegisterImmediate(class63_, class57_, class53_2);
			RecoveredRuntime.EmbedByte(106, class47_0.class53_0);
			RecoveredRuntime.EmbedByte(51, class47_0.class53_0);
			RecoveredRuntime.EmbedByte(232, class47_0.class53_0);
			RecoveredRuntime.EmbedUInt32(class47_0.class53_0, 0u);
			RecoveredRuntime.EmbedByte(131, class47_0.class53_0);
			RecoveredRuntime.EmbedByte(4, class47_0.class53_0);
			RecoveredRuntime.EmbedByte(36, class47_0.class53_0);
			RecoveredRuntime.EmbedByte(5, class47_0.class53_0);
			RecoveredRuntime.EmbedByte(203, class47_0.class53_0);
		}
		RecoveredRuntime.EmitMoveRegisterToMemory(class47_0.class53_0, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_57, 8L), AsmJitRuntime.class63_54);
		RecoveredRuntime.EmitMoveRegisterToMemory(class47_0.class53_0, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_57, 16L), AsmJitRuntime.class63_55);
		RecoveredRuntime.EmitMoveRegisterToMemory(class47_0.class53_0, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_57, 24L), AsmJitRuntime.class63_61);
		RecoveredRuntime.EmitMoveRegisterToMemory(class47_0.class53_0, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_57, 32L), AsmJitRuntime.class63_62);
	}

	internal static AsmJitOperand.Struct13 GetLabelOperandData(AsmJitOperand class56_0)
	{
		return AsmJitOperand.Reinterpret<AsmJitOperand.Struct7, AsmJitOperand.Struct13>(class56_0.GetRawData());
	}

	internal static void EmitPushFlags(AsmJitAssembler class53_0)
	{
		if (!class53_0.Is32BitMode && !AsmJitRuntime.bool_0)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(11455));
		}
		RecoveredRuntime.EmitInstruction(class53_0, AsmJitInstructionId.const_466);
	}

	internal static void EmitAndRegisterImmediate(AsmJitGpRegister class63_0, AsmJitImmediate class57_0, AsmJitAssembler class53_0)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_10, class63_0, class57_0);
	}

	internal static bool CreateRemoteActivationContext(ManualMapInjector class89_0, ManualMapInjector.Class172 class172_0)
	{
		byte[] array = ManualMapInjector.ExtractManifestResource(class172_0.GetImage());
		if (array == null)
		{
			return true;
		}
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(class89_0.GetRemoteProcess())[EncodedStringTable.DecodeString(8503)];
		if (gclass == null)
		{
			return true;
		}
		IntPtr intPtr = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(12056), false);
		if (intPtr == IntPtr.Zero)
		{
			return RecoveredRuntime.FailManualMap(class89_0, new MissingMethodException(EncodedStringTable.DecodeString(12077)));
		}
		string tempFileName = Path.GetTempFileName();
		try
		{
			File.WriteAllBytes(tempFileName, array);
			IntPtr remoteBuffer = RecoveredRuntime.AllocateRemoteMemory(class89_0, 4096L, NativeTypes.Enum34.flag_2);
			if (remoteBuffer == IntPtr.Zero)
			{
				return RecoveredRuntime.FailManualMap(class89_0, new AccessViolationException(EncodedStringTable.DecodeString(12146)));
			}

			using (AsmJitAssembler assembler = new AsmJitAssembler())
			{
				RemoteAssembler remoteAssembler = new RemoteAssembler(assembler, class89_0.GetRemoteProcess());
				AsmJitLabel activationContextData = RecoveredRuntime.CreateLabel(assembler);
				RecoveredRuntime.EmitRemoteCallPrologue(remoteAssembler);
				RecoveredRuntime.EmitRemoteCall(remoteAssembler, new AsmJitImmediate(intPtr), CallingConvention.StdCall, new object[]
				{
					RecoveredRuntime.CreateLabelReference(remoteAssembler, activationContextData)
				});
				remoteAssembler.CaptureReturnValue<IntPtr>();
				RecoveredRuntime.EmitRemoteCallEpilogue(remoteAssembler, -1);
				RecoveredRuntime.AlignRemoteData(remoteAssembler);

				if (!RecoveredRuntime.Is32BitProcess(class89_0.GetRemoteProcess()))
				{
					NativeTypes.Struct52 activationContext = default(NativeTypes.Struct52);
					activationContext.int_0 = typeof(NativeTypes.Struct52).SizeOf();
					activationContext.intptr_0 = remoteBuffer.Add(RecoveredRuntime.GetAssemblerOffset(assembler));
					RecoveredRuntime.EmbedBytes(assembler, Encoding.Unicode.GetBytes(tempFileName + EncodedStringTable.DecodeString(12219)));
					RecoveredRuntime.AlignRemoteData(remoteAssembler);
					RecoveredRuntime.BindLabel(assembler, activationContextData);
					assembler.EmbedData(activationContext);
				}
				else
				{
					NativeTypes.Struct51 activationContext = default(NativeTypes.Struct51);
					activationContext.int_0 = typeof(NativeTypes.Struct51).SizeOf();
					activationContext.uint_1 = (uint)(remoteBuffer.ToInt32() + RecoveredRuntime.GetAssemblerOffset(assembler));
					RecoveredRuntime.EmbedBytes(assembler, Encoding.Unicode.GetBytes(tempFileName + EncodedStringTable.DecodeString(12219)));
					RecoveredRuntime.AlignRemoteData(remoteAssembler);
					RecoveredRuntime.BindLabel(assembler, activationContextData);
					assembler.EmbedData(activationContext);
				}

				class172_0.SetRemoteActivationContext(class89_0.Execute<IntPtr>(remoteAssembler, remoteBuffer, true));
				return true;
			}
		}
		finally
		{
			File.Delete(tempFileName);
		}
	}

	internal static void EmitInstruction(AsmJitAssembler class53_0, AsmJitInstructionId enum7_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.delegate7_0(ref class53_0.struct19_0, enum7_0);
		}
		else
		{
			AsmJitApi.delegate3_0(ref class53_0.struct19_0, enum7_0);
		}
	}

	internal static void EmitLowerBoundJump(AsmJitJumpHint enum12_0, AsmJitLabel class58_0, AsmJitAssembler class53_0)
	{
		EmitJumpInstruction(class58_0, enum12_0, class53_0, AsmJitInstructionId.const_225);
	}

	internal static void BindLabel(AsmJitAssembler class53_0, AsmJitLabel class58_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.delegate27_0(ref class53_0.struct19_0, class58_0);
			return;
		}
		AsmJitApi.delegate26_0(ref class53_0.struct19_0, class58_0);
	}

	internal static bool InvokeExport(ModuleEntry module, IntPtr intptr_0, RemoteProcess process)
	{
        if (HasProcessExited(process))
        {
            throw new InvalidOperationException(UiText.Get("Message.TargetNoLongerActive"));
        }

        ExportedSymbol export;
        using (FileStream stream = new FileStream(module.Path, FileMode.Open, FileAccess.Read, FileShare.Read))
        using (PeImage image = PeExportReader.ReadExports(stream, module.Path, ownsStream: false, layout: PeImageLayout.const_0))
        {
            if (image.GetExports() == null)
            {
                throw new MissingFieldException(UiText.Get("Message.ExportDirectoryMissing"));
            }

            export = image.GetExports().list_1.FirstOrDefault(candidate => candidate.GetName() == module.ExportName);
            if (export == null)
            {
                throw new MissingMethodException(UiText.Format("Message.ExportNotFound", module.ExportName));
            }
        }

        IntPtr exportAddress = intptr_0.Add(export.GetAddressRva());
        if (module.Parameters == null)
        {
            module.Parameters = new List<ExportParameter>();
        }

        object[] values = module.Parameters.Select(ParseExportParameterValue).ToArray();
        AsmJitAssembler assembler = new AsmJitAssembler();
        RemoteAssembler remoteAssembler = new RemoteAssembler(assembler, process);
        List<AsmJitLabel> stringLabels = new List<AsmJitLabel>();
        List<object> arguments = new List<object>();

        for (int index = 0; index < values.Length; index++)
        {
            if (values[index] is string)
            {
                AsmJitLabel label = CreateLabel(assembler);
                stringLabels.Add(label);
                arguments.Add(CreateLabelReference(remoteAssembler, label));
                continue;
            }

            if (Is32BitProcess(process) && module.Parameters[index].Type == ExportParameterType.UInt64)
            {
                long value = (long)values[index];
                arguments.Add(((ulong)(value & 0xFFFFFFFFL)).ToImmediate());
                arguments.Add(((ulong)(value & -4294967296L) >> 32).ToImmediate());
            }
            else
            {
                arguments.Add(values[index].ToImmediate());
            }
        }

        EmitRemoteCallPrologue(remoteAssembler);
        EmitRemoteCall(remoteAssembler, new AsmJitImmediate(exportAddress), module.CallingConvention, arguments.ToArray());
        EmitRemoteCallEpilogue(remoteAssembler, -1);

        int stringIndex = 0;
        for (int index = 0; index < values.Length; index++)
        {
            if (values[index] is not string text)
            {
                continue;
            }

            AlignRemoteData(remoteAssembler);
            BindLabel(assembler, stringLabels[stringIndex++]);
            if (module.Parameters[index].Type == ExportParameterType.AnsiString)
            {
                EmbedBytes(assembler, Encoding.ASCII.GetBytes(text));
                EmbedByte(0, assembler);
            }
            else
            {
                EmbedBytes(assembler, Encoding.Unicode.GetBytes(text));
                EmbedUInt16(0, assembler);
            }
        }

        using (RemoteCodeExecutor executor = new RemoteCodeExecutor(process))
        {
            return ExecuteRemoteAssembler(executor, assembler);
        }
    }

	internal static void WriteX86RegisterArgument(AsmJitGpRegister class63_0, RemoteAssembler class47_0, RemoteAssembler.Enum6 enum6_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_38,
			AsmJitRuntime.class63_39
		};
		if (enum6_0 < RemoteAssembler.Enum6.const_2)
		{
			RecoveredRuntime.EmitMoveRegisterToRegister(class47_0.class53_0, array[(int)enum6_0], class63_0);
			return;
		}
		RecoveredRuntime.EmitPushRegister(class47_0.class53_0, class63_0);
	}

	internal static AsmJitLabel CreateLabel(AsmJitAssembler class53_0)
	{
		AsmJitLabel @class = new AsmJitLabel();
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.delegate25_0(ref class53_0.struct19_0, @class);
		}
		else
		{
			AsmJitApi.delegate24_0(ref class53_0.struct19_0, @class);
		}
		return @class;
	}

	internal static bool OperandsNotEqual(AsmJitOperand class56_0, AsmJitOperand class56_1)
	{
		return !OperandsEqual(class56_0, class56_1);
	}

	internal static AsmJitMemoryManager CreateAsmJitMemoryManager()
	{
		return new NativeAsmJitMemoryManager(AsmJitMemoryManager.delegate41_0());
	}

	internal static void EmbedUInt16(AsmJitAssembler class53_0, ushort ushort_0)
	{
		EmbedData(2L, ushort_0, class53_0);
	}

	internal static void EmitPopFlags(AsmJitAssembler class53_0)
	{
		if (!class53_0.Is32BitMode && AsmJitRuntime.bool_0)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(12411));
		}
		RecoveredRuntime.EmitInstruction(class53_0, AsmJitInstructionId.const_422);
	}

	internal static void EmitRemoteCall(RemoteAssembler class47_0, AsmJitImmediate class57_0, CallingConvention callingConvention_0, object[] object_0)
	{
		DispatchRemoteCallByArchitecture(object_0, callingConvention_0, class57_0, class47_0);
	}

	internal static void EmitPopAllRegisters(AsmJitAssembler class53_0)
	{
		if (class53_0.Is32BitMode || !AsmJitRuntime.bool_0)
		{
			RecoveredRuntime.EmitInstruction(class53_0, AsmJitInstructionId.const_420);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(12411));
	}

	internal static void SetVariableOperandData(AsmJitOperand.Struct14 struct14_0, AsmJitOperand class56_0)
	{
		class56_0.SetRawData(AsmJitOperand.Reinterpret<AsmJitOperand.Struct14, AsmJitOperand.Struct7>(struct14_0));
	}

	internal static AsmJitImmediate CreateImmediate(sbyte sbyte_0)
	{
		return new AsmJitImmediate((IntPtr)sbyte_0);
	}

	internal static IntPtr AssembleRemoteCode(AsmJitAssembler class53_0, RemoteCodeExecutorBase class84_0)
	{
		return AssembleRemoteCode(IntPtr.Zero, class53_0, class84_0);
	}

	internal static void EmitMoveRegisterToXmm(AsmJitAssembler class53_0, AsmJitXmmRegister class65_0, AsmJitGpRegister class63_0)
	{
		if (class53_0.Is32BitMode || AsmJitRuntime.bool_0)
		{
			RecoveredRuntime.EmitInstruction(class53_0, AsmJitInstructionId.const_289, class65_0, class63_0);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(11455));
	}

	internal static AsmJitImmediate CreateImmediate(byte byte_0)
	{
		return new AsmJitImmediate((IntPtr)byte_0, bool_0: true);
	}

	internal static void EmitMoveRegisterToMemory(AsmJitAssembler class53_0, AsmJitMemoryOperand class59_0, AsmJitGpRegister class63_0)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_266, class59_0, class63_0);
	}

	internal static AsmJitMemoryOperand CreateDwordLabelMemoryForProcess(long long_0, RemoteAssembler class47_0, AsmJitLabel class58_0)
	{
		if (class47_0.bool_0)
		{
			AsmJitAssembler class53_ = class47_0.class53_0;
			class53_.struct19_0.uint_2 = (class53_.struct19_0.uint_2 | 8u);
		}
		return RecoveredRuntime.CreateDwordLabelMemory(class58_0, long_0);
	}

	internal static void EmitPushRegister(AsmJitAssembler class53_0, AsmJitGpRegister class63_0)
	{
		EmitInstruction(class63_0, AsmJitInstructionId.const_463, class53_0);
	}

	internal static void DispatchRemoteCallByArchitecture(object[] object_0, CallingConvention callingConvention_0, AsmJitOperand class56_0, RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			RecoveredRuntime.EmitX86FunctionCall(class56_0, object_0, callingConvention_0, class47_0);
			return;
		}
		RecoveredRuntime.EmitX64FunctionCall(class47_0, class56_0, object_0);
	}

	internal static object CreateLabelReference(RemoteAssembler class47_0, AsmJitLabel class58_0)
	{
		return new RemoteAssembler.Class48(class58_0);
	}

	internal static void EmitZeroResultJump(AsmJitLabel class58_0, AsmJitJumpHint enum12_0, AsmJitAssembler class53_0)
	{
		EmitJumpInstructionWithHint(AsmJitInstructionId.const_240, class58_0, class53_0, enum12_0);
	}

	internal static void EmitPushAllRegisters(AsmJitAssembler class53_0)
	{
		if (!class53_0.Is32BitMode && AsmJitRuntime.bool_0)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(12411));
		}
		RecoveredRuntime.EmitInstruction(class53_0, AsmJitInstructionId.const_465);
	}

	internal static void EmbedUInt64(AsmJitAssembler class53_0, ulong ulong_0)
	{
		EmbedData(8L, ulong_0, class53_0);
	}

	internal static void EmbedUInt16(ushort ushort_0, AsmJitAssembler class53_0)
	{
		EmbedData(2L, ushort_0, class53_0);
	}

	internal static void EmitCompareMemoryImmediate(AsmJitImmediate class57_0, AsmJitMemoryOperand class59_0, AsmJitAssembler class53_0)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_64, class59_0, class57_0);
	}

	internal static void WriteX86ImmediateArgument(RemoteAssembler.Enum6 enum6_0, AsmJitImmediate class57_0, RemoteAssembler class47_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_38,
			AsmJitRuntime.class63_39
		};
		if (enum6_0 >= RemoteAssembler.Enum6.const_2)
		{
			RecoveredRuntime.EmitPushImmediate(class47_0.class53_0, class57_0);
			return;
		}
		if (!(RecoveredRuntime.GetImmediateOperandData(class57_0).intptr_0 == IntPtr.Zero))
		{
			RecoveredRuntime.EmitMoveImmediateToRegister(class47_0.class53_0, array[(int)enum6_0], class57_0);
			return;
		}
		RecoveredRuntime.EmitXorRegisters(class47_0.class53_0, array[(int)enum6_0], array[(int)enum6_0]);
	}

	internal static void DisposeAssemblerState(AsmJitAssembler class53_0)
	{
		class53_0.struct19_0.struct15_0.Release();
		class53_0.struct19_0.struct17_0.Release();
		class53_0.struct19_0.struct18_1.Release();
		class53_0.struct19_0.struct18_0.Release();
		class53_0.struct19_0.uint_0 = 0u;
	}

	internal static AsmJitMemoryOperand CreateWordLabelMemoryForProcess(AsmJitLabel class58_0, long long_0, RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			AsmJitAssembler class53_ = class47_0.class53_0;
			class53_.struct19_0.uint_2 = (class53_.struct19_0.uint_2 | 8u);
		}
		return RecoveredRuntime.CreateWordLabelMemory(class58_0, long_0);
	}

	internal static void EmbedPointer(AsmJitAssembler class53_0, IntPtr intptr_0)
	{
		EmbedData(IntPtr.Size, intptr_0, class53_0);
	}

	internal static void WriteX64ImmediateArgument(RemoteAssembler class47_0, AsmJitImmediate class57_0, int int_0, bool bool_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_54,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_61,
			AsmJitRuntime.class63_62
		};
		AsmJitXmmRegister[] array2 = new AsmJitXmmRegister[]
		{
			AsmJitRuntime.class65_0,
			AsmJitRuntime.class65_1,
			AsmJitRuntime.class65_2,
			AsmJitRuntime.class65_3
		};
		bool flag = RecoveredRuntime.GetImmediateOperandData(class57_0).intptr_0 == IntPtr.Zero;
		if (int_0 >= 4)
		{
			if (!flag)
			{
				RecoveredRuntime.EmitMoveImmediateToRegister(class47_0.class53_0, AsmJitRuntime.class63_53, class57_0);
			}
			else
			{
				RecoveredRuntime.EmitXorRegisters(class47_0.class53_0, AsmJitRuntime.class63_53, AsmJitRuntime.class63_53);
			}
			RecoveredRuntime.EmitMoveRegisterToMemory(class47_0.class53_0, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_57, (long)(int_0 * 8)), AsmJitRuntime.class63_53);
			return;
		}
		if (bool_0)
		{
			if (flag)
			{
				RecoveredRuntime.EmitMoveImmediateToRegister(class47_0.class53_0, AsmJitRuntime.class63_53, class57_0);
			}
			else
			{
				RecoveredRuntime.EmitXorRegisters(class47_0.class53_0, AsmJitRuntime.class63_53, AsmJitRuntime.class63_53);
			}
			RecoveredRuntime.EmitMoveRegisterToXmm(class47_0.class53_0, array2[int_0], AsmJitRuntime.class63_53);
			return;
		}
		if (flag)
		{
			RecoveredRuntime.EmitXorRegisters(class47_0.class53_0, array[int_0], array[int_0]);
			return;
		}
		RecoveredRuntime.EmitMoveImmediateToRegister(class47_0.class53_0, array[int_0], class57_0);
	}

	internal static AsmJitImmediate CreateImmediate(ulong ulong_0)
	{
		if (!PlatformInfo.bool_0)
		{
			return new AsmJitImmediate((IntPtr)(int)ulong_0);
		}
		return new AsmJitImmediate((IntPtr)(long)ulong_0);
	}

	internal static AsmJitMemoryOperand CreateDwordLabelMemory(AsmJitLabel class58_0, long long_0)
	{
		return CreateLabelMemoryOperand(4u, (IntPtr)long_0, class58_0);
	}

	internal static void EmitMoveImmediateToMemory(AsmJitImmediate class57_0, AsmJitMemoryOperand class59_0, AsmJitAssembler class53_0)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_266, class59_0, class57_0);
	}

	internal static bool RegistersEqual(AsmJitRegister class62_0, AsmJitRegister class62_1)
	{
		return (class62_1 == null && class62_0 == null) || (class62_1 != null && class62_1.Equals(class62_0));
	}

	internal static void EmitInstruction(AsmJitAssembler class53_0, AsmJitInstructionId enum7_0, AsmJitOperand class56_0, AsmJitOperand class56_1)
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.delegate9_0(ref class53_0.struct19_0, enum7_0, class56_0, class56_1);
			return;
		}
		AsmJitApi.delegate5_0(ref class53_0.struct19_0, enum7_0, class56_0, class56_1);
	}

	internal static bool ExecuteRemoteAssembler(RemoteCodeExecutor class91_0, AsmJitAssembler class53_0)
	{
		return ExecuteAssemblerThread(class53_0, class91_0);
	}

	internal static IntPtr BuildThreadHijackStub32(ThreadHijackInjector class90_0, IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, out NativeTypes.Struct54 struct54_0, out int int_0, out int int_1, ref int int_2)
	{
		struct54_0 = default(NativeTypes.Struct54);
		int_0 = 0;
		int_1 = 0;
		AsmJitAssembler @class = new AsmJitAssembler();
		@class.Is32BitMode = true;
		AsmJitAssembler class2 = @class;
		AsmJitLabel class58_ = RecoveredRuntime.CreateLabel(class2);
		AsmJitLabel class58_2 = RecoveredRuntime.CreateLabel(class2);
		AsmJitLabel class58_3 = RecoveredRuntime.CreateLabel(class2);
		AsmJitLabel class58_4 = RecoveredRuntime.CreateLabel(class2);
		AsmJitLabel class58_5 = RecoveredRuntime.CreateLabel(class2);
		RecoveredRuntime.EmitPushImmediate(class2, RecoveredRuntime.CreateImmediate(struct54_0.uint_17));
		RecoveredRuntime.EmitPushAllRegisters(class2);
		RecoveredRuntime.EmitPushGeneralRegisters(class2);
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_37,
			AsmJitRuntime.class63_40,
			AsmJitRuntime.class63_39,
			AsmJitRuntime.class63_38,
			AsmJitRuntime.class63_44,
			AsmJitRuntime.class63_42,
			AsmJitRuntime.class63_59
		};
		AsmJitGpRegister[] array2 = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_69,
			AsmJitRuntime.class63_72,
			AsmJitRuntime.class63_71,
			AsmJitRuntime.class63_70,
			AsmJitRuntime.class63_76,
			AsmJitRuntime.class63_74,
			AsmJitRuntime.class63_60
		};
		AsmJitGpRegister class63_ = array.GetRandomElement<AsmJitGpRegister>();
		AsmJitAssembler class3 = class2;
		class3.struct19_0.uint_2 = (class3.struct19_0.uint_2 | 8u);
		RecoveredRuntime.EmitLoadEffectiveAddress(class2, class63_, RecoveredRuntime.CreateDwordLabelMemory(class58_, 0L));
		RecoveredRuntime.EmitPushRegister(class2, class63_);
		int num = array.GetRandomIndex<AsmJitGpRegister>();
		RecoveredRuntime.EmitMoveImmediateToRegister(class2, array[num], new AsmJitImmediate(intptr_0));
		RecoveredRuntime.EmitCallRegister(array2[num], class2);
		AsmJitAssembler class4 = class2;
		class4.struct19_0.uint_2 = (class4.struct19_0.uint_2 | 8u);
		RecoveredRuntime.EmitMoveRegisterToMemory(class2, RecoveredRuntime.CreateDwordLabelMemory(class58_3, 0L), AsmJitRuntime.class63_37);
		AsmJitGpRegister class63_2 = AsmJitRuntime.class63_37;
		AsmJitGpRegister class63_3 = AsmJitRuntime.class63_37;
		RecoveredRuntime.EmitTestRegisters(class63_2, class63_3, class2);
		RecoveredRuntime.EmitZeroResultJump(class58_5, AsmJitJumpHint.const_0, class2);
		RecoveredRuntime.EmitMoveImmediateToRegister(class2, array[num], new AsmJitImmediate(intptr_1));
		RecoveredRuntime.EmitCallRegister(array2[num], class2);
		AsmJitAssembler class5 = class2;
		class5.struct19_0.uint_2 = (class5.struct19_0.uint_2 | 8u);
		RecoveredRuntime.EmitMoveRegisterToMemory(class2, RecoveredRuntime.CreateDwordLabelMemory(class58_4, 0L), AsmJitRuntime.class63_37);
		RecoveredRuntime.BindLabel(class2, class58_5);
		AsmJitAssembler class6 = class2;
		class6.struct19_0.uint_2 = (class6.struct19_0.uint_2 | 8u);
		AsmJitMemoryOperand class59_ = RecoveredRuntime.CreateDwordLabelMemory(class58_2, 0L);
		AsmJitImmediate class57_ = RecoveredRuntime.CreateImmediate(1);
		RecoveredRuntime.EmitMoveImmediateToMemory(class57_, class59_, class2);
		RecoveredRuntime.EmitPopAllRegisters(class2);
		RecoveredRuntime.EmitPopFlags(class2);
		RecoveredRuntime.EmitReturn(class2);
		RecoveredRuntime.AlignCode(class2, 4u);
		RecoveredRuntime.BindLabel(class2, class58_);
		RecoveredRuntime.EmbedBytes(class2, byte_0);
		RecoveredRuntime.AlignCode(class2, 4u);
		RecoveredRuntime.BindLabel(class2, class58_4);
		int_2 = RecoveredRuntime.GetAssemblerOffset(class2);
		RecoveredRuntime.EmbedUInt32(class2, 0u);
		RecoveredRuntime.AlignCode(class2, 4u);
		RecoveredRuntime.BindLabel(class2, class58_3);
		int_1 = RecoveredRuntime.GetAssemblerOffset(class2);
		RecoveredRuntime.EmbedUInt32(class2, 0u);
		RecoveredRuntime.BindLabel(class2, class58_2);
		int_0 = RecoveredRuntime.GetAssemblerOffset(class2);
		RecoveredRuntime.EmbedUInt32(class2, 0u);
		return RecoveredRuntime.AssembleRemoteCode(class2, class90_0);
	}

	internal static void EmitJumpInstructionWithHint(AsmJitInstructionId enum7_0, AsmJitLabel class58_0, AsmJitAssembler class53_0, AsmJitJumpHint enum12_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.delegate23_1(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
			return;
		}
		AsmJitApi.delegate22_1(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
	}

	internal static void SetImmediateOperandData(AsmJitOperand class56_0, AsmJitOperand.Struct12 struct12_0)
	{
		class56_0.SetRawData(AsmJitOperand.Reinterpret<AsmJitOperand.Struct12, AsmJitOperand.Struct7>(struct12_0));
	}

	internal static AsmJitMemoryOperand CreateLabelMemoryOperand(uint uint_0, IntPtr intptr_0, AsmJitLabel class58_0)
	{
		AsmJitMemoryOperand @class = new AsmJitMemoryOperand();
		AsmJitApi.delegate28_0(@class, class58_0, intptr_0, uint_0);
		return @class;
	}

	internal static void EmitXorRegisters(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitGpRegister class63_1)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_575, class63_0, class63_1);
	}

	internal static AsmJitImmediate CreateImmediate(int int_0)
	{
		return new AsmJitImmediate((IntPtr)int_0);
	}

	internal static void EmitAddMemoryToRegister(AsmJitMemoryOperand class59_0, AsmJitGpRegister class63_0, AsmJitAssembler class53_0)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_1, class63_0, class59_0);
	}

	internal static void EmitPopRegister(AsmJitAssembler class53_0, AsmJitGpRegister class63_0)
	{
		EmitInstruction(class63_0, AsmJitInstructionId.const_419, class53_0);
	}

	internal static void EmitPushGeneralRegisters(AsmJitAssembler class53_0)
	{
		if (class53_0.Is32BitMode || !AsmJitRuntime.bool_0)
		{
			RecoveredRuntime.EmitInstruction(class53_0, AsmJitInstructionId.const_464);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(12411));
	}

	internal static IntPtr BuildThreadHijackStub64(ThreadHijackInjector class90_0, IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, out NativeTypes.Struct55 struct55_0, out int int_0, out int int_1, ref int int_2)
	{
		struct55_0 = default(NativeTypes.Struct55);
		int_0 = 0;
		int_1 = 0;
		AsmJitAssembler class53_ = new AsmJitAssembler();
		AsmJitLabel class58_ = RecoveredRuntime.CreateLabel(class53_);
		AsmJitLabel class58_2 = RecoveredRuntime.CreateLabel(class53_);
		AsmJitLabel class58_3 = RecoveredRuntime.CreateLabel(class53_);
		AsmJitLabel class58_4 = RecoveredRuntime.CreateLabel(class53_);
		AsmJitLabel class58_5 = RecoveredRuntime.CreateLabel(class53_);
		AsmJitLabel class58_6 = RecoveredRuntime.CreateLabel(class53_);
		RecoveredRuntime.EmitPushMemory(class53_, RecoveredRuntime.CreateQwordLabelMemory(class58_4, 0L));
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_53,
			AsmJitRuntime.class63_54,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_56,
			AsmJitRuntime.class63_58,
			AsmJitRuntime.class63_59,
			AsmJitRuntime.class63_60,
			AsmJitRuntime.class63_61,
			AsmJitRuntime.class63_62,
			AsmJitRuntime.class63_63,
			AsmJitRuntime.class63_64,
			AsmJitRuntime.class63_65,
			AsmJitRuntime.class63_66,
			AsmJitRuntime.class63_67,
			AsmJitRuntime.class63_68
		};
		array.Shuffle<AsmJitGpRegister>();
		RecoveredRuntime.EmitPushFlags(class53_);
		foreach (AsmJitGpRegister class63_ in array)
		{
			RecoveredRuntime.EmitPushRegister(class53_, class63_);
		}
		ulong num = (struct55_0.ulong_16 - (ulong)((long)(IntPtr.Size * (2 + array.Length)))) % 16UL;
		if (num != 0UL)
		{
			AsmJitGpRegister class63_2 = AsmJitRuntime.class63_57;
			AsmJitImmediate class57_ = RecoveredRuntime.CreateImmediate(num);
			RecoveredRuntime.EmitSubtractRegisterImmediate(class63_2, class57_, class53_);
		}
		RecoveredRuntime.EmitLoadEffectiveAddress(class53_, AsmJitRuntime.class63_54, RecoveredRuntime.CreateQwordLabelMemory(class58_, 0L));
		AsmJitGpRegister class63_3 = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_53,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_56,
			AsmJitRuntime.class63_58,
			AsmJitRuntime.class63_59,
			AsmJitRuntime.class63_60
		}.GetRandomElement<AsmJitGpRegister>();
		RecoveredRuntime.EmitMoveImmediateToRegister(class53_, class63_3, new AsmJitImmediate(intptr_0));
		RecoveredRuntime.EmitCallRegister(class63_3, class53_);
		RecoveredRuntime.EmitMoveRegisterToMemory(class53_, RecoveredRuntime.CreateQwordLabelMemory(class58_3, 0L), AsmJitRuntime.class63_53);
		AsmJitGpRegister class63_4 = AsmJitRuntime.class63_53;
		AsmJitGpRegister class63_5 = AsmJitRuntime.class63_53;
		RecoveredRuntime.EmitTestRegisters(class63_4, class63_5, class53_);
		RecoveredRuntime.EmitZeroResultJump(class58_5, AsmJitJumpHint.const_0, class53_);
		RecoveredRuntime.EmitMoveImmediateToRegister(class53_, class63_3, new AsmJitImmediate(intptr_1));
		RecoveredRuntime.EmitCallRegister(class63_3, class53_);
		RecoveredRuntime.EmitMoveRegisterToMemory(class53_, RecoveredRuntime.CreateDwordLabelMemory(class58_6, 0L), AsmJitRuntime.class63_37);
		RecoveredRuntime.BindLabel(class53_, class58_5);
		AsmJitMemoryOperand class59_ = RecoveredRuntime.CreateDwordLabelMemory(class58_2, 0L);
		AsmJitImmediate class57_2 = RecoveredRuntime.CreateImmediate(1);
		RecoveredRuntime.EmitMoveImmediateToMemory(class57_2, class59_, class53_);
		if (num != 0UL)
		{
			RecoveredRuntime.EmitAddRegisterImmediate(class53_, AsmJitRuntime.class63_57, RecoveredRuntime.CreateImmediate(num));
		}
		Array.Reverse(array);
		foreach (AsmJitGpRegister class63_6 in array)
		{
			RecoveredRuntime.EmitPopRegister(class53_, class63_6);
		}
		RecoveredRuntime.EmitPopFlags64(class53_);
		RecoveredRuntime.EmitReturn(class53_);
		RecoveredRuntime.AlignCode(class53_, 8u);
		RecoveredRuntime.BindLabel(class53_, class58_);
		RecoveredRuntime.EmbedBytes(class53_, byte_0);
		RecoveredRuntime.AlignCode(class53_, 8u);
		RecoveredRuntime.BindLabel(class53_, class58_4);
		RecoveredRuntime.EmbedUInt64(class53_, struct55_0.ulong_28);
		RecoveredRuntime.BindLabel(class53_, class58_3);
		int_1 = RecoveredRuntime.GetAssemblerOffset(class53_);
		RecoveredRuntime.EmbedPointer(class53_, IntPtr.Zero);
		RecoveredRuntime.AlignCode(class53_, 8u);
		int_2 = RecoveredRuntime.GetAssemblerOffset(class53_);
		RecoveredRuntime.BindLabel(class53_, class58_6);
		RecoveredRuntime.EmbedUInt32(class53_, 0u);
		RecoveredRuntime.AlignCode(class53_, 8u);
		RecoveredRuntime.BindLabel(class53_, class58_2);
		int_0 = RecoveredRuntime.GetAssemblerOffset(class53_);
		RecoveredRuntime.EmbedUInt32(class53_, 0u);
		return RecoveredRuntime.AssembleRemoteCode(class53_, class90_0);
	}

	internal static void WriteX86Argument(object object_0, RemoteAssembler class47_0, RemoteAssembler.Enum6 enum6_0)
	{
		RemoteAssembler.Class48 @class = object_0 as RemoteAssembler.Class48;
		if (@class != null)
		{
			RecoveredRuntime.EmitLoadEffectiveAddress(class47_0.class53_0, AsmJitRuntime.class63_37, RecoveredRuntime.CreatePointerLabelMemory(class47_0, @class.GetLabel(), 0L));
			RecoveredRuntime.WriteX86RegisterArgument(AsmJitRuntime.class63_37, class47_0, enum6_0);
			return;
		}
		AsmJitImmediate class2 = object_0.ToImmediate();
		if (RecoveredRuntime.OperandsNotEqual(class2, null))
		{
			RecoveredRuntime.WriteX86ImmediateArgument(enum6_0, class2, class47_0);
			return;
		}
		AsmJitGpRegister class3 = object_0 as AsmJitGpRegister;
		if (RecoveredRuntime.RegistersNotEqual(null, class3))
		{
			RecoveredRuntime.WriteX86RegisterArgument(class3, class47_0, enum6_0);
			return;
		}
		AsmJitMemoryOperand class59_ = object_0 as AsmJitMemoryOperand;
		if (!RecoveredRuntime.MemoryOperandsNotEqual(class59_, null))
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(13555));
		}
		RecoveredRuntime.WriteX86MemoryArgument(enum6_0, class47_0, class59_);
	}

	internal static AsmJitOperand.Struct9 GetRegisterOperandData(AsmJitOperand class56_0)
	{
		return AsmJitOperand.Reinterpret<AsmJitOperand.Struct7, AsmJitOperand.Struct9>(class56_0.GetRawData());
	}

	internal static void ReleaseAsmJitAllocation(IntPtr intptr_0)
	{
		if (AsmJitRuntime.delegate0_0 == null)
		{
			AsmJitRuntime.delegate0_0 = RecoveredRuntime.ResolveAsmJitAllocationDelegate();
		}
		AsmJitRuntime.delegate0_0(intptr_0);
	}

	internal static void EmitSubtractRegisterImmediate(AsmJitGpRegister class63_0, AsmJitImmediate class57_0, AsmJitAssembler class53_0)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_560, class63_0, class57_0);
	}

	internal static AsmJitImmediate CreateImmediate(long long_0)
	{
		if (!PlatformInfo.bool_0)
		{
			return new AsmJitImmediate((IntPtr)(int)long_0);
		}
		return new AsmJitImmediate((IntPtr)long_0);
	}

	internal static void WriteX64RegisterArgument(int int_0, RemoteAssembler class47_0, AsmJitGpRegister class63_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_54,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_61,
			AsmJitRuntime.class63_62
		};
		if (int_0 < 4)
		{
			RecoveredRuntime.EmitMoveRegisterToRegister(class47_0.class53_0, array[int_0], class63_0);
			return;
		}
		RecoveredRuntime.EmitMoveRegisterToRegister(class47_0.class53_0, AsmJitRuntime.class63_53, class63_0);
		RecoveredRuntime.EmitMoveRegisterToMemory(class47_0.class53_0, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_57, (long)(int_0 * 8)), AsmJitRuntime.class63_53);
	}

	internal static void AlignCode(AsmJitAssembler class53_0, uint uint_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.delegate39_0(ref class53_0.struct19_0, uint_0);
			return;
		}
		AsmJitApi.delegate38_0(ref class53_0.struct19_0, uint_0);
	}

	internal static void EmitCompareRegisters(AsmJitGpRegister class63_0, AsmJitAssembler class53_0, AsmJitGpRegister class63_1)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_64, class63_0, class63_1);
	}

	internal static AsmJitOperand.Struct8 GetBaseOperandData(AsmJitOperand class56_0)
	{
		return AsmJitOperand.Reinterpret<AsmJitOperand.Struct7, AsmJitOperand.Struct8>(class56_0.GetRawData());
	}

	internal static AsmJitOperand.Struct12 GetImmediateOperandData(AsmJitOperand class56_0)
	{
		return AsmJitOperand.Reinterpret<AsmJitOperand.Struct7, AsmJitOperand.Struct12>(class56_0.GetRawData());
	}

	internal static void EmitUpperBoundJump(AsmJitJumpHint enum12_0, AsmJitLabel class58_0, AsmJitAssembler class53_0)
	{
		EmitJumpInstruction(class58_0, enum12_0, class53_0, AsmJitInstructionId.const_223);
	}

	internal static AsmJitMemoryOperand CreatePointerLabelMemory(RemoteAssembler class47_0, AsmJitLabel class58_0, long long_0)
	{
		if (class47_0.bool_0)
		{
			class47_0.class53_0.struct19_0.uint_2 |= 8u;
			return CreateDwordLabelMemory(class58_0, long_0);
		}
		return CreateQwordLabelMemory(class58_0, long_0);
	}

	internal static void EmbedInt32(AsmJitAssembler class53_0, int int_0)
	{
		EmbedData(4L, int_0, class53_0);
	}

	internal static int DisassembleInstruction(ref BeaEngineDisasm struct31_0)
	{
		return BeaEngineDisassembler.delegate44_0(ref struct31_0);
	}

	internal static void EmitRemoteCallEpilogue(RemoteAssembler class47_0, int int_0)
	{
		if (class47_0.bool_0)
		{
			RecoveredRuntime.EmitMoveRegisterToRegister(class47_0.class53_0, AsmJitRuntime.class63_41, AsmJitRuntime.class63_42);
			RecoveredRuntime.EmitPopRegister(class47_0.class53_0, AsmJitRuntime.class63_42);
			RecoveredRuntime.EmitReturnAndPop(class47_0.class53_0, RecoveredRuntime.CreateImmediate((int_0 == -1) ? 4 : int_0));
		}
		else
		{
			RecoveredRuntime.EmitMoveMemoryToRegister(class47_0.class53_0, AsmJitRuntime.class63_54, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_57, 8L));
			RecoveredRuntime.EmitMoveMemoryToRegister(class47_0.class53_0, AsmJitRuntime.class63_55, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_57, 16L));
			RecoveredRuntime.EmitMoveMemoryToRegister(class47_0.class53_0, AsmJitRuntime.class63_61, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_57, 24L));
			RecoveredRuntime.EmitMoveMemoryToRegister(class47_0.class53_0, AsmJitRuntime.class63_62, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_57, 32L));
			if (class47_0.bool_1)
			{
				RecoveredRuntime.EmbedByte(232, class47_0.class53_0);
				RecoveredRuntime.EmbedUInt32(class47_0.class53_0, 0u);
				RecoveredRuntime.EmbedByte(199, class47_0.class53_0);
				RecoveredRuntime.EmbedByte(68, class47_0.class53_0);
				RecoveredRuntime.EmbedByte(36, class47_0.class53_0);
				RecoveredRuntime.EmbedByte(4, class47_0.class53_0);
				RecoveredRuntime.EmbedByte(35, class47_0.class53_0);
				RecoveredRuntime.EmbedByte(0, class47_0.class53_0);
				RecoveredRuntime.EmbedByte(0, class47_0.class53_0);
				RecoveredRuntime.EmbedByte(0, class47_0.class53_0);
				RecoveredRuntime.EmbedByte(131, class47_0.class53_0);
				RecoveredRuntime.EmbedByte(4, class47_0.class53_0);
				RecoveredRuntime.EmbedByte(36, class47_0.class53_0);
				RecoveredRuntime.EmbedByte(13, class47_0.class53_0);
				RecoveredRuntime.EmbedByte(203, class47_0.class53_0);
				AsmJitAssembler class53_ = class47_0.class53_0;
				class53_.struct19_0.uint_2 = (class53_.struct19_0.uint_2 | 8u);
				RecoveredRuntime.EmitMoveMemoryToRegister(class47_0.class53_0, AsmJitRuntime.class63_41, RecoveredRuntime.CreateDwordLabelMemory(class47_0.class58_1, 0L));
				RecoveredRuntime.EmitReturnAndPop(class47_0.class53_0, RecoveredRuntime.CreateImmediate((int_0 == -1) ? 4 : int_0));
				RecoveredRuntime.AlignRemoteData(class47_0);
				RecoveredRuntime.BindLabel(class47_0.class53_0, class47_0.class58_1);
				RecoveredRuntime.EmbedUInt32(class47_0.class53_0, 0u);
			}
			else
			{
				RecoveredRuntime.EmitReturn(class47_0.class53_0);
			}
		}
		if (RecoveredRuntime.OperandsNotEqual(class47_0.class58_0, null))
		{
			RecoveredRuntime.AlignRemoteData(class47_0);
			RecoveredRuntime.BindLabel(class47_0.class53_0, class47_0.class58_0);
			class47_0.SetResultOffset(RecoveredRuntime.GetAssemblerOffset(class47_0.class53_0));
			RecoveredRuntime.EmbedBytes(class47_0.class53_0, new byte[class47_0.int_0]);
		}
	}

	internal static void AlignRemoteData(RemoteAssembler class47_0)
	{
		AlignCode(class47_0.class53_0, class47_0.bool_0 ? 4u : 8u);
	}

	internal static void WriteX64LabelArgument(int int_0, AsmJitLabel class58_0, RemoteAssembler class47_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_54,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_61,
			AsmJitRuntime.class63_62
		};
		if (int_0 < 4)
		{
			RecoveredRuntime.EmitLoadEffectiveAddress(class47_0.class53_0, array[int_0], RecoveredRuntime.CreatePointerLabelMemory(class47_0, class58_0, 0L));
			return;
		}
		RecoveredRuntime.EmitLoadEffectiveAddress(class47_0.class53_0, AsmJitRuntime.class63_53, RecoveredRuntime.CreatePointerLabelMemory(class47_0, class58_0, 0L));
		RecoveredRuntime.EmitMoveRegisterToMemory(class47_0.class53_0, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_57, (long)(int_0 * 8)), AsmJitRuntime.class63_53);
	}

	internal static AsmJitMemoryOperand CreateQwordBaseMemory(AsmJitGpRegister class63_0, long long_0)
	{
		return CreateBaseMemoryOperand((IntPtr)long_0, 8u, class63_0);
	}

	internal static bool ExecuteAssemblerThread(AsmJitAssembler class53_0, RemoteCodeExecutorBase class84_0)
	{
		IntPtr intPtr = RecoveredRuntime.AssembleRemoteCode(class53_0, class84_0);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		IntPtr intPtr2 = RecoveredRuntime.StartRemoteThread(class84_0, intPtr, IntPtr.Zero);
		if (!(intPtr2 == IntPtr.Zero))
		{
			RecoveredRuntime.WaitForRemoteThread(class84_0, intPtr2, -1);
			RecoveredRuntime.CloseRemoteHandle(class84_0, intPtr2);
			return true;
		}
		return false;
	}

	internal static void EmitUnconditionalJump(AsmJitAssembler class53_0, AsmJitLabel class58_0)
	{
		EmitInstruction(class58_0, AsmJitInstructionId.const_247, class53_0);
	}

	internal static int GetAssemblerOffset(AsmJitAssembler class53_0)
	{
		return (int)(class53_0.struct19_0.struct17_0.intptr_1.ToInt64() - class53_0.struct19_0.struct17_0.intptr_0.ToInt64() + class53_0.struct19_0.intptr_3.ToInt64());
	}

	internal static void EmitJumpInstruction(AsmJitLabel class58_0, AsmJitJumpHint enum12_0, AsmJitAssembler class53_0, AsmJitInstructionId enum7_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.delegate23_0(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
			return;
		}
		AsmJitApi.delegate22_0(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
	}

	internal static AsmJitMemoryOperand CreateByteLabelMemory(AsmJitLabel class58_0, long long_0)
	{
		return CreateLabelMemoryOperand(1u, (IntPtr)long_0, class58_0);
	}

	internal static void EmitLoadEffectiveAddress(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitMemoryOperand class59_0)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_251, class63_0, class59_0);
	}

	internal static void EmbedInt64(AsmJitAssembler class53_0, long long_0)
	{
		EmbedData(8L, long_0, class53_0);
	}

	internal static bool MemoryOperandsNotEqual(AsmJitMemoryOperand class59_0, AsmJitMemoryOperand class59_1)
	{
		return !MemoryOperandsEqual(class59_0, class59_1);
	}

	internal static void SetBaseOperandData(AsmJitOperand class56_0, AsmJitOperand.Struct8 struct8_0)
	{
		class56_0.SetRawData(AsmJitOperand.Reinterpret<AsmJitOperand.Struct8, AsmJitOperand.Struct7>(struct8_0));
	}

	internal static void SetRegisterOperandData(AsmJitOperand class56_0, AsmJitOperand.Struct9 struct9_0)
	{
		class56_0.SetRawData(AsmJitOperand.Reinterpret<AsmJitOperand.Struct9, AsmJitOperand.Struct7>(struct9_0));
	}

	internal static void EmbedPlatformPointer(RemoteAssembler class47_0, IntPtr intptr_0)
	{
		if (class47_0.bool_0)
		{
			RecoveredRuntime.EmbedInt32(class47_0.class53_0, intptr_0.ToInt32());
			return;
		}
		RecoveredRuntime.EmbedPointer(class47_0.class53_0, intptr_0);
	}

	internal static AsmJitMemoryOperand CreateByteLabelMemoryForProcess(AsmJitLabel class58_0, long long_0, RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			AsmJitAssembler class53_ = class47_0.class53_0;
			class53_.struct19_0.uint_2 = (class53_.struct19_0.uint_2 | 8u);
		}
		return RecoveredRuntime.CreateByteLabelMemory(class58_0, long_0);
	}

	internal static byte[] GetAsmJitX86Image()
	{
		return (byte[])GetEmbeddedResourceManager().GetObject("AsmJitx86", EmbeddedResources.cultureInfo_0);
	}

	internal static void EmitPopFlags64(AsmJitAssembler class53_0)
	{
		if (!class53_0.Is32BitMode && !AsmJitRuntime.bool_0)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(11455));
		}
		RecoveredRuntime.EmitInstruction(class53_0, AsmJitInstructionId.const_423);
	}

	internal static void EmitPushImmediate(AsmJitAssembler class53_0, AsmJitImmediate class57_0)
	{
		EmitInstruction(class57_0, AsmJitInstructionId.const_463, class53_0);
	}

	internal static AsmJitImmediate CreateImmediate(UIntPtr uintptr_0)
	{
		return new AsmJitImmediate((IntPtr)(long)(ulong)uintptr_0, bool_0: true);
	}

	internal static void EmitMoveImmediateToRegister(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitImmediate class57_0)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_266, class63_0, class57_0);
	}

	internal static void EmbedData(long long_0, object object_0, AsmJitAssembler class53_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.delegate18_0(ref class53_0.struct19_0, object_0, (IntPtr)long_0);
			return;
		}
		AsmJitApi.delegate17_0(ref class53_0.struct19_0, object_0, (IntPtr)long_0);
	}

	internal static byte[] GetAsmJitX64Image()
	{
		return (byte[])GetEmbeddedResourceManager().GetObject("AsmJitx64", EmbeddedResources.cultureInfo_0);
	}

	internal static void EmitTestRegisters(AsmJitGpRegister class63_0, AsmJitGpRegister class63_1, AsmJitAssembler class53_0)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_565, class63_0, class63_1);
	}

	internal static void InitializeAsmJitRegisters()
	{
		AsmJitRuntime.class63_0 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(19962));
		AsmJitRuntime.class63_1 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(19999));
		AsmJitRuntime.class63_2 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20032));
		AsmJitRuntime.class63_3 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20065));
		AsmJitRuntime.class63_4 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20098));
		if (AsmJitRuntime.bool_0)
		{
			AsmJitRuntime.class63_5 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20131));
			AsmJitRuntime.class63_6 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20164));
			AsmJitRuntime.class63_7 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20197));
			AsmJitRuntime.class63_8 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20230));
			AsmJitRuntime.class63_9 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20263));
			AsmJitRuntime.class63_10 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20296));
			AsmJitRuntime.class63_11 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20329));
			AsmJitRuntime.class63_12 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20366));
			AsmJitRuntime.class63_13 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20403));
			AsmJitRuntime.class63_14 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20440));
			AsmJitRuntime.class63_15 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20477));
			AsmJitRuntime.class63_16 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20514));
		}
		AsmJitRuntime.class63_17 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20551));
		AsmJitRuntime.class63_18 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20584));
		AsmJitRuntime.class63_19 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20617));
		AsmJitRuntime.class63_20 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20650));
		AsmJitRuntime.class63_21 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20683));
		AsmJitRuntime.class63_22 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20716));
		AsmJitRuntime.class63_23 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20749));
		AsmJitRuntime.class63_24 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20782));
		AsmJitRuntime.class63_25 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20815));
		AsmJitRuntime.class63_26 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20848));
		AsmJitRuntime.class63_27 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20881));
		AsmJitRuntime.class63_28 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20914));
		if (AsmJitRuntime.bool_0)
		{
			AsmJitRuntime.class63_29 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20947));
			AsmJitRuntime.class63_30 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20980));
			AsmJitRuntime.class63_31 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21013));
			AsmJitRuntime.class63_32 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21050));
			AsmJitRuntime.class63_33 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21087));
			AsmJitRuntime.class63_34 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21124));
			AsmJitRuntime.class63_35 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21161));
			AsmJitRuntime.class63_36 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21198));
		}
		AsmJitRuntime.class63_37 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21235));
		AsmJitRuntime.class63_38 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21268));
		AsmJitRuntime.class63_39 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21301));
		AsmJitRuntime.class63_40 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21334));
		AsmJitRuntime.class63_41 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21367));
		AsmJitRuntime.class63_42 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21400));
		AsmJitRuntime.class63_43 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21433));
		AsmJitRuntime.class63_44 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21466));
		if (AsmJitRuntime.bool_0)
		{
			AsmJitRuntime.class63_45 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21499));
			AsmJitRuntime.class63_46 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21532));
			AsmJitRuntime.class63_47 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21565));
			AsmJitRuntime.class63_48 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21602));
			AsmJitRuntime.class63_49 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21639));
			AsmJitRuntime.class63_50 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21676));
			AsmJitRuntime.class63_51 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21713));
			AsmJitRuntime.class63_52 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21750));
		}
		if (AsmJitRuntime.bool_0)
		{
			AsmJitRuntime.class63_53 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21787));
			AsmJitRuntime.class63_54 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21820));
			AsmJitRuntime.class63_55 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21853));
			AsmJitRuntime.class63_56 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21886));
			AsmJitRuntime.class63_57 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21919));
			AsmJitRuntime.class63_58 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21952));
			AsmJitRuntime.class63_59 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21985));
			AsmJitRuntime.class63_60 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22018));
			AsmJitRuntime.class63_61 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22051));
			AsmJitRuntime.class63_62 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22084));
			AsmJitRuntime.class63_63 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22117));
			AsmJitRuntime.class63_64 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22150));
			AsmJitRuntime.class63_65 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22183));
			AsmJitRuntime.class63_66 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22216));
			AsmJitRuntime.class63_67 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22249));
			AsmJitRuntime.class63_68 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22282));
		}
		AsmJitRuntime.class63_69 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22315));
		AsmJitRuntime.class63_70 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22348));
		AsmJitRuntime.class63_71 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22381));
		AsmJitRuntime.class63_72 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22414));
		AsmJitRuntime.class63_73 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22447));
		AsmJitRuntime.class63_74 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22480));
		AsmJitRuntime.class63_75 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22513));
		AsmJitRuntime.class63_76 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22546));
		AsmJitRuntime.class64_0 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22579));
		AsmJitRuntime.class64_1 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22612));
		AsmJitRuntime.class64_2 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22645));
		AsmJitRuntime.class64_3 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22678));
		AsmJitRuntime.class64_4 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22711));
		AsmJitRuntime.class64_5 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22744));
		AsmJitRuntime.class64_6 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22777));
		AsmJitRuntime.class64_7 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22810));
		AsmJitRuntime.class65_0 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(22843));
		AsmJitRuntime.class65_1 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(22880));
		AsmJitRuntime.class65_2 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(22917));
		AsmJitRuntime.class65_3 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(22954));
		AsmJitRuntime.class65_4 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(22991));
		AsmJitRuntime.class65_5 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23028));
		AsmJitRuntime.class65_6 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23065));
		AsmJitRuntime.class65_7 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23102));
		if (AsmJitRuntime.bool_0)
		{
			AsmJitRuntime.class65_8 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23139));
			AsmJitRuntime.class65_9 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23176));
			AsmJitRuntime.class65_10 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23213));
			AsmJitRuntime.class65_11 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23250));
			AsmJitRuntime.class65_12 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23287));
			AsmJitRuntime.class65_13 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23324));
			AsmJitRuntime.class65_14 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23361));
			AsmJitRuntime.class65_15 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23398));
		}
	}

	internal static void EmitMoveRegisterToRegister(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitGpRegister class63_1)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_266, class63_0, class63_1);
	}

	internal static bool MemoryOperandsEqual(AsmJitMemoryOperand class59_0, AsmJitMemoryOperand class59_1)
	{
		return (class59_0 == null && class59_1 == null) || (class59_0 != null && class59_0.Equals(class59_1));
	}

	internal static void EmbedBytes(AsmJitAssembler class53_0, byte[] byte_0)
	{
		EmbedData(byte_0.Length, byte_0, class53_0);
	}

	internal static void WriteX64MemoryArgument(AsmJitMemoryOperand class59_0, RemoteAssembler class47_0, int int_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_54,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_61,
			AsmJitRuntime.class63_62
		};
		if (int_0 < 4)
		{
			RecoveredRuntime.EmitMoveMemoryToRegister(class47_0.class53_0, array[int_0], class59_0);
			return;
		}
		RecoveredRuntime.EmitMoveMemoryToRegister(class47_0.class53_0, AsmJitRuntime.class63_53, class59_0);
		RecoveredRuntime.EmitMoveRegisterToMemory(class47_0.class53_0, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_57, (long)(int_0 * 8)), AsmJitRuntime.class63_53);
	}

	internal static bool OperandsEqual(AsmJitOperand class56_0, AsmJitOperand class56_1)
	{
		return (class56_0 == null && class56_1 == null) || (class56_0 != null && class56_0.Equals(class56_1));
	}

	internal static AsmJitMemoryOperand CreateQwordLabelMemory(AsmJitLabel class58_0, long long_0)
	{
		return CreateLabelMemoryOperand(8u, (IntPtr)long_0, class58_0);
	}

	internal static void EmitComparisonFailureJump(AsmJitJumpHint enum12_0, AsmJitAssembler class53_0, AsmJitLabel class58_0)
	{
		EmitJumpInstruction(class58_0, enum12_0, class53_0, AsmJitInstructionId.const_232);
	}

	internal static void EmbedNullPointer(RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			RecoveredRuntime.EmbedUInt32(class47_0.class53_0, 0u);
			return;
		}
		RecoveredRuntime.EmbedInt64(class47_0.class53_0, 0L);
	}

	internal static uint GetRegisterId(AsmJitRegister class62_0)
	{
		return GetRegisterOperandData(class62_0).uint_1;
	}

	internal static AsmJitImmediate CreateImmediate(short short_0)
	{
		return new AsmJitImmediate((IntPtr)short_0);
	}

	internal static void EmitReturn(AsmJitAssembler class53_0)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_502);
	}

	internal static void EmitInstruction(AsmJitOperand class56_0, AsmJitInstructionId enum7_0, AsmJitAssembler class53_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.delegate8_0(ref class53_0.struct19_0, enum7_0, class56_0);
			return;
		}
		AsmJitApi.delegate4_0(ref class53_0.struct19_0, enum7_0, class56_0);
	}

	internal static void EmitX86FunctionCall(AsmJitOperand class56_0, object[] object_0, CallingConvention callingConvention_0, RemoteAssembler class47_0)
	{
		bool[] array = new bool[object_0.Length];
		if (callingConvention_0 == CallingConvention.ThisCall || callingConvention_0 == CallingConvention.FastCall)
		{
			int num = (callingConvention_0 == CallingConvention.FastCall) ? 2 : 1;
			int num2 = 0;
			int num3 = 0;
			while (num2 < object_0.Length && num3 < num)
			{
				array[num2] = true;
				RecoveredRuntime.WriteX86Argument(object_0[num2], class47_0, (RemoteAssembler.Enum6)num3);
				num3++;
				num2++;
			}
		}
		for (int i = object_0.Length - 1; i >= 0; i--)
		{
			if (!array[i])
			{
				RecoveredRuntime.WriteX86Argument(object_0[i], class47_0, RemoteAssembler.Enum6.const_2);
			}
		}
		AsmJitImmediate @class = class56_0 as AsmJitImmediate;
		if (RecoveredRuntime.OperandsNotEqual(@class, null))
		{
			RecoveredRuntime.EmitMoveImmediateToRegister(class47_0.class53_0, AsmJitRuntime.class63_37, @class);
			AsmJitAssembler class53_ = class47_0.class53_0;
			AsmJitGpRegister class63_ = AsmJitRuntime.class63_69;
			RecoveredRuntime.EmitCallRegister(class63_, class53_);
		}
		AsmJitGpRegister class2 = class56_0 as AsmJitGpRegister;
		if (RecoveredRuntime.RegistersNotEqual(null, class2))
		{
			RecoveredRuntime.EmitCallRegister(class2, class47_0.class53_0);
		}
		if (RecoveredRuntime.OperandsEqual(@class, null) && RecoveredRuntime.RegistersEqual(null, class2))
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(24964));
		}
		if (callingConvention_0 == CallingConvention.Cdecl)
		{
			int num4 = 0;
			foreach (object obj in object_0)
			{
				if (!(obj is IntPtr) && !(obj is UIntPtr) && !(obj is RemoteAssembler.Class48))
				{
					num4 += obj.GetType().SizeOf();
				}
				else
				{
					num4 += 4;
				}
			}
			RecoveredRuntime.EmitAddRegisterImmediate(class47_0.class53_0, AsmJitRuntime.class63_41, RecoveredRuntime.CreateImmediate(num4));
			return;
		}
	}

	internal static void EmitReturnAndPop(AsmJitAssembler class53_0, AsmJitImmediate class57_0)
	{
		EmitInstruction(class57_0, AsmJitInstructionId.const_502, class53_0);
	}

	internal static void EmitAddRegisterImmediate(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitImmediate class57_0)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_1, class63_0, class57_0);
	}

	internal static AsmJitMemoryOperand CreateWordLabelMemory(AsmJitLabel class58_0, long long_0)
	{
		return CreateLabelMemoryOperand(2u, (IntPtr)long_0, class58_0);
	}

	internal static void EmitX64FunctionCall(RemoteAssembler class47_0, AsmJitOperand class56_0, object[] object_0)
	{
		int num = (object_0.Length <= 4) ? 40 : (object_0.Length * 8);
		AsmJitImmediate @class = class56_0 as AsmJitImmediate;
		num -= num % 16;
		AsmJitAssembler class53_ = class47_0.class53_0;
		AsmJitGpRegister class63_ = AsmJitRuntime.class63_57;
		AsmJitImmediate class57_ = RecoveredRuntime.CreateImmediate(num + 8);
		RecoveredRuntime.EmitSubtractRegisterImmediate(class63_, class57_, class53_);
		if (!class47_0.GetRandomizeArgumentSetup())
		{
			for (int i = 0; i < object_0.Length; i++)
			{
				RecoveredRuntime.WriteX64Argument(class47_0, object_0[i], i);
			}
		}
		else
		{
			int[] array = Enumerable.Range(0, object_0.Length).ToArray<int>();
			array.Shuffle<int>();
			foreach (int num2 in array)
			{
				RecoveredRuntime.WriteX64Argument(class47_0, object_0[num2], num2);
			}
		}
		if (RecoveredRuntime.OperandsNotEqual(@class, null))
		{
			RecoveredRuntime.EmitMoveImmediateToRegister(class47_0.class53_0, AsmJitRuntime.class63_53, @class);
			AsmJitAssembler class53_2 = class47_0.class53_0;
			AsmJitGpRegister class63_2 = AsmJitRuntime.class63_53;
			RecoveredRuntime.EmitCallRegister(class63_2, class53_2);
		}
		AsmJitGpRegister class2 = class56_0 as AsmJitGpRegister;
		if (RecoveredRuntime.RegistersNotEqual(null, class2))
		{
			RecoveredRuntime.EmitCallRegister(class2, class47_0.class53_0);
		}
		if (RecoveredRuntime.OperandsEqual(@class, null) && RecoveredRuntime.RegistersEqual(null, class2))
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(24964));
		}
		RecoveredRuntime.EmitAddRegisterImmediate(class47_0.class53_0, AsmJitRuntime.class63_57, RecoveredRuntime.CreateImmediate(num + 8));
	}

	internal static void EmitPushMemory(AsmJitAssembler class53_0, AsmJitMemoryOperand class59_0)
	{
		EmitInstruction(class59_0, AsmJitInstructionId.const_463, class53_0);
	}

	internal static void EmitCallRegister(AsmJitGpRegister class63_0, AsmJitAssembler class53_0)
	{
		EmitInstruction(class63_0, AsmJitInstructionId.const_26, class53_0);
	}

	internal static AsmJitImmediate CreateImmediate(uint uint_0)
	{
		return new AsmJitImmediate((IntPtr)(int)uint_0, bool_0: true);
	}

	internal static void SetLabelOperandData(AsmJitOperand.Struct13 struct13_0, AsmJitOperand class56_0)
	{
		class56_0.SetRawData(AsmJitOperand.Reinterpret<AsmJitOperand.Struct13, AsmJitOperand.Struct7>(struct13_0));
	}

	internal static AsmJitImmediate CreateImmediate(ushort ushort_0)
	{
		return new AsmJitImmediate((IntPtr)ushort_0);
	}

	internal static AsmJitOperand.Struct11 GetMemoryOperandData(AsmJitOperand class56_0)
	{
		return AsmJitOperand.Reinterpret<AsmJitOperand.Struct7, AsmJitOperand.Struct11>(class56_0.GetRawData());
	}

	internal static void WriteX64Argument(RemoteAssembler class47_0, object object_0, int int_0)
	{
		RemoteAssembler.Class48 @class = object_0 as RemoteAssembler.Class48;
		if (@class != null)
		{
			RecoveredRuntime.WriteX64LabelArgument(int_0, @class.GetLabel(), class47_0);
			return;
		}
		AsmJitImmediate class2 = object_0.ToImmediate();
		if (RecoveredRuntime.OperandsNotEqual(class2, null))
		{
			RecoveredRuntime.WriteX64ImmediateArgument(class47_0, class2, int_0, object_0 is float || object_0 is double);
			return;
		}
		AsmJitGpRegister class3 = object_0 as AsmJitGpRegister;
		if (RecoveredRuntime.RegistersNotEqual(null, class3))
		{
			RecoveredRuntime.WriteX64RegisterArgument(int_0, class47_0, class3);
			return;
		}
		AsmJitMemoryOperand class59_ = object_0 as AsmJitMemoryOperand;
		if (RecoveredRuntime.MemoryOperandsNotEqual(class59_, null))
		{
			RecoveredRuntime.WriteX64MemoryArgument(class59_, class47_0, int_0);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(13555));
	}

	internal static bool RegistersNotEqual(AsmJitRegister class62_0, AsmJitRegister class62_1)
	{
		return !RegistersEqual(class62_0, class62_1);
	}

	internal static AsmJitMemoryOperand CreateDwordBaseMemory(long long_0, AsmJitGpRegister class63_0)
	{
		return CreateBaseMemoryOperand((IntPtr)long_0, 4u, class63_0);
	}

	internal static IntPtr GetAssemblerCodePointer(AsmJitAssembler class53_0)
	{
		if (!AsmJitRuntime.bool_0)
		{
			return AsmJitApi.delegate11_0(ref class53_0.struct19_0);
		}
		return AsmJitApi.delegate12_0(ref class53_0.struct19_0);
	}

	internal static AsmJitOperand.Struct14 GetVariableOperandData(AsmJitOperand class56_0)
	{
		return AsmJitOperand.Reinterpret<AsmJitOperand.Struct7, AsmJitOperand.Struct14>(class56_0.GetRawData());
	}

	internal static bool InstallVectoredExceptionHandler(bool bool_0, ulong ulong_0, VectoredExceptionHandlerInstaller class92_0, IntPtr intptr_0)
	{
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(class92_0.GetRemoteProcess())[EncodedStringTable.DecodeString(8549)];
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(12731));
		}
		AsmJitAssembler @class = new AsmJitAssembler();
		IntPtr value;
		if (!class92_0.GetRemoteProcess().Is64Bit)
		{
			IntPtr intPtr = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(27396), false);
			for (int i = 0; i < class92_0.byte_0.Length - 4; i++)
			{
				uint num = BitConverter.ToUInt32(class92_0.byte_0, i);
				if (num != 3735935610u)
				{
					if (num == 3735929054u)
					{
						BitConverter.GetBytes(intPtr.ToInt32()).CopyTo(class92_0.byte_0, i);
						break;
					}
					if (num == 3735929042u)
					{
						value = RecoveredRuntime.GetNativeLoaderHooks(class92_0.GetRemoteProcess()).GetRemoveInvertedFunctionTableAddress();
						BitConverter.GetBytes(value.ToInt32()).CopyTo(class92_0.byte_0, i);
					}
				}
				else
				{
					value = RecoveredRuntime.GetNativeLoaderHooks(class92_0.GetRemoteProcess()).GetInvertedFunctionTableAddress();
					BitConverter.GetBytes(value.ToInt32()).CopyTo(class92_0.byte_0, i);
				}
			}
			class92_0.intptr_2 = RecoveredRuntime.AllocateRemoteMemory(class92_0, (long)class92_0.byte_0.Length, NativeTypes.Enum34.flag_2);
			if (class92_0.intptr_2 == IntPtr.Zero)
			{
				throw new AccessViolationException(EncodedStringTable.DecodeString(27429));
			}
			if (!class92_0.WriteArray<byte>(class92_0.intptr_2, class92_0.byte_0))
			{
				throw new AccessViolationException(EncodedStringTable.DecodeString(27482));
			}
		}
		else
		{
			if (class92_0.intptr_1 == IntPtr.Zero)
			{
				class92_0.intptr_1 = RecoveredRuntime.AllocateRemoteMemory(class92_0, 4096L, NativeTypes.Enum34.flag_6);
				if (class92_0.intptr_1 == IntPtr.Zero)
				{
					throw new AccessViolationException(EncodedStringTable.DecodeString(27339));
				}
			}
			VectoredExceptionHandlerInstaller.Struct71 @struct = class92_0.Read<VectoredExceptionHandlerInstaller.Struct71>(class92_0.intptr_1);
			long num2 = @struct.intptr_0.ToInt64();
			AsmJitLabel class58_;
			AsmJitLabel class58_2;
			AsmJitLabel class58_3;
			AsmJitLabel class58_4;
			AsmJitGpRegister class63_;
			AsmJitGpRegister class63_2;
			AsmJitGpRegister class63_3;
			checked
			{
				@struct.struct70_0[(int)((IntPtr)num2)].intptr_0 = intptr_0;
				@struct.struct70_0[(int)((IntPtr)num2)].intptr_1 = (IntPtr)((long)ulong_0);
				@struct.intptr_0 = @struct.intptr_0.Add(1);
				class92_0.Write<VectoredExceptionHandlerInstaller.Struct71>(class92_0.intptr_1, @struct);
				class58_ = RecoveredRuntime.CreateLabel(@class);
				class58_2 = RecoveredRuntime.CreateLabel(@class);
				class58_3 = RecoveredRuntime.CreateLabel(@class);
				class58_4 = RecoveredRuntime.CreateLabel(@class);
				RecoveredRuntime.EmitMoveMemoryToRegister(@class, AsmJitRuntime.class63_53, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_54, 0L));
				AsmJitMemoryOperand class59_ = RecoveredRuntime.CreateDwordBaseMemory(0L, AsmJitRuntime.class63_53);
				AsmJitImmediate class57_ = RecoveredRuntime.CreateImmediate(3765269347u);
				RecoveredRuntime.EmitCompareMemoryImmediate(class57_, class59_, @class);
				RecoveredRuntime.EmitComparisonFailureJump(AsmJitJumpHint.const_0, @class, class58_);
				class59_ = RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_53, 32L);
				class57_ = RecoveredRuntime.CreateImmediate(26820608u);
				RecoveredRuntime.EmitCompareMemoryImmediate(class57_, class59_, @class);
				RecoveredRuntime.EmitComparisonFailureJump(AsmJitJumpHint.const_0, @class, class58_);
				class59_ = RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_53, 56L);
				class57_ = RecoveredRuntime.CreateImmediate(0);
				RecoveredRuntime.EmitCompareMemoryImmediate(class57_, class59_, @class);
				RecoveredRuntime.EmitComparisonFailureJump(AsmJitJumpHint.const_0, @class, class58_);
				RecoveredRuntime.EmitMoveImmediateToRegister(@class, AsmJitRuntime.class63_62, new AsmJitImmediate(class92_0.intptr_1));
				RecoveredRuntime.EmitMoveMemoryToRegister(@class, AsmJitRuntime.class63_55, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_62, 0L));
				RecoveredRuntime.EmitAddRegisterImmediate(@class, AsmJitRuntime.class63_62, RecoveredRuntime.CreateImmediate(IntPtr.Size));
				RecoveredRuntime.EmitXorRegisters(@class, AsmJitRuntime.class63_63, AsmJitRuntime.class63_63);
				RecoveredRuntime.BindLabel(@class, class58_2);
				RecoveredRuntime.EmitMoveMemoryToRegister(@class, AsmJitRuntime.class63_61, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_53, 48L));
				RecoveredRuntime.EmitMoveMemoryToRegister(@class, AsmJitRuntime.class63_64, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_62, 0L));
				class63_ = AsmJitRuntime.class63_61;
				class63_2 = AsmJitRuntime.class63_64;
				RecoveredRuntime.EmitCompareRegisters(class63_, @class, class63_2);
				RecoveredRuntime.EmitLowerBoundJump(AsmJitJumpHint.const_0, class58_3, @class);
				class63_3 = AsmJitRuntime.class63_64;
			}
			AsmJitMemoryOperand class59_2 = RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_62, (long)IntPtr.Size);
			RecoveredRuntime.EmitAddMemoryToRegister(class59_2, class63_3, @class);
			class63_ = AsmJitRuntime.class63_61;
			class63_2 = AsmJitRuntime.class63_64;
			RecoveredRuntime.EmitCompareRegisters(class63_, @class, class63_2);
			RecoveredRuntime.EmitUpperBoundJump(AsmJitJumpHint.const_0, class58_3, @class);
			RecoveredRuntime.EmitUnconditionalJump(@class, class58_4);
			RecoveredRuntime.BindLabel(@class, class58_3);
			RecoveredRuntime.EmitAddRegisterImmediate(@class, AsmJitRuntime.class63_62, RecoveredRuntime.CreateImmediate(typeof(VectoredExceptionHandlerInstaller.Struct70).SizeOf()));
			RecoveredRuntime.EmitAddRegisterImmediate(@class, AsmJitRuntime.class63_63, RecoveredRuntime.CreateImmediate(1));
			class63_ = AsmJitRuntime.class63_63;
			class63_2 = AsmJitRuntime.class63_55;
			RecoveredRuntime.EmitCompareRegisters(class63_, @class, class63_2);
			RecoveredRuntime.EmitComparisonFailureJump(AsmJitJumpHint.const_0, @class, class58_2);
			RecoveredRuntime.EmitUnconditionalJump(@class, class58_);
			RecoveredRuntime.BindLabel(@class, class58_4);
			AsmJitMemoryOperand class59_3 = RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_53, 32L);
			AsmJitImmediate class57_2 = RecoveredRuntime.CreateImmediate(429065504u);
			RecoveredRuntime.EmitMoveImmediateToMemory(class57_2, class59_3, @class);
			RecoveredRuntime.EmitMoveMemoryToRegister(@class, AsmJitRuntime.class63_54, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_54, 0L));
			RecoveredRuntime.EmitMoveMemoryToRegister(@class, AsmJitRuntime.class63_55, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_62, 0L));
			RecoveredRuntime.EmitMoveRegisterToMemory(@class, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.class63_53, 56L), AsmJitRuntime.class63_55);
			RecoveredRuntime.BindLabel(@class, class58_);
			RecoveredRuntime.EmitXorRegisters(@class, AsmJitRuntime.class63_53, AsmJitRuntime.class63_53);
			RecoveredRuntime.EmitReturn(@class);
			RecoveredRuntime.EmbedByte(204, @class);
			RecoveredRuntime.EmbedByte(204, @class);
			RecoveredRuntime.EmbedByte(204, @class);
			class92_0.intptr_2 = RecoveredRuntime.AssembleRemoteCode(@class, class92_0);
			RecoveredRuntime.DisposeAssemblerState(@class);
		}
		RemoteAssembler class2 = new RemoteAssembler(@class, class92_0.GetRemoteProcess());
		RecoveredRuntime.EmitRemoteCallPrologue(class2);
		RecoveredRuntime.EmitRemoteCall(class2, new AsmJitImmediate(RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(27531), false)), CallingConvention.StdCall, new object[]
		{
			0,
			class92_0.intptr_2
		});
		class2.CaptureReturnValue<IntPtr>();
		RecoveredRuntime.EmitRemoteCallEpilogue(class2, -1);
		value = (class92_0.intptr_3 = class92_0.Execute<IntPtr>(class2));
		return value != IntPtr.Zero;
	}

	internal static AsmJitMemoryOperand CreatePointerBaseMemory(AsmJitGpRegister class63_0, long long_0, RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			class47_0.class53_0.struct19_0.uint_2 |= 8u;
			return CreateDwordBaseMemory(long_0, class63_0);
		}
		return CreateQwordBaseMemory(class63_0, long_0);
	}

	internal static void EmbedByte(byte byte_0, AsmJitAssembler class53_0)
	{
		EmbedData(1L, byte_0, class53_0);
	}

	internal static AsmJitImmediate CreateImmediate(float float_0)
	{
		return new AsmJitImmediate((IntPtr)BitConverter.ToInt32(BitConverter.GetBytes(float_0), 0));
	}
}
