using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// A base model supported by the RL service. Per-mode configs are present only when the model supports that mode.
/// </summary>
public record RlSupportedModel
{
    /// <summary>
    /// Base model identifier to pass as base_model when creating a model resource
    /// </summary>
    [JsonPropertyName("base_model")]
    public required string BaseModel { get; init; }

    /// <summary>
    /// GPU type used when model-resource creation omits gpu_type.
    /// </summary>
    [JsonPropertyName("default_gpu_type")]
    public required DefaultGpuType DefaultGpuType { get; init; }

    /// <summary>
    /// Validated GPU configurations available for this base model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("compute_configs")]
    public IReadOnlyList<RlSupportedModelComputeConfig>? ComputeConfigs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
