using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record DeShadowExperimentSampling3
{
    /// <summary>
    /// Adaptive sticky-key sampling toward a target QPS.
    /// </summary>
    [JsonPropertyName("adaptiveKeyBased")]
    public required DeShadowExperimentAdaptiveKeyBasedSampling AdaptiveKeyBased { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
