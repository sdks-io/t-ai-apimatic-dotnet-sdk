using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Endpoint traffic source returned for a shadow experiment.
/// </summary>
public record DeShadowExperimentSourceResponse
{
    /// <summary>
    /// Endpoint-level source that samples traffic at the API gateway.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public required DeShadowExperimentEndpointSourceResponse Endpoint { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
