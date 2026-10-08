using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(TrainOnInputs1Converter))]
public record TrainOnInputs1
{
    private readonly Optional<bool> _boolValue;

    private readonly Optional<TrainOnInputs> _trainOnInputsValue;

    private TrainOnInputs1(Optional<bool> boolValue, Optional<TrainOnInputs> trainOnInputsValue)
    {
        _boolValue = boolValue;
        _trainOnInputsValue = trainOnInputsValue;
    }

    public static TrainOnInputs1 Bool(bool value) => new(Optional<bool>.Some(value), default);

    public static TrainOnInputs1 TrainOnInputs(TrainOnInputs value) =>
        new(default, Optional<TrainOnInputs>.Some(value));

    public bool TryGetBool(out bool value) => _boolValue.TryGetValue(out value);

    public bool TryGetTrainOnInputs(out TrainOnInputs value) => _trainOnInputsValue.TryGetValue(out value);

    public static implicit operator TrainOnInputs1(bool value) => Bool(value);

    public static implicit operator TrainOnInputs1(TrainOnInputs value) => TrainOnInputs(value);
}

file sealed class TrainOnInputs1Converter : JsonConverter<TrainOnInputs1>
{
    public override TrainOnInputs1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<bool>(root, options, out var boolValue))
        {
            return TrainOnInputs1.Bool(boolValue);
        }
        if (JsonSerializer.TryDeserialize<TrainOnInputs>(root, options, out var trainOnInputsValue))
        {
            return TrainOnInputs1.TrainOnInputs(trainOnInputsValue);
        }
        throw new JsonException($"JSON does not match bool or TrainOnInputs schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, TrainOnInputs1 value, JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(TrainOnInputs1)} contains no valid value to serialize.");
        }
    }
}
