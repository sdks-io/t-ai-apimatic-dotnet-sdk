using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Enum;

namespace TogetherApIs.Models.Enums;

/// <summary>
/// Autoscaling metric name from the server allowlist.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Name>))]
public sealed record Name : OpenStringEnum<Name>
{
    private Name(string value) : base(value)
    {
    }

    public static readonly Name ActiveSessions = new("active_sessions");

    public static readonly Name CacheHitRate = new("cache_hit_rate");

    public static readonly Name DecodingSpeed = new("decoding_speed");

    public static readonly Name E2ELatency = new("e2e_latency");

    public static readonly Name GpuUtilization = new("gpu_utilization");

    public static readonly Name InflightRequests = new("inflight_requests");

    public static readonly Name ThroughputPerReplica = new("throughput_per_replica");

    public static readonly Name TokenUtilization = new("token_utilization");

    public static readonly Name Ttft = new("ttft");

    public TResult Match<TResult>(Func<TResult> onActiveSessions,
        Func<TResult> onCacheHitRate,
        Func<TResult> onDecodingSpeed,
        Func<TResult> onE2ELatency,
        Func<TResult> onGpuUtilization,
        Func<TResult> onInflightRequests,
        Func<TResult> onThroughputPerReplica,
        Func<TResult> onTokenUtilization,
        Func<TResult> onTtft,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ActiveSessions => onActiveSessions(),
            _ when this == CacheHitRate => onCacheHitRate(),
            _ when this == DecodingSpeed => onDecodingSpeed(),
            _ when this == E2ELatency => onE2ELatency(),
            _ when this == GpuUtilization => onGpuUtilization(),
            _ when this == InflightRequests => onInflightRequests(),
            _ when this == ThroughputPerReplica => onThroughputPerReplica(),
            _ when this == TokenUtilization => onTokenUtilization(),
            _ when this == Ttft => onTtft(),
            _ => otherwise(Value)
        };

    public void Match(Action onActiveSessions,
        Action onCacheHitRate,
        Action onDecodingSpeed,
        Action onE2ELatency,
        Action onGpuUtilization,
        Action onInflightRequests,
        Action onThroughputPerReplica,
        Action onTokenUtilization,
        Action onTtft,
        Action<string> otherwise)
    {
        if (this == ActiveSessions) onActiveSessions();
        else if (this == CacheHitRate) onCacheHitRate();
        else if (this == DecodingSpeed) onDecodingSpeed();
        else if (this == E2ELatency) onE2ELatency();
        else if (this == GpuUtilization) onGpuUtilization();
        else if (this == InflightRequests) onInflightRequests();
        else if (this == ThroughputPerReplica) onThroughputPerReplica();
        else if (this == TokenUtilization) onTokenUtilization();
        else if (this == Ttft) onTtft();
        else otherwise(Value);
    }
}
