using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(LrSchedulerArgsConverter))]
public record LrSchedulerArgs
{
    private readonly Optional<LinearLrSchedulerArgs> _linearLrSchedulerArgsValue;

    private readonly Optional<CosineLrSchedulerArgs> _cosineLrSchedulerArgsValue;

    private LrSchedulerArgs(Optional<LinearLrSchedulerArgs> linearLrSchedulerArgsValue,
        Optional<CosineLrSchedulerArgs> cosineLrSchedulerArgsValue)
    {
        _linearLrSchedulerArgsValue = linearLrSchedulerArgsValue;
        _cosineLrSchedulerArgsValue = cosineLrSchedulerArgsValue;
    }

    public static LrSchedulerArgs LinearLrSchedulerArgs(LinearLrSchedulerArgs value) =>
        new(Optional<LinearLrSchedulerArgs>.Some(value), default);

    public static LrSchedulerArgs CosineLrSchedulerArgs(CosineLrSchedulerArgs value) =>
        new(default, Optional<CosineLrSchedulerArgs>.Some(value));

    public bool TryGetLinearLrSchedulerArgs(out LinearLrSchedulerArgs value) =>
        _linearLrSchedulerArgsValue.TryGetValue(out value);

    public bool TryGetCosineLrSchedulerArgs(out CosineLrSchedulerArgs value) =>
        _cosineLrSchedulerArgsValue.TryGetValue(out value);

    public static implicit operator LrSchedulerArgs(LinearLrSchedulerArgs value) => LinearLrSchedulerArgs(value);

    public static implicit operator LrSchedulerArgs(CosineLrSchedulerArgs value) => CosineLrSchedulerArgs(value);
}

file sealed class LrSchedulerArgsConverter : JsonConverter<LrSchedulerArgs>
{
    public override LrSchedulerArgs Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<LinearLrSchedulerArgs>(root, options, out var linearLrSchedulerArgsValue))
        {
            return LrSchedulerArgs.LinearLrSchedulerArgs(linearLrSchedulerArgsValue);
        }
        if (JsonSerializer.TryDeserialize<CosineLrSchedulerArgs>(root, options, out var cosineLrSchedulerArgsValue))
        {
            return LrSchedulerArgs.CosineLrSchedulerArgs(cosineLrSchedulerArgsValue);
        }
        throw new JsonException(
            $"JSON does not match LinearLrSchedulerArgs or CosineLrSchedulerArgs schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, LrSchedulerArgs value, JsonSerializerOptions options)
    {
        if (value.TryGetLinearLrSchedulerArgs(out var linearLrSchedulerArgsValue))
        {
            JsonSerializer.Serialize(writer, linearLrSchedulerArgsValue, options);
        }
        else if (value.TryGetCosineLrSchedulerArgs(out var cosineLrSchedulerArgsValue))
        {
            JsonSerializer.Serialize(writer, cosineLrSchedulerArgsValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(LrSchedulerArgs)} contains no valid value to serialize.");
        }
    }
}
