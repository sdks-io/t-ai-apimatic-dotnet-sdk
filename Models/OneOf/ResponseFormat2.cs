using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.OneOf;

/// <summary>
/// An object specifying the format that the model must output.
/// <para>
/// Setting to <c>{ "type": "json_schema", "json_schema": {...} }</c> enables
/// Structured Outputs which ensures the model will match your supplied JSON
/// schema. Learn more in the [Structured Outputs
/// guide](https://docs.together.ai/docs/json-mode).
/// </para>
/// <para>
/// Setting to <c>{ "type": "json_object" }</c> enables the older JSON mode, which
/// ensures the message the model generates is valid JSON. Using <c>json_schema</c>
/// is preferred for models that support it.
/// </para>
/// </summary>
[JsonConverter(typeof(ResponseFormat2Converter))]
public record ResponseFormat2
{
    private ResponseFormat2()
    {
    }
}

file sealed class ResponseFormat2Converter : JsonConverter<ResponseFormat2>
{
    public override ResponseFormat2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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

    public override void Write(Utf8JsonWriter writer, ResponseFormat2 value, JsonSerializerOptions options)
    {
        throw new JsonException($"{nameof(ResponseFormat2)} contains no valid value to serialize.");
    }
}
