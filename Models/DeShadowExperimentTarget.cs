using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Deployment that receives mirrored traffic for a shadow experiment.
/// </summary>
public record DeShadowExperimentTarget
{
    /// <summary>
    /// Output only. Unique shadow experiment target identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Output only. Shadow experiment this target belongs to.
    /// </summary>
    [JsonPropertyName("experimentId")]
    public required string ExperimentId { get; init; }

    /// <summary>
    /// Human-readable target name, unique within the shadow experiment. At most 256 characters.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Deployment under the parent endpoint that receives mirrored traffic. It must not be a live traffic-split member or the source or target of an active rollout; traffic-split weight 0 warm-up targets are allowed.
    /// </summary>
    [JsonPropertyName("targetDeploymentId")]
    public required string TargetDeploymentId { get; init; }

    /// <summary>
    /// Optional free-form target description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Output only. Timestamp when the target was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Output only. Timestamp when the target was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// Opaque version tag for optimistic concurrency control. Returned on read; set it on update or delete requests for consistent read-modify-write.
    /// </summary>
    [JsonPropertyName("etag")]
    public required string Etag { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
