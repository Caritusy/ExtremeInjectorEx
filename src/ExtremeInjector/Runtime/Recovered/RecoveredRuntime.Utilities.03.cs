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

	internal static void smethod_251(int int_0, byte[] byte_0, int int_1, DeflateDecoder.Class181 class181_0)
	{
		if (class181_0.int_0 < class181_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 > int_1 || int_1 > num || num > byte_0.Length)
		{
			throw new ArgumentOutOfRangeException();
		}
		if ((int_0 & 1) != 0)
		{
			class181_0.uint_0 |= (uint)((uint)(byte_0[int_1++] & byte.MaxValue) << class181_0.int_2);
			class181_0.int_2 += 8;
		}
		class181_0.byte_0 = byte_0;
		class181_0.int_0 = int_1;
		class181_0.int_1 = num;
	}

	internal static void smethod_254(FileDropMessageFilter class10_0, Message message_0)
	{
		StringBuilder stringBuilder = new StringBuilder(260);
		uint num = RecoveredRuntime.DragQueryFile(message_0.WParam, uint.MaxValue, stringBuilder, 0u);
		List<string> list = new List<string>();
		for (uint num2 = 0u; num2 <= num - 1u; num2 += 1u)
		{
			if (RecoveredRuntime.DragQueryFile(message_0.WParam, num2, stringBuilder, Convert.ToUInt32(stringBuilder.Capacity) * 2u) > 0u)
			{
				list.Add(stringBuilder.ToString());
			}
		}
		FileDropMessageFilter.Struct5 @struct;
		RecoveredRuntime.DragQueryPoint(message_0.WParam, out @struct);
		RecoveredRuntime.DragFinish(message_0.WParam);
		FileDropEventArgs eventArgs = new FileDropEventArgs();
		eventArgs.method_0(message_0.HWnd);
		eventArgs.method_2(list);
		eventArgs.method_3(@struct.int_0);
		eventArgs.method_4(@struct.int_1);
		FileDropEventArgs e = eventArgs;
		if (class10_0.eventHandler_0 != null)
		{
			class10_0.eventHandler_0(class10_0, e);
		}
	}

	internal static bool smethod_262(ResourceDirectory class166_0, long long_0)
	{
		if (!smethod_282(class166_0, long_0, 0))
		{
			return false;
		}
		class166_0.class5_0.BaseStream.Position = class166_0.long_0 + long_0;
		return true;
	}

	internal static int smethod_265(int int_0, DeflateDecoder.Class182 class182_0, int int_1, byte[] byte_0)
	{
		int num = class182_0.int_0;
		if (int_1 <= class182_0.int_1)
		{
			num = (class182_0.int_0 - class182_0.int_1 + int_1 & 32767);
		}
		else
		{
			int_1 = class182_0.int_1;
		}
		int num2 = int_1;
		int num3 = int_1 - num;
		if (num3 > 0)
		{
			Array.Copy(class182_0.byte_0, 32768 - num3, byte_0, int_0, num3);
			int_0 += num3;
			int_1 = num;
		}
		Array.Copy(class182_0.byte_0, num - int_1, byte_0, int_0, int_1);
		class182_0.int_1 -= num2;
		if (class182_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	internal static void smethod_267(Encoding encoding_0, PeScrambler gclass4_0, string string_0)
	{
		byte[] bytes = encoding_0.GetBytes(string_0);
		byte[] bytes2 = encoding_0.GetBytes(smethod_275(string_0.Length));
		smethod_143(bytes2, bytes, gclass4_0);
	}

	internal static string smethod_268()
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		if (RecoveredRuntime.GetWindowsDirectory(stringBuilder, stringBuilder.Capacity) != 0u)
		{
			return stringBuilder.ToString();
		}
		return Environment.GetEnvironmentVariable(EncodedStringTable.smethod_0(17892));
	}

	internal static IntPtr smethod_270(RemotePeb class117_0)
	{
		return class117_0.method_17();
	}

	internal static bool smethod_272()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	internal static string smethod_273(PeScrambler gclass4_0)
	{
		StringBuilder stringBuilder = new StringBuilder(EncodedStringTable.smethod_0(952));
		for (int i = 0; i < gclass4_0.random_0.Next(4, 8); i++)
		{
			stringBuilder.Append(EncodedStringTable.smethod_0(17901)[gclass4_0.random_0.Next(EncodedStringTable.smethod_0(17901).Length)]);
		}
		return stringBuilder.ToString();
	}

	internal static string smethod_275(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_0; i++)
		{
			char c = EncodedStringTable.smethod_0(17901)[PlatformInfo.random_0.Next(EncodedStringTable.smethod_0(17901).Length)];
			stringBuilder.Append((PlatformInfo.random_0.Next(2) == 1) ? c : char.ToUpper(c));
		}
		return stringBuilder.ToString();
	}

	internal static PlatformInfo.Delegate47 smethod_276(int int_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("Memcpy", typeof(void), new Type[3]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(uint)
		}, typeof(PlatformInfo));
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.Emit(OpCodes.Ldarg_2);
		if (int_0 != -1)
		{
			iLGenerator.Emit(OpCodes.Unaligned, (byte)int_0);
		}
		iLGenerator.Emit(OpCodes.Cpblk);
		iLGenerator.Emit(OpCodes.Ret);
		return (PlatformInfo.Delegate47)dynamicMethod.CreateDelegate(typeof(PlatformInfo.Delegate47));
	}

	internal static uint smethod_277(InvertedFunctionTable32 class112_0)
	{
		return class112_0.method_21<uint>(1);
	}

	internal static bool smethod_282(ResourceDirectory class166_0, long long_0, int int_0)
	{
		return long_0 >= 0L && long_0 + (long)int_0 >= long_0 && (uint)(long_0 + (long)int_0) <= class166_0.uint_0;
	}

	internal static bool smethod_295(int int_0, ushort ushort_0, int int_1, int int_2)
	{
		NativeTypes.Struct38 @struct;
		if (RecoveredRuntime.GetProcAddress(RecoveredRuntime.GetModuleHandle(EncodedStringTable.smethod_0(8549)), EncodedStringTable.smethod_0(19448)) != IntPtr.Zero)
		{
			@struct = default(NativeTypes.Struct38);
			@struct.int_0 = typeof(NativeTypes.Struct38).smethod_7();
			NativeTypes.Struct38 struct2 = @struct;
			if (RecoveredRuntime.RtlGetVersion(ref struct2) == 0u)
			{
				if (struct2.int_1 > int_1)
				{
					return true;
				}
				if (struct2.int_1 < int_1)
				{
					return false;
				}
				if (struct2.int_2 > int_0)
				{
					return true;
				}
				if (struct2.int_2 >= int_0)
				{
					if (int_2 != -1)
					{
						if (struct2.int_3 > int_2)
						{
							return true;
						}
						if (struct2.int_3 < int_2)
						{
							return false;
						}
					}
					return struct2.ushort_0 >= ushort_0;
				}
				return false;
			}
		}
		@struct = default(NativeTypes.Struct38);
		@struct.int_0 = typeof(NativeTypes.Struct38).smethod_7();
		NativeTypes.Struct38 struct3 = @struct;
		ulong ulong_ = RecoveredRuntime.VerSetConditionMask(RecoveredRuntime.VerSetConditionMask(RecoveredRuntime.VerSetConditionMask(0UL, 2u, 3), 1u, 3), 32u, 3);
		struct3.int_1 = int_1;
		struct3.int_2 = int_0;
		struct3.ushort_0 = ushort_0;
		if (int_2 != -1)
		{
			struct3.int_3 = int_2;
		}
		return RecoveredRuntime.VerifyVersionInfo(ref struct3, 35u, ulong_);
	}

	internal static void SetModulePath(MainForm.ModuleRow class21_0, string string_0)
	{
		class21_0.Entry.Path = string_0;
	}

	internal static bool smethod_305(DeflateDecoder.Class184 class184_0, DeflateDecoder.Class181 class181_0)
	{
		for (;;)
		{
			switch (class184_0.int_2)
			{
			case 0:
				class184_0.int_3 = RecoveredRuntime.smethod_60(class181_0, 5);
				if (class184_0.int_3 < 0)
				{
					return false;
				}
				class184_0.int_3 += 257;
				RecoveredRuntime.smethod_396(class181_0, 5);
				class184_0.int_2 = 1;
				continue;
			case 1:
				class184_0.int_4 = RecoveredRuntime.smethod_60(class181_0, 5);
				if (class184_0.int_4 < 0)
				{
					return false;
				}
				class184_0.int_4++;
				RecoveredRuntime.smethod_396(class181_0, 5);
				class184_0.int_6 = class184_0.int_3 + class184_0.int_4;
				class184_0.byte_1 = new byte[class184_0.int_6];
				class184_0.int_2 = 2;
				continue;
			case 2:
				class184_0.int_5 = RecoveredRuntime.smethod_60(class181_0, 4);
				if (class184_0.int_5 < 0)
				{
					return false;
				}
				class184_0.int_5 += 4;
				RecoveredRuntime.smethod_396(class181_0, 4);
				class184_0.byte_0 = new byte[19];
				class184_0.int_8 = 0;
				class184_0.int_2 = 3;
				continue;
			case 3:
				while (class184_0.int_8 < class184_0.int_5)
				{
					int codeLength = RecoveredRuntime.smethod_60(class181_0, 3);
					if (codeLength < 0)
					{
						return false;
					}
					RecoveredRuntime.smethod_396(class181_0, 3);
					class184_0.byte_0[DeflateDecoder.Class184.int_9[class184_0.int_8]] = (byte)codeLength;
					class184_0.int_8++;
				}
				class184_0.class183_0 = new DeflateDecoder.Class183(class184_0.byte_0);
				class184_0.byte_0 = null;
				class184_0.int_8 = 0;
				class184_0.int_2 = 4;
				continue;
			case 4:
				int symbol;
				while (((symbol = RecoveredRuntime.smethod_96(class184_0.class183_0, class181_0)) & -16) == 0)
				{
					if (class184_0.int_8 >= class184_0.int_6)
					{
						return false;
					}
					class184_0.byte_1[class184_0.int_8++] = (class184_0.byte_2 = (byte)symbol);
					if (class184_0.int_8 == class184_0.int_6)
					{
						return true;
					}
				}
				if (symbol < 16 || symbol > 18)
				{
					return false;
				}
				if (symbol >= 17)
				{
					class184_0.byte_2 = 0;
				}
				class184_0.int_7 = symbol - 16;
				class184_0.int_2 = 5;
				continue;
			case 5:
				int extraBitCount = DeflateDecoder.Class184.int_1[class184_0.int_7];
				int repeatCount = RecoveredRuntime.smethod_60(class181_0, extraBitCount);
				if (repeatCount < 0)
				{
					return false;
				}
				RecoveredRuntime.smethod_396(class181_0, extraBitCount);
				repeatCount += DeflateDecoder.Class184.int_0[class184_0.int_7];
				if (repeatCount > class184_0.int_6 - class184_0.int_8)
				{
					return false;
				}
				while (repeatCount-- > 0)
				{
					class184_0.byte_1[class184_0.int_8++] = class184_0.byte_2;
				}
				if (class184_0.int_8 == class184_0.int_6)
				{
					return true;
				}
				class184_0.int_2 = 4;
				continue;
			default:
				return false;
			}
		}
	}

	internal static uint smethod_314(ResourceDirectory class166_0)
	{
		return class166_0.class5_0.ReadUInt32();
	}

	internal static RemotePlatformStructure.RemoteFieldLayout smethod_316(Type type_0)
	{
		int int_ = smethod_245(type_0);
		return new RemotePlatformStructure.RemoteFieldLayout
		{
			int_0 = int_
		};
	}

	internal static string smethod_317()
	{
		string s = ApplicationSettings.DefaultPath;
		char[] array = Convert.ToBase64String(Encoding.UTF8.GetBytes(s)).ToCharArray();
		Array.Reverse(array);
		return new string(array);
	}

	internal static short smethod_322(int int_0)
	{
		return (short)((DeflateDecoder.Class185.byte_0[int_0 & 0xF] << 12) | (DeflateDecoder.Class185.byte_0[(int_0 >> 4) & 0xF] << 8) | (DeflateDecoder.Class185.byte_0[(int_0 >> 8) & 0xF] << 4) | DeflateDecoder.Class185.byte_0[int_0 >> 12]);
	}

	internal static IntPtr smethod_323(InvertedFunctionTableEntry32 class113_0)
	{
		return (IntPtr)class113_0.method_21<uint>(1);
	}

	internal static void smethod_339(CookieAwareWebClient class20_0, WebResponse webResponse_0)
	{
		HttpWebResponse httpWebResponse = webResponse_0 as HttpWebResponse;
		if (httpWebResponse == null)
		{
			return;
		}
		CookieCollection cookies = httpWebResponse.Cookies;
		class20_0.method_0().Add(cookies);
	}

	internal static bool smethod_340(string string_0, int int_0, byte[] byte_0)
	{
		if (int_0 + string_0.Length > byte_0.Length)
		{
			return false;
		}
		for (int i = 0; i < string_0.Length; i++)
		{
			if ((char)byte_0[int_0 + i] != string_0[i])
			{
				return false;
			}
		}
		return true;
	}

	internal static void smethod_341()
	{
		smethod_34("SeDebugPrivilege");
	}

	internal unsafe static int smethod_343(byte[] byte_0, string string_0, int int_0)
	{
		return IndexOfByteString(byte_0, string_0, int_0);
}

	internal static string smethod_345(string string_0, Exception exception_0, bool bool_0)
	{
		Type type = exception_0.GetType();
		string text = string_0;
		if (bool_0)
		{
			text += EncodedStringTable.smethod_0(24371);
		}
		text = text + type.FullName + EncodedStringTable.smethod_0(24376) + exception_0.Message;
		if (!text.EndsWith(EncodedStringTable.smethod_0(952)))
		{
			text += EncodedStringTable.smethod_0(952);
		}
		if (exception_0.InnerException != null)
		{
			return RecoveredRuntime.smethod_345(text + EncodedStringTable.smethod_0(24371), exception_0.InnerException, false);
		}
		return text;
	}

	internal static bool smethod_348(DeflateDecoder.Class180 class180_0)
	{
		int availableOutput = RecoveredRuntime.smethod_14(class180_0.class182_0);
		while (availableOutput >= 258)
		{
			switch (class180_0.int_4)
			{
			case 7:
				int symbol;
				while (((symbol = RecoveredRuntime.smethod_96(class180_0.class183_0, class180_0.class181_0)) & -256) == 0)
				{
					RecoveredRuntime.smethod_77(class180_0.class182_0, symbol);
					if (--availableOutput < 258)
					{
						return true;
					}
				}
				if (symbol < 0)
				{
					return false;
				}
				if (symbol < 257)
				{
					class180_0.class183_1 = null;
					class180_0.class183_0 = null;
					class180_0.int_4 = 2;
					return true;
				}
				int lengthIndex = symbol - 257;
				if (lengthIndex >= DeflateDecoder.Class180.int_0.Length)
				{
					return false;
				}
				class180_0.int_6 = DeflateDecoder.Class180.int_0[lengthIndex];
				class180_0.int_5 = DeflateDecoder.Class180.int_1[lengthIndex];
				class180_0.int_4 = 8;
				continue;
			case 8:
				if (class180_0.int_5 > 0)
				{
					int extraLength = RecoveredRuntime.smethod_60(class180_0.class181_0, class180_0.int_5);
					if (extraLength < 0)
					{
						return false;
					}
					RecoveredRuntime.smethod_396(class180_0.class181_0, class180_0.int_5);
					class180_0.int_6 += extraLength;
				}
				class180_0.int_4 = 9;
				continue;
			case 9:
				int distanceSymbol = RecoveredRuntime.smethod_96(class180_0.class183_1, class180_0.class181_0);
				if (distanceSymbol < 0 || distanceSymbol >= DeflateDecoder.Class180.int_2.Length)
				{
					return false;
				}
				class180_0.int_7 = DeflateDecoder.Class180.int_2[distanceSymbol];
				class180_0.int_5 = DeflateDecoder.Class180.int_3[distanceSymbol];
				class180_0.int_4 = 10;
				continue;
			case 10:
				if (class180_0.int_5 > 0)
				{
					int extraDistance = RecoveredRuntime.smethod_60(class180_0.class181_0, class180_0.int_5);
					if (extraDistance < 0)
					{
						return false;
					}
					RecoveredRuntime.smethod_396(class180_0.class181_0, class180_0.int_5);
					class180_0.int_7 += extraDistance;
				}
				RecoveredRuntime.smethod_132(class180_0.class182_0, class180_0.int_6, class180_0.int_7);
				availableOutput -= class180_0.int_6;
				class180_0.int_4 = 7;
				continue;
			default:
				return false;
			}
		}
		return true;
	}

	internal static void smethod_359()
	{
		try
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				WorkingSetTrimmer.gclass6_0 = new WorkingSetTrimmer();
			}
		}
		catch
		{
		}
	}

	internal unsafe static void smethod_361(long long_0, IntPtr intptr_0, byte byte_0)
	{
		byte* ptr = (byte*)((void*)intptr_0);
		byte* ptr2 = ptr + long_0;
		for (;;)
		{
			long num = (long)(ptr2 - ptr);
			if (num < 8L)
			{
				if (num < 4L)
				{
					if (num < 2L)
					{
						break;
					}
					*(short*)ptr = (short)byte_0;
					ptr += 2;
				}
				else
				{
					*(int*)ptr = (int)byte_0;
					ptr += 4;
				}
			}
			else
			{
				*(long*)ptr = (long)((ulong)byte_0);
				ptr += 8;
			}
		}
		*(ptr++) = byte_0;
	}

	internal static int smethod_362(Type type_0)
	{
		if (!type_0.IsSubclassOf(typeof(RemotePlatformStructure)))
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(25005));
		}
		if (RemotePlatformStructure.dictionary_0.ContainsKey(type_0))
		{
			return RemotePlatformStructure.dictionary_0[type_0].Last<int>();
		}
		if (RemotePlatformStructure.dictionary_1.ContainsKey(type_0))
		{
			return RemotePlatformStructure.dictionary_1[type_0].Last<int>();
		}
		int count = RemotePlatformStructure.dictionary_0.Count;
		int count2 = RemotePlatformStructure.dictionary_1.Count;
		RuntimeHelpers.RunClassConstructor(type_0.TypeHandle);
		if (RemotePlatformStructure.dictionary_0.Count == count && RemotePlatformStructure.dictionary_1.Count == count2)
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(13137) + type_0 + EncodedStringTable.smethod_0(3656));
		}
		return RecoveredRuntime.smethod_362(type_0);
	}

	internal static uint smethod_366(InvertedFunctionTable32 class112_0)
	{
		return class112_0.method_21<uint>(0);
	}

	internal static void smethod_367(string string_0, PeScrambler gclass4_0)
	{
		smethod_299(string_0, gclass4_0.class154_0);
	}

	internal static ushort smethod_370(ResourceDirectory class166_0)
	{
		return class166_0.class5_0.ReadUInt16();
	}

	internal unsafe static bool smethod_375(char* pChar_0, byte* pByte_0, char* pChar_1)
	{
		byte* ptr = (byte*)pChar_1;
		byte* ptr2 = (byte*)pChar_0;
		while (*ptr2 != 0)
		{
			if (*ptr2 == 120 && *pByte_0 != *ptr)
			{
				return false;
			}
			ptr2 += 2;
			pByte_0++;
			ptr += 2;
		}
		return *ptr2 == 0;
	}

	internal static void smethod_377(PeScrambler gclass4_0, long long_0, long long_1)
	{
		byte[] buffer = new byte[long_1];
		gclass4_0.class154_0.method_28().Position = long_0;
		gclass4_0.binaryWriter_0.Write(buffer);
	}

	internal static int smethod_378(byte[] byte_0, string string_0, int int_0)
	{
		if (int_0 + string_0.Length > byte_0.Length)
		{
			return -1;
		}
		if (byte_0.Length - int_0 < 20000 || string_0.Length < 5)
		{
			return RecoveredRuntime.smethod_343(byte_0, string_0, int_0);
		}
		int length = string_0.Length;
		byte[] array = new byte[length];
		for (int i = 0; i < length; i++)
		{
			array[i] = (byte)string_0[i];
		}
		return RecoveredRuntime.smethod_12(byte_0, array, int_0);
	}

	internal static bool smethod_387(ResourceIdentifier class137_0)
	{
		return class137_0.method_0() != null;
	}

	internal static void smethod_388(RemoteMemoryAccessor class82_0)
	{
		if (class82_0.method_6() != null)
		{
			class82_0.method_6().imethod_6(class82_0.method_2());
			return;
		}
		if (class82_0.method_2() != IntPtr.Zero)
		{
			RecoveredRuntime.CloseHandle(class82_0.method_2());
			class82_0.method_3(IntPtr.Zero);
		}
	}

	internal static void smethod_396(DeflateDecoder.Class181 class181_0, int int_0)
	{
		class181_0.uint_0 >>= int_0;
		class181_0.int_2 -= int_0;
	}

	internal static void smethod_400(IntPtr intptr_0, RemotePebLdrData class109_0)
	{
		class109_0.method_18(intptr_0);
	}

	internal static int smethod_401(DeflateDecoder.Class181 class181_0)
	{
		return class181_0.int_1 - class181_0.int_0 + (class181_0.int_2 >> 3);
	}

	internal static string smethod_404(BoundsCheckedBinaryReader class5_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string result;
		try
		{
			bool flag = true;
			while (flag)
			{
				byte[] array = class5_0.ReadBytes(16);
				for (int i = 0; i < 16; i++)
				{
					byte b = array[i];
					if (b == 0)
					{
						class5_0.BaseStream.Position -= (long)(15 - i);
						flag = false;
						break;
					}
					stringBuilder.Append((char)b);
				}
			}
			result = stringBuilder.ToString();
		}
		catch
		{
			result = stringBuilder.ToString();
		}
		return result;
	}

	internal static void smethod_414(ResourceDirectoryNode class138_0)
	{
		if (class138_0.long_0 < 0L)
		{
			return;
		}
		if (!RecoveredRuntime.smethod_282(class138_0.class166_0, class138_0.long_0, 16))
		{
			return;
		}
		if (!RecoveredRuntime.smethod_262(class138_0.class166_0, class138_0.long_0))
		{
			return;
		}
		class138_0.method_8(RecoveredRuntime.smethod_314(class138_0.class166_0));
		class138_0.method_9(RecoveredRuntime.smethod_314(class138_0.class166_0));
		class138_0.method_10(RecoveredRuntime.smethod_370(class138_0.class166_0));
		class138_0.method_11(RecoveredRuntime.smethod_370(class138_0.class166_0));
		int num = (int)RecoveredRuntime.smethod_370(class138_0.class166_0);
		int num2 = (int)RecoveredRuntime.smethod_370(class138_0.class166_0);
		int num3 = num + num2;
		if (RecoveredRuntime.smethod_176(class138_0.class166_0, num3 * 8))
		{
			long num4 = 0L;
			long num5 = class138_0.long_0 + 16L;
			while (num4 < (long)num3)
			{
				RecoveredRuntime.smethod_262(class138_0.class166_0, num5);
				uint num6 = RecoveredRuntime.smethod_314(class138_0.class166_0);
				uint num7 = RecoveredRuntime.smethod_314(class138_0.class166_0);
				string text = null;
				int int_ = -1;
				if ((num6 & 2147483648u) == 0u)
				{
					int_ = (int)num6;
				}
				else
				{
					text = RecoveredRuntime.smethod_90((int)(num6 & 2147483647u), class138_0.class166_0);
					if (text == null)
					{
						return;
					}
				}
				if ((num7 & 2147483648u) == 0u)
				{
					if (!RecoveredRuntime.smethod_262(class138_0.class166_0, (long)num7) || !RecoveredRuntime.smethod_176(class138_0.class166_0, 16))
					{
						break;
					}
					uint num8 = RecoveredRuntime.smethod_314(class138_0.class166_0);
					uint uint_ = RecoveredRuntime.smethod_314(class138_0.class166_0);
					if (num8 != 0u)
					{
						if (text == null)
						{
							class138_0.method_4().Add(new ResourceDataEntry(int_, num8, uint_));
						}
						else
						{
							class138_0.method_4().Add(new ResourceDataEntry(text, num8, uint_));
						}
					}
				}
				else
				{
					int num9 = (int)(num7 & 2147483647u);
					if (num9 != 0 && (long)num9 != class138_0.long_0)
					{
						if (text == null)
						{
							class138_0.method_6().Add(new ResourceDirectoryNode(int_, class138_0.class166_0, (long)num9));
						}
						else
						{
							class138_0.method_6().Add(new ResourceDirectoryNode(text, class138_0.class166_0, (long)num9));
						}
					}
				}
				num4 += 1L;
				num5 += 8L;
			}
			return;
		}
	}

	internal static int smethod_419(byte[] byte_0, string string_0, string string_1, int int_0)
	{
		if (int_0 >= byte_0.Length || string_0.Length != string_1.Length || int_0 + string_0.Length > byte_0.Length)
		{
			return -1;
		}
		if (byte_0.Length - int_0 < 4 || string_0.Length < 4)
		{
			return RecoveredRuntime.smethod_35(byte_0, string_0, string_1, int_0);
		}
		return RecoveredRuntime.smethod_17(int_0, string_0, string_1, byte_0);
	}

	internal static int smethod_422(DeflateDecoder.Class181 class181_0)
	{
		return class181_0.int_2;
	}

	internal static uint smethod_425(InvertedFunctionTableEntry32 class113_0)
	{
		return class113_0.method_21<uint>(3);
	}

	internal static string smethod_426()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = DynamicIlEmitter.random_0.Next(5, 30);
		for (int i = 0; i < num; i++)
		{
			stringBuilder.Append((DynamicIlEmitter.random_0.Next(2) == 1) ? char.ToUpper(EncodedStringTable.smethod_0(17901)[DynamicIlEmitter.random_0.Next(EncodedStringTable.smethod_0(17901).Length)]) : EncodedStringTable.smethod_0(17901)[DynamicIlEmitter.random_0.Next(EncodedStringTable.smethod_0(17901).Length)]);
		}
		return stringBuilder.ToString();
	}

	internal static string smethod_428(PeScrambler gclass4_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(EncodedStringTable.smethod_0(27891)[gclass4_0.random_0.Next(EncodedStringTable.smethod_0(27891).Length)]).Append(':');
		for (int i = 0; i < gclass4_0.random_0.Next(4, 8); i++)
		{
			stringBuilder.Append(EncodedStringTable.smethod_0(27928));
			for (int j = 0; j < gclass4_0.random_0.Next(4, 20); j++)
			{
				stringBuilder.Append(EncodedStringTable.smethod_0(17901)[gclass4_0.random_0.Next(EncodedStringTable.smethod_0(17901).Length)]);
			}
		}
		return stringBuilder.Append(EncodedStringTable.smethod_0(27933)).ToString();
	}

	internal static bool smethod_434(string string_0, string string_1)
	{
		return (string_0.StartsWith(EncodedStringTable.smethod_0(27942) + string_1, StringComparison.OrdinalIgnoreCase) || string_0.StartsWith(EncodedStringTable.smethod_0(27951) + string_1, StringComparison.OrdinalIgnoreCase)) && (string_0.EndsWith(EncodedStringTable.smethod_0(16146), StringComparison.OrdinalIgnoreCase) || string_0.EndsWith(EncodedStringTable.smethod_0(10075), StringComparison.OrdinalIgnoreCase));
	}

	internal static bool smethod_436(DeflateDecoder.Class180 class180_0)
	{
		switch (class180_0.int_4)
		{
		case 2:
			if (class180_0.bool_0)
			{
				class180_0.int_4 = 12;
				return false;
			}
			int blockHeader = RecoveredRuntime.smethod_60(class180_0.class181_0, 3);
			if (blockHeader < 0)
			{
				return false;
			}
			RecoveredRuntime.smethod_396(class180_0.class181_0, 3);
			if ((blockHeader & 1) != 0)
			{
				class180_0.bool_0 = true;
			}
			switch (blockHeader >> 1)
			{
			case 0:
				RecoveredRuntime.smethod_141(class180_0.class181_0);
				class180_0.int_4 = 3;
				break;
			case 1:
				class180_0.class183_0 = DeflateDecoder.Class183.class183_0;
				class180_0.class183_1 = DeflateDecoder.Class183.class183_1;
				class180_0.int_4 = 7;
				break;
			case 2:
				class180_0.class184_0 = new DeflateDecoder.Class184();
				class180_0.int_4 = 6;
				break;
			default:
				class180_0.int_4 = 11;
				return false;
			}
			return true;
		case 3:
			int storedLength = RecoveredRuntime.smethod_60(class180_0.class181_0, 16);
			if (storedLength < 0)
			{
				return false;
			}
			class180_0.int_8 = storedLength;
			RecoveredRuntime.smethod_396(class180_0.class181_0, 16);
			class180_0.int_4 = 4;
			break;
		case 4:
			break;
		case 5:
			return RecoveredRuntime.ContinueStoredDeflateBlock(class180_0);
		case 6:
			if (!RecoveredRuntime.smethod_305(class180_0.class184_0, class180_0.class181_0))
			{
				return false;
			}
			class180_0.class183_0 = RecoveredRuntime.smethod_63(class180_0.class184_0);
			class180_0.class183_1 = RecoveredRuntime.smethod_62(class180_0.class184_0);
			class180_0.int_4 = 7;
			return RecoveredRuntime.smethod_348(class180_0);
		case 7:
		case 8:
		case 9:
		case 10:
			return RecoveredRuntime.smethod_348(class180_0);
		default:
			return false;
		}

		int storedLengthComplement = RecoveredRuntime.smethod_60(class180_0.class181_0, 16);
		if (storedLengthComplement < 0)
		{
			return false;
		}
		RecoveredRuntime.smethod_396(class180_0.class181_0, 16);
		if ((class180_0.int_8 ^ 65535) != storedLengthComplement)
		{
			class180_0.int_4 = 11;
			return false;
		}
		class180_0.int_4 = 5;
		return RecoveredRuntime.ContinueStoredDeflateBlock(class180_0);
	}

	internal static bool ContinueStoredDeflateBlock(DeflateDecoder.Class180 decoder)
	{
		int copiedByteCount = RecoveredRuntime.smethod_170(decoder.class182_0, decoder.class181_0, decoder.int_8);
		decoder.int_8 -= copiedByteCount;
		if (decoder.int_8 != 0)
		{
			return !RecoveredRuntime.smethod_106(decoder.class181_0);
		}
		decoder.int_4 = 2;
		return true;
	}

	internal static void smethod_437(PeScrambler gclass4_0, long long_0, long long_1)
	{
		byte[] buffer = new byte[long_1];
		gclass4_0.random_0.NextBytes(buffer);
		gclass4_0.class154_0.method_28().Position = long_0;
		gclass4_0.binaryWriter_0.Write(buffer);
	}

	internal static int smethod_438(DeflateDecoder.Stream1 stream1_0)
	{
		return stream1_0.ReadByte() | (stream1_0.ReadByte() << 8);
	}

	internal static string smethod_440(string string_0, string string_1, string string_2, DependencySearchFlags enum43_0, int int_0, IntPtr intptr_0)
	{
		ApiSetSchema.Class170 @class = new ApiSetSchema.Class170();
		string_0 = string_0.ToLowerInvariant();
		string_1 = (string.IsNullOrEmpty(string_1) ? string.Empty : string_1.ToLowerInvariant());
		@class.string_0 = Path.GetFileName(string_0);
		if (!PlatformInfo.bool_7 && @class.string_0.StartsWith(EncodedStringTable.smethod_0(27960)))
		{
			@class.string_0 = @class.string_0.Substring(4);
		}
		KeyValuePair<string, List<string>> keyValuePair = ApiSetSchema.dictionary_0.FirstOrDefault(new Func<KeyValuePair<string, List<string>>, bool>(@class.method_0));
		if (string_1.Length > 0 && keyValuePair.Key != null && keyValuePair.Value != null && keyValuePair.Value.Count >= 1)
		{
			List<string> value = keyValuePair.Value;
			string_0 = ((value.First<string>() != string_1) ? value.First<string>() : value.Last<string>());
			if (RecoveredRuntime.smethod_136(ref string_0, intptr_0))
			{
				return string_0;
			}
			if ((enum43_0 & DependencySearchFlags.flag_2) == DependencySearchFlags.flag_0)
			{
				return string_0;
			}
			if ((enum43_0 & DependencySearchFlags.flag_4) != DependencySearchFlags.flag_0)
			{
				return Path.Combine(PlatformInfo.string_2, string_0);
			}
			return Path.Combine(PlatformInfo.string_1, string_0);
		}
		else
		{
			if ((enum43_0 & DependencySearchFlags.flag_1) != DependencySearchFlags.flag_0)
			{
				return null;
			}
			if (RecoveredRuntime.smethod_136(ref string_0, intptr_0))
			{
				return string_0;
			}
			if ((enum43_0 & DependencySearchFlags.flag_3) != DependencySearchFlags.flag_0)
			{
				return null;
			}
			if (Path.IsPathRooted(string_0) && File.Exists(string_0))
			{
				return string_0;
			}
			RegistryKey registryKey = null;
			try
			{
				registryKey = Registry.LocalMachine.OpenSubKey(EncodedStringTable.smethod_0(27973));
				if (registryKey != null)
				{
					foreach (string name in registryKey.GetValueNames())
					{
						string text = registryKey.GetValue(name) as string;
						if (text != null && text.Equals(@class.string_0, StringComparison.OrdinalIgnoreCase))
						{
							string text2 = registryKey.GetValue(((enum43_0 & DependencySearchFlags.flag_4) != DependencySearchFlags.flag_0) ? EncodedStringTable.smethod_0(28071) : EncodedStringTable.smethod_0(28054)) as string;
							if (text2 != null)
							{
								registryKey.Close();
								return Path.Combine(text2, text);
							}
						}
					}
					registryKey.Close();
				}
			}
			catch
			{
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			string text3;
			if (!string.IsNullOrEmpty(string_2))
			{
				text3 = Path.Combine(string_2, @class.string_0);
				if (File.Exists(text3))
				{
					return text3;
				}
			}
			if (int_0 != 0)
			{
				text3 = Path.Combine(Path.GetDirectoryName(RecoveredRuntime.smethod_47(int_0).FilePath), @class.string_0);
				if (File.Exists(text3))
				{
					return text3;
				}
			}
			text3 = Path.Combine(((enum43_0 & DependencySearchFlags.flag_4) != DependencySearchFlags.flag_0) ? PlatformInfo.string_2 : PlatformInfo.string_1, @class.string_0);
			if (File.Exists(text3))
			{
				return text3;
			}
			text3 = Path.Combine(PlatformInfo.string_0, @class.string_0);
			if (File.Exists(text3))
			{
				return text3;
			}
			text3 = Path.Combine(Environment.CurrentDirectory, @class.string_0);
			if (File.Exists(text3))
			{
				return text3;
			}
			string environmentVariable = Environment.GetEnvironmentVariable(EncodedStringTable.smethod_0(28092));
			if (environmentVariable != null)
			{
				foreach (string text4 in environmentVariable.Split(new char[]
				{
					';'
				}))
				{
					if ((enum43_0 & DependencySearchFlags.flag_4) == DependencySearchFlags.flag_0 || !text4.Equals(PlatformInfo.string_1, StringComparison.OrdinalIgnoreCase))
					{
						text3 = Path.Combine(text4, @class.string_0);
						if (File.Exists(text3))
						{
							return text3;
						}
					}
				}
			}
			return null;
		}
	}

	internal static string smethod_442(long long_0)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		RecoveredRuntime.StrFormatByteSize(long_0, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	internal static bool smethod_444(ref DosHeader class158_0, [Out] BoundsCheckedBinaryReader class5_0)
	{
		class158_0 = null;
		if (class5_0.BaseStream.Length < 128L)
		{
			return false;
		}
		class158_0 = new DosHeader();
		if (class5_0.ReadUInt16() == 23117)
		{
			RecoveredRuntime.smethod_217(class5_0, 58);
			class158_0.method_1(class5_0.ReadUInt32());
			return true;
		}
		return false;
	}

	internal static IntPtr smethod_445(IntPtr intptr_0, int int_0)
	{
		if (PlatformInfo.bool_0)
		{
			return GetClassLongPtr(intptr_0, int_0);
		}
		return (IntPtr)GetClassLong(intptr_0, int_0);
	}

	internal static BinaryReader smethod_447(Stream stream_0)
	{
		return new BinaryReader(stream_0);
	}

	internal static void smethod_448(Stream stream_0, long long_0)
	{
		stream_0.Position = long_0;
	}

	internal static uint smethod_449(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static long smethod_450(Stream stream_0)
	{
		return stream_0.Position;
	}

	internal static int smethod_451(Random random_0, int int_0)
	{
		return random_0.Next(int_0);
	}

	internal static void smethod_452(BinaryWriter binaryWriter_0, byte byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	internal static byte smethod_453(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadByte();
	}

	internal static void smethod_454(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static long smethod_455(Stream stream_0)
	{
		return stream_0.Length;
	}

	internal static byte[] smethod_456(BinaryReader binaryReader_0, int int_0)
	{
		return binaryReader_0.ReadBytes(int_0);
	}

	internal static Type smethod_457(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static string smethod_459(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	internal static TypeBuilder smethod_460(ModuleBuilder moduleBuilder_0, string string_0, TypeAttributes typeAttributes_0)
	{
		return moduleBuilder_0.DefineType(string_0, typeAttributes_0);
	}

	internal static int smethod_461(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	internal static MethodBuilder smethod_462(TypeBuilder typeBuilder_0, string string_0, MethodAttributes methodAttributes_0, Type type_0, Type[] type_1)
	{
		return typeBuilder_0.DefineMethod(string_0, methodAttributes_0, type_0, type_1);
	}

	internal static ILGenerator smethod_463(MethodBuilder methodBuilder_0)
	{
		return methodBuilder_0.GetILGenerator();
	}

	internal static bool smethod_464(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}

	internal static LocalBuilder smethod_465(ILGenerator ilgenerator_0, Type type_0)
	{
		return ilgenerator_0.DeclareLocal(type_0);
	}

	internal static void smethod_466(ILGenerator ilgenerator_0, OpCode opCode_0, LocalBuilder localBuilder_0)
	{
		ilgenerator_0.Emit(opCode_0, localBuilder_0);
	}

	internal static void smethod_467(ILGenerator ilgenerator_0, OpCode opCode_0, Type type_0)
	{
		ilgenerator_0.Emit(opCode_0, type_0);
	}

	internal static void smethod_468(ILGenerator ilgenerator_0, OpCode opCode_0)
	{
		ilgenerator_0.Emit(opCode_0);
	}

	internal static bool smethod_469(Type type_0, Type type_1)
	{
		return type_0 == type_1;
	}

	internal static FieldBuilder smethod_470(TypeBuilder typeBuilder_0, string string_0, Type type_0, FieldAttributes fieldAttributes_0)
	{
		return typeBuilder_0.DefineField(string_0, type_0, fieldAttributes_0);
	}

	internal static Stream smethod_471(BinaryReader binaryReader_0)
	{
		return binaryReader_0.BaseStream;
	}

	internal static ushort smethod_472(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt16();
	}

	internal static MemoryStream smethod_473()
	{
		return new MemoryStream();
	}

	internal static byte[] smethod_474(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	internal static bool smethod_478(WaitCallback waitCallback_0)
	{
		return ThreadPool.QueueUserWorkItem(waitCallback_0);
	}

	internal static int smethod_483()
	{
		return RuntimeHelpers.OffsetToStringData;
	}

	internal static int smethod_484(string string_0)
	{
		return string_0.Length;
	}

	internal static bool smethod_485(Type type_0, Type type_1)
	{
		return type_0.IsAssignableFrom(type_1);
	}

	internal static Type smethod_486(Type type_0)
	{
		return Enum.GetUnderlyingType(type_0);
	}

	internal static InvalidOperationException smethod_487(string string_0)
	{
		return new InvalidOperationException(string_0);
	}

	internal static GroupBox smethod_490()
	{
		return new ModernGroupBox();
	}

	internal static Button smethod_491()
	{
		return new Button();
	}

	internal static TextBox smethod_492()
	{
		return new TextBox();
	}

	internal static ComboBox smethod_493()
	{
		return new ComboBox();
	}

	internal static void smethod_498(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	internal static string smethod_505(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}

	internal static MissingMethodException smethod_511(string string_0)
	{
		return new MissingMethodException(string_0);
	}

	internal static string smethod_512()
	{
		return Path.GetTempFileName();
	}

	internal static void smethod_513(string string_0, byte[] byte_0)
	{
		File.WriteAllBytes(string_0, byte_0);
	}

	internal static void smethod_514(string string_0)
	{
		File.Delete(string_0);
	}

	internal static AccessViolationException smethod_515(string string_0)
	{
		return new AccessViolationException(string_0);
	}

	internal static Encoding smethod_516()
	{
		return Encoding.Unicode;
	}

	internal static string smethod_517(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	internal static byte[] smethod_518(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	internal static bool smethod_519(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	internal static FileStream smethod_520(string string_0, FileMode fileMode_0, FileAccess fileAccess_0, FileShare fileShare_0)
	{
		return new FileStream(string_0, fileMode_0, fileAccess_0, fileShare_0);
	}

	internal static MissingFieldException smethod_521(string string_0)
	{
		return new MissingFieldException(string_0);
	}

	internal static Encoding smethod_522()
	{
		return Encoding.ASCII;
	}

	internal static BinaryWriter smethod_523(Stream stream_0)
	{
		return new BinaryWriter(stream_0);
	}

	internal static void smethod_524(BinaryWriter binaryWriter_0, uint uint_0)
	{
		binaryWriter_0.Write(uint_0);
	}

	internal static char smethod_525(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	internal static void smethod_526(BinaryWriter binaryWriter_0, int int_0)
	{
		binaryWriter_0.Write(int_0);
	}

	internal static int smethod_527(Random random_0)
	{
		return random_0.Next();
	}

	internal static void smethod_528(BinaryWriter binaryWriter_0, byte[] byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	internal static void smethod_530(Array array_0, int int_0, Array array_1, int int_1, int int_2)
	{
		Array.Copy(array_0, int_0, array_1, int_1, int_2);
	}

	internal static string smethod_531(string string_0)
	{
		return Path.GetDirectoryName(string_0);
	}

	internal static FileNotFoundException smethod_532(string string_0)
	{
		return new FileNotFoundException(string_0);
	}

	internal static Exception smethod_533(string string_0, Exception exception_0)
	{
		return new Exception(string_0, exception_0);
	}

	internal static void smethod_534(Stream stream_0, long long_0)
	{
		stream_0.SetLength(long_0);
	}

	internal static InvalidOperationException smethod_535()
	{
		return new InvalidOperationException();
	}

	internal static StringBuilder smethod_536(string string_0)
	{
		return new StringBuilder(string_0);
	}

	internal static int smethod_540(Version version_0)
	{
		return version_0.Major;
	}

	internal static StringBuilder smethod_541(StringBuilder stringBuilder_0, int int_0)
	{
		return stringBuilder_0.Append(int_0);
	}

	internal static StringBuilder smethod_542(StringBuilder stringBuilder_0, char char_0)
	{
		return stringBuilder_0.Append(char_0);
	}

	internal static int smethod_543(Version version_0)
	{
		return version_0.Minor;
	}

	internal static int smethod_544(Version version_0)
	{
		return version_0.Build;
	}

	internal static StringBuilder smethod_545(StringBuilder stringBuilder_0, string string_0)
	{
		return stringBuilder_0.Append(string_0);
	}

	internal static string smethod_546(object object_0)
	{
		return object_0.ToString();
	}

	internal static StringBuilder smethod_548(int int_0)
	{
		return new StringBuilder(int_0);
	}

	internal static int smethod_549(StringBuilder stringBuilder_0)
	{
		return stringBuilder_0.Capacity;
	}

	internal static string smethod_550(string string_0)
	{
		return Path.GetFileName(string_0);
	}

	internal static bool smethod_551(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	internal static void smethod_559(Graphics graphics_0, InterpolationMode interpolationMode_0)
	{
		graphics_0.InterpolationMode = interpolationMode_0;
	}

	internal static UnauthorizedAccessException smethod_563(string string_0)
	{
		return new UnauthorizedAccessException(string_0);
	}

	internal static void smethod_565(CheckBox checkBox_0, EventHandler eventHandler_0)
	{
		checkBox_0.CheckedChanged += eventHandler_0;
	}

	internal static object smethod_566(FieldInfo fieldInfo_0, object object_0)
	{
		return fieldInfo_0.GetValue(object_0);
	}

	internal static void smethod_567(CheckBox checkBox_0, bool bool_0)
	{
		checkBox_0.Checked = bool_0;
	}

	internal static ProgressBar smethod_573()
	{
		return new ProgressBar();
	}

	internal static Font smethod_575(string string_0, float float_0)
	{
		return new Font(string_0, float_0);
	}

	internal static RuntimeTypeHandle smethod_577(Type type_0)
	{
		return type_0.TypeHandle;
	}

	internal static void smethod_578(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		RuntimeHelpers.RunClassConstructor(runtimeTypeHandle_0);
	}

	internal static string smethod_579(object object_0, object object_1, object object_2)
	{
		return string.Concat(object_0, object_1, object_2);
	}

	internal static string smethod_581(string string_0)
	{
		return string_0.ToLowerInvariant();
	}

	internal static bool smethod_583(object object_0, object object_1)
	{
		return object_0.Equals(object_1);
	}

	internal static bool smethod_584(string string_0, string string_1)
	{
		return string_0.EndsWith(string_1);
	}

	internal static string smethod_585(string string_0, int int_0, int int_1)
	{
		return string_0.Substring(int_0, int_1);
	}

	internal static Int64Converter smethod_586()
	{
		return new Int64Converter();
	}

	internal static object smethod_587(TypeConverter typeConverter_0, string string_0)
	{
		return typeConverter_0.ConvertFromString(string_0);
	}

	internal static bool smethod_588(string string_0, string string_1)
	{
		return string_0.StartsWith(string_1);
	}

	internal static string smethod_589(string string_0, int int_0)
	{
		return string_0.Substring(int_0);
	}

	internal static string smethod_590()
	{
		return Path.GetTempPath();
	}

	internal static string smethod_591(string string_0, string string_1, string string_2)
	{
		return string_0.Replace(string_1, string_2);
	}

	internal static string smethod_592(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	internal static bool smethod_593(string string_0)
	{
		return File.Exists(string_0);
	}

	internal static bool smethod_594(string string_0, string string_1, StringComparison stringComparison_0)
	{
		return string_0.EndsWith(string_1, stringComparison_0);
	}

	internal static bool smethod_595(string string_0, string string_1, StringComparison stringComparison_0)
	{
		return string_0.Equals(string_1, stringComparison_0);
	}

	internal static ObjectDisposedException smethod_596(string string_0, string string_1)
	{
		return new ObjectDisposedException(string_0, string_1);
	}

	internal static void smethod_598(BinaryWriter binaryWriter_0, ushort ushort_0)
	{
		binaryWriter_0.Write(ushort_0);
	}

	internal static ulong smethod_599(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt64();
	}

	internal static void smethod_600(BinaryWriter binaryWriter_0, ulong ulong_0)
	{
		binaryWriter_0.Write(ulong_0);
	}

	internal static int smethod_601(int int_0, int int_1)
	{
		return Math.Min(int_0, int_1);
	}

	internal static void smethod_602(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static void smethod_603(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static string smethod_604(string[] string_0)
	{
		return string.Concat(string_0);
	}

	internal static void smethod_605(Array array_0)
	{
		Array.Reverse(array_0);
	}

	internal static string smethod_606(string string_0, int int_0, string string_1)
	{
		return string_0.Insert(int_0, string_1);
	}

	internal static StringBuilder smethod_607()
	{
		return new StringBuilder();
	}

	internal static bool smethod_608()
	{
		return NetworkInterface.GetIsNetworkAvailable();
	}

	internal static string smethod_609(WebClient webClient_0, string string_0)
	{
		return webClient_0.DownloadString(string_0);
	}

	internal static bool smethod_611(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	internal static bool smethod_612(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	internal static int smethod_613(byte[] byte_0, int int_0)
	{
		return BitConverter.ToInt32(byte_0, int_0);
	}

	internal static string smethod_617(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	internal static void smethod_622(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	internal static void smethod_624(int int_0)
	{
		Thread.Sleep(int_0);
	}

	internal static Win32Exception smethod_625(int int_0)
	{
		return new Win32Exception(int_0);
	}

	internal static string smethod_626(Exception exception_0)
	{
		return exception_0.Message;
	}

	internal static string smethod_627(string string_0)
	{
		return Path.GetFileNameWithoutExtension(string_0);
	}

	internal static string smethod_628(string string_0)
	{
		return Path.GetExtension(string_0);
	}

	internal static string smethod_629(object[] object_0)
	{
		return string.Concat(object_0);
	}

	internal static void smethod_630(string string_0, string string_1)
	{
		File.Copy(string_0, string_1);
	}

	internal static object smethod_631(Type type_0, object[] object_0)
	{
		return Activator.CreateInstance(type_0, object_0);
	}

	internal static Exception smethod_632(string string_0)
	{
		return new Exception(string_0);
	}

	internal static FileVersionInfo smethod_633(string string_0)
	{
		return FileVersionInfo.GetVersionInfo(string_0);
	}

	internal static string smethod_634(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.CompanyName;
	}

	internal static CheckBox smethod_635()
	{
		return new CheckBox();
	}

	internal static bool smethod_636(CheckBox checkBox_0)
	{
		return checkBox_0.Checked;
	}

	internal static bool smethod_637(string string_0, string string_1, StringComparison stringComparison_0)
	{
		return string_0.StartsWith(string_1, stringComparison_0);
	}

	internal static Process smethod_638(string string_0)
	{
		return Process.Start(string_0);
	}

	internal static bool smethod_639(Type type_0, Type type_1)
	{
		return type_0.IsSubclassOf(type_1);
	}

	internal static ArgumentOutOfRangeException smethod_640()
	{
		return new ArgumentOutOfRangeException();
	}

	internal static void smethod_643(NumericUpDown numericUpDown_0, decimal decimal_0)
	{
		numericUpDown_0.Value = decimal_0;
	}

	internal static string smethod_644(string string_0)
	{
		return Environment.GetEnvironmentVariable(string_0);
	}

	internal static WindowsIdentity smethod_645()
	{
		return WindowsIdentity.GetCurrent();
	}

	internal static WindowsPrincipal smethod_646(WindowsIdentity windowsIdentity_0)
	{
		return new WindowsPrincipal(windowsIdentity_0);
	}

	internal static bool smethod_647(WindowsPrincipal windowsPrincipal_0, WindowsBuiltInRole windowsBuiltInRole_0)
	{
		return windowsPrincipal_0.IsInRole(windowsBuiltInRole_0);
	}

	internal static int smethod_648(string string_0)
	{
		return string_0.Length;
	}

	internal static char smethod_649(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	internal static DynamicMethod smethod_650(string string_0, Type type_0, Type[] type_1, Type type_2)
	{
		return new DynamicMethod(string_0, type_0, type_1, type_2);
	}

	internal static ILGenerator smethod_651(DynamicMethod dynamicMethod_0)
	{
		return dynamicMethod_0.GetILGenerator();
	}

	internal static void smethod_652(ILGenerator ilgenerator_0, OpCode opCode_0, byte byte_0)
	{
		ilgenerator_0.Emit(opCode_0, byte_0);
	}

	internal static Delegate smethod_653(DynamicMethod dynamicMethod_0, Type type_0)
	{
		return dynamicMethod_0.CreateDelegate(type_0);
	}

	internal static void smethod_654(Random random_0, byte[] byte_0)
	{
		random_0.NextBytes(byte_0);
	}

	internal static short smethod_656(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadInt16();
	}

	internal static int smethod_657(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadInt32();
	}

	internal static int smethod_659(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2)
	{
		return hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_1, int_2);
	}

	internal static byte[] smethod_660(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		return hashAlgorithm_0.TransformFinalBlock(byte_0, int_0, int_1);
	}

	internal static byte[] smethod_661(HashAlgorithm hashAlgorithm_0)
	{
		return hashAlgorithm_0.Hash;
	}

	internal static NumericUpDown smethod_662()
	{
		return new NumericUpDown();
	}

	internal static Panel smethod_663()
	{
		return new Panel();
	}

	internal static ColorDialog smethod_664()
	{
		return new ColorDialog();
	}

	internal static FileStream smethod_665(string string_0)
	{
		return File.OpenWrite(string_0);
	}

	internal static PictureBox smethod_666()
	{
		return new PictureBox();
	}

	internal static LinkLabel smethod_667()
	{
		return new LinkLabel();
	}

	internal static void smethod_668(Panel panel_0, BorderStyle borderStyle_0)
	{
		panel_0.BorderStyle = borderStyle_0;
	}

	internal static Encoding smethod_670()
	{
		return Encoding.UTF8;
	}

	internal static string smethod_671(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	internal static char[] smethod_672(string string_0)
	{
		return string_0.ToCharArray();
	}

	internal static string smethod_673(char[] char_0)
	{
		return new string(char_0);
	}

	internal static void smethod_674(string string_0, string string_1, bool bool_0)
	{
		File.Copy(string_0, string_1, bool_0);
	}

	internal static AppDomain smethod_675()
	{
		return AppDomain.CurrentDomain;
	}

	internal static decimal smethod_679(NumericUpDown numericUpDown_0)
	{
		return numericUpDown_0.Value;
	}

	internal static CookieCollection smethod_692(HttpWebResponse httpWebResponse_0)
	{
		return httpWebResponse_0.Cookies;
	}

	internal static void smethod_693(CookieContainer cookieContainer_0, CookieCollection cookieCollection_0)
	{
		cookieContainer_0.Add(cookieCollection_0);
	}

	internal static ComboBox.ObjectCollection smethod_694(ComboBox comboBox_0)
	{
		return comboBox_0.Items;
	}

	internal static object smethod_695(ComboBox.ObjectCollection objectCollection_0, int int_0)
	{
		return objectCollection_0[int_0];
	}

	internal static Type smethod_696(Exception exception_0)
	{
		return exception_0.GetType();
	}

	internal static string smethod_697(Type type_0)
	{
		return type_0.FullName;
	}

	internal static string smethod_698(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	internal static Exception smethod_699(Exception exception_0)
	{
		return exception_0.InnerException;
	}

	internal static string smethod_700(string string_0)
	{
		return Path.GetFullPath(string_0);
	}

	internal static IEnumerator smethod_701(IEnumerable ienumerable_0)
	{
		return ienumerable_0.GetEnumerator();
	}

	internal static object smethod_702(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	internal static Exception smethod_703()
	{
		return new Exception();
	}

	internal static byte[] smethod_708(string string_0)
	{
		return Convert.FromBase64String(string_0);
	}

	internal static void smethod_709(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	internal static Type smethod_710(object object_0)
	{
		return object_0.GetType();
	}

	internal static OperatingSystem smethod_711()
	{
		return Environment.OSVersion;
	}

	internal static PlatformID smethod_712(OperatingSystem operatingSystem_0)
	{
		return operatingSystem_0.Platform;
	}

	internal static IEnumerable<int> smethod_713(int int_0, int int_1)
	{
		return Enumerable.Range(int_0, int_1);
	}

	internal static Cursor smethod_718()
	{
		return Cursors.Default;
	}

	internal static Cursor smethod_720()
	{
		return Cursors.Hand;
	}

	internal static string smethod_721(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.FileDescription;
	}

	internal static Container smethod_723()
	{
		return new Container();
	}

	internal static FormatException smethod_729(string string_0)
	{
		return new FormatException(string_0);
	}

	internal static int smethod_730(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		return stream_0.Read(byte_0, int_0, int_1);
	}

	internal static void smethod_732(Stream stream_0)
	{
		stream_0.Close();
	}

	internal static TabPage smethod_734()
	{
		return new TabPage();
	}

	internal static Win32Exception smethod_736(string string_0)
	{
		return new Win32Exception(string_0);
	}

	internal static string[] smethod_738(string string_0, char[] char_0)
	{
		return string_0.Split(char_0);
	}

	internal static int smethod_739(string string_0, char char_0)
	{
		return string_0.IndexOf(char_0);
	}

	internal static DirectoryInfo smethod_742(string string_0)
	{
		return Directory.CreateDirectory(string_0);
	}

	internal static int smethod_744(ComboBox.ObjectCollection objectCollection_0)
	{
		return objectCollection_0.Count;
	}

	internal static byte[] smethod_745(float float_0)
	{
		return BitConverter.GetBytes(float_0);
	}

	internal static AccessViolationException smethod_746(string string_0, Exception exception_0)
	{
		return new AccessViolationException(string_0, exception_0);
	}
}
