using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed class Form0 : Form
{
	[CompilerGenerated]
	private Class16 class16_0;

	[CompilerGenerated]
	private Class154 class154_0;

	private IContainer icontainer_0;

	internal GroupBox groupBox_0;

	internal ComboBox comboBox_0;

	internal Label label_0;

	internal Label label_1;

	internal DataGridView dataGridView_0;

	internal Label label_2;

	internal ComboBox comboBox_1;

	internal Button button_0;

	internal TextBox textBox_0;

	internal ComboBox comboBox_2;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	[SpecialName]
	[CompilerGenerated]
	internal Class16 method_0()
	{
		return class16_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(Class16 class16_1)
	{
		class16_0 = class16_1;
	}

	[SpecialName]
	[CompilerGenerated]
	private Class154 method_2()
	{
		return class154_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(Class154 class154_1)
	{
		class154_0 = class154_1;
	}

	public Form0()
	{
		Class171.smethod_22(this);
	}

	internal void method_4(object sender, EventArgs e)
	{
		comboBox_0.Items.Add(Class178.smethod_0(394));
		int selectedIndex = default(int);
		Class152 current = default(Class152);
		Class17 current2 = default(Class17);
		while (true)
		{
			int num = -219746061;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -880575615)) % 4)
				{
				case 3u:
					if (method_2().method_14() != null)
					{
						num = (int)((num2 * 1438130231) ^ 0x53483049);
						continue;
					}
					goto IL_01b2;
				case 2u:
					selectedIndex = 0;
					num = (int)(num2 * 1912274277) ^ -1480732588;
					continue;
				case 0u:
					break;
				default:
					{
						using (List<Class152>.Enumerator enumerator = method_2().method_14().list_1.GetEnumerator())
						{
							while (true)
							{
								IL_0194:
								int num3;
								int num4;
								if (enumerator.MoveNext())
								{
									num3 = -558416422;
									num4 = -558416422;
								}
								else
								{
									num3 = -1205422416;
									num4 = -1205422416;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -880575615)) % 7)
									{
									case 6u:
										current = enumerator.Current;
										num3 = -594253350;
										continue;
									case 4u:
									{
										comboBox_0.Items.Add(current.method_4());
										int num7;
										int num8;
										if (current.method_4() == method_0().string_1)
										{
											num7 = -1627027615;
											num8 = -1627027615;
										}
										else
										{
											num7 = -446458686;
											num8 = -446458686;
										}
										num3 = num7 ^ (int)(num2 * 1984859475);
										continue;
									}
									case 3u:
										selectedIndex = comboBox_0.Items.Count - 1;
										num3 = ((int)num2 * -1565894139) ^ 0x294815BA;
										continue;
									case 1u:
									{
										int num5;
										int num6;
										if (!current.method_0())
										{
											num5 = 1586744110;
											num6 = 1586744110;
										}
										else
										{
											num5 = 1991350857;
											num6 = 1991350857;
										}
										num3 = num5 ^ ((int)num2 * -1222969250);
										continue;
									}
									case 0u:
										num3 = -558416422;
										continue;
									default:
										goto end_IL_0157;
									case 2u:
										break;
									case 5u:
										goto end_IL_0157;
									}
									goto IL_0194;
									continue;
									end_IL_0157:
									break;
								}
								break;
							}
						}
						goto IL_01b2;
					}
					IL_01b2:
					comboBox_0.SelectedIndex = selectedIndex;
					comboBox_1.Items.Add(Class178.smethod_0(395));
					while (true)
					{
						int num9 = -1090224113;
						while (true)
						{
							switch ((num2 = (uint)(num9 ^ -880575615)) % 19)
							{
							case 18u:
								comboBox_2.Items.Add(Class178.smethod_0(479));
								num9 = ((int)num2 * -1559685076) ^ 0x2AAF2DE2;
								continue;
							case 17u:
								comboBox_1.SelectedIndex = 2;
								num9 = ((int)num2 * -1682805343) ^ -888335665;
								continue;
							case 16u:
							{
								int num14;
								int num15;
								if (method_0().callingConvention_0 != 0)
								{
									num14 = -943580251;
									num15 = -943580251;
								}
								else
								{
									num14 = -229270540;
									num15 = -229270540;
								}
								num9 = num14 ^ (int)(num2 * 654463414);
								continue;
							}
							case 15u:
								comboBox_1.Items.Add(Class178.smethod_0(417));
								num9 = ((int)num2 * -337876557) ^ 0x1D2162E2;
								continue;
							case 14u:
							{
								int num17;
								if (method_0().callingConvention_0 == CallingConvention.Cdecl)
								{
									num9 = -1461955806;
									num17 = -1461955806;
								}
								else
								{
									num9 = -1891489375;
									num17 = -1891489375;
								}
								continue;
							}
							case 13u:
							{
								int num18;
								int num19;
								if (method_0().list_0 == null)
								{
									num18 = 1792036083;
									num19 = 1792036083;
								}
								else
								{
									num18 = 6450968;
									num19 = 6450968;
								}
								num9 = num18 ^ ((int)num2 * -237178418);
								continue;
							}
							case 12u:
								comboBox_1.Items.Add(Class178.smethod_0(408));
								num9 = ((int)num2 * -1117680441) ^ -1434670704;
								continue;
							case 11u:
								num9 = (int)(num2 * 1608728107) ^ -932300848;
								continue;
							case 10u:
								comboBox_2.Items.Add(Class178.smethod_0(488));
								num9 = ((int)num2 * -1421628372) ^ 0x7DE74003;
								continue;
							case 7u:
							{
								int num16;
								if (method_0().callingConvention_0 == CallingConvention.FastCall)
								{
									num9 = -1363730;
									num16 = -1363730;
								}
								else
								{
									num9 = -340801925;
									num16 = -340801925;
								}
								continue;
							}
							case 6u:
								comboBox_2.Items.Add(Class178.smethod_0(470));
								num9 = (int)((num2 * 1268467148) ^ 0x526E179C);
								continue;
							case 5u:
								comboBox_1.SelectedIndex = 0;
								num9 = -340801925;
								continue;
							case 4u:
								comboBox_1.SelectedIndex = 0;
								num9 = (int)((num2 * 2007912271) ^ 0x449AB0B0);
								continue;
							case 2u:
							{
								int num12;
								int num13;
								if (method_0().callingConvention_0 == CallingConvention.StdCall)
								{
									num12 = 1377154188;
									num13 = 1377154188;
								}
								else
								{
									num12 = 303533518;
									num13 = 303533518;
								}
								num9 = num12 ^ (int)(num2 * 1400031935);
								continue;
							}
							case 1u:
								comboBox_2.Items.Add(Class178.smethod_0(430));
								comboBox_2.Items.Add(Class178.smethod_0(439));
								comboBox_2.Items.Add(Class178.smethod_0(452));
								comboBox_2.Items.Add(Class178.smethod_0(461));
								num9 = -176907944;
								continue;
							case 0u:
								comboBox_1.SelectedIndex = 1;
								num9 = ((int)num2 * -1647404153) ^ 0x455CD88E;
								continue;
							case 9u:
								break;
							case 3u:
								return;
							default:
							{
								using List<Class17>.Enumerator enumerator2 = method_0().list_0.GetEnumerator();
								while (true)
								{
									int num10;
									int num11;
									if (!enumerator2.MoveNext())
									{
										num10 = -93580133;
										num11 = -93580133;
									}
									else
									{
										num10 = -616727158;
										num11 = -616727158;
									}
									while (true)
									{
										switch ((num2 = (uint)(num10 ^ -880575615)) % 5)
										{
										case 4u:
											num10 = -616727158;
											continue;
										case 3u:
											current2 = enumerator2.Current;
											num10 = -258485167;
											continue;
										case 2u:
											Class171.smethod_336(this, current2.string_0, current2.enum5_0, false);
											num10 = ((int)num2 * -1607316244) ^ 0x4896AA15;
											continue;
										default:
											return;
										case 1u:
											break;
										case 0u:
											return;
										}
										break;
									}
								}
							}
							}
							break;
						}
					}
				}
				break;
			}
		}
	}

	internal void method_5(object sender, EventArgs e)
	{
		bool flag = comboBox_0.SelectedIndex != 0;
		ComboBox comboBox = comboBox_1;
		DataGridView dataGridView = dataGridView_0;
		ComboBox comboBox2 = comboBox_2;
		TextBox textBox = textBox_0;
		bool flag2 = (button_0.Enabled = flag);
		bool flag4 = (textBox.Enabled = flag2);
		bool flag6 = (comboBox2.Enabled = flag4);
		bool enabled = (dataGridView.Enabled = flag6);
		comboBox.Enabled = enabled;
		method_0().string_1 = ((comboBox_0.SelectedIndex != 0) ? comboBox_0.SelectedItem.ToString() : string.Empty);
	}

	internal void method_6(object sender, EventArgs e)
	{
		if (comboBox_1.SelectedIndex == 0)
		{
			goto IL_001f;
		}
		goto IL_00e1;
		IL_001f:
		int num = 1331055496;
		goto IL_009c;
		IL_009c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6A7E140F)) % 9)
			{
			case 8u:
				break;
			case 6u:
				goto IL_0026;
			case 4u:
				method_0().callingConvention_0 = CallingConvention.StdCall;
				num = ((int)num2 * -469334512) ^ -170244121;
				continue;
			case 3u:
				method_0().callingConvention_0 = CallingConvention.Cdecl;
				num = (int)((num2 * 462020655) ^ 0x297F4B08);
				continue;
			case 0u:
				method_0().callingConvention_0 = CallingConvention.FastCall;
				num = (int)((num2 * 1106634793) ^ 0x2E8A28F0);
				continue;
			default:
				return;
			case 1u:
				goto IL_00e1;
			case 2u:
				return;
			case 5u:
				return;
			case 7u:
				return;
			}
			break;
			IL_0026:
			int num3;
			if (comboBox_1.SelectedIndex != 2)
			{
				num = 835743471;
				num3 = 835743471;
			}
			else
			{
				num = 648360200;
				num3 = 648360200;
			}
		}
		goto IL_001f;
		IL_00e1:
		int num4;
		if (comboBox_1.SelectedIndex != 1)
		{
			num = 1024556359;
			num4 = 1024556359;
		}
		else
		{
			num = 1796553505;
			num4 = 1796553505;
		}
		goto IL_009c;
	}

	internal void method_7(object sender, EventArgs e)
	{
		if (comboBox_2.SelectedIndex == -1)
		{
			goto IL_0037;
		}
		goto IL_006d;
		IL_0037:
		int num = 446463276;
		goto IL_003c;
		IL_003c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x560A11F5)) % 5)
			{
			case 4u:
				textBox_0.ResetText();
				num = (int)(num2 * 768341863) ^ -206211775;
				continue;
			case 2u:
				break;
			default:
				return;
			case 0u:
				goto IL_006d;
			case 1u:
				return;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0037;
		IL_006d:
		int num3;
		if (!Class171.smethod_336(this, textBox_0.Text, (Enum5)comboBox_2.SelectedIndex, true))
		{
			num = 692908412;
			num3 = 692908412;
		}
		else
		{
			num = 1795704142;
			num3 = 1795704142;
		}
		goto IL_003c;
	}

	internal void method_8(object sender, DataGridViewRowsAddedEventArgs e)
	{
		int num = 0;
		IEnumerator enumerator = ((IEnumerable)dataGridView_0.Rows).GetEnumerator();
		try
		{
			while (true)
			{
				int num2;
				int num3;
				if (enumerator.MoveNext())
				{
					num2 = 1240011439;
					num3 = 1240011439;
				}
				else
				{
					num2 = 207731885;
					num3 = 207731885;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ 0x3BF45DC1)) % 4)
					{
					case 3u:
						num2 = 1240011439;
						continue;
					case 2u:
					{
						DataGridViewCell dataGridViewCell = ((DataGridViewRow)enumerator.Current).Cells[0];
						int num5 = num + 1;
						num = num5;
						dataGridViewCell.Value = num5.ToString();
						num2 = 154553916;
						continue;
					}
					default:
						return;
					case 1u:
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
			IDisposable disposable = enumerator as IDisposable;
			while (true)
			{
				IL_00f5:
				int num6 = 1606165727;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num6 ^ 0x3BF45DC1)) % 4)
					{
					case 2u:
					{
						int num7;
						int num8;
						if (disposable != null)
						{
							num7 = -162674348;
							num8 = -162674348;
						}
						else
						{
							num7 = -1159836990;
							num8 = -1159836990;
						}
						num6 = num7 ^ ((int)num4 * -371359576);
						continue;
					}
					case 1u:
						disposable.Dispose();
						num6 = ((int)num4 * -1501701826) ^ -81955196;
						continue;
					default:
						goto end_IL_00d3;
					case 0u:
						break;
					case 3u:
						goto end_IL_00d3;
					}
					goto IL_00f5;
					continue;
					end_IL_00d3:
					break;
				}
				break;
			}
		}
	}

	internal void method_9(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		method_0().list_0.RemoveAt(e.RowIndex);
		int num = 0;
		IEnumerator enumerator = ((IEnumerable)dataGridView_0.Rows).GetEnumerator();
		try
		{
			while (true)
			{
				int num2;
				int num3;
				if (!enumerator.MoveNext())
				{
					num2 = 30818418;
					num3 = 30818418;
				}
				else
				{
					num2 = 1831287923;
					num3 = 1831287923;
				}
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num2 ^ 0x336090FD)) % 4)
					{
					case 2u:
					{
						DataGridViewCell dataGridViewCell = ((DataGridViewRow)enumerator.Current).Cells[0];
						int num5 = num + 1;
						num = num5;
						dataGridViewCell.Value = num5.ToString();
						num2 = 1239756624;
						continue;
					}
					case 0u:
						num2 = 1831287923;
						continue;
					default:
						return;
					case 1u:
						break;
					case 3u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				while (true)
				{
					IL_00e5:
					int num6 = 1972137218;
					while (true)
					{
						uint num4;
						switch ((num4 = (uint)(num6 ^ 0x336090FD)) % 3)
						{
						case 1u:
							goto IL_00b3;
						default:
							goto end_IL_00c7;
						case 0u:
							break;
						case 2u:
							goto end_IL_00c7;
						}
						goto IL_00e5;
						IL_00b3:
						disposable.Dispose();
						num6 = ((int)num4 * -464910156) ^ -401306699;
						continue;
						end_IL_00c7:
						break;
					}
					break;
				}
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			while (true)
			{
				int num = 318956064;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x4C2FBCD9)) % 4)
					{
					case 2u:
						icontainer_0.Dispose();
						num = ((int)num2 * -736360242) ^ 0x3AC62C72;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if (icontainer_0 != null)
						{
							num3 = -204063474;
							num4 = -204063474;
						}
						else
						{
							num3 = -2124255189;
							num4 = -2124255189;
						}
						num = num3 ^ (int)(num2 * 669983437);
						continue;
					}
					case 0u:
						break;
					default:
						goto end_IL_0067;
					}
					break;
				}
				continue;
				end_IL_0067:
				break;
			}
		}
		base.Dispose(disposing);
	}
}
