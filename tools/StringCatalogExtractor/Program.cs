using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

if (args.Length is < 2 or > 3)
{
    Console.Error.WriteLine("Usage: StringCatalogExtractor <source-root> <output-json> [--rewrite]");
    return 2;
}

var sourceRoot = Path.GetFullPath(args[0]);
var outputPath = Path.GetFullPath(args[1]);
var rewrite = args.Length == 3 && args[2] == "--rewrite";
if (!Directory.Exists(sourceRoot))
{
    Console.Error.WriteLine($"Source root does not exist: {sourceRoot}");
    return 2;
}

var protectedResource = Path.Combine(sourceRoot, "-f4f5d655-d3f5-4ecf-9a53-3a2fe4afba9b-");
var stringTable = UnpackStringTable(File.ReadAllBytes(protectedResource));
var callPattern = new Regex(@"Class178\.smethod_0\((\d+)\)", RegexOptions.Compiled);
var catalog = new SortedDictionary<int, string>();
var replacementCount = 0;
var changedFileCount = 0;

foreach (var file in Directory.EnumerateFiles(sourceRoot, "*.cs", SearchOption.AllDirectories))
{
    var source = File.ReadAllText(file);
    var changed = false;
    var rewritten = callPattern.Replace(source, match =>
    {
        var encodedOffset = int.Parse(match.Groups[1].Value);
        if (!catalog.TryGetValue(encodedOffset, out var value))
        {
            value = DecodeString(stringTable, encodedOffset - 24);
            catalog.Add(encodedOffset, value);
        }

        if (!rewrite)
        {
            return match.Value;
        }

        changed = true;
        replacementCount++;
        return ToCSharpLiteral(value);
    });

    if (changed)
    {
        File.WriteAllText(file, rewritten, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
        changedFileCount++;
    }
}

Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
File.WriteAllText(
    outputPath,
    JsonSerializer.Serialize(catalog, new JsonSerializerOptions { WriteIndented = true }),
    new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));

Console.WriteLine($"Decoded strings: {catalog.Count}");
Console.WriteLine($"Replacements: {replacementCount}");
Console.WriteLine($"Changed files: {changedFileCount}");
Console.WriteLine(outputPath);
return 0;

static byte[] UnpackStringTable(byte[] protectedBytes)
{
    var current = protectedBytes;
    while (true)
    {
        if (current.Length < 8)
        {
            throw new InvalidDataException("Protected resource header is truncated.");
        }

        var header = BitConverter.ToInt32(current, 0);
        var mode = (byte)((uint)header >> 24);
        var signature = header & 0x00FFFFFF;
        if (signature != 0x007D7A7B)
        {
            throw new InvalidDataException($"Unexpected protected resource signature: 0x{signature:X6}");
        }

        switch (mode)
        {
            case 1:
                return InflateBlocks(current);
            case 2:
                current = DecryptDes(current.AsSpan(4).ToArray());
                break;
            default:
                throw new InvalidDataException($"Unsupported protected resource mode: {mode}");
        }
    }
}

static byte[] DecryptDes(byte[] ciphertext)
{
    byte[] key = [245, 35, 118, 82, 159, 2, 179, 67];
    byte[] iv = [149, 124, 101, 201, 198, 183, 16, 200];
    using var des = DES.Create();
    using var decryptor = des.CreateDecryptor(key, iv);
    return decryptor.TransformFinalBlock(ciphertext, 0, ciphertext.Length);
}

static byte[] InflateBlocks(byte[] input)
{
    using var source = new MemoryStream(input, writable: false);
    using var reader = new BinaryReader(source, Encoding.UTF8, leaveOpen: true);
    reader.ReadInt32();
    var totalLength = reader.ReadInt32();
    using var output = new MemoryStream(totalLength);

    while (output.Length < totalLength)
    {
        var compressedLength = reader.ReadInt32();
        var uncompressedLength = reader.ReadInt32();
        var compressed = reader.ReadBytes(compressedLength);
        if (compressed.Length != compressedLength)
        {
            throw new EndOfStreamException("Compressed string-table block is truncated.");
        }

        using var blockSource = new MemoryStream(compressed, writable: false);
        using var deflate = new DeflateStream(blockSource, CompressionMode.Decompress);
        var before = output.Length;
        deflate.CopyTo(output);
        if (output.Length - before != uncompressedLength)
        {
            throw new InvalidDataException("Unexpected inflated string-table block length.");
        }
    }

    if (output.Length != totalLength)
    {
        throw new InvalidDataException("Unexpected total string-table length.");
    }
    return output.ToArray();
}

static string DecodeString(byte[] table, int offset)
{
    if ((uint)offset >= (uint)table.Length)
    {
        throw new InvalidDataException($"String offset is outside the table: {offset}");
    }

    var index = offset;
    var prefix = table[index++];
    int encodedLength;
    if ((prefix & 0x80) == 0)
    {
        encodedLength = prefix;
    }
    else if ((prefix & 0x40) == 0)
    {
        encodedLength = ((prefix & 0x3F) << 8) | table[index++];
    }
    else
    {
        encodedLength = ((prefix & 0x1F) << 24) |
                        (table[index++] << 16) |
                        (table[index++] << 8) |
                        table[index++];
    }

    if (index + encodedLength > table.Length)
    {
        throw new InvalidDataException($"Encoded string at offset {offset} is truncated.");
    }

    var base64 = Encoding.UTF8.GetString(table, index, encodedLength);
    return Encoding.UTF8.GetString(Convert.FromBase64String(base64));
}

static string ToCSharpLiteral(string value)
{
    var result = new StringBuilder(value.Length + 2);
    result.Append('"');
    foreach (var character in value)
    {
        result.Append(character switch
        {
            '"' => "\\\"",
            '\\' => "\\\\",
            '\0' => "\\0",
            '\a' => "\\a",
            '\b' => "\\b",
            '\f' => "\\f",
            '\n' => "\\n",
            '\r' => "\\r",
            '\t' => "\\t",
            '\v' => "\\v",
            _ when char.IsControl(character) => $"\\u{(int)character:X4}",
            _ => character.ToString()
        });
    }
    result.Append('"');
    return result.ToString();
}
