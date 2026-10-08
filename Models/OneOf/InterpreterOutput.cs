using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.OneOf;

[JsonConverter(typeof(InterpreterOutputConverter))]
public record InterpreterOutput
{
    private InterpreterOutput()
    {
    }
}

file sealed class InterpreterOutputConverter : JsonConverter<InterpreterOutput>
{
    public override InterpreterOutput Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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

    public override void Write(Utf8JsonWriter writer, InterpreterOutput value, JsonSerializerOptions options)
    {
        throw new JsonException($"{nameof(InterpreterOutput)} contains no valid value to serialize.");
    }
}
