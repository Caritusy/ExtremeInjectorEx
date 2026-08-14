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
		RecoveredRuntime.smethod_406(this);
		ModernUi.ApplyLegacyFormTheme(this);
		ApplyModernLayout();
		ModernUi.StyleDangerButton(button_0);
		ModernUi.StyleDangerButton(button_1);
		ModernUi.StyleDangerButton(button_4);
	}

	private void ApplyModernLayout()
	{
		SuspendLayout();
		FormBorderStyle = FormBorderStyle.Sizable;
		ClientSize = new Size(560, 650);
		MinimumSize = new Size(500, 590);
		SizeGripStyle = SizeGripStyle.Show;

		var root = new TableLayoutPanel
		{
			BackColor = ModernUi.Window,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(16),
			RowCount = 3
		};
		root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		root.RowStyles.Add(new RowStyle(SizeType.Absolute, 200f));
		root.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		root.RowStyles.Add(new RowStyle(SizeType.Absolute, 42f));

		groupBox_0.Dock = DockStyle.Fill;
		groupBox_0.Margin = new Padding(0, 0, 0, 12);
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.BackgroundImageLayout = ImageLayout.Zoom;
		pictureBox_0.Anchor = AnchorStyles.Top;
		pictureBox_0.Margin = Padding.Empty;
		label_0.AutoSize = false;
		label_0.AutoEllipsis = true;
		label_0.Dock = DockStyle.Fill;
		label_0.Margin = new Padding(10, 0, 0, 0);
		var summaryLayout = new TableLayoutPanel
		{
			BackColor = ModernUi.Surface,
			ColumnCount = 2,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(14, 28, 14, 10),
			RowCount = 1
		};
		summaryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52f));
		summaryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		summaryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		summaryLayout.Controls.Add(pictureBox_0, 0, 0);
		summaryLayout.Controls.Add(label_0, 1, 0);
		groupBox_0.Controls.Clear();
		groupBox_0.Controls.Add(summaryLayout);

		tabControl_0.Dock = DockStyle.Fill;
		tabControl_0.Margin = new Padding(0, 0, 0, 10);
		ConfigureTabPage(tabPage_0, dataGridView_0, button_1, null);
		ConfigureTabPage(tabPage_1, dataGridView_1, button_4, button_3);

		var footer = new FlowLayoutPanel
		{
			BackColor = ModernUi.Window,
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.RightToLeft,
			Margin = Padding.Empty,
			Padding = new Padding(0, 6, 0, 0),
			WrapContents = false
		};
		button_2.Margin = Padding.Empty;
		button_0.Margin = new Padding(0, 0, 8, 0);
		footer.Controls.Add(button_2);
		footer.Controls.Add(button_0);

		Controls.Clear();
		root.Controls.Add(groupBox_0, 0, 0);
		root.Controls.Add(tabControl_0, 0, 1);
		root.Controls.Add(footer, 0, 2);
		Controls.Add(root);
		ResumeLayout(performLayout: true);
	}

	private static void ConfigureTabPage(
		TabPage page,
		DataGridView grid,
		Button rightButton,
		Button secondaryButton)
	{
		var layout = new TableLayoutPanel
		{
			BackColor = ModernUi.Surface,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(10),
			RowCount = 2
		};
		layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42f));

		grid.Dock = DockStyle.Fill;
		grid.Margin = Padding.Empty;
		var actions = new FlowLayoutPanel
		{
			BackColor = ModernUi.Surface,
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.RightToLeft,
			Margin = Padding.Empty,
			Padding = new Padding(0, 6, 0, 0),
			WrapContents = false
		};
		rightButton.Margin = Padding.Empty;
		actions.Controls.Add(rightButton);
		if (secondaryButton != null)
		{
			secondaryButton.Margin = new Padding(0, 0, 8, 0);
			actions.Controls.Add(secondaryButton);
		}

		page.Controls.Clear();
		layout.Controls.Add(grid, 0, 0);
		layout.Controls.Add(actions, 0, 1);
		page.Controls.Add(layout);
	}

	internal void method_2()
	{
		this.dataGridView_0.Rows.Clear();
		this.dataGridView_1.Rows.Clear();
		ProcessModuleCollection @class = RecoveredRuntime.smethod_42(this.method_0());
		foreach (ProcessModuleInfo gclass in @class)
		{
			if (!gclass.method_12())
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow
				{
					Tag = gclass
				};
				dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
				{
					Value = gclass.method_8(),
					Tag = gclass.method_8()
				});
				dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
				{
					Value = EncodedStringTable.smethod_0(2072) + gclass.method_0().ToString(EncodedStringTable.smethod_0(2077)),
					Tag = gclass.method_0().ToInt64()
				});
				dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
				{
					Value = RecoveredRuntime.smethod_442((long)((ulong)gclass.method_4())),
					Tag = gclass.method_4()
				});
				this.dataGridView_0.Rows.Add(dataGridViewRow);
			}
		}
		using (Icon icon = RecoveredRuntime.smethod_11(this.method_0().FilePath, IconSize.const_1))
		{
			this.pictureBox_0.BackgroundImage = ((icon == null) ? null : icon.ToBitmap());
		}
		this.label_0.Text = string.Format(EncodedStringTable.smethod_0(2082), new object[]
		{
			this.method_0().Name,
			this.method_0().FilePath,
			this.method_0().ProcessId,
			RecoveredRuntime.smethod_42(this.method_0()).Count,
			RecoveredRuntime.smethod_179(this.method_0()).Count
		});
		foreach (ProcessThreadInfo class2 in RecoveredRuntime.smethod_179(this.method_0()))
		{
			DataGridViewRow dataGridViewRow2 = new DataGridViewRow
			{
				Tag = class2
			};
			dataGridViewRow2.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = class2.method_0().ToString(),
				Tag = class2.method_0()
			});
			dataGridViewRow2.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = ProcessInspectorForm.smethod_0(@class, class2.method_2()),
				Tag = class2.method_2()
			});
			dataGridViewRow2.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = RecoveredRuntime.smethod_182(class2.method_7()),
				Tag = class2.method_7()
			});
			this.dataGridView_1.Rows.Add(dataGridViewRow2);
		}
	}

	internal static string smethod_0(IEnumerable<ProcessModuleInfo> ienumerable_0, IntPtr intptr_0)
	{
		foreach (ProcessModuleInfo gclass in ienumerable_0)
		{
			if ((long)intptr_0 >= (long)gclass.method_0() && (long)intptr_0 <= (long)gclass.method_0() + (long)((ulong)gclass.method_4()))
			{
				List<ExportedSymbol> list = RecoveredRuntime.smethod_131(gclass);
				uint num = (uint)((long)intptr_0 - (long)gclass.method_0());
				ExportedSymbol @class = null;
				foreach (ExportedSymbol class2 in list)
				{
					if (num > class2.method_6() && (@class == null || class2.method_6() > @class.method_6()))
					{
						@class = class2;
					}
				}
				if (@class != null)
				{
					uint num2 = num - @class.method_6();
					return string.Concat(new string[]
					{
						gclass.method_8(),
						EncodedStringTable.smethod_0(2176),
						(!@class.method_0()) ? @class.method_2().ToString() : @class.method_4(),
						EncodedStringTable.smethod_0(2171),
						num2.ToString(EncodedStringTable.smethod_0(2077))
					});
				}
				return gclass.method_8() + EncodedStringTable.smethod_0(2171) + num.ToString(EncodedStringTable.smethod_0(2077));
			}
		}
		return EncodedStringTable.smethod_0(2072) + intptr_0.ToString(EncodedStringTable.smethod_0(2077));
	}

	internal void method_3(object sender, EventArgs e)
	{
		Close();
	}

	internal void method_4(object sender, EventArgs e)
	{
		try
		{
			RecoveredRuntime.smethod_411(this.method_0());
			MessageBox.Show(EncodedStringTable.smethod_0(2181), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (Exception)
		{
			MessageBox.Show(EncodedStringTable.smethod_0(2242), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal void method_5(object sender, EventArgs e)
	{
		if (!RecoveredRuntime.HasProcessExited(this.method_0()))
		{
			return;
		}
		this.timer_0.Stop();
		Control control = this.button_0;
		Control control2 = this.button_1;
		Control control3 = this.button_3;
		this.button_4.Enabled = false;
		control3.Enabled = false;
		control2.Enabled = false;
		control.Enabled = false;
	}

	internal void method_6(object sender, EventArgs e)
	{
		button_1.Enabled = timer_0.Enabled;
	}

	internal void method_7(object sender, DataGridViewSortCompareEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		DataGridViewCell dataGridViewCell = dataGridView[e.Column.Index, e.RowIndex1];
		DataGridViewCell dataGridViewCell2 = dataGridView[e.Column.Index, e.RowIndex2];
		IComparable comparable = dataGridViewCell.Tag as IComparable;
		if (comparable != null)
		{
			e.SortResult = comparable.CompareTo(dataGridViewCell2.Tag);
			e.Handled = true;
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
			ProcessModuleInfo gclass = (ProcessModuleInfo)this.dataGridView_0.SelectedRows[0].Tag;
			if (RecoveredRuntime.smethod_103(gclass, new RemoteModuleManager(this.method_0())))
			{
				this.method_2();
				MessageBox.Show(gclass.method_8() + EncodedStringTable.smethod_0(2327), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show(gclass.method_8() + EncodedStringTable.smethod_0(2396), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(EncodedStringTable.smethod_0(2453) + ex.Message, EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal void method_10(object sender, EventArgs e)
	{
		this.button_3.Enabled = (this.button_4.Enabled = this.timer_0.Enabled);
		if (this.timer_0.Enabled)
		{
			RecoveredRuntime.smethod_88(this);
		}
	}

	internal void method_11(object sender, EventArgs e)
	{
		ProcessThreadInfo class75_ = (ProcessThreadInfo)this.dataGridView_1.SelectedRows[0].Tag;
		bool flag;
		if (!((!(flag = (this.button_3.Text == EncodedStringTable.smethod_0(2546)))) ? RecoveredRuntime.smethod_300(class75_) : RecoveredRuntime.smethod_97(class75_)))
		{
			MessageBox.Show(EncodedStringTable.smethod_0(2555) + (flag ? EncodedStringTable.smethod_0(2585) : EncodedStringTable.smethod_0(2572)) + EncodedStringTable.smethod_0(2594), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			MessageBox.Show(EncodedStringTable.smethod_0(2623) + ((!flag) ? EncodedStringTable.smethod_0(2664) : EncodedStringTable.smethod_0(2677)) + EncodedStringTable.smethod_0(2690), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		RecoveredRuntime.smethod_88(this);
	}

	internal void method_12(object sender, EventArgs e)
	{
		if (!RecoveredRuntime.smethod_74((ProcessThreadInfo)this.dataGridView_1.SelectedRows[0].Tag))
		{
			MessageBox.Show(EncodedStringTable.smethod_0(2711), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		MessageBox.Show(EncodedStringTable.smethod_0(2796), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
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
