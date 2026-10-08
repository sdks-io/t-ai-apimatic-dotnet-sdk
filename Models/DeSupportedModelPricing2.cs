using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Serverless pricing in USD per one million tokens, if available.
/// </summary>
public record DeSupportedModelPricing2
{
    /// <summary>
    /// Price in USD per one million input tokens.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("input")]
    public double? Input { get; init; }

    /// <summary>
    /// Price in USD per one million output tokens.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("output")]
    public double? Output { get; init; }

    /// <summary>
    /// Price in USD per one million cached input tokens.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cachedInput")]
    public double? CachedInput { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
