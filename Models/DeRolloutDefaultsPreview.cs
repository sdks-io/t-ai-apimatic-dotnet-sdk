using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// Completed create-form state — the caller's spec with defaulted values filled in, the steps the rollout is expected to walk, and the capacity context the defaults were computed from. Display only.
/// </summary>
public record DeRolloutDefaultsPreview
{
    /// <summary>
    /// The caller's spec with defaulted values filled in for display. canary.steps is echoed exactly as sent; the suggested ladder is returned in estimatedEffectiveSteps instead.
    /// </summary>
    [JsonPropertyName("spec")]
    public required DeCreateRolloutRequest3 Spec { get; init; }

    /// <summary>
    /// Steps the rollout is expected to walk when the caller leaves steps unset. Display only. Empty when the caller supplied steps or no ladder applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("estimatedEffectiveSteps")]
    public IReadOnlyList<DeRolloutStep>? EstimatedEffectiveSteps { get; init; }

    /// <summary>
    /// True when both deployments stand in the endpoint traffic split, so the rollout resumes from the current split rather than from zero. See warnings for standing split shapes that StartRollout will still reject.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("frozenPair")]
    public bool? FrozenPair { get; init; }

    /// <summary>
    /// Percentage of the pair's traffic currently reaching the target, the floor the suggested steps start above. Unset when not a frozen pair or unknown; 0 is a real measurement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("estimatedSeedPercent")]
    public int? EstimatedSeedPercent { get; init; }

    /// <summary>
    /// Source deployment replica count the defaults were computed from. Zero is a real value.
    /// </summary>
    [JsonPropertyName("sourceReplicas")]
    public required int SourceReplicas { get; init; }

    /// <summary>
    /// Target deployment replica count the defaults were computed from. Zero is a real value.
    /// </summary>
    [JsonPropertyName("targetReplicas")]
    public required int TargetReplicas { get; init; }

    /// <summary>
    /// Target deployment autoscaling minimum replica count. Zero is a real value.
    /// </summary>
    [JsonPropertyName("targetMinReplicas")]
    public required int TargetMinReplicas { get; init; }

    /// <summary>
    /// Target deployment autoscaling maximum replica count. Zero is a real value.
    /// </summary>
    [JsonPropertyName("targetMaxReplicas")]
    public required int TargetMaxReplicas { get; init; }

    /// <summary>
    /// Findings to surface next to the form when a later gate will refuse the spec or a standing guarantee is lost. An empty list means the shown values are safe to submit as-is; render message for unrecognized codes.
    /// </summary>
    [JsonPropertyName("warnings")]
    public required IReadOnlyList<DePreviewWarning> Warnings { get; init; }

    /// <summary>
    /// Expected autoscaling minimum replicas for the completed target; unset while the final target replicas cannot be resolved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("landingMinReplicas")]
    public int? LandingMinReplicas { get; init; }

    /// <summary>
    /// Expected autoscaling maximum replicas for the completed target; unset while the final target replicas cannot be resolved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("landingMaxReplicas")]
    public int? LandingMaxReplicas { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
