using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Fixed-rate random sampling returned by the API. A zero rate may be omitted by JSON serialization.
/// </summary>
public record DeShadowExperimentUniformSamplingResponse
{
    /// <summary>
    /// Fraction of requests sampled, from 0.0 to 1.0.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rate")]
    public double? Rate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
