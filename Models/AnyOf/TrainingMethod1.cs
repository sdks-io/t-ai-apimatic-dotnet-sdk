using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(TrainingMethod1Converter))]
public record TrainingMethod1
{
    private readonly Optional<TrainingMethodSft> _trainingMethodSftValue;

    private readonly Optional<TrainingMethodDpo> _trainingMethodDpoValue;

    private TrainingMethod1(Optional<TrainingMethodSft> trainingMethodSftValue,
        Optional<TrainingMethodDpo> trainingMethodDpoValue)
    {
        _trainingMethodSftValue = trainingMethodSftValue;
        _trainingMethodDpoValue = trainingMethodDpoValue;
    }

    public static TrainingMethod1 TrainingMethodSft(TrainingMethodSft value) =>
        new(Optional<TrainingMethodSft>.Some(value), default);

    public static TrainingMethod1 TrainingMethodDpo(TrainingMethodDpo value) =>
        new(default, Optional<TrainingMethodDpo>.Some(value));

    public bool TryGetTrainingMethodSft(out TrainingMethodSft value) => _trainingMethodSftValue.TryGetValue(out value);

    public bool TryGetTrainingMethodDpo(out TrainingMethodDpo value) => _trainingMethodDpoValue.TryGetValue(out value);

    public static implicit operator TrainingMethod1(TrainingMethodSft value) => TrainingMethodSft(value);

    public static implicit operator TrainingMethod1(TrainingMethodDpo value) => TrainingMethodDpo(value);
}

file sealed class TrainingMethod1Converter : JsonConverter<TrainingMethod1>
{
    public override TrainingMethod1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<TrainingMethodSft>(root, options, out var trainingMethodSftValue))
        {
            return TrainingMethod1.TrainingMethodSft(trainingMethodSftValue);
        }
        if (JsonSerializer.TryDeserialize<TrainingMethodDpo>(root, options, out var trainingMethodDpoValue))
        {
            return TrainingMethod1.TrainingMethodDpo(trainingMethodDpoValue);
        }
        throw new JsonException(
            $"JSON does not match TrainingMethodSft or TrainingMethodDpo schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TrainingMethod1 value, JsonSerializerOptions options)
    {
        if (value.TryGetTrainingMethodSft(out var trainingMethodSftValue))
        {
            JsonSerializer.Serialize(writer, trainingMethodSftValue, options);
        }
        else if (value.TryGetTrainingMethodDpo(out var trainingMethodDpoValue))
        {
            JsonSerializer.Serialize(writer, trainingMethodDpoValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TrainingMethod1)} contains no valid value to serialize.");
        }
    }
}
