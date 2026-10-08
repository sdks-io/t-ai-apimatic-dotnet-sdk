using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Aggregation used for the metric.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Stat>))]
public sealed record Stat : OpenStringEnum<Stat>
{
    private Stat(string value) : base(value)
    {
    }

    public static readonly Stat MetricStatTypeAvg = new("METRIC_STAT_TYPE_AVG");

    public static readonly Stat MetricStatTypePercentile = new("METRIC_STAT_TYPE_PERCENTILE");

    public TResult Match<TResult>(Func<TResult> onMetricStatTypeAvg,
        Func<TResult> onMetricStatTypePercentile,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MetricStatTypeAvg => onMetricStatTypeAvg(),
            _ when this == MetricStatTypePercentile => onMetricStatTypePercentile(),
            _ => otherwise(Value)
        };

    public void Match(Action onMetricStatTypeAvg, Action onMetricStatTypePercentile, Action<string> otherwise)
    {
        if (this == MetricStatTypeAvg) onMetricStatTypeAvg();
        else if (this == MetricStatTypePercentile) onMetricStatTypePercentile();
        else otherwise(Value);
    }
}
