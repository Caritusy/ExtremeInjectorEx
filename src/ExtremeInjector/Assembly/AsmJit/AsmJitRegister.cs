using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public class AsmJitRegister : AsmJitOperand
{
	public AsmJitRegister(uint uint_0, uint uint_1)
		: base(AsmJitRuntime.struct20_0)
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
					struct9_.uint_0 = AsmJitRuntime.uint_0;
					num = ((int)num2 * -937263064) ^ 0x47C0D6B8;
					continue;
				case 2u:
					struct9_ = RecoveredRuntime.smethod_188(this);
					struct9_.enum8_0 = AsmJitOperandType.flag_1;
					struct9_.byte_0 = (byte)uint_1;
					num = (int)(num2 * 40342304) ^ -1913491811;
					continue;
				case 0u:
					struct9_.uint_1 = uint_0;
					RecoveredRuntime.smethod_280(this, struct9_);
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
		AsmJitRegister @class = obj as AsmJitRegister;
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
					num3 = ((!RecoveredRuntime.smethod_134(null, @class)) ? (-2137625157) : (-1864291848));
					goto IL_0028;
				case 2u:
					break;
				case 0u:
					return false;
				default:
					return RecoveredRuntime.smethod_338(this) == RecoveredRuntime.smethod_338(@class);
				}
				break;
				IL_0028:
				num = num3 ^ ((int)num2 * -1830854136);
			}
		}
	}

	public override int GetHashCode()
	{
		return RecoveredRuntime.smethod_338(this).GetHashCode();
	}
}
