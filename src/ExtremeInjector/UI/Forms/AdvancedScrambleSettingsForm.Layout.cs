using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

public sealed partial class AdvancedScrambleSettingsForm
{
	private void InitializeModernScrambleSettingsForm()
	{
		SuspendLayout();
		container = new Container();

		AutoScaleDimensions = new SizeF(96f, 96f);
		AutoScaleMode = AutoScaleMode.Dpi;
		BackColor = ModernUi.Window;
		ClientSize = new Size(780, 480);
		Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "AdvancedScrambleSettingsForm";
		ShowInTaskbar = false;
		SizeGripStyle = SizeGripStyle.Hide;
		StartPosition = FormStartPosition.CenterParent;
		Text = UiText.Get("Scramble.Title");

		var resources = new ComponentResourceManager(typeof(AdvancedScrambleSettingsForm));
		Icon = resources.GetObject("$this.Icon") as Icon;

		checkBox = CreateScrambleCheckBox("scrambleHeaderFieldsCheckBox", "Scramble.HeaderFields");
		checkBox2 = CreateScrambleCheckBox("removeUnusedDataCheckBox", "Scramble.RemoveUselessData");
		checkBox3 = CreateScrambleCheckBox("shiftSectionDataCheckBox", "Scramble.ShiftSectionData");
		checkBox4 = CreateScrambleCheckBox("insertExtraSectionsCheckBox", "Scramble.InsertSections");
		checkBox5 = CreateScrambleCheckBox("modifyAssemblyCodeCheckBox", "Scramble.ModifyCode");
		checkBox6 = CreateScrambleCheckBox("renameSectionsCheckBox", "Scramble.RenameSections");
		checkBox7 = CreateScrambleCheckBox("createEntryPointCheckBox", "Scramble.NewEntryPoint");
		checkBox9 = CreateScrambleCheckBox("modifyImportTableCheckBox", "Scramble.ModifyImports");
		checkBox11 = CreateScrambleCheckBox("removeDebugDataCheckBox", "Scramble.RemoveDebug");
		checkBox8 = CreateScrambleCheckBox("moveRelocationTableCheckBox", "Scramble.MoveRelocations");
		checkBox10 = CreateScrambleCheckBox("createFakeDebugDirectoryCheckBox", "Scramble.FakeDebug");
		checkBox13 = CreateScrambleCheckBox("shiftSectionMemoryCheckBox", "Scramble.ShiftMemory");
		checkBox12 = CreateScrambleCheckBox("stripSectionCharacteristicsCheckBox", "Scramble.StripCharacteristics");

		var cards = new TableLayoutPanel
		{
			ColumnCount = 3,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			RowCount = 1
		};
		cards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31f));
		cards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34f));
		cards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35f));
		cards.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		ModernCard headerCard = CreateScrambleCard(UiText.Get("Scramble.HeaderOptions"), checkBox, checkBox2);
		ModernCard sectionCard = CreateScrambleCard(UiText.Get("Scramble.SectionOptions"), checkBox3, checkBox4, checkBox5, checkBox6, checkBox7);
		ModernCard directoryCard = CreateScrambleCard(UiText.Get("Scramble.DirectoryOptions"), checkBox9, checkBox11, checkBox8, checkBox10, checkBox13, checkBox12);
		headerCard.Margin = new Padding(0, 0, 6, 0);
		sectionCard.Margin = new Padding(6, 0, 6, 0);
		directoryCard.Margin = new Padding(6, 0, 0, 0);
		cards.Controls.Add(headerCard, 0, 0);
		cards.Controls.Add(sectionCard, 1, 0);
		cards.Controls.Add(directoryCard, 2, 0);

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
		root.Controls.Add(CreateScrambleHeader(), 0, 0);
		root.Controls.Add(cards, 0, 1);
		root.Controls.Add(footer, 0, 2);
		Controls.Add(root);

		AcceptButton = closeButton;
		CancelButton = closeButton;
		Color accent = ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1);
		ModernUi.StylePrimaryButton(closeButton, accent, ModernUi.Darken(accent, 0.08f));
		ResumeLayout(performLayout: true);
	}

	private static Control CreateScrambleHeader()
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
			Text = UiText.Get("Scramble.Title")
		}, 0, 0);
		header.Controls.Add(new Label
		{
			AutoSize = true,
			ForeColor = ModernUi.TextSecondary,
			Margin = new Padding(1, 2, 0, 0),
			Text = UiText.Get("Scramble.Description")
		}, 0, 1);
		return header;
	}

	private static ModernCard CreateScrambleCard(string title, params CheckBox[] checkBoxes)
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

	private static CheckBox CreateScrambleCheckBox(string name, string textKey)
	{
		var checkBox = new CheckBox
		{
			Name = name,
			Text = UiText.Get(textKey)
		};
		ModernUi.StyleCheckBox(checkBox);
		return checkBox;
	}
}
