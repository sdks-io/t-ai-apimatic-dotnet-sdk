using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

public record FineTunesEstimatePriceRequest
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
    /// Name of the base model to run fine-tune job on
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model")]
    public string? Model { get; init; }

    /// <summary>
    /// Number of complete passes through the training dataset (higher values may improve results but increase cost and risk of overfitting)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("n_epochs")]
    public int? NEpochs { get; init; } = 1;

    /// <summary>
    /// Number of evaluations to be run on a given validation set during training
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("n_evals")]
    public int? NEvals { get; init; } = 0;

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
    public TrainingType3? TrainingType { get; init; }

    /// <summary>
    /// The checkpoint identifier to continue training from a previous fine-tuning job. Format is <c>{$JOB_ID}</c> or <c>{$OUTPUT_MODEL_NAME}</c> or <c>{$JOB_ID}:{$STEP}</c> or <c>{$OUTPUT_MODEL_NAME}:{$STEP}</c>. The step value is optional; without it, uses the final checkpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("from_checkpoint")]
    public string? FromCheckpoint { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
