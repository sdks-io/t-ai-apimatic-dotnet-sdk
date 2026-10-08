using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(TrainingTypeConverter))]
public record TrainingType
{
    private readonly Optional<FullTrainingType> _fullTrainingTypeValue;

    private readonly Optional<LoRaTrainingType> _loRaTrainingTypeValue;

    private TrainingType(Optional<FullTrainingType> fullTrainingTypeValue,
        Optional<LoRaTrainingType> loRaTrainingTypeValue)
    {
        _fullTrainingTypeValue = fullTrainingTypeValue;
        _loRaTrainingTypeValue = loRaTrainingTypeValue;
    }

    public static TrainingType FullTrainingType(FullTrainingType value) =>
        new(Optional<FullTrainingType>.Some(value), default);

    public static TrainingType LoRaTrainingType(LoRaTrainingType value) =>
        new(default, Optional<LoRaTrainingType>.Some(value));

    public bool TryGetFullTrainingType(out FullTrainingType value) => _fullTrainingTypeValue.TryGetValue(out value);

    public bool TryGetLoRaTrainingType(out LoRaTrainingType value) => _loRaTrainingTypeValue.TryGetValue(out value);

    public static implicit operator TrainingType(FullTrainingType value) => FullTrainingType(value);

    public static implicit operator TrainingType(LoRaTrainingType value) => LoRaTrainingType(value);
}

file sealed class TrainingTypeConverter : JsonConverter<TrainingType>
{
    public override TrainingType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<FullTrainingType>(root, options, out var fullTrainingTypeValue))
        {
            return TrainingType.FullTrainingType(fullTrainingTypeValue);
        }
        if (JsonSerializer.TryDeserialize<LoRaTrainingType>(root, options, out var loRaTrainingTypeValue))
        {
            return TrainingType.LoRaTrainingType(loRaTrainingTypeValue);
        }
        throw new JsonException($"JSON does not match FullTrainingType or LoRaTrainingType schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TrainingType value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TrainingType)} contains no valid value to serialize.");
        }
    }
}
