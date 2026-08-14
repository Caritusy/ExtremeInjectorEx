using System;
using System.ComponentModel;
using System.Windows.Forms;

public sealed class ProcessSelectorForm : Form
{
	internal RemoteProcess SelectedProcess { get; private set; }

	internal IContainer container;

	internal DataGridView dataGridView;

	internal DataGridViewImageColumn dataGridViewImageColumn;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn;

	internal Button button;

	internal Button button2;

	internal Button button3;

	internal Button button4;

	public ProcessSelectorForm()
	{
		RecoveredRuntime.InitializeProcessSelectorForm(this);
		ModernUi.ApplyLegacyFormTheme(this);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		ShowInTaskbar = false;
		ModernUi.StylePrimaryButton(
			button3,
			ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1),
			ModernUi.HarmonizeInteractiveColor(
				ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1),
				ApplicationSettings.Current.Options.BackgroundColor2));
		button3.AutoSize = false;
		button3.MinimumSize = System.Drawing.Size.Empty;
		button3.Padding = Padding.Empty;
		RecoveredRuntime.PopulateAllProcesses(this);
	}

	internal void OnCancelClick(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	internal void OnSelectClick(object sender, EventArgs e)
	{
		SelectedProcess = (RemoteProcess)dataGridView.SelectedRows[0].Tag;
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	internal void OnAllProcessesClick(object sender, EventArgs e)
	{
		RecoveredRuntime.PopulateAllProcesses(this);
	}

	internal void OnProcessDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		button3.PerformClick();
	}

	internal void OnWindowedProcessesClick(object sender, EventArgs e)
	{
		RecoveredRuntime.PopulateWindowedProcesses(this);
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
