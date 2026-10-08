using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// A validated hardware configuration available for an RL base model.
/// </summary>
public record RlSupportedModelComputeConfig
{
    /// <summary>
    /// GPU type this configuration provisions.
    /// </summary>
    [JsonPropertyName("gpu_type")]
    public required GpuType2 GpuType { get; init; }

    /// <summary>
    /// Training config for this GPU type. Set when the model supports at least one training mode on this GPU type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trainer_config")]
    public RlModelTrainerConfig1? TrainerConfig { get; init; }

    /// <summary>
    /// Inference config for this GPU type. Set when the model can be provisioned with generator replicas on this GPU type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generator_config")]
    public RlModelGeneratorConfig1? GeneratorConfig { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
