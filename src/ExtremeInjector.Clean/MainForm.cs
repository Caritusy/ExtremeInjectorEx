using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

public sealed class MainForm : Form
{
	public sealed class ModuleRow
	{
		public ModuleEntry Entry { get; }

		public ModuleRow(ModuleEntry entry)
		{
			Entry = entry ?? new ModuleEntry
			{
				Enabled = true
			};
		}
	}

	internal RemoteProcess selectedProcess;
	private int? lastAutoInjectedProcessId;

	internal static readonly Dictionary<InjectionMethod, Type> InjectorBackendTypes = new Dictionary<InjectionMethod, Type>
	{
		{ InjectionMethod.StandardInjection, typeof(LoadLibraryInjector) },
		{ InjectionMethod.LdrpLoadDll, typeof(LdrLoadDllInjector) },
		{ InjectionMethod.LdrpLoadDllStub, typeof(LdrLoadDllStubInjector) },
		{ InjectionMethod.ThreadHijacking, typeof(ThreadHijackInjector) }
	};

	internal IContainer icontainer_0;
	internal Label processNameLabel;
	internal TextBox processNameTextBox;
	internal Button selectProcessButton;
	internal PictureBox processIconPictureBox;
	internal Label processDescriptionLabel;
	internal System.Windows.Forms.Timer processRefreshTimer;
	internal Panel mainPanel;
	internal Label injectionListLabel;
	internal DataGridView moduleGrid;
	internal Button clearButton;
	internal Button removeButton;
	internal Button toggleButton;
	internal Button addDllButton;
	internal Button injectButton;
	internal Button aboutButton;
	internal Button settingsButton;
	internal DataGridViewCheckBoxColumn enabledColumn;
	internal DataGridViewTextBoxColumn dllNameColumn;
	internal DataGridViewButtonColumn exportOptionsColumn;
	private Panel processSurface;
	private Panel processNameFrame;

	public MainForm()
		: this(initializeRuntime: true)
	{
	}

	internal MainForm(bool initializeRuntime)
	{
		InitializeModernComponents();
		if (!initializeRuntime)
		{
			ApplyModernTheme();
			UpdateWindowTitle();
			return;
		}

		Class171.smethod_341();
		processRefreshTimer.Start();
		Class171.smethod_4(Class10.class10_0, moduleGrid.Handle);
		Class10.class10_0.method_0(OnModulesDropped);

		if (Class127.bool_1)
		{
			moduleGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		}

		foreach (ModuleEntry module in ApplicationSettings.Current.Modules)
		{
			Class171.AddModuleToGrid(module.Enabled, module, bool_1: false, this, module.Path);
		}

		processNameTextBox.Text = ApplicationSettings.Current.ProcessName;
		ApplyModernTheme();

		if (DateTime.Now.Subtract(ApplicationSettings.Current.LastUpdateCheck).TotalDays >= 7.0)
		{
			ApplicationSettings.Current.LastUpdateCheck = DateTime.Now;
			ThreadPool.QueueUserWorkItem(_ => Class171.smethod_408());
		}

		UpdateWindowTitle();
		ApplicationSettings.Save();
	}

