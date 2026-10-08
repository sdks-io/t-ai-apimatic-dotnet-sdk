using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// A (policy version, starting token) span within a sampled sequence. Version 0 is the initial model; each optim_step call increments the version by 1.
/// </summary>
public record RlPolicyVersionSegment
{
    /// <summary>
    /// Model version under which this segment of tokens was generated
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    /// <summary>
    /// Index of the first token of this segment within the sampled sequence. Always 0 for the first segment.
    /// </summary>
    [JsonPropertyName("start_token")]
    public required int StartToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
