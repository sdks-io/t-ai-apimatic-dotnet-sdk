using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(AudioInputConverter))]
public record AudioInput
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<AudioRef> _audioRefValue;

    private AudioInput(Optional<string> stringValue, Optional<AudioRef> audioRefValue)
    {
        _stringValue = stringValue;
        _audioRefValue = audioRefValue;
    }

    public static AudioInput String(string value) => new(Optional<string>.Some(value), default);

    public static AudioInput AudioRef(AudioRef value) => new(default, Optional<AudioRef>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetAudioRef(out AudioRef value) => _audioRefValue.TryGetValue(out value);

    public static implicit operator AudioInput(string value) => String(value);

    public static implicit operator AudioInput(AudioRef value) => AudioRef(value);
}

file sealed class AudioInputConverter : JsonConverter<AudioInput>
{
    public override AudioInput Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return AudioInput.String(value);
        }
        if (JsonSerializer.TryDeserialize<AudioRef>(root, options, out var audioRefValue))
        {
            return AudioInput.AudioRef(audioRefValue);
        }
        throw new JsonException($"JSON does not match string or AudioRef schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, AudioInput value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetAudioRef(out var audioRefValue))
        {
            JsonSerializer.Serialize(writer, audioRefValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(AudioInput)} contains no valid value to serialize.");
        }
    }
}
