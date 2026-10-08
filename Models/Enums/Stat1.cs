using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Aggregation used for the metric. Optional for router_error_rate and inflight_requests; omitted values default to METRIC_STAT_TYPE_AVG. Required for router_latency, where AVG or PERCENTILE may be used.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Stat1>))]
public sealed record Stat1 : OpenStringEnum<Stat1>
{
    private Stat1(string value) : base(value)
    {
    }

    public static readonly Stat1 MetricStatTypeAvg = new("METRIC_STAT_TYPE_AVG");

    public static readonly Stat1 MetricStatTypePercentile = new("METRIC_STAT_TYPE_PERCENTILE");

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
