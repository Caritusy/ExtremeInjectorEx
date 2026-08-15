using System;
using System.ComponentModel;
using System.Windows.Forms;

public sealed partial class ManualMapOptionsForm : Form
{
	internal IContainer container = null;

	internal GroupBox groupBox;

	internal CheckBox checkBox;

	internal CheckBox checkBox2;

	internal GroupBox groupBox2;

	internal CheckBox checkBox3;

	internal CheckBox checkBox4;

	public ManualMapOptionsForm()
	{
		InitializeModernManualMapOptionsForm();
		this.checkBox3.Checked = ApplicationSettings.Current.Options.Advanced.HideFromDebugger;
		this.checkBox2.Checked = ApplicationSettings.Current.Options.Advanced.ManualResolveImports;
		this.checkBox.Checked = ApplicationSettings.Current.Options.Advanced.DisableExceptionSupport;
		this.checkBox4.Checked = ApplicationSettings.Current.Options.Advanced.DisableSehValidation;
	}

	internal void OnHideFromDebuggerChanged(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			return;
		}
		ApplicationSettings.Current.Options.Advanced.HideFromDebugger = this.checkBox3.Checked;
	}

	internal void OnManualResolveImportsChanged(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			return;
		}
		ApplicationSettings.Current.Options.Advanced.ManualResolveImports = this.checkBox2.Checked;
	}

	internal void OnDisableExceptionSupportChanged(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			return;
		}
		if (this.checkBox.Checked && MessageBox.Show(this, UiText.Get("ManualMap.DisableExceptionsWarning"), UiText.Get("App.Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
		{
			this.checkBox.Checked = false;
		}
		ApplicationSettings.Current.Options.Advanced.DisableExceptionSupport = this.checkBox.Checked;
	}

	internal void OnDisableSehValidationChanged(object sender, EventArgs e)
	{
		if (!base.Visible)
		{
			return;
		}
		if (this.checkBox4.Checked && MessageBox.Show(this, UiText.Get("ManualMap.DisableSehValidationWarning"), UiText.Get("App.Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
		{
			this.checkBox4.Checked = false;
		}
		ApplicationSettings.Current.Options.Advanced.DisableSehValidation = this.checkBox4.Checked;
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
