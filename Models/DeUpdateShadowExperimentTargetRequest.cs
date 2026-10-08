using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Mutable name, deployment, and description for a shadow experiment target.
/// </summary>
public record DeUpdateShadowExperimentTargetRequest
{
    /// <summary>
    /// Updated human-readable target name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Replacement deployment under the parent endpoint. It must not be a live traffic-split member or the source or target of an active rollout; traffic-split weight 0 warm-up targets are allowed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetDeploymentId")]
    public string? TargetDeploymentId { get; init; }

    /// <summary>
    /// Updated free-form target description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Opaque version tag from a prior read for optimistic concurrency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("etag")]
    public string? Etag { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
