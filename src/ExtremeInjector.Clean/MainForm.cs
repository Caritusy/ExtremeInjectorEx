using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;
using System.Windows.Forms;

public sealed class MainForm : Form
{
	public sealed class ModuleRow
	{
		public ModuleEntry Entry { get; }

		public ModuleRow(ModuleEntry entry)
		{
			Entry = entry ?? new ModuleEntry
			{
				Enabled = true
			};
		}
	}

	internal GClass2 selectedProcess;
	private int? lastAutoInjectedProcessId;

	internal static readonly Dictionary<InjectionMethod, Type> dictionary_0 = new Dictionary<InjectionMethod, Type>
	{
		{ InjectionMethod.StandardInjection, typeof(Class87) },
		{ InjectionMethod.LdrpLoadDll, typeof(Class88) },
		{ InjectionMethod.LdrpLoadDllStub, typeof(Class86) },
		{ InjectionMethod.ThreadHijacking, typeof(Class90) }
	};

	internal IContainer icontainer_0;
	internal Label processNameLabel;
	internal TextBox processNameTextBox;
	internal Button selectProcessButton;
	internal PictureBox processIconPictureBox;
	internal Label processDescriptionLabel;
	internal System.Windows.Forms.Timer processRefreshTimer;
	internal Panel mainPanel;
	internal Label injectionListLabel;
	internal DataGridView moduleGrid;
	internal Button clearButton;
	internal Button removeButton;
	internal Button toggleButton;
	internal Button addDllButton;
	internal Button injectButton;
	internal Button aboutButton;
	internal Button settingsButton;
	internal DataGridViewCheckBoxColumn enabledColumn;
	internal DataGridViewTextBoxColumn dllNameColumn;
	internal DataGridViewButtonColumn exportOptionsColumn;

	public MainForm()
	{
		Class171.InitializeMainFormComponents(this);
		Class171.smethod_341();
		processRefreshTimer.Start();
		Class171.smethod_4(Class10.class10_0, moduleGrid.Handle);
		Class10.class10_0.method_0(OnModulesDropped);

		if (Class127.bool_1)
		{
			moduleGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		}

		foreach (ModuleEntry module in ApplicationSettings.Current.Modules)
		{
			Class171.AddModuleToGrid(module.Enabled, module, bool_1: false, this, module.Path);
		}

		processNameTextBox.Text = ApplicationSettings.Current.ProcessName;
		Class171.ApplyMainFormTheme(this);

		if (DateTime.Now.Subtract(ApplicationSettings.Current.LastUpdateCheck).TotalDays >= 7.0)
		{
			ApplicationSettings.Current.LastUpdateCheck = DateTime.Now;
			ThreadPool.QueueUserWorkItem(_ => Class171.smethod_408());
		}

		Class171.smethod_79(this);
		ApplicationSettings.Save();
	}

	internal void QueueInjectionWorkflow(ModuleRow[] modules, ScramblePreset scramblePreset)
	{
		ThreadPool.QueueUserWorkItem(_ => RunInjectionWorkflow(modules, scramblePreset));
	}

	private void RunInjectionWorkflow(ModuleRow[] modules, ScramblePreset scramblePreset)
	{
		bool attemptedInjection = false;
		bool allModulesSucceeded = true;

		foreach (ModuleRow module in modules)
		{
			string modulePath = module.Entry.Path;
			if (!File.Exists(modulePath))
			{
				continue;
			}

			string moduleName = Path.GetFileName(modulePath);
			SetProcessStatus("Injecting " + moduleName + "...");
			Class171.WaitWithStatus(this, ApplicationSettings.Current.Options.DelayBeforeInjection, "Waiting {0} seconds before injection...");

			IntPtr moduleBase = IntPtr.Zero;
			attemptedInjection = true;
			bool moduleSucceeded = Class171.InjectModule(ref moduleBase, this, scramblePreset, modulePath);

			if (moduleSucceeded && !string.IsNullOrEmpty(module.Entry.ExportName))
			{
				SetProcessStatus("Running export routine... (" + moduleName + ")");
				try
				{
					moduleSucceeded = Class171.InvokeExport(module, moduleBase, this);
				}
				catch (Exception exception)
				{
					Class171.ShowInjectionError(this, "An error occurred while running the export routine.", exception);
					moduleSucceeded = false;
				}
			}

			allModulesSucceeded &= moduleSucceeded;

			Class171.WaitWithStatus(this, ApplicationSettings.Current.Options.DelayBetweenModules, "Waiting {0} seconds before injecting the next DLL...");
		}

		bool injectionSucceeded = attemptedInjection && allModulesSucceeded;
		Invoke((Action)(() => Class171.CompleteInjection(injectionSucceeded, this)));
	}

	private void SetProcessStatus(string status)
	{
		Invoke((Action)(() => processDescriptionLabel.Text = status));
	}

	internal void OnSelectProcessClicked(object sender, EventArgs e)
	{
		GClass2 process = Class171.SelectProcess();
		if (process == null)
		{
			return;
		}

		processNameTextBox.Text = process.method_2();
		Class171.SetSelectedProcess(this, process);
	}

	internal void OnProcessNameChanged(object sender, EventArgs e)
	{
		Class171.ResolveSelectedProcess(this);
	}

