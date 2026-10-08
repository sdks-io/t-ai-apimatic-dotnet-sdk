using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Tokenized preview for sampled rows from a fine-tuning training file.
/// </summary>
public record FineTunePreviewResponse
{
    /// <summary>
    /// Name of the base model used to tokenize the sampled rows.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Detected SFT dataset format for the sampled rows.
    /// </summary>
    [JsonPropertyName("dataset_format")]
    public required DatasetFormat DatasetFormat { get; init; }

    /// <summary>
    /// Maximum sequence length configured for the requested model.
    /// </summary>
    [JsonPropertyName("max_seq_length")]
    public required int MaxSeqLength { get; init; }

    /// <summary>
    /// Whether prompt or user-message tokens contribute to training loss.
    /// </summary>
    [JsonPropertyName("train_on_inputs")]
    public required bool TrainOnInputs { get; init; }

    /// <summary>
    /// Tokenized preview rows, in the same order as the sampled training file rows.
    /// </summary>
    [JsonPropertyName("rows")]
    public required IReadOnlyList<FineTunePreviewRow> Rows { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
