using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(AudioSpeechStreamResponseConverter))]
public record AudioSpeechStreamResponse
{
    private readonly Optional<AudioSpeechStreamEvent> _audioSpeechStreamEventValue;

    private readonly Optional<StreamSentinel> _streamSentinelValue;

    private AudioSpeechStreamResponse(Optional<AudioSpeechStreamEvent> audioSpeechStreamEventValue,
        Optional<StreamSentinel> streamSentinelValue)
    {
        _audioSpeechStreamEventValue = audioSpeechStreamEventValue;
        _streamSentinelValue = streamSentinelValue;
    }

    public static AudioSpeechStreamResponse AudioSpeechStreamEvent(AudioSpeechStreamEvent value) =>
        new(Optional<AudioSpeechStreamEvent>.Some(value), default);

    public static AudioSpeechStreamResponse StreamSentinel(StreamSentinel value) =>
        new(default, Optional<StreamSentinel>.Some(value));

    public bool TryGetAudioSpeechStreamEvent(out AudioSpeechStreamEvent value) =>
        _audioSpeechStreamEventValue.TryGetValue(out value);

    public bool TryGetStreamSentinel(out StreamSentinel value) => _streamSentinelValue.TryGetValue(out value);

    public static implicit operator AudioSpeechStreamResponse(AudioSpeechStreamEvent value) =>
        AudioSpeechStreamEvent(value);

    public static implicit operator AudioSpeechStreamResponse(StreamSentinel value) => StreamSentinel(value);
}

file sealed class AudioSpeechStreamResponseConverter : JsonConverter<AudioSpeechStreamResponse>
{
    public override AudioSpeechStreamResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AudioSpeechStreamEvent>(root, options, out var audioSpeechStreamEventValue))
        {
            return AudioSpeechStreamResponse.AudioSpeechStreamEvent(audioSpeechStreamEventValue);
        }
        if (JsonSerializer.TryDeserialize<StreamSentinel>(root, options, out var streamSentinelValue))
        {
            return AudioSpeechStreamResponse.StreamSentinel(streamSentinelValue);
        }
        throw new JsonException(
            $"JSON does not match AudioSpeechStreamEvent or StreamSentinel schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AudioSpeechStreamResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetAudioSpeechStreamEvent(out var audioSpeechStreamEventValue))
        {
            JsonSerializer.Serialize(writer, audioSpeechStreamEventValue, options);
        }
        else if (value.TryGetStreamSentinel(out var streamSentinelValue))
        {
            JsonSerializer.Serialize(writer, streamSentinelValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AudioSpeechStreamResponse)} contains no valid value to serialize.");
        }
    }
}
