using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Metric and target used by the autoscaler to recommend a replica count.
/// </summary>
public record DeScalingMetric
{
    /// <summary>
    /// Autoscaling metric name from the server allowlist.
    /// </summary>
    [JsonPropertyName("name")]
    public required Name Name { get; init; }

    /// <summary>
    /// Whether <c>target</c> is an absolute value, a utilization percentage, or a per-replica average.
    /// </summary>
    [JsonPropertyName("type")]
    public required TypeEnum Type { get; init; }

    /// <summary>
    /// Target interpreted according to <c>type</c>. Utilization uses a percentage from 0 to 100, value uses an absolute measurement, and average value uses a per-replica measurement.
    /// </summary>
    [JsonPropertyName("target")]
    public required double Target { get; init; }

    /// <summary>
    /// Percentile to evaluate for latency-based metrics: <c>p50</c>, <c>p90</c>, <c>p95</c>, or <c>p99</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentile")]
    public string? Percentile { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
