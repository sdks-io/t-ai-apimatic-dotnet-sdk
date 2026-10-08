using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Validation.Attributes;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Request body for previewing tokenized fine-tuning data.
/// </summary>
public record FineTunePreviewRequest
{
    /// <summary>
    /// Name of the base model whose tokenizer and chat template will be used.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// File-ID of the uploaded JSONL training file to sample for preview.
    /// </summary>
    [JsonPropertyName("training_file")]
    public required string TrainingFile { get; init; }

    /// <summary>
    /// Fine-tuning method to preview. Only supervised fine-tuning is currently supported.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("training_method")]
    public TrainingMethod? TrainingMethod { get; init; } = TrainingMethod.Sft;

    /// <summary>
    /// Whether prompt or user-message tokens should contribute to training loss in the preview.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("train_on_inputs")]
    public bool? TrainOnInputs { get; init; } = false;

    /// <summary>
    /// Maximum number of rows from the start of the training file to tokenize.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_k")]
    [Minimum(1)]
    [Maximum(50)]
    public int? TopK { get; init; } = 5;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
