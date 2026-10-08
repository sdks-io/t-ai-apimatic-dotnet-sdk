using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Threshold comparison operator.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Operator>))]
public sealed record Operator : OpenStringEnum<Operator>
{
    private Operator(string value) : base(value)
    {
    }

    public static readonly Operator ThresholdOperatorGt = new("THRESHOLD_OPERATOR_GT");

    public static readonly Operator ThresholdOperatorGte = new("THRESHOLD_OPERATOR_GTE");

    public static readonly Operator ThresholdOperatorLt = new("THRESHOLD_OPERATOR_LT");

    public static readonly Operator ThresholdOperatorLte = new("THRESHOLD_OPERATOR_LTE");

    public TResult Match<TResult>(Func<TResult> onThresholdOperatorGt,
        Func<TResult> onThresholdOperatorGte,
        Func<TResult> onThresholdOperatorLt,
        Func<TResult> onThresholdOperatorLte,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ThresholdOperatorGt => onThresholdOperatorGt(),
            _ when this == ThresholdOperatorGte => onThresholdOperatorGte(),
            _ when this == ThresholdOperatorLt => onThresholdOperatorLt(),
            _ when this == ThresholdOperatorLte => onThresholdOperatorLte(),
            _ => otherwise(Value)
        };

    public void Match(Action onThresholdOperatorGt,
        Action onThresholdOperatorGte,
        Action onThresholdOperatorLt,
        Action onThresholdOperatorLte,
        Action<string> otherwise)
    {
        if (this == ThresholdOperatorGt) onThresholdOperatorGt();
        else if (this == ThresholdOperatorGte) onThresholdOperatorGte();
        else if (this == ThresholdOperatorLt) onThresholdOperatorLt();
        else if (this == ThresholdOperatorLte) onThresholdOperatorLte();
        else otherwise(Value);
    }
}
