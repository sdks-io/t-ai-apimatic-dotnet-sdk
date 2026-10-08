using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record DeShadowExperimentSampling2
{
    /// <summary>
    /// Adaptive random sampling toward a target QPS.
    /// </summary>
    [JsonPropertyName("adaptiveUniform")]
    public required DeShadowExperimentAdaptiveUniformSampling AdaptiveUniform { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
