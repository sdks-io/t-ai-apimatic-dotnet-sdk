using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Training step at time of save
/// </summary>
[JsonConverter(typeof(Step1Converter))]
public record Step1
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private Step1(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static Step1 String(string value) => new(Optional<string>.Some(value), default);

    public static Step1 Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator Step1(string value) => String(value);

    public static implicit operator Step1(int value) => Int(value);
}

file sealed class Step1Converter : JsonConverter<Step1>
{
    public override Step1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return Step1.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue))
            {
                return Step1.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Step1 value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(Step1)} contains no valid value to serialize.");
        }
    }
}
