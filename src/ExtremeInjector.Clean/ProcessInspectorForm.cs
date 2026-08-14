using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public sealed class ProcessInspectorForm : Form
{
	[CompilerGenerated]
	internal RemoteProcess gclass2_0;

	internal IContainer icontainer_0;

	internal Button button_0;

	internal DataGridView dataGridView_0;

	internal Label label_0;

	internal GroupBox groupBox_0;

	internal PictureBox pictureBox_0;

	internal Button button_1;

	internal Timer timer_0;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	internal Button button_2;

	internal TabControl tabControl_0;

	internal TabPage tabPage_0;

	internal TabPage tabPage_1;

	internal DataGridView dataGridView_1;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	internal Button button_3;

	internal Button button_4;

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

	public ProcessInspectorForm()
	{
		Class171.smethod_406(this);
		new Class11(tabControl_0);
	}

	internal void method_2()
	{
		dataGridView_0.Rows.Clear();
		dataGridView_1.Rows.Clear();
		Class69 @class = default(Class69);
		DataGridViewRow dataGridViewRow = default(DataGridViewRow);
		GClass1 current = default(GClass1);
		Class75 current2 = default(Class75);
		DataGridViewRow dataGridViewRow2 = default(DataGridViewRow);
		while (true)
		{
			int num = 1079689502;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3EBECFA2)) % 3)
				{
				case 1u:
					goto IL_0022;
				case 0u:
					break;
				default:
				{
					using (List<GClass1>.Enumerator enumerator = @class.GetEnumerator())
					{
						while (true)
						{
							IL_023a:
							int num3 = ((!enumerator.MoveNext()) ? 639173813 : 2104826547);
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x3EBECFA2)) % 10)
								{
								case 9u:
									num3 = 2104826547;
									continue;
								case 8u:
									dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
									{
										Value = "0x" + current.method_0().ToString("X"),
										Tag = current.method_0().ToInt64()
									});
									num3 = ((int)num2 * -961743698) ^ -2045217925;
									continue;
								case 6u:
									num3 = (current.method_12() ? (-243569838) : (-173658280)) ^ ((int)num2 * -98594269);
									continue;
								case 5u:
									current = enumerator.Current;
									num3 = 1369324496;
									continue;
								case 4u:
									dataGridViewRow = new DataGridViewRow
									{
										Tag = current
									};
									num3 = (int)((num2 * 73226851) ^ 0x10BFB436);
									continue;
								case 3u:
									dataGridView_0.Rows.Add(dataGridViewRow);
									num3 = (int)(num2 * 1905236751) ^ -589127819;
									continue;
								case 1u:
									dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
									{
										Value = Class171.smethod_442(current.method_4()),
										Tag = current.method_4()
									});
									num3 = (int)((num2 * 1556010828) ^ 0x5A6F03E1);
									continue;
								case 0u:
									dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
									{
										Value = current.method_8(),
										Tag = current.method_8()
									});
									num3 = ((int)num2 * -1624413917) ^ 0x714AD670;
									continue;
								default:
									goto end_IL_01f0;
								case 2u:
									break;
								case 7u:
									goto end_IL_01f0;
								}
								goto IL_023a;
								continue;
								end_IL_01f0:
								break;
							}
							break;
						}
					}
					Icon icon = Class171.smethod_11(method_0().FilePath, Enum18.const_1);
					try
					{
						pictureBox_0.BackgroundImage = icon?.ToBitmap();
					}
					finally
					{
						if (icon != null)
						{
							while (true)
							{
								IL_02bf:
								int num4 = 717180417;
								while (true)
								{
									switch ((num2 = (uint)(num4 ^ 0x3EBECFA2)) % 3)
									{
									case 1u:
										goto IL_028c;
									default:
										goto end_IL_02a1;
									case 0u:
										break;
									case 2u:
										goto end_IL_02a1;
									}
									goto IL_02bf;
									IL_028c:
									((IDisposable)icon).Dispose();
									num4 = (int)(num2 * 568451320) ^ -1690526814;
									continue;
									end_IL_02a1:
									break;
								}
								break;
							}
						}
					}
					label_0.Text = string.Format("{0}\n\n{1}\n\nProcess ID: 0x{2:X} ({2})\n\nModules: {3}    Threads: {4}", method_0().Name, method_0().FilePath, method_0().ProcessId, Class171.smethod_42(method_0()).Count, Class171.smethod_179(method_0()).Count);
					using List<Class75>.Enumerator enumerator2 = Class171.smethod_179(method_0()).GetEnumerator();
					while (true)
					{
						int num5 = (enumerator2.MoveNext() ? 990697753 : 644568432);
						while (true)
						{
							switch ((num2 = (uint)(num5 ^ 0x3EBECFA2)) % 6)
							{
							case 5u:
								current2 = enumerator2.Current;
								dataGridViewRow2 = new DataGridViewRow
								{
									Tag = current2
								};
								dataGridViewRow2.Cells.Add(new DataGridViewTextBoxCell
								{
									Value = current2.method_0().ToString(),
									Tag = current2.method_0()
								});
								dataGridViewRow2.Cells.Add(new DataGridViewTextBoxCell
								{
									Value = smethod_0(@class, current2.method_2()),
									Tag = current2.method_2()
								});
								num5 = 861797416;
								continue;
							case 3u:
								dataGridView_1.Rows.Add(dataGridViewRow2);
								num5 = ((int)num2 * -173819140) ^ -1492809243;
								continue;
							case 2u:
								num5 = 990697753;
								continue;
							case 0u:
								dataGridViewRow2.Cells.Add(new DataGridViewTextBoxCell
								{
									Value = Class171.smethod_182(current2.method_7()),
									Tag = current2.method_7()
								});
								num5 = ((int)num2 * -396315488) ^ -1965781529;
								continue;
							default:
								return;
							case 1u:
								break;
							case 4u:
								return;
							}
							break;
						}
					}
				}
				}
				break;
				IL_0022:
				@class = Class171.smethod_42(method_0());
				num = (int)(num2 * 1929385556) ^ -2040208312;
			}
		}
	}

	internal static string smethod_0(IEnumerable<GClass1> ienumerable_0, IntPtr intptr_0)
	{
		IEnumerator<GClass1> enumerator = ienumerable_0.GetEnumerator();
		string result = default(string);
		try
		{
			GClass1 current = default(GClass1);
			uint num4 = default(uint);
			Class152 @class = default(Class152);
			Class152 current2 = default(Class152);
			while (true)
			{
				if (enumerator.MoveNext())
				{
					while (true)
					{
						current = enumerator.Current;
						if ((ulong)(long)intptr_0 < (ulong)(long)current.method_0())
						{
							break;
						}
						int num = 472145156;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num ^ 0x560B19B8)) % 4)
							{
							case 3u:
								num = 1670308201;
								continue;
							case 0u:
								break;
							case 1u:
								goto end_IL_0047;
							default:
								goto IL_0088;
							}
							if ((ulong)(long)intptr_0 > (ulong)((long)current.method_0() + current.method_4()))
							{
								goto end_IL_0069;
							}
							num = ((int)num2 * -821109673) ^ -688514198;
							continue;
							end_IL_0047:
							break;
						}
						continue;
						end_IL_0069:
						break;
					}
					continue;
				}
				int num3 = 1936350653;
				goto IL_0221;
				IL_021c:
				num3 = 671841505;
				goto IL_0221;
				IL_0221:
				switch ((uint)(num3 ^ 0x560B19B8) % 6u)
				{
				case 0u:
					break;
				case 2u:
					goto IL_021c;
				default:
					goto end_IL_0263;
				case 5u:
					continue;
				case 1u:
					result = current.method_8() + "+0x" + num4.ToString("X");
					goto IL_02fe;
				case 3u:
					goto end_IL_0263;
				case 4u:
					goto IL_02fe;
				}
				goto IL_01b6;
				IL_0088:
				List<Class152> list = Class171.smethod_131(current);
				num4 = (uint)((long)intptr_0 - (long)current.method_0());
				@class = null;
				using (List<Class152>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (true)
					{
						IL_0195:
						int num5 = ((!enumerator2.MoveNext()) ? 408886547 : 847219454);
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num5 ^ 0x560B19B8)) % 7)
							{
							case 5u:
								@class = current2;
								num5 = 1678597690;
								continue;
							case 4u:
								num5 = 847219454;
								continue;
							case 3u:
								current2 = enumerator2.Current;
								num5 = ((num4 <= current2.method_6()) ? 1678597690 : 1969053891);
								continue;
							case 2u:
								num5 = ((@class != null) ? 113000516 : 390188438) ^ ((int)num2 * -78067621);
								continue;
							case 1u:
								num5 = ((current2.method_6() > @class.method_6()) ? 134880809 : 44813116) ^ ((int)num2 * -344017330);
								continue;
							default:
								goto end_IL_0158;
							case 0u:
								break;
							case 6u:
								goto end_IL_0158;
							}
							goto IL_0195;
							continue;
							end_IL_0158:
							break;
						}
						break;
					}
				}
				if (@class != null)
				{
					goto IL_01b6;
				}
				goto IL_021c;
				IL_01b6:
				uint num6 = num4 - @class.method_6();
				result = current.method_8() + "!" + ((!@class.method_0()) ? @class.method_2().ToString() : @class.method_4()) + "+0x" + num6.ToString("X");
				num3 = 299249054;
				goto IL_0221;
				continue;
				end_IL_0263:
				break;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_02d5:
					int num7 = 868955022;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num7 ^ 0x560B19B8)) % 3)
						{
						case 2u:
							goto IL_02a3;
						default:
							goto end_IL_02b7;
						case 0u:
							break;
						case 1u:
							goto end_IL_02b7;
						}
						goto IL_02d5;
						IL_02a3:
						enumerator.Dispose();
						num7 = ((int)num2 * -1031815348) ^ 0x3756192C;
						continue;
						end_IL_02b7:
						break;
					}
					break;
				}
			}
		}
		return "0x" + intptr_0.ToString("X");
		IL_02fe:
		return result;
	}

	internal void method_3(object sender, EventArgs e)
	{
		Close();
	}

	internal void method_4(object sender, EventArgs e)
	{
		try
		{
			Class171.smethod_411(method_0());
			while (true)
			{
				int num = -2074048646;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1410434573)) % 3)
					{
					case 1u:
						goto IL_000e;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_000e:
					MessageBox.Show("The process has been successfully terminated.", "Extreme Injector Ex", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					num = (int)(num2 * 174653001) ^ -5123630;
				}
			}
		}
		catch (Exception)
		{
			MessageBox.Show("Extreme Injector Ex was unable to terminate the specified process.", "Extreme Injector Ex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal void method_5(object sender, EventArgs e)
	{
		if (!Class171.HasProcessExited(method_0()))
		{
			goto IL_000d;
		}
		goto IL_0031;
		IL_000d:
		int num = -1009207916;
		goto IL_0012;
		IL_0012:
		switch ((uint)(num ^ -464339707) % 4u)
		{
		case 0u:
			break;
		case 3u:
			goto IL_0031;
		case 1u:
			return;
		default:
		{
			Button button = button_0;
			Button button2 = button_1;
			Button button3 = button_3;
			button_4.Enabled = false;
			button3.Enabled = false;
			button2.Enabled = false;
			button.Enabled = false;
			return;
		}
		}
		goto IL_000d;
		IL_0031:
		timer_0.Stop();
		num = -767225361;
		goto IL_0012;
	}

	internal void method_6(object sender, EventArgs e)
	{
		button_1.Enabled = timer_0.Enabled;
	}

	internal void method_7(object sender, DataGridViewSortCompareEventArgs e)
	{
		DataGridView obj = (DataGridView)sender;
		DataGridViewCell dataGridViewCell = obj[e.Column.Index, e.RowIndex1];
		DataGridViewCell dataGridViewCell2 = obj[e.Column.Index, e.RowIndex2];
		if (!(dataGridViewCell.Tag is IComparable comparable))
		{
			return;
		}
		while (true)
		{
			int num = 1571599917;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1FAE9B90)) % 3)
				{
				case 2u:
					goto IL_0046;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0046:
				e.SortResult = comparable.CompareTo(dataGridViewCell2.Tag);
				e.Handled = true;
				num = (int)((num2 * 1317880195) ^ 0x5CA896E4);
			}
		}
	}

	internal void method_8(object sender, EventArgs e)
	{
		method_2();
		timer_0.Start();
	}

	internal void method_9(object sender, EventArgs e)
	{
		try
		{
			GClass1 gClass = (GClass1)dataGridView_0.SelectedRows[0].Tag;
			if (Class171.smethod_103(gClass, new Class93(method_0())))
			{
				goto IL_0030;
			}
			goto IL_00a6;
			IL_0030:
			int num = 615984725;
			goto IL_0081;
			IL_0081:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x298E9195)) % 5)
				{
				case 4u:
					break;
				case 3u:
					method_2();
					MessageBox.Show(gClass.method_8() + " has been successfully unloaded from the process.", "Extreme Injector Ex", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					num = (int)(num2 * 1446355278) ^ -31155133;
					continue;
				case 1u:
					num = (int)((num2 * 516441638) ^ 0xC1C7ED);
					continue;
				default:
					return;
				case 2u:
					goto IL_00a6;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0030;
			IL_00a6:
			MessageBox.Show(gClass.method_8() + " could not be unloaded from the process.", "Extreme Injector Ex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			num = 2037362985;
			goto IL_0081;
		}
		catch (Exception ex)
		{
			MessageBox.Show("An error occurred when attempting to unload the specified module:\n\n" + ex.Message, "Extreme Injector Ex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal void method_10(object sender, EventArgs e)
	{
		Button button = button_3;
		bool enabled = (button_4.Enabled = timer_0.Enabled);
		button.Enabled = enabled;
		while (true)
		{
			int num = 1380314093;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x30B4587)) % 4)
				{
				case 2u:
					num = ((!timer_0.Enabled) ? (-598167744) : (-743784286)) ^ ((int)num2 * -1603810802);
					continue;
				case 1u:
					Class171.smethod_88(this);
					num = ((int)num2 * -1297105286) ^ 0x7A03EF86;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	internal void method_11(object sender, EventArgs e)
	{
		Class75 class75_ = (Class75)dataGridView_1.SelectedRows[0].Tag;
		bool flag;
		if (!(flag = button_3.Text == "Resume"))
		{
			goto IL_0095;
		}
		bool num = Class171.smethod_97(class75_);
		goto IL_012b;
		IL_011c:
		num = Class171.smethod_300(class75_);
		goto IL_012b;
		IL_012b:
		if (num)
		{
			goto IL_0045;
		}
		int num2 = 312454150;
		goto IL_00e6;
		IL_0095:
		num2 = 1484077775;
		goto IL_00e6;
		IL_00e6:
		while (true)
		{
			switch ((uint)(num2 ^ 0x44FB4084) % 6u)
			{
			case 4u:
				break;
			case 5u:
				Class171.smethod_88(this);
				num2 = 1699181933;
				continue;
			case 2u:
				goto IL_0095;
			case 0u:
				MessageBox.Show("Unable to " + (flag ? "resume" : "suspend") + " the selected thread.", "Extreme Injector Ex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				num2 = 2093860131;
				continue;
			default:
				return;
			case 1u:
				goto IL_011c;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0045;
		IL_0045:
		MessageBox.Show("The selected thread has been " + ((!flag) ? "suspended" : "resumed") + " successfully.", "Extreme Injector Ex", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		num2 = 2093860131;
		goto IL_00e6;
	}

	internal void method_12(object sender, EventArgs e)
	{
		if (!Class171.smethod_74((Class75)dataGridView_1.SelectedRows[0].Tag))
		{
			goto IL_0022;
		}
		goto IL_0078;
		IL_0022:
		int num = -1029997403;
		goto IL_0053;
		IL_0053:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -666740338)) % 5)
			{
			case 4u:
				break;
			case 3u:
				MessageBox.Show("Extreme Injector Ex was unable to terminate the selected thread.", "Extreme Injector Ex", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				num = (int)(num2 * 354435775) ^ -677172765;
				continue;
			default:
				return;
			case 1u:
				goto IL_0078;
			case 0u:
				return;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0022;
		IL_0078:
		MessageBox.Show("The selected thread has been terminated successfully.", "Extreme Injector Ex", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		num = -1446707801;
		goto IL_0053;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0048;
		}
		goto IL_0072;
		IL_0048:
		int num = 1868565375;
		goto IL_004d;
		IL_004d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x3CB1E8EC)) % 5)
			{
			case 2u:
				icontainer_0.Dispose();
				num = (int)((num2 * 447977154) ^ 0xFF48042);
				continue;
			case 1u:
				num = ((icontainer_0 == null) ? 417993808 : 388882196) ^ ((int)num2 * -1736371094);
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_0072;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0048;
		IL_0072:
		base.Dispose(disposing);
		num = 1205798872;
		goto IL_004d;
	}

	internal static DataGridViewRowCollection smethod_1(DataGridView dataGridView_2)
	{
		return dataGridView_2.Rows;
	}

	internal static void smethod_2(DataGridViewRowCollection dataGridViewRowCollection_0)
	{
		dataGridViewRowCollection_0.Clear();
	}

	internal static DataGridViewRow smethod_3()
	{
		return new DataGridViewRow();
	}

	internal static void smethod_4(DataGridViewBand dataGridViewBand_0, object object_0)
	{
		dataGridViewBand_0.Tag = object_0;
	}

	internal static DataGridViewCellCollection smethod_5(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.Cells;
	}

	internal static DataGridViewTextBoxCell smethod_6()
	{
		return new DataGridViewTextBoxCell();
	}

	internal static void smethod_7(DataGridViewCell dataGridViewCell_0, object object_0)
	{
		dataGridViewCell_0.Value = object_0;
	}

	internal static void smethod_8(DataGridViewCell dataGridViewCell_0, object object_0)
	{
		dataGridViewCell_0.Tag = object_0;
	}

	internal static int smethod_9(DataGridViewCellCollection dataGridViewCellCollection_0, DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCellCollection_0.Add(dataGridViewCell_0);
	}

	internal static void smethod_10(Form form_0)
	{
		form_0.Close();
	}

	internal static DialogResult smethod_11(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	internal static void smethod_12(Timer timer_1)
	{
		timer_1.Stop();
	}

	internal static void smethod_13(Control control_0, bool bool_0)
	{
		control_0.Enabled = bool_0;
	}

	internal static bool smethod_14(Timer timer_1)
	{
		return timer_1.Enabled;
	}

	internal static DataGridViewColumn smethod_15(DataGridViewSortCompareEventArgs dataGridViewSortCompareEventArgs_0)
	{
		return dataGridViewSortCompareEventArgs_0.Column;
	}

	internal static int smethod_16(DataGridViewBand dataGridViewBand_0)
	{
		return dataGridViewBand_0.Index;
	}

	internal static int smethod_17(DataGridViewSortCompareEventArgs dataGridViewSortCompareEventArgs_0)
	{
		return dataGridViewSortCompareEventArgs_0.RowIndex1;
	}

	internal static DataGridViewCell smethod_18(DataGridView dataGridView_2, int int_0, int int_1)
	{
		return dataGridView_2[int_0, int_1];
	}

	internal static int smethod_19(DataGridViewSortCompareEventArgs dataGridViewSortCompareEventArgs_0)
	{
		return dataGridViewSortCompareEventArgs_0.RowIndex2;
	}

	internal static object smethod_20(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.Tag;
	}

	internal static int smethod_21(IComparable icomparable_0, object object_0)
	{
		return icomparable_0.CompareTo(object_0);
	}

	internal static void smethod_22(DataGridViewSortCompareEventArgs dataGridViewSortCompareEventArgs_0, int int_0)
	{
		dataGridViewSortCompareEventArgs_0.SortResult = int_0;
	}

	internal static void smethod_23(HandledEventArgs handledEventArgs_0, bool bool_0)
	{
		handledEventArgs_0.Handled = bool_0;
	}

	internal static void smethod_24(Timer timer_1)
	{
		timer_1.Start();
	}

	internal static DataGridViewSelectedRowCollection smethod_25(DataGridView dataGridView_2)
	{
		return dataGridView_2.SelectedRows;
	}

	internal static DataGridViewRow smethod_26(DataGridViewSelectedRowCollection dataGridViewSelectedRowCollection_0, int int_0)
	{
		return dataGridViewSelectedRowCollection_0[int_0];
	}

	internal static object smethod_27(DataGridViewBand dataGridViewBand_0)
	{
		return dataGridViewBand_0.Tag;
	}

	internal static string smethod_28(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	internal static string smethod_29(Exception exception_0)
	{
		return exception_0.Message;
	}

	internal static string smethod_30(Control control_0)
	{
		return control_0.Text;
	}

	internal static bool smethod_31(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	internal static string smethod_32(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	internal static void smethod_33(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
