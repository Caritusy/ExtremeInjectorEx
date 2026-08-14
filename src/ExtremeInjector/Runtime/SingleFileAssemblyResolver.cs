using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

internal static class SingleFileAssemblyResolver
{
	private const string ResourcePrefix = "ExtremeInjector.Dependencies.";

	private static readonly object SyncRoot = new object();
	private static readonly Dictionary<string, Assembly> LoadedAssemblies =
		new Dictionary<string, Assembly>(StringComparer.OrdinalIgnoreCase);

	private static bool isRegistered;

	internal static void Register()
	{
		lock (SyncRoot)
		{
			if (isRegistered)
			{
				return;
			}

			AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;
			isRegistered = true;
		}
	}

	private static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
	{
		var requestedAssembly = new AssemblyName(args.Name);
		string simpleName = requestedAssembly.Name;
		if (string.IsNullOrEmpty(simpleName) || simpleName.EndsWith(".resources", StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}

		lock (SyncRoot)
		{
			if (LoadedAssemblies.TryGetValue(simpleName, out Assembly loadedAssembly))
			{
				return loadedAssembly;
			}

			string resourceName = ResourcePrefix + simpleName + ".dll";
			using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
			{
				if (stream == null)
				{
					return null;
				}

				using (var buffer = new MemoryStream((int)stream.Length))
				{
					stream.CopyTo(buffer);
					loadedAssembly = Assembly.Load(buffer.ToArray());
				}
			}

			LoadedAssemblies[simpleName] = loadedAssembly;
			return loadedAssembly;
		}
	}
}
