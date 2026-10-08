using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Current status of a deployment, derived at read time from internal state.
/// </summary>
public record DeDeploymentStatus
{
    /// <summary>
    /// High-level lifecycle state.
    /// </summary>
    [JsonPropertyName("state")]
    public required State1 State { get; init; }

    /// <summary>
    /// Total replicas actively serving traffic across all clusters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("readyReplicas")]
    public int? ReadyReplicas { get; init; }

    /// <summary>
    /// Human-readable explanation of the current state.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }

    /// <summary>
    /// Replicas the scheduler has placed on clusters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduledReplicas")]
    public int? ScheduledReplicas { get; init; }

    /// <summary>
    /// Status totals broken down by dimension. Omitted when the breakdown cannot be determined.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public DeStatusDetails? Details { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
