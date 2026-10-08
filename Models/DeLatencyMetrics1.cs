using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Time-to-first-token, end-to-end, and inter-token latency percentiles.
/// </summary>
public record DeLatencyMetrics1
{
    /// <summary>
    /// 50th-percentile time to first token, in milliseconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ttftP50Ms")]
    public double? TtftP50Ms { get; init; }

    /// <summary>
    /// 90th-percentile time to first token, in milliseconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ttftP90Ms")]
    public double? TtftP90Ms { get; init; }

    /// <summary>
    /// 99th-percentile time to first token, in milliseconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ttftP99Ms")]
    public double? TtftP99Ms { get; init; }

    /// <summary>
    /// 50th-percentile end-to-end request latency, in milliseconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latencyP50Ms")]
    public double? LatencyP50Ms { get; init; }

    /// <summary>
    /// 90th-percentile end-to-end request latency, in milliseconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latencyP90Ms")]
    public double? LatencyP90Ms { get; init; }

    /// <summary>
    /// 99th-percentile end-to-end request latency, in milliseconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latencyP99Ms")]
    public double? LatencyP99Ms { get; init; }

    /// <summary>
    /// 50th-percentile inter-token latency, in milliseconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("itlP50Ms")]
    public double? ItlP50Ms { get; init; }

    /// <summary>
    /// 90th-percentile inter-token latency, in milliseconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("itlP90Ms")]
    public double? ItlP90Ms { get; init; }

    /// <summary>
    /// 99th-percentile inter-token latency, in milliseconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("itlP99Ms")]
    public double? ItlP99Ms { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
