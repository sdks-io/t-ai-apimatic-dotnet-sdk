using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// External source Together copied into this volume version.
/// </summary>
public record VolumeOrigin1
{
    /// <summary>
    /// S3 bucket or prefix source for the volume sync.
    /// </summary>
    [JsonPropertyName("s3")]
    public required S3Origin2 S3 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
