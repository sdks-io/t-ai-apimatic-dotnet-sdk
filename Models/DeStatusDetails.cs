using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Deployment status broken down by each supported dimension.
/// </summary>
public record DeStatusDetails
{
    /// <summary>
    /// Regions where the deployment is actually scheduled or serving replicas, sorted by region.
    /// </summary>
    [JsonPropertyName("region")]
    public required IReadOnlyList<DeRegionStatus> Region { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
