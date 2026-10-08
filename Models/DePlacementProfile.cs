using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Reusable ordered region preferences for scheduling a project's deployments.
/// </summary>
public record DePlacementProfile
{
    /// <summary>
    /// Unique placement profile identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Project that owns the placement profile.
    /// </summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    /// <summary>
    /// Organization that owns the placement profile.
    /// </summary>
    [JsonPropertyName("organizationId")]
    public required string OrganizationId { get; init; }

    /// <summary>
    /// Human-readable placement profile name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Preferred deployment regions in descending priority order.
    /// </summary>
    [JsonPropertyName("preferredRegions")]
    public required IReadOnlyList<string> PreferredRegions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
