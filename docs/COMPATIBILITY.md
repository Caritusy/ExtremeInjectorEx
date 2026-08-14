# Compatibility and Validation

Extreme Injector Ex separates build compatibility from runtime injection compatibility. A successful build or CLI smoke test does not prove that every injection backend works against every target.

## Validation levels

| Level | Meaning |
| --- | --- |
| CI build | The project compiles for the listed platform on `windows-latest` |
| Automated test | Deterministic behavior is covered by the test project |
| CLI smoke | The built executable starts in English and Simplified Chinese CLI modes and exits successfully |
| Controlled integration | Injection was tested against a repository-owned fixture process and DLL |
| Manual compatibility | A maintainer documented a specific Windows, architecture, backend, and fixture result |

## Current matrix

| Area | AnyCPU | x86 | x64 |
| --- | ---: | ---: | ---: |
| Release build | CI | CI | CI |
| CLI help smoke test | CI | CI | CI |
| Settings/localization/PE tests | Automated | Build only | Build only |
| Standard injection fixture | Planned | Planned | Planned |
| Thread hijacking fixture | Planned | Planned | Planned |
| `LdrLoadDll` fixtures | Planned | Planned | Planned |
| Manual Map fixture | Planned | Planned | Planned |

## Runtime rules

- Injector, target process, and DLL architecture must be compatible.
- A process name must resolve to exactly one target; scripts should prefer PID after discovery.
- Administrator privileges may be required by the target's integrity level and access policy.
- Windows loader internals are version-sensitive. Manual Map changes require validation on currently supported Windows builds.
- Malformed or adversarial PE files must fail safely without unbounded reads or writes.

## Manual Map regression areas

Changes should consider:

- PE32 and PE32+ headers and section alignment.
- Normal imports, forwarded exports, delay imports, and API-set contracts.
- Base relocations and preferred-base allocation.
- TLS callbacks and module entry points.
- x86 SEH and x64 unwind/exception metadata.
- Shared pages, discardable sections, and final memory protections.
- Instruction-cache flushing and remote execution timeouts.
- Duplicate module names, full-path identity, and manually mapped module snapshots.
- Failure cleanup when a remote thread may still be executing.

This document records evidence, not assumptions. Move an item from `Planned` only when a repeatable fixture or documented manual result exists.
