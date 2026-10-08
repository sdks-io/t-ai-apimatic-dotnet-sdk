using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(FineTunesEstimatePriceResponse2Converter))]
public record FineTunesEstimatePriceResponse2
{
    private readonly Optional<FineTunesEstimatePriceResponse> _fineTunesEstimatePriceResponseValue;

    private readonly Optional<FineTunesEstimatePriceResponse1> _fineTunesEstimatePriceResponse1Value;

    private FineTunesEstimatePriceResponse2(Optional<FineTunesEstimatePriceResponse> fineTunesEstimatePriceResponseValue,
        Optional<FineTunesEstimatePriceResponse1> fineTunesEstimatePriceResponse1Value)
    {
        _fineTunesEstimatePriceResponseValue = fineTunesEstimatePriceResponseValue;
        _fineTunesEstimatePriceResponse1Value = fineTunesEstimatePriceResponse1Value;
    }

    public static FineTunesEstimatePriceResponse2 FineTunesEstimatePriceResponse(FineTunesEstimatePriceResponse value) =>
        new(Optional<FineTunesEstimatePriceResponse>.Some(value), default);

    public static FineTunesEstimatePriceResponse2 FineTunesEstimatePriceResponse1(FineTunesEstimatePriceResponse1 value) =>
        new(default, Optional<FineTunesEstimatePriceResponse1>.Some(value));

    public bool TryGetFineTunesEstimatePriceResponse(out FineTunesEstimatePriceResponse value) =>
        _fineTunesEstimatePriceResponseValue.TryGetValue(out value);

    public bool TryGetFineTunesEstimatePriceResponse1(out FineTunesEstimatePriceResponse1 value) =>
        _fineTunesEstimatePriceResponse1Value.TryGetValue(out value);

    public static implicit operator FineTunesEstimatePriceResponse2(FineTunesEstimatePriceResponse value) =>
        FineTunesEstimatePriceResponse(value);

    public static implicit operator FineTunesEstimatePriceResponse2(FineTunesEstimatePriceResponse1 value) =>
        FineTunesEstimatePriceResponse1(value);
}

file sealed class FineTunesEstimatePriceResponse2Converter : JsonConverter<FineTunesEstimatePriceResponse2>
{
    public override FineTunesEstimatePriceResponse2 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<FineTunesEstimatePriceResponse>(
            root,
            options,
            out var fineTunesEstimatePriceResponseValue))
        {
            return FineTunesEstimatePriceResponse2.FineTunesEstimatePriceResponse(fineTunesEstimatePriceResponseValue);
        }
        if (JsonSerializer.TryDeserialize<FineTunesEstimatePriceResponse1>(
            root,
            options,
            out var fineTunesEstimatePriceResponse1Value))
        {
            return FineTunesEstimatePriceResponse2.FineTunesEstimatePriceResponse1(
                fineTunesEstimatePriceResponse1Value);
        }
        throw new JsonException(
            $"JSON does not match FineTunesEstimatePriceResponse or FineTunesEstimatePriceResponse1 schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        FineTunesEstimatePriceResponse2 value,
        JsonSerializerOptions options)
    {
        if (value.TryGetFineTunesEstimatePriceResponse(out var fineTunesEstimatePriceResponseValue))
        {
            JsonSerializer.Serialize(writer, fineTunesEstimatePriceResponseValue, options);
        }
        else if (value.TryGetFineTunesEstimatePriceResponse1(out var fineTunesEstimatePriceResponse1Value))
        {
            JsonSerializer.Serialize(writer, fineTunesEstimatePriceResponse1Value, options);
        }
        else
        {
            throw new JsonException($"{nameof(FineTunesEstimatePriceResponse2)} contains no valid value to serialize.");
        }
    }
}
