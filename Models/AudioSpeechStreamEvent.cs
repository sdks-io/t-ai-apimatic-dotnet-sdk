using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record AudioSpeechStreamEvent
{
    [JsonPropertyName("data")]
    public required AudioSpeechStreamChunk Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
