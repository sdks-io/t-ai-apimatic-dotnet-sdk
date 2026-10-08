using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Paginated list of model resources
/// </summary>
public record RlModelResourcesListResponse
{
    /// <summary>
    /// List of model resources
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<RlModelResources> Data { get; init; }

    /// <summary>
    /// Pagination metadata
    /// </summary>
    [JsonPropertyName("meta")]
    public required RlListMeta1 Meta { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
