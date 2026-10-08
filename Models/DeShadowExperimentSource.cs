using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Traffic source for a shadow experiment. The public API supports endpoint sources only.
/// </summary>
public record DeShadowExperimentSource
{
    /// <summary>
    /// Endpoint-level source that samples traffic at the API gateway.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public required DeShadowExperimentEndpointSource Endpoint { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
