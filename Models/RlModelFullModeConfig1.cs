using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Full-weight training config. Set when the model supports full-weight training.
/// </summary>
public record RlModelFullModeConfig1
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
