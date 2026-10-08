using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Validation.Attributes;

namespace TogetherApIs.Models;

public record RlSampleBody
{
    /// <summary>
    /// Model inputs to sample from
    /// </summary>
    [JsonPropertyName("model_inputs")]
    public required IReadOnlyList<RlModelInput> ModelInputs { get; init; }

    /// <summary>
    /// Optional sampling parameters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sampling_params")]
    public RlSamplingParams2? SamplingParams { get; init; }

    /// <summary>
    /// Number of completions to generate per prompt
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_samples")]
    public int? NumSamples { get; init; } = 1;

    /// <summary>
    /// When true, also compute teacher-forced log-probabilities for the model input tokens and return them in <c>SampleResult.prompt_logprobs</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prompt_logprobs")]
    public bool? PromptLogprobs { get; init; } = false;

    /// <summary>
    /// Number of most likely alternative tokens to return per model input token in <c>SampleResult.topk_prompt_logprobs</c>. 0 disables top-k prompt log-probabilities. Maximum 20.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topk_prompt_logprobs")]
    [Minimum(0)]
    [Maximum(20)]
    public int? TopkPromptLogprobs { get; init; } = 0;

    /// <summary>
    /// When true, enable reuse of the expert selections from sampled sequences during training. Only supported for mixture-of-experts models; ignored for other models.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_routed_experts")]
    public bool? ReturnRoutedExperts { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
