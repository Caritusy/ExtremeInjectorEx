using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public class AsmJitOperand
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct7
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public uint[] uint_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public IntPtr[] intptr_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct8
	{
		public AsmJitOperandType enum8_0;

		public byte byte_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public byte[] byte_1;

		public uint uint_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal uint[] uint_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal IntPtr[] intptr_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct9
	{
		public AsmJitOperandType enum8_0;

		public byte byte_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public byte[] byte_1;

		public uint uint_0;

		public uint uint_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		internal uint[] uint_2;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal IntPtr[] intptr_0;
	}

	public struct Struct10
	{
		internal byte byte_0;

		internal static byte[] byte_1 = new byte[9] { 0, 1, 3, 7, 15, 31, 63, 127, 255 };

		public void method_0(int int_0, int int_1, byte byte_2)
		{
			byte b = AsmJitOperand.Struct10.byte_1[int_1];
			if (byte_2 <= b)
			{
				this.byte_0 = (byte)((int)this.byte_0 & ~((int)b << int_0));
				this.byte_0 = (byte)((int)this.byte_0 | (int)byte_2 << int_0);
				return;
			}
			throw new ArgumentOutOfRangeException();
		}

		internal static ArgumentOutOfRangeException smethod_0()
		{
			return new ArgumentOutOfRangeException();
		}

		internal static void smethod_1(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct11
	{
		public AsmJitOperandType enum8_0;

		public byte byte_0;

		public AsmJitMemoryType enum9_0;

		internal Struct10 struct10_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		[SpecialName]
		public void method_0(bool bool_0)
		{
			struct10_0.method_0(4, 1, (byte)(bool_0 ? 1 : 0));
		}

		[SpecialName]
		public void method_1(byte byte_1)
		{
			struct10_0.method_0(5, 3, byte_1);
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct12
	{
		public AsmJitOperandType enum8_0;

		public byte byte_0;

		[MarshalAs(UnmanagedType.U1)]
		public bool bool_0;

		public byte byte_1;

		public uint uint_0;

		public IntPtr intptr_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal uint[] uint_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		internal IntPtr[] intptr_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct13
	{
		public AsmJitOperandType enum8_0;

		public byte byte_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public byte[] byte_1;

		public uint uint_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal uint[] uint_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal IntPtr[] intptr_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct14
	{
		public AsmJitOperandType enum8_0;

		public byte byte_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public byte[] byte_1;

		public uint uint_0;

		public uint uint_1;

		public AsmJitVariableType enum11_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		internal IntPtr[] intptr_0;
	}

	[CompilerGenerated]
	internal Struct7 struct7_0;

	[SpecialName]
	[CompilerGenerated]
	internal Struct7 method_0()
	{
		return struct7_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(Struct7 struct7_1)
	{
		struct7_0 = struct7_1;
	}

	internal static U smethod_0<T, U>(T gparam_0) where T : struct where U : struct
	{
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(T)));
		Marshal.StructureToPtr(gparam_0, intPtr, false);
		U result = (U)((object)Marshal.PtrToStructure(intPtr, typeof(U)));
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public AsmJitOperand()
	{
		this.method_1(new AsmJitOperand.Struct7
		{
			uint_0 = new uint[4],
			intptr_0 = new IntPtr[2]
		});
		AsmJitOperand.Struct8 struct8_ = RecoveredRuntime.smethod_218(this);
		struct8_.uint_0 = AsmJitRuntime.uint_0;
		RecoveredRuntime.smethod_279(this, struct8_);
	}

	internal AsmJitOperand(AsmJitUninitializedOperandTag struct20_0)
	{
		method_1(new Struct7
		{
			uint_0 = new uint[4],
			intptr_0 = new IntPtr[2]
		});
	}

	public override bool Equals(object obj)
	{
		AsmJitOperand @class = obj as AsmJitOperand;
		if (@class == null)
		{
			return false;
		}
		AsmJitOperand.Struct8 @struct = RecoveredRuntime.smethod_218(this);
		return RecoveredRuntime.smethod_218(@class).enum8_0 == @struct.enum8_0 && RecoveredRuntime.smethod_218(@class).byte_0 == @struct.byte_0 && @struct.uint_0 == RecoveredRuntime.smethod_218(@class).uint_0;
	}

	public override int GetHashCode()
	{
		Struct8 @struct = RecoveredRuntime.smethod_218(this);
		return (@struct.uint_0.GetHashCode() * 397 + @struct.enum8_0.GetHashCode()) * 397 + @struct.byte_0.GetHashCode();
	}

	internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int smethod_2(Type type_0)
	{
		return Marshal.SizeOf(type_0);
	}

	internal static IntPtr smethod_3(int int_0)
	{
		return Marshal.AllocHGlobal(int_0);
	}

	internal static void smethod_4(object object_0, IntPtr intptr_0, bool bool_0)
	{
		Marshal.StructureToPtr(object_0, intptr_0, bool_0);
	}

	internal static object smethod_5(IntPtr intptr_0, Type type_0)
	{
		return Marshal.PtrToStructure(intptr_0, type_0);
	}

	internal static void smethod_6(IntPtr intptr_0)
	{
		Marshal.FreeHGlobal(intptr_0);
	}
}
