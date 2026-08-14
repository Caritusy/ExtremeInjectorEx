using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

public static class NativeTypes
{
	[Flags]
	public enum SendMessageTimeoutFlags : uint
	{
		Normal = 0u,
		Block = 1u,
		AbortIfHung = 2u,
		NoTimeoutIfNotHung = 8u
	}

	public delegate bool WindowEnumerationCallback(IntPtr address, IntPtr address2);

	public struct NativeRect(int intValue, int intValue2, int intValue3, int intValue4)
	{
		public int Left = intValue;

		public int Top = intValue2;

		public int Right = intValue3;

		public int Bottom = intValue4;

		public NativeRect(Rectangle rectangle)
			: this(rectangle.Left, rectangle.Top, rectangle.Right, rectangle.Bottom)
		{
		}

		[SpecialName]
		public int GetHeight()
		{
			return Bottom - Top;
		}

		[SpecialName]
		public int GetWidth()
		{
			return Right - Left;
		}

		[SpecialName]
		public static Rectangle ToRectangle(NativeRect nativeRect)
		{
			return new Rectangle(nativeRect.Left, nativeRect.Top, nativeRect.GetWidth(), nativeRect.GetHeight());
		}

		public bool Equals(NativeRect nativeRect)
		{
			return nativeRect.Left == this.Left && nativeRect.Top == this.Top && nativeRect.Right == this.Right && nativeRect.Bottom == this.Bottom;
		}

		public override bool Equals(object obj)
		{
			if (obj is NativeTypes.NativeRect)
			{
				return this.Equals((NativeTypes.NativeRect)obj);
			}
			return obj is Rectangle && this.Equals(new NativeTypes.NativeRect((Rectangle)obj));
		}

