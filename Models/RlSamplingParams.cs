using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

public record RlSamplingParams
{
    /// <summary>
    /// Maximum number of tokens to generate per completion
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_tokens")]
    public int? MaxTokens { get; init; } = 512;

    /// <summary>
    /// Sampling temperature
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("temperature")]
    public double? Temperature { get; init; } = 1d;

    /// <summary>
    /// Nucleus sampling probability threshold
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_p")]
    public double? TopP { get; init; } = 1d;

    /// <summary>
    /// Top-k sampling limit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_k")]
    public int? TopK { get; init; } = -1;

    /// <summary>
    /// Generation stops when any of these strings is produced
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stop")]
    public IReadOnlyList<string>? Stop { get; init; }

    /// <summary>
    /// Random seed for reproducible sampling for the same prompt and model state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seed")]
    public Seed? Seed { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
