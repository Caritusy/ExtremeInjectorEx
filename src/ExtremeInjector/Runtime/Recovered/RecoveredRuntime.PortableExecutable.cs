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
		long num3 = default(long);
		long position = default(long);
		long num5 = default(long);
		byte c = default(byte);
		uint uint_ = default(uint);
		uint num6 = default(uint);
		while (true)
		{
			int num = 540401048;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7C66F37F)) % 5)
				{
				case 3u:
					num = ((num3 != -1L) ? 419420136 : 59497708) ^ (int)(num2 * 181328586);
					continue;
				case 2u:
					num3 = smethod_135(gclass4_0.class154_0, @class.method_0());
					num = ((int)num2 * -1464551743) ^ 0x4ED6733D;
					continue;
				case 0u:
					break;
				case 1u:
					return;
				default:
				{
					Stream stream = smethod_174(gclass4_0.class154_0);
					try
					{
						BinaryReader binaryReader = new BinaryReader(stream);
						try
						{
							stream.Position = num3;
							while (true)
							{
								int num4 = 870570562;
								while (true)
								{
									switch ((num2 = (uint)(num4 ^ 0x7C66F37F)) % 11)
									{
									case 10u:
										num4 = (int)((num2 * 1525613292) ^ 0xD7FD7);
										continue;
									case 9u:
										position = stream.Position;
										stream.Position = num5;
										num4 = (int)((num2 * 753593317) ^ 0xABDF745);
										continue;
									case 8u:
										gclass4_0.binaryWriter_0.Write((gclass4_0.random_0.Next(2) == 1) ? ((byte)char.ToUpper((char)c)) : ((byte)char.ToLower((char)c)));
										num4 = 1701885455;
										continue;
									case 5u:
									{
										uint num7 = binaryReader.ReadUInt32();
										stream.Position += 8L;
										uint_ = binaryReader.ReadUInt32();
										num6 = binaryReader.ReadUInt32();
										num4 = ((num7 != 0) ? 1718117796 : 226559387);
										continue;
									}
									case 4u:
										num4 = (((c = binaryReader.ReadByte()) == 0) ? 2062131862 : 1480653048);
										continue;
									case 3u:
										gclass4_0.class154_0.method_28().Position = num5;
										num4 = (int)(num2 * 1401116587) ^ -1741766045;
										continue;
									case 2u:
										num4 = ((num6 == 0) ? 1851301904 : 437072204) ^ ((int)num2 * -799618038);
										continue;
									case 1u:
										num5 = smethod_135(gclass4_0.class154_0, uint_);
										num4 = ((num5 == -1L) ? 870570562 : 511459231);
										continue;
									default:
										stream.Position = position;
										goto case 5u;
									case 6u:
										break;
									case 7u:
										return;
									}
									break;
								}
							}
						}
						finally
						{
							if (binaryReader != null)
							{
								while (true)
								{
									IL_029b:
									int num8 = 1873412360;
									while (true)
									{
										switch ((num2 = (uint)(num8 ^ 0x7C66F37F)) % 3)
										{
										case 2u:
											goto IL_0269;
										default:
											goto end_IL_027d;
										case 0u:
											break;
										case 1u:
											goto end_IL_027d;
										}
										goto IL_029b;
										IL_0269:
										((IDisposable)binaryReader).Dispose();
										num8 = (int)(num2 * 216807074) ^ -883956626;
										continue;
										end_IL_027d:
										break;
									}
									break;
								}
							}
						}
					}
					finally
					{
						if (stream != null)
						{
							while (true)
							{
								IL_02da:
								int num9 = 1316564494;
								while (true)
								{
									switch ((num2 = (uint)(num9 ^ 0x7C66F37F)) % 3)
									{
									case 1u:
										goto IL_02a8;
									default:
										goto end_IL_02bc;
									case 2u:
										break;
									case 0u:
										goto end_IL_02bc;
									}
									goto IL_02da;
									IL_02a8:
									((IDisposable)stream).Dispose();
									num9 = ((int)num2 * -1486022512) ^ 0x5D1E42AD;
									continue;
									end_IL_02bc:
									break;
								}
								break;
							}
						}
					}
				}
				}
				break;
			}
		}
	}

	internal static DebugDirectoryEntry smethod_3(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[6];
		long num3 = default(long);
		while (true)
		{
			int num = 1839152769;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x55FDDBAE)) % 11)
				{
				case 10u:
					num = ((!class5_0.imethod_0(num3 + @class.method_2())) ? 484342345 : 22573945);
					continue;
				case 6u:
					smethod_157(class5_0, num3);
					num = 101535526;
					continue;
				case 5u:
					num = ((@class.method_2() == 0) ? (-381777920) : (-129109227)) ^ ((int)num2 * -1814964685);
					continue;
				case 4u:
					num = ((@class.method_0() == 0) ? (-877033036) : (-1725844192)) ^ ((int)num2 * -2102095317);
					continue;
				case 3u:
					num = (class5_0.imethod_0(num3) ? 313754748 : 1660788475) ^ (int)(num2 * 1967925550);
					continue;
				case 1u:
					num3 = smethod_135(class154_0, @class.method_0());
					num = ((num3 != -1L) ? 909075534 : 1709491387);
					continue;
				case 0u:
					break;
				case 2u:
					return null;
				case 7u:
					return null;
				case 8u:
					return null;
				default:
					return new DebugDirectoryEntry(class5_0);
				}
				break;
			}
		}
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
		MemoryStream memoryStream = new MemoryStream();
		byte[] result = default(byte[]);
		try
		{
			class154_0.method_28().smethod_5(memoryStream, (int)((long_0 == -1L) ? (class154_0.method_28().Length - long_1) : long_0));
			while (true)
			{
				IL_0099:
				int num = 53687269;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x4376A52C)) % 4)
					{
					case 2u:
						result = memoryStream.ToArray();
						num = ((int)num2 * -1607740926) ^ 0x162E187;
						continue;
					case 1u:
						class154_0.method_28().Position = position;
						num = (int)((num2 * 1490051492) ^ 0x178E6F36);
						continue;
					default:
						goto end_IL_0078;
					case 0u:
						break;
					case 3u:
						goto end_IL_0078;
					}
					goto IL_0099;
					continue;
					end_IL_0078:
					break;
				}
				break;
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					IL_00d7:
					int num3 = 872099658;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num3 ^ 0x4376A52C)) % 3)
						{
						case 1u:
							goto IL_00a7;
						default:
							goto end_IL_00ba;
						case 2u:
							break;
						case 0u:
							goto end_IL_00ba;
						}
						goto IL_00d7;
						IL_00a7:
						((IDisposable)memoryStream).Dispose();
						num3 = ((int)num2 * -1955289633) ^ 0x469149F3;
						continue;
						end_IL_00ba:
						break;
					}
					break;
				}
			}
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
			MessageBox.Show(mainForm, "It appears you are using a version of Windows that has not been properly tested with the manual map injection method. There is a chance that injection may fail or crash so use another injection method if it doesn't work and report the problem to me. If it crashes, you may want to try ticking \"Disable SEH handler validation\" under Injection Method's Advanced settings.", "Extreme Injector Ex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			warnings.ManualMapAcknowledged = true;
			warningsChanged = true;
		}

		bool usesLdrpLoadDll = options.Method == InjectionMethod.LdrpLoadDll || options.Method == InjectionMethod.LdrpLoadDllStub;
		if (!PlatformInfo.bool_11 && usesLdrpLoadDll && !warnings.LdrpLoadDllAcknowledged)
		{
			MessageBox.Show(mainForm, "It appears you are using a version of Windows that has not been properly tested with the LdrpLoadDll injection method. There is a chance that injection may fail or crash so use another injection method if it doesn't work and report the problem to me.", "Extreme Injector Ex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			warnings.LdrpLoadDllAcknowledged = true;
			warningsChanged = true;
		}

		if (scramblePreset != ScramblePreset.None && !warnings.ScrambleAcknowledged)
		{
			MessageBox.Show(mainForm, "It appears it's the first time you have used the scrambling feature. Sometimes scrambling may cause a DLL to stop working. If this happens, try lowering the scrambling preset (eg. Extreme -> Basic) or turn scrambling off completely.", "Extreme Injector Ex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
		if (@class.method_0() != 0)
		{
			long num3 = default(long);
			while (true)
			{
				int num = 1809806289;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x7573263F)) % 9)
					{
					case 8u:
						break;
					case 4u:
						goto IL_0055;
					case 3u:
						num = ((@class.method_2() == 0) ? (-631331484) : (-1538800215)) ^ (int)(num2 * 1825944899);
						continue;
					case 2u:
						num = ((!class5_0.imethod_0(num3)) ? (-1860934608) : (-681132653)) ^ ((int)num2 * -2076873983);
						continue;
					case 0u:
						goto end_IL_00d0;
					case 1u:
						return null;
					case 5u:
						return null;
					default:
						smethod_157(class5_0, num3);
						return new ImportDirectory(class5_0, class154_0);
					case 6u:
						goto end_IL_0106;
					}
					num3 = smethod_135(class154_0, @class.method_0());
					num = ((num3 == -1L) ? 717800216 : 1609419031);
					continue;
					IL_0055:
					num = ((!class5_0.imethod_0(num3 + @class.method_2())) ? 1505719495 : 603287673);
					continue;
					end_IL_00d0:
					break;
				}
				continue;
				end_IL_0106:
				break;
			}
		}
		return null;
	}

	internal static void smethod_41(PeSectionHeader gclass5_0, PeScrambler gclass4_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] array;
		try
		{
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			try
			{
				binaryWriter.Write(1396986706);
				while (true)
				{
					IL_00e7:
					int num = -1870487940;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1044298899)) % 5)
						{
						case 4u:
							binaryWriter.Write(gclass4_0.random_0.Next());
							binaryWriter.Write(gclass4_0.random_0.Next());
							binaryWriter.Write(Encoding.ASCII.GetBytes(smethod_428(gclass4_0) + "\0"));
							num = (int)((num2 * 1540468110) ^ 0x183F5763);
							continue;
						case 3u:
							binaryWriter.Write(gclass4_0.random_0.Next());
							binaryWriter.Write(gclass4_0.random_0.Next());
							num = (int)((num2 * 1865871664) ^ 0x18918E8D);
							continue;
						case 1u:
							binaryWriter.Write(gclass4_0.random_0.Next());
							num = (int)((num2 * 26423592) ^ 0x76AA72DD);
							continue;
						case 2u:
							break;
						default:
							array = memoryStream.ToArray();
							goto end_IL_00c2;
						}
						goto IL_00e7;
						continue;
						end_IL_00c2:
						break;
					}
					break;
				}
			}
			finally
			{
				if (binaryWriter != null)
				{
					while (true)
					{
						IL_012c:
						int num3 = -2125217943;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num3 ^ -1044298899)) % 3)
							{
							case 1u:
								goto IL_00fc;
							default:
								goto end_IL_010f;
							case 0u:
								break;
							case 2u:
								goto end_IL_010f;
							}
							goto IL_012c;
							IL_00fc:
							((IDisposable)binaryWriter).Dispose();
							num3 = ((int)num2 * -1580879481) ^ -1775441165;
							continue;
							end_IL_010f:
							break;
						}
						break;
					}
				}
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					IL_0169:
					int num4 = -529713195;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num4 ^ -1044298899)) % 3)
						{
						case 1u:
							goto IL_0139;
						default:
							goto end_IL_014c;
						case 0u:
							break;
						case 2u:
							goto end_IL_014c;
						}
						goto IL_0169;
						IL_0139:
						((IDisposable)memoryStream).Dispose();
						num4 = ((int)num2 * -2050419802) ^ 0x7E6A58C5;
						continue;
						end_IL_014c:
						break;
					}
					break;
				}
			}
		}
		gclass4_0.class154_0.method_28().Position = gclass5_0.method_8();
		while (true)
		{
			int num5 = -1372042530;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num5 ^ -1044298899)) % 9)
				{
				case 8u:
					gclass4_0.binaryWriter_0.Write(0);
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num5 = ((int)num2 * -233917129) ^ 0x55B1D94C;
					continue;
				case 7u:
					gclass4_0.binaryWriter_0.Write(array.Length);
					num5 = ((int)num2 * -206896365) ^ -1401188166;
					continue;
				case 6u:
					gclass4_0.binaryWriter_0.Write(0);
					num5 = (int)(num2 * 534129865) ^ -1911474422;
					continue;
				case 5u:
					gclass4_0.binaryWriter_0.Write(gclass5_0.method_4() + 32);
					gclass4_0.binaryWriter_0.Write(gclass5_0.method_8() + 32);
					num5 = ((int)num2 * -1264665237) ^ -99212651;
					continue;
				case 4u:
					gclass4_0.binaryWriter_0.Write(2);
					num5 = (int)((num2 * 1555342059) ^ 0x3103DD8);
					continue;
				case 2u:
					gclass4_0.binaryWriter_0.Write(0);
					gclass4_0.binaryWriter_0.Write(array);
					num5 = (int)(num2 * 512326005) ^ -750366103;
					continue;
				case 0u:
					gclass4_0.class154_0.method_6().method_3().imethod_49()[6].method_1(gclass5_0.method_4());
					num5 = (int)((num2 * 1971433476) ^ 0x7990A0D5);
					continue;
				case 3u:
					break;
				default:
					gclass4_0.class154_0.method_6().method_3().imethod_49()[6].method_3(28u);
					gclass5_0.method_19((SectionCharacteristics)((uint)gclass5_0.method_18() & 0xFDFFFFFFu));
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_43(ImportDirectory.Class150 class150_0)
	{
		class150_0.int_0 = -1;
		while (true)
		{
			int num = 423635800;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4D4CAC9B)) % 4)
				{
				case 3u:
					num = ((class150_0.ienumerator_0 != null) ? 1814998357 : 1465715938) ^ (int)(num2 * 2015806412);
					continue;
				case 2u:
					class150_0.ienumerator_0.Dispose();
					num = (int)(num2 * 2071760766) ^ -1938431190;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
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
		IntPtr intPtr = smethod_42(class89_0.method_19()).method_0(string_0);
		if (intPtr != IntPtr.Zero)
		{
			goto IL_0028;
		}
		goto IL_015a;
		IL_0028:
		int num = 2058013507;
		goto IL_0117;
		IL_0117:
		DependencySearchFlags @enum = default(DependencySearchFlags);
		ManualMapInjector @class = default(ManualMapInjector);
		string text = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6DAC9DEC)) % 12)
			{
			case 10u:
				break;
			case 9u:
				@enum |= DependencySearchFlags.flag_4;
				num = ((int)num2 * -617834182) ^ 0x92E7F4F;
				continue;
			case 8u:
			{
				ManualMapInjector class2 = new ManualMapInjector(class89_0.method_19());
				class2.method_20(class89_0.method_19());
				@class = class2;
				num = ((int)num2 * -58568668) ^ -244573276;
				continue;
			}
			case 6u:
				num = (smethod_379(class89_0.method_19()) ? (-608394723) : (-119591427)) ^ (int)(num2 * 1614912708);
				continue;
			case 5u:
				num = ((text != null) ? (-1646373516) : (-584007238)) ^ (int)(num2 * 1169821124);
				continue;
			case 4u:
				goto IL_00c9;
			case 1u:
				text = smethod_440(string_0, class172_0.method_4(), Path.GetDirectoryName(class172_0.method_4()), @enum, class89_0.method_0(), class172_0.method_10());
				num = 504318009;
				continue;
			case 7u:
				goto IL_015a;
			case 0u:
			{
				IntPtr intPtr2 = @class.method_36(text, enum44_);
				if (intPtr2 == IntPtr.Zero)
				{
					class89_0.method_35(new Exception("Failed to load the requested depedency: " + text, @class.method_34()));
				}
				return intPtr2;
			}
			case 2u:
				class89_0.method_35(new FileNotFoundException("Unable to resolve path for dependency: " + string_0));
				return IntPtr.Zero;
			default:
				try
				{
					return new LoadLibraryInjector(class89_0.method_19()).Inject(text);
				}
				catch (Exception innerException)
				{
					class89_0.method_35(new Exception("Failed to load the requested depedency: " + text, innerException));
					return IntPtr.Zero;
				}
			case 11u:
				return intPtr;
			}
			break;
			IL_00c9:
			num = (((class172_0.method_8() & ManualMapInjector.Enum44.flag_4) != 0) ? 1788943320 : 1492857747);
		}
		goto IL_0028;
		IL_015a:
		@enum = DependencySearchFlags.flag_2;
		num = 1007740930;
		goto IL_0117;
	}

	internal static void smethod_71(PeImageWriter class165_0)
	{
		class165_0.stream_0.Position = class165_0.class154_0.method_4().method_0();
		while (true)
		{
			int num = 1728965764;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4FFAF0F9)) % 4)
				{
				case 1u:
					class165_0.stream_0.Position += 4L;
					num = (int)(num2 * 1744096964) ^ -930849271;
					continue;
				case 0u:
					smethod_159(class165_0);
					num = ((int)num2 * -655409013) ^ -1596080050;
					continue;
				case 2u:
					break;
				default:
					smethod_163(class165_0);
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_76(Stream stream_0, PeImageWriter class165_0)
	{
		stream_0.SetLength(0L);
		while (true)
		{
			int num = -26007130;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1110948373)) % 6)
				{
				case 4u:
					class165_0.class154_0.method_28().Position = 0L;
					smethod_333(class165_0);
					smethod_71(class165_0);
					num = ((int)num2 * -171861212) ^ 0x223EFF10;
					continue;
				case 3u:
					class165_0.method_0();
					num = (int)((num2 * 1475144994) ^ 0x2706DE75);
					continue;
				case 1u:
					class165_0.stream_0 = stream_0;
					class165_0.binaryWriter_0 = new BinaryWriter(stream_0);
					num = (int)((num2 * 94666023) ^ 0x705902E2);
					continue;
				case 0u:
					class165_0.class154_0.method_28().Position = 0L;
					class165_0.class154_0.method_28().smethod_6(stream_0);
					num = ((int)num2 * -306463078) ^ -1347130365;
					continue;
				default:
					return;
				case 5u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	internal static PeImage smethod_81(PeImageLayout enum39_0, string string_0)
	{
		return PeImageReader.smethod_5(new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite), string_0, bool_0: true, enum39_0);
	}

	internal static LoadConfigurationDirectory smethod_92(BoundsCheckedBinaryReader class5_0, PeImage class154_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[10];
		long num3 = default(long);
		while (true)
		{
			int num = 1626571605;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x49CCA07F)) % 11)
				{
				case 8u:
					num = (class5_0.imethod_0(num3) ? 1127392671 : 1564690107) ^ ((int)num2 * -917787358);
					continue;
				case 7u:
					num = ((num3 == -1L) ? (-150406441) : (-1264037439)) ^ ((int)num2 * -1658718608);
					continue;
				case 6u:
					num = ((@class.method_0() != 0) ? 132131702 : 1864030419) ^ (int)(num2 * 2056369660);
					continue;
				case 5u:
					num = ((@class.method_2() == 0) ? (-1279481049) : (-981612614)) ^ (int)(num2 * 274703084);
					continue;
				case 4u:
					num = ((!class5_0.imethod_0(num3 + @class.method_2())) ? 1338331955 : 2004073118);
					continue;
				case 1u:
					num3 = smethod_135(class154_0, @class.method_0());
					num = 1863516466;
					continue;
				case 10u:
					break;
				default:
					smethod_157(class5_0, num3);
					return new LoadConfigurationDirectory(class5_0, class154_0);
				case 2u:
					return null;
				case 3u:
					return null;
				case 9u:
					return null;
				}
				break;
			}
		}
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
		List<ExportedSymbol> result = default(List<ExportedSymbol>);
		if (gclass1_0.list_0 == null)
		{
			ProcessMemoryStream stream = new ProcessMemoryStream(gclass1_0.gclass2_0, gclass1_0.method_0(), ProcessMemoryAccess.const_0, gclass1_0.method_4());
			try
			{
				PeImage @class = PeExportReader.Read(stream, ownsStream: false, layout: PeImageLayout.const_1);
				try
				{
					if (@class.method_14() != null)
					{
						goto IL_0078;
					}
					while (true)
					{
						int num = -895623178;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num ^ -866161837)) % 4)
							{
							case 1u:
								result = new List<ExportedSymbol>();
								num = (int)((num2 * 36783674) ^ 0x67D99247);
								continue;
							case 0u:
								break;
							case 2u:
								goto end_IL_006c;
							default:
								goto IL_0078;
							}
							break;
						}
						continue;
						end_IL_006c:
						break;
					}
					goto end_IL_002e;
					IL_0078:
					gclass1_0.list_0 = new List<ExportedSymbol>(@class.method_14().list_1);
					goto IL_010a;
					end_IL_002e:;
				}
				finally
				{
					if (@class != null)
					{
						while (true)
						{
							IL_00c5:
							int num3 = -408093656;
							while (true)
							{
								uint num2;
								switch ((num2 = (uint)(num3 ^ -866161837)) % 3)
								{
								case 2u:
									goto IL_0095;
								default:
									goto end_IL_00a8;
								case 0u:
									break;
								case 1u:
									goto end_IL_00a8;
								}
								goto IL_00c5;
								IL_0095:
								((IDisposable)@class).Dispose();
								num3 = (int)((num2 * 488368625) ^ 0x7C1C473);
								continue;
								end_IL_00a8:
								break;
							}
							break;
						}
					}
				}
			}
			finally
			{
				if (stream != null)
				{
					while (true)
					{
						IL_0102:
						int num4 = -1670227128;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num4 ^ -866161837)) % 3)
							{
							case 2u:
								goto IL_00d2;
							default:
								goto end_IL_00e5;
							case 0u:
								break;
							case 1u:
								goto end_IL_00e5;
							}
							goto IL_0102;
							IL_00d2:
							((IDisposable)stream).Dispose();
							num4 = ((int)num2 * -882439963) ^ 0xF27D980;
							continue;
							end_IL_00e5:
							break;
						}
						break;
					}
				}
			}
			goto IL_016b;
		}
		goto IL_016d;
		IL_016d:
		return gclass1_0.list_0;
		IL_010a:
		if (!gclass1_0.gclass2_0.dictionary_0.ContainsKey(gclass1_0))
		{
			while (true)
			{
				int num5 = -713425170;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num5 ^ -866161837)) % 4)
					{
					case 1u:
						gclass1_0.gclass2_0.dictionary_0.Add(gclass1_0, gclass1_0.list_0);
						num5 = ((int)num2 * -312428016) ^ 0x455B1;
						continue;
					case 0u:
						break;
					default:
						goto end_IL_0164;
					case 2u:
						goto IL_016d;
					}
					break;
				}
				continue;
				end_IL_0164:
				break;
			}
			goto IL_016b;
		}
		goto IL_016d;
		IL_016b:
		return result;
	}

	internal static long smethod_135(PeImage class154_0, uint uint_0)
	{
		return class154_0.interface3_0.imethod_0(class154_0, uint_0);
	}

	internal static void smethod_159(PeImageWriter class165_0)
	{
		CoffHeader @class = class165_0.class154_0.method_6().method_1();
		while (true)
		{
			int num = -11103572;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -951192336)) % 7)
				{
				case 6u:
					class165_0.binaryWriter_0.Write(@class.method_4());
					num = (int)((num2 * 41769899) ^ 0x4143AB9C);
					continue;
				case 4u:
					class165_0.binaryWriter_0.Write(@class.method_2());
					num = ((int)num2 * -1654486217) ^ 0x4D6475D4;
					continue;
				case 3u:
					class165_0.binaryWriter_0.Write(@class.method_8());
					class165_0.binaryWriter_0.Write(@class.method_10());
					num = (int)((num2 * 114485687) ^ 0x4A5D6A2C);
					continue;
				case 1u:
					class165_0.binaryWriter_0.Write((ushort)@class.method_0());
					@class.method_3((ushort)class165_0.class154_0.method_8().Count);
					num = ((int)num2 * -321670666) ^ -1852362774;
					continue;
				case 0u:
					class165_0.binaryWriter_0.Write(@class.method_6());
					num = ((int)num2 * -1543656515) ^ 0x64D75037;
					continue;
				case 2u:
					break;
				default:
					class165_0.binaryWriter_0.Write((ushort)@class.method_12());
					return;
				}
				break;
			}
		}
	}

	internal static TlsDirectory smethod_160(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[9];
		if (@class.method_0() != 0)
		{
			long num3 = default(long);
			while (true)
			{
				int num = -1969361044;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -778437864)) % 10)
					{
					case 7u:
						num = ((num3 != -1L) ? 1382265114 : 728438419) ^ ((int)num2 * -2077078811);
						continue;
					case 6u:
						num = ((@class.method_2() != 0) ? 32689746 : 616889365) ^ (int)(num2 * 268919682);
						continue;
					case 4u:
						num3 = smethod_135(class154_0, @class.method_0());
						num = -323609743;
						continue;
					case 1u:
						num = (class5_0.imethod_0(num3) ? (-1954671987) : (-1700156455)) ^ (int)(num2 * 1061795529);
						continue;
					case 0u:
						break;
					case 2u:
						goto end_IL_00e3;
					case 5u:
						return null;
					case 8u:
						return null;
					default:
						smethod_157(class5_0, num3);
						return new TlsDirectory(class5_0, class154_0);
					case 3u:
						goto end_IL_011d;
					}
					num = (class5_0.imethod_0(num3 + @class.method_2()) ? (-216356153) : (-1294962737));
					continue;
					end_IL_00e3:
					break;
				}
				continue;
				end_IL_011d:
				break;
			}
		}
		return null;
	}

	internal static List<ImportedSymbol> smethod_162(BoundsCheckedBinaryReader class5_0, ImportDirectory class148_0, PeImage class154_0)
	{
		List<ImportedSymbol> list = new List<ImportedSymbol>();
		ulong ulong_ = default(ulong);
		ImportedSymbol @class = default(ImportedSymbol);
		long num4 = default(long);
		long position = default(long);
		while (true)
		{
			IL_022e:
			long num;
			if (smethod_19(class154_0))
			{
				num = class5_0.ReadUInt32();
				goto IL_021e;
			}
			int num2 = 349227263;
			goto IL_01b8;
			IL_021e:
			ulong_ = (ulong)num;
			num2 = ((num == 0L) ? 508034706 : 776340766);
			goto IL_01b8;
			IL_01b8:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x5D3863A1)) % 15)
				{
				case 14u:
					@class.method_8((@class.method_0() & (ulong)(smethod_19(class154_0) ? 2147483648L : long.MinValue)) > 0L);
					num2 = 82630643;
					continue;
				case 13u:
					num2 = 776340766;
					continue;
				case 10u:
					break;
				case 9u:
				{
					ImportedSymbol class2 = new ImportedSymbol();
					class2.method_1(ulong_);
					@class = class2;
					num2 = 875083338;
					continue;
				}
				case 8u:
					num2 = (@class.method_7() ? 1434587224 : 618987481) ^ (int)(num3 * 1331639034);
					continue;
				case 7u:
					num2 = (class5_0.imethod_0(num4) ? (-1753774204) : (-87263071)) ^ ((int)num3 * -111140187);
					continue;
				case 6u:
					num2 = ((int)num3 * -1209214295) ^ 0x7E523D88;
					continue;
				case 5u:
					smethod_157(class5_0, num4);
					@class.method_6(class5_0.ReadUInt16());
					num2 = ((int)num3 * -1838402414) ^ -993675798;
					continue;
				case 4u:
					list.Add(@class);
					num2 = 1617367704;
					continue;
				case 3u:
					@class.method_3((ushort)(@class.method_0() & 0xFFFFL));
					num2 = ((int)num3 * -1143329219) ^ -1093811936;
					continue;
				case 2u:
					smethod_157(class5_0, position);
					num2 = 896373552;
					continue;
				case 1u:
					@class.method_5(smethod_404(class5_0));
					num2 = (int)(num3 * 331792779) ^ -1102987839;
					continue;
				case 0u:
					goto end_IL_01b8;
				case 11u:
					goto IL_022e;
				default:
					return list;
				}
				num4 = smethod_135(class154_0, (uint)@class.method_0());
				position = class5_0.BaseStream.Position;
				num2 = ((num4 != -1L) ? 1414193164 : 149397536);
				continue;
				end_IL_01b8:
				break;
			}
			num = (long)class5_0.ReadUInt64();
			goto IL_021e;
		}
	}

	internal static void smethod_163(PeImageWriter class165_0)
	{
		IPeOptionalHeader @interface = class165_0.class154_0.method_6().method_3();
		class165_0.binaryWriter_0.Write(@interface.imethod_0());
		if (smethod_19(class165_0.class154_0))
		{
			goto IL_0167;
		}
		goto IL_0880;
		IL_0167:
		int num = 1585451590;
		goto IL_07a1;
		IL_07a1:
		DataDirectory @class = default(DataDirectory);
		DataDirectory[] array = default(DataDirectory[]);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x69A3DFF9)) % 51)
			{
			case 50u:
				class165_0.binaryWriter_0.Write((ushort)@interface.imethod_34());
				num = (int)((num2 * 593508747) ^ 0xFEC38AA);
				continue;
			case 49u:
				class165_0.binaryWriter_0.Write(@interface.imethod_45());
				num = (int)(num2 * 1368992320) ^ -2126707751;
				continue;
			case 48u:
				class165_0.binaryWriter_0.Write(@interface.imethod_22());
				num = (int)(num2 * 411278587) ^ -1243200568;
				continue;
			case 47u:
				class165_0.binaryWriter_0.Write(@interface.imethod_27());
				class165_0.binaryWriter_0.Write(@interface.imethod_28());
				num = ((int)num2 * -367567761) ^ 0x1DCA663;
				continue;
			case 46u:
				class165_0.binaryWriter_0.Write(@interface.imethod_29());
				num = (int)(num2 * 1178225318) ^ -2115100843;
				continue;
			case 45u:
				class165_0.binaryWriter_0.Write(@interface.imethod_43());
				num = ((int)num2 * -1187036265) ^ -955846974;
				continue;
			case 44u:
				class165_0.binaryWriter_0.Write((uint)@interface.imethod_43());
				class165_0.binaryWriter_0.Write(@interface.imethod_45());
				class165_0.binaryWriter_0.Write(@interface.imethod_47());
				num = ((int)num2 * -1123984887) ^ 0xD5F98E5;
				continue;
			case 43u:
				break;
			case 42u:
				class165_0.binaryWriter_0.Write(@interface.imethod_17());
				class165_0.binaryWriter_0.Write(@interface.imethod_18());
				num = (int)((num2 * 723129526) ^ 0x6FAEE9E8);
				continue;
			case 41u:
				class165_0.binaryWriter_0.Write(@interface.imethod_41());
				num = (int)((num2 * 1990579644) ^ 0x21E2F870);
				continue;
			case 40u:
				class165_0.binaryWriter_0.Write(@interface.imethod_7());
				num = ((int)num2 * -462127733) ^ 0x4A8C7515;
				continue;
			case 39u:
				class165_0.binaryWriter_0.Write((uint)@interface.imethod_39());
				num = ((int)num2 * -67482074) ^ 0x566B73A8;
				continue;
			case 38u:
				class165_0.binaryWriter_0.Write(@interface.imethod_22());
				num = ((int)num2 * -912603324) ^ 0x421C339A;
				continue;
			case 37u:
				class165_0.binaryWriter_0.Write((uint)@interface.imethod_41());
				num = (int)(num2 * 1640527425) ^ -1491227095;
				continue;
			case 36u:
				goto IL_025c;
			case 35u:
				class165_0.binaryWriter_0.Write(@interface.imethod_31());
				num = (int)(num2 * 1837562381) ^ -149266983;
				continue;
			case 34u:
				class165_0.binaryWriter_0.Write(@interface.imethod_32());
				num = ((int)num2 * -974082496) ^ 0x2240FF7E;
				continue;
			case 33u:
				@class = array[num3];
				num = 1509465831;
				continue;
			case 31u:
				class165_0.binaryWriter_0.Write(@interface.imethod_26());
				num = ((int)num2 * -1774634896) ^ -1925902590;
				continue;
			case 30u:
				class165_0.binaryWriter_0.Write(@class.method_0());
				class165_0.binaryWriter_0.Write(@class.method_2());
				num = (int)((num2 * 1080186114) ^ 0x1A2231BB);
				continue;
			case 29u:
				class165_0.binaryWriter_0.Write((ushort)@interface.imethod_35());
				class165_0.binaryWriter_0.Write((uint)@interface.imethod_37());
				num = (int)(num2 * 1963406374) ^ -1432444795;
				continue;
			case 28u:
				class165_0.binaryWriter_0.Write((uint)@interface.imethod_17());
				num = ((int)num2 * -1862238666) ^ -1740693451;
				continue;
			case 27u:
				class165_0.binaryWriter_0.Write(@interface.imethod_1());
				num = ((int)num2 * -94461500) ^ -1289489728;
				continue;
			case 25u:
				class165_0.binaryWriter_0.Write(@interface.imethod_13());
				class165_0.binaryWriter_0.Write(@interface.imethod_15());
				num = ((int)num2 * -2131041605) ^ -1075029938;
				continue;
			case 24u:
				class165_0.binaryWriter_0.Write(@interface.imethod_24());
				num = (int)((num2 * 876076062) ^ 0xA18CF58);
				continue;
			case 23u:
				class165_0.binaryWriter_0.Write(@interface.imethod_37());
				class165_0.binaryWriter_0.Write(@interface.imethod_39());
				num = ((int)num2 * -1250094360) ^ 0x5180C1CD;
				continue;
			case 22u:
				class165_0.binaryWriter_0.Write(@interface.imethod_20());
				num = (int)(num2 * 149637219) ^ -1683141213;
				continue;
			case 21u:
				class165_0.binaryWriter_0.Write(@interface.imethod_3());
				num = ((int)num2 * -864582228) ^ 0x1CE35C63;
				continue;
			case 20u:
				array = @interface.imethod_49();
				num3 = 0;
				num = 1632085619;
				continue;
			case 19u:
				class165_0.binaryWriter_0.Write(@interface.imethod_32());
				num = ((int)num2 * -1994936969) ^ 0x10A174F0;
				continue;
			case 18u:
				class165_0.binaryWriter_0.Write(@interface.imethod_31());
				num = ((int)num2 * -1997437539) ^ 0x24843846;
				continue;
			case 17u:
				class165_0.binaryWriter_0.Write(@interface.imethod_11());
				num = (int)(num2 * 898087749) ^ -1489199782;
				continue;
			case 16u:
				class165_0.binaryWriter_0.Write(@interface.imethod_47());
				num = ((int)num2 * -1665732561) ^ -1951856644;
				continue;
			case 15u:
				class165_0.binaryWriter_0.Write(@interface.imethod_5());
				num = (int)((num2 * 241060048) ^ 0x5783FC63);
				continue;
			case 14u:
				class165_0.binaryWriter_0.Write(@interface.imethod_9());
				num = ((int)num2 * -938820760) ^ 0x509725F6;
				continue;
			case 13u:
				class165_0.binaryWriter_0.Write(@interface.imethod_19());
				num = (int)((num2 * 628276) ^ 0x4579A4CC);
				continue;
			case 12u:
				class165_0.binaryWriter_0.Write(@interface.imethod_21());
				num = ((int)num2 * -428505566) ^ -1423167702;
				continue;
			case 11u:
				class165_0.binaryWriter_0.Write(@interface.imethod_13());
				num = ((int)num2 * -997252785) ^ -2075669073;
				continue;
			case 10u:
				class165_0.binaryWriter_0.Write(@interface.imethod_28());
				class165_0.binaryWriter_0.Write(@interface.imethod_29());
				num = ((int)num2 * -591526744) ^ 0x6E0B9C78;
				continue;
			case 9u:
				class165_0.binaryWriter_0.Write((ushort)@interface.imethod_35());
				num = (int)((num2 * 1785867546) ^ 0xACE36CD);
				continue;
			case 8u:
				class165_0.binaryWriter_0.Write(@interface.imethod_20());
				num = ((int)num2 * -2078447524) ^ 0x147E4FC1;
				continue;
			case 7u:
				class165_0.binaryWriter_0.Write((ushort)@interface.imethod_34());
				num = (int)((num2 * 682789992) ^ 0x7E81230D);
				continue;
			case 6u:
				class165_0.binaryWriter_0.Write(@interface.imethod_9());
				class165_0.binaryWriter_0.Write(@interface.imethod_11());
				num = ((int)num2 * -810361972) ^ -1928406851;
				continue;
			case 5u:
				class165_0.binaryWriter_0.Write(@interface.imethod_5());
				class165_0.binaryWriter_0.Write(@interface.imethod_7());
				num = ((int)num2 * -2010825938) ^ 0x712327FA;
				continue;
			case 4u:
				class165_0.binaryWriter_0.Write(@interface.imethod_26());
				class165_0.binaryWriter_0.Write(@interface.imethod_27());
				num = ((int)num2 * -864622139) ^ -882827660;
				continue;
			case 3u:
				class165_0.binaryWriter_0.Write(@interface.imethod_24());
				num = (int)((num2 * 933531428) ^ 0x569530BC);
				continue;
			case 2u:
				num3++;
				num = (int)((num2 * 1185251618) ^ 0x6AF8DCCF);
				continue;
			case 1u:
				class165_0.binaryWriter_0.Write(@interface.imethod_21());
				num = ((int)num2 * -1841880505) ^ 0x6B9D817D;
				continue;
			case 0u:
				class165_0.binaryWriter_0.Write(@interface.imethod_18());
				class165_0.binaryWriter_0.Write(@interface.imethod_19());
				num = (int)((num2 * 807695130) ^ 0x2791A9E5);
				continue;
			default:
				return;
			case 26u:
				goto IL_0880;
			case 32u:
				return;
			}
			break;
			IL_025c:
			num = ((num3 >= array.Length) ? 593774735 : 978895543);
		}
		goto IL_0167;
		IL_0880:
		class165_0.binaryWriter_0.Write(@interface.imethod_1());
		class165_0.binaryWriter_0.Write(@interface.imethod_3());
		num = 1160779843;
		goto IL_07a1;
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
			FileStream fileStream = new FileStream(class16_0.Path, FileMode.Open, FileAccess.Read, FileShare.Read);
			try
			{
				@class = PeExportReader.Read(fileStream, class16_0.Path, ownsStream: false, layout: PeImageLayout.const_0);
				while (true)
				{
					IL_0079:
					int num = 775880384;
					while (true)
					{
						uint num2;
						int num3;
						switch ((num2 = (uint)(num ^ 0x5C35901D)) % 4)
						{
						case 1u:
							num3 = ((@class == null) ? 422722883 : 1041870194);
							goto IL_004f;
						default:
							goto end_IL_0058;
						case 0u:
							break;
						case 2u:
							goto end_IL_0058;
						case 3u:
							return;
						}
						goto IL_0079;
						IL_004f:
						num = num3 ^ (int)(num2 * 1837221785);
						continue;
						end_IL_0058:
						break;
					}
					break;
				}
			}
			finally
			{
				if (fileStream != null)
				{
					while (true)
					{
						IL_00bc:
						int num4 = 544381015;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num4 ^ 0x5C35901D)) % 3)
							{
							case 1u:
								goto IL_008c;
							default:
								goto end_IL_009f;
							case 0u:
								break;
							case 2u:
								goto end_IL_009f;
							}
							goto IL_00bc;
							IL_008c:
							((IDisposable)fileStream).Dispose();
							num4 = ((int)num2 * -1666731322) ^ 0x39A80842;
							continue;
							end_IL_009f:
							break;
						}
						break;
					}
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
				while (true)
				{
					IL_00fe:
					int num5 = 1330094482;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num5 ^ 0x5C35901D)) % 3)
						{
						case 1u:
							goto IL_00ce;
						default:
							goto end_IL_00e1;
						case 0u:
							break;
						case 2u:
							goto end_IL_00e1;
						}
						goto IL_00fe;
						IL_00ce:
						@class.System_002EIDisposable_002EDispose();
						num5 = (int)((num2 * 1530459447) ^ 0x3910D768);
						continue;
						end_IL_00e1:
						break;
					}
					break;
				}
			}
		}
		ModuleOptionsForm form = new ModuleOptionsForm();
		form.method_1(class16_0);
		form.method_3(@class);
		form.ShowDialog();
	}

	internal static Stream smethod_174(PeImage class154_0)
	{
		Stream result = default(Stream);
		lock (class154_0.method_28())
		{
			if (class154_0.method_28() is FileStream)
			{
				goto IL_005a;
			}
			goto IL_0088;
			IL_005a:
			int num = 1453266469;
			goto IL_005f;
			IL_005f:
			MemoryStream memoryStream = default(MemoryStream);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x79F02DB)) % 6)
				{
				case 4u:
					result = new FileStream(class154_0.method_28().smethod_4(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					num = (int)((num2 * 935477354) ^ 0x9A4F6CA);
					continue;
				case 2u:
					class154_0.method_28().smethod_6(memoryStream);
					num = ((int)num2 * -1961812357) ^ 0x2D95C3DA;
					continue;
				case 0u:
					break;
				case 3u:
					goto IL_0088;
				case 1u:
					goto end_IL_000d;
				default:
					memoryStream.Position = 0L;
					result = memoryStream;
					goto end_IL_000d;
				}
				break;
			}
			goto IL_005a;
			IL_0088:
			class154_0.method_28().Position = 0L;
			memoryStream = new MemoryStream();
			num = 1713584963;
			goto IL_005f;
			end_IL_000d:;
		}
		return result;
	}

	internal static void smethod_203(string string_0, string string_1, string string_2, PeImage class154_0, string string_3, MainForm mainForm, string string_4, bool bool_0, string string_5, bool bool_1, string string_6)
	{
		if (bool_0)
		{
			goto IL_00f9;
		}
		goto IL_014f;
		IL_00f9:
		int num = -1987986550;
		goto IL_00fe;
		IL_00fe:
		string string_7 = default(string);
		while (true)
		{
			uint num2;
			string text;
			switch ((num2 = (uint)(num ^ -1895653345)) % 12)
			{
			case 11u:
			{
				DependencyInstallerForm form = new DependencyInstallerForm();
				smethod_29(form, string_0, string_1, "vcredist_" + (smethod_19(class154_0) ? "x86" : "x64") + ".exe");
				form.ShowDialog();
				num = -223346627;
				continue;
			}
			case 10u:
				if (!smethod_19(class154_0))
				{
					num = (int)((num2 * 1464400382) ^ 0x496C19CE);
					continue;
				}
				text = string_4;
				goto IL_0086;
			case 9u:
				smethod_405(class154_0.method_2(), mainForm, string_1, string_7, string_2);
				num = (int)(num2 * 2025920650) ^ -323971473;
				continue;
			case 7u:
				break;
			case 5u:
				text = string_5;
				goto IL_0086;
			case 1u:
				num = ((!PlatformInfo.bool_1) ? 48887343 : 763773503) ^ ((int)num2 * -726703909);
				continue;
			case 0u:
				goto end_IL_00fe;
			default:
				return;
			case 4u:
				goto IL_014f;
			case 2u:
				return;
			case 3u:
				smethod_177(string_2, mainForm, class154_0.method_2());
				return;
			case 6u:
				return;
			case 8u:
				return;
				IL_0086:
				string_7 = text;
				num = -1972545494;
				continue;
			}
			num = (PlatformInfo.bool_1 ? (-1053013471) : (-223346627));
			continue;
			end_IL_00fe:
			break;
		}
		goto IL_00f9;
		IL_014f:
		num = (smethod_337(mainForm, class154_0.method_2(), string_2, string_3, bool_1, string.Format("Microsoft Visual C++ {0} Runtime", string_6)) ? (-94053324) : (-627536497));
		goto IL_00fe;
	}

	internal static ManualMapInjector.Enum44 smethod_206(ManualMapInjector class89_0)
	{
		ManualMapInjector.Enum44 @enum = (ManualMapInjector.Enum44)0;
		while (true)
		{
			int num = 1854214070;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4707AFE7)) % 12)
				{
				case 11u:
					@enum |= ManualMapInjector.Enum44.flag_4;
					num = ((int)num2 * -1520174881) ^ -852355327;
					continue;
				case 9u:
					@enum |= ManualMapInjector.Enum44.flag_1;
					num = ((int)num2 * -2001017929) ^ -1916017482;
					continue;
				case 8u:
					num = (class89_0.method_30() ? 1136704172 : 1413423956);
					continue;
				case 7u:
					num = ((!class89_0.method_32()) ? 953982681 : 1340603571);
					continue;
				case 6u:
					num = ((!class89_0.method_26()) ? 1263587133 : 1006590223);
					continue;
				case 4u:
					@enum |= ManualMapInjector.Enum44.flag_2;
					num = (int)((num2 * 561684884) ^ 0x2E96691D);
					continue;
				case 3u:
					@enum |= ManualMapInjector.Enum44.flag_3;
					num = ((int)num2 * -450798947) ^ -406828320;
					continue;
				case 2u:
					num = ((!class89_0.method_28()) ? 725963719 : 422226548);
					continue;
				case 1u:
					num = (class89_0.method_24() ? (-1226952485) : (-62108980)) ^ (int)(num2 * 455416225);
					continue;
				case 0u:
					@enum |= ManualMapInjector.Enum44.flag_0;
					num = (int)((num2 * 285533461) ^ 0x7E9C673D);
					continue;
				case 5u:
					break;
				default:
					return @enum;
				}
				break;
			}
		}
	}

	internal static PeImage smethod_215(ProcessModuleInfo gclass1_0)
	{
		ProcessMemoryStream stream = new ProcessMemoryStream(gclass1_0.gclass2_0, gclass1_0.method_0(), ProcessMemoryAccess.const_0, gclass1_0.method_4());
		try
		{
			return PeImageReader.smethod_4(stream, bool_0: false, PeImageLayout.const_1);
		}
		finally
		{
			if (stream != null)
			{
				while (true)
				{
					IL_005a:
					int num = 14819409;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x192C7112)) % 3)
						{
						case 1u:
							goto IL_002a;
						default:
							goto end_IL_003d;
						case 2u:
							break;
						case 0u:
							goto end_IL_003d;
						}
						goto IL_005a;
						IL_002a:
						((IDisposable)stream).Dispose();
						num = ((int)num2 * -1708580224) ^ -2062428185;
						continue;
						end_IL_003d:
						break;
					}
					break;
				}
			}
		}
	}

	private static bool ModuleMatchesProcessArchitecture(MainForm mainForm, string modulePath)
	{
		bool moduleIs32Bit;
		using (FileStream stream = new FileStream(modulePath, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (PeImage module = PeImportReader.smethod_13(stream, modulePath, bool_0: false, PeImageLayout.const_0))
		{
			moduleIs32Bit = smethod_19(module);
		}

		bool processIs32Bit = smethod_427(mainForm.selectedProcess);
		if (moduleIs32Bit == processIs32Bit)
		{
			return true;
		}

		mainForm.Invoke((MethodInvoker)delegate
		{
			string modulePlatform = moduleIs32Bit ? "32-bit" : "64-bit";
			string processPlatform = processIs32Bit ? "32-bit" : "64-bit";
			MessageBox.Show(
				mainForm,
				"Platform mismatch detected. You are trying to inject a " + modulePlatform + " DLL (" + Path.GetFileName(modulePath) + ") into a " + processPlatform + " process (" + mainForm.selectedProcess.Name + ") which is not supported.",
				"Extreme Injector Ex",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation);
		});
		return false;
	}

	private static IntPtr InjectWithConfiguredBackend(MainForm mainForm, string modulePath, string sourceModulePath, InjectionOptions options)
	{
		if (options.Method == InjectionMethod.ManualMap)
		{
			return InjectWithManualMap(mainForm.selectedProcess, modulePath, options);
		}

		IntPtr moduleBase;
		using (DllInjector injector = MainForm.InjectorBackendFactories[options.Method](mainForm.selectedProcess))
		{
			injector.method_18(options.Advanced.HideFromDebugger);
			moduleBase = injector.Inject(modulePath);
		}

		if (moduleBase == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}

		ApplyPostInjectionOptions(mainForm, moduleBase, sourceModulePath, options);
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

	private static void ApplyPostInjectionOptions(MainForm mainForm, IntPtr moduleBase, string sourceModulePath, InjectionOptions options)
	{
		if (options.ErasePeHeaders)
		{
			try
			{
				using (PeHeaderEraser moduleEditor = new PeHeaderEraser(mainForm.selectedProcess))
				{
					moduleEditor.method_19(moduleBase);
				}
			}
			catch (Exception exception)
			{
				ShowInjectionError(mainForm, "An error occurred while erasing the PE for \"" + Path.GetFileName(sourceModulePath) + "\"", exception);
			}
		}

		if (options.HideModule)
		{
			try
			{
				smethod_327(new RemoteModuleUnlinker(mainForm.selectedProcess), moduleBase);
			}
			catch (Exception exception)
			{
				ShowInjectionError(mainForm, "An error occurred while hiding the module (" + Path.GetFileName(sourceModulePath) + ").", exception);
			}
		}
	}

	// Raw control-flow-flattened body retained as recovery evidence.
#if false
	internal static bool InjectModuleObfuscated(ref IntPtr intptr_0, MainForm mainForm, [Out] ScramblePreset enum3_0, string string_0)
	{
		string modulePath = string_0;
		intptr_0 = IntPtr.Zero;
		FileStream fileStream = new FileStream(modulePath, FileMode.Open, FileAccess.Read, FileShare.Read);
		bool result = default(bool);
		try
		{
			PeImage class154_ = PeImportReader.smethod_13(fileStream, modulePath, bool_0: false, PeImageLayout.const_0);
			bool moduleIs32Bit = smethod_19(class154_);
			bool processIs32Bit = smethod_427(mainForm.selectedProcess);
			if (moduleIs32Bit != processIs32Bit)
			{
				mainForm.Invoke((MethodInvoker)delegate
				{
					string modulePlatform = moduleIs32Bit ? "32-bit" : "64-bit";
					string processPlatform = processIs32Bit ? "32-bit" : "64-bit";
					MessageBox.Show(mainForm, "Platform mismatch detected. You are trying to inject a " + modulePlatform + " DLL (" + Path.GetFileName(modulePath) + ") into a " + processPlatform + " process (" + mainForm.selectedProcess.method_2() + ") which is not supported.", "Extreme Injector Ex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				});
				result = false;
				goto IL_072f;
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_0110:
					int num = 1014200609;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x7007E065)) % 3)
						{
						case 2u:
							goto IL_00dd;
						default:
							goto end_IL_00f2;
						case 0u:
							break;
						case 1u:
							goto end_IL_00f2;
						}
						goto IL_0110;
						IL_00dd:
						((IDisposable)fileStream).Dispose();
						num = ((int)num2 * -1430391361) ^ -252574851;
						continue;
						end_IL_00f2:
						break;
					}
					break;
				}
			}
		}
		InjectionOptions class14_ = ApplicationSettings.Current.Options;
		string text2 = default(string);
		string text = default(string);
		string path = default(string);
		while (true)
		{
			int num3 = 1481290001;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num3 ^ 0x7007E065)) % 8)
				{
				case 7u:
					text2 = Path.Combine(Path.GetDirectoryName(modulePath), Path.GetFileNameWithoutExtension(modulePath) + "_Scrambled");
					num3 = (int)((num2 * 2095241435) ^ 0x27DE295E);
					continue;
				case 5u:
					break;
				case 4u:
					text = modulePath;
					num3 = ((int)num2 * -646710067) ^ 0x277534FB;
					continue;
				case 3u:
					modulePath = smethod_147(".dll");
					num3 = ((int)num2 * -1611286360) ^ 0x15D10E84;
					continue;
				case 2u:
					num3 = (class14_.StealthInject ? 1887908592 : 1097553202) ^ ((int)num2 * -801763565);
					continue;
				case 1u:
					goto IL_01ee;
				case 0u:
					goto end_IL_01f9;
				default:
					goto IL_02a1;
				}
				if (text == modulePath)
				{
					num3 = (int)((num2 * 715549268) ^ 0x27A7E93E);
					continue;
				}
				goto IL_03cd;
				IL_02a1:
				string extension = Path.GetExtension(modulePath);
				modulePath = text2 + extension;
				try
				{
					if (File.Exists(modulePath))
					{
						while (true)
						{
							IL_0303:
							int num4 = 175693255;
							while (true)
							{
								switch ((num2 = (uint)(num4 ^ 0x7007E065)) % 3)
								{
								case 1u:
									goto IL_02cc;
								default:
									goto end_IL_02e5;
								case 2u:
									break;
								case 0u:
									goto end_IL_02e5;
								}
								goto IL_0303;
								IL_02cc:
								File.Delete(modulePath);
								num4 = (int)(num2 * 692291241) ^ -638726554;
								continue;
								end_IL_02e5:
								break;
							}
							break;
						}
					}
				}
				catch
				{
					int num5 = 1;
					while (true)
					{
						IL_03c4:
						int num6 = 690991702;
						while (true)
						{
							switch ((num2 = (uint)(num6 ^ 0x7007E065)) % 6)
							{
							case 5u:
								num5++;
								num6 = 929048651;
								continue;
							case 4u:
								num6 = ((!File.Exists(path)) ? (-277627350) : (-1407187072)) ^ ((int)num2 * -1010120620);
								continue;
							case 1u:
								num6 = (int)(num2 * 722033706) ^ -1517094891;
								continue;
							case 0u:
								path = (modulePath = text2 + "_" + num5 + extension);
								num6 = 1608583659;
								continue;
							default:
								goto end_IL_039a;
							case 2u:
								break;
							case 3u:
								goto end_IL_039a;
							}
							goto IL_03c4;
							continue;
							end_IL_039a:
							break;
						}
						break;
					}
				}
				goto IL_03cd;
				IL_01ee:
				if (enum3_0 != ScramblePreset.None)
				{
					num3 = 1616631776;
					continue;
				}
				while (true)
				{
					int num7 = ((!(text != modulePath)) ? 1063043804 : 624167310);
					while (true)
					{
						switch ((num2 = (uint)(num7 ^ 0x7007E065)) % 4)
						{
						case 3u:
							File.Copy(text, modulePath);
							num7 = (int)(num2 * 1223685243) ^ -636052171;
							continue;
						case 0u:
							num7 = 1141830131;
							continue;
						case 2u:
							break;
						default:
							goto end_IL_0291;
						}
						break;
					}
					continue;
					end_IL_0291:
					break;
				}
				goto IL_03da;
				IL_03cd:
				smethod_325(mainForm, text, modulePath);
				goto IL_03da;
				IL_03da:
				InjectionMethod enum4_ = class14_.Method;
				try
				{
					if (enum4_ == InjectionMethod.ManualMap)
					{
						AdvancedInjectionOptions class13_ = class14_.Advanced;
						ManualMapInjector class3 = new ManualMapInjector(mainForm.selectedProcess);
						try
						{
							class3.method_18(class13_.HideFromDebugger);
							class3.method_25(class13_.DisableExceptionSupport);
							while (true)
							{
								IL_04a1:
								int num8 = 2077823332;
								while (true)
								{
									int num9;
									switch ((num2 = (uint)(num8 ^ 0x7007E065)) % 4)
									{
									case 1u:
										class3.method_31(class13_.ManualResolveImports);
										class3.method_27(class14_.ErasePeHeaders);
										class3.method_33(class13_.DisableSehValidation);
							intptr_0 = class3.Inject(modulePath);
										num9 = ((class3.method_34() != null) ? 1628520009 : 932593972);
										goto IL_0475;
									default:
										goto end_IL_047f;
									case 0u:
										break;
									case 3u:
										throw class3.method_34();
									case 2u:
										goto end_IL_047f;
									}
									goto IL_04a1;
									IL_0475:
									num8 = num9 ^ (int)(num2 * 1769376855);
									continue;
									end_IL_047f:
									break;
								}
								break;
							}
						}
						finally
						{
							if (class3 != null)
							{
								while (true)
								{
									IL_04ee:
									int num10 = 981285000;
									while (true)
									{
										switch ((num2 = (uint)(num10 ^ 0x7007E065)) % 3)
										{
										case 1u:
											goto IL_04bb;
										default:
											goto end_IL_04d0;
										case 2u:
											break;
										case 0u:
											goto end_IL_04d0;
										}
										goto IL_04ee;
										IL_04bb:
										((IDisposable)class3).Dispose();
										num10 = ((int)num2 * -934255860) ^ -977679286;
										continue;
										end_IL_04d0:
										break;
									}
									break;
								}
							}
						}
					}
					else
					{
						DllInjector class4 = MainForm.InjectorBackendFactories[enum4_](mainForm.selectedProcess);
						class4.method_18(class14_.Advanced.HideFromDebugger);
						while (true)
						{
							int num11 = 1553830076;
							while (true)
							{
								switch ((num2 = (uint)(num11 ^ 0x7007E065)) % 3)
								{
								case 2u:
									intptr_0 = class4.Inject(modulePath);
									num11 = ((int)num2 * -1040866324) ^ 0x102DE663;
									continue;
								case 0u:
									break;
								default:
									goto end_IL_056b;
								}
								break;
							}
							continue;
							end_IL_056b:
							break;
						}
						if (class14_.ErasePeHeaders)
						{
							try
							{
								PeHeaderEraser class5 = new PeHeaderEraser(mainForm.selectedProcess);
								try
								{
									class5.method_19(intptr_0);
								}
								finally
								{
									if (class5 != null)
									{
										while (true)
										{
											IL_05ce:
											int num12 = 1288609482;
											while (true)
											{
												switch ((num2 = (uint)(num12 ^ 0x7007E065)) % 3)
												{
												case 1u:
													goto IL_059b;
												default:
													goto end_IL_05b0;
												case 2u:
													break;
												case 0u:
													goto end_IL_05b0;
												}
												goto IL_05ce;
												IL_059b:
												((IDisposable)class5).Dispose();
												num12 = ((int)num2 * -1012506106) ^ 0x577DA4AC;
												continue;
												end_IL_05b0:
												break;
											}
											break;
										}
									}
								}
							}
							catch (Exception exception_)
							{
								ShowInjectionError(mainForm, "An error occurred while erasing the PE for \"" + Path.GetFileName(text) + "\"", exception_);
							}
						}
						if (class14_.HideModule)
						{
							try
							{
								smethod_327(new RemoteModuleUnlinker(mainForm.selectedProcess), intptr_0);
							}
							catch (Exception exception_2)
							{
								ShowInjectionError(mainForm, "An error occurred while hiding the module (" + Path.GetFileName(text) + ").", exception_2);
							}
						}
					}
					if (intptr_0 == IntPtr.Zero)
					{
						goto IL_0659;
					}
					goto IL_0680;
					IL_0680:
					result = true;
					int num13 = 726568866;
					goto IL_065e;
					IL_0659:
					num13 = 1978625527;
					goto IL_065e;
					IL_065e:
					switch ((uint)(num13 ^ 0x7007E065) % 4u)
					{
					case 0u:
						break;
					default:
						goto end_IL_03e1;
					case 1u:
						goto IL_0680;
					case 2u:
						throw new Exception("The injection method used returned NULL (injection failed).");
					case 3u:
						goto end_IL_03e1;
					}
					goto IL_0659;
					end_IL_03e1:;
				}
				catch (Exception exception_3)
				{
					while (true)
					{
						IL_0726:
						int num14 = 407330830;
						while (true)
						{
							switch ((num2 = (uint)(num14 ^ 0x7007E065)) % 3)
							{
							case 1u:
								goto IL_06a6;
							default:
								goto end_IL_0708;
							case 0u:
								break;
							case 2u:
								goto end_IL_0708;
							}
							goto IL_0726;
							IL_06a6:
							ShowInjectionError(mainForm, "An error occurred while injecting \"" + Path.GetFileName(text) + "\" into \"" + mainForm.selectedProcess.method_2() + "\".", exception_3);
							result = false;
							num14 = (int)(num2 * 649623379) ^ -1756034482;
							continue;
							end_IL_0708:
							break;
						}
						break;
					}
				}
				goto end_IL_022b;
				continue;
				end_IL_01f9:
				break;
			}
			continue;
			end_IL_022b:
			break;
		}
		goto IL_072f;
		IL_072f:
		return result;
	}