		public override int GetHashCode()
		{
			return ToRectangle(this).GetHashCode();
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.CurrentCulture, "{{Left={0},Top={1},Right={2},Bottom={3}}}", Left, Top, Right, Bottom);
		}
	}

	public struct OsVersionInfoEx
	{
		public int intValue;

		public int intValue2;

		public int intValue3;

		public int intValue4;

		public int intValue5;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string text;

		public ushort ushortValue;

		public ushort ushortValue2;

		public ushort ushortValue3;

		public byte byteValue;

		public byte byteValue2;
	}

	public struct SystemProcessInformation
	{
		public uint uintValue;

		public uint uintValue2;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		internal long[] longValueArray;

		public long longValue;

		public long longValue2;

		public long longValue3;

		public UnicodeString unicodeString;

		public uint uintValue3;

		public IntPtr address;

		public IntPtr address2;

		public uint uintValue4;

		public uint uintValue5;

		public IntPtr address3;

		public VmCounters vmCounters;

		public IntPtr address4;

		public IoCounters ioCounters;
	}

	public struct SystemThreadInformation
	{
		public long longValue;

		public long longValue2;

		public long longValue3;

		public uint uintValue;

		public IntPtr address;

		public ClientId clientId;

		public uint uintValue2;

		public int intValue;

		public uint uintValue3;

		public uint uintValue4;

		public NativeThreadWaitReason nativeThreadWaitReason;
	}

	public struct IoCounters
	{
		public ulong ulongValue;

		public ulong ulongValue2;

		public ulong ulongValue3;

		public ulong ulongValue4;

		public ulong ulongValue5;

		public ulong ulongValue6;
	}

	public struct VmCounters
	{
		public IntPtr address;

		public IntPtr address2;

		public uint uintValue;

		public IntPtr address3;

		public IntPtr address4;

		public IntPtr address5;

		public IntPtr address6;

		public IntPtr address7;

		public IntPtr address8;

		public IntPtr address9;

		public IntPtr address10;
	}

	public struct UnicodeString
	{
		public ushort ushortValue;

		public ushort ushortValue2;

		public IntPtr address;

		public override string ToString()
		{
			return Marshal.PtrToStringUni(address, ushortValue / 2);
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ThreadEntry32
	{
		public uint uintValue;

		public uint uintValue2;

		public uint uintValue3;

		public uint uintValue4;

		public uint uintValue5;

		public uint uintValue6;

		public uint uintValue7;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ProcessBasicInformation
	{
		public IntPtr address;

		public IntPtr address2;

		public IntPtr address3;

		public IntPtr address4;

		public UIntPtr address5;

		public IntPtr address6;
	}

	public struct ModuleInformation
	{
		public IntPtr address;

		public uint uintValue;

		public IntPtr address2;
	}

	public struct MemoryBasicInformation
	{
		public IntPtr address;

		public IntPtr address2;

		public MemoryProtection memoryProtection;

		public IntPtr address3;

		public MemoryState memoryState;

		public MemoryProtection memoryProtection2;

		public MemoryType memoryType;
	}

	public struct ClientId
	{
		public IntPtr address;

		public IntPtr address2;
	}

	public struct ThreadBasicInformation
	{
		public uint uintValue;

		public IntPtr address;

		public ClientId clientId;

		public IntPtr address2;

		public uint uintValue2;

		public uint uintValue3;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
	public struct ActivationContext
	{
		public int intValue;

		public uint uintValue;

		public string text;

		public ushort ushortValue;

		public short shortValue;

		public string text2;

		public string text3;

		public string text4;

		public IntPtr address;
	}

	public struct ActivationContext32
	{
		public int intValue;

		public uint uintValue;

		public uint uintValue2;

		public ushort ushortValue;

		public short shortValue;

		public uint uintValue3;

		public uint uintValue4;

		public uint uintValue5;

		public uint uintValue6;
	}

	public struct ActivationContext64
	{
		public int intValue;

		public uint uintValue;

		public IntPtr address;

		public ushort ushortValue;

		public short shortValue;

		public IntPtr address2;

		public IntPtr address3;

		public IntPtr address4;

		public IntPtr address5;
	}

	public struct FloatingSaveArea
	{
		public uint uintValue;

		public uint uintValue2;

		public uint uintValue3;

		public uint uintValue4;

		public uint uintValue5;

		public uint uintValue6;

		public uint uintValue7;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] bytes;

		public uint uintValue8;
	}

	public struct Context32
	{
		public X86ContextFlags x86ContextFlags;

		public uint uintValue;

		public uint uintValue2;

		public uint uintValue3;

		public uint uintValue4;

		public uint uintValue5;

		public uint uintValue6;

		public FloatingSaveArea floatingSaveArea;

		public uint uintValue7;

		public uint uintValue8;

		public uint uintValue9;

		public uint uintValue10;

		public uint uintValue11;

		public uint uintValue12;

		public uint uintValue13;

		public uint uintValue14;

		public uint uintValue15;

		public uint uintValue16;

		public uint uintValue17;

		public uint uintValue18;

		public uint uintValue19;

		public uint uintValue20;

		public uint uintValue21;

		public uint uintValue22;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] bytes;
	}

	public struct Context64
	{
		public ulong ulongValue;

		public ulong ulongValue2;

		public ulong ulongValue3;

		public ulong ulongValue4;

		public ulong ulongValue5;

		public ulong ulongValue6;

		public X64ContextFlags x64ContextFlags;

		public uint uintValue;

		public ushort ushortValue;

		public ushort ushortValue2;

		public ushort ushortValue3;

		public ushort ushortValue4;

		public ushort ushortValue5;

		public ushort ushortValue6;

		public uint uintValue2;

		public ulong ulongValue7;

		public ulong ulongValue8;

		public ulong ulongValue9;

		public ulong ulongValue10;

		public ulong ulongValue11;

		public ulong ulongValue12;

		public ulong ulongValue13;

		public ulong ulongValue14;

		public ulong ulongValue15;

		public ulong ulongValue16;

		public ulong ulongValue17;

		public ulong ulongValue18;

		public ulong ulongValue19;

		public ulong ulongValue20;

		public ulong ulongValue21;

		public ulong ulongValue22;

		public ulong ulongValue23;

		public ulong ulongValue24;

		public ulong ulongValue25;

		public ulong ulongValue26;

		public ulong ulongValue27;

		public ulong ulongValue28;

		public ulong ulongValue29;

		public FloatingSaveAreaUnion floatingSaveAreaUnion;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
		public M128A[] m128AArray;

		public ulong ulongValue30;

		public ulong ulongValue31;

		public ulong ulongValue32;

		public ulong ulongValue33;

		public ulong ulongValue34;

		public ulong ulongValue35;
	}

	public struct M128A
	{
		public ulong ulongValue;

		public long longValue;
	}

	public struct XmmSaveArea32
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public M128A[] m128AArray;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public M128A[] m128AArray2;

		public M128A m128A;

		public M128A m128A2;

		public M128A m128A3;

		public M128A m128A4;

		public M128A m128A5;

		public M128A m128A6;

		public M128A m128A7;

		public M128A m128A8;

		public M128A m128A9;

		public M128A m128A10;

		public M128A m128A11;

		public M128A m128A12;

		public M128A m128A13;

		public M128A m128A14;

		public M128A m128A15;

		public M128A m128A16;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 96)]
		internal byte[] bytes;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct FloatingSaveAreaUnion
	{
		[FieldOffset(0)]
		public XmmSaveArea32 xmmSaveArea32;
	}

	[Flags]
	public enum X86ContextFlags : uint
	{
		Control = 0x10001u
	}

	[Flags]
	public enum X64ContextFlags : uint
	{
		Control = 0x100001u
	}

	public enum NativeThreadWaitReason : uint
	{
		Suspended = 5u
	}

	public enum SystemInformationClass
	{
		ProcessInformation = 5
	}

	public enum ThreadInformationClass
	{
		BasicInformation = 0,
		Win32StartAddress = 9,
		HideFromDebugger = 17
	}

	public enum ProcessInformationClass
	{
		BasicInformation = 0,
		Wow64Information = 26
	}

	[Flags]
	public enum SnapshotFlags : uint
	{
		Thread = 4u
	}

	public enum MemoryFreeType : uint
	{
		Decommit = 0x4000u,
		Release = 0x8000u
	}

	public enum MemoryState : uint
	{
	}

	public enum MemoryType : uint
	{
	}

	[Flags]
	public enum ThreadAccessRights : uint
	{
		Terminate = 1u,
		SuspendResume = 2u,
		GetContext = 8u,
		SetContext = 0x10u,
		QueryInformation = 0x40u
	}

	[Flags]
	public enum ProcessAccessRights : uint
	{
		Terminate = 1u,
		CreateThread = 2u,
		VirtualMemoryOperation = 8u,
		VirtualMemoryRead = 0x10u,
		VirtualMemoryWrite = 0x20u,
		QueryInformation = 0x400u,
		QueryLimitedInformation = 0x1000u,
		Synchronize = 0x100000u
	}

	[Flags]
	public enum MemoryAllocationType : uint
	{
		Commit = 0x1000u,
		Reserve = 0x2000u
	}

	[Flags]
	public enum MemoryProtection : uint
	{
		Execute = 0x10u,
		ExecuteRead = 0x20u,
		ExecuteReadWrite = 0x40u,
		ExecuteWriteCopy = 0x80u,
		NoAccess = 1u,
		ReadOnly = 2u,
		ReadWrite = 4u,
		WriteCopy = 8u,
		NoCache = 0x200u
	}

	public static readonly IntPtr address = (IntPtr)(-1);

	public static readonly int intValue = Marshal.SizeOf(typeof(MemoryBasicInformation));

	[DllImport("kernel32.dll")]
	[SuppressUnmanagedCodeSecurity]
	public static extern int VirtualQueryEx(IntPtr address2, IntPtr address3, out MemoryBasicInformation memoryBasicInformation, uint uintValue);
}
