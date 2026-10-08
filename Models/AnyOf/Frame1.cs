using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Optional param to specify where to insert the frame. If this is omitted, the following heuristics are applied:
/// - frame_images size is one, frame is first.
/// - If size is two, frames are first and last.
/// - If size is larger, frames are first, last and evenly spaced between.
/// </summary>
[JsonConverter(typeof(Frame1Converter))]
public record Frame1
{
    private readonly Optional<double> _doubleValue;

    private readonly Optional<Frame> _frameValue;

    private Frame1(Optional<double> doubleValue, Optional<Frame> frameValue)
    {
        _doubleValue = doubleValue;
        _frameValue = frameValue;
    }

    public static Frame1 Double(double value) => new(Optional<double>.Some(value), default);

    public static Frame1 Frame(Frame value) => new(default, Optional<Frame>.Some(value));

    public bool TryGetDouble(out double value) => _doubleValue.TryGetValue(out value);

    public bool TryGetFrame(out Frame value) => _frameValue.TryGetValue(out value);

    public static implicit operator Frame1(double value) => Double(value);

    public static implicit operator Frame1(Frame value) => Frame(value);
}

file sealed class Frame1Converter : JsonConverter<Frame1>
{
    public override Frame1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<double>(root, options, out var doubleValue))
        {
            return Frame1.Double(doubleValue);
        }
        if (JsonSerializer.TryDeserialize<Frame>(root, options, out var frameValue))
        {
            return Frame1.Frame(frameValue);
        }
        throw new JsonException($"JSON does not match double or Frame schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Frame1 value, JsonSerializerOptions options)
    {
        if (value.TryGetDouble(out var doubleValue))
        {
            JsonSerializer.Serialize(writer, doubleValue, options);
        }
        else if (value.TryGetFrame(out var frameValue))
        {
            JsonSerializer.Serialize(writer, frameValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Frame1)} contains no valid value to serialize.");
        }
    }
}
