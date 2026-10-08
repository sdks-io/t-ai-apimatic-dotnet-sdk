using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(ChatCompletionStreamConverter))]
public record ChatCompletionStream
{
    private readonly Optional<ChatCompletionEvent> _chatCompletionEventValue;

    private readonly Optional<StreamSentinel> _streamSentinelValue;

    private ChatCompletionStream(Optional<ChatCompletionEvent> chatCompletionEventValue,
        Optional<StreamSentinel> streamSentinelValue)
    {
        _chatCompletionEventValue = chatCompletionEventValue;
        _streamSentinelValue = streamSentinelValue;
    }

    public static ChatCompletionStream ChatCompletionEvent(ChatCompletionEvent value) =>
        new(Optional<ChatCompletionEvent>.Some(value), default);

    public static ChatCompletionStream StreamSentinel(StreamSentinel value) =>
        new(default, Optional<StreamSentinel>.Some(value));

    public bool TryGetChatCompletionEvent(out ChatCompletionEvent value) =>
        _chatCompletionEventValue.TryGetValue(out value);

    public bool TryGetStreamSentinel(out StreamSentinel value) => _streamSentinelValue.TryGetValue(out value);

    public static implicit operator ChatCompletionStream(ChatCompletionEvent value) => ChatCompletionEvent(value);

    public static implicit operator ChatCompletionStream(StreamSentinel value) => StreamSentinel(value);
}

file sealed class ChatCompletionStreamConverter : JsonConverter<ChatCompletionStream>
{
    public override ChatCompletionStream Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<ChatCompletionEvent>(root, options, out var chatCompletionEventValue))
        {
            return ChatCompletionStream.ChatCompletionEvent(chatCompletionEventValue);
        }
        if (JsonSerializer.TryDeserialize<StreamSentinel>(root, options, out var streamSentinelValue))
        {
            return ChatCompletionStream.StreamSentinel(streamSentinelValue);
        }
        throw new JsonException(
            $"JSON does not match ChatCompletionEvent or StreamSentinel schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ChatCompletionStream value, JsonSerializerOptions options)
    {
        if (value.TryGetChatCompletionEvent(out var chatCompletionEventValue))
        {
            JsonSerializer.Serialize(writer, chatCompletionEventValue, options);
        }
        else if (value.TryGetStreamSentinel(out var streamSentinelValue))
        {
            JsonSerializer.Serialize(writer, streamSentinelValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ChatCompletionStream)} contains no valid value to serialize.");
        }
    }
}
