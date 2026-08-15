using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

public sealed partial class ManualMapOptionsForm
{
	private void InitializeModernManualMapOptionsForm()
	{
		SuspendLayout();
		container = new Container();

		AutoScaleDimensions = new SizeF(96f, 96f);
		AutoScaleMode = AutoScaleMode.Dpi;
		BackColor = ModernUi.Window;
		ClientSize = new Size(600, 330);
		Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "ManualMapOptionsForm";
		ShowInTaskbar = false;
		SizeGripStyle = SizeGripStyle.Hide;
		StartPosition = FormStartPosition.CenterParent;
		Text = UiText.Get("ManualMap.Title");

		var resources = new ComponentResourceManager(typeof(ManualMapOptionsForm));
		Icon = resources.GetObject("$this.Icon") as Icon;

		checkBox2 = CreateManualMapCheckBox("manualResolveImportsCheckBox", "ManualMap.MapImports", OnManualResolveImportsChanged);
		checkBox = CreateManualMapCheckBox("disableExceptionSupportCheckBox", "ManualMap.DisableExceptions", OnDisableExceptionSupportChanged);
		checkBox3 = CreateManualMapCheckBox("hideThreadsCheckBox", "ManualMap.HideThreads", OnHideFromDebuggerChanged);
		checkBox4 = CreateManualMapCheckBox("disableSehValidationCheckBox", "ManualMap.DisableSehValidation", OnDisableSehValidationChanged);

		var cards = new TableLayoutPanel
		{
			ColumnCount = 2,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			RowCount = 1
		};
		cards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		cards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		cards.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		ModernCard mappingCard = CreateManualMapCard(UiText.Get("ManualMap.Options"), checkBox2, checkBox);
		ModernCard generalCard = CreateManualMapCard(UiText.Get("ManualMap.General"), checkBox3, checkBox4);
		mappingCard.Margin = new Padding(0, 0, 6, 0);
		generalCard.Margin = new Padding(6, 0, 0, 0);
		cards.Controls.Add(mappingCard, 0, 0);
		cards.Controls.Add(generalCard, 1, 0);

		var closeButton = new Button
		{
			DialogResult = DialogResult.OK,
			Name = "closeButton",
			Text = UiText.Get("Common.Close")
		};
		closeButton.Click += (sender, args) => Close();
		var footer = new FlowLayoutPanel
		{
			BackColor = ModernUi.Window,
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.RightToLeft,
			Margin = Padding.Empty,
			Padding = new Padding(0, 8, 0, 0),
			WrapContents = false
		};
		footer.Controls.Add(closeButton);

		var root = new TableLayoutPanel
		{
			BackColor = ModernUi.Window,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(20, 16, 20, 16),
			RowCount = 3
		};
		root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		root.RowStyles.Add(new RowStyle(SizeType.Absolute, 62f));
		root.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		root.RowStyles.Add(new RowStyle(SizeType.Absolute, 44f));
		root.Controls.Add(CreateManualMapHeader(), 0, 0);
		root.Controls.Add(cards, 0, 1);
		root.Controls.Add(footer, 0, 2);
		Controls.Add(root);

		AcceptButton = closeButton;
		CancelButton = closeButton;
		ApplyModernManualMapTheme(closeButton);
		ResumeLayout(performLayout: true);
	}

	private static Control CreateManualMapHeader()
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
			Text = UiText.Get("ManualMap.Title")
		}, 0, 0);
		header.Controls.Add(new Label
		{
			AutoSize = true,
			ForeColor = ModernUi.TextSecondary,
			Margin = new Padding(1, 2, 0, 0),
			Text = UiText.Get("ManualMap.Description")
		}, 0, 1);
		return header;
	}

	private static ModernCard CreateManualMapCard(string title, params CheckBox[] checkBoxes)
	{
		var card = new ModernCard
		{
			Dock = DockStyle.Fill,
			Text = title
		};
		ModernUi.StyleCard(card);
		var options = new FlowLayoutPanel
		{
			BackColor = ModernUi.Surface,
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.TopDown,
			Margin = Padding.Empty,
			Padding = new Padding(0, 6, 0, 0),
			WrapContents = false
		};
		foreach (CheckBox checkBox in checkBoxes)
		{
			checkBox.Margin = new Padding(0, 3, 0, 7);
			options.Controls.Add(checkBox);
		}
		card.Controls.Add(options);
		return card;
	}

	private static CheckBox CreateManualMapCheckBox(string name, string textKey, System.EventHandler handler)
	{
		var checkBox = new CheckBox
		{
			Name = name,
			Text = UiText.Get(textKey)
		};
		ModernUi.StyleCheckBox(checkBox);
		checkBox.CheckedChanged += handler;
		return checkBox;
	}

	private static void ApplyModernManualMapTheme(Button closeButton)
	{
		Color accent = ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1);
		ModernUi.StylePrimaryButton(closeButton, accent, ModernUi.Darken(accent, 0.08f));
	}
}
