using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record FinetuneResponse
{
    [JsonPropertyName("id")]
    public required Guid Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("training_file")]
    public string? TrainingFile { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validation_file")]
    public string? ValidationFile { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model")]
    public string? Model { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_output_name")]
    public string? ModelOutputName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_output_path")]
    public string? ModelOutputPath { get; init; }

    /// <summary>
    /// Storage path for the tokenized dataset archive generated for this fine-tune job.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenized_dataset_path")]
    public string? TokenizedDatasetPath { get; init; }

    /// <summary>
    /// Timestamp when the tokenized dataset archive was uploaded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenized_dataset_uploaded_at")]
    public DateTimeOffset? TokenizedDatasetUploadedAt { get; init; }

    /// <summary>
    /// Together model registry object ID for the final model weights (e.g. <c>ml_...</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_object_id")]
    public string? ModelObjectId { get; init; }

    /// <summary>
    /// Together model registry name for the final model weights, formatted as <c>&lt;project_slug&gt;/&lt;model_name&gt;</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_object_name")]
    public string? ModelObjectName { get; init; }

    /// <summary>
    /// Together model registry revision ID for the final model weights (e.g. <c>rv_...</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_object_revision_id")]
    public string? ModelObjectRevisionId { get; init; }

    /// <summary>
    /// Together model registry object ID for the final adapter weights on LoRA jobs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adapter_object_id")]
    public string? AdapterObjectId { get; init; }

    /// <summary>
    /// Together model registry name for the final adapter weights on LoRA jobs, formatted as <c>&lt;project_slug&gt;/&lt;model_name&gt;-adapter</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adapter_object_name")]
    public string? AdapterObjectName { get; init; }

    /// <summary>
    /// Together model registry revision ID for the final adapter weights on LoRA jobs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adapter_object_revision_id")]
    public string? AdapterObjectRevisionId { get; init; }

    /// <summary>
    /// ID of the user who created the fine-tune job.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trainingfile_numlines")]
    public int? TrainingfileNumlines { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trainingfile_size")]
    public int? TrainingfileSize { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("started_at")]
    public DateTimeOffset? StartedAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("n_epochs")]
    public int? NEpochs { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("n_checkpoints")]
    public int? NCheckpoints { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("n_evals")]
    public int? NEvals { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("batch_size")]
    public BatchSize1? BatchSize { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("learning_rate")]
    public double? LearningRate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lr_scheduler")]
    public LrScheduler? LrScheduler { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warmup_ratio")]
    public double? WarmupRatio { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_grad_norm")]
    public double? MaxGradNorm { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weight_decay")]
    public double? WeightDecay { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eval_steps")]
    public int? EvalSteps { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("train_on_inputs")]
    public TrainOnInputs1? TrainOnInputs { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("training_method")]
    public TrainingMethod1? TrainingMethod { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("training_type")]
    public TrainingType? TrainingType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("multimodal_params")]
    public MultimodalParams? MultimodalParams { get; init; }

    [JsonPropertyName("status")]
    public required FinetuneJobStatus Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("job_id")]
    public string? JobId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("events")]
    public IReadOnlyList<FineTuneEvent>? Events { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token_count")]
    public int? TokenCount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("param_count")]
    public int? ParamCount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_price")]
    public int? TotalPrice { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("epochs_completed")]
    public int? EpochsCompleted { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("queue_depth")]
    public int? QueueDepth { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wandb_project_name")]
    public string? WandbProjectName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wandb_url")]
    public string? WandbUrl { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("from_checkpoint")]
    public string? FromCheckpoint { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("from_hf_model")]
    public string? FromHfModel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hf_model_revision")]
    public string? HfModelRevision { get; init; }

    /// <summary>
    /// Progress information for a fine-tuning job
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("progress")]
    public FineTuneProgress? Progress { get; init; }

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
    /// Best validation loss observed, corresponding to early_stopping_best_step. Null if no improving evaluation was recorded (for example, a non-finite first evaluation).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("early_stopping_best_metric")]
    public double? EarlyStoppingBestMetric { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
