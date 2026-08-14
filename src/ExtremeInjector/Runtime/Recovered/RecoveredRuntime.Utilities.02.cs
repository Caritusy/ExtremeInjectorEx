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

	internal static uint smethod_33(IEnumerable<PeScrambler.Class132> ienumerable_0, uint uint_0)
	{
		foreach (PeScrambler.Class132 @class in ienumerable_0.Skip(1))
		{
			if (uint_0 >= @class.method_5().method_4() && uint_0 < @class.method_5().method_4() + @class.method_5().method_2())
			{
				uint num = uint_0 - @class.method_5().method_4();
				return @class.method_3().method_4() + num + @class.method_0();
			}
		}
		return uint_0;
	}

	internal static bool smethod_34(string string_0)
	{
		IntPtr intptr_;
		if (!RecoveredRuntime.OpenProcessToken(RecoveredRuntime.GetCurrentProcess_1(), 40u, out intptr_))
		{
			return false;
		}
		TokenPrivilegeNativeTypes.Struct35 struct35_;
		if (RecoveredRuntime.LookupPrivilegeValue(null, string_0, out struct35_))
		{
			TokenPrivilegeNativeTypes.Struct34 @struct = default(TokenPrivilegeNativeTypes.Struct34);
			@struct.uint_0 = 1u;
			@struct.struct35_0 = struct35_;
			@struct.uint_1 = 2u;
			TokenPrivilegeNativeTypes.Struct34 struct2 = @struct;
			bool result = RecoveredRuntime.AdjustTokenPrivileges(intptr_, false, ref struct2, 0u, IntPtr.Zero, IntPtr.Zero);
			RecoveredRuntime.CloseHandle(intptr_);
			return result;
		}
		RecoveredRuntime.CloseHandle(intptr_);
		return false;
	}

	internal unsafe static int smethod_35(byte[] byte_0, string string_0, string string_1, int int_0)
	{
		return IndexOfMaskedByteString(byte_0, string_0, string_1, int_0);
}

	internal static void smethod_38(List<PeScrambler.Class132> list_0, PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_14() == null)
		{
			return;
		}
		gclass4_0.class154_0.method_28().Position = RecoveredRuntime.smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_14().method_11());
		BinaryReader binaryReader = new BinaryReader(gclass4_0.class154_0.method_28());
		BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.method_28());
		int num = 0;
		while ((long)num < (long)((ulong)gclass4_0.class154_0.method_14().method_7()))
		{
			uint uint_ = binaryReader.ReadUInt32();
			gclass4_0.class154_0.method_28().Position -= 4L;
			binaryWriter.Write(RecoveredRuntime.smethod_33(list_0, uint_));
			num++;
		}
		gclass4_0.class154_0.method_28().Position = RecoveredRuntime.smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_14().method_13());
		int num2 = 0;
		while ((long)num2 < (long)((ulong)gclass4_0.class154_0.method_14().method_9()))
		{
			uint uint_2 = binaryReader.ReadUInt32();
			gclass4_0.class154_0.method_28().Position -= 4L;
			binaryWriter.Write(RecoveredRuntime.smethod_33(list_0, uint_2));
			num2++;
		}
		gclass4_0.class154_0.method_28().Position = RecoveredRuntime.smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_6().method_3().imethod_49()[0].method_0()) + 28L;
		binaryWriter.Write(RecoveredRuntime.smethod_33(list_0, gclass4_0.class154_0.method_14().method_11()));
		binaryWriter.Write(RecoveredRuntime.smethod_33(list_0, gclass4_0.class154_0.method_14().method_13()));
		binaryWriter.Write(RecoveredRuntime.smethod_33(list_0, gclass4_0.class154_0.method_14().method_15()));
	}

	internal static bool smethod_40(int int_0, string string_0, byte[] byte_0, string string_1)
	{
		if (int_0 + string_0.Length > byte_0.Length)
		{
			return false;
		}
		for (int i = 0; i < string_0.Length; i++)
		{
			if ((char)byte_0[int_0 + i] != string_0[i] && string_1[i] != '?')
			{
				return false;
			}
		}
		return true;
	}

	internal static int smethod_44(DeflateDecoder.Stream1 stream1_0)
	{
		return smethod_438(stream1_0) | (smethod_438(stream1_0) << 16);
	}

	internal static void smethod_46(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_4().method_0() == 64u)
		{
			return;
		}
		int num = (int)(24 + gclass4_0.class154_0.method_6().method_1().method_10()) + gclass4_0.class154_0.method_8().Count * 40;
		byte[] buffer;
		using (Stream stream = RecoveredRuntime.smethod_264(gclass4_0.class154_0, (long)((ulong)gclass4_0.class154_0.method_4().method_0()), num))
		{
			using (BinaryReader binaryReader = new BinaryReader(stream))
			{
				buffer = binaryReader.ReadBytes(num);
			}
		}
		RecoveredRuntime.smethod_377(gclass4_0, 64L, (long)((ulong)(gclass4_0.class154_0.method_4().method_0() - 64u) + (ulong)((long)num)));
		gclass4_0.class154_0.method_28().Position = 64L;
		gclass4_0.binaryWriter_0.Write(buffer);
		gclass4_0.class154_0.method_4().method_1(64u);
	}

	internal static void smethod_56(List<PeScrambler.Class132> list_0, PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_23() == null)
		{
			return;
		}
		BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.method_28());
		BinaryReader binaryReader = new BinaryReader(gclass4_0.class154_0.method_28());
		long num = RecoveredRuntime.smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_6().method_3().imethod_49()[2].method_0());
		foreach (ResourceDirectoryNode @class in RecoveredRuntime.smethod_9(gclass4_0.class154_0.method_23().method_0()))
		{
			gclass4_0.class154_0.method_28().Position = num + @class.long_0;
			gclass4_0.class154_0.method_28().Position += 12L;
			ushort num2 = binaryReader.ReadUInt16();
			ushort num3 = binaryReader.ReadUInt16();
			long position = gclass4_0.class154_0.method_28().Position;
			for (int i = 0; i < (int)(num2 + num3); i++)
			{
				gclass4_0.class154_0.method_28().Position = position + (long)(i * 8);
				gclass4_0.class154_0.method_28().Position += 4L;
				uint num4 = binaryReader.ReadUInt32();
				if ((num4 & 2147483648u) == 0u)
				{
					gclass4_0.class154_0.method_28().Position = num + (long)((ulong)num4);
					uint uint_ = binaryReader.ReadUInt32();
					gclass4_0.class154_0.method_28().Position -= 4L;
					BinaryWriter binaryWriter2 = binaryWriter;
					uint value;
					@class.method_4()[i].method_5(value = RecoveredRuntime.smethod_33(list_0, uint_));
					binaryWriter2.Write(value);
				}
			}
		}
	}

	internal static void smethod_58(PeScrambler gclass4_0, Stream stream_0)
	{
		smethod_315(stream_0, gclass4_0.class154_0);
	}

	internal static int smethod_60(DeflateDecoder.Class181 class181_0, int int_0)
	{
		if (class181_0.int_2 < int_0)
		{
			if (class181_0.int_0 == class181_0.int_1)
			{
				return -1;
			}
			class181_0.uint_0 |= (uint)((uint)((int)(class181_0.byte_0[class181_0.int_0++] & byte.MaxValue) | (int)(class181_0.byte_0[class181_0.int_0++] & byte.MaxValue) << 8) << class181_0.int_2);
			class181_0.int_2 += 16;
		}
		return (int)((ulong)class181_0.uint_0 & (ulong)((long)((1 << int_0) - 1)));
	}

	internal static DeflateDecoder.Class183 smethod_62(DeflateDecoder.Class184 class184_0)
	{
		byte[] array = new byte[class184_0.int_4];
		Array.Copy(class184_0.byte_1, class184_0.int_3, array, 0, class184_0.int_4);
		return new DeflateDecoder.Class183(array);
	}

	internal static DeflateDecoder.Class183 smethod_63(DeflateDecoder.Class184 class184_0)
	{
		byte[] array = new byte[class184_0.int_3];
		Array.Copy(class184_0.byte_1, 0, array, 0, class184_0.int_3);
		return new DeflateDecoder.Class183(array);
	}

	internal static int smethod_65(DeflateDecoder.Class181 class181_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class181_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class181_0.uint_0;
			class181_0.uint_0 >>= 8;
			class181_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 != 0)
		{
			int num2 = class181_0.int_1 - class181_0.int_0;
			if (int_1 > num2)
			{
				int_1 = num2;
			}
			Array.Copy(class181_0.byte_0, class181_0.int_0, byte_0, int_0, int_1);
			class181_0.int_0 += int_1;
			if ((class181_0.int_0 - class181_0.int_1 & 1) != 0)
			{
				class181_0.uint_0 = (uint)(class181_0.byte_0[class181_0.int_0++] & byte.MaxValue);
				class181_0.int_2 = 8;
			}
			return num + int_1;
		}
		return num;
	}

	internal static bool smethod_69()
	{
		if (!PlatformInfo.bool_1)
		{
			return false;
		}
		IntPtr intptr_;
		if (!RecoveredRuntime.OpenProcessToken(RecoveredRuntime.GetCurrentProcess_1(), 8u, out intptr_))
		{
			return false;
		}
		uint num;
		uint num2;
		if (RecoveredRuntime.GetTokenInformation(intptr_, TokenPrivilegeNativeTypes.Enum16.const_17, out num, 4u, out num2))
		{
			RecoveredRuntime.CloseHandle(intptr_);
			TokenPrivilegeNativeTypes.Enum17 @enum = (TokenPrivilegeNativeTypes.Enum17)num;
			return @enum == TokenPrivilegeNativeTypes.Enum17.const_1 || @enum == TokenPrivilegeNativeTypes.Enum17.const_2;
		}
		RecoveredRuntime.CloseHandle(intptr_);
		return false;
	}

	internal static void smethod_77(DeflateDecoder.Class182 class182_0, int int_0)
	{
		int num = class182_0.int_1++;
		if (num != 32768)
		{
			class182_0.byte_0[class182_0.int_0++] = (byte)int_0;
			class182_0.int_0 &= 32767;
			return;
		}
		throw new InvalidOperationException();
	}

	internal static void smethod_78(byte[] byte_0, PeScrambler gclass4_0)
	{
		BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.method_28());
		long num = 0L;
		while ((num = RecoveredRuntime.smethod_1(gclass4_0, byte_0, num)) != -1L)
		{
			gclass4_0.class154_0.method_28().Position = num;
			for (int i = 0; i < byte_0.Length; i++)
			{
				binaryWriter.Write(0);
			}
			num += 1L;
		}
	}

	internal static bool smethod_85(ExportedSymbol class152_0)
	{
		return class152_0.method_8() != null;
	}

	internal static void smethod_86(RemotePeb class117_0, IntPtr intptr_0)
	{
		class117_0.method_18(intptr_0);
	}

	internal static bool smethod_89(ResourceIdentifier class137_0)
	{
		return !smethod_387(class137_0);
	}

	internal static void smethod_93(IEnumerable<PeScrambler.Class132> ienumerable_0, PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_18() != null)
		{
			BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.method_28());
			gclass4_0.class154_0.method_28().Position = smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_6().method_3().imethod_49()[6].method_0()) + 20L;
			uint value;
			gclass4_0.class154_0.method_18().method_8(value = smethod_33(ienumerable_0, gclass4_0.class154_0.method_18().method_7()));
			binaryWriter.Write(value);
			gclass4_0.class154_0.method_18().method_10(value = (uint)smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_18().method_9()));
			binaryWriter.Write(value);
		}
	}

	internal static void smethod_95(PeScrambler gclass4_0)
	{
		gclass4_0.class154_0.method_6().method_3().imethod_33(0u);
		if (gclass4_0.class131_0.method_12())
		{
			RecoveredRuntime.smethod_46(gclass4_0);
		}
		if (gclass4_0.class131_0.method_0())
		{
			RecoveredRuntime.smethod_382(gclass4_0);
		}
		if (gclass4_0.class131_0.method_10())
		{
			gclass4_0.method_3();
		}
		if (gclass4_0.class131_0.method_4() || (gclass4_0.class131_0.method_2() && gclass4_0.class131_0.method_6()))
		{
			RecoveredRuntime.smethod_415(gclass4_0);
		}
		if (gclass4_0.class131_0.method_16())
		{
			gclass4_0.method_1();
		}
		if (gclass4_0.class131_0.method_23())
		{
			RecoveredRuntime.smethod_208(gclass4_0);
		}
		if (gclass4_0.class131_0.method_2())
		{
			gclass4_0.method_4();
		}
		if (gclass4_0.class131_0.method_8())
		{
			gclass4_0.method_2();
		}
		if (gclass4_0.class131_0.method_18())
		{
			RecoveredRuntime.smethod_0(gclass4_0);
		}
		if (gclass4_0.class131_0.method_23())
		{
			RecoveredRuntime.smethod_376(gclass4_0);
		}
		if (gclass4_0.class131_0.method_25())
		{
			gclass4_0.method_0();
		}
	}

	internal static int smethod_96(DeflateDecoder.Class183 class183_0, DeflateDecoder.Class181 class181_0)
	{
		int num;
		if ((num = RecoveredRuntime.smethod_60(class181_0, 9)) >= 0)
		{
			int num2;
			if ((num2 = (int)class183_0.short_0[num]) >= 0)
			{
				RecoveredRuntime.smethod_396(class181_0, num2 & 15);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 15;
			if ((num = RecoveredRuntime.smethod_60(class181_0, int_)) >= 0)
			{
				num2 = (int)class183_0.short_0[num3 | num >> 9];
				RecoveredRuntime.smethod_396(class181_0, num2 & 15);
				return num2 >> 4;
			}
			int int_2 = class181_0.int_2;
			num = RecoveredRuntime.smethod_60(class181_0, int_2);
			num2 = (int)class183_0.short_0[num3 | num >> 9];
			if ((num2 & 15) <= int_2)
			{
				RecoveredRuntime.smethod_396(class181_0, num2 & 15);
				return num2 >> 4;
			}
			return -1;
		}
		else
		{
			int int_3 = class181_0.int_2;
			num = RecoveredRuntime.smethod_60(class181_0, int_3);
			int num2 = (int)class183_0.short_0[num];
			if (num2 < 0 || (num2 & 15) > int_3)
			{
				return -1;
			}
			RecoveredRuntime.smethod_396(class181_0, num2 & 15);
			return num2 >> 4;
		}
	}

	internal static byte[] smethod_99()
	{
		return (byte[])smethod_124().GetObject("BeaEnginex64", EmbeddedResources.cultureInfo_0);
	}

	internal static void smethod_101(long long_0, ResourceDirectory class166_0, ResourceDirectoryNode class138_0)
	{
		class138_0.method_5(new List<ResourceDataEntry>());
		class138_0.method_7(new List<ResourceDirectoryNode>());
		class138_0.class166_0 = class166_0;
		class138_0.long_0 = long_0;
		smethod_414(class138_0);
	}

	internal static bool smethod_106(DeflateDecoder.Class181 class181_0)
	{
		return class181_0.int_0 == class181_0.int_1;
	}

	internal static void smethod_107(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_6().method_3().imethod_49()[14].method_0() == 0u || gclass4_0.class154_0.method_6().method_3().imethod_49()[14].method_2() <= 0u)
		{
			return;
		}
		long num = RecoveredRuntime.smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_6().method_3().imethod_49()[14].method_0());
		if (num == -1L)
		{
			return;
		}
		BinaryReader binaryReader = new BinaryReader(gclass4_0.class154_0.method_28());
		gclass4_0.class154_0.method_28().Position = num;
		if (binaryReader.ReadUInt32() == 72u)
		{
			gclass4_0.class154_0.method_28().Position += 12L;
			uint num2 = binaryReader.ReadUInt32();
			num2 &= 4294967294u;
			gclass4_0.class154_0.method_28().Position -= 4L;
			new BinaryWriter(gclass4_0.class154_0.method_28()).Write(num2);
			return;
		}
	}

	internal static int smethod_117(Type type_0)
	{
		int[] array;
		if (RemotePlatformStructure.dictionary_0.TryGetValue(type_0, out array) || RemotePlatformStructure.dictionary_1.TryGetValue(type_0, out array))
		{
			return array[array.Length - 1];
		}
		int count = RemotePlatformStructure.dictionary_0.Count;
		int count2 = RemotePlatformStructure.dictionary_1.Count;
		RuntimeHelpers.RunClassConstructor(type_0.TypeHandle);
		if (RemotePlatformStructure.dictionary_0.Count != count || RemotePlatformStructure.dictionary_1.Count != count2)
		{
			return RecoveredRuntime.smethod_117(type_0);
		}
		throw new InvalidOperationException(EncodedStringTable.smethod_0(13137) + type_0 + EncodedStringTable.smethod_0(3656));
	}

	internal static void smethod_119(RemoteListEntry class100_0)
	{
		RemoteListEntry @class = class100_0.method_07D3();
		RemoteListEntry class2 = class100_0.method_07D2();
		@class.vmethod_8(class100_0.vmethod_7());
		class2.vmethod_10(class100_0.vmethod_9());
	}

	internal static int smethod_123(byte[] byte_0, byte[] byte_1, int int_0)
	{
		if (int_0 + byte_1.Length > byte_0.Length)
		{
			return -1;
		}
		if (byte_0.Length - int_0 < 20000 || byte_1.Length < 5)
		{
			return RecoveredRuntime.smethod_152(byte_0, byte_1, int_0);
		}
		return RecoveredRuntime.smethod_12(byte_0, byte_1, int_0);
	}

	internal static int smethod_129(RemoteModuleManager class93_0, RemotePeb class117_0, IntPtr intptr_0)
	{
		RemoteLdrDataTableEntry @class = class117_0.method_0823().method_080D().method_07DF();
		while (@class != null && @class.method_07F1() != IntPtr.Zero)
		{
			if (!(@class.method_07F1() == intptr_0))
			{
				@class = @class.method_07EE().method_07DF();
			}
			else
			{
				if (PlatformInfo.bool_5)
				{
					return (int)@class.method_07F5().vmethod_7();
				}
				return (int)@class.method_07F2();
			}
		}
		return -1;
	}

	internal static int smethod_130(byte[] byte_0, int int_0, int int_1, DeflateDecoder.Class180 class180_0)
	{
		int num = 0;
		do
		{
			if (class180_0.int_4 != 11)
			{
				int num2 = RecoveredRuntime.smethod_265(int_0, class180_0.class182_0, int_1, byte_0);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (RecoveredRuntime.smethod_436(class180_0) || (class180_0.class182_0.int_1 > 0 && class180_0.int_4 != 11));
		return num;
	}

	internal static void smethod_132(DeflateDecoder.Class182 class182_0, int int_0, int int_1)
	{
		if ((class182_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = class182_0.int_0 - int_1 & 32767;
		int num2 = 32768 - int_0;
		if (num > num2 || class182_0.int_0 >= num2)
		{
			RecoveredRuntime.smethod_168(class182_0, num, int_0, int_1);
			return;
		}
		if (int_0 <= int_1)
		{
			Array.Copy(class182_0.byte_0, num, class182_0.byte_0, class182_0.int_0, int_0);
			class182_0.int_0 += int_0;
			return;
		}
		while (int_0-- > 0)
		{
			class182_0.byte_0[class182_0.int_0++] = class182_0.byte_0[num++];
		}
	}

	internal static bool smethod_133(RemoteModuleUnlinker class129_0, RemotePeb class117_0, IntPtr intptr_0)
	{
		RemoteLdrDataTableEntry @class = class117_0.method_0823().method_080D().method_07DF();
		while (@class != null && @class.method_07F1() != IntPtr.Zero)
		{
			if (@class.method_07F1() == intptr_0)
			{
				RecoveredRuntime.smethod_119(@class.method_07F0());
				RecoveredRuntime.smethod_119(@class.method_07EE());
				RecoveredRuntime.smethod_119(@class.method_07EF());
				RecoveredRuntime.smethod_119(@class.method_07F3());
				return true;
			}
			@class = @class.method_07EE().method_07DF();
		}
		return false;
	}

	internal static object smethod_138(ExportParameter class17_0)
	{
		if (class17_0.Type == ExportParameterType.AnsiString || class17_0.Type == ExportParameterType.UnicodeString)
		{
			return class17_0.Value;
		}
		if (class17_0.Type == ExportParameterType.Single)
		{
			return float.Parse(class17_0.Value);
		}
		char c;
		if (class17_0.Type != ExportParameterType.Byte || !char.TryParse(class17_0.Value, out c))
		{
			try
			{
				object obj = new Int64Converter().ConvertFromString(class17_0.Value);
				if (obj != null)
				{
					return (long)obj;
				}
			}
			catch
			{
			}
			return null;
		}
		return (long)((ulong)c);
	}

	internal static void smethod_141(DeflateDecoder.Class181 class181_0)
	{
		class181_0.uint_0 >>= class181_0.int_2 & 7;
		class181_0.int_2 &= -8;
	}

	internal static void smethod_143(byte[] byte_0, byte[] byte_1, PeScrambler gclass4_0)
	{
		BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.method_28());
		long num = 0L;
		while ((num = RecoveredRuntime.smethod_1(gclass4_0, byte_1, num)) != -1L)
		{
			gclass4_0.class154_0.method_28().Position = num;
			binaryWriter.Write(byte_0);
			num += 1L;
		}
	}

	internal static byte[] smethod_144(ResourceDirectory class166_0, int int_0)
	{
		return class166_0.class5_0.ReadBytes(int_0);
	}

	internal static string CreateUniqueTemporaryPath(string extension)
	{
		string temporaryDirectory = Path.GetTempPath();
		while (true)
		{
			string fileName = Guid.NewGuid()
				.ToString("N")
				.Substring(0, PlatformInfo.random_0.Next(5, 10)) + extension;
			string candidatePath = Path.Combine(temporaryDirectory, fileName);
			if (!File.Exists(candidatePath))
			{
				return candidatePath;
			}
		}
	}

	internal unsafe static int smethod_152(byte[] byte_0, byte[] byte_1, int int_0)
	{
		return IndexOfBytes(byte_0, byte_1, int_0);
}

	internal static void smethod_157(BoundsCheckedBinaryReader class5_0, long long_0)
	{
		class5_0.BaseStream.Position = long_0;
	}

	internal static InvertedFunctionTableEntry32[] smethod_165(InvertedFunctionTable32 class112_0)
	{
		InvertedFunctionTableEntry32[] array = new InvertedFunctionTableEntry32[RecoveredRuntime.smethod_277(class112_0)];
		IntPtr intptr_ = RecoveredRuntime.smethod_223(class112_0, 3);
		int num = RecoveredRuntime.smethod_362(typeof(InvertedFunctionTableEntry32));
		int num2 = 0;
		while ((long)num2 < (long)((ulong)RecoveredRuntime.smethod_366(class112_0)))
		{
			InvertedFunctionTableEntry32[] array2 = array;
			int num3 = num2;
			InvertedFunctionTableEntry32 @class = new InvertedFunctionTableEntry32(intptr_.smethod_8(num2 * num), class112_0.method_2());
			@class.method_7(class112_0.method_6());
			array2[num3] = @class;
			num2++;
		}
		return array;
	}

	internal static byte smethod_166()
	{
		byte b;
		for (;;)
		{
			b = PlatformInfo.random_0.smethod_3();
			if (b >= 64)
			{
				if (b <= 97)
				{
					continue;
				}
			}
			if (b > 144)
			{
				if (b < 152)
				{
					continue;
				}
			}
			if (b != 38 && b != 39 && b != 46 && b != 47 && b != 54 && b != 55 && b != 62 && b != 63)
			{
				if (b >= 100)
				{
					if (b <= 103)
					{
						continue;
					}
				}
				if (b != 195)
				{
					if (b >= 201)
					{
						if (b <= 204)
						{
							continue;
						}
					}
					if (b != 206 && b != 207 && b != 214 && b != 215)
					{
						if (b >= 240)
						{
							if (b <= 245)
							{
								continue;
							}
						}
						if (b < 248)
						{
							break;
						}
						if (b > 253)
						{
							break;
						}
					}
				}
			}
		}
		return b;
	}

	internal static void smethod_168(DeflateDecoder.Class182 class182_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class182_0.byte_0[class182_0.int_0++] = class182_0.byte_0[int_0++];
			class182_0.int_0 &= 32767;
			int_0 &= 32767;
		}
	}

	internal static int smethod_170(DeflateDecoder.Class182 class182_0, DeflateDecoder.Class181 class181_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class182_0.int_1), RecoveredRuntime.smethod_401(class181_0));
		int num = 32768 - class182_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = RecoveredRuntime.smethod_65(class181_0, class182_0.byte_0, class182_0.int_0, num);
			if (num2 == num)
			{
				num2 += RecoveredRuntime.smethod_65(class181_0, class182_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = RecoveredRuntime.smethod_65(class181_0, class182_0.byte_0, class182_0.int_0, int_0);
		}
		class182_0.int_0 = (class182_0.int_0 + num2 & 32767);
		class182_0.int_1 += num2;
		return num2;
	}

	internal static IntPtr smethod_175(RemoteMemoryAccessor class82_0, long long_0, NativeTypes.Enum34 enum34_0)
	{
		return class82_0.method_15(IntPtr.Zero, long_0, enum34_0);
	}

	internal static bool smethod_176(ResourceDirectory class166_0, int int_0)
	{
		return smethod_282(class166_0, (int)(class166_0.class5_0.BaseStream.Position - class166_0.long_0), int_0);
	}

	internal static byte[] smethod_180()
	{
		return (byte[])smethod_124().GetObject("BeaEnginex86", EmbeddedResources.cultureInfo_0);
	}

	internal static string smethod_182(ThreadPriorityLevel threadPriorityLevel_0)
	{
		string text = threadPriorityLevel_0.ToString();
		int length = text.Length;
		for (int i = 1; i < length; i++)
		{
			if (char.IsUpper(text[i]))
			{
				text = text.Insert(i, EncodedStringTable.smethod_0(13584));
				break;
			}
		}
		return text;
	}

	internal static bool smethod_184(IntPtr intptr_0)
	{
		NativeTypes.Struct47 @struct;
		return RecoveredRuntime.VirtualQuery(intptr_0, out @struct, (uint)typeof(NativeTypes.Struct47).smethod_7()) != 0 && ((@struct.enum34_1 & NativeTypes.Enum34.flag_5) != (NativeTypes.Enum34)0u || (@struct.enum34_1 & NativeTypes.Enum34.flag_1) != (NativeTypes.Enum34)0u || (@struct.enum34_1 & NativeTypes.Enum34.flag_2) > (NativeTypes.Enum34)0u);
	}

	internal static void smethod_185(Encoding encoding_0, PeScrambler gclass4_0, string string_0)
	{
		smethod_78(encoding_0.GetBytes(string_0), gclass4_0);
	}

	internal static string smethod_186(IEnumerable<byte> ienumerable_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (byte b in ienumerable_0)
		{
			if (b == 0)
			{
				break;
			}
			stringBuilder.Append((char)b);
		}
		return stringBuilder.ToString();
	}

	internal static RemotePlatformStructure.RemoteFieldLayout smethod_187(Type type_0, int int_0)
	{
		return new RemotePlatformStructure.RemoteFieldLayout
		{
			int_0 = smethod_245(type_0) + int_0,
			bool_0 = true
		};
	}

	internal static RemotePlatformStructure.RemoteFieldLayout smethod_194(Type type_0, int int_0)
	{
		return new RemotePlatformStructure.RemoteFieldLayout
		{
			int_0 = smethod_245(type_0) * int_0
		};
	}

	internal static uint smethod_201(uint uint_0, uint uint_1)
	{
		if (uint_1 % uint_0 != 0)
		{
			return uint_1 + uint_0 - uint_1 % uint_0;
		}
		return uint_1;
	}

	internal static void smethod_202(BoundsCheckedBinaryReader class5_0, uint uint_0)
	{
		class5_0.BaseStream.Position = uint_0;
	}

	internal static void smethod_208(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_16() == null)
		{
			return;
		}
		int[] source = new int[]
		{
			0,
			1,
			2,
			3,
			5,
			6,
			9,
			10,
			12
		};
		int num = 0;
		while ((long)num < (long)((ulong)gclass4_0.class154_0.method_6().method_3().imethod_47()))
		{
			if (gclass4_0.class154_0.method_6().method_3().imethod_49()[num].method_0() != 0u && !source.Contains(num))
			{
				return;
			}
			num++;
		}
		List<PeScrambler.Class132> list = gclass4_0.method_6();
		RecoveredRuntime.smethod_38(list, gclass4_0);
		gclass4_0.method_7(list);
		RecoveredRuntime.smethod_56(list, gclass4_0);
		gclass4_0.method_8(list);
		gclass4_0.method_9(list);
		RecoveredRuntime.smethod_93(list, gclass4_0);
		RecoveredRuntime.smethod_420(list, gclass4_0);
	}

	internal static int smethod_210(DeflateDecoder.Class182 class182_0)
	{
		return class182_0.int_1;
	}

	internal static Win32Exception smethod_213(uint uint_0, RemoteCodeExecutorBase class84_0)
	{
		int num = RecoveredRuntime.RtlNtStatusToDosError(uint_0);
		if ((long)num == 317L)
		{
			return null;
		}
		Win32Exception ex = new Win32Exception(num);
		if (!ex.Message.StartsWith(EncodedStringTable.smethod_0(14279)))
		{
			return ex;
		}
		return null;
	}

	private static string PrepareModuleForInjection(string sourcePath, InjectionOptions options, ScramblePreset scramblePreset)
	{
		string workingPath = options.StealthInject
			? CreateUniqueTemporaryPath(".dll")
			: sourcePath;

		if (scramblePreset != ScramblePreset.None)
		{
			if (!options.StealthInject)
			{
				workingPath = GetAvailableScrambledModulePath(sourcePath);
			}

			ScrambleModule(sourcePath, workingPath);
		}
		else if (!string.Equals(sourcePath, workingPath, StringComparison.OrdinalIgnoreCase))
		{
			File.Copy(sourcePath, workingPath);
		}

		return workingPath;
	}

	private static string GetAvailableScrambledModulePath(string sourcePath)
	{
		string extension = Path.GetExtension(sourcePath);
		string basePath = Path.Combine(
			Path.GetDirectoryName(sourcePath),
			Path.GetFileNameWithoutExtension(sourcePath) + "_Scrambled");
		string preferredPath = basePath + extension;

		try
		{
			if (File.Exists(preferredPath))
			{
				File.Delete(preferredPath);
			}
			return preferredPath;
		}
		catch
		{
			for (int suffix = 1; ; suffix++)
			{
				string candidatePath = basePath + "_" + suffix + extension;
				if (!File.Exists(candidatePath))
				{
					return candidatePath;
				}
			}
		}
	}

	internal static IntPtr smethod_223(RemotePlatformStructure class96_0, int int_0)
	{
		return class96_0.method_17().smethod_8(class96_0.int_1[int_0]);
	}

	internal static long smethod_228(ResourceDirectoryNode class138_0)
	{
		return class138_0.long_0;
	}

	internal static int smethod_232(Type type_0)
	{
		int result;
		if (!PlatformInfo.dictionary_0.TryGetValue(type_0, out result))
		{
			PlatformInfo.dictionary_0.Add(type_0, result = RecoveredRuntime.smethod_18(type_0));
		}
		return result;
	}

	internal static bool smethod_235(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_6().method_3().imethod_49()[14].method_0() == 0u || gclass4_0.class154_0.method_6().method_3().imethod_49()[14].method_2() <= 0u)
		{
			return true;
		}
		long num = RecoveredRuntime.smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_6().method_3().imethod_49()[14].method_0());
		if (num == -1L)
		{
			return true;
		}
		BinaryReader binaryReader = new BinaryReader(gclass4_0.class154_0.method_28());
		gclass4_0.class154_0.method_28().Position = num;
		if (binaryReader.ReadUInt32() != 72u)
		{
			return true;
		}
		gclass4_0.class154_0.method_28().Position += 12L;
		return (binaryReader.ReadUInt32() & 2u) == 2u;
	}

	internal static string GetModulePath(MainForm.ModuleRow class21_0)
	{
		return class21_0.Entry.Path;
	}

	internal static int smethod_245(Type type_0)
	{
		if (!type_0.IsSubclassOf(typeof(RemotePlatformStructure)))
		{
			return smethod_232(type_0);
		}
		return smethod_117(type_0);
	}

	internal static void smethod_249(byte[] byte_0, DeflateDecoder.Class183 class183_0)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		foreach (int num in byte_0)
		{
			if (num > 0)
			{
				array[num]++;
			}
		}
		int num2 = 0;
		int num3 = 512;
		for (int j = 1; j <= 15; j++)
		{
			array2[j] = num2;
			num2 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num4 = array2[j] & 130944;
				int num5 = num2 & 130944;
				num3 += num5 - num4 >> 16 - j;
			}
		}
		class183_0.short_0 = new short[num3];
		int num6 = 512;
		for (int k = 15; k >= 10; k--)
		{
			int num7 = num2 & 130944;
			num2 -= array[k] << 16 - k;
			int num8 = num2 & 130944;
			for (int l = num8; l < num7; l += 128)
			{
				class183_0.short_0[(int)RecoveredRuntime.smethod_322(l)] = (short)(-num6 << 4 | k);
				num6 += 1 << k - 9;
			}
		}
		for (int m = 0; m < byte_0.Length; m++)
		{
			int num9 = (int)byte_0[m];
			if (num9 != 0)
			{
				num2 = array2[num9];
				int num10 = (int)RecoveredRuntime.smethod_322(num2);
				if (num9 > 9)
				{
					int num11 = (int)class183_0.short_0[num10 & 511];
					int num12 = 1 << (num11 & 15);
					num11 = -(num11 >> 4);
					do
					{
						class183_0.short_0[num11 | num10 >> 9] = (short)(m << 4 | num9);
						num10 += 1 << num9;
					}
					while (num10 < num12);
				}
				else
				{
					do
					{
						class183_0.short_0[num10] = (short)(m << 4 | num9);
						num10 += 1 << num9;
					}
					while (num10 < 512);
				}
				array2[num9] = num2 + (1 << 16 - num9);
			}
		}
	}
}