#endif

	internal static void smethod_217(BoundsCheckedBinaryReader class5_0, int int_0)
	{
		class5_0.BaseStream.Position += int_0;
	}

	internal static BaseRelocationDirectory smethod_230(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[5];
		long num3 = default(long);
		while (true)
		{
			int num = -986286837;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -89417837)) % 12)
				{
				case 11u:
					num3 = smethod_135(class154_0, @class.method_0());
					num = -904342158;
					continue;
				case 10u:
					num = ((!class5_0.imethod_0(num3)) ? 1897255325 : 1795174784) ^ ((int)num2 * -528952732);
					continue;
				case 7u:
					num = ((num3 + @class.method_2() <= class5_0.BaseStream.Length) ? (-1935543753) : (-947981668));
					continue;
				case 6u:
					num = ((@class.method_2() == 0) ? 212981327 : 1056417020) ^ (int)(num2 * 2022940474);
					continue;
				case 5u:
					num = ((num3 != -1L) ? 1357502099 : 260166383) ^ ((int)num2 * -1258185318);
					continue;
				case 4u:
					num = ((@class.method_0() == 0) ? 874644619 : 1370116925) ^ ((int)num2 * -394709219);
					continue;
				case 0u:
					smethod_157(class5_0, num3);
					num = -593310486;
					continue;
				case 9u:
					break;
				default:
					return new BaseRelocationDirectory(class5_0, class154_0);
				case 2u:
					return null;
				case 3u:
					return null;
				case 8u:
					return null;
				}
				break;
			}
		}
	}

	internal static void smethod_233(ManualMapOptionsForm form2_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ManualMapOptionsForm));
		while (true)
		{
			int num = 1286435599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3DF4862C)) % 47)
				{
				case 46u:
					form2_0.checkBox_3.AutoSize = true;
					form2_0.checkBox_3.Location = new Point(10, 67);
					form2_0.checkBox_3.Name = "disableHandlerValidationCheckBox";
					form2_0.checkBox_3.Size = new Size(184, 17);
					form2_0.checkBox_3.TabIndex = 2;
					num = ((int)num2 * -1841048426) ^ 0x447E8E3B;
					continue;
				case 45u:
					form2_0.groupBox_0.Size = new Size(199, 93);
					num = ((int)num2 * -558020846) ^ 0x4BCCC31B;
					continue;
				case 43u:
					form2_0.groupBox_0.Controls.Add(form2_0.checkBox_3);
					num = ((int)num2 * -1682726095) ^ -2050862917;
					continue;
				case 42u:
					form2_0.checkBox_2.Size = new Size(173, 17);
					num = (int)((num2 * 2143584893) ^ 0x4FC7E0A3);
					continue;
				case 41u:
					form2_0.AutoScaleMode = AutoScaleMode.Dpi;
					num = ((int)num2 * -1480903020) ^ -919384540;
					continue;
				case 40u:
					form2_0.groupBox_1.Name = "generalOptions";
					form2_0.groupBox_1.Size = new Size(199, 47);
					form2_0.groupBox_1.TabIndex = 2;
					num = (int)((num2 * 1615262741) ^ 0x2879C19E);
					continue;
				case 39u:
					form2_0.checkBox_1.Name = "manuallyResolveCheckBox";
					num = (int)((num2 * 730982378) ^ 0x565AE362);
					continue;
				case 38u:
					form2_0.checkBox_2.Name = "hideFromDebuggerCheckBox";
					num = ((int)num2 * -316615933) ^ 0x5274D75A;
					continue;
				case 37u:
					form2_0.checkBox_2.Text = "Hide threads from debugger";
					form2_0.checkBox_2.UseVisualStyleBackColor = true;
					form2_0.checkBox_2.CheckedChanged += form2_0.method_0;
					num = ((int)num2 * -485035542) ^ -804350330;
					continue;
				case 36u:
					form2_0.checkBox_1 = new CheckBox();
					num = (int)(num2 * 1622681415) ^ -154911134;
					continue;
				case 35u:
					form2_0.groupBox_1.PerformLayout();
					num = (int)(num2 * 1758641446) ^ -1026621650;
					continue;
				case 34u:
					form2_0.checkBox_1.Size = new Size(140, 17);
					form2_0.checkBox_1.TabIndex = 0;
					form2_0.checkBox_1.Text = "Manually map imports";
					num = ((int)num2 * -832232227) ^ -1423454085;
					continue;
				case 33u:
					form2_0.groupBox_0.TabIndex = 1;
					form2_0.groupBox_0.TabStop = false;
					num = (int)((num2 * 1973525920) ^ 0x2F1F7FF4);
					continue;
				case 32u:
					form2_0.checkBox_3 = new CheckBox();
					form2_0.checkBox_0 = new CheckBox();
					num = (int)((num2 * 366590973) ^ 0x34B8E0);
					continue;
				case 31u:
					form2_0.checkBox_3.Text = "Disable SEH handler validation";
					num = (int)(num2 * 2076113155) ^ -1960891467;
					continue;
				case 30u:
					form2_0.groupBox_0.Location = new Point(12, 65);
					num = ((int)num2 * -853582256) ^ -985537447;
					continue;
				case 29u:
					form2_0.checkBox_0.CheckedChanged += form2_0.method_2;
					num = (int)((num2 * 1755340225) ^ 0x5663EBD);
					continue;
				case 28u:
					form2_0.groupBox_0.SuspendLayout();
					num = (int)((num2 * 1252007216) ^ 0x6DE0FBFC);
					continue;
				case 27u:
					form2_0.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					num = (int)(num2 * 623997504) ^ -441492064;
					continue;
				case 26u:
					form2_0.checkBox_0.TabIndex = 1;
					form2_0.checkBox_0.Text = "Disable exception support";
					form2_0.checkBox_0.UseVisualStyleBackColor = true;
					num = (int)(num2 * 918020437) ^ -2118819917;
					continue;
				case 25u:
					form2_0.Name = "AdvancedSettingsForm";
					form2_0.StartPosition = FormStartPosition.CenterParent;
					form2_0.Text = "Advanced Settings";
					num = (int)(num2 * 1465955018) ^ -1411775573;
					continue;
				case 24u:
					form2_0.groupBox_1.TabStop = false;
					form2_0.groupBox_1.Text = "General";
					form2_0.checkBox_2.AutoSize = true;
					form2_0.checkBox_2.Location = new Point(10, 21);
					num = ((int)num2 * -1357569558) ^ 0x1FD4E4E6;
					continue;
				case 23u:
					form2_0.groupBox_1.SuspendLayout();
					num = ((int)num2 * -1772395188) ^ 0x48FBA94B;
					continue;
				case 22u:
					form2_0.groupBox_0.Name = "manualMapGroupBox";
					num = ((int)num2 * -549904218) ^ -1974310541;
					continue;
				case 21u:
					form2_0.groupBox_1.ResumeLayout(performLayout: false);
					num = (int)((num2 * 1722255766) ^ 0x2D7EE2DA);
					continue;
				case 20u:
					form2_0.groupBox_1.Controls.Add(form2_0.checkBox_2);
					form2_0.groupBox_1.Location = new Point(12, 12);
					num = (int)((num2 * 610097106) ^ 0x235ABEA7);
					continue;
				case 19u:
					form2_0.groupBox_0.PerformLayout();
					num = (int)(num2 * 336119588) ^ -771375962;
					continue;
				case 18u:
					form2_0.Controls.Add(form2_0.groupBox_1);
					form2_0.Controls.Add(form2_0.groupBox_0);
					form2_0.Font = new Font("Segoe UI", 8.25f);
					num = (int)((num2 * 592057581) ^ 0x26EDD48F);
					continue;
				case 17u:
					form2_0.groupBox_0.Controls.Add(form2_0.checkBox_1);
					num = ((int)num2 * -177578953) ^ -341059023;
					continue;
				case 16u:
					form2_0.checkBox_2 = new CheckBox();
					num = ((int)num2 * -1827111395) ^ 0x31A1FD9;
					continue;
				case 15u:
					form2_0.ResumeLayout(performLayout: false);
					num = (int)((num2 * 2121185601) ^ 0x649D8C0D);
					continue;
				case 14u:
					form2_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
					num = ((int)num2 * -1660421897) ^ 0x5D3FA4C9;
					continue;
				case 13u:
					form2_0.checkBox_3.UseVisualStyleBackColor = true;
					form2_0.checkBox_3.CheckedChanged += form2_0.method_3;
					num = (int)(num2 * 663739557) ^ -1036692927;
					continue;
				case 12u:
					form2_0.checkBox_1.AutoSize = true;
					form2_0.checkBox_1.Location = new Point(10, 21);
					num = ((int)num2 * -1491262952) ^ 0x47A6F5B9;
					continue;
				case 11u:
					form2_0.ClientSize = new Size(223, 170);
					num = (int)((num2 * 2020291074) ^ 0x6F88B133);
					continue;
				case 10u:
					form2_0.checkBox_2.TabIndex = 1;
					num = (int)(num2 * 1552761091) ^ -94033333;
					continue;
				case 9u:
					form2_0.SuspendLayout();
					num = (int)(num2 * 559428801) ^ -1289776847;
					continue;
				case 8u:
					form2_0.groupBox_0.ResumeLayout(performLayout: false);
					num = (int)((num2 * 785730876) ^ 0x107C7CD0);
					continue;
				case 7u:
					form2_0.groupBox_0.Text = "Manual Map Options";
					num = ((int)num2 * -954614082) ^ 0x3044D2D3;
					continue;
				case 6u:
					form2_0.groupBox_1 = new GroupBox();
					num = (int)(num2 * 1835330303) ^ -1831319753;
					continue;
				case 5u:
					form2_0.groupBox_0 = new GroupBox();
					num = ((int)num2 * -1246417789) ^ -731880736;
					continue;
				case 4u:
					form2_0.groupBox_0.Controls.Add(form2_0.checkBox_0);
					num = ((int)num2 * -909554621) ^ -1512998362;
					continue;
				case 2u:
					form2_0.checkBox_0.AutoSize = true;
					form2_0.checkBox_0.Location = new Point(10, 44);
					form2_0.checkBox_0.Name = "disableExceptionsCheckBox";
					form2_0.checkBox_0.Size = new Size(161, 17);
					num = ((int)num2 * -440801927) ^ -884944355;
					continue;
				case 1u:
					form2_0.AutoScaleDimensions = new SizeF(96f, 96f);
					num = (int)((num2 * 260883508) ^ 0xC1DFABA);
					continue;
				case 0u:
					form2_0.checkBox_1.UseVisualStyleBackColor = true;
					form2_0.checkBox_1.CheckedChanged += form2_0.method_1;
					num = ((int)num2 * -1415902137) ^ -1232925945;
					continue;
				default:
					return;
				case 3u:
					break;
				case 44u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_234(AdvancedScrambleSettingsForm gform1_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvancedScrambleSettingsForm));
		while (true)
		{
			int num = -621873833;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -273116904)) % 86)
				{
				case 85u:
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_2);
					num = (int)(num2 * 23674641) ^ -1662600352;
					continue;
				case 84u:
					gform1_0.groupBox_0.Controls.Add(gform1_0.checkBox_1);
					gform1_0.groupBox_0.Controls.Add(gform1_0.checkBox_0);
					gform1_0.groupBox_0.Location = new Point(12, 12);
					num = ((int)num2 * -2052000843) ^ -901015183;
					continue;
				case 83u:
					gform1_0.groupBox_2.PerformLayout();
					num = (int)(num2 * 661226880) ^ -143114380;
					continue;
				case 82u:
					gform1_0.checkBox_8.AutoSize = true;
					num = ((int)num2 * -389949115) ^ 0x38D66359;
					continue;
				case 81u:
					gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_9);
					num = (int)((num2 * 550708044) ^ 0x3AD190A8);
					continue;
				case 80u:
					gform1_0.checkBox_12 = new CheckBox();
					num = ((int)num2 * -1354268964) ^ 0x1C3AE87D;
					continue;
				case 79u:
					gform1_0.checkBox_6.Location = new Point(9, 159);
					gform1_0.checkBox_6.Name = "createEntryPointCheckBox";
					gform1_0.checkBox_6.Size = new Size(141, 17);
					num = (int)(num2 * 343817644) ^ -897658996;
					continue;
				case 78u:
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_4);
					num = ((int)num2 * -1716003977) ^ 0x463B6FAF;
					continue;
				case 76u:
					gform1_0.ResumeLayout(performLayout: false);
					num = ((int)num2 * -889697329) ^ -1509094071;
					continue;
				case 75u:
					gform1_0.checkBox_1.UseVisualStyleBackColor = true;
					gform1_0.checkBox_0.AutoSize = true;
					num = ((int)num2 * -762260694) ^ -2042309300;
					continue;
				case 74u:
					gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_7);
					num = ((int)num2 * -260042164) ^ -866076368;
					continue;
				case 73u:
					gform1_0.checkBox_11.AutoSize = true;
					gform1_0.checkBox_11.Location = new Point(9, 136);
					num = (int)((num2 * 1750289060) ^ 0x686C64F8);
					continue;
				case 72u:
					gform1_0.checkBox_1.Size = new Size(132, 17);
					gform1_0.checkBox_1.TabIndex = 1;
					gform1_0.checkBox_1.Text = "Remove useless data";
					num = (int)(num2 * 1027668513) ^ -1894667495;
					continue;
				case 71u:
					gform1_0.checkBox_2.Name = "shiftSectionDataCheckBox";
					gform1_0.checkBox_2.Size = new Size(116, 17);
					gform1_0.checkBox_2.TabIndex = 1;
					gform1_0.checkBox_2.Text = "Shift section data";
					num = (int)((num2 * 1281399823) ^ 0x1C69A605);
					continue;
				case 70u:
					gform1_0.groupBox_2.TabIndex = 2;
					gform1_0.groupBox_2.TabStop = false;
					num = (int)(num2 * 945715193) ^ -1007988016;
					continue;
				case 69u:
					gform1_0.checkBox_8.Name = "modifyImportTableCheckBox";
					gform1_0.checkBox_8.Size = new Size(128, 17);
					num = (int)((num2 * 1434085307) ^ 0x37C9571F);
					continue;
				case 68u:
					gform1_0.checkBox_2.Location = new Point(9, 44);
					num = ((int)num2 * -1997802922) ^ 0x4FC78E9;
					continue;
				case 67u:
					gform1_0.checkBox_4.AutoSize = true;
					num = ((int)num2 * -829989855) ^ -1753772205;
					continue;
				case 66u:
					gform1_0.Controls.Add(gform1_0.groupBox_2);
					gform1_0.Controls.Add(gform1_0.groupBox_1);
					gform1_0.Controls.Add(gform1_0.groupBox_0);
					gform1_0.Font = new Font("Segoe UI", 8.25f);
					gform1_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
					gform1_0.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					gform1_0.Name = "AdvancedScrambleForm";
					gform1_0.StartPosition = FormStartPosition.CenterParent;
					num = (int)(num2 * 282615022) ^ -1464069882;
					continue;
				case 65u:
					gform1_0.groupBox_1.ResumeLayout(performLayout: false);
					num = (int)(num2 * 931311091) ^ -270631796;
					continue;
				case 64u:
					gform1_0.groupBox_0.Text = "Header Options";
					num = (int)((num2 * 172260938) ^ 0x55803483);
					continue;
				case 63u:
					gform1_0.checkBox_9.TabIndex = 5;
					gform1_0.checkBox_9.Text = "Create fake debug directory";
					gform1_0.checkBox_9.UseVisualStyleBackColor = true;
					num = ((int)num2 * -2066208409) ^ 0x1D1BB77F;
					continue;
				case 62u:
					gform1_0.checkBox_6.UseVisualStyleBackColor = true;
					num = ((int)num2 * -52808147) ^ 0x70958A8B;
					continue;
				case 61u:
					gform1_0.checkBox_9 = new CheckBox();
					gform1_0.checkBox_7 = new CheckBox();
					gform1_0.checkBox_8 = new CheckBox();
					num = (int)((num2 * 52638954) ^ 0x29BF9E0);
					continue;
				case 60u:
					gform1_0.checkBox_0.Location = new Point(9, 21);
					gform1_0.checkBox_0.Name = "scrambleFieldsCheckBox";
					gform1_0.checkBox_0.Size = new Size(142, 17);
					gform1_0.checkBox_0.TabIndex = 0;
					num = ((int)num2 * -1557670625) ^ 0x6D60DA7;
					continue;
				case 59u:
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_3);
					gform1_0.groupBox_1.Location = new Point(12, 86);
					gform1_0.groupBox_1.Name = "sectionsGroupBox";
					num = ((int)num2 * -789973812) ^ 0x5390D8C4;
					continue;
				case 58u:
					gform1_0.checkBox_8.TabIndex = 3;
					gform1_0.checkBox_8.Text = "Modify import table";
					gform1_0.checkBox_8.UseVisualStyleBackColor = true;
					gform1_0.checkBox_12.AutoSize = true;
					gform1_0.checkBox_12.Location = new Point(9, 113);
					gform1_0.checkBox_12.Name = "shiftSectionMemoryCheckBox";
					gform1_0.checkBox_12.Size = new Size(133, 17);
					num = (int)(num2 * 1731256801) ^ -61465073;
					continue;
				case 57u:
					gform1_0.groupBox_0 = new GroupBox();
					gform1_0.checkBox_1 = new CheckBox();
					num = ((int)num2 * -1426794440) ^ 0x1CD319DD;
					continue;
				case 56u:
					gform1_0.checkBox_1.Name = "removeUselessDataCheckBox";
					num = (int)(num2 * 1156660406) ^ -952432516;
					continue;
				case 55u:
					gform1_0.checkBox_11.UseVisualStyleBackColor = true;
					num = (int)(num2 * 450366620) ^ -1604948202;
					continue;
				case 54u:
					gform1_0.checkBox_11.Text = "Strip section characteristics";
					num = (int)((num2 * 1518420147) ^ 0x45D43D9D);
					continue;
				case 53u:
					gform1_0.checkBox_7.UseVisualStyleBackColor = true;
					num = (int)(num2 * 735441325) ^ -968378271;
					continue;
				case 52u:
					gform1_0.checkBox_3.TabIndex = 0;
					gform1_0.checkBox_3.Text = "Insert extra sections";
					num = ((int)num2 * -176693677) ^ -525561867;
					continue;
				case 51u:
					gform1_0.checkBox_11.Size = new Size(165, 17);
					gform1_0.checkBox_11.TabIndex = 6;
					num = (int)(num2 * 265089394) ^ -1552524730;
					continue;
				case 50u:
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_11);
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_12);
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_6);
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_5);
					num = (int)(num2 * 1321130338) ^ -1142964998;
					continue;
				case 49u:
					gform1_0.checkBox_4.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1910310273) ^ -467854554;
					continue;
				case 48u:
					gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_8);
					num = (int)(num2 * 1328389104) ^ -1102836592;
					continue;
				case 47u:
					gform1_0.checkBox_4 = new CheckBox();
					gform1_0.checkBox_2 = new CheckBox();
					gform1_0.checkBox_3 = new CheckBox();
					gform1_0.groupBox_2 = new GroupBox();
					gform1_0.checkBox_10 = new CheckBox();
					num = ((int)num2 * -400900666) ^ 0x45EDF053;
					continue;
				case 46u:
					gform1_0.groupBox_2.Location = new Point(12, 278);
					gform1_0.groupBox_2.Name = "directoryOptionsGroupBox";
					gform1_0.groupBox_2.Size = new Size(187, 120);
					num = (int)(num2 * 539921534) ^ -2069265074;
					continue;
				case 45u:
					gform1_0.checkBox_5.UseVisualStyleBackColor = true;
					num = (int)((num2 * 576759512) ^ 0x186FB66D);
					continue;
				case 44u:
					gform1_0.checkBox_12.UseVisualStyleBackColor = true;
					num = ((int)num2 * -832710069) ^ -1476546483;
					continue;
				case 42u:
					gform1_0.checkBox_9.Name = "createFakeDebugDirectoryCheckBox";
					gform1_0.checkBox_9.Size = new Size(169, 17);
					num = ((int)num2 * -587681899) ^ 0x2C98DD7F;
					continue;
				case 41u:
					gform1_0.checkBox_8.Location = new Point(9, 21);
					num = (int)((num2 * 2066908818) ^ 0x2019A273);
					continue;
				case 40u:
					gform1_0.checkBox_11.Name = "stripCharacteristicsCheckBox";
					num = (int)((num2 * 1776968976) ^ 0x1EE73E0D);
					continue;
				case 39u:
					gform1_0.checkBox_0.Text = "Scramble header fields";
					gform1_0.checkBox_0.UseVisualStyleBackColor = true;
					num = (int)((num2 * 589438285) ^ 0x126A6B87);
					continue;
				case 38u:
					gform1_0.groupBox_0.TabStop = false;
					num = ((int)num2 * -1758220505) ^ 0x699B028;
					continue;
				case 37u:
					gform1_0.AutoScaleMode = AutoScaleMode.Dpi;
					num = (int)(num2 * 1323938635) ^ -2082167424;
					continue;
				case 36u:
					gform1_0.checkBox_2.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1116541063) ^ 0x3DDDEADE;
					continue;
				case 35u:
					gform1_0.checkBox_0 = new CheckBox();
					gform1_0.groupBox_1 = new GroupBox();
					gform1_0.checkBox_6 = new CheckBox();
					num = ((int)num2 * -2069691687) ^ -1689728988;
					continue;
				case 34u:
					gform1_0.checkBox_7.TabIndex = 4;
					gform1_0.checkBox_7.Text = "Move relocation table";
					num = (int)(num2 * 382154377) ^ -1181653091;
					continue;
				case 33u:
					gform1_0.groupBox_0.Name = "headersGroupBox";
					gform1_0.groupBox_0.Size = new Size(187, 68);
					num = (int)((num2 * 990017972) ^ 0x1B1CBE08);
					continue;
				case 32u:
					gform1_0.checkBox_5.Size = new Size(112, 17);
					gform1_0.checkBox_5.TabIndex = 3;
					num = (int)((num2 * 1651923130) ^ 0x3EC0C88E);
					continue;
				case 31u:
					gform1_0.checkBox_11 = new CheckBox();
					gform1_0.groupBox_0.SuspendLayout();
					gform1_0.groupBox_1.SuspendLayout();
					num = ((int)num2 * -2094414304) ^ -1137650583;
					continue;
				case 30u:
					gform1_0.checkBox_7.AutoSize = true;
					num = (int)((num2 * 1781786021) ^ 0x6D6C0017);
					continue;
				case 29u:
					gform1_0.checkBox_5.AutoSize = true;
					num = ((int)num2 * -7468495) ^ -722762334;
					continue;
				case 28u:
					gform1_0.checkBox_6.TabIndex = 4;
					num = ((int)num2 * -40940598) ^ -1602723134;
					continue;
				case 27u:
					gform1_0.groupBox_1.PerformLayout();
					gform1_0.groupBox_2.ResumeLayout(performLayout: false);
					num = ((int)num2 * -1205413814) ^ 0x6D41F1FD;
					continue;
				case 26u:
					gform1_0.groupBox_2.Text = "Directory Options";
					gform1_0.checkBox_10.AutoSize = true;
					gform1_0.checkBox_10.Location = new Point(9, 44);
					num = (int)((num2 * 119579196) ^ 0x20FCBA34);
					continue;
				case 25u:
					gform1_0.checkBox_9.AutoSize = true;
					gform1_0.checkBox_9.Location = new Point(9, 90);
					num = (int)(num2 * 1049986877) ^ -1197577751;
					continue;
				case 24u:
					gform1_0.Text = "Advanced Scramble Settings";
					gform1_0.groupBox_0.ResumeLayout(performLayout: false);
					num = (int)(num2 * 1960018299) ^ -2026772792;
					continue;
				case 23u:
					gform1_0.checkBox_12.TabIndex = 5;
					gform1_0.checkBox_12.Text = "Shift section memory";
					num = ((int)num2 * -572279095) ^ -325043327;
					continue;
				case 22u:
					gform1_0.checkBox_3.AutoSize = true;
					gform1_0.checkBox_3.Location = new Point(9, 21);
					gform1_0.checkBox_3.Name = "insertSectionsCheckBox";
					gform1_0.checkBox_3.Size = new Size(128, 17);
					num = (int)(num2 * 1836177835) ^ -1719086732;
					continue;
				case 21u:
					gform1_0.groupBox_2.SuspendLayout();
					gform1_0.SuspendLayout();
					num = ((int)num2 * -279731497) ^ -1008234747;
					continue;
				case 20u:
					gform1_0.checkBox_4.Location = new Point(9, 67);
					num = (int)((num2 * 1635198877) ^ 0xB4EC7C5);
					continue;
				case 19u:
					gform1_0.checkBox_1.AutoSize = true;
					gform1_0.checkBox_1.Location = new Point(9, 44);
					num = (int)((num2 * 286154601) ^ 0x1F5EFD0B);
					continue;
				case 18u:
					gform1_0.checkBox_4.Text = "Modify assembly code";
					num = ((int)num2 * -117621193) ^ -1502094739;
					continue;
				case 17u:
					gform1_0.checkBox_5.Location = new Point(9, 90);
					num = ((int)num2 * -1388664512) ^ -417446515;
					continue;
				case 16u:
					gform1_0.checkBox_6.Text = "Create new entrypoint";
					num = (int)((num2 * 303090442) ^ 0x44932EFA);
					continue;
				case 15u:
					gform1_0.checkBox_5 = new CheckBox();
					num = ((int)num2 * -830965724) ^ 0x1B862E67;
					continue;
				case 14u:
					gform1_0.checkBox_7.Size = new Size(138, 17);
					num = (int)((num2 * 1165210078) ^ 0x1E958152);
					continue;
				case 13u:
					gform1_0.checkBox_2.AutoSize = true;
					num = ((int)num2 * -349899331) ^ -1201832273;
					continue;
				case 12u:
					gform1_0.AutoScaleDimensions = new SizeF(96f, 96f);
					num = (int)(num2 * 1249709979) ^ -1997932449;
					continue;
				case 11u:
					gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_10);
					num = ((int)num2 * -1343994367) ^ 0x643F55E0;
					continue;
				case 10u:
					gform1_0.checkBox_10.TabIndex = 6;
					gform1_0.checkBox_10.Text = "Remove debug data";
					gform1_0.checkBox_10.UseVisualStyleBackColor = true;
					num = (int)(num2 * 477898099) ^ -615185821;
					continue;
				case 9u:
					gform1_0.checkBox_3.UseVisualStyleBackColor = true;
					num = (int)((num2 * 1668033962) ^ 0x4587ADBB);
					continue;
				case 8u:
					gform1_0.groupBox_0.PerformLayout();
					num = (int)(num2 * 1911016424) ^ -1192049013;
					continue;
				case 7u:
					gform1_0.checkBox_4.Name = "modifyCodeCheckBox";
					gform1_0.checkBox_4.Size = new Size(139, 17);
					gform1_0.checkBox_4.TabIndex = 2;
					num = ((int)num2 * -1081688659) ^ -1037095281;
					continue;
				case 6u:
					gform1_0.checkBox_5.Text = "Rename sections";
					num = ((int)num2 * -1096633799) ^ -1348949827;
					continue;
				case 5u:
					gform1_0.ClientSize = new Size(213, 411);
					num = (int)((num2 * 1795035616) ^ 0x7567EBA8);
					continue;
				case 4u:
					gform1_0.groupBox_1.Size = new Size(187, 186);
					gform1_0.groupBox_1.TabIndex = 1;
					gform1_0.groupBox_1.TabStop = false;
					gform1_0.groupBox_1.Text = "Section Options";
					gform1_0.checkBox_6.AutoSize = true;
					num = (int)(num2 * 636471069) ^ -528562159;
					continue;
				case 3u:
					gform1_0.checkBox_7.Location = new Point(9, 67);
					gform1_0.checkBox_7.Name = "moveRelocationTableCheckBox";
					num = ((int)num2 * -2129944110) ^ 0x76D3175C;
					continue;
				case 2u:
					gform1_0.checkBox_10.Name = "removeDebugDataCheckBox";
					gform1_0.checkBox_10.Size = new Size(129, 17);
					num = (int)((num2 * 1671308631) ^ 0x3F40D032);
					continue;
				case 1u:
					gform1_0.checkBox_5.Name = "renameSectionsCheckBox";
					num = ((int)num2 * -315961578) ^ -23914572;
					continue;
				case 0u:
					gform1_0.groupBox_0.TabIndex = 0;
					num = ((int)num2 * -787275316) ^ 0x3DA697BE;
					continue;
				default:
					return;
				case 43u:
					break;
				case 77u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_240(PeImage class154_0, string string_0, MainForm mainForm)
	{
		bool flag2 = false;
		if (!string_0.StartsWith("msvc", StringComparison.OrdinalIgnoreCase))
		{
			goto IL_0032;
		}
		goto IL_005d;
		IL_0032:
		int num = -1781397143;
		goto IL_0037;
		IL_0037:
		bool flag = default(bool);
		string text = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1402335039)) % 5)
			{
			case 3u:
				break;
			case 0u:
				goto end_IL_0037;
			case 2u:
				goto IL_005d;
			default:
				goto IL_006c;
			case 4u:
				return;
			}
			flag = false;
			if (!string.IsNullOrEmpty(text))
			{
				num = ((int)num2 * -1389369515) ^ -1898394505;
				continue;
			}
			goto IL_0550;
			continue;
			end_IL_0037:
			break;
		}
		goto IL_0032;
		IL_005d:
		text = smethod_353(class154_0, string_0);
		num = -1608867157;
		goto IL_0037;
		IL_0550:
		flag2 = string_0.EndsWith("d.dll", StringComparison.OrdinalIgnoreCase);
		int num3 = ((!PlatformInfo.bool_0) ? (-1018977624) : (-9692213));
		goto IL_04b2;
		IL_04b2:
		string string_5 = default(string);
		string string_4 = default(string);
		string string_2 = default(string);
		string string_3 = default(string);
		string string_1 = default(string);
		while (true)
		{
			uint num2;
			string text2;
			string string_6;
			switch ((num2 = (uint)(num3 ^ -1402335039)) % 31)
			{
			case 29u:
				if (!smethod_19(class154_0))
				{
					num3 = (int)((num2 * 1226008074) ^ 0x1CA774DF);
					continue;
				}
				text2 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202010%20x86%20(Debug).zip";
				goto IL_05ab;
			case 27u:
				string_5 = "2013";
				string_4 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202013%20x86%20(Debug).zip";
				num3 = ((int)num2 * -1918884445) ^ -866666153;
				continue;
			case 25u:
				string_5 = "2012";
				num3 = (int)(num2 * 1940252670) ^ -33320410;
				continue;
			case 24u:
				string_4 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202012%20x86%20(Debug).zip";
				string_2 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202012%20x64%20(Debug).zip";
				string_3 = "http://www.microsoft.com/download/details.aspx?id=30679";
				smethod_203(string_3, string_1, string_0, class154_0, text, mainForm, string_4, flag2, string_2, flag, string_5);
				num3 = (int)(num2 * 1229063295) ^ -805821474;
				continue;
			case 22u:
				string_4 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202015%20x86%20(Debug).zip";
				num3 = (int)((num2 * 1309028008) ^ 0x2412B5B1);
				continue;
			case 20u:
				num3 = (flag2 ? 170669938 : 700320521) ^ ((int)num2 * -1136219596);
				continue;
			case 19u:
				break;
			case 18u:
				string_2 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202015%20x64%20(Debug).zip";
				string_3 = "https://www.microsoft.com/download/details.aspx?id=53840";
				num3 = (int)(num2 * 997741652) ^ -1439617287;
				continue;
			case 17u:
				goto IL_02ac;
			case 15u:
				num3 = (int)((num2 * 536199463) ^ 0x5441B12);
				continue;
			case 14u:
				smethod_203(string_3, string_1, string_0, class154_0, text, mainForm, string_4, flag2, string_2, flag2, string_5);
				num3 = (int)(num2 * 1294788388) ^ -122959201;
				continue;
			case 13u:
				goto IL_031d;
			case 12u:
				num3 = (smethod_19(class154_0) ? (-881593969) : (-223998686)) ^ (int)(num2 * 963837249);
				continue;
			case 11u:
				string_5 = "2015";
				num3 = (int)((num2 * 435508830) ^ 0x24C86BEC);
				continue;
			case 10u:
				goto IL_0397;
			case 9u:
				string_3 = "http://www.microsoft.com/download/details.aspx?id=40784";
				smethod_203(string_3, string_1, string_0, class154_0, text, mainForm, string_4, flag2, string_2, flag, string_5);
				num3 = (int)(num2 * 1297993915) ^ -1752498774;
				continue;
			case 8u:
				string_1 = PlatformInfo.string_1;
				num3 = -2080748112;
				continue;
			case 7u:
				goto IL_03fe;
			case 6u:
				goto IL_042c;
			case 4u:
				string_2 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202013%20x64%20(Debug).zip";
				num3 = ((int)num2 * -1560068227) ^ -1691341806;
				continue;
			case 3u:
				string_1 = PlatformInfo.string_2;
				num3 = ((int)num2 * -1513590725) ^ -1791827357;
				continue;
			case 0u:
				goto IL_0489;
			default:
				return;
			case 16u:
				goto IL_0550;
			case 1u:
				Process.Start("http://www.microsoft.com/download/details.aspx?id=8328");
				return;
			case 2u:
				return;
			case 5u:
				Process.Start("http://www.microsoft.com/download/details.aspx?id=13523");
				return;
			case 21u:
				return;
			case 23u:
				return;
			case 26u:
				return;
			case 28u:
				return;
			case 30u:
				{
					text2 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202010%20x64%20(Debug).zip";
					goto IL_05ab;
				}
				IL_05ab:
				string_6 = text2;
				smethod_405(class154_0.method_2(), mainForm, string_1, string_6, string_0);
				return;
			}
			break;
			IL_0489:
			num3 = ((!smethod_434(string_0, "140")) ? (-675176961) : (-1669463194));
			continue;
			IL_03fe:
			num3 = ((!smethod_434(string_0, "110")) ? (-794947190) : (-590898738));
			continue;
			IL_031d:
			num3 = ((!smethod_434(string_0, "120")) ? (-1272127945) : (-69454099));
			continue;
			IL_042c:
			num3 = (smethod_434(string_0, "100") ? (-1168170587) : (-849012758));
			continue;
			IL_02ac:
			num3 = (smethod_337(mainForm, class154_0.method_2(), string_0, text, flag, "Microsoft Visual C++ 2010 Runtime") ? (-1410142964) : (-82041023));
			continue;
			IL_0397:
			num3 = (smethod_19(class154_0) ? (-1233975278) : (-1045191890));
		}
		goto IL_0277;
		IL_006c:
		FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
		try
		{
			PeImage @class = PeImportReader.smethod_13(fileStream, text, bool_0: false, PeImageLayout.const_0);
			while (true)
			{
				IL_0115:
				int num4 = -790734913;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num4 ^ -1402335039)) % 5)
					{
					case 2u:
						num4 = ((smethod_19(@class) != smethod_19(class154_0)) ? (-729517767) : (-1992703194)) ^ ((int)num2 * -1264109307);
						continue;
					case 1u:
						num4 = ((@class != null) ? (-1731337321) : (-528649616)) ^ ((int)num2 * -528007083);
						continue;
					case 0u:
						flag = true;
						num4 = ((int)num2 * -92557931) ^ -1363019906;
						continue;
					default:
						goto end_IL_00ef;
					case 4u:
						break;
					case 3u:
						goto end_IL_00ef;
					}
					goto IL_0115;
					continue;
					end_IL_00ef:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_015a:
					int num5 = -821711553;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num5 ^ -1402335039)) % 3)
						{
						case 2u:
							goto IL_0127;
						default:
							goto end_IL_013c;
						case 0u:
							break;
						case 1u:
							goto end_IL_013c;
						}
						goto IL_015a;
						IL_0127:
						((IDisposable)fileStream).Dispose();
						num5 = ((int)num2 * -892779052) ^ -1868747642;
						continue;
						end_IL_013c:
						break;
					}
					break;
				}
			}
		}
		if (!flag)
		{
			goto IL_0277;
		}
		goto IL_0550;
		IL_0277:
		num3 = -1046144651;
		goto IL_04b2;
	}

	internal static void smethod_242(ManualMapInjector class89_0, ManualMapInjector.Class172 class172_0)
	{
		byte[] array = ManualMapInjector.smethod_7(class172_0.method_0());
		NativeTypes.Struct50 @struct = default(NativeTypes.Struct50);
		string tempFileName = default(string);
		NativeTypes.Struct50 struct50_ = default(NativeTypes.Struct50);
		while (true)
		{
			int num = -306815367;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1862415398)) % 8)
				{
				case 7u:
					@struct.string_0 = tempFileName;
					num = (int)(num2 * 1775869119) ^ -1759317750;
					continue;
				case 6u:
					tempFileName = Path.GetTempFileName();
					File.WriteAllBytes(tempFileName, array);
					@struct = default(NativeTypes.Struct50);
					num = -1984870842;
					continue;
				case 4u:
					@struct.int_0 = typeof(NativeTypes.Struct50).smethod_7();
					num = (int)(num2 * 1078367355) ^ -1797749071;
					continue;
				case 3u:
					num = ((array != null) ? 1633666709 : 1470329281) ^ ((int)num2 * -1368651093);
					continue;
				case 1u:
					struct50_ = @struct;
					num = ((int)num2 * -1681076010) ^ -1657278495;
					continue;
				case 0u:
					break;
				case 2u:
					return;
				default:
					class172_0.method_11(CreateActCtx(ref struct50_));
					File.Delete(tempFileName);
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_258(SettingsForm gform2_0)
	{
		InjectionOptions class14_ = ApplicationSettings.Current.Options;
		while (true)
		{
			int num = 336446219;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x21E75A13)) % 10)
				{
				case 9u:
					gform2_0.panel_0.BackColor = class14_.BackgroundColor2;
					num = ((int)num2 * -713785333) ^ 0x3796121E;
					continue;
				case 8u:
					gform2_0.checkBox_4.Checked = class14_.ErasePeHeaders;
					num = ((int)num2 * -179221261) ^ 0x7709B898;
					continue;
				case 7u:
					gform2_0.numericUpDown_0.Value = class14_.DelayBetweenModules;
					num = ((int)num2 * -590752730) ^ 0x5F67E55B;
					continue;
				case 6u:
					gform2_0.numericUpDown_1.Value = class14_.DelayBeforeInjection;
					num = (int)(num2 * 1873854063) ^ -1436503997;
					continue;
				case 4u:
					gform2_0.comboBox_0.SelectedIndex = (int)class14_.Method;
					gform2_0.panel_2.BackColor = class14_.TextColor;
					gform2_0.panel_1.BackColor = class14_.BackgroundColor1;
					num = (int)((num2 * 540263552) ^ 0x3670B412);
					continue;
				case 3u:
					gform2_0.checkBox_1.Checked = class14_.CloseOnInject;
					num = ((int)num2 * -450971630) ^ 0x1ACB9788;
					continue;
				case 2u:
					gform2_0.checkBox_2.Checked = class14_.AutoInject;
					num = (int)(num2 * 1371463133) ^ -1356489936;
					continue;
				case 1u:
					gform2_0.checkBox_0.Checked = class14_.StealthInject;
					num = (int)((num2 * 1677704227) ^ 0xE9EAACB);
					continue;
				case 0u:
					break;
				default:
					gform2_0.checkBox_3.Checked = class14_.HideModule;
					smethod_421(gform2_0);
					gform2_0.ApplyModernSettingsTheme();
					return;
				}
				break;
			}
		}
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
		IEnumerator<KeyValuePair<string, List<string>>> enumerator = class154_0.method_10().gclass0_0.imethod_8();
		try
		{
			string key = default(string);
			while (true)
			{
				int num = ((!enumerator.MoveNext()) ? 275879052 : 474212495);
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x13C45758)) % 6)
					{
					case 5u:
						num = (string.IsNullOrEmpty(key) ? (-2087396708) : (-745053135)) ^ (int)(num2 * 1219299494);
						continue;
					case 3u:
						smethod_240(class154_0, key, mainForm);
						smethod_351(class154_0, key, mainForm);
						num = (int)((num2 * 1092998434) ^ 0x63703B8);
						continue;
					case 2u:
						num = 474212495;
						continue;
					case 1u:
						key = enumerator.Current.Key;
						num = 2035192635;
						continue;
					default:
						return;
					case 4u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_0112:
					int num3 = 1477513241;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num3 ^ 0x13C45758)) % 3)
						{
						case 1u:
							goto IL_00e2;
						default:
							goto end_IL_00f5;
						case 2u:
							break;
						case 0u:
							goto end_IL_00f5;
						}
						goto IL_0112;
						IL_00e2:
						enumerator.Dispose();
						num3 = ((int)num2 * -1515806521) ^ 0x96F3EC8;
						continue;
						end_IL_00f5:
						break;
					}
					break;
				}
			}
		}
	}

	internal static Stream smethod_264(PeImage class154_0, long long_0, int int_0)
	{
		Stream result = default(Stream);
		lock (class154_0.method_28())
		{
			long position = class154_0.method_28().Position;
			class154_0.method_28().Position = long_0;
			MemoryStream memoryStream = new MemoryStream();
			while (true)
			{
				IL_00ab:
				int num = 192671807;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x304DD467)) % 5)
					{
					case 2u:
						class154_0.method_28().smethod_5(memoryStream, int_0);
						num = (int)((num2 * 117971427) ^ 0x1351C677);
						continue;
					case 1u:
						class154_0.method_28().Position = position;
						num = (int)(num2 * 1227241566) ^ -986844259;
						continue;
					case 0u:
						memoryStream.Position = 0L;
						result = memoryStream;
						num = (int)(num2 * 919051529) ^ -322841799;
						continue;
					default:
						goto end_IL_0085;
					case 3u:
						break;
					case 4u:
						goto end_IL_0085;
					}
					goto IL_00ab;
					continue;
					end_IL_0085:
					break;
				}
				break;
			}
		}
		return result;
	}

	internal static void smethod_266(ProcessModuleCollection class69_0, PeImage class154_0, IntPtr intptr_0, bool bool_0)
	{
		ProcessModuleInfo gClass = new ProcessModuleInfo(class69_0.gclass2_0, null, intptr_0, bool_0, bool_3: true);
		while (true)
		{
			int num = -630079707;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2014581677)) % 3)
				{
				case 1u:
					goto IL_0012;
				case 2u:
					break;
				default:
					class69_0.gclass2_0.list_1.Add(gClass);
					return;
				}
				break;
				IL_0012:
				string string_ = class154_0.method_0();
				string fileName = Path.GetFileName(class154_0.method_0());
				IntPtr intptr_1 = intptr_0.smethod_9(class154_0.method_6().method_3().imethod_11());
				uint uint_ = class154_0.method_6().method_3().imethod_29();
				smethod_313(string_, fileName, intptr_1, gClass, uint_);
				num = (int)((num2 * 1506359811) ^ 0x31EDE7E8);
			}
		}
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
