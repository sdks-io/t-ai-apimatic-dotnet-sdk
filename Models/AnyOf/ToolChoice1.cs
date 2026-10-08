using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Controls which (if any) function is called by the model. By default uses <c>auto</c>, which lets the model pick between generating a message or calling a function.
/// </summary>
[JsonConverter(typeof(ToolChoice1Converter))]
public record ToolChoice1
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<ToolChoice> _toolChoiceValue;

    private ToolChoice1(Optional<string> stringValue, Optional<ToolChoice> toolChoiceValue)
    {
        _stringValue = stringValue;
        _toolChoiceValue = toolChoiceValue;
    }

    public static ToolChoice1 String(string value) => new(Optional<string>.Some(value), default);

    public static ToolChoice1 ToolChoice(ToolChoice value) => new(default, Optional<ToolChoice>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetToolChoice(out ToolChoice value) => _toolChoiceValue.TryGetValue(out value);

    public static implicit operator ToolChoice1(string value) => String(value);

    public static implicit operator ToolChoice1(ToolChoice value) => ToolChoice(value);
}

file sealed class ToolChoice1Converter : JsonConverter<ToolChoice1>
{
    public override ToolChoice1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ToolChoice1.String(value);
        }
        if (JsonSerializer.TryDeserialize<ToolChoice>(root, options, out var toolChoiceValue))
        {
            return ToolChoice1.ToolChoice(toolChoiceValue);
        }
        throw new JsonException($"JSON does not match string or ToolChoice schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ToolChoice1 value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetToolChoice(out var toolChoiceValue))
        {
            JsonSerializer.Serialize(writer, toolChoiceValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ToolChoice1)} contains no valid value to serialize.");
        }
    }
}
