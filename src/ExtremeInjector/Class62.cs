using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal class Class62 : Class56
{
	public Class62(uint uint_0, uint uint_1)
		: base(Class49.struct20_0)
	{
		Struct9 struct9_ = default(Struct9);
		while (true)
		{
			int num = -811697026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1656931952)) % 5)
				{
				case 4u:
					struct9_.uint_0 = Class49.uint_0;
					num = ((int)num2 * -937263064) ^ 0x47C0D6B8;
					continue;
				case 2u:
					struct9_ = Class171.smethod_187((Class56)this);
					struct9_.enum8_0 = Enum8.flag_1;
					struct9_.byte_0 = (byte)uint_1;
					num = (int)(num2 * 40342304) ^ -1913491811;
					continue;
				case 0u:
					struct9_.uint_1 = uint_0;
					Class171.smethod_274((Class56)this, struct9_);
					num = ((int)num2 * -1295476480) ^ -1633021472;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public override bool Class56_002E_202D_200F_202A_206A_206A_206B_200D_206A_202D_200C_206C_202B_202D_200D_200B_200C_206B_206E_200D_200F_206F_200C_206B_200C_206B_200F_200B_200F_206A_202D_202B_200B_206E_202D_202E_200C_200C_202E_200F_206B_202E(object obj)
	{
		Class62 @class = obj as Class62;
		while (true)
		{
			int num = -883041979;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ -990005344)) % 4)
				{
				case 1u:
				{
					int num4;
					if (Class171.smethod_133((Class62)null, @class))
					{
						num3 = -1864291848;
						num4 = -1864291848;
					}
					else
					{
						num3 = -2137625157;
						num4 = -2137625157;
					}
					goto IL_0028;
				}
				case 2u:
					break;
				case 0u:
					return false;
				default:
					return Class171.smethod_332(this) == Class171.smethod_332(@class);
				}
				break;
				IL_0028:
				num = num3 ^ ((int)num2 * -1830854136);
			}
		}
	}

	public override int Class56_002E_202E_206B_202C_206C_206C_202A_206C_206A_206C_206F_206B_200D_202C_200E_202D_206E_206F_206E_202B_206D_202C_202A_200E_202E_202B_200B_202B_202C_200F_206E_206D_206A_200D_206D_200E_206A_200E_206A_200B_200D_202E()
	{
		return Class171.smethod_332(this).GetHashCode();
	}
}
