using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
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
		InitializeModernComponents();
		ApplyModernLayout();
		ModernUi.ApplyLegacyFormTheme(this);
		ModernUi.StyleDangerButton(button);
		ModernUi.StyleDangerButton(button2);
		ModernUi.StyleDangerButton(button5);
	}

	private void InitializeModernComponents()
	{
		container = new Container();
		button = CreateButton("terminateProcessButton", "ProcessInfo.KillProcess", OnTerminateProcessClick);
		button2 = CreateButton("unloadModuleButton", "ProcessInfo.UnloadModule", OnUnloadModuleClick);
		button2.Enabled = false;
		button3 = CreateButton("closeButton", "Common.Close", OnCloseClick);
		button4 = CreateButton("toggleThreadSuspensionButton", "ProcessInfo.Suspend", OnToggleThreadSuspensionClick);
		button4.Enabled = false;
		button5 = CreateButton("terminateThreadButton", "ProcessInfo.KillThread", OnTerminateThreadClick);
		button5.Enabled = false;

		dataGridViewTextBoxColumn = CreateColumn("moduleNameColumn", "ProcessInfo.ModuleName", DataGridViewAutoSizeColumnMode.Fill);
		dataGridViewTextBoxColumn2 = CreateColumn("moduleBaseColumn", "ProcessInfo.ModuleBase", DataGridViewAutoSizeColumnMode.None, 130);
		dataGridViewTextBoxColumn3 = CreateColumn("moduleSizeColumn", "ProcessInfo.ModuleSize", DataGridViewAutoSizeColumnMode.None, 110);
		dataGridView = CreateGrid("moduleGrid", dataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3);
		dataGridView.SelectionChanged += OnModuleSelectionChanged;
		dataGridView.SortCompare += OnGridSortCompare;

		dataGridViewTextBoxColumn4 = CreateColumn("threadIdColumn", "ProcessInfo.ThreadId", DataGridViewAutoSizeColumnMode.None, 100);
		dataGridViewTextBoxColumn5 = CreateColumn("startAddressColumn", "ProcessInfo.StartAddress", DataGridViewAutoSizeColumnMode.Fill);
		dataGridViewTextBoxColumn6 = CreateColumn("priorityColumn", "ProcessInfo.Priority", DataGridViewAutoSizeColumnMode.None, 110);
		dataGridView2 = CreateGrid("threadGrid", dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6);
		dataGridView2.SelectionChanged += OnThreadSelectionChanged;
		dataGridView2.SortCompare += OnGridSortCompare;

		label = new Label
		{
			Name = "processSummaryLabel",
			Text = UiText.Get("ProcessInfo.SummaryPlaceholder")
		};
		pictureBox = new PictureBox
		{
			BackColor = Color.Transparent,
			Name = "processIcon",
			TabStop = false
		};
		groupBox = new ModernGroupBox
		{
			Name = "processSummaryCard",
			Text = UiText.Get("ProcessInfo.Process")
		};
		tabPage = new TabPage
		{
			Name = "modulesTab",
			Text = UiText.Get("ProcessInfo.Modules")
		};
		tabPage2 = new TabPage
		{
			Name = "threadsTab",
			Text = UiText.Get("ProcessInfo.Threads")
		};
		tabControl = new ModernTabControl
		{
			Name = "processDetailsTabs"
		};
		tabControl.TabPages.Add(tabPage);
		tabControl.TabPages.Add(tabPage2);

		timer = new Timer(container)
		{
			Interval = 250
		};
		timer.Tick += OnProcessExitTimerTick;

		AutoScaleDimensions = new SizeF(96f, 96f);
		AutoScaleMode = AutoScaleMode.Dpi;
		BackColor = ModernUi.Window;
		Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		Name = "ProcessInspectorForm";
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = UiText.Get("ProcessInfo.Title");
		Icon = new ComponentResourceManager(typeof(ProcessInspectorForm)).GetObject("$this.Icon") as Icon;
		Load += OnFormLoad;
	}

	private static Button CreateButton(string name, string textKey, EventHandler handler)
	{
		var result = new Button
		{
			Name = name,
			Text = UiText.Get(textKey)
		};
		result.Click += handler;
		return result;
	}

	private static DataGridViewTextBoxColumn CreateColumn(
		string name,
		string textKey,
		DataGridViewAutoSizeColumnMode autoSizeMode,
		int width = 100)
	{
		return new DataGridViewTextBoxColumn
		{
			AutoSizeMode = autoSizeMode,
			HeaderText = UiText.Get(textKey),
			Name = name,
			ReadOnly = true,
			Width = width
		};
	}

	private static DataGridView CreateGrid(string name, params DataGridViewColumn[] columns)
	{
		var result = new DataGridView
		{
			AllowUserToAddRows = false,
			AllowUserToDeleteRows = false,
			AllowUserToResizeRows = false,
			AutoGenerateColumns = false,
			ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
			MultiSelect = false,
			Name = name,
			ReadOnly = true,
			RowHeadersVisible = false,
			SelectionMode = DataGridViewSelectionMode.FullRowSelect
		};
		result.Columns.AddRange(columns);
		return result;
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
		if (SelectedProcess == null)
		{
			return;
		}

		this.dataGridView.Rows.Clear();
		this.dataGridView2.Rows.Clear();
		ProcessModuleCollection modules = RecoveredRuntime.CaptureProcessModules(SelectedProcess);
		List<ProcessThreadInfo> threads = RecoveredRuntime.EnumerateProcessThreads(SelectedProcess);
		foreach (ProcessModuleInfo module in modules)
		{
			if (!module.GetIsManualMapped())
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow
				{
					Tag = module
				};
				dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
				{
					Value = module.GetFilePath(),
					Tag = module.GetFilePath()
				});
				dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
				{
					Value = "0x" + module.GetModuleBase().ToString("X"),
					Tag = module.GetModuleBase().ToInt64()
				});
				dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell
				{
					Value = RecoveredRuntime.FormatByteSize((long)((ulong)module.GetImageSize())),
					Tag = module.GetImageSize()
				});
				this.dataGridView.Rows.Add(dataGridViewRow);
			}
		}
		using (Icon icon = RecoveredRuntime.GetFileIcon(SelectedProcess.FilePath, IconSize.Large))
		{
			Image oldImage = this.pictureBox.BackgroundImage;
			this.pictureBox.BackgroundImage = ((icon == null) ? null : icon.ToBitmap());
			oldImage?.Dispose();
		}
		this.label.Text = UiText.Format(
			"ProcessInfo.Summary",
			SelectedProcess.Name,
			SelectedProcess.FilePath,
			SelectedProcess.ProcessId,
			modules.Count,
			threads.Count);
		foreach (ProcessThreadInfo thread in threads)
		{
			DataGridViewRow dataGridViewRow2 = new DataGridViewRow
			{
				Tag = thread
			};
			dataGridViewRow2.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = thread.GetThreadId().ToString(),
				Tag = thread.GetThreadId()
			});
			dataGridViewRow2.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = ProcessInspectorForm.FormatAddress(modules, thread.GetStartAddress()),
				Tag = thread.GetStartAddress()
			});
			dataGridViewRow2.Cells.Add(new DataGridViewTextBoxCell
			{
				Value = RecoveredRuntime.FormatThreadPriority(thread.GetPriorityLevel()),
				Tag = thread.GetPriorityLevel()
			});
			this.dataGridView2.Rows.Add(dataGridViewRow2);
		}
	}

	internal static string FormatAddress(IEnumerable<ProcessModuleInfo> items, IntPtr address)
	{
		foreach (ProcessModuleInfo module in items)
		{
			if ((long)address >= (long)module.GetModuleBase() && (long)address <= (long)module.GetModuleBase() + (long)((ulong)module.GetImageSize()))
			{
				List<ExportedSymbol> exports = RecoveredRuntime.GetRemoteModuleExports(module);
				uint relativeAddress = (uint)((long)address - (long)module.GetModuleBase());
				ExportedSymbol nearestExport = null;
				foreach (ExportedSymbol export in exports)
				{
					if (relativeAddress >= export.GetAddressRva() && (nearestExport == null || export.GetAddressRva() > nearestExport.GetAddressRva()))
					{
						nearestExport = export;
					}
				}
				if (nearestExport != null)
				{
					uint offset = relativeAddress - nearestExport.GetAddressRva();
					string exportName = nearestExport.GetHasName() ? nearestExport.GetName() : nearestExport.GetOrdinal().ToString();
					return module.GetFilePath() + "!" + exportName + "+0x" + offset.ToString("X");
				}
				return module.GetFilePath() + "+0x" + relativeAddress.ToString("X");
			}
		}
		return "0x" + address.ToString("X");
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
			MessageBox.Show(this, UiText.Get("Message.Process.Terminated"), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		catch (Exception exception)
		{
			MessageBox.Show(this, UiText.Format("Message.Process.TerminateFailed", exception.Message), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
		button2.Enabled = timer.Enabled && dataGridView.SelectedRows.Count > 0;
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
		if (dataGridView.SelectedRows.Count == 0)
		{
			return;
		}

		try
		{
			ProcessModuleInfo module = (ProcessModuleInfo)this.dataGridView.SelectedRows[0].Tag;
			if (RecoveredRuntime.UnloadProcessModule(module, new RemoteModuleManager(SelectedProcess)))
			{
				this.RefreshProcessDetails();
				MessageBox.Show(this, UiText.Format("Message.Process.UnloadSucceeded", module.GetFilePath()), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show(this, UiText.Format("Message.Process.UnloadFailed", module.GetFilePath()), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(this, UiText.Format("Message.Process.UnloadError", ex.Message), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal void OnThreadSelectionChanged(object sender, EventArgs e)
	{
		bool hasSelection = this.timer.Enabled && dataGridView2.SelectedRows.Count > 0;
		this.button4.Enabled = (this.button5.Enabled = hasSelection);
		if (hasSelection)
		{
			RecoveredRuntime.UpdateThreadActionText(this);
		}
	}

	internal void OnToggleThreadSuspensionClick(object sender, EventArgs e)
	{
		if (dataGridView2.SelectedRows.Count == 0)
		{
			return;
		}

		ProcessThreadInfo thread = (ProcessThreadInfo)this.dataGridView2.SelectedRows[0].Tag;
		bool resume = this.button4.Text == UiText.Get("ProcessInfo.Resume");
		bool succeeded = resume
			? RecoveredRuntime.ResumeProcessThread(thread)
			: RecoveredRuntime.SuspendProcessThread(thread);
		string action = resume ? UiText.Get("ProcessInfo.Resume") : UiText.Get("ProcessInfo.Suspend");
		if (!succeeded)
		{
			MessageBox.Show(this, UiText.Format("Message.Process.ThreadActionFailed", action), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			MessageBox.Show(this, UiText.Format("Message.Process.ThreadActionSucceeded", action), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		RecoveredRuntime.UpdateThreadActionText(this);
	}

	internal void OnTerminateThreadClick(object sender, EventArgs e)
	{
		if (dataGridView2.SelectedRows.Count == 0)
		{
			return;
		}

		if (!RecoveredRuntime.TerminateProcessThread((ProcessThreadInfo)this.dataGridView2.SelectedRows[0].Tag))
		{
			MessageBox.Show(this, UiText.Get("Message.Process.ThreadTerminateFailed"), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		MessageBox.Show(this, UiText.Get("Message.Process.ThreadTerminated"), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
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
