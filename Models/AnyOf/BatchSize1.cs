using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(BatchSize1Converter))]
public record BatchSize1
{
    private readonly Optional<int> _intValue;

    private readonly Optional<BatchSize> _batchSizeValue;

    private BatchSize1(Optional<int> intValue, Optional<BatchSize> batchSizeValue)
    {
        _intValue = intValue;
        _batchSizeValue = batchSizeValue;
    }

    public static BatchSize1 Int(int value) => new(Optional<int>.Some(value), default);

    public static BatchSize1 BatchSize(BatchSize value) => new(default, Optional<BatchSize>.Some(value));

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public bool TryGetBatchSize(out BatchSize value) => _batchSizeValue.TryGetValue(out value);

    public static implicit operator BatchSize1(int value) => Int(value);

    public static implicit operator BatchSize1(BatchSize value) => BatchSize(value);
}

file sealed class BatchSize1Converter : JsonConverter<BatchSize1>
{
    public override BatchSize1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue))
            {
                return BatchSize1.Int(intValue);
            }
        }
        if (JsonSerializer.TryDeserialize<BatchSize>(root, options, out var batchSizeValue))
        {
            return BatchSize1.BatchSize(batchSizeValue);
        }
        throw new JsonException($"JSON does not match int or BatchSize schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, BatchSize1 value, JsonSerializerOptions options)
    {
        if (value.TryGetInt(out var intValue))
        {
            JsonSerializer.Serialize(writer, intValue, options);
        }
        else if (value.TryGetBatchSize(out var batchSizeValue))
        {
            JsonSerializer.Serialize(writer, batchSizeValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(BatchSize1)} contains no valid value to serialize.");
        }
    }
}
