using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// The name of the model to query.&lt;br&gt; &lt;br&gt; <see href="https://docs.together.ai/docs/serverless-models#audio-models">See all of Together AI's chat models</see> The current supported tts models are: - cartesia/sonic - hexgrad/Kokoro-82M - canopylabs/orpheus-3b-0.1-ft
/// </summary>
[JsonConverter(typeof(Model21Converter))]
public record Model21
{
    private readonly Optional<Model2> _model2Value;

    private readonly Optional<string> _stringValue;

    private Model21(Optional<Model2> model2Value, Optional<string> stringValue)
    {
        _model2Value = model2Value;
        _stringValue = stringValue;
    }

    public static Model21 Model2(Model2 value) => new(Optional<Model2>.Some(value), default);

    public static Model21 String(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetModel2(out Model2 value) => _model2Value.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator Model21(Model2 value) => Model2(value);

    public static implicit operator Model21(string value) => String(value);
}

file sealed class Model21Converter : JsonConverter<Model21>
{
    public override Model21 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Model2>(root, options, out var model2Value))
        {
            return Model21.Model2(model2Value);
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return Model21.String(value);
        }
        throw new JsonException($"JSON does not match Model2 or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Model21 value, JsonSerializerOptions options)
    {
        if (value.TryGetModel2(out var model2Value))
        {
            JsonSerializer.Serialize(writer, model2Value, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Model21)} contains no valid value to serialize.");
        }
    }
}
