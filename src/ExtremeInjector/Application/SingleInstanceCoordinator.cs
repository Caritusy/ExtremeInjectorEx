using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

internal sealed class SingleInstanceCoordinator : IDisposable
{
	internal const string NameOverrideKey = "ExtremeInjectorEx.SingleInstanceNameOverride";

	private const int RestoreWindow = 9;
	private const uint NoMove = 0x0002;
	private const uint NoSize = 0x0001;
	private const uint ShowWindow = 0x0040;
	private static readonly IntPtr TopMost = new IntPtr(-1);
	private static readonly IntPtr NotTopMost = new IntPtr(-2);

	private readonly EventWaitHandle activationEvent;
	private readonly Mutex instanceMutex;
	private RegisteredWaitHandle activationRegistration;
	private Form mainWindow;
	private bool disposed;

	private SingleInstanceCoordinator(
		EventWaitHandle activationEvent,
		Mutex instanceMutex,
		bool isPrimary)
	{
		this.activationEvent = activationEvent;
		this.instanceMutex = instanceMutex;
		IsPrimary = isPrimary;
	}

	internal bool IsPrimary { get; }

	internal static bool TryActivateExisting()
	{
		try
		{
			using (EventWaitHandle existingEvent = EventWaitHandle.OpenExisting(GetActivationEventName()))
			{
				existingEvent.Set();
				return true;
			}
		}
		catch (WaitHandleCannotBeOpenedException)
		{
			return false;
		}
		catch (UnauthorizedAccessException)
		{
			return IsExistingInstanceRunning();
		}
	}

	internal static SingleInstanceCoordinator Acquire()
	{
		bool eventCreated;
		var activationEvent = new EventWaitHandle(
			initialState: false,
			mode: EventResetMode.AutoReset,
			name: GetActivationEventName(),
			createdNew: out eventCreated);
		bool isPrimary;
		var instanceMutex = new Mutex(
			initiallyOwned: false,
			name: GetMutexName(),
			createdNew: out isPrimary);
		var coordinator = new SingleInstanceCoordinator(activationEvent, instanceMutex, isPrimary);
		if (!isPrimary)
		{
			coordinator.RequestActivation();
		}

		return coordinator;
	}

	internal void AttachMainWindow(Form window)
	{
		if (!IsPrimary)
		{
			throw new InvalidOperationException("Only the primary instance can own the main window.");
		}

		mainWindow = window ?? throw new ArgumentNullException(nameof(window));
		IntPtr unusedHandle = mainWindow.Handle;
		activationRegistration = ThreadPool.RegisterWaitForSingleObject(
			activationEvent,
			OnActivationRequested,
			state: null,
			millisecondsTimeOutInterval: Timeout.Infinite,
			executeOnlyOnce: false);
	}

	internal void RequestActivation()
	{
		activationEvent.Set();
	}

	private void OnActivationRequested(object state, bool timedOut)
	{
		Form window = mainWindow;
		if (window == null || window.IsDisposed || !window.IsHandleCreated)
		{
			return;
		}

		try
		{
			window.BeginInvoke((Action)(() => BringWindowToForeground(window)));
		}
		catch (InvalidOperationException)
		{
		}
	}

	private static void BringWindowToForeground(Form window)
	{
		if (window.IsDisposed)
		{
			return;
		}

		if (!window.Visible)
		{
			window.Show();
		}

		if (window.WindowState == FormWindowState.Minimized)
		{
			ShowWindowAsync(window.Handle, RestoreWindow);
			window.WindowState = FormWindowState.Normal;
		}

		SetWindowPos(window.Handle, TopMost, 0, 0, 0, 0, NoMove | NoSize | ShowWindow);
		SetWindowPos(window.Handle, NotTopMost, 0, 0, 0, 0, NoMove | NoSize | ShowWindow);
		BringWindowToTop(window.Handle);
		SetForegroundWindow(window.Handle);
		window.BringToFront();
		window.Activate();
	}

	private static bool IsExistingInstanceRunning()
	{
		try
		{
			using (Mutex existingMutex = Mutex.OpenExisting(GetMutexName()))
			{
				return existingMutex != null;
			}
		}
		catch (WaitHandleCannotBeOpenedException)
		{
			return false;
		}
		catch (UnauthorizedAccessException)
		{
			return true;
		}
	}

	private static string GetActivationEventName()
	{
		return @"Local\" + GetNameBase() + ".Activate";
	}

	private static string GetMutexName()
	{
		return @"Global\" + GetNameBase() + ".Mutex";
	}

	private static string GetNameBase()
	{
		string overrideName = AppDomain.CurrentDomain.GetData(NameOverrideKey) as string;
		if (!string.IsNullOrWhiteSpace(overrideName))
		{
			return "ExtremeInjectorEx." + overrideName;
		}

		SecurityIdentifier user = WindowsIdentity.GetCurrent().User;
		string userIdentity = user?.Value ?? Environment.UserName;
		return "ExtremeInjectorEx." + userIdentity;
	}

	public void Dispose()
	{
		if (disposed)
		{
			return;
		}

		disposed = true;
		activationRegistration?.Unregister(null);
		activationEvent.Dispose();
		instanceMutex.Dispose();
	}

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool ShowWindowAsync(IntPtr windowHandle, int command);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetForegroundWindow(IntPtr windowHandle);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool BringWindowToTop(IntPtr windowHandle);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetWindowPos(
		IntPtr windowHandle,
		IntPtr insertAfter,
		int x,
		int y,
		int width,
		int height,
		uint flags);
}
