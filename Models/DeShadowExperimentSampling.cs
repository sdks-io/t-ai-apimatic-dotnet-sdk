using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record DeShadowExperimentSampling
{
    /// <summary>
    /// Fixed random request sampling.
    /// </summary>
    [JsonPropertyName("uniform")]
    public required DeShadowExperimentUniformSampling Uniform { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
