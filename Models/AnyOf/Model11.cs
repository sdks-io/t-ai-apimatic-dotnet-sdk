using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// The name of the model to query.&lt;br&gt; &lt;br&gt; <see href="https://docs.together.ai/docs/serverless-models#chat-models">See all of Together AI's chat models</see>
/// </summary>
[JsonConverter(typeof(Model11Converter))]
public record Model11
{
    private readonly Optional<Model1> _model1Value;

    private readonly Optional<string> _stringValue;

    private Model11(Optional<Model1> model1Value, Optional<string> stringValue)
    {
        _model1Value = model1Value;
        _stringValue = stringValue;
    }

    public static Model11 Model1(Model1 value) => new(Optional<Model1>.Some(value), default);

    public static Model11 String(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetModel1(out Model1 value) => _model1Value.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator Model11(Model1 value) => Model1(value);

    public static implicit operator Model11(string value) => String(value);
}

file sealed class Model11Converter : JsonConverter<Model11>
{
    public override Model11 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Model1>(root, options, out var model1Value))
        {
            return Model11.Model1(model1Value);
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return Model11.String(value);
        }
        throw new JsonException($"JSON does not match Model1 or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Model11 value, JsonSerializerOptions options)
    {
        if (value.TryGetModel1(out var model1Value))
        {
            JsonSerializer.Serialize(writer, model1Value, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Model11)} contains no valid value to serialize.");
        }
    }
}
