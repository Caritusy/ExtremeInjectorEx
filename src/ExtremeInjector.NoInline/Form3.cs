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

public sealed class Form3 : Form
{
	[CompilerGenerated]
	public sealed class Class35
	{
		public DownloadProgressChangedEventArgs downloadProgressChangedEventArgs_0;

		public Form3 form3_0;

		internal void method_0()
		{
			smethod_1(form3_0.progressBar_0, smethod_0(downloadProgressChangedEventArgs_0));
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
						text = null;
						num = ((smethod_3(smethod_2(form3_0.class20_0), Class178.smethod_0(3814)) == null) ? 454574697 : 276394693) ^ (int)(num2 * 1224346641);
						continue;
					case 7u:
						text = form3_0.string_2;
						num = ((int)num2 * -584978239) ^ -1271616069;
						continue;
					case 5u:
						text = smethod_10(smethod_9(smethod_8(smethod_7(form3_0.string_0))));
						num = (int)((num2 * 522087323) ^ 0x3DBD0C68);
						continue;
					case 3u:
						smethod_14(form3_0.label_0, smethod_13(new string[7]
						{
							Class178.smethod_0(3843),
							text,
							Class178.smethod_0(3860),
							Class171.smethod_442(smethod_11(downloadProgressChangedEventArgs_0)),
							Class178.smethod_0(3869),
							Class171.smethod_442(smethod_12(downloadProgressChangedEventArgs_0)),
							Class178.smethod_0(3874)
						}));
						num = -2111451650;
						continue;
					case 2u:
						num = ((!smethod_6(text)) ? (-2032280084) : (-1961673711));
						continue;
					case 1u:
						num = (smethod_6(text) ? (-1165123445) : (-724793491));
						continue;
					case 0u:
						text = smethod_5(smethod_4(smethod_3(smethod_2(form3_0.class20_0), Class178.smethod_0(3814))));
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

		internal static int smethod_0(ProgressChangedEventArgs progressChangedEventArgs_0)
		{
			return progressChangedEventArgs_0.ProgressPercentage;
		}

		internal static void smethod_1(ProgressBar progressBar_0, int int_0)
		{
			progressBar_0.Value = int_0;
		}

		internal static WebHeaderCollection smethod_2(WebClient webClient_0)
		{
			return webClient_0.ResponseHeaders;
		}

		internal static string smethod_3(NameValueCollection nameValueCollection_0, string string_0)
		{
			return nameValueCollection_0[string_0];
		}

		internal static ContentDisposition smethod_4(string string_0)
		{
			return new ContentDisposition(string_0);
		}

		internal static string smethod_5(ContentDisposition contentDisposition_0)
		{
			return contentDisposition_0.FileName;
		}

		internal static bool smethod_6(string string_0)
		{
			return string.IsNullOrEmpty(string_0);
		}

		internal static Uri smethod_7(string string_0)
		{
			return new Uri(string_0);
		}

		internal static string smethod_8(Uri uri_0)
		{
			return uri_0.AbsolutePath;
		}

		internal static string smethod_9(string string_0)
		{
			return Path.GetFileName(string_0);
		}

		internal static string smethod_10(string string_0)
		{
			return Uri.UnescapeDataString(string_0);
		}

		internal static long smethod_11(DownloadProgressChangedEventArgs downloadProgressChangedEventArgs_1)
		{
			return downloadProgressChangedEventArgs_1.BytesReceived;
		}

		internal static long smethod_12(DownloadProgressChangedEventArgs downloadProgressChangedEventArgs_1)
		{
			return downloadProgressChangedEventArgs_1.TotalBytesToReceive;
		}

		internal static string smethod_13(string[] string_0)
		{
			return string.Concat(string_0);
		}

		internal static void smethod_14(Control control_0, string string_0)
		{
			control_0.Text = string_0;
		}
	}

	[CompilerGenerated]
	public sealed class Class36
	{
		public DownloadDataCompletedEventArgs downloadDataCompletedEventArgs_0;

		public Form3 form3_0;

		public WaitCallback waitCallback_0;

