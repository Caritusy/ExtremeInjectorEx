using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using ExtremeInjector;

public sealed class SettingsForm : Form
{
	[Serializable]
	[CompilerGenerated]
	public sealed class Class37
	{
		public static readonly Class37 _003C_003E9 = new Class37();

		public static Func<object, bool> _003C_003E9__11_0;

		internal bool method_0(object object_0)
		{
			return object_0.GetType() == typeof(ScramblePresetAttribute);
		}

		internal static Type smethod_0(object object_0)
		{
			return object_0.GetType();
		}

		internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static bool smethod_2(Type type_0, Type type_1)
		{
			return type_0 == type_1;
		}
	}

	[CompilerGenerated]
	internal RemoteProcess gclass2_0;

	internal IContainer icontainer_0;

	internal GroupBox groupBox_0;

	internal ComboBox comboBox_0;

	internal Button button_0;

	internal GroupBox groupBox_1;

	internal CheckBox checkBox_0;

	internal CheckBox checkBox_1;

	internal CheckBox checkBox_2;

	internal GroupBox groupBox_2;

	internal Button button_1;

	internal ComboBox comboBox_1;

	internal NumericUpDown numericUpDown_0;

	internal System.Windows.Forms.Label label_0;

	internal NumericUpDown numericUpDown_1;

	internal System.Windows.Forms.Label label_1;

	internal GroupBox groupBox_3;

	internal CheckBox checkBox_3;

	internal CheckBox checkBox_4;

	internal GroupBox groupBox_4;

	internal System.Windows.Forms.Label label_2;

	internal Panel panel_0;

	internal Panel panel_1;

	internal System.Windows.Forms.Label label_3;

	internal System.Windows.Forms.Label label_4;

	internal Panel panel_2;

	internal Button button_2;

	internal Button button_3;

	internal GroupBox groupBox_5;

	internal Button button_4;

	internal Button button_5;

	internal Button button_6;

	internal ColorDialog colorDialog_0;

