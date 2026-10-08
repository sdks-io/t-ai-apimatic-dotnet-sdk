using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Evaluation form used by the metric rule.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Check>))]
public sealed record Check : OpenStringEnum<Check>
{
    private Check(string value) : base(value)
    {
    }

    public static readonly Check MetricCheckTypeThreshold = new("METRIC_CHECK_TYPE_THRESHOLD");

    public static readonly Check MetricCheckTypeRegression = new("METRIC_CHECK_TYPE_REGRESSION");

    public TResult Match<TResult>(Func<TResult> onMetricCheckTypeThreshold,
        Func<TResult> onMetricCheckTypeRegression,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MetricCheckTypeThreshold => onMetricCheckTypeThreshold(),
            _ when this == MetricCheckTypeRegression => onMetricCheckTypeRegression(),
            _ => otherwise(Value)
        };

    public void Match(Action onMetricCheckTypeThreshold, Action onMetricCheckTypeRegression, Action<string> otherwise)
    {
        if (this == MetricCheckTypeThreshold) onMetricCheckTypeThreshold();
        else if (this == MetricCheckTypeRegression) onMetricCheckTypeRegression();
        else otherwise(Value);
    }
}
