using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ImageResponseDataUrl
{
    [JsonPropertyName("index")]
    public required int Index { get; init; }

    [JsonPropertyName("url")]
    public required string Url { get; init; }

    [JsonPropertyName("type")]
    public string Type { get; } = "url";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
