using System.Text.RegularExpressions;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.DotNet.Writer;

if (args.Length != 2)
{
    Console.Error.WriteLine("Usage: MetadataNormalizer <input-assembly> <output-assembly>");
    return 2;
}

var inputPath = Path.GetFullPath(args[0]);
var outputPath = Path.GetFullPath(args[1]);
Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);

using var module = ModuleDefMD.Load(inputPath);
var normalizer = new MetadataNormalizer(module);
normalizer.Normalize();

var writerOptions = new ModuleWriterOptions(module)
{
    Logger = DummyLogger.NoThrowInstance
};
module.Write(outputPath, writerOptions);

Console.WriteLine($"Normalized methods: {normalizer.RenamedMethodCount}");
Console.WriteLine($"Removed fake attributes: {normalizer.RemovedAttributeCount}");
Console.WriteLine($"Removed MethodImpl mappings: {normalizer.RemovedOverrideCount}");
Console.WriteLine(outputPath);
return 0;

internal sealed class MetadataNormalizer
{
    private static readonly Regex IdentifierPattern = new(
        "^[A-Za-z_][A-Za-z0-9_]*$",
        RegexOptions.CultureInvariant | RegexOptions.Compiled);

    private static readonly HashSet<string> ClassOverrideTargets = new(StringComparer.Ordinal)
    {
        "System.Object",
        "System.ValueType",
        "System.IO.Stream",
        "System.Random",
        "System.Net.WebClient",
        "System.ComponentModel.TypeConverter",
        "System.ComponentModel.Component",
        "System.Windows.Forms.Form",
        "System.Windows.Forms.NativeWindow",
        "System.Collections.Generic.Comparer`1",
        "System.Collections.ObjectModel.KeyedCollection`2"
    };

    private readonly ModuleDefMD module;
    private readonly Dictionary<MethodDef, string> desiredMethodNames = new();
    private readonly HashSet<MethodDef> convertedExtensionMethods = new();

    public MetadataNormalizer(ModuleDefMD module)
    {
        this.module = module;
    }

    public int RenamedMethodCount { get; private set; }
    public int RemovedAttributeCount { get; private set; }
    public int RemovedOverrideCount { get; private set; }

    public void Normalize()
    {
        RemoveFakeAttributes(module.CustomAttributes);
        if (module.Assembly is not null)
        {
            RemoveFakeAttributes(module.Assembly.CustomAttributes);
        }

        RemoveInterfaceForwarders();

        foreach (var type in module.GetTypes())
        {
            NormalizeType(type);
            RemoveFakeAttributes(type.CustomAttributes);

            foreach (var field in type.Fields)
            {
                RemoveFakeAttributes(field.CustomAttributes);
                if (IsPrivateLike(field.Attributes))
                {
                    field.Attributes &= ~FieldAttributes.FieldAccessMask;
                    field.Attributes |= FieldAttributes.Assembly;
                }
            }

            foreach (var property in type.Properties)
            {
                RemoveFakeAttributes(property.CustomAttributes);
            }

            foreach (var @event in type.Events)
            {
                RemoveFakeAttributes(@event.CustomAttributes);
            }

            foreach (var method in type.Methods)
            {
                RemoveFakeAttributes(method.CustomAttributes);
                StripInvalidParameterDefaults(method);
                if (IsPrivateLike(method.Attributes) &&
                    method.Overrides.Count == 0 &&
                    !method.IsStaticConstructor)
                {
                    method.Attributes &= ~MethodAttributes.MemberAccessMask;
                    method.Attributes |= MethodAttributes.Assembly;
                }
                desiredMethodNames[method] = GetInitialMethodName(method);
            }
        }

        PropagateOverrideNames();
        ApplyMethodNames();
    }

    private void NormalizeType(TypeDef type)
    {
        if (type.IsAbstract && type.IsSealed &&
            (HasExtensionAttribute(type.CustomAttributes) ||
             type.Methods.Any(method => HasExtensionAttribute(method.CustomAttributes))))
        {
            ConvertBrokenExtensionMethods(type);
        }

        if (!type.IsGlobalModuleType)
        {
            type.Attributes &= ~TypeAttributes.VisibilityMask;
            type.Attributes |= type.IsNested ? TypeAttributes.NestedPublic : TypeAttributes.Public;
        }

        if (type.IsAbstract && type.IsSealed &&
            type.Methods.Any(method => !method.IsStatic && !method.IsConstructor))
        {
            type.Attributes &= ~(TypeAttributes.Abstract | TypeAttributes.Sealed);
        }

        if (!type.IsGlobalModuleType && !IsTypeIdentifier(type.Name))
        {
            type.Name = $"Type{type.MDToken.Rid:X4}";
        }
    }

