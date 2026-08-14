using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using ExtremeInjector;

public sealed class GForm1 : Form
{
	internal sealed class Class32
	{
		[CompilerGenerated]
		private sealed class Class33
		{
			public string string_0;

			public Func<object, bool> func_0;

			internal bool method_0(FieldInfo fieldInfo_0)
			{
				return fieldInfo_0.GetCustomAttributes(inherit: false).Any((object object_0) => object_0 is DataMemberAttribute && ((DataMemberAttribute)object_0).Name == string_0);
			}

			internal bool method_1(object object_0)
			{
				if (object_0 is DataMemberAttribute)
				{
					return ((DataMemberAttribute)object_0).Name == string_0;
				}
				return false;
			}
		}

		[CompilerGenerated]
		private CheckBox checkBox_0;

		[CompilerGenerated]
		private FieldInfo fieldInfo_0;

		[SpecialName]
		[CompilerGenerated]
		public CheckBox method_0()
		{
			return checkBox_0;
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_1(CheckBox checkBox_1)
		{
			checkBox_0 = checkBox_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public FieldInfo method_2()
		{
			return fieldInfo_0;
		}

		[SpecialName]
		[CompilerGenerated]
		private void method_3(FieldInfo fieldInfo_1)
		{
			fieldInfo_0 = fieldInfo_1;
		}

		public Class32(string string_0, CheckBox checkBox_1)
		{
			method_1(checkBox_1);
			method_3(((Class32)(object)typeof(InjectorScrambleOptions)).method_4().First((FieldInfo fieldInfo_0) => fieldInfo_0.GetCustomAttributes(inherit: false).Any((object object_0) => object_0 is DataMemberAttribute && ((DataMemberAttribute)object_0).Name == string_0)));
		}

		FieldInfo[] method_4()
		{
			return ((Type)this).GetFields();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class Class34
	{
		public static readonly Class34 _003C_003E9 = new Class34();

		public static EventHandler _003C_003E9__3_0;

		internal void method_0(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			FieldInfo fieldInfo = default(FieldInfo);
			while (true)
			{
				int num = -1750369519;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -2048042955)) % 8)
					{
					case 7u:
						fieldInfo.SetValue(Class12.class12_0.class14_0.injectorScrambleOptions_0, checkBox.Checked);
						num = -305095817;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (!(fieldInfo == null))
						{
							num5 = 1750423734;
							num6 = 1750423734;
						}
						else
						{
							num5 = 341420472;
							num6 = 341420472;
						}
						num = num5 ^ (int)(num2 * 88021122);
						continue;
					}
					case 5u:
						fieldInfo = checkBox.Tag as FieldInfo;
						num = -1058975229;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (checkBox == null)
						{
							num3 = -1329302106;
							num4 = -1329302106;
						}
						else
						{
							num3 = -1438641648;
							num4 = -1438641648;
						}
						num = num3 ^ (int)(num2 * 844439786);
						continue;
					}
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					case 2u:
						return;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	private IContainer icontainer_0;

	internal GroupBox groupBox_0;

	internal CheckBox checkBox_0;

	internal CheckBox checkBox_1;

	internal GroupBox groupBox_1;

	internal CheckBox checkBox_2;

	internal CheckBox checkBox_3;

	internal CheckBox checkBox_4;

	internal CheckBox checkBox_5;

	internal CheckBox checkBox_6;

	internal GroupBox groupBox_2;

	internal CheckBox checkBox_7;

	internal CheckBox checkBox_8;

	internal CheckBox checkBox_9;

	internal CheckBox checkBox_10;

	internal CheckBox checkBox_11;

	internal CheckBox checkBox_12;

	public GForm1()
	{
		Class171.smethod_228(this);
		checkBox_3.CheckedChanged += delegate
		{
			Class171.smethod_231(this);
		};
		Class171.smethod_104(this, (IEnumerable<Class32>)new Class32[13]
		{
			new Class32(Class178.smethod_0(1018), checkBox_0),
			new Class32(Class178.smethod_0(1047), checkBox_1),
			new Class32(Class178.smethod_0(1072), checkBox_3),
			new Class32(Class178.smethod_0(1101), checkBox_2),
			new Class32(Class178.smethod_0(1126), checkBox_4),
			new Class32(Class178.smethod_0(1151), checkBox_5),
			new Class32(Class178.smethod_0(1172), checkBox_6),
			new Class32(Class178.smethod_0(1201), checkBox_8),
			new Class32(Class178.smethod_0(1226), checkBox_10),
			new Class32(Class178.smethod_0(1247), checkBox_7),
			new Class32(Class178.smethod_0(1276), checkBox_9),
			new Class32(Class178.smethod_0(1309), checkBox_12),
			new Class32(Class178.smethod_0(1334), checkBox_11)
		});
		Class171.smethod_231(this);
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing)
		{
			while (true)
			{
				int num = -819503620;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -468039133)) % 4)
					{
					case 3u:
					{
						int num3;
						int num4;
						if (icontainer_0 == null)
						{
							num3 = -624615149;
							num4 = -624615149;
						}
						else
						{
							num3 = -297161400;
							num4 = -297161400;
						}
						num = num3 ^ (int)(num2 * 1811205811);
						continue;
					}
					case 2u:
						icontainer_0.Dispose();
						num = ((int)num2 * -1637467239) ^ -1396314904;
						continue;
					case 0u:
						break;
					default:
						goto end_IL_0067;
					}
					break;
				}
				continue;
				end_IL_0067:
				break;
			}
		}
		Dispose(disposing);
	}

	[CompilerGenerated]
	private void checkBox_3_CheckedChanged(object sender, EventArgs e)
	{
		Class171.smethod_231(this);
	}
}
