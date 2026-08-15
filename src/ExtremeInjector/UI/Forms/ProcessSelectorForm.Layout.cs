using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

public sealed partial class ProcessSelectorForm
{
	private void InitializeModernProcessSelectorForm()
	{
		SuspendLayout();
		container = new Container();

		AutoScaleDimensions = new SizeF(96f, 96f);
		AutoScaleMode = AutoScaleMode.Dpi;
		BackColor = ModernUi.Window;
		ClientSize = new Size(480, 420);
		Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "ProcessSelectorForm";
		ShowInTaskbar = false;
		SizeGripStyle = SizeGripStyle.Hide;
		StartPosition = FormStartPosition.CenterParent;
		Text = UiText.Get("ProcessList.Title");

		var resources = new ComponentResourceManager(typeof(ProcessSelectorForm));
		Icon = resources.GetObject("$this.Icon") as Icon;

		processIconColumn = new DataGridViewImageColumn
		{
			AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
			Name = "processIconColumn",
			ReadOnly = true,
			Width = 42
		};
		processNameColumn = new DataGridViewTextBoxColumn
		{
			AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
			Name = "processNameColumn",
			ReadOnly = true,
			SortMode = DataGridViewColumnSortMode.NotSortable
		};
		processGrid = new BufferedDataGridView
		{
			AllowUserToAddRows = false,
			AllowUserToDeleteRows = false,
			AllowUserToResizeColumns = false,
			AllowUserToResizeRows = false,
			ColumnHeadersVisible = false,
			Dock = DockStyle.Fill,
			EditMode = DataGridViewEditMode.EditProgrammatically,
			Margin = Padding.Empty,
			MultiSelect = false,
			Name = "processGrid",
			ReadOnly = true,
			RowHeadersVisible = false,
			RowTemplate = { Height = 36, Resizable = DataGridViewTriState.False },
			SelectionMode = DataGridViewSelectionMode.FullRowSelect
		};
		processGrid.Columns.AddRange(processIconColumn, processNameColumn);
		processGrid.CellDoubleClick += OnProcessDoubleClick;

		allProcessesButton = CreateSecondaryButton(
			"allProcessesButton",
			UiText.Get("ProcessList.Processes"),
			OnAllProcessesClick);
		windowedProcessesButton = CreateSecondaryButton(
			"windowedProcessesButton",
			UiText.Get("ProcessList.Windows"),
			OnWindowedProcessesClick);
		selectButton = new Button
		{
			Enabled = false,
			Name = "selectButton",
			Text = UiText.Get("ProcessList.Select")
		};
		selectButton.Click += OnSelectClick;
		cancelButton = CreateSecondaryButton(
			"cancelButton",
			UiText.Get("Common.Cancel"),
			OnCancelClick);
		cancelButton.DialogResult = DialogResult.Cancel;

		var filterButtons = new FlowLayoutPanel
		{
			BackColor = ModernUi.Window,
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.LeftToRight,
			Margin = Padding.Empty,
			Padding = new Padding(0, 8, 0, 0),
			WrapContents = false
		};
		allProcessesButton.Margin = new Padding(0, 0, 8, 0);
		windowedProcessesButton.Margin = Padding.Empty;
		filterButtons.Controls.Add(allProcessesButton);
		filterButtons.Controls.Add(windowedProcessesButton);

		var actionButtons = new FlowLayoutPanel
		{
			BackColor = ModernUi.Window,
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.RightToLeft,
			Margin = Padding.Empty,
			Padding = new Padding(0, 8, 0, 0),
			WrapContents = false
		};
		selectButton.Margin = Padding.Empty;
		cancelButton.Margin = new Padding(0, 0, 8, 0);
		actionButtons.Controls.Add(selectButton);
		actionButtons.Controls.Add(cancelButton);

		var rootLayout = new TableLayoutPanel
		{
			BackColor = ModernUi.Window,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(16),
			RowCount = 3
		};
		rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42f));
		rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42f));
		rootLayout.Controls.Add(processGrid, 0, 0);
		rootLayout.Controls.Add(filterButtons, 0, 1);
		rootLayout.Controls.Add(actionButtons, 0, 2);
		Controls.Add(rootLayout);

		AcceptButton = selectButton;
		CancelButton = cancelButton;
		ApplyModernProcessSelectorTheme();
		ResumeLayout(performLayout: true);
	}

	private void ApplyModernProcessSelectorTheme()
	{
		Color accent = ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1);
		Color secondary = ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor2);
		ModernUi.StyleDataGridView(processGrid, accent);
		ModernUi.StyleSecondaryButton(allProcessesButton, accent);
		ModernUi.StyleSecondaryButton(windowedProcessesButton, accent);
		ModernUi.StyleSecondaryButton(cancelButton, accent);
		ModernUi.StylePrimaryButton(
			selectButton,
			accent,
			ModernUi.HarmonizeInteractiveColor(accent, secondary));
	}

	private static Button CreateSecondaryButton(string name, string text, System.EventHandler clickHandler)
	{
		var button = new Button
		{
			Name = name,
			Text = text
		};
		button.Click += clickHandler;
		return button;
	}

	protected override void OnDpiChanged(DpiChangedEventArgs e)
	{
		base.OnDpiChanged(e);
		ApplyModernProcessSelectorTheme();
		PerformLayout();
	}

	private sealed class BufferedDataGridView : DataGridView
	{
		internal BufferedDataGridView()
		{
			DoubleBuffered = true;
		}
	}
}
