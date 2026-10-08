using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Serving workload that binds a model and immutable config to an endpoint and manages its replicas.
/// </summary>
public record DeDeployment
{
    /// <summary>
    /// Unique deployment identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// ID of the project that owns the deployment.
    /// </summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    /// <summary>
    /// ID of the endpoint that contains the deployment.
    /// </summary>
    [JsonPropertyName("endpointId")]
    public required string EndpointId { get; init; }

    /// <summary>
    /// Project- and endpoint-qualified deployment name in the form <c>&lt;project_slug&gt;/&lt;endpoint_name&gt;/&lt;deployment_name&gt;</c>. Pass it as <c>model</c> in an inference request to target this deployment directly instead of using the endpoint's traffic split.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Timestamp when the deployment was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Timestamp when the deployment was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// Deprecated. Use <c>model</c>. Model identifier being served, populated during migration.
    /// </summary>
    [JsonPropertyName("modelId")]
    public required string ModelId { get; init; }

    /// <summary>
    /// Deprecated. Use <c>model</c> with a /revisions/{revisionId} segment. Pin to a specific model revision.
    /// </summary>
    [JsonPropertyName("modelRevisionId")]
    public required string ModelRevisionId { get; init; }

    /// <summary>
    /// Pinned model resource in the form <c>projects/{projectId}/models/{modelId}/revisions/{revisionId}</c>.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Replica bounds, timing windows, and metrics that control horizontal scaling.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public required DeAutoscalingResponse Autoscaling { get; init; }

    /// <summary>
    /// Deprecated. Use <c>config</c>. Config revision identifier, populated during migration.
    /// </summary>
    [JsonPropertyName("configId")]
    public required string ConfigId { get; init; }

    /// <summary>
    /// Immutable config revision in the form <c>projects/{projectId}/configs/{configRevisionId}</c>.
    /// </summary>
    [JsonPropertyName("config")]
    public required string Config { get; init; }

    /// <summary>
    /// Deprecated. Use <c>speculator</c>. Speculative decoding model identifier derived from the deployment config.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("speculatorId")]
    public string? SpeculatorId { get; init; }

    /// <summary>
    /// Deprecated. Use <c>speculator</c>. ID of the speculative decoding draft-model revision pinned at creation time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("speculatorRevisionId")]
    public string? SpeculatorRevisionId { get; init; }

    /// <summary>
    /// Pinned draft-model resource used for speculative decoding, in the same form as <c>model</c>. Omitted when speculative decoding is disabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("speculator")]
    public string? Speculator { get; init; }

    /// <summary>
    /// Estimated fraction in [0, 1] of endpoint traffic that reaches this deployment under the current routing configuration. Absent or unrouted deployments are 0.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("estimatedEffectiveTrafficShare")]
    public double? EstimatedEffectiveTrafficShare { get; init; }

    /// <summary>
    /// Maximum number of inference requests that may be in flight to a single replica. If omitted, the platform uses one less than the config's per-replica concurrency limit to reserve a health-check slot. Values above that maximum are reduced on create and update; 0 means unlimited when the config limit is 1 or less. Changes take effect without restarting replicas.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxConcurrentRequestsPerReplica")]
    public string? MaxConcurrentRequestsPerReplica { get; init; }

    /// <summary>
    /// Minutes without an inference request before the deployment stops automatically. Omitted or 0 means automatic stopping is disabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactiveTimeout")]
    public int? InactiveTimeout { get; init; }

    /// <summary>
    /// Opaque version tag for optimistic concurrency control. Supply on update/delete to ensure consistent read-modify-write. If not set, the write overwrites based on current state.
    /// </summary>
    [JsonPropertyName("etag")]
    public required string Etag { get; init; }

    /// <summary>
    /// Hardware selected by the deployment config, including GPU type and count.
    /// </summary>
    [JsonPropertyName("hardware")]
    public required string Hardware { get; init; }

    /// <summary>
    /// Whether the deployment serves client-visible responses or only mirrored shadow traffic.
    /// </summary>
    [JsonPropertyName("trafficMode")]
    public required TrafficMode TrafficMode { get; init; }

    /// <summary>
    /// Serving engine and feature support derived from the immutable config.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("runtimeInfo")]
    public DeRuntimeInfo? RuntimeInfo { get; init; }

    /// <summary>
    /// Number of replicas the autoscaler currently wants across all regions. Not settable on
    /// any request; steer it through <c>autoscaling.minReplicas</c> and <c>autoscaling.maxReplicas</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("desiredReplicas")]
    public int? DesiredReplicas { get; init; }

    /// <summary>
    /// Current lifecycle state and observed replica counts.
    /// </summary>
    [JsonPropertyName("status")]
    public required DeDeploymentStatus Status { get; init; }

    /// <summary>
    /// Region constraints used to schedule the deployment's replicas.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("placement")]
    public DePlacement2? Placement { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
