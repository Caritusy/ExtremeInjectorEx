using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public sealed class GForm0 : Form
{
	public sealed class Class21
	{
		[CompilerGenerated]
		private Class16 class16_0;

		[SpecialName]
		[CompilerGenerated]
		public Class16 method_0()
		{
			return class16_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(Class16 class16_1)
		{
			class16_0 = class16_1;
		}

		public Class21(Class16 class16_1)
		{
			method_1(class16_1 ?? new Class16
			{
				bool_0 = true
			});
		}
	}

	[CompilerGenerated]
	public sealed class Class22
	{
		public Class21 class21_0;

		internal bool method_0(Class152 class152_0)
		{
			return class152_0.method_4() == class21_0.method_0().string_1;
		}
	}

	[Serializable]
	[CompilerGenerated]
	public sealed class Class23
	{
		public static readonly Class23 field_00B9 = new Class23();

		public static WaitCallback field_00BA;

		public static Func<DataGridViewRow, Class21> field_00BB;

		public static Func<Class21, bool> field_00BC;

		internal void method_0(object object_0)
		{
			Class171.smethod_400();
		}

		internal Class21 method_1(DataGridViewRow dataGridViewRow_0)
		{
			return (Class21)dataGridViewRow_0.Tag;
		}

		internal bool method_2(Class21 class21_0)
		{
			return class21_0.method_0().bool_0;
		}
	}

	[CompilerGenerated]
	public sealed class Class24
	{
		public Class21[] class21_0;

		public Enum3 enum3_0;

		public GForm0 gform0_0;

		internal void method_0(object object_0)
		{
			Class26 CS_0024_003C_003E8__locals5 = new Class26();
			Class25 @class = default(Class25);
			GForm0 gForm = default(GForm0);
			Class21[] array = default(Class21[]);
			Class21 class2 = default(Class21);
			IntPtr intptr_ = default(IntPtr);
			int num3 = default(int);
			while (true)
			{
				int num = 2095854833;
				while (true)
				{
					int num4;
					uint num2;
					switch ((num2 = (uint)(num ^ 0x44BA2852)) % 14)
					{
					case 10u:
						break;
					case 13u:
						CS_0024_003C_003E8__locals5.class24_0 = this;
						num = ((int)num2 * -69833256) ^ -2125899609;
						continue;
					case 12u:
						gform0_0.Invoke(new Action(@class.method_0));
						gForm = gform0_0;
						num = (int)((num2 * 647728552) ^ 0x7AD86FBE);
						continue;
					case 11u:
						CS_0024_003C_003E8__locals5.bool_0 = false;
						array = class21_0;
						num = ((int)num2 * -177398216) ^ -317006518;
						continue;
					default:
						gform0_0.Invoke(new Action(@class.method_1));
						try
						{
							@class.class26_0.bool_0 = Class171.smethod_37(class2, intptr_, gform0_0);
						}
						catch (Exception exception_)
						{
							Class171.smethod_157(gform0_0, Class178.smethod_0(3464), exception_);
							@class.class26_0.bool_0 = false;
						}
						goto IL_02ae;
					case 3u:
						class2 = array[num3];
						@class = new Class25();
						num = 1297658261;
						continue;
					case 8u:
						if (!string.IsNullOrEmpty(class2.method_0().string_1))
						{
							num = (int)(num2 * 1989880082) ^ -753991385;
							continue;
						}
						goto IL_02ae;
					case 7u:
						@class.string_0 = Path.GetFileName(Class171.smethod_237(class2));
						num = ((int)num2 * -1134913587) ^ 0x19E9CB0B;
						continue;
					case 6u:
						@class.class26_0.bool_0 = true;
						num = ((int)num2 * -483328851) ^ 0x2A0CEE10;
						continue;
					case 5u:
						@class.class26_0 = CS_0024_003C_003E8__locals5;
						if (File.Exists(Class171.smethod_237(class2)))
						{
							num = ((int)num2 * -810754441) ^ 0x19BE967C;
							continue;
						}
						goto IL_0125;
					case 4u:
						num3 = 0;
						goto IL_0130;
					case 2u:
					{
						string string_ = Class171.smethod_237(class2);
						Enum3 @enum = enum3_0;
						int num5;
						int num6;
						if (!Class171.smethod_211(ref intptr_, gForm, @enum, string_))
						{
							num5 = -1054222856;
							num6 = -1054222856;
						}
						else
						{
							num5 = -339275510;
							num6 = -339275510;
						}
						num = num5 ^ ((int)num2 * -1439401513);
						continue;
					}
					case 1u:
						Class171.smethod_207(gform0_0, Class12.class12_0.class14_0.int_1, Class178.smethod_0(3411));
						num = (int)(num2 * 766385120) ^ -431335701;
						continue;
					case 0u:
						{
							if (@class.class26_0.bool_0)
							{
								num = 792056410;
								continue;
							}
							goto IL_02ae;
						}
						IL_0130:
						if (num3 >= array.Length)
						{
							num4 = 1631207293;
							goto IL_013b;
						}
						goto case 3u;
						IL_0125:
						num3++;
						num4 = 863955787;
						goto IL_013b;
						IL_02ae:
						Class171.smethod_207(gform0_0, Class12.class12_0.class14_0.int_2, Class178.smethod_0(3533));
						goto IL_0160;
						IL_0160:
						num4 = 133242544;
						goto IL_013b;
						IL_013b:
						switch ((num2 = (uint)(num4 ^ 0x44BA2852)) % 4)
						{
						case 2u:
							break;
						case 1u:
							goto IL_0130;
						case 0u:
							goto IL_0160;
						default:
							gform0_0.Invoke((Action)delegate
							{
								GForm0 gForm2 = CS_0024_003C_003E8__locals5.class24_0.gform0_0;
								bool bool_ = default(bool);
								while (true)
								{
									int num7 = 1112446656;
									while (true)
									{
										uint num8;
										switch ((num8 = (uint)(num7 ^ 0x6B79169F)) % 4)
										{
										case 3u:
											bool_ = CS_0024_003C_003E8__locals5.bool_0;
											num7 = ((int)num8 * -78775071) ^ -886593470;
											continue;
										case 2u:
											Class171.smethod_344(bool_, gForm2);
											num7 = (int)((num8 * 1757077180) ^ 0x3F5AEF5A);
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
							});
							return;
						}
						goto IL_0125;
					}
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	public sealed class Class25
	{
		public string string_0;

		public Class26 class26_0;

		internal void method_0()
		{
			class26_0.class24_0.gform0_0.label_1.Text = Class178.smethod_0(3602) + string_0 + Class178.smethod_0(1864);
		}

		internal void method_1()
		{
			class26_0.class24_0.gform0_0.label_1.Text = Class178.smethod_0(3619) + string_0 + Class178.smethod_0(3656);
		}
	}

	[CompilerGenerated]
	public sealed class Class26
	{
		public bool bool_0;

		public Class24 class24_0;

		internal void method_0()
		{
			GForm0 gform0_ = class24_0.gform0_0;
			bool flag = default(bool);
			while (true)
			{
				int num = 1112446656;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x6B79169F)) % 4)
					{
					case 3u:
						flag = bool_0;
						num = ((int)num2 * -78775071) ^ -886593470;
						continue;
					case 2u:
						Class171.smethod_344(flag, gform0_);
						num = (int)((num2 * 1757077180) ^ 0x3F5AEF5A);
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
	}

	[CompilerGenerated]
	public sealed class Class27
	{
		public string string_0;

		public int int_0;

		public GForm0 gform0_0;
	}

	[CompilerGenerated]
	public sealed class Class28
	{
		public int int_0;

		public Class27 class27_0;

		internal void method_0()
		{
			class27_0.gform0_0.label_1.Text = string.Format(class27_0.string_0, (float)(class27_0.int_0 - int_0) / 1000f);
		}
	}

	[CompilerGenerated]
	public sealed class Class29
	{
		public string string_0;

		public string string_1;

		public Class30 class30_0;

		internal void method_0()
		{
			MessageBox.Show(class30_0.gform0_0, Class178.smethod_0(3661) + string_0 + Class178.smethod_0(3738) + Path.GetFileName(class30_0.string_0) + Class178.smethod_0(3747) + string_1 + Class178.smethod_0(3760) + class30_0.gform0_0.gclass2_0.method_2() + Class178.smethod_0(3777), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	[CompilerGenerated]
	public sealed class Class30
	{
		public string string_0;

		public GForm0 gform0_0;
	}

	[CompilerGenerated]
	public sealed class Class31
	{
		public string string_0;

		public Exception exception_0;

		public GForm0 gform0_0;

		internal void method_0()
		{
			MessageBox.Show(gform0_0, Class171.smethod_339(string_0, exception_0, true), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal GClass2 gclass2_0;

	internal static readonly Dictionary<Enum4, Type> dictionary_0 = new Dictionary<Enum4, Type>
	{
		{
			Enum4.const_0,
			typeof(Class87)
		},
		{
			Enum4.const_2,
			typeof(Class88)
		},
		{
			Enum4.const_3,
			typeof(Class86)
		},
		{
			Enum4.const_1,
			typeof(Class90)
		}
	};

	internal IContainer icontainer_0;

	internal Label label_0;

	internal TextBox textBox_0;

	internal Button button_0;

	internal PictureBox pictureBox_0;

	internal Label label_1;

	internal System.Windows.Forms.Timer timer_0;

	internal Panel panel_0;

	internal Label label_2;

	internal DataGridView dataGridView_0;

	internal Button button_1;

	internal Button button_2;

	internal Button button_3;

	internal Button button_4;

	internal Button button_5;

	internal Button button_6;

	internal Button button_7;

	internal DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	internal DataGridViewButtonColumn dataGridViewButtonColumn_0;

	public GForm0()
	{
		Class171.smethod_377(this);
		Class171.smethod_335();
		timer_0.Start();
		Class171.smethod_4(Class10.class10_0, dataGridView_0.Handle);
		Class10.class10_0.method_0(delegate(object sender, EventArgs0 e)
		{
			using (List<string>.Enumerator enumerator2 = e.method_1().GetEnumerator())
			{
				while (true)
				{
					IL_0065:
					int num;
					int num2;
					if (enumerator2.MoveNext())
					{
						num = -1808137696;
						num2 = -1808137696;
					}
					else
					{
						num = -893043266;
						num2 = -893043266;
					}
					while (true)
					{
						switch ((uint)(num ^ -783116989) % 4u)
						{
						case 3u:
						{
							string current2 = enumerator2.Current;
							Class171.smethod_343(true, (Class16)null, true, this, current2);
							num = -1917655493;
							continue;
						}
						case 2u:
							num = -1808137696;
							continue;
						default:
							goto end_IL_003a;
						case 0u:
							break;
						case 1u:
							goto end_IL_003a;
						}
						goto IL_0065;
						continue;
						end_IL_003a:
						break;
					}
					break;
				}
			}
			Class12.smethod_1();
		});
		if (Class127.bool_1)
		{
			dataGridView_0.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		}
		foreach (Class16 item in Class12.class12_0.list_0)
		{
			string string_ = item.string_0;
			Class171.smethod_343(item.bool_0, item, false, this, string_);
		}
		textBox_0.Text = Class12.class12_0.string_0;
		Class171.smethod_283(this);
		if (DateTime.Now.Subtract(Class12.class12_0.dateTime_0).TotalDays >= 7.0)
		{
			Class12.class12_0.dateTime_0 = DateTime.Now;
			ThreadPool.QueueUserWorkItem(delegate
			{
				Class171.smethod_400();
			});
		}
		Class171.smethod_79(this);
		Class12.smethod_1();
	}

	internal void method_0(object sender, EventArgs e)
	{
		GClass2 gClass = Class171.smethod_45();
		while (true)
		{
			int num = 885604246;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x408FAA74)) % 5)
				{
				case 3u:
					Class171.smethod_374(this, gClass);
					num = ((int)num2 * -168255463) ^ 0x19454FBF;
					continue;
				case 2u:
					textBox_0.Text = gClass.method_2();
					num = (int)(num2 * 47810369) ^ -1450466420;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (gClass != null)
					{
						num3 = 392114455;
						num4 = 392114455;
					}
					else
					{
						num3 = 1818432828;
						num4 = 1818432828;
					}
					num = num3 ^ (int)(num2 * 166785732);
					continue;
				}
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

	internal void method_1(object sender, EventArgs e)
	{
		Class171.smethod_421(this);
	}

	internal void method_2(object sender, EventArgs e)
	{
		if (gclass2_0 != null)
		{
			goto IL_000b;
		}
		goto IL_0101;
		IL_000b:
		int num = 913092886;
		goto IL_00c7;
		IL_00c7:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x4448A500)) % 10)
			{
			case 8u:
				break;
			case 7u:
			{
				int num5;
				int num6;
				if (Class171.smethod_153(this).Length == 0)
				{
					num5 = 970253221;
					num6 = 970253221;
				}
				else
				{
					num5 = 1761209380;
					num6 = 1761209380;
				}
				num = num5 ^ (int)(num2 * 945278361);
				continue;
			}
			case 4u:
				goto IL_0042;
			case 3u:
				timer_0.Stop();
				num = ((int)num2 * -2079949461) ^ -1012620610;
				continue;
			case 2u:
			{
				int num3;
				int num4;
				if (Class12.class12_0.class14_0.bool_0)
				{
					num3 = 2052540103;
					num4 = 2052540103;
				}
				else
				{
					num3 = 1135081994;
					num4 = 1135081994;
				}
				num = num3 ^ (int)(num2 * 906729616);
				continue;
			}
			case 1u:
				Class171.smethod_10(this);
				num = (int)((num2 * 542547353) ^ 0x699EBF7C);
				continue;
			default:
				return;
			case 5u:
				goto IL_0101;
			case 0u:
				return;
			case 6u:
				return;
			case 9u:
				return;
			}
			break;
			IL_0042:
			int num7;
			if (Class171.smethod_296(gclass2_0))
			{
				num = 1450742243;
				num7 = 1450742243;
			}
			else
			{
				num = 922654054;
				num7 = 922654054;
			}
		}
		goto IL_000b;
		IL_0101:
		timer_0.Stop();
		Class171.smethod_421(this);
		timer_0.Start();
		num = 1477361870;
		goto IL_00c7;
	}

	internal void method_3(object sender, PaintEventArgs e)
	{
		Size clientSize = base.ClientSize;
		while (true)
		{
			int num = -788328708;
			while (true)
			{
				int num4;
				uint num2;
				switch ((num2 = (uint)(num ^ -1290972729)) % 4)
				{
				case 3u:
				{
					int num5;
					if (clientSize.IsEmpty)
					{
						num4 = -528146501;
						num5 = -528146501;
					}
					else
					{
						num4 = -747675630;
						num5 = -747675630;
					}
					goto IL_0028;
				}
				case 2u:
					break;
				case 0u:
					return;
				default:
				{
					Rectangle rect = new Rectangle(0, 0, base.ClientSize.Width, base.ClientSize.Height);
					LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, Class12.class12_0.class14_0.Color_0, Class12.class12_0.class14_0.Color_1, 90f);
					try
					{
						e.Graphics.FillRectangle(linearGradientBrush, rect);
						return;
					}
					finally
					{
						if (linearGradientBrush != null)
						{
							while (true)
							{
								IL_00ed:
								int num3 = -1501431655;
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -1290972729)) % 3)
									{
									case 1u:
										goto IL_00bd;
									default:
										goto end_IL_00d0;
									case 0u:
										break;
									case 2u:
										goto end_IL_00d0;
									}
									goto IL_00ed;
									IL_00bd:
									((IDisposable)linearGradientBrush).Dispose();
									num3 = (int)((num2 * 1691631517) ^ 0x265F23C);
									continue;
									end_IL_00d0:
									break;
								}
								break;
							}
						}
					}
				}
				}
				break;
				IL_0028:
				num = num4 ^ (int)(num2 * 1786941324);
			}
		}
	}

	internal void method_4(object sender, EventArgs e)
	{
		dataGridView_0.Rows.Clear();
		while (true)
		{
			int num = -786483381;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1117557375)) % 3)
				{
				case 2u:
					goto IL_0012;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0012:
				Class12.class12_0.list_0.Clear();
				Class12.smethod_1();
				num = (int)(num2 * 1095002302) ^ -734838463;
			}
		}
	}

	internal void method_5(object sender, EventArgs e)
	{
		if (dataGridView_0.SelectedRows.Count <= 0)
		{
			return;
		}
		DataGridViewRow dataGridViewRow = default(DataGridViewRow);
		while (true)
		{
			int num = -1877785361;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -55263900)) % 5)
				{
				case 4u:
					Class12.class12_0.list_0.Remove(((Class21)dataGridViewRow.Tag).method_0());
					num = ((int)num2 * -252673013) ^ -1930896394;
					continue;
				case 3u:
					dataGridViewRow = dataGridView_0.SelectedRows[0];
					dataGridView_0.Rows.Remove(dataGridViewRow);
					num = (int)((num2 * 405120424) ^ 0x64F84D11);
					continue;
				case 1u:
					Class12.smethod_1();
					num = ((int)num2 * -1517584645) ^ 0x28FA4CBB;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	internal void method_6(object sender, EventArgs e)
	{
		if (dataGridView_0.SelectedRows.Count != 0)
		{
			Class171.smethod_111(this, dataGridView_0.SelectedRows[0].Index);
		}
	}

	internal void method_7(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		try
		{
			openFileDialog.Filter = Class178.smethod_0(497);
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			while (true)
			{
				int num = 1001138623;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x6F50CE45)) % 4)
					{
					case 2u:
						Class171.smethod_343(true, (Class16)null, true, this, openFileDialog.FileName);
						num = ((int)num2 * -1628861704) ^ 0x477DCB3C;
						continue;
					case 1u:
						Class12.smethod_1();
						num = (int)((num2 * 904965658) ^ 0x6B3DE40);
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
		finally
		{
			if (openFileDialog != null)
			{
				while (true)
				{
					IL_00b0:
					int num3 = 680032298;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num3 ^ 0x6F50CE45)) % 3)
						{
						case 1u:
							goto IL_0080;
						default:
							goto end_IL_0093;
						case 0u:
							break;
						case 2u:
							goto end_IL_0093;
						}
						goto IL_00b0;
						IL_0080:
						((IDisposable)openFileDialog).Dispose();
						num3 = (int)(num2 * 571036560) ^ -1212022825;
						continue;
						end_IL_0093:
						break;
					}
					break;
				}
			}
		}
	}

	internal void method_8(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (e.ColumnIndex == 0)
		{
			goto IL_0017;
		}
		goto IL_0081;
		IL_0017:
		int num = 1368065273;
		goto IL_0050;
		IL_0050:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0xBDC4E55)) % 5)
			{
			case 4u:
				break;
			case 1u:
				Class171.smethod_6((Class21)dataGridView_0.Rows[e.RowIndex].Tag);
				num = ((int)num2 * -1498507046) ^ 0x5DD94F7A;
				continue;
			default:
				return;
			case 0u:
				goto IL_0081;
			case 2u:
				return;
			case 3u:
				Class171.smethod_111(this, e.RowIndex);
				return;
			}
			break;
		}
		goto IL_0017;
		IL_0081:
		int num3;
		if (e.ColumnIndex == 2)
		{
			num = 1655184592;
			num3 = 1655184592;
		}
		else
		{
			num = 1873441336;
			num3 = 1873441336;
		}
		goto IL_0050;
	}

	internal void method_9(object sender, EventArgs e)
	{
		if (gclass2_0 == null)
		{
			return;
		}
		while (true)
		{
			int num = -48067247;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1021811542)) % 3)
				{
				case 1u:
					goto IL_000a;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000a:
				Class171.smethod_209(gclass2_0);
				num = (int)((num2 * 29376819) ^ 0x67D8A74C);
			}
		}
	}

	internal void method_10(object sender, EventArgs e)
	{
		Refresh();
	}

	internal void method_11(object sender, EventArgs e)
	{
		new Form1().ShowDialog(this);
	}

	internal void method_12(object sender, EventArgs e)
	{
		Class171.smethod_238(gclass2_0);
		while (true)
		{
			int num = 611492607;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x395D1E14)) % 3)
				{
				case 1u:
					goto IL_000d;
				case 2u:
					break;
				default:
					Class171.smethod_283(this);
					return;
				}
				break;
				IL_000d:
				Invalidate();
				num = (int)(num2 * 628624752) ^ -580379289;
			}
		}
	}

	internal void method_13(object sender, EventArgs e)
	{
		Class171.smethod_10(this);
	}

	internal void method_14(object sender, EventArgs e)
	{
		DoubleBuffered = true;
		while (true)
		{
			int num = 272788726;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xD28D10F)) % 4)
				{
				case 2u:
					Text = Class171.smethod_269(Class127.random_0.Next(10, 25));
					num = ((int)num2 * -1437779953) ^ -861528518;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (Class18.bool_0)
					{
						num3 = 1254342227;
						num4 = 1254342227;
					}
					else
					{
						num3 = 2079763258;
						num4 = 2079763258;
					}
					num = num3 ^ (int)(num2 * 1786912406);
					continue;
				}
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

	internal void method_15(object sender, MouseEventArgs e)
	{
		if (button_5.Enabled)
		{
			return;
		}
		while (true)
		{
			int num = -118742640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -87900181)) % 10)
				{
				case 9u:
				{
					int num5;
					int num6;
					if (GetChildAtPoint(e.Location) == button_5)
					{
						num5 = 650290902;
						num6 = 650290902;
					}
					else
					{
						num5 = 1712314969;
						num6 = 1712314969;
					}
					num = num5 ^ ((int)num2 * -597800849);
					continue;
				}
				case 6u:
				{
					int num4;
					if (!Class12.class12_0.class14_0.bool_0)
					{
						num = -650660338;
						num4 = -650660338;
					}
					else
					{
						num = -26103791;
						num4 = -26103791;
					}
					continue;
				}
				case 4u:
					MessageBox.Show(Class178.smethod_0(518), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					num = ((int)num2 * -1777241989) ^ -676478233;
					continue;
				case 3u:
					MessageBox.Show(Class178.smethod_0(859), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					num = -1453238682;
					continue;
				case 0u:
				{
					int num3;
					if (!string.IsNullOrEmpty(textBox_0.Text))
					{
						num = -1871696631;
						num3 = -1871696631;
					}
					else
					{
						num = -68952149;
						num3 = -68952149;
					}
					continue;
				}
				default:
					return;
				case 7u:
					break;
				case 2u:
					return;
				case 5u:
					return;
				case 8u:
					MessageBox.Show(Class178.smethod_0(628) + textBox_0.Text + Class178.smethod_0(705), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				case 1u:
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
			goto IL_0003;
		}
		goto IL_0070;
		IL_0003:
		int num = -1876328478;
		goto IL_004b;
		IL_004b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -698741242)) % 5)
			{
			case 4u:
				break;
			case 1u:
			{
				int num3;
				int num4;
				if (icontainer_0 != null)
				{
					num3 = 464053287;
					num4 = 464053287;
				}
				else
				{
					num3 = 704378865;
					num4 = 704378865;
				}
				num = num3 ^ (int)(num2 * 697077469);
				continue;
			}
			case 0u:
				icontainer_0.Dispose();
				num = (int)((num2 * 1777553482) ^ 0x2E45CAF7);
				continue;
			default:
				return;
			case 2u:
				goto IL_0070;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0003;
		IL_0070:
		base.Dispose(disposing);
		num = -2040569350;
		goto IL_004b;
	}

	[CompilerGenerated]
	private void method_16(object sender, EventArgs0 e)
	{
		using (List<string>.Enumerator enumerator = e.method_1().GetEnumerator())
		{
			while (true)
			{
				IL_0065:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1808137696;
					num2 = -1808137696;
				}
				else
				{
					num = -893043266;
					num2 = -893043266;
				}
				while (true)
				{
					switch ((uint)(num ^ -783116989) % 4u)
					{
					case 3u:
					{
						string current = enumerator.Current;
						Class171.smethod_343(true, (Class16)null, true, this, current);
						num = -1917655493;
						continue;
					}
					case 2u:
						num = -1808137696;
						continue;
					default:
						goto end_IL_003a;
					case 0u:
						break;
					case 1u:
						goto end_IL_003a;
					}
					goto IL_0065;
					continue;
					end_IL_003a:
					break;
				}
				break;
			}
		}
		Class12.smethod_1();
	}
}
