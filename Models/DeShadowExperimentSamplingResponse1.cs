using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record DeShadowExperimentSamplingResponse1
{
    /// <summary>
    /// Fixed sampling by a sticky request key.
    /// </summary>
    [JsonPropertyName("keyBased")]
    public required DeShadowExperimentKeyBasedSamplingResponse KeyBased { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
