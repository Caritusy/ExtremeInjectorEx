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
		while (true)
		{
			int num = -438807568;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1137245213)) % 72)
				{
				case 71u:
					form0_0.groupBox_0.TabStop = false;
					form0_0.groupBox_0.Text = UiText.Get("Module.ExportOptions");
					num = ((int)num2 * -10012300) ^ -993370950;
					continue;
				case 70u:
					form0_0.comboBox_1 = new ComboBox();
					num = (int)(num2 * 1576235532) ^ -94106030;
					continue;
				case 69u:
					form0_0.label_0.Size = new Size(137, 13);
					form0_0.label_0.TabIndex = 0;
					num = ((int)num2 * -616780528) ^ -1323735521;
					continue;
				case 68u:
					form0_0.label_0 = new System.Windows.Forms.Label();
					form0_0.groupBox_0.SuspendLayout();
					num = (int)((num2 * 684650846) ^ 0x4DEAE30);
					continue;
				case 67u:
					form0_0.button_0 = new Button();
					form0_0.textBox_0 = new TextBox();
					form0_0.comboBox_2 = new ComboBox();
					form0_0.dataGridView_0 = new DataGridView();
					form0_0.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
					form0_0.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
					num = ((int)num2 * -1532101053) ^ -222103568;
					continue;
				case 66u:
					form0_0.groupBox_0.Location = new Point(12, 12);
					form0_0.groupBox_0.Name = "exportGroupBox";
					num = ((int)num2 * -1427684341) ^ -1874370773;
					continue;
				case 65u:
					form0_0.dataGridView_0.Name = "paramDataGridView";
					form0_0.dataGridView_0.ReadOnly = true;
					num = (int)(num2 * 871137329) ^ -332823018;
					continue;
				case 64u:
					form0_0.comboBox_1.SelectedIndexChanged += form0_0.method_6;
					form0_0.label_1.AutoSize = true;
					num = (int)((num2 * 1515966208) ^ 0x4B59C109);
					continue;
				case 63u:
					form0_0.dataGridViewTextBoxColumn_1.ReadOnly = true;
					form0_0.dataGridViewTextBoxColumn_1.Width = 55;
					num = (int)((num2 * 1801586444) ^ 0x12E97ADD);
					continue;
				case 62u:
					form0_0.comboBox_0.SelectedIndexChanged += form0_0.method_5;
					form0_0.label_0.AutoSize = true;
					form0_0.label_0.Location = new Point(7, 21);
					form0_0.label_0.Name = "exportFunctionLabel";
					num = (int)((num2 * 2061103370) ^ 0x1468706A);
					continue;
				case 61u:
					form0_0.button_0.Location = new Point(188, 227);
					num = (int)(num2 * 783651630) ^ -1275901385;
					continue;
				case 60u:
					form0_0.dataGridView_0.AllowUserToResizeColumns = false;
					form0_0.dataGridView_0.AllowUserToResizeRows = false;
					form0_0.dataGridView_0.BackgroundColor = Color.White;
					num = ((int)num2 * -2047378690) ^ 0x7191F9D1;
					continue;
				case 59u:
					form0_0.button_0.Size = new Size(51, 23);
					form0_0.button_0.TabIndex = 8;
					form0_0.button_0.Text = UiText.Get("Module.Add");
					form0_0.button_0.UseVisualStyleBackColor = true;
					form0_0.button_0.Click += form0_0.method_7;
					num = ((int)num2 * -886628270) ^ 0x2441D5AE;
					continue;
				case 58u:
					form0_0.comboBox_2.Name = "paramTypeComboBox";
					form0_0.comboBox_2.Size = new Size(76, 21);
					num = ((int)num2 * -974930357) ^ 0x18ADF3B;
					continue;
				case 57u:
					form0_0.groupBox_0.Controls.Add(form0_0.button_0);
					num = ((int)num2 * -740489005) ^ 0x68C54E8E;
					continue;
				case 56u:
					form0_0.comboBox_1.TabIndex = 3;
					num = (int)((num2 * 421662214) ^ 0x23BBAEE3);
					continue;
				case 55u:
					form0_0.label_2 = new System.Windows.Forms.Label();
					num = (int)((num2 * 1831248463) ^ 0x3690F2E4);
					continue;
				case 54u:
					form0_0.comboBox_2.TabIndex = 6;
					form0_0.dataGridView_0.AllowUserToAddRows = false;
					num = ((int)num2 * -1495297976) ^ -1548197505;
					continue;
				case 53u:
					form0_0.dataGridViewTextBoxColumn_0.ReadOnly = true;
					num = ((int)num2 * -1165939021) ^ 0x3A369996;
					continue;
				case 52u:
					form0_0.StartPosition = FormStartPosition.CenterParent;
					form0_0.Text = UiText.Get("Module.Title");
					form0_0.Load += form0_0.method_4;
					num = (int)(num2 * 1908332636) ^ -730069252;
					continue;
				case 51u:
					form0_0.comboBox_0 = new ComboBox();
					num = (int)(num2 * 1420889978) ^ -1053864799;
					continue;
				case 50u:
					form0_0.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
					num = (int)(num2 * 19098558) ^ -115233384;
					continue;
				case 49u:
					form0_0.dataGridView_0.RowsAdded += form0_0.method_8;
					num = ((int)num2 * -1855281124) ^ 0x160E02F6;
					continue;
				case 48u:
					form0_0.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
					num = (int)((num2 * 1720243663) ^ 0x3A84E22E);
					continue;
				case 46u:
					form0_0.groupBox_0.Controls.Add(form0_0.textBox_0);
					form0_0.groupBox_0.Controls.Add(form0_0.comboBox_2);
					form0_0.groupBox_0.Controls.Add(form0_0.dataGridView_0);
					form0_0.groupBox_0.Controls.Add(form0_0.label_2);
					form0_0.groupBox_0.Controls.Add(form0_0.comboBox_1);
					num = ((int)num2 * -2035460303) ^ 0x364BA8C2;
					continue;
				case 45u:
					form0_0.label_2.Location = new Point(7, 108);
					form0_0.label_2.Name = "parametersLabel";
					form0_0.label_2.Size = new Size(126, 13);
					num = ((int)num2 * -481480834) ^ -1339679223;
					continue;
				case 44u:
					form0_0.dataGridView_0.RowHeadersVisible = false;
					form0_0.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					num = ((int)num2 * -654255515) ^ 0x51E646A4;
					continue;
				case 43u:
					form0_0.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
					form0_0.comboBox_1.FormattingEnabled = true;
					num = ((int)num2 * -1290899922) ^ -1601301643;
					continue;
				case 42u:
					form0_0.comboBox_2.Location = new Point(10, 229);
					num = ((int)num2 * -95386088) ^ -1434935943;
					continue;
				case 41u:
					form0_0.label_1.Size = new Size(109, 13);
					num = (int)((num2 * 1820041713) ^ 0x110050A9);
					continue;
				case 40u:
					form0_0.SuspendLayout();
					num = ((int)num2 * -495111633) ^ -1458954470;
					continue;
				case 39u:
					form0_0.dataGridViewTextBoxColumn_0.HeaderText = "";
					form0_0.dataGridViewTextBoxColumn_0.Name = "NumberColumn";
					num = ((int)num2 * -1381964607) ^ -850974727;
					continue;
				case 38u:
					form0_0.groupBox_0.Size = new Size(246, 256);
					num = (int)((num2 * 660957898) ^ 0x6730FEF3);
					continue;
				case 37u:
					form0_0.dataGridViewTextBoxColumn_1.HeaderText = UiText.Get("Module.Type");
					form0_0.dataGridViewTextBoxColumn_1.Name = "TypeColumn";
					num = ((int)num2 * -2102444401) ^ 0x3F917287;
					continue;
				case 36u:
					form0_0.comboBox_1.Location = new Point(10, 80);
					num = ((int)num2 * -1827315752) ^ -1583955851;
					continue;
				case 35u:
					form0_0.label_1.TabIndex = 2;
					num = ((int)num2 * -1606469813) ^ 0x45AA8EAD;
					continue;
				case 34u:
					form0_0.dataGridViewTextBoxColumn_0.Width = 19;
					num = (int)(num2 * 56315837) ^ -1122082855;
					continue;
				case 33u:
					form0_0.label_1 = new System.Windows.Forms.Label();
					num = ((int)num2 * -327545496) ^ -662733664;
					continue;
				case 32u:
					form0_0.dataGridView_0.TabIndex = 5;
					num = ((int)num2 * -923596769) ^ -569183374;
					continue;
				case 31u:
					form0_0.label_1.Text = UiText.Get("Module.CallingConvention");
					form0_0.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
					num = ((int)num2 * -1929047089) ^ -494413140;
					continue;
				case 30u:
					form0_0.comboBox_0.FormattingEnabled = true;
					form0_0.comboBox_0.Location = new Point(10, 37);
					num = ((int)num2 * -287199415) ^ -562303043;
					continue;
				case 29u:
					form0_0.AutoScaleMode = AutoScaleMode.Dpi;
					num = (int)(num2 * 789205610) ^ -1249280313;
					continue;
				case 28u:
					form0_0.label_2.TabIndex = 4;
					num = ((int)num2 * -1885998355) ^ -325901201;
					continue;
				case 27u:
					((ISupportInitialize)form0_0.dataGridView_0).BeginInit();
					num = ((int)num2 * -1025451239) ^ 0x225B7A90;
					continue;
				case 26u:
					form0_0.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
					form0_0.dataGridView_0.Columns.AddRange(form0_0.dataGridViewTextBoxColumn_0, form0_0.dataGridViewTextBoxColumn_1, form0_0.dataGridViewTextBoxColumn_2);
					num = ((int)num2 * -934688223) ^ -2142949159;
					continue;
				case 25u:
					form0_0.dataGridView_0.RowsRemoved += form0_0.method_9;
					num = ((int)num2 * -922479897) ^ 0x4A206665;
					continue;
				case 23u:
					form0_0.groupBox_0.Controls.Add(form0_0.label_1);
					form0_0.groupBox_0.Controls.Add(form0_0.comboBox_0);
					form0_0.groupBox_0.Controls.Add(form0_0.label_0);
					num = ((int)num2 * -2044187082) ^ -191276069;
					continue;
				case 22u:
					form0_0.ClientSize = new Size(270, 280);
					form0_0.Controls.Add(form0_0.groupBox_0);
					form0_0.Font = new Font("Segoe UI", 8.25f);
					form0_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
					num = ((int)num2 * -1144520454) ^ -56154578;
					continue;
				case 21u:
					form0_0.dataGridView_0.MultiSelect = false;
					num = ((int)num2 * -1065705389) ^ -1949515731;
					continue;
				case 20u:
					form0_0.groupBox_0.TabIndex = 0;
					num = (int)(num2 * 113903180) ^ -996029444;
					continue;
				case 19u:
					((ISupportInitialize)form0_0.dataGridView_0).EndInit();
					form0_0.ResumeLayout(performLayout: false);
					num = (int)(num2 * 911824908) ^ -378471041;
					continue;
				case 18u:
					form0_0.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					num = ((int)num2 * -1767805509) ^ -1784917390;
					continue;
				case 17u:
					form0_0.textBox_0.TabIndex = 7;
					form0_0.comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
					form0_0.comboBox_2.FormattingEnabled = true;
					num = (int)((num2 * 2061221051) ^ 0x3C51857A);
					continue;
				case 16u:
					form0_0.label_2.Text = UiText.Get("Module.Parameters");
					num = ((int)num2 * -1847463114) ^ 0x345735A0;
					continue;
				case 15u:
					form0_0.groupBox_0.ResumeLayout(performLayout: false);
					num = (int)((num2 * 5716963) ^ 0x55BEC71B);
					continue;
				case 14u:
					form0_0.comboBox_1.Size = new Size(229, 21);
					num = (int)((num2 * 1764151489) ^ 0x67A3A4BD);
					continue;
				case 13u:
					form0_0.groupBox_0.PerformLayout();
					num = ((int)num2 * -1092899620) ^ -925748500;
					continue;
				case 12u:
					form0_0.label_2.AutoSize = true;
					num = (int)((num2 * 247398853) ^ 0x4183A762);
					continue;
				case 11u:
					form0_0.textBox_0.Location = new Point(92, 228);
					form0_0.textBox_0.Name = "argValueTextBox";
					form0_0.textBox_0.Size = new Size(90, 22);
					num = ((int)num2 * -1243478033) ^ -1810365769;
					continue;
				case 10u:
					form0_0.button_0.Name = "addButton";
					num = ((int)num2 * -1032839304) ^ 0x7E085CD0;
					continue;
				case 9u:
					form0_0.MaximizeBox = false;
					form0_0.MinimizeBox = false;
					form0_0.Name = "AdvancedModuleOptionsForm";
					num = (int)(num2 * 2083888429) ^ -1894112310;
					continue;
				case 8u:
					form0_0.dataGridView_0.Location = new Point(10, 124);
					num = (int)((num2 * 1791822145) ^ 0x1567FB5E);
					continue;
				case 7u:
					form0_0.dataGridViewTextBoxColumn_2.HeaderText = UiText.Get("Module.Value");
					form0_0.dataGridViewTextBoxColumn_2.Name = "ValueColumn";
					form0_0.dataGridViewTextBoxColumn_2.ReadOnly = true;
					num = ((int)num2 * -1254743129) ^ 0x17AE915E;
					continue;
				case 6u:
					form0_0.comboBox_1.Name = "callingConvComboBox";
					num = (int)(num2 * 10036335) ^ -1293850617;
					continue;
				case 5u:
					form0_0.AutoScaleDimensions = new SizeF(96f, 96f);
					num = (int)(num2 * 1351954849) ^ -405506269;
					continue;
				case 4u:
					form0_0.label_0.Text = UiText.Get("Module.ExportFunction");
					num = ((int)num2 * -1100384208) ^ 0x2930EEC6;
					continue;
				case 3u:
					form0_0.dataGridView_0.Size = new Size(229, 99);
					num = ((int)num2 * -544058712) ^ 0x248BE613;
					continue;
				case 2u:
					form0_0.label_1.Location = new Point(7, 64);
					form0_0.label_1.Name = "callingConventionLabel";
					num = ((int)num2 * -519109860) ^ -245499422;
					continue;
				case 1u:
					form0_0.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
					num = ((int)num2 * -1593684966) ^ -1294137474;
					continue;
				case 0u:
					form0_0.comboBox_0.Name = "exportFunctionComboBox";
					form0_0.comboBox_0.Size = new Size(229, 21);
					form0_0.comboBox_0.TabIndex = 1;
					num = ((int)num2 * -661769907) ^ -676956827;
					continue;
				default:
					return;
				case 47u:
					break;
				case 24u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_29(DependencyInstallerForm form3_0, string string_0, string string_1, string string_2)
	{
		form3_0.string_0 = string_0;
		form3_0.string_1 = string_1;
		form3_0.string_2 = string_2;
		while (true)
		{
			int num = -1081599329;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1141489570)) % 3)
				{
				case 2u:
					goto IL_0017;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0017:
				form3_0.bool_0 = true;
				num = ((int)num2 * -312124660) ^ 0x1AC67D05;
			}
		}
	}

	internal static void smethod_50(DependencyInstallerForm form3_0, string string_0, string string_1)
	{
		form3_0.string_0 = string_0;
		form3_0.string_1 = string_1;
		form3_0.bool_0 = false;
	}

	internal static Bitmap smethod_100(Icon icon_0)
	{
		Bitmap bitmap = icon_0.ToBitmap();
		try
		{
			Bitmap bitmap2 = new Bitmap(22, 22);
			Graphics graphics = Graphics.FromImage(bitmap2);
			try
			{
				graphics.InterpolationMode = InterpolationMode.High;
				while (true)
				{
					IL_0062:
					int num = -470118680;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1553791507)) % 3)
						{
						case 1u:
							goto IL_0021;
						default:
							goto end_IL_0044;
						case 2u:
							break;
						case 0u:
							goto end_IL_0044;
						}
						goto IL_0062;
						IL_0021:
						graphics.DrawImage(bitmap, 0, 0, bitmap2.Width, bitmap2.Height);
						num = ((int)num2 * -1194039218) ^ 0x130BC080;
						continue;
						end_IL_0044:
						break;
					}
					break;
				}
			}
			finally
			{
				if (graphics != null)
				{
					while (true)
					{
						IL_00a2:
						int num3 = -2021700286;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num3 ^ -1553791507)) % 3)
							{
							case 2u:
								goto IL_0070;
							default:
								goto end_IL_0084;
							case 0u:
								break;
							case 1u:
								goto end_IL_0084;
							}
							goto IL_00a2;
							IL_0070:
							((IDisposable)graphics).Dispose();
							num3 = ((int)num2 * -1161977881) ^ 0x7718A73B;
							continue;
							end_IL_0084:
							break;
						}
						break;
					}
				}
			}
			return bitmap2;
		}
		finally
		{
			if (bitmap != null)
			{
				while (true)
				{
					IL_00e5:
					int num4 = -333268470;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num4 ^ -1553791507)) % 3)
						{
						case 2u:
							goto IL_00b3;
						default:
							goto end_IL_00c7;
						case 0u:
							break;
						case 1u:
							goto end_IL_00c7;
						}
						goto IL_00e5;
						IL_00b3:
						((IDisposable)bitmap).Dispose();
						num4 = (int)((num2 * 802224640) ^ 0x2B271A66);
						continue;
						end_IL_00c7:
						break;
					}
					break;
				}
			}
		}
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
		while (true)
		{
			int num = -1329755379;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -979035706)) % 21)
				{
				case 20u:
					form3_0.label_0.Location = new Point(9, 9);
					num = (int)((num2 * 2009780718) ^ 0x3867E425);
					continue;
				case 19u:
					form3_0.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					num = ((int)num2 * -1282692137) ^ -1303994145;
					continue;
				case 18u:
					form3_0.label_0.Size = new Size(170, 15);
					num = ((int)num2 * -471455698) ^ -900809572;
					continue;
				case 17u:
					form3_0.progressBar_0.TabIndex = 1;
					form3_0.AutoScaleDimensions = new SizeF(96f, 96f);
					num = (int)(num2 * 1873902164) ^ -1065956977;
					continue;
				case 15u:
					form3_0.progressBar_0.Size = new Size(448, 23);
					num = ((int)num2 * -1120037884) ^ 0x1E20C1EA;
					continue;
				case 14u:
					form3_0.PerformLayout();
					num = ((int)num2 * -839804707) ^ 0x7407FEFB;
					continue;
				case 13u:
					form3_0.progressBar_0.Location = new Point(12, 29);
					form3_0.progressBar_0.Name = "mainProgressBar";
					num = (int)(num2 * 1727692378) ^ -1613471598;
					continue;
				case 12u:
					form3_0.label_0.Text = UiText.Get("Dependency.Connecting");
					num = ((int)num2 * -1941043425) ^ 0x3A311E50;
					continue;
				case 11u:
					form3_0.MinimizeBox = false;
					form3_0.Name = "DepedencyDownloadForm";
					form3_0.Text = UiText.Get("Dependency.Title");
					form3_0.FormClosing += form3_0.method_1;
					form3_0.Load += form3_0.method_0;
					num = ((int)num2 * -996366165) ^ -1124440156;
					continue;
				case 10u:
					form3_0.MaximizeBox = false;
					num = ((int)num2 * -1277922607) ^ 0x5514545F;
					continue;
				case 9u:
					form3_0.label_0.Name = "statusLabel";
					num = (int)(num2 * 1490536726) ^ -73512116;
					continue;
				case 8u:
					form3_0.AutoScaleMode = AutoScaleMode.Dpi;
					form3_0.ClientSize = new Size(472, 64);
					num = (int)(num2 * 2026145018) ^ -834500992;
					continue;
				case 7u:
					form3_0.label_0 = new System.Windows.Forms.Label();
					form3_0.progressBar_0 = new ProgressBar();
					num = ((int)num2 * -521283938) ^ -1814046910;
					continue;
				case 6u:
					form3_0.Controls.Add(form3_0.progressBar_0);
					num = (int)(num2 * 1548199136) ^ -1005340260;
					continue;
				case 5u:
					form3_0.label_0.Font = new Font("Segoe UI", 8.75f);
					num = ((int)num2 * -2034362869) ^ -847167609;
					continue;
				case 4u:
					form3_0.SuspendLayout();
					form3_0.label_0.AutoSize = true;
					num = (int)(num2 * 790717315) ^ -791956659;
					continue;
				case 3u:
					form3_0.label_0.TabIndex = 0;
					num = ((int)num2 * -1388110398) ^ -103091094;
					continue;
				case 2u:
					form3_0.ResumeLayout(performLayout: false);
					num = (int)(num2 * 1735870118) ^ -1375312663;
					continue;
				case 1u:
					form3_0.Controls.Add(form3_0.label_0);
					form3_0.Font = new Font("Segoe UI", 8.25f);
					form3_0.FormBorderStyle = FormBorderStyle.FixedSingle;
					num = ((int)num2 * -1309327633) ^ 0x5C2BF26C;
					continue;
				default:
					return;
				case 0u:
					break;
				case 16u:
					return;
				}
				break;
			}
		}
	}

	internal static bool smethod_139(ref string string_0, [Out] ModuleOptionsForm form0_0, string string_1)
	{
		if (!string_1.StartsWith("0x"))
		{
			while (true)
			{
				int num = 63086030;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x6D48C3FC)) % 4)
					{
					case 2u:
						num = ((!string_1.StartsWith("&H")) ? (-1365823868) : (-2030242627)) ^ ((int)num2 * -1865959600);
						continue;
					case 3u:
						break;
					default:
						string_0 = string_1;
						return false;
					case 1u:
						goto end_IL_0066;
					}
					break;
				}
				continue;
				end_IL_0066:
				break;
			}
		}
		string_0 = string_1.Substring(2);
		return true;
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
		while (true)
		{
			int num = -1705853563;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -928649106)) % 183)
				{
				case 182u:
					gform2_0.button_0.Location = new Point(9, 48);
					num = ((int)num2 * -1759761155) ^ -1929881329;
					continue;
				case 181u:
					gform2_0.checkBox_4.AutoSize = true;
					gform2_0.checkBox_4.Location = new Point(9, 21);
					gform2_0.checkBox_4.Name = "erasePECheckBox";
					gform2_0.checkBox_4.Size = new Size(68, 17);
					gform2_0.checkBox_4.TabIndex = 0;
					num = ((int)num2 * -919923682) ^ 0x1167733E;
					continue;
				case 180u:
					gform2_0.button_1 = new Button();
					num = ((int)num2 * -1229043392) ^ 0x72BCE751;
					continue;
				case 179u:
					gform2_0.groupBox_3.TabStop = false;
					gform2_0.groupBox_3.Text = UiText.Get("Settings.PostInjection");
					num = ((int)num2 * -239965145) ^ -211201171;
					continue;
				case 178u:
					gform2_0.groupBox_1.Name = "injectionOptionsGroupBox";
					num = (int)((num2 * 1842782672) ^ 0x79EF6CD6);
					continue;
				case 177u:
					gform2_0.groupBox_5.Name = "toolsGroupBox";
					num = (int)(num2 * 200348384) ^ -808239276;
					continue;
				case 176u:
					gform2_0.Controls.Add(gform2_0.groupBox_4);
					num = (int)(num2 * 1402666409) ^ -1340790443;
					continue;
				case 175u:
					gform2_0.panel_2.Location = new Point(152, 21);
					num = (int)((num2 * 1733435972) ^ 0x7C2367A4);
					continue;
				case 174u:
					gform2_0.button_4.Click += gform2_0.method_12;
					gform2_0.button_5.Location = new Point(9, 41);
					num = ((int)num2 * -2119591525) ^ -1190375878;
					continue;
				case 173u:
					gform2_0.button_5.Text = UiText.Get("Settings.ScrambleDll");
					gform2_0.button_5.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1680119209) ^ 0x3B34FB72;
					continue;
				case 172u:
					gform2_0.button_3.Size = new Size(110, 23);
					num = ((int)num2 * -1816139661) ^ 0x1E1CB16;
					continue;
				case 171u:
					gform2_0.button_2.Name = "resetButton";
					num = ((int)num2 * -1799554654) ^ -1236190075;
					continue;
				case 170u:
					gform2_0.button_1.UseVisualStyleBackColor = true;
					gform2_0.button_1.Click += gform2_0.method_3;
					gform2_0.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
					gform2_0.comboBox_1.FormattingEnabled = true;
					gform2_0.comboBox_1.Items.AddRange(new object[5]
					{
						UiText.Get("Settings.Preset.None"),
						UiText.Get("Settings.Preset.Basic"),
						UiText.Get("Settings.Preset.Standard"),
						UiText.Get("Settings.Preset.Extreme"),
						UiText.Get("Settings.Preset.Custom")
					});
					num = (int)(num2 * 1682174863) ^ -382272157;
					continue;
				case 169u:
					gform2_0.comboBox_1 = new ComboBox();
					gform2_0.groupBox_3 = new ModernCard();
					num = ((int)num2 * -1860990723) ^ -1332269552;
					continue;
				case 168u:
					gform2_0.numericUpDown_1.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
					gform2_0.numericUpDown_1.Name = "injectDelayNumericUpDown";
					num = (int)(num2 * 764823054) ^ -197853236;
					continue;
				case 167u:
					gform2_0.button_1.Size = new Size(162, 23);
					num = ((int)num2 * -1260734447) ^ -1932294355;
					continue;
				case 166u:
					gform2_0.button_2.Size = new Size(110, 23);
					num = (int)(num2 * 256661961) ^ -1817396875;
					continue;
				case 165u:
					gform2_0.checkBox_2.TabIndex = 0;
					num = (int)(num2 * 1689544951) ^ -205810235;
					continue;
				case 164u:
					gform2_0.checkBox_1.AutoSize = true;
					num = (int)(num2 * 1918017406) ^ -27597368;
					continue;
				case 163u:
					gform2_0.groupBox_1 = new ModernCard();
					num = (int)((num2 * 1900349460) ^ 0x6DDA9455);
					continue;
				case 162u:
					gform2_0.groupBox_5.Controls.Add(gform2_0.button_5);
					num = ((int)num2 * -455841995) ^ 0x186E7C5B;
					continue;
				case 161u:
					gform2_0.panel_1.Size = new Size(20, 20);
					num = ((int)num2 * -682958284) ^ 0xEE8CC08;
					continue;
				case 160u:
					gform2_0.groupBox_1.Location = new Point(12, 102);
					num = (int)(num2 * 1842834998) ^ -1837354693;
					continue;
				case 159u:
					gform2_0.numericUpDown_0.Location = new Point(98, 115);
					num = (int)((num2 * 161787125) ^ 0x973BDAE);
					continue;
				case 158u:
					gform2_0.groupBox_4.Controls.Add(gform2_0.panel_2);
					gform2_0.groupBox_4.Location = new Point(202, 102);
					gform2_0.groupBox_4.Name = "themeOptionsGroupBox";
					num = ((int)num2 * -1411050158) ^ -154067549;
					continue;
				case 157u:
					gform2_0.button_2 = new Button();
					num = ((int)num2 * -510801429) ^ -1333693052;
					continue;
				case 156u:
					gform2_0.label_0.Name = "delayBetweenLabel";
					num = (int)((num2 * 268053826) ^ 0x68DFBC1D);
					continue;
				case 155u:
					gform2_0.panel_2.Size = new Size(20, 20);
					num = (int)((num2 * 852726921) ^ 0x5DA0E3D1);
					continue;
				case 154u:
					gform2_0.checkBox_0.Text = UiText.Get("Settings.StealthInject");
					num = ((int)num2 * -1680241984) ^ -1051479027;
					continue;
				case 153u:
					gform2_0.button_4.Text = UiText.Get("Settings.SecureMode");
					gform2_0.button_4.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1121812860) ^ -1523937389;
					continue;
				case 152u:
					gform2_0.label_0 = new System.Windows.Forms.Label();
					num = (int)(num2 * 1672103714) ^ -1726146184;
					continue;
				case 151u:
					gform2_0.label_2.TabIndex = 5;
					num = (int)((num2 * 720283123) ^ 0x1F9D662B);
					continue;
				case 150u:
					gform2_0.comboBox_1.TabIndex = 3;
					num = (int)(num2 * 1938840562) ^ -1289074794;
					continue;
				case 149u:
					gform2_0.groupBox_4.TabIndex = 4;
					num = (int)((num2 * 786973134) ^ 0x276A8682);
					continue;
				case 148u:
					gform2_0.groupBox_5.SuspendLayout();
					num = ((int)num2 * -1346111595) ^ -828293886;
					continue;
				case 147u:
					gform2_0.button_6.Name = "viewProcessInformationButton";
					gform2_0.button_6.Size = new Size(162, 23);
					num = ((int)num2 * -931689210) ^ -1825377260;
					continue;
				case 146u:
					gform2_0.button_0.Name = "advancedInjectOptions";
					num = (int)((num2 * 409551097) ^ 0x24AF0746);
					continue;
				case 145u:
					gform2_0.checkBox_4.Text = UiText.Get("Settings.ErasePe");
					gform2_0.checkBox_4.UseVisualStyleBackColor = true;
					gform2_0.groupBox_4.Controls.Add(gform2_0.label_2);
					gform2_0.groupBox_4.Controls.Add(gform2_0.panel_0);
					gform2_0.groupBox_4.Controls.Add(gform2_0.panel_1);
					num = (int)((num2 * 1464604345) ^ 0x4C9B1C3E);
					continue;
				case 144u:
					gform2_0.panel_0.Location = new Point(152, 67);
					num = ((int)num2 * -1417472839) ^ 0x187493F0;
					continue;
				case 143u:
					gform2_0.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					gform2_0.MaximizeBox = false;
					gform2_0.MinimizeBox = false;
					gform2_0.Name = "SettingsForm";
					gform2_0.Text = UiText.Get("Settings.Title");
					gform2_0.FormClosing += gform2_0.method_9;
					gform2_0.groupBox_0.ResumeLayout(performLayout: false);
					gform2_0.groupBox_1.ResumeLayout(performLayout: false);
					gform2_0.groupBox_1.PerformLayout();
					num = (int)((num2 * 803699503) ^ 0x5CF4AD92);
					continue;
				case 142u:
					gform2_0.button_0.TabIndex = 1;
					gform2_0.button_0.Text = UiText.Get("Settings.Advanced");
					gform2_0.button_0.UseVisualStyleBackColor = true;
					num = (int)(num2 * 599319832) ^ -818623083;
					continue;
				case 141u:
					gform2_0.groupBox_3.Controls.Add(gform2_0.checkBox_4);
					num = (int)(num2 * 247168585) ^ -1460118827;
					continue;
				case 140u:
					gform2_0.label_1.TabIndex = 3;
					num = ((int)num2 * -127562948) ^ -1696392535;
					continue;
				case 139u:
					gform2_0.label_0.Size = new Size(86, 13);
					num = (int)((num2 * 44475132) ^ 0x413071D8);
					continue;
				case 138u:
					gform2_0.groupBox_3.Size = new Size(180, 48);
					num = (int)((num2 * 923602142) ^ 0x1125F99D);
					continue;
				case 137u:
					gform2_0.label_2.AutoSize = true;
					num = (int)(num2 * 1055347567) ^ -667938492;
					continue;
				case 136u:
					gform2_0.button_3.Click += gform2_0.method_8;
					gform2_0.groupBox_5.Controls.Add(gform2_0.button_4);
					num = (int)(num2 * 1101356652) ^ -1061207841;
					continue;
				case 135u:
					gform2_0.checkBox_3.AutoSize = true;
					num = ((int)num2 * -656757500) ^ 0x701E449A;
					continue;
				case 134u:
					gform2_0.checkBox_1.Name = "closeOnInjectCheckBox";
					gform2_0.checkBox_1.Size = new Size(102, 17);
					num = (int)(num2 * 1991297696) ^ -151477556;
					continue;
				case 133u:
					gform2_0.checkBox_1.Text = UiText.Get("Settings.CloseOnInject");
					gform2_0.checkBox_1.UseVisualStyleBackColor = true;
					num = (int)((num2 * 114144290) ^ 0x16D65E45);
					continue;
				case 132u:
					gform2_0.checkBox_1 = new CheckBox();
					num = (int)(num2 * 1853696398) ^ -210739268;
					continue;
				case 131u:
					gform2_0.checkBox_0.Location = new Point(9, 67);
					gform2_0.checkBox_0.Name = "stealthInjectCheckBox";
					gform2_0.checkBox_0.Size = new Size(93, 17);
					gform2_0.checkBox_0.TabIndex = 2;
					num = (int)(num2 * 1098242939) ^ -73656747;
					continue;
				case 130u:
					gform2_0.button_5.Size = new Size(162, 23);
					num = ((int)num2 * -2137561089) ^ -1402084636;
					continue;
				case 129u:
					gform2_0.panel_1.Click += gform2_0.method_14;
					num = (int)(num2 * 424977412) ^ -783288835;
					continue;
				case 128u:
					gform2_0.checkBox_2.CheckedChanged += gform2_0.method_2;
					num = ((int)num2 * -915766768) ^ -1593498246;
					continue;
				case 127u:
					gform2_0.checkBox_1.TabIndex = 1;
					num = (int)((num2 * 1414232083) ^ 0x6BA34E6B);
					continue;
				case 126u:
					gform2_0.button_3 = new Button();
					num = ((int)num2 * -1889820343) ^ -891581904;
					continue;
				case 125u:
					gform2_0.button_6 = new Button();
					gform2_0.colorDialog_0 = new ColorDialog();
					num = ((int)num2 * -1744745214) ^ 0x4E0820CA;
					continue;
				case 124u:
					gform2_0.comboBox_1.Size = new Size(162, 21);
					num = ((int)num2 * -1108374785) ^ 0x6584D4F7;
					continue;
				case 123u:
					gform2_0.button_3.Text = UiText.Get("Common.OK");
					num = ((int)num2 * -1435986023) ^ 0x380CC975;
					continue;
				case 122u:
					gform2_0.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
					gform2_0.comboBox_0.FormattingEnabled = true;
					gform2_0.comboBox_0.Items.AddRange(new object[5]
					{
						UiText.Get("Settings.Method.Standard"),
						UiText.Get("Settings.Method.ThreadHijacking"),
						UiText.Get("Settings.Method.LdrLoadDllStub"),
						UiText.Get("Settings.Method.LdrpLoadDllStub"),
						UiText.Get("Settings.Method.ManualMap")
					});
					num = (int)((num2 * 1971766879) ^ 0x75DE5166);
					continue;
				case 121u:
					gform2_0.groupBox_4.PerformLayout();
					gform2_0.groupBox_5.ResumeLayout(performLayout: false);
					num = (int)((num2 * 1426385494) ^ 0x45F7B14E);
					continue;
				case 120u:
					gform2_0.AutoScaleMode = AutoScaleMode.Dpi;
					num = (int)((num2 * 1517399758) ^ 0x6C0CF700);
					continue;
				case 119u:
					gform2_0.checkBox_2 = new CheckBox();
					gform2_0.groupBox_2 = new ModernCard();
					num = (int)((num2 * 764274511) ^ 0x510C3D12);
					continue;
				case 118u:
					gform2_0.groupBox_1.Controls.Add(gform2_0.numericUpDown_0);
					num = ((int)num2 * -1425068352) ^ -860432022;
					continue;
				case 117u:
					gform2_0.button_3.TabIndex = 7;
					num = ((int)num2 * -982113597) ^ 0x7B6FC7C0;
					continue;
				case 116u:
					gform2_0.label_4.AutoSize = true;
					gform2_0.label_4.Location = new Point(7, 25);
					num = (int)((num2 * 2138641410) ^ 0x19294D43);
					continue;
				case 115u:
					gform2_0.groupBox_5.Size = new Size(180, 95);
					num = (int)(num2 * 1881158135) ^ -2004896723;
					continue;
				case 114u:
					gform2_0.comboBox_0.Location = new Point(9, 21);
					gform2_0.comboBox_0.Name = "injectionMethodComboBox";
					gform2_0.comboBox_0.Size = new Size(162, 21);
					num = (int)(num2 * 1110422403) ^ -629204183;
					continue;
				case 113u:
					gform2_0.groupBox_1.Controls.Add(gform2_0.label_0);
					gform2_0.groupBox_1.Controls.Add(gform2_0.numericUpDown_1);
					gform2_0.groupBox_1.Controls.Add(gform2_0.label_1);
					num = ((int)num2 * -528281226) ^ -909765005;
					continue;
				case 112u:
					gform2_0.button_0.Size = new Size(162, 23);
					num = (int)((num2 * 1835374057) ^ 0x2D146DF5);
					continue;
				case 111u:
					gform2_0.checkBox_3.TabIndex = 1;
					gform2_0.checkBox_3.Text = UiText.Get("Settings.HideModule");
					gform2_0.checkBox_3.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1893466107) ^ 0x2ADCD6AE;
					continue;
				case 110u:
					gform2_0.panel_2.Name = "textColorBox";
					num = (int)(num2 * 849263786) ^ -1948895361;
					continue;
				case 109u:
					gform2_0.groupBox_3.Location = new Point(12, 257);
					num = (int)((num2 * 1770984958) ^ 0x4428B9D8);
					continue;
				case 108u:
					gform2_0.groupBox_4.Controls.Add(gform2_0.label_3);
					num = (int)((num2 * 162111896) ^ 0x56F1B289);
					continue;
				case 107u:
					gform2_0.label_1.Text = UiText.Get("Settings.DelayBefore");
					num = ((int)num2 * -300611719) ^ -1512168135;
					continue;
				case 106u:
					gform2_0.groupBox_0.Size = new Size(180, 84);
					gform2_0.groupBox_0.TabIndex = 0;
					num = ((int)num2 * -84141935) ^ -587237939;
					continue;
				case 105u:
					gform2_0.groupBox_4.ResumeLayout(performLayout: false);
					num = ((int)num2 * -470560664) ^ -244736908;
					continue;
				case 104u:
					gform2_0.groupBox_0.TabStop = false;
					num = ((int)num2 * -300083950) ^ -1639726315;
					continue;
				case 103u:
					gform2_0.checkBox_3.Name = "hideModuleCheckBox";
					gform2_0.checkBox_3.Size = new Size(93, 17);
					num = ((int)num2 * -969119992) ^ 0x5EA16AFD;
					continue;
				case 102u:
					gform2_0.button_6.UseVisualStyleBackColor = true;
					gform2_0.button_6.Click += gform2_0.method_10;
					gform2_0.AutoScaleDimensions = new SizeF(96f, 96f);
					num = ((int)num2 * -1775427697) ^ 0x68A9D935;
					continue;
				case 101u:
					gform2_0.numericUpDown_0.TabIndex = 6;
					num = ((int)num2 * -1296678026) ^ -1083204196;
					continue;
				case 100u:
					gform2_0.button_2.Click += gform2_0.method_7;
					gform2_0.button_3.Location = new Point(273, 315);
					num = (int)((num2 * 441552836) ^ 0xF0FEFF8);
					continue;
				case 99u:
					gform2_0.groupBox_4.TabStop = false;
					num = (int)(num2 * 1953473678) ^ -1716190711;
					continue;
				case 98u:
					gform2_0.Controls.Add(gform2_0.groupBox_3);
					gform2_0.Controls.Add(gform2_0.groupBox_2);
					num = ((int)num2 * -1841680759) ^ 0x6574DA;
					continue;
				case 97u:
					gform2_0.panel_2.Click += gform2_0.method_13;
					num = ((int)num2 * -1953414657) ^ -89683309;
					continue;
				case 96u:
					gform2_0.comboBox_1.Location = new Point(9, 21);
					num = ((int)num2 * -481355542) ^ -1617966988;
					continue;
				case 95u:
					gform2_0.checkBox_0.AutoSize = true;
					num = (int)(num2 * 312810258) ^ -244152340;
					continue;
				case 94u:
					gform2_0.Controls.Add(gform2_0.groupBox_1);
					num = ((int)num2 * -385831777) ^ 0x42B032F1;
					continue;
				case 93u:
					gform2_0.groupBox_3.Name = "postInjectGroupBox";
					num = (int)((num2 * 1888025264) ^ 0x5C5E8A54);
					continue;
				case 92u:
					gform2_0.checkBox_0.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1605420969) ^ 0x5D80A815;
					continue;
				case 91u:
					gform2_0.label_4.Name = "textColorLabel";
					num = (int)(num2 * 60051400) ^ -1022146585;
					continue;
				case 90u:
					gform2_0.groupBox_2.Controls.Add(gform2_0.comboBox_1);
					num = ((int)num2 * -1189043289) ^ 0x100D4DAE;
					continue;
				case 89u:
					gform2_0.groupBox_5 = new ModernCard();
					gform2_0.button_4 = new Button();
					gform2_0.button_5 = new Button();
					num = ((int)num2 * -1771542883) ^ -1402056416;
					continue;
				case 88u:
					gform2_0.label_4 = new System.Windows.Forms.Label();
					num = ((int)num2 * -859800146) ^ -2009653411;
					continue;
				case 87u:
					gform2_0.panel_0.Name = "backgroundColor2Box";
					gform2_0.panel_0.Size = new Size(20, 20);
					gform2_0.panel_0.TabIndex = 4;
					gform2_0.panel_0.Click += gform2_0.method_15;
					num = (int)(num2 * 1488372860) ^ -1207072453;
					continue;
				case 86u:
					gform2_0.ClientSize = new Size(396, 347);
					num = ((int)num2 * -1525424288) ^ -174112198;
					continue;
				case 85u:
					gform2_0.numericUpDown_1.Location = new Point(98, 90);
					num = ((int)num2 * -1995935368) ^ 0x1C240136;
					continue;
				case 84u:
					gform2_0.button_6.TabIndex = 0;
					num = (int)((num2 * 667019363) ^ 0x1948B1BC);
					continue;
				case 83u:
					gform2_0.checkBox_1.Location = new Point(9, 44);
					num = (int)(num2 * 314508367) ^ -1520265514;
					continue;
				case 82u:
					gform2_0.button_5.TabIndex = 1;
					num = ((int)num2 * -959217249) ^ -63229709;
					continue;
				case 81u:
					gform2_0.label_0.TabIndex = 5;
					gform2_0.label_0.Text = UiText.Get("Settings.DelayBetween");
					num = (int)(num2 * 100035645) ^ -576261038;
					continue;
				case 80u:
					gform2_0.label_4.TabIndex = 1;
					num = ((int)num2 * -57954872) ^ -2135226614;
					continue;
				case 79u:
					gform2_0.comboBox_0.TabIndex = 0;
					num = ((int)num2 * -425049992) ^ -1536749328;
					continue;
				case 78u:
					gform2_0.button_6.Text = UiText.Get("Settings.ProcessInfo");
					num = (int)(num2 * 83058863) ^ -1651661353;
					continue;
				case 77u:
					gform2_0.label_3.Location = new Point(7, 48);
					num = (int)(num2 * 651707463) ^ -1158182476;
					continue;
				case 76u:
					gform2_0.checkBox_2.Text = UiText.Get("Settings.AutoInject");
					gform2_0.checkBox_2.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1492198581) ^ 0x2F92B1CB;
					continue;
				case 75u:
					gform2_0.button_3.UseVisualStyleBackColor = true;
					num = (int)(num2 * 717293402) ^ -1623797971;
					continue;
				case 74u:
					gform2_0.label_4.Text = UiText.Get("Settings.TextColor");
					gform2_0.panel_2.BorderStyle = BorderStyle.FixedSingle;
					num = (int)(num2 * 1508877135) ^ -232209066;
					continue;
				case 73u:
					gform2_0.label_2.Text = UiText.Get("Settings.SecondaryAccent");
					gform2_0.panel_0.BorderStyle = BorderStyle.FixedSingle;
					num = (int)(num2 * 1646328371) ^ -130906542;
					continue;
				case 72u:
					gform2_0.groupBox_3.SuspendLayout();
					num = ((int)num2 * -1082079) ^ 0x3AB6AB34;
					continue;
				case 71u:
					gform2_0.groupBox_0.Text = UiText.Get("Settings.InjectionMethod");
					num = (int)(num2 * 1258531918) ^ -1146556521;
					continue;
				case 70u:
					gform2_0.Controls.Add(gform2_0.button_2);
					num = ((int)num2 * -1513215670) ^ 0x167BDFBF;
					continue;
				case 69u:
					gform2_0.SuspendLayout();
					gform2_0.groupBox_0.Controls.Add(gform2_0.button_0);
					gform2_0.groupBox_0.Controls.Add(gform2_0.comboBox_0);
					gform2_0.groupBox_0.Location = new Point(12, 12);
					gform2_0.groupBox_0.Name = "injectionMethodGroupBox";
					num = ((int)num2 * -2021217969) ^ 0x3F8C3518;
					continue;
				case 68u:
					gform2_0.checkBox_3.Location = new Point(83, 21);
					num = ((int)num2 * -38643171) ^ 0xC67D88E;
					continue;
				case 67u:
					gform2_0.panel_2.TabIndex = 0;
					num = ((int)num2 * -614556199) ^ 0x223F40B2;
					continue;
				case 66u:
					gform2_0.numericUpDown_1.TabIndex = 4;
					gform2_0.label_1.AutoSize = true;
					gform2_0.label_1.Location = new Point(6, 92);
					gform2_0.label_1.Name = "injectDelayLabel";
					gform2_0.label_1.Size = new Size(68, 13);
					num = (int)((num2 * 844572949) ^ 0x63EC8B47);
					continue;
				case 65u:
					gform2_0.groupBox_5.Controls.Add(gform2_0.button_6);
					gform2_0.groupBox_5.Location = new Point(203, 210);
					num = ((int)num2 * -880268576) ^ -1692775314;
					continue;
				case 64u:
					gform2_0.groupBox_1.Size = new Size(180, 149);
					gform2_0.groupBox_1.TabIndex = 1;
					gform2_0.groupBox_1.TabStop = false;
					num = ((int)num2 * -133084430) ^ -1996238017;
					continue;
				case 63u:
					gform2_0.panel_2 = new Panel();
					num = ((int)num2 * -1208662241) ^ 0x5145ECB5;
					continue;
				case 62u:
					gform2_0.checkBox_2.AutoSize = true;
					gform2_0.checkBox_2.Location = new Point(9, 21);
					num = ((int)num2 * -1953982742) ^ -1787356595;
					continue;
				case 61u:
					gform2_0.numericUpDown_0.Increment = new decimal(new int[4] { 100, 0, 0, 0 });
					num = ((int)num2 * -216663688) ^ -42023610;
					continue;
				case 60u:
					gform2_0.groupBox_4.SuspendLayout();
					num = ((int)num2 * -732654394) ^ -1442463994;
					continue;
				case 59u:
					gform2_0.groupBox_0 = new ModernCard();
					num = ((int)num2 * -858001066) ^ 0x6641E9B3;
					continue;
				case 58u:
					gform2_0.button_0 = new Button();
					num = ((int)num2 * -635074520) ^ 0x1CD1180C;
					continue;
				case 57u:
					gform2_0.groupBox_1.Text = UiText.Get("Settings.InjectionBehavior");
					num = (int)(num2 * 1705913247) ^ -1066752638;
					continue;
				case 56u:
					gform2_0.panel_2.Cursor = Cursors.Hand;
					num = ((int)num2 * -1410646213) ^ 0x543004F3;
					continue;
				case 55u:
					gform2_0.label_3.Name = "backgroundColor1Label";
					gform2_0.label_3.Size = new Size(120, 13);
					gform2_0.label_3.TabIndex = 2;
					num = ((int)num2 * -686526002) ^ -485679540;
					continue;
				case 54u:
					gform2_0.panel_1.Location = new Point(152, 44);
					gform2_0.panel_1.Name = "backgroundColor1Box";
					num = (int)((num2 * 2141057814) ^ 0x37C7C311);
					continue;
				case 53u:
					gform2_0.numericUpDown_0.Size = new Size(73, 22);
					num = ((int)num2 * -1627378003) ^ -556650304;
					continue;
				case 52u:
					gform2_0.groupBox_5.Text = UiText.Get("Settings.Tools");
					gform2_0.button_4.Location = new Point(9, 65);
					gform2_0.button_4.Name = "startInSecureModeButton";
					gform2_0.button_4.Size = new Size(162, 23);
					gform2_0.button_4.TabIndex = 2;
					num = ((int)num2 * -543077981) ^ 0x7F2FC780;
					continue;
				case 51u:
					gform2_0.Controls.Add(gform2_0.groupBox_5);
					gform2_0.Controls.Add(gform2_0.button_3);
					num = ((int)num2 * -1736658880) ^ 0x7AF0A583;
					continue;
				case 50u:
					gform2_0.label_3.AutoSize = true;
					num = (int)(num2 * 1776307351) ^ -651388740;
					continue;
				case 49u:
					gform2_0.label_2.Location = new Point(7, 71);
					gform2_0.label_2.Name = "backgroundColor2Label";
					gform2_0.label_2.Size = new Size(120, 13);
					num = ((int)num2 * -1379487104) ^ 0x4C64C91A;
					continue;
				case 48u:
					gform2_0.groupBox_5.TabIndex = 8;
					gform2_0.groupBox_5.TabStop = false;
					num = (int)((num2 * 1552973733) ^ 0x4D3761A2);
					continue;
				case 47u:
					gform2_0.groupBox_2.Location = new Point(203, 12);
					gform2_0.groupBox_2.Name = "scrambleGroupBox";
					gform2_0.groupBox_2.Size = new Size(180, 84);
					gform2_0.groupBox_2.TabIndex = 2;
					gform2_0.groupBox_2.TabStop = false;
					gform2_0.groupBox_2.Text = UiText.Get("Settings.Scrambling");
					num = ((int)num2 * -1738138535) ^ -763755152;
					continue;
				case 45u:
					gform2_0.button_1.Location = new Point(9, 48);
					gform2_0.button_1.Name = "advancedScramblingOptions";
					num = (int)((num2 * 1300305928) ^ 0x39A2A41F);
					continue;
				case 44u:
					gform2_0.button_1.Text = UiText.Get("Settings.Advanced");
					num = (int)((num2 * 104117610) ^ 0x4E2C57DB);
					continue;
				case 43u:
					gform2_0.comboBox_0 = new ComboBox();
					num = ((int)num2 * -2054983239) ^ 0x6FAE3ECC;
					continue;
				case 42u:
					gform2_0.comboBox_1.Name = "scramblePresetCheckBox";
					num = (int)((num2 * 878068039) ^ 0x3B0E7B7);
					continue;
				case 41u:
					gform2_0.groupBox_2.SuspendLayout();
					num = (int)((num2 * 946625981) ^ 0x3A49E1A6);
					continue;
				case 40u:
					gform2_0.button_2.Text = UiText.Get("Settings.Reset");
					num = ((int)num2 * -2063498107) ^ -425840925;
					continue;
				case 39u:
					gform2_0.label_0.Location = new Point(6, 117);
					num = (int)((num2 * 41396785) ^ 0x3698B59B);
					continue;
				case 38u:
					gform2_0.label_4.Size = new Size(61, 13);
					num = (int)((num2 * 565883422) ^ 0x19FA530E);
					continue;
				case 37u:
					((ISupportInitialize)gform2_0.numericUpDown_0).EndInit();
					((ISupportInitialize)gform2_0.numericUpDown_1).EndInit();
					gform2_0.groupBox_2.ResumeLayout(performLayout: false);
					gform2_0.groupBox_3.ResumeLayout(performLayout: false);
					num = ((int)num2 * -1597863313) ^ -1000097276;
					continue;
				case 36u:
					gform2_0.button_2.TabIndex = 5;
					num = (int)((num2 * 692903669) ^ 0x3172A2FF);
					continue;
				case 35u:
					gform2_0.groupBox_4.Text = UiText.Get("Settings.Appearance");
					num = (int)((num2 * 765100405) ^ 0xF905A1B);
					continue;
				case 34u:
					gform2_0.panel_1 = new Panel();
					gform2_0.label_3 = new System.Windows.Forms.Label();
					num = (int)((num2 * 2045708045) ^ 0x71F885E7);
					continue;
				case 33u:
					gform2_0.label_2 = new System.Windows.Forms.Label();
					gform2_0.panel_0 = new Panel();
					num = ((int)num2 * -935719697) ^ -677260451;
					continue;
				case 32u:
					gform2_0.button_5.Name = "scrambleDLLButton";
					num = (int)(num2 * 1833616186) ^ -1346424999;
					continue;
				case 31u:
					gform2_0.button_6.Location = new Point(9, 17);
					num = (int)((num2 * 290824226) ^ 0x1AB4A874);
					continue;
				case 30u:
					gform2_0.button_2.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1415193449) ^ -837768528;
					continue;
				case 29u:
					gform2_0.comboBox_1.SelectedIndexChanged += gform2_0.method_6;
					gform2_0.groupBox_3.Controls.Add(gform2_0.checkBox_3);
					num = (int)((num2 * 60884723) ^ 0xD301FFC);
					continue;
				case 28u:
					gform2_0.button_2.Location = new Point(12, 315);
					num = (int)((num2 * 1606827284) ^ 0x2B9D3773);
					continue;
				case 27u:
					gform2_0.groupBox_3.TabIndex = 3;
					num = ((int)num2 * -978088827) ^ -355103241;
					continue;
				case 26u:
					gform2_0.numericUpDown_0 = new NumericUpDown();
					num = (int)(num2 * 772235592) ^ -1068228246;
					continue;
				case 25u:
					gform2_0.groupBox_4.Size = new Size(181, 102);
					num = ((int)num2 * -144019996) ^ 0x2522A86C;
					continue;
				case 24u:
					gform2_0.groupBox_0.SuspendLayout();
					gform2_0.groupBox_1.SuspendLayout();
					num = (int)((num2 * 638804735) ^ 0x43D67D89);
					continue;
				case 23u:
					gform2_0.Controls.Add(gform2_0.groupBox_0);
					gform2_0.Font = new Font("Segoe UI", 8.25f);
					gform2_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
					num = ((int)num2 * -2012857834) ^ -93567473;
					continue;
				case 22u:
					gform2_0.label_3.Text = UiText.Get("Settings.PrimaryAccent");
					num = ((int)num2 * -1675504492) ^ -929453098;
					continue;
				case 21u:
					gform2_0.numericUpDown_0.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
					gform2_0.numericUpDown_0.Name = "delayBetweenNumericUpDown";
					num = (int)((num2 * 32595147) ^ 0x6FBBD187);
					continue;
				case 20u:
					gform2_0.button_1.TabIndex = 3;
					num = ((int)num2 * -991577024) ^ 0x30B0091E;
					continue;
				case 19u:
					gform2_0.groupBox_1.Controls.Add(gform2_0.checkBox_0);
					gform2_0.groupBox_1.Controls.Add(gform2_0.checkBox_1);
					gform2_0.groupBox_1.Controls.Add(gform2_0.checkBox_2);
					num = (int)((num2 * 1431455018) ^ 0x712B49B1);
					continue;
				case 18u:
					gform2_0.checkBox_2.Size = new Size(82, 17);
					num = ((int)num2 * -1672037320) ^ -1328730899;
					continue;
				case 17u:
					((ISupportInitialize)gform2_0.numericUpDown_0).BeginInit();
					num = (int)((num2 * 205811180) ^ 0x633C0CE3);
					continue;
				case 16u:
					gform2_0.button_0.Click += gform2_0.method_4;
					num = ((int)num2 * -296051188) ^ -694000671;
					continue;
				case 15u:
					gform2_0.groupBox_3.PerformLayout();
					num = (int)((num2 * 1004176377) ^ 0x741F2339);
					continue;
				case 14u:
					gform2_0.groupBox_4.Controls.Add(gform2_0.label_4);
					num = (int)(num2 * 1214085597) ^ -585298907;
					continue;
				case 13u:
					((ISupportInitialize)gform2_0.numericUpDown_1).BeginInit();
					num = ((int)num2 * -1703498273) ^ 0x63B1E65F;
					continue;
				case 12u:
					gform2_0.numericUpDown_1 = new NumericUpDown();
					gform2_0.label_1 = new System.Windows.Forms.Label();
					gform2_0.checkBox_0 = new CheckBox();
					num = ((int)num2 * -1579160828) ^ 0x19E91DEB;
					continue;
				case 11u:
					gform2_0.button_5.Click += gform2_0.method_11;
					num = (int)((num2 * 1028526430) ^ 0x785708BD);
					continue;
				case 9u:
					gform2_0.label_0.AutoSize = true;
					num = (int)((num2 * 1425742731) ^ 0x418219CD);
					continue;
				case 8u:
					gform2_0.checkBox_3 = new CheckBox();
					gform2_0.checkBox_4 = new CheckBox();
					gform2_0.groupBox_4 = new ModernCard();
					num = (int)((num2 * 1797852206) ^ 0x861229C);
					continue;
				case 7u:
					gform2_0.panel_1.TabIndex = 3;
					num = ((int)num2 * -249761401) ^ -1650872974;
					continue;
				case 6u:
					gform2_0.numericUpDown_1.Size = new Size(73, 22);
					num = (int)(num2 * 333357971) ^ -1989230013;
					continue;
				case 5u:
					gform2_0.numericUpDown_1.Increment = new decimal(new int[4] { 100, 0, 0, 0 });
					num = ((int)num2 * -2113593143) ^ 0x4467412;
					continue;
				case 4u:
					gform2_0.panel_0.Cursor = Cursors.Hand;
					num = (int)(num2 * 130142555) ^ -1335865918;
					continue;
				case 3u:
					gform2_0.button_3.Name = "okButton";
					num = ((int)num2 * -422395361) ^ 0x17847060;
					continue;
				case 2u:
					gform2_0.groupBox_2.Controls.Add(gform2_0.button_1);
					num = (int)(num2 * 1200106085) ^ -1952566121;
					continue;
				case 1u:
					gform2_0.checkBox_2.Name = "autoInjectCheckBox";
					num = (int)(num2 * 596162948) ^ -1276677487;
					continue;
				case 0u:
					gform2_0.panel_1.BorderStyle = BorderStyle.FixedSingle;
					gform2_0.panel_1.Cursor = Cursors.Hand;
					num = ((int)num2 * -939287170) ^ -684707784;
					continue;
				case 10u:
					break;
				default:
					gform2_0.ResumeLayout(performLayout: false);
					return;
				}
				break;
			}
		}
	}

	internal static bool smethod_337(MainForm mainForm, string string_0, string string_1, string string_2, bool bool_0, string string_3)
	{
		if (bool_0)
		{
			goto IL_00c5;
		}
		goto IL_0102;
		IL_00c5:
		int num = 84938991;
		goto IL_00ca;
		IL_00ca:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0xCF75D19)) % 6)
			{
			case 2u:
				num = ((MessageBox.Show(mainForm, UiText.Format("Message.Dependency.VersionMismatch", string_0, string_1, string_2, string_3), UiText.Get("App.Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes) ? (-972875680) : (-1020958494)) ^ ((int)num2 * -275383844);
				continue;
			case 0u:
				break;
			case 4u:
				goto IL_0102;
			default:
				return true;
			case 3u:
				return false;
			case 5u:
				return false;
			}
			break;
		}
		goto IL_00c5;
		IL_0102:
		num = ((MessageBox.Show(mainForm, UiText.Format("Message.Dependency.Missing", string_0, string_1, string_3), UiText.Get("App.Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes) ? 1866094268 : 1156328842);
		goto IL_00ca;
	}

	internal static bool smethod_342(ModuleOptionsForm form0_0, string string_0, ExportParameterType enum5_0, bool bool_0)
	{
		string string_1 = default(string);
		int num;
		string string_3 = default(string);
		string string_4 = default(string);
		string string_2 = default(string);
		bool flag2 = default(bool);
		bool flag3;
		uint result9;
		bool flag4;
		ushort result10;
		switch (enum5_0)
		{
		case ExportParameterType.UInt64:
			string_1 = string_0;
			num = 617349255;
			goto IL_002b;
		default:
			goto IL_0113;
		case ExportParameterType.Byte:
			goto IL_0154;
		case ExportParameterType.UInt32:
			goto IL_0235;
		case ExportParameterType.UInt16:
			goto IL_0347;
		case ExportParameterType.AnsiString:
		case ExportParameterType.UnicodeString:
			goto IL_038a;
			IL_002b:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3D90D2E3)) % 24)
				{
				case 23u:
					break;
				case 21u:
				{
					num = (sbyte.TryParse(string_3, out var _) ? (-694853176) : (-1073503255)) ^ (int)(num2 * 371918870);
					continue;
				}
				case 20u:
					num = (int)((num2 * 858045942) ^ 0x3EA9D554);
					continue;
				case 19u:
				{
					num = ((!long.TryParse(string_1, out var _)) ? (-2111857770) : (-1480684005)) ^ (int)(num2 * 169385271);
					continue;
				}
				case 18u:
					goto IL_0113;
				case 17u:
					form0_0.method_0().Parameters.Add(new ExportParameter
					{
						Type = (ExportParameterType)form0_0.comboBox_2.SelectedIndex,
						Value = string_0
					});
					num = 660552184;
					continue;
				case 16u:
					goto IL_0154;
				case 15u:
					goto IL_016b;
				case 14u:
					form0_0.method_0().Parameters = new List<ExportParameter>();
					num = (int)((num2 * 746177784) ^ 0xF0A0ECA);
					continue;
				case 11u:
					goto IL_01d0;
				case 10u:
					num = ((form0_0.method_0().Parameters != null) ? (-322189534) : (-1727077499)) ^ ((int)num2 * -684848276);
					continue;
				case 9u:
					goto IL_0235;
				case 8u:
				{
					num = ((!int.TryParse(string_4, out var _)) ? 1746011596 : 2052809590) ^ ((int)num2 * -790560600);
					continue;
				}
				case 6u:
				{
					num = (short.TryParse(string_2, out var _) ? 1145038720 : 1891523568) ^ (int)(num2 * 1198967497);
					continue;
				}
				case 4u:
					goto IL_02d8;
				case 2u:
				{
					num = ((!char.TryParse(string_0, out var _)) ? (-2054104040) : (-967780434)) ^ (int)(num2 * 1293683084);
					continue;
				}
				case 1u:
					goto IL_0347;
				case 13u:
					goto IL_038a;
				case 0u:
					return false;
				default:
					return true;
				case 5u:
					return false;
				case 7u:
					return false;
				case 12u:
					return false;
				case 22u:
					return false;
				}
				break;
				IL_02d8:
				bool flag = smethod_139(ref string_1, form0_0, string_1);
				num = ((!ulong.TryParse(string_1, flag ? NumberStyles.HexNumber : NumberStyles.None, null, out var _)) ? 990579736 : 528111862);
				continue;
				IL_01d0:
				num = (byte.TryParse(string_3, flag2 ? NumberStyles.HexNumber : NumberStyles.None, null, out var _) ? 528111862 : 936894686);
				continue;
				IL_016b:
				num = (float.TryParse(string_0, out var _) ? 528111862 : 2020286037);
			}
			goto case ExportParameterType.UInt64;
			IL_038a:
			form0_0.dataGridView_0.Rows.Add(null, form0_0.comboBox_2.Items[(int)enum5_0].ToString(), string_0);
			num = ((!bool_0) ? 660552184 : 402604281);
			goto IL_002b;
			IL_0235:
			string_4 = string_0;
			flag3 = smethod_139(ref string_4, form0_0, string_4);
			num = ((!uint.TryParse(string_4, flag3 ? NumberStyles.HexNumber : NumberStyles.None, null, out result9)) ? 1025648467 : 528111862);
			goto IL_002b;
			IL_0154:
			string_3 = string_0;
			flag2 = smethod_139(ref string_3, form0_0, string_3);
			num = 463231825;
			goto IL_002b;
			IL_0347:
			string_2 = string_0;
			flag4 = smethod_139(ref string_2, form0_0, string_2);
			num = (ushort.TryParse(string_2, flag4 ? NumberStyles.HexNumber : NumberStyles.None, null, out result10) ? 528111862 : 1490647589);
			goto IL_002b;
			IL_0113:
			num = 179109175;
			goto IL_002b;
		}
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
		DialogResult dialogResult = MessageBox.Show(mainForm, UiText.Format("Message.Dependency.Decision", string_0, string_3), UiText.Get("App.Title"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
		if (dialogResult == DialogResult.Yes)
		{
			goto IL_00bf;
		}
		goto IL_0147;
		IL_00bf:
		int num = -2077519238;
		goto IL_0102;
		IL_0102:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1204839189)) % 9)
			{
			case 8u:
				MessageBox.Show(mainForm, UiText.Format("Message.Dependency.ExtractManually", string_1), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				num = ((int)num2 * -1180998039) ^ -766772100;
				continue;
			case 7u:
			{
				DependencyInstallerForm form = new DependencyInstallerForm();
				smethod_50(form, string_2, string_1);
				form.ShowDialog();
				num = -1712413616;
				continue;
			}
			case 5u:
				break;
			case 2u:
				Process.Start(string_2);
				num = (int)((num2 * 185510003) ^ 0x1DBAA607);
				continue;
			case 1u:
				num = ((!smethod_272()) ? 510315496 : 33659344) ^ ((int)num2 * -1135787917);
				continue;
			default:
				return;
			case 6u:
				goto IL_0147;
			case 0u:
				return;
			case 3u:
				MessageBox.Show(mainForm, UiText.Get("Message.Dependency.AdminRequired"), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_00bf;
		IL_0147:
		num = ((dialogResult != DialogResult.No) ? (-1900042582) : (-1842604189));
		goto IL_0102;
	}

	internal static void smethod_406(ProcessInspectorForm form4_0)
	{
		form4_0.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		while (true)
		{
			int num = 1492183839;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x63FE30A9)) % 119)
				{
				case 118u:
					form4_0.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
					form4_0.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
					num = (int)(num2 * 1124877414) ^ -1802278058;
					continue;
				case 117u:
					form4_0.button_2.Name = "closeButton";
					num = (int)((num2 * 516890950) ^ 0x52EB762);
					continue;
				case 116u:
					form4_0.groupBox_0.ResumeLayout(performLayout: false);
					num = (int)(num2 * 1800037052) ^ -986107357;
					continue;
				case 115u:
					form4_0.dataGridViewTextBoxColumn_1.Name = "moduleBaseColumn";
					form4_0.dataGridViewTextBoxColumn_1.ReadOnly = true;
					form4_0.dataGridViewTextBoxColumn_1.Width = 120;
					num = (int)(num2 * 678514833) ^ -2021011883;
					continue;
				case 114u:
					form4_0.groupBox_0.Size = new Size(387, 154);
					num = ((int)num2 * -1806196393) ^ -1305373541;
					continue;
				case 113u:
					form4_0.tabPage_1.Controls.Add(form4_0.button_3);
					form4_0.tabPage_1.Controls.Add(form4_0.dataGridView_1);
					num = ((int)num2 * -2053778814) ^ 0x60100D28;
					continue;
				case 112u:
					form4_0.dataGridViewTextBoxColumn_3.Name = "threadIDColumn";
					form4_0.dataGridViewTextBoxColumn_3.ReadOnly = true;
					num = (int)((num2 * 126284135) ^ 0x26FAA06E);
					continue;
				case 111u:
					form4_0.groupBox_0.SuspendLayout();
					num = (int)(num2 * 685889998) ^ -621253256;
					continue;
				case 110u:
					form4_0.SuspendLayout();
					form4_0.button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					num = ((int)num2 * -1222856088) ^ -754095682;
					continue;
				case 109u:
					form4_0.label_0.Location = new Point(47, 21);
					num = ((int)num2 * -1662144353) ^ 0x6B3A0129;
					continue;
				case 108u:
					form4_0.Text = UiText.Get("ProcessInfo.Title");
					form4_0.Load += form4_0.method_8;
					num = ((int)num2 * -1915030955) ^ -1304656414;
					continue;
				case 107u:
					form4_0.button_2.TabIndex = 12;
					num = (int)(num2 * 738674761) ^ -1603169623;
					continue;
				case 106u:
					form4_0.dataGridViewTextBoxColumn_4.Name = "threadStartAddressColumn";
					num = ((int)num2 * -1757421603) ^ 0x37CCD6DB;
					continue;
				case 105u:
					form4_0.button_3.Name = "resumeSuspendButton";
					num = (int)((num2 * 546010240) ^ 0x4D5EB1DE);
					continue;
				case 104u:
					((ISupportInitialize)form4_0.dataGridView_1).BeginInit();
					num = ((int)num2 * -2038056785) ^ -166752477;
					continue;
				case 103u:
					form4_0.dataGridView_0.SelectionChanged += form4_0.method_6;
					num = (int)((num2 * 266197842) ^ 0xBF6A3D6);
					continue;
				case 102u:
					form4_0.button_1.Click += form4_0.method_9;
					num = ((int)num2 * -232926698) ^ 0x7370333D;
					continue;
				case 101u:
					form4_0.pictureBox_0.BackColor = Color.Transparent;
					num = (int)((num2 * 1227468866) ^ 0x5833D78E);
					continue;
				case 100u:
					form4_0.pictureBox_0.Name = "processPictureBox";
					num = (int)(num2 * 1304826556) ^ -356742038;
					continue;
				case 99u:
					form4_0.button_1.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1113096251) ^ -1073347928;
					continue;
				case 97u:
					form4_0.dataGridViewTextBoxColumn_0.ReadOnly = true;
					num = (int)((num2 * 868330073) ^ 0x59D77B0A);
					continue;
				case 96u:
					form4_0.dataGridView_0.Size = new Size(379, 209);
					form4_0.dataGridView_0.TabIndex = 11;
					num = (int)((num2 * 1125691275) ^ 0x7536D43);
					continue;
				case 95u:
					form4_0.dataGridView_1 = new DataGridView();
					num = (int)((num2 * 1573467732) ^ 0x17D5F085);
					continue;
				case 94u:
					form4_0.dataGridView_0.ReadOnly = true;
					form4_0.dataGridView_0.RowHeadersVisible = false;
					form4_0.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					num = (int)((num2 * 635603845) ^ 0x513136A2);
					continue;
				case 93u:
					form4_0.MaximizeBox = false;
					form4_0.MinimizeBox = false;
					num = (int)(num2 * 1332529162) ^ -1781430736;
					continue;
				case 92u:
					form4_0.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
					num = (int)((num2 * 899714683) ^ 0x7653ACA2);
					continue;
				case 91u:
					form4_0.tabPage_1.Size = new Size(379, 240);
					form4_0.tabPage_1.TabIndex = 1;
					num = ((int)num2 * -1276110064) ^ -1088871325;
					continue;
				case 90u:
					form4_0.Controls.Add(form4_0.groupBox_0);
					num = (int)((num2 * 826979221) ^ 0x1D4E7E6C);
					continue;
				case 89u:
					form4_0.dataGridView_0.Location = new Point(0, 0);
					num = ((int)num2 * -115037066) ^ 0xC5D39C5;
					continue;
				case 88u:
					form4_0.tabPage_1.ResumeLayout(performLayout: false);
					((ISupportInitialize)form4_0.dataGridView_1).EndInit();
					num = ((int)num2 * -1077379614) ^ -1113381826;
					continue;
				case 87u:
					form4_0.pictureBox_0.Size = new Size(32, 32);
					num = (int)(num2 * 626272854) ^ -786755609;
					continue;
				case 86u:
					form4_0.button_2.Location = new Point(302, 442);
					num = ((int)num2 * -1118313406) ^ -1736549970;
					continue;
				case 85u:
					((ISupportInitialize)form4_0.pictureBox_0).EndInit();
					num = ((int)num2 * -558872750) ^ -1135206156;
					continue;
				case 84u:
					form4_0.groupBox_0.Name = "processGroupBox";
					num = ((int)num2 * -1149068105) ^ -1061866957;
					continue;
				case 83u:
					form4_0.button_1 = new Button();
					num = (int)((num2 * 1308665203) ^ 0x397F3468);
					continue;
				case 82u:
					form4_0.tabPage_0.TabIndex = 0;
					form4_0.tabPage_0.Text = UiText.Get("ProcessInfo.Modules");
					form4_0.tabPage_0.UseVisualStyleBackColor = true;
					num = ((int)num2 * -704552755) ^ 0xB1B455B;
					continue;
				case 81u:
					form4_0.dataGridView_0.AllowUserToDeleteRows = false;
					num = (int)((num2 * 616231219) ^ 0x68720078);
					continue;
				case 80u:
					form4_0.label_0.Name = "processDetailsLabel";
					form4_0.label_0.Size = new Size(334, 123);
					num = ((int)num2 * -1839246135) ^ -1655881458;
					continue;
				case 79u:
					form4_0.tabControl_0.ResumeLayout(performLayout: false);
					num = (int)(num2 * 5593930) ^ -489349702;
					continue;
				case 78u:
					form4_0.dataGridViewTextBoxColumn_0.Width = 150;
					form4_0.dataGridViewTextBoxColumn_1.HeaderText = UiText.Get("ProcessInfo.ModuleBase");
					num = ((int)num2 * -627271498) ^ -453027333;
					continue;
				case 77u:
					form4_0.pictureBox_0.TabIndex = 4;
					form4_0.pictureBox_0.TabStop = false;
					num = (int)((num2 * 575197394) ^ 0x7C6C653C);
					continue;
				case 76u:
					form4_0.dataGridViewTextBoxColumn_2.Name = "moduleSizeColumn";
					num = (int)(num2 * 1150989671) ^ -984335465;
					continue;
				case 75u:
					form4_0.button_0.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1839120619) ^ -224645727;
					continue;
				case 74u:
					form4_0.dataGridView_1.MultiSelect = false;
					form4_0.dataGridView_1.Name = "threadsDataGridView";
					form4_0.dataGridView_1.ReadOnly = true;
					num = ((int)num2 * -522734500) ^ -1417891544;
					continue;
				case 73u:
					form4_0.dataGridView_0.AllowUserToResizeRows = false;
					form4_0.dataGridView_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					num = (int)(num2 * 1116552455) ^ -1850935632;
					continue;
				case 72u:
					form4_0.button_3.TabIndex = 15;
					form4_0.button_3.Text = UiText.Get("ProcessInfo.Suspend");
					num = ((int)num2 * -2012751643) ^ 0x71E45379;
					continue;
				case 71u:
					form4_0.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					num = ((int)num2 * -916768898) ^ -1675268683;
					continue;
				case 70u:
					form4_0.tabControl_0.Size = new Size(387, 266);
					form4_0.tabControl_0.TabIndex = 15;
					form4_0.tabPage_0.Controls.Add(form4_0.dataGridView_0);
					form4_0.tabPage_0.Controls.Add(form4_0.button_1);
					form4_0.tabPage_0.Location = new Point(4, 22);
					form4_0.tabPage_0.Name = "modulesTabPage";
					form4_0.tabPage_0.Size = new Size(379, 240);
					num = ((int)num2 * -820701765) ^ 0x7900772D;
					continue;
				case 69u:
					form4_0.dataGridView_1.AllowUserToAddRows = false;
					form4_0.dataGridView_1.AllowUserToDeleteRows = false;
					form4_0.dataGridView_1.AllowUserToResizeRows = false;
					form4_0.dataGridView_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					num = (int)(num2 * 161592687) ^ -595772479;
					continue;
				case 68u:
					form4_0.button_1.Location = new Point(279, 215);
					form4_0.button_1.Name = "unloadButton";
					num = ((int)num2 * -1645207230) ^ -137170787;
					continue;
				case 67u:
					form4_0.dataGridView_0.SortCompare += form4_0.method_7;
					num = (int)((num2 * 1330864667) ^ 0x700FD12E);
					continue;
				case 66u:
					form4_0.button_3.Enabled = false;
					form4_0.button_3.Location = new Point(279, 215);
					num = (int)(num2 * 1371478191) ^ -1203268546;
					continue;
				case 65u:
					form4_0.button_2.Size = new Size(97, 22);
					num = ((int)num2 * -1039482067) ^ 0x43F2B95E;
					continue;
				case 63u:
					form4_0.dataGridView_0.Name = "modulesDataGridView";
					num = ((int)num2 * -2067419219) ^ 0x673198DF;
					continue;
				case 62u:
					form4_0.pictureBox_0.Location = new Point(9, 21);
					num = (int)((num2 * 948978901) ^ 0x4D6C8CB7);
					continue;
				case 61u:
					form4_0.timer_0.Interval = 250;
					form4_0.timer_0.Tick += form4_0.method_5;
					num = (int)((num2 * 1569841658) ^ 0x1AF328A8);
					continue;
				case 60u:
					form4_0.button_3.Click += form4_0.method_11;
					num = ((int)num2 * -881506109) ^ 0x476F2135;
					continue;
				case 59u:
					form4_0.tabPage_1.Controls.Add(form4_0.button_4);
					num = (int)(num2 * 1988707896) ^ -518722822;
					continue;
				case 58u:
					form4_0.dataGridViewTextBoxColumn_4.ReadOnly = true;
					form4_0.dataGridViewTextBoxColumn_5.HeaderText = UiText.Get("ProcessInfo.Priority");
					form4_0.dataGridViewTextBoxColumn_5.Name = "threadStateColumn";
					num = (int)((num2 * 999546692) ^ 0x26FBE465);
					continue;
				case 57u:
					form4_0.groupBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
					form4_0.groupBox_0.Controls.Add(form4_0.label_0);
					form4_0.groupBox_0.Controls.Add(form4_0.pictureBox_0);
					num = (int)(num2 * 1478561824) ^ -1687204159;
					continue;
				case 56u:
					form4_0.button_0.Click += form4_0.method_4;
					form4_0.dataGridView_0.AllowUserToAddRows = false;
					num = ((int)num2 * -189976035) ^ -1051190262;
					continue;
				case 55u:
					form4_0.tabPage_1.SuspendLayout();
					num = (int)((num2 * 418906612) ^ 0x4E0FBAC7);
					continue;
				case 54u:
					form4_0.dataGridViewTextBoxColumn_2.ReadOnly = true;
					num = (int)((num2 * 9393747) ^ 0x66D13BBA);
					continue;
				case 53u:
					form4_0.groupBox_0.TabStop = false;
					num = ((int)num2 * -950236462) ^ 0x7833970B;
					continue;
				case 52u:
					form4_0.tabControl_0 = new ModernTabControl();
					form4_0.tabPage_0 = new TabPage();
					num = (int)((num2 * 1578810192) ^ 0x681D1D9E);
					continue;
				case 51u:
					form4_0.button_0 = new Button();
					num = (int)(num2 * 1407908096) ^ -1027878506;
					continue;
				case 50u:
					form4_0.dataGridViewTextBoxColumn_2.HeaderText = UiText.Get("ProcessInfo.ModuleSize");
					num = (int)(num2 * 1672614920) ^ -1298649630;
					continue;
				case 49u:
					form4_0.button_1.Size = new Size(97, 22);
					form4_0.button_1.TabIndex = 14;
					form4_0.button_1.Text = UiText.Get("ProcessInfo.UnloadModule");
					num = (int)((num2 * 1071731497) ^ 0x51E9761E);
					continue;
				case 48u:
					form4_0.Controls.Add(form4_0.button_2);
					num = ((int)num2 * -704493046) ^ -1660156403;
					continue;
				case 47u:
					form4_0.button_3.UseVisualStyleBackColor = true;
					num = (int)(num2 * 677183425) ^ -971028231;
					continue;
				case 46u:
					form4_0.button_0.TabIndex = 13;
					form4_0.button_0.Text = UiText.Get("ProcessInfo.KillProcess");
					num = ((int)num2 * -1896737684) ^ -702008778;
					continue;
				case 45u:
					form4_0.tabPage_1.Text = UiText.Get("ProcessInfo.Threads");
					form4_0.tabPage_1.UseVisualStyleBackColor = true;
					num = (int)(num2 * 1425762367) ^ -422594718;
					continue;
				case 44u:
					form4_0.dataGridView_0.BackgroundColor = Color.White;
					num = ((int)num2 * -784030222) ^ 0x3BB1010F;
					continue;
				case 43u:
					form4_0.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					form4_0.dataGridViewTextBoxColumn_4.HeaderText = UiText.Get("ProcessInfo.StartAddress");
					num = ((int)num2 * -391774442) ^ -214321483;
					continue;
				case 42u:
					((ISupportInitialize)form4_0.pictureBox_0).BeginInit();
					num = (int)(num2 * 306477978) ^ -921963825;
					continue;
				case 41u:
					form4_0.button_4.Size = new Size(97, 22);
					num = ((int)num2 * -1678307562) ^ -2037180615;
					continue;
				case 40u:
					form4_0.Name = "ProcessInfoForm";
					num = (int)(num2 * 2021781618) ^ -942642779;
					continue;
				case 39u:
					form4_0.label_0 = new System.Windows.Forms.Label();
					form4_0.pictureBox_0 = new PictureBox();
					form4_0.timer_0 = new System.Windows.Forms.Timer(form4_0.icontainer_0);
					num = ((int)num2 * -443293442) ^ -1815871773;
					continue;
				case 38u:
					form4_0.button_3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					num = (int)((num2 * 425949892) ^ 0x46FC13EE);
					continue;
				case 37u:
					((ISupportInitialize)form4_0.dataGridView_0).EndInit();
					num = (int)(num2 * 658783111) ^ -691368026;
					continue;
				case 36u:
					form4_0.button_4.Location = new Point(176, 215);
					num = ((int)num2 * -180340077) ^ 0x5B988496;
					continue;
				case 35u:
					form4_0.dataGridView_1.RowHeadersVisible = false;
					num = (int)(num2 * 1560831611) ^ -1030759883;
					continue;
				case 34u:
					form4_0.label_0.Text = UiText.Get("ProcessInfo.Process");
					num = ((int)num2 * -279299136) ^ 0x1365B4B7;
					continue;
				case 33u:
					form4_0.button_1.Enabled = false;
					num = (int)(num2 * 1612143251) ^ -1018879073;
					continue;
				case 32u:
					componentResourceManager = new ComponentResourceManager(typeof(ProcessInspectorForm));
					num = ((int)num2 * -1936636729) ^ -1851659438;
					continue;
				case 31u:
					form4_0.tabPage_1 = new TabPage();
					num = (int)(num2 * 646911602) ^ -12611303;
					continue;
				case 30u:
					form4_0.dataGridView_1.Location = new Point(0, 0);
					num = (int)(num2 * 1053164096) ^ -928959558;
					continue;
				case 29u:
					form4_0.button_4.Text = UiText.Get("ProcessInfo.KillThread");
					form4_0.button_4.UseVisualStyleBackColor = true;
					form4_0.button_4.Click += form4_0.method_12;
					num = (int)(num2 * 1326306197) ^ -2098700400;
					continue;
				case 28u:
					form4_0.dataGridViewTextBoxColumn_5.ReadOnly = true;
					num = (int)((num2 * 2103636455) ^ 0x4FBE1031);
					continue;
				case 27u:
					form4_0.button_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					form4_0.button_0.Location = new Point(199, 442);
					form4_0.button_0.Name = "killButton";
					form4_0.button_0.Size = new Size(97, 22);
					num = ((int)num2 * -582996159) ^ -1625269320;
					continue;
				case 26u:
					form4_0.button_3.Size = new Size(97, 22);
					num = (int)(num2 * 1400608749) ^ -1236526714;
					continue;
				case 25u:
					form4_0.button_3 = new Button();
					form4_0.button_4 = new Button();
					((ISupportInitialize)form4_0.dataGridView_0).BeginInit();
					num = ((int)num2 * -1143745786) ^ 0x568BEE15;
					continue;
				case 24u:
					form4_0.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
					form4_0.groupBox_0 = new ModernGroupBox();
					num = (int)(num2 * 1644058102) ^ -726715906;
					continue;
				case 23u:
					form4_0.tabPage_1.Location = new Point(4, 22);
					form4_0.tabPage_1.Name = "threadsTabPage";
					num = ((int)num2 * -296412965) ^ 0x19EDBF27;
					continue;
				case 22u:
					form4_0.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
					form4_0.dataGridView_0.Columns.AddRange(form4_0.dataGridViewTextBoxColumn_0, form4_0.dataGridViewTextBoxColumn_1, form4_0.dataGridViewTextBoxColumn_2);
					num = ((int)num2 * -320111316) ^ -757753653;
					continue;
				case 21u:
					form4_0.button_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					num = ((int)num2 * -2038913893) ^ -324222483;
					continue;
				case 20u:
					form4_0.dataGridView_1.BackgroundColor = Color.White;
					form4_0.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
					form4_0.dataGridView_1.Columns.AddRange(form4_0.dataGridViewTextBoxColumn_3, form4_0.dataGridViewTextBoxColumn_4, form4_0.dataGridViewTextBoxColumn_5);
					num = (int)(num2 * 95765469) ^ -1558921475;
					continue;
				case 19u:
					form4_0.dataGridView_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					form4_0.dataGridView_1.Size = new Size(379, 209);
					form4_0.dataGridView_1.TabIndex = 12;
					form4_0.dataGridView_1.SelectionChanged += form4_0.method_10;
					form4_0.dataGridView_1.SortCompare += form4_0.method_7;
					form4_0.dataGridViewTextBoxColumn_3.HeaderText = UiText.Get("ProcessInfo.ThreadId");
					num = ((int)num2 * -2136049403) ^ -1524411868;
					continue;
				case 18u:
					form4_0.groupBox_0.TabIndex = 10;
					num = (int)(num2 * 1544125282) ^ -1573801816;
					continue;
				case 17u:
					form4_0.tabControl_0.Name = "mainTabControl";
					form4_0.tabControl_0.SelectedIndex = 0;
					num = (int)((num2 * 1052512932) ^ 0x20E9DB51);
					continue;
				case 16u:
					form4_0.dataGridViewTextBoxColumn_0.HeaderText = UiText.Get("ProcessInfo.ModuleName");
					form4_0.dataGridViewTextBoxColumn_0.Name = "moduleNameColumn";
					num = (int)(num2 * 144185050) ^ -511044056;
					continue;
				case 15u:
					form4_0.label_0.TabIndex = 5;
					num = ((int)num2 * -568932589) ^ -1728036158;
					continue;
				case 14u:
					form4_0.AutoScaleDimensions = new SizeF(96f, 96f);
					form4_0.AutoScaleMode = AutoScaleMode.Dpi;
					form4_0.ClientSize = new Size(410, 469);
					form4_0.Controls.Add(form4_0.tabControl_0);
					form4_0.Controls.Add(form4_0.button_0);
					num = (int)((num2 * 195882119) ^ 0x10519D78);
					continue;
				case 13u:
					form4_0.tabControl_0.SuspendLayout();
					form4_0.tabPage_0.SuspendLayout();
					num = ((int)num2 * -1866918174) ^ 0x817EFF8;
					continue;
				case 12u:
					form4_0.groupBox_0.Text = UiText.Get("ProcessInfo.Process");
					form4_0.label_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
					num = ((int)num2 * -2011165707) ^ -338311936;
					continue;
				case 11u:
					form4_0.button_2.Text = UiText.Get("Common.Close");
					num = ((int)num2 * -940598734) ^ -1436476336;
					continue;
				case 10u:
					form4_0.FormBorderStyle = FormBorderStyle.SizableToolWindow;
					form4_0.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					num = ((int)num2 * -1346165877) ^ 0x6F04C688;
					continue;
				case 9u:
					form4_0.button_4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					form4_0.button_4.Enabled = false;
					num = ((int)num2 * -453855962) ^ -2054557291;
					continue;
				case 8u:
					form4_0.button_4.TabIndex = 16;
					num = ((int)num2 * -966712865) ^ 0x282A72F8;
					continue;
				case 7u:
					form4_0.dataGridView_0.MultiSelect = false;
					num = (int)((num2 * 2027399700) ^ 0x36FFFB7);
					continue;
				case 6u:
					form4_0.button_2.UseVisualStyleBackColor = true;
					form4_0.button_2.Click += form4_0.method_3;
					form4_0.tabControl_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					form4_0.tabControl_0.Controls.Add(form4_0.tabPage_0);
					form4_0.tabControl_0.Controls.Add(form4_0.tabPage_1);
					form4_0.tabControl_0.Location = new Point(12, 172);
					num = ((int)num2 * -1287982852) ^ -1804477627;
					continue;
				case 5u:
					form4_0.dataGridView_0 = new DataGridView();
					form4_0.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
					form4_0.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
					num = ((int)num2 * -1785432504) ^ -746671375;
					continue;
				case 4u:
					form4_0.groupBox_0.Location = new Point(12, 12);
					num = (int)((num2 * 830681275) ^ 0x5BE229F0);
					continue;
				case 3u:
					form4_0.button_4.Name = "killThreadButton";
					num = ((int)num2 * -90509380) ^ -1015389013;
					continue;
				case 2u:
					form4_0.tabPage_0.ResumeLayout(performLayout: false);
					num = (int)((num2 * 2037820977) ^ 0x579FF33);
					continue;
				case 1u:
					form4_0.button_2 = new Button();
					num = (int)((num2 * 1492214568) ^ 0x6B4DBFAC);
					continue;
				case 0u:
					form4_0.Font = new Font("Segoe UI", 8.25f);
					num = (int)((num2 * 648637052) ^ 0x6678435D);
					continue;
				case 64u:
					break;
				default:
					form4_0.ResumeLayout(performLayout: false);
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_408()
	{
		if (!smethod_193(out var string_))
		{
			goto IL_0009;
		}
		goto IL_002d;
		IL_0009:
		int num = -1388352169;
		goto IL_000e;
		IL_000e:
		switch ((uint)(num ^ -2075905034) % 4u)
		{
		case 2u:
			break;
		default:
			return;
		case 3u:
			goto IL_002d;
		case 0u:
			return;
		case 1u:
			return;
		}
		goto IL_0009;
		IL_002d:
		MessageBox.Show(UiText.Format("Message.NewVersion", string_), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		num = -1339150522;
		goto IL_000e;
	}

	internal static void smethod_421(SettingsForm gform2_0)
	{
		ScramblePreset @enum = ApplicationSettings.Current.Options.Scramble.Detect();
		while (true)
		{
			int num = 1333184472;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xB247207)) % 9)
				{
				case 6u:
					num = ((@enum == ScramblePreset.Custom) ? 1483050419 : 371770663);
					continue;
				case 5u:
					num = ((@enum == ScramblePreset.None) ? (-695007426) : (-1407516889)) ^ (int)(num2 * 1622403653);
					continue;
				case 4u:
					gform2_0.comboBox_1.SelectedIndex = (int)(@enum - 1);
					num = 2003090427;
					continue;
				case 1u:
					gform2_0.comboBox_1.SelectedIndex = gform2_0.comboBox_1.Items.Count - 1;
					num = ((int)num2 * -1136136869) ^ -1030355687;
					continue;
				case 0u:
					gform2_0.comboBox_1.SelectedIndex = 0;
					num = (int)((num2 * 1754092774) ^ 0x512C2D35);
					continue;
				default:
					return;
				case 7u:
					break;
				case 2u:
					return;
				case 3u:
					return;
				case 8u:
					return;
				}
				break;
			}
		}
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
