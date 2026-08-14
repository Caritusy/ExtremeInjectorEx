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

	internal static void SetDeflateInput(int int_0, byte[] byte_0, int int_1, DeflateDecoder.Class181 class181_0)
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

	internal static void HandleFileDrop(FileDropMessageFilter class10_0, Message message_0)
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
		FileDropMessageFilter.NativePoint @struct;
		RecoveredRuntime.DragQueryPoint(message_0.WParam, out @struct);
		RecoveredRuntime.DragFinish(message_0.WParam);
		FileDropEventArgs eventArgs = new FileDropEventArgs();
		eventArgs.WindowHandle = message_0.HWnd;
		eventArgs.Files = list;
		eventArgs.X = @struct.X;
		eventArgs.Y = @struct.Y;
		FileDropEventArgs e = eventArgs;
		if (class10_0.eventHandler_0 != null)
		{
			class10_0.eventHandler_0(class10_0, e);
		}
	}

	internal static bool SeekResourceOffset(ResourceDirectory class166_0, long long_0)
	{
		if (!IsResourceRangeValid(class166_0, long_0, 0))
		{
			return false;
		}
		class166_0.class5_0.BaseStream.Position = class166_0.long_0 + long_0;
		return true;
	}

	internal static int CopyDeflateOutput(int int_0, DeflateDecoder.Class182 class182_0, int int_1, byte[] byte_0)
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

	internal static void ReplaceStringWithRandomValue(Encoding encoding_0, PeScrambler gclass4_0, string string_0)
	{
		byte[] bytes = encoding_0.GetBytes(string_0);
		byte[] bytes2 = encoding_0.GetBytes(GenerateRandomMixedCaseString(string_0.Length));
		ReplaceBytePatternOccurrences(bytes2, bytes, gclass4_0);
	}

	internal static IntPtr GetPebAddress(RemotePeb class117_0)
	{
		return class117_0.GetAddress();
	}

	internal static bool IsAdministrator()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	internal static string GenerateRandomSectionName(PeScrambler gclass4_0)
	{
		StringBuilder stringBuilder = new StringBuilder(EncodedStringTable.DecodeString(952));
		for (int i = 0; i < gclass4_0.random_0.Next(4, 8); i++)
		{
			stringBuilder.Append(EncodedStringTable.DecodeString(17901)[gclass4_0.random_0.Next(EncodedStringTable.DecodeString(17901).Length)]);
		}
		return stringBuilder.ToString();
	}

	internal static string GenerateRandomMixedCaseString(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < int_0; i++)
		{
			char c = EncodedStringTable.DecodeString(17901)[PlatformInfo.random_0.Next(EncodedStringTable.DecodeString(17901).Length)];
			stringBuilder.Append((PlatformInfo.random_0.Next(2) == 1) ? c : char.ToUpper(c));
		}
		return stringBuilder.ToString();
	}

	internal static uint GetInvertedFunctionTableCapacity(InvertedFunctionTable32 class112_0)
	{
		return class112_0.ReadField<uint>(1);
	}

	internal static bool IsResourceRangeValid(ResourceDirectory class166_0, long long_0, int int_0)
	{
		return long_0 >= 0L && long_0 + (long)int_0 >= long_0 && (uint)(long_0 + (long)int_0) <= class166_0.uint_0;
	}

	internal static void SetModulePath(MainForm.ModuleRow class21_0, string string_0)
	{
		class21_0.Entry.Path = string_0;
	}

	internal static bool ReadDynamicDeflateTrees(DeflateDecoder.Class184 class184_0, DeflateDecoder.Class181 class181_0)
	{
		for (;;)
		{
			switch (class184_0.int_2)
			{
			case 0:
				class184_0.int_3 = RecoveredRuntime.PeekDeflateBits(class181_0, 5);
				if (class184_0.int_3 < 0)
				{
					return false;
				}
				class184_0.int_3 += 257;
				RecoveredRuntime.DropDeflateBits(class181_0, 5);
				class184_0.int_2 = 1;
				continue;
			case 1:
				class184_0.int_4 = RecoveredRuntime.PeekDeflateBits(class181_0, 5);
				if (class184_0.int_4 < 0)
				{
					return false;
				}
				class184_0.int_4++;
				RecoveredRuntime.DropDeflateBits(class181_0, 5);
				class184_0.int_6 = class184_0.int_3 + class184_0.int_4;
				class184_0.byte_1 = new byte[class184_0.int_6];
				class184_0.int_2 = 2;
				continue;
			case 2:
				class184_0.int_5 = RecoveredRuntime.PeekDeflateBits(class181_0, 4);
				if (class184_0.int_5 < 0)
				{
					return false;
				}
				class184_0.int_5 += 4;
				RecoveredRuntime.DropDeflateBits(class181_0, 4);
				class184_0.byte_0 = new byte[19];
				class184_0.int_8 = 0;
				class184_0.int_2 = 3;
				continue;
			case 3:
				while (class184_0.int_8 < class184_0.int_5)
				{
					int codeLength = RecoveredRuntime.PeekDeflateBits(class181_0, 3);
					if (codeLength < 0)
					{
						return false;
					}
					RecoveredRuntime.DropDeflateBits(class181_0, 3);
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
				while (((symbol = RecoveredRuntime.DecodeHuffmanSymbol(class184_0.class183_0, class181_0)) & -16) == 0)
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
				int repeatCount = RecoveredRuntime.PeekDeflateBits(class181_0, extraBitCount);
				if (repeatCount < 0)
				{
					return false;
				}
				RecoveredRuntime.DropDeflateBits(class181_0, extraBitCount);
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

	internal static uint ReadResourceUInt32(ResourceDirectory class166_0)
	{
		return class166_0.class5_0.ReadUInt32();
	}

	internal static RemotePlatformStructure.RemoteFieldLayout CreateRemoteFieldLayout(Type type_0)
	{
		int int_ = GetPlatformTypeSize(type_0);
		return new RemotePlatformStructure.RemoteFieldLayout
		{
			int_0 = int_
		};
	}

	internal static string GetEncodedSettingsPath()
	{
		string s = ApplicationSettings.DefaultPath;
		char[] array = Convert.ToBase64String(Encoding.UTF8.GetBytes(s)).ToCharArray();
		Array.Reverse(array);
		return new string(array);
	}

	internal static short ReverseDeflateBits(int int_0)
	{
		return (short)((DeflateDecoder.Class185.byte_0[int_0 & 0xF] << 12) | (DeflateDecoder.Class185.byte_0[(int_0 >> 4) & 0xF] << 8) | (DeflateDecoder.Class185.byte_0[(int_0 >> 8) & 0xF] << 4) | DeflateDecoder.Class185.byte_0[int_0 >> 12]);
	}

	internal static IntPtr GetInvertedFunctionImageBase(InvertedFunctionTableEntry32 class113_0)
	{
		return (IntPtr)class113_0.ReadField<uint>(1);
	}

	internal static void CaptureResponseCookies(CookieAwareWebClient class20_0, WebResponse webResponse_0)
	{
		HttpWebResponse httpWebResponse = webResponse_0 as HttpWebResponse;
		if (httpWebResponse == null)
		{
			return;
		}
		CookieCollection cookies = httpWebResponse.Cookies;
		class20_0.Cookies.Add(cookies);
	}

	internal static bool MatchesAsciiAt(string string_0, int int_0, byte[] byte_0)
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

	internal static void EnableDebugPrivilege()
	{
		EnableTokenPrivilege("SeDebugPrivilege");
	}

	internal unsafe static int FindAsciiSequence(byte[] byte_0, string string_0, int int_0)
	{
		return IndexOfByteString(byte_0, string_0, int_0);
}

	internal static string FormatExceptionChain(string string_0, Exception exception_0, bool bool_0)
	{
		Type type = exception_0.GetType();
		string text = string_0;
		if (bool_0)
		{
			text += EncodedStringTable.DecodeString(24371);
		}
		text = text + type.FullName + EncodedStringTable.DecodeString(24376) + exception_0.Message;
		if (!text.EndsWith(EncodedStringTable.DecodeString(952)))
		{
			text += EncodedStringTable.DecodeString(952);
		}
		if (exception_0.InnerException != null)
		{
			return RecoveredRuntime.FormatExceptionChain(text + EncodedStringTable.DecodeString(24371), exception_0.InnerException, false);
		}
		return text;
	}

	internal static bool DecodeCompressedDeflateBlock(DeflateDecoder.Class180 class180_0)
	{
		int availableOutput = RecoveredRuntime.GetAvailableDeflateWindowBytes(class180_0.class182_0);
		while (availableOutput >= 258)
		{
			switch (class180_0.int_4)
			{
			case 7:
				int symbol;
				while (((symbol = RecoveredRuntime.DecodeHuffmanSymbol(class180_0.class183_0, class180_0.class181_0)) & -256) == 0)
				{
					RecoveredRuntime.WriteDeflateLiteral(class180_0.class182_0, symbol);
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
					int extraLength = RecoveredRuntime.PeekDeflateBits(class180_0.class181_0, class180_0.int_5);
					if (extraLength < 0)
					{
						return false;
					}
					RecoveredRuntime.DropDeflateBits(class180_0.class181_0, class180_0.int_5);
					class180_0.int_6 += extraLength;
				}
				class180_0.int_4 = 9;
				continue;
			case 9:
				int distanceSymbol = RecoveredRuntime.DecodeHuffmanSymbol(class180_0.class183_1, class180_0.class181_0);
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
					int extraDistance = RecoveredRuntime.PeekDeflateBits(class180_0.class181_0, class180_0.int_5);
					if (extraDistance < 0)
					{
						return false;
					}
					RecoveredRuntime.DropDeflateBits(class180_0.class181_0, class180_0.int_5);
					class180_0.int_7 += extraDistance;
				}
				RecoveredRuntime.CopyDeflateMatch(class180_0.class182_0, class180_0.int_6, class180_0.int_7);
				availableOutput -= class180_0.int_6;
				class180_0.int_4 = 7;
				continue;
			default:
				return false;
			}
		}
		return true;
	}

	internal unsafe static void ZeroMemory(long long_0, IntPtr intptr_0, byte byte_0)
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

	internal static int GetRemoteStructureSize(Type type_0)
	{
		if (!type_0.IsSubclassOf(typeof(RemotePlatformStructure)))
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(25005));
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
			throw new InvalidOperationException(EncodedStringTable.DecodeString(13137) + type_0 + EncodedStringTable.DecodeString(3656));
		}
		return RecoveredRuntime.GetRemoteStructureSize(type_0);
	}

	internal static uint GetInvertedFunctionTableCount(InvertedFunctionTable32 class112_0)
	{
		return class112_0.ReadField<uint>(0);
	}

	internal static void SaveScrambledImage(string string_0, PeScrambler gclass4_0)
	{
		SavePeImage(string_0, gclass4_0.class154_0);
	}

	internal static ushort ReadResourceUInt16(ResourceDirectory class166_0)
	{
		return class166_0.class5_0.ReadUInt16();
	}

	internal static void ZeroFillImageRange(PeScrambler gclass4_0, long long_0, long long_1)
	{
		byte[] buffer = new byte[long_1];
		gclass4_0.class154_0.GetStream().Position = long_0;
		gclass4_0.binaryWriter_0.Write(buffer);
	}

	internal static int FindAsciiPattern(byte[] byte_0, string string_0, int int_0)
	{
		if (int_0 + string_0.Length > byte_0.Length)
		{
			return -1;
		}
		if (byte_0.Length - int_0 < 20000 || string_0.Length < 5)
		{
			return RecoveredRuntime.FindAsciiSequence(byte_0, string_0, int_0);
		}
		int length = string_0.Length;
		byte[] array = new byte[length];
		for (int i = 0; i < length; i++)
		{
			array[i] = (byte)string_0[i];
		}
		return RecoveredRuntime.FindByteSequence(byte_0, array, int_0);
	}

	internal static bool HasResourceName(ResourceIdentifier class137_0)
	{
		return class137_0.GetName() != null;
	}

	internal static void CloseRemoteMemoryAccessor(RemoteMemoryAccessor class82_0)
	{
		if (class82_0.GetMemoryApi() != null)
		{
			class82_0.GetMemoryApi().CloseHandle(class82_0.GetProcessHandle());
			return;
		}
		if (class82_0.GetProcessHandle() != IntPtr.Zero)
		{
			RecoveredRuntime.CloseHandle(class82_0.GetProcessHandle());
			class82_0.SetProcessHandle(IntPtr.Zero);
		}
	}

	internal static void DropDeflateBits(DeflateDecoder.Class181 class181_0, int int_0)
	{
		class181_0.uint_0 >>= int_0;
		class181_0.int_2 -= int_0;
	}

	internal static void SetPebLdrDataAddress(IntPtr intptr_0, RemotePebLdrData class109_0)
	{
		class109_0.SetAddress(intptr_0);
	}

	internal static int GetAvailableDeflateInputBytes(DeflateDecoder.Class181 class181_0)
	{
		return class181_0.int_1 - class181_0.int_0 + (class181_0.int_2 >> 3);
	}

	internal static string ReadNullTerminatedAsciiString(BoundsCheckedBinaryReader class5_0)
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

	internal static void ParseResourceDirectoryNode(ResourceDirectoryNode class138_0)
	{
		if (class138_0.long_0 < 0L)
		{
			return;
		}
		if (!RecoveredRuntime.IsResourceRangeValid(class138_0.class166_0, class138_0.long_0, 16))
		{
			return;
		}
		if (!RecoveredRuntime.SeekResourceOffset(class138_0.class166_0, class138_0.long_0))
		{
			return;
		}
		class138_0.SetCharacteristics(RecoveredRuntime.ReadResourceUInt32(class138_0.class166_0));
		class138_0.SetTimeDateStamp(RecoveredRuntime.ReadResourceUInt32(class138_0.class166_0));
		class138_0.SetMajorVersion(RecoveredRuntime.ReadResourceUInt16(class138_0.class166_0));
		class138_0.SetMinorVersion(RecoveredRuntime.ReadResourceUInt16(class138_0.class166_0));
		int num = (int)RecoveredRuntime.ReadResourceUInt16(class138_0.class166_0);
		int num2 = (int)RecoveredRuntime.ReadResourceUInt16(class138_0.class166_0);
		int num3 = num + num2;
		if (RecoveredRuntime.IsCurrentResourceRangeValid(class138_0.class166_0, num3 * 8))
		{
			long num4 = 0L;
			long num5 = class138_0.long_0 + 16L;
			while (num4 < (long)num3)
			{
				RecoveredRuntime.SeekResourceOffset(class138_0.class166_0, num5);
				uint num6 = RecoveredRuntime.ReadResourceUInt32(class138_0.class166_0);
				uint num7 = RecoveredRuntime.ReadResourceUInt32(class138_0.class166_0);
				string text = null;
				int int_ = -1;
				if ((num6 & 2147483648u) == 0u)
				{
					int_ = (int)num6;
				}
				else
				{
					text = RecoveredRuntime.ReadResourceDirectoryString((int)(num6 & 2147483647u), class138_0.class166_0);
					if (text == null)
					{
						return;
					}
				}
				if ((num7 & 2147483648u) == 0u)
				{
					if (!RecoveredRuntime.SeekResourceOffset(class138_0.class166_0, (long)num7) || !RecoveredRuntime.IsCurrentResourceRangeValid(class138_0.class166_0, 16))
					{
						break;
					}
					uint num8 = RecoveredRuntime.ReadResourceUInt32(class138_0.class166_0);
					uint uint_ = RecoveredRuntime.ReadResourceUInt32(class138_0.class166_0);
					if (num8 != 0u)
					{
						if (text == null)
						{
							class138_0.GetDataEntries().Add(new ResourceDataEntry(int_, num8, uint_));
						}
						else
						{
							class138_0.GetDataEntries().Add(new ResourceDataEntry(text, num8, uint_));
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
							class138_0.GetSubdirectories().Add(new ResourceDirectoryNode(int_, class138_0.class166_0, (long)num9));
						}
						else
						{
							class138_0.GetSubdirectories().Add(new ResourceDirectoryNode(text, class138_0.class166_0, (long)num9));
						}
					}
				}
				num4 += 1L;
				num5 += 8L;
			}
			return;
		}
	}

	internal static int FindMaskedPattern(byte[] byte_0, string string_0, string string_1, int int_0)
	{
		if (int_0 >= byte_0.Length || string_0.Length != string_1.Length || int_0 + string_0.Length > byte_0.Length)
		{
			return -1;
		}
		if (byte_0.Length - int_0 < 4 || string_0.Length < 4)
		{
			return RecoveredRuntime.FindMaskedBytePattern(byte_0, string_0, string_1, int_0);
		}
		return RecoveredRuntime.FindMaskedByteSequence(int_0, string_0, string_1, byte_0);
	}

	internal static uint GetInvertedFunctionTableEntrySize(InvertedFunctionTableEntry32 class113_0)
	{
		return class113_0.ReadField<uint>(3);
	}

	internal static string GenerateRandomIdentifier()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = DynamicIlEmitter.random_0.Next(5, 30);
		for (int i = 0; i < num; i++)
		{
			stringBuilder.Append((DynamicIlEmitter.random_0.Next(2) == 1) ? char.ToUpper(EncodedStringTable.DecodeString(17901)[DynamicIlEmitter.random_0.Next(EncodedStringTable.DecodeString(17901).Length)]) : EncodedStringTable.DecodeString(17901)[DynamicIlEmitter.random_0.Next(EncodedStringTable.DecodeString(17901).Length)]);
		}
		return stringBuilder.ToString();
	}

	internal static string GenerateFakePdbPath(PeScrambler gclass4_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(EncodedStringTable.DecodeString(27891)[gclass4_0.random_0.Next(EncodedStringTable.DecodeString(27891).Length)]).Append(':');
		for (int i = 0; i < gclass4_0.random_0.Next(4, 8); i++)
		{
			stringBuilder.Append(EncodedStringTable.DecodeString(27928));
			for (int j = 0; j < gclass4_0.random_0.Next(4, 20); j++)
			{
				stringBuilder.Append(EncodedStringTable.DecodeString(17901)[gclass4_0.random_0.Next(EncodedStringTable.DecodeString(17901).Length)]);
			}
		}
		return stringBuilder.Append(EncodedStringTable.DecodeString(27933)).ToString();
	}

	internal static bool MatchesDependencyName(string string_0, string string_1)
	{
		return (string_0.StartsWith(EncodedStringTable.DecodeString(27942) + string_1, StringComparison.OrdinalIgnoreCase) || string_0.StartsWith(EncodedStringTable.DecodeString(27951) + string_1, StringComparison.OrdinalIgnoreCase)) && (string_0.EndsWith(EncodedStringTable.DecodeString(16146), StringComparison.OrdinalIgnoreCase) || string_0.EndsWith(EncodedStringTable.DecodeString(10075), StringComparison.OrdinalIgnoreCase));
	}

	internal static bool DecodeNextDeflateBlock(DeflateDecoder.Class180 class180_0)
	{
		switch (class180_0.int_4)
		{
		case 2:
			if (class180_0.bool_0)
			{
				class180_0.int_4 = 12;
				return false;
			}
			int blockHeader = RecoveredRuntime.PeekDeflateBits(class180_0.class181_0, 3);
			if (blockHeader < 0)
			{
				return false;
			}
			RecoveredRuntime.DropDeflateBits(class180_0.class181_0, 3);
			if ((blockHeader & 1) != 0)
			{
				class180_0.bool_0 = true;
			}
			switch (blockHeader >> 1)
			{
			case 0:
				RecoveredRuntime.AlignDeflateInputToByteBoundary(class180_0.class181_0);
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
			int storedLength = RecoveredRuntime.PeekDeflateBits(class180_0.class181_0, 16);
			if (storedLength < 0)
			{
				return false;
			}
			class180_0.int_8 = storedLength;
			RecoveredRuntime.DropDeflateBits(class180_0.class181_0, 16);
			class180_0.int_4 = 4;
			break;
		case 4:
			break;
		case 5:
			return RecoveredRuntime.ContinueStoredDeflateBlock(class180_0);
		case 6:
			if (!RecoveredRuntime.ReadDynamicDeflateTrees(class180_0.class184_0, class180_0.class181_0))
			{
				return false;
			}
			class180_0.class183_0 = RecoveredRuntime.BuildLiteralLengthHuffmanTree(class180_0.class184_0);
			class180_0.class183_1 = RecoveredRuntime.BuildDistanceHuffmanTree(class180_0.class184_0);
			class180_0.int_4 = 7;
			return RecoveredRuntime.DecodeCompressedDeflateBlock(class180_0);
		case 7:
		case 8:
		case 9:
		case 10:
			return RecoveredRuntime.DecodeCompressedDeflateBlock(class180_0);
		default:
			return false;
		}

		int storedLengthComplement = RecoveredRuntime.PeekDeflateBits(class180_0.class181_0, 16);
		if (storedLengthComplement < 0)
		{
			return false;
		}
		RecoveredRuntime.DropDeflateBits(class180_0.class181_0, 16);
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
		int copiedByteCount = RecoveredRuntime.CopyStoredDeflateBytes(decoder.class182_0, decoder.class181_0, decoder.int_8);
		decoder.int_8 -= copiedByteCount;
		if (decoder.int_8 != 0)
		{
			return !RecoveredRuntime.IsDeflateInputExhausted(decoder.class181_0);
		}
		decoder.int_4 = 2;
		return true;
	}

	internal static void FillImageRangeWithRandomBytes(PeScrambler gclass4_0, long long_0, long long_1)
	{
		byte[] buffer = new byte[long_1];
		gclass4_0.random_0.NextBytes(buffer);
		gclass4_0.class154_0.GetStream().Position = long_0;
		gclass4_0.binaryWriter_0.Write(buffer);
	}

	internal static int ReadUInt16LittleEndian(DeflateDecoder.Stream1 stream1_0)
	{
		return stream1_0.ReadByte() | (stream1_0.ReadByte() << 8);
	}

	internal static string ResolveDependencyPath(string string_0, string string_1, string string_2, DependencySearchFlags enum43_0, int int_0, IntPtr intptr_0)
	{
		ApiSetSchema.Class170 @class = new ApiSetSchema.Class170();
		string_0 = string_0.ToLowerInvariant();
		string_1 = (string.IsNullOrEmpty(string_1) ? string.Empty : string_1.ToLowerInvariant());
		@class.string_0 = Path.GetFileName(string_0);
		if (!PlatformInfo.bool_7 && @class.string_0.StartsWith(EncodedStringTable.DecodeString(27960)))
		{
			@class.string_0 = @class.string_0.Substring(4);
		}
		KeyValuePair<string, List<string>> keyValuePair = ApiSetSchema.dictionary_0.FirstOrDefault(new Func<KeyValuePair<string, List<string>>, bool>(@class.MatchesContract));
		if (string_1.Length > 0 && keyValuePair.Key != null && keyValuePair.Value != null && keyValuePair.Value.Count >= 1)
		{
			List<string> value = keyValuePair.Value;
			string_0 = ((value.First<string>() != string_1) ? value.First<string>() : value.Last<string>());
			if (RecoveredRuntime.ResolveSideBySideDllPath(ref string_0, intptr_0))
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
			if (RecoveredRuntime.ResolveSideBySideDllPath(ref string_0, intptr_0))
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
				registryKey = Registry.LocalMachine.OpenSubKey(EncodedStringTable.DecodeString(27973));
				if (registryKey != null)
				{
					foreach (string name in registryKey.GetValueNames())
					{
						string text = registryKey.GetValue(name) as string;
						if (text != null && text.Equals(@class.string_0, StringComparison.OrdinalIgnoreCase))
						{
							string text2 = registryKey.GetValue(((enum43_0 & DependencySearchFlags.flag_4) != DependencySearchFlags.flag_0) ? EncodedStringTable.DecodeString(28071) : EncodedStringTable.DecodeString(28054)) as string;
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
				text3 = Path.Combine(Path.GetDirectoryName(RecoveredRuntime.OpenRemoteProcessById(int_0).FilePath), @class.string_0);
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
			string environmentVariable = Environment.GetEnvironmentVariable(EncodedStringTable.DecodeString(28092));
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

	internal static string FormatByteSize(long long_0)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		RecoveredRuntime.StrFormatByteSize(long_0, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	internal static bool TryReadDosHeader(ref DosHeader class158_0, [Out] BoundsCheckedBinaryReader class5_0)
	{
		class158_0 = null;
		if (class5_0.BaseStream.Length < 128L)
		{
			return false;
		}
		class158_0 = new DosHeader();
		if (class5_0.ReadUInt16() == 23117)
		{
			RecoveredRuntime.SkipBytes(class5_0, 58);
			class158_0.SetPeHeaderOffset(class5_0.ReadUInt32());
			return true;
		}
		return false;
	}

	internal static IntPtr GetWindowClassLongPtr(IntPtr intptr_0, int int_0)
	{
		if (PlatformInfo.bool_0)
		{
			return GetClassLongPtr(intptr_0, int_0);
		}
		return (IntPtr)GetClassLong(intptr_0, int_0);
	}
}
