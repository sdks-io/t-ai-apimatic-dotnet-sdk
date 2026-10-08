using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record Result
{
    [JsonPropertyName("index")]
    public required int Index { get; init; }

    [JsonPropertyName("relevance_score")]
    public required double RelevanceScore { get; init; }

    [JsonPropertyName("document")]
    public required Document Document { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
