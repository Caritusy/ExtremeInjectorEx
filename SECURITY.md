# Security Policy

Extreme Injector Ex is a dual-use Windows development and testing tool. Use it only with software and systems you own or are explicitly authorized to test.

## Supported versions

| Version | Status |
| --- | --- |
| Latest `3.7.x` release | Supported |
| Current `main` branch | Development support |
| Original Extreme Injector releases | Not maintained here |

## Reporting a vulnerability

Use [GitHub private vulnerability reporting](https://github.com/Caritusy/ExtremeInjectorEx/security/advisories/new). Do not include sensitive details in a public issue.

Include, when applicable:

- The affected version or commit.
- Windows version and process architecture.
- A minimal reproduction using files you are permitted to share.
- Expected and actual behavior.
- Security impact and known prerequisites.
- Suggested mitigations, if available.

If private reporting is unavailable, open a public issue requesting a private contact channel without disclosing vulnerability details.

## Relevant security issues

Examples include:

- Memory-safety or bounds-checking defects triggered by malformed PE input.
- Arbitrary file writes, settings path traversal, or unsafe temporary-file handling.
- Incorrect privilege boundaries or unintended process selection.
- Release asset, dependency, or update-channel compromise.
- Command-line behavior that acts on a different target than explicitly selected.

Requests to bypass anti-cheat, endpoint security, authorization, licensing, or access controls are not vulnerability reports and are outside project scope.

## Disclosure

Please allow maintainers time to reproduce, fix, validate, and publish an update before public disclosure. Confirmed fixes should include a regression test whenever a safe deterministic test is possible.
