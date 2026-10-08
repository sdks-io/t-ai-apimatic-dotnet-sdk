using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Realized scheduled and ready replica counts for one deployment region.
/// </summary>
public record DeRegionStatus
{
    /// <summary>
    /// Region name using the same vocabulary accepted by inline placement regions.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; init; }

    /// <summary>
    /// Replicas the scheduler has placed in this region.
    /// </summary>
    [JsonPropertyName("scheduledReplicas")]
    public required int ScheduledReplicas { get; init; }

    /// <summary>
    /// Replicas serving traffic in this region.
    /// </summary>
    [JsonPropertyName("readyReplicas")]
    public required int ReadyReplicas { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
