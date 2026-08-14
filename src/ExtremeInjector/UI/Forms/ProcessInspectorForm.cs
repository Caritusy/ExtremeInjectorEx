using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class ProcessInspectorForm : Form
{
	internal RemoteProcess SelectedProcess { get; set; }

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

	public ProcessInspectorForm()
	{
		RecoveredRuntime.InitializeProcessInspectorForm(this);
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

	internal void RefreshProcessDetails()
	{
		this.dataGridView_0.Rows.Clear();
		this.dataGridView_1.Rows.Clear();
		ProcessModuleCollection @class = RecoveredRuntime.CaptureProcessModules(SelectedProcess);
		foreach (ProcessModuleInfo gclass in @class)
		{
			if (!gclass.GetIsManualMapped())
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow
				{
					Tag = gclass
				};
				dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
				{
					Value = gclass.GetFilePath(),
					Tag = gclass.GetFilePath()
				});
				dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
				{
					Value = EncodedStringTable.DecodeString(2072) + gclass.GetModuleBase().ToString(EncodedStringTable.DecodeString(2077)),
					Tag = gclass.GetModuleBase().ToInt64()
				});
				dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
				{
					Value = RecoveredRuntime.FormatByteSize((long)((ulong)gclass.GetImageSize())),
					Tag = gclass.GetImageSize()
				});
				this.dataGridView_0.Rows.Add(dataGridViewRow);
			}
		}
		using (Icon icon = RecoveredRuntime.GetFileIcon(SelectedProcess.FilePath, IconSize.const_1))
		{
			this.pictureBox_0.BackgroundImage = ((icon == null) ? null : icon.ToBitmap());
		}
		this.label_0.Text = string.Format(EncodedStringTable.DecodeString(2082), new object[]
		{
			SelectedProcess.Name,
			SelectedProcess.FilePath,
			SelectedProcess.ProcessId,
			RecoveredRuntime.CaptureProcessModules(SelectedProcess).Count,
			RecoveredRuntime.EnumerateProcessThreads(SelectedProcess).Count
		});
		foreach (ProcessThreadInfo class2 in RecoveredRuntime.EnumerateProcessThreads(SelectedProcess))
		{
			DataGridViewRow dataGridViewRow2 = new DataGridViewRow
			{
				Tag = class2
			};
			dataGridViewRow2.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = class2.GetThreadId().ToString(),
				Tag = class2.GetThreadId()
			});
			dataGridViewRow2.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = ProcessInspectorForm.FormatAddress(@class, class2.GetStartAddress()),
				Tag = class2.GetStartAddress()
			});
			dataGridViewRow2.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = RecoveredRuntime.FormatThreadPriority(class2.GetPriorityLevel()),
				Tag = class2.GetPriorityLevel()
			});
			this.dataGridView_1.Rows.Add(dataGridViewRow2);
		}
	}

	internal static string FormatAddress(IEnumerable<ProcessModuleInfo> ienumerable_0, IntPtr intptr_0)
	{
		foreach (ProcessModuleInfo gclass in ienumerable_0)
		{
			if ((long)intptr_0 >= (long)gclass.GetModuleBase() && (long)intptr_0 <= (long)gclass.GetModuleBase() + (long)((ulong)gclass.GetImageSize()))
			{
				List<ExportedSymbol> list = RecoveredRuntime.GetRemoteModuleExports(gclass);
				uint num = (uint)((long)intptr_0 - (long)gclass.GetModuleBase());
				ExportedSymbol @class = null;
				foreach (ExportedSymbol class2 in list)
				{
					if (num > class2.GetAddressRva() && (@class == null || class2.GetAddressRva() > @class.GetAddressRva()))
					{
						@class = class2;
					}
				}
				if (@class != null)
				{
					uint num2 = num - @class.GetAddressRva();
					return string.Concat(new string[]
					{
						gclass.GetFilePath(),
						EncodedStringTable.DecodeString(2176),
						(!@class.GetHasName()) ? @class.GetOrdinal().ToString() : @class.GetName(),
						EncodedStringTable.DecodeString(2171),
						num2.ToString(EncodedStringTable.DecodeString(2077))
					});
				}
				return gclass.GetFilePath() + EncodedStringTable.DecodeString(2171) + num.ToString(EncodedStringTable.DecodeString(2077));
			}
		}
		return EncodedStringTable.DecodeString(2072) + intptr_0.ToString(EncodedStringTable.DecodeString(2077));
	}

	internal void OnCloseClick(object sender, EventArgs e)
	{
		Close();
	}

	internal void OnTerminateProcessClick(object sender, EventArgs e)
	{
		try
		{
			RecoveredRuntime.TerminateRemoteProcess(SelectedProcess);
			MessageBox.Show(EncodedStringTable.DecodeString(2181), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		catch (Exception)
		{
			MessageBox.Show(EncodedStringTable.DecodeString(2242), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal void OnProcessExitTimerTick(object sender, EventArgs e)
	{
		if (!RecoveredRuntime.HasProcessExited(SelectedProcess))
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

	internal void OnModuleSelectionChanged(object sender, EventArgs e)
	{
		button_1.Enabled = timer_0.Enabled;
	}

	internal void OnGridSortCompare(object sender, DataGridViewSortCompareEventArgs e)
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

	internal void OnFormLoad(object sender, EventArgs e)
	{
		RefreshProcessDetails();
		timer_0.Start();
	}

	internal void OnUnloadModuleClick(object sender, EventArgs e)
	{
		try
		{
			ProcessModuleInfo gclass = (ProcessModuleInfo)this.dataGridView_0.SelectedRows[0].Tag;
			if (RecoveredRuntime.UnloadProcessModule(gclass, new RemoteModuleManager(SelectedProcess)))
			{
				this.RefreshProcessDetails();
				MessageBox.Show(gclass.GetFilePath() + EncodedStringTable.DecodeString(2327), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show(gclass.GetFilePath() + EncodedStringTable.DecodeString(2396), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(EncodedStringTable.DecodeString(2453) + ex.Message, EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal void OnThreadSelectionChanged(object sender, EventArgs e)
	{
		this.button_3.Enabled = (this.button_4.Enabled = this.timer_0.Enabled);
		if (this.timer_0.Enabled)
		{
			RecoveredRuntime.UpdateThreadActionText(this);
		}
	}

	internal void OnToggleThreadSuspensionClick(object sender, EventArgs e)
	{
		ProcessThreadInfo class75_ = (ProcessThreadInfo)this.dataGridView_1.SelectedRows[0].Tag;
		bool flag;
		if (!((!(flag = (this.button_3.Text == EncodedStringTable.DecodeString(2546)))) ? RecoveredRuntime.SuspendProcessThread(class75_) : RecoveredRuntime.ResumeProcessThread(class75_)))
		{
			MessageBox.Show(EncodedStringTable.DecodeString(2555) + (flag ? EncodedStringTable.DecodeString(2585) : EncodedStringTable.DecodeString(2572)) + EncodedStringTable.DecodeString(2594), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			MessageBox.Show(EncodedStringTable.DecodeString(2623) + ((!flag) ? EncodedStringTable.DecodeString(2664) : EncodedStringTable.DecodeString(2677)) + EncodedStringTable.DecodeString(2690), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		RecoveredRuntime.UpdateThreadActionText(this);
	}

	internal void OnTerminateThreadClick(object sender, EventArgs e)
	{
		if (!RecoveredRuntime.TerminateProcessThread((ProcessThreadInfo)this.dataGridView_1.SelectedRows[0].Tag))
		{
			MessageBox.Show(EncodedStringTable.DecodeString(2711), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		MessageBox.Show(EncodedStringTable.DecodeString(2796), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}
}
