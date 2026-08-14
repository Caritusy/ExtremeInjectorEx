using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ExtremeInjector;
using Microsoft.Win32;

public sealed partial class RecoveredRuntime
{

	internal static void ConfigureInstallerDownload(DependencyInstallerForm form3_0, string string_0, string string_1, string string_2)
	{
		form3_0.string_0 = string_0;
		form3_0.string_1 = string_1;
		form3_0.string_2 = string_2;
		form3_0.bool_0 = true;
	}

	internal static void ConfigureArchiveDownload(DependencyInstallerForm form3_0, string string_0, string string_1)
	{
		form3_0.string_0 = string_0;
		form3_0.string_1 = string_1;
		form3_0.bool_0 = false;
	}

	internal static Bitmap CreateSmallIconBitmap(Icon icon_0)
	{
		Bitmap result;
		using (Bitmap bitmap = icon_0.ToBitmap())
		{
			Bitmap bitmap2 = new Bitmap(22, 22);
			using (Graphics graphics = Graphics.FromImage(bitmap2))
			{
				graphics.InterpolationMode = InterpolationMode.High;
				graphics.DrawImage(bitmap, 0, 0, bitmap2.Width, bitmap2.Height);
			}
			result = bitmap2;
		}
		return result;
	}

	internal static void ToggleModuleEnabled(MainForm mainForm, int int_0)
	{
		if (int_0 < 0 || int_0 >= mainForm.moduleGrid.Rows.Count)
		{
			return;
		}

		DataGridViewRow row = mainForm.moduleGrid.Rows[int_0];
		bool enabled = !(bool)row.Cells[0].Value;
		row.Cells[0].Value = enabled;
		((MainForm.ModuleRow)row.Tag).Entry.Enabled = enabled;
		ApplicationSettings.Save();
	}

