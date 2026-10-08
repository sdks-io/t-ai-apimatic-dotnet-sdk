using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// A downloadable file within a checkpoint
/// </summary>
public record RlCheckpointFile
{
    /// <summary>
    /// Name of the file
    /// </summary>
    [JsonPropertyName("filename")]
    public required string Filename { get; init; }

    /// <summary>
    /// Presigned URL for downloading the file
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    /// <summary>
    /// File size in bytes
    /// </summary>
    [JsonPropertyName("size")]
    public required Size Size { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
