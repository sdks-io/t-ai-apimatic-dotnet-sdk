using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Training config for this GPU type. Set when the model supports at least one training mode on this GPU type.
/// </summary>
public record RlModelTrainerConfig1
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
