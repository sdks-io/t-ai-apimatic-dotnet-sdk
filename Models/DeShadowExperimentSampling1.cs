using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record DeShadowExperimentSampling1
{
    /// <summary>
    /// Fixed sampling by a sticky request key.
    /// </summary>
    [JsonPropertyName("keyBased")]
    public required DeShadowExperimentKeyBasedSampling KeyBased { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
