using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(AudioTranslationResponseConverter))]
public record AudioTranslationResponse
{
    private readonly Optional<AudioTranslationJsonResponse> _audioTranslationJsonResponseValue;

    private readonly Optional<AudioTranslationVerboseJsonResponse> _audioTranslationVerboseJsonResponseValue;

    private AudioTranslationResponse(Optional<AudioTranslationJsonResponse> audioTranslationJsonResponseValue,
        Optional<AudioTranslationVerboseJsonResponse> audioTranslationVerboseJsonResponseValue)
    {
        _audioTranslationJsonResponseValue = audioTranslationJsonResponseValue;
        _audioTranslationVerboseJsonResponseValue = audioTranslationVerboseJsonResponseValue;
    }

    public static AudioTranslationResponse AudioTranslationJsonResponse(AudioTranslationJsonResponse value) =>
        new(Optional<AudioTranslationJsonResponse>.Some(value), default);

    public static AudioTranslationResponse AudioTranslationVerboseJsonResponse(AudioTranslationVerboseJsonResponse value) =>
        new(default, Optional<AudioTranslationVerboseJsonResponse>.Some(value));

    public bool TryGetAudioTranslationJsonResponse(out AudioTranslationJsonResponse value) =>
        _audioTranslationJsonResponseValue.TryGetValue(out value);

    public bool TryGetAudioTranslationVerboseJsonResponse(out AudioTranslationVerboseJsonResponse value) =>
        _audioTranslationVerboseJsonResponseValue.TryGetValue(out value);

    public static implicit operator AudioTranslationResponse(AudioTranslationJsonResponse value) =>
        AudioTranslationJsonResponse(value);

    public static implicit operator AudioTranslationResponse(AudioTranslationVerboseJsonResponse value) =>
        AudioTranslationVerboseJsonResponse(value);
}

file sealed class AudioTranslationResponseConverter : JsonConverter<AudioTranslationResponse>
{
    public override AudioTranslationResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AudioTranslationJsonResponse>(
            root,
            options,
            out var audioTranslationJsonResponseValue))
        {
            return AudioTranslationResponse.AudioTranslationJsonResponse(audioTranslationJsonResponseValue);
        }
        if (JsonSerializer.TryDeserialize<AudioTranslationVerboseJsonResponse>(
            root,
            options,
            out var audioTranslationVerboseJsonResponseValue))
        {
            return AudioTranslationResponse.AudioTranslationVerboseJsonResponse(
                audioTranslationVerboseJsonResponseValue);
        }
        throw new JsonException(
            $"JSON does not match AudioTranslationJsonResponse or AudioTranslationVerboseJsonResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AudioTranslationResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetAudioTranslationJsonResponse(out var audioTranslationJsonResponseValue))
        {
            JsonSerializer.Serialize(writer, audioTranslationJsonResponseValue, options);
        }
        else if (value.TryGetAudioTranslationVerboseJsonResponse(out var audioTranslationVerboseJsonResponseValue))
        {
            JsonSerializer.Serialize(writer, audioTranslationVerboseJsonResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AudioTranslationResponse)} contains no valid value to serialize.");
        }
    }
}
