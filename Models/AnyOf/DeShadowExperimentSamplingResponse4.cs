using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Sampling strategy returned for endpoint-level shadow traffic.
/// </summary>
[JsonConverter(typeof(DeShadowExperimentSamplingResponse4Converter))]
public record DeShadowExperimentSamplingResponse4
{
    private readonly Optional<DeShadowExperimentSamplingResponse> _deShadowExperimentSamplingResponseValue;

    private readonly Optional<DeShadowExperimentSamplingResponse1> _deShadowExperimentSamplingResponse1Value;

    private readonly Optional<DeShadowExperimentSamplingResponse2> _deShadowExperimentSamplingResponse2Value;

    private readonly Optional<DeShadowExperimentSamplingResponse3> _deShadowExperimentSamplingResponse3Value;

    private DeShadowExperimentSamplingResponse4(Optional<DeShadowExperimentSamplingResponse> deShadowExperimentSamplingResponseValue,
        Optional<DeShadowExperimentSamplingResponse1> deShadowExperimentSamplingResponse1Value,
        Optional<DeShadowExperimentSamplingResponse2> deShadowExperimentSamplingResponse2Value,
        Optional<DeShadowExperimentSamplingResponse3> deShadowExperimentSamplingResponse3Value)
    {
        _deShadowExperimentSamplingResponseValue = deShadowExperimentSamplingResponseValue;
        _deShadowExperimentSamplingResponse1Value = deShadowExperimentSamplingResponse1Value;
        _deShadowExperimentSamplingResponse2Value = deShadowExperimentSamplingResponse2Value;
        _deShadowExperimentSamplingResponse3Value = deShadowExperimentSamplingResponse3Value;
    }

    public static DeShadowExperimentSamplingResponse4 DeShadowExperimentSamplingResponse(DeShadowExperimentSamplingResponse value) =>
        new(Optional<DeShadowExperimentSamplingResponse>.Some(value), default, default, default);

    public static DeShadowExperimentSamplingResponse4 DeShadowExperimentSamplingResponse1(DeShadowExperimentSamplingResponse1 value) =>
        new(default, Optional<DeShadowExperimentSamplingResponse1>.Some(value), default, default);

    public static DeShadowExperimentSamplingResponse4 DeShadowExperimentSamplingResponse2(DeShadowExperimentSamplingResponse2 value) =>
        new(default, default, Optional<DeShadowExperimentSamplingResponse2>.Some(value), default);

    public static DeShadowExperimentSamplingResponse4 DeShadowExperimentSamplingResponse3(DeShadowExperimentSamplingResponse3 value) =>
        new(default, default, default, Optional<DeShadowExperimentSamplingResponse3>.Some(value));

    public bool TryGetDeShadowExperimentSamplingResponse(out DeShadowExperimentSamplingResponse value) =>
        _deShadowExperimentSamplingResponseValue.TryGetValue(out value);

    public bool TryGetDeShadowExperimentSamplingResponse1(out DeShadowExperimentSamplingResponse1 value) =>
        _deShadowExperimentSamplingResponse1Value.TryGetValue(out value);

    public bool TryGetDeShadowExperimentSamplingResponse2(out DeShadowExperimentSamplingResponse2 value) =>
        _deShadowExperimentSamplingResponse2Value.TryGetValue(out value);

    public bool TryGetDeShadowExperimentSamplingResponse3(out DeShadowExperimentSamplingResponse3 value) =>
        _deShadowExperimentSamplingResponse3Value.TryGetValue(out value);

    public static implicit operator DeShadowExperimentSamplingResponse4(DeShadowExperimentSamplingResponse value) =>
        DeShadowExperimentSamplingResponse(value);

    public static implicit operator DeShadowExperimentSamplingResponse4(DeShadowExperimentSamplingResponse1 value) =>
        DeShadowExperimentSamplingResponse1(value);

    public static implicit operator DeShadowExperimentSamplingResponse4(DeShadowExperimentSamplingResponse2 value) =>
        DeShadowExperimentSamplingResponse2(value);

    public static implicit operator DeShadowExperimentSamplingResponse4(DeShadowExperimentSamplingResponse3 value) =>
        DeShadowExperimentSamplingResponse3(value);
}

file sealed class DeShadowExperimentSamplingResponse4Converter : JsonConverter<DeShadowExperimentSamplingResponse4>
{
    public override DeShadowExperimentSamplingResponse4 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DeShadowExperimentSamplingResponse>(
            root,
            options,
            out var deShadowExperimentSamplingResponseValue))
        {
            return DeShadowExperimentSamplingResponse4.DeShadowExperimentSamplingResponse(
                deShadowExperimentSamplingResponseValue);
        }
        if (JsonSerializer.TryDeserialize<DeShadowExperimentSamplingResponse1>(
            root,
            options,
            out var deShadowExperimentSamplingResponse1Value))
        {
            return DeShadowExperimentSamplingResponse4.DeShadowExperimentSamplingResponse1(
                deShadowExperimentSamplingResponse1Value);
        }
        if (JsonSerializer.TryDeserialize<DeShadowExperimentSamplingResponse2>(
            root,
            options,
            out var deShadowExperimentSamplingResponse2Value))
        {
            return DeShadowExperimentSamplingResponse4.DeShadowExperimentSamplingResponse2(
                deShadowExperimentSamplingResponse2Value);
        }
        if (JsonSerializer.TryDeserialize<DeShadowExperimentSamplingResponse3>(
            root,
            options,
            out var deShadowExperimentSamplingResponse3Value))
        {
            return DeShadowExperimentSamplingResponse4.DeShadowExperimentSamplingResponse3(
                deShadowExperimentSamplingResponse3Value);
        }
        throw new JsonException(
            $"JSON does not match DeShadowExperimentSamplingResponse or DeShadowExperimentSamplingResponse1 or DeShadowExperimentSamplingResponse2 or DeShadowExperimentSamplingResponse3 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        DeShadowExperimentSamplingResponse4 value,
        JsonSerializerOptions options)
    {
        if (value.TryGetDeShadowExperimentSamplingResponse(out var deShadowExperimentSamplingResponseValue))
        {
            JsonSerializer.Serialize(writer, deShadowExperimentSamplingResponseValue, options);
        }
        else if (value.TryGetDeShadowExperimentSamplingResponse1(out var deShadowExperimentSamplingResponse1Value))
        {
            JsonSerializer.Serialize(writer, deShadowExperimentSamplingResponse1Value, options);
        }
        else if (value.TryGetDeShadowExperimentSamplingResponse2(out var deShadowExperimentSamplingResponse2Value))
        {
            JsonSerializer.Serialize(writer, deShadowExperimentSamplingResponse2Value, options);
        }
        else if (value.TryGetDeShadowExperimentSamplingResponse3(out var deShadowExperimentSamplingResponse3Value))
        {
            JsonSerializer.Serialize(writer, deShadowExperimentSamplingResponse3Value, options);
        }
        else
        {
            throw new JsonException(
                $"{nameof(DeShadowExperimentSamplingResponse4)} contains no valid value to serialize.");
        }
    }
}
