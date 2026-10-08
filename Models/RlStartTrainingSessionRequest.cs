using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record RlStartTrainingSessionRequest
{
    /// <summary>
    /// Checkpoint ID to resume from. LoRA training checkpoints may resume on another model resource with compatible base-model weights. Full-weight training checkpoints require the original base model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resume_from_checkpoint_id")]
    public string? ResumeFromCheckpointId { get; init; }

    /// <summary>
    /// HuggingFace repo (or hf://) to resume model weights from. Accepts either a full model or a PEFT adapter directory. Mutually exclusive with resume_from_checkpoint_id.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resume_from_hf_checkpoint")]
    public string? ResumeFromHfCheckpoint { get; init; }

    /// <summary>
    /// LoRA adapter configuration for the session
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lora_config")]
    public RlLoraConfig3? LoraConfig { get; init; }

    /// <summary>
    /// ID of the model resource to use for this training session.
    /// </summary>
    [JsonPropertyName("model_resources_id")]
    public required string ModelResourcesId { get; init; }

    /// <summary>
    /// Optional display name used to identify the training session
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_name")]
    [MaxLength(128)]
    public string? DisplayName { get; init; }

    /// <summary>
    /// Optional auxiliary metadata to associate with the training session
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public RlTrainingSessionMetadata4? Metadata { get; init; }

    /// <summary>
    /// Whether to restore optimizer state and step from a training checkpoint. Omitted or true restores them; false loads weights only with a fresh optimizer and step 0. Not valid for inference or HuggingFace checkpoints, which have no optimizer state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("load_optimizer")]
    public bool? LoadOptimizer { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
