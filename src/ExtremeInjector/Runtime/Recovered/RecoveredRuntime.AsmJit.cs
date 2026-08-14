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

	internal static void EmitRemoteCallPrologue(RemoteAssembler remoteAssembler)
	{
		if (remoteAssembler.flag)
		{
			RecoveredRuntime.EmitPushRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister43);
			RecoveredRuntime.EmitMoveRegisterToRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister43, AsmJitRuntime.gpRegister42);
			return;
		}
		if (remoteAssembler.flag2)
		{
			remoteAssembler.label2 = RecoveredRuntime.CreateLabel(remoteAssembler.assembler);
			AsmJitAssembler class53_ = remoteAssembler.assembler;
			class53_.assemblerState.uintValue3 = (class53_.assemblerState.uintValue3 | 8u);
			RecoveredRuntime.EmitMoveRegisterToMemory(remoteAssembler.assembler, RecoveredRuntime.CreateDwordLabelMemory(remoteAssembler.label2, 0L), AsmJitRuntime.gpRegister42);
			AsmJitAssembler assembler = remoteAssembler.assembler;
			AsmJitGpRegister class63_ = AsmJitRuntime.gpRegister42;
			AsmJitImmediate class57_ = RecoveredRuntime.CreateImmediate(4294967280u);
			RecoveredRuntime.EmitAndRegisterImmediate(class63_, class57_, assembler);
			RecoveredRuntime.EmbedByte(106, remoteAssembler.assembler);
			RecoveredRuntime.EmbedByte(51, remoteAssembler.assembler);
			RecoveredRuntime.EmbedByte(232, remoteAssembler.assembler);
			RecoveredRuntime.EmbedUInt32(remoteAssembler.assembler, 0u);
			RecoveredRuntime.EmbedByte(131, remoteAssembler.assembler);
			RecoveredRuntime.EmbedByte(4, remoteAssembler.assembler);
			RecoveredRuntime.EmbedByte(36, remoteAssembler.assembler);
			RecoveredRuntime.EmbedByte(5, remoteAssembler.assembler);
			RecoveredRuntime.EmbedByte(203, remoteAssembler.assembler);
		}
		RecoveredRuntime.EmitMoveRegisterToMemory(remoteAssembler.assembler, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister58, 8L), AsmJitRuntime.gpRegister55);
		RecoveredRuntime.EmitMoveRegisterToMemory(remoteAssembler.assembler, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister58, 16L), AsmJitRuntime.gpRegister56);
		RecoveredRuntime.EmitMoveRegisterToMemory(remoteAssembler.assembler, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister58, 24L), AsmJitRuntime.gpRegister62);
		RecoveredRuntime.EmitMoveRegisterToMemory(remoteAssembler.assembler, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister58, 32L), AsmJitRuntime.gpRegister63);
	}

	internal static AsmJitOperand.RegisterOperandData GetLabelOperandData(AsmJitOperand operand)
	{
		return AsmJitOperand.Reinterpret<AsmJitOperand.RawOperandData, AsmJitOperand.RegisterOperandData>(operand.GetRawData());
	}

	internal static void EmitPushFlags(AsmJitAssembler assembler)
	{
		if (!assembler.Is32BitMode && !AsmJitRuntime.flag)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(11455));
		}
		RecoveredRuntime.EmitInstruction(assembler, AsmJitInstructionId.PushFlags);
	}

	internal static void EmitAndRegisterImmediate(AsmJitGpRegister gpRegister, AsmJitImmediate immediate, AsmJitAssembler assembler)
	{
		EmitInstruction(assembler, AsmJitInstructionId.And, gpRegister, immediate);
	}

	internal static bool CreateRemoteActivationContext(ManualMapInjector manualMapInjector, ManualMapInjector.MappingContext mappingContext)
	{
		byte[] array = ManualMapInjector.ExtractManifestResource(mappingContext.GetImage());
		if (array == null)
		{
			return true;
		}
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(manualMapInjector.GetRemoteProcess())[EncodedStringTable.DecodeString(8503)];
		if (gclass == null)
		{
			return true;
		}
		IntPtr intPtr = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(12056), false);
		if (intPtr == IntPtr.Zero)
		{
			return RecoveredRuntime.FailManualMap(manualMapInjector, new MissingMethodException(EncodedStringTable.DecodeString(12077)));
		}
		string tempFileName = Path.GetTempFileName();
		try
		{
			File.WriteAllBytes(tempFileName, array);
			IntPtr remoteBuffer = RecoveredRuntime.AllocateRemoteMemory(manualMapInjector, 4096L, NativeTypes.MemoryProtection.ExecuteReadWrite);
			if (remoteBuffer == IntPtr.Zero)
			{
				return RecoveredRuntime.FailManualMap(manualMapInjector, new AccessViolationException(EncodedStringTable.DecodeString(12146)));
			}

			using (AsmJitAssembler assembler = new AsmJitAssembler())
			{
				RemoteAssembler remoteAssembler = new RemoteAssembler(assembler, manualMapInjector.GetRemoteProcess());
				AsmJitLabel activationContextData = RecoveredRuntime.CreateLabel(assembler);
				RecoveredRuntime.EmitRemoteCallPrologue(remoteAssembler);
				RecoveredRuntime.EmitRemoteCall(remoteAssembler, new AsmJitImmediate(intPtr), CallingConvention.StdCall, new object[]
				{
					RecoveredRuntime.CreateLabelReference(remoteAssembler, activationContextData)
				});
				remoteAssembler.CaptureReturnValue<IntPtr>();
				RecoveredRuntime.EmitRemoteCallEpilogue(remoteAssembler, -1);
				RecoveredRuntime.AlignRemoteData(remoteAssembler);

				if (!RecoveredRuntime.Is32BitProcess(manualMapInjector.GetRemoteProcess()))
				{
					NativeTypes.ActivationContext64 activationContext = default(NativeTypes.ActivationContext64);
					activationContext.intValue = typeof(NativeTypes.ActivationContext64).SizeOf();
					activationContext.address = remoteBuffer.Add(RecoveredRuntime.GetAssemblerOffset(assembler));
					RecoveredRuntime.EmbedBytes(assembler, Encoding.Unicode.GetBytes(tempFileName + EncodedStringTable.DecodeString(12219)));
					RecoveredRuntime.AlignRemoteData(remoteAssembler);
					RecoveredRuntime.BindLabel(assembler, activationContextData);
					assembler.EmbedData(activationContext);
				}
				else
				{
					NativeTypes.ActivationContext32 activationContext = default(NativeTypes.ActivationContext32);
					activationContext.intValue = typeof(NativeTypes.ActivationContext32).SizeOf();
					activationContext.uintValue2 = (uint)(remoteBuffer.ToInt32() + RecoveredRuntime.GetAssemblerOffset(assembler));
					RecoveredRuntime.EmbedBytes(assembler, Encoding.Unicode.GetBytes(tempFileName + EncodedStringTable.DecodeString(12219)));
					RecoveredRuntime.AlignRemoteData(remoteAssembler);
					RecoveredRuntime.BindLabel(assembler, activationContextData);
					assembler.EmbedData(activationContext);
				}

				mappingContext.SetRemoteActivationContext(manualMapInjector.Execute<IntPtr>(remoteAssembler, remoteBuffer, true));
				return true;
			}
		}
		finally
		{
			File.Delete(tempFileName);
		}
	}

	internal static void EmitInstruction(AsmJitAssembler assembler, AsmJitInstructionId instructionId)
	{
		if (AsmJitRuntime.flag)
		{
			AsmJitApi.emitInstructionCdecl(ref assembler.assemblerState, instructionId);
		}
		else
		{
			AsmJitApi.emitInstructionThisCall(ref assembler.assemblerState, instructionId);
		}
	}

	internal static void EmitLowerBoundJump(AsmJitJumpHint jumpHint, AsmJitLabel label, AsmJitAssembler assembler)
	{
		EmitJumpInstruction(label, jumpHint, assembler, AsmJitInstructionId.JumpLess);
	}

	internal static void BindLabel(AsmJitAssembler assembler, AsmJitLabel label)
	{
		if (AsmJitRuntime.flag)
		{
			AsmJitApi.bindLabelCdecl(ref assembler.assemblerState, label);
			return;
		}
		AsmJitApi.bindLabelThisCall(ref assembler.assemblerState, label);
	}

	internal static bool InvokeExport(ModuleEntry module, IntPtr address, RemoteProcess process)
	{
        if (HasProcessExited(process))
        {
            throw new InvalidOperationException(UiText.Get("Message.TargetNoLongerActive"));
        }

        ExportedSymbol export;
        using (FileStream stream = new FileStream(module.Path, FileMode.Open, FileAccess.Read, FileShare.Read))
        using (PeImage image = PeExportReader.ReadExports(stream, module.Path, ownsStream: false, layout: PeImageLayout.File))
        {
            if (image.GetExports() == null)
            {
                throw new MissingFieldException(UiText.Get("Message.ExportDirectoryMissing"));
            }

            export = image.GetExports().items2.FirstOrDefault(candidate => candidate.GetName() == module.ExportName);
            if (export == null)
            {
                throw new MissingMethodException(UiText.Format("Message.ExportNotFound", module.ExportName));
            }
        }

        IntPtr exportAddress = address.Add(export.GetAddressRva());
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

	internal static void WriteX86RegisterArgument(AsmJitGpRegister gpRegister, RemoteAssembler remoteAssembler, RemoteAssembler.X86ArgumentSlot x86ArgumentSlot)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.gpRegister39,
			AsmJitRuntime.gpRegister40
		};
		if (x86ArgumentSlot < RemoteAssembler.X86ArgumentSlot.FirstStackArgument)
		{
			RecoveredRuntime.EmitMoveRegisterToRegister(remoteAssembler.assembler, array[(int)x86ArgumentSlot], gpRegister);
			return;
		}
		RecoveredRuntime.EmitPushRegister(remoteAssembler.assembler, gpRegister);
	}

	internal static AsmJitLabel CreateLabel(AsmJitAssembler assembler)
	{
		AsmJitLabel @class = new AsmJitLabel();
		if (AsmJitRuntime.flag)
		{
			AsmJitApi.createLabelCdecl(ref assembler.assemblerState, @class);
		}
		else
		{
			AsmJitApi.createLabelThisCall(ref assembler.assemblerState, @class);
		}
		return @class;
	}

	internal static bool OperandsNotEqual(AsmJitOperand operand, AsmJitOperand operand2)
	{
		return !OperandsEqual(operand, operand2);
	}

	internal static AsmJitMemoryManager CreateAsmJitMemoryManager()
	{
		return new NativeAsmJitMemoryManager(AsmJitMemoryManager.getGlobalMemoryManager());
	}

	internal static void EmbedUInt16(AsmJitAssembler assembler, ushort ushortValue)
	{
		EmbedData(2L, ushortValue, assembler);
	}

	internal static void EmitPopFlags(AsmJitAssembler assembler)
	{
		if (!assembler.Is32BitMode && AsmJitRuntime.flag)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(12411));
		}
		RecoveredRuntime.EmitInstruction(assembler, AsmJitInstructionId.PopFlags);
	}

	internal static void EmitRemoteCall(RemoteAssembler remoteAssembler, AsmJitImmediate immediate, CallingConvention callingConvention, object[] instanceArray)
	{
		DispatchRemoteCallByArchitecture(instanceArray, callingConvention, immediate, remoteAssembler);
	}

	internal static void EmitPopAllRegisters(AsmJitAssembler assembler)
	{
		if (assembler.Is32BitMode || !AsmJitRuntime.flag)
		{
			RecoveredRuntime.EmitInstruction(assembler, AsmJitInstructionId.PopAll);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(12411));
	}

	internal static void SetVariableOperandData(AsmJitOperand.VariableOperandData variableOperandData, AsmJitOperand operand)
	{
		operand.SetRawData(AsmJitOperand.Reinterpret<AsmJitOperand.VariableOperandData, AsmJitOperand.RawOperandData>(variableOperandData));
	}

	internal static AsmJitImmediate CreateImmediate(sbyte signedByteValue)
	{
		return new AsmJitImmediate((IntPtr)signedByteValue);
	}

	internal static IntPtr AssembleRemoteCode(AsmJitAssembler assembler, RemoteCodeExecutorBase remoteCodeExecutorBase)
	{
		return AssembleRemoteCode(IntPtr.Zero, assembler, remoteCodeExecutorBase);
	}

	internal static void EmitMoveRegisterToXmm(AsmJitAssembler assembler, AsmJitXmmRegister xmmRegister, AsmJitGpRegister gpRegister)
	{
		if (assembler.Is32BitMode || AsmJitRuntime.flag)
		{
			RecoveredRuntime.EmitInstruction(assembler, AsmJitInstructionId.MoveDoubleword, xmmRegister, gpRegister);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(11455));
	}

	internal static AsmJitImmediate CreateImmediate(byte byteValue)
	{
		return new AsmJitImmediate((IntPtr)byteValue, flag: true);
	}

	internal static void EmitMoveRegisterToMemory(AsmJitAssembler assembler, AsmJitMemoryOperand memoryOperand, AsmJitGpRegister gpRegister)
	{
		EmitInstruction(assembler, AsmJitInstructionId.Move, memoryOperand, gpRegister);
	}

	internal static AsmJitMemoryOperand CreateDwordLabelMemoryForProcess(long longValue, RemoteAssembler remoteAssembler, AsmJitLabel label)
	{
		if (remoteAssembler.flag)
		{
			AsmJitAssembler class53_ = remoteAssembler.assembler;
			class53_.assemblerState.uintValue3 = (class53_.assemblerState.uintValue3 | 8u);
		}
		return RecoveredRuntime.CreateDwordLabelMemory(label, longValue);
	}

	internal static void EmitPushRegister(AsmJitAssembler assembler, AsmJitGpRegister gpRegister)
	{
		EmitInstruction(gpRegister, AsmJitInstructionId.Push, assembler);
	}

	internal static void DispatchRemoteCallByArchitecture(object[] instanceArray, CallingConvention callingConvention, AsmJitOperand operand, RemoteAssembler remoteAssembler)
	{
		if (remoteAssembler.flag)
		{
			RecoveredRuntime.EmitX86FunctionCall(operand, instanceArray, callingConvention, remoteAssembler);
			return;
		}
		RecoveredRuntime.EmitX64FunctionCall(remoteAssembler, operand, instanceArray);
	}

	internal static object CreateLabelReference(RemoteAssembler remoteAssembler, AsmJitLabel label)
	{
		return new RemoteAssembler.LabelReference(label);
	}

	internal static void EmitZeroResultJump(AsmJitLabel label, AsmJitJumpHint jumpHint, AsmJitAssembler assembler)
	{
		EmitJumpInstructionWithHint(AsmJitInstructionId.JumpZero, label, assembler, jumpHint);
	}

	internal static void EmitPushAllRegisters(AsmJitAssembler assembler)
	{
		if (!assembler.Is32BitMode && AsmJitRuntime.flag)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(12411));
		}
		RecoveredRuntime.EmitInstruction(assembler, AsmJitInstructionId.PushAllDoubleword);
	}

	internal static void EmbedUInt64(AsmJitAssembler assembler, ulong ulongValue)
	{
		EmbedData(8L, ulongValue, assembler);
	}

	internal static void EmbedUInt16(ushort ushortValue, AsmJitAssembler assembler)
	{
		EmbedData(2L, ushortValue, assembler);
	}

	internal static void EmitCompareMemoryImmediate(AsmJitImmediate immediate, AsmJitMemoryOperand memoryOperand, AsmJitAssembler assembler)
	{
		EmitInstruction(assembler, AsmJitInstructionId.Compare, memoryOperand, immediate);
	}

	internal static void WriteX86ImmediateArgument(RemoteAssembler.X86ArgumentSlot x86ArgumentSlot, AsmJitImmediate immediate, RemoteAssembler remoteAssembler)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.gpRegister39,
			AsmJitRuntime.gpRegister40
		};
		if (x86ArgumentSlot >= RemoteAssembler.X86ArgumentSlot.FirstStackArgument)
		{
			RecoveredRuntime.EmitPushImmediate(remoteAssembler.assembler, immediate);
			return;
		}
		if (!(RecoveredRuntime.GetImmediateOperandData(immediate).address == IntPtr.Zero))
		{
			RecoveredRuntime.EmitMoveImmediateToRegister(remoteAssembler.assembler, array[(int)x86ArgumentSlot], immediate);
			return;
		}
		RecoveredRuntime.EmitXorRegisters(remoteAssembler.assembler, array[(int)x86ArgumentSlot], array[(int)x86ArgumentSlot]);
	}

	internal static void DisposeAssemblerState(AsmJitAssembler assembler)
	{
		assembler.assemblerState.zone.Release();
		assembler.assemblerState.codeBuffer.Release();
		assembler.assemblerState.dataBlock2.Release();
		assembler.assemblerState.dataBlock.Release();
		assembler.assemblerState.uintValue = 0u;
	}

	internal static AsmJitMemoryOperand CreateWordLabelMemoryForProcess(AsmJitLabel label, long longValue, RemoteAssembler remoteAssembler)
	{
		if (remoteAssembler.flag)
		{
			AsmJitAssembler class53_ = remoteAssembler.assembler;
			class53_.assemblerState.uintValue3 = (class53_.assemblerState.uintValue3 | 8u);
		}
		return RecoveredRuntime.CreateWordLabelMemory(label, longValue);
	}

	internal static void EmbedPointer(AsmJitAssembler assembler, IntPtr address)
	{
		EmbedData(IntPtr.Size, address, assembler);
	}

	internal static void WriteX64ImmediateArgument(RemoteAssembler remoteAssembler, AsmJitImmediate immediate, int intValue, bool flag2)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.gpRegister55,
			AsmJitRuntime.gpRegister56,
			AsmJitRuntime.gpRegister62,
			AsmJitRuntime.gpRegister63
		};
		AsmJitXmmRegister[] array2 = new AsmJitXmmRegister[]
		{
			AsmJitRuntime.xmmRegister,
			AsmJitRuntime.xmmRegister2,
			AsmJitRuntime.xmmRegister3,
			AsmJitRuntime.xmmRegister4
		};
		bool flag = RecoveredRuntime.GetImmediateOperandData(immediate).address == IntPtr.Zero;
		if (intValue >= 4)
		{
			if (!flag)
			{
				RecoveredRuntime.EmitMoveImmediateToRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister54, immediate);
			}
			else
			{
				RecoveredRuntime.EmitXorRegisters(remoteAssembler.assembler, AsmJitRuntime.gpRegister54, AsmJitRuntime.gpRegister54);
			}
			RecoveredRuntime.EmitMoveRegisterToMemory(remoteAssembler.assembler, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister58, (long)(intValue * 8)), AsmJitRuntime.gpRegister54);
			return;
		}
		if (flag2)
		{
			if (flag)
			{
				RecoveredRuntime.EmitMoveImmediateToRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister54, immediate);
			}
			else
			{
				RecoveredRuntime.EmitXorRegisters(remoteAssembler.assembler, AsmJitRuntime.gpRegister54, AsmJitRuntime.gpRegister54);
			}
			RecoveredRuntime.EmitMoveRegisterToXmm(remoteAssembler.assembler, array2[intValue], AsmJitRuntime.gpRegister54);
			return;
		}
		if (flag)
		{
			RecoveredRuntime.EmitXorRegisters(remoteAssembler.assembler, array[intValue], array[intValue]);
			return;
		}
		RecoveredRuntime.EmitMoveImmediateToRegister(remoteAssembler.assembler, array[intValue], immediate);
	}

	internal static AsmJitImmediate CreateImmediate(ulong ulongValue)
	{
		if (!PlatformInfo.flag)
		{
			return new AsmJitImmediate((IntPtr)(int)ulongValue);
		}
		return new AsmJitImmediate((IntPtr)(long)ulongValue);
	}

	internal static AsmJitMemoryOperand CreateDwordLabelMemory(AsmJitLabel label, long longValue)
	{
		return CreateLabelMemoryOperand(4u, (IntPtr)longValue, label);
	}

	internal static void EmitMoveImmediateToMemory(AsmJitImmediate immediate, AsmJitMemoryOperand memoryOperand, AsmJitAssembler assembler)
	{
		EmitInstruction(assembler, AsmJitInstructionId.Move, memoryOperand, immediate);
	}

	internal static bool RegistersEqual(AsmJitRegister register, AsmJitRegister register2)
	{
		return (register2 == null && register == null) || (register2 != null && register2.Equals(register));
	}

	internal static void EmitInstruction(AsmJitAssembler assembler, AsmJitInstructionId instructionId, AsmJitOperand operand, AsmJitOperand operand2)
	{
		if (AsmJitRuntime.flag)
		{
			AsmJitApi.emitTwoOperandInstructionCdecl(ref assembler.assemblerState, instructionId, operand, operand2);
			return;
		}
		AsmJitApi.emitTwoOperandInstructionThisCall(ref assembler.assemblerState, instructionId, operand, operand2);
	}

	internal static bool ExecuteRemoteAssembler(RemoteCodeExecutor remoteCodeExecutor, AsmJitAssembler assembler)
	{
		return ExecuteAssemblerThread(assembler, remoteCodeExecutor);
	}

	internal static IntPtr BuildThreadHijackStub32(ThreadHijackInjector threadHijackInjector, IntPtr address, IntPtr address2, byte[] bytes, out NativeTypes.Context32 context32, out int intValue, out int intValue2, ref int intValue3)
	{
		context32 = default(NativeTypes.Context32);
		intValue = 0;
		intValue2 = 0;
		AsmJitAssembler @class = new AsmJitAssembler();
		@class.Is32BitMode = true;
		AsmJitAssembler class2 = @class;
		AsmJitLabel class58_ = RecoveredRuntime.CreateLabel(class2);
		AsmJitLabel label = RecoveredRuntime.CreateLabel(class2);
		AsmJitLabel label2 = RecoveredRuntime.CreateLabel(class2);
		AsmJitLabel label3 = RecoveredRuntime.CreateLabel(class2);
		AsmJitLabel label4 = RecoveredRuntime.CreateLabel(class2);
		RecoveredRuntime.EmitPushImmediate(class2, RecoveredRuntime.CreateImmediate(context32.uintValue18));
		RecoveredRuntime.EmitPushAllRegisters(class2);
		RecoveredRuntime.EmitPushGeneralRegisters(class2);
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.gpRegister38,
			AsmJitRuntime.gpRegister41,
			AsmJitRuntime.gpRegister40,
			AsmJitRuntime.gpRegister39,
			AsmJitRuntime.gpRegister45,
			AsmJitRuntime.gpRegister43,
			AsmJitRuntime.gpRegister60
		};
		AsmJitGpRegister[] array2 = new AsmJitGpRegister[]
		{
			AsmJitRuntime.gpRegister70,
			AsmJitRuntime.gpRegister73,
			AsmJitRuntime.gpRegister72,
			AsmJitRuntime.gpRegister71,
			AsmJitRuntime.gpRegister77,
			AsmJitRuntime.gpRegister75,
			AsmJitRuntime.gpRegister61
		};
		AsmJitGpRegister class63_ = array.GetRandomElement<AsmJitGpRegister>();
		AsmJitAssembler class3 = class2;
		class3.assemblerState.uintValue3 = (class3.assemblerState.uintValue3 | 8u);
		RecoveredRuntime.EmitLoadEffectiveAddress(class2, class63_, RecoveredRuntime.CreateDwordLabelMemory(class58_, 0L));
		RecoveredRuntime.EmitPushRegister(class2, class63_);
		int num = array.GetRandomIndex<AsmJitGpRegister>();
		RecoveredRuntime.EmitMoveImmediateToRegister(class2, array[num], new AsmJitImmediate(address));
		RecoveredRuntime.EmitCallRegister(array2[num], class2);
		AsmJitAssembler class4 = class2;
		class4.assemblerState.uintValue3 = (class4.assemblerState.uintValue3 | 8u);
		RecoveredRuntime.EmitMoveRegisterToMemory(class2, RecoveredRuntime.CreateDwordLabelMemory(label2, 0L), AsmJitRuntime.gpRegister38);
		AsmJitGpRegister gpRegister = AsmJitRuntime.gpRegister38;
		AsmJitGpRegister gpRegister2 = AsmJitRuntime.gpRegister38;
		RecoveredRuntime.EmitTestRegisters(gpRegister, gpRegister2, class2);
		RecoveredRuntime.EmitZeroResultJump(label4, AsmJitJumpHint.None, class2);
		RecoveredRuntime.EmitMoveImmediateToRegister(class2, array[num], new AsmJitImmediate(address2));
		RecoveredRuntime.EmitCallRegister(array2[num], class2);
		AsmJitAssembler class5 = class2;
		class5.assemblerState.uintValue3 = (class5.assemblerState.uintValue3 | 8u);
		RecoveredRuntime.EmitMoveRegisterToMemory(class2, RecoveredRuntime.CreateDwordLabelMemory(label3, 0L), AsmJitRuntime.gpRegister38);
		RecoveredRuntime.BindLabel(class2, label4);
		AsmJitAssembler class6 = class2;
		class6.assemblerState.uintValue3 = (class6.assemblerState.uintValue3 | 8u);
		AsmJitMemoryOperand class59_ = RecoveredRuntime.CreateDwordLabelMemory(label, 0L);
		AsmJitImmediate class57_ = RecoveredRuntime.CreateImmediate(1);
		RecoveredRuntime.EmitMoveImmediateToMemory(class57_, class59_, class2);
		RecoveredRuntime.EmitPopAllRegisters(class2);
		RecoveredRuntime.EmitPopFlags(class2);
		RecoveredRuntime.EmitReturn(class2);
		RecoveredRuntime.AlignCode(class2, 4u);
		RecoveredRuntime.BindLabel(class2, class58_);
		RecoveredRuntime.EmbedBytes(class2, bytes);
		RecoveredRuntime.AlignCode(class2, 4u);
		RecoveredRuntime.BindLabel(class2, label3);
		intValue3 = RecoveredRuntime.GetAssemblerOffset(class2);
		RecoveredRuntime.EmbedUInt32(class2, 0u);
		RecoveredRuntime.AlignCode(class2, 4u);
		RecoveredRuntime.BindLabel(class2, label2);
		intValue2 = RecoveredRuntime.GetAssemblerOffset(class2);
		RecoveredRuntime.EmbedUInt32(class2, 0u);
		RecoveredRuntime.BindLabel(class2, label);
		intValue = RecoveredRuntime.GetAssemblerOffset(class2);
		RecoveredRuntime.EmbedUInt32(class2, 0u);
		return RecoveredRuntime.AssembleRemoteCode(class2, threadHijackInjector);
	}

	internal static void EmitJumpInstructionWithHint(AsmJitInstructionId instructionId, AsmJitLabel label, AsmJitAssembler assembler, AsmJitJumpHint jumpHint)
	{
		if (AsmJitRuntime.flag)
		{
			AsmJitApi.emitJumpCdecl2(ref assembler.assemblerState, instructionId, label, jumpHint);
			return;
		}
		AsmJitApi.emitJumpThisCall2(ref assembler.assemblerState, instructionId, label, jumpHint);
	}

	internal static void SetImmediateOperandData(AsmJitOperand operand, AsmJitOperand.LabelOperandData labelOperandData)
	{
		operand.SetRawData(AsmJitOperand.Reinterpret<AsmJitOperand.LabelOperandData, AsmJitOperand.RawOperandData>(labelOperandData));
	}

	internal static AsmJitMemoryOperand CreateLabelMemoryOperand(uint uintValue, IntPtr address, AsmJitLabel label)
	{
		AsmJitMemoryOperand @class = new AsmJitMemoryOperand();
		AsmJitApi.createLabelMemoryOperand(@class, label, address, uintValue);
		return @class;
	}

	internal static void EmitXorRegisters(AsmJitAssembler assembler, AsmJitGpRegister gpRegister, AsmJitGpRegister gpRegister2)
	{
		EmitInstruction(assembler, AsmJitInstructionId.Xor, gpRegister, gpRegister2);
	}

	internal static AsmJitImmediate CreateImmediate(int intValue)
	{
		return new AsmJitImmediate((IntPtr)intValue);
	}

	internal static void EmitAddMemoryToRegister(AsmJitMemoryOperand memoryOperand, AsmJitGpRegister gpRegister, AsmJitAssembler assembler)
	{
		EmitInstruction(assembler, AsmJitInstructionId.Add, gpRegister, memoryOperand);
	}

	internal static void EmitPopRegister(AsmJitAssembler assembler, AsmJitGpRegister gpRegister)
	{
		EmitInstruction(gpRegister, AsmJitInstructionId.Pop, assembler);
	}

	internal static void EmitPushGeneralRegisters(AsmJitAssembler assembler)
	{
		if (assembler.Is32BitMode || !AsmJitRuntime.flag)
		{
			RecoveredRuntime.EmitInstruction(assembler, AsmJitInstructionId.PushAll);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(12411));
	}

	internal static IntPtr BuildThreadHijackStub64(ThreadHijackInjector threadHijackInjector, IntPtr address, IntPtr address2, byte[] bytes, out NativeTypes.Context64 context64, out int intValue, out int intValue2, ref int intValue3)
	{
		context64 = default(NativeTypes.Context64);
		intValue = 0;
		intValue2 = 0;
		AsmJitAssembler class53_ = new AsmJitAssembler();
		AsmJitLabel class58_ = RecoveredRuntime.CreateLabel(class53_);
		AsmJitLabel label = RecoveredRuntime.CreateLabel(class53_);
		AsmJitLabel label2 = RecoveredRuntime.CreateLabel(class53_);
		AsmJitLabel label3 = RecoveredRuntime.CreateLabel(class53_);
		AsmJitLabel label4 = RecoveredRuntime.CreateLabel(class53_);
		AsmJitLabel label5 = RecoveredRuntime.CreateLabel(class53_);
		RecoveredRuntime.EmitPushMemory(class53_, RecoveredRuntime.CreateQwordLabelMemory(label3, 0L));
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.gpRegister54,
			AsmJitRuntime.gpRegister55,
			AsmJitRuntime.gpRegister56,
			AsmJitRuntime.gpRegister57,
			AsmJitRuntime.gpRegister59,
			AsmJitRuntime.gpRegister60,
			AsmJitRuntime.gpRegister61,
			AsmJitRuntime.gpRegister62,
			AsmJitRuntime.gpRegister63,
			AsmJitRuntime.gpRegister64,
			AsmJitRuntime.gpRegister65,
			AsmJitRuntime.gpRegister66,
			AsmJitRuntime.gpRegister67,
			AsmJitRuntime.gpRegister68,
			AsmJitRuntime.gpRegister69
		};
		array.Shuffle<AsmJitGpRegister>();
		RecoveredRuntime.EmitPushFlags(class53_);
		foreach (AsmJitGpRegister class63_ in array)
		{
			RecoveredRuntime.EmitPushRegister(class53_, class63_);
		}
		ulong num = (context64.ulongValue17 - (ulong)((long)(IntPtr.Size * (2 + array.Length)))) % 16UL;
		if (num != 0UL)
		{
			AsmJitGpRegister gpRegister = AsmJitRuntime.gpRegister58;
			AsmJitImmediate class57_ = RecoveredRuntime.CreateImmediate(num);
			RecoveredRuntime.EmitSubtractRegisterImmediate(gpRegister, class57_, class53_);
		}
		RecoveredRuntime.EmitLoadEffectiveAddress(class53_, AsmJitRuntime.gpRegister55, RecoveredRuntime.CreateQwordLabelMemory(class58_, 0L));
		AsmJitGpRegister gpRegister2 = new AsmJitGpRegister[]
		{
			AsmJitRuntime.gpRegister54,
			AsmJitRuntime.gpRegister56,
			AsmJitRuntime.gpRegister57,
			AsmJitRuntime.gpRegister59,
			AsmJitRuntime.gpRegister60,
			AsmJitRuntime.gpRegister61
		}.GetRandomElement<AsmJitGpRegister>();
		RecoveredRuntime.EmitMoveImmediateToRegister(class53_, gpRegister2, new AsmJitImmediate(address));
		RecoveredRuntime.EmitCallRegister(gpRegister2, class53_);
		RecoveredRuntime.EmitMoveRegisterToMemory(class53_, RecoveredRuntime.CreateQwordLabelMemory(label2, 0L), AsmJitRuntime.gpRegister54);
		AsmJitGpRegister gpRegister3 = AsmJitRuntime.gpRegister54;
		AsmJitGpRegister gpRegister4 = AsmJitRuntime.gpRegister54;
		RecoveredRuntime.EmitTestRegisters(gpRegister3, gpRegister4, class53_);
		RecoveredRuntime.EmitZeroResultJump(label4, AsmJitJumpHint.None, class53_);
		RecoveredRuntime.EmitMoveImmediateToRegister(class53_, gpRegister2, new AsmJitImmediate(address2));
		RecoveredRuntime.EmitCallRegister(gpRegister2, class53_);
		RecoveredRuntime.EmitMoveRegisterToMemory(class53_, RecoveredRuntime.CreateDwordLabelMemory(label5, 0L), AsmJitRuntime.gpRegister38);
		RecoveredRuntime.BindLabel(class53_, label4);
		AsmJitMemoryOperand class59_ = RecoveredRuntime.CreateDwordLabelMemory(label, 0L);
		AsmJitImmediate immediate = RecoveredRuntime.CreateImmediate(1);
		RecoveredRuntime.EmitMoveImmediateToMemory(immediate, class59_, class53_);
		if (num != 0UL)
		{
			RecoveredRuntime.EmitAddRegisterImmediate(class53_, AsmJitRuntime.gpRegister58, RecoveredRuntime.CreateImmediate(num));
		}
		Array.Reverse(array);
		foreach (AsmJitGpRegister gpRegister5 in array)
		{
			RecoveredRuntime.EmitPopRegister(class53_, gpRegister5);
		}
		RecoveredRuntime.EmitPopFlags64(class53_);
		RecoveredRuntime.EmitReturn(class53_);
		RecoveredRuntime.AlignCode(class53_, 8u);
		RecoveredRuntime.BindLabel(class53_, class58_);
		RecoveredRuntime.EmbedBytes(class53_, bytes);
		RecoveredRuntime.AlignCode(class53_, 8u);
		RecoveredRuntime.BindLabel(class53_, label3);
		RecoveredRuntime.EmbedUInt64(class53_, context64.ulongValue29);
		RecoveredRuntime.BindLabel(class53_, label2);
		intValue2 = RecoveredRuntime.GetAssemblerOffset(class53_);
		RecoveredRuntime.EmbedPointer(class53_, IntPtr.Zero);
		RecoveredRuntime.AlignCode(class53_, 8u);
		intValue3 = RecoveredRuntime.GetAssemblerOffset(class53_);
		RecoveredRuntime.BindLabel(class53_, label5);
		RecoveredRuntime.EmbedUInt32(class53_, 0u);
		RecoveredRuntime.AlignCode(class53_, 8u);
		RecoveredRuntime.BindLabel(class53_, label);
		intValue = RecoveredRuntime.GetAssemblerOffset(class53_);
		RecoveredRuntime.EmbedUInt32(class53_, 0u);
		return RecoveredRuntime.AssembleRemoteCode(class53_, threadHijackInjector);
	}

	internal static void WriteX86Argument(object instance, RemoteAssembler remoteAssembler, RemoteAssembler.X86ArgumentSlot x86ArgumentSlot)
	{
		RemoteAssembler.LabelReference @class = instance as RemoteAssembler.LabelReference;
		if (@class != null)
		{
			RecoveredRuntime.EmitLoadEffectiveAddress(remoteAssembler.assembler, AsmJitRuntime.gpRegister38, RecoveredRuntime.CreatePointerLabelMemory(remoteAssembler, @class.GetLabel(), 0L));
			RecoveredRuntime.WriteX86RegisterArgument(AsmJitRuntime.gpRegister38, remoteAssembler, x86ArgumentSlot);
			return;
		}
		AsmJitImmediate class2 = instance.ToImmediate();
		if (RecoveredRuntime.OperandsNotEqual(class2, null))
		{
			RecoveredRuntime.WriteX86ImmediateArgument(x86ArgumentSlot, class2, remoteAssembler);
			return;
		}
		AsmJitGpRegister class3 = instance as AsmJitGpRegister;
		if (RecoveredRuntime.RegistersNotEqual(null, class3))
		{
			RecoveredRuntime.WriteX86RegisterArgument(class3, remoteAssembler, x86ArgumentSlot);
			return;
		}
		AsmJitMemoryOperand class59_ = instance as AsmJitMemoryOperand;
		if (!RecoveredRuntime.MemoryOperandsNotEqual(class59_, null))
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(13555));
		}
		RecoveredRuntime.WriteX86MemoryArgument(x86ArgumentSlot, remoteAssembler, class59_);
	}

	internal static AsmJitOperand.ImmediateOperandData GetRegisterOperandData(AsmJitOperand operand)
	{
		return AsmJitOperand.Reinterpret<AsmJitOperand.RawOperandData, AsmJitOperand.ImmediateOperandData>(operand.GetRawData());
	}

	internal static void ReleaseAsmJitAllocation(IntPtr address)
	{
		if (AsmJitRuntime.releaseNativeLibrary == null)
		{
			AsmJitRuntime.releaseNativeLibrary = RecoveredRuntime.ResolveAsmJitAllocationDelegate();
		}
		AsmJitRuntime.releaseNativeLibrary(address);
	}

	internal static void EmitSubtractRegisterImmediate(AsmJitGpRegister gpRegister, AsmJitImmediate immediate, AsmJitAssembler assembler)
	{
		EmitInstruction(assembler, AsmJitInstructionId.Subtract, gpRegister, immediate);
	}

	internal static AsmJitImmediate CreateImmediate(long longValue)
	{
		if (!PlatformInfo.flag)
		{
			return new AsmJitImmediate((IntPtr)(int)longValue);
		}
		return new AsmJitImmediate((IntPtr)longValue);
	}

	internal static void WriteX64RegisterArgument(int intValue, RemoteAssembler remoteAssembler, AsmJitGpRegister gpRegister)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.gpRegister55,
			AsmJitRuntime.gpRegister56,
			AsmJitRuntime.gpRegister62,
			AsmJitRuntime.gpRegister63
		};
		if (intValue < 4)
		{
			RecoveredRuntime.EmitMoveRegisterToRegister(remoteAssembler.assembler, array[intValue], gpRegister);
			return;
		}
		RecoveredRuntime.EmitMoveRegisterToRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister54, gpRegister);
		RecoveredRuntime.EmitMoveRegisterToMemory(remoteAssembler.assembler, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister58, (long)(intValue * 8)), AsmJitRuntime.gpRegister54);
	}

	internal static void AlignCode(AsmJitAssembler assembler, uint uintValue)
	{
		if (AsmJitRuntime.flag)
		{
			AsmJitApi.alignAssemblerCdecl(ref assembler.assemblerState, uintValue);
			return;
		}
		AsmJitApi.alignAssemblerThisCall(ref assembler.assemblerState, uintValue);
	}

	internal static void EmitCompareRegisters(AsmJitGpRegister gpRegister, AsmJitAssembler assembler, AsmJitGpRegister gpRegister2)
	{
		EmitInstruction(assembler, AsmJitInstructionId.Compare, gpRegister, gpRegister2);
	}

	internal static AsmJitOperand.BaseOperandData GetBaseOperandData(AsmJitOperand operand)
	{
		return AsmJitOperand.Reinterpret<AsmJitOperand.RawOperandData, AsmJitOperand.BaseOperandData>(operand.GetRawData());
	}

	internal static AsmJitOperand.LabelOperandData GetImmediateOperandData(AsmJitOperand operand)
	{
		return AsmJitOperand.Reinterpret<AsmJitOperand.RawOperandData, AsmJitOperand.LabelOperandData>(operand.GetRawData());
	}

	internal static void EmitUpperBoundJump(AsmJitJumpHint jumpHint, AsmJitLabel label, AsmJitAssembler assembler)
	{
		EmitJumpInstruction(label, jumpHint, assembler, AsmJitInstructionId.JumpGreater);
	}

	internal static AsmJitMemoryOperand CreatePointerLabelMemory(RemoteAssembler remoteAssembler, AsmJitLabel label, long longValue)
	{
		if (remoteAssembler.flag)
		{
			remoteAssembler.assembler.assemblerState.uintValue3 |= 8u;
			return CreateDwordLabelMemory(label, longValue);
		}
		return CreateQwordLabelMemory(label, longValue);
	}

	internal static void EmbedInt32(AsmJitAssembler assembler, int intValue)
	{
		EmbedData(4L, intValue, assembler);
	}

	internal static int DisassembleInstruction(ref BeaEngineDisasm disasm)
	{
		return BeaEngineDisassembler.disassembleInstruction(ref disasm);
	}

	internal static void EmitRemoteCallEpilogue(RemoteAssembler remoteAssembler, int intValue)
	{
		if (remoteAssembler.flag)
		{
			RecoveredRuntime.EmitMoveRegisterToRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister42, AsmJitRuntime.gpRegister43);
			RecoveredRuntime.EmitPopRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister43);
			RecoveredRuntime.EmitReturnAndPop(remoteAssembler.assembler, RecoveredRuntime.CreateImmediate((intValue == -1) ? 4 : intValue));
		}
		else
		{
			RecoveredRuntime.EmitMoveMemoryToRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister55, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister58, 8L));
			RecoveredRuntime.EmitMoveMemoryToRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister56, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister58, 16L));
			RecoveredRuntime.EmitMoveMemoryToRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister62, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister58, 24L));
			RecoveredRuntime.EmitMoveMemoryToRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister63, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister58, 32L));
			if (remoteAssembler.flag2)
			{
				RecoveredRuntime.EmbedByte(232, remoteAssembler.assembler);
				RecoveredRuntime.EmbedUInt32(remoteAssembler.assembler, 0u);
				RecoveredRuntime.EmbedByte(199, remoteAssembler.assembler);
				RecoveredRuntime.EmbedByte(68, remoteAssembler.assembler);
				RecoveredRuntime.EmbedByte(36, remoteAssembler.assembler);
				RecoveredRuntime.EmbedByte(4, remoteAssembler.assembler);
				RecoveredRuntime.EmbedByte(35, remoteAssembler.assembler);
				RecoveredRuntime.EmbedByte(0, remoteAssembler.assembler);
				RecoveredRuntime.EmbedByte(0, remoteAssembler.assembler);
				RecoveredRuntime.EmbedByte(0, remoteAssembler.assembler);
				RecoveredRuntime.EmbedByte(131, remoteAssembler.assembler);
				RecoveredRuntime.EmbedByte(4, remoteAssembler.assembler);
				RecoveredRuntime.EmbedByte(36, remoteAssembler.assembler);
				RecoveredRuntime.EmbedByte(13, remoteAssembler.assembler);
				RecoveredRuntime.EmbedByte(203, remoteAssembler.assembler);
				AsmJitAssembler class53_ = remoteAssembler.assembler;
				class53_.assemblerState.uintValue3 = (class53_.assemblerState.uintValue3 | 8u);
				RecoveredRuntime.EmitMoveMemoryToRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister42, RecoveredRuntime.CreateDwordLabelMemory(remoteAssembler.label2, 0L));
				RecoveredRuntime.EmitReturnAndPop(remoteAssembler.assembler, RecoveredRuntime.CreateImmediate((intValue == -1) ? 4 : intValue));
				RecoveredRuntime.AlignRemoteData(remoteAssembler);
				RecoveredRuntime.BindLabel(remoteAssembler.assembler, remoteAssembler.label2);
				RecoveredRuntime.EmbedUInt32(remoteAssembler.assembler, 0u);
			}
			else
			{
				RecoveredRuntime.EmitReturn(remoteAssembler.assembler);
			}
		}
		if (RecoveredRuntime.OperandsNotEqual(remoteAssembler.label, null))
		{
			RecoveredRuntime.AlignRemoteData(remoteAssembler);
			RecoveredRuntime.BindLabel(remoteAssembler.assembler, remoteAssembler.label);
			remoteAssembler.SetResultOffset(RecoveredRuntime.GetAssemblerOffset(remoteAssembler.assembler));
			RecoveredRuntime.EmbedBytes(remoteAssembler.assembler, new byte[remoteAssembler.intValue]);
		}
	}

	internal static void AlignRemoteData(RemoteAssembler remoteAssembler)
	{
		AlignCode(remoteAssembler.assembler, remoteAssembler.flag ? 4u : 8u);
	}

	internal static void WriteX64LabelArgument(int intValue, AsmJitLabel label, RemoteAssembler remoteAssembler)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.gpRegister55,
			AsmJitRuntime.gpRegister56,
			AsmJitRuntime.gpRegister62,
			AsmJitRuntime.gpRegister63
		};
		if (intValue < 4)
		{
			RecoveredRuntime.EmitLoadEffectiveAddress(remoteAssembler.assembler, array[intValue], RecoveredRuntime.CreatePointerLabelMemory(remoteAssembler, label, 0L));
			return;
		}
		RecoveredRuntime.EmitLoadEffectiveAddress(remoteAssembler.assembler, AsmJitRuntime.gpRegister54, RecoveredRuntime.CreatePointerLabelMemory(remoteAssembler, label, 0L));
		RecoveredRuntime.EmitMoveRegisterToMemory(remoteAssembler.assembler, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister58, (long)(intValue * 8)), AsmJitRuntime.gpRegister54);
	}

	internal static AsmJitMemoryOperand CreateQwordBaseMemory(AsmJitGpRegister gpRegister, long longValue)
	{
		return CreateBaseMemoryOperand((IntPtr)longValue, 8u, gpRegister);
	}

	internal static bool ExecuteAssemblerThread(AsmJitAssembler assembler, RemoteCodeExecutorBase remoteCodeExecutorBase)
	{
		IntPtr intPtr = RecoveredRuntime.AssembleRemoteCode(assembler, remoteCodeExecutorBase);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		IntPtr intPtr2 = RecoveredRuntime.StartRemoteThread(remoteCodeExecutorBase, intPtr, IntPtr.Zero);
		if (!(intPtr2 == IntPtr.Zero))
		{
			RecoveredRuntime.WaitForRemoteThread(remoteCodeExecutorBase, intPtr2, -1);
			RecoveredRuntime.CloseRemoteHandle(remoteCodeExecutorBase, intPtr2);
			return true;
		}
		return false;
	}

	internal static void EmitUnconditionalJump(AsmJitAssembler assembler, AsmJitLabel label)
	{
		EmitInstruction(label, AsmJitInstructionId.Jump, assembler);
	}

	internal static int GetAssemblerOffset(AsmJitAssembler assembler)
	{
		return (int)(assembler.assemblerState.codeBuffer.address2.ToInt64() - assembler.assemblerState.codeBuffer.address.ToInt64() + assembler.assemblerState.address4.ToInt64());
	}

	internal static void EmitJumpInstruction(AsmJitLabel label, AsmJitJumpHint jumpHint, AsmJitAssembler assembler, AsmJitInstructionId instructionId)
	{
		if (AsmJitRuntime.flag)
		{
			AsmJitApi.emitJumpCdecl(ref assembler.assemblerState, instructionId, label, jumpHint);
			return;
		}
		AsmJitApi.emitJumpThisCall(ref assembler.assemblerState, instructionId, label, jumpHint);
	}

	internal static AsmJitMemoryOperand CreateByteLabelMemory(AsmJitLabel label, long longValue)
	{
		return CreateLabelMemoryOperand(1u, (IntPtr)longValue, label);
	}

	internal static void EmitLoadEffectiveAddress(AsmJitAssembler assembler, AsmJitGpRegister gpRegister, AsmJitMemoryOperand memoryOperand)
	{
		EmitInstruction(assembler, AsmJitInstructionId.LoadEffectiveAddress, gpRegister, memoryOperand);
	}

	internal static void EmbedInt64(AsmJitAssembler assembler, long longValue)
	{
		EmbedData(8L, longValue, assembler);
	}

	internal static bool MemoryOperandsNotEqual(AsmJitMemoryOperand memoryOperand, AsmJitMemoryOperand memoryOperand2)
	{
		return !MemoryOperandsEqual(memoryOperand, memoryOperand2);
	}

	internal static void SetBaseOperandData(AsmJitOperand operand, AsmJitOperand.BaseOperandData baseOperandData)
	{
		operand.SetRawData(AsmJitOperand.Reinterpret<AsmJitOperand.BaseOperandData, AsmJitOperand.RawOperandData>(baseOperandData));
	}

	internal static void SetRegisterOperandData(AsmJitOperand operand, AsmJitOperand.ImmediateOperandData immediateOperandData)
	{
		operand.SetRawData(AsmJitOperand.Reinterpret<AsmJitOperand.ImmediateOperandData, AsmJitOperand.RawOperandData>(immediateOperandData));
	}

	internal static void EmbedPlatformPointer(RemoteAssembler remoteAssembler, IntPtr address)
	{
		if (remoteAssembler.flag)
		{
			RecoveredRuntime.EmbedInt32(remoteAssembler.assembler, address.ToInt32());
			return;
		}
		RecoveredRuntime.EmbedPointer(remoteAssembler.assembler, address);
	}

	internal static AsmJitMemoryOperand CreateByteLabelMemoryForProcess(AsmJitLabel label, long longValue, RemoteAssembler remoteAssembler)
	{
		if (remoteAssembler.flag)
		{
			AsmJitAssembler class53_ = remoteAssembler.assembler;
			class53_.assemblerState.uintValue3 = (class53_.assemblerState.uintValue3 | 8u);
		}
		return RecoveredRuntime.CreateByteLabelMemory(label, longValue);
	}

	internal static byte[] GetAsmJitX86Image()
	{
		return (byte[])GetEmbeddedResourceManager().GetObject("AsmJitx86", EmbeddedResources.cultureInfo);
	}

	internal static void EmitPopFlags64(AsmJitAssembler assembler)
	{
		if (!assembler.Is32BitMode && !AsmJitRuntime.flag)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(11455));
		}
		RecoveredRuntime.EmitInstruction(assembler, AsmJitInstructionId.PopFlags64);
	}

	internal static void EmitPushImmediate(AsmJitAssembler assembler, AsmJitImmediate immediate)
	{
		EmitInstruction(immediate, AsmJitInstructionId.Push, assembler);
	}

	internal static AsmJitImmediate CreateImmediate(UIntPtr address)
	{
		return new AsmJitImmediate((IntPtr)(long)(ulong)address, flag: true);
	}

	internal static void EmitMoveImmediateToRegister(AsmJitAssembler assembler, AsmJitGpRegister gpRegister, AsmJitImmediate immediate)
	{
		EmitInstruction(assembler, AsmJitInstructionId.Move, gpRegister, immediate);
	}

	internal static void EmbedData(long longValue, object instance, AsmJitAssembler assembler)
	{
		if (AsmJitRuntime.flag)
		{
			AsmJitApi.embedDataCdecl(ref assembler.assemblerState, instance, (IntPtr)longValue);
			return;
		}
		AsmJitApi.embedDataThisCall(ref assembler.assemblerState, instance, (IntPtr)longValue);
	}

	internal static byte[] GetAsmJitX64Image()
	{
		return (byte[])GetEmbeddedResourceManager().GetObject("AsmJitx64", EmbeddedResources.cultureInfo);
	}

	internal static void EmitTestRegisters(AsmJitGpRegister gpRegister, AsmJitGpRegister gpRegister2, AsmJitAssembler assembler)
	{
		EmitInstruction(assembler, AsmJitInstructionId.Test, gpRegister, gpRegister2);
	}

	internal static void InitializeAsmJitRegisters()
	{
		AsmJitRuntime.gpRegister = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(19962));
		AsmJitRuntime.gpRegister2 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(19999));
		AsmJitRuntime.gpRegister3 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20032));
		AsmJitRuntime.gpRegister4 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20065));
		AsmJitRuntime.gpRegister5 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20098));
		if (AsmJitRuntime.flag)
		{
			AsmJitRuntime.gpRegister6 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20131));
			AsmJitRuntime.gpRegister7 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20164));
			AsmJitRuntime.gpRegister8 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20197));
			AsmJitRuntime.gpRegister9 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20230));
			AsmJitRuntime.gpRegister10 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20263));
			AsmJitRuntime.gpRegister11 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20296));
			AsmJitRuntime.gpRegister12 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20329));
			AsmJitRuntime.gpRegister13 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20366));
			AsmJitRuntime.gpRegister14 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20403));
			AsmJitRuntime.gpRegister15 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20440));
			AsmJitRuntime.gpRegister16 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20477));
			AsmJitRuntime.gpRegister17 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20514));
		}
		AsmJitRuntime.gpRegister18 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20551));
		AsmJitRuntime.gpRegister19 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20584));
		AsmJitRuntime.gpRegister20 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20617));
		AsmJitRuntime.gpRegister21 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20650));
		AsmJitRuntime.gpRegister22 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20683));
		AsmJitRuntime.gpRegister23 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20716));
		AsmJitRuntime.gpRegister24 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20749));
		AsmJitRuntime.gpRegister25 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20782));
		AsmJitRuntime.gpRegister26 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20815));
		AsmJitRuntime.gpRegister27 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20848));
		AsmJitRuntime.gpRegister28 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20881));
		AsmJitRuntime.gpRegister29 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20914));
		if (AsmJitRuntime.flag)
		{
			AsmJitRuntime.gpRegister30 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20947));
			AsmJitRuntime.gpRegister31 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(20980));
			AsmJitRuntime.gpRegister32 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21013));
			AsmJitRuntime.gpRegister33 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21050));
			AsmJitRuntime.gpRegister34 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21087));
			AsmJitRuntime.gpRegister35 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21124));
			AsmJitRuntime.gpRegister36 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21161));
			AsmJitRuntime.gpRegister37 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21198));
		}
		AsmJitRuntime.gpRegister38 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21235));
		AsmJitRuntime.gpRegister39 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21268));
		AsmJitRuntime.gpRegister40 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21301));
		AsmJitRuntime.gpRegister41 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21334));
		AsmJitRuntime.gpRegister42 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21367));
		AsmJitRuntime.gpRegister43 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21400));
		AsmJitRuntime.gpRegister44 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21433));
		AsmJitRuntime.gpRegister45 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21466));
		if (AsmJitRuntime.flag)
		{
			AsmJitRuntime.gpRegister46 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21499));
			AsmJitRuntime.gpRegister47 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21532));
			AsmJitRuntime.gpRegister48 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21565));
			AsmJitRuntime.gpRegister49 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21602));
			AsmJitRuntime.gpRegister50 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21639));
			AsmJitRuntime.gpRegister51 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21676));
			AsmJitRuntime.gpRegister52 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21713));
			AsmJitRuntime.gpRegister53 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21750));
		}
		if (AsmJitRuntime.flag)
		{
			AsmJitRuntime.gpRegister54 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21787));
			AsmJitRuntime.gpRegister55 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21820));
			AsmJitRuntime.gpRegister56 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21853));
			AsmJitRuntime.gpRegister57 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21886));
			AsmJitRuntime.gpRegister58 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21919));
			AsmJitRuntime.gpRegister59 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21952));
			AsmJitRuntime.gpRegister60 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(21985));
			AsmJitRuntime.gpRegister61 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22018));
			AsmJitRuntime.gpRegister62 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22051));
			AsmJitRuntime.gpRegister63 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22084));
			AsmJitRuntime.gpRegister64 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22117));
			AsmJitRuntime.gpRegister65 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22150));
			AsmJitRuntime.gpRegister66 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22183));
			AsmJitRuntime.gpRegister67 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22216));
			AsmJitRuntime.gpRegister68 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22249));
			AsmJitRuntime.gpRegister69 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22282));
		}
		AsmJitRuntime.gpRegister70 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22315));
		AsmJitRuntime.gpRegister71 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22348));
		AsmJitRuntime.gpRegister72 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22381));
		AsmJitRuntime.gpRegister73 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22414));
		AsmJitRuntime.gpRegister74 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22447));
		AsmJitRuntime.gpRegister75 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22480));
		AsmJitRuntime.gpRegister76 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22513));
		AsmJitRuntime.gpRegister77 = AsmJitNative.ReadExportValue<AsmJitGpRegister>(EncodedStringTable.DecodeString(22546));
		AsmJitRuntime.mmxRegister = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22579));
		AsmJitRuntime.mmxRegister2 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22612));
		AsmJitRuntime.mmxRegister3 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22645));
		AsmJitRuntime.mmxRegister4 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22678));
		AsmJitRuntime.mmxRegister5 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22711));
		AsmJitRuntime.mmxRegister6 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22744));
		AsmJitRuntime.mmxRegister7 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22777));
		AsmJitRuntime.mmxRegister8 = AsmJitNative.ReadExportValue<AsmJitMmxRegister>(EncodedStringTable.DecodeString(22810));
		AsmJitRuntime.xmmRegister = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(22843));
		AsmJitRuntime.xmmRegister2 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(22880));
		AsmJitRuntime.xmmRegister3 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(22917));
		AsmJitRuntime.xmmRegister4 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(22954));
		AsmJitRuntime.xmmRegister5 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(22991));
		AsmJitRuntime.xmmRegister6 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23028));
		AsmJitRuntime.xmmRegister7 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23065));
		AsmJitRuntime.xmmRegister8 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23102));
		if (AsmJitRuntime.flag)
		{
			AsmJitRuntime.xmmRegister9 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23139));
			AsmJitRuntime.xmmRegister10 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23176));
			AsmJitRuntime.xmmRegister11 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23213));
			AsmJitRuntime.xmmRegister12 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23250));
			AsmJitRuntime.xmmRegister13 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23287));
			AsmJitRuntime.xmmRegister14 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23324));
			AsmJitRuntime.xmmRegister15 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23361));
			AsmJitRuntime.xmmRegister16 = AsmJitNative.ReadExportValue<AsmJitXmmRegister>(EncodedStringTable.DecodeString(23398));
		}
	}

	internal static void EmitMoveRegisterToRegister(AsmJitAssembler assembler, AsmJitGpRegister gpRegister, AsmJitGpRegister gpRegister2)
	{
		EmitInstruction(assembler, AsmJitInstructionId.Move, gpRegister, gpRegister2);
	}

	internal static bool MemoryOperandsEqual(AsmJitMemoryOperand memoryOperand, AsmJitMemoryOperand memoryOperand2)
	{
		return (memoryOperand == null && memoryOperand2 == null) || (memoryOperand != null && memoryOperand.Equals(memoryOperand2));
	}

	internal static void EmbedBytes(AsmJitAssembler assembler, byte[] bytes)
	{
		EmbedData(bytes.Length, bytes, assembler);
	}

	internal static void WriteX64MemoryArgument(AsmJitMemoryOperand memoryOperand, RemoteAssembler remoteAssembler, int intValue)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.gpRegister55,
			AsmJitRuntime.gpRegister56,
			AsmJitRuntime.gpRegister62,
			AsmJitRuntime.gpRegister63
		};
		if (intValue < 4)
		{
			RecoveredRuntime.EmitMoveMemoryToRegister(remoteAssembler.assembler, array[intValue], memoryOperand);
			return;
		}
		RecoveredRuntime.EmitMoveMemoryToRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister54, memoryOperand);
		RecoveredRuntime.EmitMoveRegisterToMemory(remoteAssembler.assembler, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister58, (long)(intValue * 8)), AsmJitRuntime.gpRegister54);
	}

	internal static bool OperandsEqual(AsmJitOperand operand, AsmJitOperand operand2)
	{
		return (operand == null && operand2 == null) || (operand != null && operand.Equals(operand2));
	}

	internal static AsmJitMemoryOperand CreateQwordLabelMemory(AsmJitLabel label, long longValue)
	{
		return CreateLabelMemoryOperand(8u, (IntPtr)longValue, label);
	}

	internal static void EmitComparisonFailureJump(AsmJitJumpHint jumpHint, AsmJitAssembler assembler, AsmJitLabel label)
	{
		EmitJumpInstruction(label, jumpHint, assembler, AsmJitInstructionId.JumpNotEqual);
	}

	internal static void EmbedNullPointer(RemoteAssembler remoteAssembler)
	{
		if (remoteAssembler.flag)
		{
			RecoveredRuntime.EmbedUInt32(remoteAssembler.assembler, 0u);
			return;
		}
		RecoveredRuntime.EmbedInt64(remoteAssembler.assembler, 0L);
	}

	internal static uint GetRegisterId(AsmJitRegister register)
	{
		return GetRegisterOperandData(register).uintValue2;
	}

	internal static AsmJitImmediate CreateImmediate(short shortValue)
	{
		return new AsmJitImmediate((IntPtr)shortValue);
	}

	internal static void EmitReturn(AsmJitAssembler assembler)
	{
		EmitInstruction(assembler, AsmJitInstructionId.Return);
	}

	internal static void EmitInstruction(AsmJitOperand operand, AsmJitInstructionId instructionId, AsmJitAssembler assembler)
	{
		if (AsmJitRuntime.flag)
		{
			AsmJitApi.emitOneOperandInstructionCdecl(ref assembler.assemblerState, instructionId, operand);
			return;
		}
		AsmJitApi.emitOneOperandInstructionThisCall(ref assembler.assemblerState, instructionId, operand);
	}

	internal static void EmitX86FunctionCall(AsmJitOperand operand, object[] instanceArray, CallingConvention callingConvention, RemoteAssembler remoteAssembler)
	{
		bool[] array = new bool[instanceArray.Length];
		if (callingConvention == CallingConvention.ThisCall || callingConvention == CallingConvention.FastCall)
		{
			int num = (callingConvention == CallingConvention.FastCall) ? 2 : 1;
			int num2 = 0;
			int num3 = 0;
			while (num2 < instanceArray.Length && num3 < num)
			{
				array[num2] = true;
				RecoveredRuntime.WriteX86Argument(instanceArray[num2], remoteAssembler, (RemoteAssembler.X86ArgumentSlot)num3);
				num3++;
				num2++;
			}
		}
		for (int i = instanceArray.Length - 1; i >= 0; i--)
		{
			if (!array[i])
			{
				RecoveredRuntime.WriteX86Argument(instanceArray[i], remoteAssembler, RemoteAssembler.X86ArgumentSlot.FirstStackArgument);
			}
		}
		AsmJitImmediate @class = operand as AsmJitImmediate;
		if (RecoveredRuntime.OperandsNotEqual(@class, null))
		{
			RecoveredRuntime.EmitMoveImmediateToRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister38, @class);
			AsmJitAssembler class53_ = remoteAssembler.assembler;
			AsmJitGpRegister class63_ = AsmJitRuntime.gpRegister70;
			RecoveredRuntime.EmitCallRegister(class63_, class53_);
		}
		AsmJitGpRegister class2 = operand as AsmJitGpRegister;
		if (RecoveredRuntime.RegistersNotEqual(null, class2))
		{
			RecoveredRuntime.EmitCallRegister(class2, remoteAssembler.assembler);
		}
		if (RecoveredRuntime.OperandsEqual(@class, null) && RecoveredRuntime.RegistersEqual(null, class2))
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(24964));
		}
		if (callingConvention == CallingConvention.Cdecl)
		{
			int num4 = 0;
			foreach (object obj in instanceArray)
			{
				if (!(obj is IntPtr) && !(obj is UIntPtr) && !(obj is RemoteAssembler.LabelReference))
				{
					num4 += obj.GetType().SizeOf();
				}
				else
				{
					num4 += 4;
				}
			}
			RecoveredRuntime.EmitAddRegisterImmediate(remoteAssembler.assembler, AsmJitRuntime.gpRegister42, RecoveredRuntime.CreateImmediate(num4));
			return;
		}
	}

	internal static void EmitReturnAndPop(AsmJitAssembler assembler, AsmJitImmediate immediate)
	{
		EmitInstruction(immediate, AsmJitInstructionId.Return, assembler);
	}

	internal static void EmitAddRegisterImmediate(AsmJitAssembler assembler, AsmJitGpRegister gpRegister, AsmJitImmediate immediate)
	{
		EmitInstruction(assembler, AsmJitInstructionId.Add, gpRegister, immediate);
	}

	internal static AsmJitMemoryOperand CreateWordLabelMemory(AsmJitLabel label, long longValue)
	{
		return CreateLabelMemoryOperand(2u, (IntPtr)longValue, label);
	}

	internal static void EmitX64FunctionCall(RemoteAssembler remoteAssembler, AsmJitOperand operand, object[] instanceArray)
	{
		int num = (instanceArray.Length <= 4) ? 40 : (instanceArray.Length * 8);
		AsmJitImmediate @class = operand as AsmJitImmediate;
		num -= num % 16;
		AsmJitAssembler class53_ = remoteAssembler.assembler;
		AsmJitGpRegister class63_ = AsmJitRuntime.gpRegister58;
		AsmJitImmediate class57_ = RecoveredRuntime.CreateImmediate(num + 8);
		RecoveredRuntime.EmitSubtractRegisterImmediate(class63_, class57_, class53_);
		if (!remoteAssembler.GetRandomizeArgumentSetup())
		{
			for (int i = 0; i < instanceArray.Length; i++)
			{
				RecoveredRuntime.WriteX64Argument(remoteAssembler, instanceArray[i], i);
			}
		}
		else
		{
			int[] array = Enumerable.Range(0, instanceArray.Length).ToArray<int>();
			array.Shuffle<int>();
			foreach (int num2 in array)
			{
				RecoveredRuntime.WriteX64Argument(remoteAssembler, instanceArray[num2], num2);
			}
		}
		if (RecoveredRuntime.OperandsNotEqual(@class, null))
		{
			RecoveredRuntime.EmitMoveImmediateToRegister(remoteAssembler.assembler, AsmJitRuntime.gpRegister54, @class);
			AsmJitAssembler assembler = remoteAssembler.assembler;
			AsmJitGpRegister gpRegister = AsmJitRuntime.gpRegister54;
			RecoveredRuntime.EmitCallRegister(gpRegister, assembler);
		}
		AsmJitGpRegister class2 = operand as AsmJitGpRegister;
		if (RecoveredRuntime.RegistersNotEqual(null, class2))
		{
			RecoveredRuntime.EmitCallRegister(class2, remoteAssembler.assembler);
		}
		if (RecoveredRuntime.OperandsEqual(@class, null) && RecoveredRuntime.RegistersEqual(null, class2))
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(24964));
		}
		RecoveredRuntime.EmitAddRegisterImmediate(remoteAssembler.assembler, AsmJitRuntime.gpRegister58, RecoveredRuntime.CreateImmediate(num + 8));
	}

	internal static void EmitPushMemory(AsmJitAssembler assembler, AsmJitMemoryOperand memoryOperand)
	{
		EmitInstruction(memoryOperand, AsmJitInstructionId.Push, assembler);
	}

	internal static void EmitCallRegister(AsmJitGpRegister gpRegister, AsmJitAssembler assembler)
	{
		EmitInstruction(gpRegister, AsmJitInstructionId.Call, assembler);
	}

	internal static AsmJitImmediate CreateImmediate(uint uintValue)
	{
		return new AsmJitImmediate((IntPtr)(int)uintValue, flag: true);
	}

	internal static void SetLabelOperandData(AsmJitOperand.RegisterOperandData registerOperandData, AsmJitOperand operand)
	{
		operand.SetRawData(AsmJitOperand.Reinterpret<AsmJitOperand.RegisterOperandData, AsmJitOperand.RawOperandData>(registerOperandData));
	}

	internal static AsmJitImmediate CreateImmediate(ushort ushortValue)
	{
		return new AsmJitImmediate((IntPtr)ushortValue);
	}

	internal static AsmJitOperand.MemoryOperandData GetMemoryOperandData(AsmJitOperand operand)
	{
		return AsmJitOperand.Reinterpret<AsmJitOperand.RawOperandData, AsmJitOperand.MemoryOperandData>(operand.GetRawData());
	}

	internal static void WriteX64Argument(RemoteAssembler remoteAssembler, object instance, int intValue)
	{
		RemoteAssembler.LabelReference @class = instance as RemoteAssembler.LabelReference;
		if (@class != null)
		{
			RecoveredRuntime.WriteX64LabelArgument(intValue, @class.GetLabel(), remoteAssembler);
			return;
		}
		AsmJitImmediate class2 = instance.ToImmediate();
		if (RecoveredRuntime.OperandsNotEqual(class2, null))
		{
			RecoveredRuntime.WriteX64ImmediateArgument(remoteAssembler, class2, intValue, instance is float || instance is double);
			return;
		}
		AsmJitGpRegister class3 = instance as AsmJitGpRegister;
		if (RecoveredRuntime.RegistersNotEqual(null, class3))
		{
			RecoveredRuntime.WriteX64RegisterArgument(intValue, remoteAssembler, class3);
			return;
		}
		AsmJitMemoryOperand class59_ = instance as AsmJitMemoryOperand;
		if (RecoveredRuntime.MemoryOperandsNotEqual(class59_, null))
		{
			RecoveredRuntime.WriteX64MemoryArgument(class59_, remoteAssembler, intValue);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(13555));
	}

	internal static bool RegistersNotEqual(AsmJitRegister register, AsmJitRegister register2)
	{
		return !RegistersEqual(register, register2);
	}

	internal static AsmJitMemoryOperand CreateDwordBaseMemory(long longValue, AsmJitGpRegister gpRegister)
	{
		return CreateBaseMemoryOperand((IntPtr)longValue, 4u, gpRegister);
	}

	internal static IntPtr GetAssemblerCodePointer(AsmJitAssembler assembler)
	{
		if (!AsmJitRuntime.flag)
		{
			return AsmJitApi.getAssemblerOffsetThisCall(ref assembler.assemblerState);
		}
		return AsmJitApi.getAssemblerOffsetCdecl(ref assembler.assemblerState);
	}

	internal static AsmJitOperand.VariableOperandData GetVariableOperandData(AsmJitOperand operand)
	{
		return AsmJitOperand.Reinterpret<AsmJitOperand.RawOperandData, AsmJitOperand.VariableOperandData>(operand.GetRawData());
	}

	internal static bool InstallVectoredExceptionHandler(bool flag, ulong ulongValue, VectoredExceptionHandlerInstaller vectoredExceptionHandlerInstaller, IntPtr address)
	{
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(vectoredExceptionHandlerInstaller.GetRemoteProcess())[EncodedStringTable.DecodeString(8549)];
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(12731));
		}
		AsmJitAssembler @class = new AsmJitAssembler();
		IntPtr value;
		if (!vectoredExceptionHandlerInstaller.GetRemoteProcess().Is64Bit)
		{
			IntPtr intPtr = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(27396), false);
			for (int i = 0; i < vectoredExceptionHandlerInstaller.bytes.Length - 4; i++)
			{
				uint num = BitConverter.ToUInt32(vectoredExceptionHandlerInstaller.bytes, i);
				if (num != 3735935610u)
				{
					if (num == 3735929054u)
					{
						BitConverter.GetBytes(intPtr.ToInt32()).CopyTo(vectoredExceptionHandlerInstaller.bytes, i);
						break;
					}
					if (num == 3735929042u)
					{
						value = RecoveredRuntime.GetNativeLoaderHooks(vectoredExceptionHandlerInstaller.GetRemoteProcess()).GetRemoveInvertedFunctionTableAddress();
						BitConverter.GetBytes(value.ToInt32()).CopyTo(vectoredExceptionHandlerInstaller.bytes, i);
					}
				}
				else
				{
					value = RecoveredRuntime.GetNativeLoaderHooks(vectoredExceptionHandlerInstaller.GetRemoteProcess()).GetInvertedFunctionTableAddress();
					BitConverter.GetBytes(value.ToInt32()).CopyTo(vectoredExceptionHandlerInstaller.bytes, i);
				}
			}
			vectoredExceptionHandlerInstaller.address2 = RecoveredRuntime.AllocateRemoteMemory(vectoredExceptionHandlerInstaller, (long)vectoredExceptionHandlerInstaller.bytes.Length, NativeTypes.MemoryProtection.ExecuteReadWrite);
			if (vectoredExceptionHandlerInstaller.address2 == IntPtr.Zero)
			{
				throw new AccessViolationException(EncodedStringTable.DecodeString(27429));
			}
			if (!vectoredExceptionHandlerInstaller.WriteArray<byte>(vectoredExceptionHandlerInstaller.address2, vectoredExceptionHandlerInstaller.bytes))
			{
				throw new AccessViolationException(EncodedStringTable.DecodeString(27482));
			}
		}
		else
		{
			if (vectoredExceptionHandlerInstaller.address == IntPtr.Zero)
			{
				vectoredExceptionHandlerInstaller.address = RecoveredRuntime.AllocateRemoteMemory(vectoredExceptionHandlerInstaller, 4096L, NativeTypes.MemoryProtection.ReadWrite);
				if (vectoredExceptionHandlerInstaller.address == IntPtr.Zero)
				{
					throw new AccessViolationException(EncodedStringTable.DecodeString(27339));
				}
			}
			VectoredExceptionHandlerInstaller.InvertedFunctionTable @struct = vectoredExceptionHandlerInstaller.Read<VectoredExceptionHandlerInstaller.InvertedFunctionTable>(vectoredExceptionHandlerInstaller.address);
			long num2 = @struct.address.ToInt64();
			AsmJitLabel class58_;
			AsmJitLabel label;
			AsmJitLabel label2;
			AsmJitLabel label3;
			AsmJitGpRegister class63_;
			AsmJitGpRegister gpRegister;
			AsmJitGpRegister gpRegister2;
			checked
			{
				@struct.invertedFunctionTableEntryArray[(int)((IntPtr)num2)].address = address;
				@struct.invertedFunctionTableEntryArray[(int)((IntPtr)num2)].address2 = (IntPtr)((long)ulongValue);
				@struct.address = @struct.address.Add(1);
				vectoredExceptionHandlerInstaller.Write<VectoredExceptionHandlerInstaller.InvertedFunctionTable>(vectoredExceptionHandlerInstaller.address, @struct);
				class58_ = RecoveredRuntime.CreateLabel(@class);
				label = RecoveredRuntime.CreateLabel(@class);
				label2 = RecoveredRuntime.CreateLabel(@class);
				label3 = RecoveredRuntime.CreateLabel(@class);
				RecoveredRuntime.EmitMoveMemoryToRegister(@class, AsmJitRuntime.gpRegister54, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister55, 0L));
				AsmJitMemoryOperand class59_ = RecoveredRuntime.CreateDwordBaseMemory(0L, AsmJitRuntime.gpRegister54);
				AsmJitImmediate class57_ = RecoveredRuntime.CreateImmediate(3765269347u);
				RecoveredRuntime.EmitCompareMemoryImmediate(class57_, class59_, @class);
				RecoveredRuntime.EmitComparisonFailureJump(AsmJitJumpHint.None, @class, class58_);
				class59_ = RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister54, 32L);
				class57_ = RecoveredRuntime.CreateImmediate(26820608u);
				RecoveredRuntime.EmitCompareMemoryImmediate(class57_, class59_, @class);
				RecoveredRuntime.EmitComparisonFailureJump(AsmJitJumpHint.None, @class, class58_);
				class59_ = RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister54, 56L);
				class57_ = RecoveredRuntime.CreateImmediate(0);
				RecoveredRuntime.EmitCompareMemoryImmediate(class57_, class59_, @class);
				RecoveredRuntime.EmitComparisonFailureJump(AsmJitJumpHint.None, @class, class58_);
				RecoveredRuntime.EmitMoveImmediateToRegister(@class, AsmJitRuntime.gpRegister63, new AsmJitImmediate(vectoredExceptionHandlerInstaller.address));
				RecoveredRuntime.EmitMoveMemoryToRegister(@class, AsmJitRuntime.gpRegister56, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister63, 0L));
				RecoveredRuntime.EmitAddRegisterImmediate(@class, AsmJitRuntime.gpRegister63, RecoveredRuntime.CreateImmediate(IntPtr.Size));
				RecoveredRuntime.EmitXorRegisters(@class, AsmJitRuntime.gpRegister64, AsmJitRuntime.gpRegister64);
				RecoveredRuntime.BindLabel(@class, label);
				RecoveredRuntime.EmitMoveMemoryToRegister(@class, AsmJitRuntime.gpRegister62, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister54, 48L));
				RecoveredRuntime.EmitMoveMemoryToRegister(@class, AsmJitRuntime.gpRegister65, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister63, 0L));
				class63_ = AsmJitRuntime.gpRegister62;
				gpRegister = AsmJitRuntime.gpRegister65;
				RecoveredRuntime.EmitCompareRegisters(class63_, @class, gpRegister);
				RecoveredRuntime.EmitLowerBoundJump(AsmJitJumpHint.None, label2, @class);
				gpRegister2 = AsmJitRuntime.gpRegister65;
			}
			AsmJitMemoryOperand memoryOperand = RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister63, (long)IntPtr.Size);
			RecoveredRuntime.EmitAddMemoryToRegister(memoryOperand, gpRegister2, @class);
			class63_ = AsmJitRuntime.gpRegister62;
			gpRegister = AsmJitRuntime.gpRegister65;
			RecoveredRuntime.EmitCompareRegisters(class63_, @class, gpRegister);
			RecoveredRuntime.EmitUpperBoundJump(AsmJitJumpHint.None, label2, @class);
			RecoveredRuntime.EmitUnconditionalJump(@class, label3);
			RecoveredRuntime.BindLabel(@class, label2);
			RecoveredRuntime.EmitAddRegisterImmediate(@class, AsmJitRuntime.gpRegister63, RecoveredRuntime.CreateImmediate(typeof(VectoredExceptionHandlerInstaller.InvertedFunctionTableEntry).SizeOf()));
			RecoveredRuntime.EmitAddRegisterImmediate(@class, AsmJitRuntime.gpRegister64, RecoveredRuntime.CreateImmediate(1));
			class63_ = AsmJitRuntime.gpRegister64;
			gpRegister = AsmJitRuntime.gpRegister56;
			RecoveredRuntime.EmitCompareRegisters(class63_, @class, gpRegister);
			RecoveredRuntime.EmitComparisonFailureJump(AsmJitJumpHint.None, @class, label);
			RecoveredRuntime.EmitUnconditionalJump(@class, class58_);
			RecoveredRuntime.BindLabel(@class, label3);
			AsmJitMemoryOperand memoryOperand2 = RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister54, 32L);
			AsmJitImmediate immediate = RecoveredRuntime.CreateImmediate(429065504u);
			RecoveredRuntime.EmitMoveImmediateToMemory(immediate, memoryOperand2, @class);
			RecoveredRuntime.EmitMoveMemoryToRegister(@class, AsmJitRuntime.gpRegister55, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister55, 0L));
			RecoveredRuntime.EmitMoveMemoryToRegister(@class, AsmJitRuntime.gpRegister56, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister63, 0L));
			RecoveredRuntime.EmitMoveRegisterToMemory(@class, RecoveredRuntime.CreateQwordBaseMemory(AsmJitRuntime.gpRegister54, 56L), AsmJitRuntime.gpRegister56);
			RecoveredRuntime.BindLabel(@class, class58_);
			RecoveredRuntime.EmitXorRegisters(@class, AsmJitRuntime.gpRegister54, AsmJitRuntime.gpRegister54);
			RecoveredRuntime.EmitReturn(@class);
			RecoveredRuntime.EmbedByte(204, @class);
			RecoveredRuntime.EmbedByte(204, @class);
			RecoveredRuntime.EmbedByte(204, @class);
			vectoredExceptionHandlerInstaller.address2 = RecoveredRuntime.AssembleRemoteCode(@class, vectoredExceptionHandlerInstaller);
			RecoveredRuntime.DisposeAssemblerState(@class);
		}
		RemoteAssembler class2 = new RemoteAssembler(@class, vectoredExceptionHandlerInstaller.GetRemoteProcess());
		RecoveredRuntime.EmitRemoteCallPrologue(class2);
		RecoveredRuntime.EmitRemoteCall(class2, new AsmJitImmediate(RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(27531), false)), CallingConvention.StdCall, new object[]
		{
			0,
			vectoredExceptionHandlerInstaller.address2
		});
		class2.CaptureReturnValue<IntPtr>();
		RecoveredRuntime.EmitRemoteCallEpilogue(class2, -1);
		value = (vectoredExceptionHandlerInstaller.address3 = vectoredExceptionHandlerInstaller.Execute<IntPtr>(class2));
		return value != IntPtr.Zero;
	}

	internal static AsmJitMemoryOperand CreatePointerBaseMemory(AsmJitGpRegister gpRegister, long longValue, RemoteAssembler remoteAssembler)
	{
		if (remoteAssembler.flag)
		{
			remoteAssembler.assembler.assemblerState.uintValue3 |= 8u;
			return CreateDwordBaseMemory(longValue, gpRegister);
		}
		return CreateQwordBaseMemory(gpRegister, longValue);
	}

	internal static void EmbedByte(byte byteValue, AsmJitAssembler assembler)
	{
		EmbedData(1L, byteValue, assembler);
	}

	internal static AsmJitImmediate CreateImmediate(float floatValue)
	{
		return new AsmJitImmediate((IntPtr)BitConverter.ToInt32(BitConverter.GetBytes(floatValue), 0));
	}
}
