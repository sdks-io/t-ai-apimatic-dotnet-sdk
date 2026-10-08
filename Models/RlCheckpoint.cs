using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Metadata for a saved checkpoint
/// </summary>
public record RlCheckpoint
{
    /// <summary>
    /// Unique identifier for the checkpoint
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Training session that produced the checkpoint
    /// </summary>
    [JsonPropertyName("session_id")]
    public required string SessionId { get; init; }

    /// <summary>
    /// Base model the checkpoint was trained from
    /// </summary>
    [JsonPropertyName("base_model")]
    public required string BaseModel { get; init; }

    /// <summary>
    /// Whether this is a training checkpoint or an inference checkpoint
    /// </summary>
    [JsonPropertyName("type")]
    public required RlCheckpointType2 Type { get; init; }

    /// <summary>
    /// Training step at time of save
    /// </summary>
    [JsonPropertyName("step")]
    public required Step1 Step { get; init; }

    /// <summary>
    /// LoRA rank of the session that produced this checkpoint. Absent for full-weight sessions and for checkpoints saved before this field was recorded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lora_rank")]
    public int? LoraRank { get; init; }

    /// <summary>
    /// Timestamp when the checkpoint was created
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
