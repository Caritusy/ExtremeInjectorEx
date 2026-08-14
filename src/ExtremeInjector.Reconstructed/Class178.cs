using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

public sealed class Class178
{
	private static readonly string string_0;

	private static readonly string string_1;

	private static readonly byte[] byte_0;

	private static readonly Dictionary<int, string> dictionary_0;

	private static readonly object object_0;

	private static readonly bool bool_0;

	private static readonly int int_0;

	public static string smethod_0(int int_1)
	{
		int_1 -= int_0;
		string result = default(string);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			int num = 1534672999;
			while (true)
			{
				int num4;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5227590F)) % 3)
				{
				case 1u:
					if (bool_0)
					{
						goto IL_0015;
					}
					goto IL_00b1;
				case 0u:
					break;
				default:
					{
						lock (object_0)
						{
							dictionary_0.TryGetValue(int_1, out var value);
							if (value != null)
							{
								while (true)
								{
									IL_009b:
									int num3 = 1335756900;
									while (true)
									{
										switch ((num2 = (uint)(num3 ^ 0x5227590F)) % 4)
										{
										case 3u:
											goto IL_0068;
										default:
											goto end_IL_0079;
										case 0u:
											break;
										case 1u:
											goto end_IL_0079;
										case 2u:
											goto IL_0289;
										}
										goto IL_009b;
										IL_0068:
										result = value;
										num3 = (int)(num2 * 1511108956) ^ -383116683;
										continue;
										end_IL_0079:
										break;
									}
									break;
								}
							}
						}
						goto IL_00b1;
					}
					IL_00b1:
					num4 = 0;
					while (true)
					{
						int num5 = 692546890;
						while (true)
						{
							int index;
							switch ((num2 = (uint)(num5 ^ 0x5227590F)) % 10)
							{
							case 9u:
							{
								int num7;
								int num8;
								if ((num6 & 0x80) != 0)
								{
									num7 = 287165552;
									num8 = 287165552;
								}
								else
								{
									num7 = 422546357;
									num8 = 422546357;
								}
								num5 = num7 ^ ((int)num2 * -1221901953);
								continue;
							}
							case 7u:
								num4 = num6;
								if (num4 == 0)
								{
									num5 = (int)((num2 * 272569035) ^ 0x67BE75C1);
									continue;
								}
								goto case 2u;
							case 5u:
								index = int_1;
								num5 = (int)((num2 * 689227500) ^ 0x439C3890);
								continue;
							case 4u:
								break;
							case 3u:
								num6 = byte_0[index++];
								num5 = ((int)num2 * -839024009) ^ -1862879569;
								continue;
							case 0u:
								num4 = ((num6 & 0x3F) << 8) + byte_0[index++];
								num5 = ((int)num2 * -1319502137) ^ 0x273EB3EB;
								continue;
							case 8u:
								goto end_IL_016c;
							case 1u:
								return string.Empty;
							default:
								num4 = ((num6 & 0x1F) << 24) + (byte_0[index++] << 16) + (byte_0[index++] << 8) + byte_0[index++];
								goto case 2u;
							case 2u:
								try
								{
									byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(byte_0, index, num4));
									while (true)
									{
										IL_0246:
										int num9 = 449640665;
										while (true)
										{
											switch ((num2 = (uint)(num9 ^ 0x5227590F)) % 3)
											{
											case 1u:
												goto IL_0202;
											case 0u:
												break;
											default:
												if (bool_0)
												{
													try
													{
														lock (object_0)
														{
															dictionary_0.Add(int_1, text);
														}
													}
													catch
													{
													}
												}
												result = text;
												goto end_IL_0228;
											}
											goto IL_0246;
											IL_0202:
											text = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
											num9 = ((int)num2 * -1283988837) ^ 0x13A36B80;
											continue;
											end_IL_0228:
											break;
										}
										break;
									}
								}
								catch
								{
									result = null;
								}
								goto end_IL_01a7;
							}
							int num10;
							if ((num6 & 0x40) == 0)
							{
								num5 = 2012916853;
								num10 = 2012916853;
							}
							else
							{
								num5 = 1460727029;
								num10 = 1460727029;
							}
							continue;
							end_IL_016c:
							break;
						}
						continue;
						end_IL_01a7:
						break;
					}
					goto IL_0289;
					IL_0289:
					return result;
				}
				break;
				IL_0015:
				num = (int)((num2 * 1768309251) ^ 0x5B77C7E9);
			}
		}
	}

	static Class178()
	{
		string_0 = global::_003CModule_003E.smethod_6<string>(1174137030u);
		byte[] array = default(byte[]);
		while (true)
		{
			int num = 290985342;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4EAC7DC8)) % 9)
				{
				case 8u:
					int_0 = Convert.ToInt32(string_1);
					num = 965384964;
					continue;
				case 7u:
					string_1 = global::_003CModule_003E.smethod_5<string>(1533425201u);
					num = ((int)num2 * -388102863) ^ -1794753634;
					continue;
				case 4u:
					byte_0 = null;
					num = ((int)num2 * -1115553388) ^ 0x72AEE08F;
					continue;
				case 3u:
					bool_0 = true;
					num = (int)(num2 * 1329307971) ^ -626639867;
					continue;
				case 2u:
					dictionary_0 = new Dictionary<int, string>();
					num = ((int)num2 * -773986314) ^ 0x95C18B1;
					continue;
				case 1u:
				{
					int_0 = 0;
					int num6;
					int num7;
					if (string_0 == global::_003CModule_003E.smethod_3<string>(1753162200u))
					{
						num6 = 1778634209;
						num7 = 1778634209;
					}
					else
					{
						num6 = 1452500361;
						num7 = 1452500361;
					}
					num = num6 ^ ((int)num2 * -1987377030);
					continue;
				}
				case 0u:
					object_0 = new object();
					bool_0 = false;
					num = (int)(num2 * 133856894) ^ -608629664;
					continue;
				case 5u:
					break;
				default:
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(global::_003CModule_003E.smethod_5<string>(460238251u));
					try
					{
						int num3 = Convert.ToInt32(manifestResourceStream.Length);
						while (true)
						{
							int num4 = 1294845014;
							while (true)
							{
								switch ((num2 = (uint)(num4 ^ 0x4EAC7DC8)) % 4)
								{
								case 2u:
									array = new byte[num3];
									num4 = (int)((num2 * 560776137) ^ 0x233238F3);
									continue;
								case 1u:
									manifestResourceStream.Read(array, 0, num3);
									byte_0 = Class171.smethod_387(array);
									num4 = (int)(num2 * 427632772) ^ -391743592;
									continue;
								case 3u:
									break;
								default:
									array = null;
									manifestResourceStream.Close();
									return;
								}
								break;
							}
						}
					}
					finally
					{
						if (manifestResourceStream != null)
						{
							while (true)
							{
								IL_01fb:
								int num5 = 154755588;
								while (true)
								{
									switch ((num2 = (uint)(num5 ^ 0x4EAC7DC8)) % 3)
									{
									case 2u:
										goto IL_01c9;
									default:
										goto end_IL_01dd;
									case 0u:
										break;
									case 1u:
										goto end_IL_01dd;
									}
									goto IL_01fb;
									IL_01c9:
									((IDisposable)manifestResourceStream).Dispose();
									num5 = ((int)num2 * -250368079) ^ -520984247;
									continue;
									end_IL_01dd:
									break;
								}
								break;
							}
						}
					}
				}
				}
				break;
			}
		}
	}
}
