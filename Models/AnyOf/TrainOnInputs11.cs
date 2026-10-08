using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Whether to mask user messages in conversational data or prompts in instruction data.
/// </summary>
[JsonConverter(typeof(TrainOnInputs11Converter))]
public record TrainOnInputs11
{
    private readonly Optional<bool> _boolValue;

    private readonly Optional<TrainOnInputs> _trainOnInputsValue;

    private TrainOnInputs11(Optional<bool> boolValue, Optional<TrainOnInputs> trainOnInputsValue)
    {
        _boolValue = boolValue;
        _trainOnInputsValue = trainOnInputsValue;
    }

    public static TrainOnInputs11 Bool(bool value) => new(Optional<bool>.Some(value), default);

    public static TrainOnInputs11 TrainOnInputs(TrainOnInputs value) =>
        new(default, Optional<TrainOnInputs>.Some(value));

    public bool TryGetBool(out bool value) => _boolValue.TryGetValue(out value);

    public bool TryGetTrainOnInputs(out TrainOnInputs value) => _trainOnInputsValue.TryGetValue(out value);

    public static implicit operator TrainOnInputs11(bool value) => Bool(value);

    public static implicit operator TrainOnInputs11(TrainOnInputs value) => TrainOnInputs(value);
}

file sealed class TrainOnInputs11Converter : JsonConverter<TrainOnInputs11>
{
    public override TrainOnInputs11 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<bool>(root, options, out var boolValue))
        {
            return TrainOnInputs11.Bool(boolValue);
        }
        if (JsonSerializer.TryDeserialize<TrainOnInputs>(root, options, out var trainOnInputsValue))
        {
            return TrainOnInputs11.TrainOnInputs(trainOnInputsValue);
        }
        throw new JsonException($"JSON does not match bool or TrainOnInputs schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TrainOnInputs11 value, JsonSerializerOptions options)
    {
        if (value.TryGetBool(out var boolValue))
        {
            JsonSerializer.Serialize(writer, boolValue, options);
        }
        else if (value.TryGetTrainOnInputs(out var trainOnInputsValue))
        {
            JsonSerializer.Serialize(writer, trainOnInputsValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(TrainOnInputs11)} contains no valid value to serialize.");
        }
    }
}
