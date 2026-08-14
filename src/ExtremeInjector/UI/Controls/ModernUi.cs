using System;
using System.Drawing;
using System.Windows.Forms;

internal static class ModernUi
{
	internal static readonly Color Window = Color.FromArgb(246, 247, 249);
	internal static readonly Color Surface = Color.FromArgb(255, 255, 255);
	internal static readonly Color SurfaceMuted = Color.FromArgb(241, 243, 246);
	internal static readonly Color TextPrimary = Color.FromArgb(31, 35, 40);
	internal static readonly Color TextSecondary = Color.FromArgb(92, 99, 112);
	internal static readonly Color Border = Color.FromArgb(214, 218, 224);
	internal static readonly Color Danger = Color.FromArgb(184, 39, 54);

	internal static void StylePrimaryButton(Button button, Color accent, Color hoverAccent)
	{
		StyleButtonBase(button);
		if (!button.Enabled)
		{
			button.BackColor = SurfaceMuted;
			button.ForeColor = TextSecondary;
			button.FlatAppearance.BorderColor = Border;
			button.FlatAppearance.BorderSize = 1;
			button.FlatAppearance.MouseOverBackColor = SurfaceMuted;
			button.FlatAppearance.MouseDownBackColor = SurfaceMuted;
			return;
		}

		button.BackColor = accent;
		button.ForeColor = GetContrastingTextColor(accent);
		button.FlatAppearance.BorderSize = 0;
		button.FlatAppearance.MouseOverBackColor = hoverAccent;
		button.FlatAppearance.MouseDownBackColor = Darken(accent, 0.16f);
	}

	internal static void StyleSecondaryButton(Button button, Color accent)
	{
		StyleButtonBase(button);
		button.BackColor = Surface;
		button.ForeColor = TextPrimary;
		button.FlatAppearance.BorderColor = Border;
		button.FlatAppearance.BorderSize = 1;
		button.FlatAppearance.MouseOverBackColor = SurfaceMuted;
		button.FlatAppearance.MouseDownBackColor = Blend(SurfaceMuted, accent, 0.12f);
	}

	internal static void StyleQuietButton(Button button, Color accent)
	{
		StyleButtonBase(button);
		button.BackColor = Window;
		button.ForeColor = TextSecondary;
		button.FlatAppearance.BorderSize = 0;
		button.FlatAppearance.MouseOverBackColor = SurfaceMuted;
		button.FlatAppearance.MouseDownBackColor = Blend(SurfaceMuted, accent, 0.12f);
	}

