using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record LogprobsPart
{
    /// <summary>
    /// List of token IDs corresponding to the logprobs
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token_ids")]
    public IReadOnlyList<double>? TokenIds { get; init; }

    /// <summary>
    /// List of token strings
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokens")]
    public IReadOnlyList<string>? Tokens { get; init; }

    /// <summary>
    /// List of token log probabilities
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token_logprobs")]
    public IReadOnlyList<double>? TokenLogprobs { get; init; }

    /// <summary>
    /// Top log probabilities for the tokens.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_logprobs")]
    public IReadOnlyDictionary<string, double>? TopLogprobs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
