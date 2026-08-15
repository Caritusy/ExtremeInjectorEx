using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public sealed partial class ProcessSelectorForm : Form
{
	internal RemoteProcess SelectedProcess { get; private set; }

	internal IContainer container = null;

	internal DataGridView processGrid;

	internal DataGridViewImageColumn processIconColumn;

	internal DataGridViewTextBoxColumn processNameColumn;

	internal Button allProcessesButton;

	internal Button windowedProcessesButton;

	internal Button selectButton;

	internal Button cancelButton;

	public ProcessSelectorForm()
	{
		InitializeModernProcessSelectorForm();
		PopulateAllProcesses();
	}

	internal void OnCancelClick(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	internal void OnSelectClick(object sender, EventArgs e)
	{
		if (processGrid.SelectedRows.Count == 0 ||
			processGrid.SelectedRows[0].Tag is not RemoteProcess selectedProcess)
		{
			return;
		}

		SelectedProcess = selectedProcess;
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	internal void OnAllProcessesClick(object sender, EventArgs e)
	{
		PopulateAllProcesses();
	}

	internal void OnProcessDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			selectButton.PerformClick();
		}
	}

	internal void OnWindowedProcessesClick(object sender, EventArgs e)
	{
		PopulateWindowedProcesses();
	}

	private void PopulateAllProcesses()
	{
		var rows = new List<ProcessSelectionRow>();
		foreach (RemoteProcess process in RecoveredRuntime.EnumerateRemoteProcesses())
		{
			using (Icon icon = RecoveredRuntime.GetFileIcon(process.FilePath, IconSize.Large))
			{
				rows.Add(new ProcessSelectionRow(
					CreateProcessBitmap(icon),
					UiText.Format("ProcessList.Entry", process.ProcessId, process.Name),
					process));
			}
		}

		ReplaceRows(rows);
	}

	private void PopulateWindowedProcesses()
	{
		var rows = new List<ProcessSelectionRow>();
		foreach (ProcessWindowInfo window in RecoveredRuntime.EnumerateTopLevelWindows())
		{
			string title = RecoveredRuntime.GetWindowTitle(window);
			if (!RecoveredRuntime.IsProcessWindowVisible(window) || title.Length == 0)
			{
				continue;
			}

			RemoteProcess process = RecoveredRuntime.OpenRemoteProcessById(window.GetProcessId());
			if (process == null)
			{
				continue;
			}

			using (Icon icon = RecoveredRuntime.GetWindowIcon(window))
			{
				rows.Add(new ProcessSelectionRow(
					CreateProcessBitmap(icon),
					UiText.Format("ProcessList.Entry", window.GetProcessId(), title),
					process));
			}
		}

		ReplaceRows(rows);
	}

	private static Bitmap CreateProcessBitmap(Icon icon)
	{
		return icon == null ? new Bitmap(22, 22) : RecoveredRuntime.CreateSmallIconBitmap(icon);
	}

	private void ReplaceRows(IReadOnlyList<ProcessSelectionRow> rows)
	{
		ClearRows();
		foreach (ProcessSelectionRow row in rows)
		{
			int index = processGrid.Rows.Add(row.Icon, row.DisplayName);
			processGrid.Rows[index].Tag = row.Process;
		}

		bool hasRows = processGrid.Rows.Count > 0;
		selectButton.Enabled = hasRows;
		if (hasRows)
		{
			processGrid.Rows[0].Selected = true;
			processGrid.CurrentCell = processGrid.Rows[0].Cells[1];
		}

		ApplyModernProcessSelectorTheme();
	}

	private void ClearRows()
	{
		foreach (DataGridViewRow row in processGrid.Rows)
		{
			if (row.Cells.Count > 0 && row.Cells[0].Value is Image image)
			{
				image.Dispose();
			}
		}

		processGrid.Rows.Clear();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (processGrid != null)
			{
				ClearRows();
			}

			this.container?.Dispose();
		}
		base.Dispose(disposing);
	}

	private sealed class ProcessSelectionRow
	{
		internal ProcessSelectionRow(Bitmap icon, string displayName, RemoteProcess process)
		{
			Icon = icon;
			DisplayName = displayName;
			Process = process;
		}

		internal Bitmap Icon { get; }

		internal string DisplayName { get; }

		internal RemoteProcess Process { get; }
	}
}
