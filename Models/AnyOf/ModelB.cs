using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Either an EvaluationModelRequest for generation or a string column name from the dataset (when responses are pre-generated). When both model_a and model_b are EvaluationModelRequest objects, their inference runs execute in parallel to reduce total wall-clock time.
/// </summary>
[JsonConverter(typeof(ModelBConverter))]
public record ModelB
{
    private readonly Optional<EvaluationModelRequest> _evaluationModelRequestValue;

    private readonly Optional<string> _stringValue;

    private ModelB(Optional<EvaluationModelRequest> evaluationModelRequestValue, Optional<string> stringValue)
    {
        _evaluationModelRequestValue = evaluationModelRequestValue;
        _stringValue = stringValue;
    }

    public static ModelB EvaluationModelRequest(EvaluationModelRequest value) =>
        new(Optional<EvaluationModelRequest>.Some(value), default);

    public static ModelB String(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetEvaluationModelRequest(out EvaluationModelRequest value) =>
        _evaluationModelRequestValue.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator ModelB(EvaluationModelRequest value) => EvaluationModelRequest(value);

    public static implicit operator ModelB(string value) => String(value);
}

file sealed class ModelBConverter : JsonConverter<ModelB>
{
    public override ModelB Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<EvaluationModelRequest>(root, options, out var evaluationModelRequestValue))
        {
            return ModelB.EvaluationModelRequest(evaluationModelRequestValue);
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ModelB.String(value);
        }
        throw new JsonException($"JSON does not match EvaluationModelRequest or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ModelB value, JsonSerializerOptions options)
    {
        if (value.TryGetEvaluationModelRequest(out var evaluationModelRequestValue))
        {
            JsonSerializer.Serialize(writer, evaluationModelRequestValue, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ModelB)} contains no valid value to serialize.");
        }
    }
}
