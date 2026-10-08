using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Allocated GPU resources that training sessions attach to
/// </summary>
public record RlModelResources
{
    /// <summary>
    /// Unique identifier for the model resource
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Lifecycle status of the model resource
    /// </summary>
    [JsonPropertyName("status")]
    public required RlModelResourcesStatus1 Status { get; init; }

    /// <summary>
    /// Structured detail for the model resource's current error. Set when the resource is in an error state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public RlModelResourcesError2? Error { get; init; }

    /// <summary>
    /// Base model the resource is provisioned for
    /// </summary>
    [JsonPropertyName("base_model")]
    public required string BaseModel { get; init; }

    /// <summary>
    /// Model-registry model whose weights the resource trains in place of the base model's own, pinned to the revision resolved when the resource was created. Absent when the resource trains the base model's own weights.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_weights_ref")]
    public string? BaseWeightsRef { get; init; }

    /// <summary>
    /// Compute layout provisioned for the resource.
    /// </summary>
    [JsonPropertyName("compute_config")]
    public required RlComputeConfig1 ComputeConfig { get; init; }

    /// <summary>
    /// Whether the resource hosts LoRA sessions or a full-weight session
    /// </summary>
    [JsonPropertyName("lora_enabled")]
    public required bool LoraEnabled { get; init; }

    /// <summary>
    /// Timestamp when the model resource was created
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Timestamp when the model resource was last updated
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// Optimizer configuration for this resource.
    /// </summary>
    [JsonPropertyName("optimizer_config")]
    public required RlOptimizerConfig1 OptimizerConfig { get; init; }

    /// <summary>
    /// ID of the user who created the model resource
    /// </summary>
    [JsonPropertyName("created_by")]
    public required string CreatedBy { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
