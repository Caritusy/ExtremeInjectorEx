using System;
using System.ComponentModel;
using System.Windows.Forms;

public sealed class ProcessSelectorForm : Form
{
	internal RemoteProcess SelectedProcess { get; private set; }

	internal IContainer icontainer_0;

	internal DataGridView dataGridView_0;

	internal DataGridViewImageColumn dataGridViewImageColumn_0;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	internal Button button_0;

	internal Button button_1;

	internal Button button_2;

	internal Button button_3;

	public ProcessSelectorForm()
	{
		RecoveredRuntime.InitializeProcessSelectorForm(this);
		ModernUi.ApplyLegacyFormTheme(this);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		ShowInTaskbar = false;
		ModernUi.StylePrimaryButton(
			button_2,
			ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1),
			ModernUi.HarmonizeInteractiveColor(
				ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1),
				ApplicationSettings.Current.Options.BackgroundColor2));
		button_2.AutoSize = false;
		button_2.MinimumSize = System.Drawing.Size.Empty;
		button_2.Padding = Padding.Empty;
		RecoveredRuntime.PopulateAllProcesses(this);
	}

	internal void OnCancelClick(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	internal void OnSelectClick(object sender, EventArgs e)
	{
		SelectedProcess = (RemoteProcess)dataGridView_0.SelectedRows[0].Tag;
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	internal void OnAllProcessesClick(object sender, EventArgs e)
	{
		RecoveredRuntime.PopulateAllProcesses(this);
	}

	internal void OnProcessDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		button_2.PerformClick();
	}

	internal void OnWindowedProcessesClick(object sender, EventArgs e)
	{
		RecoveredRuntime.PopulateWindowedProcesses(this);
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
