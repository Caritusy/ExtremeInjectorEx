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
		RecoveredRuntime.smethod_114(this);
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
			if (this.class20_0.ResponseHeaders[EncodedStringTable.smethod_0(3814)] != null)
			{
				text = new ContentDisposition(this.class20_0.ResponseHeaders[EncodedStringTable.smethod_0(3814)]).FileName;
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
				EncodedStringTable.smethod_0(3843),
				text,
				EncodedStringTable.smethod_0(3860),
				RecoveredRuntime.smethod_442(e.BytesReceived),
				EncodedStringTable.smethod_0(3869),
				RecoveredRuntime.smethod_442(e.TotalBytesToReceive),
				EncodedStringTable.smethod_0(3874)
			});
		}));
	}

	internal void class20_0_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
	{
		base.Invoke(new MethodInvoker(delegate
		{
			if (e.Error != null)
			{
				MessageBox.Show(this, EncodedStringTable.smethod_0(3879) + e.Error.Message, EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
				this.label_0.Text = EncodedStringTable.smethod_0(1869);
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
				this.label_0.Text = EncodedStringTable.smethod_0(1847) + this.string_2 + EncodedStringTable.smethod_0(1864);
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
						throw new Exception(EncodedStringTable.smethod_0(3956) + process.ExitCode);
					}
					Thread.Sleep(100);
					File.Delete(installerPath);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(EncodedStringTable.smethod_0(4029) + ex.Message, EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				succeeded = false;
			}
		}

		if (succeeded)
		{
			MessageBox.Show(EncodedStringTable.smethod_0(4102), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		this.Invoke(new MethodInvoker(this.Close));
	}

	internal void method_0(object sender, EventArgs e)
	{
		ThreadPool.QueueUserWorkItem(delegate(object object_0)
		{
			if (this.bool_0)
			{
				bool flag = false;
				try
				{
					string address = this.string_0.Replace(EncodedStringTable.smethod_0(1902), EncodedStringTable.smethod_0(1915));
					IEnumerator enumerator = Regex.Matches(this.class20_0.DownloadString(address), EncodedStringTable.smethod_0(1936)).GetEnumerator();
					{
						while (enumerator.MoveNext())
						{
							string value = ((Match)enumerator.Current).Groups[EncodedStringTable.smethod_0(1969)].Value;
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
					MessageBox.Show(EncodedStringTable.smethod_0(1978) + this.string_2 + EncodedStringTable.smethod_0(2023), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

	internal void method_1(object sender, FormClosingEventArgs e)
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

	[CompilerGenerated]
	internal void method_2()
	{
		label_0.Text = UiText.Format("Dependency.Installing", string_2);
	}

	[CompilerGenerated]
	internal void method_3()
	{
		label_0.Text = UiText.Get("Dependency.Extracting");
	}

	[CompilerGenerated]
	internal void method_4(object object_0)
	{
		if (this.bool_0)
		{
			bool flag = false;
			try
			{
				string address = this.string_0.Replace(EncodedStringTable.smethod_0(1902), EncodedStringTable.smethod_0(1915));
				IEnumerator enumerator = Regex.Matches(this.class20_0.DownloadString(address), EncodedStringTable.smethod_0(1936)).GetEnumerator();
				{
					while (enumerator.MoveNext())
					{
						string value = ((Match)enumerator.Current).Groups[EncodedStringTable.smethod_0(1969)].Value;
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
				MessageBox.Show(EncodedStringTable.smethod_0(1978) + this.string_2 + EncodedStringTable.smethod_0(2023), EncodedStringTable.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Process.Start(this.string_0);
				return;
			}
		}
		else
		{
			this.class20_0.DownloadDataAsync(new Uri(this.string_0));
		}
	}

	internal static void smethod_0(WebClient webClient_0, DownloadDataCompletedEventHandler downloadDataCompletedEventHandler_0)
	{
		webClient_0.DownloadDataCompleted += downloadDataCompletedEventHandler_0;
	}

	internal static void smethod_1(WebClient webClient_0, DownloadProgressChangedEventHandler downloadProgressChangedEventHandler_0)
	{
		webClient_0.DownloadProgressChanged += downloadProgressChangedEventHandler_0;
	}

	internal static object smethod_2(Control control_0, Delegate delegate_0)
	{
		return control_0.Invoke(delegate_0);
	}

	internal static bool smethod_3(WaitCallback waitCallback_0)
	{
		return ThreadPool.QueueUserWorkItem(waitCallback_0);
	}

	internal static void smethod_4(WebClient webClient_0)
	{
		webClient_0.CancelAsync();
	}

	internal static void smethod_5(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static string smethod_6(string string_3, string string_4, string string_5)
	{
		return string_3 + string_4 + string_5;
	}

	internal static void smethod_7(Control control_0, string string_3)
	{
		control_0.Text = string_3;
	}

	internal static string smethod_8(string string_3, string string_4, string string_5)
	{
		return string_3.Replace(string_4, string_5);
	}

	internal static string smethod_9(WebClient webClient_0, string string_3)
	{
		return webClient_0.DownloadString(string_3);
	}

	internal static MatchCollection smethod_10(string string_3, string string_4)
	{
		return Regex.Matches(string_3, string_4);
	}

	internal static IEnumerator smethod_11(MatchCollection matchCollection_0)
	{
		return matchCollection_0.GetEnumerator();
	}

	internal static object smethod_12(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	internal static GroupCollection smethod_13(Match match_0)
	{
		return match_0.Groups;
	}

	internal static Group smethod_14(GroupCollection groupCollection_0, string string_3)
	{
		return groupCollection_0[string_3];
	}

	internal static string smethod_15(Capture capture_0)
	{
		return capture_0.Value;
	}

	internal static int smethod_16(string string_3, string string_4, StringComparison stringComparison_0)
	{
		return string_3.IndexOf(string_4, stringComparison_0);
	}

	internal static Uri smethod_17(string string_3)
	{
		return new Uri(string_3);
	}

	internal static void smethod_18(WebClient webClient_0, Uri uri_0)
	{
		webClient_0.DownloadDataAsync(uri_0);
	}

	internal static bool smethod_19(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	internal static DialogResult smethod_20(string string_3, string string_4, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		return MessageBox.Show(string_3, string_4, messageBoxButtons_0, messageBoxIcon_0);
	}

	internal static Process smethod_21(string string_3)
	{
		return Process.Start(string_3);
	}
}
