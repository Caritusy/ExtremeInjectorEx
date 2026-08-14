using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class ProcessInspectorForm : Form
{
	internal RemoteProcess SelectedProcess { get; set; }

	internal IContainer container;

	internal Button button;

	internal DataGridView dataGridView;

	internal Label label;

	internal GroupBox groupBox;

	internal PictureBox pictureBox;

	internal Button button2;

	internal Timer timer;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	internal Button button3;

	internal TabControl tabControl;

	internal TabPage tabPage;

	internal TabPage tabPage2;

	internal DataGridView dataGridView2;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

	internal Button button4;

	internal Button button5;

	public ProcessInspectorForm()
	{
		RecoveredRuntime.InitializeProcessInspectorForm(this);
		ModernUi.ApplyLegacyFormTheme(this);
		ApplyModernLayout();
		ModernUi.StyleDangerButton(button);
		ModernUi.StyleDangerButton(button2);
		ModernUi.StyleDangerButton(button5);
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

		groupBox.Dock = DockStyle.Fill;
		groupBox.Margin = new Padding(0, 0, 0, 12);
		pictureBox.Size = new Size(48, 48);
		pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
		pictureBox.Anchor = AnchorStyles.Top;
		pictureBox.Margin = Padding.Empty;
		label.AutoSize = false;
		label.AutoEllipsis = true;
		label.Dock = DockStyle.Fill;
		label.Margin = new Padding(10, 0, 0, 0);
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
		summaryLayout.Controls.Add(pictureBox, 0, 0);
		summaryLayout.Controls.Add(label, 1, 0);
		groupBox.Controls.Clear();
		groupBox.Controls.Add(summaryLayout);

		tabControl.Dock = DockStyle.Fill;
		tabControl.Margin = new Padding(0, 0, 0, 10);
		ConfigureTabPage(tabPage, dataGridView, button2, null);
		ConfigureTabPage(tabPage2, dataGridView2, button5, button4);

		var footer = new FlowLayoutPanel
		{
			BackColor = ModernUi.Window,
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.RightToLeft,
			Margin = Padding.Empty,
			Padding = new Padding(0, 6, 0, 0),
			WrapContents = false
		};
		button3.Margin = Padding.Empty;
		button.Margin = new Padding(0, 0, 8, 0);
		footer.Controls.Add(button3);
		footer.Controls.Add(button);

		Controls.Clear();
		root.Controls.Add(groupBox, 0, 0);
		root.Controls.Add(tabControl, 0, 1);
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
		this.dataGridView.Rows.Clear();
		this.dataGridView2.Rows.Clear();
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
				this.dataGridView.Rows.Add(dataGridViewRow);
			}
		}
		using (Icon icon = RecoveredRuntime.GetFileIcon(SelectedProcess.FilePath, IconSize.Large))
		{
			this.pictureBox.BackgroundImage = ((icon == null) ? null : icon.ToBitmap());
		}
		this.label.Text = string.Format(EncodedStringTable.DecodeString(2082), new object[]
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
			this.dataGridView2.Rows.Add(dataGridViewRow2);
		}
	}

	internal static string FormatAddress(IEnumerable<ProcessModuleInfo> items, IntPtr address)
	{
		foreach (ProcessModuleInfo gclass in items)
		{
			if ((long)address >= (long)gclass.GetModuleBase() && (long)address <= (long)gclass.GetModuleBase() + (long)((ulong)gclass.GetImageSize()))
			{
				List<ExportedSymbol> list = RecoveredRuntime.GetRemoteModuleExports(gclass);
				uint num = (uint)((long)address - (long)gclass.GetModuleBase());
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
		return EncodedStringTable.DecodeString(2072) + address.ToString(EncodedStringTable.DecodeString(2077));
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
		this.timer.Stop();
		Control control = this.button;
		Control control2 = this.button2;
		Control control3 = this.button4;
		this.button5.Enabled = false;
		control3.Enabled = false;
		control2.Enabled = false;
		control.Enabled = false;
	}

	internal void OnModuleSelectionChanged(object sender, EventArgs e)
	{
		button2.Enabled = timer.Enabled;
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
		timer.Start();
	}

	internal void OnUnloadModuleClick(object sender, EventArgs e)
	{
		try
		{
			ProcessModuleInfo gclass = (ProcessModuleInfo)this.dataGridView.SelectedRows[0].Tag;
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
		this.button4.Enabled = (this.button5.Enabled = this.timer.Enabled);
		if (this.timer.Enabled)
		{
			RecoveredRuntime.UpdateThreadActionText(this);
		}
	}

	internal void OnToggleThreadSuspensionClick(object sender, EventArgs e)
	{
		ProcessThreadInfo class75_ = (ProcessThreadInfo)this.dataGridView2.SelectedRows[0].Tag;
		bool flag;
		if (!((!(flag = (this.button4.Text == EncodedStringTable.DecodeString(2546)))) ? RecoveredRuntime.SuspendProcessThread(class75_) : RecoveredRuntime.ResumeProcessThread(class75_)))
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
		if (!RecoveredRuntime.TerminateProcessThread((ProcessThreadInfo)this.dataGridView2.SelectedRows[0].Tag))
		{
			MessageBox.Show(EncodedStringTable.DecodeString(2711), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		MessageBox.Show(EncodedStringTable.DecodeString(2796), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.container != null)
		{
			this.container.Dispose();
		}
		base.Dispose(disposing);
	}
}
