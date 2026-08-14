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
			byte b = byte_1[int_1];
			while (true)
			{
				int num = -1217736627;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -974201227)) % 6)
					{
					case 4u:
						num = ((byte_2 > b) ? (-1719776998) : (-1878150151)) ^ ((int)num2 * -198098087);
						continue;
					case 3u:
						byte_0 = (byte)(byte_0 | (byte_2 << int_0));
						num = (int)((num2 * 189092499) ^ 0x46D36231);
						continue;
					case 2u:
						byte_0 = (byte)(byte_0 & ~(b << int_0));
						num = -396937012;
						continue;
					default:
						return;
					case 0u:
						break;
					case 1u:
						throw new ArgumentOutOfRangeException();
					case 5u:
						return;
					}
					break;
				}
			}
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
		while (true)
		{
			int num = -1801068041;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2124770681)) % 3)
				{
				case 2u:
					goto IL_0017;
				case 0u:
					break;
				default:
				{
					U result = (U)Marshal.PtrToStructure(intPtr, typeof(U));
					Marshal.FreeHGlobal(intPtr);
					return result;
				}
				}
				break;
				IL_0017:
				Marshal.StructureToPtr((object)gparam_0, intPtr, false);
				num = (int)(num2 * 457157488) ^ -400236183;
			}
		}
	}

	public AsmJitOperand()
	{
		Struct8 struct8_ = default(Struct8);
		while (true)
		{
			int num = -1485077065;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -227471119)) % 4)
				{
				case 3u:
					struct8_ = RecoveredRuntime.smethod_218(this);
					struct8_.uint_0 = AsmJitRuntime.uint_0;
					num = ((int)num2 * -1885681385) ^ -1653105623;
					continue;
				case 2u:
					method_1(new Struct7
					{
						uint_0 = new uint[4],
						intptr_0 = new IntPtr[2]
					});
					num = (int)((num2 * 1783438672) ^ 0x52E232A2);
					continue;
				case 0u:
					break;
				default:
					RecoveredRuntime.smethod_279(this, struct8_);
					return;
				}
				break;
			}
		}
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
			goto IL_000d;
		}
		goto IL_00a3;
		IL_000d:
		int num = -181055998;
		goto IL_0072;
		IL_0072:
		Struct8 @struct = default(Struct8);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2145577002)) % 8)
			{
			case 5u:
				break;
			case 3u:
				goto IL_0014;
			case 2u:
				num = ((RecoveredRuntime.smethod_218(@class).enum8_0 == @struct.enum8_0) ? (-1234531591) : (-860608492)) ^ (int)(num2 * 1807140430);
				continue;
			case 0u:
				goto IL_00a3;
			default:
				return @struct.uint_0 == RecoveredRuntime.smethod_218(@class).uint_0;
			case 4u:
				return false;
			case 6u:
				return false;
			case 7u:
				return false;
			}
			break;
			IL_0014:
			num = ((RecoveredRuntime.smethod_218(@class).byte_0 == @struct.byte_0) ? (-1273019657) : (-1860768839));
		}
		goto IL_000d;
		IL_00a3:
		@struct = RecoveredRuntime.smethod_218(this);
		num = -11293284;
		goto IL_0072;
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
