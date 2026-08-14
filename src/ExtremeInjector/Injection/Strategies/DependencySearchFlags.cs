using System;

[Flags]
public enum DependencySearchFlags
{
	None = 0,
	ApiSetOnly = 1,
	ResolveApiSetToSystemDirectory = 2,
	SideBySideOnly = 4,
	UseWow64SystemDirectory = 8
}
