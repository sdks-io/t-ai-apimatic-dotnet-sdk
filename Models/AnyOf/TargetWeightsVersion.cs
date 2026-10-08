using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Policy version promised to the generator by the latest weights-sync.
/// </summary>
[JsonConverter(typeof(TargetWeightsVersionConverter))]
public record TargetWeightsVersion
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private TargetWeightsVersion(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static TargetWeightsVersion String(string value) => new(Optional<string>.Some(value), default);

    public static TargetWeightsVersion Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator TargetWeightsVersion(string value) => String(value);

    public static implicit operator TargetWeightsVersion(int value) => Int(value);
}

file sealed class TargetWeightsVersionConverter : JsonConverter<TargetWeightsVersion>
{
    public override TargetWeightsVersion Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return TargetWeightsVersion.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue))
            {
                return TargetWeightsVersion.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TargetWeightsVersion value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TargetWeightsVersion)} contains no valid value to serialize.");
        }
    }
}
