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

	internal static void RandomizeImportNameCasing(PeScrambler peScrambler)
	{
		PeImage image = peScrambler.peImage;
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
					bool useUpperCase = peScrambler.random.Next(2) == 1;
					peScrambler.binaryWriter.Write((byte)(useUpperCase
						? char.ToUpperInvariant((char)character)
						: char.ToLowerInvariant((char)character)));
				}
				stream.Position = descriptorPosition;
			}
		}
	}

	internal static DebugDirectoryEntry ReadDebugDirectory(PeImage peImage, BoundsCheckedBinaryReader boundsCheckedBinaryReader)
	{
		DataDirectory @class = peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[6];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(peImage, @class.GetVirtualAddress());
		if (num == -1L || !boundsCheckedBinaryReader.IsValidOffset(num))
		{
			return null;
		}
		if (boundsCheckedBinaryReader.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
			return new DebugDirectoryEntry(boundsCheckedBinaryReader);
		}
		return null;
	}

	internal static bool TryReadPe32OptionalHeader(BoundsCheckedBinaryReader boundsCheckedBinaryReader, uint uintValue, out Pe32OptionalHeader pe32OptionalHeader)
	{
		pe32OptionalHeader = null;
		const uint fixedHeaderSize = 96;
		long start = boundsCheckedBinaryReader.BaseStream.Position;
		if (uintValue < fixedHeaderSize || start < 0 || start + uintValue > boundsCheckedBinaryReader.BaseStream.Length)
		{
			return false;
		}

		var header = new Pe32OptionalHeader();
		header.SetMagic(boundsCheckedBinaryReader.ReadUInt16());
		if (header.GetMagic() != 0x010B)
		{
			return false;
		}

		header.SetMajorLinkerVersion(boundsCheckedBinaryReader.ReadByte());
		header.SetMinorLinkerVersion(boundsCheckedBinaryReader.ReadByte());
		header.SetSizeOfCode(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSizeOfInitializedData(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSizeOfUninitializedData(boundsCheckedBinaryReader.ReadUInt32());
		header.SetAddressOfEntryPoint(boundsCheckedBinaryReader.ReadUInt32());
		header.SetBaseOfCode(boundsCheckedBinaryReader.ReadUInt32());
		header.SetBaseOfData(boundsCheckedBinaryReader.ReadUInt32());
		header.SetImageBase(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSectionAlignment(boundsCheckedBinaryReader.ReadUInt32());
		header.SetFileAlignment(boundsCheckedBinaryReader.ReadUInt32());
		header.SetMajorOperatingSystemVersion(boundsCheckedBinaryReader.ReadUInt16());
		header.SetMinorOperatingSystemVersion(boundsCheckedBinaryReader.ReadUInt16());
		header.SetMajorImageVersion(boundsCheckedBinaryReader.ReadUInt16());
		header.SetMinorImageVersion(boundsCheckedBinaryReader.ReadUInt16());
		header.SetMajorSubsystemVersion(boundsCheckedBinaryReader.ReadUInt16());
		header.SetMinorSubsystemVersion(boundsCheckedBinaryReader.ReadUInt16());
		header.SetWin32VersionValue(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSizeOfImage(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSizeOfHeaders(boundsCheckedBinaryReader.ReadUInt32());
		header.SetChecksum(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSubsystem((Subsystem)boundsCheckedBinaryReader.ReadUInt16());
		header.SetDllCharacteristics((DllCharacteristics)boundsCheckedBinaryReader.ReadUInt16());
		header.SetSizeOfStackReserve(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSizeOfStackCommit(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSizeOfHeapReserve(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSizeOfHeapCommit(boundsCheckedBinaryReader.ReadUInt32());
		header.SetLoaderFlags(boundsCheckedBinaryReader.ReadUInt32());
		header.SetNumberOfRvaAndSizes(boundsCheckedBinaryReader.ReadUInt32());

		DataDirectory[] directories = header.GetDataDirectories();
		uint availableDirectoryCount = (uintValue - fixedHeaderSize) / 8U;
		int directoryCount = (int)Math.Min((uint)directories.Length, Math.Min(header.GetNumberOfRvaAndSizes(), availableDirectoryCount));
		for (int index = 0; index < directories.Length; index++)
		{
			directories[index] = index < directoryCount ? new DataDirectory(boundsCheckedBinaryReader) : new DataDirectory();
		}

		boundsCheckedBinaryReader.BaseStream.Position = start + uintValue;
		pe32OptionalHeader = header;
		return true;
	}

	internal static byte[] ReadImageBytes(long longValue, PeImage peImage, long longValue2)
	{
		Stream imageStream = peImage.GetStream();
		long originalPosition = imageStream.Position;
		try
		{
			imageStream.Position = longValue2;
			using (MemoryStream output = new MemoryStream())
			{
				long byteCount = longValue == -1L ? imageStream.Length - longValue2 : longValue;
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

		if (!PlatformInfo.flag12 && options.Method == InjectionMethod.ManualMap && !warnings.ManualMapAcknowledged)
		{
			MessageBox.Show(mainForm, UiText.Get("Message.ManualMapCompatibility"), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			warnings.ManualMapAcknowledged = true;
			warningsChanged = true;
		}

		bool usesLdrpLoadDll = options.Method == InjectionMethod.LdrpLoadDll || options.Method == InjectionMethod.LdrpLoadDllStub;
		if (!PlatformInfo.flag12 && usesLdrpLoadDll && !warnings.LdrpLoadDllAcknowledged)
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

	internal static bool Is32BitImage(PeImage peImage)
	{
		return peImage.GetHeaders().GetOptionalHeader().GetMagic() == 267;
	}

	internal static ImportDirectory ReadImportDirectory(PeImage peImage, BoundsCheckedBinaryReader boundsCheckedBinaryReader)
	{
		DataDirectory @class = peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[1];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(peImage, @class.GetVirtualAddress());
		if (num == -1L || !boundsCheckedBinaryReader.IsValidOffset(num))
		{
			return null;
		}
		if (boundsCheckedBinaryReader.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
			return new ImportDirectory(boundsCheckedBinaryReader, peImage);
		}
		return null;
	}

	internal static void WriteFakeDebugDirectory(PeSectionHeader peSectionHeader, PeScrambler peScrambler)
	{
		byte[] array;
		using (MemoryStream memoryStream = new MemoryStream())
		using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
		{
			binaryWriter.Write(1396986706);
			binaryWriter.Write(peScrambler.random.Next());
			binaryWriter.Write(peScrambler.random.Next());
			binaryWriter.Write(peScrambler.random.Next());
			binaryWriter.Write(peScrambler.random.Next());
			binaryWriter.Write(peScrambler.random.Next());
			binaryWriter.Write(Encoding.ASCII.GetBytes(RecoveredRuntime.GenerateFakePdbPath(peScrambler) + EncodedStringTable.DecodeString(12219)));
			array = memoryStream.ToArray();
		}
		peScrambler.peImage.GetStream().Position = (long)((ulong)peSectionHeader.GetPointerToRawData());
		peScrambler.binaryWriter.Write(0);
		peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
		peScrambler.binaryWriter.Write(0);
		peScrambler.binaryWriter.Write(2);
		peScrambler.binaryWriter.Write(array.Length);
		peScrambler.binaryWriter.Write(peSectionHeader.GetVirtualAddress() + 32u);
		peScrambler.binaryWriter.Write(peSectionHeader.GetPointerToRawData() + 32u);
		peScrambler.binaryWriter.Write(0);
		peScrambler.binaryWriter.Write(array);
		peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[6].SetVirtualAddress(peSectionHeader.GetVirtualAddress());
		peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[6].SetSize(28u);
		peSectionHeader.SetCharacteristics(peSectionHeader.GetCharacteristics() & ~SectionCharacteristics.Discardable);
	}

	internal static void DisposeImportNameIterator(ImportDirectory.ImportedNameIterator importedNameIterator)
	{
		importedNameIterator.intValue = -1;
		if (importedNameIterator.enumerator != null)
		{
			importedNameIterator.enumerator.Dispose();
		}
	}

	internal static long MapVirtualAddressToFileOffset(PeImage peImage, ulong ulongValue)
	{
		if (ulongValue < peImage.GetHeaders().GetOptionalHeader().GetImageBase())
		{
			return -1L;
		}
		return MapRvaToFileOffset(peImage, (uint)(ulongValue - peImage.GetHeaders().GetOptionalHeader().GetImageBase()));
	}

	internal static IntPtr ResolveOrLoadDependency(ManualMapInjector.MappingContext mappingContext, ManualMapInjector manualMapInjector, string text2)
	{
		ManualMapInjector.ManualMapOptions enum44_ = ManualMapInjector.ManualMapOptions.UseVectoredExceptionHandler | ManualMapInjector.ManualMapOptions.SkipActivationContext | ManualMapInjector.ManualMapOptions.SkipDelayImports;
		IntPtr intPtr = RecoveredRuntime.CaptureProcessModules(manualMapInjector.GetRemoteProcess()).GetModuleBase(text2);
		if (intPtr != IntPtr.Zero)
		{
			return intPtr;
		}
		DependencySearchFlags @enum = DependencySearchFlags.ResolveApiSetToSystemDirectory;
		if (RecoveredRuntime.IsWow64RemoteProcess(manualMapInjector.GetRemoteProcess()))
		{
			@enum |= DependencySearchFlags.UseWow64SystemDirectory;
		}
		string text = RecoveredRuntime.ResolveDependencyPath(text2, mappingContext.GetFilePath(), Path.GetDirectoryName(mappingContext.GetFilePath()), @enum, manualMapInjector.GetProcessId(), mappingContext.GetActivationContextHandle());
		if (text == null)
		{
			manualMapInjector.SetLastException(new FileNotFoundException(EncodedStringTable.DecodeString(12476) + text2));
			return IntPtr.Zero;
		}
		if ((mappingContext.GetOptions() & ManualMapInjector.ManualMapOptions.ResolveImportsManually) == (ManualMapInjector.ManualMapOptions)0)
		{
			IntPtr result;
			try
			{
				result = new LoadLibraryInjector(manualMapInjector.GetRemoteProcess()).Inject(text);
			}
			catch (Exception innerException)
			{
				manualMapInjector.SetLastException(new Exception(EncodedStringTable.DecodeString(12529) + text, innerException));
				result = IntPtr.Zero;
			}
			return result;
		}
		ManualMapInjector @class = new ManualMapInjector(manualMapInjector.GetRemoteProcess());
		@class.SetRemoteProcess(manualMapInjector.GetRemoteProcess());
		ManualMapInjector class2 = @class;
		IntPtr intPtr2 = class2.InjectModule(text, enum44_);
		if (intPtr2 == IntPtr.Zero)
		{
			manualMapInjector.SetLastException(new Exception(EncodedStringTable.DecodeString(12529) + text, class2.GetLastException()));
		}
		return intPtr2;
	}

	internal static void WritePeHeaders(PeImageWriter peImageWriter)
	{
		peImageWriter.stream.Position = (long)((ulong)peImageWriter.peImage.GetDosHeader().GetPeHeaderOffset());
		peImageWriter.stream.Position += 4L;
		RecoveredRuntime.WriteCoffHeader(peImageWriter);
		RecoveredRuntime.WriteOptionalHeader(peImageWriter);
	}

	internal static void WritePeImage(Stream stream, PeImageWriter peImageWriter)
	{
		stream.SetLength(0L);
		peImageWriter.stream = stream;
		peImageWriter.binaryWriter = new BinaryWriter(stream);
		peImageWriter.peImage.GetStream().Position = 0L;
        BinaryExtensions.CopyTo(peImageWriter.peImage.GetStream(), stream);
		peImageWriter.peImage.GetStream().Position = 0L;
		RecoveredRuntime.WriteDosHeaderPeOffset(peImageWriter);
		RecoveredRuntime.WritePeHeaders(peImageWriter);
		peImageWriter.WriteSectionHeaders();
	}

	internal static PeImage LoadPeImageFromFile(PeImageLayout peImageLayout, string text)
	{
		return PeImageReader.ReadFullImage(new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite), text, flag: true, peImageLayout);
	}

	internal static LoadConfigurationDirectory ReadLoadConfigurationDirectory(BoundsCheckedBinaryReader boundsCheckedBinaryReader, PeImage peImage)
	{
		DataDirectory @class = peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[10];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(peImage, @class.GetVirtualAddress());
		if (num == -1L || !boundsCheckedBinaryReader.IsValidOffset(num))
		{
			return null;
		}
		if (boundsCheckedBinaryReader.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
			return new LoadConfigurationDirectory(boundsCheckedBinaryReader, peImage);
		}
		return null;
	}

	internal static bool FailManualMap(ManualMapInjector manualMapInjector, Exception exception)
	{
		manualMapInjector.SetLastException(exception);
		return false;
	}

	internal static List<ExportedSymbol> GetRemoteModuleExports(ProcessModuleInfo processModuleInfo)
	{
		if (processModuleInfo.items == null)
		{
			using (ProcessMemoryStream stream = new ProcessMemoryStream(processModuleInfo.remoteProcess, processModuleInfo.GetModuleBase(), ProcessMemoryAccess.Read, (long)((ulong)processModuleInfo.GetImageSize())))
			using (PeImage image = PeExportReader.ReadExports(stream, false, PeImageLayout.Memory))
			{
				if (image.GetExports() == null)
				{
					return new List<ExportedSymbol>();
				}
				processModuleInfo.items = new List<ExportedSymbol>(image.GetExports().items2);
			}
			if (!processModuleInfo.remoteProcess.dictionary.ContainsKey(processModuleInfo))
			{
				processModuleInfo.remoteProcess.dictionary.Add(processModuleInfo, processModuleInfo.items);
			}
		}
		return processModuleInfo.items;
	}

	internal static long MapRvaToFileOffset(PeImage peImage, uint uintValue)
	{
		return peImage.rvaMapper.MapRvaToFileOffset(peImage, uintValue);
	}

	internal static void WriteCoffHeader(PeImageWriter peImageWriter)
	{
		CoffHeader @class = peImageWriter.peImage.GetHeaders().GetCoffHeader();
		peImageWriter.binaryWriter.Write((ushort)@class.GetMachine());
		@class.SetNumberOfSections((ushort)peImageWriter.peImage.GetSections().Count);
		peImageWriter.binaryWriter.Write(@class.GetNumberOfSections());
		peImageWriter.binaryWriter.Write(@class.GetTimeDateStamp());
		peImageWriter.binaryWriter.Write(@class.GetPointerToSymbolTable());
		peImageWriter.binaryWriter.Write(@class.GetNumberOfSymbols());
		peImageWriter.binaryWriter.Write(@class.GetSizeOfOptionalHeader());
		peImageWriter.binaryWriter.Write((ushort)@class.GetCharacteristics());
	}

	internal static TlsDirectory ReadTlsDirectory(PeImage peImage, BoundsCheckedBinaryReader boundsCheckedBinaryReader)
	{
		DataDirectory @class = peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[9];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(peImage, @class.GetVirtualAddress());
		if (num == -1L || !boundsCheckedBinaryReader.IsValidOffset(num))
		{
			return null;
		}
		if (!boundsCheckedBinaryReader.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			return null;
		}
		RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
		return new TlsDirectory(boundsCheckedBinaryReader, peImage);
	}

	internal static List<ImportedSymbol> ReadImportedSymbols(BoundsCheckedBinaryReader boundsCheckedBinaryReader, ImportDirectory importDirectory, PeImage peImage)
	{
		List<ImportedSymbol> list = new List<ImportedSymbol>();
		ulong ulong_;
		while ((ulong_ = (RecoveredRuntime.Is32BitImage(peImage) ? ((ulong)boundsCheckedBinaryReader.ReadUInt32()) : boundsCheckedBinaryReader.ReadUInt64())) != 0UL)
		{
			ImportedSymbol @class = new ImportedSymbol();
			@class.SetThunkValue(ulong_);
			ImportedSymbol class2 = @class;
			class2.SetIsOrdinal((class2.GetThunkValue() & (RecoveredRuntime.Is32BitImage(peImage) ? 2147483648UL : 9223372036854775808UL)) > 0UL);
			if (!class2.GetIsOrdinal())
			{
				long num = RecoveredRuntime.MapRvaToFileOffset(peImage, (uint)class2.GetThunkValue());
				long position = boundsCheckedBinaryReader.BaseStream.Position;
				if (num != -1L && boundsCheckedBinaryReader.IsValidOffset(num))
				{
					RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
					class2.SetHint(boundsCheckedBinaryReader.ReadUInt16());
					class2.SetName(RecoveredRuntime.ReadNullTerminatedAsciiString(boundsCheckedBinaryReader));
				}
				RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, position);
			}
			else
			{
				class2.SetOrdinal((ushort)(class2.GetThunkValue() & 65535UL));
			}
			list.Add(class2);
		}
		return list;
	}

	internal static void WriteOptionalHeader(PeImageWriter peImageWriter)
	{
		IPeOptionalHeader @interface = peImageWriter.peImage.GetHeaders().GetOptionalHeader();
		BinaryWriter writer = peImageWriter.binaryWriter;
		bool is32Bit = RecoveredRuntime.Is32BitImage(peImageWriter.peImage);

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

	internal static void ShowModuleOptions(ModuleEntry moduleEntry)
	{
		if (!File.Exists(moduleEntry.Path))
		{
			return;
		}

		try
		{
			using (FileStream fileStream = new FileStream(moduleEntry.Path, FileMode.Open, FileAccess.Read, FileShare.Read))
			using (PeImage image = PeExportReader.ReadExports(fileStream, moduleEntry.Path, false, PeImageLayout.File))
			{
				if (image == null)
				{
					return;
				}

				using (ModuleOptionsForm form = new ModuleOptionsForm
				{
					Module = moduleEntry,
					Image = image
				})
				{
				form.ShowDialog();
				}
			}
		}
		catch
		{
			return;
		}
	}

	internal static Stream OpenImageReadStream(PeImage peImage)
	{
		Stream imageStream = peImage.GetStream();
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

	internal static void HandleRuntimeDependencyInstallation(string text, string text2, string text3, PeImage peImage, string text4, MainForm mainForm, string text5, bool flag, string text6, bool flag2, string text7)
	{
		if (flag)
		{
			if (!PlatformInfo.flag2)
			{
				RecoveredRuntime.ShowUnsupportedWindowsXpMessage(text3, mainForm, peImage.GetFileName());
				return;
			}

			string packageName = RecoveredRuntime.Is32BitImage(peImage) ? text5 : text6;
			RecoveredRuntime.PromptDependencyInstallation(peImage.GetFileName(), mainForm, text2, packageName, text3);
			return;
		}

		if (!RecoveredRuntime.ConfirmDependencyInstallation(mainForm, peImage.GetFileName(), text3, text4, flag2, string.Format(EncodedStringTable.DecodeString(14117), text7)))
		{
			return;
		}

		DependencyInstallerForm form = new DependencyInstallerForm();
		RecoveredRuntime.ConfigureInstallerDownload(form, text, text2, EncodedStringTable.DecodeString(14162) + (RecoveredRuntime.Is32BitImage(peImage) ? EncodedStringTable.DecodeString(14180) : EncodedStringTable.DecodeString(14175)) + EncodedStringTable.DecodeString(93));
		form.ShowDialog();
	}

	internal static ManualMapInjector.ManualMapOptions BuildManualMapOptions(ManualMapInjector manualMapInjector)
	{
		ManualMapInjector.ManualMapOptions @enum = (ManualMapInjector.ManualMapOptions)0;
		if (manualMapInjector.GetDisableExceptionSupport())
		{
			@enum |= ManualMapInjector.ManualMapOptions.DisableExceptionSupport;
		}
		if (manualMapInjector.GetErasePeHeaders())
		{
			@enum |= ManualMapInjector.ManualMapOptions.ErasePeHeaders;
		}
		if (manualMapInjector.GetManualResolveImports())
		{
			@enum |= ManualMapInjector.ManualMapOptions.ResolveImportsManually;
		}
		if (manualMapInjector.GetDisableSehValidation())
		{
			@enum |= ManualMapInjector.ManualMapOptions.DisableSehValidation;
		}
		return @enum;
	}

	internal static PeImage ReadRemoteModuleImage(ProcessModuleInfo processModuleInfo)
	{
		PeImage result;
		using (ProcessMemoryStream stream = new ProcessMemoryStream(processModuleInfo.remoteProcess, processModuleInfo.GetModuleBase(), ProcessMemoryAccess.Read, (long)((ulong)processModuleInfo.GetImageSize())))
		{
			result = PeImageReader.ReadFullImage(stream, false, PeImageLayout.Memory);
		}
		return result;
	}

	private static bool ModuleMatchesProcessArchitecture(RemoteProcess process, string modulePath, out string mismatchMessage)
	{
		mismatchMessage = null;
		bool moduleIs32Bit;
		using (FileStream stream = new FileStream(modulePath, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (PeImage module = PeImportReader.ReadImports(stream, modulePath, flag: false, PeImageLayout.File))
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
				ReportInjectionErrorSafely(
					reportError,
					UiText.Format("Message.ErasePeFailed", Path.GetFileName(sourceModulePath)),
					exception);
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
				ReportInjectionErrorSafely(
					reportError,
					UiText.Format("Message.HideModuleFailed", Path.GetFileName(sourceModulePath)),
					exception);
			}
		}
	}

	internal static void SkipBytes(BoundsCheckedBinaryReader boundsCheckedBinaryReader, int intValue)
	{
		boundsCheckedBinaryReader.BaseStream.Position += intValue;
	}

	internal static BaseRelocationDirectory ReadBaseRelocationDirectory(PeImage peImage, BoundsCheckedBinaryReader boundsCheckedBinaryReader)
	{
		DataDirectory @class = peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[5];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(peImage, @class.GetVirtualAddress());
		if (num == -1L || !boundsCheckedBinaryReader.IsValidOffset(num))
		{
			return null;
		}
		if (num + (long)((ulong)@class.GetSize()) > boundsCheckedBinaryReader.BaseStream.Length)
		{
			return null;
		}
		RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
		return new BaseRelocationDirectory(boundsCheckedBinaryReader, peImage);
	}

	internal static void InitializeManualMapOptionsForm(ManualMapOptionsForm manualMapOptionsForm)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ManualMapOptionsForm));
		manualMapOptionsForm.groupBox = new GroupBox();
		manualMapOptionsForm.checkBox4 = new CheckBox();
		manualMapOptionsForm.checkBox = new CheckBox();
		manualMapOptionsForm.checkBox2 = new CheckBox();
		manualMapOptionsForm.groupBox2 = new GroupBox();
		manualMapOptionsForm.checkBox3 = new CheckBox();
		manualMapOptionsForm.groupBox.SuspendLayout();
		manualMapOptionsForm.groupBox2.SuspendLayout();
		manualMapOptionsForm.SuspendLayout();
		manualMapOptionsForm.groupBox.Controls.Add(manualMapOptionsForm.checkBox4);
		manualMapOptionsForm.groupBox.Controls.Add(manualMapOptionsForm.checkBox);
		manualMapOptionsForm.groupBox.Controls.Add(manualMapOptionsForm.checkBox2);
		manualMapOptionsForm.groupBox.Location = new Point(12, 65);
		manualMapOptionsForm.groupBox.Name = EncodedStringTable.DecodeString(14653);
		manualMapOptionsForm.groupBox.Size = new Size(199, 93);
		manualMapOptionsForm.groupBox.TabIndex = 1;
		manualMapOptionsForm.groupBox.TabStop = false;
		manualMapOptionsForm.groupBox.Text = EncodedStringTable.DecodeString(14678);
		manualMapOptionsForm.checkBox4.AutoSize = true;
		manualMapOptionsForm.checkBox4.Location = new Point(10, 67);
		manualMapOptionsForm.checkBox4.Name = EncodedStringTable.DecodeString(14703);
		manualMapOptionsForm.checkBox4.Size = new Size(184, 17);
		manualMapOptionsForm.checkBox4.TabIndex = 2;
		manualMapOptionsForm.checkBox4.Text = EncodedStringTable.DecodeString(14748);
		manualMapOptionsForm.checkBox4.UseVisualStyleBackColor = true;
		manualMapOptionsForm.checkBox4.CheckedChanged += manualMapOptionsForm.OnDisableSehValidationChanged;
		manualMapOptionsForm.checkBox.AutoSize = true;
		manualMapOptionsForm.checkBox.Location = new Point(10, 44);
		manualMapOptionsForm.checkBox.Name = EncodedStringTable.DecodeString(14789);
		manualMapOptionsForm.checkBox.Size = new Size(161, 17);
		manualMapOptionsForm.checkBox.TabIndex = 1;
		manualMapOptionsForm.checkBox.Text = EncodedStringTable.DecodeString(14826);
		manualMapOptionsForm.checkBox.UseVisualStyleBackColor = true;
		manualMapOptionsForm.checkBox.CheckedChanged += manualMapOptionsForm.OnDisableExceptionSupportChanged;
		manualMapOptionsForm.checkBox2.AutoSize = true;
		manualMapOptionsForm.checkBox2.Location = new Point(10, 21);
		manualMapOptionsForm.checkBox2.Name = EncodedStringTable.DecodeString(14863);
		manualMapOptionsForm.checkBox2.Size = new Size(140, 17);
		manualMapOptionsForm.checkBox2.TabIndex = 0;
		manualMapOptionsForm.checkBox2.Text = EncodedStringTable.DecodeString(14896);
		manualMapOptionsForm.checkBox2.UseVisualStyleBackColor = true;
		manualMapOptionsForm.checkBox2.CheckedChanged += manualMapOptionsForm.OnManualResolveImportsChanged;
		manualMapOptionsForm.groupBox2.Controls.Add(manualMapOptionsForm.checkBox3);
		manualMapOptionsForm.groupBox2.Location = new Point(12, 12);
		manualMapOptionsForm.groupBox2.Name = EncodedStringTable.DecodeString(14925);
		manualMapOptionsForm.groupBox2.Size = new Size(199, 47);
		manualMapOptionsForm.groupBox2.TabIndex = 2;
		manualMapOptionsForm.groupBox2.TabStop = false;
		manualMapOptionsForm.groupBox2.Text = EncodedStringTable.DecodeString(14946);
		manualMapOptionsForm.checkBox3.AutoSize = true;
		manualMapOptionsForm.checkBox3.Location = new Point(10, 21);
		manualMapOptionsForm.checkBox3.Name = EncodedStringTable.DecodeString(14959);
		manualMapOptionsForm.checkBox3.Size = new Size(173, 17);
		manualMapOptionsForm.checkBox3.TabIndex = 1;
		manualMapOptionsForm.checkBox3.Text = EncodedStringTable.DecodeString(14992);
		manualMapOptionsForm.checkBox3.UseVisualStyleBackColor = true;
		manualMapOptionsForm.checkBox3.CheckedChanged += manualMapOptionsForm.OnHideFromDebuggerChanged;
		manualMapOptionsForm.AutoScaleDimensions = new SizeF(96f, 96f);
		manualMapOptionsForm.AutoScaleMode = AutoScaleMode.Dpi;
		manualMapOptionsForm.ClientSize = new Size(223, 170);
		manualMapOptionsForm.Controls.Add(manualMapOptionsForm.groupBox2);
		manualMapOptionsForm.Controls.Add(manualMapOptionsForm.groupBox);
		manualMapOptionsForm.Font = new Font(EncodedStringTable.DecodeString(11956), 8.25f);
		manualMapOptionsForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		manualMapOptionsForm.Icon = componentResourceManager.GetObject("$this.Icon") as Icon;
		manualMapOptionsForm.Name = EncodedStringTable.DecodeString(15029);
		manualMapOptionsForm.StartPosition = FormStartPosition.CenterParent;
		manualMapOptionsForm.Text = EncodedStringTable.DecodeString(15058);
		manualMapOptionsForm.groupBox.ResumeLayout(false);
		manualMapOptionsForm.groupBox.PerformLayout();
		manualMapOptionsForm.groupBox2.ResumeLayout(false);
		manualMapOptionsForm.groupBox2.PerformLayout();
		manualMapOptionsForm.ResumeLayout(false);
	}

	internal static void InitializeAdvancedScrambleSettingsForm(AdvancedScrambleSettingsForm advancedScrambleSettingsForm)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvancedScrambleSettingsForm));
		advancedScrambleSettingsForm.groupBox = new GroupBox();
		advancedScrambleSettingsForm.checkBox2 = new CheckBox();
		advancedScrambleSettingsForm.checkBox = new CheckBox();
		advancedScrambleSettingsForm.groupBox2 = new GroupBox();
		advancedScrambleSettingsForm.checkBox7 = new CheckBox();
		advancedScrambleSettingsForm.checkBox6 = new CheckBox();
		advancedScrambleSettingsForm.checkBox5 = new CheckBox();
		advancedScrambleSettingsForm.checkBox3 = new CheckBox();
		advancedScrambleSettingsForm.checkBox4 = new CheckBox();
		advancedScrambleSettingsForm.groupBox3 = new GroupBox();
		advancedScrambleSettingsForm.checkBox11 = new CheckBox();
		advancedScrambleSettingsForm.checkBox10 = new CheckBox();
		advancedScrambleSettingsForm.checkBox8 = new CheckBox();
		advancedScrambleSettingsForm.checkBox9 = new CheckBox();
		advancedScrambleSettingsForm.checkBox13 = new CheckBox();
		advancedScrambleSettingsForm.checkBox12 = new CheckBox();
		advancedScrambleSettingsForm.groupBox.SuspendLayout();
		advancedScrambleSettingsForm.groupBox2.SuspendLayout();
		advancedScrambleSettingsForm.groupBox3.SuspendLayout();
		advancedScrambleSettingsForm.SuspendLayout();
		advancedScrambleSettingsForm.groupBox.Controls.Add(advancedScrambleSettingsForm.checkBox2);
		advancedScrambleSettingsForm.groupBox.Controls.Add(advancedScrambleSettingsForm.checkBox);
		advancedScrambleSettingsForm.groupBox.Location = new Point(12, 12);
		advancedScrambleSettingsForm.groupBox.Name = EncodedStringTable.DecodeString(15083);
		advancedScrambleSettingsForm.groupBox.Size = new Size(187, 68);
		advancedScrambleSettingsForm.groupBox.TabIndex = 0;
		advancedScrambleSettingsForm.groupBox.TabStop = false;
		advancedScrambleSettingsForm.groupBox.Text = EncodedStringTable.DecodeString(15104);
		advancedScrambleSettingsForm.checkBox2.AutoSize = true;
		advancedScrambleSettingsForm.checkBox2.Location = new Point(9, 44);
		advancedScrambleSettingsForm.checkBox2.Name = EncodedStringTable.DecodeString(15125);
		advancedScrambleSettingsForm.checkBox2.Size = new Size(132, 17);
		advancedScrambleSettingsForm.checkBox2.TabIndex = 1;
		advancedScrambleSettingsForm.checkBox2.Text = EncodedStringTable.DecodeString(15162);
		advancedScrambleSettingsForm.checkBox2.UseVisualStyleBackColor = true;
		advancedScrambleSettingsForm.checkBox.AutoSize = true;
		advancedScrambleSettingsForm.checkBox.Location = new Point(9, 21);
		advancedScrambleSettingsForm.checkBox.Name = EncodedStringTable.DecodeString(15191);
		advancedScrambleSettingsForm.checkBox.Size = new Size(142, 17);
		advancedScrambleSettingsForm.checkBox.TabIndex = 0;
		advancedScrambleSettingsForm.checkBox.Text = EncodedStringTable.DecodeString(15224);
		advancedScrambleSettingsForm.checkBox.UseVisualStyleBackColor = true;
		advancedScrambleSettingsForm.groupBox2.Controls.Add(advancedScrambleSettingsForm.checkBox12);
		advancedScrambleSettingsForm.groupBox2.Controls.Add(advancedScrambleSettingsForm.checkBox13);
		advancedScrambleSettingsForm.groupBox2.Controls.Add(advancedScrambleSettingsForm.checkBox7);
		advancedScrambleSettingsForm.groupBox2.Controls.Add(advancedScrambleSettingsForm.checkBox6);
		advancedScrambleSettingsForm.groupBox2.Controls.Add(advancedScrambleSettingsForm.checkBox5);
		advancedScrambleSettingsForm.groupBox2.Controls.Add(advancedScrambleSettingsForm.checkBox3);
		advancedScrambleSettingsForm.groupBox2.Controls.Add(advancedScrambleSettingsForm.checkBox4);
		advancedScrambleSettingsForm.groupBox2.Location = new Point(12, 86);
		advancedScrambleSettingsForm.groupBox2.Name = EncodedStringTable.DecodeString(15257);
		advancedScrambleSettingsForm.groupBox2.Size = new Size(187, 186);
		advancedScrambleSettingsForm.groupBox2.TabIndex = 1;
		advancedScrambleSettingsForm.groupBox2.TabStop = false;
		advancedScrambleSettingsForm.groupBox2.Text = EncodedStringTable.DecodeString(15282);
		advancedScrambleSettingsForm.checkBox7.AutoSize = true;
		advancedScrambleSettingsForm.checkBox7.Location = new Point(9, 159);
		advancedScrambleSettingsForm.checkBox7.Name = EncodedStringTable.DecodeString(15303);
		advancedScrambleSettingsForm.checkBox7.Size = new Size(141, 17);
		advancedScrambleSettingsForm.checkBox7.TabIndex = 4;
		advancedScrambleSettingsForm.checkBox7.Text = EncodedStringTable.DecodeString(15336);
		advancedScrambleSettingsForm.checkBox7.UseVisualStyleBackColor = true;
		advancedScrambleSettingsForm.checkBox6.AutoSize = true;
		advancedScrambleSettingsForm.checkBox6.Location = new Point(9, 90);
		advancedScrambleSettingsForm.checkBox6.Name = EncodedStringTable.DecodeString(15365);
		advancedScrambleSettingsForm.checkBox6.Size = new Size(112, 17);
		advancedScrambleSettingsForm.checkBox6.TabIndex = 3;
		advancedScrambleSettingsForm.checkBox6.Text = EncodedStringTable.DecodeString(15398);
		advancedScrambleSettingsForm.checkBox6.UseVisualStyleBackColor = true;
		advancedScrambleSettingsForm.checkBox5.AutoSize = true;
		advancedScrambleSettingsForm.checkBox5.Location = new Point(9, 67);
		advancedScrambleSettingsForm.checkBox5.Name = EncodedStringTable.DecodeString(15419);
		advancedScrambleSettingsForm.checkBox5.Size = new Size(139, 17);
		advancedScrambleSettingsForm.checkBox5.TabIndex = 2;
		advancedScrambleSettingsForm.checkBox5.Text = EncodedStringTable.DecodeString(15444);
		advancedScrambleSettingsForm.checkBox5.UseVisualStyleBackColor = true;
		advancedScrambleSettingsForm.checkBox3.AutoSize = true;
		advancedScrambleSettingsForm.checkBox3.Location = new Point(9, 44);
		advancedScrambleSettingsForm.checkBox3.Name = EncodedStringTable.DecodeString(15473);
		advancedScrambleSettingsForm.checkBox3.Size = new Size(116, 17);
		advancedScrambleSettingsForm.checkBox3.TabIndex = 1;
		advancedScrambleSettingsForm.checkBox3.Text = EncodedStringTable.DecodeString(15506);
		advancedScrambleSettingsForm.checkBox3.UseVisualStyleBackColor = true;
		advancedScrambleSettingsForm.checkBox4.AutoSize = true;
		advancedScrambleSettingsForm.checkBox4.Location = new Point(9, 21);
		advancedScrambleSettingsForm.checkBox4.Name = EncodedStringTable.DecodeString(15531);
		advancedScrambleSettingsForm.checkBox4.Size = new Size(128, 17);
		advancedScrambleSettingsForm.checkBox4.TabIndex = 0;
		advancedScrambleSettingsForm.checkBox4.Text = EncodedStringTable.DecodeString(15564);
		advancedScrambleSettingsForm.checkBox4.UseVisualStyleBackColor = true;
		advancedScrambleSettingsForm.groupBox3.Controls.Add(advancedScrambleSettingsForm.checkBox11);
		advancedScrambleSettingsForm.groupBox3.Controls.Add(advancedScrambleSettingsForm.checkBox10);
		advancedScrambleSettingsForm.groupBox3.Controls.Add(advancedScrambleSettingsForm.checkBox8);
		advancedScrambleSettingsForm.groupBox3.Controls.Add(advancedScrambleSettingsForm.checkBox9);
		advancedScrambleSettingsForm.groupBox3.Location = new Point(12, 278);
		advancedScrambleSettingsForm.groupBox3.Name = EncodedStringTable.DecodeString(15593);
		advancedScrambleSettingsForm.groupBox3.Size = new Size(187, 120);
		advancedScrambleSettingsForm.groupBox3.TabIndex = 2;
		advancedScrambleSettingsForm.groupBox3.TabStop = false;
		advancedScrambleSettingsForm.groupBox3.Text = EncodedStringTable.DecodeString(15626);
		advancedScrambleSettingsForm.checkBox11.AutoSize = true;
		advancedScrambleSettingsForm.checkBox11.Location = new Point(9, 44);
		advancedScrambleSettingsForm.checkBox11.Name = EncodedStringTable.DecodeString(15651);
		advancedScrambleSettingsForm.checkBox11.Size = new Size(129, 17);
		advancedScrambleSettingsForm.checkBox11.TabIndex = 6;
		advancedScrambleSettingsForm.checkBox11.Text = EncodedStringTable.DecodeString(15684);
		advancedScrambleSettingsForm.checkBox11.UseVisualStyleBackColor = true;
		advancedScrambleSettingsForm.checkBox10.AutoSize = true;
		advancedScrambleSettingsForm.checkBox10.Location = new Point(9, 90);
		advancedScrambleSettingsForm.checkBox10.Name = EncodedStringTable.DecodeString(15709);
		advancedScrambleSettingsForm.checkBox10.Size = new Size(169, 17);
		advancedScrambleSettingsForm.checkBox10.TabIndex = 5;
		advancedScrambleSettingsForm.checkBox10.Text = EncodedStringTable.DecodeString(15754);
		advancedScrambleSettingsForm.checkBox10.UseVisualStyleBackColor = true;
		advancedScrambleSettingsForm.checkBox8.AutoSize = true;
		advancedScrambleSettingsForm.checkBox8.Location = new Point(9, 67);
		advancedScrambleSettingsForm.checkBox8.Name = EncodedStringTable.DecodeString(15791);
		advancedScrambleSettingsForm.checkBox8.Size = new Size(138, 17);
		advancedScrambleSettingsForm.checkBox8.TabIndex = 4;
		advancedScrambleSettingsForm.checkBox8.Text = EncodedStringTable.DecodeString(15828);
		advancedScrambleSettingsForm.checkBox8.UseVisualStyleBackColor = true;
		advancedScrambleSettingsForm.checkBox9.AutoSize = true;
		advancedScrambleSettingsForm.checkBox9.Location = new Point(9, 21);
		advancedScrambleSettingsForm.checkBox9.Name = EncodedStringTable.DecodeString(15857);
		advancedScrambleSettingsForm.checkBox9.Size = new Size(128, 17);
		advancedScrambleSettingsForm.checkBox9.TabIndex = 3;
		advancedScrambleSettingsForm.checkBox9.Text = EncodedStringTable.DecodeString(15894);
		advancedScrambleSettingsForm.checkBox9.UseVisualStyleBackColor = true;
		advancedScrambleSettingsForm.checkBox13.AutoSize = true;
		advancedScrambleSettingsForm.checkBox13.Location = new Point(9, 113);
		advancedScrambleSettingsForm.checkBox13.Name = EncodedStringTable.DecodeString(15923);
		advancedScrambleSettingsForm.checkBox13.Size = new Size(133, 17);
		advancedScrambleSettingsForm.checkBox13.TabIndex = 5;
		advancedScrambleSettingsForm.checkBox13.Text = EncodedStringTable.DecodeString(15960);
		advancedScrambleSettingsForm.checkBox13.UseVisualStyleBackColor = true;
		advancedScrambleSettingsForm.checkBox12.AutoSize = true;
		advancedScrambleSettingsForm.checkBox12.Location = new Point(9, 136);
		advancedScrambleSettingsForm.checkBox12.Name = EncodedStringTable.DecodeString(15989);
		advancedScrambleSettingsForm.checkBox12.Size = new Size(165, 17);
		advancedScrambleSettingsForm.checkBox12.TabIndex = 6;
		advancedScrambleSettingsForm.checkBox12.Text = EncodedStringTable.DecodeString(16030);
		advancedScrambleSettingsForm.checkBox12.UseVisualStyleBackColor = true;
		advancedScrambleSettingsForm.AutoScaleDimensions = new SizeF(96f, 96f);
		advancedScrambleSettingsForm.AutoScaleMode = AutoScaleMode.Dpi;
		advancedScrambleSettingsForm.ClientSize = new Size(213, 411);
		advancedScrambleSettingsForm.Controls.Add(advancedScrambleSettingsForm.groupBox3);
		advancedScrambleSettingsForm.Controls.Add(advancedScrambleSettingsForm.groupBox2);
		advancedScrambleSettingsForm.Controls.Add(advancedScrambleSettingsForm.groupBox);
		advancedScrambleSettingsForm.Font = new Font(EncodedStringTable.DecodeString(11956), 8.25f);
		advancedScrambleSettingsForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		advancedScrambleSettingsForm.Icon = componentResourceManager.GetObject("$this.Icon") as Icon;
		advancedScrambleSettingsForm.Name = EncodedStringTable.DecodeString(16071);
		advancedScrambleSettingsForm.StartPosition = FormStartPosition.CenterParent;
		advancedScrambleSettingsForm.Text = EncodedStringTable.DecodeString(16100);
		advancedScrambleSettingsForm.groupBox.ResumeLayout(false);
		advancedScrambleSettingsForm.groupBox.PerformLayout();
		advancedScrambleSettingsForm.groupBox2.ResumeLayout(false);
		advancedScrambleSettingsForm.groupBox2.PerformLayout();
		advancedScrambleSettingsForm.groupBox3.ResumeLayout(false);
		advancedScrambleSettingsForm.groupBox3.PerformLayout();
		advancedScrambleSettingsForm.ResumeLayout(false);
	}

	internal static void HandleLegacyNativeDependency(PeImage peImage, string text2, MainForm mainForm)
	{
		if (!text2.StartsWith(EncodedStringTable.DecodeString(16137), StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		string text = RecoveredRuntime.ResolveImageDependencyPath(peImage, text2);
		bool flag = false;
		if (!string.IsNullOrEmpty(text))
		{
			using (FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				try
				{
					PeImage @class = PeImportReader.ReadImports(fileStream, text, false, PeImageLayout.File);
					if (@class != null && RecoveredRuntime.Is32BitImage(@class) != RecoveredRuntime.Is32BitImage(peImage))
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
		bool flag2 = text2.EndsWith(EncodedStringTable.DecodeString(16146), StringComparison.OrdinalIgnoreCase);
		string string_;
		if (!PlatformInfo.flag || !RecoveredRuntime.Is32BitImage(peImage))
		{
			string_ = PlatformInfo.text2;
		}
		else
		{
			string_ = PlatformInfo.text3;
		}
		if (!RecoveredRuntime.MatchesDependencyName(text2, EncodedStringTable.DecodeString(16155)))
		{
			if (RecoveredRuntime.MatchesDependencyName(text2, EncodedStringTable.DecodeString(16671)))
			{
				string text3 = EncodedStringTable.DecodeString(16676);
				string text4 = EncodedStringTable.DecodeString(16685);
				string text5 = EncodedStringTable.DecodeString(16843);
				string text6 = EncodedStringTable.DecodeString(17001);
				RecoveredRuntime.HandleRuntimeDependencyInstallation(text6, string_, text2, peImage, text, mainForm, text4, flag2, text5, flag, text3);
				return;
			}
			if (RecoveredRuntime.MatchesDependencyName(text2, EncodedStringTable.DecodeString(17078)))
			{
				string text7 = EncodedStringTable.DecodeString(17083);
				string text8 = EncodedStringTable.DecodeString(17092);
				string text9 = EncodedStringTable.DecodeString(17250);
				string text10 = EncodedStringTable.DecodeString(17408);
				RecoveredRuntime.HandleRuntimeDependencyInstallation(text10, string_, text2, peImage, text, mainForm, text8, flag2, text9, flag, text7);
				return;
			}
			if (RecoveredRuntime.MatchesDependencyName(text2, EncodedStringTable.DecodeString(17485)))
			{
				string text11 = EncodedStringTable.DecodeString(17490);
				string text12 = EncodedStringTable.DecodeString(17499);
				string text13 = EncodedStringTable.DecodeString(17657);
				string text14 = EncodedStringTable.DecodeString(17815);
				RecoveredRuntime.HandleRuntimeDependencyInstallation(text14, string_, text2, peImage, text, mainForm, text12, flag2, text13, flag2, text11);
			}
			return;
		}
		else
		{
			if (flag2)
			{
				string text15 = RecoveredRuntime.Is32BitImage(peImage) ? EncodedStringTable.DecodeString(16318) : EncodedStringTable.DecodeString(16160);
				RecoveredRuntime.PromptDependencyInstallation(peImage.GetFileName(), mainForm, string_, text15, text2);
				return;
			}
			if (!RecoveredRuntime.ConfirmDependencyInstallation(mainForm, peImage.GetFileName(), text2, text, flag, EncodedStringTable.DecodeString(16476)))
			{
				return;
			}
			if (!RecoveredRuntime.Is32BitImage(peImage))
			{
				Process.Start(EncodedStringTable.DecodeString(16594));
				return;
			}
			Process.Start(EncodedStringTable.DecodeString(16521));
			return;
		}
	}

	internal static void CreateActivationContextFromManifest(ManualMapInjector manualMapInjector, ManualMapInjector.MappingContext mappingContext)
	{
		byte[] array = ManualMapInjector.ExtractManifestResource(mappingContext.GetImage());
		if (array == null)
		{
			return;
		}
		string tempFileName = Path.GetTempFileName();
		try
		{
			File.WriteAllBytes(tempFileName, array);
			NativeTypes.ActivationContext activationContext = default(NativeTypes.ActivationContext);
			activationContext.intValue = typeof(NativeTypes.ActivationContext).SizeOf();
			activationContext.text = tempFileName;
			mappingContext.SetActivationContextHandle(RecoveredRuntime.CreateActCtx(ref activationContext));
		}
		finally
		{
			File.Delete(tempFileName);
		}
	}

	internal static void LoadSettingsIntoForm(SettingsForm settingsForm)
	{
		InjectionOptions class14_ = ApplicationSettings.Current.Options;
		settingsForm.comboBox.SelectedIndex = (int)class14_.Method;
		settingsForm.panel3.BackColor = class14_.TextColor;
		settingsForm.panel2.BackColor = class14_.BackgroundColor1;
		settingsForm.panel.BackColor = class14_.BackgroundColor2;
		settingsForm.checkBox3.Checked = class14_.AutoInject;
		settingsForm.checkBox.Checked = class14_.StealthInject;
		settingsForm.checkBox2.Checked = class14_.CloseOnInject;
		settingsForm.numericUpDown.Value = class14_.DelayBetweenModules;
		settingsForm.numericUpDown2.Value = class14_.DelayBeforeInjection;
		settingsForm.checkBox5.Checked = class14_.ErasePeHeaders;
		settingsForm.checkBox4.Checked = class14_.HideModule;
		RecoveredRuntime.SelectCurrentScramblePreset(settingsForm);
	}

	internal static void ResetManualMapOptions(ManualMapInjector manualMapInjector)
	{
		manualMapInjector.SetManualResolveImports(flag: false);
		manualMapInjector.SetErasePeHeaders(flag: false);
		manualMapInjector.SetDisableExceptionSupport(flag: false);
		manualMapInjector.SetHideRemoteThreadFromDebugger(flag: false);
	}

	internal static void CheckImportedDependencies(PeImage peImage, MainForm mainForm)
	{
		if (peImage.GetImports() == null)
		{
			return;
		}
		foreach (KeyValuePair<string, List<string>> import in peImage.GetImports().dictionary)
		{
			string dependencyName = import.Key;
			if (!string.IsNullOrEmpty(dependencyName))
			{
				RecoveredRuntime.HandleLegacyNativeDependency(peImage, dependencyName, mainForm);
				RecoveredRuntime.HandleLegacyManagedDependency(peImage, dependencyName, mainForm);
			}
		}
	}

	internal static Stream CopyImageRange(PeImage peImage, long longValue, int intValue)
	{
		Stream imageStream = peImage.GetStream();
		lock (imageStream)
		{
			long originalPosition = imageStream.Position;
			try
			{
				imageStream.Position = longValue;
				MemoryStream copy = new MemoryStream();
				imageStream.CopyBytesTo(copy, intValue);
				copy.Position = 0L;
				return copy;
			}
			finally
			{
				imageStream.Position = originalPosition;
			}
		}
	}

	internal static void RegisterManualMappedModule(ProcessModuleCollection processModuleCollection, PeImage peImage, IntPtr address, bool flag)
	{
		ProcessModuleInfo gclass = new ProcessModuleInfo(processModuleCollection.remoteProcess, null, address, flag, true);
		string string_ = peImage.GetFilePath();
		string fileName = Path.GetFileName(peImage.GetFilePath());
		IntPtr intptr_ = address.Add((long)((ulong)peImage.GetHeaders().GetOptionalHeader().GetAddressOfEntryPoint()));
		uint uint_ = peImage.GetHeaders().GetOptionalHeader().GetSizeOfImage();
		RecoveredRuntime.SetProcessModuleMetadata(string_, fileName, intptr_, gclass, uint_);
		processModuleCollection.remoteProcess.items2.Add(gclass);
	}

	internal static bool TryReadPeHeaders(ref PeHeaders peHeaders, [Out] BoundsCheckedBinaryReader boundsCheckedBinaryReader)
	{
		peHeaders = null;
		if (boundsCheckedBinaryReader.ReadUInt32() != 0x00004550U)
		{
			return false;
		}

		var headers = new PeHeaders();
		headers.SetSignature(0x00004550U);
		headers.SetCoffHeader(new CoffHeader(boundsCheckedBinaryReader));

		if (headers.GetCoffHeader().GetSizeOfOptionalHeader() < sizeof(ushort))
		{
			return false;
		}

		long optionalHeaderStart = boundsCheckedBinaryReader.BaseStream.Position;
		ushort magic = boundsCheckedBinaryReader.ReadUInt16();
		boundsCheckedBinaryReader.BaseStream.Position = optionalHeaderStart;

		if (magic == 0x010B)
		{
			Pe32OptionalHeader optionalHeader;
			if (!TryReadPe32OptionalHeader(boundsCheckedBinaryReader, headers.GetCoffHeader().GetSizeOfOptionalHeader(), out optionalHeader))
			{
				return false;
			}

			headers.SetOptionalHeader(optionalHeader);
		}
		else if (magic == 0x020B)
		{
			Pe64OptionalHeader optionalHeader;
			if (!TryReadPe64OptionalHeader(boundsCheckedBinaryReader, headers.GetCoffHeader().GetSizeOfOptionalHeader(), out optionalHeader))
			{
				return false;
			}

			headers.SetOptionalHeader(optionalHeader);
		}
		else
		{
			return false;
		}

		peHeaders = headers;
		return true;
	}
}
