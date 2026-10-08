using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Tokenized representation of one sampled fine-tuning row.
/// </summary>
public record FineTunePreviewRow
{
    /// <summary>
    /// Token IDs produced for the sampled row.
    /// </summary>
    [JsonPropertyName("input_ids")]
    public required IReadOnlyList<int> InputIds { get; init; }

    /// <summary>
    /// Raw token strings produced for the sampled row.
    /// </summary>
    [JsonPropertyName("tokens")]
    public required IReadOnlyList<string> Tokens { get; init; }

    /// <summary>
    /// Training labels for each token; masked tokens use -100.
    /// </summary>
    [JsonPropertyName("labels")]
    public required IReadOnlyList<int> Labels { get; init; }

    /// <summary>
    /// Half-open token index ranges that contribute to training loss.
    /// </summary>
    [JsonPropertyName("trained_spans")]
    public required IReadOnlyList<IReadOnlyList<int>> TrainedSpans { get; init; }

    /// <summary>
    /// Total number of tokens in the preview row after truncation.
    /// </summary>
    [JsonPropertyName("num_tokens")]
    public required int NumTokens { get; init; }

    /// <summary>
    /// Number of tokens in the row that contribute to training loss.
    /// </summary>
    [JsonPropertyName("num_trained_tokens")]
    public required int NumTrainedTokens { get; init; }

    /// <summary>
    /// Whether the row was truncated to the model maximum sequence length.
    /// </summary>
    [JsonPropertyName("truncated")]
    public required bool Truncated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
