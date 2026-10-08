using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Limits for full training.
/// </summary>
public record FullTraining
{
    /// <summary>
    /// Maximum batch size for SFT full training.
    /// </summary>
    [JsonPropertyName("max_batch_size")]
    public required int MaxBatchSize { get; init; }

    /// <summary>
    /// Maximum batch size for DPO full training.
    /// </summary>
    [JsonPropertyName("max_batch_size_dpo")]
    public required int MaxBatchSizeDpo { get; init; }

    /// <summary>
    /// Minimum batch size for full training.
    /// </summary>
    [JsonPropertyName("min_batch_size")]
    public required int MinBatchSize { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
