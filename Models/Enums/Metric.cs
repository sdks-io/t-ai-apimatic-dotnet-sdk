using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Metric must be HTTPTotalRequests or HTTPAvgRequestDuration
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Metric>))]
public sealed record Metric : OpenStringEnum<Metric>
{
    private Metric(string value) : base(value)
    {
    }

    public static readonly Metric HttpTotalRequests = new("HTTPTotalRequests");

    public static readonly Metric HttpAvgRequestDuration = new("HTTPAvgRequestDuration");

    public TResult Match<TResult>(Func<TResult> onHttpTotalRequests,
        Func<TResult> onHttpAvgRequestDuration,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == HttpTotalRequests => onHttpTotalRequests(),
            _ when this == HttpAvgRequestDuration => onHttpAvgRequestDuration(),
            _ => otherwise(Value)
        };

    public void Match(Action onHttpTotalRequests, Action onHttpAvgRequestDuration, Action<string> otherwise)
    {
        if (this == HttpTotalRequests) onHttpTotalRequests();
        else if (this == HttpAvgRequestDuration) onHttpAvgRequestDuration();
        else otherwise(Value);
    }
}
