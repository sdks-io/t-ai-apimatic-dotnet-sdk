using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ReplicaEvent
{
    /// <summary>
    /// Image is the container image used for this replica
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image")]
    public string? Image { get; init; }

    /// <summary>
    /// ReplicaReadySince is the timestamp when the replica became ready to serve traffic
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replica_ready_since")]
    public string? ReplicaReadySince { get; init; }

    /// <summary>
    /// ReplicaStatus is the current status of the replica (e.g., "Running", "Waiting", "Terminated")
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replica_status")]
    public string? ReplicaStatus { get; init; }

    /// <summary>
    /// ReplicaStatusMessage provides a human-readable message explaining the replica's status
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replica_status_message")]
    public string? ReplicaStatusMessage { get; init; }

    /// <summary>
    /// ReplicaStatusReason provides a brief machine-readable reason for the replica's status
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replica_status_reason")]
    public string? ReplicaStatusReason { get; init; }

    /// <summary>
    /// RevisionID is the deployment revision ID associated with this replica
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("revision_id")]
    public string? RevisionId { get; init; }

    /// <summary>
    /// VolumePreloadCompletedAt is the timestamp when the volume preload completed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volume_preload_completed_at")]
    public string? VolumePreloadCompletedAt { get; init; }

    /// <summary>
    /// VolumePreloadStartedAt is the timestamp when the volume preload started
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volume_preload_started_at")]
    public string? VolumePreloadStartedAt { get; init; }

    /// <summary>
    /// VolumePreloadStatus is the status of the volume preload (e.g., "InProgress", "Completed", "Failed")
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volume_preload_status")]
    public string? VolumePreloadStatus { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
