# Extreme Injector Ex 3.7.4

This repository contains Extreme Injector Ex, a maintained continuation of the recovered Extreme Injector 3.7.3 source. The original recovery was performed by static analysis only; the supplied executable was not launched.

## Current status

- Target: .NET Framework 4.8 Windows Forms application
- Recovered source: 217 C# files and 8 WinForms `.resx` files
- Recovered resources: application icon, manifest, managed resources, and embedded binary resources
- Clean development project: `src\ExtremeInjector.Clean\ExtremeInjector.Clean.csproj`
- Per-monitor V2 UI with content-measured WinForms layouts and a redesigned main/About experience
- Unified settings: `%AppData%\ExtremeInjectorEx\settings.xml`, with automatic migration from legacy folder-local settings
- UI/settings smoke checks: `tests\ExtremeInjector.UiSmoke\ExtremeInjector.UiSmoke.csproj`
- Build status: full solution succeeds with 0 errors
- Detected protector: Goliath .NET Obfuscator 2.2.0
- Babel, Dotfuscator, and Xenocode strings in the assembly are decoy markers, not the active protector

Open `ExtremeInjector.Recovered.sln` in Visual Studio 2022, or build from a Developer PowerShell:

```powershell
dotnet restore .\ExtremeInjector.Recovered.sln
dotnet build .\ExtremeInjector.Recovered.sln -c Release
```

The application project intended for continued cleanup is:

```text
src\ExtremeInjector.Clean\ExtremeInjector.Clean.csproj
```

## Recovery layout

- `src\ExtremeInjector.Clean`: active, buildable source tree with recovered domain and workflow names
- `src\ExtremeInjector.KeepInlined`: preserved buildable recovery baseline
- `artifacts\original`: byte-for-byte preserved input and extracted embedded assemblies
- `artifacts\deobfuscated`: de4dot variants and normalized managed assemblies
- `tools\MetadataNormalizer`: reproducible dnlib metadata repair tool
- `analysis`: compiler logs retained during recovery

The preserved original has this SHA-256 hash:

```text
B65F40618F584303CA0BCF9B5F88C233CC4237699C0C4BF40BA8FACBE8195A46
```

The selected normalized assembly is:

```text
artifacts\deobfuscated\ExtremeInjector-3.7.3.keep-inlined.normalized.dll
```

## What was repaired

The metadata normalizer removes fake obfuscator attributes and invalid `MethodImpl` mappings, restores usable member visibility, and assigns stable names to invalid virtual methods and their overrides. The keep-inlined de4dot variant was selected because it preserved required definitions while producing fewer invalid decompiler constructs than the other variants.

Several pointer-heavy methods were decompiled into illegal C# because control-flow jumps crossed pinned regions. Their raw ILSpy bodies remain in the source under `#if false`, while equivalent readable implementations are active for byte-pattern search, masked-pattern search, array marshalling, and process-memory stream reads/writes. This keeps the recovery evidence without preventing compilation.

The clean project also restores the settings contract, scramble presets, form names, main-form controls and events, process-selection state, and the top-level injection workflow. The workflow now explicitly performs per-module file checks, configured delays, architecture validation, working-copy preparation, backend selection, post-injection options, optional export invocation, and UI completion. Automatic injection is tracked by process ID so the timer injects once per process instance. The former flattened single-module wrapper is retained under `#if false` as recovery evidence while the active implementation is sequential.

The Ex interface uses DPI-aware layout containers instead of the recovered absolute-position designers. DLL headers and rows are measured from their fonts and padding at the current monitor DPI. The smoke project exercises configuration migration, round-trip persistence, the main form, and the About form without entering the injector runtime.

## Recovery limits

This is not the exact original project. Obfuscation permanently removed original private type/member names, comments, local names, formatting, and the original solution layout. Names such as `Class171` are stable recovered names, not the authors' original identifiers. Lower-level injection, PE parsing, and native interop code still contains recovered `ClassN` and `smethod_N` names and control-flow state machines; those areas must be cleaned incrementally against the preserved baseline.

The rebuilt executable is a recovered development artifact, not a byte-identical reproduction of the supplied executable. Runtime behavior has not been exercised as part of this static recovery.
