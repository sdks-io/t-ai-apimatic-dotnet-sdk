using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// A single generated completion sequence with tokens and logprobs
/// </summary>
public record RlSampledSequence
{
    /// <summary>
    /// Generated token IDs
    /// </summary>
    [JsonPropertyName("tokens")]
    public required IReadOnlyList<Token> Tokens { get; init; }

    /// <summary>
    /// Log probabilities for each generated token
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logprobs")]
    public IReadOnlyList<double>? Logprobs { get; init; }

    /// <summary>
    /// Reason for stopping generation
    /// </summary>
    [JsonPropertyName("stop_reason")]
    public required RlStopReason2 StopReason { get; init; }

    /// <summary>
    /// Number of model input tokens served from the prefix cache while generating this sequence.
    /// </summary>
    [JsonPropertyName("prompt_cache_hit_tokens")]
    public required int PromptCacheHitTokens { get; init; }

    /// <summary>
    /// Opaque key for reusing this sequence's expert selections during training. Pass it unchanged with the corresponding training sample. Absent for non-mixture-of-experts models or when <c>return_routed_experts</c> is disabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routed_experts_key")]
    public string? RoutedExpertsKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
