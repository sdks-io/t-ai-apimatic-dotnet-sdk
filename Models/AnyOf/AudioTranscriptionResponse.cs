using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(AudioTranscriptionResponseConverter))]
public record AudioTranscriptionResponse
{
    private readonly Optional<AudioTranscriptionJsonResponse> _audioTranscriptionJsonResponseValue;

    private readonly Optional<AudioTranscriptionVerboseJsonResponse> _audioTranscriptionVerboseJsonResponseValue;

    private AudioTranscriptionResponse(Optional<AudioTranscriptionJsonResponse> audioTranscriptionJsonResponseValue,
        Optional<AudioTranscriptionVerboseJsonResponse> audioTranscriptionVerboseJsonResponseValue)
    {
        _audioTranscriptionJsonResponseValue = audioTranscriptionJsonResponseValue;
        _audioTranscriptionVerboseJsonResponseValue = audioTranscriptionVerboseJsonResponseValue;
    }

    public static AudioTranscriptionResponse AudioTranscriptionJsonResponse(AudioTranscriptionJsonResponse value) =>
        new(Optional<AudioTranscriptionJsonResponse>.Some(value), default);

    public static AudioTranscriptionResponse AudioTranscriptionVerboseJsonResponse(AudioTranscriptionVerboseJsonResponse value) =>
        new(default, Optional<AudioTranscriptionVerboseJsonResponse>.Some(value));

    public bool TryGetAudioTranscriptionJsonResponse(out AudioTranscriptionJsonResponse value) =>
        _audioTranscriptionJsonResponseValue.TryGetValue(out value);

    public bool TryGetAudioTranscriptionVerboseJsonResponse(out AudioTranscriptionVerboseJsonResponse value) =>
        _audioTranscriptionVerboseJsonResponseValue.TryGetValue(out value);

    public static implicit operator AudioTranscriptionResponse(AudioTranscriptionJsonResponse value) =>
        AudioTranscriptionJsonResponse(value);

    public static implicit operator AudioTranscriptionResponse(AudioTranscriptionVerboseJsonResponse value) =>
        AudioTranscriptionVerboseJsonResponse(value);
}

file sealed class AudioTranscriptionResponseConverter : JsonConverter<AudioTranscriptionResponse>
{
    public override AudioTranscriptionResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AudioTranscriptionJsonResponse>(
            root,
            options,
            out var audioTranscriptionJsonResponseValue))
        {
            return AudioTranscriptionResponse.AudioTranscriptionJsonResponse(audioTranscriptionJsonResponseValue);
        }
        if (JsonSerializer.TryDeserialize<AudioTranscriptionVerboseJsonResponse>(
            root,
            options,
            out var audioTranscriptionVerboseJsonResponseValue))
        {
            return AudioTranscriptionResponse.AudioTranscriptionVerboseJsonResponse(
                audioTranscriptionVerboseJsonResponseValue);
        }
        throw new JsonException(
            $"JSON does not match AudioTranscriptionJsonResponse or AudioTranscriptionVerboseJsonResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AudioTranscriptionResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetAudioTranscriptionJsonResponse(out var audioTranscriptionJsonResponseValue))
        {
            JsonSerializer.Serialize(writer, audioTranscriptionJsonResponseValue, options);
        }
        else if (value.TryGetAudioTranscriptionVerboseJsonResponse(out var audioTranscriptionVerboseJsonResponseValue))
        {
            JsonSerializer.Serialize(writer, audioTranscriptionVerboseJsonResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AudioTranscriptionResponse)} contains no valid value to serialize.");
        }
    }
}
