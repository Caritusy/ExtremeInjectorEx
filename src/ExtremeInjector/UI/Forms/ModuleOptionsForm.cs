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

	internal IContainer icontainer_0;

	internal ModernCard groupBox_0;

	internal ComboBox comboBox_0;

	internal Label label_0;

	internal Label label_1;

	internal DataGridView dataGridView_0;

	internal Label label_2;

	internal ComboBox comboBox_1;

	internal Button button_0;

	internal TextBox textBox_0;

	internal ComboBox comboBox_2;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

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
		this.comboBox_0.Items.Add(EncodedStringTable.DecodeString(394));
		int selectedIndex = 0;
		if (Image.GetExports() != null)
		{
			foreach (ExportedSymbol @class in Image.GetExports().list_1)
			{
				if (@class.GetHasName())
				{
					this.comboBox_0.Items.Add(@class.GetName());
					if (@class.GetName() == Module.ExportName)
					{
						selectedIndex = this.comboBox_0.Items.Count - 1;
					}
				}
			}
		}
		this.comboBox_0.SelectedIndex = selectedIndex;
		this.comboBox_1.Items.Add(EncodedStringTable.DecodeString(395));
		this.comboBox_1.Items.Add(EncodedStringTable.DecodeString(408));
		this.comboBox_1.Items.Add(EncodedStringTable.DecodeString(417));
		if (Module.CallingConvention != (CallingConvention)0)
		{
			if (Module.CallingConvention == CallingConvention.StdCall)
			{
				this.comboBox_1.SelectedIndex = 0;
			}
			else if (Module.CallingConvention == CallingConvention.Cdecl)
			{
				this.comboBox_1.SelectedIndex = 1;
			}
			else if (Module.CallingConvention == CallingConvention.FastCall)
			{
				this.comboBox_1.SelectedIndex = 2;
			}
		}
		else
		{
			this.comboBox_1.SelectedIndex = 0;
		}
		this.comboBox_2.Items.Add(EncodedStringTable.DecodeString(430));
		this.comboBox_2.Items.Add(EncodedStringTable.DecodeString(439));
		this.comboBox_2.Items.Add(EncodedStringTable.DecodeString(452));
		this.comboBox_2.Items.Add(EncodedStringTable.DecodeString(461));
		this.comboBox_2.Items.Add(EncodedStringTable.DecodeString(470));
		this.comboBox_2.Items.Add(EncodedStringTable.DecodeString(479));
		this.comboBox_2.Items.Add(EncodedStringTable.DecodeString(488));
		if (Module.Parameters == null)
		{
			return;
		}
		foreach (ExportParameter class2 in Module.Parameters)
		{
			RecoveredRuntime.TryAddExportParameter(this, class2.Value, class2.Type, false);
		}
	}

	internal void OnExportSelectionChanged(object sender, EventArgs e)
	{
		bool flag = comboBox_0.SelectedIndex != 0;
		ComboBox comboBox = comboBox_1;
		DataGridView dataGridView = dataGridView_0;
		ComboBox comboBox2 = comboBox_2;
		TextBox textBox = textBox_0;
		bool flag2 = (button_0.Enabled = flag);
		bool flag4 = (textBox.Enabled = flag2);
		bool flag6 = (comboBox2.Enabled = flag4);
		bool enabled = (dataGridView.Enabled = flag6);
		comboBox.Enabled = enabled;
		Module.ExportName = ((comboBox_0.SelectedIndex != 0) ? comboBox_0.SelectedItem.ToString() : string.Empty);
	}

	internal void OnCallingConventionChanged(object sender, EventArgs e)
	{
		if (this.comboBox_1.SelectedIndex == 0)
		{
			Module.CallingConvention = CallingConvention.StdCall;
			return;
		}
		if (this.comboBox_1.SelectedIndex == 1)
		{
			Module.CallingConvention = CallingConvention.Cdecl;
			return;
		}
		if (this.comboBox_1.SelectedIndex == 2)
		{
			Module.CallingConvention = CallingConvention.FastCall;
		}
	}

	internal void OnAddParameterClick(object sender, EventArgs e)
	{
		if (this.comboBox_2.SelectedIndex == -1)
		{
			return;
		}
		if (RecoveredRuntime.TryAddExportParameter(this, this.textBox_0.Text, (ExportParameterType)this.comboBox_2.SelectedIndex, true))
		{
			this.textBox_0.ResetText();
		}
	}

	internal void OnParameterRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		int num = 0;
		foreach (object obj in ((IEnumerable)this.dataGridView_0.Rows))
		{
			DataGridViewCell dataGridViewCell = ((DataGridViewRow)obj).Cells[0];
			int num2 = num + 1;
			num = num2;
			dataGridViewCell.Value = num2.ToString();
		}
	}

	internal void OnParameterRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		Module.Parameters.RemoveAt(e.RowIndex);
		int num = 0;
		foreach (DataGridViewRow row in this.dataGridView_0.Rows)
		{
			DataGridViewCell dataGridViewCell = row.Cells[0];
			int num2 = num + 1;
			num = num2;
			dataGridViewCell.Value = num2.ToString();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}
}
