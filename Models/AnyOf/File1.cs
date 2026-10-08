using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Validation;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Audio file upload or public HTTP/HTTPS URL. Supported formats: .wav, .mp3, .m4a, .webm, .flac, .ogg, .opus, .aac. Maximum duration 4 hours; longer audio is rejected with <c>audio_too_long</c>. Binary uploads are additionally capped at 80 MB (HTTP 413); URL-fetched audio is capped at 1 GB.
/// </summary>
[JsonConverter(typeof(File1Converter))]
public record File1
{
    private readonly Optional<BinaryContent> _byteArrayValue;

    private readonly Optional<string> _uriStringValue;

    private File1(Optional<BinaryContent> byteArrayValue, Optional<string> uriStringValue)
    {
        _byteArrayValue = byteArrayValue;
        _uriStringValue = uriStringValue;
    }

    public static File1 ByteArray(BinaryContent value) => new(Optional<BinaryContent>.Some(value), default);

    public static File1 UriString(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetByteArray(out BinaryContent value) => _byteArrayValue.TryGetValue(out value);

    public bool TryGetUriString(out string value) => _uriStringValue.TryGetValue(out value);

    public static implicit operator File1(BinaryContent value) => ByteArray(value);

    public static implicit operator File1(string value) => UriString(value);
}

file sealed class File1Converter : JsonConverter<File1>
{
    public override File1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<BinaryContent>(root, options, out var byteArrayValue))
        {
            return File1.ByteArray(byteArrayValue);
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            if (value.HasFormat(FormatKind.Uri))
            {
                return File1.UriString(value);
            }
        }
        throw new JsonException($"JSON does not match BinaryContent or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, File1 value, JsonSerializerOptions options)
    {
        if (value.TryGetByteArray(out var byteArrayValue))
        {
            JsonSerializer.Serialize(writer, byteArrayValue, options);
        }
        else if (value.TryGetUriString(out var uriStringValue))
        {
            JsonSerializer.Serialize(writer, uriStringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(File1)} contains no valid value to serialize.");
        }
    }
}
