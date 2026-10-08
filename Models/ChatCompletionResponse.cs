using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ChatCompletionResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("choices")]
    public required IReadOnlyList<ChatCompletionChoicesDatum> Choices { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usage")]
    public UsageData? Usage { get; init; }

    [JsonPropertyName("created")]
    public required int Created { get; init; }

    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// When <c>echo</c> is true, the prompt is included in the response. Additionally, when <c>logprobs</c> is also provided, log probability information is provided on the prompt.
    /// </summary>
    [JsonPropertyName("prompt")]
    public required IReadOnlyList<PromptPart> Prompt { get; init; }

    /// <summary>
    /// The object type, which is always <c>chat.completion</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "chat.completion";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<InferenceWarning>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
