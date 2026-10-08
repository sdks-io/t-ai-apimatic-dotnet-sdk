using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// The training type to use. Defaults to LoRA if not provided.
/// </summary>
[JsonConverter(typeof(TrainingType2Converter))]
public record TrainingType2
{
    private readonly Optional<FullTrainingType> _fullTrainingTypeValue;

    private readonly Optional<LoRaTrainingType> _loRaTrainingTypeValue;

    private TrainingType2(Optional<FullTrainingType> fullTrainingTypeValue,
        Optional<LoRaTrainingType> loRaTrainingTypeValue)
    {
        _fullTrainingTypeValue = fullTrainingTypeValue;
        _loRaTrainingTypeValue = loRaTrainingTypeValue;
    }

    public static TrainingType2 FullTrainingType(FullTrainingType value) =>
        new(Optional<FullTrainingType>.Some(value), default);

    public static TrainingType2 LoRaTrainingType(LoRaTrainingType value) =>
        new(default, Optional<LoRaTrainingType>.Some(value));

    public bool TryGetFullTrainingType(out FullTrainingType value) => _fullTrainingTypeValue.TryGetValue(out value);

    public bool TryGetLoRaTrainingType(out LoRaTrainingType value) => _loRaTrainingTypeValue.TryGetValue(out value);

    public static implicit operator TrainingType2(FullTrainingType value) => FullTrainingType(value);

    public static implicit operator TrainingType2(LoRaTrainingType value) => LoRaTrainingType(value);
}

file sealed class TrainingType2Converter : JsonConverter<TrainingType2>
{
    public override TrainingType2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<FullTrainingType>(root, options, out var fullTrainingTypeValue))
        {
            return TrainingType2.FullTrainingType(fullTrainingTypeValue);
        }
        if (JsonSerializer.TryDeserialize<LoRaTrainingType>(root, options, out var loRaTrainingTypeValue))
        {
            return TrainingType2.LoRaTrainingType(loRaTrainingTypeValue);
        }
        throw new JsonException($"JSON does not match FullTrainingType or LoRaTrainingType schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TrainingType2 value, JsonSerializerOptions options)
    {
        if (value.TryGetFullTrainingType(out var fullTrainingTypeValue))
        {
            JsonSerializer.Serialize(writer, fullTrainingTypeValue, options);
        }
        else if (value.TryGetLoRaTrainingType(out var loRaTrainingTypeValue))
        {
            JsonSerializer.Serialize(writer, loRaTrainingTypeValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TrainingType2)} contains no valid value to serialize.");
        }
    }
}
