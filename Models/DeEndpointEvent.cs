using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// One endpoint- or deployment-scoped entry in an endpoint's combined audit and lifecycle feed.
/// </summary>
public record DeEndpointEvent
{
    /// <summary>
    /// Output only. Unique event identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Output only. Event creation time.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Output only. Severity level.
    /// </summary>
    [JsonPropertyName("level")]
    public required Level1 Level { get; init; }

    /// <summary>
    /// Output only. Stable event type, such as <c>endpoint.updated</c>, <c>deployment.created</c>, <c>deployment.scaled</c>, <c>condition.set</c>, or <c>pod.log</c>.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Output only. Human-readable description of the event. Short and stable; not structured data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// Output only. Service, cluster, or controller that emitted the event.
    /// </summary>
    [JsonPropertyName("source")]
    public required string Source { get; init; }

    /// <summary>
    /// Output only. Whether this row describes the endpoint or one of its deployments.
    /// </summary>
    [JsonPropertyName("sourceKind")]
    public required SourceKind SourceKind { get; init; }

    /// <summary>
    /// Output only. The endpoint this event belongs to. Always set.
    /// </summary>
    [JsonPropertyName("endpointId")]
    public required string EndpointId { get; init; }

    /// <summary>
    /// Output only. Deployment associated with the event when <c>sourceKind</c> is <c>SOURCE_KIND_DEPLOYMENT</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deploymentId")]
    public string? DeploymentId { get; init; }

    /// <summary>
    /// Output only. ID of the event's subject, such as a rollout, shadow target, or condition type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subjectId")]
    public string? SubjectId { get; init; }

    /// <summary>
    /// Resource name at the time of the event. Populated by: deployment.created, deployment.deleted, endpoint.created, endpoint.deleted
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Field-mask paths that were modified. Populated by: deployment.updated, endpoint.updated
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paths")]
    public IReadOnlyList<string>? Paths { get; init; }

    /// <summary>
    /// Replica-count transition. Populated by: deployment.scaled
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oldReplicas")]
    public int? OldReplicas { get; init; }

    /// <summary>
    /// New replica count for a <c>deployment.scaled</c> event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("newReplicas")]
    public int? NewReplicas { get; init; }

    /// <summary>
    /// Target version. Populated by <c>target.created</c>; the target ID is carried in <c>subjectId</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>
    /// Condition status for <c>condition.set</c> and <c>cluster_condition.set</c>: <c>True</c>, <c>False</c>, or <c>Unknown</c>. The condition type is carried in <c>subjectId</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// Stable condition reason, such as <c>AllReplicasReady</c>, <c>ReplicasProgressing</c>, or <c>ApplySuccessful</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// ID of the cluster associated with a cluster-scoped event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clusterId")]
    public string? ClusterId { get; init; }

    /// <summary>
    /// Deployment subservice associated with the event, such as <c>model-deployment</c> or <c>speculator-deployment</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceType")]
    public string? ServiceType { get; init; }

    /// <summary>
    /// Opaque replica identity associated with a <c>pod.*</c> event, stable for grouping events from the same replica.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicaId")]
    public string? ReplicaId { get; init; }

    /// <summary>
    /// Stable public component label associated with a replica event, such as <c>engine</c>, <c>model-download</c>, or <c>sidecar</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; init; }

    /// <summary>
    /// Short diagnostic log excerpt captured with a pod event, for example during a crash, out-of-memory termination, or image pull failure. This field is truncated and is not a streaming log API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logExcerpt")]
    public string? LogExcerpt { get; init; }

    /// <summary>
    /// Opaque node handle for correlating replica failures on the same node. Omitted when the replica is unscheduled or the node is unknown.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nodeId")]
    public string? NodeId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
