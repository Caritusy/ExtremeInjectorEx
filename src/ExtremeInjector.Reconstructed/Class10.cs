using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public sealed class Class10 : IMessageFilter
{
	public struct Struct5
	{
		public int int_0;

		public int int_1;
	}

	public enum Enum0 : uint
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	public enum Enum1 : uint
	{
		const_0,
		const_1,
		const_2
	}

	public enum Enum2 : uint
	{
		const_0 = 1u,
		const_1
	}

	public struct Struct6
	{
		public uint uint_0;

		public Enum0 enum0_0;
	}

	public static Class10 class10_0 = new Class10();

	[CompilerGenerated]
	internal EventHandler<EventArgs0> eventHandler_0;

	[SpecialName]
	[CompilerGenerated]
	public void method_0(EventHandler<EventArgs0> eventHandler_1)
	{
		EventHandler<EventArgs0> eventHandler = eventHandler_0;
		EventHandler<EventArgs0> eventHandler2 = default(EventHandler<EventArgs0>);
		EventHandler<EventArgs0> value = default(EventHandler<EventArgs0>);
		while (true)
		{
			int num = -76136891;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1715277265)) % 5)
				{
				case 3u:
					eventHandler2 = eventHandler;
					num = -545239564;
					continue;
				case 2u:
				{
					eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
					int num3;
					int num4;
					if ((object)eventHandler == eventHandler2)
					{
						num3 = -1234848759;
						num4 = -1234848759;
					}
					else
					{
						num3 = -1360049409;
						num4 = -1360049409;
					}
					num = num3 ^ (int)(num2 * 654397325);
					continue;
				}
				case 1u:
					value = (EventHandler<EventArgs0>)Delegate.Combine(eventHandler2, eventHandler_1);
					num = (int)((num2 * 167735514) ^ 0x1F0BB673);
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	protected Class10()
	{
		while (true)
		{
			int num = -534400790;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -176378217)) % 3)
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
				Application.AddMessageFilter(this);
				num = ((int)num2 * -1327696686) ^ 0x69FC16FF;
			}
		}
	}

	bool IMessageFilter.PreFilterMessage(ref Message message_0)
	{
		if (message_0.Msg == 563L)
		{
			Class171.smethod_248(this, message_0);
			return true;
		}
		return false;
	}
}
