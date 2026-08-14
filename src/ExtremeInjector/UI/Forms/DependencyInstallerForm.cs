using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mime;
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
		RecoveredRuntime.InitializeDependencyInstallerForm(this);
		ModernUi.ApplyLegacyFormTheme(this);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		ShowInTaskbar = false;
		SizeGripStyle = SizeGripStyle.Hide;
		cookieAwareWebClient.DownloadDataCompleted += OnDownloadCompleted;
		cookieAwareWebClient.DownloadProgressChanged += OnDownloadProgressChanged;
	}

	internal void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
		base.Invoke(new MethodInvoker(delegate
		{
			this.progressBar.Value = e.ProgressPercentage;
			string text = null;
			if (this.cookieAwareWebClient.ResponseHeaders[EncodedStringTable.DecodeString(3814)] != null)
			{
				text = new ContentDisposition(this.cookieAwareWebClient.ResponseHeaders[EncodedStringTable.DecodeString(3814)]).FileName;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = this.text3;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = Uri.UnescapeDataString(Path.GetFileName(new Uri(this.text).AbsolutePath));
			}
			this.label.Text = string.Concat(new string[]
			{
				EncodedStringTable.DecodeString(3843),
				text,
				EncodedStringTable.DecodeString(3860),
				RecoveredRuntime.FormatByteSize(e.BytesReceived),
				EncodedStringTable.DecodeString(3869),
				RecoveredRuntime.FormatByteSize(e.TotalBytesToReceive),
				EncodedStringTable.DecodeString(3874)
			});
		}));
	}

	internal void OnDownloadCompleted(object sender, DownloadDataCompletedEventArgs e)
	{
		base.Invoke(new MethodInvoker(delegate
		{
			if (e.Error != null)
			{
				MessageBox.Show(this, EncodedStringTable.DecodeString(3879) + e.Error.Message, EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
				this.label.Text = EncodedStringTable.DecodeString(1869);
			}));
			try
			{
				SafeZipExtractor.Extract(downloadedData, this.text2);
			}
			catch (Exception ex)
			{
				MessageBox.Show(EncodedStringTable.DecodeString(4029) + ex.Message, EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				succeeded = false;
			}
		}
		else
		{
			this.Invoke(new MethodInvoker(delegate
			{
				this.label.Text = EncodedStringTable.DecodeString(1847) + this.text3 + EncodedStringTable.DecodeString(1864);
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
						throw new Exception(EncodedStringTable.DecodeString(3956) + process.ExitCode);
					}
					Thread.Sleep(100);
					File.Delete(installerPath);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(EncodedStringTable.DecodeString(4029) + ex.Message, EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				succeeded = false;
			}
		}

		if (succeeded)
		{
			MessageBox.Show(EncodedStringTable.DecodeString(4102), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		this.Invoke(new MethodInvoker(this.Close));
	}

	internal void OnFormLoad(object sender, EventArgs e)
	{
		ThreadPool.QueueUserWorkItem(delegate(object instance)
		{
			if (this.flag)
			{
				bool flag = false;
				try
				{
					string address = this.text.Replace(EncodedStringTable.DecodeString(1902), EncodedStringTable.DecodeString(1915));
					IEnumerator enumerator = Regex.Matches(this.cookieAwareWebClient.DownloadString(address), EncodedStringTable.DecodeString(1936)).GetEnumerator();
					{
						while (enumerator.MoveNext())
						{
							string value = ((Match)enumerator.Current).Groups[EncodedStringTable.DecodeString(1969)].Value;
							if (value.IndexOf(this.text3, StringComparison.OrdinalIgnoreCase) != -1)
							{
								flag = true;
								this.cookieAwareWebClient.DownloadDataAsync(new Uri(value));
								break;
							}
						}
					}
				}
				catch
				{
				}
				if (!flag)
				{
					MessageBox.Show(EncodedStringTable.DecodeString(1978) + this.text3 + EncodedStringTable.DecodeString(2023), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Process.Start(this.text);
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
