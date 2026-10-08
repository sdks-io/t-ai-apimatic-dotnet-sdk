using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record FineTuneEvent
{
    /// <summary>
    /// The object type, which is always <c>fine-tune-event</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "fine-tune-event";

    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("level")]
    public FinetuneEventLevels? Level { get; init; }

    [JsonPropertyName("message")]
    public required string Message { get; init; }

    [JsonPropertyName("type")]
    public required FinetuneEventType Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("param_count")]
    public int? ParamCount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token_count")]
    public int? TokenCount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_steps")]
    public int? TotalSteps { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wandb_url")]
    public string? WandbUrl { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("step")]
    public int? Step { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkpoint_path")]
    public string? CheckpointPath { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_path")]
    public string? ModelPath { get; init; }

    /// <summary>
    /// Storage path for the tokenized dataset archive associated with this event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenized_dataset_path")]
    public string? TokenizedDatasetPath { get; init; }

    /// <summary>
    /// For early_stopped events, the selected best-checkpoint step when a finite best metric exists. If early_stopping_best_metric_value is null, this is the halt step.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("early_stopping_best_step")]
    public int? EarlyStoppingBestStep { get; init; }

    /// <summary>
    /// For early_stopped events, the best validation loss observed. Null if no improving evaluation was recorded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("early_stopping_best_metric_value")]
    public double? EarlyStoppingBestMetricValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
