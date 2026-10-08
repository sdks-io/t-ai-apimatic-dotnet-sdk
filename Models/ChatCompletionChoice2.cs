using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record ChatCompletionChoice2
{
    [JsonPropertyName("index")]
    public required int Index { get; init; }

    [JsonPropertyName("finish_reason")]
    public required FinishReason FinishReason { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logprobs")]
    public double? Logprobs { get; init; }

    /// <summary>
    /// Top log probabilities for the tokens.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_logprobs")]
    public IReadOnlyDictionary<string, double>? TopLogprobs { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seed")]
    public int? Seed { get; init; }

    [JsonPropertyName("delta")]
    public required ChatCompletionChoiceDelta Delta { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
