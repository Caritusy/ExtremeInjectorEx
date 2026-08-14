using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed partial class ModuleOptionsForm
{
	private TableLayoutPanel moduleOptionsRootLayout;

	private void InitializeModernModuleOptionsForm(bool attachRuntimeLoadHandler)
	{
		SuspendLayout();
		container = new Container();

		AutoScaleDimensions = new SizeF(96f, 96f);
		AutoScaleMode = AutoScaleMode.Dpi;
		BackColor = ModernUi.Window;
		ClientSize = new Size(520, 500);
		Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "AdvancedModuleOptionsForm";
		ShowInTaskbar = false;
		SizeGripStyle = SizeGripStyle.Hide;
		StartPosition = FormStartPosition.CenterParent;
		Text = UiText.Get("Module.Title");

		moduleOptionsRootLayout = new TableLayoutPanel
		{
			BackColor = ModernUi.Window,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Padding = new Padding(20, 16, 20, 16),
			RowCount = 3
		};
		moduleOptionsRootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		moduleOptionsRootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62f));
		moduleOptionsRootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		moduleOptionsRootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44f));
		moduleOptionsRootLayout.Controls.Add(CreateModuleOptionsHeader(), 0, 0);
		moduleOptionsRootLayout.Controls.Add(CreateExportOptionsCard(), 0, 1);
		moduleOptionsRootLayout.Controls.Add(CreateModuleOptionsFooter(), 0, 2);
		Controls.Add(moduleOptionsRootLayout);

		if (attachRuntimeLoadHandler)
		{
			Load += OnFormLoad;
		}
		ApplyModernModuleOptionsTheme();
		ResumeLayout(performLayout: true);
	}

	private static Control CreateModuleOptionsHeader()
	{
		var header = new TableLayoutPanel
		{
			BackColor = ModernUi.Window,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			RowCount = 2
		};
		header.RowStyles.Add(new RowStyle(SizeType.Absolute, 31f));
		header.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		header.Controls.Add(new Label
		{
			AutoSize = true,
			Font = new Font("Segoe UI Semibold", 16f, FontStyle.Bold, GraphicsUnit.Point),
			ForeColor = ModernUi.TextPrimary,
			Margin = Padding.Empty,
			Text = UiText.Get("Module.Heading")
		}, 0, 0);
		header.Controls.Add(new Label
		{
			AutoSize = true,
			Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point),
			ForeColor = ModernUi.TextSecondary,
			Margin = new Padding(1, 2, 0, 0),
			Text = UiText.Get("Module.Description")
		}, 0, 1);
		return header;
	}

	private ModernCard CreateExportOptionsCard()
	{
		modernCard = new ModernCard
		{
			Dock = DockStyle.Fill,
			Margin = new Padding(0, 0, 0, 8),
			Name = "exportGroupBox",
			Text = UiText.Get("Module.ExportOptions")
		};
		ModernUi.StyleCard(modernCard);

		label = CreateModuleFieldLabel("exportFunctionLabel", UiText.Get("Module.ExportFunction"));
		label2 = CreateModuleFieldLabel("callingConventionLabel", UiText.Get("Module.CallingConvention"));
		label3 = CreateModuleFieldLabel("parametersLabel", UiText.Get("Module.Parameters"));

		exportRoutineComboBox = CreateModuleComboBox("exportFunctionComboBox");
		exportRoutineComboBox.SelectedIndexChanged += OnExportSelectionChanged;
		callingConventionComboBox = CreateModuleComboBox("callingConvComboBox");
		callingConventionComboBox.SelectedIndexChanged += OnCallingConventionChanged;
		parameterTypeComboBox = CreateModuleComboBox("paramTypeComboBox");

		parameterValueTextBox = new TextBox
		{
			Dock = DockStyle.Fill,
			Margin = new Padding(8, 0, 8, 0),
			Name = "argValueTextBox"
		};
		ModernUi.StyleTextBox(parameterValueTextBox);

		button = new Button
		{
			Enabled = false,
			Name = "addButton",
			Text = UiText.Get("Module.Add")
		};
		button.Click += OnAddParameterClick;
		button.EnabledChanged += (sender, args) => ApplyModernModuleOptionsTheme();

		dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
		{
			AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
			HeaderText = UiText.Get("Module.Number"),
			Name = "NumberColumn",
			ReadOnly = true,
			SortMode = DataGridViewColumnSortMode.NotSortable,
			Width = 42
		};
		dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn
		{
			AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
			HeaderText = UiText.Get("Module.Type"),
			Name = "TypeColumn",
			ReadOnly = true,
			SortMode = DataGridViewColumnSortMode.NotSortable,
			Width = 112
		};
		dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn
		{
			AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
			HeaderText = UiText.Get("Module.Value"),
			Name = "ValueColumn",
			ReadOnly = true,
			SortMode = DataGridViewColumnSortMode.NotSortable
		};

		parametersGrid = new DataGridView
		{
			AllowUserToAddRows = false,
			AllowUserToDeleteRows = true,
			AllowUserToResizeRows = false,
			AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders,
			Dock = DockStyle.Fill,
			EditMode = DataGridViewEditMode.EditProgrammatically,
			Margin = Padding.Empty,
			MultiSelect = false,
			Name = "paramDataGridView",
			ReadOnly = true,
			SelectionMode = DataGridViewSelectionMode.FullRowSelect
		};
		parametersGrid.Columns.AddRange(
			dataGridViewTextBoxColumn,
			dataGridViewTextBoxColumn2,
			dataGridViewTextBoxColumn3);
		parametersGrid.RowsAdded += OnParameterRowsAdded;
		parametersGrid.RowsRemoved += OnParameterRowsRemoved;

		var layout = new TableLayoutPanel
		{
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(0, 6, 0, 0),
			RowCount = 7
		};
		layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34f));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34f));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
		layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42f));
		exportRoutineComboBox.Dock = DockStyle.Fill;
		exportRoutineComboBox.Margin = new Padding(0, 0, 0, 6);
		callingConventionComboBox.Dock = DockStyle.Fill;
		callingConventionComboBox.Margin = new Padding(0, 0, 0, 6);
		layout.Controls.Add(label, 0, 0);
		layout.Controls.Add(exportRoutineComboBox, 0, 1);
		layout.Controls.Add(label2, 0, 2);
		layout.Controls.Add(callingConventionComboBox, 0, 3);
		layout.Controls.Add(label3, 0, 4);
		layout.Controls.Add(parametersGrid, 0, 5);
		layout.Controls.Add(CreateParameterEntryRow(), 0, 6);
		modernCard.Controls.Add(layout);
		return modernCard;
	}

	private Control CreateParameterEntryRow()
	{
		var row = new TableLayoutPanel
		{
			ColumnCount = 3,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(0, 8, 0, 0),
			RowCount = 1
		};
		row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118f));
		row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		row.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
		parameterTypeComboBox.Dock = DockStyle.Fill;
		parameterTypeComboBox.Margin = Padding.Empty;
		button.Dock = DockStyle.Fill;
		button.Margin = Padding.Empty;
		row.Controls.Add(parameterTypeComboBox, 0, 0);
		row.Controls.Add(parameterValueTextBox, 1, 0);
		row.Controls.Add(button, 2, 0);
		return row;
	}

	private Control CreateModuleOptionsFooter()
	{
		var closeButton = new Button
		{
			DialogResult = DialogResult.OK,
			Name = "closeButton",
			Text = UiText.Get("Module.Done")
		};
		closeButton.Click += (sender, args) => Close();
		var footer = new FlowLayoutPanel
		{
			BackColor = ModernUi.Window,
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.RightToLeft,
			Margin = Padding.Empty,
			Padding = new Padding(0, 7, 0, 0),
			WrapContents = false
		};
		footer.Controls.Add(closeButton);
		AcceptButton = closeButton;
		return footer;
	}

	private void ApplyModernModuleOptionsTheme()
	{
		Color accent = ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1);
		Color secondary = ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor2);
		ModernUi.StyleDataGridView(parametersGrid, accent);
		ModernUi.StylePrimaryButton(button, accent, ModernUi.HarmonizeInteractiveColor(accent, secondary));
		if (AcceptButton is Button closeButton)
		{
			ModernUi.StyleSecondaryButton(closeButton, accent);
		}
	}

	private static Label CreateModuleFieldLabel(string name, string text)
	{
		var label = new Label
		{
			Anchor = AnchorStyles.Left,
			Name = name,
			Text = text
		};
		ModernUi.StyleFieldLabel(label);
		return label;
	}

	private static ComboBox CreateModuleComboBox(string name)
	{
		var comboBox = new ComboBox { Name = name };
		ModernUi.StyleComboBox(comboBox);
		return comboBox;
	}

	protected override void OnDpiChanged(DpiChangedEventArgs e)
	{
		base.OnDpiChanged(e);
		ApplyModernModuleOptionsTheme();
		PerformLayout();
	}
}
