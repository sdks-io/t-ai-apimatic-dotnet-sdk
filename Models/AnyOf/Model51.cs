using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// The name of the embedding model to use.&lt;br&gt; &lt;br&gt; <see href="https://docs.together.ai/docs/serverless-models#embedding-models">See all of Together AI's embedding models</see>
/// </summary>
[JsonConverter(typeof(Model51Converter))]
public record Model51
{
    private readonly Optional<Model5> _model5Value;

    private readonly Optional<string> _stringValue;

    private Model51(Optional<Model5> model5Value, Optional<string> stringValue)
    {
        _model5Value = model5Value;
        _stringValue = stringValue;
    }

    public static Model51 Model5(Model5 value) => new(Optional<Model5>.Some(value), default);

    public static Model51 String(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetModel5(out Model5 value) => _model5Value.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator Model51(Model5 value) => Model5(value);

    public static implicit operator Model51(string value) => String(value);
}

file sealed class Model51Converter : JsonConverter<Model51>
{
    public override Model51 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<Model5>(root, options, out var model5Value))
        {
            return Model51.Model5(model5Value);
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return Model51.String(value);
        }
        throw new JsonException($"JSON does not match Model5 or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Model51 value, JsonSerializerOptions options)
    {
        if (value.TryGetModel5(out var model5Value))
        {
            JsonSerializer.Serialize(writer, model5Value, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Model51)} contains no valid value to serialize.");
        }
    }
}
