using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Extensions;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models.AnyOf;

/// <summary>
/// Type-specific parameters for the evaluation
/// </summary>
[JsonConverter(typeof(ParametersConverter))]
public record Parameters
{
    private readonly Optional<EvaluationClassifyParameters> _evaluationClassifyParametersValue;

    private readonly Optional<EvaluationScoreParameters> _evaluationScoreParametersValue;

    private readonly Optional<EvaluationCompareParameters> _evaluationCompareParametersValue;

    private Parameters(Optional<EvaluationClassifyParameters> evaluationClassifyParametersValue,
        Optional<EvaluationScoreParameters> evaluationScoreParametersValue,
        Optional<EvaluationCompareParameters> evaluationCompareParametersValue)
    {
        _evaluationClassifyParametersValue = evaluationClassifyParametersValue;
        _evaluationScoreParametersValue = evaluationScoreParametersValue;
        _evaluationCompareParametersValue = evaluationCompareParametersValue;
    }

    public static Parameters EvaluationClassifyParameters(EvaluationClassifyParameters value) =>
        new(Optional<EvaluationClassifyParameters>.Some(value), default, default);

    public static Parameters EvaluationScoreParameters(EvaluationScoreParameters value) =>
        new(default, Optional<EvaluationScoreParameters>.Some(value), default);

    public static Parameters EvaluationCompareParameters(EvaluationCompareParameters value) =>
        new(default, default, Optional<EvaluationCompareParameters>.Some(value));

    public bool TryGetEvaluationClassifyParameters(out EvaluationClassifyParameters value) =>
        _evaluationClassifyParametersValue.TryGetValue(out value);

    public bool TryGetEvaluationScoreParameters(out EvaluationScoreParameters value) =>
        _evaluationScoreParametersValue.TryGetValue(out value);

    public bool TryGetEvaluationCompareParameters(out EvaluationCompareParameters value) =>
        _evaluationCompareParametersValue.TryGetValue(out value);

    public static implicit operator Parameters(EvaluationClassifyParameters value) =>
        EvaluationClassifyParameters(value);

    public static implicit operator Parameters(EvaluationScoreParameters value) => EvaluationScoreParameters(value);

    public static implicit operator Parameters(EvaluationCompareParameters value) => EvaluationCompareParameters(value);
}

file sealed class ParametersConverter : JsonConverter<Parameters>
{
    public override Parameters Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<EvaluationClassifyParameters>(
            root,
            options,
            out var evaluationClassifyParametersValue))
        {
            return Parameters.EvaluationClassifyParameters(evaluationClassifyParametersValue);
        }
        if (JsonSerializer.TryDeserialize<EvaluationScoreParameters>(
            root,
            options,
            out var evaluationScoreParametersValue))
        {
            return Parameters.EvaluationScoreParameters(evaluationScoreParametersValue);
        }
        if (JsonSerializer.TryDeserialize<EvaluationCompareParameters>(
            root,
            options,
            out var evaluationCompareParametersValue))
        {
            return Parameters.EvaluationCompareParameters(evaluationCompareParametersValue);
        }
        throw new JsonException(
            $"JSON does not match EvaluationClassifyParameters or EvaluationScoreParameters or EvaluationCompareParameters schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Parameters value, JsonSerializerOptions options)
    {
        if (value.TryGetEvaluationClassifyParameters(out var evaluationClassifyParametersValue))
        {
            JsonSerializer.Serialize(writer, evaluationClassifyParametersValue, options);
        }
        else if (value.TryGetEvaluationScoreParameters(out var evaluationScoreParametersValue))
        {
            JsonSerializer.Serialize(writer, evaluationScoreParametersValue, options);
        }
        else if (value.TryGetEvaluationCompareParameters(out var evaluationCompareParametersValue))
        {
            JsonSerializer.Serialize(writer, evaluationCompareParametersValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Parameters)} contains no valid value to serialize.");
        }
    }
}
