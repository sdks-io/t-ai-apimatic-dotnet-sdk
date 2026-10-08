using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Fixed-rate random sampling of endpoint requests.
/// </summary>
public record DeShadowExperimentUniformSampling
{
    /// <summary>
    /// Required fraction of requests to sample, from 0.0 to 1.0.
    /// </summary>
    [JsonPropertyName("rate")]
    public required double Rate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
