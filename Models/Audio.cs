using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record Audio
{
    [JsonPropertyName("type")]
    public string Type { get; } = "audio_url";

    [JsonPropertyName("audio_url")]
    public required AudioUrl AudioUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
