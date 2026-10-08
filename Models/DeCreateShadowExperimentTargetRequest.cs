using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Deployment under the parent endpoint that should receive mirrored requests from a shadow experiment.
/// </summary>
public record DeCreateShadowExperimentTargetRequest
{
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
