using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(StrictConverter))]
public record Strict
{
    private readonly Optional<bool> _boolValue;

    private Strict(Optional<bool> boolValue)
    {
        _boolValue = boolValue;
    }

    public static Strict Bool(bool value) => new(Optional<bool>.Some(value));

    public bool TryGetBool(out bool value) => _boolValue.TryGetValue(out value);

    public static implicit operator Strict(bool value) => Bool(value);
}

file sealed class StrictConverter : JsonConverter<Strict>
{
    public override Strict Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<bool>(root, options, out var boolValue))
        {
            return Strict.Bool(boolValue);
        }
        throw new JsonException($"JSON does not match bool schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Strict value, JsonSerializerOptions options)
    {
        if (value.TryGetBool(out var boolValue))
        {
            JsonSerializer.Serialize(writer, boolValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Strict)} contains no valid value to serialize.");
        }
    }
}
