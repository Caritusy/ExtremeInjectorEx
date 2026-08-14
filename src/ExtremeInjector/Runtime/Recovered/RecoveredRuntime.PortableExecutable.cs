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

	internal static void RandomizeImportNameCasing(PeScrambler gclass4_0)
	{
		PeImage image = gclass4_0.class154_0;
		DataDirectory importDirectory = image.GetHeaders().GetOptionalHeader().GetDataDirectories()[1];
		long importDirectoryOffset = RecoveredRuntime.MapRvaToFileOffset(image, importDirectory.GetVirtualAddress());
		if (importDirectoryOffset == -1L)
		{
			return;
		}

		using (Stream stream = RecoveredRuntime.OpenImageReadStream(image))
		using (BinaryReader reader = new BinaryReader(stream))
		{
			stream.Position = importDirectoryOffset;
			while (true)
			{
				bool hasOriginalThunk = reader.ReadUInt32() != 0u;
				stream.Position += 8L;
				uint nameRva = reader.ReadUInt32();
				uint firstThunk = reader.ReadUInt32();
				if (!hasOriginalThunk && firstThunk == 0u)
				{
					break;
				}

				long nameOffset = RecoveredRuntime.MapRvaToFileOffset(image, nameRva);
				if (nameOffset == -1L)
				{
					continue;
				}

				long descriptorPosition = stream.Position;
				stream.Position = nameOffset;
				image.GetStream().Position = nameOffset;
				byte character;
				while ((character = reader.ReadByte()) != 0)
				{
					bool useUpperCase = gclass4_0.random_0.Next(2) == 1;
					gclass4_0.binaryWriter_0.Write((byte)(useUpperCase
						? char.ToUpperInvariant((char)character)
						: char.ToLowerInvariant((char)character)));
				}
				stream.Position = descriptorPosition;
			}
		}
	}

	internal static DebugDirectoryEntry ReadDebugDirectory(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[6];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, @class.GetVirtualAddress());
		if (num == -1L || !class5_0.IsValidOffset(num))
		{
			return null;
		}
		if (class5_0.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			RecoveredRuntime.SeekReader(class5_0, num);
			return new DebugDirectoryEntry(class5_0);
		}
		return null;
	}

	internal static bool TryReadPe32OptionalHeader(BoundsCheckedBinaryReader class5_0, uint uint_0, out Pe32OptionalHeader class162_0)
	{
		class162_0 = null;
		const uint fixedHeaderSize = 96;
		long start = class5_0.BaseStream.Position;
		if (uint_0 < fixedHeaderSize || start < 0 || start + uint_0 > class5_0.BaseStream.Length)
		{
			return false;
		}

		var header = new Pe32OptionalHeader();
		header.SetMagic(class5_0.ReadUInt16());
		if (header.GetMagic() != 0x010B)
		{
			return false;
		}

		header.SetMajorLinkerVersion(class5_0.ReadByte());
		header.SetMinorLinkerVersion(class5_0.ReadByte());
		header.SetSizeOfCode(class5_0.ReadUInt32());
		header.SetSizeOfInitializedData(class5_0.ReadUInt32());
		header.SetSizeOfUninitializedData(class5_0.ReadUInt32());
		header.SetAddressOfEntryPoint(class5_0.ReadUInt32());
		header.SetBaseOfCode(class5_0.ReadUInt32());
		header.SetBaseOfData(class5_0.ReadUInt32());
		header.SetImageBase(class5_0.ReadUInt32());
		header.SetSectionAlignment(class5_0.ReadUInt32());
		header.SetFileAlignment(class5_0.ReadUInt32());
		header.SetMajorOperatingSystemVersion(class5_0.ReadUInt16());
		header.SetMinorOperatingSystemVersion(class5_0.ReadUInt16());
		header.SetMajorImageVersion(class5_0.ReadUInt16());
		header.SetMinorImageVersion(class5_0.ReadUInt16());
		header.SetMajorSubsystemVersion(class5_0.ReadUInt16());
		header.SetMinorSubsystemVersion(class5_0.ReadUInt16());
		header.SetWin32VersionValue(class5_0.ReadUInt32());
		header.SetSizeOfImage(class5_0.ReadUInt32());
		header.SetSizeOfHeaders(class5_0.ReadUInt32());
		header.SetChecksum(class5_0.ReadUInt32());
		header.SetSubsystem((Subsystem)class5_0.ReadUInt16());
		header.SetDllCharacteristics((DllCharacteristics)class5_0.ReadUInt16());
		header.SetSizeOfStackReserve(class5_0.ReadUInt32());
		header.SetSizeOfStackCommit(class5_0.ReadUInt32());
		header.SetSizeOfHeapReserve(class5_0.ReadUInt32());
		header.SetSizeOfHeapCommit(class5_0.ReadUInt32());
		header.SetLoaderFlags(class5_0.ReadUInt32());
		header.SetNumberOfRvaAndSizes(class5_0.ReadUInt32());

		DataDirectory[] directories = header.GetDataDirectories();
		uint availableDirectoryCount = (uint_0 - fixedHeaderSize) / 8U;
		int directoryCount = (int)Math.Min((uint)directories.Length, Math.Min(header.GetNumberOfRvaAndSizes(), availableDirectoryCount));
		for (int index = 0; index < directories.Length; index++)
		{
			directories[index] = index < directoryCount ? new DataDirectory(class5_0) : new DataDirectory();
		}

		class5_0.BaseStream.Position = start + uint_0;
		class162_0 = header;
		return true;
	}

	internal static byte[] ReadImageBytes(long long_0, PeImage class154_0, long long_1)
	{
		Stream imageStream = class154_0.GetStream();
		long originalPosition = imageStream.Position;
		try
		{
			imageStream.Position = long_1;
			using (MemoryStream output = new MemoryStream())
			{
				long byteCount = long_0 == -1L ? imageStream.Length - long_1 : long_0;
				imageStream.CopyBytesTo(output, checked((int)byteCount));
				return output.ToArray();
			}
		}
		finally
		{
			imageStream.Position = originalPosition;
		}
	}

	internal static void BeginInjection(MainForm mainForm)
	{
		MainForm.ModuleRow[] modules = GetEnabledModuleRows(mainForm);
		if (modules.Length == 0)
		{
			return;
		}

		InjectionOptions options = ApplicationSettings.Current.Options;
		WarningPreferences warnings = ApplicationSettings.Current.Warnings;
		ScramblePreset scramblePreset = options.Scramble.Detect();
		bool warningsChanged = false;

		if (!PlatformInfo.bool_11 && options.Method == InjectionMethod.ManualMap && !warnings.ManualMapAcknowledged)
		{
			MessageBox.Show(mainForm, UiText.Get("Message.ManualMapCompatibility"), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			warnings.ManualMapAcknowledged = true;
			warningsChanged = true;
		}

		bool usesLdrpLoadDll = options.Method == InjectionMethod.LdrpLoadDll || options.Method == InjectionMethod.LdrpLoadDllStub;
		if (!PlatformInfo.bool_11 && usesLdrpLoadDll && !warnings.LdrpLoadDllAcknowledged)
		{
			MessageBox.Show(mainForm, UiText.Get("Message.LdrpCompatibility"), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			warnings.LdrpLoadDllAcknowledged = true;
			warningsChanged = true;
		}

		if (scramblePreset != ScramblePreset.None && !warnings.ScrambleAcknowledged)
		{
			MessageBox.Show(mainForm, UiText.Get("Message.ScramblingWarning"), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			warnings.ScrambleAcknowledged = true;
			warningsChanged = true;
		}

		if (warningsChanged)
		{
			ApplicationSettings.Save();
		}

		mainForm.processRefreshTimer.Stop();
		mainForm.injectButton.Enabled = false;
		mainForm.settingsButton.Enabled = false;
		mainForm.QueueInjectionWorkflow(modules, scramblePreset);
	}

	internal static bool Is32BitImage(PeImage class154_0)
	{
		return class154_0.GetHeaders().GetOptionalHeader().GetMagic() == 267;
	}

	internal static ImportDirectory ReadImportDirectory(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[1];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, @class.GetVirtualAddress());
		if (num == -1L || !class5_0.IsValidOffset(num))
		{
			return null;
		}
		if (class5_0.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			RecoveredRuntime.SeekReader(class5_0, num);
			return new ImportDirectory(class5_0, class154_0);
		}
		return null;
	}

	internal static void WriteFakeDebugDirectory(PeSectionHeader gclass5_0, PeScrambler gclass4_0)
	{
		byte[] array;
		using (MemoryStream memoryStream = new MemoryStream())
		using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
		{
			binaryWriter.Write(1396986706);
			binaryWriter.Write(gclass4_0.random_0.Next());
			binaryWriter.Write(gclass4_0.random_0.Next());
			binaryWriter.Write(gclass4_0.random_0.Next());
			binaryWriter.Write(gclass4_0.random_0.Next());
			binaryWriter.Write(gclass4_0.random_0.Next());
			binaryWriter.Write(Encoding.ASCII.GetBytes(RecoveredRuntime.GenerateFakePdbPath(gclass4_0) + EncodedStringTable.DecodeString(12219)));
			array = memoryStream.ToArray();
		}
		gclass4_0.class154_0.GetStream().Position = (long)((ulong)gclass5_0.GetPointerToRawData());
		gclass4_0.binaryWriter_0.Write(0);
		gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
		gclass4_0.binaryWriter_0.Write(0);
		gclass4_0.binaryWriter_0.Write(2);
		gclass4_0.binaryWriter_0.Write(array.Length);
		gclass4_0.binaryWriter_0.Write(gclass5_0.GetVirtualAddress() + 32u);
		gclass4_0.binaryWriter_0.Write(gclass5_0.GetPointerToRawData() + 32u);
		gclass4_0.binaryWriter_0.Write(0);
		gclass4_0.binaryWriter_0.Write(array);
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[6].SetVirtualAddress(gclass5_0.GetVirtualAddress());
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[6].SetSize(28u);
		gclass5_0.SetCharacteristics(gclass5_0.GetCharacteristics() & ~SectionCharacteristics.flag_28);
	}

	internal static void DisposeImportNameIterator(ImportDirectory.Class150 class150_0)
	{
		class150_0.int_0 = -1;
		if (class150_0.ienumerator_0 != null)
		{
			class150_0.ienumerator_0.Dispose();
		}
	}

	internal static long MapVirtualAddressToFileOffset(PeImage class154_0, ulong ulong_0)
	{
		if (ulong_0 < class154_0.GetHeaders().GetOptionalHeader().GetImageBase())
		{
			return -1L;
		}
		return MapRvaToFileOffset(class154_0, (uint)(ulong_0 - class154_0.GetHeaders().GetOptionalHeader().GetImageBase()));
	}

	internal static IntPtr ResolveOrLoadDependency(ManualMapInjector.Class172 class172_0, ManualMapInjector class89_0, string string_0)
	{
		ManualMapInjector.Enum44 enum44_ = ManualMapInjector.Enum44.flag_5 | ManualMapInjector.Enum44.flag_6 | ManualMapInjector.Enum44.flag_7;
		IntPtr intPtr = RecoveredRuntime.CaptureProcessModules(class89_0.GetRemoteProcess()).GetModuleBase(string_0);
		if (intPtr != IntPtr.Zero)
		{
			return intPtr;
		}
		DependencySearchFlags @enum = DependencySearchFlags.flag_2;
		if (RecoveredRuntime.IsWow64RemoteProcess(class89_0.GetRemoteProcess()))
		{
			@enum |= DependencySearchFlags.flag_4;
		}
		string text = RecoveredRuntime.ResolveDependencyPath(string_0, class172_0.GetFilePath(), Path.GetDirectoryName(class172_0.GetFilePath()), @enum, class89_0.GetProcessId(), class172_0.GetActivationContextHandle());
		if (text == null)
		{
			class89_0.SetLastException(new FileNotFoundException(EncodedStringTable.DecodeString(12476) + string_0));
			return IntPtr.Zero;
		}
		if ((class172_0.GetOptions() & ManualMapInjector.Enum44.flag_4) == (ManualMapInjector.Enum44)0)
		{
			IntPtr result;
			try
			{
				result = new LoadLibraryInjector(class89_0.GetRemoteProcess()).Inject(text);
			}
			catch (Exception innerException)
			{
				class89_0.SetLastException(new Exception(EncodedStringTable.DecodeString(12529) + text, innerException));
				result = IntPtr.Zero;
			}
			return result;
		}
		ManualMapInjector @class = new ManualMapInjector(class89_0.GetRemoteProcess());
		@class.SetRemoteProcess(class89_0.GetRemoteProcess());
		ManualMapInjector class2 = @class;
		IntPtr intPtr2 = class2.InjectModule(text, enum44_);
		if (intPtr2 == IntPtr.Zero)
		{
			class89_0.SetLastException(new Exception(EncodedStringTable.DecodeString(12529) + text, class2.GetLastException()));
		}
		return intPtr2;
	}

	internal static void WritePeHeaders(PeImageWriter class165_0)
	{
		class165_0.stream_0.Position = (long)((ulong)class165_0.class154_0.GetDosHeader().GetPeHeaderOffset());
		class165_0.stream_0.Position += 4L;
		RecoveredRuntime.WriteCoffHeader(class165_0);
		RecoveredRuntime.WriteOptionalHeader(class165_0);
	}

	internal static void WritePeImage(Stream stream_0, PeImageWriter class165_0)
	{
		stream_0.SetLength(0L);
		class165_0.stream_0 = stream_0;
		class165_0.binaryWriter_0 = new BinaryWriter(stream_0);
		class165_0.class154_0.GetStream().Position = 0L;
        BinaryExtensions.CopyTo(class165_0.class154_0.GetStream(), stream_0);
		class165_0.class154_0.GetStream().Position = 0L;
		RecoveredRuntime.WriteDosHeaderPeOffset(class165_0);
		RecoveredRuntime.WritePeHeaders(class165_0);
		class165_0.WriteSectionHeaders();
	}

	internal static PeImage LoadPeImageFromFile(PeImageLayout enum39_0, string string_0)
	{
		return PeImageReader.ReadFullImage(new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite), string_0, bool_0: true, enum39_0);
	}

	internal static LoadConfigurationDirectory ReadLoadConfigurationDirectory(BoundsCheckedBinaryReader class5_0, PeImage class154_0)
	{
		DataDirectory @class = class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[10];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, @class.GetVirtualAddress());
		if (num == -1L || !class5_0.IsValidOffset(num))
		{
			return null;
		}
		if (class5_0.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			RecoveredRuntime.SeekReader(class5_0, num);
			return new LoadConfigurationDirectory(class5_0, class154_0);
		}
		return null;
	}

	internal static bool FailManualMap(ManualMapInjector class89_0, Exception exception_0)
	{
		class89_0.SetLastException(exception_0);
		return false;
	}

	internal static List<ExportedSymbol> GetRemoteModuleExports(ProcessModuleInfo gclass1_0)
	{
		if (gclass1_0.list_0 == null)
		{
			using (ProcessMemoryStream stream = new ProcessMemoryStream(gclass1_0.gclass2_0, gclass1_0.GetModuleBase(), ProcessMemoryAccess.const_0, (long)((ulong)gclass1_0.GetImageSize())))
			using (PeImage image = PeExportReader.ReadExports(stream, false, PeImageLayout.const_1))
			{
				if (image.GetExports() == null)
				{
					return new List<ExportedSymbol>();
				}
				gclass1_0.list_0 = new List<ExportedSymbol>(image.GetExports().list_1);
			}
			if (!gclass1_0.gclass2_0.dictionary_0.ContainsKey(gclass1_0))
			{
				gclass1_0.gclass2_0.dictionary_0.Add(gclass1_0, gclass1_0.list_0);
			}
		}
		return gclass1_0.list_0;
	}

	internal static long MapRvaToFileOffset(PeImage class154_0, uint uint_0)
	{
		return class154_0.interface3_0.MapRvaToFileOffset(class154_0, uint_0);
	}

	internal static void WriteCoffHeader(PeImageWriter class165_0)
	{
		CoffHeader @class = class165_0.class154_0.GetHeaders().GetCoffHeader();
		class165_0.binaryWriter_0.Write((ushort)@class.GetMachine());
		@class.SetNumberOfSections((ushort)class165_0.class154_0.GetSections().Count);
		class165_0.binaryWriter_0.Write(@class.GetNumberOfSections());
		class165_0.binaryWriter_0.Write(@class.GetTimeDateStamp());
		class165_0.binaryWriter_0.Write(@class.GetPointerToSymbolTable());
		class165_0.binaryWriter_0.Write(@class.GetNumberOfSymbols());
		class165_0.binaryWriter_0.Write(@class.GetSizeOfOptionalHeader());
		class165_0.binaryWriter_0.Write((ushort)@class.GetCharacteristics());
	}

	internal static TlsDirectory ReadTlsDirectory(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[9];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, @class.GetVirtualAddress());
		if (num == -1L || !class5_0.IsValidOffset(num))
		{
			return null;
		}
		if (!class5_0.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			return null;
		}
		RecoveredRuntime.SeekReader(class5_0, num);
		return new TlsDirectory(class5_0, class154_0);
	}

	internal static List<ImportedSymbol> ReadImportedSymbols(BoundsCheckedBinaryReader class5_0, ImportDirectory class148_0, PeImage class154_0)
	{
		List<ImportedSymbol> list = new List<ImportedSymbol>();
		ulong ulong_;
		while ((ulong_ = (RecoveredRuntime.Is32BitImage(class154_0) ? ((ulong)class5_0.ReadUInt32()) : class5_0.ReadUInt64())) != 0UL)
		{
			ImportedSymbol @class = new ImportedSymbol();
			@class.SetThunkValue(ulong_);
			ImportedSymbol class2 = @class;
			class2.SetIsOrdinal((class2.GetThunkValue() & (RecoveredRuntime.Is32BitImage(class154_0) ? 2147483648UL : 9223372036854775808UL)) > 0UL);
			if (!class2.GetIsOrdinal())
			{
				long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, (uint)class2.GetThunkValue());
				long position = class5_0.BaseStream.Position;
				if (num != -1L && class5_0.IsValidOffset(num))
				{
					RecoveredRuntime.SeekReader(class5_0, num);
					class2.SetHint(class5_0.ReadUInt16());
					class2.SetName(RecoveredRuntime.ReadNullTerminatedAsciiString(class5_0));
				}
				RecoveredRuntime.SeekReader(class5_0, position);
			}
			else
			{
				class2.SetOrdinal((ushort)(class2.GetThunkValue() & 65535UL));
			}
			list.Add(class2);
		}
		return list;
	}

	internal static void WriteOptionalHeader(PeImageWriter class165_0)
	{
		IPeOptionalHeader @interface = class165_0.class154_0.GetHeaders().GetOptionalHeader();
		BinaryWriter writer = class165_0.binaryWriter_0;
		bool is32Bit = RecoveredRuntime.Is32BitImage(class165_0.class154_0);

		writer.Write(@interface.GetMagic());
		writer.Write(@interface.GetMajorLinkerVersion());
		writer.Write(@interface.GetMinorLinkerVersion());
		writer.Write(@interface.GetSizeOfCode());
		writer.Write(@interface.GetSizeOfInitializedData());
		writer.Write(@interface.GetSizeOfUninitializedData());
		writer.Write(@interface.GetAddressOfEntryPoint());
		writer.Write(@interface.GetBaseOfCode());
		if (is32Bit)
		{
			writer.Write(@interface.GetBaseOfData());
			writer.Write((uint)@interface.GetImageBase());
		}
		else
		{
			writer.Write(@interface.GetImageBase());
		}

		writer.Write(@interface.GetSectionAlignment());
		writer.Write(@interface.GetFileAlignment());
		writer.Write(@interface.GetMajorOperatingSystemVersion());
		writer.Write(@interface.GetMinorOperatingSystemVersion());
		writer.Write(@interface.GetMajorImageVersion());
		writer.Write(@interface.GetMinorImageVersion());
		writer.Write(@interface.GetMajorSubsystemVersion());
		writer.Write(@interface.GetMinorSubsystemVersion());
		writer.Write(@interface.GetWin32VersionValue());
		writer.Write(@interface.GetSizeOfImage());
		writer.Write(@interface.GetSizeOfHeaders());
		writer.Write(@interface.GetChecksum());
		writer.Write((ushort)@interface.GetSubsystem());
		writer.Write((ushort)@interface.GetDllCharacteristics());
		if (is32Bit)
		{
			writer.Write((uint)@interface.GetSizeOfStackReserve());
			writer.Write((uint)@interface.GetSizeOfStackCommit());
			writer.Write((uint)@interface.GetSizeOfHeapReserve());
			writer.Write((uint)@interface.GetSizeOfHeapCommit());
		}
		else
		{
			writer.Write(@interface.GetSizeOfStackReserve());
			writer.Write(@interface.GetSizeOfStackCommit());
			writer.Write(@interface.GetSizeOfHeapReserve());
			writer.Write(@interface.GetSizeOfHeapCommit());
		}
		writer.Write(@interface.GetLoaderFlags());
		writer.Write(@interface.GetNumberOfRvaAndSizes());
		foreach (DataDirectory @class in @interface.GetDataDirectories())
		{
			writer.Write(@class.GetVirtualAddress());
			writer.Write(@class.GetSize());
		}
	}

	internal static void ShowModuleOptions(ModuleEntry class16_0)
	{
		if (!File.Exists(class16_0.Path))
		{
			return;
		}

		try
		{
			using (FileStream fileStream = new FileStream(class16_0.Path, FileMode.Open, FileAccess.Read, FileShare.Read))
			using (PeImage image = PeExportReader.ReadExports(fileStream, class16_0.Path, false, PeImageLayout.const_0))
			{
				if (image == null)
				{
					return;
				}

				ModuleOptionsForm form = new ModuleOptionsForm
				{
					Module = class16_0,
					Image = image
				};
				form.ShowDialog();
			}
		}
		catch
		{
			return;
		}
	}

	internal static Stream OpenImageReadStream(PeImage class154_0)
	{
		Stream imageStream = class154_0.GetStream();
		lock (imageStream)
		{
			if (imageStream is FileStream)
			{
				return new FileStream(imageStream.GetFilePath(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			}

			imageStream.Position = 0L;
			MemoryStream copy = new MemoryStream();
			BinaryExtensions.CopyTo(imageStream, copy);
			copy.Position = 0L;
			return copy;
		}
	}

	internal static void HandleRuntimeDependencyInstallation(string string_0, string string_1, string string_2, PeImage class154_0, string string_3, MainForm mainForm, string string_4, bool bool_0, string string_5, bool bool_1, string string_6)
	{
		if (bool_0)
		{
			if (!PlatformInfo.bool_1)
			{
				RecoveredRuntime.ShowUnsupportedWindowsXpMessage(string_2, mainForm, class154_0.GetFileName());
				return;
			}

			string packageName = RecoveredRuntime.Is32BitImage(class154_0) ? string_4 : string_5;
			RecoveredRuntime.PromptDependencyInstallation(class154_0.GetFileName(), mainForm, string_1, packageName, string_2);
			return;
		}

		if (!RecoveredRuntime.ConfirmDependencyInstallation(mainForm, class154_0.GetFileName(), string_2, string_3, bool_1, string.Format(EncodedStringTable.DecodeString(14117), string_6)))
		{
			return;
		}

		DependencyInstallerForm form = new DependencyInstallerForm();
		RecoveredRuntime.ConfigureInstallerDownload(form, string_0, string_1, EncodedStringTable.DecodeString(14162) + (RecoveredRuntime.Is32BitImage(class154_0) ? EncodedStringTable.DecodeString(14180) : EncodedStringTable.DecodeString(14175)) + EncodedStringTable.DecodeString(93));
		form.ShowDialog();
	}

	internal static ManualMapInjector.Enum44 BuildManualMapOptions(ManualMapInjector class89_0)
	{
		ManualMapInjector.Enum44 @enum = (ManualMapInjector.Enum44)0;
		if (class89_0.GetDisableExceptionSupport())
		{
			@enum |= ManualMapInjector.Enum44.flag_1;
		}
		if (class89_0.GetErasePeHeaders())
		{
			@enum |= ManualMapInjector.Enum44.flag_2;
		}
		if (class89_0.GetManualResolveImports())
		{
			@enum |= ManualMapInjector.Enum44.flag_4;
		}
		if (class89_0.GetDisableSehValidation())
		{
			@enum |= ManualMapInjector.Enum44.flag_0;
		}
		return @enum;
	}

	internal static PeImage ReadRemoteModuleImage(ProcessModuleInfo gclass1_0)
	{
		PeImage result;
		using (ProcessMemoryStream stream = new ProcessMemoryStream(gclass1_0.gclass2_0, gclass1_0.GetModuleBase(), ProcessMemoryAccess.const_0, (long)((ulong)gclass1_0.GetImageSize())))
		{
			result = PeImageReader.ReadFullImage(stream, false, PeImageLayout.const_1);
		}
		return result;
	}

	private static bool ModuleMatchesProcessArchitecture(RemoteProcess process, string modulePath, out string mismatchMessage)
	{
		mismatchMessage = null;
		bool moduleIs32Bit;
		using (FileStream stream = new FileStream(modulePath, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (PeImage module = PeImportReader.ReadImports(stream, modulePath, bool_0: false, PeImageLayout.const_0))
		{
			moduleIs32Bit = Is32BitImage(module);
		}

		bool processIs32Bit = Is32BitProcess(process);
		if (moduleIs32Bit == processIs32Bit)
		{
			return true;
		}

		string modulePlatform = moduleIs32Bit ? "32-bit" : "64-bit";
		string processPlatform = processIs32Bit ? "32-bit" : "64-bit";
		mismatchMessage = UiText.Format(
			"Message.PlatformMismatch",
			modulePlatform,
			Path.GetFileName(modulePath),
			processPlatform,
			process.Name);
		return false;
	}

	private static IntPtr InjectWithConfiguredBackend(
		RemoteProcess process,
		string modulePath,
		string sourceModulePath,
		InjectionOptions options,
		Action<string, Exception> reportError)
	{
		if (options.Method == InjectionMethod.ManualMap)
		{
			return InjectWithManualMap(process, modulePath, options);
		}

		IntPtr moduleBase;
		using (DllInjector injector = InjectorFactory.Create(options.Method, process))
		{
			injector.SetHideRemoteThreadFromDebugger(options.Advanced.HideFromDebugger);
			moduleBase = injector.Inject(modulePath);
		}

		if (moduleBase == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}

		ApplyPostInjectionOptions(process, moduleBase, sourceModulePath, options, reportError);
		return moduleBase;
	}

	private static IntPtr InjectWithManualMap(RemoteProcess process, string modulePath, InjectionOptions options)
	{
		AdvancedInjectionOptions advanced = options.Advanced;
		using (ManualMapInjector injector = new ManualMapInjector(process))
		{
			injector.SetHideRemoteThreadFromDebugger(advanced.HideFromDebugger);
			injector.SetDisableExceptionSupport(advanced.DisableExceptionSupport);
			injector.SetManualResolveImports(advanced.ManualResolveImports);
			injector.SetErasePeHeaders(options.ErasePeHeaders);
			injector.SetDisableSehValidation(advanced.DisableSehValidation);

			IntPtr moduleBase = injector.Inject(modulePath);
			if (injector.GetLastException() != null)
			{
				throw injector.GetLastException();
			}
			return moduleBase;
		}
	}

	private static void ApplyPostInjectionOptions(
		RemoteProcess process,
		IntPtr moduleBase,
		string sourceModulePath,
		InjectionOptions options,
		Action<string, Exception> reportError)
	{
		if (options.ErasePeHeaders)
		{
			try
			{
				using (PeHeaderEraser moduleEditor = new PeHeaderEraser(process))
				{
					moduleEditor.EraseAt(moduleBase);
				}
			}
			catch (Exception exception)
			{
				reportError?.Invoke(UiText.Format("Message.ErasePeFailed", Path.GetFileName(sourceModulePath)), exception);
			}
		}

		if (options.HideModule)
		{
			try
			{
				UnlinkModuleByBaseAddress(new RemoteModuleUnlinker(process), moduleBase);
			}
			catch (Exception exception)
			{
				reportError?.Invoke(UiText.Format("Message.HideModuleFailed", Path.GetFileName(sourceModulePath)), exception);
			}
		}
	}

	internal static void SkipBytes(BoundsCheckedBinaryReader class5_0, int int_0)
	{
		class5_0.BaseStream.Position += int_0;
	}

	internal static BaseRelocationDirectory ReadBaseRelocationDirectory(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[5];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, @class.GetVirtualAddress());
		if (num == -1L || !class5_0.IsValidOffset(num))
		{
			return null;
		}
		if (num + (long)((ulong)@class.GetSize()) > class5_0.BaseStream.Length)
		{
			return null;
		}
		RecoveredRuntime.SeekReader(class5_0, num);
		return new BaseRelocationDirectory(class5_0, class154_0);
	}

	internal static void InitializeManualMapOptionsForm(ManualMapOptionsForm form2_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ManualMapOptionsForm));
		form2_0.groupBox_0 = new GroupBox();
		form2_0.checkBox_3 = new CheckBox();
		form2_0.checkBox_0 = new CheckBox();
		form2_0.checkBox_1 = new CheckBox();
		form2_0.groupBox_1 = new GroupBox();
		form2_0.checkBox_2 = new CheckBox();
		form2_0.groupBox_0.SuspendLayout();
		form2_0.groupBox_1.SuspendLayout();
		form2_0.SuspendLayout();
		form2_0.groupBox_0.Controls.Add(form2_0.checkBox_3);
		form2_0.groupBox_0.Controls.Add(form2_0.checkBox_0);
		form2_0.groupBox_0.Controls.Add(form2_0.checkBox_1);
		form2_0.groupBox_0.Location = new Point(12, 65);
		form2_0.groupBox_0.Name = EncodedStringTable.DecodeString(14653);
		form2_0.groupBox_0.Size = new Size(199, 93);
		form2_0.groupBox_0.TabIndex = 1;
		form2_0.groupBox_0.TabStop = false;
		form2_0.groupBox_0.Text = EncodedStringTable.DecodeString(14678);
		form2_0.checkBox_3.AutoSize = true;
		form2_0.checkBox_3.Location = new Point(10, 67);
		form2_0.checkBox_3.Name = EncodedStringTable.DecodeString(14703);
		form2_0.checkBox_3.Size = new Size(184, 17);
		form2_0.checkBox_3.TabIndex = 2;
		form2_0.checkBox_3.Text = EncodedStringTable.DecodeString(14748);
		form2_0.checkBox_3.UseVisualStyleBackColor = true;
		form2_0.checkBox_3.CheckedChanged += form2_0.OnDisableSehValidationChanged;
		form2_0.checkBox_0.AutoSize = true;
		form2_0.checkBox_0.Location = new Point(10, 44);
		form2_0.checkBox_0.Name = EncodedStringTable.DecodeString(14789);
		form2_0.checkBox_0.Size = new Size(161, 17);
		form2_0.checkBox_0.TabIndex = 1;
		form2_0.checkBox_0.Text = EncodedStringTable.DecodeString(14826);
		form2_0.checkBox_0.UseVisualStyleBackColor = true;
		form2_0.checkBox_0.CheckedChanged += form2_0.OnDisableExceptionSupportChanged;
		form2_0.checkBox_1.AutoSize = true;
		form2_0.checkBox_1.Location = new Point(10, 21);
		form2_0.checkBox_1.Name = EncodedStringTable.DecodeString(14863);
		form2_0.checkBox_1.Size = new Size(140, 17);
		form2_0.checkBox_1.TabIndex = 0;
		form2_0.checkBox_1.Text = EncodedStringTable.DecodeString(14896);
		form2_0.checkBox_1.UseVisualStyleBackColor = true;
		form2_0.checkBox_1.CheckedChanged += form2_0.OnManualResolveImportsChanged;
		form2_0.groupBox_1.Controls.Add(form2_0.checkBox_2);
		form2_0.groupBox_1.Location = new Point(12, 12);
		form2_0.groupBox_1.Name = EncodedStringTable.DecodeString(14925);
		form2_0.groupBox_1.Size = new Size(199, 47);
		form2_0.groupBox_1.TabIndex = 2;
		form2_0.groupBox_1.TabStop = false;
		form2_0.groupBox_1.Text = EncodedStringTable.DecodeString(14946);
		form2_0.checkBox_2.AutoSize = true;
		form2_0.checkBox_2.Location = new Point(10, 21);
		form2_0.checkBox_2.Name = EncodedStringTable.DecodeString(14959);
		form2_0.checkBox_2.Size = new Size(173, 17);
		form2_0.checkBox_2.TabIndex = 1;
		form2_0.checkBox_2.Text = EncodedStringTable.DecodeString(14992);
		form2_0.checkBox_2.UseVisualStyleBackColor = true;
		form2_0.checkBox_2.CheckedChanged += form2_0.OnHideFromDebuggerChanged;
		form2_0.AutoScaleDimensions = new SizeF(96f, 96f);
		form2_0.AutoScaleMode = AutoScaleMode.Dpi;
		form2_0.ClientSize = new Size(223, 170);
		form2_0.Controls.Add(form2_0.groupBox_1);
		form2_0.Controls.Add(form2_0.groupBox_0);
		form2_0.Font = new Font(EncodedStringTable.DecodeString(11956), 8.25f);
		form2_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		form2_0.Icon = (Icon)componentResourceManager.GetObject(EncodedStringTable.DecodeString(13062));
		form2_0.Name = EncodedStringTable.DecodeString(15029);
		form2_0.StartPosition = FormStartPosition.CenterParent;
		form2_0.Text = EncodedStringTable.DecodeString(15058);
		form2_0.groupBox_0.ResumeLayout(false);
		form2_0.groupBox_0.PerformLayout();
		form2_0.groupBox_1.ResumeLayout(false);
		form2_0.groupBox_1.PerformLayout();
		form2_0.ResumeLayout(false);
	}

	internal static void InitializeAdvancedScrambleSettingsForm(AdvancedScrambleSettingsForm gform1_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvancedScrambleSettingsForm));
		gform1_0.groupBox_0 = new GroupBox();
		gform1_0.checkBox_1 = new CheckBox();
		gform1_0.checkBox_0 = new CheckBox();
		gform1_0.groupBox_1 = new GroupBox();
		gform1_0.checkBox_6 = new CheckBox();
		gform1_0.checkBox_5 = new CheckBox();
		gform1_0.checkBox_4 = new CheckBox();
		gform1_0.checkBox_2 = new CheckBox();
		gform1_0.checkBox_3 = new CheckBox();
		gform1_0.groupBox_2 = new GroupBox();
		gform1_0.checkBox_10 = new CheckBox();
		gform1_0.checkBox_9 = new CheckBox();
		gform1_0.checkBox_7 = new CheckBox();
		gform1_0.checkBox_8 = new CheckBox();
		gform1_0.checkBox_12 = new CheckBox();
		gform1_0.checkBox_11 = new CheckBox();
		gform1_0.groupBox_0.SuspendLayout();
		gform1_0.groupBox_1.SuspendLayout();
		gform1_0.groupBox_2.SuspendLayout();
		gform1_0.SuspendLayout();
		gform1_0.groupBox_0.Controls.Add(gform1_0.checkBox_1);
		gform1_0.groupBox_0.Controls.Add(gform1_0.checkBox_0);
		gform1_0.groupBox_0.Location = new Point(12, 12);
		gform1_0.groupBox_0.Name = EncodedStringTable.DecodeString(15083);
		gform1_0.groupBox_0.Size = new Size(187, 68);
		gform1_0.groupBox_0.TabIndex = 0;
		gform1_0.groupBox_0.TabStop = false;
		gform1_0.groupBox_0.Text = EncodedStringTable.DecodeString(15104);
		gform1_0.checkBox_1.AutoSize = true;
		gform1_0.checkBox_1.Location = new Point(9, 44);
		gform1_0.checkBox_1.Name = EncodedStringTable.DecodeString(15125);
		gform1_0.checkBox_1.Size = new Size(132, 17);
		gform1_0.checkBox_1.TabIndex = 1;
		gform1_0.checkBox_1.Text = EncodedStringTable.DecodeString(15162);
		gform1_0.checkBox_1.UseVisualStyleBackColor = true;
		gform1_0.checkBox_0.AutoSize = true;
		gform1_0.checkBox_0.Location = new Point(9, 21);
		gform1_0.checkBox_0.Name = EncodedStringTable.DecodeString(15191);
		gform1_0.checkBox_0.Size = new Size(142, 17);
		gform1_0.checkBox_0.TabIndex = 0;
		gform1_0.checkBox_0.Text = EncodedStringTable.DecodeString(15224);
		gform1_0.checkBox_0.UseVisualStyleBackColor = true;
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_11);
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_12);
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_6);
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_5);
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_4);
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_2);
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_3);
		gform1_0.groupBox_1.Location = new Point(12, 86);
		gform1_0.groupBox_1.Name = EncodedStringTable.DecodeString(15257);
		gform1_0.groupBox_1.Size = new Size(187, 186);
		gform1_0.groupBox_1.TabIndex = 1;
		gform1_0.groupBox_1.TabStop = false;
		gform1_0.groupBox_1.Text = EncodedStringTable.DecodeString(15282);
		gform1_0.checkBox_6.AutoSize = true;
		gform1_0.checkBox_6.Location = new Point(9, 159);
		gform1_0.checkBox_6.Name = EncodedStringTable.DecodeString(15303);
		gform1_0.checkBox_6.Size = new Size(141, 17);
		gform1_0.checkBox_6.TabIndex = 4;
		gform1_0.checkBox_6.Text = EncodedStringTable.DecodeString(15336);
		gform1_0.checkBox_6.UseVisualStyleBackColor = true;
		gform1_0.checkBox_5.AutoSize = true;
		gform1_0.checkBox_5.Location = new Point(9, 90);
		gform1_0.checkBox_5.Name = EncodedStringTable.DecodeString(15365);
		gform1_0.checkBox_5.Size = new Size(112, 17);
		gform1_0.checkBox_5.TabIndex = 3;
		gform1_0.checkBox_5.Text = EncodedStringTable.DecodeString(15398);
		gform1_0.checkBox_5.UseVisualStyleBackColor = true;
		gform1_0.checkBox_4.AutoSize = true;
		gform1_0.checkBox_4.Location = new Point(9, 67);
		gform1_0.checkBox_4.Name = EncodedStringTable.DecodeString(15419);
		gform1_0.checkBox_4.Size = new Size(139, 17);
		gform1_0.checkBox_4.TabIndex = 2;
		gform1_0.checkBox_4.Text = EncodedStringTable.DecodeString(15444);
		gform1_0.checkBox_4.UseVisualStyleBackColor = true;
		gform1_0.checkBox_2.AutoSize = true;
		gform1_0.checkBox_2.Location = new Point(9, 44);
		gform1_0.checkBox_2.Name = EncodedStringTable.DecodeString(15473);
		gform1_0.checkBox_2.Size = new Size(116, 17);
		gform1_0.checkBox_2.TabIndex = 1;
		gform1_0.checkBox_2.Text = EncodedStringTable.DecodeString(15506);
		gform1_0.checkBox_2.UseVisualStyleBackColor = true;
		gform1_0.checkBox_3.AutoSize = true;
		gform1_0.checkBox_3.Location = new Point(9, 21);
		gform1_0.checkBox_3.Name = EncodedStringTable.DecodeString(15531);
		gform1_0.checkBox_3.Size = new Size(128, 17);
		gform1_0.checkBox_3.TabIndex = 0;
		gform1_0.checkBox_3.Text = EncodedStringTable.DecodeString(15564);
		gform1_0.checkBox_3.UseVisualStyleBackColor = true;
		gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_10);
		gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_9);
		gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_7);
		gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_8);
		gform1_0.groupBox_2.Location = new Point(12, 278);
		gform1_0.groupBox_2.Name = EncodedStringTable.DecodeString(15593);
		gform1_0.groupBox_2.Size = new Size(187, 120);
		gform1_0.groupBox_2.TabIndex = 2;
		gform1_0.groupBox_2.TabStop = false;
		gform1_0.groupBox_2.Text = EncodedStringTable.DecodeString(15626);
		gform1_0.checkBox_10.AutoSize = true;
		gform1_0.checkBox_10.Location = new Point(9, 44);
		gform1_0.checkBox_10.Name = EncodedStringTable.DecodeString(15651);
		gform1_0.checkBox_10.Size = new Size(129, 17);
		gform1_0.checkBox_10.TabIndex = 6;
		gform1_0.checkBox_10.Text = EncodedStringTable.DecodeString(15684);
		gform1_0.checkBox_10.UseVisualStyleBackColor = true;
		gform1_0.checkBox_9.AutoSize = true;
		gform1_0.checkBox_9.Location = new Point(9, 90);
		gform1_0.checkBox_9.Name = EncodedStringTable.DecodeString(15709);
		gform1_0.checkBox_9.Size = new Size(169, 17);
		gform1_0.checkBox_9.TabIndex = 5;
		gform1_0.checkBox_9.Text = EncodedStringTable.DecodeString(15754);
		gform1_0.checkBox_9.UseVisualStyleBackColor = true;
		gform1_0.checkBox_7.AutoSize = true;
		gform1_0.checkBox_7.Location = new Point(9, 67);
		gform1_0.checkBox_7.Name = EncodedStringTable.DecodeString(15791);
		gform1_0.checkBox_7.Size = new Size(138, 17);
		gform1_0.checkBox_7.TabIndex = 4;
		gform1_0.checkBox_7.Text = EncodedStringTable.DecodeString(15828);
		gform1_0.checkBox_7.UseVisualStyleBackColor = true;
		gform1_0.checkBox_8.AutoSize = true;
		gform1_0.checkBox_8.Location = new Point(9, 21);
		gform1_0.checkBox_8.Name = EncodedStringTable.DecodeString(15857);
		gform1_0.checkBox_8.Size = new Size(128, 17);
		gform1_0.checkBox_8.TabIndex = 3;
		gform1_0.checkBox_8.Text = EncodedStringTable.DecodeString(15894);
		gform1_0.checkBox_8.UseVisualStyleBackColor = true;
		gform1_0.checkBox_12.AutoSize = true;
		gform1_0.checkBox_12.Location = new Point(9, 113);
		gform1_0.checkBox_12.Name = EncodedStringTable.DecodeString(15923);
		gform1_0.checkBox_12.Size = new Size(133, 17);
		gform1_0.checkBox_12.TabIndex = 5;
		gform1_0.checkBox_12.Text = EncodedStringTable.DecodeString(15960);
		gform1_0.checkBox_12.UseVisualStyleBackColor = true;
		gform1_0.checkBox_11.AutoSize = true;
		gform1_0.checkBox_11.Location = new Point(9, 136);
		gform1_0.checkBox_11.Name = EncodedStringTable.DecodeString(15989);
		gform1_0.checkBox_11.Size = new Size(165, 17);
		gform1_0.checkBox_11.TabIndex = 6;
		gform1_0.checkBox_11.Text = EncodedStringTable.DecodeString(16030);
		gform1_0.checkBox_11.UseVisualStyleBackColor = true;
		gform1_0.AutoScaleDimensions = new SizeF(96f, 96f);
		gform1_0.AutoScaleMode = AutoScaleMode.Dpi;
		gform1_0.ClientSize = new Size(213, 411);
		gform1_0.Controls.Add(gform1_0.groupBox_2);
		gform1_0.Controls.Add(gform1_0.groupBox_1);
		gform1_0.Controls.Add(gform1_0.groupBox_0);
		gform1_0.Font = new Font(EncodedStringTable.DecodeString(11956), 8.25f);
		gform1_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		gform1_0.Icon = (Icon)componentResourceManager.GetObject(EncodedStringTable.DecodeString(13062));
		gform1_0.Name = EncodedStringTable.DecodeString(16071);
		gform1_0.StartPosition = FormStartPosition.CenterParent;
		gform1_0.Text = EncodedStringTable.DecodeString(16100);
		gform1_0.groupBox_0.ResumeLayout(false);
		gform1_0.groupBox_0.PerformLayout();
		gform1_0.groupBox_1.ResumeLayout(false);
		gform1_0.groupBox_1.PerformLayout();
		gform1_0.groupBox_2.ResumeLayout(false);
		gform1_0.groupBox_2.PerformLayout();
		gform1_0.ResumeLayout(false);
	}

	internal static void HandleLegacyNativeDependency(PeImage class154_0, string string_0, MainForm mainForm)
	{
		if (!string_0.StartsWith(EncodedStringTable.DecodeString(16137), StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		string text = RecoveredRuntime.ResolveImageDependencyPath(class154_0, string_0);
		bool flag = false;
		if (!string.IsNullOrEmpty(text))
		{
			using (FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				try
				{
					PeImage @class = PeImportReader.ReadImports(fileStream, text, false, PeImageLayout.const_0);
					if (@class != null && RecoveredRuntime.Is32BitImage(@class) != RecoveredRuntime.Is32BitImage(class154_0))
					{
						flag = true;
					}
				}
				catch
				{
				}
			}
			if (!flag)
			{
				return;
			}
		}
		bool flag2 = string_0.EndsWith(EncodedStringTable.DecodeString(16146), StringComparison.OrdinalIgnoreCase);
		string string_;
		if (!PlatformInfo.bool_0 || !RecoveredRuntime.Is32BitImage(class154_0))
		{
			string_ = PlatformInfo.string_1;
		}
		else
		{
			string_ = PlatformInfo.string_2;
		}
		if (!RecoveredRuntime.MatchesDependencyName(string_0, EncodedStringTable.DecodeString(16155)))
		{
			if (RecoveredRuntime.MatchesDependencyName(string_0, EncodedStringTable.DecodeString(16671)))
			{
				string string_2 = EncodedStringTable.DecodeString(16676);
				string string_3 = EncodedStringTable.DecodeString(16685);
				string string_4 = EncodedStringTable.DecodeString(16843);
				string string_5 = EncodedStringTable.DecodeString(17001);
				RecoveredRuntime.HandleRuntimeDependencyInstallation(string_5, string_, string_0, class154_0, text, mainForm, string_3, flag2, string_4, flag, string_2);
				return;
			}
			if (RecoveredRuntime.MatchesDependencyName(string_0, EncodedStringTable.DecodeString(17078)))
			{
				string string_2 = EncodedStringTable.DecodeString(17083);
				string string_3 = EncodedStringTable.DecodeString(17092);
				string string_4 = EncodedStringTable.DecodeString(17250);
				string string_5 = EncodedStringTable.DecodeString(17408);
				RecoveredRuntime.HandleRuntimeDependencyInstallation(string_5, string_, string_0, class154_0, text, mainForm, string_3, flag2, string_4, flag, string_2);
				return;
			}
			if (RecoveredRuntime.MatchesDependencyName(string_0, EncodedStringTable.DecodeString(17485)))
			{
				string string_2 = EncodedStringTable.DecodeString(17490);
				string string_3 = EncodedStringTable.DecodeString(17499);
				string string_4 = EncodedStringTable.DecodeString(17657);
				string string_5 = EncodedStringTable.DecodeString(17815);
				RecoveredRuntime.HandleRuntimeDependencyInstallation(string_5, string_, string_0, class154_0, text, mainForm, string_3, flag2, string_4, flag2, string_2);
			}
			return;
		}
		else
		{
			if (flag2)
			{
				string string_6 = RecoveredRuntime.Is32BitImage(class154_0) ? EncodedStringTable.DecodeString(16318) : EncodedStringTable.DecodeString(16160);
				RecoveredRuntime.PromptDependencyInstallation(class154_0.GetFileName(), mainForm, string_, string_6, string_0);
				return;
			}
			if (!RecoveredRuntime.ConfirmDependencyInstallation(mainForm, class154_0.GetFileName(), string_0, text, flag, EncodedStringTable.DecodeString(16476)))
			{
				return;
			}
			if (!RecoveredRuntime.Is32BitImage(class154_0))
			{
				Process.Start(EncodedStringTable.DecodeString(16594));
				return;
			}
			Process.Start(EncodedStringTable.DecodeString(16521));
			return;
		}
	}

	internal static void CreateActivationContextFromManifest(ManualMapInjector class89_0, ManualMapInjector.Class172 class172_0)
	{
		byte[] array = ManualMapInjector.ExtractManifestResource(class172_0.GetImage());
		if (array == null)
		{
			return;
		}
		string tempFileName = Path.GetTempFileName();
		try
		{
			File.WriteAllBytes(tempFileName, array);
			NativeTypes.Struct50 activationContext = default(NativeTypes.Struct50);
			activationContext.int_0 = typeof(NativeTypes.Struct50).SizeOf();
			activationContext.string_0 = tempFileName;
			class172_0.SetActivationContextHandle(RecoveredRuntime.CreateActCtx(ref activationContext));
		}
		finally
		{
			File.Delete(tempFileName);
		}
	}

	internal static void LoadSettingsIntoForm(SettingsForm gform2_0)
	{
		InjectionOptions class14_ = ApplicationSettings.Current.Options;
		gform2_0.comboBox_0.SelectedIndex = (int)class14_.Method;
		gform2_0.panel_2.BackColor = class14_.TextColor;
		gform2_0.panel_1.BackColor = class14_.BackgroundColor1;
		gform2_0.panel_0.BackColor = class14_.BackgroundColor2;
		gform2_0.checkBox_2.Checked = class14_.AutoInject;
		gform2_0.checkBox_0.Checked = class14_.StealthInject;
		gform2_0.checkBox_1.Checked = class14_.CloseOnInject;
		gform2_0.numericUpDown_0.Value = class14_.DelayBetweenModules;
		gform2_0.numericUpDown_1.Value = class14_.DelayBeforeInjection;
		gform2_0.checkBox_4.Checked = class14_.ErasePeHeaders;
		gform2_0.checkBox_3.Checked = class14_.HideModule;
		RecoveredRuntime.SelectCurrentScramblePreset(gform2_0);
	}

	internal static void ResetManualMapOptions(ManualMapInjector class89_0)
	{
		class89_0.SetManualResolveImports(bool_7: false);
		class89_0.SetErasePeHeaders(bool_7: false);
		class89_0.SetDisableExceptionSupport(bool_7: false);
		class89_0.SetHideRemoteThreadFromDebugger(bool_2: false);
	}

	internal static void CheckImportedDependencies(PeImage class154_0, MainForm mainForm)
	{
		if (class154_0.GetImports() == null)
		{
			return;
		}
		foreach (KeyValuePair<string, List<string>> import in class154_0.GetImports().gclass0_0)
		{
			string dependencyName = import.Key;
			if (!string.IsNullOrEmpty(dependencyName))
			{
				RecoveredRuntime.HandleLegacyNativeDependency(class154_0, dependencyName, mainForm);
				RecoveredRuntime.HandleLegacyManagedDependency(class154_0, dependencyName, mainForm);
			}
		}
	}

	internal static Stream CopyImageRange(PeImage class154_0, long long_0, int int_0)
	{
		Stream imageStream = class154_0.GetStream();
		lock (imageStream)
		{
			long originalPosition = imageStream.Position;
			try
			{
				imageStream.Position = long_0;
				MemoryStream copy = new MemoryStream();
				imageStream.CopyBytesTo(copy, int_0);
				copy.Position = 0L;
				return copy;
			}
			finally
			{
				imageStream.Position = originalPosition;
			}
		}
	}

	internal static void RegisterManualMappedModule(ProcessModuleCollection class69_0, PeImage class154_0, IntPtr intptr_0, bool bool_0)
	{
		ProcessModuleInfo gclass = new ProcessModuleInfo(class69_0.gclass2_0, null, intptr_0, bool_0, true);
		string string_ = class154_0.GetFilePath();
		string fileName = Path.GetFileName(class154_0.GetFilePath());
		IntPtr intptr_ = intptr_0.Add((long)((ulong)class154_0.GetHeaders().GetOptionalHeader().GetAddressOfEntryPoint()));
		uint uint_ = class154_0.GetHeaders().GetOptionalHeader().GetSizeOfImage();
		RecoveredRuntime.SetProcessModuleMetadata(string_, fileName, intptr_, gclass, uint_);
		class69_0.gclass2_0.list_1.Add(gclass);
	}

	internal static bool TryReadPeHeaders(ref PeHeaders class161_0, [Out] BoundsCheckedBinaryReader class5_0)
	{
		class161_0 = null;
		if (class5_0.ReadUInt32() != 0x00004550U)
		{
			return false;
		}

		var headers = new PeHeaders();
		headers.SetSignature(0x00004550U);
		headers.SetCoffHeader(new CoffHeader(class5_0));

		if (headers.GetCoffHeader().GetSizeOfOptionalHeader() < sizeof(ushort))
		{
			return false;
		}

		long optionalHeaderStart = class5_0.BaseStream.Position;
		ushort magic = class5_0.ReadUInt16();
		class5_0.BaseStream.Position = optionalHeaderStart;

		if (magic == 0x010B)
		{
			Pe32OptionalHeader optionalHeader;
			if (!TryReadPe32OptionalHeader(class5_0, headers.GetCoffHeader().GetSizeOfOptionalHeader(), out optionalHeader))
			{
				return false;
			}

			headers.SetOptionalHeader(optionalHeader);
		}
		else if (magic == 0x020B)
		{
			Pe64OptionalHeader optionalHeader;
			if (!TryReadPe64OptionalHeader(class5_0, headers.GetCoffHeader().GetSizeOfOptionalHeader(), out optionalHeader))
			{
				return false;
			}

			headers.SetOptionalHeader(optionalHeader);
		}
		else
		{
			return false;
		}

		class161_0 = headers;
		return true;
	}
}
