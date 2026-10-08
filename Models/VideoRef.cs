using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record VideoRef
{
    /// <summary>
    /// URL of the video.
    /// </summary>
    [JsonPropertyName("video")]
    public required string Video { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
