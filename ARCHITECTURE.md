# Architecture

Extreme Injector Ex retains compatibility code recovered from the original binary, but its source-level control-flow obfuscation has been removed. Ongoing work focuses on descriptive naming and smaller service boundaries without changing compatibility all at once.

## Dependency direction

```text
Program
  -> ApplicationHost
      -> GuiApplication / CliApplication
          -> presentation models and coordinators
              -> injection, PE, settings, localization, and platform services
                  -> Win32 interop and recovered compatibility adapters
```

- `Program.Main` is a composition root. It delegates immediately and contains no settings, UI, process, injection, persistence, or command-line behavior.
- GUI forms are views. New workflows must put state and user actions in presentation models/controllers and put system operations in services. Existing recovered form code is migration debt, not a pattern to extend.
- CLI parsing, process selection, settings persistence, and injection execution should remain separable even when a coordinator composes them.
- Injection services own mapping, remote execution, module snapshots, memory protection, and cleanup policy. Compatibility methods such as `smethod_*` may forward to these services but must not receive new business logic.
- Injector backend selection belongs to `InjectorFactory`; views must not construct or register injection backends.
- PE models and parsers do not depend on UI types.

## Manual Map boundaries

- `ManualMapProtectionService` creates and applies a page-coalesced protection plan. A discardable section cannot decommit a page that also contains headers or retained section data.
- `RemoteModuleSnapshotService` captures all visible target modules, keeps full paths and base names distinct, and merges manually tracked images by base address.
- `RemoteCodeExecutorBase` bounds remote-thread waits, flushes generated code from the instruction cache, and retains allocations when a timed-out thread may still execute them.
- x64 exception tables remain handled by the existing compatibility path. MareInjector's initialization-thread-only static-TLS simulation and `_CxxThrowException` special case are intentionally not copied into this general-purpose mapper.

## Source policy

Maintained source must use normal names and structured control flow. The current `src` tree contains no opaque predicates, XOR/modulo switch dispatchers, or generated `goto` graphs. Do not reintroduce those patterns, flattened `while (true)` state machines, or numbered `class123` APIs. Obfuscation belongs in an optional release pipeline; protected or decompiled output must never be copied back into `src`.

When touching recovered code, prefer extracting one testable behavior behind a descriptive service and leave a thin compatibility adapter. Do not perform broad mechanical rewrites without a focused regression path.
