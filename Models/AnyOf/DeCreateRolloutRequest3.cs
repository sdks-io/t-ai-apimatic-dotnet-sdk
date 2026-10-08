using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Strategy, metric gates, timing, and cleanup policy for shifting traffic between two deployments under one endpoint.
/// </summary>
[JsonConverter(typeof(DeCreateRolloutRequest3Converter))]
public record DeCreateRolloutRequest3
{
    private readonly Optional<DeCreateRolloutRequest> _deCreateRolloutRequestValue;

    private readonly Optional<DeCreateRolloutRequest1> _deCreateRolloutRequest1Value;

    private readonly Optional<DeCreateRolloutRequest2> _deCreateRolloutRequest2Value;

    private DeCreateRolloutRequest3(Optional<DeCreateRolloutRequest> deCreateRolloutRequestValue,
        Optional<DeCreateRolloutRequest1> deCreateRolloutRequest1Value,
        Optional<DeCreateRolloutRequest2> deCreateRolloutRequest2Value)
    {
        _deCreateRolloutRequestValue = deCreateRolloutRequestValue;
        _deCreateRolloutRequest1Value = deCreateRolloutRequest1Value;
        _deCreateRolloutRequest2Value = deCreateRolloutRequest2Value;
    }

    public static DeCreateRolloutRequest3 DeCreateRolloutRequest(DeCreateRolloutRequest value) =>
        new(Optional<DeCreateRolloutRequest>.Some(value), default, default);

    public static DeCreateRolloutRequest3 DeCreateRolloutRequest1(DeCreateRolloutRequest1 value) =>
        new(default, Optional<DeCreateRolloutRequest1>.Some(value), default);

    public static DeCreateRolloutRequest3 DeCreateRolloutRequest2(DeCreateRolloutRequest2 value) =>
        new(default, default, Optional<DeCreateRolloutRequest2>.Some(value));

    public bool TryGetDeCreateRolloutRequest(out DeCreateRolloutRequest value) =>
        _deCreateRolloutRequestValue.TryGetValue(out value);

    public bool TryGetDeCreateRolloutRequest1(out DeCreateRolloutRequest1 value) =>
        _deCreateRolloutRequest1Value.TryGetValue(out value);

    public bool TryGetDeCreateRolloutRequest2(out DeCreateRolloutRequest2 value) =>
        _deCreateRolloutRequest2Value.TryGetValue(out value);

    public static implicit operator DeCreateRolloutRequest3(DeCreateRolloutRequest value) =>
        DeCreateRolloutRequest(value);

    public static implicit operator DeCreateRolloutRequest3(DeCreateRolloutRequest1 value) =>
        DeCreateRolloutRequest1(value);

    public static implicit operator DeCreateRolloutRequest3(DeCreateRolloutRequest2 value) =>
        DeCreateRolloutRequest2(value);
}

file sealed class DeCreateRolloutRequest3Converter : JsonConverter<DeCreateRolloutRequest3>
{
    public override DeCreateRolloutRequest3 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DeCreateRolloutRequest>(root, options, out var deCreateRolloutRequestValue))
        {
            return DeCreateRolloutRequest3.DeCreateRolloutRequest(deCreateRolloutRequestValue);
        }
        if (JsonSerializer.TryDeserialize<DeCreateRolloutRequest1>(root, options, out var deCreateRolloutRequest1Value))
        {
            return DeCreateRolloutRequest3.DeCreateRolloutRequest1(deCreateRolloutRequest1Value);
        }
        if (JsonSerializer.TryDeserialize<DeCreateRolloutRequest2>(root, options, out var deCreateRolloutRequest2Value))
        {
            return DeCreateRolloutRequest3.DeCreateRolloutRequest2(deCreateRolloutRequest2Value);
        }
        throw new JsonException(
            $"JSON does not match DeCreateRolloutRequest or DeCreateRolloutRequest1 or DeCreateRolloutRequest2 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DeCreateRolloutRequest3 value, JsonSerializerOptions options)
    {
        if (value.TryGetDeCreateRolloutRequest(out var deCreateRolloutRequestValue))
        {
            JsonSerializer.Serialize(writer, deCreateRolloutRequestValue, options);
        }
        else if (value.TryGetDeCreateRolloutRequest1(out var deCreateRolloutRequest1Value))
        {
            JsonSerializer.Serialize(writer, deCreateRolloutRequest1Value, options);
        }
        else if (value.TryGetDeCreateRolloutRequest2(out var deCreateRolloutRequest2Value))
        {
            JsonSerializer.Serialize(writer, deCreateRolloutRequest2Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(DeCreateRolloutRequest3)} contains no valid value to serialize.");
        }
    }
}
