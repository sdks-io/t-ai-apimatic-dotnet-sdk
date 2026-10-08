using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// Endpoint-level source that samples endpoint traffic at the API gateway.
/// </summary>
public record DeShadowExperimentEndpointSource
{
    /// <summary>
    /// Sampling strategy applied to endpoint traffic.
    /// </summary>
    [JsonPropertyName("sampling")]
    public required DeShadowExperimentSampling4 Sampling { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
