using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record Video
{
    [JsonPropertyName("type")]
    public string Type { get; } = "video_url";

    [JsonPropertyName("video_url")]
    public required VideoUrl VideoUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