		internal void method_0()
		{
			if (smethod_0(downloadDataCompletedEventArgs_0) != null)
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
					smethod_4(form3_0);
					num = ((int)num2 * -1958857336) ^ -1983099817;
					continue;
				case 1u:
					smethod_3(form3_0, smethod_2(Class178.smethod_0(3879), smethod_1(smethod_0(downloadDataCompletedEventArgs_0))), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					num = (int)(num2 * 977009865) ^ -647304280;
					continue;
				case 3u:
					goto IL_009f;
				default:
					smethod_6(delegate
					{
						bool flag = true;
						Process process = default(Process);
						while (true)
						{
							int num3 = -289592701;
							while (true)
							{
								int num10;
								uint num4;
								switch ((num4 = (uint)(num3 ^ -265431999)) % 3)
								{
								case 1u:
								{
									if (form3_0.bool_0)
									{
										goto IL_0011;
									}
									smethod_7(form3_0, (MethodInvoker)delegate
									{
										Form3.smethod_7((Control)form3_0.label_0, Class178.smethod_0(1869));
									});
									MemoryStream memoryStream = smethod_23(smethod_13(downloadDataCompletedEventArgs_0));
									try
									{
										ZipFile val = smethod_24(memoryStream);
										try
										{
											IEnumerator<ZipEntry> enumerator = smethod_25(val);
											try
											{
												while (smethod_27(enumerator))
												{
													ZipEntry current = enumerator.Current;
													try
													{
														smethod_26(current, form3_0.string_1, (ExtractExistingFileAction)1);
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
														int num7 = -1342398227;
														while (true)
														{
															switch ((num4 = (uint)(num7 ^ -265431999)) % 3)
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
															smethod_28(enumerator);
															num7 = (int)((num4 * 1770200392) ^ 0x4BFB0E45);
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
													int num8 = -852231878;
													while (true)
													{
														switch ((num4 = (uint)(num8 ^ -265431999)) % 3)
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
														smethod_28((IDisposable)val);
														num8 = ((int)num4 * -1297051926) ^ -25082576;
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
												int num9 = -2136234169;
												while (true)
												{
													switch ((num4 = (uint)(num9 ^ -265431999)) % 3)
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
													smethod_28(memoryStream);
													num9 = (int)(num4 * 1999367492) ^ -1472965522;
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
										smethod_7(form3_0, (MethodInvoker)delegate
										{
											Form3.smethod_7((Control)form3_0.label_0, Form3.smethod_6(Class178.smethod_0(1847), form3_0.string_2, Class178.smethod_0(1864)));
										});
										try
										{
											string string_ = smethod_10(smethod_8(), smethod_9());
											if (!smethod_11(string_))
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
													smethod_16(process);
													num5 = ((smethod_17(process) == 0) ? 1936168321 : 993833967) ^ ((int)num4 * -761573537);
													continue;
												case 8u:
													smethod_20(100);
													num5 = -95280532;
													continue;
												case 7u:
													smethod_21(string_);
													num5 = (int)((num4 * 1351960756) ^ 0x7BBE07A0);
													continue;
												case 6u:
													break;
												case 4u:
													smethod_12(string_);
													num5 = ((int)num4 * -1883058446) ^ 0x509B7DE2;
													continue;
												case 3u:
													num5 = ((process != null) ? 435269807 : 443513832) ^ (int)(num4 * 336045675);
													continue;
												case 2u:
													smethod_14(string_, smethod_13(downloadDataCompletedEventArgs_0));
													num5 = (int)(num4 * 1784209556) ^ -562088028;
													continue;
												case 1u:
													process = smethod_15(string_);
													num5 = (int)((num4 * 1017596815) ^ 0x79058A02);
													continue;
												default:
													goto end_IL_019a;
												case 9u:
													goto IL_02c9;
												case 0u:
													throw smethod_19(smethod_18(Class178.smethod_0(3956), smethod_17(process)));
												case 5u:
													goto end_IL_019a;
												}
												break;
											}
											goto IL_0211;
											IL_02c9:
											string_ = smethod_10(string_, form3_0.string_2);
											num5 = -1790331266;
											goto IL_028a;
											end_IL_019a:;
										}
										catch (Exception exception_)
										{
											while (true)
											{
												IL_035d:
												int num6 = -187471593;
												while (true)
												{
													switch ((num4 = (uint)(num6 ^ -265431999)) % 3)
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
													smethod_22(smethod_2(Class178.smethod_0(4029), smethod_1(exception_)), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
													flag = false;
													num6 = ((int)num4 * -893526725) ^ 0x3B80B715;
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
									num10 = -1782048388;
									goto IL_039d;
									IL_0366:
									if (flag)
									{
										goto IL_0398;
									}
									goto IL_03bf;
									IL_03bf:
									smethod_7(form3_0, new MethodInvoker(form3_0.Close));
									num10 = -1327381341;
									goto IL_039d;
									IL_039d:
									while (true)
									{
										switch ((num4 = (uint)(num10 ^ -265431999)) % 4)
										{
										case 1u:
											smethod_22(Class178.smethod_0(4102), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
											num10 = (int)((num4 * 1571657903) ^ 0x24EA10B1);
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
			smethod_5(form3_0.progressBar_0, 100);
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
					int num8;
					uint num2;
					switch ((num2 = (uint)(num ^ -265431999)) % 3)
					{
					case 1u:
					{
						if (form3_0.bool_0)
						{
							goto IL_0011;
						}
						smethod_7(form3_0, (MethodInvoker)delegate
						{
							Form3.smethod_7((Control)form3_0.label_0, Class178.smethod_0(1869));
						});
						MemoryStream memoryStream = smethod_23(smethod_13(downloadDataCompletedEventArgs_0));
						try
						{
							ZipFile val = smethod_24(memoryStream);
							try
							{
								IEnumerator<ZipEntry> enumerator = smethod_25(val);
								try
								{
									while (smethod_27(enumerator))
									{
										ZipEntry current = enumerator.Current;
										try
										{
											smethod_26(current, form3_0.string_1, (ExtractExistingFileAction)1);
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
											int num5 = -1342398227;
											while (true)
											{
												switch ((num2 = (uint)(num5 ^ -265431999)) % 3)
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
												smethod_28(enumerator);
												num5 = (int)((num2 * 1770200392) ^ 0x4BFB0E45);
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
										int num6 = -852231878;
										while (true)
										{
											switch ((num2 = (uint)(num6 ^ -265431999)) % 3)
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
											smethod_28((IDisposable)val);
											num6 = ((int)num2 * -1297051926) ^ -25082576;
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
									int num7 = -2136234169;
									while (true)
									{
										switch ((num2 = (uint)(num7 ^ -265431999)) % 3)
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
										smethod_28(memoryStream);
										num7 = (int)(num2 * 1999367492) ^ -1472965522;
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
							smethod_7(form3_0, (MethodInvoker)delegate
							{
								Form3.smethod_7((Control)form3_0.label_0, Form3.smethod_6(Class178.smethod_0(1847), form3_0.string_2, Class178.smethod_0(1864)));
							});
							try
							{
								string string_ = smethod_10(smethod_8(), smethod_9());
								if (!smethod_11(string_))
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
										smethod_16(process);
										num3 = ((smethod_17(process) == 0) ? 1936168321 : 993833967) ^ ((int)num2 * -761573537);
										continue;
									case 8u:
										smethod_20(100);
										num3 = -95280532;
										continue;
									case 7u:
										smethod_21(string_);
										num3 = (int)((num2 * 1351960756) ^ 0x7BBE07A0);
										continue;
									case 6u:
										break;
									case 4u:
										smethod_12(string_);
										num3 = ((int)num2 * -1883058446) ^ 0x509B7DE2;
										continue;
									case 3u:
										num3 = ((process != null) ? 435269807 : 443513832) ^ (int)(num2 * 336045675);
										continue;
									case 2u:
										smethod_14(string_, smethod_13(downloadDataCompletedEventArgs_0));
										num3 = (int)(num2 * 1784209556) ^ -562088028;
										continue;
									case 1u:
										process = smethod_15(string_);
										num3 = (int)((num2 * 1017596815) ^ 0x79058A02);
										continue;
									default:
										goto end_IL_019a;
									case 9u:
										goto IL_02c9;
									case 0u:
										throw smethod_19(smethod_18(Class178.smethod_0(3956), smethod_17(process)));
									case 5u:
										goto end_IL_019a;
									}
									break;
								}
								goto IL_0211;
								IL_02c9:
								string_ = smethod_10(string_, form3_0.string_2);
								num3 = -1790331266;
								goto IL_028a;
								end_IL_019a:;
							}
							catch (Exception exception_)
							{
								while (true)
								{
									IL_035d:
									int num4 = -187471593;
									while (true)
									{
										switch ((num2 = (uint)(num4 ^ -265431999)) % 3)
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
										smethod_22(smethod_2(Class178.smethod_0(4029), smethod_1(exception_)), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
										flag = false;
										num4 = ((int)num2 * -893526725) ^ 0x3B80B715;
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
						num8 = -1782048388;
						goto IL_039d;
						IL_0366:
						if (flag)
						{
							goto IL_0398;
						}
						goto IL_03bf;
						IL_03bf:
						smethod_7(form3_0, new MethodInvoker(form3_0.Close));
						num8 = -1327381341;
						goto IL_039d;
						IL_039d:
						while (true)
						{
							switch ((num2 = (uint)(num8 ^ -265431999)) % 4)
							{
							case 1u:
								smethod_22(Class178.smethod_0(4102), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								num8 = (int)((num2 * 1571657903) ^ 0x24EA10B1);
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

		internal static Exception smethod_0(AsyncCompletedEventArgs asyncCompletedEventArgs_0)
		{
			return asyncCompletedEventArgs_0.Error;
		}

		internal static string smethod_1(Exception exception_0)
		{
			return exception_0.Message;
		}

		internal static string smethod_2(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		internal static DialogResult smethod_3(IWin32Window iwin32Window_0, string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
		{
			return MessageBox.Show(iwin32Window_0, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
		}

		internal static void smethod_4(Form form_0)
		{
			form_0.Close();
		}

		internal static void smethod_5(ProgressBar progressBar_0, int int_0)
		{
			progressBar_0.Value = int_0;
		}

		internal static bool smethod_6(WaitCallback waitCallback_1)
		{
			return ThreadPool.QueueUserWorkItem(waitCallback_1);
		}

		internal static object smethod_7(Control control_0, Delegate delegate_0)
		{
			return control_0.Invoke(delegate_0);
		}

		internal static string smethod_8()
		{
			return Path.GetTempPath();
		}

		internal static string smethod_9()
		{
			return Path.GetRandomFileName();
		}

		internal static string smethod_10(string string_0, string string_1)
		{
			return Path.Combine(string_0, string_1);
		}

		internal static bool smethod_11(string string_0)
		{
			return Directory.Exists(string_0);
		}

		internal static DirectoryInfo smethod_12(string string_0)
		{
			return Directory.CreateDirectory(string_0);
		}

		internal static byte[] smethod_13(DownloadDataCompletedEventArgs downloadDataCompletedEventArgs_1)
		{
			return downloadDataCompletedEventArgs_1.Result;
		}

		internal static void smethod_14(string string_0, byte[] byte_0)
		{
			File.WriteAllBytes(string_0, byte_0);
		}

		internal static Process smethod_15(string string_0)
		{
			return Process.Start(string_0);
		}

		internal static void smethod_16(Process process_0)
		{
			process_0.WaitForExit();
		}

		internal static int smethod_17(Process process_0)
		{
			return process_0.ExitCode;
		}

		internal static string smethod_18(object object_0, object object_1)
		{
			return string.Concat(object_0, object_1);
		}

		internal static Exception smethod_19(string string_0)
		{
			return new Exception(string_0);
		}

		internal static void smethod_20(int int_0)
		{
			Thread.Sleep(int_0);
		}

		internal static void smethod_21(string string_0)
		{
			File.Delete(string_0);
		}

		internal static DialogResult smethod_22(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
		{
			return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
		}

		internal static MemoryStream smethod_23(byte[] byte_0)
		{
			return new MemoryStream(byte_0);
		}

		internal static ZipFile smethod_24(Stream stream_0)
		{
			return ZipFile.Read(stream_0);
		}

		internal static IEnumerator<ZipEntry> smethod_25(ZipFile zipFile_0)
		{
			return zipFile_0.GetEnumerator();
		}

		internal static void smethod_26(ZipEntry zipEntry_0, string string_0, ExtractExistingFileAction extractExistingFileAction_0)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			zipEntry_0.Extract(string_0, extractExistingFileAction_0);
		}

		internal static bool smethod_27(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		internal static void smethod_28(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}
	}

	internal bool bool_0;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal Class20 class20_0 = new Class20();

	internal IContainer icontainer_0;

	internal Label label_0;

	internal ProgressBar progressBar_0;

	public Form3()
	{
		Class171.smethod_114(this);
		smethod_0(class20_0, method_1);
		smethod_1(class20_0, method_0);
	}

	internal void method_0(object sender, DownloadProgressChangedEventArgs e)
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
				smethod_2(this, (MethodInvoker)delegate
				{
					Class35.smethod_1(form3_0.progressBar_0, Class35.smethod_0(downloadProgressChangedEventArgs_0));
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
								text = null;
								num3 = ((Class35.smethod_3(Class35.smethod_2(form3_0.class20_0), Class178.smethod_0(3814)) == null) ? 454574697 : 276394693) ^ (int)(num4 * 1224346641);
								continue;
							case 7u:
								text = form3_0.string_2;
								num3 = ((int)num4 * -584978239) ^ -1271616069;
								continue;
							case 5u:
								text = Class35.smethod_10(Class35.smethod_9(Class35.smethod_8(Class35.smethod_7(form3_0.string_0))));
								num3 = (int)((num4 * 522087323) ^ 0x3DBD0C68);
								continue;
							case 3u:
								Class35.smethod_14(form3_0.label_0, Class35.smethod_13(new string[7]
								{
									Class178.smethod_0(3843),
									text,
									Class178.smethod_0(3860),
									Class171.smethod_442(Class35.smethod_11(downloadProgressChangedEventArgs_0)),
									Class178.smethod_0(3869),
									Class171.smethod_442(Class35.smethod_12(downloadProgressChangedEventArgs_0)),
									Class178.smethod_0(3874)
								}));
								num3 = -2111451650;
								continue;
							case 2u:
								num3 = ((!Class35.smethod_6(text)) ? (-2032280084) : (-1961673711));
								continue;
							case 1u:
								num3 = (Class35.smethod_6(text) ? (-1165123445) : (-724793491));
								continue;
							case 0u:
								text = Class35.smethod_5(Class35.smethod_4(Class35.smethod_3(Class35.smethod_2(form3_0.class20_0), Class178.smethod_0(3814))));
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

	internal void method_1(object sender, DownloadDataCompletedEventArgs e)
	{
		smethod_2(this, (MethodInvoker)delegate
		{
			if (Class36.smethod_0(e) != null)
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
					Class36.smethod_4(this);
					num = ((int)num2 * -1958857336) ^ -1983099817;
					continue;
				case 1u:
					Class36.smethod_3(this, Class36.smethod_2(Class178.smethod_0(3879), Class36.smethod_1(Class36.smethod_0(e))), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					num = (int)(num2 * 977009865) ^ -647304280;
					continue;
				case 3u:
					goto IL_009f;
				default:
					Class36.smethod_6(delegate
					{
						bool flag = true;
						Process process = default(Process);
						while (true)
						{
							int num3 = -289592701;
							while (true)
							{
								int num10;
								uint num4;
								switch ((num4 = (uint)(num3 ^ -265431999)) % 3)
								{
								case 1u:
								{
									if (bool_0)
									{
										goto IL_0011;
									}
									Class36.smethod_7(this, (MethodInvoker)delegate
									{
										smethod_7(label_0, Class178.smethod_0(1869));
									});
									MemoryStream memoryStream = Class36.smethod_23(Class36.smethod_13(e));
									try
									{
										ZipFile val = Class36.smethod_24(memoryStream);
										try
										{
											IEnumerator<ZipEntry> enumerator = Class36.smethod_25(val);
											try
											{
												while (Class36.smethod_27(enumerator))
												{
													ZipEntry current = enumerator.Current;
													try
													{
														Class36.smethod_26(current, string_1, (ExtractExistingFileAction)1);
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
														int num7 = -1342398227;
														while (true)
														{
															switch ((num4 = (uint)(num7 ^ -265431999)) % 3)
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
															Class36.smethod_28(enumerator);
															num7 = (int)((num4 * 1770200392) ^ 0x4BFB0E45);
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
													int num8 = -852231878;
													while (true)
													{
														switch ((num4 = (uint)(num8 ^ -265431999)) % 3)
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
														Class36.smethod_28((IDisposable)val);
														num8 = ((int)num4 * -1297051926) ^ -25082576;
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
												int num9 = -2136234169;
												while (true)
												{
													switch ((num4 = (uint)(num9 ^ -265431999)) % 3)
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
													Class36.smethod_28(memoryStream);
													num9 = (int)(num4 * 1999367492) ^ -1472965522;
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
										Class36.smethod_7(this, (MethodInvoker)delegate
										{
											smethod_7(label_0, smethod_6(Class178.smethod_0(1847), string_2, Class178.smethod_0(1864)));
										});
										try
										{
											string text = Class36.smethod_10(Class36.smethod_8(), Class36.smethod_9());
											if (!Class36.smethod_11(text))
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
													Class36.smethod_16(process);
													num5 = ((Class36.smethod_17(process) == 0) ? 1936168321 : 993833967) ^ ((int)num4 * -761573537);
													continue;
												case 8u:
													Class36.smethod_20(100);
													num5 = -95280532;
													continue;
												case 7u:
													Class36.smethod_21(text);
													num5 = (int)((num4 * 1351960756) ^ 0x7BBE07A0);
													continue;
												case 6u:
													break;
												case 4u:
													Class36.smethod_12(text);
													num5 = ((int)num4 * -1883058446) ^ 0x509B7DE2;
													continue;
												case 3u:
													num5 = ((process != null) ? 435269807 : 443513832) ^ (int)(num4 * 336045675);
													continue;
												case 2u:
													Class36.smethod_14(text, Class36.smethod_13(e));
													num5 = (int)(num4 * 1784209556) ^ -562088028;
													continue;
												case 1u:
													process = Class36.smethod_15(text);
													num5 = (int)((num4 * 1017596815) ^ 0x79058A02);
													continue;
												default:
													goto end_IL_019a;
												case 9u:
													goto IL_02c9;
												case 0u:
													throw Class36.smethod_19(Class36.smethod_18(Class178.smethod_0(3956), Class36.smethod_17(process)));
												case 5u:
													goto end_IL_019a;
												}
												break;
											}
											goto IL_0211;
											IL_02c9:
											text = Class36.smethod_10(text, string_2);
											num5 = -1790331266;
											goto IL_028a;
											end_IL_019a:;
										}
										catch (Exception exception_)
										{
											while (true)
											{
												IL_035d:
												int num6 = -187471593;
												while (true)
												{
													switch ((num4 = (uint)(num6 ^ -265431999)) % 3)
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
													Class36.smethod_22(Class36.smethod_2(Class178.smethod_0(4029), Class36.smethod_1(exception_)), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
													flag = false;
													num6 = ((int)num4 * -893526725) ^ 0x3B80B715;
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
									num10 = -1782048388;
									goto IL_039d;
									IL_0366:
									if (flag)
									{
										goto IL_0398;
									}
									goto IL_03bf;
									IL_03bf:
									Class36.smethod_7(this, new MethodInvoker(base.Close));
									num10 = -1327381341;
									goto IL_039d;
									IL_039d:
									while (true)
									{
										switch ((num4 = (uint)(num10 ^ -265431999)) % 4)
										{
										case 1u:
											Class36.smethod_22(Class178.smethod_0(4102), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
											num10 = (int)((num4 * 1571657903) ^ 0x24EA10B1);
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
			Class36.smethod_5(progressBar_0, 100);
			num = -1316627093;
			goto IL_0076;
		});
	}

	internal void method_2(object sender, EventArgs e)
	{
		smethod_3(delegate
		{
			if (bool_0)
			{
				bool flag = false;
				try
				{
					string string_ = smethod_8(string_0, Class178.smethod_0(1902), Class178.smethod_0(1915));
					IEnumerator enumerator = smethod_11(smethod_10(smethod_9(class20_0, string_), Class178.smethod_0(1936)));
					try
					{
						string string_2 = default(string);
						while (true)
						{
							IL_013a:
							int num = (smethod_19(enumerator) ? (-466365456) : (-549956804));
							while (true)
							{
								uint num2;
								switch ((num2 = (uint)(num ^ -1523805111)) % 7)
								{
								case 5u:
									num = (int)((num2 * 1272139222) ^ 0x7AC520C4);
									continue;
								case 3u:
									flag = true;
									num = ((int)num2 * -54244233) ^ 0x128298DE;
									continue;
								case 2u:
									smethod_18(class20_0, smethod_17(string_2));
									num = (int)((num2 * 315993970) ^ 0x5845D99F);
									continue;
								case 1u:
									string_2 = smethod_15(smethod_14(smethod_13((Match)smethod_12(enumerator)), Class178.smethod_0(1969)));
									num = ((smethod_16(string_2, this.string_2, StringComparison.OrdinalIgnoreCase) != -1) ? (-1203052117) : (-1311954052));
									continue;
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
						if (enumerator is IDisposable idisposable_)
						{
							while (true)
							{
								IL_018a:
								int num3 = -1067037714;
								while (true)
								{
									uint num2;
									switch ((num2 = (uint)(num3 ^ -1523805111)) % 3)
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
									smethod_5(idisposable_);
									num3 = (int)((num2 * 964328149) ^ 0x51C77B80);
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
			int num4;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num4 ^ -1523805111)) % 5)
				{
				case 3u:
					smethod_20(smethod_6(Class178.smethod_0(1978), this.string_2, Class178.smethod_0(2023)), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					smethod_21(string_0);
					num4 = (int)((num2 * 766058975) ^ 0x4B474E8F);
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
			smethod_18(class20_0, smethod_17(string_0));
			num4 = -811558667;
			goto IL_01f2;
			IL_01ed:
			num4 = -976391202;
			goto IL_01f2;
		});
	}

	internal void method_3(object sender, FormClosingEventArgs e)
	{
		smethod_4(class20_0);
	}

	protected override void Dispose(bool disposing)
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
				smethod_5(icontainer_0);
				num = ((int)num2 * -1835518553) ^ 0x5DE7C166;
				continue;
			case 1u:
				num = ((icontainer_0 != null) ? (-1555145436) : (-1050585095)) ^ ((int)num2 * -1255079457);
				continue;
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
		base.Dispose(disposing);
		num = 1300235304;
		goto IL_004d;
	}

	[CompilerGenerated]
	internal void method_4()
	{
		smethod_7(label_0, smethod_6(Class178.smethod_0(1847), string_2, Class178.smethod_0(1864)));
	}

	[CompilerGenerated]
	internal void method_5()
	{
		smethod_7(label_0, Class178.smethod_0(1869));
	}

	[CompilerGenerated]
	internal void method_6(object object_0)
	{
		if (bool_0)
		{
			bool flag = false;
			try
			{
				string string_ = smethod_8(string_0, Class178.smethod_0(1902), Class178.smethod_0(1915));
				IEnumerator enumerator = smethod_11(smethod_10(smethod_9(class20_0, string_), Class178.smethod_0(1936)));
				try
				{
					string string_2 = default(string);
					while (true)
					{
						IL_013a:
						int num = (smethod_19(enumerator) ? (-466365456) : (-549956804));
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num ^ -1523805111)) % 7)
							{
							case 5u:
								num = (int)((num2 * 1272139222) ^ 0x7AC520C4);
								continue;
							case 3u:
								flag = true;
								num = ((int)num2 * -54244233) ^ 0x128298DE;
								continue;
							case 2u:
								smethod_18(class20_0, smethod_17(string_2));
								num = (int)((num2 * 315993970) ^ 0x5845D99F);
								continue;
							case 1u:
								string_2 = smethod_15(smethod_14(smethod_13((Match)smethod_12(enumerator)), Class178.smethod_0(1969)));
								num = ((smethod_16(string_2, this.string_2, StringComparison.OrdinalIgnoreCase) != -1) ? (-1203052117) : (-1311954052));
								continue;
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
					if (enumerator is IDisposable idisposable_)
					{
						while (true)
						{
							IL_018a:
							int num3 = -1067037714;
							while (true)
							{
								uint num2;
								switch ((num2 = (uint)(num3 ^ -1523805111)) % 3)
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
								smethod_5(idisposable_);
								num3 = (int)((num2 * 964328149) ^ 0x51C77B80);
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
		int num4;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num4 ^ -1523805111)) % 5)
			{
			case 3u:
				smethod_20(smethod_6(Class178.smethod_0(1978), this.string_2, Class178.smethod_0(2023)), Class178.smethod_0(599), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				smethod_21(string_0);
				num4 = (int)((num2 * 766058975) ^ 0x4B474E8F);
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
		smethod_18(class20_0, smethod_17(string_0));
		num4 = -811558667;
		goto IL_01f2;
		IL_01ed:
		num4 = -976391202;
		goto IL_01f2;
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
