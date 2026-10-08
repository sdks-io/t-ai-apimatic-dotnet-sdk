using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Sampling strategy for endpoint-level shadow traffic. Exactly one strategy must be set.
/// </summary>
[JsonConverter(typeof(DeShadowExperimentSampling4Converter))]
public record DeShadowExperimentSampling4
{
    private readonly Optional<DeShadowExperimentSampling> _deShadowExperimentSamplingValue;

    private readonly Optional<DeShadowExperimentSampling1> _deShadowExperimentSampling1Value;

    private readonly Optional<DeShadowExperimentSampling2> _deShadowExperimentSampling2Value;

    private readonly Optional<DeShadowExperimentSampling3> _deShadowExperimentSampling3Value;

    private DeShadowExperimentSampling4(Optional<DeShadowExperimentSampling> deShadowExperimentSamplingValue,
        Optional<DeShadowExperimentSampling1> deShadowExperimentSampling1Value,
        Optional<DeShadowExperimentSampling2> deShadowExperimentSampling2Value,
        Optional<DeShadowExperimentSampling3> deShadowExperimentSampling3Value)
    {
        _deShadowExperimentSamplingValue = deShadowExperimentSamplingValue;
        _deShadowExperimentSampling1Value = deShadowExperimentSampling1Value;
        _deShadowExperimentSampling2Value = deShadowExperimentSampling2Value;
        _deShadowExperimentSampling3Value = deShadowExperimentSampling3Value;
    }

    public static DeShadowExperimentSampling4 DeShadowExperimentSampling(DeShadowExperimentSampling value) =>
        new(Optional<DeShadowExperimentSampling>.Some(value), default, default, default);

    public static DeShadowExperimentSampling4 DeShadowExperimentSampling1(DeShadowExperimentSampling1 value) =>
        new(default, Optional<DeShadowExperimentSampling1>.Some(value), default, default);

    public static DeShadowExperimentSampling4 DeShadowExperimentSampling2(DeShadowExperimentSampling2 value) =>
        new(default, default, Optional<DeShadowExperimentSampling2>.Some(value), default);

    public static DeShadowExperimentSampling4 DeShadowExperimentSampling3(DeShadowExperimentSampling3 value) =>
        new(default, default, default, Optional<DeShadowExperimentSampling3>.Some(value));

    public bool TryGetDeShadowExperimentSampling(out DeShadowExperimentSampling value) =>
        _deShadowExperimentSamplingValue.TryGetValue(out value);

    public bool TryGetDeShadowExperimentSampling1(out DeShadowExperimentSampling1 value) =>
        _deShadowExperimentSampling1Value.TryGetValue(out value);

    public bool TryGetDeShadowExperimentSampling2(out DeShadowExperimentSampling2 value) =>
        _deShadowExperimentSampling2Value.TryGetValue(out value);

    public bool TryGetDeShadowExperimentSampling3(out DeShadowExperimentSampling3 value) =>
        _deShadowExperimentSampling3Value.TryGetValue(out value);

    public static implicit operator DeShadowExperimentSampling4(DeShadowExperimentSampling value) =>
        DeShadowExperimentSampling(value);

    public static implicit operator DeShadowExperimentSampling4(DeShadowExperimentSampling1 value) =>
        DeShadowExperimentSampling1(value);

    public static implicit operator DeShadowExperimentSampling4(DeShadowExperimentSampling2 value) =>
        DeShadowExperimentSampling2(value);

    public static implicit operator DeShadowExperimentSampling4(DeShadowExperimentSampling3 value) =>
        DeShadowExperimentSampling3(value);
}

file sealed class DeShadowExperimentSampling4Converter : JsonConverter<DeShadowExperimentSampling4>
{
    public override DeShadowExperimentSampling4 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DeShadowExperimentSampling>(
            root,
            options,
            out var deShadowExperimentSamplingValue))
        {
            return DeShadowExperimentSampling4.DeShadowExperimentSampling(deShadowExperimentSamplingValue);
        }
        if (JsonSerializer.TryDeserialize<DeShadowExperimentSampling1>(
            root,
            options,
            out var deShadowExperimentSampling1Value))
        {
            return DeShadowExperimentSampling4.DeShadowExperimentSampling1(deShadowExperimentSampling1Value);
        }
        if (JsonSerializer.TryDeserialize<DeShadowExperimentSampling2>(
            root,
            options,
            out var deShadowExperimentSampling2Value))
        {
            return DeShadowExperimentSampling4.DeShadowExperimentSampling2(deShadowExperimentSampling2Value);
        }
        if (JsonSerializer.TryDeserialize<DeShadowExperimentSampling3>(
            root,
            options,
            out var deShadowExperimentSampling3Value))
        {
            return DeShadowExperimentSampling4.DeShadowExperimentSampling3(deShadowExperimentSampling3Value);
        }
        throw new JsonException(
            $"JSON does not match DeShadowExperimentSampling or DeShadowExperimentSampling1 or DeShadowExperimentSampling2 or DeShadowExperimentSampling3 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DeShadowExperimentSampling4 value, JsonSerializerOptions options)
    {
        if (value.TryGetDeShadowExperimentSampling(out var deShadowExperimentSamplingValue))
        {
            JsonSerializer.Serialize(writer, deShadowExperimentSamplingValue, options);
        }
        else if (value.TryGetDeShadowExperimentSampling1(out var deShadowExperimentSampling1Value))
        {
            JsonSerializer.Serialize(writer, deShadowExperimentSampling1Value, options);
        }
        else if (value.TryGetDeShadowExperimentSampling2(out var deShadowExperimentSampling2Value))
        {
            JsonSerializer.Serialize(writer, deShadowExperimentSampling2Value, options);
        }
        else if (value.TryGetDeShadowExperimentSampling3(out var deShadowExperimentSampling3Value))
        {
            JsonSerializer.Serialize(writer, deShadowExperimentSampling3Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(DeShadowExperimentSampling4)} contains no valid value to serialize.");
        }
    }
}