    private void PropagateOverrideNames()
    {
        for (var pass = 0; pass < 8; pass++)
        {
            var changed = false;
            foreach (var method in desiredMethodNames.Keys)
            {
                string? replacement;
                if (method.Overrides.Count > 0)
                {
                    if (!IsClassOverride(method.Overrides[0].MethodDeclaration))
                    {
                        continue;
                    }
                    replacement = ResolveOverrideName(method, method.Overrides[0].MethodDeclaration);
                }
                else if (method.IsVirtual && !method.IsNewSlot)
                {
                    replacement = ResolveBaseSlotName(method);
                }
                else
                {
                    continue;
                }
                if (replacement is not null && desiredMethodNames[method] != replacement)
                {
                    desiredMethodNames[method] = replacement;
                    changed = true;
                }
            }

            if (!changed)
            {
                break;
            }
        }
    }

    private string? ResolveBaseSlotName(MethodDef method)
    {
        var baseType = TryResolveType(method.DeclaringType.BaseType);
        while (baseType is not null)
        {
            var signatureMatches = baseType.Methods.Where(candidate =>
                candidate.IsVirtual && SignaturesMatch(candidate.MethodSig, method.MethodSig));
            var signatureMatch = signatureMatches.FirstOrDefault(candidate => candidate.Name == method.Name) ??
                signatureMatches.FirstOrDefault();
            if (signatureMatch is not null && desiredMethodNames.TryGetValue(signatureMatch, out var name))
            {
                return name;
            }
            baseType = TryResolveType(baseType.BaseType);
        }
        return null;
    }

    private string? ResolveOverrideName(MethodDef method, IMethodDefOrRef declaration)
    {
        var declaringTypeName = declaration.DeclaringType?.FullName ?? string.Empty;
        var knownName = ResolveKnownObjectMethod(declaringTypeName, declaration.MethodSig);
        if (knownName is not null)
        {
            return knownName;
        }

        var declarationDef = TryResolveMethod(declaration);
        if (declarationDef is not null && desiredMethodNames.TryGetValue(declarationDef, out var localName))
        {
            return localName;
        }

        var declaringTypeDef = TryResolveType(declaration.DeclaringType);
        if (declaringTypeDef is not null)
        {
            var signatureMatch = declaringTypeDef.Methods.FirstOrDefault(candidate =>
                SignaturesMatch(candidate.MethodSig, declaration.MethodSig));
            if (signatureMatch is not null && desiredMethodNames.TryGetValue(signatureMatch, out localName))
            {
                return localName;
            }
        }

        var baseType = TryResolveType(method.DeclaringType.BaseType);
        while (baseType is not null)
        {
            var signatureMatch = baseType.Methods.FirstOrDefault(candidate =>
                SignaturesMatch(candidate.MethodSig, method.MethodSig));
            if (signatureMatch is not null && desiredMethodNames.TryGetValue(signatureMatch, out localName))
            {
                return localName;
            }
            baseType = TryResolveType(baseType.BaseType);
        }

        return IsIdentifier(declaration.Name) ? declaration.Name.String : null;
    }

    private static string? ResolveKnownObjectMethod(string typeName, MethodSig? signature)
    {
        if (signature is null || (typeName != "System.Object" && typeName != "System.ValueType"))
        {
            return null;
        }

        var parameters = signature.Params.Select(parameter => parameter.FullName).ToArray();
        var returnType = signature.RetType.FullName;
        if (returnType == "System.Void" && parameters.Length == 0)
        {
            return "Finalize";
        }
        if (returnType == "System.Boolean" && parameters.SequenceEqual(new[] { "System.Object" }))
        {
            return "Equals";
        }
        if (returnType == "System.Int32" && parameters.Length == 0)
        {
            return "GetHashCode";
        }
        if (returnType == "System.String" && parameters.Length == 0)
        {
            return "ToString";
        }
        return null;
    }

