using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public class Class62 : Class56
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

	public override bool Equals(object obj)
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

	public override int GetHashCode()
	{
		return Class171.smethod_332(this).GetHashCode();
	}
}