	internal static void StyleCard(GroupBox groupBox)
	{
		groupBox.BackColor = Surface;
		groupBox.FlatStyle = FlatStyle.Flat;
		groupBox.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point);
		groupBox.ForeColor = TextPrimary;
		groupBox.Padding = new Padding(12, 12, 12, 12);
		groupBox.TabStop = false;
	}

	internal static void StyleFieldLabel(Label label)
	{
		label.AutoSize = true;
		label.Font = new Font("Segoe UI", 8.75f, FontStyle.Regular, GraphicsUnit.Point);
		label.ForeColor = TextSecondary;
		label.Margin = new Padding(0, 0, 0, 4);
	}

	internal static void StyleComboBox(ComboBox comboBox)
	{
		comboBox.BackColor = Surface;
		comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox.FlatStyle = FlatStyle.Flat;
		comboBox.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		comboBox.ForeColor = TextPrimary;
		comboBox.IntegralHeight = false;
	}

	internal static void StyleTextBox(TextBox textBox)
	{
		textBox.BackColor = Surface;
		textBox.BorderStyle = BorderStyle.FixedSingle;
		textBox.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		textBox.ForeColor = TextPrimary;
	}

	internal static void StyleNumericUpDown(NumericUpDown numericUpDown)
	{
		numericUpDown.BackColor = Surface;
		numericUpDown.BorderStyle = BorderStyle.FixedSingle;
		numericUpDown.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		numericUpDown.ForeColor = TextPrimary;
		NumericUpDownAcceleration acceleration = new NumericUpDownAcceleration(1, 100);
		numericUpDown.Accelerations.Add(acceleration);
	}

	internal static void StyleCheckBox(CheckBox checkBox)
	{
		checkBox.AutoSize = true;
		checkBox.BackColor = Surface;
		checkBox.FlatStyle = FlatStyle.System;
		checkBox.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		checkBox.ForeColor = TextPrimary;
		checkBox.UseVisualStyleBackColor = false;
	}

	internal static void StyleDataGridView(DataGridView grid, Color accent)
	{
		grid.BackgroundColor = Surface;
		grid.BorderStyle = BorderStyle.None;
		grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
		grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		grid.ColumnHeadersDefaultCellStyle.BackColor = SurfaceMuted;
		grid.ColumnHeadersDefaultCellStyle.ForeColor = TextSecondary;
		grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 8.75f, FontStyle.Bold, GraphicsUnit.Point);
		grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 6, 8, 6);
		grid.DefaultCellStyle.BackColor = Surface;
		grid.DefaultCellStyle.ForeColor = TextPrimary;
		grid.DefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		grid.DefaultCellStyle.Padding = new Padding(8, 5, 8, 5);
		grid.DefaultCellStyle.SelectionBackColor = Blend(accent, Color.White, 0.82f);
		grid.DefaultCellStyle.SelectionForeColor = TextPrimary;
		grid.EnableHeadersVisualStyles = false;
		grid.GridColor = Border;
		grid.RowHeadersVisible = false;
	}

	internal static Color NormalizeAccent(Color candidate)
	{
		if (candidate.IsEmpty || candidate.A < 255)
		{
			return Color.FromArgb(15, 108, 189);
		}

		if (candidate.ToArgb() == Color.DodgerBlue.ToArgb())
		{
			return Color.FromArgb(15, 108, 189);
		}

		if (candidate.ToArgb() == Color.DeepSkyBlue.ToArgb())
		{
			return Color.FromArgb(17, 94, 163);
		}

		double luminance = RelativeLuminance(candidate);
		if (luminance > 0.78)
		{
			return Darken(candidate, 0.34f);
		}

		if (luminance < 0.06)
		{
			return Blend(candidate, Color.White, 0.18f);
		}

		return candidate;
	}

	internal static Color GetContrastingTextColor(Color background)
	{
		double backgroundLuminance = RelativeLuminance(background);
		double whiteContrast = 1.05d / (backgroundLuminance + 0.05d);
		double darkContrast = (backgroundLuminance + 0.05d) / (RelativeLuminance(TextPrimary) + 0.05d);
		return whiteContrast >= darkContrast ? Color.White : TextPrimary;
	}

	internal static Color HarmonizeInteractiveColor(Color primary, Color candidate)
	{
		Color foreground = GetContrastingTextColor(primary);
		Color blended = Blend(primary, candidate, 0.24f);
		if (ContrastRatio(foreground, blended) >= 4.5d)
		{
			return blended;
		}

		return foreground == Color.White
			? Darken(primary, 0.10f)
			: Blend(primary, Color.White, 0.10f);
	}

	internal static Color Darken(Color color, float amount)
	{
		return Blend(color, Color.Black, amount);
	}

	internal static Color Blend(Color first, Color second, float amount)
	{
		amount = Math.Max(0f, Math.Min(1f, amount));
		return Color.FromArgb(
			255,
			(int)Math.Round(first.R + ((second.R - first.R) * amount)),
			(int)Math.Round(first.G + ((second.G - first.G) * amount)),
			(int)Math.Round(first.B + ((second.B - first.B) * amount)));
	}

	private static void StyleButtonBase(Button button)
	{
		float scale = button.IsHandleCreated ? Math.Max(1f, button.DeviceDpi / 96f) : 1f;
		int minimumWidth = (int)Math.Round(72f * scale);
		int minimumHeight = (int)Math.Round(22f * scale);

		button.AutoSize = true;
		button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		button.Cursor = Cursors.Hand;
		button.FlatStyle = FlatStyle.Flat;
		button.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		button.MinimumSize = new Size(
			Math.Max(button.MinimumSize.Width, minimumWidth),
			Math.Max(button.MinimumSize.Height, minimumHeight));
		button.Padding = new Padding(
			(int)Math.Round(10f * scale),
			0,
			(int)Math.Round(10f * scale),
			0);
		button.UseVisualStyleBackColor = false;
	}

	private static double RelativeLuminance(Color color)
	{
		double red = Linearize(color.R / 255d);
		double green = Linearize(color.G / 255d);
		double blue = Linearize(color.B / 255d);
		return (0.2126d * red) + (0.7152d * green) + (0.0722d * blue);
	}

	private static double ContrastRatio(Color first, Color second)
	{
		double firstLuminance = RelativeLuminance(first);
		double secondLuminance = RelativeLuminance(second);
		double lighter = Math.Max(firstLuminance, secondLuminance);
		double darker = Math.Min(firstLuminance, secondLuminance);
		return (lighter + 0.05d) / (darker + 0.05d);
	}

	private static double Linearize(double channel)
	{
		return channel <= 0.03928d
			? channel / 12.92d
			: Math.Pow((channel + 0.055d) / 1.055d, 2.4d);
	}
}

internal sealed class EmptyStateDataGridView : DataGridView
{
	public string EmptyStateText { get; set; } = UiText.Get("Main.EmptyDllList");

	public EmptyStateDataGridView()
	{
		DoubleBuffered = true;
	}

	internal void RefreshContentMetrics()
	{
		Font headerFont = ColumnHeadersDefaultCellStyle.Font ?? Font;
		Padding headerPadding = ColumnHeadersDefaultCellStyle.Padding;
		int textHeight;
		if (IsHandleCreated)
		{
			using (Graphics graphics = CreateGraphics())
			{
				textHeight = TextRenderer.MeasureText(
					graphics,
					"Ag",
					headerFont,
					Size.Empty,
					TextFormatFlags.NoPadding | TextFormatFlags.SingleLine).Height;
			}
		}
		else
		{
			textHeight = TextRenderer.MeasureText(
				"Ag",
				headerFont,
				Size.Empty,
				TextFormatFlags.NoPadding | TextFormatFlags.SingleLine).Height;
		}

		ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		ColumnHeadersHeight = textHeight + headerPadding.Vertical + 4;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		if (Rows.Count != 0 || string.IsNullOrEmpty(EmptyStateText))
		{
			return;
		}

		Rectangle emptyBounds = ClientRectangle;
		emptyBounds.Y += ColumnHeadersVisible ? ColumnHeadersHeight : 0;
		emptyBounds.Height -= ColumnHeadersVisible ? ColumnHeadersHeight : 0;
		TextRenderer.DrawText(
			e.Graphics,
			EmptyStateText,
			Font,
			emptyBounds,
			ModernUi.TextSecondary,
			TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
	}

	protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
	{
		base.OnRowsAdded(e);
		Invalidate();
	}

	protected override void OnRowsRemoved(DataGridViewRowsRemovedEventArgs e)
	{
		base.OnRowsRemoved(e);
		Invalidate();
	}
}
