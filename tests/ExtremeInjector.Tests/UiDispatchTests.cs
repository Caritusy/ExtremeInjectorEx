using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtremeInjector.Tests;

[TestClass]
public sealed class UiDispatchTests
{
	[TestMethod]
	public void UiDispatchRejectsUnavailableControlsWithoutThrowing()
	{
		bool invoked = false;

		Assert.IsFalse(RecoveredRuntime.TryInvoke(null, () => invoked = true));
		Assert.IsFalse(RecoveredRuntime.TryBeginInvoke(null, () => invoked = true));
		Assert.IsFalse(invoked);
	}

	[TestMethod]
	public void UiDispatchDoesNotRequireAWinFormsHandleForErrorReporting()
	{
		RecoveredRuntime.ReportInjectionErrorSafely(
			(message, exception) => RecoveredRuntime.TryInvoke(null, () => { }),
			"Injection failed",
			new InvalidOperationException("form closed"));
	}
}
