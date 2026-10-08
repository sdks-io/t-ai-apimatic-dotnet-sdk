using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Default sampling parameters used for a Sample request.
/// </summary>
public record RlModelSamplingDefaults
{
    /// <summary>
    /// Number of completions per prompt
    /// </summary>
    [JsonPropertyName("n")]
    public required int N { get; init; }

    /// <summary>
    /// Maximum tokens generated per completion
    /// </summary>
    [JsonPropertyName("max_tokens")]
    public required int MaxTokens { get; init; }

    /// <summary>
    /// Sampling temperature
    /// </summary>
    [JsonPropertyName("temperature")]
    public required double Temperature { get; init; }

    /// <summary>
    /// Number of logprobs to return per token
    /// </summary>
    [JsonPropertyName("logprobs")]
    public required int Logprobs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
