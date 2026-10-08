using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Source video to edit. Accepts a URL string or an object with a "video" key.
/// </summary>
[JsonConverter(typeof(SourceVideoConverter))]
public record SourceVideo
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<VideoRef> _videoRefValue;

    private SourceVideo(Optional<string> stringValue, Optional<VideoRef> videoRefValue)
    {
        _stringValue = stringValue;
        _videoRefValue = videoRefValue;
    }

    public static SourceVideo String(string value) => new(Optional<string>.Some(value), default);

    public static SourceVideo VideoRef(VideoRef value) => new(default, Optional<VideoRef>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetVideoRef(out VideoRef value) => _videoRefValue.TryGetValue(out value);

    public static implicit operator SourceVideo(string value) => String(value);

    public static implicit operator SourceVideo(VideoRef value) => VideoRef(value);
}

file sealed class SourceVideoConverter : JsonConverter<SourceVideo>
{
    public override SourceVideo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return SourceVideo.String(value);
        }
        if (JsonSerializer.TryDeserialize<VideoRef>(root, options, out var videoRefValue))
        {
            return SourceVideo.VideoRef(videoRefValue);
        }
        throw new JsonException($"JSON does not match string or VideoRef schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, SourceVideo value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetVideoRef(out var videoRefValue))
        {
            JsonSerializer.Serialize(writer, videoRefValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(SourceVideo)} contains no valid value to serialize.");
        }
    }
}
