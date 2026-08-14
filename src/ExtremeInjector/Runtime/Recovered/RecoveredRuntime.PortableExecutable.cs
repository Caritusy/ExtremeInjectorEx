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

	internal static void smethod_0(PeScrambler gclass4_0)
	{
		DataDirectory @class = gclass4_0.class154_0.method_6().method_3().imethod_49()[1];
		long num = RecoveredRuntime.smethod_135(gclass4_0.class154_0, @class.method_0());
		if (num == -1L)
		{
			return;
		}
		using (Stream stream = RecoveredRuntime.smethod_174(gclass4_0.class154_0))
		{
			using (BinaryReader binaryReader = new BinaryReader(stream))
			{
				stream.Position = num;
				for (;;)
				{
					bool flag = binaryReader.ReadUInt32() != 0u;
					stream.Position += 8L;
					uint uint_ = binaryReader.ReadUInt32();
					uint num2 = binaryReader.ReadUInt32();
					if (!flag && num2 == 0u)
					{
						break;
					}
					long num3 = RecoveredRuntime.smethod_135(gclass4_0.class154_0, uint_);
					if (num3 != -1L)
					{
						long position = stream.Position;
						stream.Position = num3;
						gclass4_0.class154_0.method_28().Position = num3;
						byte c;
						while ((c = binaryReader.ReadByte()) != 0)
						{
							gclass4_0.binaryWriter_0.Write((gclass4_0.random_0.Next(2) == 1) ? ((byte)char.ToUpper((char)c)) : ((byte)char.ToLower((char)c)));
						}
						stream.Position = position;
					}
				}
			}
		}
	}

	internal static DebugDirectoryEntry smethod_3(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[6];
		if (@class.method_0() == 0u || @class.method_2() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.smethod_135(class154_0, @class.method_0());
		if (num == -1L || !class5_0.imethod_0(num))
		{
			return null;
		}
		if (class5_0.imethod_0(num + (long)((ulong)@class.method_2())))
		{
			RecoveredRuntime.smethod_157(class5_0, num);
			return new DebugDirectoryEntry(class5_0);
		}
		return null;
	}

	internal static bool smethod_7(BoundsCheckedBinaryReader class5_0, uint uint_0, out Pe32OptionalHeader class162_0)
	{
		class162_0 = null;
		const uint fixedHeaderSize = 96;
		long start = class5_0.BaseStream.Position;
		if (uint_0 < fixedHeaderSize || start < 0 || start + uint_0 > class5_0.BaseStream.Length)
		{
			return false;
		}

		var header = new Pe32OptionalHeader();
		header.vmethod_0(class5_0.ReadUInt16());
		if (header.imethod_0() != 0x010B)
		{
			return false;
		}

		header.imethod_2(class5_0.ReadByte());
		header.imethod_4(class5_0.ReadByte());
		header.imethod_6(class5_0.ReadUInt32());
		header.imethod_8(class5_0.ReadUInt32());
		header.imethod_10(class5_0.ReadUInt32());
		header.imethod_12(class5_0.ReadUInt32());
		header.imethod_14(class5_0.ReadUInt32());
		header.imethod_16(class5_0.ReadUInt32());
		header.vmethod_1(class5_0.ReadUInt32());
		header.vmethod_2(class5_0.ReadUInt32());
		header.vmethod_3(class5_0.ReadUInt32());
		header.vmethod_4(class5_0.ReadUInt16());
		header.vmethod_5(class5_0.ReadUInt16());
		header.imethod_23(class5_0.ReadUInt16());
		header.imethod_25(class5_0.ReadUInt16());
		header.vmethod_6(class5_0.ReadUInt16());
		header.vmethod_7(class5_0.ReadUInt16());
		header.vmethod_8(class5_0.ReadUInt32());
		header.imethod_30(class5_0.ReadUInt32());
		header.vmethod_9(class5_0.ReadUInt32());
		header.imethod_33(class5_0.ReadUInt32());
		header.vmethod_10((Subsystem)class5_0.ReadUInt16());
		header.imethod_36((DllCharacteristics)class5_0.ReadUInt16());
		header.imethod_38(class5_0.ReadUInt32());
		header.imethod_40(class5_0.ReadUInt32());
		header.imethod_42(class5_0.ReadUInt32());
		header.imethod_44(class5_0.ReadUInt32());
		header.imethod_46(class5_0.ReadUInt32());
		header.imethod_48(class5_0.ReadUInt32());

		DataDirectory[] directories = header.imethod_49();
		uint availableDirectoryCount = (uint_0 - fixedHeaderSize) / 8U;
		int directoryCount = (int)Math.Min((uint)directories.Length, Math.Min(header.imethod_47(), availableDirectoryCount));
		for (int index = 0; index < directories.Length; index++)
		{
			directories[index] = index < directoryCount ? new DataDirectory(class5_0) : new DataDirectory();
		}

		class5_0.BaseStream.Position = start + uint_0;
		class162_0 = header;
		return true;
	}

	internal static byte[] smethod_8(long long_0, PeImage class154_0, long long_1)
	{
		long position = class154_0.method_28().Position;
		class154_0.method_28().Position = long_1;
		byte[] result;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			class154_0.method_28().smethod_5(memoryStream, (int)((long_0 == -1L) ? (class154_0.method_28().Length - long_1) : long_0));
			class154_0.method_28().Position = position;
			result = memoryStream.ToArray();
		}
		return result;
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

	internal static bool smethod_19(PeImage class154_0)
	{
		return class154_0.method_6().method_3().imethod_0() == 267;
	}

	internal static ImportDirectory smethod_24(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[1];
		if (@class.method_0() == 0u || @class.method_2() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.smethod_135(class154_0, @class.method_0());
		if (num == -1L || !class5_0.imethod_0(num))
		{
			return null;
		}
		if (class5_0.imethod_0(num + (long)((ulong)@class.method_2())))
		{
			RecoveredRuntime.smethod_157(class5_0, num);
			return new ImportDirectory(class5_0, class154_0);
		}
		return null;
	}

	internal static void smethod_41(PeSectionHeader gclass5_0, PeScrambler gclass4_0)
	{
		byte[] array;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
			{
				binaryWriter.Write(1396986706);
				binaryWriter.Write(gclass4_0.random_0.Next());
				binaryWriter.Write(gclass4_0.random_0.Next());
				binaryWriter.Write(gclass4_0.random_0.Next());
				binaryWriter.Write(gclass4_0.random_0.Next());
				binaryWriter.Write(gclass4_0.random_0.Next());
				binaryWriter.Write(Encoding.ASCII.GetBytes(RecoveredRuntime.smethod_428(gclass4_0) + EncodedStringTable.smethod_0(12219)));
				array = memoryStream.ToArray();
			}
		}
		gclass4_0.class154_0.method_28().Position = (long)((ulong)gclass5_0.method_8());
		gclass4_0.binaryWriter_0.Write(0);
		gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
		gclass4_0.binaryWriter_0.Write(0);
		gclass4_0.binaryWriter_0.Write(2);
		gclass4_0.binaryWriter_0.Write(array.Length);
		gclass4_0.binaryWriter_0.Write(gclass5_0.method_4() + 32u);
		gclass4_0.binaryWriter_0.Write(gclass5_0.method_8() + 32u);
		gclass4_0.binaryWriter_0.Write(0);
		gclass4_0.binaryWriter_0.Write(array);
		gclass4_0.class154_0.method_6().method_3().imethod_49()[6].method_1(gclass5_0.method_4());
		gclass4_0.class154_0.method_6().method_3().imethod_49()[6].method_3(28u);
		gclass5_0.method_19(gclass5_0.method_18() & ~SectionCharacteristics.flag_28);
	}

	internal static void smethod_43(ImportDirectory.Class150 class150_0)
	{
		class150_0.int_0 = -1;
		if (class150_0.ienumerator_0 != null)
		{
			class150_0.ienumerator_0.Dispose();
		}
	}

	internal static long smethod_64(PeImage class154_0, ulong ulong_0)
	{
		if (ulong_0 < class154_0.method_6().method_3().imethod_17())
		{
			return -1L;
		}
		return smethod_135(class154_0, (uint)(ulong_0 - class154_0.method_6().method_3().imethod_17()));
	}

	internal static IntPtr smethod_67(ManualMapInjector.Class172 class172_0, ManualMapInjector class89_0, string string_0)
	{
		ManualMapInjector.Enum44 enum44_ = ManualMapInjector.Enum44.flag_5 | ManualMapInjector.Enum44.flag_6 | ManualMapInjector.Enum44.flag_7;
		IntPtr intPtr = RecoveredRuntime.smethod_42(class89_0.method_19()).method_0(string_0);
		if (intPtr != IntPtr.Zero)
		{
			return intPtr;
		}
		DependencySearchFlags @enum = DependencySearchFlags.flag_2;
		if (RecoveredRuntime.smethod_379(class89_0.method_19()))
		{
			@enum |= DependencySearchFlags.flag_4;
		}
		string text = RecoveredRuntime.smethod_440(string_0, class172_0.method_4(), Path.GetDirectoryName(class172_0.method_4()), @enum, class89_0.method_0(), class172_0.method_10());
		if (text == null)
		{
			class89_0.method_35(new FileNotFoundException(EncodedStringTable.smethod_0(12476) + string_0));
			return IntPtr.Zero;
		}
		if ((class172_0.method_8() & ManualMapInjector.Enum44.flag_4) == (ManualMapInjector.Enum44)0)
		{
			IntPtr result;
			try
			{
				result = new LoadLibraryInjector(class89_0.method_19()).Inject(text);
			}
			catch (Exception innerException)
			{
				class89_0.method_35(new Exception(EncodedStringTable.smethod_0(12529) + text, innerException));
				result = IntPtr.Zero;
			}
			return result;
		}
		ManualMapInjector @class = new ManualMapInjector(class89_0.method_19());
		@class.method_20(class89_0.method_19());
		ManualMapInjector class2 = @class;
		IntPtr intPtr2 = class2.method_36(text, enum44_);
		if (intPtr2 == IntPtr.Zero)
		{
			class89_0.method_35(new Exception(EncodedStringTable.smethod_0(12529) + text, class2.method_34()));
		}
		return intPtr2;
	}

	internal static void smethod_71(PeImageWriter class165_0)
	{
		class165_0.stream_0.Position = (long)((ulong)class165_0.class154_0.method_4().method_0());
		class165_0.stream_0.Position += 4L;
		RecoveredRuntime.smethod_159(class165_0);
		RecoveredRuntime.smethod_163(class165_0);
	}

	internal static void smethod_76(Stream stream_0, PeImageWriter class165_0)
	{
		stream_0.SetLength(0L);
		class165_0.stream_0 = stream_0;
		class165_0.binaryWriter_0 = new BinaryWriter(stream_0);
		class165_0.class154_0.method_28().Position = 0L;
		class165_0.class154_0.method_28().smethod_6(stream_0);
		class165_0.class154_0.method_28().Position = 0L;
		RecoveredRuntime.smethod_333(class165_0);
		RecoveredRuntime.smethod_71(class165_0);
		class165_0.method_0();
	}

	internal static PeImage smethod_81(PeImageLayout enum39_0, string string_0)
	{
		return PeImageReader.smethod_5(new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite), string_0, bool_0: true, enum39_0);
	}

	internal static LoadConfigurationDirectory smethod_92(BoundsCheckedBinaryReader class5_0, PeImage class154_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[10];
		if (@class.method_0() == 0u || @class.method_2() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.smethod_135(class154_0, @class.method_0());
		if (num == -1L || !class5_0.imethod_0(num))
		{
			return null;
		}
		if (class5_0.imethod_0(num + (long)((ulong)@class.method_2())))
		{
			RecoveredRuntime.smethod_157(class5_0, num);
			return new LoadConfigurationDirectory(class5_0, class154_0);
		}
		return null;
	}

	internal static PeImage smethod_113(PeScrambler gclass4_0)
	{
		return gclass4_0.class154_0;
	}

	internal static bool smethod_128(ManualMapInjector class89_0, Exception exception_0)
	{
		class89_0.method_35(exception_0);
		return false;
	}

	internal static List<ExportedSymbol> smethod_131(ProcessModuleInfo gclass1_0)
	{
		if (gclass1_0.list_0 == null)
		{
			using (ProcessMemoryStream stream = new ProcessMemoryStream(gclass1_0.gclass2_0, gclass1_0.method_0(), ProcessMemoryAccess.const_0, (long)((ulong)gclass1_0.method_4())))
			{
				using (PeImage @class = PeExportReader.Read(stream, false, PeImageLayout.const_1))
				{
					if (@class.method_14() == null)
					{
						return new List<ExportedSymbol>();
					}
					gclass1_0.list_0 = new List<ExportedSymbol>(@class.method_14().list_1);
				}
			}
			if (!gclass1_0.gclass2_0.dictionary_0.ContainsKey(gclass1_0))
			{
				gclass1_0.gclass2_0.dictionary_0.Add(gclass1_0, gclass1_0.list_0);
			}
		}
		return gclass1_0.list_0;
	}

	internal static long smethod_135(PeImage class154_0, uint uint_0)
	{
		return class154_0.interface3_0.imethod_0(class154_0, uint_0);
	}

	internal static void smethod_159(PeImageWriter class165_0)
	{
		CoffHeader @class = class165_0.class154_0.method_6().method_1();
		class165_0.binaryWriter_0.Write((ushort)@class.method_0());
		@class.method_3((ushort)class165_0.class154_0.method_8().Count);
		class165_0.binaryWriter_0.Write(@class.method_2());
		class165_0.binaryWriter_0.Write(@class.method_4());
		class165_0.binaryWriter_0.Write(@class.method_6());
		class165_0.binaryWriter_0.Write(@class.method_8());
		class165_0.binaryWriter_0.Write(@class.method_10());
		class165_0.binaryWriter_0.Write((ushort)@class.method_12());
	}

	internal static TlsDirectory smethod_160(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[9];
		if (@class.method_0() == 0u || @class.method_2() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.smethod_135(class154_0, @class.method_0());
		if (num == -1L || !class5_0.imethod_0(num))
		{
			return null;
		}
		if (!class5_0.imethod_0(num + (long)((ulong)@class.method_2())))
		{
			return null;
		}
		RecoveredRuntime.smethod_157(class5_0, num);
		return new TlsDirectory(class5_0, class154_0);
	}

	internal static List<ImportedSymbol> smethod_162(BoundsCheckedBinaryReader class5_0, ImportDirectory class148_0, PeImage class154_0)
	{
		List<ImportedSymbol> list = new List<ImportedSymbol>();
		ulong ulong_;
		while ((ulong_ = (RecoveredRuntime.smethod_19(class154_0) ? ((ulong)class5_0.ReadUInt32()) : class5_0.ReadUInt64())) != 0UL)
		{
			ImportedSymbol @class = new ImportedSymbol();
			@class.method_1(ulong_);
			ImportedSymbol class2 = @class;
			class2.method_8((class2.method_0() & (RecoveredRuntime.smethod_19(class154_0) ? 2147483648UL : 9223372036854775808UL)) > 0UL);
			if (!class2.method_7())
			{
				long num = RecoveredRuntime.smethod_135(class154_0, (uint)class2.method_0());
				long position = class5_0.BaseStream.Position;
				if (num != -1L && class5_0.imethod_0(num))
				{
					RecoveredRuntime.smethod_157(class5_0, num);
					class2.method_6(class5_0.ReadUInt16());
					class2.method_5(RecoveredRuntime.smethod_404(class5_0));
				}
				RecoveredRuntime.smethod_157(class5_0, position);
			}
			else
			{
				class2.method_3((ushort)(class2.method_0() & 65535UL));
			}
			list.Add(class2);
		}
		return list;
	}

	internal static void smethod_163(PeImageWriter class165_0)
	{
		IPeOptionalHeader @interface = class165_0.class154_0.method_6().method_3();
		class165_0.binaryWriter_0.Write(@interface.imethod_0());
		if (RecoveredRuntime.smethod_19(class165_0.class154_0))
		{
			class165_0.binaryWriter_0.Write(@interface.imethod_1());
			class165_0.binaryWriter_0.Write(@interface.imethod_3());
			class165_0.binaryWriter_0.Write(@interface.imethod_5());
			class165_0.binaryWriter_0.Write(@interface.imethod_7());
			class165_0.binaryWriter_0.Write(@interface.imethod_9());
			class165_0.binaryWriter_0.Write(@interface.imethod_11());
			class165_0.binaryWriter_0.Write(@interface.imethod_13());
			class165_0.binaryWriter_0.Write(@interface.imethod_15());
			class165_0.binaryWriter_0.Write((uint)@interface.imethod_17());
			class165_0.binaryWriter_0.Write(@interface.imethod_18());
			class165_0.binaryWriter_0.Write(@interface.imethod_19());
			class165_0.binaryWriter_0.Write(@interface.imethod_20());
			class165_0.binaryWriter_0.Write(@interface.imethod_21());
			class165_0.binaryWriter_0.Write(@interface.imethod_22());
			class165_0.binaryWriter_0.Write(@interface.imethod_24());
			class165_0.binaryWriter_0.Write(@interface.imethod_26());
			class165_0.binaryWriter_0.Write(@interface.imethod_27());
			class165_0.binaryWriter_0.Write(@interface.imethod_28());
			class165_0.binaryWriter_0.Write(@interface.imethod_29());
			class165_0.binaryWriter_0.Write(@interface.imethod_31());
			class165_0.binaryWriter_0.Write(@interface.imethod_32());
			class165_0.binaryWriter_0.Write((ushort)@interface.imethod_34());
			class165_0.binaryWriter_0.Write((ushort)@interface.imethod_35());
			class165_0.binaryWriter_0.Write((uint)@interface.imethod_37());
			class165_0.binaryWriter_0.Write((uint)@interface.imethod_39());
			class165_0.binaryWriter_0.Write((uint)@interface.imethod_41());
			class165_0.binaryWriter_0.Write((uint)@interface.imethod_43());
			class165_0.binaryWriter_0.Write(@interface.imethod_45());
			class165_0.binaryWriter_0.Write(@interface.imethod_47());
		}
		else
		{
			class165_0.binaryWriter_0.Write(@interface.imethod_1());
			class165_0.binaryWriter_0.Write(@interface.imethod_3());
			class165_0.binaryWriter_0.Write(@interface.imethod_5());
			class165_0.binaryWriter_0.Write(@interface.imethod_7());
			class165_0.binaryWriter_0.Write(@interface.imethod_9());
			class165_0.binaryWriter_0.Write(@interface.imethod_11());
			class165_0.binaryWriter_0.Write(@interface.imethod_13());
			class165_0.binaryWriter_0.Write(@interface.imethod_17());
			class165_0.binaryWriter_0.Write(@interface.imethod_18());
			class165_0.binaryWriter_0.Write(@interface.imethod_19());
			class165_0.binaryWriter_0.Write(@interface.imethod_20());
			class165_0.binaryWriter_0.Write(@interface.imethod_21());
			class165_0.binaryWriter_0.Write(@interface.imethod_22());
			class165_0.binaryWriter_0.Write(@interface.imethod_24());
			class165_0.binaryWriter_0.Write(@interface.imethod_26());
			class165_0.binaryWriter_0.Write(@interface.imethod_27());
			class165_0.binaryWriter_0.Write(@interface.imethod_28());
			class165_0.binaryWriter_0.Write(@interface.imethod_29());
			class165_0.binaryWriter_0.Write(@interface.imethod_31());
			class165_0.binaryWriter_0.Write(@interface.imethod_32());
			class165_0.binaryWriter_0.Write((ushort)@interface.imethod_34());
			class165_0.binaryWriter_0.Write((ushort)@interface.imethod_35());
			class165_0.binaryWriter_0.Write(@interface.imethod_37());
			class165_0.binaryWriter_0.Write(@interface.imethod_39());
			class165_0.binaryWriter_0.Write(@interface.imethod_41());
			class165_0.binaryWriter_0.Write(@interface.imethod_43());
			class165_0.binaryWriter_0.Write(@interface.imethod_45());
			class165_0.binaryWriter_0.Write(@interface.imethod_47());
		}
		foreach (DataDirectory @class in @interface.imethod_49())
		{
			class165_0.binaryWriter_0.Write(@class.method_0());
			class165_0.binaryWriter_0.Write(@class.method_2());
		}
	}

	internal static void smethod_172(ModuleEntry class16_0)
	{
		if (!File.Exists(class16_0.Path))
		{
			return;
		}
		PeImage @class = null;
		try
		{
			using (FileStream fileStream = new FileStream(class16_0.Path, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				@class = PeExportReader.Read(fileStream, class16_0.Path, false, PeImageLayout.const_0);
				if (@class == null)
				{
					return;
				}
			}
		}
		catch
		{
			return;
		}
		finally
		{
			if (@class != null)
			{
				((IDisposable)@class).Dispose();
			}
		}
		ModuleOptionsForm form = new ModuleOptionsForm();
		form.method_1(class16_0);
		form.method_3(@class);
		form.ShowDialog();
	}

	internal static Stream smethod_174(PeImage class154_0)
	{
		Stream obj = class154_0.method_28();
		Stream result;
		lock (obj)
		{
			if (class154_0.method_28() is FileStream)
			{
				result = new FileStream(class154_0.method_28().smethod_4(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			}
			else
			{
				class154_0.method_28().Position = 0L;
				MemoryStream memoryStream = new MemoryStream();
				class154_0.method_28().smethod_6(memoryStream);
				memoryStream.Position = 0L;
				result = memoryStream;
			}
		}
		return result;
	}

	internal static void smethod_203(string string_0, string string_1, string string_2, PeImage class154_0, string string_3, MainForm mainForm, string string_4, bool bool_0, string string_5, bool bool_1, string string_6)
	{
		if (bool_0)
		{
			if (!PlatformInfo.bool_1)
			{
				RecoveredRuntime.smethod_177(string_2, mainForm, class154_0.method_2());
				return;
			}
			if (PlatformInfo.bool_1)
			{
				string string_7 = RecoveredRuntime.smethod_19(class154_0) ? string_4 : string_5;
				RecoveredRuntime.smethod_405(class154_0.method_2(), mainForm, string_1, string_7, string_2);
				return;
			}
		}
		else
		{
			if (!RecoveredRuntime.smethod_337(mainForm, class154_0.method_2(), string_2, string_3, bool_1, string.Format(EncodedStringTable.smethod_0(14117), string_6)))
			{
				return;
			}
			DependencyInstallerForm form = new DependencyInstallerForm();
			RecoveredRuntime.smethod_29(form, string_0, string_1, EncodedStringTable.smethod_0(14162) + (RecoveredRuntime.smethod_19(class154_0) ? EncodedStringTable.smethod_0(14180) : EncodedStringTable.smethod_0(14175)) + EncodedStringTable.smethod_0(93));
			form.ShowDialog();
		}
	}

	internal static ManualMapInjector.Enum44 smethod_206(ManualMapInjector class89_0)
	{
		ManualMapInjector.Enum44 @enum = (ManualMapInjector.Enum44)0;
		if (class89_0.method_24())
		{
			@enum |= ManualMapInjector.Enum44.flag_1;
		}
		if (class89_0.method_26())
		{
			@enum |= ManualMapInjector.Enum44.flag_2;
		}
		if (class89_0.method_28())
		{
			@enum |= ManualMapInjector.Enum44.flag_3;
		}
		if (class89_0.method_30())
		{
			@enum |= ManualMapInjector.Enum44.flag_4;
		}
		if (class89_0.method_32())
		{
			@enum |= ManualMapInjector.Enum44.flag_0;
		}
		return @enum;
	}

	internal static PeImage smethod_215(ProcessModuleInfo gclass1_0)
	{
		PeImage result;
		using (ProcessMemoryStream stream = new ProcessMemoryStream(gclass1_0.gclass2_0, gclass1_0.method_0(), ProcessMemoryAccess.const_0, (long)((ulong)gclass1_0.method_4())))
		{
			result = PeImageReader.smethod_4(stream, false, PeImageLayout.const_1);
		}
		return result;
	}

	private static bool ModuleMatchesProcessArchitecture(RemoteProcess process, string modulePath, out string mismatchMessage)
	{
		mismatchMessage = null;
		bool moduleIs32Bit;
		using (FileStream stream = new FileStream(modulePath, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (PeImage module = PeImportReader.smethod_13(stream, modulePath, bool_0: false, PeImageLayout.const_0))
		{
			moduleIs32Bit = smethod_19(module);
		}

		bool processIs32Bit = smethod_427(process);
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
			injector.method_18(options.Advanced.HideFromDebugger);
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
			injector.method_18(advanced.HideFromDebugger);
			injector.method_25(advanced.DisableExceptionSupport);
			injector.method_31(advanced.ManualResolveImports);
			injector.method_27(options.ErasePeHeaders);
			injector.method_33(advanced.DisableSehValidation);

			IntPtr moduleBase = injector.Inject(modulePath);
			if (injector.method_34() != null)
			{
				throw injector.method_34();
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
					moduleEditor.method_19(moduleBase);
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
				smethod_327(new RemoteModuleUnlinker(process), moduleBase);
			}
			catch (Exception exception)
			{
				reportError?.Invoke(UiText.Format("Message.HideModuleFailed", Path.GetFileName(sourceModulePath)), exception);
			}
		}
	}

	internal static void smethod_217(BoundsCheckedBinaryReader class5_0, int int_0)
	{
		class5_0.BaseStream.Position += int_0;
	}

	internal static BaseRelocationDirectory smethod_230(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[5];
		if (@class.method_0() == 0u || @class.method_2() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.smethod_135(class154_0, @class.method_0());
		if (num == -1L || !class5_0.imethod_0(num))
		{
			return null;
		}
		if (num + (long)((ulong)@class.method_2()) > class5_0.BaseStream.Length)
		{
			return null;
		}
		RecoveredRuntime.smethod_157(class5_0, num);
		return new BaseRelocationDirectory(class5_0, class154_0);
	}

	internal static void smethod_233(ManualMapOptionsForm form2_0)
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
		form2_0.groupBox_0.Name = EncodedStringTable.smethod_0(14653);
		form2_0.groupBox_0.Size = new Size(199, 93);
		form2_0.groupBox_0.TabIndex = 1;
		form2_0.groupBox_0.TabStop = false;
		form2_0.groupBox_0.Text = EncodedStringTable.smethod_0(14678);
		form2_0.checkBox_3.AutoSize = true;
		form2_0.checkBox_3.Location = new Point(10, 67);
		form2_0.checkBox_3.Name = EncodedStringTable.smethod_0(14703);
		form2_0.checkBox_3.Size = new Size(184, 17);
		form2_0.checkBox_3.TabIndex = 2;
		form2_0.checkBox_3.Text = EncodedStringTable.smethod_0(14748);
		form2_0.checkBox_3.UseVisualStyleBackColor = true;
		form2_0.checkBox_3.CheckedChanged += form2_0.method_3;
		form2_0.checkBox_0.AutoSize = true;
		form2_0.checkBox_0.Location = new Point(10, 44);
		form2_0.checkBox_0.Name = EncodedStringTable.smethod_0(14789);
		form2_0.checkBox_0.Size = new Size(161, 17);
		form2_0.checkBox_0.TabIndex = 1;
		form2_0.checkBox_0.Text = EncodedStringTable.smethod_0(14826);
		form2_0.checkBox_0.UseVisualStyleBackColor = true;
		form2_0.checkBox_0.CheckedChanged += form2_0.method_2;
		form2_0.checkBox_1.AutoSize = true;
		form2_0.checkBox_1.Location = new Point(10, 21);
		form2_0.checkBox_1.Name = EncodedStringTable.smethod_0(14863);
		form2_0.checkBox_1.Size = new Size(140, 17);
		form2_0.checkBox_1.TabIndex = 0;
		form2_0.checkBox_1.Text = EncodedStringTable.smethod_0(14896);
		form2_0.checkBox_1.UseVisualStyleBackColor = true;
		form2_0.checkBox_1.CheckedChanged += form2_0.method_1;
		form2_0.groupBox_1.Controls.Add(form2_0.checkBox_2);
		form2_0.groupBox_1.Location = new Point(12, 12);
		form2_0.groupBox_1.Name = EncodedStringTable.smethod_0(14925);
		form2_0.groupBox_1.Size = new Size(199, 47);
		form2_0.groupBox_1.TabIndex = 2;
		form2_0.groupBox_1.TabStop = false;
		form2_0.groupBox_1.Text = EncodedStringTable.smethod_0(14946);
		form2_0.checkBox_2.AutoSize = true;
		form2_0.checkBox_2.Location = new Point(10, 21);
		form2_0.checkBox_2.Name = EncodedStringTable.smethod_0(14959);
		form2_0.checkBox_2.Size = new Size(173, 17);
		form2_0.checkBox_2.TabIndex = 1;
		form2_0.checkBox_2.Text = EncodedStringTable.smethod_0(14992);
		form2_0.checkBox_2.UseVisualStyleBackColor = true;
		form2_0.checkBox_2.CheckedChanged += form2_0.method_0;
		form2_0.AutoScaleDimensions = new SizeF(96f, 96f);
		form2_0.AutoScaleMode = AutoScaleMode.Dpi;
		form2_0.ClientSize = new Size(223, 170);
		form2_0.Controls.Add(form2_0.groupBox_1);
		form2_0.Controls.Add(form2_0.groupBox_0);
		form2_0.Font = new Font(EncodedStringTable.smethod_0(11956), 8.25f);
		form2_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		form2_0.Icon = (Icon)componentResourceManager.GetObject(EncodedStringTable.smethod_0(13062));
		form2_0.Name = EncodedStringTable.smethod_0(15029);
		form2_0.StartPosition = FormStartPosition.CenterParent;
		form2_0.Text = EncodedStringTable.smethod_0(15058);
		form2_0.groupBox_0.ResumeLayout(false);
		form2_0.groupBox_0.PerformLayout();
		form2_0.groupBox_1.ResumeLayout(false);
		form2_0.groupBox_1.PerformLayout();
		form2_0.ResumeLayout(false);
	}

	internal static void smethod_234(AdvancedScrambleSettingsForm gform1_0)
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
		gform1_0.groupBox_0.Name = EncodedStringTable.smethod_0(15083);
		gform1_0.groupBox_0.Size = new Size(187, 68);
		gform1_0.groupBox_0.TabIndex = 0;
		gform1_0.groupBox_0.TabStop = false;
		gform1_0.groupBox_0.Text = EncodedStringTable.smethod_0(15104);
		gform1_0.checkBox_1.AutoSize = true;
		gform1_0.checkBox_1.Location = new Point(9, 44);
		gform1_0.checkBox_1.Name = EncodedStringTable.smethod_0(15125);
		gform1_0.checkBox_1.Size = new Size(132, 17);
		gform1_0.checkBox_1.TabIndex = 1;
		gform1_0.checkBox_1.Text = EncodedStringTable.smethod_0(15162);
		gform1_0.checkBox_1.UseVisualStyleBackColor = true;
		gform1_0.checkBox_0.AutoSize = true;
		gform1_0.checkBox_0.Location = new Point(9, 21);
		gform1_0.checkBox_0.Name = EncodedStringTable.smethod_0(15191);
		gform1_0.checkBox_0.Size = new Size(142, 17);
		gform1_0.checkBox_0.TabIndex = 0;
		gform1_0.checkBox_0.Text = EncodedStringTable.smethod_0(15224);
		gform1_0.checkBox_0.UseVisualStyleBackColor = true;
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_11);
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_12);
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_6);
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_5);
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_4);
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_2);
		gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_3);
		gform1_0.groupBox_1.Location = new Point(12, 86);
		gform1_0.groupBox_1.Name = EncodedStringTable.smethod_0(15257);
		gform1_0.groupBox_1.Size = new Size(187, 186);
		gform1_0.groupBox_1.TabIndex = 1;
		gform1_0.groupBox_1.TabStop = false;
		gform1_0.groupBox_1.Text = EncodedStringTable.smethod_0(15282);
		gform1_0.checkBox_6.AutoSize = true;
		gform1_0.checkBox_6.Location = new Point(9, 159);
		gform1_0.checkBox_6.Name = EncodedStringTable.smethod_0(15303);
		gform1_0.checkBox_6.Size = new Size(141, 17);
		gform1_0.checkBox_6.TabIndex = 4;
		gform1_0.checkBox_6.Text = EncodedStringTable.smethod_0(15336);
		gform1_0.checkBox_6.UseVisualStyleBackColor = true;
		gform1_0.checkBox_5.AutoSize = true;
		gform1_0.checkBox_5.Location = new Point(9, 90);
		gform1_0.checkBox_5.Name = EncodedStringTable.smethod_0(15365);
		gform1_0.checkBox_5.Size = new Size(112, 17);
		gform1_0.checkBox_5.TabIndex = 3;
		gform1_0.checkBox_5.Text = EncodedStringTable.smethod_0(15398);
		gform1_0.checkBox_5.UseVisualStyleBackColor = true;
		gform1_0.checkBox_4.AutoSize = true;
		gform1_0.checkBox_4.Location = new Point(9, 67);
		gform1_0.checkBox_4.Name = EncodedStringTable.smethod_0(15419);
		gform1_0.checkBox_4.Size = new Size(139, 17);
		gform1_0.checkBox_4.TabIndex = 2;
		gform1_0.checkBox_4.Text = EncodedStringTable.smethod_0(15444);
		gform1_0.checkBox_4.UseVisualStyleBackColor = true;
		gform1_0.checkBox_2.AutoSize = true;
		gform1_0.checkBox_2.Location = new Point(9, 44);
		gform1_0.checkBox_2.Name = EncodedStringTable.smethod_0(15473);
		gform1_0.checkBox_2.Size = new Size(116, 17);
		gform1_0.checkBox_2.TabIndex = 1;
		gform1_0.checkBox_2.Text = EncodedStringTable.smethod_0(15506);
		gform1_0.checkBox_2.UseVisualStyleBackColor = true;
		gform1_0.checkBox_3.AutoSize = true;
		gform1_0.checkBox_3.Location = new Point(9, 21);
		gform1_0.checkBox_3.Name = EncodedStringTable.smethod_0(15531);
		gform1_0.checkBox_3.Size = new Size(128, 17);
		gform1_0.checkBox_3.TabIndex = 0;
		gform1_0.checkBox_3.Text = EncodedStringTable.smethod_0(15564);
		gform1_0.checkBox_3.UseVisualStyleBackColor = true;
		gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_10);
		gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_9);
		gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_7);
		gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_8);
		gform1_0.groupBox_2.Location = new Point(12, 278);
		gform1_0.groupBox_2.Name = EncodedStringTable.smethod_0(15593);
		gform1_0.groupBox_2.Size = new Size(187, 120);
		gform1_0.groupBox_2.TabIndex = 2;
		gform1_0.groupBox_2.TabStop = false;
		gform1_0.groupBox_2.Text = EncodedStringTable.smethod_0(15626);
		gform1_0.checkBox_10.AutoSize = true;
		gform1_0.checkBox_10.Location = new Point(9, 44);
		gform1_0.checkBox_10.Name = EncodedStringTable.smethod_0(15651);
		gform1_0.checkBox_10.Size = new Size(129, 17);
		gform1_0.checkBox_10.TabIndex = 6;
		gform1_0.checkBox_10.Text = EncodedStringTable.smethod_0(15684);
		gform1_0.checkBox_10.UseVisualStyleBackColor = true;
		gform1_0.checkBox_9.AutoSize = true;
		gform1_0.checkBox_9.Location = new Point(9, 90);
		gform1_0.checkBox_9.Name = EncodedStringTable.smethod_0(15709);
		gform1_0.checkBox_9.Size = new Size(169, 17);
		gform1_0.checkBox_9.TabIndex = 5;
		gform1_0.checkBox_9.Text = EncodedStringTable.smethod_0(15754);
		gform1_0.checkBox_9.UseVisualStyleBackColor = true;
		gform1_0.checkBox_7.AutoSize = true;
		gform1_0.checkBox_7.Location = new Point(9, 67);
		gform1_0.checkBox_7.Name = EncodedStringTable.smethod_0(15791);
		gform1_0.checkBox_7.Size = new Size(138, 17);
		gform1_0.checkBox_7.TabIndex = 4;
		gform1_0.checkBox_7.Text = EncodedStringTable.smethod_0(15828);
		gform1_0.checkBox_7.UseVisualStyleBackColor = true;
		gform1_0.checkBox_8.AutoSize = true;
		gform1_0.checkBox_8.Location = new Point(9, 21);
		gform1_0.checkBox_8.Name = EncodedStringTable.smethod_0(15857);
		gform1_0.checkBox_8.Size = new Size(128, 17);
		gform1_0.checkBox_8.TabIndex = 3;
		gform1_0.checkBox_8.Text = EncodedStringTable.smethod_0(15894);
		gform1_0.checkBox_8.UseVisualStyleBackColor = true;
		gform1_0.checkBox_12.AutoSize = true;
		gform1_0.checkBox_12.Location = new Point(9, 113);
		gform1_0.checkBox_12.Name = EncodedStringTable.smethod_0(15923);
		gform1_0.checkBox_12.Size = new Size(133, 17);
		gform1_0.checkBox_12.TabIndex = 5;
		gform1_0.checkBox_12.Text = EncodedStringTable.smethod_0(15960);
		gform1_0.checkBox_12.UseVisualStyleBackColor = true;
		gform1_0.checkBox_11.AutoSize = true;
		gform1_0.checkBox_11.Location = new Point(9, 136);
		gform1_0.checkBox_11.Name = EncodedStringTable.smethod_0(15989);
		gform1_0.checkBox_11.Size = new Size(165, 17);
		gform1_0.checkBox_11.TabIndex = 6;
		gform1_0.checkBox_11.Text = EncodedStringTable.smethod_0(16030);
		gform1_0.checkBox_11.UseVisualStyleBackColor = true;
		gform1_0.AutoScaleDimensions = new SizeF(96f, 96f);
		gform1_0.AutoScaleMode = AutoScaleMode.Dpi;
		gform1_0.ClientSize = new Size(213, 411);
		gform1_0.Controls.Add(gform1_0.groupBox_2);
		gform1_0.Controls.Add(gform1_0.groupBox_1);
		gform1_0.Controls.Add(gform1_0.groupBox_0);
		gform1_0.Font = new Font(EncodedStringTable.smethod_0(11956), 8.25f);
		gform1_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		gform1_0.Icon = (Icon)componentResourceManager.GetObject(EncodedStringTable.smethod_0(13062));
		gform1_0.Name = EncodedStringTable.smethod_0(16071);
		gform1_0.StartPosition = FormStartPosition.CenterParent;
		gform1_0.Text = EncodedStringTable.smethod_0(16100);
		gform1_0.groupBox_0.ResumeLayout(false);
		gform1_0.groupBox_0.PerformLayout();
		gform1_0.groupBox_1.ResumeLayout(false);
		gform1_0.groupBox_1.PerformLayout();
		gform1_0.groupBox_2.ResumeLayout(false);
		gform1_0.groupBox_2.PerformLayout();
		gform1_0.ResumeLayout(false);
	}

	internal static void smethod_240(PeImage class154_0, string string_0, MainForm mainForm)
	{
		if (!string_0.StartsWith(EncodedStringTable.smethod_0(16137), StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		string text = RecoveredRuntime.smethod_353(class154_0, string_0);
		bool flag = false;
		if (!string.IsNullOrEmpty(text))
		{
			using (FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				try
				{
					PeImage @class = PeImportReader.smethod_13(fileStream, text, false, PeImageLayout.const_0);
					if (@class != null && RecoveredRuntime.smethod_19(@class) != RecoveredRuntime.smethod_19(class154_0))
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
		bool flag2 = string_0.EndsWith(EncodedStringTable.smethod_0(16146), StringComparison.OrdinalIgnoreCase);
		string string_;
		if (!PlatformInfo.bool_0 || !RecoveredRuntime.smethod_19(class154_0))
		{
			string_ = PlatformInfo.string_1;
		}
		else
		{
			string_ = PlatformInfo.string_2;
		}
		if (!RecoveredRuntime.smethod_434(string_0, EncodedStringTable.smethod_0(16155)))
		{
			if (RecoveredRuntime.smethod_434(string_0, EncodedStringTable.smethod_0(16671)))
			{
				string string_2 = EncodedStringTable.smethod_0(16676);
				string string_3 = EncodedStringTable.smethod_0(16685);
				string string_4 = EncodedStringTable.smethod_0(16843);
				string string_5 = EncodedStringTable.smethod_0(17001);
				RecoveredRuntime.smethod_203(string_5, string_, string_0, class154_0, text, mainForm, string_3, flag2, string_4, flag, string_2);
				return;
			}
			if (RecoveredRuntime.smethod_434(string_0, EncodedStringTable.smethod_0(17078)))
			{
				string string_2 = EncodedStringTable.smethod_0(17083);
				string string_3 = EncodedStringTable.smethod_0(17092);
				string string_4 = EncodedStringTable.smethod_0(17250);
				string string_5 = EncodedStringTable.smethod_0(17408);
				RecoveredRuntime.smethod_203(string_5, string_, string_0, class154_0, text, mainForm, string_3, flag2, string_4, flag, string_2);
				return;
			}
			if (RecoveredRuntime.smethod_434(string_0, EncodedStringTable.smethod_0(17485)))
			{
				string string_2 = EncodedStringTable.smethod_0(17490);
				string string_3 = EncodedStringTable.smethod_0(17499);
				string string_4 = EncodedStringTable.smethod_0(17657);
				string string_5 = EncodedStringTable.smethod_0(17815);
				RecoveredRuntime.smethod_203(string_5, string_, string_0, class154_0, text, mainForm, string_3, flag2, string_4, flag2, string_2);
			}
			return;
		}
		else
		{
			if (flag2)
			{
				string string_6 = RecoveredRuntime.smethod_19(class154_0) ? EncodedStringTable.smethod_0(16318) : EncodedStringTable.smethod_0(16160);
				RecoveredRuntime.smethod_405(class154_0.method_2(), mainForm, string_, string_6, string_0);
				return;
			}
			if (!RecoveredRuntime.smethod_337(mainForm, class154_0.method_2(), string_0, text, flag, EncodedStringTable.smethod_0(16476)))
			{
				return;
			}
			if (!RecoveredRuntime.smethod_19(class154_0))
			{
				Process.Start(EncodedStringTable.smethod_0(16594));
				return;
			}
			Process.Start(EncodedStringTable.smethod_0(16521));
			return;
		}
	}

	internal static void smethod_242(ManualMapInjector class89_0, ManualMapInjector.Class172 class172_0)
	{
		byte[] array = ManualMapInjector.smethod_7(class172_0.method_0());
		if (array == null)
		{
			return;
		}
		string tempFileName = Path.GetTempFileName();
		File.WriteAllBytes(tempFileName, array);
		NativeTypes.Struct50 @struct = default(NativeTypes.Struct50);
		@struct.int_0 = typeof(NativeTypes.Struct50).smethod_7();
		@struct.string_0 = tempFileName;
		NativeTypes.Struct50 struct2 = @struct;
		class172_0.method_11(RecoveredRuntime.CreateActCtx(ref struct2));
		File.Delete(tempFileName);
	}

	internal static void smethod_258(SettingsForm gform2_0)
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
		RecoveredRuntime.smethod_421(gform2_0);
	}

	internal static void smethod_259(ManualMapInjector class89_0)
	{
		class89_0.method_31(bool_7: false);
		class89_0.method_29(bool_7: false);
		class89_0.method_27(bool_7: false);
		class89_0.method_25(bool_7: false);
		class89_0.method_18(bool_2: false);
	}

	internal static void smethod_261(PeImage class154_0, MainForm mainForm)
	{
		if (class154_0.method_10() == null)
		{
			return;
		}
		using (IEnumerator<KeyValuePair<string, List<string>>> enumerator = class154_0.method_10().gclass0_0.imethod_8())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, List<string>> keyValuePair = enumerator.Current;
				string key = keyValuePair.Key;
				if (!string.IsNullOrEmpty(key))
				{
					RecoveredRuntime.smethod_240(class154_0, key, mainForm);
					RecoveredRuntime.smethod_351(class154_0, key, mainForm);
				}
			}
		}
	}

	internal static Stream smethod_264(PeImage class154_0, long long_0, int int_0)
	{
		Stream obj = class154_0.method_28();
		Stream result;
		lock (obj)
		{
			long position = class154_0.method_28().Position;
			class154_0.method_28().Position = long_0;
			MemoryStream memoryStream = new MemoryStream();
			class154_0.method_28().smethod_5(memoryStream, int_0);
			class154_0.method_28().Position = position;
			memoryStream.Position = 0L;
			result = memoryStream;
		}
		return result;
	}

	internal static void smethod_266(ProcessModuleCollection class69_0, PeImage class154_0, IntPtr intptr_0, bool bool_0)
	{
		ProcessModuleInfo gclass = new ProcessModuleInfo(class69_0.gclass2_0, null, intptr_0, bool_0, true);
		string string_ = class154_0.method_0();
		string fileName = Path.GetFileName(class154_0.method_0());
		IntPtr intptr_ = intptr_0.smethod_9((long)((ulong)class154_0.method_6().method_3().imethod_11()));
		uint uint_ = class154_0.method_6().method_3().imethod_29();
		RecoveredRuntime.smethod_313(string_, fileName, intptr_, gclass, uint_);
		class69_0.gclass2_0.list_1.Add(gclass);
	}

	internal static bool smethod_271(ref PeHeaders class161_0, [Out] BoundsCheckedBinaryReader class5_0)
	{
		class161_0 = null;
		if (class5_0.ReadUInt32() != 0x00004550U)
		{
			return false;
		}

		var headers = new PeHeaders();
		headers.method_0(0x00004550U);
		headers.method_2(new CoffHeader(class5_0));

		if (headers.method_1().method_10() < sizeof(ushort))
		{
			return false;
		}

		long optionalHeaderStart = class5_0.BaseStream.Position;
		ushort magic = class5_0.ReadUInt16();
		class5_0.BaseStream.Position = optionalHeaderStart;

		if (magic == 0x010B)
		{
			Pe32OptionalHeader optionalHeader;
			if (!smethod_7(class5_0, headers.method_1().method_10(), out optionalHeader))
			{
				return false;
			}

			headers.method_4(optionalHeader);
		}
		else if (magic == 0x020B)
		{
			Pe64OptionalHeader optionalHeader;
			if (!smethod_398(class5_0, headers.method_1().method_10(), out optionalHeader))
			{
				return false;
			}

			headers.method_4(optionalHeader);
		}
		else
		{
			return false;
		}

		class161_0 = headers;
		return true;
	}
}
