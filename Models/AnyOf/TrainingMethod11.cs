using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Method of training used
/// </summary>
[JsonConverter(typeof(TrainingMethod11Converter))]
public record TrainingMethod11
{
    private readonly Optional<TrainingMethodSft> _trainingMethodSftValue;

    private readonly Optional<TrainingMethodDpo> _trainingMethodDpoValue;

    private TrainingMethod11(Optional<TrainingMethodSft> trainingMethodSftValue,
        Optional<TrainingMethodDpo> trainingMethodDpoValue)
    {
        _trainingMethodSftValue = trainingMethodSftValue;
        _trainingMethodDpoValue = trainingMethodDpoValue;
    }

    public static TrainingMethod11 TrainingMethodSft(TrainingMethodSft value) =>
        new(Optional<TrainingMethodSft>.Some(value), default);

    public static TrainingMethod11 TrainingMethodDpo(TrainingMethodDpo value) =>
        new(default, Optional<TrainingMethodDpo>.Some(value));

    public bool TryGetTrainingMethodSft(out TrainingMethodSft value) => _trainingMethodSftValue.TryGetValue(out value);

    public bool TryGetTrainingMethodDpo(out TrainingMethodDpo value) => _trainingMethodDpoValue.TryGetValue(out value);

    public static implicit operator TrainingMethod11(TrainingMethodSft value) => TrainingMethodSft(value);

    public static implicit operator TrainingMethod11(TrainingMethodDpo value) => TrainingMethodDpo(value);
}

file sealed class TrainingMethod11Converter : JsonConverter<TrainingMethod11>
{
    public override TrainingMethod11 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<TrainingMethodSft>(root, options, out var trainingMethodSftValue))
        {
            return TrainingMethod11.TrainingMethodSft(trainingMethodSftValue);
        }
        if (JsonSerializer.TryDeserialize<TrainingMethodDpo>(root, options, out var trainingMethodDpoValue))
        {
            return TrainingMethod11.TrainingMethodDpo(trainingMethodDpoValue);
        }
        throw new JsonException(
            $"JSON does not match TrainingMethodSft or TrainingMethodDpo schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TrainingMethod11 value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TrainingMethod11)} contains no valid value to serialize.");
        }
    }
}
