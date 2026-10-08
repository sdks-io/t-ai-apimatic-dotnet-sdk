using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// Policy and weight versions for this training session. Compare these with <c>policy_segments[].version</c> on sample results from the same session. Versions may reset after session recovery or resume.
/// </summary>
public record RlSessionPolicyState
{
    /// <summary>
    /// Policy version produced by the last completed optimizer step. Distinct from <c>TrainingSession.step</c>, which is the durable optimizer-step counter.
    /// </summary>
    [JsonPropertyName("trainer_step")]
    public required TrainerStep TrainerStep { get; init; }

    /// <summary>
    /// Policy version promised to the generator by the latest weights-sync.
    /// </summary>
    [JsonPropertyName("target_weights_version")]
    public required TargetWeightsVersion TargetWeightsVersion { get; init; }

    /// <summary>
    /// Policy version successfully applied to the generator for this session.
    /// </summary>
    [JsonPropertyName("applied_weights_version")]
    public required AppliedWeightsVersion AppliedWeightsVersion { get; init; }

    /// <summary>
    /// True when a generator publish has been requested but has not finished.
    /// </summary>
    [JsonPropertyName("pending_publish")]
    public required bool PendingPublish { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
