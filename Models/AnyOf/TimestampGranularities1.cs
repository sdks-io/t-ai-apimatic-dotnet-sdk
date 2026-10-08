using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Controls level of timestamp detail in verbose_json. Only used when response_format is verbose_json. Can be a single granularity or an array to get multiple levels.
/// </summary>
[JsonConverter(typeof(TimestampGranularities1Converter))]
public record TimestampGranularities1
{
    private readonly Optional<TimestampGranularities> _timestampGranularitiesValue;

    private readonly Optional<IReadOnlyList<TimestampGranularities>> _listOfTimestampGranularitiesValue;

    private TimestampGranularities1(Optional<TimestampGranularities> timestampGranularitiesValue,
        Optional<IReadOnlyList<TimestampGranularities>> listOfTimestampGranularitiesValue)
    {
        _timestampGranularitiesValue = timestampGranularitiesValue;
        _listOfTimestampGranularitiesValue = listOfTimestampGranularitiesValue;
    }

    public static TimestampGranularities1 TimestampGranularities(TimestampGranularities value) =>
        new(Optional<TimestampGranularities>.Some(value), default);

    public static TimestampGranularities1 ListOfTimestampGranularities(IReadOnlyList<TimestampGranularities> value) =>
        new(default, Optional<IReadOnlyList<TimestampGranularities>>.Some(value));

    public bool TryGetTimestampGranularities(out TimestampGranularities value) =>
        _timestampGranularitiesValue.TryGetValue(out value);

    public bool TryGetListOfTimestampGranularities(out IReadOnlyList<TimestampGranularities> value) =>
        _listOfTimestampGranularitiesValue.TryGetValue(out value);

    public static implicit operator TimestampGranularities1(TimestampGranularities value) =>
        TimestampGranularities(value);
}

file sealed class TimestampGranularities1Converter : JsonConverter<TimestampGranularities1>
{
    public override TimestampGranularities1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<TimestampGranularities>(root, options, out var timestampGranularitiesValue))
        {
            return TimestampGranularities1.TimestampGranularities(timestampGranularitiesValue);
        }
        if (JsonSerializer.TryDeserialize<IReadOnlyList<TimestampGranularities>>(
            root,
            options,
            out var listOfTimestampGranularitiesValue))
        {
            return TimestampGranularities1.ListOfTimestampGranularities(listOfTimestampGranularitiesValue);
        }
        throw new JsonException(
            $"JSON does not match TimestampGranularities or IReadOnlyList<TimestampGranularities> schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TimestampGranularities1 value, JsonSerializerOptions options)
    {
        if (value.TryGetTimestampGranularities(out var timestampGranularitiesValue))
        {
            JsonSerializer.Serialize(writer, timestampGranularitiesValue, options);
        }
        else if (value.TryGetListOfTimestampGranularities(out var listOfTimestampGranularitiesValue))
        {
            JsonSerializer.Serialize(writer, listOfTimestampGranularitiesValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TimestampGranularities1)} contains no valid value to serialize.");
        }
    }
}
