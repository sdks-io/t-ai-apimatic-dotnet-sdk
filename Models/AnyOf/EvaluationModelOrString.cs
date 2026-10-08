using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

[JsonConverter(typeof(EvaluationModelOrStringConverter))]
public record EvaluationModelOrString
{
    private readonly Optional<string> _stringValue;

    private readonly Optional<EvaluationModelRequest> _evaluationModelRequestValue;

    private EvaluationModelOrString(Optional<string> stringValue,
        Optional<EvaluationModelRequest> evaluationModelRequestValue)
    {
        _stringValue = stringValue;
        _evaluationModelRequestValue = evaluationModelRequestValue;
    }

    public static EvaluationModelOrString String(string value) => new(Optional<string>.Some(value), default);

    public static EvaluationModelOrString EvaluationModelRequest(EvaluationModelRequest value) =>
        new(default, Optional<EvaluationModelRequest>.Some(value));

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public bool TryGetEvaluationModelRequest(out EvaluationModelRequest value) =>
        _evaluationModelRequestValue.TryGetValue(out value);

    public static implicit operator EvaluationModelOrString(string value) => String(value);

    public static implicit operator EvaluationModelOrString(EvaluationModelRequest value) =>
        EvaluationModelRequest(value);
}

file sealed class EvaluationModelOrStringConverter : JsonConverter<EvaluationModelOrString>
{
    public override EvaluationModelOrString Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return EvaluationModelOrString.String(value);
        }
        if (JsonSerializer.TryDeserialize<EvaluationModelRequest>(root, options, out var evaluationModelRequestValue))
        {
            return EvaluationModelOrString.EvaluationModelRequest(evaluationModelRequestValue);
        }
        throw new JsonException($"JSON does not match string or EvaluationModelRequest schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EvaluationModelOrString value, JsonSerializerOptions options)
    {
        if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else if (value.TryGetEvaluationModelRequest(out var evaluationModelRequestValue))
        {
            JsonSerializer.Serialize(writer, evaluationModelRequestValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EvaluationModelOrString)} contains no valid value to serialize.");
        }
    }
}
