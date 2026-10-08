using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Model limits for fine-tuning.
/// </summary>
public record FineTuneModelLimits
{
    /// <summary>
    /// The name of the model.
    /// </summary>
    [JsonPropertyName("model_name")]
    public required string ModelName { get; init; }

    /// <summary>
    /// Limits for full training.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("full_training")]
    public FullTraining? FullTraining { get; init; }

    /// <summary>
    /// Limits for LoRA training.
    /// </summary>
    [JsonPropertyName("lora_training")]
    public required LoraTraining LoraTraining { get; init; }

    /// <summary>
    /// Maximum number of training epochs.
    /// </summary>
    [JsonPropertyName("max_num_epochs")]
    public required int MaxNumEpochs { get; init; }

    /// <summary>
    /// Maximum number of evaluations.
    /// </summary>
    [JsonPropertyName("max_num_evals")]
    public required int MaxNumEvals { get; init; }

    /// <summary>
    /// Maximum learning rate.
    /// </summary>
    [JsonPropertyName("max_learning_rate")]
    public required double MaxLearningRate { get; init; }

    /// <summary>
    /// Minimum learning rate.
    /// </summary>
    [JsonPropertyName("min_learning_rate")]
    public required double MinLearningRate { get; init; }

    /// <summary>
    /// Whether the model supports full (non-LoRA) fine-tuning. When false, only LoRA fine-tuning is available and the full_training limits are reported as zero.
    /// </summary>
    [JsonPropertyName("supports_full_training")]
    public required bool SupportsFullTraining { get; init; }

    /// <summary>
    /// Whether the model supports vision/multimodal inputs.
    /// </summary>
    [JsonPropertyName("supports_vision")]
    public required bool SupportsVision { get; init; }

    /// <summary>
    /// Whether the model supports tool/function calling.
    /// </summary>
    [JsonPropertyName("supports_tools")]
    public required bool SupportsTools { get; init; }

    /// <summary>
    /// Whether the model supports reasoning.
    /// </summary>
    [JsonPropertyName("supports_reasoning")]
    public required bool SupportsReasoning { get; init; }

    /// <summary>
    /// Whether a merged checkpoint (the base model with the trained LoRA adapter fused in) is produced for LoRA fine-tunes of this model, in addition to the standalone adapter.
    /// </summary>
    [JsonPropertyName("merge_output_lora")]
    public required bool MergeOutputLora { get; init; }

    /// <summary>
    /// Default gradient accumulation steps used when a fine-tune request omits the value or sets it to 0.
    /// </summary>
    [JsonPropertyName("default_gradient_accumulation_steps")]
    public required int DefaultGradientAccumulationSteps { get; init; }

    /// <summary>
    /// Maximum number of checkpoints that can be saved during a fine-tuning job.
    /// </summary>
    [JsonPropertyName("max_num_checkpoints")]
    public required int MaxNumCheckpoints { get; init; }

    /// <summary>
    /// Minimum value allowed for the max_seq_length hyperparameter.
    /// </summary>
    [JsonPropertyName("min_max_seq_length")]
    public required int MinMaxSeqLength { get; init; }

    /// <summary>
    /// Maximum sequence length supported for SFT training.
    /// </summary>
    [JsonPropertyName("max_seq_length_sft")]
    public required int MaxSeqLengthSft { get; init; }

    /// <summary>
    /// Maximum sequence length supported for DPO training.
    /// </summary>
    [JsonPropertyName("max_seq_length_dpo")]
    public required int MaxSeqLengthDpo { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
