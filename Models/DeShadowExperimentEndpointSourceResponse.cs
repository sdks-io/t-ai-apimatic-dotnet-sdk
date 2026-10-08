using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// Endpoint-level source returned for a shadow experiment.
/// </summary>
public record DeShadowExperimentEndpointSourceResponse
{
    /// <summary>
    /// Resolved sampling strategy applied to endpoint traffic.
    /// </summary>
    [JsonPropertyName("sampling")]
    public required DeShadowExperimentSamplingResponse4 Sampling { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
