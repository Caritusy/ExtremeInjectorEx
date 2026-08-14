using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

public sealed class AboutForm : Form
{
	internal IContainer container;
	internal Panel panel;
	internal Label label;
	internal Label label2;
	internal Label label3;
	internal Label label4;
	internal PictureBox pictureBox;
	internal LinkLabel linkLabel;
	internal Label label5;

	internal Button closeButton;

	public AboutForm()
	{
		InitializeModernComponents();
		ApplyLocalizedText();
		Version version = Assembly.GetExecutingAssembly().GetName().Version;
		label.Text = string.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Build);
	}

	private void InitializeModernComponents()
	{
		container = new Container();
		panel = new Panel();
		label = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		pictureBox = new PictureBox();
		linkLabel = new LinkLabel();
		label5 = new Label();
		closeButton = new Button();

		SuspendLayout();
		((ISupportInitialize)pictureBox).BeginInit();

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

		panel.AutoSize = true;
		panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		panel.BackColor = ModernUi.Surface;
		panel.Dock = DockStyle.Fill;
		panel.Margin = Padding.Empty;
		panel.Padding = new Padding(22, 18, 22, 16);

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
		pictureBox.BackgroundImage = resources.GetObject("logoPictureBox.BackgroundImage") as Image;
		pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
		pictureBox.Margin = new Padding(0, 1, 12, 0);
		pictureBox.MinimumSize = new Size(48, 48);
		pictureBox.Name = "logoPictureBox";
		pictureBox.Size = new Size(48, 48);
		pictureBox.TabStop = false;

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

		label2.AutoSize = true;
		label2.Font = new Font("Segoe UI Semibold", 17.5f, FontStyle.Bold, GraphicsUnit.Point);
		label2.ForeColor = ModernUi.TextPrimary;
		label2.Margin = Padding.Empty;
		label2.Name = "productNameLabel";
		label2.Text = UiText.Get("About.Product");

		label.AutoSize = true;
		label.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular, GraphicsUnit.Point);
		label.ForeColor = ModernUi.TextSecondary;
		label.Margin = new Padding(1, 4, 0, 0);
		label.Name = "versionLabel";

		label3.AutoSize = true;
		label3.Font = new Font("Segoe UI Semibold", 8.5f, FontStyle.Bold, GraphicsUnit.Point);
		label3.ForeColor = ModernUi.TextPrimary;
		label3.Margin = new Padding(1, 6, 0, 0);
		label3.Name = "initialsLabel";
		label3.Text = UiText.Get("About.Initials");

		identityLayout.Controls.Add(label2, 0, 0);
		identityLayout.Controls.Add(label, 0, 1);
		identityLayout.Controls.Add(label3, 0, 2);
		headerLayout.Controls.Add(pictureBox, 0, 0);
		headerLayout.Controls.Add(identityLayout, 1, 0);
		panel.Controls.Add(headerLayout);

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

		label4.AutoSize = true;
		label4.Dock = DockStyle.Top;
		label4.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		label4.ForeColor = ModernUi.TextPrimary;
		label4.Margin = Padding.Empty;
		label4.Name = "originalCreditLabel";
		label4.Text = UiText.Get("About.OriginalCredit");

		label5.AutoSize = true;
		label5.Dock = DockStyle.Top;
		label5.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		label5.ForeColor = ModernUi.TextPrimary;
		label5.Margin = new Padding(0, 8, 0, 0);
		label5.Name = "exCreditLabel";
		label5.Text = UiText.Get("About.MaintainerCredit");

		Color accent = ModernUi.NormalizeAccent(ApplicationSettings.Current.Options.BackgroundColor1);
		linkLabel.ActiveLinkColor = ModernUi.Darken(accent, 0.18f);
		linkLabel.AutoSize = true;
		linkLabel.LinkColor = accent;
		linkLabel.Anchor = AnchorStyles.Left;
		linkLabel.Margin = Padding.Empty;
		linkLabel.Name = "projectLinkLabel";
		linkLabel.Text = UiText.Get("About.ProjectLink");
		linkLabel.VisitedLinkColor = accent;
		linkLabel.LinkClicked += OnProjectLinkClicked;

		creditsLayout.Controls.Add(label4, 0, 0);
		creditsLayout.Controls.Add(label5, 0, 1);

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
		footerLayout.Controls.Add(linkLabel, 0, 0);
		footerLayout.Controls.Add(closeButton, 1, 0);

		rootLayout.Controls.Add(panel, 0, 0);
		rootLayout.Controls.Add(creditsLayout, 0, 1);
		rootLayout.Controls.Add(footerLayout, 0, 2);
		Controls.Add(rootLayout);
		AcceptButton = closeButton;
		CancelButton = closeButton;

		((ISupportInitialize)pictureBox).EndInit();
		ResumeLayout(performLayout: true);
	}

	private void ApplyLocalizedText()
	{
		Text = UiText.Get("About.Title");
		label2.Text = UiText.Get("About.Product");
		label3.Text = UiText.Get("About.Initials");
		label4.Text = UiText.Get("About.OriginalCredit");
		label5.Text = UiText.Get("About.MaintainerCredit");
		linkLabel.Text = UiText.Get("About.ProjectLink");
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
			container?.Dispose();
		}

		base.Dispose(disposing);
	}
}
