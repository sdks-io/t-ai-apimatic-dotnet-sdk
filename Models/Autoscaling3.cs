using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// New autoscaling configuration for the endpoint
/// </summary>
public record Autoscaling3
{
    /// <summary>
    /// The minimum number of replicas to maintain, even when there is no load
    /// </summary>
    [JsonPropertyName("min_replicas")]
    public required int MinReplicas { get; init; }

    /// <summary>
    /// The maximum number of replicas to scale up to under load
    /// </summary>
    [JsonPropertyName("max_replicas")]
    public required int MaxReplicas { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
