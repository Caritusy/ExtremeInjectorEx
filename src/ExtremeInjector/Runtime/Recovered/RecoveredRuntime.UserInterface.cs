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

	internal static void smethod_22(ModuleOptionsForm form0_0)
	{
		form0_0.groupBox_0 = new ModernCard();
		form0_0.button_0 = new Button();
		form0_0.textBox_0 = new TextBox();
		form0_0.comboBox_2 = new ComboBox();
		form0_0.dataGridView_0 = new DataGridView();
		form0_0.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		form0_0.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		form0_0.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		form0_0.label_2 = new System.Windows.Forms.Label();
		form0_0.comboBox_1 = new ComboBox();
		form0_0.label_1 = new System.Windows.Forms.Label();
		form0_0.comboBox_0 = new ComboBox();
		form0_0.label_0 = new System.Windows.Forms.Label();
		form0_0.groupBox_0.SuspendLayout();
		((ISupportInitialize)form0_0.dataGridView_0).BeginInit();
		form0_0.SuspendLayout();
		form0_0.groupBox_0.Controls.Add(form0_0.button_0);
		form0_0.groupBox_0.Controls.Add(form0_0.textBox_0);
		form0_0.groupBox_0.Controls.Add(form0_0.comboBox_2);
		form0_0.groupBox_0.Controls.Add(form0_0.dataGridView_0);
		form0_0.groupBox_0.Controls.Add(form0_0.label_2);
		form0_0.groupBox_0.Controls.Add(form0_0.comboBox_1);
		form0_0.groupBox_0.Controls.Add(form0_0.label_1);
		form0_0.groupBox_0.Controls.Add(form0_0.comboBox_0);
		form0_0.groupBox_0.Controls.Add(form0_0.label_0);
		form0_0.groupBox_0.Location = new Point(12, 12);
		form0_0.groupBox_0.Name = EncodedStringTable.smethod_0(11520);
		form0_0.groupBox_0.Size = new Size(246, 256);
		form0_0.groupBox_0.TabIndex = 0;
		form0_0.groupBox_0.TabStop = false;
		form0_0.groupBox_0.Text = EncodedStringTable.smethod_0(11541);
		form0_0.button_0.Location = new Point(188, 227);
		form0_0.button_0.Name = EncodedStringTable.smethod_0(11562);
		form0_0.button_0.Size = new Size(51, 23);
		form0_0.button_0.TabIndex = 8;
		form0_0.button_0.Text = EncodedStringTable.smethod_0(11575);
		form0_0.button_0.UseVisualStyleBackColor = true;
		form0_0.button_0.Click += form0_0.method_7;
		form0_0.textBox_0.Location = new Point(92, 228);
		form0_0.textBox_0.Name = EncodedStringTable.smethod_0(11580);
		form0_0.textBox_0.Size = new Size(90, 22);
		form0_0.textBox_0.TabIndex = 7;
		form0_0.comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
		form0_0.comboBox_2.FormattingEnabled = true;
		form0_0.comboBox_2.Location = new Point(10, 229);
		form0_0.comboBox_2.Name = EncodedStringTable.smethod_0(11601);
		form0_0.comboBox_2.Size = new Size(76, 21);
		form0_0.comboBox_2.TabIndex = 6;
		form0_0.dataGridView_0.AllowUserToAddRows = false;
		form0_0.dataGridView_0.AllowUserToResizeColumns = false;
		form0_0.dataGridView_0.AllowUserToResizeRows = false;
		form0_0.dataGridView_0.BackgroundColor = Color.White;
		form0_0.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		form0_0.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
		{
			form0_0.dataGridViewTextBoxColumn_0,
			form0_0.dataGridViewTextBoxColumn_1,
			form0_0.dataGridViewTextBoxColumn_2
		});
		form0_0.dataGridView_0.Location = new Point(10, 124);
		form0_0.dataGridView_0.MultiSelect = false;
		form0_0.dataGridView_0.Name = EncodedStringTable.smethod_0(11626);
		form0_0.dataGridView_0.ReadOnly = true;
		form0_0.dataGridView_0.RowHeadersVisible = false;
		form0_0.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		form0_0.dataGridView_0.Size = new Size(229, 99);
		form0_0.dataGridView_0.TabIndex = 5;
		form0_0.dataGridView_0.RowsAdded += form0_0.method_8;
		form0_0.dataGridView_0.RowsRemoved += form0_0.method_9;
		form0_0.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		form0_0.dataGridViewTextBoxColumn_0.HeaderText = EncodedStringTable.smethod_0(394);
		form0_0.dataGridViewTextBoxColumn_0.Name = EncodedStringTable.smethod_0(11651);
		form0_0.dataGridViewTextBoxColumn_0.ReadOnly = true;
		form0_0.dataGridViewTextBoxColumn_0.Width = 19;
		form0_0.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		form0_0.dataGridViewTextBoxColumn_1.HeaderText = EncodedStringTable.smethod_0(11668);
		form0_0.dataGridViewTextBoxColumn_1.Name = EncodedStringTable.smethod_0(11677);
		form0_0.dataGridViewTextBoxColumn_1.ReadOnly = true;
		form0_0.dataGridViewTextBoxColumn_1.Width = 55;
		form0_0.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		form0_0.dataGridViewTextBoxColumn_2.HeaderText = EncodedStringTable.smethod_0(11694);
		form0_0.dataGridViewTextBoxColumn_2.Name = EncodedStringTable.smethod_0(11703);
		form0_0.dataGridViewTextBoxColumn_2.ReadOnly = true;
		form0_0.label_2.AutoSize = true;
		form0_0.label_2.Location = new Point(7, 108);
		form0_0.label_2.Name = EncodedStringTable.smethod_0(11720);
		form0_0.label_2.Size = new Size(126, 13);
		form0_0.label_2.TabIndex = 4;
		form0_0.label_2.Text = EncodedStringTable.smethod_0(11741);
		form0_0.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		form0_0.comboBox_1.FormattingEnabled = true;
		form0_0.comboBox_1.Location = new Point(10, 80);
		form0_0.comboBox_1.Name = EncodedStringTable.smethod_0(11770);
		form0_0.comboBox_1.Size = new Size(229, 21);
		form0_0.comboBox_1.TabIndex = 3;
		form0_0.comboBox_1.SelectedIndexChanged += form0_0.method_6;
		form0_0.label_1.AutoSize = true;
		form0_0.label_1.Location = new Point(7, 64);
		form0_0.label_1.Name = EncodedStringTable.smethod_0(11799);
		form0_0.label_1.Size = new Size(109, 13);
		form0_0.label_1.TabIndex = 2;
		form0_0.label_1.Text = EncodedStringTable.smethod_0(11832);
		form0_0.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		form0_0.comboBox_0.FormattingEnabled = true;
		form0_0.comboBox_0.Location = new Point(10, 37);
		form0_0.comboBox_0.Name = EncodedStringTable.smethod_0(11861);
		form0_0.comboBox_0.Size = new Size(229, 21);
		form0_0.comboBox_0.TabIndex = 1;
		form0_0.comboBox_0.SelectedIndexChanged += form0_0.method_5;
		form0_0.label_0.AutoSize = true;
		form0_0.label_0.Location = new Point(7, 21);
		form0_0.label_0.Name = EncodedStringTable.smethod_0(11894);
		form0_0.label_0.Size = new Size(137, 13);
		form0_0.label_0.TabIndex = 0;
		form0_0.label_0.Text = EncodedStringTable.smethod_0(11923);
		form0_0.AutoScaleDimensions = new SizeF(6f, 13f);
		form0_0.AutoScaleMode = AutoScaleMode.Font;
		form0_0.ClientSize = new Size(270, 280);
		form0_0.Controls.Add(form0_0.groupBox_0);
		form0_0.Font = new Font(EncodedStringTable.smethod_0(11956), 8.25f);
		form0_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		form0_0.MaximizeBox = false;
		form0_0.MinimizeBox = false;
		form0_0.Name = EncodedStringTable.smethod_0(11969);
		form0_0.StartPosition = FormStartPosition.CenterParent;
		form0_0.Text = EncodedStringTable.smethod_0(12006);
		form0_0.Load += form0_0.method_4;
		form0_0.groupBox_0.ResumeLayout(false);
		form0_0.groupBox_0.PerformLayout();
		((ISupportInitialize)form0_0.dataGridView_0).EndInit();
		form0_0.ResumeLayout(false);
	}

	internal static void smethod_29(DependencyInstallerForm form3_0, string string_0, string string_1, string string_2)
	{
		form3_0.string_0 = string_0;
		form3_0.string_1 = string_1;
		form3_0.string_2 = string_2;
		form3_0.bool_0 = true;
	}

	internal static void smethod_50(DependencyInstallerForm form3_0, string string_0, string string_1)
	{
		form3_0.string_0 = string_0;
		form3_0.string_1 = string_1;
		form3_0.bool_0 = false;
	}

	internal static Bitmap smethod_100(Icon icon_0)
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

	internal static void smethod_114(DependencyInstallerForm form3_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DependencyInstallerForm));
		form3_0.label_0 = new System.Windows.Forms.Label();
		form3_0.progressBar_0 = new ProgressBar();
		form3_0.SuspendLayout();
		form3_0.label_0.AutoSize = true;
		form3_0.label_0.Font = new Font(EncodedStringTable.smethod_0(11956), 8.75f);
		form3_0.label_0.Location = new Point(9, 9);
		form3_0.label_0.Name = EncodedStringTable.smethod_0(12983);
		form3_0.label_0.Size = new Size(170, 15);
		form3_0.label_0.TabIndex = 0;
		form3_0.label_0.Text = EncodedStringTable.smethod_0(13000);
		form3_0.progressBar_0.Location = new Point(12, 29);
		form3_0.progressBar_0.Name = EncodedStringTable.smethod_0(13041);
		form3_0.progressBar_0.Size = new Size(448, 23);
		form3_0.progressBar_0.TabIndex = 1;
		form3_0.AutoScaleDimensions = new SizeF(96f, 96f);
		form3_0.AutoScaleMode = AutoScaleMode.Dpi;
		form3_0.ClientSize = new Size(472, 64);
		form3_0.Controls.Add(form3_0.progressBar_0);
		form3_0.Controls.Add(form3_0.label_0);
		form3_0.Font = new Font(EncodedStringTable.smethod_0(11956), 8.25f);
		form3_0.FormBorderStyle = FormBorderStyle.FixedSingle;
		form3_0.Icon = (Icon)componentResourceManager.GetObject(EncodedStringTable.smethod_0(13062));
		form3_0.MaximizeBox = false;
		form3_0.MinimizeBox = false;
		form3_0.Name = EncodedStringTable.smethod_0(13079);
		form3_0.Text = EncodedStringTable.smethod_0(13108);
		form3_0.FormClosing += form3_0.method_1;
		form3_0.Load += form3_0.method_0;
		form3_0.ResumeLayout(false);
		form3_0.PerformLayout();
	}

	internal static bool smethod_139(ref string string_0, [Out] ModuleOptionsForm form0_0, string string_1)
	{
		if (string_1.StartsWith(EncodedStringTable.smethod_0(2072)) || string_1.StartsWith(EncodedStringTable.smethod_0(13195)))
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
				smethod_345(message, exception, bool_0: true),
				UiText.Get("App.Title"),
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation);
		});
	}

	internal static void smethod_177(string string_0, MainForm mainForm, string string_1)
	{
		MessageBox.Show(mainForm, UiText.Format("Message.Dependency.UnsupportedXp", string_1, string_0), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	internal static TabControlWindow smethod_204(TabControl tabControl_0)
	{
		return new TabControlWindow(tabControl_0);
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

	internal static void smethod_237(AdvancedScrambleSettingsForm gform1_0)
	{
		bool enabled = gform1_0.checkBox_3.Checked;
		gform1_0.checkBox_9.Enabled = enabled;
		gform1_0.checkBox_7.Enabled = enabled;
		gform1_0.checkBox_6.Enabled = enabled;
	}

	internal static void smethod_294(SettingsForm gform2_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SettingsForm));
		gform2_0.groupBox_0 = new ModernCard();
		gform2_0.button_0 = new Button();
		gform2_0.comboBox_0 = new ComboBox();
		gform2_0.groupBox_1 = new ModernCard();
		gform2_0.numericUpDown_0 = new NumericUpDown();
		gform2_0.label_0 = new System.Windows.Forms.Label();
		gform2_0.numericUpDown_1 = new NumericUpDown();
		gform2_0.label_1 = new System.Windows.Forms.Label();
		gform2_0.checkBox_0 = new CheckBox();
		gform2_0.checkBox_1 = new CheckBox();
		gform2_0.checkBox_2 = new CheckBox();
		gform2_0.groupBox_2 = new ModernCard();
		gform2_0.button_1 = new Button();
		gform2_0.comboBox_1 = new ComboBox();
		gform2_0.groupBox_3 = new ModernCard();
		gform2_0.checkBox_3 = new CheckBox();
		gform2_0.checkBox_4 = new CheckBox();
		gform2_0.groupBox_4 = new ModernCard();
		gform2_0.label_2 = new System.Windows.Forms.Label();
		gform2_0.panel_0 = new Panel();
		gform2_0.panel_1 = new Panel();
		gform2_0.label_3 = new System.Windows.Forms.Label();
		gform2_0.label_4 = new System.Windows.Forms.Label();
		gform2_0.panel_2 = new Panel();
		gform2_0.button_2 = new Button();
		gform2_0.button_3 = new Button();
		gform2_0.groupBox_5 = new ModernCard();
		gform2_0.button_4 = new Button();
		gform2_0.button_5 = new Button();
		gform2_0.button_6 = new Button();
		gform2_0.colorDialog_0 = new ColorDialog();
		gform2_0.groupBox_0.SuspendLayout();
		gform2_0.groupBox_1.SuspendLayout();
		((ISupportInitialize)gform2_0.numericUpDown_0).BeginInit();
		((ISupportInitialize)gform2_0.numericUpDown_1).BeginInit();
		gform2_0.groupBox_2.SuspendLayout();
		gform2_0.groupBox_3.SuspendLayout();
		gform2_0.groupBox_4.SuspendLayout();
		gform2_0.groupBox_5.SuspendLayout();
		gform2_0.SuspendLayout();
		gform2_0.groupBox_0.Controls.Add(gform2_0.button_0);
		gform2_0.groupBox_0.Controls.Add(gform2_0.comboBox_0);
		gform2_0.groupBox_0.Location = new Point(12, 12);
		gform2_0.groupBox_0.Name = EncodedStringTable.smethod_0(17972);
		gform2_0.groupBox_0.Size = new Size(180, 84);
		gform2_0.groupBox_0.TabIndex = 0;
		gform2_0.groupBox_0.TabStop = false;
		gform2_0.groupBox_0.Text = EncodedStringTable.smethod_0(18005);
		gform2_0.button_0.Location = new Point(9, 48);
		gform2_0.button_0.Name = EncodedStringTable.smethod_0(18030);
		gform2_0.button_0.Size = new Size(162, 23);
		gform2_0.button_0.TabIndex = 1;
		gform2_0.button_0.Text = EncodedStringTable.smethod_0(18059);
		gform2_0.button_0.UseVisualStyleBackColor = true;
		gform2_0.button_0.Click += gform2_0.method_4;
		gform2_0.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		gform2_0.comboBox_0.FormattingEnabled = true;
		gform2_0.comboBox_0.Items.AddRange(new object[]
		{
			EncodedStringTable.smethod_0(18072),
			EncodedStringTable.smethod_0(18097),
			EncodedStringTable.smethod_0(18122),
			EncodedStringTable.smethod_0(18143),
			EncodedStringTable.smethod_0(18168)
		});
		gform2_0.comboBox_0.Location = new Point(9, 21);
		gform2_0.comboBox_0.Name = EncodedStringTable.smethod_0(18185);
		gform2_0.comboBox_0.Size = new Size(162, 21);
		gform2_0.comboBox_0.TabIndex = 0;
		gform2_0.groupBox_1.Controls.Add(gform2_0.numericUpDown_0);
		gform2_0.groupBox_1.Controls.Add(gform2_0.label_0);
		gform2_0.groupBox_1.Controls.Add(gform2_0.numericUpDown_1);
		gform2_0.groupBox_1.Controls.Add(gform2_0.label_1);
		gform2_0.groupBox_1.Controls.Add(gform2_0.checkBox_0);
		gform2_0.groupBox_1.Controls.Add(gform2_0.checkBox_1);
		gform2_0.groupBox_1.Controls.Add(gform2_0.checkBox_2);
		gform2_0.groupBox_1.Location = new Point(12, 102);
		gform2_0.groupBox_1.Name = EncodedStringTable.smethod_0(18218);
		gform2_0.groupBox_1.Size = new Size(180, 149);
		gform2_0.groupBox_1.TabIndex = 1;
		gform2_0.groupBox_1.TabStop = false;
		gform2_0.groupBox_1.Text = EncodedStringTable.smethod_0(18251);
		NumericUpDown numericUpDown_ = gform2_0.numericUpDown_0;
		int[] array = new int[4];
		array[0] = 100;
		numericUpDown_.Increment = new decimal(array);
		gform2_0.numericUpDown_0.Location = new Point(98, 115);
		NumericUpDown numericUpDown_2 = gform2_0.numericUpDown_0;
		int[] array2 = new int[4];
		array2[0] = 30000;
		numericUpDown_2.Maximum = new decimal(array2);
		gform2_0.numericUpDown_0.Name = EncodedStringTable.smethod_0(18276);
		gform2_0.numericUpDown_0.Size = new Size(73, 22);
		gform2_0.numericUpDown_0.TabIndex = 6;
		gform2_0.label_0.AutoSize = true;
		gform2_0.label_0.Location = new Point(6, 117);
		gform2_0.label_0.Name = EncodedStringTable.smethod_0(18313);
		gform2_0.label_0.Size = new Size(86, 13);
		gform2_0.label_0.TabIndex = 5;
		gform2_0.label_0.Text = EncodedStringTable.smethod_0(18338);
		NumericUpDown numericUpDown_3 = gform2_0.numericUpDown_1;
		int[] array3 = new int[4];
		array3[0] = 100;
		numericUpDown_3.Increment = new decimal(array3);
		gform2_0.numericUpDown_1.Location = new Point(98, 90);
		NumericUpDown numericUpDown_4 = gform2_0.numericUpDown_1;
		int[] array4 = new int[4];
		array4[0] = 30000;
		numericUpDown_4.Maximum = new decimal(array4);
		gform2_0.numericUpDown_1.Name = EncodedStringTable.smethod_0(18359);
		gform2_0.numericUpDown_1.Size = new Size(73, 22);
		gform2_0.numericUpDown_1.TabIndex = 4;
		gform2_0.label_1.AutoSize = true;
		gform2_0.label_1.Location = new Point(6, 92);
		gform2_0.label_1.Name = EncodedStringTable.smethod_0(18392);
		gform2_0.label_1.Size = new Size(68, 13);
		gform2_0.label_1.TabIndex = 3;
		gform2_0.label_1.Text = EncodedStringTable.smethod_0(18417);
		gform2_0.checkBox_0.AutoSize = true;
		gform2_0.checkBox_0.Location = new Point(9, 67);
		gform2_0.checkBox_0.Name = EncodedStringTable.smethod_0(18438);
		gform2_0.checkBox_0.Size = new Size(93, 17);
		gform2_0.checkBox_0.TabIndex = 2;
		gform2_0.checkBox_0.Text = EncodedStringTable.smethod_0(18467);
		gform2_0.checkBox_0.UseVisualStyleBackColor = true;
		gform2_0.checkBox_1.AutoSize = true;
		gform2_0.checkBox_1.Location = new Point(9, 44);
		gform2_0.checkBox_1.Name = EncodedStringTable.smethod_0(18488);
		gform2_0.checkBox_1.Size = new Size(102, 17);
		gform2_0.checkBox_1.TabIndex = 1;
		gform2_0.checkBox_1.Text = EncodedStringTable.smethod_0(18517);
		gform2_0.checkBox_1.UseVisualStyleBackColor = true;
		gform2_0.checkBox_2.AutoSize = true;
		gform2_0.checkBox_2.Location = new Point(9, 21);
		gform2_0.checkBox_2.Name = EncodedStringTable.smethod_0(18538);
		gform2_0.checkBox_2.Size = new Size(82, 17);
		gform2_0.checkBox_2.TabIndex = 0;
		gform2_0.checkBox_2.Text = EncodedStringTable.smethod_0(18563);
		gform2_0.checkBox_2.UseVisualStyleBackColor = true;
		gform2_0.checkBox_2.CheckedChanged += gform2_0.method_2;
		gform2_0.groupBox_2.Controls.Add(gform2_0.button_1);
		gform2_0.groupBox_2.Controls.Add(gform2_0.comboBox_1);
		gform2_0.groupBox_2.Location = new Point(203, 12);
		gform2_0.groupBox_2.Name = EncodedStringTable.smethod_0(18580);
		gform2_0.groupBox_2.Size = new Size(180, 84);
		gform2_0.groupBox_2.TabIndex = 2;
		gform2_0.groupBox_2.TabStop = false;
		gform2_0.groupBox_2.Text = EncodedStringTable.smethod_0(18605);
		gform2_0.button_1.Location = new Point(9, 48);
		gform2_0.button_1.Name = EncodedStringTable.smethod_0(18634);
		gform2_0.button_1.Size = new Size(162, 23);
		gform2_0.button_1.TabIndex = 3;
		gform2_0.button_1.Text = EncodedStringTable.smethod_0(18059);
		gform2_0.button_1.UseVisualStyleBackColor = true;
		gform2_0.button_1.Click += gform2_0.method_3;
		gform2_0.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		gform2_0.comboBox_1.FormattingEnabled = true;
		gform2_0.comboBox_1.Items.AddRange(new object[]
		{
			EncodedStringTable.smethod_0(18671),
			EncodedStringTable.smethod_0(18680),
			EncodedStringTable.smethod_0(18689),
			EncodedStringTable.smethod_0(18702),
			EncodedStringTable.smethod_0(18715)
		});
		gform2_0.comboBox_1.Location = new Point(9, 21);
		gform2_0.comboBox_1.Name = EncodedStringTable.smethod_0(18724);
		gform2_0.comboBox_1.Size = new Size(162, 21);
		gform2_0.comboBox_1.TabIndex = 3;
		gform2_0.comboBox_1.SelectedIndexChanged += gform2_0.method_6;
		gform2_0.groupBox_3.Controls.Add(gform2_0.checkBox_3);
		gform2_0.groupBox_3.Controls.Add(gform2_0.checkBox_4);
		gform2_0.groupBox_3.Location = new Point(12, 257);
		gform2_0.groupBox_3.Name = EncodedStringTable.smethod_0(18757);
		gform2_0.groupBox_3.Size = new Size(180, 48);
		gform2_0.groupBox_3.TabIndex = 3;
		gform2_0.groupBox_3.TabStop = false;
		gform2_0.groupBox_3.Text = EncodedStringTable.smethod_0(18782);
		gform2_0.checkBox_3.AutoSize = true;
		gform2_0.checkBox_3.Location = new Point(83, 21);
		gform2_0.checkBox_3.Name = EncodedStringTable.smethod_0(18811);
		gform2_0.checkBox_3.Size = new Size(93, 17);
		gform2_0.checkBox_3.TabIndex = 1;
		gform2_0.checkBox_3.Text = EncodedStringTable.smethod_0(18836);
		gform2_0.checkBox_3.UseVisualStyleBackColor = true;
		gform2_0.checkBox_4.AutoSize = true;
		gform2_0.checkBox_4.Location = new Point(9, 21);
		gform2_0.checkBox_4.Name = EncodedStringTable.smethod_0(18853);
		gform2_0.checkBox_4.Size = new Size(68, 17);
		gform2_0.checkBox_4.TabIndex = 0;
		gform2_0.checkBox_4.Text = EncodedStringTable.smethod_0(18874);
		gform2_0.checkBox_4.UseVisualStyleBackColor = true;
		gform2_0.groupBox_4.Controls.Add(gform2_0.label_2);
		gform2_0.groupBox_4.Controls.Add(gform2_0.panel_0);
		gform2_0.groupBox_4.Controls.Add(gform2_0.panel_1);
		gform2_0.groupBox_4.Controls.Add(gform2_0.label_3);
		gform2_0.groupBox_4.Controls.Add(gform2_0.label_4);
		gform2_0.groupBox_4.Controls.Add(gform2_0.panel_2);
		gform2_0.groupBox_4.Location = new Point(202, 102);
		gform2_0.groupBox_4.Name = EncodedStringTable.smethod_0(18887);
		gform2_0.groupBox_4.Size = new Size(181, 102);
		gform2_0.groupBox_4.TabIndex = 4;
		gform2_0.groupBox_4.TabStop = false;
		gform2_0.groupBox_4.Text = EncodedStringTable.smethod_0(18916);
		gform2_0.label_2.AutoSize = true;
		gform2_0.label_2.Location = new Point(7, 71);
		gform2_0.label_2.Name = EncodedStringTable.smethod_0(18937);
		gform2_0.label_2.Size = new Size(120, 13);
		gform2_0.label_2.TabIndex = 5;
		gform2_0.label_2.Text = EncodedStringTable.smethod_0(18966);
		gform2_0.panel_0.BorderStyle = BorderStyle.FixedSingle;
		gform2_0.panel_0.Cursor = Cursors.Hand;
		gform2_0.panel_0.Location = new Point(152, 67);
		gform2_0.panel_0.Name = EncodedStringTable.smethod_0(18995);
		gform2_0.panel_0.Size = new Size(20, 20);
		gform2_0.panel_0.TabIndex = 4;
		gform2_0.panel_0.Click += gform2_0.method_15;
		gform2_0.panel_1.BorderStyle = BorderStyle.FixedSingle;
		gform2_0.panel_1.Cursor = Cursors.Hand;
		gform2_0.panel_1.Location = new Point(152, 44);
		gform2_0.panel_1.Name = EncodedStringTable.smethod_0(19024);
		gform2_0.panel_1.Size = new Size(20, 20);
		gform2_0.panel_1.TabIndex = 3;
		gform2_0.panel_1.Click += gform2_0.method_14;
		gform2_0.label_3.AutoSize = true;
		gform2_0.label_3.Location = new Point(7, 48);
		gform2_0.label_3.Name = EncodedStringTable.smethod_0(19053);
		gform2_0.label_3.Size = new Size(120, 13);
		gform2_0.label_3.TabIndex = 2;
		gform2_0.label_3.Text = EncodedStringTable.smethod_0(19082);
		gform2_0.label_4.AutoSize = true;
		gform2_0.label_4.Location = new Point(7, 25);
		gform2_0.label_4.Name = EncodedStringTable.smethod_0(19111);
		gform2_0.label_4.Size = new Size(61, 13);
		gform2_0.label_4.TabIndex = 1;
		gform2_0.label_4.Text = EncodedStringTable.smethod_0(19132);
		gform2_0.panel_2.BorderStyle = BorderStyle.FixedSingle;
		gform2_0.panel_2.Cursor = Cursors.Hand;
		gform2_0.panel_2.Location = new Point(152, 21);
		gform2_0.panel_2.Name = EncodedStringTable.smethod_0(19149);
		gform2_0.panel_2.Size = new Size(20, 20);
		gform2_0.panel_2.TabIndex = 0;
		gform2_0.panel_2.Click += gform2_0.method_13;
		gform2_0.button_2.Location = new Point(12, 315);
		gform2_0.button_2.Name = EncodedStringTable.smethod_0(19166);
		gform2_0.button_2.Size = new Size(110, 23);
		gform2_0.button_2.TabIndex = 5;
		gform2_0.button_2.Text = EncodedStringTable.smethod_0(19183);
		gform2_0.button_2.UseVisualStyleBackColor = true;
		gform2_0.button_2.Click += gform2_0.method_7;
		gform2_0.button_3.Location = new Point(273, 315);
		gform2_0.button_3.Name = EncodedStringTable.smethod_0(19192);
		gform2_0.button_3.Size = new Size(110, 23);
		gform2_0.button_3.TabIndex = 7;
		gform2_0.button_3.Text = EncodedStringTable.smethod_0(19205);
		gform2_0.button_3.UseVisualStyleBackColor = true;
		gform2_0.button_3.Click += gform2_0.method_8;
		gform2_0.groupBox_5.Controls.Add(gform2_0.button_4);
		gform2_0.groupBox_5.Controls.Add(gform2_0.button_5);
		gform2_0.groupBox_5.Controls.Add(gform2_0.button_6);
		gform2_0.groupBox_5.Location = new Point(203, 210);
		gform2_0.groupBox_5.Name = EncodedStringTable.smethod_0(19210);
		gform2_0.groupBox_5.Size = new Size(180, 95);
		gform2_0.groupBox_5.TabIndex = 8;
		gform2_0.groupBox_5.TabStop = false;
		gform2_0.groupBox_5.Text = EncodedStringTable.smethod_0(19231);
		gform2_0.button_4.Location = new Point(9, 65);
		gform2_0.button_4.Name = EncodedStringTable.smethod_0(19240);
		gform2_0.button_4.Size = new Size(162, 23);
		gform2_0.button_4.TabIndex = 2;
		gform2_0.button_4.Text = EncodedStringTable.smethod_0(19273);
		gform2_0.button_4.UseVisualStyleBackColor = true;
		gform2_0.button_4.Click += gform2_0.method_12;
		gform2_0.button_5.Location = new Point(9, 41);
		gform2_0.button_5.Name = EncodedStringTable.smethod_0(19302);
		gform2_0.button_5.Size = new Size(162, 23);
		gform2_0.button_5.TabIndex = 1;
		gform2_0.button_5.Text = EncodedStringTable.smethod_0(19327);
		gform2_0.button_5.UseVisualStyleBackColor = true;
		gform2_0.button_5.Click += gform2_0.method_11;
		gform2_0.button_6.Location = new Point(9, 17);
		gform2_0.button_6.Name = EncodedStringTable.smethod_0(19344);
		gform2_0.button_6.Size = new Size(162, 23);
		gform2_0.button_6.TabIndex = 0;
		gform2_0.button_6.Text = EncodedStringTable.smethod_0(19385);
		gform2_0.button_6.UseVisualStyleBackColor = true;
		gform2_0.button_6.Click += gform2_0.method_10;
		gform2_0.AutoScaleDimensions = new SizeF(96f, 96f);
		gform2_0.AutoScaleMode = AutoScaleMode.Dpi;
		gform2_0.ClientSize = new Size(396, 347);
		gform2_0.Controls.Add(gform2_0.groupBox_5);
		gform2_0.Controls.Add(gform2_0.button_3);
		gform2_0.Controls.Add(gform2_0.button_2);
		gform2_0.Controls.Add(gform2_0.groupBox_4);
		gform2_0.Controls.Add(gform2_0.groupBox_3);
		gform2_0.Controls.Add(gform2_0.groupBox_2);
		gform2_0.Controls.Add(gform2_0.groupBox_1);
		gform2_0.Controls.Add(gform2_0.groupBox_0);
		gform2_0.Font = new Font(EncodedStringTable.smethod_0(11956), 8.25f);
		gform2_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		gform2_0.Icon = (Icon)componentResourceManager.GetObject(EncodedStringTable.smethod_0(13062));
		gform2_0.MaximizeBox = false;
		gform2_0.MinimizeBox = false;
		gform2_0.Name = EncodedStringTable.smethod_0(19418);
		gform2_0.Text = EncodedStringTable.smethod_0(19435);
		gform2_0.FormClosing += gform2_0.method_9;
		gform2_0.groupBox_0.ResumeLayout(false);
		gform2_0.groupBox_1.ResumeLayout(false);
		gform2_0.groupBox_1.PerformLayout();
		((ISupportInitialize)gform2_0.numericUpDown_0).EndInit();
		((ISupportInitialize)gform2_0.numericUpDown_1).EndInit();
		gform2_0.groupBox_2.ResumeLayout(false);
		gform2_0.groupBox_3.ResumeLayout(false);
		gform2_0.groupBox_3.PerformLayout();
		gform2_0.groupBox_4.ResumeLayout(false);
		gform2_0.groupBox_4.PerformLayout();
		gform2_0.groupBox_5.ResumeLayout(false);
		gform2_0.ResumeLayout(false);
	}

	internal static bool smethod_337(MainForm mainForm, string string_0, string string_1, string string_2, bool bool_0, string string_3)
	{
		if (bool_0)
		{
			if (MessageBox.Show(mainForm, string.Concat(new string[]
			{
				EncodedStringTable.smethod_0(13250),
				string_0,
				EncodedStringTable.smethod_0(13291),
				string_1,
				EncodedStringTable.smethod_0(23898),
				string_2,
				EncodedStringTable.smethod_0(24068),
				string_3,
				EncodedStringTable.smethod_0(24129),
				string_3,
				EncodedStringTable.smethod_0(24174)
			}), EncodedStringTable.smethod_0(599), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
			{
				return false;
			}
		}
		else if (MessageBox.Show(mainForm, string.Concat(new string[]
		{
			EncodedStringTable.smethod_0(13250),
			string_0,
			EncodedStringTable.smethod_0(13291),
			string_1,
			EncodedStringTable.smethod_0(24183),
			string_3,
			EncodedStringTable.smethod_0(24341)
		}), EncodedStringTable.smethod_0(599), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
		{
			return false;
		}
		return true;
	}

	internal static bool smethod_342(ModuleOptionsForm form0_0, string string_0, ExportParameterType enum5_0, bool bool_0)
	{
		string numericText = string_0;
		bool hexadecimal = smethod_139(ref numericText, form0_0, numericText);
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
			if (form0_0.method_0().Parameters == null)
			{
				form0_0.method_0().Parameters = new List<ExportParameter>();
			}

			form0_0.method_0().Parameters.Add(new ExportParameter
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

	internal static void smethod_405(string string_0, MainForm mainForm, string string_1, string string_2, string string_3)
	{
		DialogResult dialogResult = MessageBox.Show(mainForm, string.Concat(new string[]
		{
			EncodedStringTable.smethod_0(13250),
			string_0,
			EncodedStringTable.smethod_0(13291),
			string_3,
			EncodedStringTable.smethod_0(25673)
		}), EncodedStringTable.smethod_0(599), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
		if (dialogResult != DialogResult.Yes)
		{
			if (dialogResult == DialogResult.No)
			{
				MessageBox.Show(mainForm, EncodedStringTable.smethod_0(26205) + string_1 + EncodedStringTable.smethod_0(26318), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Process.Start(string_2);
			}
			return;
		}
		if (RecoveredRuntime.smethod_272())
		{
			DependencyInstallerForm form = new DependencyInstallerForm();
			RecoveredRuntime.smethod_50(form, string_2, string_1);
			form.ShowDialog();
			return;
		}
		MessageBox.Show(mainForm, EncodedStringTable.smethod_0(26027), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	internal static void smethod_406(ProcessInspectorForm form4_0)
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
		form4_0.button_1.Name = EncodedStringTable.smethod_0(26363);
		form4_0.button_1.Size = new Size(97, 22);
		form4_0.button_1.TabIndex = 14;
		form4_0.button_1.Text = EncodedStringTable.smethod_0(26380);
		form4_0.button_1.UseVisualStyleBackColor = true;
		form4_0.button_1.Click += form4_0.method_9;
		form4_0.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		form4_0.button_0.Location = new Point(199, 442);
		form4_0.button_0.Name = EncodedStringTable.smethod_0(26401);
		form4_0.button_0.Size = new Size(97, 22);
		form4_0.button_0.TabIndex = 13;
		form4_0.button_0.Text = EncodedStringTable.smethod_0(26418);
		form4_0.button_0.UseVisualStyleBackColor = true;
		form4_0.button_0.Click += form4_0.method_4;
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
		form4_0.dataGridView_0.Name = EncodedStringTable.smethod_0(26435);
		form4_0.dataGridView_0.ReadOnly = true;
		form4_0.dataGridView_0.RowHeadersVisible = false;
		form4_0.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		form4_0.dataGridView_0.Size = new Size(379, 209);
		form4_0.dataGridView_0.TabIndex = 11;
		form4_0.dataGridView_0.SelectionChanged += form4_0.method_6;
		form4_0.dataGridView_0.SortCompare += form4_0.method_7;
		form4_0.dataGridViewTextBoxColumn_0.HeaderText = EncodedStringTable.smethod_0(26464);
		form4_0.dataGridViewTextBoxColumn_0.Name = EncodedStringTable.smethod_0(26481);
		form4_0.dataGridViewTextBoxColumn_0.ReadOnly = true;
		form4_0.dataGridViewTextBoxColumn_0.Width = 150;
		form4_0.dataGridViewTextBoxColumn_1.HeaderText = EncodedStringTable.smethod_0(26506);
		form4_0.dataGridViewTextBoxColumn_1.Name = EncodedStringTable.smethod_0(26523);
		form4_0.dataGridViewTextBoxColumn_1.ReadOnly = true;
		form4_0.dataGridViewTextBoxColumn_1.Width = 120;
		form4_0.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		form4_0.dataGridViewTextBoxColumn_2.HeaderText = EncodedStringTable.smethod_0(26548);
		form4_0.dataGridViewTextBoxColumn_2.Name = EncodedStringTable.smethod_0(26565);
		form4_0.dataGridViewTextBoxColumn_2.ReadOnly = true;
		form4_0.groupBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		form4_0.groupBox_0.Controls.Add(form4_0.label_0);
		form4_0.groupBox_0.Controls.Add(form4_0.pictureBox_0);
		form4_0.groupBox_0.Location = new Point(12, 12);
		form4_0.groupBox_0.Name = EncodedStringTable.smethod_0(26590);
		form4_0.groupBox_0.Size = new Size(387, 154);
		form4_0.groupBox_0.TabIndex = 10;
		form4_0.groupBox_0.TabStop = false;
		form4_0.groupBox_0.Text = EncodedStringTable.smethod_0(26611);
		form4_0.label_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		form4_0.label_0.Location = new Point(47, 21);
		form4_0.label_0.Name = EncodedStringTable.smethod_0(26624);
		form4_0.label_0.Size = new Size(334, 123);
		form4_0.label_0.TabIndex = 5;
		form4_0.label_0.Text = EncodedStringTable.smethod_0(26653);
		form4_0.pictureBox_0.BackColor = Color.Transparent;
		form4_0.pictureBox_0.Location = new Point(9, 21);
		form4_0.pictureBox_0.Name = EncodedStringTable.smethod_0(26670);
		form4_0.pictureBox_0.Size = new Size(32, 32);
		form4_0.pictureBox_0.TabIndex = 4;
		form4_0.pictureBox_0.TabStop = false;
		form4_0.timer_0.Interval = 250;
		form4_0.timer_0.Tick += form4_0.method_5;
		form4_0.button_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		form4_0.button_2.Location = new Point(302, 442);
		form4_0.button_2.Name = EncodedStringTable.smethod_0(23701);
		form4_0.button_2.Size = new Size(97, 22);
		form4_0.button_2.TabIndex = 12;
		form4_0.button_2.Text = EncodedStringTable.smethod_0(23718);
		form4_0.button_2.UseVisualStyleBackColor = true;
		form4_0.button_2.Click += form4_0.method_3;
		form4_0.tabControl_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		form4_0.tabControl_0.Controls.Add(form4_0.tabPage_0);
		form4_0.tabControl_0.Controls.Add(form4_0.tabPage_1);
		form4_0.tabControl_0.Location = new Point(12, 172);
		form4_0.tabControl_0.Name = EncodedStringTable.smethod_0(26695);
		form4_0.tabControl_0.SelectedIndex = 0;
		form4_0.tabControl_0.Size = new Size(387, 266);
		form4_0.tabControl_0.TabIndex = 15;
		form4_0.tabPage_0.Controls.Add(form4_0.dataGridView_0);
		form4_0.tabPage_0.Controls.Add(form4_0.button_1);
		form4_0.tabPage_0.Location = new Point(4, 22);
		form4_0.tabPage_0.Name = EncodedStringTable.smethod_0(26716);
		form4_0.tabPage_0.Size = new Size(379, 240);
		form4_0.tabPage_0.TabIndex = 0;
		form4_0.tabPage_0.Text = EncodedStringTable.smethod_0(26737);
		form4_0.tabPage_0.UseVisualStyleBackColor = true;
		form4_0.tabPage_1.Controls.Add(form4_0.button_4);
		form4_0.tabPage_1.Controls.Add(form4_0.button_3);
		form4_0.tabPage_1.Controls.Add(form4_0.dataGridView_1);
		form4_0.tabPage_1.Location = new Point(4, 22);
		form4_0.tabPage_1.Name = EncodedStringTable.smethod_0(26750);
		form4_0.tabPage_1.Size = new Size(379, 240);
		form4_0.tabPage_1.TabIndex = 1;
		form4_0.tabPage_1.Text = EncodedStringTable.smethod_0(26771);
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
		form4_0.dataGridView_1.Name = EncodedStringTable.smethod_0(26784);
		form4_0.dataGridView_1.ReadOnly = true;
		form4_0.dataGridView_1.RowHeadersVisible = false;
		form4_0.dataGridView_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		form4_0.dataGridView_1.Size = new Size(379, 209);
		form4_0.dataGridView_1.TabIndex = 12;
		form4_0.dataGridView_1.SelectionChanged += form4_0.method_10;
		form4_0.dataGridView_1.SortCompare += form4_0.method_7;
		form4_0.dataGridViewTextBoxColumn_3.HeaderText = EncodedStringTable.smethod_0(26813);
		form4_0.dataGridViewTextBoxColumn_3.Name = EncodedStringTable.smethod_0(26826);
		form4_0.dataGridViewTextBoxColumn_3.ReadOnly = true;
		form4_0.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		form4_0.dataGridViewTextBoxColumn_4.HeaderText = EncodedStringTable.smethod_0(26847);
		form4_0.dataGridViewTextBoxColumn_4.Name = EncodedStringTable.smethod_0(26868);
		form4_0.dataGridViewTextBoxColumn_4.ReadOnly = true;
		form4_0.dataGridViewTextBoxColumn_5.HeaderText = EncodedStringTable.smethod_0(26901);
		form4_0.dataGridViewTextBoxColumn_5.Name = EncodedStringTable.smethod_0(26914);
		form4_0.dataGridViewTextBoxColumn_5.ReadOnly = true;
		form4_0.button_3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		form4_0.button_3.Enabled = false;
		form4_0.button_3.Location = new Point(279, 215);
		form4_0.button_3.Name = EncodedStringTable.smethod_0(26939);
		form4_0.button_3.Size = new Size(97, 22);
		form4_0.button_3.TabIndex = 15;
		form4_0.button_3.Text = EncodedStringTable.smethod_0(12632);
		form4_0.button_3.UseVisualStyleBackColor = true;
		form4_0.button_3.Click += form4_0.method_11;
		form4_0.button_4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		form4_0.button_4.Enabled = false;
		form4_0.button_4.Location = new Point(176, 215);
		form4_0.button_4.Name = EncodedStringTable.smethod_0(26968);
		form4_0.button_4.Size = new Size(97, 22);
		form4_0.button_4.TabIndex = 16;
		form4_0.button_4.Text = EncodedStringTable.smethod_0(26993);
		form4_0.button_4.UseVisualStyleBackColor = true;
		form4_0.button_4.Click += form4_0.method_12;
		form4_0.AutoScaleDimensions = new SizeF(96f, 96f);
		form4_0.AutoScaleMode = AutoScaleMode.Dpi;
		form4_0.ClientSize = new Size(410, 469);
		form4_0.Controls.Add(form4_0.tabControl_0);
		form4_0.Controls.Add(form4_0.button_0);
		form4_0.Controls.Add(form4_0.button_2);
		form4_0.Controls.Add(form4_0.groupBox_0);
		form4_0.Font = new Font(EncodedStringTable.smethod_0(11956), 8.25f);
		form4_0.FormBorderStyle = FormBorderStyle.SizableToolWindow;
		form4_0.Icon = (Icon)componentResourceManager.GetObject(EncodedStringTable.smethod_0(13062));
		form4_0.MaximizeBox = false;
		form4_0.MinimizeBox = false;
		form4_0.Name = EncodedStringTable.smethod_0(27002);
		form4_0.Text = EncodedStringTable.smethod_0(27023);
		form4_0.Load += form4_0.method_8;
		((ISupportInitialize)form4_0.dataGridView_0).EndInit();
		form4_0.groupBox_0.ResumeLayout(false);
		((ISupportInitialize)form4_0.pictureBox_0).EndInit();
		form4_0.tabControl_0.ResumeLayout(false);
		form4_0.tabPage_0.ResumeLayout(false);
		form4_0.tabPage_1.ResumeLayout(false);
		((ISupportInitialize)form4_0.dataGridView_1).EndInit();
		form4_0.ResumeLayout(false);
	}

	internal static void smethod_408()
	{
		string str;
		if (!RecoveredRuntime.smethod_193(out str))
		{
			return;
		}
		MessageBox.Show(EncodedStringTable.smethod_0(27052) + str + EncodedStringTable.smethod_0(27125), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	internal static void smethod_421(SettingsForm gform2_0)
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

	internal static void smethod_475(System.Windows.Forms.Timer timer_0)
	{
		timer_0.Stop();
	}

	internal static void smethod_476(Control control_0, bool bool_0)
	{
		control_0.Enabled = bool_0;
	}

	internal static DialogResult smethod_477(IWin32Window iwin32Window_0, string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		return MessageBox.Show(iwin32Window_0, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	internal static Icon smethod_480(IntPtr intptr_0)
	{
		return Icon.FromHandle(intptr_0);
	}

	internal static object smethod_481(Icon icon_0)
	{
		return icon_0.Clone();
	}

	internal static DataGridView smethod_494()
	{
		return new DataGridView();
	}

	internal static DataGridViewTextBoxColumn smethod_495()
	{
		return new DataGridViewTextBoxColumn();
	}

	internal static System.Windows.Forms.Label smethod_496()
	{
		return new System.Windows.Forms.Label();
	}

	internal static void smethod_497(Control control_0)
	{
		control_0.SuspendLayout();
	}

	internal static void smethod_499(Control control_0)
	{
		control_0.SuspendLayout();
	}

	internal static Control.ControlCollection smethod_500(Control control_0)
	{
		return control_0.Controls;
	}

	internal static void smethod_501(Control.ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	internal static DataGridViewRowCollection smethod_502(DataGridView dataGridView_0)
	{
		return dataGridView_0.Rows;
	}

	internal static void smethod_503(DataGridViewRowCollection dataGridViewRowCollection_0)
	{
		dataGridViewRowCollection_0.Clear();
	}

	internal static Bitmap smethod_504(int int_0, int int_1)
	{
		return new Bitmap(int_0, int_1);
	}

	internal static int smethod_506(DataGridViewRowCollection dataGridViewRowCollection_0, object[] object_0)
	{
		return dataGridViewRowCollection_0.Add(object_0);
	}

	internal static DataGridViewRow smethod_507(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return dataGridViewRowCollection_0[int_0];
	}

	internal static void smethod_508(DataGridViewBand dataGridViewBand_0, object object_0)
	{
		dataGridViewBand_0.Tag = object_0;
	}

	internal static int smethod_509(DataGridViewRowCollection dataGridViewRowCollection_0)
	{
		return dataGridViewRowCollection_0.Count;
	}

	internal static void smethod_510(DataGridViewBand dataGridViewBand_0, bool bool_0)
	{
		dataGridViewBand_0.Selected = bool_0;
	}

	internal static DialogResult smethod_529(Form form_0)
	{
		return form_0.ShowDialog();
	}

	internal static void smethod_547(Control control_0, string string_0)
	{
		control_0.Text = string_0;
	}

	internal static DataGridViewSelectedRowCollection smethod_552(DataGridView dataGridView_0)
	{
		return dataGridView_0.SelectedRows;
	}

	internal static DataGridViewRow smethod_553(DataGridViewSelectedRowCollection dataGridViewSelectedRowCollection_0, int int_0)
	{
		return dataGridViewSelectedRowCollection_0[int_0];
	}

	internal static object smethod_554(DataGridViewBand dataGridViewBand_0)
	{
		return dataGridViewBand_0.Tag;
	}

	internal static Bitmap smethod_557(Icon icon_0)
	{
		return icon_0.ToBitmap();
	}

	internal static Graphics smethod_558(Image image_0)
	{
		return Graphics.FromImage(image_0);
	}

	internal static int smethod_560(Image image_0)
	{
		return image_0.Width;
	}

	internal static int smethod_561(Image image_0)
	{
		return image_0.Height;
	}

	internal static void smethod_562(Graphics graphics_0, Image image_0, int int_0, int int_1, int int_2, int int_3)
	{
		graphics_0.DrawImage(image_0, int_0, int_1, int_2, int_3);
	}

	internal static void smethod_564(Control control_0, object object_0)
	{
		control_0.Tag = object_0;
	}

	internal static DataGridViewCellCollection smethod_568(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.Cells;
	}

	internal static DataGridViewCell smethod_569(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0[int_0];
	}

	internal static object smethod_570(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.Value;
	}

	internal static void smethod_571(DataGridViewCell dataGridViewCell_0, object object_0)
	{
		dataGridViewCell_0.Value = object_0;
	}

	internal static void smethod_574(Control control_0, bool bool_0)
	{
		control_0.AutoSize = bool_0;
	}

	internal static void smethod_576(Control control_0, Font font_0)
	{
		control_0.Font = font_0;
	}

	internal static object smethod_597(Control control_0, Delegate delegate_0)
	{
		return control_0.Invoke(delegate_0);
	}

	internal static IAsyncResult smethod_623(Control control_0, Delegate delegate_0)
	{
		return control_0.BeginInvoke(delegate_0);
	}

	internal static void smethod_641(ListControl listControl_0, int int_0)
	{
		listControl_0.SelectedIndex = int_0;
	}

	internal static void smethod_642(Control control_0, Color color_0)
	{
		control_0.BackColor = color_0;
	}

	internal static void smethod_655(Control control_0, Color color_0)
	{
		control_0.ForeColor = color_0;
	}

	internal static int smethod_677(ListControl listControl_0)
	{
		return listControl_0.SelectedIndex;
	}

	internal static Color smethod_678(Control control_0)
	{
		return control_0.BackColor;
	}

	internal static DataGridViewImageColumn smethod_680()
	{
		return new DataGridViewImageColumn();
	}

	internal static void smethod_681(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.AllowUserToAddRows = bool_0;
	}

	internal static void smethod_682(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.AllowUserToDeleteRows = bool_0;
	}

	internal static void smethod_683(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.AllowUserToResizeColumns = bool_0;
	}

	internal static void smethod_684(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.AllowUserToResizeRows = bool_0;
	}

	internal static void smethod_685(DataGridView dataGridView_0, Color color_0)
	{
		dataGridView_0.BackgroundColor = color_0;
	}

	internal static void smethod_686(DataGridView dataGridView_0, DataGridViewCellBorderStyle dataGridViewCellBorderStyle_0)
	{
		dataGridView_0.CellBorderStyle = dataGridViewCellBorderStyle_0;
	}

	internal static void smethod_687(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		dataGridView_0.ColumnHeadersHeightSizeMode = dataGridViewColumnHeadersHeightSizeMode_0;
	}

	internal static void smethod_688(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.ColumnHeadersVisible = bool_0;
	}

	internal static DataGridViewColumnCollection smethod_689(DataGridView dataGridView_0)
	{
		return dataGridView_0.Columns;
	}

	internal static void smethod_690(DataGridViewColumnCollection dataGridViewColumnCollection_0, DataGridViewColumn[] dataGridViewColumn_0)
	{
		dataGridViewColumnCollection_0.AddRange(dataGridViewColumn_0);
	}

	internal static void smethod_691(DataGridView dataGridView_0, DataGridViewEditMode dataGridViewEditMode_0)
	{
		dataGridView_0.EditMode = dataGridViewEditMode_0;
	}

	internal static void smethod_704(DataGridViewCell dataGridViewCell_0, string string_0)
	{
		dataGridViewCell_0.ToolTipText = string_0;
	}

	internal static void smethod_705(Form form_0)
	{
		form_0.Close();
	}

	internal static DialogResult smethod_706(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	internal static void smethod_707(System.Windows.Forms.Timer timer_0)
	{
		timer_0.Start();
	}

	internal static Image smethod_714(Control control_0)
	{
		return control_0.BackgroundImage;
	}

	internal static void smethod_715(Control control_0, Image image_0)
	{
		control_0.BackgroundImage = image_0;
	}

	internal static void smethod_716(Image image_0)
	{
		image_0.Dispose();
	}

	internal static void smethod_717(Control control_0)
	{
		control_0.ResetText();
	}

	internal static void smethod_719(Control control_0, Cursor cursor_0)
	{
		control_0.Cursor = cursor_0;
	}

	internal static string smethod_722(Control control_0)
	{
		return control_0.Text;
	}

	internal static DataGridViewCellStyle smethod_724()
	{
		return new DataGridViewCellStyle();
	}

	internal static System.Windows.Forms.Timer smethod_725(IContainer icontainer_0)
	{
		return new System.Windows.Forms.Timer(icontainer_0);
	}

	internal static DataGridViewCheckBoxColumn smethod_726()
	{
		return new DataGridViewCheckBoxColumn();
	}

	internal static DataGridViewButtonColumn smethod_727()
	{
		return new DataGridViewButtonColumn();
	}

	internal static TabControl smethod_733()
	{
		return new ModernTabControl();
	}

	internal static void smethod_735(Control control_0, AnchorStyles anchorStyles_0)
	{
		control_0.Anchor = anchorStyles_0;
	}
}
