using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Number of training examples processed together (larger batches use more memory but may train faster). Defaults to "max". We use training optimizations like packing, so the effective batch size may be different than the value you set.
/// </summary>
[JsonConverter(typeof(BatchSize11Converter))]
public record BatchSize11
{
    private readonly Optional<int> _intValue;

    private readonly Optional<BatchSize> _batchSizeValue;

    private BatchSize11(Optional<int> intValue, Optional<BatchSize> batchSizeValue)
    {
        _intValue = intValue;
        _batchSizeValue = batchSizeValue;
    }

    public static BatchSize11 Int(int value) => new(Optional<int>.Some(value), default);

    public static BatchSize11 BatchSize(BatchSize value) => new(default, Optional<BatchSize>.Some(value));

    public bool TryGetInt(out int value) => _intValue.TryGetValue(out value);

    public bool TryGetBatchSize(out BatchSize value) => _batchSizeValue.TryGetValue(out value);

    public static implicit operator BatchSize11(int value) => Int(value);

    public static implicit operator BatchSize11(BatchSize value) => BatchSize(value);
}

file sealed class BatchSize11Converter : JsonConverter<BatchSize11>
{
    public override BatchSize11 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.Number)
        {
            if (root.TryGetInt32(out var intValue))
            {
                return BatchSize11.Int(intValue);
            }
        }
        if (JsonSerializer.TryDeserialize<BatchSize>(root, options, out var batchSizeValue))
        {
            return BatchSize11.BatchSize(batchSizeValue);
        }
        throw new JsonException($"JSON does not match int or BatchSize schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, BatchSize11 value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(BatchSize11)} contains no valid value to serialize.");
        }
    }
}
