using System;
using System.ComponentModel;
using System.Windows.Forms;

public sealed class ManualMapOptionsForm : Form
{
	internal IContainer icontainer_0;

	internal GroupBox groupBox_0;

	internal CheckBox checkBox_0;

	internal CheckBox checkBox_1;

	internal GroupBox groupBox_1;

	internal CheckBox checkBox_2;

	internal CheckBox checkBox_3;

	public ManualMapOptionsForm()
	{
		RecoveredRuntime.InitializeManualMapOptionsForm(this);
		this.checkBox_2.Checked = ApplicationSettings.Current.Options.Advanced.HideFromDebugger;
		this.checkBox_1.Checked = ApplicationSettings.Current.Options.Advanced.ManualResolveImports;
		this.checkBox_0.Checked = ApplicationSettings.Current.Options.Advanced.DisableExceptionSupport;
		this.checkBox_3.Checked = ApplicationSettings.Current.Options.Advanced.DisableSehValidation;
	}

	internal void OnHideFromDebuggerChanged(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			return;
		}
		ApplicationSettings.Current.Options.Advanced.HideFromDebugger = this.checkBox_2.Checked;
	}

	internal void OnManualResolveImportsChanged(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			return;
		}
		ApplicationSettings.Current.Options.Advanced.ManualResolveImports = this.checkBox_1.Checked;
	}

	internal void OnDisableExceptionSupportChanged(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			return;
		}
		if (this.checkBox_0.Checked && MessageBox.Show(EncodedStringTable.DecodeString(1371), EncodedStringTable.DecodeString(599), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
		{
			this.checkBox_0.Checked = false;
		}
		ApplicationSettings.Current.Options.Advanced.DisableExceptionSupport = this.checkBox_0.Checked;
	}

	internal void OnDisableSehValidationChanged(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			return;
		}
		if (this.checkBox_3.Checked && MessageBox.Show(EncodedStringTable.DecodeString(1541), EncodedStringTable.DecodeString(599), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
		{
			this.checkBox_3.Checked = false;
		}
		ApplicationSettings.Current.Options.Advanced.DisableSehValidation = this.checkBox_3.Checked;
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
