using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// The model to be used for the rerank request.&lt;br&gt; &lt;br&gt; <see href="https://docs.together.ai/docs/serverless-models#rerank-models">See all of Together AI's rerank models</see>
/// </summary>
[JsonConverter(typeof(Model7Converter))]
public record Model7
{
    private readonly Optional<Model> _modelValue;

    private readonly Optional<string> _stringValue;

    private Model7(Optional<Model> modelValue, Optional<string> stringValue)
    {
        _modelValue = modelValue;
        _stringValue = stringValue;
    }

    public static Model7 Model(Model value) => new(Optional<Model>.Some(value), default);

    public static Model7 String(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetModel(out Model value) => _modelValue.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator Model7(Model value) => Model(value);

    public static implicit operator Model7(string value) => String(value);
}

file sealed class Model7Converter : JsonConverter<Model7>
{
    public override Model7 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Model>(root, options, out var modelValue))
        {
            return Model7.Model(modelValue);
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return Model7.String(value);
        }
        throw new JsonException($"JSON does not match Model or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Model7 value, JsonSerializerOptions options)
    {
        if (value.TryGetModel(out var modelValue))
        {
            JsonSerializer.Serialize(writer, modelValue, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Model7)} contains no valid value to serialize.");
        }
    }
}
