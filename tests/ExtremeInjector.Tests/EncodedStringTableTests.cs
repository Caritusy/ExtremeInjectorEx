using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtremeInjector.Tests;

[TestClass]
public sealed class EncodedStringTableTests
{
	[TestMethod]
	public void RestoredTableDecodesKnownValues()
	{
		Assert.AreEqual(24, EncodedStringTable.intValue);
		Assert.AreEqual("get_Length", EncodedStringTable.DecodeString(24));
		Assert.AreEqual("Extreme Injector v3", EncodedStringTable.DecodeString(599));
		Assert.AreEqual(".", EncodedStringTable.DecodeString(952));
		Assert.AreEqual("kernel32.dll", EncodedStringTable.DecodeString(8503));
		Assert.AreEqual("Unable to open the specified process for injection.", EncodedStringTable.DecodeString(12662));
		Assert.AreEqual("\n\n", EncodedStringTable.DecodeString(24371));
		Assert.AreEqual(": ", EncodedStringTable.DecodeString(24376));
	}

	[TestMethod]
	public void ExceptionFormattingDoesNotDependOnEncodedStringTableValues()
	{
		var exception = new InvalidOperationException("outer", new ArgumentException("inner"));

		string result = RecoveredRuntime.FormatExceptionChain("Injection failed", exception, flag: true);

		Assert.AreEqual(
			"Injection failed\n\nSystem.InvalidOperationException: outer.\n\nSystem.ArgumentException: inner.",
			result);
	}

	[TestMethod]
	public void ThrowingErrorReporterDoesNotEscapeInjectionBoundary()
	{
		RecoveredRuntime.ReportInjectionErrorSafely(
			(message, exception) => throw new InvalidOperationException("reporter failed"),
			"Injection failed",
			new Exception("loader failed"));
	}

	[TestMethod]
	public void AsmJitRuntimeUsesTheInjectorProcessArchitecture()
	{
		Assert.AreEqual(IntPtr.Size == 8, AsmJitRuntime.flag);
		Assert.AreEqual(uint.MaxValue, AsmJitRuntime.uintValue);
		Assert.IsNotNull(AsmJitRuntime.nativeLibraryImage);
	}
}
