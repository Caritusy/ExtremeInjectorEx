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

	internal static uint RemapRva(IEnumerable<PeScrambler.Class132> ienumerable_0, uint uint_0)
	{
		foreach (PeScrambler.Class132 @class in ienumerable_0.Skip(1))
		{
			if (uint_0 >= @class.GetOriginalSection().GetVirtualAddress() && uint_0 < @class.GetOriginalSection().GetVirtualAddress() + @class.GetOriginalSection().GetVirtualSize())
			{
				uint num = uint_0 - @class.GetOriginalSection().GetVirtualAddress();
				return @class.GetModifiedSection().GetVirtualAddress() + num + @class.GetContentOffset();
			}
		}
		return uint_0;
	}

	internal static bool EnableTokenPrivilege(string string_0)
	{
		if (!RecoveredRuntime.OpenProcessToken(RecoveredRuntime.GetCurrentProcess(), 40u, out IntPtr tokenHandle))
		{
			return false;
		}

		try
		{
			if (!RecoveredRuntime.LookupPrivilegeValue(null, string_0, out TokenPrivilegeNativeTypes.Struct35 privilegeId))
			{
				return false;
			}

			TokenPrivilegeNativeTypes.Struct34 privileges = default(TokenPrivilegeNativeTypes.Struct34);
			privileges.uint_0 = 1u;
			privileges.struct35_0 = privilegeId;
			privileges.uint_1 = 2u;
			return RecoveredRuntime.AdjustTokenPrivileges(tokenHandle, false, ref privileges, 0u, IntPtr.Zero, IntPtr.Zero);
		}
		finally
		{
			RecoveredRuntime.CloseHandle(tokenHandle);
		}
	}

	internal unsafe static int FindMaskedBytePattern(byte[] byte_0, string string_0, string string_1, int int_0)
	{
		return IndexOfMaskedByteString(byte_0, string_0, string_1, int_0);
}

	internal static void RemapExportDirectory(List<PeScrambler.Class132> list_0, PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.GetExports() == null)
		{
			return;
		}
		gclass4_0.class154_0.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(gclass4_0.class154_0, gclass4_0.class154_0.GetExports().GetAddressOfFunctions());
		BinaryReader binaryReader = new BinaryReader(gclass4_0.class154_0.GetStream());
		BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.GetStream());
		int num = 0;
		while ((long)num < (long)((ulong)gclass4_0.class154_0.GetExports().GetNumberOfFunctions()))
		{
			uint uint_ = binaryReader.ReadUInt32();
			gclass4_0.class154_0.GetStream().Position -= 4L;
			binaryWriter.Write(RecoveredRuntime.RemapRva(list_0, uint_));
			num++;
		}
		gclass4_0.class154_0.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(gclass4_0.class154_0, gclass4_0.class154_0.GetExports().GetAddressOfNames());
		int num2 = 0;
		while ((long)num2 < (long)((ulong)gclass4_0.class154_0.GetExports().GetNumberOfNames()))
		{
			uint uint_2 = binaryReader.ReadUInt32();
			gclass4_0.class154_0.GetStream().Position -= 4L;
			binaryWriter.Write(RecoveredRuntime.RemapRva(list_0, uint_2));
			num2++;
		}
		gclass4_0.class154_0.GetStream().Position = RecoveredRuntime.MapRvaToFileOffset(gclass4_0.class154_0, gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[0].GetVirtualAddress()) + 28L;
		binaryWriter.Write(RecoveredRuntime.RemapRva(list_0, gclass4_0.class154_0.GetExports().GetAddressOfFunctions()));
		binaryWriter.Write(RecoveredRuntime.RemapRva(list_0, gclass4_0.class154_0.GetExports().GetAddressOfNames()));
		binaryWriter.Write(RecoveredRuntime.RemapRva(list_0, gclass4_0.class154_0.GetExports().GetAddressOfNameOrdinals()));
	}

	internal static bool MatchesMaskedBytePattern(int int_0, string string_0, byte[] byte_0, string string_1)
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

	internal static int ReadDeflateInt32(DeflateDecoder.Stream1 stream1_0)
	{
		return ReadUInt16LittleEndian(stream1_0) | (ReadUInt16LittleEndian(stream1_0) << 16);
	}

	internal static void CompactPeHeaders(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.GetDosHeader().GetPeHeaderOffset() == 64u)
		{
			return;
		}
		int num = (int)(24 + gclass4_0.class154_0.GetHeaders().GetCoffHeader().GetSizeOfOptionalHeader()) + gclass4_0.class154_0.GetSections().Count * 40;
		byte[] buffer;
		using (Stream stream = RecoveredRuntime.CopyImageRange(gclass4_0.class154_0, (long)((ulong)gclass4_0.class154_0.GetDosHeader().GetPeHeaderOffset()), num))
		using (BinaryReader binaryReader = new BinaryReader(stream))
		{
			buffer = binaryReader.ReadBytes(num);
		}
		RecoveredRuntime.ZeroFillImageRange(gclass4_0, 64L, (long)((ulong)(gclass4_0.class154_0.GetDosHeader().GetPeHeaderOffset() - 64u) + (ulong)((long)num)));
		gclass4_0.class154_0.GetStream().Position = 64L;
		gclass4_0.binaryWriter_0.Write(buffer);
		gclass4_0.class154_0.GetDosHeader().SetPeHeaderOffset(64u);
	}

	internal static void RemapResourceDirectory(List<PeScrambler.Class132> list_0, PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.GetResources() == null)
		{
			return;
		}
		BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.GetStream());
		BinaryReader binaryReader = new BinaryReader(gclass4_0.class154_0.GetStream());
		long num = RecoveredRuntime.MapRvaToFileOffset(gclass4_0.class154_0, gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[2].GetVirtualAddress());
		foreach (ResourceDirectoryNode @class in RecoveredRuntime.EnumerateResourceNodes(gclass4_0.class154_0.GetResources().GetRoot()))
		{
			gclass4_0.class154_0.GetStream().Position = num + @class.long_0;
			gclass4_0.class154_0.GetStream().Position += 12L;
			ushort num2 = binaryReader.ReadUInt16();
			ushort num3 = binaryReader.ReadUInt16();
			long position = gclass4_0.class154_0.GetStream().Position;
			for (int i = 0; i < (int)(num2 + num3); i++)
			{
				gclass4_0.class154_0.GetStream().Position = position + (long)(i * 8);
				gclass4_0.class154_0.GetStream().Position += 4L;
				uint num4 = binaryReader.ReadUInt32();
				if ((num4 & 2147483648u) == 0u)
				{
					gclass4_0.class154_0.GetStream().Position = num + (long)((ulong)num4);
					uint uint_ = binaryReader.ReadUInt32();
					gclass4_0.class154_0.GetStream().Position -= 4L;
					BinaryWriter binaryWriter2 = binaryWriter;
					uint value;
					@class.GetDataEntries()[i].SetDataRva(value = RecoveredRuntime.RemapRva(list_0, uint_));
					binaryWriter2.Write(value);
				}
			}
		}
	}

	internal static void WriteScrambledImage(PeScrambler gclass4_0, Stream stream_0)
	{
		WritePeImage(stream_0, gclass4_0.class154_0);
	}

	internal static int PeekDeflateBits(DeflateDecoder.Class181 class181_0, int int_0)
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

	internal static DeflateDecoder.Class183 BuildDistanceHuffmanTree(DeflateDecoder.Class184 class184_0)
	{
		byte[] array = new byte[class184_0.int_4];
		Array.Copy(class184_0.byte_1, class184_0.int_3, array, 0, class184_0.int_4);
		return new DeflateDecoder.Class183(array);
	}

	internal static DeflateDecoder.Class183 BuildLiteralLengthHuffmanTree(DeflateDecoder.Class184 class184_0)
	{
		byte[] array = new byte[class184_0.int_3];
		Array.Copy(class184_0.byte_1, 0, array, 0, class184_0.int_3);
		return new DeflateDecoder.Class183(array);
	}

	internal static int CopyDeflateInput(DeflateDecoder.Class181 class181_0, byte[] byte_0, int int_0, int int_1)
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

	internal static void WriteDeflateLiteral(DeflateDecoder.Class182 class182_0, int int_0)
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

	internal static void ZeroBytePatternOccurrences(byte[] byte_0, PeScrambler gclass4_0)
	{
		BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.GetStream());
		long num = 0L;
		while ((num = RecoveredRuntime.FindPatternOffset(gclass4_0, byte_0, num)) != -1L)
		{
			gclass4_0.class154_0.GetStream().Position = num;
			for (int i = 0; i < byte_0.Length; i++)
			{
				binaryWriter.Write(0);
			}
			num += 1L;
		}
	}

	internal static bool IsForwardedExport(ExportedSymbol class152_0)
	{
		return class152_0.GetForwarder() != null;
	}

	internal static void SetRemotePebAddress(RemotePeb class117_0, IntPtr intptr_0)
	{
		class117_0.SetAddress(intptr_0);
	}

	internal static bool HasNumericResourceIdentifier(ResourceIdentifier class137_0)
	{
		return !HasResourceName(class137_0);
	}

	internal static void RemapDebugDirectory(IEnumerable<PeScrambler.Class132> ienumerable_0, PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.GetDebugDirectory() != null)
		{
			BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.GetStream());
			gclass4_0.class154_0.GetStream().Position = MapRvaToFileOffset(gclass4_0.class154_0, gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[6].GetVirtualAddress()) + 20L;
			uint value;
			gclass4_0.class154_0.GetDebugDirectory().SetAddressOfRawData(value = RemapRva(ienumerable_0, gclass4_0.class154_0.GetDebugDirectory().GetAddressOfRawData()));
			binaryWriter.Write(value);
			gclass4_0.class154_0.GetDebugDirectory().SetPointerToRawData(value = (uint)MapRvaToFileOffset(gclass4_0.class154_0, gclass4_0.class154_0.GetDebugDirectory().GetPointerToRawData()));
			binaryWriter.Write(value);
		}
	}

	internal static void ScramblePeImage(PeScrambler gclass4_0)
	{
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetChecksum(0u);
		if (gclass4_0.class131_0.RemoveUselessData)
		{
			RecoveredRuntime.CompactPeHeaders(gclass4_0);
		}
		if (gclass4_0.class131_0.ScrambleHeaderFields)
		{
			RecoveredRuntime.ScramblePeHeaderFields(gclass4_0);
		}
		if (gclass4_0.class131_0.ModifyAssemblyCode)
		{
			gclass4_0.RemoveCodePadding();
		}
		if (gclass4_0.class131_0.RemoveDebugData || (gclass4_0.class131_0.InsertExtraSections && gclass4_0.class131_0.CreateFakeDebugDirectory))
		{
			RecoveredRuntime.RemoveDebugDirectory(gclass4_0);
		}
		if (gclass4_0.class131_0.RenameSections)
		{
			gclass4_0.RandomizeSectionNames();
		}
		if (gclass4_0.class131_0.ShiftSectionMemory)
		{
			RecoveredRuntime.RemapPeSections(gclass4_0);
		}
		if (gclass4_0.class131_0.InsertExtraSections)
		{
			gclass4_0.AddDecoySections();
		}
		if (gclass4_0.class131_0.ShiftSectionData)
		{
			gclass4_0.InsertHeaderPadding();
		}
		if (gclass4_0.class131_0.ModifyImportTable)
		{
			RecoveredRuntime.RandomizeImportNameCasing(gclass4_0);
		}
		if (gclass4_0.class131_0.ShiftSectionMemory)
		{
			RecoveredRuntime.NormalizeSectionVirtualSizes(gclass4_0);
		}
		if (gclass4_0.class131_0.StripSectionCharacteristics)
		{
			gclass4_0.StripSectionAlignmentFlags();
		}
	}

	internal static int DecodeHuffmanSymbol(DeflateDecoder.Class183 class183_0, DeflateDecoder.Class181 class181_0)
	{
		int num;
		if ((num = RecoveredRuntime.PeekDeflateBits(class181_0, 9)) >= 0)
		{
			int num2;
			if ((num2 = (int)class183_0.short_0[num]) >= 0)
			{
				RecoveredRuntime.DropDeflateBits(class181_0, num2 & 15);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 15;
			if ((num = RecoveredRuntime.PeekDeflateBits(class181_0, int_)) >= 0)
			{
				num2 = (int)class183_0.short_0[num3 | num >> 9];
				RecoveredRuntime.DropDeflateBits(class181_0, num2 & 15);
				return num2 >> 4;
			}
			int int_2 = class181_0.int_2;
			num = RecoveredRuntime.PeekDeflateBits(class181_0, int_2);
			num2 = (int)class183_0.short_0[num3 | num >> 9];
			if ((num2 & 15) <= int_2)
			{
				RecoveredRuntime.DropDeflateBits(class181_0, num2 & 15);
				return num2 >> 4;
			}
			return -1;
		}

		int availableBits = class181_0.int_2;
		num = RecoveredRuntime.PeekDeflateBits(class181_0, availableBits);
		int fallbackEntry = (int)class183_0.short_0[num];
		if (fallbackEntry < 0 || (fallbackEntry & 15) > availableBits)
		{
			return -1;
		}
		RecoveredRuntime.DropDeflateBits(class181_0, fallbackEntry & 15);
		return fallbackEntry >> 4;
	}

	internal static byte[] GetBeaEngineX64Image()
	{
		return (byte[])GetEmbeddedResourceManager().GetObject("BeaEnginex64", EmbeddedResources.cultureInfo_0);
	}

	internal static void InitializeResourceDirectoryNode(long long_0, ResourceDirectory class166_0, ResourceDirectoryNode class138_0)
	{
		class138_0.SetDataEntries(new List<ResourceDataEntry>());
		class138_0.SetSubdirectories(new List<ResourceDirectoryNode>());
		class138_0.class166_0 = class166_0;
		class138_0.long_0 = long_0;
		ParseResourceDirectoryNode(class138_0);
	}

	internal static bool IsDeflateInputExhausted(DeflateDecoder.Class181 class181_0)
	{
		return class181_0.int_0 == class181_0.int_1;
	}

	internal static void ClearClrIlOnlyFlag(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[14].GetVirtualAddress() == 0u || gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[14].GetSize() <= 0u)
		{
			return;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(gclass4_0.class154_0, gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[14].GetVirtualAddress());
		if (num == -1L)
		{
			return;
		}
		BinaryReader binaryReader = new BinaryReader(gclass4_0.class154_0.GetStream());
		gclass4_0.class154_0.GetStream().Position = num;
		if (binaryReader.ReadUInt32() == 72u)
		{
			gclass4_0.class154_0.GetStream().Position += 12L;
			uint num2 = binaryReader.ReadUInt32();
			num2 &= 4294967294u;
			gclass4_0.class154_0.GetStream().Position -= 4L;
			new BinaryWriter(gclass4_0.class154_0.GetStream()).Write(num2);
			return;
		}
	}

	internal static int GetRemoteStructureRegisteredSize(Type type_0)
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
			return RecoveredRuntime.GetRemoteStructureRegisteredSize(type_0);
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(13137) + type_0 + EncodedStringTable.DecodeString(3656));
	}

	internal static void UnlinkRemoteListEntry(RemoteListEntry class100_0)
	{
		RemoteListEntry @class = class100_0.GetBackwardEntry();
		RemoteListEntry class2 = class100_0.GetForwardEntry();
		@class.SetForwardLink(class100_0.GetForwardLink());
		class2.SetBackwardLink(class100_0.GetBackwardLink());
	}

	internal static int FindByteSequenceOptimized(byte[] byte_0, byte[] byte_1, int int_0)
	{
		if (int_0 + byte_1.Length > byte_0.Length)
		{
			return -1;
		}
		if (byte_0.Length - int_0 < 20000 || byte_1.Length < 5)
		{
			return RecoveredRuntime.FindByteSequenceNaive(byte_0, byte_1, int_0);
		}
		return RecoveredRuntime.FindByteSequence(byte_0, byte_1, int_0);
	}

	internal static int GetLoaderModuleReferenceCount(RemoteModuleManager class93_0, RemotePeb class117_0, IntPtr intptr_0)
	{
		RemoteLdrDataTableEntry @class = class117_0.GetLoaderData().GetLoadOrderModuleList().GetModuleEntry();
		while (@class != null && @class.GetModuleBase() != IntPtr.Zero)
		{
			if (!(@class.GetModuleBase() == intptr_0))
			{
				@class = @class.GetLoadOrderLinks().GetModuleEntry();
			}
			else
			{
				if (PlatformInfo.bool_5)
				{
					return (int)@class.GetDependencyNode().GetLoadCount();
				}
				return (int)@class.GetLoadCount();
			}
		}
		return -1;
	}

	internal static int InflateBytes(byte[] byte_0, int int_0, int int_1, DeflateDecoder.Class180 class180_0)
	{
		int num = 0;
		do
		{
			if (class180_0.int_4 != 11)
			{
				int num2 = RecoveredRuntime.CopyDeflateOutput(int_0, class180_0.class182_0, int_1, byte_0);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (RecoveredRuntime.DecodeNextDeflateBlock(class180_0) || (class180_0.class182_0.int_1 > 0 && class180_0.int_4 != 11));
		return num;
	}

	internal static void CopyDeflateMatch(DeflateDecoder.Class182 class182_0, int int_0, int int_1)
	{
		if ((class182_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = class182_0.int_0 - int_1 & 32767;
		int num2 = 32768 - int_0;
		if (num > num2 || class182_0.int_0 >= num2)
		{
			RecoveredRuntime.CopyWrappedDeflateMatch(class182_0, num, int_0, int_1);
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

	internal static bool UnlinkModuleFromPebLists(RemoteModuleUnlinker class129_0, RemotePeb class117_0, IntPtr intptr_0)
	{
		RemoteLdrDataTableEntry @class = class117_0.GetLoaderData().GetLoadOrderModuleList().GetModuleEntry();
		while (@class != null && @class.GetModuleBase() != IntPtr.Zero)
		{
			if (@class.GetModuleBase() == intptr_0)
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

	internal static object ParseExportParameterValue(ExportParameter class17_0)
	{
		if (class17_0.Type == ExportParameterType.AnsiString || class17_0.Type == ExportParameterType.UnicodeString)
		{
			return class17_0.Value;
		}
		if (class17_0.Type == ExportParameterType.Single)
		{
			return float.Parse(class17_0.Value);
		}
		if (class17_0.Type == ExportParameterType.Byte && char.TryParse(class17_0.Value, out char character))
		{
			return (long)character;
		}

		try
		{
			object converted = new Int64Converter().ConvertFromString(class17_0.Value);
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

	internal static void AlignDeflateInputToByteBoundary(DeflateDecoder.Class181 class181_0)
	{
		class181_0.uint_0 >>= class181_0.int_2 & 7;
		class181_0.int_2 &= -8;
	}

	internal static void ReplaceBytePatternOccurrences(byte[] byte_0, byte[] byte_1, PeScrambler gclass4_0)
	{
		BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.GetStream());
		long num = 0L;
		while ((num = RecoveredRuntime.FindPatternOffset(gclass4_0, byte_1, num)) != -1L)
		{
			gclass4_0.class154_0.GetStream().Position = num;
			binaryWriter.Write(byte_0);
			num += 1L;
		}
	}

	internal static byte[] ReadResourceBytes(ResourceDirectory class166_0, int int_0)
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

	internal unsafe static int FindByteSequenceNaive(byte[] byte_0, byte[] byte_1, int int_0)
	{
		return IndexOfBytes(byte_0, byte_1, int_0);
}

	internal static void SeekReader(BoundsCheckedBinaryReader class5_0, long long_0)
	{
		class5_0.BaseStream.Position = long_0;
	}

	internal static InvertedFunctionTableEntry32[] ReadInvertedFunctionTableEntries(InvertedFunctionTable32 class112_0)
	{
		InvertedFunctionTableEntry32[] array = new InvertedFunctionTableEntry32[RecoveredRuntime.GetInvertedFunctionTableCapacity(class112_0)];
		IntPtr intptr_ = RecoveredRuntime.GetRemoteFieldAddress(class112_0, 3);
		int num = RecoveredRuntime.GetRemoteStructureSize(typeof(InvertedFunctionTableEntry32));
		int num2 = 0;
		while ((long)num2 < (long)((ulong)RecoveredRuntime.GetInvertedFunctionTableCount(class112_0)))
		{
			InvertedFunctionTableEntry32[] array2 = array;
			int num3 = num2;
			InvertedFunctionTableEntry32 @class = new InvertedFunctionTableEntry32(intptr_.Add(num2 * num), class112_0.GetProcessHandle());
			@class.SetMemoryApi(class112_0.GetMemoryApi());
			array2[num3] = @class;
			num2++;
		}
		return array;
	}

	internal static byte GenerateSafeRandomInstructionByte()
	{
		while (true)
		{
			byte value = PlatformInfo.random_0.NextByte();
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

	internal static void CopyWrappedDeflateMatch(DeflateDecoder.Class182 class182_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class182_0.byte_0[class182_0.int_0++] = class182_0.byte_0[int_0++];
			class182_0.int_0 &= 32767;
			int_0 &= 32767;
		}
	}

	internal static int CopyStoredDeflateBytes(DeflateDecoder.Class182 class182_0, DeflateDecoder.Class181 class181_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class182_0.int_1), RecoveredRuntime.GetAvailableDeflateInputBytes(class181_0));
		int num = 32768 - class182_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = RecoveredRuntime.CopyDeflateInput(class181_0, class182_0.byte_0, class182_0.int_0, num);
			if (num2 == num)
			{
				num2 += RecoveredRuntime.CopyDeflateInput(class181_0, class182_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = RecoveredRuntime.CopyDeflateInput(class181_0, class182_0.byte_0, class182_0.int_0, int_0);
		}
		class182_0.int_0 = (class182_0.int_0 + num2 & 32767);
		class182_0.int_1 += num2;
		return num2;
	}

	internal static IntPtr AllocateRemoteMemory(RemoteMemoryAccessor class82_0, long long_0, NativeTypes.Enum34 enum34_0)
	{
		return class82_0.AllocateMemory(IntPtr.Zero, long_0, enum34_0);
	}

	internal static bool IsCurrentResourceRangeValid(ResourceDirectory class166_0, int int_0)
	{
		return IsResourceRangeValid(class166_0, (int)(class166_0.class5_0.BaseStream.Position - class166_0.long_0), int_0);
	}

	internal static byte[] GetBeaEngineX86Image()
	{
		return (byte[])GetEmbeddedResourceManager().GetObject("BeaEnginex86", EmbeddedResources.cultureInfo_0);
	}

	internal static string FormatThreadPriority(ThreadPriorityLevel threadPriorityLevel_0)
	{
		string text = threadPriorityLevel_0.ToString();
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

	internal static bool IsReadableMemoryAddress(IntPtr intptr_0)
	{
		NativeTypes.Struct47 @struct;
		return RecoveredRuntime.VirtualQuery(intptr_0, out @struct, (uint)typeof(NativeTypes.Struct47).SizeOf()) != 0 && ((@struct.enum34_1 & NativeTypes.Enum34.flag_5) != (NativeTypes.Enum34)0u || (@struct.enum34_1 & NativeTypes.Enum34.flag_1) != (NativeTypes.Enum34)0u || (@struct.enum34_1 & NativeTypes.Enum34.flag_2) > (NativeTypes.Enum34)0u);
	}

	internal static void RemoveEncodedString(Encoding encoding_0, PeScrambler gclass4_0, string string_0)
	{
		ZeroBytePatternOccurrences(encoding_0.GetBytes(string_0), gclass4_0);
	}

	internal static string ReadNullTerminatedByteString(IEnumerable<byte> ienumerable_0)
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

	internal static RemotePlatformStructure.RemoteFieldLayout CreatePaddedRemoteFieldLayout(Type type_0, int int_0)
	{
		return new RemotePlatformStructure.RemoteFieldLayout
		{
			int_0 = GetPlatformTypeSize(type_0) + int_0,
			bool_0 = true
		};
	}

	internal static RemotePlatformStructure.RemoteFieldLayout CreateRemoteArrayFieldLayout(Type type_0, int int_0)
	{
		return new RemotePlatformStructure.RemoteFieldLayout
		{
			int_0 = GetPlatformTypeSize(type_0) * int_0
		};
	}

	internal static uint AlignUp(uint uint_0, uint uint_1)
	{
		if (uint_1 % uint_0 != 0)
		{
			return uint_1 + uint_0 - uint_1 % uint_0;
		}
		return uint_1;
	}

	internal static void RemapPeSections(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.GetBaseRelocations() == null)
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
		while ((long)num < (long)((ulong)gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetNumberOfRvaAndSizes()))
		{
			if (gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[num].GetVirtualAddress() != 0u && !source.Contains(num))
			{
				return;
			}
			num++;
		}
		List<PeScrambler.Class132> list = gclass4_0.CreateSectionRemap();
		RecoveredRuntime.RemapExportDirectory(list, gclass4_0);
		gclass4_0.RemapImportDirectory(list);
		RecoveredRuntime.RemapResourceDirectory(list, gclass4_0);
		gclass4_0.RemapExceptionDirectory(list);
		gclass4_0.RemapBaseRelocations(list);
		RecoveredRuntime.RemapDebugDirectory(list, gclass4_0);
		RecoveredRuntime.ApplySectionRemap(list, gclass4_0);
	}

	internal static Win32Exception CreateWin32ExceptionFromNtStatus(uint uint_0, RemoteCodeExecutorBase class84_0)
	{
		int num = RecoveredRuntime.RtlNtStatusToDosError(uint_0);
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

	internal static IntPtr GetRemoteFieldAddress(RemotePlatformStructure class96_0, int int_0)
	{
		return class96_0.GetAddress().Add(class96_0.int_1[int_0]);
	}

	internal static int GetCachedNativeTypeSize(Type type_0)
	{
		int result;
		if (!PlatformInfo.dictionary_0.TryGetValue(type_0, out result))
		{
			PlatformInfo.dictionary_0.Add(type_0, result = RecoveredRuntime.SizeOfNativeType(type_0));
		}
		return result;
	}

	internal static bool CanScrambleDataDirectoryCount(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[14].GetVirtualAddress() == 0u || gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[14].GetSize() <= 0u)
		{
			return true;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(gclass4_0.class154_0, gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[14].GetVirtualAddress());
		if (num == -1L)
		{
			return true;
		}
		BinaryReader binaryReader = new BinaryReader(gclass4_0.class154_0.GetStream());
		gclass4_0.class154_0.GetStream().Position = num;
		if (binaryReader.ReadUInt32() != 72u)
		{
			return true;
		}
		gclass4_0.class154_0.GetStream().Position += 12L;
		return (binaryReader.ReadUInt32() & 2u) == 2u;
	}

	internal static string GetModulePath(MainForm.ModuleRow class21_0)
	{
		return class21_0.Entry.Path;
	}

	internal static int GetPlatformTypeSize(Type type_0)
	{
		if (!type_0.IsSubclassOf(typeof(RemotePlatformStructure)))
		{
			return GetCachedNativeTypeSize(type_0);
		}
		return GetRemoteStructureRegisteredSize(type_0);
	}

	internal static void BuildDeflateHuffmanTree(byte[] byte_0, DeflateDecoder.Class183 class183_0)
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
				class183_0.short_0[(int)RecoveredRuntime.ReverseDeflateBits(l)] = (short)(-num6 << 4 | k);
				num6 += 1 << k - 9;
			}
		}
		for (int m = 0; m < byte_0.Length; m++)
		{
			int num9 = (int)byte_0[m];
			if (num9 != 0)
			{
				num2 = array2[num9];
				int num10 = (int)RecoveredRuntime.ReverseDeflateBits(num2);
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
