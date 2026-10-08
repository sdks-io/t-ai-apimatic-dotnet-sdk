using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Autoscaling config for QueueBacklogPerWorker metric
/// </summary>
public record QueueAutoscalingConfig
{
    /// <summary>
    /// Metric must be QueueBacklogPerWorker
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metric")]
    public Metric1? Metric { get; init; }

    /// <summary>
    /// Model overrides the model name for queue status lookup. Defaults to the deployment app name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model")]
    public string? Model { get; init; }

    /// <summary>
    /// Target is the threshold value. Default: 1.01
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target")]
    public double? Target { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
