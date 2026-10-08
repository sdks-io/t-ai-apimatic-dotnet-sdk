using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// The model to use for image generation.&lt;br&gt; &lt;br&gt; <see href="https://docs.together.ai/docs/serverless-models#image-models">See all of Together AI's image models</see>
/// </summary>
[JsonConverter(typeof(Model61Converter))]
public record Model61
{
    private readonly Optional<Model6> _model6Value;

    private readonly Optional<string> _stringValue;

    private Model61(Optional<Model6> model6Value, Optional<string> stringValue)
    {
        _model6Value = model6Value;
        _stringValue = stringValue;
    }

    public static Model61 Model6(Model6 value) => new(Optional<Model6>.Some(value), default);

    public static Model61 String(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetModel6(out Model6 value) => _model6Value.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator Model61(Model6 value) => Model6(value);

    public static implicit operator Model61(string value) => String(value);
}

file sealed class Model61Converter : JsonConverter<Model61>
{
    public override Model61 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Model6>(root, options, out var model6Value))
        {
            return Model61.Model6(model6Value);
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return Model61.String(value);
        }
        throw new JsonException($"JSON does not match Model6 or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Model61 value, JsonSerializerOptions options)
    {
        if (value.TryGetModel6(out var model6Value))
        {
            JsonSerializer.Serialize(writer, model6Value, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Model61)} contains no valid value to serialize.");
        }
    }
}
