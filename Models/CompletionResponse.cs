using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record CompletionResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("choices")]
    public required IReadOnlyList<CompletionChoicesDatum> Choices { get; init; }

    /// <summary>
    /// When <c>echo</c> is true, the prompt is included in the response. Additionally, when <c>logprobs</c> is also provided, log probability information is provided on the prompt.
    /// </summary>
    [JsonPropertyName("prompt")]
    public required IReadOnlyList<PromptPart> Prompt { get; init; }

    [JsonPropertyName("usage")]
    public required UsageData? Usage { get; init; }

    [JsonPropertyName("created")]
    public required int Created { get; init; }

    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// The object type, which is always <c>text.completion</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "text.completion";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