    private void ApplyMethodNames()
    {
        foreach (var type in module.GetTypes())
        {
            var seenSignatures = new HashSet<string>(StringComparer.Ordinal);
            foreach (var method in type.Methods)
            {
                if (method.IsConstructor)
                {
                    continue;
                }

                var originalName = method.Name.String;
                var desiredName = desiredMethodNames[method];
                var interfaceImplementation = method.Overrides.Count > 0 &&
                    !IsClassOverride(method.Overrides[0].MethodDeclaration);
                if (interfaceImplementation)
                {
                    seenSignatures.Add(BuildCSharpSignatureKey(originalName, method.MethodSig));
                    continue;
                }
                var signatureKey = BuildCSharpSignatureKey(desiredName, method.MethodSig);
                if (!seenSignatures.Add(signatureKey))
                {
                    desiredName = $"{desiredName}_{method.MDToken.Rid:X4}";
                    seenSignatures.Add(BuildCSharpSignatureKey(desiredName, method.MethodSig));
                }

                if (originalName != desiredName)
                {
                    method.Name = desiredName;
                    RenamedMethodCount++;
                }

                var ownerProperty = type.Properties.FirstOrDefault(property =>
                    property.GetMethod == method || property.SetMethod == method);
                if (ownerProperty is not null &&
                    (desiredName.StartsWith("get_", StringComparison.Ordinal) ||
                     desiredName.StartsWith("set_", StringComparison.Ordinal)))
                {
                    ownerProperty.Name = desiredName[4..];
                }

                if (method.Overrides.Count > 0 && IsClassOverride(method.Overrides[0].MethodDeclaration))
                {
                    method.Overrides.Clear();
                    method.Attributes &= ~MethodAttributes.NewSlot;
                    RemovedOverrideCount++;
                }
            }
        }
    }

    private static string BuildCSharpSignatureKey(string name, MethodSig? signature)
    {
        if (signature is null)
        {
            return name;
        }
        return $"{name}({string.Join(",", signature.Params.Select(parameter => parameter.FullName))})";
    }

    private static bool IsClassOverride(IMethodDefOrRef declaration)
    {
        var resolvedType = TryResolveType(declaration.DeclaringType);
        if (resolvedType is not null)
        {
            return !resolvedType.IsInterface;
        }
        var fullName = declaration.DeclaringType?.FullName ?? string.Empty;
        return ClassOverrideTargets.Any(target =>
            fullName == target || fullName.StartsWith(target + "<", StringComparison.Ordinal));
    }

    private void RemoveInterfaceForwarders()
    {
        foreach (var type in module.GetTypes().Where(type => type.IsInterface).ToArray())
        {
            var mappedMethods = type.Methods
                .Where(method => method.Overrides.Count > 0)
                .ToArray();
            foreach (var method in mappedMethods)
            {
                method.Overrides.Clear();
            }
        }
    }

    private void ConvertBrokenExtensionMethods(TypeDef type)
    {
        foreach (var method in type.Methods.Where(method => !method.IsStatic && !method.IsConstructor))
        {
            var targetType = method.Body?.Instructions
                .FirstOrDefault(instruction => instruction.OpCode.Code == Code.Castclass)
                ?.Operand as ITypeDefOrRef;
            targetType ??= method.Body?.Instructions
                .Where(instruction => instruction.OpCode.Code is Code.Call or Code.Callvirt)
                .Select(instruction => instruction.Operand as IMethod)
                .FirstOrDefault(calledMethod => calledMethod is not null && calledMethod.MethodSig?.HasThis == true)
                ?.DeclaringType;
            if (targetType is null || method.MethodSig is null)
            {
                continue;
            }

            foreach (var parameter in method.ParamDefs.Where(parameter => parameter.Sequence > 0))
            {
                parameter.Sequence++;
            }
            method.ParamDefs.Add(new ParamDefUser("type", 1));
            method.MethodSig.Params.Insert(0, targetType.ToTypeSig());
            method.MethodSig.HasThis = false;
            method.MethodSig.ExplicitThis = false;
            method.Attributes |= MethodAttributes.Static;
            convertedExtensionMethods.Add(method);
        }
    }

