using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Progress information for a fine-tuning job
/// </summary>
public record FineTuneProgress
{
    /// <summary>
    /// Whether time estimate is available
    /// </summary>
    [JsonPropertyName("estimate_available")]
    public required bool EstimateAvailable { get; init; }

    /// <summary>
    /// Estimated time remaining in seconds for the fine-tuning job to next state
    /// </summary>
    [JsonPropertyName("seconds_remaining")]
    public required int SecondsRemaining { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
