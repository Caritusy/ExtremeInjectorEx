using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Forms;
using ExtremeInjector;

public sealed class GForm1 : Form
{
	public sealed class Class32
	{
		[CompilerGenerated]
		public sealed class Class33
		{
			public string string_0;

			public Func<object, bool> func_0;

			internal bool method_0(FieldInfo fieldInfo_0)
			{
				return smethod_0(fieldInfo_0, bool_0: false).Any((object object_0) => object_0 is DataMemberAttribute && smethod_2(smethod_1((DataMemberAttribute)object_0), string_0));
			}

			internal bool method_1(object object_0)
			{
				if (object_0 is DataMemberAttribute)
				{
					return smethod_2(smethod_1((DataMemberAttribute)object_0), string_0);
				}
				return false;
			}

			internal static object[] smethod_0(MemberInfo memberInfo_0, bool bool_0)
			{
				return memberInfo_0.GetCustomAttributes(bool_0);
			}

			internal static string smethod_1(DataMemberAttribute dataMemberAttribute_0)
			{
				return dataMemberAttribute_0.Name;
			}

			internal static bool smethod_2(string string_1, string string_2)
			{
				return string_1 == string_2;
			}
		}

		[CompilerGenerated]
		internal CheckBox checkBox_0;

		[CompilerGenerated]
		internal FieldInfo fieldInfo_0;

		[SpecialName]
		[CompilerGenerated]
		public CheckBox method_0()
		{
			return checkBox_0;
		}

		[SpecialName]
		[CompilerGenerated]
		internal void method_1(CheckBox checkBox_1)
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
		internal void method_3(FieldInfo fieldInfo_1)
		{
			fieldInfo_0 = fieldInfo_1;
		}

		public Class32(string string_0, CheckBox checkBox_1)
		{
			method_1(checkBox_1);
			method_3(((Class32)(object)smethod_0(typeof(InjectorScrambleOptions).TypeHandle)).method_4().First((FieldInfo fieldInfo_0) => Class33.smethod_0(fieldInfo_0, bool_0: false).Any((object object_0) => object_0 is DataMemberAttribute && Class33.smethod_2(Class33.smethod_1((DataMemberAttribute)object_0), string_0))));
		}

		internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal FieldInfo[] method_4()
		{
			return ((Type)this).GetFields();
		}
	}

	[Serializable]
	[CompilerGenerated]
	public sealed class Class34
	{
		public static readonly Class34 _003C_003E9 = new Class34();

		public static EventHandler _003C_003E9__3_0;

		internal void method_0(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			FieldInfo fieldInfo_ = default(FieldInfo);
			while (true)
			{
				int num = -1750369519;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -2048042955)) % 8)
					{
					case 7u:
						smethod_3(fieldInfo_, Class12.class12_0.class14_0.injectorScrambleOptions_0, smethod_2(checkBox));
						num = -305095817;
						continue;
					case 6u:
						num = (smethod_1(fieldInfo_, null) ? 341420472 : 1750423734) ^ (int)(num2 * 88021122);
						continue;
					case 5u:
						fieldInfo_ = smethod_0(checkBox) as FieldInfo;
						num = -1058975229;
						continue;
					case 4u:
						num = ((checkBox != null) ? (-1438641648) : (-1329302106)) ^ (int)(num2 * 844439786);
						continue;
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

		internal static object smethod_0(Control control_0)
		{
			return control_0.Tag;
		}

		internal static bool smethod_1(FieldInfo fieldInfo_0, FieldInfo fieldInfo_1)
		{
			return fieldInfo_0 == fieldInfo_1;
		}

		internal static bool smethod_2(CheckBox checkBox_0)
		{
			return checkBox_0.Checked;
		}

		internal static void smethod_3(FieldInfo fieldInfo_0, object object_0, object object_1)
		{
			fieldInfo_0.SetValue(object_0, object_1);
		}
	}

	internal IContainer icontainer_0;

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
		Class171.smethod_234(this);
		smethod_0(checkBox_3, delegate
		{
			Class171.smethod_237(this);
		});
		Class171.smethod_104(this, new Class32[13]
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
		Class171.smethod_237(this);
	}

	protected override void Dispose(bool disposing)
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
						num = ((icontainer_0 != null) ? (-297161400) : (-624615149)) ^ (int)(num2 * 1811205811);
						continue;
					case 2u:
						smethod_1(icontainer_0);
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
		base.Dispose(disposing);
	}

	[CompilerGenerated]
	internal void method_0(object sender, EventArgs e)
	{
		Class171.smethod_237(this);
	}

	internal static void smethod_0(CheckBox checkBox_13, EventHandler eventHandler_0)
	{
		checkBox_13.CheckedChanged += eventHandler_0;
	}

	internal static void smethod_1(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
