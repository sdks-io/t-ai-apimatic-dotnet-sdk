using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// A page of training checkpoints
/// </summary>
public record RlCheckpointsListResponse
{
    /// <summary>
    /// Training checkpoints in this page
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<RlCheckpoint> Data { get; init; }

    /// <summary>
    /// Pagination metadata
    /// </summary>
    [JsonPropertyName("meta")]
    public required RlListMeta1 Meta { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
