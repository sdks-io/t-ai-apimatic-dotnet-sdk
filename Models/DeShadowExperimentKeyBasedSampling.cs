using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Fixed-rate sampling of distinct key values with sticky decisions.
/// </summary>
public record DeShadowExperimentKeyBasedSampling
{
    /// <summary>
    /// Required fraction of distinct key values to sample, from 0.0 to 1.0.
    /// </summary>
    [JsonPropertyName("rate")]
    public required double Rate { get; init; }

    /// <summary>
    /// Required request-body field used as the sticky sampling key.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
