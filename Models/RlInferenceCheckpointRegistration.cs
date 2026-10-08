using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Model registration details for an inference checkpoint
/// </summary>
public record RlInferenceCheckpointRegistration
{
    /// <summary>
    /// Registered model name for downloading the checkpoint
    /// </summary>
    [JsonPropertyName("model_name")]
    public required string ModelName { get; init; }

    /// <summary>
    /// Timestamp when the model was registered
    /// </summary>
    [JsonPropertyName("registered_at")]
    public required DateTimeOffset RegisteredAt { get; init; }

    /// <summary>
    /// Together model registry object ID for the model checkpoint (e.g. <c>ml_...</c>), set on full-weight training sessions
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_object_id")]
    public string? ModelObjectId { get; init; }

    /// <summary>
    /// Together model registry revision ID for the model checkpoint (e.g. <c>rv_...</c>)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_object_revision_id")]
    public string? ModelObjectRevisionId { get; init; }

    /// <summary>
    /// Together model registry object ID for the adapter checkpoint (e.g. <c>ml_...</c>), set on LoRA training sessions
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adapter_object_id")]
    public string? AdapterObjectId { get; init; }

    /// <summary>
    /// Together model registry revision ID for the adapter checkpoint (e.g. <c>rv_...</c>)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adapter_object_revision_id")]
    public string? AdapterObjectRevisionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
