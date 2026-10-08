using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Request to provision a standalone model resource
/// </summary>
public record RlCreateModelResourcesRequest
{
    /// <summary>
    /// Base model to provision the resource for, selected from /rl/supported-models
    /// </summary>
    [JsonPropertyName("base_model")]
    public required string BaseModel { get; init; }

    /// <summary>
    /// Model in this project's model registry whose weights the resource trains in place of the base model's own. It must be a full-weight model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_weights_ref")]
    [MaxLength(256)]
    [RegularExpression("^together://ml_[A-Za-z0-9]+(@rv_[A-Za-z0-9]+)?$")]
    public string? BaseWeightsRef { get; init; }

    /// <summary>
    /// Compute layout to provision.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("compute_config")]
    public RlComputeConfigCreateRequest1? ComputeConfig { get; init; }

    /// <summary>
    /// Whether the resource hosts LoRA sessions or a single full-weight session
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lora_enabled")]
    public bool? LoraEnabled { get; init; } = true;

    /// <summary>
    /// Optimizer configuration for this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("optimizer_config")]
    public RlOptimizerConfig1? OptimizerConfig { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
