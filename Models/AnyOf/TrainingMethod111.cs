using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// The training method to use. 'sft' for Supervised Fine-Tuning or 'dpo' for Direct Preference Optimization.
/// </summary>
[JsonConverter(typeof(TrainingMethod111Converter))]
public record TrainingMethod111
{
    private readonly Optional<TrainingMethodSft> _trainingMethodSftValue;

    private readonly Optional<TrainingMethodDpo> _trainingMethodDpoValue;

    private TrainingMethod111(Optional<TrainingMethodSft> trainingMethodSftValue,
        Optional<TrainingMethodDpo> trainingMethodDpoValue)
    {
        _trainingMethodSftValue = trainingMethodSftValue;
        _trainingMethodDpoValue = trainingMethodDpoValue;
    }

    public static TrainingMethod111 TrainingMethodSft(TrainingMethodSft value) =>
        new(Optional<TrainingMethodSft>.Some(value), default);

    public static TrainingMethod111 TrainingMethodDpo(TrainingMethodDpo value) =>
        new(default, Optional<TrainingMethodDpo>.Some(value));

    public bool TryGetTrainingMethodSft(out TrainingMethodSft value) => _trainingMethodSftValue.TryGetValue(out value);

    public bool TryGetTrainingMethodDpo(out TrainingMethodDpo value) => _trainingMethodDpoValue.TryGetValue(out value);

    public static implicit operator TrainingMethod111(TrainingMethodSft value) => TrainingMethodSft(value);

    public static implicit operator TrainingMethod111(TrainingMethodDpo value) => TrainingMethodDpo(value);
}

file sealed class TrainingMethod111Converter : JsonConverter<TrainingMethod111>
{
    public override TrainingMethod111 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<TrainingMethodSft>(root, options, out var trainingMethodSftValue))
        {
            return TrainingMethod111.TrainingMethodSft(trainingMethodSftValue);
        }
        if (JsonSerializer.TryDeserialize<TrainingMethodDpo>(root, options, out var trainingMethodDpoValue))
        {
            return TrainingMethod111.TrainingMethodDpo(trainingMethodDpoValue);
        }
        throw new JsonException(
            $"JSON does not match TrainingMethodSft or TrainingMethodDpo schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TrainingMethod111 value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TrainingMethod111)} contains no valid value to serialize.");
        }
    }
}
