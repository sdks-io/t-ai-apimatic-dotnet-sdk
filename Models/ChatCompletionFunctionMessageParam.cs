using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ChatCompletionFunctionMessageParam
{
    [JsonPropertyName("role")]
    public string Role { get; } = "function";

    [JsonPropertyName("content")]
    public required string Content { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
