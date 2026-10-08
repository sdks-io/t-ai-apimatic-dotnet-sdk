using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record UsageData
{
    [JsonPropertyName("prompt_tokens")]
    public required int PromptTokens { get; init; }

    [JsonPropertyName("completion_tokens")]
    public required int CompletionTokens { get; init; }

    [JsonPropertyName("total_tokens")]
    public required int TotalTokens { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
