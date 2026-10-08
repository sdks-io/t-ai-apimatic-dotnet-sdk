using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// LoRA training config. If present, the model supports LoRA training.
/// </summary>
public record RlModelLoraModeConfig
{
    /// <summary>
    /// Maximum global batch size accepted by a forward-backward step
    /// </summary>
    [JsonPropertyName("max_batch_size")]
    public required int MaxBatchSize { get; init; }

    /// <summary>
    /// Maximum sequence length in tokens
    /// </summary>
    [JsonPropertyName("max_seq_length")]
    public required int MaxSeqLength { get; init; }

    /// <summary>
    /// Maximum LoRA rank
    /// </summary>
    [JsonPropertyName("max_rank")]
    public required int MaxRank { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
