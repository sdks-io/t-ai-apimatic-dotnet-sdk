using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Completions generated for a single model input
/// </summary>
public record RlSampleResult
{
    /// <summary>
    /// Generated completions
    /// </summary>
    [JsonPropertyName("sequences")]
    public required IReadOnlyList<RlSampledSequence> Sequences { get; init; }

    /// <summary>
    /// Teacher-forced log-probability of each model input token. Full prompt length; entry i corresponds to prompt token i. Entry 0 is always 0 as a placeholder: the first prompt token has no conditioning context, so it has no log-probability. Present only when prompt_logprobs was set on the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prompt_logprobs")]
    public IReadOnlyList<double>? PromptLogprobs { get; init; }

    /// <summary>
    /// The most likely alternative tokens at each model input token, up to <c>topk_prompt_logprobs</c> per position. Full prompt length; entry i corresponds to prompt token i, and entry 0 is empty. Present only when topk_prompt_logprobs was set on the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topk_prompt_logprobs")]
    public IReadOnlyList<RlPromptTopLogprobs>? TopkPromptLogprobs { get; init; }

    /// <summary>
    /// Policy versions that produced these completions
    /// </summary>
    [JsonPropertyName("policy_segments")]
    public required IReadOnlyList<RlPolicyVersionSegment> PolicySegments { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
