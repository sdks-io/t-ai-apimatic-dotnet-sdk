using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Configuration for a managed live-traffic split across deployments under one endpoint.
/// </summary>
public record DeCreateAbExperimentRequest
{
    /// <summary>
    /// Human-readable A/B experiment name, unique within the endpoint.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Optional free-form description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Two to 20 participating deployments with exactly one control. Integer traffic percentages across all members must add up to 100.
    /// </summary>
    [JsonPropertyName("members")]
    public required IReadOnlyList<DeAbExperimentMember> Members { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
