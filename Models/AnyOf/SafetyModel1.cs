using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// The name of the moderation model used to validate tokens. Choose from the available moderation models found <see href="https://docs.together.ai/docs/inference-models#moderation-models">here</see>.
/// </summary>
[JsonConverter(typeof(SafetyModel1Converter))]
public record SafetyModel1
{
    private readonly Optional<SafetyModel> _safetyModelValue;

    private readonly Optional<string> _stringValue;

    private SafetyModel1(Optional<SafetyModel> safetyModelValue, Optional<string> stringValue)
    {
        _safetyModelValue = safetyModelValue;
        _stringValue = stringValue;
    }

    public static SafetyModel1 SafetyModel(SafetyModel value) => new(Optional<SafetyModel>.Some(value), default);

    public static SafetyModel1 String(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetSafetyModel(out SafetyModel value) => _safetyModelValue.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator SafetyModel1(SafetyModel value) => SafetyModel(value);

    public static implicit operator SafetyModel1(string value) => String(value);
}

file sealed class SafetyModel1Converter : JsonConverter<SafetyModel1>
{
    public override SafetyModel1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<SafetyModel>(root, options, out var safetyModelValue))
        {
            return SafetyModel1.SafetyModel(safetyModelValue);
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return SafetyModel1.String(value);
        }
        throw new JsonException($"JSON does not match SafetyModel or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, SafetyModel1 value, JsonSerializerOptions options)
    {
        if (value.TryGetSafetyModel(out var safetyModelValue))
        {
            JsonSerializer.Serialize(writer, safetyModelValue, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SafetyModel1)} contains no valid value to serialize.");
        }
    }
}
