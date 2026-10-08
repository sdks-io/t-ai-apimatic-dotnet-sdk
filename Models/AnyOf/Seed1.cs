using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Random seed for initializing LoRA adapter weights. Ignored when LoRA is disabled or the session resumes from a checkpoint.
/// </summary>
[JsonConverter(typeof(Seed1Converter))]
public record Seed1
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private Seed1(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static Seed1 String(string value) => new(Optional<string>.Some(value), default);

    public static Seed1 Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator Seed1(string value) => String(value);

    public static implicit operator Seed1(int value) => Int(value);
}

file sealed class Seed1Converter : JsonConverter<Seed1>
{
    public override Seed1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return Seed1.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue))
            {
                return Seed1.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Seed1 value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(Seed1)} contains no valid value to serialize.");
        }
    }
}
