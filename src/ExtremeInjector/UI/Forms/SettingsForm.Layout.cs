using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed partial class SettingsForm
{
	private TableLayoutPanel settingsRootLayout;

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
		Text = "Settings";

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
		settingsRootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 94f));
		settingsRootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44f));

		settingsRootLayout.Controls.Add(CreateSettingsHeader(), 0, 0);
		settingsRootLayout.Controls.Add(CreateSettingsContent(), 0, 1);
		settingsRootLayout.Controls.Add(CreateToolsCard(), 0, 2);
		settingsRootLayout.Controls.Add(CreateSettingsFooter(), 0, 3);
		Controls.Add(settingsRootLayout);

		AcceptButton = button_3;
		FormClosing += method_9;
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
		header.Controls.Add(new Label
		{
			AutoSize = true,
			Font = new Font("Segoe UI Semibold", 16f, FontStyle.Bold, GraphicsUnit.Point),
			ForeColor = ModernUi.TextPrimary,
			Margin = Padding.Empty,
			Text = "Settings"
		}, 0, 0);
		header.Controls.Add(new Label
		{
			AutoSize = true,
			Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point),
			ForeColor = ModernUi.TextSecondary,
			Margin = new Padding(1, 2, 0, 0),
			Text = "Configure injection behavior, appearance, and maintenance tools."
		}, 0, 1);
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

	private GroupBox CreateInjectionMethodCard()
	{
		groupBox_0 = CreateCard("Injection method");
		comboBox_0 = CreateComboBox("injectionMethodComboBox");
		comboBox_0.Items.AddRange(new object[]
		{
			"Standard Injection",
			"Thread Hijacking",
			"LdrLoadDll Stub",
			"LdrpLoadDll Stub",
			"Manual Map"
		});

		button_0 = CreateSecondaryButton("advancedInjectOptions", "Advanced");
		button_0.Click += method_4;

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
		var label = CreateFieldLabel("Injection backend");
		row.Controls.Add(label, 0, 0);
		row.SetColumnSpan(label, 2);
		comboBox_0.Dock = DockStyle.Fill;
		comboBox_0.Margin = new Padding(0, 0, 8, 0);
		button_0.Dock = DockStyle.Fill;
		button_0.Margin = Padding.Empty;
		row.Controls.Add(comboBox_0, 0, 1);
		row.Controls.Add(button_0, 1, 1);
		groupBox_0.Controls.Add(row);
		return groupBox_0;
	}

	private GroupBox CreateInjectionBehaviorCard()
	{
		groupBox_1 = CreateCard("Injection behavior");
		checkBox_2 = CreateCheckBox("autoInjectCheckBox", "Auto inject when the process starts");
		checkBox_1 = CreateCheckBox("closeOnInjectCheckBox", "Close after a successful injection");
		checkBox_0 = CreateCheckBox("stealthInjectCheckBox", "Use stealth injection");
		checkBox_2.CheckedChanged += method_2;

		label_1 = CreateFieldLabel("Delay before injection (ms)");
		label_1.Name = "injectDelayLabel";
		label_0 = CreateFieldLabel("Delay between modules (ms)");
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

	private GroupBox CreateScramblingCard()
	{
		groupBox_2 = CreateCard("Scrambling");
		comboBox_1 = CreateComboBox("scramblePresetCheckBox");
		comboBox_1.Items.AddRange(new object[] { "None", "Basic", "Standard", "Extreme", "Custom" });
		comboBox_1.SelectedIndexChanged += method_6;
		button_1 = CreateSecondaryButton("advancedScramblingOptions", "Advanced");
		button_1.Click += method_3;

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
		var label = CreateFieldLabel("Preset");
		layout.Controls.Add(label, 0, 0);
		layout.SetColumnSpan(label, 2);
		comboBox_1.Dock = DockStyle.Fill;
		comboBox_1.Margin = new Padding(0, 0, 8, 0);
		button_1.Dock = DockStyle.Fill;
		button_1.Margin = Padding.Empty;
		layout.Controls.Add(comboBox_1, 0, 1);
		layout.Controls.Add(button_1, 1, 1);
		groupBox_2.Controls.Add(layout);
		return groupBox_2;
	}

	private GroupBox CreatePostInjectionCard()
	{
		groupBox_3 = CreateCard("Post-injection");
		checkBox_3 = CreateCheckBox("hideModuleCheckBox", "Hide module from the loader lists");
		checkBox_4 = CreateCheckBox("erasePECheckBox", "Erase PE headers");
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

	private GroupBox CreateAppearanceCard()
	{
		groupBox_4 = CreateCard("Appearance");
		label_4 = CreateFieldLabel("Text color");
		label_4.Name = "textColorLabel";
		label_3 = CreateFieldLabel("Primary accent");
		label_3.Name = "backgroundColor1Label";
		label_2 = CreateFieldLabel("Secondary accent");
		label_2.Name = "backgroundColor2Label";
		panel_2 = CreateColorSwatch("textColorBox", method_13);
		panel_1 = CreateColorSwatch("backgroundColor1Box", method_14);
		panel_0 = CreateColorSwatch("backgroundColor2Box", method_15);

		var layout = new TableLayoutPanel
		{
			ColumnCount = 2,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(0, 5, 0, 0),
			RowCount = 3
		};
		layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42f));
		for (int index = 0; index < 3; index++)
		{
			layout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.333f));
		}
		layout.Controls.Add(label_4, 0, 0);
		layout.Controls.Add(panel_2, 1, 0);
		layout.Controls.Add(label_3, 0, 1);
		layout.Controls.Add(panel_1, 1, 1);
		layout.Controls.Add(label_2, 0, 2);
		layout.Controls.Add(panel_0, 1, 2);
		groupBox_4.Controls.Add(layout);
		return groupBox_4;
	}

	private GroupBox CreateToolsCard()
	{
		groupBox_5 = CreateCard("Tools");
		groupBox_5.Margin = new Padding(0, 0, 0, 8);
		button_4 = CreateSecondaryButton("startInSecureModeButton", "Start in secure mode");
		button_5 = CreateSecondaryButton("scrambleDLLButton", "Scramble a DLL");
		button_6 = CreateSecondaryButton("viewProcessInformationButton", "View process information");
		button_4.Click += method_12;
		button_5.Click += method_11;
		button_6.Click += method_10;

		var tools = new FlowLayoutPanel
		{
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.LeftToRight,
			Margin = Padding.Empty,
			Padding = new Padding(0, 7, 0, 0),
			WrapContents = false
		};
		button_4.Margin = new Padding(0, 0, 8, 0);
		button_5.Margin = new Padding(0, 0, 8, 0);
		button_6.Margin = Padding.Empty;
		tools.Controls.Add(button_4);
		tools.Controls.Add(button_5);
		tools.Controls.Add(button_6);
		groupBox_5.Controls.Add(tools);
		return groupBox_5;
	}

	private Control CreateSettingsFooter()
	{
		button_2 = CreateSecondaryButton("resetButton", "Reset settings");
		button_2.Click += method_7;
		button_3 = new Button { Name = "okButton", Text = "Save and close" };
		button_3.Click += method_8;

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

	private static GroupBox CreateCard(string text)
	{
		var card = new GroupBox
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
			Cursor = Cursors.Hand,
			Dock = DockStyle.Fill,
			Margin = new Padding(6, 4, 0, 4),
			MinimumSize = new Size(34, 22),
			Name = name,
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
