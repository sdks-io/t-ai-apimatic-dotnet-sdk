using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ImageResponseDataB64
{
    [JsonPropertyName("index")]
    public required int Index { get; init; }

    [JsonPropertyName("b64_json")]
    public required string B64Json { get; init; }

    [JsonPropertyName("type")]
    public string Type { get; } = "b64_json";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
