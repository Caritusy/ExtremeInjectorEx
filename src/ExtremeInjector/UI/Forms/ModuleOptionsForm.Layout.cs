using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed partial class ModuleOptionsForm
{
	private TableLayoutPanel moduleOptionsRootLayout;

	private void InitializeModernModuleOptionsForm(bool attachRuntimeLoadHandler)
	{
		SuspendLayout();
		icontainer_0 = new Container();

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
		Text = "Advanced Module Options";

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
			Load += method_4;
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
			Text = "Export invocation"
		}, 0, 0);
		header.Controls.Add(new Label
		{
			AutoSize = true,
			Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point),
			ForeColor = ModernUi.TextSecondary,
			Margin = new Padding(1, 2, 0, 0),
			Text = "Optionally call an exported routine after this module is injected."
		}, 0, 1);
		return header;
	}

	private GroupBox CreateExportOptionsCard()
	{
		groupBox_0 = new GroupBox
		{
			Dock = DockStyle.Fill,
			Margin = new Padding(0, 0, 0, 8),
			Name = "exportGroupBox",
			Text = "Export options"
		};
		ModernUi.StyleCard(groupBox_0);

		label_0 = CreateModuleFieldLabel("exportFunctionLabel", "Export function or routine");
		label_1 = CreateModuleFieldLabel("callingConventionLabel", "Calling convention");
		label_2 = CreateModuleFieldLabel("parametersLabel", "Parameters and arguments");

		comboBox_0 = CreateModuleComboBox("exportFunctionComboBox");
		comboBox_0.SelectedIndexChanged += method_5;
		comboBox_1 = CreateModuleComboBox("callingConvComboBox");
		comboBox_1.SelectedIndexChanged += method_6;
		comboBox_2 = CreateModuleComboBox("paramTypeComboBox");

		textBox_0 = new TextBox
		{
			Dock = DockStyle.Fill,
			Margin = new Padding(8, 0, 8, 0),
			Name = "argValueTextBox"
		};
		ModernUi.StyleTextBox(textBox_0);

		button_0 = new Button
		{
			Enabled = false,
			Name = "addButton",
			Text = "Add"
		};
		button_0.Click += method_7;
		button_0.EnabledChanged += (sender, args) => ApplyModernModuleOptionsTheme();

		dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn
		{
			AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
			HeaderText = "#",
			Name = "NumberColumn",
			ReadOnly = true,
			SortMode = DataGridViewColumnSortMode.NotSortable,
			Width = 42
		};
		dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn
		{
			AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
			HeaderText = "Type",
			Name = "TypeColumn",
			ReadOnly = true,
			SortMode = DataGridViewColumnSortMode.NotSortable,
			Width = 112
		};
		dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn
		{
			AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
			HeaderText = "Value",
			Name = "ValueColumn",
			ReadOnly = true,
			SortMode = DataGridViewColumnSortMode.NotSortable
		};

		dataGridView_0 = new DataGridView
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
		dataGridView_0.Columns.AddRange(
			dataGridViewTextBoxColumn_0,
			dataGridViewTextBoxColumn_1,
			dataGridViewTextBoxColumn_2);
		dataGridView_0.RowsAdded += method_8;
		dataGridView_0.RowsRemoved += method_9;

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
		comboBox_0.Dock = DockStyle.Fill;
		comboBox_0.Margin = new Padding(0, 0, 0, 6);
		comboBox_1.Dock = DockStyle.Fill;
		comboBox_1.Margin = new Padding(0, 0, 0, 6);
		layout.Controls.Add(label_0, 0, 0);
		layout.Controls.Add(comboBox_0, 0, 1);
		layout.Controls.Add(label_1, 0, 2);
		layout.Controls.Add(comboBox_1, 0, 3);
		layout.Controls.Add(label_2, 0, 4);
		layout.Controls.Add(dataGridView_0, 0, 5);
		layout.Controls.Add(CreateParameterEntryRow(), 0, 6);
		groupBox_0.Controls.Add(layout);
		return groupBox_0;
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
		comboBox_2.Dock = DockStyle.Fill;
		comboBox_2.Margin = Padding.Empty;
		button_0.Dock = DockStyle.Fill;
		button_0.Margin = Padding.Empty;
		row.Controls.Add(comboBox_2, 0, 0);
		row.Controls.Add(textBox_0, 1, 0);
		row.Controls.Add(button_0, 2, 0);
		return row;
	}

	private Control CreateModuleOptionsFooter()
	{
		var closeButton = new Button
		{
			DialogResult = DialogResult.OK,
			Name = "closeButton",
			Text = "Done"
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
		ModernUi.StyleDataGridView(dataGridView_0, accent);
		ModernUi.StylePrimaryButton(button_0, accent, ModernUi.HarmonizeInteractiveColor(accent, secondary));
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
