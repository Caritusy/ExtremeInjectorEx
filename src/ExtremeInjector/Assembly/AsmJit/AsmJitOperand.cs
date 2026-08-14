using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public class AsmJitOperand
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct RawOperandData
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public uint[] uintValueArray;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public IntPtr[] addresses;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct BaseOperandData
	{
		public AsmJitOperandType operandType;

		public byte byteValue;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public byte[] bytes;

		public uint uintValue;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal uint[] uintValueArray;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal IntPtr[] addresses;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ImmediateOperandData
	{
		public AsmJitOperandType operandType;

		public byte byteValue;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public byte[] bytes;

		public uint uintValue;

		public uint uintValue2;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		internal uint[] uintValueArray;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal IntPtr[] addresses;
	}

	public struct PackedOperandFlags
	{
		internal byte byteValue;

		internal static byte[] bytes = new byte[9] { 0, 1, 3, 7, 15, 31, 63, 127, 255 };

		public void SetBits(int intValue, int intValue2, byte byteValue2)
		{
			byte b = AsmJitOperand.PackedOperandFlags.bytes[intValue2];
			if (byteValue2 <= b)
			{
				this.byteValue = (byte)((int)this.byteValue & ~((int)b << intValue));
				this.byteValue = (byte)((int)this.byteValue | (int)byteValue2 << intValue);
				return;
			}
			throw new ArgumentOutOfRangeException();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MemoryOperandData
	{
		public AsmJitOperandType operandType;

		public byte byteValue;

		public AsmJitMemoryType memoryType;

		internal PackedOperandFlags addressingFlag;

		public uint uintValue;

		public uint uintValue2;

		public uint uintValue3;

		public IntPtr address;

		public IntPtr address2;

		[SpecialName]
		public void SetAddressingFlag(bool flag)
		{
			addressingFlag.SetBits(4, 1, (byte)(flag ? 1 : 0));
		}

		[SpecialName]
		public void SetScaleShift(byte byteValue2)
		{
			addressingFlag.SetBits(5, 3, byteValue2);
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LabelOperandData
	{
		public AsmJitOperandType operandType;

		public byte byteValue;

		[MarshalAs(UnmanagedType.U1)]
		public bool flag;

		public byte byteValue2;

		public uint uintValue;

		public IntPtr address;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal uint[] uintValueArray;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		internal IntPtr[] addresses;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct RegisterOperandData
	{
		public AsmJitOperandType operandType;

		public byte byteValue;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public byte[] bytes;

		public uint uintValue;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal uint[] uintValueArray;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal IntPtr[] addresses;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct VariableOperandData
	{
		public AsmJitOperandType operandType;

		public byte byteValue;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public byte[] bytes;

		public uint uintValue;

		public uint uintValue2;

		public AsmJitVariableType variableType;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal IntPtr[] addresses;
	}

	[CompilerGenerated]
	internal RawOperandData rawData;

	[SpecialName]
	[CompilerGenerated]
	internal RawOperandData GetRawData()
	{
		return rawData;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetRawData(RawOperandData rawOperandData)
	{
		rawData = rawOperandData;
	}

	internal static U Reinterpret<T, U>(T value) where T : struct where U : struct
	{
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(T)));
		Marshal.StructureToPtr(value, intPtr, false);
		U result = (U)((object)Marshal.PtrToStructure(intPtr, typeof(U)));
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public AsmJitOperand()
	{
		this.SetRawData(new AsmJitOperand.RawOperandData
		{
			uintValueArray = new uint[4],
			addresses = new IntPtr[2]
		});
		AsmJitOperand.BaseOperandData struct8_ = RecoveredRuntime.GetBaseOperandData(this);
		struct8_.uintValue = AsmJitRuntime.uintValue;
		RecoveredRuntime.SetBaseOperandData(this, struct8_);
	}

	internal AsmJitOperand(AsmJitUninitializedOperandTag uninitializedOperandTag)
	{
		SetRawData(new RawOperandData
		{
			uintValueArray = new uint[4],
			addresses = new IntPtr[2]
		});
	}

	public override bool Equals(object obj)
	{
		AsmJitOperand @class = obj as AsmJitOperand;
		if (@class == null)
		{
			return false;
		}
		AsmJitOperand.BaseOperandData @struct = RecoveredRuntime.GetBaseOperandData(this);
		return RecoveredRuntime.GetBaseOperandData(@class).operandType == @struct.operandType && RecoveredRuntime.GetBaseOperandData(@class).byteValue == @struct.byteValue && @struct.uintValue == RecoveredRuntime.GetBaseOperandData(@class).uintValue;
	}

	public override int GetHashCode()
	{
		BaseOperandData @struct = RecoveredRuntime.GetBaseOperandData(this);
		return (@struct.uintValue.GetHashCode() * 397 + @struct.operandType.GetHashCode()) * 397 + @struct.byteValue.GetHashCode();
	}
}
