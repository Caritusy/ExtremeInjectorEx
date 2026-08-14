using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using ExtremeInjector;

public sealed class GForm2 : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class37
	{
		public static readonly Class37 _003C_003E9 = new Class37();

		public static Func<object, bool> _003C_003E9__11_0;

		internal bool method_0(object object_0)
		{
			return object_0.GetType() == typeof(Attribute0);
		}
	}

	[CompilerGenerated]
	private GClass2 gclass2_0;

	private IContainer icontainer_0;

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

	internal Label label_0;

	internal NumericUpDown numericUpDown_1;

	internal Label label_1;

	internal GroupBox groupBox_3;

	internal CheckBox checkBox_3;

	internal CheckBox checkBox_4;

	internal GroupBox groupBox_4;

	internal Label label_2;

	internal Panel panel_0;

	internal Panel panel_1;

	internal Label label_3;

	internal Label label_4;

	internal Panel panel_2;

	internal Button button_2;

	internal Button button_3;

	internal GroupBox groupBox_5;

	internal Button button_4;

	internal Button button_5;

	internal Button button_6;

	internal ColorDialog colorDialog_0;

	public GForm2()
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
					Class171.smethod_252(this);
					return;
				}
				break;
				IL_0008:
				Class171.smethod_288(this);
				num = (int)((num2 * 1587728921) ^ 0xE422672);
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private GClass2 method_0()
	{
		return gclass2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(GClass2 gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	internal void method_2(object sender, EventArgs e)
	{
		checkBox_1.Enabled = !checkBox_2.Checked;
	}

	internal void method_3(object sender, EventArgs e)
	{
		new GForm1().ShowDialog();
		Class171.smethod_413(this);
	}

	internal void method_4(object sender, EventArgs e)
	{
		new Form2().ShowDialog();
	}

	private void method_5()
	{
		FieldInfo[] array = ((GForm2)(object)typeof(InjectorScrambleOptions)).method_16();
		if (comboBox_1.SelectedIndex == 0)
		{
			goto IL_020c;
		}
		goto IL_027f;
		IL_020c:
		int num = 335506543;
		goto IL_0211;
		IL_0211:
		FieldInfo[] array2 = default(FieldInfo[]);
		FieldInfo fieldInfo = default(FieldInfo);
		int num3 = default(int);
		object obj = default(object);
		int num5 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x5CE54162)) % 19)
			{
			case 18u:
				array2 = array;
				num = ((int)num2 * -367903709) ^ 0x7D8E6F02;
				continue;
			case 17u:
				fieldInfo = array2[num3];
				num = 74003427;
				continue;
			case 16u:
				button_5.Enabled = false;
				num = (int)((num2 * 1542956286) ^ 0x73245C63);
				continue;
			case 15u:
				array2[num3].SetValue(Class12.class12_0.class14_0.injectorScrambleOptions_0, false);
				num3++;
				num = 801499988;
				continue;
			case 14u:
			{
				int num4 = (int)((Attribute0)obj).method_0();
				fieldInfo.SetValue(Class12.class12_0.class14_0.injectorScrambleOptions_0, num5 >= num4);
				num = (int)(num2 * 2094900494) ^ -779081180;
				continue;
			}
			case 13u:
				button_5.Enabled = true;
				num = (int)(num2 * 469685797) ^ -1110203276;
				continue;
			case 12u:
				num3++;
				num = 1333476743;
				continue;
			case 11u:
				array2 = array;
				num3 = 0;
				num = (int)((num2 * 1296503411) ^ 0x72B6E272);
				continue;
			case 9u:
			{
				int num6;
				int num7;
				if (obj != null)
				{
					num6 = 1721512633;
					num7 = 1721512633;
				}
				else
				{
					num6 = 2017708180;
					num7 = 2017708180;
				}
				num = num6 ^ (int)(num2 * 292277522);
				continue;
			}
			case 8u:
				num5 = 2 + comboBox_1.SelectedIndex - 1;
				num = (int)((num2 * 1837118451) ^ 0x1DE9E466);
				continue;
			case 7u:
				break;
			case 6u:
				num = ((int)num2 * -373126672) ^ 0xDF9C37;
				continue;
			case 3u:
				goto IL_01a6;
			case 2u:
				num3 = 0;
				num = (int)(num2 * 530455336) ^ -2028983220;
				continue;
			case 1u:
				obj = fieldInfo.GetCustomAttributes(inherit: false).FirstOrDefault((object object_0) => object_0.GetType() == typeof(Attribute0));
				num = 2009770873;
				continue;
			case 0u:
				goto end_IL_0211;
			default:
				return;
			case 5u:
				goto IL_027f;
			case 4u:
				return;
			case 10u:
				return;
			}
			int num8;
			if (num3 < array2.Length)
			{
				num = 37215;
				num8 = 37215;
			}
			else
			{
				num = 1306111333;
				num8 = 1306111333;
			}
			continue;
			IL_01a6:
			int num9;
			if (num3 < array2.Length)
			{
				num = 453309878;
				num9 = 453309878;
			}
			else
			{
				num = 926407722;
				num9 = 926407722;
			}
			continue;
			end_IL_0211:
			break;
		}
		goto IL_020c;
		IL_027f:
		int num10;
		if (comboBox_1.SelectedIndex < comboBox_1.Items.Count - 1)
		{
			num = 2088906825;
			num10 = 2088906825;
		}
		else
		{
			num = 1306111333;
			num10 = 1306111333;
		}
		goto IL_0211;
	}

	internal void method_6(object sender, EventArgs e)
	{
		method_5();
	}

	internal void method_7(object sender, EventArgs e)
	{
		if (MessageBox.Show(Class178.smethod_0(2869), Class178.smethod_0(599), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
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
				Class12.class12_0 = new Class12();
				Class12.smethod_1();
				Class171.smethod_252(this);
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
		Class171.smethod_324(this);
	}

	internal void method_10(object sender, EventArgs e)
	{
		Class171.smethod_209(method_0());
	}

	internal void method_11(object sender, EventArgs e)
	{
		if (!Class12.class12_0.class15_0.bool_2)
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
						MessageBox.Show(Class178.smethod_0(2930), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						num = (int)((num2 * 233957255) ^ 0x12755E55);
						continue;
					case 1u:
						Class12.class12_0.class15_0.bool_2 = true;
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
			openFileDialog.Filter = Class178.smethod_0(497);
			uint num2;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
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
								int num10;
								switch ((num2 = (uint)(num3 ^ -605434328)) % 4)
								{
								case 1u:
								{
									int num11;
									if ((@class.method_6().method_1().method_12() & Enum36.flag_12) == 0)
									{
										num10 = 40628579;
										num11 = 40628579;
									}
									else
									{
										num10 = 29459692;
										num11 = 29459692;
									}
									goto IL_00ef;
								}
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
													injectorScrambleOptions_ = Class12.class12_0.class14_0.injectorScrambleOptions_0;
													num4 = -1291058490;
													continue;
												case 3u:
												{
													int num7;
													int num8;
													if (saveFileDialog.ShowDialog() == DialogResult.OK)
													{
														num7 = 1959171153;
														num8 = 1959171153;
													}
													else
													{
														num7 = 1136902959;
														num8 = 1136902959;
													}
													num4 = num7 ^ (int)(num2 * 1097795143);
													continue;
												}
												case 1u:
													saveFileDialog.InitialDirectory = Path.GetDirectoryName(openFileDialog.FileName);
													saveFileDialog.FileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName) + Class178.smethod_0(3096);
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
																	MessageBox.Show(Class178.smethod_0(3117), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
																	return;
																}
																break;
																IL_02b8:
																Class171.smethod_361(saveFileDialog.FileName, gClass);
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
												int num9 = -226884265;
												while (true)
												{
													switch ((num2 = (uint)(num9 ^ -605434328)) % 3)
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
													num9 = ((int)num2 * -519100131) ^ 0x36A05483;
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
								num3 = num10 ^ ((int)num2 * -5173800);
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
								int num12 = -1176749812;
								while (true)
								{
									switch ((num2 = (uint)(num12 ^ -605434328)) % 3)
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
									num12 = (int)(num2 * 1636820537) ^ -1388513852;
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
					MessageBox.Show(Class178.smethod_0(3186) + ex.Message, Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			num2 = 875182351u;
		}
		finally
		{
			if (openFileDialog != null)
			{
				while (true)
				{
					IL_0453:
					int num13 = -261073156;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num13 ^ -605434328)) % 3)
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
						num13 = (int)(num2 * 316266070) ^ -274923658;
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
				string string_ = Class178.smethod_0(3275);
				Encoding aSCII = Encoding.ASCII;
				Class171.smethod_261(aSCII, gClass, string_);
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
							Class171.smethod_58(gClass, (Stream)memoryStream);
							num = (int)((num2 * 967311158) ^ 0x796A89A4);
							continue;
						case 12u:
							Class171.smethod_261(aSCII, gClass, string_);
							string_2 = Class178.smethod_0(3321);
							encoding_ = Encoding.ASCII;
							Class171.smethod_184(encoding_, gClass, string_2);
							num = (int)((num2 * 1608621453) ^ 0x76E1422);
							continue;
						case 11u:
							Environment.Exit(0);
							num = (int)((num2 * 1753740522) ^ 0x67A8E9CA);
							continue;
						case 10u:
							string_ = Class178.smethod_0(3300);
							num = ((int)num2 * -1341676039) ^ -50678194;
							continue;
						case 9u:
							Class12.smethod_1();
							memoryStream = new MemoryStream();
							num = ((int)num2 * -2079510115) ^ -970640455;
							continue;
						case 8u:
							Class171.smethod_184(encoding_, gClass, string_2);
							text = Class171.smethod_146(Class178.smethod_0(93));
							num = (int)(num2 * 1739945033) ^ -1426810306;
							continue;
						case 7u:
							Process.Start(text, Class171.smethod_311());
							num = (int)((num2 * 279839820) ^ 0x57E4044A);
							continue;
						case 6u:
							encoding_ = Encoding.Unicode;
							num = (int)((num2 * 1165277215) ^ 0x4646E508);
							continue;
						case 5u:
							string_2 = Class178.smethod_0(3321);
							num = (int)(num2 * 27064200) ^ -817821368;
							continue;
						case 4u:
							Class9.smethod_3(memoryStream.ToArray(), text);
							Class171.smethod_285(text);
							num = (int)(num2 * 1578314667) ^ -1618127793;
							continue;
						case 3u:
							string_2 = Class178.smethod_0(3275);
							encoding_ = Encoding.Unicode;
							num = (int)(num2 * 322806409) ^ -2065932608;
							continue;
						case 1u:
							Class171.smethod_184(encoding_, gClass, string_2);
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
						MessageBox.Show(Class178.smethod_0(3334) + ex.Message, Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
		colorDialog_0.Color = Class12.class12_0.class14_0.Color_2;
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
				Class12.class12_0.class14_0.Color_2 = colorDialog_0.Color;
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
		Class171.smethod_252(this);
		num = -1690740026;
		goto IL_0058;
	}

	internal void method_14(object sender, EventArgs e)
	{
		colorDialog_0.Color = Class12.class12_0.class14_0.Color_0;
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
				Class12.class12_0.class14_0.Color_0 = colorDialog_0.Color;
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
		Class171.smethod_252(this);
		num = 1504340079;
		goto IL_0058;
	}

	internal void method_15(object sender, EventArgs e)
	{
		colorDialog_0.Color = Class12.class12_0.class14_0.Color_1;
		while (true)
		{
			int num = 1652796655;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x75A5EA21)) % 4)
				{
				case 2u:
				{
					int num3;
					int num4;
					if (colorDialog_0.ShowDialog() == DialogResult.OK)
					{
						num3 = 2098480816;
						num4 = 2098480816;
					}
					else
					{
						num3 = 660861890;
						num4 = 660861890;
					}
					num = num3 ^ (int)(num2 * 1727397516);
					continue;
				}
				case 1u:
					Class12.class12_0.class14_0.Color_1 = colorDialog_0.Color;
					num = (int)((num2 * 1503459866) ^ 0x6E3B60A0);
					continue;
				case 0u:
					break;
				default:
					Class171.smethod_252(this);
					return;
				}
				break;
			}
		}
	}

	void Form.Dispose(bool disposing)
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
			{
				int num3;
				int num4;
				if (icontainer_0 != null)
				{
					num3 = 1161568117;
					num4 = 1161568117;
				}
				else
				{
					num3 = 1358176602;
					num4 = 1358176602;
				}
				num = num3 ^ ((int)num2 * -265332846);
				continue;
			}
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
		Dispose(disposing);
		num = -842615805;
		goto IL_004d;
	}

	FieldInfo[] method_16()
	{
		return ((Type)(object)this).GetFields();
	}
}
