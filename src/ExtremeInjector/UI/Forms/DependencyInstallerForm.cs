using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mime;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

public sealed class DependencyInstallerForm : Form
{
	internal bool flag;

	internal string text;

	internal string text2;

	internal string text3;

	internal CookieAwareWebClient cookieAwareWebClient = new CookieAwareWebClient();

	internal IContainer container = null;

	internal Label label;

	internal ProgressBar progressBar;

	public DependencyInstallerForm()
	{
		InitializeModernComponents();
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		ShowInTaskbar = false;
		SizeGripStyle = SizeGripStyle.Hide;
		cookieAwareWebClient.DownloadDataCompleted += OnDownloadCompleted;
		cookieAwareWebClient.DownloadProgressChanged += OnDownloadProgressChanged;
	}

	private void InitializeModernComponents()
	{
		SuspendLayout();
		container = new Container();
		label = new Label
		{
			AutoEllipsis = true,
			Dock = DockStyle.Fill,
			ForeColor = ModernUi.TextSecondary,
			Name = "downloadStatusLabel",
			Text = UiText.Get("Dependency.Connecting"),
			TextAlign = ContentAlignment.MiddleLeft
		};
		progressBar = new ProgressBar
		{
			Dock = DockStyle.Fill,
			Name = "downloadProgressBar",
			Style = ProgressBarStyle.Continuous
		};

		var root = new TableLayoutPanel
		{
			BackColor = ModernUi.Window,
			ColumnCount = 1,
			Dock = DockStyle.Fill,
			Margin = Padding.Empty,
			Padding = new Padding(18, 14, 18, 16),
			RowCount = 2
		};
		root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		root.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
		root.RowStyles.Add(new RowStyle(SizeType.Absolute, 24f));
		root.Controls.Add(label, 0, 0);
		root.Controls.Add(progressBar, 0, 1);

		AutoScaleDimensions = new SizeF(96f, 96f);
		AutoScaleMode = AutoScaleMode.Dpi;
		BackColor = ModernUi.Window;
		ClientSize = new Size(520, 86);
		Controls.Add(root);
		Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point);
		Icon = new ComponentResourceManager(typeof(DependencyInstallerForm)).GetObject("$this.Icon") as Icon;
		Name = "DependencyInstallerForm";
		StartPosition = FormStartPosition.CenterParent;
		Text = UiText.Get("Dependency.Title");
		FormClosing += OnFormClosing;
		Load += OnFormLoad;
		ResumeLayout(performLayout: true);
	}

	internal void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
		base.Invoke(new MethodInvoker(delegate
		{
			this.progressBar.Value = e.ProgressPercentage;
			string fileName = null;
			string disposition = this.cookieAwareWebClient.ResponseHeaders?["Content-Disposition"];
			if (!string.IsNullOrWhiteSpace(disposition))
			{
				try
				{
					fileName = new ContentDisposition(disposition).FileName;
				}
				catch (FormatException)
				{
					// A malformed optional header must not abort an otherwise valid download.
				}
			}
			if (string.IsNullOrEmpty(fileName))
			{
				fileName = this.text3;
			}
			if (string.IsNullOrEmpty(fileName))
			{
				fileName = Uri.UnescapeDataString(Path.GetFileName(new Uri(this.text).AbsolutePath));
			}
			this.label.Text = UiText.Format(
				"Dependency.Downloading",
				fileName,
				RecoveredRuntime.FormatByteSize(e.BytesReceived),
				RecoveredRuntime.FormatByteSize(e.TotalBytesToReceive));
		}));
	}

	internal void OnDownloadCompleted(object sender, DownloadDataCompletedEventArgs e)
	{
		base.Invoke(new MethodInvoker(delegate
		{
			if (e.Cancelled)
			{
				Close();
				return;
			}

			if (e.Error != null)
			{
				MessageBox.Show(this, UiText.Format("Message.Dependency.DownloadFailed", e.Error.Message), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.Close();
				return;
			}

			this.progressBar.Value = 100;
			ThreadPool.QueueUserWorkItem(delegate
			{
				this.InstallDownloadedDependency(e.Result);
			});
		}));
	}

	private void InstallDownloadedDependency(byte[] downloadedData)
	{
		bool succeeded = true;
		if (!this.flag)
		{
			this.Invoke(new MethodInvoker(delegate
			{
				this.label.Text = UiText.Get("Dependency.Extracting");
			}));
			try
			{
				SafeZipExtractor.Extract(downloadedData, this.text2);
			}
			catch (Exception ex)
			{
				ShowMessage(UiText.Format("Message.Dependency.ExtractFailed", ex.Message), MessageBoxIcon.Exclamation);
				succeeded = false;
			}
		}
		else
		{
			this.Invoke(new MethodInvoker(delegate
			{
				this.label.Text = UiText.Format("Dependency.Installing", this.text3);
			}));
			try
			{
				string temporaryDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
				Directory.CreateDirectory(temporaryDirectory);
				string installerPath = Path.Combine(temporaryDirectory, this.text3);
				File.WriteAllBytes(installerPath, downloadedData);
				Process process = Process.Start(installerPath);
				if (process != null)
				{
					process.WaitForExit();
					if (process.ExitCode != 0)
					{
						throw new InvalidOperationException(UiText.Format("Message.Dependency.SetupExitCode", process.ExitCode));
					}
					Thread.Sleep(100);
					File.Delete(installerPath);
				}
			}
			catch (Exception ex)
			{
				ShowMessage(UiText.Format("Message.Dependency.SetupFailed", ex.Message), MessageBoxIcon.Exclamation);
				succeeded = false;
			}
		}

		if (succeeded)
		{
			ShowMessage(UiText.Get("Message.Dependency.Completed"), MessageBoxIcon.Information);
		}
		this.Invoke(new MethodInvoker(this.Close));
	}

	private void ShowMessage(string message, MessageBoxIcon icon)
	{
		if (IsDisposed)
		{
			return;
		}

		Invoke(new MethodInvoker(() =>
			MessageBox.Show(this, message, UiText.Get("App.Title"), MessageBoxButtons.OK, icon)));
	}

	internal void OnFormLoad(object sender, EventArgs e)
	{
		if (!Uri.TryCreate(this.text, UriKind.Absolute, out _))
		{
			MessageBox.Show(this, UiText.Get("Message.Dependency.InvalidAddress"), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			Close();
			return;
		}

		ThreadPool.QueueUserWorkItem(delegate(object instance)
		{
			if (this.flag)
			{
				bool downloadStarted = false;
				try
				{
					string address = Regex.Replace(
						this.text,
						@"/details\.aspx",
						"/confirmation.aspx",
						RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
					string downloadPage = this.cookieAwareWebClient.DownloadString(address);
					MatchCollection matches = Regex.Matches(
						downloadPage,
						@"href\s*=\s*[""'](?<url>https?://[^""']+)[""']",
						RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
					foreach (Match match in matches)
					{
						string value = WebUtility.HtmlDecode(match.Groups["url"].Value);
						if (value.IndexOf(this.text3, StringComparison.OrdinalIgnoreCase) != -1 &&
							Uri.TryCreate(value, UriKind.Absolute, out Uri downloadUri))
						{
							downloadStarted = true;
							this.cookieAwareWebClient.DownloadDataAsync(downloadUri);
							break;
						}
					}
				}
				catch
				{
				}
				if (!downloadStarted)
				{
					ShowMessage(UiText.Format("Message.Dependency.ManualInstall", this.text3), MessageBoxIcon.Information);
					try
					{
						Process.Start(this.text);
					}
					finally
					{
						this.Invoke(new MethodInvoker(this.Close));
					}
					return;
				}
			}
			else
			{
				this.cookieAwareWebClient.DownloadDataAsync(new Uri(this.text));
			}
		});
	}

	internal void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		cookieAwareWebClient.CancelAsync();
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
