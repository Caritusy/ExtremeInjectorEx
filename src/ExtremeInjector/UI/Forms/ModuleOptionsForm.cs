using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed partial class ModuleOptionsForm : Form
{
	internal ModuleEntry Module { get; set; }

	internal PeImage Image { get; set; }

	internal IContainer container;

	internal ModernCard modernCard;

	internal ComboBox exportRoutineComboBox;

	internal Label label;

	internal Label label2;

	internal DataGridView parametersGrid;

	internal Label label3;

	internal ComboBox callingConventionComboBox;

	internal Button button;

	internal TextBox parameterValueTextBox;

	internal ComboBox parameterTypeComboBox;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

	public ModuleOptionsForm()
		: this(attachRuntimeLoadHandler: true)
	{
	}

	internal ModuleOptionsForm(bool attachRuntimeLoadHandler)
	{
		InitializeModernModuleOptionsForm(attachRuntimeLoadHandler);
	}

	internal void OnFormLoad(object sender, EventArgs e)
	{
		PopulateChoiceLists();
		if (Module == null || Image == null)
		{
			return;
		}

		int selectedIndex = 0;
		if (Image.GetExports() != null)
		{
			foreach (ExportedSymbol @class in Image.GetExports().items2)
			{
				if (@class.GetHasName())
				{
					this.exportRoutineComboBox.Items.Add(@class.GetName());
					if (@class.GetName() == Module.ExportName)
					{
						selectedIndex = this.exportRoutineComboBox.Items.Count - 1;
					}
				}
			}
		}
		this.exportRoutineComboBox.SelectedIndex = selectedIndex;
		if (Module.CallingConvention != (CallingConvention)0)
		{
			if (Module.CallingConvention == CallingConvention.StdCall)
			{
				this.callingConventionComboBox.SelectedIndex = 0;
			}
			else if (Module.CallingConvention == CallingConvention.Cdecl)
			{
				this.callingConventionComboBox.SelectedIndex = 1;
			}
			else if (Module.CallingConvention == CallingConvention.FastCall)
			{
				this.callingConventionComboBox.SelectedIndex = 2;
			}
		}
		else
		{
			this.callingConventionComboBox.SelectedIndex = 0;
		}
		this.parameterTypeComboBox.SelectedIndex = 0;
		if (Module.Parameters == null)
		{
			return;
		}
		foreach (ExportParameter class2 in Module.Parameters)
		{
			RecoveredRuntime.TryAddExportParameter(this, class2.Value, class2.Type, false);
		}
	}

	internal void PopulateChoiceLists()
	{
		exportRoutineComboBox.Items.Clear();
		exportRoutineComboBox.Items.Add(UiText.Get("Module.Export.None"));

		callingConventionComboBox.Items.Clear();
		callingConventionComboBox.Items.Add(UiText.Get("Module.Convention.StdCall"));
		callingConventionComboBox.Items.Add(UiText.Get("Module.Convention.Cdecl"));
		callingConventionComboBox.Items.Add(UiText.Get("Module.Convention.FastCall"));

		parameterTypeComboBox.Items.Clear();
		parameterTypeComboBox.Items.Add(UiText.Get("Module.Parameter.AnsiString"));
		parameterTypeComboBox.Items.Add(UiText.Get("Module.Parameter.UnicodeString"));
		parameterTypeComboBox.Items.Add(UiText.Get("Module.Parameter.Byte"));
		parameterTypeComboBox.Items.Add(UiText.Get("Module.Parameter.Word"));
		parameterTypeComboBox.Items.Add(UiText.Get("Module.Parameter.Dword"));
		parameterTypeComboBox.Items.Add(UiText.Get("Module.Parameter.Qword"));
		parameterTypeComboBox.Items.Add(UiText.Get("Module.Parameter.Float"));
	}

	internal void OnExportSelectionChanged(object sender, EventArgs e)
	{
		bool hasSelectedExport = exportRoutineComboBox.SelectedIndex > 0;
		button.Enabled = hasSelectedExport;
		parameterValueTextBox.Enabled = hasSelectedExport;
		parameterTypeComboBox.Enabled = hasSelectedExport;
		parametersGrid.Enabled = hasSelectedExport;
		callingConventionComboBox.Enabled = hasSelectedExport;
		if (Module != null)
		{
			Module.ExportName = hasSelectedExport ? exportRoutineComboBox.SelectedItem.ToString() : string.Empty;
		}
	}

	internal void OnCallingConventionChanged(object sender, EventArgs e)
	{
		if (Module == null)
		{
			return;
		}

		if (this.callingConventionComboBox.SelectedIndex == 0)
		{
			Module.CallingConvention = CallingConvention.StdCall;
			return;
		}
		if (this.callingConventionComboBox.SelectedIndex == 1)
		{
			Module.CallingConvention = CallingConvention.Cdecl;
			return;
		}
		if (this.callingConventionComboBox.SelectedIndex == 2)
		{
			Module.CallingConvention = CallingConvention.FastCall;
		}
	}

	internal void OnAddParameterClick(object sender, EventArgs e)
	{
		if (this.parameterTypeComboBox.SelectedIndex == -1)
		{
			return;
		}
		if (RecoveredRuntime.TryAddExportParameter(this, this.parameterValueTextBox.Text, (ExportParameterType)this.parameterTypeComboBox.SelectedIndex, true))
		{
			this.parameterValueTextBox.ResetText();
		}
	}

	internal void OnParameterRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		int num = 0;
		foreach (object obj in ((IEnumerable)this.parametersGrid.Rows))
		{
			DataGridViewCell dataGridViewCell = ((DataGridViewRow)obj).Cells[0];
			int num2 = num + 1;
			num = num2;
			dataGridViewCell.Value = num2.ToString();
		}
	}

	internal void OnParameterRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		if (Module?.Parameters != null && e.RowIndex >= 0 && e.RowIndex < Module.Parameters.Count)
		{
			Module.Parameters.RemoveAt(e.RowIndex);
		}
		int num = 0;
		foreach (DataGridViewRow row in this.parametersGrid.Rows)
		{
			DataGridViewCell dataGridViewCell = row.Cells[0];
			int num2 = num + 1;
			num = num2;
			dataGridViewCell.Value = num2.ToString();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.container != null)
		{
			this.container.Dispose();
		}
		base.Dispose(disposing);
	}
}