	private void InitializeModernComponents()
	{
		icontainer_0 = new Container();
		processRefreshTimer = new System.Windows.Forms.Timer(icontainer_0);
		processNameLabel = new Label();
		processNameTextBox = new TextBox();
		selectProcessButton = new Button();
		processIconPictureBox = new PictureBox();
		processDescriptionLabel = new Label();
		mainPanel = new Panel();
		injectionListLabel = new Label();
		moduleGrid = new EmptyStateDataGridView();
		clearButton = new Button();
		removeButton = new Button();
		toggleButton = new Button();
		addDllButton = new Button();
		injectButton = new Button();
		aboutButton = new Button();
		settingsButton = new Button();
		enabledColumn = new DataGridViewCheckBoxColumn();
		dllNameColumn = new DataGridViewTextBoxColumn();
		exportOptionsColumn = new DataGridViewButtonColumn();
		processSurface = new Panel();
		processNameFrame = new Panel();

		SuspendLayout();
		((ISupportInitialize)processIconPictureBox).BeginInit();
		((ISupportInitialize)moduleGrid).BeginInit();

		AutoScaleDimensions = new SizeF(96f, 96f);
		AutoScaleMode = AutoScaleMode.Dpi;
		BackColor = ModernUi.Window;
		ClientSize = new Size(420, 300);
		DoubleBuffered = true;
		Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		FormBorderStyle = FormBorderStyle.Sizable;
		MaximizeBox = false;
		MinimumSize = new Size(420, 320);
		Name = "MainForm";
		Padding = new Padding(12);
		StartPosition = FormStartPosition.CenterScreen;

		var resources = new ComponentResourceManager(typeof(MainForm));
		Icon = resources.GetObject("$this.Icon") as Icon;

		var rootLayout = new TableLayoutPanel
		{
			AutoSize = false,
			BackColor = ModernUi.Window,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = Padding.Empty,
			RowCount = 3
		};
		rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		rootLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		rootLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

		var processBlock = new TableLayoutPanel
		{
			AutoSize = true,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = new Padding(0, 0, 0, 10),
			RowCount = 2
		};
		processBlock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		processBlock.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		processBlock.RowStyles.Add(new RowStyle(SizeType.AutoSize));

		processNameLabel.AutoSize = true;
		processNameLabel.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point);
		processNameLabel.ForeColor = ModernUi.TextPrimary;
		processNameLabel.Margin = new Padding(0, 0, 0, 5);
		processNameLabel.Name = "processNameLabel";
		processNameLabel.Text = "Target process";

		processSurface.AutoSize = true;
		processSurface.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		processSurface.BackColor = ModernUi.Window;
		processSurface.BorderStyle = BorderStyle.None;
		processSurface.Dock = DockStyle.Fill;
		processSurface.Margin = Padding.Empty;
		processSurface.Padding = Padding.Empty;

