using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public sealed class FileDropMessageFilter : IMessageFilter
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

	public static FileDropMessageFilter class10_0 = new FileDropMessageFilter();

	[CompilerGenerated]
	internal EventHandler<FileDropEventArgs> eventHandler_0;

	[SpecialName]
	[CompilerGenerated]
	public void method_0(EventHandler<FileDropEventArgs> eventHandler_1)
	{
		EventHandler<FileDropEventArgs> eventHandler = this.eventHandler_0;
		EventHandler<FileDropEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<FileDropEventArgs> value = (EventHandler<FileDropEventArgs>)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange<EventHandler<FileDropEventArgs>>(ref this.eventHandler_0, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	protected FileDropMessageFilter()
	{
		Application.AddMessageFilter(this);
	}

	bool IMessageFilter.PreFilterMessage(ref Message message_0)
	{
		if (message_0.Msg == 563L)
		{
			RecoveredRuntime.smethod_254(this, message_0);
			return true;
		}
		return false;
	}

	internal static Delegate smethod_0(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	internal static void smethod_1(IMessageFilter imessageFilter_0)
	{
		Application.AddMessageFilter(imessageFilter_0);
	}
}
