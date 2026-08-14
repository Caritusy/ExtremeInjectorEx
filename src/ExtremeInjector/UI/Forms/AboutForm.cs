using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

public sealed class AboutForm : Form
{
	internal IContainer icontainer_0;
	internal Panel panel_0;
	internal Label label_0;
	internal Label label_1;
	internal Label label_2;
	internal Label label_3;
	internal PictureBox pictureBox_0;
	internal LinkLabel linkLabel_0;
	internal Label label_4;

	internal Button closeButton;

	public AboutForm()
	{
		InitializeModernComponents();
		ApplyLocalizedText();
		Version version = Assembly.GetExecutingAssembly().GetName().Version;
		label_0.Text = string.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Build);
	}

	private void InitializeModernComponents()
	{
		icontainer_0 = new Container();
		panel_0 = new Panel();
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		pictureBox_0 = new PictureBox();
		linkLabel_0 = new LinkLabel();
		label_4 = new Label();
		closeButton = new Button();

		SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();

		AutoScaleDimensions = new SizeF(96f, 96f);
		AutoScaleMode = AutoScaleMode.Dpi;
		BackColor = ModernUi.Window;
		ClientSize = new Size(390, 225);
		Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		MinimumSize = new Size(390, 225);
		Name = "AboutForm";
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterParent;
		Text = UiText.Get("About.Title");

		var rootLayout = new TableLayoutPanel
		{
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = Padding.Empty,
			RowCount = 3
		};
		rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		rootLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		rootLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

		panel_0.AutoSize = true;
		panel_0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		panel_0.BackColor = ModernUi.Surface;
		panel_0.Dock = DockStyle.Fill;
		panel_0.Margin = Padding.Empty;
		panel_0.Padding = new Padding(22, 18, 22, 16);

		var headerLayout = new TableLayoutPanel
		{
			AutoSize = true,
			BackColor = ModernUi.Surface,
			ColumnCount = 2,
			Dock = DockStyle.Top,
			Margin = Padding.Empty,
			RowCount = 1
		};
		headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60f));
		headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));

		var resources = new ComponentResourceManager(typeof(AboutForm));
		pictureBox_0.BackgroundImage = resources.GetObject("logoPictureBox.BackgroundImage") as Image;
		pictureBox_0.BackgroundImageLayout = ImageLayout.Zoom;
		pictureBox_0.Margin = new Padding(0, 1, 12, 0);
		pictureBox_0.MinimumSize = new Size(48, 48);
		pictureBox_0.Name = "logoPictureBox";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.TabStop = false;

		var identityLayout = new TableLayoutPanel
		{
			AutoSize = true,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			RowCount = 3
		};
		identityLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		identityLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		identityLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		identityLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

		label_1.AutoSize = true;
		label_1.Font = new Font("Segoe UI Semibold", 17.5f, FontStyle.Bold, GraphicsUnit.Point);
		label_1.ForeColor = ModernUi.TextPrimary;
		label_1.Margin = Padding.Empty;
		label_1.Name = "productNameLabel";
		label_1.Text = UiText.Get("About.Product");

		label_0.AutoSize = true;
		label_0.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular, GraphicsUnit.Point);
		label_0.ForeColor = ModernUi.TextSecondary;
		label_0.Margin = new Padding(1, 4, 0, 0);
		label_0.Name = "versionLabel";

		label_2.AutoSize = true;
		label_2.Font = new Font("Segoe UI Semibold", 8.5f, FontStyle.Bold, GraphicsUnit.Point);
		label_2.ForeColor = ModernUi.TextPrimary;
		label_2.Margin = new Padding(1, 6, 0, 0);
		label_2.Name = "initialsLabel";
		label_2.Text = UiText.Get("About.Initials");

		identityLayout.Controls.Add(label_1, 0, 0);
		identityLayout.Controls.Add(label_0, 0, 1);
		identityLayout.Controls.Add(label_2, 0, 2);
		headerLayout.Controls.Add(pictureBox_0, 0, 0);
		headerLayout.Controls.Add(identityLayout, 1, 0);
		panel_0.Controls.Add(headerLayout);

		var creditsLayout = new TableLayoutPanel
		{
			AutoSize = true,
			ColumnCount = 1,
			Dock = DockStyle.Top,
			Margin = Padding.Empty,
			Padding = new Padding(22, 14, 22, 10),
			RowCount = 2
		};
		creditsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		creditsLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		creditsLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

		label_3.AutoSize = true;
		label_3.Dock = DockStyle.Top;
		label_3.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		label_3.ForeColor = ModernUi.TextPrimary;
		label_3.Margin = Padding.Empty;
		label_3.Name = "originalCreditLabel";
		label_3.Text = UiText.Get("About.OriginalCredit");

		label_4.AutoSize = true;
		label_4.Dock = DockStyle.Top;
		label_4.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		label_4.ForeColor = ModernUi.TextPrimary;
		label_4.Margin = new Padding(0, 8, 0, 0);
		label_4.Name = "exCreditLabel";
		label_4.Text = UiText.Get("About.MaintainerCredit");

		Color accent = ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1);
		linkLabel_0.ActiveLinkColor = ModernUi.Darken(accent, 0.18f);
		linkLabel_0.AutoSize = true;
		linkLabel_0.LinkColor = accent;
		linkLabel_0.Anchor = AnchorStyles.Left;
		linkLabel_0.Margin = Padding.Empty;
		linkLabel_0.Name = "projectLinkLabel";
		linkLabel_0.Text = UiText.Get("About.ProjectLink");
		linkLabel_0.VisitedLinkColor = accent;
		linkLabel_0.LinkClicked += OnProjectLinkClicked;

		creditsLayout.Controls.Add(label_3, 0, 0);
		creditsLayout.Controls.Add(label_4, 0, 1);

		var footerLayout = new TableLayoutPanel
		{
			AutoSize = true,
			BackColor = ModernUi.Window,
			ColumnCount = 2,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(22, 0, 22, 16),
			RowCount = 1
		};
		footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		footerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
		footerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		closeButton.DialogResult = DialogResult.OK;
		closeButton.Margin = Padding.Empty;
		closeButton.MinimumSize = new Size(74, 30);
		closeButton.Name = "closeButton";
		closeButton.Text = UiText.Get("Common.Close");
		ModernUi.StylePrimaryButton(closeButton, accent, ModernUi.Darken(accent, 0.08f));
		footerLayout.Controls.Add(linkLabel_0, 0, 0);
		footerLayout.Controls.Add(closeButton, 1, 0);

		rootLayout.Controls.Add(panel_0, 0, 0);
		rootLayout.Controls.Add(creditsLayout, 0, 1);
		rootLayout.Controls.Add(footerLayout, 0, 2);
		Controls.Add(rootLayout);
		AcceptButton = closeButton;
		CancelButton = closeButton;

		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: true);
	}

	private void ApplyLocalizedText()
	{
		Text = UiText.Get("About.Title");
		label_1.Text = UiText.Get("About.Product");
		label_2.Text = UiText.Get("About.Initials");
		label_3.Text = UiText.Get("About.OriginalCredit");
		label_4.Text = UiText.Get("About.MaintainerCredit");
		linkLabel_0.Text = UiText.Get("About.ProjectLink");
		closeButton.Text = UiText.Get("Common.Close");
	}

	// 打开项目主页，系统浏览器启动失败时保持关于窗口可用。
	internal void OnProjectLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "https://github.com/Caritusy/ExtremeInjectorEx",
				UseShellExecute = true
			});
		}
		catch
		{
		}
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
