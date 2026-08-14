using System;
using System.Collections;
using System.Collections.Generic;
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

internal sealed class Form3 : Form
{
	[CompilerGenerated]
	private sealed class Class35
	{
		public DownloadProgressChangedEventArgs downloadProgressChangedEventArgs_0;

		public Form3 form3_0;

		internal void method_0()
		{
			form3_0.progressBar_0.Value = downloadProgressChangedEventArgs_0.ProgressPercentage;
			string text = default(string);
			while (true)
			{
				int num = -1136654729;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -2041287971)) % 9)
					{
					case 8u:
					{
						text = null;
						int num5;
						int num6;
						if (form3_0.class20_0.ResponseHeaders[Class178.smethod_0(3814)] != null)
						{
							num5 = 276394693;
							num6 = 276394693;
						}
						else
						{
							num5 = 454574697;
							num6 = 454574697;
						}
						num = num5 ^ (int)(num2 * 1224346641);
						continue;
					}
					case 7u:
						text = form3_0.string_2;
						num = ((int)num2 * -584978239) ^ -1271616069;
						continue;
					case 5u:
						text = Uri.UnescapeDataString(Path.GetFileName(new Uri(form3_0.string_0).AbsolutePath));
						num = (int)((num2 * 522087323) ^ 0x3DBD0C68);
						continue;
					case 3u:
						form3_0.label_0.Text = Class178.smethod_0(3843) + text + Class178.smethod_0(3860) + Class171.smethod_433(downloadProgressChangedEventArgs_0.BytesReceived) + Class178.smethod_0(3869) + Class171.smethod_433(downloadProgressChangedEventArgs_0.TotalBytesToReceive) + Class178.smethod_0(3874);
						num = -2111451650;
						continue;
					case 2u:
					{
						int num4;
						if (string.IsNullOrEmpty(text))
						{
							num = -1961673711;
							num4 = -1961673711;
						}
						else
						{
							num = -2032280084;
							num4 = -2032280084;
						}
						continue;
					}
					case 1u:
					{
						int num3;
						if (!string.IsNullOrEmpty(text))
						{
							num = -724793491;
							num3 = -724793491;
						}
						else
						{
							num = -1165123445;
							num3 = -1165123445;
						}
						continue;
					}
					case 0u:
						text = new ContentDisposition(form3_0.class20_0.ResponseHeaders[Class178.smethod_0(3814)]).FileName;
						num = (int)(num2 * 2118235347) ^ -1132712523;
						continue;
					default:
						return;
					case 6u:
						break;
					case 4u:
						return;
					}
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class36
	{
		public DownloadDataCompletedEventArgs downloadDataCompletedEventArgs_0;

		public Form3 form3_0;

		public WaitCallback waitCallback_0;

		internal void method_0()
		{
			if (downloadDataCompletedEventArgs_0.Error != null)
			{
				goto IL_0010;
			}
			goto IL_009f;
			IL_0010:
			int num = -1871271396;
			goto IL_0076;
			IL_0076:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -271060919)) % 6)
				{
				case 5u:
					break;
				case 4u:
					form3_0.Close();
					num = ((int)num2 * -1958857336) ^ -1983099817;
					continue;
				case 1u:
					MessageBox.Show(form3_0, Class178.smethod_0(3879) + downloadDataCompletedEventArgs_0.Error.Message, Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					num = (int)(num2 * 977009865) ^ -647304280;
					continue;
				case 3u:
					goto IL_009f;
				default:
					ThreadPool.QueueUserWorkItem(delegate
					{
						bool flag = true;
						Process process = default(Process);
						while (true)
						{
							int num3 = -289592701;
							while (true)
							{
								int num14;
								uint num4;
								switch ((num4 = (uint)(num3 ^ -265431999)) % 3)
								{
								case 1u:
								{
									if (form3_0.bool_0)
									{
										goto IL_0011;
									}
									form3_0.Invoke((MethodInvoker)delegate
									{
										form3_0.label_0.Text = Class178.smethod_0(1869);
									});
									MemoryStream memoryStream = new MemoryStream(downloadDataCompletedEventArgs_0.Result);
									try
									{
										ZipFile val = ZipFile.Read((Stream)memoryStream);
										try
										{
											IEnumerator<ZipEntry> enumerator = val.GetEnumerator();
											try
											{
												while (enumerator.MoveNext())
												{
													ZipEntry current = enumerator.Current;
													try
													{
														current.Extract(form3_0.string_1, (ExtractExistingFileAction)1);
													}
													catch
													{
													}
												}
											}
											finally
											{
												if (enumerator != null)
												{
													while (true)
													{
														IL_00f3:
														int num11 = -1342398227;
														while (true)
														{
															switch ((num4 = (uint)(num11 ^ -265431999)) % 3)
															{
															case 1u:
																goto IL_00c0;
															default:
																goto end_IL_00d5;
															case 0u:
																break;
															case 2u:
																goto end_IL_00d5;
															}
															goto IL_00f3;
															IL_00c0:
															enumerator.Dispose();
															num11 = (int)((num4 * 1770200392) ^ 0x4BFB0E45);
															continue;
															end_IL_00d5:
															break;
														}
														break;
													}
												}
											}
										}
										finally
										{
											if (val != null)
											{
												while (true)
												{
													IL_0134:
													int num12 = -852231878;
													while (true)
													{
														switch ((num4 = (uint)(num12 ^ -265431999)) % 3)
														{
														case 1u:
															goto IL_0101;
														default:
															goto end_IL_0116;
														case 2u:
															break;
														case 0u:
															goto end_IL_0116;
														}
														goto IL_0134;
														IL_0101:
														((IDisposable)val).Dispose();
														num12 = ((int)num4 * -1297051926) ^ -25082576;
														continue;
														end_IL_0116:
														break;
													}
													break;
												}
											}
										}
									}
									finally
									{
										if (memoryStream != null)
										{
											while (true)
											{
												IL_0175:
												int num13 = -2136234169;
												while (true)
												{
													switch ((num4 = (uint)(num13 ^ -265431999)) % 3)
													{
													case 1u:
														goto IL_0142;
													default:
														goto end_IL_0157;
													case 2u:
														break;
													case 0u:
														goto end_IL_0157;
													}
													goto IL_0175;
													IL_0142:
													((IDisposable)memoryStream).Dispose();
													num13 = (int)(num4 * 1999367492) ^ -1472965522;
													continue;
													end_IL_0157:
													break;
												}
												break;
											}
										}
									}
									goto IL_0366;
								}
								case 0u:
									break;
								default:
									{
										form3_0.Invoke((MethodInvoker)delegate
										{
											form3_0.label_0.Text = Class178.smethod_0(1847) + form3_0.string_2 + Class178.smethod_0(1864);
										});
										try
										{
											string text = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
											if (!Directory.Exists(text))
											{
												goto IL_0211;
											}
											goto IL_02c9;
											IL_0211:
											int num5 = -552264379;
											goto IL_028a;
											IL_028a:
											while (true)
											{
												switch ((num4 = (uint)(num5 ^ -265431999)) % 11)
												{
												case 10u:
												{
													process.WaitForExit();
													int num8;
													int num9;
													if (process.ExitCode != 0)
													{
														num8 = 993833967;
														num9 = 993833967;
													}
													else
													{
														num8 = 1936168321;
														num9 = 1936168321;
													}
													num5 = num8 ^ ((int)num4 * -761573537);
													continue;
												}
												case 8u:
													Thread.Sleep(100);
													num5 = -95280532;
													continue;
												case 7u:
													File.Delete(text);
													num5 = (int)((num4 * 1351960756) ^ 0x7BBE07A0);
													continue;
												case 6u:
													break;
												case 4u:
													Directory.CreateDirectory(text);
													num5 = ((int)num4 * -1883058446) ^ 0x509B7DE2;
													continue;
												case 3u:
												{
													int num6;
													int num7;
													if (process == null)
													{
														num6 = 443513832;
														num7 = 443513832;
													}
													else
													{
														num6 = 435269807;
														num7 = 435269807;
													}
													num5 = num6 ^ (int)(num4 * 336045675);
													continue;
												}
												case 2u:
													File.WriteAllBytes(text, downloadDataCompletedEventArgs_0.Result);
													num5 = (int)(num4 * 1784209556) ^ -562088028;
													continue;
												case 1u:
													process = Process.Start(text);
													num5 = (int)((num4 * 1017596815) ^ 0x79058A02);
													continue;
												default:
													goto end_IL_019a;
												case 9u:
													goto IL_02c9;
												case 0u:
													throw new Exception(Class178.smethod_0(3956) + process.ExitCode);
												case 5u:
													goto end_IL_019a;
												}
												break;
											}
											goto IL_0211;
											IL_02c9:
											text = Path.Combine(text, form3_0.string_2);
											num5 = -1790331266;
											goto IL_028a;
											end_IL_019a:;
										}
										catch (Exception ex)
										{
											while (true)
											{
												IL_035d:
												int num10 = -187471593;
												while (true)
												{
													switch ((num4 = (uint)(num10 ^ -265431999)) % 3)
													{
													case 2u:
														goto IL_0307;
													default:
														goto end_IL_033f;
													case 0u:
														break;
													case 1u:
														goto end_IL_033f;
													}
													goto IL_035d;
													IL_0307:
													MessageBox.Show(Class178.smethod_0(4029) + ex.Message, Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
													flag = false;
													num10 = ((int)num4 * -893526725) ^ 0x3B80B715;
													continue;
													end_IL_033f:
													break;
												}
												break;
											}
										}
										goto IL_0366;
									}
									IL_0398:
									num14 = -1782048388;
									goto IL_039d;
									IL_0366:
									if (flag)
									{
										goto IL_0398;
									}
									goto IL_03bf;
									IL_03bf:
									form3_0.Invoke(new MethodInvoker(form3_0.Close));
									num14 = -1327381341;
									goto IL_039d;
									IL_039d:
									while (true)
									{
										switch ((num4 = (uint)(num14 ^ -265431999)) % 4)
										{
										case 1u:
											MessageBox.Show(Class178.smethod_0(4102), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
											num14 = (int)((num4 * 1571657903) ^ 0x24EA10B1);
											continue;
										case 0u:
											break;
										default:
											return;
										case 3u:
											goto IL_03bf;
										case 2u:
											return;
										}
										break;
									}
									goto IL_0398;
								}
								break;
								IL_0011:
								num3 = ((int)num4 * -164611940) ^ 0x5E0B0940;
							}
						}
					});
					return;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0010;
			IL_009f:
			form3_0.progressBar_0.Value = 100;
			num = -1316627093;
			goto IL_0076;
		}

		internal void method_1(object object_0)
		{
			bool flag = true;
			Process process = default(Process);
			while (true)
			{
				int num = -289592701;
				while (true)
				{
					int num12;
					uint num2;
					switch ((num2 = (uint)(num ^ -265431999)) % 3)
					{
					case 1u:
					{
						if (form3_0.bool_0)
						{
							goto IL_0011;
						}
						form3_0.Invoke((MethodInvoker)delegate
						{
							form3_0.label_0.Text = Class178.smethod_0(1869);
						});
						MemoryStream memoryStream = new MemoryStream(downloadDataCompletedEventArgs_0.Result);
						try
						{
							ZipFile val = ZipFile.Read((Stream)memoryStream);
							try
							{
								IEnumerator<ZipEntry> enumerator = val.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										ZipEntry current = enumerator.Current;
										try
										{
											current.Extract(form3_0.string_1, (ExtractExistingFileAction)1);
										}
										catch
										{
										}
									}
								}
								finally
								{
									if (enumerator != null)
									{
										while (true)
										{
											IL_00f3:
											int num9 = -1342398227;
											while (true)
											{
												switch ((num2 = (uint)(num9 ^ -265431999)) % 3)
												{
												case 1u:
													goto IL_00c0;
												default:
													goto end_IL_00d5;
												case 0u:
													break;
												case 2u:
													goto end_IL_00d5;
												}
												goto IL_00f3;
												IL_00c0:
												enumerator.Dispose();
												num9 = (int)((num2 * 1770200392) ^ 0x4BFB0E45);
												continue;
												end_IL_00d5:
												break;
											}
											break;
										}
									}
								}
							}
							finally
							{
								if (val != null)
								{
									while (true)
									{
										IL_0134:
										int num10 = -852231878;
										while (true)
										{
											switch ((num2 = (uint)(num10 ^ -265431999)) % 3)
											{
											case 1u:
												goto IL_0101;
											default:
												goto end_IL_0116;
											case 2u:
												break;
											case 0u:
												goto end_IL_0116;
											}
											goto IL_0134;
											IL_0101:
											((IDisposable)val).Dispose();
											num10 = ((int)num2 * -1297051926) ^ -25082576;
											continue;
											end_IL_0116:
											break;
										}
										break;
									}
								}
							}
						}
						finally
						{
							if (memoryStream != null)
							{
								while (true)
								{
									IL_0175:
									int num11 = -2136234169;
									while (true)
									{
										switch ((num2 = (uint)(num11 ^ -265431999)) % 3)
										{
										case 1u:
											goto IL_0142;
										default:
											goto end_IL_0157;
										case 2u:
											break;
										case 0u:
											goto end_IL_0157;
										}
										goto IL_0175;
										IL_0142:
										((IDisposable)memoryStream).Dispose();
										num11 = (int)(num2 * 1999367492) ^ -1472965522;
										continue;
										end_IL_0157:
										break;
									}
									break;
								}
							}
						}
						goto IL_0366;
					}
					case 0u:
						break;
					default:
						{
							form3_0.Invoke((MethodInvoker)delegate
							{
								form3_0.label_0.Text = Class178.smethod_0(1847) + form3_0.string_2 + Class178.smethod_0(1864);
							});
							try
							{
								string text = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
								if (!Directory.Exists(text))
								{
									goto IL_0211;
								}
								goto IL_02c9;
								IL_0211:
								int num3 = -552264379;
								goto IL_028a;
								IL_028a:
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -265431999)) % 11)
									{
									case 10u:
									{
										process.WaitForExit();
										int num6;
										int num7;
										if (process.ExitCode != 0)
										{
											num6 = 993833967;
											num7 = 993833967;
										}
										else
										{
											num6 = 1936168321;
											num7 = 1936168321;
										}
										num3 = num6 ^ ((int)num2 * -761573537);
										continue;
									}
									case 8u:
										Thread.Sleep(100);
										num3 = -95280532;
										continue;
									case 7u:
										File.Delete(text);
										num3 = (int)((num2 * 1351960756) ^ 0x7BBE07A0);
										continue;
									case 6u:
										break;
									case 4u:
										Directory.CreateDirectory(text);
										num3 = ((int)num2 * -1883058446) ^ 0x509B7DE2;
										continue;
									case 3u:
									{
										int num4;
										int num5;
										if (process == null)
										{
											num4 = 443513832;
											num5 = 443513832;
										}
										else
										{
											num4 = 435269807;
											num5 = 435269807;
										}
										num3 = num4 ^ (int)(num2 * 336045675);
										continue;
									}
									case 2u:
										File.WriteAllBytes(text, downloadDataCompletedEventArgs_0.Result);
										num3 = (int)(num2 * 1784209556) ^ -562088028;
										continue;
									case 1u:
										process = Process.Start(text);
										num3 = (int)((num2 * 1017596815) ^ 0x79058A02);
										continue;
									default:
										goto end_IL_019a;
									case 9u:
										goto IL_02c9;
									case 0u:
										throw new Exception(Class178.smethod_0(3956) + process.ExitCode);
									case 5u:
										goto end_IL_019a;
									}
									break;
								}
								goto IL_0211;
								IL_02c9:
								text = Path.Combine(text, form3_0.string_2);
								num3 = -1790331266;
								goto IL_028a;
								end_IL_019a:;
							}
							catch (Exception ex)
							{
								while (true)
								{
									IL_035d:
									int num8 = -187471593;
									while (true)
									{
										switch ((num2 = (uint)(num8 ^ -265431999)) % 3)
										{
										case 2u:
											goto IL_0307;
										default:
											goto end_IL_033f;
										case 0u:
											break;
										case 1u:
											goto end_IL_033f;
										}
										goto IL_035d;
										IL_0307:
										MessageBox.Show(Class178.smethod_0(4029) + ex.Message, Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
										flag = false;
										num8 = ((int)num2 * -893526725) ^ 0x3B80B715;
										continue;
										end_IL_033f:
										break;
									}
									break;
								}
							}
							goto IL_0366;
						}
						IL_0398:
						num12 = -1782048388;
						goto IL_039d;
						IL_0366:
						if (flag)
						{
							goto IL_0398;
						}
						goto IL_03bf;
						IL_03bf:
						form3_0.Invoke(new MethodInvoker(form3_0.Close));
						num12 = -1327381341;
						goto IL_039d;
						IL_039d:
						while (true)
						{
							switch ((num2 = (uint)(num12 ^ -265431999)) % 4)
							{
							case 1u:
								MessageBox.Show(Class178.smethod_0(4102), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								num12 = (int)((num2 * 1571657903) ^ 0x24EA10B1);
								continue;
							case 0u:
								break;
							default:
								return;
							case 3u:
								goto IL_03bf;
							case 2u:
								return;
							}
							break;
						}
						goto IL_0398;
					}
					break;
					IL_0011:
					num = ((int)num2 * -164611940) ^ 0x5E0B0940;
				}
			}
		}
	}

	internal bool bool_0;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	private Class20 class20_0 = new Class20();

	private IContainer icontainer_0;

	internal Label label_0;

	internal ProgressBar progressBar_0;

	public Form3()
	{
		Class171.smethod_113(this);
		class20_0.DownloadDataCompleted += class20_0_DownloadDataCompleted;
		class20_0.DownloadProgressChanged += class20_0_DownloadProgressChanged;
	}

	private void class20_0_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
	{
		Form3 form3_0;
		DownloadProgressChangedEventArgs downloadProgressChangedEventArgs_0;
		while (true)
		{
			int num = 1305169266;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x61E74C54)) % 3)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				form3_0 = this;
				downloadProgressChangedEventArgs_0 = e;
				Invoke((MethodInvoker)delegate
				{
					form3_0.progressBar_0.Value = downloadProgressChangedEventArgs_0.ProgressPercentage;
					string text = default(string);
					while (true)
					{
						int num3 = -1136654729;
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num3 ^ -2041287971)) % 9)
							{
							case 8u:
							{
								text = null;
								int num7;
								int num8;
								if (form3_0.class20_0.ResponseHeaders[Class178.smethod_0(3814)] != null)
								{
									num7 = 276394693;
									num8 = 276394693;
								}
								else
								{
									num7 = 454574697;
									num8 = 454574697;
								}
								num3 = num7 ^ (int)(num4 * 1224346641);
								continue;
							}
							case 7u:
								text = form3_0.string_2;
								num3 = ((int)num4 * -584978239) ^ -1271616069;
								continue;
							case 5u:
								text = Uri.UnescapeDataString(Path.GetFileName(new Uri(form3_0.string_0).AbsolutePath));
								num3 = (int)((num4 * 522087323) ^ 0x3DBD0C68);
								continue;
							case 3u:
								form3_0.label_0.Text = Class178.smethod_0(3843) + text + Class178.smethod_0(3860) + Class171.smethod_433(downloadProgressChangedEventArgs_0.BytesReceived) + Class178.smethod_0(3869) + Class171.smethod_433(downloadProgressChangedEventArgs_0.TotalBytesToReceive) + Class178.smethod_0(3874);
								num3 = -2111451650;
								continue;
							case 2u:
							{
								int num6;
								if (string.IsNullOrEmpty(text))
								{
									num3 = -1961673711;
									num6 = -1961673711;
								}
								else
								{
									num3 = -2032280084;
									num6 = -2032280084;
								}
								continue;
							}
							case 1u:
							{
								int num5;
								if (!string.IsNullOrEmpty(text))
								{
									num3 = -724793491;
									num5 = -724793491;
								}
								else
								{
									num3 = -1165123445;
									num5 = -1165123445;
								}
								continue;
							}
							case 0u:
								text = new ContentDisposition(form3_0.class20_0.ResponseHeaders[Class178.smethod_0(3814)]).FileName;
								num3 = (int)(num4 * 2118235347) ^ -1132712523;
								continue;
							default:
								return;
							case 6u:
								break;
							case 4u:
								return;
							}
							break;
						}
					}
				});
				num = ((int)num2 * -1699671744) ^ -1768900856;
			}
		}
	}

	private void class20_0_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
	{
		Invoke((MethodInvoker)delegate
		{
			if (e.Error != null)
			{
				goto IL_0010;
			}
			goto IL_009f;
			IL_0010:
			int num = -1871271396;
			goto IL_0076;
			IL_0076:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -271060919)) % 6)
				{
				case 5u:
					break;
				case 4u:
					Close();
					num = ((int)num2 * -1958857336) ^ -1983099817;
					continue;
				case 1u:
					MessageBox.Show(this, Class178.smethod_0(3879) + e.Error.Message, Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					num = (int)(num2 * 977009865) ^ -647304280;
					continue;
				case 3u:
					goto IL_009f;
				default:
					ThreadPool.QueueUserWorkItem(delegate
					{
						bool flag = true;
						Process process = default(Process);
						while (true)
						{
							int num3 = -289592701;
							while (true)
							{
								int num14;
								uint num4;
								switch ((num4 = (uint)(num3 ^ -265431999)) % 3)
								{
								case 1u:
								{
									if (bool_0)
									{
										goto IL_0011;
									}
									Invoke((MethodInvoker)delegate
									{
										label_0.Text = Class178.smethod_0(1869);
									});
									MemoryStream memoryStream = new MemoryStream(e.Result);
									try
									{
										ZipFile val = ZipFile.Read((Stream)memoryStream);
										try
										{
											IEnumerator<ZipEntry> enumerator = val.GetEnumerator();
											try
											{
												while (enumerator.MoveNext())
												{
													ZipEntry current = enumerator.Current;
													try
													{
														current.Extract(string_1, (ExtractExistingFileAction)1);
													}
													catch
													{
													}
												}
											}
											finally
											{
												if (enumerator != null)
												{
													while (true)
													{
														IL_00f3:
														int num11 = -1342398227;
														while (true)
														{
															switch ((num4 = (uint)(num11 ^ -265431999)) % 3)
															{
															case 1u:
																goto IL_00c0;
															default:
																goto end_IL_00d5;
															case 0u:
																break;
															case 2u:
																goto end_IL_00d5;
															}
															goto IL_00f3;
															IL_00c0:
															enumerator.Dispose();
															num11 = (int)((num4 * 1770200392) ^ 0x4BFB0E45);
															continue;
															end_IL_00d5:
															break;
														}
														break;
													}
												}
											}
										}
										finally
										{
											if (val != null)
											{
												while (true)
												{
													IL_0134:
													int num12 = -852231878;
													while (true)
													{
														switch ((num4 = (uint)(num12 ^ -265431999)) % 3)
														{
														case 1u:
															goto IL_0101;
														default:
															goto end_IL_0116;
														case 2u:
															break;
														case 0u:
															goto end_IL_0116;
														}
														goto IL_0134;
														IL_0101:
														((IDisposable)val).Dispose();
														num12 = ((int)num4 * -1297051926) ^ -25082576;
														continue;
														end_IL_0116:
														break;
													}
													break;
												}
											}
										}
									}
									finally
									{
										if (memoryStream != null)
										{
											while (true)
											{
												IL_0175:
												int num13 = -2136234169;
												while (true)
												{
													switch ((num4 = (uint)(num13 ^ -265431999)) % 3)
													{
													case 1u:
														goto IL_0142;
													default:
														goto end_IL_0157;
													case 2u:
														break;
													case 0u:
														goto end_IL_0157;
													}
													goto IL_0175;
													IL_0142:
													((IDisposable)memoryStream).Dispose();
													num13 = (int)(num4 * 1999367492) ^ -1472965522;
													continue;
													end_IL_0157:
													break;
												}
												break;
											}
										}
									}
									goto IL_0366;
								}
								case 0u:
									break;
								default:
									{
										Invoke((MethodInvoker)delegate
										{
											label_0.Text = Class178.smethod_0(1847) + string_2 + Class178.smethod_0(1864);
										});
										try
										{
											string text = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
											if (!Directory.Exists(text))
											{
												goto IL_0211;
											}
											goto IL_02c9;
											IL_0211:
											int num5 = -552264379;
											goto IL_028a;
											IL_028a:
											while (true)
											{
												switch ((num4 = (uint)(num5 ^ -265431999)) % 11)
												{
												case 10u:
												{
													process.WaitForExit();
													int num8;
													int num9;
													if (process.ExitCode != 0)
													{
														num8 = 993833967;
														num9 = 993833967;
													}
													else
													{
														num8 = 1936168321;
														num9 = 1936168321;
													}
													num5 = num8 ^ ((int)num4 * -761573537);
													continue;
												}
												case 8u:
													Thread.Sleep(100);
													num5 = -95280532;
													continue;
												case 7u:
													File.Delete(text);
													num5 = (int)((num4 * 1351960756) ^ 0x7BBE07A0);
													continue;
												case 6u:
													break;
												case 4u:
													Directory.CreateDirectory(text);
													num5 = ((int)num4 * -1883058446) ^ 0x509B7DE2;
													continue;
												case 3u:
												{
													int num6;
													int num7;
													if (process == null)
													{
														num6 = 443513832;
														num7 = 443513832;
													}
													else
													{
														num6 = 435269807;
														num7 = 435269807;
													}
													num5 = num6 ^ (int)(num4 * 336045675);
													continue;
												}
												case 2u:
													File.WriteAllBytes(text, e.Result);
													num5 = (int)(num4 * 1784209556) ^ -562088028;
													continue;
												case 1u:
													process = Process.Start(text);
													num5 = (int)((num4 * 1017596815) ^ 0x79058A02);
													continue;
												default:
													goto end_IL_019a;
												case 9u:
													goto IL_02c9;
												case 0u:
													throw new Exception(Class178.smethod_0(3956) + process.ExitCode);
												case 5u:
													goto end_IL_019a;
												}
												break;
											}
											goto IL_0211;
											IL_02c9:
											text = Path.Combine(text, string_2);
											num5 = -1790331266;
											goto IL_028a;
											end_IL_019a:;
										}
										catch (Exception ex)
										{
											while (true)
											{
												IL_035d:
												int num10 = -187471593;
												while (true)
												{
													switch ((num4 = (uint)(num10 ^ -265431999)) % 3)
													{
													case 2u:
														goto IL_0307;
													default:
														goto end_IL_033f;
													case 0u:
														break;
													case 1u:
														goto end_IL_033f;
													}
													goto IL_035d;
													IL_0307:
													MessageBox.Show(Class178.smethod_0(4029) + ex.Message, Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
													flag = false;
													num10 = ((int)num4 * -893526725) ^ 0x3B80B715;
													continue;
													end_IL_033f:
													break;
												}
												break;
											}
										}
										goto IL_0366;
									}
									IL_0398:
									num14 = -1782048388;
									goto IL_039d;
									IL_0366:
									if (flag)
									{
										goto IL_0398;
									}
									goto IL_03bf;
									IL_03bf:
									Invoke(new MethodInvoker(base.Close));
									num14 = -1327381341;
									goto IL_039d;
									IL_039d:
									while (true)
									{
										switch ((num4 = (uint)(num14 ^ -265431999)) % 4)
										{
										case 1u:
											MessageBox.Show(Class178.smethod_0(4102), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
											num14 = (int)((num4 * 1571657903) ^ 0x24EA10B1);
											continue;
										case 0u:
											break;
										default:
											return;
										case 3u:
											goto IL_03bf;
										case 2u:
											return;
										}
										break;
									}
									goto IL_0398;
								}
								break;
								IL_0011:
								num3 = ((int)num4 * -164611940) ^ 0x5E0B0940;
							}
						}
					});
					return;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0010;
			IL_009f:
			progressBar_0.Value = 100;
			num = -1316627093;
			goto IL_0076;
		});
	}

	internal void method_0(object sender, EventArgs e)
	{
		ThreadPool.QueueUserWorkItem(delegate
		{
			if (bool_0)
			{
				bool flag = false;
				try
				{
					string address = string_0.Replace(Class178.smethod_0(1902), Class178.smethod_0(1915));
					IEnumerator enumerator = Regex.Matches(class20_0.DownloadString(address), Class178.smethod_0(1936)).GetEnumerator();
					try
					{
						string value = default(string);
						while (true)
						{
							IL_013a:
							int num;
							int num2;
							if (!enumerator.MoveNext())
							{
								num = -549956804;
								num2 = -549956804;
							}
							else
							{
								num = -466365456;
								num2 = -466365456;
							}
							while (true)
							{
								uint num3;
								switch ((num3 = (uint)(num ^ -1523805111)) % 7)
								{
								case 5u:
									num = (int)((num3 * 1272139222) ^ 0x7AC520C4);
									continue;
								case 3u:
									flag = true;
									num = ((int)num3 * -54244233) ^ 0x128298DE;
									continue;
								case 2u:
									class20_0.DownloadDataAsync(new Uri(value));
									num = (int)((num3 * 315993970) ^ 0x5845D99F);
									continue;
								case 1u:
								{
									value = ((Match)enumerator.Current).Groups[Class178.smethod_0(1969)].Value;
									int num4;
									if (value.IndexOf(string_2, StringComparison.OrdinalIgnoreCase) == -1)
									{
										num = -1311954052;
										num4 = -1311954052;
									}
									else
									{
										num = -1203052117;
										num4 = -1203052117;
									}
									continue;
								}
								case 0u:
									num = -466365456;
									continue;
								default:
									goto end_IL_00fd;
								case 6u:
									break;
								case 4u:
									goto end_IL_00fd;
								}
								goto IL_013a;
								continue;
								end_IL_00fd:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator is IDisposable disposable)
						{
							while (true)
							{
								IL_018a:
								int num5 = -1067037714;
								while (true)
								{
									uint num3;
									switch ((num3 = (uint)(num5 ^ -1523805111)) % 3)
									{
									case 1u:
										goto IL_0157;
									default:
										goto end_IL_016c;
									case 2u:
										break;
									case 0u:
										goto end_IL_016c;
									}
									goto IL_018a;
									IL_0157:
									disposable.Dispose();
									num5 = (int)((num3 * 964328149) ^ 0x51C77B80);
									continue;
									end_IL_016c:
									break;
								}
								break;
							}
						}
					}
				}
				catch
				{
				}
				if (flag)
				{
					return;
				}
				goto IL_01ed;
			}
			goto IL_0218;
			IL_01f2:
			int num6;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num6 ^ -1523805111)) % 5)
				{
				case 3u:
					MessageBox.Show(Class178.smethod_0(1978) + string_2 + Class178.smethod_0(2023), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Process.Start(string_0);
					num6 = (int)((num3 * 766058975) ^ 0x4B474E8F);
					continue;
				case 2u:
					break;
				default:
					return;
				case 4u:
					goto IL_0218;
				case 0u:
					return;
				case 1u:
					return;
				}
				break;
			}
			goto IL_01ed;
			IL_0218:
			class20_0.DownloadDataAsync(new Uri(string_0));
			num6 = -811558667;
			goto IL_01f2;
			IL_01ed:
			num6 = -976391202;
			goto IL_01f2;
		});
	}

	internal void method_1(object sender, FormClosingEventArgs e)
	{
		class20_0.CancelAsync();
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing)
		{
			goto IL_0048;
		}
		goto IL_0072;
		IL_0048:
		int num = 887686760;
		goto IL_004d;
		IL_004d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0xA4B2E17)) % 5)
			{
			case 3u:
				icontainer_0.Dispose();
				num = ((int)num2 * -1835518553) ^ 0x5DE7C166;
				continue;
			case 1u:
			{
				int num3;
				int num4;
				if (icontainer_0 == null)
				{
					num3 = -1050585095;
					num4 = -1050585095;
				}
				else
				{
					num3 = -1555145436;
					num4 = -1555145436;
				}
				num = num3 ^ ((int)num2 * -1255079457);
				continue;
			}
			case 0u:
				break;
			default:
				return;
			case 2u:
				goto IL_0072;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0048;
		IL_0072:
		Dispose(disposing);
		num = 1300235304;
		goto IL_004d;
	}

	[CompilerGenerated]
	private void method_2()
	{
		label_0.Text = Class178.smethod_0(1847) + string_2 + Class178.smethod_0(1864);
	}

	[CompilerGenerated]
	private void method_3()
	{
		label_0.Text = Class178.smethod_0(1869);
	}

	[CompilerGenerated]
	private void method_4(object object_0)
	{
		if (bool_0)
		{
			bool flag = false;
			try
			{
				string address = string_0.Replace(Class178.smethod_0(1902), Class178.smethod_0(1915));
				IEnumerator enumerator = Regex.Matches(class20_0.DownloadString(address), Class178.smethod_0(1936)).GetEnumerator();
				try
				{
					string value = default(string);
					while (true)
					{
						IL_013a:
						int num;
						int num2;
						if (!enumerator.MoveNext())
						{
							num = -549956804;
							num2 = -549956804;
						}
						else
						{
							num = -466365456;
							num2 = -466365456;
						}
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)(num ^ -1523805111)) % 7)
							{
							case 5u:
								num = (int)((num3 * 1272139222) ^ 0x7AC520C4);
								continue;
							case 3u:
								flag = true;
								num = ((int)num3 * -54244233) ^ 0x128298DE;
								continue;
							case 2u:
								class20_0.DownloadDataAsync(new Uri(value));
								num = (int)((num3 * 315993970) ^ 0x5845D99F);
								continue;
							case 1u:
							{
								value = ((Match)enumerator.Current).Groups[Class178.smethod_0(1969)].Value;
								int num4;
								if (value.IndexOf(string_2, StringComparison.OrdinalIgnoreCase) == -1)
								{
									num = -1311954052;
									num4 = -1311954052;
								}
								else
								{
									num = -1203052117;
									num4 = -1203052117;
								}
								continue;
							}
							case 0u:
								num = -466365456;
								continue;
							default:
								goto end_IL_00fd;
							case 6u:
								break;
							case 4u:
								goto end_IL_00fd;
							}
							goto IL_013a;
							continue;
							end_IL_00fd:
							break;
						}
						break;
					}
				}
				finally
				{
					if (enumerator is IDisposable disposable)
					{
						while (true)
						{
							IL_018a:
							int num5 = -1067037714;
							while (true)
							{
								uint num3;
								switch ((num3 = (uint)(num5 ^ -1523805111)) % 3)
								{
								case 1u:
									goto IL_0157;
								default:
									goto end_IL_016c;
								case 2u:
									break;
								case 0u:
									goto end_IL_016c;
								}
								goto IL_018a;
								IL_0157:
								disposable.Dispose();
								num5 = (int)((num3 * 964328149) ^ 0x51C77B80);
								continue;
								end_IL_016c:
								break;
							}
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
				goto IL_01ed;
			}
			return;
		}
		goto IL_0218;
		IL_01f2:
		int num6;
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num6 ^ -1523805111)) % 5)
			{
			case 3u:
				MessageBox.Show(Class178.smethod_0(1978) + string_2 + Class178.smethod_0(2023), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Process.Start(string_0);
				num6 = (int)((num3 * 766058975) ^ 0x4B474E8F);
				continue;
			case 2u:
				break;
			default:
				return;
			case 4u:
				goto IL_0218;
			case 0u:
				return;
			case 1u:
				return;
			}
			break;
		}
		goto IL_01ed;
		IL_0218:
		class20_0.DownloadDataAsync(new Uri(string_0));
		num6 = -811558667;
		goto IL_01f2;
		IL_01ed:
		num6 = -976391202;
		goto IL_01f2;
	}
}