	internal static void InitializeDependencyInstallerForm(DependencyInstallerForm form3_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DependencyInstallerForm));
		form3_0.label_0 = new System.Windows.Forms.Label();
		form3_0.progressBar_0 = new ProgressBar();
		form3_0.SuspendLayout();
		form3_0.label_0.AutoSize = true;
		form3_0.label_0.Font = new Font(EncodedStringTable.DecodeString(11956), 8.75f);
		form3_0.label_0.Location = new Point(9, 9);
		form3_0.label_0.Name = EncodedStringTable.DecodeString(12983);
		form3_0.label_0.Size = new Size(170, 15);
		form3_0.label_0.TabIndex = 0;
		form3_0.label_0.Text = EncodedStringTable.DecodeString(13000);
		form3_0.progressBar_0.Location = new Point(12, 29);
		form3_0.progressBar_0.Name = EncodedStringTable.DecodeString(13041);
		form3_0.progressBar_0.Size = new Size(448, 23);
		form3_0.progressBar_0.TabIndex = 1;
		form3_0.AutoScaleDimensions = new SizeF(96f, 96f);
		form3_0.AutoScaleMode = AutoScaleMode.Dpi;
		form3_0.ClientSize = new Size(472, 64);
		form3_0.Controls.Add(form3_0.progressBar_0);
		form3_0.Controls.Add(form3_0.label_0);
		form3_0.Font = new Font(EncodedStringTable.DecodeString(11956), 8.25f);
		form3_0.FormBorderStyle = FormBorderStyle.FixedSingle;
		form3_0.Icon = (Icon)componentResourceManager.GetObject(EncodedStringTable.DecodeString(13062));
		form3_0.MaximizeBox = false;
		form3_0.MinimizeBox = false;
		form3_0.Name = EncodedStringTable.DecodeString(13079);
		form3_0.Text = EncodedStringTable.DecodeString(13108);
		form3_0.FormClosing += form3_0.OnFormClosing;
		form3_0.Load += form3_0.OnFormLoad;
		form3_0.ResumeLayout(false);
		form3_0.PerformLayout();
	}

	internal static bool StripNumericPrefix(ref string string_0, [Out] ModuleOptionsForm form0_0, string string_1)
	{
		if (string_1.StartsWith(EncodedStringTable.DecodeString(2072)) || string_1.StartsWith(EncodedStringTable.DecodeString(13195)))
		{
			string_0 = string_1.Substring(2);
			return true;
		}
		string_0 = string_1;
		return false;
	}

	internal static MainForm.ModuleRow[] GetEnabledModuleRows(MainForm mainForm)
	{
		return mainForm.moduleGrid.Rows
			.Cast<DataGridViewRow>()
			.Select(row => (MainForm.ModuleRow)row.Tag)
			.Where(module => module.Entry.Enabled)
			.ToArray();
	}

	internal static void ShowInjectionError(MainForm mainForm, string message, Exception exception)
	{
		mainForm.Invoke((MethodInvoker)delegate
		{
			MessageBox.Show(
				mainForm,
				FormatExceptionChain(message, exception, bool_0: true),
				UiText.Get("App.Title"),
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation);
		});
	}

	internal static void ShowUnsupportedWindowsXpMessage(string string_0, MainForm mainForm, string string_1)
	{
		MessageBox.Show(mainForm, UiText.Format("Message.Dependency.UnsupportedXp", string_1, string_0), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	internal static void WaitWithStatus(MainForm mainForm, int int_0, string string_0)
	{
		for (int elapsedMilliseconds = 0; elapsedMilliseconds < int_0; elapsedMilliseconds += 100)
		{
			float remainingSeconds = (float)(int_0 - elapsedMilliseconds) / 1000f;
			mainForm.BeginInvoke((Action)(() =>
			{
				mainForm.processDescriptionLabel.Text = string.Format(string_0, remainingSeconds);
			}));
			Thread.Sleep(100);
		}
	}

	internal static bool InjectModule(ref IntPtr moduleBase, MainForm mainForm, ScramblePreset scramblePreset, string sourceModulePath)
	{
		return InjectModule(
			ref moduleBase,
			mainForm.selectedProcess,
			ApplicationSettings.Current.Options,
			scramblePreset,
			sourceModulePath,
			message => mainForm.Invoke((MethodInvoker)delegate
			{
				MessageBox.Show(
					mainForm,
					message,
					UiText.Get("App.Title"),
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}),
			(message, exception) => ShowInjectionError(mainForm, message, exception));
	}

	internal static bool InjectModule(
		ref IntPtr moduleBase,
		RemoteProcess process,
		InjectionOptions options,
		ScramblePreset scramblePreset,
		string sourceModulePath,
		Action<string> reportMessage,
		Action<string, Exception> reportError)
	{
		moduleBase = IntPtr.Zero;
		string workingModulePath = sourceModulePath;

		try
		{
			if (!ModuleMatchesProcessArchitecture(process, sourceModulePath, out string mismatchMessage))
			{
				reportMessage?.Invoke(mismatchMessage);
				return false;
			}

			workingModulePath = PrepareModuleForInjection(sourceModulePath, options, scramblePreset);
			moduleBase = InjectWithConfiguredBackend(process, workingModulePath, sourceModulePath, options, reportError);
			if (moduleBase == IntPtr.Zero)
			{
				throw new InvalidOperationException(UiText.Get("Message.InjectionReturnedNull"));
			}

			return true;
		}
		catch (Exception exception)
		{
			string processName = process?.Name ?? UiText.Get("Common.UnknownProcess");
			reportError?.Invoke(UiText.Format("Message.InjectFailed", Path.GetFileName(sourceModulePath), processName), exception);
			return false;
		}
		finally
		{
			if (options.StealthInject && !string.Equals(workingModulePath, sourceModulePath, StringComparison.OrdinalIgnoreCase))
			{
				try
				{
					if (File.Exists(workingModulePath))
					{
						File.Delete(workingModulePath);
					}
				}
				catch
				{
				}
			}
		}
	}

	internal static void UpdateScrambleOptionAvailability(AdvancedScrambleSettingsForm gform1_0)
	{
		bool enabled = gform1_0.checkBox_3.Checked;
		gform1_0.checkBox_9.Enabled = enabled;
		gform1_0.checkBox_7.Enabled = enabled;
		gform1_0.checkBox_6.Enabled = enabled;
	}

	internal static bool ConfirmDependencyInstallation(MainForm mainForm, string string_0, string string_1, string string_2, bool bool_0, string string_3)
	{
		if (bool_0)
		{
			if (MessageBox.Show(mainForm, string.Concat(new string[]
			{
				EncodedStringTable.DecodeString(13250),
				string_0,
				EncodedStringTable.DecodeString(13291),
				string_1,
				EncodedStringTable.DecodeString(23898),
				string_2,
				EncodedStringTable.DecodeString(24068),
				string_3,
				EncodedStringTable.DecodeString(24129),
				string_3,
				EncodedStringTable.DecodeString(24174)
			}), EncodedStringTable.DecodeString(599), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
			{
				return false;
			}
		}
		else if (MessageBox.Show(mainForm, string.Concat(new string[]
		{
			EncodedStringTable.DecodeString(13250),
			string_0,
			EncodedStringTable.DecodeString(13291),
			string_1,
			EncodedStringTable.DecodeString(24183),
			string_3,
			EncodedStringTable.DecodeString(24341)
		}), EncodedStringTable.DecodeString(599), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
		{
			return false;
		}
		return true;
	}

	internal static bool TryAddExportParameter(ModuleOptionsForm form0_0, string string_0, ExportParameterType enum5_0, bool bool_0)
	{
		string numericText = string_0;
		bool hexadecimal = StripNumericPrefix(ref numericText, form0_0, numericText);
		NumberStyles numberStyle = hexadecimal ? NumberStyles.HexNumber : NumberStyles.Integer;
		bool valid;

		switch (enum5_0)
		{
		case ExportParameterType.AnsiString:
		case ExportParameterType.UnicodeString:
			valid = true;
			break;
		case ExportParameterType.Byte:
			valid = byte.TryParse(numericText, numberStyle, CultureInfo.InvariantCulture, out _) ||
				(!hexadecimal && (sbyte.TryParse(numericText, NumberStyles.Integer, CultureInfo.InvariantCulture, out _) || char.TryParse(string_0, out _)));
			break;
		case ExportParameterType.UInt16:
			valid = ushort.TryParse(numericText, numberStyle, CultureInfo.InvariantCulture, out _) ||
				(!hexadecimal && (short.TryParse(numericText, NumberStyles.Integer, CultureInfo.InvariantCulture, out _) || char.TryParse(string_0, out _)));
			break;
		case ExportParameterType.UInt32:
			valid = uint.TryParse(numericText, numberStyle, CultureInfo.InvariantCulture, out _) ||
				(!hexadecimal && int.TryParse(numericText, NumberStyles.Integer, CultureInfo.InvariantCulture, out _));
			break;
		case ExportParameterType.UInt64:
			valid = ulong.TryParse(numericText, numberStyle, CultureInfo.InvariantCulture, out _) ||
				(!hexadecimal && long.TryParse(numericText, NumberStyles.Integer, CultureInfo.InvariantCulture, out _));
			break;
		case ExportParameterType.Single:
			valid = !hexadecimal && float.TryParse(string_0, NumberStyles.Float, CultureInfo.InvariantCulture, out _);
			break;
		default:
			valid = false;
			break;
		}

		if (!valid)
		{
			return false;
		}

		form0_0.dataGridView_0.Rows.Add(null, form0_0.comboBox_2.Items[(int)enum5_0].ToString(), string_0);
		if (bool_0)
		{
			if (form0_0.Module.Parameters == null)
			{
				form0_0.Module.Parameters = new List<ExportParameter>();
			}

			form0_0.Module.Parameters.Add(new ExportParameter
			{
				Type = enum5_0,
				Value = string_0
			});
		}

		return true;
	}

	internal static void CompleteInjection(bool bool_0, MainForm mainForm)
	{
		if (ApplicationSettings.Current.Options.CloseOnInject)
		{
			mainForm.Close();
			return;
		}

		if (bool_0)
		{
			MessageBox.Show(UiText.Get("Message.InjectionCompleted"), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		if (mainForm.selectedProcess != null && HasProcessExited(mainForm.selectedProcess))
		{
			SetSelectedProcess(mainForm, null);
		}

		mainForm.settingsButton.Enabled = true;
		mainForm.injectButton.Enabled = mainForm.selectedProcess != null && !ApplicationSettings.Current.Options.AutoInject;
		mainForm.processRefreshTimer.Start();
	}

	internal static void PromptDependencyInstallation(string string_0, MainForm mainForm, string string_1, string string_2, string string_3)
	{
		DialogResult dialogResult = MessageBox.Show(mainForm, string.Concat(new string[]
		{
			EncodedStringTable.DecodeString(13250),
			string_0,
			EncodedStringTable.DecodeString(13291),
			string_3,
			EncodedStringTable.DecodeString(25673)
		}), EncodedStringTable.DecodeString(599), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
		if (dialogResult != DialogResult.Yes)
		{
			if (dialogResult == DialogResult.No)
			{
				MessageBox.Show(mainForm, EncodedStringTable.DecodeString(26205) + string_1 + EncodedStringTable.DecodeString(26318), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Process.Start(string_2);
			}
			return;
		}
		if (RecoveredRuntime.IsAdministrator())
		{
			DependencyInstallerForm form = new DependencyInstallerForm();
			RecoveredRuntime.ConfigureArchiveDownload(form, string_2, string_1);
			form.ShowDialog();
			return;
		}
		MessageBox.Show(mainForm, EncodedStringTable.DecodeString(26027), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	internal static void InitializeProcessInspectorForm(ProcessInspectorForm form4_0)
	{
		form4_0.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ProcessInspectorForm));
		form4_0.button_1 = new Button();
		form4_0.button_0 = new Button();
		form4_0.dataGridView_0 = new DataGridView();
		form4_0.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		form4_0.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		form4_0.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		form4_0.groupBox_0 = new GroupBox();
		form4_0.label_0 = new System.Windows.Forms.Label();
		form4_0.pictureBox_0 = new PictureBox();
		form4_0.timer_0 = new System.Windows.Forms.Timer(form4_0.icontainer_0);
		form4_0.button_2 = new Button();
		form4_0.tabControl_0 = new TabControl();
		form4_0.tabPage_0 = new TabPage();
		form4_0.tabPage_1 = new TabPage();
		form4_0.dataGridView_1 = new DataGridView();
		form4_0.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		form4_0.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		form4_0.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		form4_0.button_3 = new Button();
		form4_0.button_4 = new Button();
		((ISupportInitialize)form4_0.dataGridView_0).BeginInit();
		form4_0.groupBox_0.SuspendLayout();
		((ISupportInitialize)form4_0.pictureBox_0).BeginInit();
		form4_0.tabControl_0.SuspendLayout();
		form4_0.tabPage_0.SuspendLayout();
		form4_0.tabPage_1.SuspendLayout();
		((ISupportInitialize)form4_0.dataGridView_1).BeginInit();
		form4_0.SuspendLayout();
		form4_0.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		form4_0.button_1.Enabled = false;
		form4_0.button_1.Location = new Point(279, 215);
		form4_0.button_1.Name = EncodedStringTable.DecodeString(26363);
		form4_0.button_1.Size = new Size(97, 22);
		form4_0.button_1.TabIndex = 14;
		form4_0.button_1.Text = EncodedStringTable.DecodeString(26380);
		form4_0.button_1.UseVisualStyleBackColor = true;
		form4_0.button_1.Click += form4_0.OnUnloadModuleClick;
		form4_0.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		form4_0.button_0.Location = new Point(199, 442);
		form4_0.button_0.Name = EncodedStringTable.DecodeString(26401);
		form4_0.button_0.Size = new Size(97, 22);
		form4_0.button_0.TabIndex = 13;
		form4_0.button_0.Text = EncodedStringTable.DecodeString(26418);
		form4_0.button_0.UseVisualStyleBackColor = true;
		form4_0.button_0.Click += form4_0.OnTerminateProcessClick;
		form4_0.dataGridView_0.AllowUserToAddRows = false;
		form4_0.dataGridView_0.AllowUserToDeleteRows = false;
		form4_0.dataGridView_0.AllowUserToResizeRows = false;
		form4_0.dataGridView_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		form4_0.dataGridView_0.BackgroundColor = Color.White;
		form4_0.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		form4_0.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
		{
			form4_0.dataGridViewTextBoxColumn_0,
			form4_0.dataGridViewTextBoxColumn_1,
			form4_0.dataGridViewTextBoxColumn_2
		});
		form4_0.dataGridView_0.Location = new Point(0, 0);
		form4_0.dataGridView_0.MultiSelect = false;
		form4_0.dataGridView_0.Name = EncodedStringTable.DecodeString(26435);
		form4_0.dataGridView_0.ReadOnly = true;
		form4_0.dataGridView_0.RowHeadersVisible = false;
		form4_0.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		form4_0.dataGridView_0.Size = new Size(379, 209);
		form4_0.dataGridView_0.TabIndex = 11;
		form4_0.dataGridView_0.SelectionChanged += form4_0.OnModuleSelectionChanged;
		form4_0.dataGridView_0.SortCompare += form4_0.OnGridSortCompare;
		form4_0.dataGridViewTextBoxColumn_0.HeaderText = EncodedStringTable.DecodeString(26464);
		form4_0.dataGridViewTextBoxColumn_0.Name = EncodedStringTable.DecodeString(26481);
		form4_0.dataGridViewTextBoxColumn_0.ReadOnly = true;
		form4_0.dataGridViewTextBoxColumn_0.Width = 150;
		form4_0.dataGridViewTextBoxColumn_1.HeaderText = EncodedStringTable.DecodeString(26506);
		form4_0.dataGridViewTextBoxColumn_1.Name = EncodedStringTable.DecodeString(26523);
		form4_0.dataGridViewTextBoxColumn_1.ReadOnly = true;
		form4_0.dataGridViewTextBoxColumn_1.Width = 120;
		form4_0.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		form4_0.dataGridViewTextBoxColumn_2.HeaderText = EncodedStringTable.DecodeString(26548);
		form4_0.dataGridViewTextBoxColumn_2.Name = EncodedStringTable.DecodeString(26565);
		form4_0.dataGridViewTextBoxColumn_2.ReadOnly = true;
		form4_0.groupBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		form4_0.groupBox_0.Controls.Add(form4_0.label_0);
		form4_0.groupBox_0.Controls.Add(form4_0.pictureBox_0);
		form4_0.groupBox_0.Location = new Point(12, 12);
		form4_0.groupBox_0.Name = EncodedStringTable.DecodeString(26590);
		form4_0.groupBox_0.Size = new Size(387, 154);
		form4_0.groupBox_0.TabIndex = 10;
		form4_0.groupBox_0.TabStop = false;
		form4_0.groupBox_0.Text = EncodedStringTable.DecodeString(26611);
		form4_0.label_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		form4_0.label_0.Location = new Point(47, 21);
		form4_0.label_0.Name = EncodedStringTable.DecodeString(26624);
		form4_0.label_0.Size = new Size(334, 123);
		form4_0.label_0.TabIndex = 5;
		form4_0.label_0.Text = EncodedStringTable.DecodeString(26653);
		form4_0.pictureBox_0.BackColor = Color.Transparent;
		form4_0.pictureBox_0.Location = new Point(9, 21);
		form4_0.pictureBox_0.Name = EncodedStringTable.DecodeString(26670);
		form4_0.pictureBox_0.Size = new Size(32, 32);
		form4_0.pictureBox_0.TabIndex = 4;
		form4_0.pictureBox_0.TabStop = false;
		form4_0.timer_0.Interval = 250;
		form4_0.timer_0.Tick += form4_0.OnProcessExitTimerTick;
		form4_0.button_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		form4_0.button_2.Location = new Point(302, 442);
		form4_0.button_2.Name = EncodedStringTable.DecodeString(23701);
		form4_0.button_2.Size = new Size(97, 22);
		form4_0.button_2.TabIndex = 12;
		form4_0.button_2.Text = EncodedStringTable.DecodeString(23718);
		form4_0.button_2.UseVisualStyleBackColor = true;
		form4_0.button_2.Click += form4_0.OnCloseClick;
		form4_0.tabControl_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		form4_0.tabControl_0.Controls.Add(form4_0.tabPage_0);
		form4_0.tabControl_0.Controls.Add(form4_0.tabPage_1);
		form4_0.tabControl_0.Location = new Point(12, 172);
		form4_0.tabControl_0.Name = EncodedStringTable.DecodeString(26695);
		form4_0.tabControl_0.SelectedIndex = 0;
		form4_0.tabControl_0.Size = new Size(387, 266);
		form4_0.tabControl_0.TabIndex = 15;
		form4_0.tabPage_0.Controls.Add(form4_0.dataGridView_0);
		form4_0.tabPage_0.Controls.Add(form4_0.button_1);
		form4_0.tabPage_0.Location = new Point(4, 22);
		form4_0.tabPage_0.Name = EncodedStringTable.DecodeString(26716);
		form4_0.tabPage_0.Size = new Size(379, 240);
		form4_0.tabPage_0.TabIndex = 0;
		form4_0.tabPage_0.Text = EncodedStringTable.DecodeString(26737);
		form4_0.tabPage_0.UseVisualStyleBackColor = true;
		form4_0.tabPage_1.Controls.Add(form4_0.button_4);
		form4_0.tabPage_1.Controls.Add(form4_0.button_3);
		form4_0.tabPage_1.Controls.Add(form4_0.dataGridView_1);
		form4_0.tabPage_1.Location = new Point(4, 22);
		form4_0.tabPage_1.Name = EncodedStringTable.DecodeString(26750);
		form4_0.tabPage_1.Size = new Size(379, 240);
		form4_0.tabPage_1.TabIndex = 1;
		form4_0.tabPage_1.Text = EncodedStringTable.DecodeString(26771);
		form4_0.tabPage_1.UseVisualStyleBackColor = true;
		form4_0.dataGridView_1.AllowUserToAddRows = false;
		form4_0.dataGridView_1.AllowUserToDeleteRows = false;
		form4_0.dataGridView_1.AllowUserToResizeRows = false;
		form4_0.dataGridView_1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		form4_0.dataGridView_1.BackgroundColor = Color.White;
		form4_0.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		form4_0.dataGridView_1.Columns.AddRange(new DataGridViewColumn[]
		{
			form4_0.dataGridViewTextBoxColumn_3,
			form4_0.dataGridViewTextBoxColumn_4,
			form4_0.dataGridViewTextBoxColumn_5
		});
		form4_0.dataGridView_1.Location = new Point(0, 0);
		form4_0.dataGridView_1.MultiSelect = false;
		form4_0.dataGridView_1.Name = EncodedStringTable.DecodeString(26784);
		form4_0.dataGridView_1.ReadOnly = true;
		form4_0.dataGridView_1.RowHeadersVisible = false;
		form4_0.dataGridView_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		form4_0.dataGridView_1.Size = new Size(379, 209);
		form4_0.dataGridView_1.TabIndex = 12;
		form4_0.dataGridView_1.SelectionChanged += form4_0.OnThreadSelectionChanged;
		form4_0.dataGridView_1.SortCompare += form4_0.OnGridSortCompare;
		form4_0.dataGridViewTextBoxColumn_3.HeaderText = EncodedStringTable.DecodeString(26813);
		form4_0.dataGridViewTextBoxColumn_3.Name = EncodedStringTable.DecodeString(26826);
		form4_0.dataGridViewTextBoxColumn_3.ReadOnly = true;
		form4_0.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		form4_0.dataGridViewTextBoxColumn_4.HeaderText = EncodedStringTable.DecodeString(26847);
		form4_0.dataGridViewTextBoxColumn_4.Name = EncodedStringTable.DecodeString(26868);
		form4_0.dataGridViewTextBoxColumn_4.ReadOnly = true;
		form4_0.dataGridViewTextBoxColumn_5.HeaderText = EncodedStringTable.DecodeString(26901);
		form4_0.dataGridViewTextBoxColumn_5.Name = EncodedStringTable.DecodeString(26914);
		form4_0.dataGridViewTextBoxColumn_5.ReadOnly = true;
		form4_0.button_3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		form4_0.button_3.Enabled = false;
		form4_0.button_3.Location = new Point(279, 215);
		form4_0.button_3.Name = EncodedStringTable.DecodeString(26939);
		form4_0.button_3.Size = new Size(97, 22);
		form4_0.button_3.TabIndex = 15;
		form4_0.button_3.Text = EncodedStringTable.DecodeString(12632);
		form4_0.button_3.UseVisualStyleBackColor = true;
		form4_0.button_3.Click += form4_0.OnToggleThreadSuspensionClick;
		form4_0.button_4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		form4_0.button_4.Enabled = false;
		form4_0.button_4.Location = new Point(176, 215);
		form4_0.button_4.Name = EncodedStringTable.DecodeString(26968);
		form4_0.button_4.Size = new Size(97, 22);
		form4_0.button_4.TabIndex = 16;
		form4_0.button_4.Text = EncodedStringTable.DecodeString(26993);
		form4_0.button_4.UseVisualStyleBackColor = true;
		form4_0.button_4.Click += form4_0.OnTerminateThreadClick;
		form4_0.AutoScaleDimensions = new SizeF(96f, 96f);
		form4_0.AutoScaleMode = AutoScaleMode.Dpi;
		form4_0.ClientSize = new Size(410, 469);
		form4_0.Controls.Add(form4_0.tabControl_0);
		form4_0.Controls.Add(form4_0.button_0);
		form4_0.Controls.Add(form4_0.button_2);
		form4_0.Controls.Add(form4_0.groupBox_0);
		form4_0.Font = new Font(EncodedStringTable.DecodeString(11956), 8.25f);
		form4_0.FormBorderStyle = FormBorderStyle.SizableToolWindow;
		form4_0.Icon = (Icon)componentResourceManager.GetObject(EncodedStringTable.DecodeString(13062));
		form4_0.MaximizeBox = false;
		form4_0.MinimizeBox = false;
		form4_0.Name = EncodedStringTable.DecodeString(27002);
		form4_0.Text = EncodedStringTable.DecodeString(27023);
		form4_0.Load += form4_0.OnFormLoad;
		((ISupportInitialize)form4_0.dataGridView_0).EndInit();
		form4_0.groupBox_0.ResumeLayout(false);
		((ISupportInitialize)form4_0.pictureBox_0).EndInit();
		form4_0.tabControl_0.ResumeLayout(false);
		form4_0.tabPage_0.ResumeLayout(false);
		form4_0.tabPage_1.ResumeLayout(false);
		((ISupportInitialize)form4_0.dataGridView_1).EndInit();
		form4_0.ResumeLayout(false);
	}

	internal static void CheckForUpdatesAndNotify()
	{
		string str;
		if (!RecoveredRuntime.TryCheckForUpdate(out str))
		{
			return;
		}
		MessageBox.Show(EncodedStringTable.DecodeString(27052) + str + EncodedStringTable.DecodeString(27125), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	internal static void SelectCurrentScramblePreset(SettingsForm gform2_0)
	{
		ScramblePreset @enum = ApplicationSettings.Current.Options.Scramble.Detect();
		if (@enum == ScramblePreset.None)
		{
			gform2_0.comboBox_1.SelectedIndex = 0;
			return;
		}
		if (@enum != ScramblePreset.Custom)
		{
			gform2_0.comboBox_1.SelectedIndex = @enum - ScramblePreset.Custom;
			return;
		}
		gform2_0.comboBox_1.SelectedIndex = gform2_0.comboBox_1.Items.Count - 1;
	}
}
