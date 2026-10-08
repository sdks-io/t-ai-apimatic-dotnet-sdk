using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Required catalogue key for the metric to gate on. <c>serving_latency</c> is retired.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Name1>))]
public sealed record Name1 : OpenStringEnum<Name1>
{
    private Name1(string value) : base(value)
    {
    }

    public static readonly Name1 InflightRequests = new("inflight_requests");

    public static readonly Name1 RouterErrorRate = new("router_error_rate");

    public static readonly Name1 RouterLatency = new("router_latency");

    public TResult Match<TResult>(Func<TResult> onInflightRequests,
        Func<TResult> onRouterErrorRate,
        Func<TResult> onRouterLatency,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InflightRequests => onInflightRequests(),
            _ when this == RouterErrorRate => onRouterErrorRate(),
            _ when this == RouterLatency => onRouterLatency(),
            _ => otherwise(Value)
        };

    public void Match(Action onInflightRequests,
        Action onRouterErrorRate,
        Action onRouterLatency,
        Action<string> otherwise)
    {
        if (this == InflightRequests) onInflightRequests();
        else if (this == RouterErrorRate) onRouterErrorRate();
        else if (this == RouterLatency) onRouterLatency();
        else otherwise(Value);
    }
}