		var processLayout = new TableLayoutPanel
		{
			AutoSize = true,
			BackColor = ModernUi.Window,
			ColumnCount = 3,
			Dock = DockStyle.Top,
			Margin = Padding.Empty,
			RowCount = 1
		};
		processLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36f));
		processLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		processLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

		processIconPictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Top;
		processIconPictureBox.BackColor = ModernUi.Window;
		processIconPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
		processIconPictureBox.Cursor = Cursors.Default;
		processIconPictureBox.Margin = new Padding(0, 1, 8, 0);
		processIconPictureBox.MinimumSize = new Size(28, 28);
		processIconPictureBox.Name = "processIconPictureBox";
		processIconPictureBox.Size = new Size(28, 28);
		processIconPictureBox.TabStop = false;
		processIconPictureBox.Click += OnProcessIconClicked;

		var processTextLayout = new TableLayoutPanel
		{
			AutoSize = true,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = new Padding(0, 0, 8, 0),
			RowCount = 2
		};
		processTextLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		processTextLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		processTextLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

		processNameFrame.BackColor = ModernUi.Surface;
		processNameFrame.BorderStyle = BorderStyle.FixedSingle;
		processNameFrame.AutoSize = true;
		processNameFrame.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		processNameFrame.Dock = DockStyle.Top;
		processNameFrame.Margin = Padding.Empty;
		processNameFrame.Padding = new Padding(8, 6, 8, 4);

		processNameTextBox.BorderStyle = BorderStyle.None;
		processNameTextBox.Dock = DockStyle.Top;
		processNameTextBox.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		processNameTextBox.Margin = Padding.Empty;
		processNameTextBox.Name = "processNameTextBox";
		processNameTextBox.TabIndex = 0;
		processNameTextBox.TextChanged += OnProcessNameChanged;
		processNameFrame.Controls.Add(processNameTextBox);

		processDescriptionLabel.AutoEllipsis = true;
		processDescriptionLabel.AutoSize = true;
		processDescriptionLabel.Dock = DockStyle.Fill;
		processDescriptionLabel.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point);
		processDescriptionLabel.ForeColor = ModernUi.TextSecondary;
		processDescriptionLabel.Margin = new Padding(1, 5, 0, 0);
		processDescriptionLabel.Name = "processDescriptionLabel";
		processDescriptionLabel.Text = "No process selected";

		processTextLayout.Controls.Add(processNameFrame, 0, 0);
		processTextLayout.Controls.Add(processDescriptionLabel, 0, 1);

		selectProcessButton.Anchor = AnchorStyles.Right | AnchorStyles.Top;
		selectProcessButton.Margin = new Padding(0, 1, 0, 0);
		selectProcessButton.MinimumSize = new Size(76, 30);
		selectProcessButton.Name = "selectProcessButton";
		selectProcessButton.TabIndex = 1;
		selectProcessButton.Text = "Select";
		selectProcessButton.Click += OnSelectProcessClicked;

		processLayout.Controls.Add(processIconPictureBox, 0, 0);
		processLayout.Controls.Add(processTextLayout, 1, 0);
		processLayout.Controls.Add(selectProcessButton, 2, 0);
		processSurface.Controls.Add(processLayout);
		processBlock.Controls.Add(processNameLabel, 0, 0);
		processBlock.Controls.Add(processSurface, 0, 1);

		mainPanel.BackColor = ModernUi.Surface;
		mainPanel.BorderStyle = BorderStyle.FixedSingle;
		mainPanel.Dock = DockStyle.Fill;
		mainPanel.Margin = Padding.Empty;
		mainPanel.Padding = Padding.Empty;

		var moduleLayout = new TableLayoutPanel
		{
			ColumnCount = 2,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			RowCount = 1
		};
		moduleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108f));
		moduleLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		moduleLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));

		var commandRail = new Panel
		{
			BackColor = ModernUi.SurfaceMuted,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(9, 10, 9, 8)
		};
		var commandLayout = new TableLayoutPanel
		{
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			RowCount = 6
		};
		commandLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		commandLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		commandLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		commandLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		commandLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		commandLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		commandLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));

		injectionListLabel.AutoSize = true;
		injectionListLabel.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point);
		injectionListLabel.ForeColor = ModernUi.TextPrimary;
		injectionListLabel.Margin = new Padding(1, 0, 0, 8);
		injectionListLabel.Name = "injectionListLabel";
		injectionListLabel.Text = "DLL list";

		addDllButton.Name = "addDllButton";
		addDllButton.Text = "Add DLL";
		addDllButton.Dock = DockStyle.Top;
		addDllButton.Margin = new Padding(0, 0, 0, 2);
		addDllButton.MinimumSize = new Size(84, 22);
		addDllButton.Click += OnAddDllClicked;
		toggleButton.Name = "toggleButton";
		toggleButton.Text = "Toggle";
		toggleButton.Dock = DockStyle.Top;
		toggleButton.Margin = new Padding(0, 0, 0, 2);
		toggleButton.MinimumSize = new Size(84, 22);
		toggleButton.Click += OnToggleModuleClicked;
		removeButton.Name = "removeButton";
		removeButton.Text = "Remove";
		removeButton.Dock = DockStyle.Top;
		removeButton.Margin = new Padding(0, 0, 0, 2);
		removeButton.MinimumSize = new Size(84, 22);
		removeButton.Click += OnRemoveModuleClicked;
		clearButton.Name = "clearButton";
		clearButton.Text = "Clear";
		clearButton.Dock = DockStyle.Top;
		clearButton.Margin = Padding.Empty;
		clearButton.MinimumSize = new Size(84, 22);
		clearButton.Click += OnClearModulesClicked;
		commandLayout.Controls.Add(injectionListLabel, 0, 0);
		commandLayout.Controls.Add(addDllButton, 0, 1);
		commandLayout.Controls.Add(toggleButton, 0, 2);
		commandLayout.Controls.Add(removeButton, 0, 3);
		commandLayout.Controls.Add(clearButton, 0, 4);
		commandRail.Controls.Add(commandLayout);

		enabledColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		enabledColumn.HeaderText = string.Empty;
		enabledColumn.Name = "enabledColumn";
		enabledColumn.Width = 38;
		dllNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		dllNameColumn.HeaderText = "DLL";
		dllNameColumn.MinimumWidth = 180;
		dllNameColumn.Name = "dllNameColumn";
		dllNameColumn.ReadOnly = true;
		exportOptionsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		exportOptionsColumn.FlatStyle = FlatStyle.Flat;
		exportOptionsColumn.HeaderText = string.Empty;
		exportOptionsColumn.Name = "exportOptionsColumn";
		exportOptionsColumn.ReadOnly = true;
		exportOptionsColumn.Text = "Options";
		exportOptionsColumn.UseColumnTextForButtonValue = true;
		exportOptionsColumn.Width = 82;

		moduleGrid.AllowUserToAddRows = false;
		moduleGrid.AllowUserToDeleteRows = false;
		moduleGrid.AllowUserToResizeRows = false;
		moduleGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
		moduleGrid.BackgroundColor = ModernUi.Surface;
		moduleGrid.BorderStyle = BorderStyle.None;
		moduleGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
		moduleGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		moduleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		moduleGrid.Columns.AddRange(enabledColumn, dllNameColumn, exportOptionsColumn);
		moduleGrid.Dock = DockStyle.Fill;
		moduleGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
		moduleGrid.GridColor = ModernUi.Border;
		moduleGrid.Margin = Padding.Empty;
		moduleGrid.MultiSelect = false;
		moduleGrid.Name = "moduleGrid";
		moduleGrid.RowHeadersVisible = false;
		moduleGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		moduleGrid.TabIndex = 2;
		moduleGrid.CellMouseUp += OnModuleGridCellMouseUp;
		moduleGrid.SelectionChanged += OnModuleSelectionChanged;
		moduleGrid.RowsAdded += OnModuleRowsChanged;
		moduleGrid.RowsRemoved += OnModuleRowsChanged;

		moduleLayout.Controls.Add(commandRail, 0, 0);
		moduleLayout.Controls.Add(moduleGrid, 1, 0);
		mainPanel.Controls.Add(moduleLayout);

		var footerLayout = new TableLayoutPanel
		{
			AutoSize = true,
			ColumnCount = 4,
			Dock = DockStyle.Fill,
			Margin = new Padding(0, 10, 0, 0),
			RowCount = 1
		};
		footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
		footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
		footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
		aboutButton.Name = "aboutButton";
		aboutButton.Text = "About";
		aboutButton.Margin = new Padding(0, 0, 6, 0);
		aboutButton.MinimumSize = new Size(78, 30);
		aboutButton.Click += OnAboutClicked;
		settingsButton.Name = "settingsButton";
		settingsButton.Text = "Settings";
		settingsButton.Margin = Padding.Empty;
		settingsButton.MinimumSize = new Size(78, 30);
		settingsButton.Click += OnSettingsClicked;
		injectButton.Anchor = AnchorStyles.Right;
		injectButton.Enabled = false;
		injectButton.Margin = Padding.Empty;
		injectButton.MinimumSize = new Size(104, 32);
		injectButton.Name = "injectButton";
		injectButton.TabIndex = 3;
		injectButton.Text = "Inject";
		injectButton.Click += OnInjectClicked;
		injectButton.EnabledChanged += OnInjectButtonEnabledChanged;
		footerLayout.Controls.Add(aboutButton, 0, 0);
		footerLayout.Controls.Add(settingsButton, 1, 0);
		footerLayout.Controls.Add(injectButton, 3, 0);

		rootLayout.Controls.Add(processBlock, 0, 0);
		rootLayout.Controls.Add(mainPanel, 0, 1);
		rootLayout.Controls.Add(footerLayout, 0, 2);
		Controls.Add(rootLayout);

		AcceptButton = injectButton;
		Load += OnLoad;
		MouseUp += OnMouseUp;
		Resize += OnResize;
		processRefreshTimer.Interval = 250;
		processRefreshTimer.Tick += OnProcessRefreshTick;

		((ISupportInitialize)moduleGrid).EndInit();
		((ISupportInitialize)processIconPictureBox).EndInit();
		ResumeLayout(performLayout: true);
		UpdateModuleCommandState();
	}

	private void ApplyModernTheme()
	{
		Color accent = ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1);
		Color secondaryAccent = ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor2);
		Color hoverAccent = ModernUi.HarmonizeInteractiveColor(accent, secondaryAccent);

		BackColor = ModernUi.Window;
		processSurface.BackColor = ModernUi.Window;
		processNameFrame.BackColor = ModernUi.Surface;
		processNameTextBox.BackColor = ModernUi.Surface;
		processNameTextBox.ForeColor = ModernUi.TextPrimary;
		processNameLabel.ForeColor = ModernUi.TextPrimary;
		processDescriptionLabel.ForeColor = ModernUi.TextSecondary;
		injectionListLabel.ForeColor = ModernUi.TextPrimary;
		mainPanel.BackColor = ModernUi.Surface;

		ModernUi.StyleSecondaryButton(aboutButton, accent);
		ModernUi.StyleSecondaryButton(settingsButton, accent);
		ModernUi.StyleSecondaryButton(selectProcessButton, accent);
		ModernUi.StyleSecondaryButton(addDllButton, accent);
		ModernUi.StyleSecondaryButton(toggleButton, accent);
		ModernUi.StyleSecondaryButton(removeButton, accent);
		ModernUi.StyleQuietButton(clearButton, accent);
		ModernUi.StylePrimaryButton(injectButton, accent, hoverAccent);

		moduleGrid.BackgroundColor = ModernUi.Surface;
		moduleGrid.DefaultCellStyle.BackColor = ModernUi.Surface;
		moduleGrid.DefaultCellStyle.ForeColor = ModernUi.TextPrimary;
		moduleGrid.DefaultCellStyle.Padding = ScalePadding(8, 6, 8, 6);
		moduleGrid.DefaultCellStyle.SelectionBackColor = ModernUi.Blend(accent, Color.White, 0.82f);
		moduleGrid.DefaultCellStyle.SelectionForeColor = ModernUi.TextPrimary;
		moduleGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 251, 252);
		moduleGrid.ColumnHeadersDefaultCellStyle.BackColor = ModernUi.SurfaceMuted;
		moduleGrid.ColumnHeadersDefaultCellStyle.ForeColor = ModernUi.TextSecondary;
		moduleGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 8.75f, FontStyle.Bold, GraphicsUnit.Point);
		moduleGrid.ColumnHeadersDefaultCellStyle.Padding = ScalePadding(8, 8, 8, 8);
		moduleGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = ModernUi.SurfaceMuted;
		moduleGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = ModernUi.TextSecondary;
		moduleGrid.EnableHeadersVisualStyles = false;
		enabledColumn.Width = ScaleLogical(38);
		dllNameColumn.MinimumWidth = ScaleLogical(160);
		exportOptionsColumn.Width = ScaleLogical(82);
		enabledColumn.HeaderCell.Style.BackColor = ModernUi.SurfaceMuted;
		dllNameColumn.HeaderCell.Style.BackColor = ModernUi.SurfaceMuted;
		exportOptionsColumn.HeaderCell.Style.BackColor = ModernUi.SurfaceMuted;
		((EmptyStateDataGridView)moduleGrid).RefreshContentMetrics();
	}

	private int ScaleLogical(int value)
	{
		return (int)Math.Round(value * Math.Max(1f, DeviceDpi / 96f));
	}

	private Padding ScalePadding(int left, int top, int right, int bottom)
	{
		float scale = Math.Max(1f, DeviceDpi / 96f);
		return new Padding(
			(int)Math.Round(left * scale),
			(int)Math.Round(top * scale),
			(int)Math.Round(right * scale),
			(int)Math.Round(bottom * scale));
	}

	private void UpdateWindowTitle()
	{
		Version version = Assembly.GetExecutingAssembly().GetName().Version;
		Text = string.Format("Extreme Injector Ex {0}.{1}.{2}", version.Major, version.Minor, version.Build);
	}

	private void OnModuleSelectionChanged(object sender, EventArgs e)
	{
		UpdateModuleCommandState();
	}

	private void OnInjectButtonEnabledChanged(object sender, EventArgs e)
	{
		ApplyModernTheme();
	}

	private void OnModuleRowsChanged(object sender, EventArgs e)
	{
		UpdateModuleCommandState();
	}

	private void UpdateModuleCommandState()
	{
		bool hasRows = moduleGrid.Rows.Count != 0;
		bool hasSelection = moduleGrid.SelectedRows.Count != 0;
		clearButton.Enabled = hasRows;
		removeButton.Enabled = hasSelection;
		toggleButton.Enabled = hasSelection;
	}

	internal void QueueInjectionWorkflow(ModuleRow[] modules, ScramblePreset scramblePreset)
	{
		ThreadPool.QueueUserWorkItem(_ => RunInjectionWorkflow(modules, scramblePreset));
	}

	private void RunInjectionWorkflow(ModuleRow[] modules, ScramblePreset scramblePreset)
	{
		bool attemptedInjection = false;
		bool allModulesSucceeded = true;

		foreach (ModuleRow module in modules)
		{
			string modulePath = module.Entry.Path;
			if (!File.Exists(modulePath))
			{
				continue;
			}

			string moduleName = Path.GetFileName(modulePath);
			SetProcessStatus("Injecting " + moduleName + "...");
			Class171.WaitWithStatus(this, ApplicationSettings.Current.Options.DelayBeforeInjection, "Waiting {0} seconds before injection...");

			IntPtr moduleBase = IntPtr.Zero;
			attemptedInjection = true;
			bool moduleSucceeded = Class171.InjectModule(ref moduleBase, this, scramblePreset, modulePath);

			if (moduleSucceeded && !string.IsNullOrEmpty(module.Entry.ExportName))
			{
				SetProcessStatus("Running export routine... (" + moduleName + ")");
				try
				{
					moduleSucceeded = Class171.InvokeExport(module, moduleBase, this);
				}
				catch (Exception exception)
				{
					Class171.ShowInjectionError(this, "An error occurred while running the export routine.", exception);
					moduleSucceeded = false;
				}
			}

			allModulesSucceeded &= moduleSucceeded;

			Class171.WaitWithStatus(this, ApplicationSettings.Current.Options.DelayBetweenModules, "Waiting {0} seconds before injecting the next DLL...");
		}

		bool injectionSucceeded = attemptedInjection && allModulesSucceeded;
		Invoke((Action)(() => Class171.CompleteInjection(injectionSucceeded, this)));
	}

	private void SetProcessStatus(string status)
	{
		Invoke((Action)(() => processDescriptionLabel.Text = status));
	}

	internal void OnSelectProcessClicked(object sender, EventArgs e)
	{
		RemoteProcess process = Class171.SelectProcess();
		if (process == null)
		{
			return;
		}

		processNameTextBox.Text = process.Name;
		Class171.SetSelectedProcess(this, process);
	}

	internal void OnProcessNameChanged(object sender, EventArgs e)
	{
		Class171.ResolveSelectedProcess(this);
	}

	internal void OnProcessRefreshTick(object sender, EventArgs e)
	{
		if (selectedProcess == null || Class171.HasProcessExited(selectedProcess))
		{
			processRefreshTimer.Stop();
			Class171.ResolveSelectedProcess(this);
			processRefreshTimer.Start();
		}

		if (selectedProcess == null || !ApplicationSettings.Current.Options.AutoInject)
		{
			return;
		}

		if (lastAutoInjectedProcessId == selectedProcess.ProcessId)
		{
			return;
		}

		if (Class171.GetEnabledModuleRows(this).Length == 0)
		{
			return;
		}

		lastAutoInjectedProcessId = selectedProcess.ProcessId;
		processRefreshTimer.Stop();
		Class171.BeginInjection(this);
	}

	internal void OnBackgroundPaint(object sender, PaintEventArgs e)
	{
		if (ClientSize.IsEmpty)
		{
			return;
		}

		Rectangle bounds = new Rectangle(Point.Empty, ClientSize);
		using (LinearGradientBrush brush = new LinearGradientBrush(
			bounds,
			ApplicationSettings.Current.Options.BackgroundColor1,
			ApplicationSettings.Current.Options.BackgroundColor2,
			90f))
		{
			e.Graphics.FillRectangle(brush, bounds);
		}
	}

	internal void OnClearModulesClicked(object sender, EventArgs e)
	{
		moduleGrid.Rows.Clear();
		ApplicationSettings.Current.Modules.Clear();
		ApplicationSettings.Save();
	}

	internal void OnRemoveModuleClicked(object sender, EventArgs e)
	{
		if (moduleGrid.SelectedRows.Count == 0)
		{
			return;
		}

		DataGridViewRow selectedRow = moduleGrid.SelectedRows[0];
		moduleGrid.Rows.Remove(selectedRow);
		ApplicationSettings.Current.Modules.Remove(((ModuleRow)selectedRow.Tag).Entry);
		ApplicationSettings.Save();
	}

	internal void OnToggleModuleClicked(object sender, EventArgs e)
	{
		if (moduleGrid.SelectedRows.Count != 0)
		{
			Class171.ToggleModuleEnabled(this, moduleGrid.SelectedRows[0].Index);
		}
	}

	internal void OnAddDllClicked(object sender, EventArgs e)
	{
		using (OpenFileDialog dialog = new OpenFileDialog { Filter = "DLL Files|*.dll" })
		{
			if (dialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			Class171.AddModuleToGrid(bool_0: true, null, bool_1: true, this, dialog.FileName);
			ApplicationSettings.Save();
		}
	}

	internal void OnModuleGridCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (e.RowIndex < 0)
		{
			return;
		}

		if (e.ColumnIndex == enabledColumn.Index)
		{
			Class171.ToggleModuleEnabled(this, e.RowIndex);
		}
		else if (e.ColumnIndex == exportOptionsColumn.Index)
		{
			Class171.EditModuleOptions((ModuleRow)moduleGrid.Rows[e.RowIndex].Tag);
		}
	}

	internal void OnProcessIconClicked(object sender, EventArgs e)
	{
		if (selectedProcess != null)
		{
			Class171.ShowProcessInspector(selectedProcess);
		}
	}

	internal void OnResize(object sender, EventArgs e)
	{
		Refresh();
	}

	internal void OnAboutClicked(object sender, EventArgs e)
	{
		using (AboutForm aboutForm = new AboutForm())
		{
			aboutForm.ShowDialog(this);
		}
	}

	internal void OnSettingsClicked(object sender, EventArgs e)
	{
		Class171.ShowSettings(selectedProcess);
		Invalidate();
		ApplyModernTheme();
	}

	internal void OnInjectClicked(object sender, EventArgs e)
	{
		Class171.BeginInjection(this);
	}

	internal void OnLoad(object sender, EventArgs e)
	{
		DoubleBuffered = true;
		ApplyModernTheme();
		if (Program.UsesExternalSettings)
		{
			Text = Class171.smethod_275(Class127.random_0.Next(10, 25));
		}
	}

	internal void OnMouseUp(object sender, MouseEventArgs e)
	{
		if (injectButton.Enabled || GetChildAtPoint(e.Location) != injectButton)
		{
			return;
		}

		if (ApplicationSettings.Current.Options.AutoInject)
		{
			MessageBox.Show(
				"Extreme Injector Ex is waiting for the specified process (" + processNameTextBox.Text + ") to start because auto-inject is enabled. Injection will begin when the process starts.",
				"Extreme Injector Ex",
				MessageBoxButtons.OK,
				MessageBoxIcon.Asterisk);
		}
		else if (string.IsNullOrEmpty(processNameTextBox.Text))
		{
			MessageBox.Show(
				"You have not selected or entered a process to be injected.",
				"Extreme Injector Ex",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation);
		}
		else
		{
			MessageBox.Show(
				"You have not selected or entered a process that is currently running.",
				"Extreme Injector Ex",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation);
		}
	}

	internal void OnModulesDropped(object sender, EventArgs0 e)
	{
		foreach (string modulePath in e.method_1())
		{
			Class171.AddModuleToGrid(bool_0: true, null, bool_1: true, this, modulePath);
		}

		ApplicationSettings.Save();
	}

	protected override void OnDpiChanged(DpiChangedEventArgs e)
	{
		base.OnDpiChanged(e);
		ApplyModernTheme();
		PerformLayout();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			icontainer_0?.Dispose();
		}

		base.Dispose(disposing);
	}
}
