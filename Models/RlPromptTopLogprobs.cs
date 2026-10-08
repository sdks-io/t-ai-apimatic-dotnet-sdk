using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// The most likely alternative tokens at a single prompt position, as two parallel arrays of equal length. Both are empty for a position with no conditioning context, such as position 0.
/// </summary>
public record RlPromptTopLogprobs
{
    /// <summary>
    /// Token IDs of the alternatives, ordered by descending log-probability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token_ids")]
    public IReadOnlyList<int>? TokenIds { get; init; }

    /// <summary>
    /// Log-probability of each alternative in <c>token_ids</c>, at the same index.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logprobs")]
    public IReadOnlyList<double>? Logprobs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
