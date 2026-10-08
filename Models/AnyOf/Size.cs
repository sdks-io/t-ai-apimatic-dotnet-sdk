using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// File size in bytes
/// </summary>
[JsonConverter(typeof(SizeConverter))]
public record Size
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private Size(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static Size String(string value) => new(Optional<string>.Some(value), default);

    public static Size Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator Size(string value) => String(value);

    public static implicit operator Size(int value) => Int(value);
}

file sealed class SizeConverter : JsonConverter<Size>
{
    public override Size Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return Size.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue))
            {
                return Size.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Size value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetInt(out var intValue))
        {
            JsonSerializer.Serialize(writer, intValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Size)} contains no valid value to serialize.");
        }
    }
}
