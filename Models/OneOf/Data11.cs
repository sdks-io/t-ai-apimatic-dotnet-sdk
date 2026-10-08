using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.OneOf;

[JsonConverter(typeof(Data11Converter))]
public record Data11
{
    private Data11()
    {
    }
}

file sealed class Data11Converter : JsonConverter<Data11>
{
    public override Data11 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var typeProperty))
        {
            throw new JsonException("Missing required 'type' discriminator field");
        }
        var discriminator = typeProperty.GetString();
        return discriminator switch
        {
            _ => throw new JsonException($"JSON does not match  schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer, Data11 value, JsonSerializerOptions options)
    {
        throw new JsonException($"{nameof(Data11)} contains no valid value to serialize.");
    }
}