	internal void OnProcessRefreshTick(object sender, EventArgs e)
	{
		if (selectedProcess == null || Class171.HasProcessExited(selectedProcess))
		{
			processRefreshTimer.Stop();
			Class171.ResolveSelectedProcess(this);
			processRefreshTimer.Start();
		}

		if (selectedProcess == null || !ApplicationSettings.Current.Options.AutoInject)
		{
			return;
		}

		if (lastAutoInjectedProcessId == selectedProcess.method_0())
		{
			return;
		}

		if (Class171.GetEnabledModuleRows(this).Length == 0)
		{
			return;
		}

		lastAutoInjectedProcessId = selectedProcess.method_0();
		processRefreshTimer.Stop();
		Class171.BeginInjection(this);
	}

	internal void OnBackgroundPaint(object sender, PaintEventArgs e)
	{
		if (ClientSize.IsEmpty)
		{
			return;
		}

		Rectangle bounds = new Rectangle(Point.Empty, ClientSize);
		using (LinearGradientBrush brush = new LinearGradientBrush(
			bounds,
			ApplicationSettings.Current.Options.BackgroundColor1,
			ApplicationSettings.Current.Options.BackgroundColor2,
			90f))
		{
			e.Graphics.FillRectangle(brush, bounds);
		}
	}

	internal void OnClearModulesClicked(object sender, EventArgs e)
	{
		moduleGrid.Rows.Clear();
		ApplicationSettings.Current.Modules.Clear();
		ApplicationSettings.Save();
	}

	internal void OnRemoveModuleClicked(object sender, EventArgs e)
	{
		if (moduleGrid.SelectedRows.Count == 0)
		{
			return;
		}

		DataGridViewRow selectedRow = moduleGrid.SelectedRows[0];
		moduleGrid.Rows.Remove(selectedRow);
		ApplicationSettings.Current.Modules.Remove(((ModuleRow)selectedRow.Tag).Entry);
		ApplicationSettings.Save();
	}

	internal void OnToggleModuleClicked(object sender, EventArgs e)
	{
		if (moduleGrid.SelectedRows.Count != 0)
		{
			Class171.ToggleModuleEnabled(this, moduleGrid.SelectedRows[0].Index);
		}
	}

	internal void OnAddDllClicked(object sender, EventArgs e)
	{
		using (OpenFileDialog dialog = new OpenFileDialog { Filter = "DLL Files|*.dll" })
		{
			if (dialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			Class171.AddModuleToGrid(bool_0: true, null, bool_1: true, this, dialog.FileName);
			ApplicationSettings.Save();
		}
	}

	internal void OnModuleGridCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (e.RowIndex < 0)
		{
			return;
		}

		if (e.ColumnIndex == enabledColumn.Index)
		{
			Class171.ToggleModuleEnabled(this, e.RowIndex);
		}
		else if (e.ColumnIndex == exportOptionsColumn.Index)
		{
			Class171.EditModuleOptions((ModuleRow)moduleGrid.Rows[e.RowIndex].Tag);
		}
	}

	internal void OnProcessIconClicked(object sender, EventArgs e)
	{
		if (selectedProcess != null)
		{
			Class171.ShowProcessInspector(selectedProcess);
		}
	}

	internal void OnResize(object sender, EventArgs e)
	{
		Refresh();
	}

	internal void OnAboutClicked(object sender, EventArgs e)
	{
		using (AboutForm aboutForm = new AboutForm())
		{
			aboutForm.ShowDialog(this);
		}
	}

	internal void OnSettingsClicked(object sender, EventArgs e)
	{
		Class171.ShowSettings(selectedProcess);
		Invalidate();
		Class171.ApplyMainFormTheme(this);
	}

	internal void OnInjectClicked(object sender, EventArgs e)
	{
		Class171.BeginInjection(this);
	}

	internal void OnLoad(object sender, EventArgs e)
	{
		DoubleBuffered = true;
		if (Program.UsesExternalSettings)
		{
			Text = Class171.smethod_275(Class127.random_0.Next(10, 25));
		}
	}

	internal void OnMouseUp(object sender, MouseEventArgs e)
	{
		if (injectButton.Enabled || GetChildAtPoint(e.Location) != injectButton)
		{
			return;
		}

		if (ApplicationSettings.Current.Options.AutoInject)
		{
			MessageBox.Show(
				"Extreme Injector is waiting for the specified process (" + processNameTextBox.Text + ") to start because you selected auto-inject. Extreme Injector will automatically inject when the process starts.",
				"Extreme Injector v3",
				MessageBoxButtons.OK,
				MessageBoxIcon.Asterisk);
		}
		else if (string.IsNullOrEmpty(processNameTextBox.Text))
		{
			MessageBox.Show(
				"You have not selected or entered a process to be injected.",
				"Extreme Injector v3",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation);
		}
		else
		{
			MessageBox.Show(
				"You have not selected or entered a process that is currently running.",
				"Extreme Injector v3",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation);
		}
	}

	internal void OnModulesDropped(object sender, EventArgs0 e)
	{
		foreach (string modulePath in e.method_1())
		{
			Class171.AddModuleToGrid(bool_0: true, null, bool_1: true, this, modulePath);
		}

		ApplicationSettings.Save();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			icontainer_0?.Dispose();
		}

		base.Dispose(disposing);
	}
}