	public SettingsForm()
	{
		while (true)
		{
			int num = 829739510;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6FE22A78)) % 3)
				{
				case 1u:
					goto IL_0008;
				case 0u:
					break;
				default:
					button_4.Enabled = !string.IsNullOrEmpty(Assembly.GetExecutingAssembly().Location);
					Class171.smethod_258(this);
					return;
				}
				break;
				IL_0008:
				Class171.smethod_294(this);
				num = (int)((num2 * 1587728921) ^ 0xE422672);
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal RemoteProcess method_0()
	{
		return gclass2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(RemoteProcess gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	internal void method_2(object sender, EventArgs e)
	{
		checkBox_1.Enabled = !checkBox_2.Checked;
	}

	internal void method_3(object sender, EventArgs e)
	{
		new AdvancedScrambleSettingsForm().ShowDialog();
		Class171.smethod_421(this);
	}

	internal void method_4(object sender, EventArgs e)
	{
		new ManualMapOptionsForm().ShowDialog();
	}

	internal void method_5()
	{
		var selectedPreset = comboBox_1.SelectedIndex switch
		{
			0 => ScramblePreset.None,
			1 => ScramblePreset.Basic,
			2 => ScramblePreset.Standard,
			3 => ScramblePreset.Extreme,
			_ => ScramblePreset.Custom
		};

		button_5.Enabled = selectedPreset == ScramblePreset.Custom;
		ApplicationSettings.Current.Options.Scramble.ApplyPreset(selectedPreset);
	}

	internal void method_6(object sender, EventArgs e)
	{
		method_5();
	}

	internal void method_7(object sender, EventArgs e)
	{
		if (MessageBox.Show("Are you sure you want to reset the settings?", "Extreme Injector v3", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
		{
			return;
		}
		while (true)
		{
			int num = -1733663445;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1198282611)) % 3)
				{
				case 1u:
					goto IL_0021;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0021:
				ApplicationSettings.Current = new ApplicationSettings();
				ApplicationSettings.Save();
				Class171.smethod_258(this);
				num = (int)(num2 * 874433739) ^ -228795254;
			}
		}
	}

	internal void method_8(object sender, EventArgs e)
	{
		Close();
	}

	internal void method_9(object sender, FormClosingEventArgs e)
	{
		Class171.smethod_330(this);
	}

	internal void method_10(object sender, EventArgs e)
	{
		Class171.ShowProcessInspector(method_0());
	}

	internal void method_11(object sender, EventArgs e)
	{
		if (!ApplicationSettings.Current.Warnings.ScrambleAcknowledged)
		{
			while (true)
			{
				int num = -1492357855;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -605434328)) % 4)
					{
					case 2u:
						MessageBox.Show("Extreme Injector v3 automatically scrambles DLLs on injection. You only need to use this if you are using another injector.", "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						num = (int)((num2 * 233957255) ^ 0x12755E55);
						continue;
					case 1u:
						ApplicationSettings.Current.Warnings.ScrambleAcknowledged = true;
						num = ((int)num2 * -238310262) ^ -1069707356;
						continue;
					case 0u:
						break;
					default:
						goto end_IL_0080;
					}
					break;
				}
				continue;
				end_IL_0080:
				break;
			}
		}
		OpenFileDialog openFileDialog = new OpenFileDialog();
		try
		{
			openFileDialog.Filter = "DLL Files|*.dll";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			try
			{
				Class154 @class = Class171.smethod_81(Enum39.const_0, openFileDialog.FileName);
				try
				{
					if (@class == null)
					{
						return;
					}
					InjectorScrambleOptions injectorScrambleOptions_ = default(InjectorScrambleOptions);
					Class131 class131_ = default(Class131);
					while (true)
					{
						int num3 = -1694884631;
						while (true)
						{
							int num8;
							uint num2;
							switch ((num2 = (uint)(num3 ^ -605434328)) % 4)
							{
							case 1u:
								num8 = (((@class.method_6().method_1().method_12() & Enum36.flag_12) != 0) ? 29459692 : 40628579);
								goto IL_00ef;
							case 2u:
								break;
							default:
							{
								SaveFileDialog saveFileDialog = new SaveFileDialog();
								try
								{
									saveFileDialog.Filter = openFileDialog.Filter;
									while (true)
									{
										int num4 = -508795643;
										while (true)
										{
											switch ((num2 = (uint)(num4 ^ -605434328)) % 7)
											{
											case 6u:
											{
												Class131 class2 = new Class131();
												class2.method_21(injectorScrambleOptions_.CreateNewEntryPoint);
												class2.method_3(injectorScrambleOptions_.InsertExtraSections);
												class2.method_11(injectorScrambleOptions_.ModifyAssemblyCode);
												class2.method_1(injectorScrambleOptions_.ScrambleHeaderFields);
												class2.method_19(injectorScrambleOptions_.ModifyImportTable);
												class2.method_17(injectorScrambleOptions_.RenameSections);
												class2.method_15(injectorScrambleOptions_.MoveRelocationTable);
												class2.method_5(injectorScrambleOptions_.RemoveDebugData);
												class2.method_9(injectorScrambleOptions_.ShiftSectionData);
												class2.method_13(injectorScrambleOptions_.RemoveUselessData);
												class2.method_7(injectorScrambleOptions_.CreateFakeDebugDirectory);
												class2.method_24(injectorScrambleOptions_.ShiftSectionMemory);
												class2.method_26(injectorScrambleOptions_.StripSectionCharacteristics);
												class131_ = class2;
												num4 = ((int)num2 * -903883345) ^ 0x3763006F;
												continue;
											}
											case 4u:
												injectorScrambleOptions_ = ApplicationSettings.Current.Options.Scramble;
												num4 = -1291058490;
												continue;
											case 3u:
												num4 = ((saveFileDialog.ShowDialog() != DialogResult.OK) ? 1136902959 : 1959171153) ^ (int)(num2 * 1097795143);
												continue;
											case 1u:
												saveFileDialog.InitialDirectory = Path.GetDirectoryName(openFileDialog.FileName);
												saveFileDialog.FileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName) + "_Scrambled.dll";
												num4 = ((int)num2 * -1319970846) ^ 0xEE17922;
												continue;
											case 0u:
												break;
											default:
											{
												GClass4 gClass = new GClass4(@class, class131_);
												try
												{
													Class171.smethod_95(gClass);
													while (true)
													{
														int num5 = -583743408;
														while (true)
														{
															switch ((num2 = (uint)(num5 ^ -605434328)) % 3)
															{
															case 2u:
																goto IL_02b8;
															case 0u:
																break;
															default:
																MessageBox.Show("The specified DLL has been successfully scrambled!", "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
																return;
															}
															break;
															IL_02b8:
															Class171.smethod_367(saveFileDialog.FileName, gClass);
															num5 = (int)((num2 * 502638858) ^ 0x265E4F80);
														}
													}
												}
												finally
												{
													if (gClass != null)
													{
														while (true)
														{
															IL_0350:
															int num6 = -856826449;
															while (true)
															{
																switch ((num2 = (uint)(num6 ^ -605434328)) % 3)
																{
																case 1u:
																	goto IL_031d;
																default:
																	goto end_IL_0332;
																case 0u:
																	break;
																case 2u:
																	goto end_IL_0332;
																}
																goto IL_0350;
																IL_031d:
																((IDisposable)gClass).Dispose();
																num6 = (int)((num2 * 2056844029) ^ 0x2A5621A);
																continue;
																end_IL_0332:
																break;
															}
															break;
														}
													}
												}
											}
											case 5u:
												return;
											}
											break;
										}
									}
								}
								finally
								{
									if (saveFileDialog != null)
									{
										while (true)
										{
											IL_0396:
											int num7 = -226884265;
											while (true)
											{
												switch ((num2 = (uint)(num7 ^ -605434328)) % 3)
												{
												case 2u:
													goto IL_0364;
												default:
													goto end_IL_0378;
												case 0u:
													break;
												case 1u:
													goto end_IL_0378;
												}
												goto IL_0396;
												IL_0364:
												((IDisposable)saveFileDialog).Dispose();
												num7 = ((int)num2 * -519100131) ^ 0x36A05483;
												continue;
												end_IL_0378:
												break;
											}
											break;
										}
									}
								}
							}
							case 3u:
								return;
							}
							break;
							IL_00ef:
							num3 = num8 ^ ((int)num2 * -5173800);
						}
					}
				}
				finally
				{
					if (@class != null)
					{
						while (true)
						{
							IL_03dc:
							int num9 = -1176749812;
							while (true)
							{
								uint num2;
								switch ((num2 = (uint)(num9 ^ -605434328)) % 3)
								{
								case 2u:
									goto IL_03aa;
								default:
									goto end_IL_03be;
								case 0u:
									break;
								case 1u:
									goto end_IL_03be;
								}
								goto IL_03dc;
								IL_03aa:
								((IDisposable)@class).Dispose();
								num9 = (int)(num2 * 1636820537) ^ -1388513852;
								continue;
								end_IL_03be:
								break;
							}
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while trying to scramble the specified file:\n\n" + ex.Message, "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		finally
		{
			if (openFileDialog != null)
			{
				while (true)
				{
					IL_0453:
					int num10 = -261073156;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num10 ^ -605434328)) % 3)
						{
						case 2u:
							goto IL_0421;
						default:
							goto end_IL_0435;
						case 0u:
							break;
						case 1u:
							goto end_IL_0435;
						}
						goto IL_0453;
						IL_0421:
						((IDisposable)openFileDialog).Dispose();
						num10 = (int)(num2 * 316266070) ^ -274923658;
						continue;
						end_IL_0435:
						break;
					}
					break;
				}
			}
		}
	}

	internal void method_12(object sender, EventArgs e)
	{
		Class154 @class = Class171.smethod_81(Enum39.const_0, Assembly.GetExecutingAssembly().Location);
		try
		{
			Class131 class2 = new Class131();
			class2.method_1(bool_14: true);
			class2.method_19(bool_14: true);
			class2.method_5(bool_14: true);
			class2.method_9(bool_14: true);
			class2.method_13(bool_14: true);
			Class131 class131_ = class2;
			GClass4 gClass = new GClass4(@class, class131_);
			try
			{
				Class171.smethod_95(gClass);
				string string_ = "Extreme Injector";
				Encoding aSCII = Encoding.ASCII;
				Class171.smethod_267(aSCII, gClass, string_);
				MemoryStream memoryStream = default(MemoryStream);
				string string_2 = default(string);
				Encoding encoding_ = default(Encoding);
				string text = default(string);
				while (true)
				{
					int num = 504448418;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x2041F790)) % 15)
						{
						case 13u:
							Class171.smethod_58(gClass, memoryStream);
							num = (int)((num2 * 967311158) ^ 0x796A89A4);
							continue;
						case 12u:
							Class171.smethod_267(aSCII, gClass, string_);
							string_2 = "master131";
							encoding_ = Encoding.ASCII;
							Class171.smethod_185(encoding_, gClass, string_2);
							num = (int)((num2 * 1608621453) ^ 0x76E1422);
							continue;
						case 11u:
							Environment.Exit(0);
							num = (int)((num2 * 1753740522) ^ 0x67A8E9CA);
							continue;
						case 10u:
							string_ = "ExtremeInjector";
							num = ((int)num2 * -1341676039) ^ -50678194;
							continue;
						case 9u:
							ApplicationSettings.Save();
							memoryStream = new MemoryStream();
							num = ((int)num2 * -2079510115) ^ -970640455;
							continue;
						case 8u:
							Class171.smethod_185(encoding_, gClass, string_2);
							text = Class171.CreateUniqueTemporaryPath(".exe");
							num = (int)(num2 * 1739945033) ^ -1426810306;
							continue;
						case 7u:
							Process.Start(text, Class171.smethod_317());
							num = (int)((num2 * 279839820) ^ 0x57E4044A);
							continue;
						case 6u:
							encoding_ = Encoding.Unicode;
							num = (int)((num2 * 1165277215) ^ 0x4646E508);
							continue;
						case 5u:
							string_2 = "master131";
							num = (int)(num2 * 27064200) ^ -817821368;
							continue;
						case 4u:
							Class9.smethod_3(memoryStream.ToArray(), text, PEFileKinds.WindowApplication);
							Class171.smethod_291(text);
							num = (int)(num2 * 1578314667) ^ -1618127793;
							continue;
						case 3u:
							string_2 = "Extreme Injector";
							encoding_ = Encoding.Unicode;
							num = (int)(num2 * 322806409) ^ -2065932608;
							continue;
						case 1u:
							Class171.smethod_185(encoding_, gClass, string_2);
							num = (int)(num2 * 172715753) ^ -594004202;
							continue;
						case 0u:
							aSCII = Encoding.ASCII;
							num = (int)(num2 * 1869512847) ^ -175029175;
							continue;
						default:
							return;
						case 2u:
							break;
						case 14u:
							return;
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				while (true)
				{
					int num3 = 1874349747;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num3 ^ 0x2041F790)) % 3)
						{
						case 2u:
							goto IL_026a;
						default:
							return;
						case 0u:
							break;
						case 1u:
							return;
						}
						break;
						IL_026a:
						MessageBox.Show("An error occurred while trying to start in secure mode:\n\n" + ex.Message, "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						num3 = ((int)num2 * -1892939032) ^ -911176050;
					}
				}
			}
			finally
			{
				if (gClass != null)
				{
					while (true)
					{
						IL_02ff:
						int num4 = 9305014;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num4 ^ 0x2041F790)) % 3)
							{
							case 1u:
								goto IL_02cd;
							default:
								goto end_IL_02e1;
							case 0u:
								break;
							case 2u:
								goto end_IL_02e1;
							}
							goto IL_02ff;
							IL_02cd:
							((IDisposable)gClass).Dispose();
							num4 = ((int)num2 * -1474531002) ^ 0x690AED23;
							continue;
							end_IL_02e1:
							break;
						}
						break;
					}
				}
			}
		}
		finally
		{
			if (@class != null)
			{
				while (true)
				{
					IL_033e:
					int num5 = 284663935;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num5 ^ 0x2041F790)) % 3)
						{
						case 1u:
							goto IL_030c;
						default:
							goto end_IL_0320;
						case 2u:
							break;
						case 0u:
							goto end_IL_0320;
						}
						goto IL_033e;
						IL_030c:
						((IDisposable)@class).Dispose();
						num5 = (int)(num2 * 1760980894) ^ -1786834110;
						continue;
						end_IL_0320:
						break;
					}
					break;
				}
			}
		}
	}

	internal void method_13(object sender, EventArgs e)
	{
		colorDialog_0.Color = ApplicationSettings.Current.Options.TextColor;
		if (colorDialog_0.ShowDialog() == DialogResult.OK)
		{
			goto IL_0053;
		}
		goto IL_0079;
		IL_0053:
		int num = -226396215;
		goto IL_0058;
		IL_0058:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -879150788)) % 4)
			{
			case 1u:
				ApplicationSettings.Current.Options.TextColor = colorDialog_0.Color;
				num = ((int)num2 * -1234069786) ^ 0x34BD0CED;
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_0079;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0053;
		IL_0079:
		Class171.smethod_258(this);
		num = -1690740026;
		goto IL_0058;
	}

	internal void method_14(object sender, EventArgs e)
	{
		colorDialog_0.Color = ApplicationSettings.Current.Options.BackgroundColor1;
		if (colorDialog_0.ShowDialog() == DialogResult.OK)
		{
			goto IL_0053;
		}
		goto IL_0079;
		IL_0053:
		int num = 738528185;
		goto IL_0058;
		IL_0058:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x59219B28)) % 4)
			{
			case 1u:
				ApplicationSettings.Current.Options.BackgroundColor1 = colorDialog_0.Color;
				num = (int)(num2 * 946961291) ^ -321877223;
				continue;
			case 0u:
				break;
			default:
				return;
			case 2u:
				goto IL_0079;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0053;
		IL_0079:
		Class171.smethod_258(this);
		num = 1504340079;
		goto IL_0058;
	}

	internal void method_15(object sender, EventArgs e)
	{
		colorDialog_0.Color = ApplicationSettings.Current.Options.BackgroundColor2;
		while (true)
		{
			int num = 1652796655;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x75A5EA21)) % 4)
				{
				case 2u:
					num = ((colorDialog_0.ShowDialog() != DialogResult.OK) ? 660861890 : 2098480816) ^ (int)(num2 * 1727397516);
					continue;
				case 1u:
					ApplicationSettings.Current.Options.BackgroundColor2 = colorDialog_0.Color;
					num = (int)((num2 * 1503459866) ^ 0x6E3B60A0);
					continue;
				case 0u:
					break;
				default:
					Class171.smethod_258(this);
					return;
				}
				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0048;
		}
		goto IL_0072;
		IL_0048:
		int num = -1541027677;
		goto IL_004d;
		IL_004d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1930754146)) % 5)
			{
			case 4u:
				num = ((icontainer_0 == null) ? 1358176602 : 1161568117) ^ ((int)num2 * -265332846);
				continue;
			case 3u:
				icontainer_0.Dispose();
				num = ((int)num2 * -1673290407) ^ 0x5D6909E9;
				continue;
			case 0u:
				break;
			default:
				return;
			case 2u:
				goto IL_0072;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0048;
		IL_0072:
		base.Dispose(disposing);
		num = -842615805;
		goto IL_004d;
	}

	internal static Assembly smethod_0()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static string smethod_1(Assembly assembly_0)
	{
		return assembly_0.Location;
	}

	internal static bool smethod_2(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	internal static void smethod_3(Control control_0, bool bool_0)
	{
		control_0.Enabled = bool_0;
	}

	internal static bool smethod_4(CheckBox checkBox_5)
	{
		return checkBox_5.Checked;
	}

	internal static DialogResult smethod_5(Form form_0)
	{
		return form_0.ShowDialog();
	}

	internal static Type smethod_6(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal FieldInfo[] method_16()
	{
		return ((Type)(object)this).GetFields();
	}

	internal static int smethod_7(ListControl listControl_0)
	{
		return listControl_0.SelectedIndex;
	}

	internal static void smethod_8(FieldInfo fieldInfo_0, object object_0, object object_1)
	{
		fieldInfo_0.SetValue(object_0, object_1);
	}

	internal static ComboBox.ObjectCollection smethod_9(ComboBox comboBox_2)
	{
		return comboBox_2.Items;
	}

	internal static int smethod_10(ComboBox.ObjectCollection objectCollection_0)
	{
		return objectCollection_0.Count;
	}

	internal static object[] smethod_11(MemberInfo memberInfo_0, bool bool_0)
	{
		return memberInfo_0.GetCustomAttributes(bool_0);
	}

	internal static DialogResult smethod_12(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	internal static void smethod_13(Form form_0)
	{
		form_0.Close();
	}

	internal static OpenFileDialog smethod_14()
	{
		return new OpenFileDialog();
	}

	internal static void smethod_15(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.Filter = string_0;
	}

	internal static DialogResult smethod_16(CommonDialog commonDialog_0)
	{
		return commonDialog_0.ShowDialog();
	}

	internal static string smethod_17(FileDialog fileDialog_0)
	{
		return fileDialog_0.FileName;
	}

	internal static SaveFileDialog smethod_18()
	{
		return new SaveFileDialog();
	}

	internal static string smethod_19(FileDialog fileDialog_0)
	{
		return fileDialog_0.Filter;
	}

	internal static string smethod_20(string string_0)
	{
		return Path.GetDirectoryName(string_0);
	}

	internal static void smethod_21(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.InitialDirectory = string_0;
	}

	internal static string smethod_22(string string_0)
	{
		return Path.GetFileNameWithoutExtension(string_0);
	}

	internal static string smethod_23(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	internal static void smethod_24(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.FileName = string_0;
	}

	internal static void smethod_25(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static string smethod_26(Exception exception_0)
	{
		return exception_0.Message;
	}

	internal static Encoding smethod_27()
	{
		return Encoding.ASCII;
	}

	internal static Encoding smethod_28()
	{
		return Encoding.Unicode;
	}

	internal static MemoryStream smethod_29()
	{
		return new MemoryStream();
	}

	internal static byte[] smethod_30(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	internal static Process smethod_31(string string_0, string string_1)
	{
		return Process.Start(string_0, string_1);
	}

	internal static void smethod_32(int int_0)
	{
		Environment.Exit(int_0);
	}

	internal static void smethod_33(ColorDialog colorDialog_1, Color color_0)
	{
		colorDialog_1.Color = color_0;
	}

	internal static Color smethod_34(ColorDialog colorDialog_1)
	{
		return colorDialog_1.Color;
	}
}
