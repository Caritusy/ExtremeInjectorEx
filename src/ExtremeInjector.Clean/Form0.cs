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
	internal ModuleEntry class16_0;

	[CompilerGenerated]
	internal Class154 class154_0;

	internal IContainer icontainer_0;

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
	internal ModuleEntry method_0()
	{
		return class16_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(ModuleEntry class16_1)
	{
		class16_0 = class16_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal Class154 method_2()
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
		comboBox_0.Items.Add("");
		int selectedIndex = default(int);
		Class152 current = default(Class152);
		ExportParameter current2 = default(ExportParameter);
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
								int num3 = ((!enumerator.MoveNext()) ? (-1205422416) : (-558416422));
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -880575615)) % 7)
									{
									case 6u:
										current = enumerator.Current;
										num3 = -594253350;
										continue;
									case 4u:
										comboBox_0.Items.Add(current.method_4());
										num3 = ((!(current.method_4() == method_0().ExportName)) ? (-446458686) : (-1627027615)) ^ (int)(num2 * 1984859475);
										continue;
									case 3u:
										selectedIndex = comboBox_0.Items.Count - 1;
										num3 = ((int)num2 * -1565894139) ^ 0x294815BA;
										continue;
									case 1u:
										num3 = (current.method_0() ? 1991350857 : 1586744110) ^ ((int)num2 * -1222969250);
										continue;
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
					comboBox_1.Items.Add("StdCall");
					while (true)
					{
						int num4 = -1090224113;
						while (true)
						{
							switch ((num2 = (uint)(num4 ^ -880575615)) % 19)
							{
							case 18u:
								comboBox_2.Items.Add("QWORD");
								num4 = ((int)num2 * -1559685076) ^ 0x2AAF2DE2;
								continue;
							case 17u:
								comboBox_1.SelectedIndex = 2;
								num4 = ((int)num2 * -1682805343) ^ -888335665;
								continue;
							case 16u:
								num4 = ((method_0().CallingConvention == (CallingConvention)0) ? (-229270540) : (-943580251)) ^ (int)(num2 * 654463414);
								continue;
							case 15u:
								comboBox_1.Items.Add("FastCall");
								num4 = ((int)num2 * -337876557) ^ 0x1D2162E2;
								continue;
							case 14u:
								num4 = ((method_0().CallingConvention != CallingConvention.Cdecl) ? (-1891489375) : (-1461955806));
								continue;
							case 13u:
								num4 = ((method_0().Parameters != null) ? 6450968 : 1792036083) ^ ((int)num2 * -237178418);
								continue;
							case 12u:
								comboBox_1.Items.Add("Cdecl");
								num4 = ((int)num2 * -1117680441) ^ -1434670704;
								continue;
							case 11u:
								num4 = (int)(num2 * 1608728107) ^ -932300848;
								continue;
							case 10u:
								comboBox_2.Items.Add("FLOAT");
								num4 = ((int)num2 * -1421628372) ^ 0x7DE74003;
								continue;
							case 7u:
								num4 = ((method_0().CallingConvention != CallingConvention.FastCall) ? (-340801925) : (-1363730));
								continue;
							case 6u:
								comboBox_2.Items.Add("DWORD");
								num4 = (int)((num2 * 1268467148) ^ 0x526E179C);
								continue;
							case 5u:
								comboBox_1.SelectedIndex = 0;
								num4 = -340801925;
								continue;
							case 4u:
								comboBox_1.SelectedIndex = 0;
								num4 = (int)((num2 * 2007912271) ^ 0x449AB0B0);
								continue;
							case 2u:
								num4 = ((method_0().CallingConvention != CallingConvention.StdCall) ? 303533518 : 1377154188) ^ (int)(num2 * 1400031935);
								continue;
							case 1u:
								comboBox_2.Items.Add("LPCSTR");
								comboBox_2.Items.Add("LPCWSTR");
								comboBox_2.Items.Add("BYTE");
								comboBox_2.Items.Add("WORD");
								num4 = -176907944;
								continue;
							case 0u:
								comboBox_1.SelectedIndex = 1;
								num4 = ((int)num2 * -1647404153) ^ 0x455CD88E;
								continue;
							case 9u:
								break;
							case 3u:
								return;
							default:
							{
								using List<ExportParameter>.Enumerator enumerator2 = method_0().Parameters.GetEnumerator();
								while (true)
								{
									int num5 = (enumerator2.MoveNext() ? (-616727158) : (-93580133));
									while (true)
									{
										switch ((num2 = (uint)(num5 ^ -880575615)) % 5)
										{
										case 4u:
											num5 = -616727158;
											continue;
										case 3u:
											current2 = enumerator2.Current;
											num5 = -258485167;
											continue;
										case 2u:
											Class171.smethod_342(this, current2.Value, current2.Type, bool_0: false);
											num5 = ((int)num2 * -1607316244) ^ 0x4896AA15;
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
		method_0().ExportName = ((comboBox_0.SelectedIndex != 0) ? comboBox_0.SelectedItem.ToString() : string.Empty);
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
				method_0().CallingConvention = CallingConvention.StdCall;
				num = ((int)num2 * -469334512) ^ -170244121;
				continue;
			case 3u:
				method_0().CallingConvention = CallingConvention.Cdecl;
				num = (int)((num2 * 462020655) ^ 0x297F4B08);
				continue;
			case 0u:
				method_0().CallingConvention = CallingConvention.FastCall;
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
			num = ((comboBox_1.SelectedIndex == 2) ? 648360200 : 835743471);
		}
		goto IL_001f;
		IL_00e1:
		num = ((comboBox_1.SelectedIndex == 1) ? 1796553505 : 1024556359);
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
		num = (Class171.smethod_342(this, textBox_0.Text, (Enum5)comboBox_2.SelectedIndex, bool_0: true) ? 1795704142 : 692908412);
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
				int num2 = ((!enumerator.MoveNext()) ? 207731885 : 1240011439);
				while (true)
				{
					switch ((uint)(num2 ^ 0x3BF45DC1) % 4u)
					{
					case 3u:
						num2 = 1240011439;
						continue;
					case 2u:
					{
						DataGridViewCell dataGridViewCell = ((DataGridViewRow)enumerator.Current).Cells[0];
						int num3 = num + 1;
						num = num3;
						dataGridViewCell.Value = num3.ToString();
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
				int num4 = 1606165727;
				while (true)
				{
					uint num5;
					switch ((num5 = (uint)(num4 ^ 0x3BF45DC1)) % 4)
					{
					case 2u:
						num4 = ((disposable == null) ? (-1159836990) : (-162674348)) ^ ((int)num5 * -371359576);
						continue;
					case 1u:
						disposable.Dispose();
						num4 = ((int)num5 * -1501701826) ^ -81955196;
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
		method_0().Parameters.RemoveAt(e.RowIndex);
		int num = 0;
		IEnumerator enumerator = ((IEnumerable)dataGridView_0.Rows).GetEnumerator();
		try
		{
			while (true)
			{
				int num2 = (enumerator.MoveNext() ? 1831287923 : 30818418);
				while (true)
				{
					switch ((uint)(num2 ^ 0x336090FD) % 4u)
					{
					case 2u:
					{
						DataGridViewCell dataGridViewCell = ((DataGridViewRow)enumerator.Current).Cells[0];
						int num3 = num + 1;
						num = num3;
						dataGridViewCell.Value = num3.ToString();
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
					int num4 = 1972137218;
					while (true)
					{
						uint num5;
						switch ((num5 = (uint)(num4 ^ 0x336090FD)) % 3)
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
						num4 = ((int)num5 * -464910156) ^ -401306699;
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
						num = ((icontainer_0 == null) ? (-2124255189) : (-204063474)) ^ (int)(num2 * 669983437);
						continue;
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

	internal static ComboBox.ObjectCollection smethod_0(ComboBox comboBox_3)
	{
		return comboBox_3.Items;
	}

	internal static int smethod_1(ComboBox.ObjectCollection objectCollection_0, object object_0)
	{
		return objectCollection_0.Add(object_0);
	}

	internal static bool smethod_2(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	internal static int smethod_3(ComboBox.ObjectCollection objectCollection_0)
	{
		return objectCollection_0.Count;
	}

	internal static void smethod_4(ListControl listControl_0, int int_0)
	{
		listControl_0.SelectedIndex = int_0;
	}

	internal static int smethod_5(ListControl listControl_0)
	{
		return listControl_0.SelectedIndex;
	}

	internal static void smethod_6(Control control_0, bool bool_0)
	{
		control_0.Enabled = bool_0;
	}

	internal static object smethod_7(ComboBox comboBox_3)
	{
		return comboBox_3.SelectedItem;
	}

	internal static string smethod_8(object object_0)
	{
		return object_0.ToString();
	}

	internal static string smethod_9(Control control_0)
	{
		return control_0.Text;
	}

	internal static void smethod_10(Control control_0)
	{
		control_0.ResetText();
	}

	internal static DataGridViewRowCollection smethod_11(DataGridView dataGridView_1)
	{
		return dataGridView_1.Rows;
	}

	internal static IEnumerator smethod_12(IEnumerable ienumerable_0)
	{
		return ienumerable_0.GetEnumerator();
	}

	internal static object smethod_13(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	internal static DataGridViewCellCollection smethod_14(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.Cells;
	}

	internal static DataGridViewCell smethod_15(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0[int_0];
	}

	internal static int smethod_16(DataGridViewRowsRemovedEventArgs dataGridViewRowsRemovedEventArgs_0)
	{
		return dataGridViewRowsRemovedEventArgs_0.RowIndex;
	}

	internal static void smethod_17(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
