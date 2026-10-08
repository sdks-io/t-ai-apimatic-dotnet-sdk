using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Fixed-rate sticky-key sampling returned by the API. A zero rate may be omitted by JSON serialization.
/// </summary>
public record DeShadowExperimentKeyBasedSamplingResponse
{
    /// <summary>
    /// Fraction of distinct key values sampled, from 0.0 to 1.0.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rate")]
    public double? Rate { get; init; }

    /// <summary>
    /// Request-body field used as the sticky sampling key.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
