using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Training capabilities and limits for a model on one GPU type. Each sub-mode is present only when the model supports that training mode.
/// </summary>
public record RlModelTrainerConfig
{
    /// <summary>
    /// Full-weight training config. Set when the model supports full-weight training.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("full")]
    public RlModelFullModeConfig1? Full { get; init; }

    /// <summary>
    /// LoRA training config. Set when the model supports LoRA training.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lora")]
    public RlModelLoraModeConfig1? Lora { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
