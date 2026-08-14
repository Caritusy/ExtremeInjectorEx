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
using Ionic.Zip;

public sealed class DependencyInstallerForm : Form
{
	internal bool bool_0;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal CookieAwareWebClient class20_0 = new CookieAwareWebClient();

	internal IContainer icontainer_0;

	internal Label label_0;

	internal ProgressBar progressBar_0;

	public DependencyInstallerForm()
	{
		RecoveredRuntime.InitializeDependencyInstallerForm(this);
		ModernUi.ApplyLegacyFormTheme(this);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		ShowInTaskbar = false;
		SizeGripStyle = SizeGripStyle.Hide;
		class20_0.DownloadDataCompleted += class20_0_DownloadDataCompleted;
		class20_0.DownloadProgressChanged += class20_0_DownloadProgressChanged;
	}

	internal void class20_0_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
		base.Invoke(new MethodInvoker(delegate
		{
			this.progressBar_0.Value = e.ProgressPercentage;
			string text = null;
			if (this.class20_0.ResponseHeaders[EncodedStringTable.DecodeString(3814)] != null)
			{
				text = new ContentDisposition(this.class20_0.ResponseHeaders[EncodedStringTable.DecodeString(3814)]).FileName;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = this.string_2;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = Uri.UnescapeDataString(Path.GetFileName(new Uri(this.string_0).AbsolutePath));
			}
			this.label_0.Text = string.Concat(new string[]
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

	internal void class20_0_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
	{
		base.Invoke(new MethodInvoker(delegate
		{
			if (e.Error != null)
			{
				MessageBox.Show(this, EncodedStringTable.DecodeString(3879) + e.Error.Message, EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.Close();
				return;
			}

			this.progressBar_0.Value = 100;
			ThreadPool.QueueUserWorkItem(delegate
			{
				this.InstallDownloadedDependency(e.Result);
			});
		}));
	}

	private void InstallDownloadedDependency(byte[] downloadedData)
	{
		bool succeeded = true;
		if (!this.bool_0)
		{
			this.Invoke(new MethodInvoker(delegate
			{
				this.label_0.Text = EncodedStringTable.DecodeString(1869);
			}));
			using (MemoryStream memoryStream = new MemoryStream(downloadedData))
			using (ZipFile zipFile = ZipFile.Read(memoryStream))
			{
				foreach (ZipEntry zipEntry in zipFile)
				{
					try
					{
						zipEntry.Extract(this.string_1, (ExtractExistingFileAction)1);
					}
					catch
					{
					}
				}
			}
		}
		else
		{
			this.Invoke(new MethodInvoker(delegate
			{
				this.label_0.Text = EncodedStringTable.DecodeString(1847) + this.string_2 + EncodedStringTable.DecodeString(1864);
			}));
			try
			{
				string temporaryDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
				Directory.CreateDirectory(temporaryDirectory);
				string installerPath = Path.Combine(temporaryDirectory, this.string_2);
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
		ThreadPool.QueueUserWorkItem(delegate(object object_0)
		{
			if (this.bool_0)
			{
				bool flag = false;
				try
				{
					string address = this.string_0.Replace(EncodedStringTable.DecodeString(1902), EncodedStringTable.DecodeString(1915));
					IEnumerator enumerator = Regex.Matches(this.class20_0.DownloadString(address), EncodedStringTable.DecodeString(1936)).GetEnumerator();
					{
						while (enumerator.MoveNext())
						{
							string value = ((Match)enumerator.Current).Groups[EncodedStringTable.DecodeString(1969)].Value;
							if (value.IndexOf(this.string_2, StringComparison.OrdinalIgnoreCase) != -1)
							{
								flag = true;
								this.class20_0.DownloadDataAsync(new Uri(value));
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
					MessageBox.Show(EncodedStringTable.DecodeString(1978) + this.string_2 + EncodedStringTable.DecodeString(2023), EncodedStringTable.DecodeString(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Process.Start(this.string_0);
					return;
				}
			}
			else
			{
				this.class20_0.DownloadDataAsync(new Uri(this.string_0));
			}
		});
	}

	internal void OnFormClosing(object sender, FormClosingEventArgs e)
	{
		class20_0.CancelAsync();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}
}
