using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Autoscaling config for HTTPTotalRequests and HTTPAvgRequestDuration metrics
/// </summary>
public record HttpAutoscalingConfig
{
    /// <summary>
    /// Metric must be HTTPTotalRequests or HTTPAvgRequestDuration
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metric")]
    public Metric? Metric { get; init; }

    /// <summary>
    /// Target is the threshold value. Default: 100 for HTTPTotalRequests, 500 (ms) for HTTPAvgRequestDuration
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target")]
    public double? Target { get; init; }

    /// <summary>
    /// TimeIntervalMinutes is the rate window in minutes. Default: 10
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time_interval_minutes")]
    public int? TimeIntervalMinutes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
