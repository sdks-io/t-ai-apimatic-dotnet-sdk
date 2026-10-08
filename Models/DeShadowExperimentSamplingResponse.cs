using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record DeShadowExperimentSamplingResponse
{
    /// <summary>
    /// Fixed random request sampling.
    /// </summary>
    [JsonPropertyName("uniform")]
    public required DeShadowExperimentUniformSamplingResponse Uniform { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
