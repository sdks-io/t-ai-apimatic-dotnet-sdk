using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Whether <c>target</c> is an absolute value, a utilization percentage, or a per-replica average.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : OpenStringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum MetricTargetTypeValue = new("METRIC_TARGET_TYPE_VALUE");

    public static readonly TypeEnum MetricTargetTypeUtilization = new("METRIC_TARGET_TYPE_UTILIZATION");

    public static readonly TypeEnum MetricTargetTypeAverageValue = new("METRIC_TARGET_TYPE_AVERAGE_VALUE");

    public TResult Match<TResult>(Func<TResult> onMetricTargetTypeValue,
        Func<TResult> onMetricTargetTypeUtilization,
        Func<TResult> onMetricTargetTypeAverageValue,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MetricTargetTypeValue => onMetricTargetTypeValue(),
            _ when this == MetricTargetTypeUtilization => onMetricTargetTypeUtilization(),
            _ when this == MetricTargetTypeAverageValue => onMetricTargetTypeAverageValue(),
            _ => otherwise(Value)
        };

    public void Match(Action onMetricTargetTypeValue,
        Action onMetricTargetTypeUtilization,
        Action onMetricTargetTypeAverageValue,
        Action<string> otherwise)
    {
        if (this == MetricTargetTypeValue) onMetricTargetTypeValue();
        else if (this == MetricTargetTypeUtilization) onMetricTargetTypeUtilization();
        else if (this == MetricTargetTypeAverageValue) onMetricTargetTypeAverageValue();
        else otherwise(Value);
    }
}