    private static bool HasExtensionAttribute(CustomAttributeCollection attributes)
    {
        return attributes.Any(attribute =>
            attribute.AttributeType.FullName == "System.Runtime.CompilerServices.ExtensionAttribute");
    }

    private static MethodDef? TryResolveMethod(IMethodDefOrRef method)
    {
        try
        {
            return method.ResolveMethodDef();
        }
        catch
        {
            return null;
        }
    }

    private static TypeDef? TryResolveType(ITypeDefOrRef? type)
    {
        try
        {
            return type?.ResolveTypeDef();
        }
        catch
        {
            return null;
        }
    }

    private static bool SignaturesMatch(MethodSig? left, MethodSig? right)
    {
        if (left is null || right is null || left.GenParamCount != right.GenParamCount ||
            left.Params.Count != right.Params.Count || left.RetType.FullName != right.RetType.FullName)
        {
            return false;
        }
        for (var index = 0; index < left.Params.Count; index++)
        {
            if (left.Params[index].FullName != right.Params[index].FullName)
            {
                return false;
            }
        }
        return true;
    }

    private string GetInitialMethodName(MethodDef method)
    {
        if (method.IsConstructor)
        {
            return method.Name.String;
        }
        if (method.Overrides.Count > 0 && !IsClassOverride(method.Overrides[0].MethodDeclaration))
        {
            return method.Name.String;
        }

        var requiresMetadataRename = convertedExtensionMethods.Contains(method) ||
            method.Overrides.Count > 0 ||
            method.IsVirtual;
        if (!requiresMetadataRename)
        {
            // ILSpy sanitizes invalid metadata identifiers together with all call sites.
            // Renaming only the MethodDef here can strand cross-type MemberRefs on the old name.
            return method.Name.String;
        }

        return IsIdentifier(method.Name) ? method.Name.String : $"method_{method.MDToken.Rid:X4}";
    }

    private static bool IsPrivateLike(FieldAttributes attributes)
    {
        var access = attributes & FieldAttributes.FieldAccessMask;
        return access is FieldAttributes.Private or FieldAttributes.PrivateScope;
    }

    private static bool IsPrivateLike(MethodAttributes attributes)
    {
        var access = attributes & MethodAttributes.MemberAccessMask;
        return access is MethodAttributes.Private or MethodAttributes.PrivateScope;
    }

    private static void StripInvalidParameterDefaults(MethodDef method)
    {
        foreach (var parameter in method.ParamDefs)
        {
            parameter.Attributes &= ~(ParamAttributes.HasDefault | ParamAttributes.Optional);
            parameter.Constant = null;
            for (var index = parameter.CustomAttributes.Count - 1; index >= 0; index--)
            {
                var fullName = parameter.CustomAttributes[index].AttributeType.FullName;
                if (fullName is "System.Runtime.InteropServices.DefaultParameterValueAttribute" or
                    "System.Runtime.InteropServices.OptionalAttribute")
                {
                    parameter.CustomAttributes.RemoveAt(index);
                }
            }
        }
    }

    private void RemoveFakeAttributes(CustomAttributeCollection attributes)
    {
        for (var index = attributes.Count - 1; index >= 0; index--)
        {
            var name = attributes[index].AttributeType.FullName;
            if (name.Contains("<Module>", StringComparison.Ordinal) ||
                name.Contains("Goliath", StringComparison.OrdinalIgnoreCase) ||
                name.Contains("Babel", StringComparison.OrdinalIgnoreCase) ||
                name.Contains("Dotfuscator", StringComparison.OrdinalIgnoreCase) ||
                name.Contains("Xenocode", StringComparison.OrdinalIgnoreCase) ||
                name.Contains("ObfuscatedBy", StringComparison.OrdinalIgnoreCase))
            {
                attributes.RemoveAt(index);
                RemovedAttributeCount++;
            }
        }
    }

    private static bool IsIdentifier(UTF8String? name)
    {
        return name is not null && IdentifierPattern.IsMatch(name.String);
    }

    private static bool IsTypeIdentifier(UTF8String? name)
    {
        if (name is null)
        {
            return false;
        }
        var value = name.String;
        var genericMarker = value.IndexOf('`');
        return IdentifierPattern.IsMatch(genericMarker >= 0 ? value[..genericMarker] : value);
    }
}
