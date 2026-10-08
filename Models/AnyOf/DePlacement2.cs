using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Placement controls where a deployment is scheduled.
/// </summary>
[JsonConverter(typeof(DePlacement2Converter))]
public record DePlacement2
{
    private readonly Optional<DePlacement> _dePlacementValue;

    private readonly Optional<DePlacement1> _dePlacement1Value;

    private DePlacement2(Optional<DePlacement> dePlacementValue, Optional<DePlacement1> dePlacement1Value)
    {
        _dePlacementValue = dePlacementValue;
        _dePlacement1Value = dePlacement1Value;
    }

    public static DePlacement2 DePlacement(DePlacement value) => new(Optional<DePlacement>.Some(value), default);

    public static DePlacement2 DePlacement1(DePlacement1 value) => new(default, Optional<DePlacement1>.Some(value));

    public bool TryGetDePlacement(out DePlacement value) => _dePlacementValue.TryGetValue(out value);

    public bool TryGetDePlacement1(out DePlacement1 value) => _dePlacement1Value.TryGetValue(out value);

    public static implicit operator DePlacement2(DePlacement value) => DePlacement(value);

    public static implicit operator DePlacement2(DePlacement1 value) => DePlacement1(value);
}

file sealed class DePlacement2Converter : JsonConverter<DePlacement2>
{
    public override DePlacement2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DePlacement>(root, options, out var dePlacementValue))
        {
            return DePlacement2.DePlacement(dePlacementValue);
        }
        if (JsonSerializer.TryDeserialize<DePlacement1>(root, options, out var dePlacement1Value))
        {
            return DePlacement2.DePlacement1(dePlacement1Value);
        }
        throw new JsonException($"JSON does not match DePlacement or DePlacement1 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DePlacement2 value, JsonSerializerOptions options)
    {
        if (value.TryGetDePlacement(out var dePlacementValue))
        {
            JsonSerializer.Serialize(writer, dePlacementValue, options);
        }
        else if (value.TryGetDePlacement1(out var dePlacement1Value))
        {
            JsonSerializer.Serialize(writer, dePlacement1Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(DePlacement2)} contains no valid value to serialize.");
        }
    }
}
