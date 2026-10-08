using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Compact deployment status embedded in an endpoint response.
/// </summary>
public record DeDeploymentSummary
{
    /// <summary>
    /// Deployment identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Deprecated. Use <c>model</c>. Model identifier being served.
    /// </summary>
    [JsonPropertyName("modelId")]
    public required string ModelId { get; init; }

    /// <summary>
    /// Hardware configuration selected by the deployment's config, such as its GPU type and count.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hardware")]
    public string? Hardware { get; init; }

    /// <summary>
    /// Whether the deployment serves client-visible responses or only mirrored shadow traffic.
    /// </summary>
    [JsonPropertyName("trafficMode")]
    public required TrafficMode TrafficMode { get; init; }

    /// <summary>
    /// Current state of the deployment.
    /// </summary>
    [JsonPropertyName("state")]
    public required State State { get; init; }

    /// <summary>
    /// Inference-addressable name in the fully-qualified form
    /// "&lt;project_slug&gt;/&lt;endpoint_name&gt;/&lt;deployment_name&gt;". Pass it as the
    /// "model" field when calling the inference API to pin to this deployment.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Timestamp when the deployment was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Autoscaling configuration for the deployment.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public required DeAutoscalingResponse Autoscaling { get; init; }

    /// <summary>
    /// Number of replicas the autoscaler currently wants across all regions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("desiredReplicas")]
    public int? DesiredReplicas { get; init; }

    /// <summary>
    /// Number of replicas currently ready to serve requests across all regions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("readyReplicas")]
    public int? ReadyReplicas { get; init; }

    /// <summary>
    /// Resource name of the served model in the form
    /// <c>projects/{projectId}/models/{modelId}/revisions/{revisionId}</c>.
    /// For public models, the model's owning project may differ from the deployment's project.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Estimated fraction from 0 to 1 of endpoint traffic currently routed to this deployment.
    /// </summary>
    [JsonPropertyName("estimatedEffectiveTrafficShare")]
    public required double EstimatedEffectiveTrafficShare { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
