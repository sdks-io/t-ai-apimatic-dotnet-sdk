using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(FineTunesPreviewResponseConverter))]
public record FineTunesPreviewResponse
{
    private readonly Optional<FineTunePreviewMessageError> _fineTunePreviewMessageErrorValue;

    private readonly Optional<FineTunePreviewDetailError> _fineTunePreviewDetailErrorValue;

    private FineTunesPreviewResponse(Optional<FineTunePreviewMessageError> fineTunePreviewMessageErrorValue,
        Optional<FineTunePreviewDetailError> fineTunePreviewDetailErrorValue)
    {
        _fineTunePreviewMessageErrorValue = fineTunePreviewMessageErrorValue;
        _fineTunePreviewDetailErrorValue = fineTunePreviewDetailErrorValue;
    }

    public static FineTunesPreviewResponse FineTunePreviewMessageError(FineTunePreviewMessageError value) =>
        new(Optional<FineTunePreviewMessageError>.Some(value), default);

    public static FineTunesPreviewResponse FineTunePreviewDetailError(FineTunePreviewDetailError value) =>
        new(default, Optional<FineTunePreviewDetailError>.Some(value));

    public bool TryGetFineTunePreviewMessageError(out FineTunePreviewMessageError value) =>
        _fineTunePreviewMessageErrorValue.TryGetValue(out value);

    public bool TryGetFineTunePreviewDetailError(out FineTunePreviewDetailError value) =>
        _fineTunePreviewDetailErrorValue.TryGetValue(out value);

    public static implicit operator FineTunesPreviewResponse(FineTunePreviewMessageError value) =>
        FineTunePreviewMessageError(value);

    public static implicit operator FineTunesPreviewResponse(FineTunePreviewDetailError value) =>
        FineTunePreviewDetailError(value);
}

file sealed class FineTunesPreviewResponseConverter : JsonConverter<FineTunesPreviewResponse>
{
    public override FineTunesPreviewResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<FineTunePreviewMessageError>(
            root,
            options,
            out var fineTunePreviewMessageErrorValue))
        {
            return FineTunesPreviewResponse.FineTunePreviewMessageError(fineTunePreviewMessageErrorValue);
        }
        if (JsonSerializer.TryDeserialize<FineTunePreviewDetailError>(
            root,
            options,
            out var fineTunePreviewDetailErrorValue))
        {
            return FineTunesPreviewResponse.FineTunePreviewDetailError(fineTunePreviewDetailErrorValue);
        }
        throw new JsonException(
            $"JSON does not match FineTunePreviewMessageError or FineTunePreviewDetailError schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, FineTunesPreviewResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetFineTunePreviewMessageError(out var fineTunePreviewMessageErrorValue))
        {
            JsonSerializer.Serialize(writer, fineTunePreviewMessageErrorValue, options);
        }
        else if (value.TryGetFineTunePreviewDetailError(out var fineTunePreviewDetailErrorValue))
        {
            JsonSerializer.Serialize(writer, fineTunePreviewDetailErrorValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(FineTunesPreviewResponse)} contains no valid value to serialize.");
        }
    }
}
