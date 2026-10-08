using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Input and output token totals and averages.
/// </summary>
public record DeTokenMetrics1
{
    /// <summary>
    /// Total input tokens processed during the time range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalInputTokens")]
    public string? TotalInputTokens { get; init; }

    /// <summary>
    /// Total output tokens generated during the time range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalOutputTokens")]
    public string? TotalOutputTokens { get; init; }

    /// <summary>
    /// Average input tokens per request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avgInputTokens")]
    public double? AvgInputTokens { get; init; }

    /// <summary>
    /// Average output tokens per request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avgOutputTokens")]
    public double? AvgOutputTokens { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
