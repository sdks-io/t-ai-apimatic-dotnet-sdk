using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Autoscaling config for CustomMetric metric
/// </summary>
public record CustomMetricAutoscalingConfig
{
    /// <summary>
    /// CustomMetricName is the Prometheus metric name. Must match [a-zA-Z_:][a-zA-Z0-9_:]*
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_metric_name")]
    public string? CustomMetricName { get; init; }

    /// <summary>
    /// Metric must be CustomMetric
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metric")]
    public Metric2? Metric { get; init; }

    /// <summary>
    /// Target is the threshold value. Default: 500
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target")]
    public double? Target { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
