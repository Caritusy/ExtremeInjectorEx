using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal sealed class Form4 : Form
{
	[CompilerGenerated]
	private GClass2 gclass2_0;

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

	public Form4()
	{
		Class171.smethod_398(this);
		new Class11(tabControl_0);
	}

	private void method_2()
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
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 2104826547;
								num4 = 2104826547;
							}
							else
							{
								num3 = 639173813;
								num4 = 639173813;
							}
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
										Value = Class178.smethod_0(2072) + current.method_0().ToString(Class178.smethod_0(2077)),
										Tag = current.method_0().ToInt64()
									});
									num3 = ((int)num2 * -961743698) ^ -2045217925;
									continue;
								case 6u:
								{
									int num5;
									int num6;
									if (!current.method_12())
									{
										num5 = -173658280;
										num6 = -173658280;
									}
									else
									{
										num5 = -243569838;
										num6 = -243569838;
									}
									num3 = num5 ^ ((int)num2 * -98594269);
									continue;
								}
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
										Value = Class171.smethod_433((long)current.method_4()),
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
					Icon icon = Class171.smethod_11(method_0().method_4(), Enum18.const_1);
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
								int num7 = 717180417;
								while (true)
								{
									switch ((num2 = (uint)(num7 ^ 0x3EBECFA2)) % 3)
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
									num7 = (int)(num2 * 568451320) ^ -1690526814;
									continue;
									end_IL_02a1:
									break;
								}
								break;
							}
						}
					}
					label_0.Text = string.Format(Class178.smethod_0(2082), method_0().method_2(), method_0().method_4(), method_0().method_0(), Class171.smethod_42(method_0()).Count, Class171.smethod_178(method_0()).Count);
					using List<Class75>.Enumerator enumerator2 = Class171.smethod_178(method_0()).GetEnumerator();
					while (true)
					{
						int num8;
						int num9;
						if (!enumerator2.MoveNext())
						{
							num8 = 644568432;
							num9 = 644568432;
						}
						else
						{
							num8 = 990697753;
							num9 = 990697753;
						}
						while (true)
						{
							switch ((num2 = (uint)(num8 ^ 0x3EBECFA2)) % 6)
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
								num8 = 861797416;
								continue;
							case 3u:
								dataGridView_1.Rows.Add(dataGridViewRow2);
								num8 = ((int)num2 * -173819140) ^ -1492809243;
								continue;
							case 2u:
								num8 = 990697753;
								continue;
							case 0u:
								dataGridViewRow2.Cells.Add(new DataGridViewTextBoxCell
								{
									Value = Class171.smethod_181(current2.method_7()),
									Tag = current2.method_7()
								});
								num8 = ((int)num2 * -396315488) ^ -1965781529;
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

	private static string smethod_0(IEnumerable<GClass1> ienumerable_0, IntPtr intptr_0)
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
				uint num2;
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
				switch ((num2 = (uint)(num3 ^ 0x560B19B8)) % 6)
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
					result = current.method_8() + Class178.smethod_0(2171) + num4.ToString(Class178.smethod_0(2077));
					goto IL_02fe;
				case 3u:
					goto end_IL_0263;
				case 4u:
					goto IL_02fe;
				}
				goto IL_01b6;
				IL_0088:
				List<Class152> list = Class171.smethod_130(current);
				num4 = (uint)((long)intptr_0 - (long)current.method_0());
				@class = null;
				using (List<Class152>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (true)
					{
						IL_0195:
						int num5;
						int num6;
						if (enumerator2.MoveNext())
						{
							num5 = 847219454;
							num6 = 847219454;
						}
						else
						{
							num5 = 408886547;
							num6 = 408886547;
						}
						while (true)
						{
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
							{
								current2 = enumerator2.Current;
								int num9;
								if (num4 > current2.method_6())
								{
									num5 = 1969053891;
									num9 = 1969053891;
								}
								else
								{
									num5 = 1678597690;
									num9 = 1678597690;
								}
								continue;
							}
							case 2u:
							{
								int num10;
								int num11;
								if (@class == null)
								{
									num10 = 390188438;
									num11 = 390188438;
								}
								else
								{
									num10 = 113000516;
									num11 = 113000516;
								}
								num5 = num10 ^ ((int)num2 * -78067621);
								continue;
							}
							case 1u:
							{
								int num7;
								int num8;
								if (current2.method_6() <= @class.method_6())
								{
									num7 = 44813116;
									num8 = 44813116;
								}
								else
								{
									num7 = 134880809;
									num8 = 134880809;
								}
								num5 = num7 ^ ((int)num2 * -344017330);
								continue;
							}
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
				uint num12 = num4 - @class.method_6();
				result = current.method_8() + Class178.smethod_0(2176) + ((!@class.method_0()) ? @class.method_2().ToString() : @class.method_4()) + Class178.smethod_0(2171) + num12.ToString(Class178.smethod_0(2077));
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
					int num13 = 868955022;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num13 ^ 0x560B19B8)) % 3)
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
						num13 = ((int)num2 * -1031815348) ^ 0x3756192C;
						continue;
						end_IL_02b7:
						break;
					}
					break;
				}
			}
		}
		return Class178.smethod_0(2072) + intptr_0.ToString(Class178.smethod_0(2077));
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
			Class171.smethod_403(method_0());
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
					MessageBox.Show(Class178.smethod_0(2181), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					num = (int)(num2 * 174653001) ^ -5123630;
				}
			}
		}
		catch (Exception)
		{
			MessageBox.Show(Class178.smethod_0(2242), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal void method_5(object sender, EventArgs e)
	{
		if (!Class171.smethod_296(method_0()))
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
					MessageBox.Show(gClass.method_8() + Class178.smethod_0(2327), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
			MessageBox.Show(gClass.method_8() + Class178.smethod_0(2396), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			num = 2037362985;
			goto IL_0081;
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class178.smethod_0(2453) + ex.Message, Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
				{
					int num3;
					int num4;
					if (timer_0.Enabled)
					{
						num3 = -743784286;
						num4 = -743784286;
					}
					else
					{
						num3 = -598167744;
						num4 = -598167744;
					}
					num = num3 ^ ((int)num2 * -1603810802);
					continue;
				}
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
		if (!(flag = button_3.Text == Class178.smethod_0(2546)))
		{
			goto IL_0095;
		}
		bool num = Class171.smethod_97(class75_);
		goto IL_012b;
		IL_011c:
		num = Class171.smethod_294(class75_);
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
				MessageBox.Show(Class178.smethod_0(2555) + (flag ? Class178.smethod_0(2585) : Class178.smethod_0(2572)) + Class178.smethod_0(2594), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
		MessageBox.Show(Class178.smethod_0(2623) + ((!flag) ? Class178.smethod_0(2664) : Class178.smethod_0(2677)) + Class178.smethod_0(2690), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
				MessageBox.Show(Class178.smethod_0(2711), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
		MessageBox.Show(Class178.smethod_0(2796), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		num = -1446707801;
		goto IL_0053;
	}

	void Form.Dispose(bool disposing)
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
			{
				int num3;
				int num4;
				if (icontainer_0 != null)
				{
					num3 = 388882196;
					num4 = 388882196;
				}
				else
				{
					num3 = 417993808;
					num4 = 417993808;
				}
				num = num3 ^ ((int)num2 * -1736371094);
				continue;
			}
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
		Dispose(disposing);
		num = 1205798872;
		goto IL_004d;
	}
}
