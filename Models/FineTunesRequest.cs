using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Validation.Attributes;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

public record FineTunesRequest
{
    /// <summary>
    /// File-ID of a training file uploaded to the Together API
    /// </summary>
    [JsonPropertyName("training_file")]
    public required string TrainingFile { get; init; }

    /// <summary>
    /// File-ID of a validation file uploaded to the Together API
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validation_file")]
    public string? ValidationFile { get; init; }

    /// <summary>
    /// Whether to use sequence packing for training. This flag has no effect if the training data is in Parquet format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("packing")]
    public bool? Packing { get; init; } = true;

    /// <summary>
    /// Maximum sequence length to use for training. If not specified, the maximum allowed for the model and training method will be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_seq_length")]
    public int? MaxSeqLength { get; init; }

    /// <summary>
    /// Name of the base model to run fine-tune job on
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Number of complete passes through the training dataset (higher values may improve results but increase cost and risk of overfitting)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("n_epochs")]
    public int? NEpochs { get; init; } = 1;

    /// <summary>
    /// Number of intermediate model versions saved during training for evaluation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("n_checkpoints")]
    [Maximum(10)]
    public int? NCheckpoints { get; init; } = 1;

    /// <summary>
    /// Number of evaluations to be run on a given validation set during training
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("n_evals")]
    public int? NEvals { get; init; } = 0;

    /// <summary>
    /// Number of training examples processed together (larger batches use more memory but may train faster). Defaults to "max". We use training optimizations like packing, so the effective batch size may be different than the value you set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("batch_size")]
    public BatchSize11? BatchSize { get; init; }

    /// <summary>
    /// Number of steps to accumulate gradients before performing a weight update. If omitted or set to 0, the model default is used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gradient_accumulation_steps")]
    [Minimum(0)]
    public int? GradientAccumulationSteps { get; init; }

    /// <summary>
    /// Controls how quickly the model adapts to new information (too high may cause instability, too low may slow convergence)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("learning_rate")]
    public double? LearningRate { get; init; } = 1E-05d;

    /// <summary>
    /// The learning rate scheduler to use. It specifies how the learning rate is adjusted during training.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lr_scheduler")]
    public LrScheduler2? LrScheduler { get; init; }

    /// <summary>
    /// The percent of steps at the start of training to linearly increase the learning rate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warmup_ratio")]
    public double? WarmupRatio { get; init; } = 0d;

    /// <summary>
    /// Max gradient norm to be used for gradient clipping. Set to 0 to disable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_grad_norm")]
    public double? MaxGradNorm { get; init; } = 1d;

    /// <summary>
    /// Weight decay. Regularization parameter for the optimizer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weight_decay")]
    public double? WeightDecay { get; init; } = 0d;

    /// <summary>
    /// Random seed for reproducible training. When set, the same seed produces the same run (e.g. data shuffle, init). If omitted or null, the server applies its default seed (e.g. 42).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("random_seed")]
    public int? RandomSeed { get; init; }

    /// <summary>
    /// Whether to stop training early when validation loss stops improving. Requires a validation_file, and n_evals must be at least early_stopping_patience + early_stopping_warmup_evals + 1 so a plateau can be detected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("early_stopping_enabled")]
    public bool? EarlyStoppingEnabled { get; init; } = false;

    /// <summary>
    /// Number of consecutive evaluations with no improvement in validation loss to allow before stopping. Only applies when early_stopping_enabled is true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("early_stopping_patience")]
    [Minimum(1)]
    public int? EarlyStoppingPatience { get; init; } = 2;

    /// <summary>
    /// Minimum decrease in validation loss for an evaluation to count as an improvement. Larger values treat small gains as non-improvements, causing training to stop sooner. Only applies when early_stopping_enabled is true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("early_stopping_min_delta")]
    [Minimum(0.0)]
    public double? EarlyStoppingMinDelta { get; init; } = 0d;

    /// <summary>
    /// Number of initial evaluations excluded from the early-stopping decision. These still establish the baseline validation loss but do not count toward patience. Set to 0 to disable warmup; if omitted, defaults to 1. Only applies when early_stopping_enabled is true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("early_stopping_warmup_evals")]
    [Minimum(0)]
    public int? EarlyStoppingWarmupEvals { get; init; } = 1;

    /// <summary>
    /// Suffix to add to your fine-tuned model name. Must be at most 64 characters long.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suffix")]
    [MaxLength(64)]
    public string? Suffix { get; init; }

    /// <summary>
    /// Integration key for tracking experiments and model metrics on W&amp;B platform
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wandb_api_key")]
    public string? WandbApiKey { get; init; }

    /// <summary>
    /// The base URL of a dedicated Weights &amp; Biases instance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wandb_base_url")]
    public string? WandbBaseUrl { get; init; }

    /// <summary>
    /// The Weights &amp; Biases project for your run. If not specified, uses <c>together</c> as the project name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wandb_project_name")]
    public string? WandbProjectName { get; init; }

    /// <summary>
    /// The Weights &amp; Biases name for your run.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wandb_name")]
    public string? WandbName { get; init; }

    /// <summary>
    /// The Weights &amp; Biases entity for your run.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wandb_entity")]
    public string? WandbEntity { get; init; }

    /// <summary>
    /// Whether to mask user messages in conversational data or prompts in instruction data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("train_on_inputs")]
    public TrainOnInputs11? TrainOnInputs { get; init; }

    /// <summary>
    /// The training method to use. 'sft' for Supervised Fine-Tuning or 'dpo' for Direct Preference Optimization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("training_method")]
    public TrainingMethod111? TrainingMethod { get; init; }

    /// <summary>
    /// The training type to use. Defaults to LoRA if not provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("training_type")]
    public TrainingType2? TrainingType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("multimodal_params")]
    public MultimodalParams? MultimodalParams { get; init; }

    /// <summary>
    /// The checkpoint identifier to continue training from a previous fine-tuning job. Format is <c>{$JOB_ID}</c> or <c>{$OUTPUT_MODEL_NAME}</c> or <c>{$JOB_ID}:{$STEP}</c> or <c>{$OUTPUT_MODEL_NAME}:{$STEP}</c>. The step value is optional; without it, uses the final checkpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("from_checkpoint")]
    public string? FromCheckpoint { get; init; }

    /// <summary>
    /// The Hugging Face Hub repo to start training from. Should be as close as possible to the base model (specified by the <c>model</c> argument) in terms of architecture and size.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("from_hf_model")]
    public string? FromHfModel { get; init; }

    /// <summary>
    /// The revision of the Hugging Face Hub model to continue training from. E.g., hf_model_revision=main (default, used if the argument is not provided) or hf_model_revision='607a30d783dfa663caf39e06633721c8d4cfcd7e' (specific commit).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hf_model_revision")]
    public string? HfModelRevision { get; init; }

    /// <summary>
    /// The API token for the Hugging Face Hub.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hf_api_token")]
    public string? HfApiToken { get; init; }

    /// <summary>
    /// The name of the Hugging Face repository to upload the fine-tuned model to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hf_output_repo_name")]
    public string? HfOutputRepoName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
