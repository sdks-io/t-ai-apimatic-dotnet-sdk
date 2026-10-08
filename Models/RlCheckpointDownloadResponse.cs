using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Presigned download URLs for a checkpoint's files
/// </summary>
public record RlCheckpointDownloadResponse
{
    /// <summary>
    /// List of files with presigned download URLs
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<RlCheckpointFile> Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
