using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Limits for LoRA training.
/// </summary>
public record LoraTraining
{
    /// <summary>
    /// Maximum batch size for SFT LoRA training.
    /// </summary>
    [JsonPropertyName("max_batch_size")]
    public required int MaxBatchSize { get; init; }

    /// <summary>
    /// Maximum batch size for DPO LoRA training.
    /// </summary>
    [JsonPropertyName("max_batch_size_dpo")]
    public required int MaxBatchSizeDpo { get; init; }

    /// <summary>
    /// Minimum batch size for LoRA training.
    /// </summary>
    [JsonPropertyName("min_batch_size")]
    public required int MinBatchSize { get; init; }

    /// <summary>
    /// Maximum LoRA rank.
    /// </summary>
    [JsonPropertyName("max_rank")]
    public required int MaxRank { get; init; }

    /// <summary>
    /// Default LoRA rank applied when a fine-tune request omits training_type.
    /// </summary>
    [JsonPropertyName("default_rank")]
    public required int DefaultRank { get; init; }

    /// <summary>
    /// Available target modules for LoRA.
    /// </summary>
    [JsonPropertyName("target_modules")]
    public required IReadOnlyList<string> TargetModules { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
