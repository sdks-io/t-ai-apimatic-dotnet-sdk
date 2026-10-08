using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Rule decision recorded by the metric gate. Absent when no decision was recorded.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Verdict>))]
public sealed record Verdict : OpenStringEnum<Verdict>
{
    private Verdict(string value) : base(value)
    {
    }

    public static readonly Verdict MetricVerdictPass = new("METRIC_VERDICT_PASS");

    public static readonly Verdict MetricVerdictBreached = new("METRIC_VERDICT_BREACHED");

    public static readonly Verdict MetricVerdictUnavailable = new("METRIC_VERDICT_UNAVAILABLE");

    public TResult Match<TResult>(Func<TResult> onMetricVerdictPass,
        Func<TResult> onMetricVerdictBreached,
        Func<TResult> onMetricVerdictUnavailable,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MetricVerdictPass => onMetricVerdictPass(),
            _ when this == MetricVerdictBreached => onMetricVerdictBreached(),
            _ when this == MetricVerdictUnavailable => onMetricVerdictUnavailable(),
            _ => otherwise(Value)
        };

    public void Match(Action onMetricVerdictPass,
        Action onMetricVerdictBreached,
        Action onMetricVerdictUnavailable,
        Action<string> otherwise)
    {
        if (this == MetricVerdictPass) onMetricVerdictPass();
        else if (this == MetricVerdictBreached) onMetricVerdictBreached();
        else if (this == MetricVerdictUnavailable) onMetricVerdictUnavailable();
        else otherwise(Value);
    }
}
