# Extreme Injector Ex

[![Version](https://img.shields.io/badge/version-3.7.4-1677c8)](./version)
![Platform](https://img.shields.io/badge/platform-Windows-0078d4)
![Framework](https://img.shields.io/badge/.NET_Framework-4.8-512bd4)

**English** | [简体中文](./README.zh-CN.md)

Extreme Injector Ex is a maintained Windows DLL injector based on the recoverable source of Extreme Injector 3.7.3. This repository reorganizes the recovered code into a buildable project and continues development with a modernized interface, reliable PE parsing, bilingual localization, portable single-file distribution, and a scriptable command-line mode.

> [!WARNING]
> Use this software only with programs that you own or are explicitly authorized to test. Injecting code into third-party processes may violate software licenses, security policies, or local law.

## Highlights

- Standard (`LoadLibrary`), thread-hijacking, `LdrLoadDll`, `LdrLoadDll Stub`, and Manual Map injection methods.
- PE32 and PE32+ parsing for imports, exports, relocations, TLS, resources, and CLR directories.
- Target/DLL architecture validation before injection.
- Configurable delays, automatic injection, post-injection PE erasure, module hiding, and DLL scrambling.
- Export invocation with calling-convention and typed-argument support.
- A consistent, DPI-aware WinForms interface in English and Simplified Chinese.
- System-language detection with an immediate, persistent language override.
- One GUI instance per Windows user; later launches restore and foreground the existing window.
- Complete CLI access through `-c` or `--cli`, including every persisted application setting.
- Embedded runtime dependencies and localization resources: the built EXE can be copied and run on its own.
- Structurally deobfuscated source: no opaque predicates, XOR/modulo switch dispatchers, or decompiler-generated `goto` graphs remain under `src`.

## Requirements

### Running

- Windows 10 or Windows 11.
- .NET Framework 4.8.
- Administrator privileges when an injection operation requires access to the target process.
- Matching target-process and DLL architectures.

### Building

- Visual Studio 2022 or Build Tools 2022.
- .NET Framework 4.8 Developer Pack.
- A .NET SDK capable of building SDK-style `net48` projects.

## Build from source

Clone the repository and run the following commands from its root:

```powershell
dotnet restore .\ExtremeInjectorEx.sln
dotnet build .\ExtremeInjectorEx.sln -c Release
```

The Release output is written to:

```text
out/bin/ExtremeInjector/Release/net48/
```

All intermediate files are kept under `out/obj/`. Build output, local settings, test results, and IDE state are excluded from Git.

## GUI quick start

Run `Extreme Injector.exe` normally to open the graphical interface:

1. Select a target process.
2. Add one or more DLLs.
3. Choose an injection method and optional behavior in **Settings**.
4. Select **Inject**.

The GUI is single-instance per Windows user. Starting the application again restores and foregrounds the existing main window instead of opening another settings writer.

Settings are stored at:

```text
%AppData%\ExtremeInjectorEx\settings.xml
```

Writes use a temporary file and atomic replacement. Legacy settings found beside the executable are migrated to the per-user location.

### Portable distribution

Only `Extreme Injector.exe` is required at runtime. The generated `.config` and `.pdb` files are build/debug artifacts rather than runtime dependencies.

## Command-line interface

Enable CLI mode with `-c` or `--cli`. The executable remains windowless during ordinary GUI launches while behaving like a regular console program in CLI mode.

Show the authoritative option list for the current build:

```powershell
& '.\Extreme Injector.exe' --cli --help
```

### Select a target

Inject a DLL by process ID:

```powershell
& '.\Extreme Injector.exe' --cli --pid 1234 `
  --dll 'D:\Modules\Example.dll'
```

Wait for a named process and use Manual Map:

```powershell
& '.\Extreme Injector.exe' -c --process Game.exe `
  --auto-inject --wait-timeout 60 `
  --dll 'D:\Modules\Example.dll' --method manual-map
```

Process names may be supplied with or without `.exe`. A name must resolve to exactly one process. When multiple processes match, the CLI exits with code `3` and prints candidates without guessing:

```text
[0] First window title (1234)
[1] Second window title (5678)
```

Run the command again with the required PID.

### Multiple DLLs and exported routines

Repeat `--dll` to add multiple modules. `--export`, `--calling-convention`, and `--arg` apply to the most recently added DLL:

```powershell
& '.\Extreme Injector.exe' --cli --pid 1234 `
  --dll 'D:\Modules\First.dll' `
  --export Initialize --calling-convention stdcall --arg uint32:1 `
  --dll 'D:\Modules\Second.dll'
```

Supported exported-routine argument types are `ansi`, `unicode`, `byte`, `uint16`, `uint32`, `uint64`, and `float`.

### Configuration and persistence

Every user-configurable GUI setting has a CLI equivalent, including:

- Injection method, automatic injection, close-on-success behavior, and stealth injection.
- Pre-injection and between-module delays.
- PE-header erasure, module hiding, and Manual Map options.
- Scrambling preset and every individual scrambling flag.
- Interface language, random window title, and all three interface colors.
- Warning acknowledgements and the saved DLL list.

Arguments affect only the current invocation unless `--save-settings` is supplied. Use `--settings <path>` to work with an isolated settings file:

```powershell
& '.\Extreme Injector.exe' --cli --settings '.\automation.xml' `
  --reset-settings --language zh-CN --no-random-title --save-settings
```

CLI injection may run alongside the GUI. A settings write acquires the same per-user lock as the GUI; if another instance owns it, the command exits with code `7` rather than risking a conflicting write.

### Exit codes

| Code | Meaning |
| ---: | --- |
| `0` | Operation completed successfully. |
| `1` | Invalid command-line arguments. |
| `2` | Target process was not found. |
| `3` | The process name matched multiple targets. |
| `4` | A DLL was missing, invalid, or no enabled DLL was available. |
| `5` | Administrator privileges are required. |
| `6` | Injection failed. |
| `7` | Another instance currently owns the settings lock. |
| `8` | Process waiting was canceled. |

## Localization

The interface defaults to the Windows display language: Simplified Chinese is selected for Chinese systems and English elsewhere. The language can be changed immediately under **Settings → Appearance and language → Interface language**.

Project-owned UI and CLI text uses stable resource keys. English and Simplified Chinese resources are kept in:

```text
res/Localization/Strings.en.resx
res/Localization/Strings.zh-CN.resx
```

Both files must contain the same key set. Process names, DLL names, export names, paths, window titles, and operating-system error details remain unchanged because they originate outside the application.

## Repository layout

```text
ExtremeInjectorEx/
├─ src/ExtremeInjector/
│  ├─ Application/          Entry points, CLI, settings, and application models
│  ├─ Assembly/             AsmJit and BeaEngine interop
│  ├─ Collections/          Internal collection implementations
│  ├─ Compression/          Embedded-resource decompression
│  ├─ Injection/            Injection strategies, remote processes, and Manual Map
│  ├─ Interop/              Win32 declarations
│  ├─ Localization/         Language selection and resource access
│  ├─ PortableExecutable/   PE32/PE32+ structures and parsing
│  ├─ Runtime/              Startup, resource loading, and recovered compatibility code
│  ├─ UI/                   WinForms windows and controls
│  └─ Utilities/            Shared helpers
├─ res/
│  ├─ Embedded/             Protected and compressed runtime resources
│  ├─ Forms/                WinForms resources
│  └─ Localization/         English and Simplified Chinese text
└─ out/                     Local build output (not committed)
```

## Development notes

- Read [ARCHITECTURE.md](./ARCHITECTURE.md) before changing application startup, presentation state, injection services, PE parsing, or recovered compatibility code. New code keeps entry points thin, system behavior in focused services, and source free of control-flow obfuscation.
- The application currently targets .NET Framework 4.8; it is not a NativeAOT application.
- Normal application paths use typed factories and bindings instead of reflection-based construction. The recovered compatibility runtime still depends on dynamic IL, dynamic assembly loading, and metadata-token resolution.
- Because of those runtime requirements, WinFormsComInterop, trimming, and NativeAOT cannot be adopted as drop-in changes. A modern .NET migration must replace the dynamic runtime chain first and validate WinForms/COM behavior separately.
- Logical names for protected resources are intentionally preserved for compatibility. Check the resource resolver before changing them.
- Changes to PE parsing, process access, assembly generation, embedded dependencies, or localization should be followed by a Release build and focused regression testing.

## Project history

Extreme Injector was originally developed by **master131**. Extreme Injector Ex 3.7.4 is a community-maintained reconstruction based on the recoverable 3.7.3 program source. It does not claim to reproduce lost private identifiers, comments, or the original project layout.

## License

This repository does not currently include a standalone license file. Do not assume permission to redistribute or reuse the code beyond rights granted by the original project and individual contributors. Review and establish the applicable licensing terms before distributing derived builds.
