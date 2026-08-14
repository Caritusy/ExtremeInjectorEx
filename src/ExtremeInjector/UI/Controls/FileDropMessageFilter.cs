using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public sealed class FileDropMessageFilter : IMessageFilter
{
	public struct NativePoint
	{
		public int X;

		public int Y;
	}

	public enum MessageFilterStatus : uint
	{
		None,
		AlreadyAllowedForWindow,
		AlreadyDisallowedForWindow,
		AllowedByHigherFilter
	}

	public enum MessageFilterAction : uint
	{
		Reset,
		Allow,
		Disallow
	}

	public enum LegacyMessageFilterAction : uint
	{
		Add = 1u,
		Remove
	}

	public struct MessageFilterChangeInfo
	{
		public uint Size;

		public MessageFilterStatus Status;
	}

	public static FileDropMessageFilter class10_0 = new FileDropMessageFilter();

	[CompilerGenerated]
	internal EventHandler<FileDropEventArgs> eventHandler_0;

	[SpecialName]
	[CompilerGenerated]
	public void SubscribeFilesDropped(EventHandler<FileDropEventArgs> eventHandler_1)
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
			RecoveredRuntime.HandleFileDrop(this, message_0);
			return true;
		}
		return false;
	}
}
