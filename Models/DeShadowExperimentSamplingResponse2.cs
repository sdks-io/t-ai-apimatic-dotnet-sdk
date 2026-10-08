using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record DeShadowExperimentSamplingResponse2
{
    /// <summary>
    /// Adaptive random sampling toward a target QPS.
    /// </summary>
    [JsonPropertyName("adaptiveUniform")]
    public required DeShadowExperimentAdaptiveUniformSamplingResponse AdaptiveUniform { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
