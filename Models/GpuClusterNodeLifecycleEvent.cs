using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Node lifecycle event included in a GPU cluster timeline.
/// </summary>
public record GpuClusterNodeLifecycleEvent
{
    /// <summary>
    /// Tenant node name this lifecycle event applies to.
    /// </summary>
    [JsonPropertyName("node_id")]
    public required string NodeId { get; init; }

    /// <summary>
    /// Lifecycle event reason, for example TogetherScaledUp, TogetherScaledDown, or TogetherPreempted.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    /// <summary>
    /// Human-readable lifecycle event message.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }

    /// <summary>
    /// Event timestamp.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
