using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// Configuration for creating a deployment that binds a model and immutable config to an endpoint.
/// </summary>
public record DeCreateDeploymentRequest
{
    /// <summary>
    /// Name for the deployment within its endpoint. Returned as a fully-qualified endpoint string.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Deprecated. Use <c>model</c>. Model identifier to serve, accepted when <c>model</c> is unset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modelId")]
    public string? ModelId { get; init; }

    /// <summary>
    /// Deprecated. Use <c>model</c> with a /revisions/{revisionId} segment. If omitted, the latest revision is resolved at creation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modelRevisionId")]
    public string? ModelRevisionId { get; init; }

    /// <summary>
    /// Deprecated. Use <c>config</c>. Config revision identifier to deploy, accepted when <c>config</c> is unset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("configId")]
    public string? ConfigId { get; init; }

    /// <summary>
    /// Model resource name in the form <c>projects/{projectId}/models/{modelId}[/revisions/{revisionId}]</c>. Omit the revision segment to pin the latest revision at creation time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model")]
    public string? Model { get; init; }

    /// <summary>
    /// Autoscaling configuration for the deployment.
    /// </summary>
    [JsonPropertyName("autoscaling")]
    public required DeAutoscaling Autoscaling { get; init; }

    /// <summary>
    /// Immutable config revision in the form <c>projects/{projectId}/configs/{configRevisionId}</c>. The config must be compatible with the model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("config")]
    public string? Config { get; init; }

    /// <summary>
    /// Inactive timeout in minutes. Use 0 or omit to disable automatic stopping; otherwise accepted values are 30 through 1440.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inactiveTimeout")]
    public int? InactiveTimeout { get; init; }

    /// <summary>
    /// Maximum number of inference requests that may be in flight to a single replica. If omitted, the platform uses one less than the config's per-replica concurrency limit to reserve a health-check slot. Values above that maximum are reduced on create; 0 means unlimited when the config limit is 1 or less.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxConcurrentRequestsPerReplica")]
    public string? MaxConcurrentRequestsPerReplica { get; init; }

    /// <summary>
    /// Placement policy to use when scheduling the deployment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("placement")]
    public DePlacement2? Placement { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
