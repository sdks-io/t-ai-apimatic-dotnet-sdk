using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// A checkpoint available for a fine-tuning job.
/// </summary>
public record FineTuneCheckpoint
{
    /// <summary>
    /// Step represented by the checkpoint; final checkpoints use the shipped model step.
    /// </summary>
    [JsonPropertyName("step")]
    public required int Step { get; init; }

    /// <summary>
    /// Timestamp when the checkpoint was created.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    /// <summary>
    /// Storage path for the checkpoint artifact.
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; init; }

    /// <summary>
    /// Display label for the checkpoint, including the final or intermediate checkpoint step.
    /// </summary>
    [JsonPropertyName("checkpoint_type")]
    public required string CheckpointType { get; init; }

    /// <summary>
    /// Canonical artifact selector for checkpoint download requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkpoint")]
    public Checkpoint? Checkpoint { get; init; }

    /// <summary>
    /// Together model registry object ID for the checkpoint artifact (e.g. <c>ml_...</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_id")]
    public string? ObjectId { get; init; }

    /// <summary>
    /// Together model registry name for the checkpoint artifact, formatted as <c>&lt;project_slug&gt;/&lt;checkpoint_name&gt;</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_name")]
    public string? ObjectName { get; init; }

    /// <summary>
    /// Together model registry revision ID for the checkpoint artifact (e.g. <c>rv_...</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_revision_id")]
    public string? ObjectRevisionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
