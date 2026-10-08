using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// S3 bucket or prefix source for the volume sync.
/// </summary>
public record S3Origin2
{
    /// <summary>
    /// IAM role ARN Together assumes to read the S3 bucket or prefix.
    /// </summary>
    [JsonPropertyName("role_arn")]
    public required string RoleArn { get; init; }

    /// <summary>
    /// S3 bucket or prefix to copy into the volume.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
