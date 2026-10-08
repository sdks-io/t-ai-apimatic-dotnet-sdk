using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(CompletionStreamConverter))]
public record CompletionStream
{
    private readonly Optional<CompletionEvent> _completionEventValue;

    private readonly Optional<StreamSentinel> _streamSentinelValue;

    private CompletionStream(Optional<CompletionEvent> completionEventValue,
        Optional<StreamSentinel> streamSentinelValue)
    {
        _completionEventValue = completionEventValue;
        _streamSentinelValue = streamSentinelValue;
    }

    public static CompletionStream CompletionEvent(CompletionEvent value) =>
        new(Optional<CompletionEvent>.Some(value), default);

    public static CompletionStream StreamSentinel(StreamSentinel value) =>
        new(default, Optional<StreamSentinel>.Some(value));

    public bool TryGetCompletionEvent(out CompletionEvent value) => _completionEventValue.TryGetValue(out value);

    public bool TryGetStreamSentinel(out StreamSentinel value) => _streamSentinelValue.TryGetValue(out value);

    public static implicit operator CompletionStream(CompletionEvent value) => CompletionEvent(value);

    public static implicit operator CompletionStream(StreamSentinel value) => StreamSentinel(value);
}

file sealed class CompletionStreamConverter : JsonConverter<CompletionStream>
{
    public override CompletionStream Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<CompletionEvent>(root, options, out var completionEventValue))
        {
            return CompletionStream.CompletionEvent(completionEventValue);
        }
        if (JsonSerializer.TryDeserialize<StreamSentinel>(root, options, out var streamSentinelValue))
        {
            return CompletionStream.StreamSentinel(streamSentinelValue);
        }
        throw new JsonException($"JSON does not match CompletionEvent or StreamSentinel schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, CompletionStream value, JsonSerializerOptions options)
    {
        if (value.TryGetCompletionEvent(out var completionEventValue))
        {
            JsonSerializer.Serialize(writer, completionEventValue, options);
        }
        else if (value.TryGetStreamSentinel(out var streamSentinelValue))
        {
            JsonSerializer.Serialize(writer, streamSentinelValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(CompletionStream)} contains no valid value to serialize.");
        }
    }
}
