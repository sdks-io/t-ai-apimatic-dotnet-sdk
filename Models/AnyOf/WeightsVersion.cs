using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Policy version now available for sampling, or queued to become available for deferred sync modes. Comparable to <c>policy_segments[].version</c> on sample results.
/// </summary>
[JsonConverter(typeof(WeightsVersionConverter))]
public record WeightsVersion
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<int> _intValue;

    private WeightsVersion(Optional<string> stringValue, Optional<int> intValue)
    {
        _stringValue = stringValue;
        _intValue = intValue;
    }

    public static WeightsVersion String(string value) => new(Optional<string>.Some(value), default);

    public static WeightsVersion Int(int value) => new(default, Optional<int>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public static implicit operator WeightsVersion(string value) => String(value);

    public static implicit operator WeightsVersion(int value) => Int(value);
}

file sealed class WeightsVersionConverter : JsonConverter<WeightsVersion>
{
    public override WeightsVersion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return WeightsVersion.String(value);
        }
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue))
            {
                return WeightsVersion.Int(intValue);
            }
        }
        throw new JsonException($"JSON does not match string or int schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, WeightsVersion value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(WeightsVersion)} contains no valid value to serialize.");
        }
    }
}
