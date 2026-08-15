using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

internal sealed class ModuleListColumn : DataGridViewColumn
{
	public ModuleListColumn()
		: base(new ModuleListCell())
	{
	}
}

internal sealed class ModuleListCell : DataGridViewTextBoxCell
{
	private const int LogicalLeftPadding = 10;
	private const int LogicalTextGap = 8;

	internal static bool IsCheckBoxHit(DataGridView grid, int cellRelativeX)
	{
		float scale = Math.Max(1f, grid.DeviceDpi / 96f);
		int left = (int)Math.Round(LogicalLeftPadding * scale);
		int hitWidth = (int)Math.Round(18 * scale);
		return cellRelativeX >= left && cellRelativeX <= left + hitWidth;
	}

	protected override void Paint(
		Graphics graphics,
		Rectangle clipBounds,
		Rectangle cellBounds,
		int rowIndex,
		DataGridViewElementStates cellState,
		object value,
		object formattedValue,
		string errorText,
		DataGridViewCellStyle cellStyle,
		DataGridViewAdvancedBorderStyle advancedBorderStyle,
		DataGridViewPaintParts paintParts)
	{
		base.Paint(
			graphics,
			clipBounds,
			cellBounds,
			rowIndex,
			cellState,
			value,
			formattedValue,
			errorText,
			cellStyle,
			advancedBorderStyle,
			paintParts & ~DataGridViewPaintParts.ContentForeground);

		bool enabled = OwningRow?.Tag is MainForm.ModuleRow module && module.Entry.Enabled;
		CheckBoxState state = enabled ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal;
		Size glyphSize = CheckBoxRenderer.GetGlyphSize(graphics, state);
		float scale = Math.Max(1f, (DataGridView?.DeviceDpi ?? 96) / 96f);
		int glyphX = cellBounds.Left + (int)Math.Round(LogicalLeftPadding * scale);
		int glyphY = cellBounds.Top + Math.Max(0, (cellBounds.Height - glyphSize.Height) / 2);
		CheckBoxRenderer.DrawCheckBox(graphics, new Point(glyphX, glyphY), state);

		int textX = glyphX + glyphSize.Width + (int)Math.Round(LogicalTextGap * scale);
		var textBounds = new Rectangle(
			textX,
			cellBounds.Top,
			Math.Max(0, cellBounds.Right - textX - (int)Math.Round(8 * scale)),
			cellBounds.Height);
		Color textColor = (cellState & DataGridViewElementStates.Selected) != 0
			? cellStyle.SelectionForeColor
			: cellStyle.ForeColor;
		TextRenderer.DrawText(
			graphics,
			Convert.ToString(formattedValue),
			cellStyle.Font,
			textBounds,
			textColor,
			TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine | TextFormatFlags.VerticalCenter);
	}
}
