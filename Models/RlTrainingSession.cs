using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// A training session and its current state
/// </summary>
public record RlTrainingSession
{
    /// <summary>
    /// ID of the training session
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Display name used to identify the training session
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_name")]
    [MaxLength(128)]
    public string? DisplayName { get; init; }

    /// <summary>
    /// Auxiliary metadata associated with the training session
    /// </summary>
    [JsonPropertyName("metadata")]
    public required RlTrainingSessionMetadata3 Metadata { get; init; }

    /// <summary>
    /// Status of the training session
    /// </summary>
    [JsonPropertyName("status")]
    public RlTrainingSessionStatus Status { get; init; } = RlTrainingSessionStatus.TrainingSessionStatusUnspecified;

    /// <summary>
    /// Structured detail for the training session's current error. Set when the session is in an error state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public RlTrainingSessionError1? Error { get; init; }

    /// <summary>
    /// List of saved inference checkpoints for this session
    /// </summary>
    [JsonPropertyName("inference_checkpoints")]
    public required IReadOnlyList<RlInferenceCheckpoint> InferenceCheckpoints { get; init; }

    /// <summary>
    /// List of saved training checkpoints for this session
    /// </summary>
    [JsonPropertyName("training_checkpoints")]
    public required IReadOnlyList<RlTrainingCheckpoint> TrainingCheckpoints { get; init; }

    /// <summary>
    /// Checkpoint ID this session was resumed from
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resume_from_checkpoint_id")]
    public string? ResumeFromCheckpointId { get; init; }

    /// <summary>
    /// Current training step
    /// </summary>
    [JsonPropertyName("step")]
    public required Step3 Step { get; init; }

    /// <summary>
    /// Timestamp when the training session was created
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Timestamp when the training session was last updated
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// LoRA adapter configuration. Present only for sessions running on a LoRA-enabled model resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lora_config")]
    public RlLoraConfig1? LoraConfig { get; init; }

    /// <summary>
    /// ID of the model resource used by this training session.
    /// </summary>
    [JsonPropertyName("model_resources_id")]
    public required string ModelResourcesId { get; init; }

    /// <summary>
    /// Base model the session trains, taken from the model resource it is attached to
    /// </summary>
    [JsonPropertyName("base_model")]
    public required string BaseModel { get; init; }

    /// <summary>
    /// ID of the user who created the training session
    /// </summary>
    [JsonPropertyName("created_by")]
    public required string CreatedBy { get; init; }

    /// <summary>
    /// Session-scoped policy and weight versions for this session
    /// </summary>
    [JsonPropertyName("policy_state")]
    public required RlSessionPolicyState1 PolicyState { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
