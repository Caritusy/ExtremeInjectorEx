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

	internal static void SetDeflateInput(int intValue, byte[] bytes, int intValue2, DeflateDecoder.DeflateInputBuffer deflateInputBuffer)
	{
		if (deflateInputBuffer.intValue < deflateInputBuffer.intValue2)
		{
			throw new InvalidOperationException();
		}
		int num = intValue2 + intValue;
		if (0 > intValue2 || intValue2 > num || num > bytes.Length)
		{
			throw new ArgumentOutOfRangeException();
		}
		if ((intValue & 1) != 0)
		{
			deflateInputBuffer.uintValue |= (uint)((uint)(bytes[intValue2++] & byte.MaxValue) << deflateInputBuffer.intValue3);
			deflateInputBuffer.intValue3 += 8;
		}
		deflateInputBuffer.bytes = bytes;
		deflateInputBuffer.intValue = intValue2;
		deflateInputBuffer.intValue2 = num;
	}

	internal static void HandleFileDrop(FileDropMessageFilter fileDropMessageFilter, Message message)
	{
		StringBuilder stringBuilder = new StringBuilder(260);
		uint num = RecoveredRuntime.DragQueryFile(message.WParam, uint.MaxValue, stringBuilder, 0u);
		List<string> list = new List<string>();
		for (uint num2 = 0u; num2 <= num - 1u; num2 += 1u)
		{
			if (RecoveredRuntime.DragQueryFile(message.WParam, num2, stringBuilder, Convert.ToUInt32(stringBuilder.Capacity) * 2u) > 0u)
			{
				list.Add(stringBuilder.ToString());
			}
		}
		FileDropMessageFilter.NativePoint @struct;
		RecoveredRuntime.DragQueryPoint(message.WParam, out @struct);
		RecoveredRuntime.DragFinish(message.WParam);
		FileDropEventArgs eventArgs = new FileDropEventArgs();
		eventArgs.WindowHandle = message.HWnd;
		eventArgs.Files = list;
		eventArgs.X = @struct.X;
		eventArgs.Y = @struct.Y;
		FileDropEventArgs e = eventArgs;
		if (fileDropMessageFilter.eventHandler != null)
		{
			fileDropMessageFilter.eventHandler(fileDropMessageFilter, e);
		}
	}

	internal static bool SeekResourceOffset(ResourceDirectory resourceDirectory, long longValue)
	{
		if (!IsResourceRangeValid(resourceDirectory, longValue, 0))
		{
			return false;
		}
		resourceDirectory.boundsCheckedBinaryReader.BaseStream.Position = resourceDirectory.longValue + longValue;
		return true;
	}

	internal static int CopyDeflateOutput(int intValue, DeflateDecoder.DeflateOutputWindow deflateOutputWindow, int intValue2, byte[] bytes)
	{
		int num = deflateOutputWindow.intValue;
		if (intValue2 <= deflateOutputWindow.intValue2)
		{
			num = (deflateOutputWindow.intValue - deflateOutputWindow.intValue2 + intValue2 & 32767);
		}
		else
		{
			intValue2 = deflateOutputWindow.intValue2;
		}
		int num2 = intValue2;
		int num3 = intValue2 - num;
		if (num3 > 0)
		{
			Array.Copy(deflateOutputWindow.bytes, 32768 - num3, bytes, intValue, num3);
			intValue += num3;
			intValue2 = num;
		}
		Array.Copy(deflateOutputWindow.bytes, num - intValue2, bytes, intValue, intValue2);
		deflateOutputWindow.intValue2 -= num2;
		if (deflateOutputWindow.intValue2 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	internal static void ReplaceStringWithRandomValue(Encoding encoding, PeScrambler peScrambler, string text)
	{
		byte[] bytes = encoding.GetBytes(text);
		byte[] bytes2 = encoding.GetBytes(GenerateRandomMixedCaseString(text.Length));
		ReplaceBytePatternOccurrences(bytes2, bytes, peScrambler);
	}

	internal static IntPtr GetPebAddress(RemotePeb remotePeb)
	{
		return remotePeb.GetAddress();
	}

	internal static bool IsAdministrator()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	internal static string GenerateRandomSectionName(PeScrambler peScrambler)
	{
		StringBuilder stringBuilder = new StringBuilder(EncodedStringTable.DecodeString(952));
		for (int i = 0; i < peScrambler.random.Next(4, 8); i++)
		{
			stringBuilder.Append(EncodedStringTable.DecodeString(17901)[peScrambler.random.Next(EncodedStringTable.DecodeString(17901).Length)]);
		}
		return stringBuilder.ToString();
	}

	internal static string GenerateRandomMixedCaseString(int intValue)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < intValue; i++)
		{
			char c = EncodedStringTable.DecodeString(17901)[PlatformInfo.randomElement.Next(EncodedStringTable.DecodeString(17901).Length)];
			stringBuilder.Append((PlatformInfo.randomElement.Next(2) == 1) ? c : char.ToUpper(c));
		}
		return stringBuilder.ToString();
	}

	internal static uint GetInvertedFunctionTableCapacity(InvertedFunctionTable32 invertedFunctionTable32)
	{
		return invertedFunctionTable32.ReadField<uint>(1);
	}

	internal static bool IsResourceRangeValid(ResourceDirectory resourceDirectory, long longValue, int intValue)
	{
		return longValue >= 0L && longValue + (long)intValue >= longValue && (uint)(longValue + (long)intValue) <= resourceDirectory.uintValue;
	}

	internal static void SetModulePath(MainForm.ModuleRow moduleRow, string text)
	{
		moduleRow.Entry.Path = text;
	}

	internal static bool ReadDynamicDeflateTrees(DeflateDecoder.DynamicHuffmanHeader dynamicHuffmanHeader, DeflateDecoder.DeflateInputBuffer deflateInputBuffer)
	{
		for (;;)
		{
			switch (dynamicHuffmanHeader.intValue)
			{
			case 0:
				dynamicHuffmanHeader.intValue2 = RecoveredRuntime.PeekDeflateBits(deflateInputBuffer, 5);
				if (dynamicHuffmanHeader.intValue2 < 0)
				{
					return false;
				}
				dynamicHuffmanHeader.intValue2 += 257;
				RecoveredRuntime.DropDeflateBits(deflateInputBuffer, 5);
				dynamicHuffmanHeader.intValue = 1;
				continue;
			case 1:
				dynamicHuffmanHeader.intValue3 = RecoveredRuntime.PeekDeflateBits(deflateInputBuffer, 5);
				if (dynamicHuffmanHeader.intValue3 < 0)
				{
					return false;
				}
				dynamicHuffmanHeader.intValue3++;
				RecoveredRuntime.DropDeflateBits(deflateInputBuffer, 5);
				dynamicHuffmanHeader.intValue5 = dynamicHuffmanHeader.intValue2 + dynamicHuffmanHeader.intValue3;
				dynamicHuffmanHeader.bytes2 = new byte[dynamicHuffmanHeader.intValue5];
				dynamicHuffmanHeader.intValue = 2;
				continue;
			case 2:
				dynamicHuffmanHeader.intValue4 = RecoveredRuntime.PeekDeflateBits(deflateInputBuffer, 4);
				if (dynamicHuffmanHeader.intValue4 < 0)
				{
					return false;
				}
				dynamicHuffmanHeader.intValue4 += 4;
				RecoveredRuntime.DropDeflateBits(deflateInputBuffer, 4);
				dynamicHuffmanHeader.bytes = new byte[19];
				dynamicHuffmanHeader.intValue7 = 0;
				dynamicHuffmanHeader.intValue = 3;
				continue;
			case 3:
				while (dynamicHuffmanHeader.intValue7 < dynamicHuffmanHeader.intValue4)
				{
					int codeLength = RecoveredRuntime.PeekDeflateBits(deflateInputBuffer, 3);
					if (codeLength < 0)
					{
						return false;
					}
					RecoveredRuntime.DropDeflateBits(deflateInputBuffer, 3);
					dynamicHuffmanHeader.bytes[DeflateDecoder.DynamicHuffmanHeader.intValueArray3[dynamicHuffmanHeader.intValue7]] = (byte)codeLength;
					dynamicHuffmanHeader.intValue7++;
				}
				dynamicHuffmanHeader.deflateHuffmanTree = new DeflateDecoder.DeflateHuffmanTree(dynamicHuffmanHeader.bytes);
				dynamicHuffmanHeader.bytes = null;
				dynamicHuffmanHeader.intValue7 = 0;
				dynamicHuffmanHeader.intValue = 4;
				continue;
			case 4:
				int symbol;
				while (((symbol = RecoveredRuntime.DecodeHuffmanSymbol(dynamicHuffmanHeader.deflateHuffmanTree, deflateInputBuffer)) & -16) == 0)
				{
					if (dynamicHuffmanHeader.intValue7 >= dynamicHuffmanHeader.intValue5)
					{
						return false;
					}
					dynamicHuffmanHeader.bytes2[dynamicHuffmanHeader.intValue7++] = (dynamicHuffmanHeader.byteValue = (byte)symbol);
					if (dynamicHuffmanHeader.intValue7 == dynamicHuffmanHeader.intValue5)
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
					dynamicHuffmanHeader.byteValue = 0;
				}
				dynamicHuffmanHeader.intValue6 = symbol - 16;
				dynamicHuffmanHeader.intValue = 5;
				continue;
			case 5:
				int extraBitCount = DeflateDecoder.DynamicHuffmanHeader.intValueArray2[dynamicHuffmanHeader.intValue6];
				int repeatCount = RecoveredRuntime.PeekDeflateBits(deflateInputBuffer, extraBitCount);
				if (repeatCount < 0)
				{
					return false;
				}
				RecoveredRuntime.DropDeflateBits(deflateInputBuffer, extraBitCount);
				repeatCount += DeflateDecoder.DynamicHuffmanHeader.intValueArray[dynamicHuffmanHeader.intValue6];
				if (repeatCount > dynamicHuffmanHeader.intValue5 - dynamicHuffmanHeader.intValue7)
				{
					return false;
				}
				while (repeatCount-- > 0)
				{
					dynamicHuffmanHeader.bytes2[dynamicHuffmanHeader.intValue7++] = dynamicHuffmanHeader.byteValue;
				}
				if (dynamicHuffmanHeader.intValue7 == dynamicHuffmanHeader.intValue5)
				{
					return true;
				}
				dynamicHuffmanHeader.intValue = 4;
				continue;
			default:
				return false;
			}
		}
	}

	internal static uint ReadResourceUInt32(ResourceDirectory resourceDirectory)
	{
		return resourceDirectory.boundsCheckedBinaryReader.ReadUInt32();
	}

	internal static RemotePlatformStructure.RemoteFieldLayout CreateRemoteFieldLayout(Type typeValue)
	{
		int int_ = GetPlatformTypeSize(typeValue);
		return new RemotePlatformStructure.RemoteFieldLayout
		{
			intValue = int_
		};
	}

	internal static string GetEncodedSettingsPath()
	{
		string s = ApplicationSettings.DefaultPath;
		char[] array = Convert.ToBase64String(Encoding.UTF8.GetBytes(s)).ToCharArray();
		Array.Reverse(array);
		return new string(array);
	}

	internal static short ReverseDeflateBits(int intValue)
	{
		return (short)((DeflateDecoder.DeflateHuffmanTables.bytes[intValue & 0xF] << 12) | (DeflateDecoder.DeflateHuffmanTables.bytes[(intValue >> 4) & 0xF] << 8) | (DeflateDecoder.DeflateHuffmanTables.bytes[(intValue >> 8) & 0xF] << 4) | DeflateDecoder.DeflateHuffmanTables.bytes[intValue >> 12]);
	}

	internal static IntPtr GetInvertedFunctionImageBase(InvertedFunctionTableEntry32 invertedFunctionTableEntry32)
	{
		return (IntPtr)invertedFunctionTableEntry32.ReadField<uint>(1);
	}

	internal static void CaptureResponseCookies(CookieAwareWebClient cookieAwareWebClient, WebResponse webResponse)
	{
		HttpWebResponse httpWebResponse = webResponse as HttpWebResponse;
		if (httpWebResponse == null)
		{
			return;
		}
		CookieCollection cookies = httpWebResponse.Cookies;
		cookieAwareWebClient.Cookies.Add(cookies);
	}

	internal static bool MatchesAsciiAt(string text, int intValue, byte[] bytes)
	{
		if (intValue + text.Length > bytes.Length)
		{
			return false;
		}
		for (int i = 0; i < text.Length; i++)
		{
			if ((char)bytes[intValue + i] != text[i])
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

	internal unsafe static int FindAsciiSequence(byte[] bytes, string text, int intValue)
	{
		return IndexOfByteString(bytes, text, intValue);
}

	internal static string FormatExceptionChain(string text2, Exception exception, bool flag)
	{
		const string ExceptionSeparator = "\n\n";
		const string TypeMessageSeparator = ": ";
		const string SentenceTerminator = ".";

		Type type = exception.GetType();
		string text = text2 ?? string.Empty;
		if (flag)
		{
			text += ExceptionSeparator;
		}
		text = text + type.FullName + TypeMessageSeparator + exception.Message;
		if (!text.EndsWith(SentenceTerminator, StringComparison.Ordinal))
		{
			text += SentenceTerminator;
		}
		if (exception.InnerException != null)
		{
			return RecoveredRuntime.FormatExceptionChain(text + ExceptionSeparator, exception.InnerException, false);
		}
		return text;
	}

	internal static bool DecodeCompressedDeflateBlock(DeflateDecoder.Inflater inflater)
	{
		int availableOutput = RecoveredRuntime.GetAvailableDeflateWindowBytes(inflater.deflateOutputWindow);
		while (availableOutput >= 258)
		{
			switch (inflater.intValue)
			{
			case 7:
				int symbol;
				while (((symbol = RecoveredRuntime.DecodeHuffmanSymbol(inflater.deflateHuffmanTree, inflater.deflateInputBuffer)) & -256) == 0)
				{
					RecoveredRuntime.WriteDeflateLiteral(inflater.deflateOutputWindow, symbol);
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
					inflater.deflateHuffmanTree2 = null;
					inflater.deflateHuffmanTree = null;
					inflater.intValue = 2;
					return true;
				}
				int lengthIndex = symbol - 257;
				if (lengthIndex >= DeflateDecoder.Inflater.intValueArray.Length)
				{
					return false;
				}
				inflater.intValue3 = DeflateDecoder.Inflater.intValueArray[lengthIndex];
				inflater.intValue2 = DeflateDecoder.Inflater.intValueArray2[lengthIndex];
				inflater.intValue = 8;
				continue;
			case 8:
				if (inflater.intValue2 > 0)
				{
					int extraLength = RecoveredRuntime.PeekDeflateBits(inflater.deflateInputBuffer, inflater.intValue2);
					if (extraLength < 0)
					{
						return false;
					}
					RecoveredRuntime.DropDeflateBits(inflater.deflateInputBuffer, inflater.intValue2);
					inflater.intValue3 += extraLength;
				}
				inflater.intValue = 9;
				continue;
			case 9:
				int distanceSymbol = RecoveredRuntime.DecodeHuffmanSymbol(inflater.deflateHuffmanTree2, inflater.deflateInputBuffer);
				if (distanceSymbol < 0 || distanceSymbol >= DeflateDecoder.Inflater.intValueArray3.Length)
				{
					return false;
				}
				inflater.intValue4 = DeflateDecoder.Inflater.intValueArray3[distanceSymbol];
				inflater.intValue2 = DeflateDecoder.Inflater.intValueArray4[distanceSymbol];
				inflater.intValue = 10;
				continue;
			case 10:
				if (inflater.intValue2 > 0)
				{
					int extraDistance = RecoveredRuntime.PeekDeflateBits(inflater.deflateInputBuffer, inflater.intValue2);
					if (extraDistance < 0)
					{
						return false;
					}
					RecoveredRuntime.DropDeflateBits(inflater.deflateInputBuffer, inflater.intValue2);
					inflater.intValue4 += extraDistance;
				}
				RecoveredRuntime.CopyDeflateMatch(inflater.deflateOutputWindow, inflater.intValue3, inflater.intValue4);
				availableOutput -= inflater.intValue3;
				inflater.intValue = 7;
				continue;
			default:
				return false;
			}
		}
		return true;
	}

	internal unsafe static void ZeroMemory(long longValue, IntPtr address, byte byteValue)
	{
		byte* ptr = (byte*)((void*)address);
		byte* ptr2 = ptr + longValue;
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
					*(short*)ptr = (short)byteValue;
					ptr += 2;
				}
				else
				{
					*(int*)ptr = (int)byteValue;
					ptr += 4;
				}
			}
			else
			{
				*(long*)ptr = (long)((ulong)byteValue);
				ptr += 8;
			}
		}
		*(ptr++) = byteValue;
	}

	internal static int GetRemoteStructureSize(Type typeValue)
	{
		if (!typeValue.IsSubclassOf(typeof(RemotePlatformStructure)))
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(25005));
		}
		if (RemotePlatformStructure.dictionary.ContainsKey(typeValue))
		{
			return RemotePlatformStructure.dictionary[typeValue].Last<int>();
		}
		if (RemotePlatformStructure.dictionary2.ContainsKey(typeValue))
		{
			return RemotePlatformStructure.dictionary2[typeValue].Last<int>();
		}
		int count = RemotePlatformStructure.dictionary.Count;
		int count2 = RemotePlatformStructure.dictionary2.Count;
		RuntimeHelpers.RunClassConstructor(typeValue.TypeHandle);
		if (RemotePlatformStructure.dictionary.Count == count && RemotePlatformStructure.dictionary2.Count == count2)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(13137) + typeValue + EncodedStringTable.DecodeString(3656));
		}
		return RecoveredRuntime.GetRemoteStructureSize(typeValue);
	}

	internal static uint GetInvertedFunctionTableCount(InvertedFunctionTable32 invertedFunctionTable32)
	{
		return invertedFunctionTable32.ReadField<uint>(0);
	}

	internal static void SaveScrambledImage(string text, PeScrambler peScrambler)
	{
		SavePeImage(text, peScrambler.peImage);
	}

	internal static ushort ReadResourceUInt16(ResourceDirectory resourceDirectory)
	{
		return resourceDirectory.boundsCheckedBinaryReader.ReadUInt16();
	}

	internal static void ZeroFillImageRange(PeScrambler peScrambler, long longValue, long longValue2)
	{
		byte[] buffer = new byte[longValue2];
		peScrambler.peImage.GetStream().Position = longValue;
		peScrambler.binaryWriter.Write(buffer);
	}

	internal static int FindAsciiPattern(byte[] bytes, string text, int intValue)
	{
		if (intValue + text.Length > bytes.Length)
		{
			return -1;
		}
		if (bytes.Length - intValue < 20000 || text.Length < 5)
		{
			return RecoveredRuntime.FindAsciiSequence(bytes, text, intValue);
		}
		int length = text.Length;
		byte[] array = new byte[length];
		for (int i = 0; i < length; i++)
		{
			array[i] = (byte)text[i];
		}
		return RecoveredRuntime.FindByteSequence(bytes, array, intValue);
	}

	internal static bool HasResourceName(ResourceIdentifier resourceIdentifier)
	{
		return resourceIdentifier.GetName() != null;
	}

	internal static void CloseRemoteMemoryAccessor(RemoteMemoryAccessor remoteMemoryAccessor)
	{
		if (remoteMemoryAccessor.GetMemoryApi() != null)
		{
			remoteMemoryAccessor.GetMemoryApi().CloseHandle(remoteMemoryAccessor.GetProcessHandle());
			return;
		}
		if (remoteMemoryAccessor.GetProcessHandle() != IntPtr.Zero)
		{
			RecoveredRuntime.CloseHandle(remoteMemoryAccessor.GetProcessHandle());
			remoteMemoryAccessor.SetProcessHandle(IntPtr.Zero);
		}
	}

	internal static void DropDeflateBits(DeflateDecoder.DeflateInputBuffer deflateInputBuffer, int intValue)
	{
		deflateInputBuffer.uintValue >>= intValue;
		deflateInputBuffer.intValue3 -= intValue;
	}

	internal static void SetPebLdrDataAddress(IntPtr address, RemotePebLdrData remotePebLdrData)
	{
		remotePebLdrData.SetAddress(address);
	}

	internal static int GetAvailableDeflateInputBytes(DeflateDecoder.DeflateInputBuffer deflateInputBuffer)
	{
		return deflateInputBuffer.intValue2 - deflateInputBuffer.intValue + (deflateInputBuffer.intValue3 >> 3);
	}

	internal static string ReadNullTerminatedAsciiString(BoundsCheckedBinaryReader boundsCheckedBinaryReader)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string result;
		try
		{
			bool flag = true;
			while (flag)
			{
				byte[] array = boundsCheckedBinaryReader.ReadBytes(16);
				for (int i = 0; i < 16; i++)
				{
					byte b = array[i];
					if (b == 0)
					{
						boundsCheckedBinaryReader.BaseStream.Position -= (long)(15 - i);
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

	internal static void ParseResourceDirectoryNode(ResourceDirectoryNode resourceDirectoryNode)
	{
		if (resourceDirectoryNode.longValue < 0L)
		{
			return;
		}
		if (!RecoveredRuntime.IsResourceRangeValid(resourceDirectoryNode.resourceDirectory, resourceDirectoryNode.longValue, 16))
		{
			return;
		}
		if (!RecoveredRuntime.SeekResourceOffset(resourceDirectoryNode.resourceDirectory, resourceDirectoryNode.longValue))
		{
			return;
		}
		resourceDirectoryNode.SetCharacteristics(RecoveredRuntime.ReadResourceUInt32(resourceDirectoryNode.resourceDirectory));
		resourceDirectoryNode.SetTimeDateStamp(RecoveredRuntime.ReadResourceUInt32(resourceDirectoryNode.resourceDirectory));
		resourceDirectoryNode.SetMajorVersion(RecoveredRuntime.ReadResourceUInt16(resourceDirectoryNode.resourceDirectory));
		resourceDirectoryNode.SetMinorVersion(RecoveredRuntime.ReadResourceUInt16(resourceDirectoryNode.resourceDirectory));
		int num = (int)RecoveredRuntime.ReadResourceUInt16(resourceDirectoryNode.resourceDirectory);
		int num2 = (int)RecoveredRuntime.ReadResourceUInt16(resourceDirectoryNode.resourceDirectory);
		int num3 = num + num2;
		if (RecoveredRuntime.IsCurrentResourceRangeValid(resourceDirectoryNode.resourceDirectory, num3 * 8))
		{
			long num4 = 0L;
			long num5 = resourceDirectoryNode.longValue + 16L;
			while (num4 < (long)num3)
			{
				RecoveredRuntime.SeekResourceOffset(resourceDirectoryNode.resourceDirectory, num5);
				uint num6 = RecoveredRuntime.ReadResourceUInt32(resourceDirectoryNode.resourceDirectory);
				uint num7 = RecoveredRuntime.ReadResourceUInt32(resourceDirectoryNode.resourceDirectory);
				string text = null;
				int int_ = -1;
				if ((num6 & 2147483648u) == 0u)
				{
					int_ = (int)num6;
				}
				else
				{
					text = RecoveredRuntime.ReadResourceDirectoryString((int)(num6 & 2147483647u), resourceDirectoryNode.resourceDirectory);
					if (text == null)
					{
						return;
					}
				}
				if ((num7 & 2147483648u) == 0u)
				{
					if (!RecoveredRuntime.SeekResourceOffset(resourceDirectoryNode.resourceDirectory, (long)num7) || !RecoveredRuntime.IsCurrentResourceRangeValid(resourceDirectoryNode.resourceDirectory, 16))
					{
						break;
					}
					uint num8 = RecoveredRuntime.ReadResourceUInt32(resourceDirectoryNode.resourceDirectory);
					uint uint_ = RecoveredRuntime.ReadResourceUInt32(resourceDirectoryNode.resourceDirectory);
					if (num8 != 0u)
					{
						if (text == null)
						{
							resourceDirectoryNode.GetDataEntries().Add(new ResourceDataEntry(int_, num8, uint_));
						}
						else
						{
							resourceDirectoryNode.GetDataEntries().Add(new ResourceDataEntry(text, num8, uint_));
						}
					}
				}
				else
				{
					int num9 = (int)(num7 & 2147483647u);
					if (num9 != 0 && (long)num9 != resourceDirectoryNode.longValue)
					{
						if (text == null)
						{
							resourceDirectoryNode.GetSubdirectories().Add(new ResourceDirectoryNode(int_, resourceDirectoryNode.resourceDirectory, (long)num9));
						}
						else
						{
							resourceDirectoryNode.GetSubdirectories().Add(new ResourceDirectoryNode(text, resourceDirectoryNode.resourceDirectory, (long)num9));
						}
					}
				}
				num4 += 1L;
				num5 += 8L;
			}
			return;
		}
	}

	internal static int FindMaskedPattern(byte[] bytes, string text, string text2, int intValue)
	{
		if (intValue >= bytes.Length || text.Length != text2.Length || intValue + text.Length > bytes.Length)
		{
			return -1;
		}
		if (bytes.Length - intValue < 4 || text.Length < 4)
		{
			return RecoveredRuntime.FindMaskedBytePattern(bytes, text, text2, intValue);
		}
		return RecoveredRuntime.FindMaskedByteSequence(intValue, text, text2, bytes);
	}

	internal static uint GetInvertedFunctionTableEntrySize(InvertedFunctionTableEntry32 invertedFunctionTableEntry32)
	{
		return invertedFunctionTableEntry32.ReadField<uint>(3);
	}

	internal static string GenerateRandomIdentifier()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = DynamicIlEmitter.random.Next(5, 30);
		for (int i = 0; i < num; i++)
		{
			stringBuilder.Append((DynamicIlEmitter.random.Next(2) == 1) ? char.ToUpper(EncodedStringTable.DecodeString(17901)[DynamicIlEmitter.random.Next(EncodedStringTable.DecodeString(17901).Length)]) : EncodedStringTable.DecodeString(17901)[DynamicIlEmitter.random.Next(EncodedStringTable.DecodeString(17901).Length)]);
		}
		return stringBuilder.ToString();
	}

	internal static string GenerateFakePdbPath(PeScrambler peScrambler)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(EncodedStringTable.DecodeString(27891)[peScrambler.random.Next(EncodedStringTable.DecodeString(27891).Length)]).Append(':');
		for (int i = 0; i < peScrambler.random.Next(4, 8); i++)
		{
			stringBuilder.Append(EncodedStringTable.DecodeString(27928));
			for (int j = 0; j < peScrambler.random.Next(4, 20); j++)
			{
				stringBuilder.Append(EncodedStringTable.DecodeString(17901)[peScrambler.random.Next(EncodedStringTable.DecodeString(17901).Length)]);
			}
		}
		return stringBuilder.Append(EncodedStringTable.DecodeString(27933)).ToString();
	}

	internal static bool MatchesDependencyName(string text, string text2)
	{
		return (text.StartsWith(EncodedStringTable.DecodeString(27942) + text2, StringComparison.OrdinalIgnoreCase) || text.StartsWith(EncodedStringTable.DecodeString(27951) + text2, StringComparison.OrdinalIgnoreCase)) && (text.EndsWith(EncodedStringTable.DecodeString(16146), StringComparison.OrdinalIgnoreCase) || text.EndsWith(EncodedStringTable.DecodeString(10075), StringComparison.OrdinalIgnoreCase));
	}

	internal static bool DecodeNextDeflateBlock(DeflateDecoder.Inflater inflater)
	{
		switch (inflater.intValue)
		{
		case 2:
			if (inflater.flag)
			{
				inflater.intValue = 12;
				return false;
			}
			int blockHeader = RecoveredRuntime.PeekDeflateBits(inflater.deflateInputBuffer, 3);
			if (blockHeader < 0)
			{
				return false;
			}
			RecoveredRuntime.DropDeflateBits(inflater.deflateInputBuffer, 3);
			if ((blockHeader & 1) != 0)
			{
				inflater.flag = true;
			}
			switch (blockHeader >> 1)
			{
			case 0:
				RecoveredRuntime.AlignDeflateInputToByteBoundary(inflater.deflateInputBuffer);
				inflater.intValue = 3;
				break;
			case 1:
				inflater.deflateHuffmanTree = DeflateDecoder.DeflateHuffmanTree.deflateHuffmanTree;
				inflater.deflateHuffmanTree2 = DeflateDecoder.DeflateHuffmanTree.deflateHuffmanTree2;
				inflater.intValue = 7;
				break;
			case 2:
				inflater.dynamicHuffmanHeader = new DeflateDecoder.DynamicHuffmanHeader();
				inflater.intValue = 6;
				break;
			default:
				inflater.intValue = 11;
				return false;
			}
			return true;
		case 3:
			int storedLength = RecoveredRuntime.PeekDeflateBits(inflater.deflateInputBuffer, 16);
			if (storedLength < 0)
			{
				return false;
			}
			inflater.intValue5 = storedLength;
			RecoveredRuntime.DropDeflateBits(inflater.deflateInputBuffer, 16);
			inflater.intValue = 4;
			break;
		case 4:
			break;
		case 5:
			return RecoveredRuntime.ContinueStoredDeflateBlock(inflater);
		case 6:
			if (!RecoveredRuntime.ReadDynamicDeflateTrees(inflater.dynamicHuffmanHeader, inflater.deflateInputBuffer))
			{
				return false;
			}
			inflater.deflateHuffmanTree = RecoveredRuntime.BuildLiteralLengthHuffmanTree(inflater.dynamicHuffmanHeader);
			inflater.deflateHuffmanTree2 = RecoveredRuntime.BuildDistanceHuffmanTree(inflater.dynamicHuffmanHeader);
			inflater.intValue = 7;
			return RecoveredRuntime.DecodeCompressedDeflateBlock(inflater);
		case 7:
		case 8:
		case 9:
		case 10:
			return RecoveredRuntime.DecodeCompressedDeflateBlock(inflater);
		default:
			return false;
		}

		int storedLengthComplement = RecoveredRuntime.PeekDeflateBits(inflater.deflateInputBuffer, 16);
		if (storedLengthComplement < 0)
		{
			return false;
		}
		RecoveredRuntime.DropDeflateBits(inflater.deflateInputBuffer, 16);
		if ((inflater.intValue5 ^ 65535) != storedLengthComplement)
		{
			inflater.intValue = 11;
			return false;
		}
		inflater.intValue = 5;
		return RecoveredRuntime.ContinueStoredDeflateBlock(inflater);
	}

	internal static bool ContinueStoredDeflateBlock(DeflateDecoder.Inflater decoder)
	{
		int copiedByteCount = RecoveredRuntime.CopyStoredDeflateBytes(decoder.deflateOutputWindow, decoder.deflateInputBuffer, decoder.intValue5);
		decoder.intValue5 -= copiedByteCount;
		if (decoder.intValue5 != 0)
		{
			return !RecoveredRuntime.IsDeflateInputExhausted(decoder.deflateInputBuffer);
		}
		decoder.intValue = 2;
		return true;
	}

	internal static void FillImageRangeWithRandomBytes(PeScrambler peScrambler, long longValue, long longValue2)
	{
		byte[] buffer = new byte[longValue2];
		peScrambler.random.NextBytes(buffer);
		peScrambler.peImage.GetStream().Position = longValue;
		peScrambler.binaryWriter.Write(buffer);
	}

	internal static int ReadUInt16LittleEndian(DeflateDecoder.ReadOnlyMemoryStream readOnlyMemoryStream)
	{
		return readOnlyMemoryStream.ReadByte() | (readOnlyMemoryStream.ReadByte() << 8);
	}

	internal static string ResolveDependencyPath(string text5, string text6, string text7, DependencySearchFlags dependencySearchFlags, int intValue, IntPtr address)
	{
		ApiSetSchema.ApiSetContractMatcher @class = new ApiSetSchema.ApiSetContractMatcher();
		text5 = text5.ToLowerInvariant();
		text6 = (string.IsNullOrEmpty(text6) ? string.Empty : text6.ToLowerInvariant());
		@class.text = Path.GetFileName(text5);
		if (!PlatformInfo.flag8 && @class.text.StartsWith(EncodedStringTable.DecodeString(27960)))
		{
			@class.text = @class.text.Substring(4);
		}
		KeyValuePair<string, List<string>> keyValuePair = ApiSetSchema.dictionary.FirstOrDefault(new Func<KeyValuePair<string, List<string>>, bool>(@class.MatchesContract));
		if (text6.Length > 0 && keyValuePair.Key != null && keyValuePair.Value != null && keyValuePair.Value.Count >= 1)
		{
			List<string> value = keyValuePair.Value;
			text5 = ((value.First<string>() != text6) ? value.First<string>() : value.Last<string>());
			if (RecoveredRuntime.ResolveSideBySideDllPath(ref text5, address))
			{
				return text5;
			}
			if ((dependencySearchFlags & DependencySearchFlags.ResolveApiSetToSystemDirectory) == DependencySearchFlags.None)
			{
				return text5;
			}
			if ((dependencySearchFlags & DependencySearchFlags.UseWow64SystemDirectory) != DependencySearchFlags.None)
			{
				return Path.Combine(PlatformInfo.text3, text5);
			}
			return Path.Combine(PlatformInfo.text2, text5);
		}
		else
		{
			if ((dependencySearchFlags & DependencySearchFlags.ApiSetOnly) != DependencySearchFlags.None)
			{
				return null;
			}
			if (RecoveredRuntime.ResolveSideBySideDllPath(ref text5, address))
			{
				return text5;
			}
			if ((dependencySearchFlags & DependencySearchFlags.SideBySideOnly) != DependencySearchFlags.None)
			{
				return null;
			}
			if (Path.IsPathRooted(text5) && File.Exists(text5))
			{
				return text5;
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
						if (text != null && text.Equals(@class.text, StringComparison.OrdinalIgnoreCase))
						{
							string text2 = registryKey.GetValue(((dependencySearchFlags & DependencySearchFlags.UseWow64SystemDirectory) != DependencySearchFlags.None) ? EncodedStringTable.DecodeString(28071) : EncodedStringTable.DecodeString(28054)) as string;
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
			if (!string.IsNullOrEmpty(text7))
			{
				text3 = Path.Combine(text7, @class.text);
				if (File.Exists(text3))
				{
					return text3;
				}
			}
			if (intValue != 0)
			{
				text3 = Path.Combine(Path.GetDirectoryName(RecoveredRuntime.OpenRemoteProcessById(intValue).FilePath), @class.text);
				if (File.Exists(text3))
				{
					return text3;
				}
			}
			text3 = Path.Combine(((dependencySearchFlags & DependencySearchFlags.UseWow64SystemDirectory) != DependencySearchFlags.None) ? PlatformInfo.text3 : PlatformInfo.text2, @class.text);
			if (File.Exists(text3))
			{
				return text3;
			}
			text3 = Path.Combine(PlatformInfo.text, @class.text);
			if (File.Exists(text3))
			{
				return text3;
			}
			text3 = Path.Combine(Environment.CurrentDirectory, @class.text);
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
					if ((dependencySearchFlags & DependencySearchFlags.UseWow64SystemDirectory) == DependencySearchFlags.None || !text4.Equals(PlatformInfo.text2, StringComparison.OrdinalIgnoreCase))
					{
						text3 = Path.Combine(text4, @class.text);
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

	internal static string FormatByteSize(long longValue)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		RecoveredRuntime.StrFormatByteSize(longValue, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	internal static bool TryReadDosHeader(ref DosHeader dosHeader, [Out] BoundsCheckedBinaryReader boundsCheckedBinaryReader)
	{
		dosHeader = null;
		if (boundsCheckedBinaryReader.BaseStream.Length < 128L)
		{
			return false;
		}
		dosHeader = new DosHeader();
		if (boundsCheckedBinaryReader.ReadUInt16() == 23117)
		{
			RecoveredRuntime.SkipBytes(boundsCheckedBinaryReader, 58);
			dosHeader.SetPeHeaderOffset(boundsCheckedBinaryReader.ReadUInt32());
			return true;
		}
		return false;
	}

	internal static IntPtr GetWindowClassLongPtr(IntPtr address, int intValue)
	{
		if (PlatformInfo.flag)
		{
			return GetClassLongPtr(address, intValue);
		}
		return (IntPtr)GetClassLong(address, intValue);
	}
}
