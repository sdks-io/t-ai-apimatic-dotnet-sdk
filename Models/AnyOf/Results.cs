using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Results of the evaluation (when completed)
/// </summary>
[JsonConverter(typeof(ResultsConverter))]
public record Results
{
    private readonly Optional<EvaluationClassifyResults> _evaluationClassifyResultsValue;

    private readonly Optional<EvaluationScoreResults> _evaluationScoreResultsValue;

    private readonly Optional<EvaluationCompareResults> _evaluationCompareResultsValue;

    private readonly Optional<BatchErrorResponse> _batchErrorResponseValue;

    private Results(Optional<EvaluationClassifyResults> evaluationClassifyResultsValue,
        Optional<EvaluationScoreResults> evaluationScoreResultsValue,
        Optional<EvaluationCompareResults> evaluationCompareResultsValue,
        Optional<BatchErrorResponse> batchErrorResponseValue)
    {
        _evaluationClassifyResultsValue = evaluationClassifyResultsValue;
        _evaluationScoreResultsValue = evaluationScoreResultsValue;
        _evaluationCompareResultsValue = evaluationCompareResultsValue;
        _batchErrorResponseValue = batchErrorResponseValue;
    }

    public static Results EvaluationClassifyResults(EvaluationClassifyResults value) =>
        new(Optional<EvaluationClassifyResults>.Some(value), default, default, default);

    public static Results EvaluationScoreResults(EvaluationScoreResults value) =>
        new(default, Optional<EvaluationScoreResults>.Some(value), default, default);

    public static Results EvaluationCompareResults(EvaluationCompareResults value) =>
        new(default, default, Optional<EvaluationCompareResults>.Some(value), default);

    public static Results BatchErrorResponse(BatchErrorResponse value) =>
        new(default, default, default, Optional<BatchErrorResponse>.Some(value));

    public bool TryGetEvaluationClassifyResults(out EvaluationClassifyResults value) =>
        _evaluationClassifyResultsValue.TryGetValue(out value);

    public bool TryGetEvaluationScoreResults(out EvaluationScoreResults value) =>
        _evaluationScoreResultsValue.TryGetValue(out value);

    public bool TryGetEvaluationCompareResults(out EvaluationCompareResults value) =>
        _evaluationCompareResultsValue.TryGetValue(out value);

    public bool TryGetBatchErrorResponse(out BatchErrorResponse value) =>
        _batchErrorResponseValue.TryGetValue(out value);

    public static implicit operator Results(EvaluationClassifyResults value) => EvaluationClassifyResults(value);

    public static implicit operator Results(EvaluationScoreResults value) => EvaluationScoreResults(value);

    public static implicit operator Results(EvaluationCompareResults value) => EvaluationCompareResults(value);

    public static implicit operator Results(BatchErrorResponse value) => BatchErrorResponse(value);
}

file sealed class ResultsConverter : JsonConverter<Results>
{
    public override Results Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<EvaluationClassifyResults>(
            root,
            options,
            out var evaluationClassifyResultsValue))
        {
            return Results.EvaluationClassifyResults(evaluationClassifyResultsValue);
        }
        if (JsonSerializer.TryDeserialize<EvaluationScoreResults>(root, options, out var evaluationScoreResultsValue))
        {
            return Results.EvaluationScoreResults(evaluationScoreResultsValue);
        }
        if (JsonSerializer.TryDeserialize<EvaluationCompareResults>(
            root,
            options,
            out var evaluationCompareResultsValue))
        {
            return Results.EvaluationCompareResults(evaluationCompareResultsValue);
        }
        if (JsonSerializer.TryDeserialize<BatchErrorResponse>(root, options, out var batchErrorResponseValue))
        {
            return Results.BatchErrorResponse(batchErrorResponseValue);
        }
        throw new JsonException(
            $"JSON does not match EvaluationClassifyResults or EvaluationScoreResults or EvaluationCompareResults or BatchErrorResponse schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Results value, JsonSerializerOptions options)
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
        else if (value.TryGetBatchErrorResponse(out var batchErrorResponseValue))
        {
            JsonSerializer.Serialize(writer, batchErrorResponseValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Results)} contains no valid value to serialize.");
        }
    }
}
