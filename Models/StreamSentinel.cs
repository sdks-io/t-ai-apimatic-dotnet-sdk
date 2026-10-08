using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record StreamSentinel
{
    [JsonPropertyName("data")]
    public string Data { get; } = "[DONE]";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
