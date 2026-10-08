using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// The results of the evaluation job
/// </summary>
[JsonConverter(typeof(Results1Converter))]
public record Results1
{
    private readonly Optional<EvaluationClassifyResults> _evaluationClassifyResultsValue;

    private readonly Optional<EvaluationScoreResults> _evaluationScoreResultsValue;

    private readonly Optional<EvaluationCompareResults> _evaluationCompareResultsValue;

    private Results1(Optional<EvaluationClassifyResults> evaluationClassifyResultsValue,
        Optional<EvaluationScoreResults> evaluationScoreResultsValue,
        Optional<EvaluationCompareResults> evaluationCompareResultsValue)
    {
        _evaluationClassifyResultsValue = evaluationClassifyResultsValue;
        _evaluationScoreResultsValue = evaluationScoreResultsValue;
        _evaluationCompareResultsValue = evaluationCompareResultsValue;
    }

    public static Results1 EvaluationClassifyResults(EvaluationClassifyResults value) =>
        new(Optional<EvaluationClassifyResults>.Some(value), default, default);

    public static Results1 EvaluationScoreResults(EvaluationScoreResults value) =>
        new(default, Optional<EvaluationScoreResults>.Some(value), default);

    public static Results1 EvaluationCompareResults(EvaluationCompareResults value) =>
        new(default, default, Optional<EvaluationCompareResults>.Some(value));

    public bool TryGetEvaluationClassifyResults(out EvaluationClassifyResults value) =>
        _evaluationClassifyResultsValue.TryGetValue(out value);

    public bool TryGetEvaluationScoreResults(out EvaluationScoreResults value) =>
        _evaluationScoreResultsValue.TryGetValue(out value);

    public bool TryGetEvaluationCompareResults(out EvaluationCompareResults value) =>
        _evaluationCompareResultsValue.TryGetValue(out value);

    public static implicit operator Results1(EvaluationClassifyResults value) => EvaluationClassifyResults(value);

    public static implicit operator Results1(EvaluationScoreResults value) => EvaluationScoreResults(value);

    public static implicit operator Results1(EvaluationCompareResults value) => EvaluationCompareResults(value);
}

file sealed class Results1Converter : JsonConverter<Results1>
{
    public override Results1 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<EvaluationClassifyResults>(
            root,
            options,
            out var evaluationClassifyResultsValue))
        {
            return Results1.EvaluationClassifyResults(evaluationClassifyResultsValue);
        }
        if (JsonSerializer.TryDeserialize<EvaluationScoreResults>(root, options, out var evaluationScoreResultsValue))
        {
            return Results1.EvaluationScoreResults(evaluationScoreResultsValue);
        }
        if (JsonSerializer.TryDeserialize<EvaluationCompareResults>(
            root,
            options,
            out var evaluationCompareResultsValue))
        {
            return Results1.EvaluationCompareResults(evaluationCompareResultsValue);
        }
        throw new JsonException(
            $"JSON does not match EvaluationClassifyResults or EvaluationScoreResults or EvaluationCompareResults schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Results1 value, JsonSerializerOptions options)
    {
        if (value.TryGetEvaluationClassifyResults(out var evaluationClassifyResultsValue))
        {
            JsonSerializer.Serialize(writer, evaluationClassifyResultsValue, options);
        }
        else if (value.TryGetEvaluationScoreResults(out var evaluationScoreResultsValue))
        {
            JsonSerializer.Serialize(writer, evaluationScoreResultsValue, options);
        }
        else if (value.TryGetEvaluationCompareResults(out var evaluationCompareResultsValue))
        {
            JsonSerializer.Serialize(writer, evaluationCompareResultsValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Results1)} contains no valid value to serialize.");
        }
    }
}
