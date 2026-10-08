using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Sampling strategy and optional initial targets for mirroring endpoint requests without affecting client responses.
/// </summary>
public record DeCreateShadowExperimentRequest
{
    /// <summary>
    /// Human-readable shadow experiment name, unique within the endpoint. At most 256 characters.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Endpoint source and sampling configuration for the experiment.
    /// </summary>
    [JsonPropertyName("source")]
    public required DeShadowExperimentSource Source { get; init; }

    /// <summary>
    /// Optional initial target deployments. At most 100 targets; manage later changes through the target APIs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targets")]
    public IReadOnlyList<DeCreateShadowExperimentTargetRequest>? Targets { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
