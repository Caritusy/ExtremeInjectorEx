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

	internal static uint RemapRva(IEnumerable<PeScrambler.SectionRemap> items, uint uintValue)
	{
		foreach (PeScrambler.SectionRemap @class in items.Skip(1))
		{
			if (uintValue >= @class.GetOriginalSection().GetVirtualAddress() && uintValue < @class.GetOriginalSection().GetVirtualAddress() + @class.GetOriginalSection().GetVirtualSize())
			{
				uint num = uintValue - @class.GetOriginalSection().GetVirtualAddress();
				return @class.GetModifiedSection().GetVirtualAddress() + num + @class.GetContentOffset();
			}
		}
		return uintValue;
	}

	internal static bool EnableTokenPrivilege(string text)
	{
		if (!RecoveredRuntime.OpenProcessToken(RecoveredRuntime.GetCurrentProcess(), 40u, out IntPtr tokenHandle))
		{
			return false;
		}

		try
		{
			if (!RecoveredRuntime.LookupPrivilegeValue(null, text, out TokenPrivilegeNativeTypes.Luid privilegeId))
			{
				return false;
			}

			TokenPrivilegeNativeTypes.TokenPrivileges privileges = default(TokenPrivilegeNativeTypes.TokenPrivileges);
			privileges.PrivilegeCount = 1u;
			privileges.PrivilegeLuid = privilegeId;
			privileges.Attributes = 2u;
			return RecoveredRuntime.AdjustTokenPrivileges(tokenHandle, false, ref privileges, 0u, IntPtr.Zero, IntPtr.Zero);
		}
		finally
		{
			RecoveredRuntime.CloseHandle(tokenHandle);
		}
	}

	internal unsafe static int FindMaskedBytePattern(byte[] bytes, string text, string text2, int intValue)
	{
		return IndexOfMaskedByteString(bytes, text, text2, intValue);
}

	internal static void RemapExportDirectory(List<PeScrambler.SectionRemap> items, PeScrambler peScrambler)
	{
		if (peScrambler.peImage.GetExports() == null)
		{
			return;
		}
		peScrambler.peImage.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(peScrambler.peImage, peScrambler.peImage.GetExports().GetAddressOfFunctions());
		BinaryReader binaryReader = new BinaryReader(peScrambler.peImage.GetStream());
		BinaryWriter binaryWriter = new BinaryWriter(peScrambler.peImage.GetStream());
		int num = 0;
		while ((long)num < (long)((ulong)peScrambler.peImage.GetExports().GetNumberOfFunctions()))
		{
			uint uint_ = binaryReader.ReadUInt32();
			peScrambler.peImage.GetStream().Position -= 4L;
			binaryWriter.Write(RecoveredRuntime.RemapRva(items, uint_));
			num++;
		}
		peScrambler.peImage.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(peScrambler.peImage, peScrambler.peImage.GetExports().GetAddressOfNames());
		int num2 = 0;
		while ((long)num2 < (long)((ulong)peScrambler.peImage.GetExports().GetNumberOfNames()))
		{
			uint uintValue = binaryReader.ReadUInt32();
			peScrambler.peImage.GetStream().Position -= 4L;
			binaryWriter.Write(RecoveredRuntime.RemapRva(items, uintValue));
			num2++;
		}
		peScrambler.peImage.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(peScrambler.peImage, peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[0].GetVirtualAddress()) + 28L;
		binaryWriter.Write(RecoveredRuntime.RemapRva(items, peScrambler.peImage.GetExports().GetAddressOfFunctions()));
		binaryWriter.Write(RecoveredRuntime.RemapRva(items, peScrambler.peImage.GetExports().GetAddressOfNames()));
		binaryWriter.Write(RecoveredRuntime.RemapRva(items, peScrambler.peImage.GetExports().GetAddressOfNameOrdinals()));
	}

	internal static bool MatchesMaskedBytePattern(int intValue, string text, byte[] bytes, string text2)
	{
		if (intValue + text.Length > bytes.Length)
		{
			return false;
		}
		for (int i = 0; i < text.Length; i++)
		{
			if ((char)bytes[intValue + i] != text[i] && text2[i] != '?')
			{
				return false;
			}
		}
		return true;
	}

	internal static int ReadDeflateInt32(DeflateDecoder.ReadOnlyMemoryStream readOnlyMemoryStream)
	{
		return ReadUInt16LittleEndian(readOnlyMemoryStream) | (ReadUInt16LittleEndian(readOnlyMemoryStream) << 16);
	}

	internal static void CompactPeHeaders(PeScrambler peScrambler)
	{
		if (peScrambler.peImage.GetDosHeader().GetPeHeaderOffset() == 64u)
		{
			return;
		}
		int num = (int)(24 + peScrambler.peImage.GetHeaders().GetCoffHeader().GetSizeOfOptionalHeader()) + peScrambler.peImage.GetSections().Count * 40;
		byte[] buffer;
		using (Stream stream = RecoveredRuntime.CopyImageRange(peScrambler.peImage, (long)((ulong)peScrambler.peImage.GetDosHeader().GetPeHeaderOffset()), num))
		using (BinaryReader binaryReader = new BinaryReader(stream))
		{
			buffer = binaryReader.ReadBytes(num);
		}
		RecoveredRuntime.ZeroFillImageRange(peScrambler, 64L, (long)((ulong)(peScrambler.peImage.GetDosHeader().GetPeHeaderOffset() - 64u) + (ulong)((long)num)));
		peScrambler.peImage.GetStream().Position = 64L;
		peScrambler.binaryWriter.Write(buffer);
		peScrambler.peImage.GetDosHeader().SetPeHeaderOffset(64u);
	}

	internal static void RemapResourceDirectory(List<PeScrambler.SectionRemap> items, PeScrambler peScrambler)
	{
		if (peScrambler.peImage.GetResources() == null)
		{
			return;
		}
		BinaryWriter binaryWriter = new BinaryWriter(peScrambler.peImage.GetStream());
		BinaryReader binaryReader = new BinaryReader(peScrambler.peImage.GetStream());
		long num = RecoveredRuntime.MapRvaToFileOffset(peScrambler.peImage, peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[2].GetVirtualAddress());
		foreach (ResourceDirectoryNode @class in RecoveredRuntime.EnumerateResourceNodes(peScrambler.peImage.GetResources().GetRoot()))
		{
			peScrambler.peImage.GetStream().Position = num + @class.longValue;
			peScrambler.peImage.GetStream().Position += 12L;
			ushort num2 = binaryReader.ReadUInt16();
			ushort num3 = binaryReader.ReadUInt16();
			long position = peScrambler.peImage.GetStream().Position;
			for (int i = 0; i < (int)(num2 + num3); i++)
			{
				peScrambler.peImage.GetStream().Position = position + (long)(i * 8);
				peScrambler.peImage.GetStream().Position += 4L;
				uint num4 = binaryReader.ReadUInt32();
				if ((num4 & 2147483648u) == 0u)
				{
					peScrambler.peImage.GetStream().Position = num + (long)((ulong)num4);
					uint uint_ = binaryReader.ReadUInt32();
					peScrambler.peImage.GetStream().Position -= 4L;
					BinaryWriter binaryWriter2 = binaryWriter;
					uint value;
					@class.GetDataEntries()[i].SetDataRva(value = RecoveredRuntime.RemapRva(items, uint_));
					binaryWriter2.Write(value);
				}
			}
		}
	}

	internal static void WriteScrambledImage(PeScrambler peScrambler, Stream stream)
	{
		WritePeImage(stream, peScrambler.peImage);
	}

	internal static int PeekDeflateBits(DeflateDecoder.DeflateInputBuffer deflateInputBuffer, int intValue)
	{
		if (deflateInputBuffer.intValue3 < intValue)
		{
			if (deflateInputBuffer.intValue == deflateInputBuffer.intValue2)
			{
				return -1;
			}
			deflateInputBuffer.uintValue |= (uint)((uint)((int)(deflateInputBuffer.bytes[deflateInputBuffer.intValue++] & byte.MaxValue) | (int)(deflateInputBuffer.bytes[deflateInputBuffer.intValue++] & byte.MaxValue) << 8) << deflateInputBuffer.intValue3);
			deflateInputBuffer.intValue3 += 16;
		}
		return (int)((ulong)deflateInputBuffer.uintValue & (ulong)((long)((1 << intValue) - 1)));
	}

	internal static DeflateDecoder.DeflateHuffmanTree BuildDistanceHuffmanTree(DeflateDecoder.DynamicHuffmanHeader dynamicHuffmanHeader)
	{
		byte[] array = new byte[dynamicHuffmanHeader.intValue3];
		Array.Copy(dynamicHuffmanHeader.bytes2, dynamicHuffmanHeader.intValue2, array, 0, dynamicHuffmanHeader.intValue3);
		return new DeflateDecoder.DeflateHuffmanTree(array);
	}

	internal static DeflateDecoder.DeflateHuffmanTree BuildLiteralLengthHuffmanTree(DeflateDecoder.DynamicHuffmanHeader dynamicHuffmanHeader)
	{
		byte[] array = new byte[dynamicHuffmanHeader.intValue2];
		Array.Copy(dynamicHuffmanHeader.bytes2, 0, array, 0, dynamicHuffmanHeader.intValue2);
		return new DeflateDecoder.DeflateHuffmanTree(array);
	}

	internal static int CopyDeflateInput(DeflateDecoder.DeflateInputBuffer deflateInputBuffer, byte[] bytes, int intValue, int intValue2)
	{
		int num = 0;
		while (deflateInputBuffer.intValue3 > 0 && intValue2 > 0)
		{
			bytes[intValue++] = (byte)deflateInputBuffer.uintValue;
			deflateInputBuffer.uintValue >>= 8;
			deflateInputBuffer.intValue3 -= 8;
			intValue2--;
			num++;
		}
		if (intValue2 != 0)
		{
			int num2 = deflateInputBuffer.intValue2 - deflateInputBuffer.intValue;
			if (intValue2 > num2)
			{
				intValue2 = num2;
			}
			Array.Copy(deflateInputBuffer.bytes, deflateInputBuffer.intValue, bytes, intValue, intValue2);
			deflateInputBuffer.intValue += intValue2;
			if ((deflateInputBuffer.intValue - deflateInputBuffer.intValue2 & 1) != 0)
			{
				deflateInputBuffer.uintValue = (uint)(deflateInputBuffer.bytes[deflateInputBuffer.intValue++] & byte.MaxValue);
				deflateInputBuffer.intValue3 = 8;
			}
			return num + intValue2;
		}
		return num;
	}

	internal static void WriteDeflateLiteral(DeflateDecoder.DeflateOutputWindow deflateOutputWindow, int intValue)
	{
		int num = deflateOutputWindow.intValue2++;
		if (num != 32768)
		{
			deflateOutputWindow.bytes[deflateOutputWindow.intValue++] = (byte)intValue;
			deflateOutputWindow.intValue &= 32767;
			return;
		}
		throw new InvalidOperationException();
	}

	internal static void ZeroBytePatternOccurrences(byte[] bytes, PeScrambler peScrambler)
	{
		BinaryWriter binaryWriter = new BinaryWriter(peScrambler.peImage.GetStream());
		long num = 0L;
		while ((num = RecoveredRuntime.FindPatternOffset(peScrambler, bytes, num)) != -1L)
		{
			peScrambler.peImage.GetStream().Position = num;
			for (int i = 0; i < bytes.Length; i++)
			{
				binaryWriter.Write(0);
			}
			num += 1L;
		}
	}

	internal static bool IsForwardedExport(ExportedSymbol exportedSymbol)
	{
		return exportedSymbol.GetForwarder() != null;
	}

	internal static void SetRemotePebAddress(RemotePeb remotePeb, IntPtr address)
	{
		remotePeb.SetAddress(address);
	}

	internal static bool HasNumericResourceIdentifier(ResourceIdentifier resourceIdentifier)
	{
		return !HasResourceName(resourceIdentifier);
	}

	internal static void RemapDebugDirectory(IEnumerable<PeScrambler.SectionRemap> items, PeScrambler peScrambler)
	{
		if (peScrambler.peImage.GetDebugDirectory() != null)
		{
			BinaryWriter binaryWriter = new BinaryWriter(peScrambler.peImage.GetStream());
			peScrambler.peImage.GetStream().Position = MapRvaToFileOffset(peScrambler.peImage, peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[6].GetVirtualAddress()) + 20L;
			uint value;
			peScrambler.peImage.GetDebugDirectory().SetAddressOfRawData(value = RemapRva(items, peScrambler.peImage.GetDebugDirectory().GetAddressOfRawData()));
			binaryWriter.Write(value);
			peScrambler.peImage.GetDebugDirectory().SetPointerToRawData(value = (uint)MapRvaToFileOffset(peScrambler.peImage, peScrambler.peImage.GetDebugDirectory().GetPointerToRawData()));
			binaryWriter.Write(value);
		}
	}

	internal static void ScramblePeImage(PeScrambler peScrambler)
	{
		peScrambler.peImage.GetHeaders().GetOptionalHeader().SetChecksum(0u);
		if (peScrambler.peScrambleOptions.RemoveUselessData)
		{
			RecoveredRuntime.CompactPeHeaders(peScrambler);
		}
		if (peScrambler.peScrambleOptions.ScrambleHeaderFields)
		{
			RecoveredRuntime.ScramblePeHeaderFields(peScrambler);
		}
		if (peScrambler.peScrambleOptions.ModifyAssemblyCode)
		{
			peScrambler.RemoveCodePadding();
		}
		if (peScrambler.peScrambleOptions.RemoveDebugData || (peScrambler.peScrambleOptions.InsertExtraSections && peScrambler.peScrambleOptions.CreateFakeDebugDirectory))
		{
			RecoveredRuntime.RemoveDebugDirectory(peScrambler);
		}
		if (peScrambler.peScrambleOptions.RenameSections)
		{
			peScrambler.RandomizeSectionNames();
		}
		if (peScrambler.peScrambleOptions.ShiftSectionMemory)
		{
			RecoveredRuntime.RemapPeSections(peScrambler);
		}
		if (peScrambler.peScrambleOptions.InsertExtraSections)
		{
			peScrambler.AddDecoySections();
		}
		if (peScrambler.peScrambleOptions.ShiftSectionData)
		{
			peScrambler.InsertHeaderPadding();
		}
		if (peScrambler.peScrambleOptions.ModifyImportTable)
		{
			RecoveredRuntime.RandomizeImportNameCasing(peScrambler);
		}
		if (peScrambler.peScrambleOptions.ShiftSectionMemory)
		{
			RecoveredRuntime.NormalizeSectionVirtualSizes(peScrambler);
		}
		if (peScrambler.peScrambleOptions.StripSectionCharacteristics)
		{
			peScrambler.StripSectionAlignmentFlags();
		}
	}

	internal static int DecodeHuffmanSymbol(DeflateDecoder.DeflateHuffmanTree deflateHuffmanTree, DeflateDecoder.DeflateInputBuffer deflateInputBuffer)
	{
		int num;
		if ((num = RecoveredRuntime.PeekDeflateBits(deflateInputBuffer, 9)) >= 0)
		{
			int num2;
			if ((num2 = (int)deflateHuffmanTree.shortValueArray[num]) >= 0)
			{
				RecoveredRuntime.DropDeflateBits(deflateInputBuffer, num2 & 15);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 15;
			if ((num = RecoveredRuntime.PeekDeflateBits(deflateInputBuffer, int_)) >= 0)
			{
				num2 = (int)deflateHuffmanTree.shortValueArray[num3 | num >> 9];
				RecoveredRuntime.DropDeflateBits(deflateInputBuffer, num2 & 15);
				return num2 >> 4;
			}
			int intValue = deflateInputBuffer.intValue3;
			num = RecoveredRuntime.PeekDeflateBits(deflateInputBuffer, intValue);
			num2 = (int)deflateHuffmanTree.shortValueArray[num3 | num >> 9];
			if ((num2 & 15) <= intValue)
			{
				RecoveredRuntime.DropDeflateBits(deflateInputBuffer, num2 & 15);
				return num2 >> 4;
			}
			return -1;
		}

		int availableBits = deflateInputBuffer.intValue3;
		num = RecoveredRuntime.PeekDeflateBits(deflateInputBuffer, availableBits);
		int fallbackEntry = (int)deflateHuffmanTree.shortValueArray[num];
		if (fallbackEntry < 0 || (fallbackEntry & 15) > availableBits)
		{
			return -1;
		}
		RecoveredRuntime.DropDeflateBits(deflateInputBuffer, fallbackEntry & 15);
		return fallbackEntry >> 4;
	}

	internal static byte[] GetBeaEngineX64Image()
	{
		return (byte[])GetEmbeddedResourceManager().GetObject("BeaEnginex64", EmbeddedResources.cultureInfo);
	}

	internal static void InitializeResourceDirectoryNode(long longValue, ResourceDirectory resourceDirectory, ResourceDirectoryNode resourceDirectoryNode)
	{
		resourceDirectoryNode.SetDataEntries(new List<ResourceDataEntry>());
		resourceDirectoryNode.SetSubdirectories(new List<ResourceDirectoryNode>());
		resourceDirectoryNode.resourceDirectory = resourceDirectory;
		resourceDirectoryNode.longValue = longValue;
		ParseResourceDirectoryNode(resourceDirectoryNode);
	}

	internal static bool IsDeflateInputExhausted(DeflateDecoder.DeflateInputBuffer deflateInputBuffer)
	{
		return deflateInputBuffer.intValue == deflateInputBuffer.intValue2;
	}

	internal static void ClearClrIlOnlyFlag(PeScrambler peScrambler)
	{
		if (peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[14].GetVirtualAddress() == 0u || peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[14].GetSize() <= 0u)
		{
			return;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(peScrambler.peImage, peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[14].GetVirtualAddress());
		if (num == -1L)
		{
			return;
		}
		BinaryReader binaryReader = new BinaryReader(peScrambler.peImage.GetStream());
		peScrambler.peImage.GetStream().Position = num;
		if (binaryReader.ReadUInt32() == 72u)
		{
			peScrambler.peImage.GetStream().Position += 12L;
			uint num2 = binaryReader.ReadUInt32();
			num2 &= 4294967294u;
			peScrambler.peImage.GetStream().Position -= 4L;
			new BinaryWriter(peScrambler.peImage.GetStream()).Write(num2);
			return;
		}
	}

	internal static int GetRemoteStructureRegisteredSize(Type typeValue)
	{
		int[] array;
		if (RemotePlatformStructure.dictionary.TryGetValue(typeValue, out array) || RemotePlatformStructure.dictionary2.TryGetValue(typeValue, out array))
		{
			return array[array.Length - 1];
		}
		int count = RemotePlatformStructure.dictionary.Count;
		int count2 = RemotePlatformStructure.dictionary2.Count;
		RuntimeHelpers.RunClassConstructor(typeValue.TypeHandle);
		if (RemotePlatformStructure.dictionary.Count != count || RemotePlatformStructure.dictionary2.Count != count2)
		{
			return RecoveredRuntime.GetRemoteStructureRegisteredSize(typeValue);
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(13137) + typeValue + EncodedStringTable.DecodeString(3656));
	}

	internal static void UnlinkRemoteListEntry(RemoteListEntry remoteListEntry)
	{
		RemoteListEntry @class = remoteListEntry.GetBackwardEntry();
		RemoteListEntry class2 = remoteListEntry.GetForwardEntry();
		@class.SetForwardLink(remoteListEntry.GetForwardLink());
		class2.SetBackwardLink(remoteListEntry.GetBackwardLink());
	}

	internal static int FindByteSequenceOptimized(byte[] bytes, byte[] bytes2, int intValue)
	{
		if (intValue + bytes2.Length > bytes.Length)
		{
			return -1;
		}
		if (bytes.Length - intValue < 20000 || bytes2.Length < 5)
		{
			return RecoveredRuntime.FindByteSequenceNaive(bytes, bytes2, intValue);
		}
		return RecoveredRuntime.FindByteSequence(bytes, bytes2, intValue);
	}

	internal static int GetLoaderModuleReferenceCount(RemoteModuleManager remoteModuleManager, RemotePeb remotePeb, IntPtr address)
	{
		RemoteLdrDataTableEntry @class = remotePeb.GetLoaderData().GetLoadOrderModuleList().GetModuleEntry();
		while (@class != null && @class.GetModuleBase() != IntPtr.Zero)
		{
			if (!(@class.GetModuleBase() == address))
			{
				@class = @class.GetLoadOrderLinks().GetModuleEntry();
			}
			else
			{
				if (PlatformInfo.flag6)
				{
					return (int)@class.GetDependencyNode().GetLoadCount();
				}
				return (int)@class.GetLoadCount();
			}
		}
		return -1;
	}

	internal static int InflateBytes(byte[] bytes, int intValue, int intValue2, DeflateDecoder.Inflater inflater)
	{
		int num = 0;
		do
		{
			if (inflater.intValue != 11)
			{
				int num2 = RecoveredRuntime.CopyDeflateOutput(intValue, inflater.deflateOutputWindow, intValue2, bytes);
				intValue += num2;
				num += num2;
				intValue2 -= num2;
				if (intValue2 == 0)
				{
					return num;
				}
			}
		}
		while (RecoveredRuntime.DecodeNextDeflateBlock(inflater) || (inflater.deflateOutputWindow.intValue2 > 0 && inflater.intValue != 11));
		return num;
	}

	internal static void CopyDeflateMatch(DeflateDecoder.DeflateOutputWindow deflateOutputWindow, int intValue, int intValue2)
	{
		if ((deflateOutputWindow.intValue2 += intValue) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = deflateOutputWindow.intValue - intValue2 & 32767;
		int num2 = 32768 - intValue;
		if (num > num2 || deflateOutputWindow.intValue >= num2)
		{
			RecoveredRuntime.CopyWrappedDeflateMatch(deflateOutputWindow, num, intValue, intValue2);
			return;
		}
		if (intValue <= intValue2)
		{
			Array.Copy(deflateOutputWindow.bytes, num, deflateOutputWindow.bytes, deflateOutputWindow.intValue, intValue);
			deflateOutputWindow.intValue += intValue;
			return;
		}
		while (intValue-- > 0)
		{
			deflateOutputWindow.bytes[deflateOutputWindow.intValue++] = deflateOutputWindow.bytes[num++];
		}
	}

	internal static bool UnlinkModuleFromPebLists(RemoteModuleUnlinker remoteModuleUnlinker, RemotePeb remotePeb, IntPtr address)
	{
		RemoteLdrDataTableEntry @class = remotePeb.GetLoaderData().GetLoadOrderModuleList().GetModuleEntry();
		while (@class != null && @class.GetModuleBase() != IntPtr.Zero)
		{
			if (@class.GetModuleBase() == address)
			{
				RecoveredRuntime.UnlinkRemoteListEntry(@class.GetInitializationOrderLinks());
				RecoveredRuntime.UnlinkRemoteListEntry(@class.GetLoadOrderLinks());
				RecoveredRuntime.UnlinkRemoteListEntry(@class.GetMemoryOrderLinks());
				RecoveredRuntime.UnlinkRemoteListEntry(@class.GetHashLinks());
				return true;
			}
			@class = @class.GetLoadOrderLinks().GetModuleEntry();
		}
		return false;
	}

	internal static object ParseExportParameterValue(ExportParameter exportParameter)
	{
		if (exportParameter.Type == ExportParameterType.AnsiString || exportParameter.Type == ExportParameterType.UnicodeString)
		{
			return exportParameter.Value;
		}
		if (exportParameter.Type == ExportParameterType.Single)
		{
			return float.Parse(exportParameter.Value);
		}
		if (exportParameter.Type == ExportParameterType.Byte && char.TryParse(exportParameter.Value, out char character))
		{
			return (long)character;
		}

		try
		{
			object converted = new Int64Converter().ConvertFromString(exportParameter.Value);
			if (converted != null)
			{
				return (long)converted;
			}
		}
		catch
		{
		}
		return null;
	}

	internal static void AlignDeflateInputToByteBoundary(DeflateDecoder.DeflateInputBuffer deflateInputBuffer)
	{
		deflateInputBuffer.uintValue >>= deflateInputBuffer.intValue3 & 7;
		deflateInputBuffer.intValue3 &= -8;
	}

	internal static void ReplaceBytePatternOccurrences(byte[] bytes, byte[] bytes2, PeScrambler peScrambler)
	{
		BinaryWriter binaryWriter = new BinaryWriter(peScrambler.peImage.GetStream());
		long num = 0L;
		while ((num = RecoveredRuntime.FindPatternOffset(peScrambler, bytes2, num)) != -1L)
		{
			peScrambler.peImage.GetStream().Position = num;
			binaryWriter.Write(bytes);
			num += 1L;
		}
	}

	internal static byte[] ReadResourceBytes(ResourceDirectory resourceDirectory, int intValue)
	{
		return resourceDirectory.boundsCheckedBinaryReader.ReadBytes(intValue);
	}

	internal static string CreateUniqueTemporaryPath(string extension)
	{
		string temporaryDirectory = Path.GetTempPath();
		while (true)
		{
			string fileName = Guid.NewGuid()
				.ToString("N")
				.Substring(0, PlatformInfo.randomElement.Next(5, 10)) + extension;
			string candidatePath = Path.Combine(temporaryDirectory, fileName);
			if (!File.Exists(candidatePath))
			{
				return candidatePath;
			}
		}
	}

	internal unsafe static int FindByteSequenceNaive(byte[] bytes, byte[] bytes2, int intValue)
	{
		return IndexOfBytes(bytes, bytes2, intValue);
}

	internal static void SeekReader(BoundsCheckedBinaryReader boundsCheckedBinaryReader, long longValue)
	{
		boundsCheckedBinaryReader.BaseStream.Position = longValue;
	}

	internal static InvertedFunctionTableEntry32[] ReadInvertedFunctionTableEntries(InvertedFunctionTable32 invertedFunctionTable32)
	{
		InvertedFunctionTableEntry32[] array = new InvertedFunctionTableEntry32[RecoveredRuntime.GetInvertedFunctionTableCapacity(invertedFunctionTable32)];
		IntPtr intptr_ = RecoveredRuntime.GetRemoteFieldAddress(invertedFunctionTable32, 3);
		int num = RecoveredRuntime.GetRemoteStructureSize(typeof(InvertedFunctionTableEntry32));
		int num2 = 0;
		while ((long)num2 < (long)((ulong)RecoveredRuntime.GetInvertedFunctionTableCount(invertedFunctionTable32)))
		{
			InvertedFunctionTableEntry32[] array2 = array;
			int num3 = num2;
			InvertedFunctionTableEntry32 @class = new InvertedFunctionTableEntry32(intptr_.Add(num2 * num), invertedFunctionTable32.GetProcessHandle());
			@class.SetMemoryApi(invertedFunctionTable32.GetMemoryApi());
			array2[num3] = @class;
			num2++;
		}
		return array;
	}

	internal static byte GenerateSafeRandomInstructionByte()
	{
		while (true)
		{
			byte value = PlatformInfo.randomElement.NextByte();
			bool isUnsafeInstruction =
				(value >= 64 && value <= 97) ||
				(value >= 100 && value <= 103) ||
				(value >= 145 && value <= 151) ||
				(value >= 201 && value <= 204) ||
				(value >= 240 && value <= 245) ||
				(value >= 248 && value <= 253) ||
				value == 38 || value == 39 || value == 46 || value == 47 ||
				value == 54 || value == 55 || value == 62 || value == 63 ||
				value == 195 || value == 206 || value == 207 ||
				value == 214 || value == 215;
			if (!isUnsafeInstruction)
			{
				return value;
			}
		}
	}

	internal static void CopyWrappedDeflateMatch(DeflateDecoder.DeflateOutputWindow deflateOutputWindow, int intValue, int intValue2, int intValue3)
	{
		while (intValue2-- > 0)
		{
			deflateOutputWindow.bytes[deflateOutputWindow.intValue++] = deflateOutputWindow.bytes[intValue++];
			deflateOutputWindow.intValue &= 32767;
			intValue &= 32767;
		}
	}

	internal static int CopyStoredDeflateBytes(DeflateDecoder.DeflateOutputWindow deflateOutputWindow, DeflateDecoder.DeflateInputBuffer deflateInputBuffer, int intValue)
	{
		intValue = Math.Min(Math.Min(intValue, 32768 - deflateOutputWindow.intValue2), RecoveredRuntime.GetAvailableDeflateInputBytes(deflateInputBuffer));
		int num = 32768 - deflateOutputWindow.intValue;
		int num2;
		if (intValue > num)
		{
			num2 = RecoveredRuntime.CopyDeflateInput(deflateInputBuffer, deflateOutputWindow.bytes, deflateOutputWindow.intValue, num);
			if (num2 == num)
			{
				num2 += RecoveredRuntime.CopyDeflateInput(deflateInputBuffer, deflateOutputWindow.bytes, 0, intValue - num);
			}
		}
		else
		{
			num2 = RecoveredRuntime.CopyDeflateInput(deflateInputBuffer, deflateOutputWindow.bytes, deflateOutputWindow.intValue, intValue);
		}
		deflateOutputWindow.intValue = (deflateOutputWindow.intValue + num2 & 32767);
		deflateOutputWindow.intValue2 += num2;
		return num2;
	}

	internal static IntPtr AllocateRemoteMemory(RemoteMemoryAccessor remoteMemoryAccessor, long longValue, NativeTypes.MemoryProtection memoryProtection)
	{
		return remoteMemoryAccessor.AllocateMemory(IntPtr.Zero, longValue, memoryProtection);
	}

	internal static bool IsCurrentResourceRangeValid(ResourceDirectory resourceDirectory, int intValue)
	{
		return IsResourceRangeValid(resourceDirectory, (int)(resourceDirectory.boundsCheckedBinaryReader.BaseStream.Position - resourceDirectory.longValue), intValue);
	}

	internal static byte[] GetBeaEngineX86Image()
	{
		return (byte[])GetEmbeddedResourceManager().GetObject("BeaEnginex86", EmbeddedResources.cultureInfo);
	}

	internal static string FormatThreadPriority(ThreadPriorityLevel threadPriorityLevel)
	{
		string text = threadPriorityLevel.ToString();
		int length = text.Length;
		for (int i = 1; i < length; i++)
		{
			if (char.IsUpper(text[i]))
			{
				text = text.Insert(i, EncodedStringTable.DecodeString(13584));
				break;
			}
		}
		return text;
	}

	internal static bool IsReadableMemoryAddress(IntPtr address)
	{
		NativeTypes.MemoryBasicInformation @struct;
		return RecoveredRuntime.VirtualQuery(address, out @struct, (uint)typeof(NativeTypes.MemoryBasicInformation).SizeOf()) != 0 && ((@struct.memoryProtection2 & NativeTypes.MemoryProtection.ReadOnly) != (NativeTypes.MemoryProtection)0u || (@struct.memoryProtection2 & NativeTypes.MemoryProtection.ExecuteRead) != (NativeTypes.MemoryProtection)0u || (@struct.memoryProtection2 & NativeTypes.MemoryProtection.ExecuteReadWrite) > (NativeTypes.MemoryProtection)0u);
	}

	internal static void RemoveEncodedString(Encoding encoding, PeScrambler peScrambler, string text)
	{
		ZeroBytePatternOccurrences(encoding.GetBytes(text), peScrambler);
	}

	internal static string ReadNullTerminatedByteString(IEnumerable<byte> items)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (byte b in items)
		{
			if (b == 0)
			{
				break;
			}
			stringBuilder.Append((char)b);
		}
		return stringBuilder.ToString();
	}

	internal static RemotePlatformStructure.RemoteFieldLayout CreatePaddedRemoteFieldLayout(Type typeValue, int intValue)
	{
		return new RemotePlatformStructure.RemoteFieldLayout
		{
			intValue = GetPlatformTypeSize(typeValue) + intValue,
			flag = true
		};
	}

	internal static RemotePlatformStructure.RemoteFieldLayout CreateRemoteArrayFieldLayout(Type typeValue, int intValue)
	{
		return new RemotePlatformStructure.RemoteFieldLayout
		{
			intValue = GetPlatformTypeSize(typeValue) * intValue
		};
	}

	internal static uint AlignUp(uint uintValue, uint uintValue2)
	{
		if (uintValue2 % uintValue != 0)
		{
			return uintValue2 + uintValue - uintValue2 % uintValue;
		}
		return uintValue2;
	}

	internal static void RemapPeSections(PeScrambler peScrambler)
	{
		if (peScrambler.peImage.GetBaseRelocations() == null)
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
		while ((long)num < (long)((ulong)peScrambler.peImage.GetHeaders().GetOptionalHeader().GetNumberOfRvaAndSizes()))
		{
			if (peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[num].GetVirtualAddress() != 0u && !source.Contains(num))
			{
				return;
			}
			num++;
		}
		List<PeScrambler.SectionRemap> list = peScrambler.CreateSectionRemap();
		RecoveredRuntime.RemapExportDirectory(list, peScrambler);
		peScrambler.RemapImportDirectory(list);
		RecoveredRuntime.RemapResourceDirectory(list, peScrambler);
		peScrambler.RemapExceptionDirectory(list);
		peScrambler.RemapBaseRelocations(list);
		RecoveredRuntime.RemapDebugDirectory(list, peScrambler);
		RecoveredRuntime.ApplySectionRemap(list, peScrambler);
	}

	internal static Win32Exception CreateWin32ExceptionFromNtStatus(uint uintValue, RemoteCodeExecutorBase remoteCodeExecutorBase)
	{
		int num = RecoveredRuntime.RtlNtStatusToDosError(uintValue);
		if ((long)num == 317L)
		{
			return null;
		}
		Win32Exception ex = new Win32Exception(num);
		if (!ex.Message.StartsWith(EncodedStringTable.DecodeString(14279)))
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

	internal static IntPtr GetRemoteFieldAddress(RemotePlatformStructure remotePlatformStructure, int intValue)
	{
		return remotePlatformStructure.GetAddress().Add(remotePlatformStructure.intValueArray[intValue]);
	}

	internal static int GetCachedNativeTypeSize(Type typeValue)
	{
		int result;
		if (!PlatformInfo.dictionary.TryGetValue(typeValue, out result))
		{
			PlatformInfo.dictionary.Add(typeValue, result = RecoveredRuntime.SizeOfNativeType(typeValue));
		}
		return result;
	}

	internal static bool CanScrambleDataDirectoryCount(PeScrambler peScrambler)
	{
		if (peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[14].GetVirtualAddress() == 0u || peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[14].GetSize() <= 0u)
		{
			return true;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(peScrambler.peImage, peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[14].GetVirtualAddress());
		if (num == -1L)
		{
			return true;
		}
		BinaryReader binaryReader = new BinaryReader(peScrambler.peImage.GetStream());
		peScrambler.peImage.GetStream().Position = num;
		if (binaryReader.ReadUInt32() != 72u)
		{
			return true;
		}
		peScrambler.peImage.GetStream().Position += 12L;
		return (binaryReader.ReadUInt32() & 2u) == 2u;
	}

	internal static string GetModulePath(MainForm.ModuleRow moduleRow)
	{
		return moduleRow.Entry.Path;
	}

	internal static int GetPlatformTypeSize(Type typeValue)
	{
		if (!typeValue.IsSubclassOf(typeof(RemotePlatformStructure)))
		{
			return GetCachedNativeTypeSize(typeValue);
		}
		return GetRemoteStructureRegisteredSize(typeValue);
	}

	internal static void BuildDeflateHuffmanTree(byte[] bytes, DeflateDecoder.DeflateHuffmanTree deflateHuffmanTree)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		foreach (int num in bytes)
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
		deflateHuffmanTree.shortValueArray = new short[num3];
		int num6 = 512;
		for (int k = 15; k >= 10; k--)
		{
			int num7 = num2 & 130944;
			num2 -= array[k] << 16 - k;
			int num8 = num2 & 130944;
			for (int l = num8; l < num7; l += 128)
			{
				deflateHuffmanTree.shortValueArray[(int)RecoveredRuntime.ReverseDeflateBits(l)] = (short)(-num6 << 4 | k);
				num6 += 1 << k - 9;
			}
		}
		for (int m = 0; m < bytes.Length; m++)
		{
			int num9 = (int)bytes[m];
			if (num9 != 0)
			{
				num2 = array2[num9];
				int num10 = (int)RecoveredRuntime.ReverseDeflateBits(num2);
				if (num9 > 9)
				{
					int num11 = (int)deflateHuffmanTree.shortValueArray[num10 & 511];
					int num12 = 1 << (num11 & 15);
					num11 = -(num11 >> 4);
					do
					{
						deflateHuffmanTree.shortValueArray[num11 | num10 >> 9] = (short)(m << 4 | num9);
						num10 += 1 << num9;
					}
					while (num10 < num12);
				}
				else
				{
					do
					{
						deflateHuffmanTree.shortValueArray[num10] = (short)(m << 4 | num9);
						num10 += 1 << num9;
					}
					while (num10 < 512);
				}
				array2[num9] = num2 + (1 << 16 - num9);
			}
		}
	}
}
