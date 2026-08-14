using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public sealed partial class ModuleOptionsForm : Form
{
	[CompilerGenerated]
	internal ModuleEntry class16_0;

	[CompilerGenerated]
	internal PeImage class154_0;

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

	[SpecialName]
	[CompilerGenerated]
	internal ModuleEntry method_0()
	{
		return class16_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(ModuleEntry class16_1)
	{
		class16_0 = class16_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal PeImage method_2()
	{
		return class154_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(PeImage class154_1)
	{
		class154_0 = class154_1;
	}

	public ModuleOptionsForm()
		: this(attachRuntimeLoadHandler: true)
	{
	}

	internal ModuleOptionsForm(bool attachRuntimeLoadHandler)
	{
		InitializeModernModuleOptionsForm(attachRuntimeLoadHandler);
	}

	internal void method_4(object sender, EventArgs e)
	{
		this.comboBox_0.Items.Add(EncodedStringTable.smethod_0(394));
		int selectedIndex = 0;
		if (this.method_2().method_14() != null)
		{
			foreach (ExportedSymbol @class in this.method_2().method_14().list_1)
			{
				if (@class.method_0())
				{
					this.comboBox_0.Items.Add(@class.method_4());
					if (@class.method_4() == this.method_0().ExportName)
					{
						selectedIndex = this.comboBox_0.Items.Count - 1;
					}
				}
			}
		}
		this.comboBox_0.SelectedIndex = selectedIndex;
		this.comboBox_1.Items.Add(EncodedStringTable.smethod_0(395));
		this.comboBox_1.Items.Add(EncodedStringTable.smethod_0(408));
		this.comboBox_1.Items.Add(EncodedStringTable.smethod_0(417));
		if (this.method_0().CallingConvention != (CallingConvention)0)
		{
			if (this.method_0().CallingConvention == CallingConvention.StdCall)
			{
				this.comboBox_1.SelectedIndex = 0;
			}
			else if (this.method_0().CallingConvention == CallingConvention.Cdecl)
			{
				this.comboBox_1.SelectedIndex = 1;
			}
			else if (this.method_0().CallingConvention == CallingConvention.FastCall)
			{
				this.comboBox_1.SelectedIndex = 2;
			}
		}
		else
		{
			this.comboBox_1.SelectedIndex = 0;
		}
		this.comboBox_2.Items.Add(EncodedStringTable.smethod_0(430));
		this.comboBox_2.Items.Add(EncodedStringTable.smethod_0(439));
		this.comboBox_2.Items.Add(EncodedStringTable.smethod_0(452));
		this.comboBox_2.Items.Add(EncodedStringTable.smethod_0(461));
		this.comboBox_2.Items.Add(EncodedStringTable.smethod_0(470));
		this.comboBox_2.Items.Add(EncodedStringTable.smethod_0(479));
		this.comboBox_2.Items.Add(EncodedStringTable.smethod_0(488));
		if (this.method_0().Parameters == null)
		{
			return;
		}
		foreach (ExportParameter class2 in this.method_0().Parameters)
		{
			RecoveredRuntime.smethod_342(this, class2.Value, class2.Type, false);
		}
	}

	internal void method_5(object sender, EventArgs e)
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
		method_0().ExportName = ((comboBox_0.SelectedIndex != 0) ? comboBox_0.SelectedItem.ToString() : string.Empty);
	}

	internal void method_6(object sender, EventArgs e)
	{
		if (this.comboBox_1.SelectedIndex == 0)
		{
			this.method_0().CallingConvention = CallingConvention.StdCall;
			return;
		}
		if (this.comboBox_1.SelectedIndex == 1)
		{
			this.method_0().CallingConvention = CallingConvention.Cdecl;
			return;
		}
		if (this.comboBox_1.SelectedIndex == 2)
		{
			this.method_0().CallingConvention = CallingConvention.FastCall;
		}
	}

	internal void method_7(object sender, EventArgs e)
	{
		if (this.comboBox_2.SelectedIndex == -1)
		{
			return;
		}
		if (RecoveredRuntime.smethod_342(this, this.textBox_0.Text, (ExportParameterType)this.comboBox_2.SelectedIndex, true))
		{
			this.textBox_0.ResetText();
		}
	}

	internal void method_8(object sender, DataGridViewRowsAddedEventArgs e)
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

	internal void method_9(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		this.method_0().Parameters.RemoveAt(e.RowIndex);
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

	internal static ComboBox.ObjectCollection smethod_0(ComboBox comboBox_3)
	{
		return comboBox_3.Items;
	}

	internal static int smethod_1(ComboBox.ObjectCollection objectCollection_0, object object_0)
	{
		return objectCollection_0.Add(object_0);
	}

	internal static bool smethod_2(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	internal static int smethod_3(ComboBox.ObjectCollection objectCollection_0)
	{
		return objectCollection_0.Count;
	}

	internal static void smethod_4(ListControl listControl_0, int int_0)
	{
		listControl_0.SelectedIndex = int_0;
	}

	internal static int smethod_5(ListControl listControl_0)
	{
		return listControl_0.SelectedIndex;
	}

	internal static void smethod_6(Control control_0, bool bool_0)
	{
		control_0.Enabled = bool_0;
	}

	internal static object smethod_7(ComboBox comboBox_3)
	{
		return comboBox_3.SelectedItem;
	}

	internal static string smethod_8(object object_0)
	{
		return object_0.ToString();
	}

	internal static string smethod_9(Control control_0)
	{
		return control_0.Text;
	}

	internal static void smethod_10(Control control_0)
	{
		control_0.ResetText();
	}

	internal static DataGridViewRowCollection smethod_11(DataGridView dataGridView_1)
	{
		return dataGridView_1.Rows;
	}

	internal static IEnumerator smethod_12(IEnumerable ienumerable_0)
	{
		return ienumerable_0.GetEnumerator();
	}

	internal static object smethod_13(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	internal static DataGridViewCellCollection smethod_14(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.Cells;
	}

	internal static DataGridViewCell smethod_15(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0[int_0];
	}

	internal static int smethod_16(DataGridViewRowsRemovedEventArgs dataGridViewRowsRemovedEventArgs_0)
	{
		return dataGridViewRowsRemovedEventArgs_0.RowIndex;
	}

	internal static void smethod_17(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
