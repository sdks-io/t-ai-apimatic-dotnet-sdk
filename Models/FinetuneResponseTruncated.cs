using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// A truncated version of the fine-tune response, used for POST /fine-tunes, GET /fine-tunes and POST /fine-tunes/{id}/cancel endpoints
/// </summary>
public record FinetuneResponseTruncated
{
    /// <summary>
    /// Unique identifier for the fine-tune job
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("status")]
    public required FinetuneJobStatus Status { get; init; }

    /// <summary>
    /// Creation timestamp of the fine-tune job
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Last update timestamp of the fine-tune job
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// Start timestamp of the current stage of the fine-tune job
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("started_at")]
    public DateTimeOffset? StartedAt { get; init; }

    /// <summary>
    /// ID of the user who created the fine-tune job.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// Owner address information
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("owner_address")]
    public string? OwnerAddress { get; init; }

    /// <summary>
    /// Total price for the fine-tuning job
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_price")]
    public int? TotalPrice { get; init; }

    /// <summary>
    /// Count of tokens processed
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token_count")]
    public int? TokenCount { get; init; }

    /// <summary>
    /// Events related to this fine-tune job
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("events")]
    public IReadOnlyList<FineTuneEvent>? Events { get; init; }

    /// <summary>
    /// File-ID of the training file
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("training_file")]
    public string? TrainingFile { get; init; }

    /// <summary>
    /// File-ID of the validation file
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validation_file")]
    public string? ValidationFile { get; init; }

    /// <summary>
    /// Whether sequence packing is being used for training.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("packing")]
    public bool? Packing { get; init; }

    /// <summary>
    /// Maximum sequence length to use for training. If not specified, uses the maximum allowed for the model and training method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_seq_length")]
    public int? MaxSeqLength { get; init; }

    /// <summary>
    /// Base model used for fine-tuning
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model")]
    public string? Model { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_output_name")]
    public string? ModelOutputName { get; init; }

    /// <summary>
    /// Suffix added to the fine-tuned model name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suffix")]
    public string? Suffix { get; init; }

    /// <summary>
    /// Number of training epochs
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("n_epochs")]
    public int? NEpochs { get; init; }

    /// <summary>
    /// Number of evaluations during training
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("n_evals")]
    public int? NEvals { get; init; }

    /// <summary>
    /// Number of checkpoints saved during training
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("n_checkpoints")]
    public int? NCheckpoints { get; init; }

    /// <summary>
    /// Batch size used for training
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("batch_size")]
    public int? BatchSize { get; init; }

    /// <summary>
    /// Type of training used (full or LoRA)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("training_type")]
    public TrainingType1? TrainingType { get; init; }

    /// <summary>
    /// Method of training used
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("training_method")]
    public TrainingMethod11? TrainingMethod { get; init; }

    /// <summary>
    /// Learning rate used for training
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("learning_rate")]
    public double? LearningRate { get; init; }

    /// <summary>
    /// Learning rate scheduler configuration
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lr_scheduler")]
    public LrScheduler1? LrScheduler { get; init; }

    /// <summary>
    /// Ratio of warmup steps
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warmup_ratio")]
    public double? WarmupRatio { get; init; }

    /// <summary>
    /// Maximum gradient norm for clipping
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_grad_norm")]
    public double? MaxGradNorm { get; init; }

    /// <summary>
    /// Weight decay value used
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weight_decay")]
    public double? WeightDecay { get; init; }

    /// <summary>
    /// Random seed used for training. Integer when set; null if not stored (e.g. legacy jobs) or no explicit seed was recorded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("random_seed")]
    public int? RandomSeed { get; init; }

    /// <summary>
    /// Weights &amp; Biases project name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wandb_project_name")]
    public string? WandbProjectName { get; init; }

    /// <summary>
    /// Weights &amp; Biases run name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wandb_name")]
    public string? WandbName { get; init; }

    /// <summary>
    /// Checkpoint used to continue training
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("from_checkpoint")]
    public string? FromCheckpoint { get; init; }

    /// <summary>
    /// Hugging Face Hub repo to start training from
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("from_hf_model")]
    public string? FromHfModel { get; init; }

    /// <summary>
    /// The revision of the Hugging Face Hub model to continue training from
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hf_model_revision")]
    public string? HfModelRevision { get; init; }

    /// <summary>
    /// Progress information for the fine-tuning job
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("progress")]
    public FineTuneProgress1? Progress { get; init; }

    /// <summary>
    /// Whether the early-stopping criterion triggered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("early_stopped")]
    public bool? EarlyStopped { get; init; }

    /// <summary>
    /// Step associated with the selected early-stopping artifact. When early_stopping_best_metric is null, no finite best metric was recorded; this is the halt step, not a best-checkpoint step.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("early_stopping_best_step")]
    public int? EarlyStoppingBestStep { get; init; }

    /// <summary>
    /// Best validation loss observed, corresponding to early_stopping_best_step. Null if no improving evaluation was recorded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("early_stopping_best_metric")]
    public double? EarlyStoppingBestMetric { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
