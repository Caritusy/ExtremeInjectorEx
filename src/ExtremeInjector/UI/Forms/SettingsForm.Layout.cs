using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed partial class SettingsForm
{
	private TableLayoutPanel settingsRootLayout;
	private Label settingsTitleLabel;
	private Label settingsDescriptionLabel;
	private Label injectionBackendLabel;
	private Label scramblePresetLabel;
	private Label languageLabel;
	private Label cliHintLabel;
	internal ComboBox languageComboBox;
	internal CheckBox randomizeWindowTitleCheckBox;

	private void InitializeModernSettingsForm()
	{
		SuspendLayout();
		icontainer_0 = new Container();
		colorDialog_0 = new ColorDialog();

		AutoScaleDimensions = new SizeF(96f, 96f);
		AutoScaleMode = AutoScaleMode.Dpi;
		BackColor = ModernUi.Window;
		ClientSize = new Size(720, 610);
		Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "SettingsForm";
		ShowInTaskbar = false;
		SizeGripStyle = SizeGripStyle.Hide;
		StartPosition = FormStartPosition.CenterParent;
		Text = UiText.Get("Settings.Title");

		var resources = new ComponentResourceManager(typeof(SettingsForm));
		if (resources.GetObject("$this.Icon") is Icon icon)
		{
			Icon = icon;
		}

		settingsRootLayout = new TableLayoutPanel
		{
			BackColor = ModernUi.Window,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Padding = new Padding(20, 16, 20, 16),
			RowCount = 4
		};
		settingsRootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		settingsRootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62f));
		settingsRootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		settingsRootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 100f));
		settingsRootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44f));

		settingsRootLayout.Controls.Add(CreateSettingsHeader(), 0, 0);
		settingsRootLayout.Controls.Add(CreateSettingsContent(), 0, 1);
		settingsRootLayout.Controls.Add(CreateToolsCard(), 0, 2);
		settingsRootLayout.Controls.Add(CreateSettingsFooter(), 0, 3);
		Controls.Add(settingsRootLayout);

		AcceptButton = button_3;
		FormClosing += OnFormClosing;
		ResumeLayout(performLayout: true);
	}

	private Control CreateSettingsHeader()
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
		settingsTitleLabel = new Label
		{
			AutoSize = true,
			Font = new Font("Segoe UI Semibold", 16f, FontStyle.Bold, GraphicsUnit.Point),
			ForeColor = ModernUi.TextPrimary,
			Margin = Padding.Empty,
			Text = UiText.Get("Settings.Title")
		};
		header.Controls.Add(settingsTitleLabel, 0, 0);
		settingsDescriptionLabel = new Label
		{
			AutoSize = true,
			Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point),
			ForeColor = ModernUi.TextSecondary,
			Margin = new Padding(1, 2, 0, 0),
			Text = UiText.Get("Settings.Description")
		};
		header.Controls.Add(settingsDescriptionLabel, 0, 1);
		return header;
	}

	private Control CreateSettingsContent()
	{
		var content = new TableLayoutPanel
		{
			BackColor = ModernUi.Window,
			ColumnCount = 2,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			RowCount = 1
		};
		content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
		content.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));

		var left = new TableLayoutPanel
		{
			BackColor = ModernUi.Window,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = new Padding(0, 0, 6, 8),
			RowCount = 2
		};
		left.RowStyles.Add(new RowStyle(SizeType.Absolute, 116f));
		left.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		left.Controls.Add(CreateInjectionMethodCard(), 0, 0);
		left.Controls.Add(CreateInjectionBehaviorCard(), 0, 1);

		var right = new TableLayoutPanel
		{
			BackColor = ModernUi.Window,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = new Padding(6, 0, 0, 8),
			RowCount = 3
		};
		right.RowStyles.Add(new RowStyle(SizeType.Absolute, 106f));
		right.RowStyles.Add(new RowStyle(SizeType.Absolute, 108f));
		right.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		right.Controls.Add(CreateScramblingCard(), 0, 0);
		right.Controls.Add(CreatePostInjectionCard(), 0, 1);
		right.Controls.Add(CreateAppearanceCard(), 0, 2);

		content.Controls.Add(left, 0, 0);
		content.Controls.Add(right, 1, 0);
		return content;
	}

	private ModernCard CreateInjectionMethodCard()
	{
		groupBox_0 = CreateCard(UiText.Get("Settings.InjectionMethod"));
		comboBox_0 = CreateComboBox("injectionMethodComboBox");
		comboBox_0.Items.AddRange(new object[]
		{
			UiText.Get("Settings.Method.Standard"),
			UiText.Get("Settings.Method.ThreadHijacking"),
			UiText.Get("Settings.Method.LdrLoadDllStub"),
			UiText.Get("Settings.Method.LdrpLoadDllStub"),
			UiText.Get("Settings.Method.ManualMap")
		});

		button_0 = CreateSecondaryButton("advancedInjectOptions", UiText.Get("Settings.Advanced"));
		button_0.Click += OnManualMapOptionsClick;

		var row = new TableLayoutPanel
		{
			ColumnCount = 2,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(0, 5, 0, 0),
			RowCount = 2
		};
		row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		row.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
		row.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
		row.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		injectionBackendLabel = CreateFieldLabel(UiText.Get("Settings.InjectionBackend"));
		row.Controls.Add(injectionBackendLabel, 0, 0);
		row.SetColumnSpan(injectionBackendLabel, 2);
		comboBox_0.Dock = DockStyle.Fill;
		comboBox_0.Margin = new Padding(0, 0, 8, 0);
		button_0.Dock = DockStyle.Fill;
		button_0.Margin = Padding.Empty;
		row.Controls.Add(comboBox_0, 0, 1);
		row.Controls.Add(button_0, 1, 1);
		groupBox_0.Controls.Add(row);
		return groupBox_0;
	}

	private ModernCard CreateInjectionBehaviorCard()
	{
		groupBox_1 = CreateCard(UiText.Get("Settings.InjectionBehavior"));
		checkBox_2 = CreateCheckBox("autoInjectCheckBox", UiText.Get("Settings.AutoInject"));
		checkBox_1 = CreateCheckBox("closeOnInjectCheckBox", UiText.Get("Settings.CloseOnInject"));
		checkBox_0 = CreateCheckBox("stealthInjectCheckBox", UiText.Get("Settings.StealthInject"));
		checkBox_2.CheckedChanged += OnAutoInjectChanged;

		label_1 = CreateFieldLabel(UiText.Get("Settings.DelayBefore"));
		label_1.Name = "injectDelayLabel";
		label_0 = CreateFieldLabel(UiText.Get("Settings.DelayBetween"));
		label_0.Name = "delayBetweenLabel";
		numericUpDown_1 = CreateDelayInput("injectDelayNumericUpDown");
		numericUpDown_0 = CreateDelayInput("delayBetweenNumericUpDown");

		var layout = new TableLayoutPanel
		{
			ColumnCount = 2,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(0, 5, 0, 0),
			RowCount = 5
		};
		layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108f));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 29f));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 29f));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34f));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 37f));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 37f));
		layout.Controls.Add(checkBox_2, 0, 0);
		layout.SetColumnSpan(checkBox_2, 2);
		layout.Controls.Add(checkBox_1, 0, 1);
		layout.SetColumnSpan(checkBox_1, 2);
		layout.Controls.Add(checkBox_0, 0, 2);
		layout.SetColumnSpan(checkBox_0, 2);
		layout.Controls.Add(label_1, 0, 3);
		layout.Controls.Add(numericUpDown_1, 1, 3);
		layout.Controls.Add(label_0, 0, 4);
		layout.Controls.Add(numericUpDown_0, 1, 4);
		groupBox_1.Controls.Add(layout);
		return groupBox_1;
	}

	private ModernCard CreateScramblingCard()
	{
		groupBox_2 = CreateCard(UiText.Get("Settings.Scrambling"));
		comboBox_1 = CreateComboBox("scramblePresetCheckBox");
		comboBox_1.Items.AddRange(GetScramblePresetLabels());
		comboBox_1.SelectedIndexChanged += OnScramblePresetChanged;
		button_1 = CreateSecondaryButton("advancedScramblingOptions", UiText.Get("Settings.Advanced"));
		button_1.Click += OnAdvancedScrambleSettingsClick;

		var layout = new TableLayoutPanel
		{
			ColumnCount = 2,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(0, 5, 0, 0),
			RowCount = 2
		};
		layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		layout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
		layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		scramblePresetLabel = CreateFieldLabel(UiText.Get("Settings.Preset"));
		layout.Controls.Add(scramblePresetLabel, 0, 0);
		layout.SetColumnSpan(scramblePresetLabel, 2);
		comboBox_1.Dock = DockStyle.Fill;
		comboBox_1.Margin = new Padding(0, 0, 8, 0);
		button_1.Dock = DockStyle.Fill;
		button_1.Margin = Padding.Empty;
		layout.Controls.Add(comboBox_1, 0, 1);
		layout.Controls.Add(button_1, 1, 1);
		groupBox_2.Controls.Add(layout);
		return groupBox_2;
	}

	private ModernCard CreatePostInjectionCard()
	{
		groupBox_3 = CreateCard(UiText.Get("Settings.PostInjection"));
		checkBox_3 = CreateCheckBox("hideModuleCheckBox", UiText.Get("Settings.HideModule"));
		checkBox_4 = CreateCheckBox("erasePECheckBox", UiText.Get("Settings.ErasePe"));
		var layout = new FlowLayoutPanel
		{
			AutoScroll = false,
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.TopDown,
			Margin = Padding.Empty,
			Padding = new Padding(0, 6, 0, 0),
			WrapContents = false
		};
		layout.Controls.Add(checkBox_3);
		layout.Controls.Add(checkBox_4);
		groupBox_3.Controls.Add(layout);
		return groupBox_3;
	}

	private ModernCard CreateAppearanceCard()
	{
		groupBox_4 = CreateCard(UiText.Get("Settings.Appearance"));
		label_4 = CreateFieldLabel(UiText.Get("Settings.TextColor"));
		label_4.Name = "textColorLabel";
		label_3 = CreateFieldLabel(UiText.Get("Settings.PrimaryAccent"));
		label_3.Name = "backgroundColor1Label";
		label_2 = CreateFieldLabel(UiText.Get("Settings.SecondaryAccent"));
		label_2.Name = "backgroundColor2Label";
		panel_2 = CreateColorSwatch("textColorBox", OnTextColorClick);
		panel_1 = CreateColorSwatch("backgroundColor1Box", OnPrimaryColorClick);
		panel_0 = CreateColorSwatch("backgroundColor2Box", OnSecondaryColorClick);
		languageLabel = CreateFieldLabel(UiText.Get("Settings.Language"));
		languageComboBox = CreateComboBox("languageComboBox");
		languageComboBox.Items.AddRange(GetLanguageLabels());
		randomizeWindowTitleCheckBox = CreateCheckBox(
			"randomizeWindowTitleCheckBox",
			UiText.Get("Settings.RandomizeWindowTitle"));

		var layout = new TableLayoutPanel
		{
			ColumnCount = 2,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(0, 5, 0, 0),
			RowCount = 5
		};
		layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142f));
		for (int index = 0; index < 5; index++)
		{
			layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
		}
		layout.Controls.Add(label_4, 0, 0);
		layout.Controls.Add(panel_2, 1, 0);
		layout.Controls.Add(label_3, 0, 1);
		layout.Controls.Add(panel_1, 1, 1);
		layout.Controls.Add(label_2, 0, 2);
		layout.Controls.Add(panel_0, 1, 2);
		layout.Controls.Add(languageLabel, 0, 3);
		languageComboBox.Dock = DockStyle.Fill;
		languageComboBox.Margin = new Padding(6, 2, 0, 2);
		layout.Controls.Add(languageComboBox, 1, 3);
		layout.Controls.Add(randomizeWindowTitleCheckBox, 0, 4);
		layout.SetColumnSpan(randomizeWindowTitleCheckBox, 2);
		groupBox_4.Controls.Add(layout);
		return groupBox_4;
	}

	private ModernCard CreateToolsCard()
	{
		groupBox_5 = CreateCard(UiText.Get("Settings.Tools"));
		groupBox_5.Margin = new Padding(0, 0, 0, 8);
		button_4 = CreateSecondaryButton("startInSecureModeButton", UiText.Get("Settings.SecureMode"));
		button_5 = CreateSecondaryButton("scrambleDLLButton", UiText.Get("Settings.ScrambleDll"));
		button_6 = CreateSecondaryButton("viewProcessInformationButton", UiText.Get("Settings.ProcessInfo"));
		button_4.Click += OnRestartSafeModeClick;
		button_5.Click += OnScrambleDllClick;
		button_6.Click += OnInspectProcessClick;

		cliHintLabel = new Label
		{
			AutoEllipsis = true,
			Dock = DockStyle.Fill,
			Font = new Font("Segoe UI", 8.5f, FontStyle.Regular, GraphicsUnit.Point),
			ForeColor = ModernUi.TextSecondary,
			Margin = Padding.Empty,
			Text = UiText.Get("Settings.CliHint"),
			TextAlign = ContentAlignment.MiddleLeft
		};

		var tools = new FlowLayoutPanel
		{
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.LeftToRight,
			Margin = Padding.Empty,
			Padding = Padding.Empty,
			WrapContents = false
		};
		button_4.Margin = new Padding(0, 0, 8, 0);
		button_5.Margin = new Padding(0, 0, 8, 0);
		button_6.Margin = Padding.Empty;
		tools.Controls.Add(button_4);
		tools.Controls.Add(button_5);
		tools.Controls.Add(button_6);

		var layout = new TableLayoutPanel
		{
			BackColor = ModernUi.Surface,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			RowCount = 2
		};
		layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
		layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		layout.Controls.Add(cliHintLabel, 0, 0);
		layout.Controls.Add(tools, 0, 1);
		groupBox_5.Controls.Add(layout);
		return groupBox_5;
	}

	private Control CreateSettingsFooter()
	{
		button_2 = CreateSecondaryButton("resetButton", UiText.Get("Settings.Reset"));
		button_2.Click += OnResetSettingsClick;
		button_3 = new Button { Name = "okButton", Text = UiText.Get("Settings.SaveClose") };
		button_3.Click += OnCloseClick;

		var footer = new FlowLayoutPanel
		{
			BackColor = ModernUi.Window,
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.RightToLeft,
			Margin = Padding.Empty,
			Padding = new Padding(0, 7, 0, 0),
			WrapContents = false
		};
		button_3.Margin = Padding.Empty;
		button_2.Margin = new Padding(0, 0, 8, 0);
		footer.Controls.Add(button_3);
		footer.Controls.Add(button_2);
		return footer;
	}

	internal void ApplyModernSettingsTheme()
	{
		Color accent = ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1);
		Color hoverAccent = ModernUi.HarmonizeInteractiveColor(
			accent,
			ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor2));
		ModernUi.StyleSecondaryButton(button_0, accent);
		ModernUi.StyleSecondaryButton(button_1, accent);
		ModernUi.StyleSecondaryButton(button_2, accent);
		ModernUi.StyleSecondaryButton(button_4, accent);
		ModernUi.StyleSecondaryButton(button_5, accent);
		ModernUi.StyleSecondaryButton(button_6, accent);
		ModernUi.StylePrimaryButton(button_3, accent, hoverAccent);
	}

	internal void ApplyLocalizedText()
	{
		Text = UiText.Get("Settings.Title");
		settingsTitleLabel.Text = UiText.Get("Settings.Title");
		settingsDescriptionLabel.Text = UiText.Get("Settings.Description");
		groupBox_0.Text = UiText.Get("Settings.InjectionMethod");
		injectionBackendLabel.Text = UiText.Get("Settings.InjectionBackend");
		button_0.Text = UiText.Get("Settings.Advanced");
		groupBox_1.Text = UiText.Get("Settings.InjectionBehavior");
		checkBox_2.Text = UiText.Get("Settings.AutoInject");
		checkBox_1.Text = UiText.Get("Settings.CloseOnInject");
		checkBox_0.Text = UiText.Get("Settings.StealthInject");
		label_1.Text = UiText.Get("Settings.DelayBefore");
		label_0.Text = UiText.Get("Settings.DelayBetween");
		groupBox_2.Text = UiText.Get("Settings.Scrambling");
		scramblePresetLabel.Text = UiText.Get("Settings.Preset");
		button_1.Text = UiText.Get("Settings.Advanced");
		groupBox_3.Text = UiText.Get("Settings.PostInjection");
		checkBox_3.Text = UiText.Get("Settings.HideModule");
		checkBox_4.Text = UiText.Get("Settings.ErasePe");
		groupBox_4.Text = UiText.Get("Settings.Appearance");
		label_4.Text = UiText.Get("Settings.TextColor");
		label_3.Text = UiText.Get("Settings.PrimaryAccent");
		label_2.Text = UiText.Get("Settings.SecondaryAccent");
		languageLabel.Text = UiText.Get("Settings.Language");
		randomizeWindowTitleCheckBox.Text = UiText.Get("Settings.RandomizeWindowTitle");
		groupBox_5.Text = UiText.Get("Settings.Tools");
		cliHintLabel.Text = UiText.Get("Settings.CliHint");
		button_4.Text = UiText.Get("Settings.SecureMode");
		button_5.Text = UiText.Get("Settings.ScrambleDll");
		button_6.Text = UiText.Get("Settings.ProcessInfo");
		button_2.Text = UiText.Get("Settings.Reset");
		button_3.Text = UiText.Get("Settings.SaveClose");

		ReplaceComboItems(comboBox_0, GetInjectionMethodLabels());
		comboBox_1.SelectedIndexChanged -= OnScramblePresetChanged;
		ReplaceComboItems(comboBox_1, GetScramblePresetLabels());
		comboBox_1.SelectedIndexChanged += OnScramblePresetChanged;
		languageComboBox.SelectedIndexChanged -= OnLanguageSelectionChanged;
		ReplaceComboItems(languageComboBox, GetLanguageLabels());
		languageComboBox.SelectedIndexChanged += OnLanguageSelectionChanged;
	}

	private static object[] GetInjectionMethodLabels()
	{
		return new object[]
		{
			UiText.Get("Settings.Method.Standard"),
			UiText.Get("Settings.Method.ThreadHijacking"),
			UiText.Get("Settings.Method.LdrLoadDllStub"),
			UiText.Get("Settings.Method.LdrpLoadDllStub"),
			UiText.Get("Settings.Method.ManualMap")
		};
	}

	private static object[] GetScramblePresetLabels()
	{
		return new object[]
		{
			UiText.Get("Settings.Preset.None"),
			UiText.Get("Settings.Preset.Basic"),
			UiText.Get("Settings.Preset.Standard"),
			UiText.Get("Settings.Preset.Extreme"),
			UiText.Get("Settings.Preset.Custom")
		};
	}

	private static object[] GetLanguageLabels()
	{
		return new object[]
		{
			UiText.Get("Language.System"),
			UiText.Get("Language.English"),
			UiText.Get("Language.SimplifiedChinese")
		};
	}

	private static void ReplaceComboItems(ComboBox comboBox, object[] items)
	{
		int selectedIndex = comboBox.SelectedIndex;
		comboBox.BeginUpdate();
		try
		{
			comboBox.Items.Clear();
			comboBox.Items.AddRange(items);
			comboBox.SelectedIndex = selectedIndex >= 0 && selectedIndex < items.Length
				? selectedIndex
				: 0;
		}
		finally
		{
			comboBox.EndUpdate();
		}
	}

	private static ModernCard CreateCard(string text)
	{
		var card = new ModernCard
		{
			Dock = DockStyle.Fill,
			Margin = new Padding(0, 0, 0, 10),
			Text = text
		};
		ModernUi.StyleCard(card);
		return card;
	}

	private static Label CreateFieldLabel(string text)
	{
		var label = new Label
		{
			Anchor = AnchorStyles.Left,
			Text = text
		};
		ModernUi.StyleFieldLabel(label);
		return label;
	}

	private static ComboBox CreateComboBox(string name)
	{
		var comboBox = new ComboBox
		{
			Name = name
		};
		ModernUi.StyleComboBox(comboBox);
		return comboBox;
	}

	private static CheckBox CreateCheckBox(string name, string text)
	{
		var checkBox = new CheckBox
		{
			Anchor = AnchorStyles.Left,
			Margin = new Padding(0, 2, 0, 2),
			Name = name,
			Text = text
		};
		ModernUi.StyleCheckBox(checkBox);
		return checkBox;
	}

	private static NumericUpDown CreateDelayInput(string name)
	{
		var input = new NumericUpDown
		{
			Anchor = AnchorStyles.Left | AnchorStyles.Right,
			Maximum = 30000m,
			Name = name,
			TextAlign = HorizontalAlignment.Right,
			ThousandsSeparator = true
		};
		ModernUi.StyleNumericUpDown(input);
		return input;
	}

	private static Button CreateSecondaryButton(string name, string text)
	{
		var button = new Button
		{
			Name = name,
			Text = text
		};
		ModernUi.StyleSecondaryButton(button, ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1));
		return button;
	}

	private static Panel CreateColorSwatch(string name, System.EventHandler clickHandler)
	{
		var swatch = new ColorSwatchPanel
		{
			Anchor = AnchorStyles.Right,
			Cursor = Cursors.Hand,
			Margin = new Padding(6, 4, 0, 4),
			MinimumSize = new Size(34, 22),
			Name = name,
			Size = new Size(34, 24),
			TabStop = true
		};
		swatch.Click += clickHandler;
		return swatch;
	}

	private sealed class ColorSwatchPanel : Panel
	{
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Rectangle border = ClientRectangle;
			border.Width = System.Math.Max(0, border.Width - 1);
			border.Height = System.Math.Max(0, border.Height - 1);
			using (var pen = new Pen(Color.FromArgb(142, 149, 160), 1f))
			{
				e.Graphics.DrawRectangle(pen, border);
			}
		}
	}

	protected override void OnDpiChanged(DpiChangedEventArgs e)
	{
		base.OnDpiChanged(e);
		ApplyModernSettingsTheme();
		PerformLayout();
	}
}
