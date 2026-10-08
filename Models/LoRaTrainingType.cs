using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// LoRA training configuration for a fine-tuning job.
/// </summary>
public record LoRaTrainingType
{
    /// <summary>
    /// Identifies this request as a LoRA fine-tune.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "Lora";

    /// <summary>
    /// Rank of the LoRA adapter matrices.
    /// </summary>
    [JsonPropertyName("lora_r")]
    public required int LoraR { get; init; }

    /// <summary>
    /// Scaling factor applied to the LoRA adapter weights.
    /// </summary>
    [JsonPropertyName("lora_alpha")]
    public required int LoraAlpha { get; init; }

    /// <summary>
    /// Dropout probability applied to LoRA adapter inputs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lora_dropout")]
    public double? LoraDropout { get; init; } = 0d;

    /// <summary>
    /// Comma-separated LoRA target modules. Use <c>all-linear</c> for model defaults; MoE expert modules (<c>w_up</c>, <c>w_gate</c>, <c>w_down</c>) can be combined with attention modules on compatible models. Fine-tuning jobs that target expert modules produce adapter-only output unless the selected model supports merged expert LoRA output.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lora_trainable_modules")]
    public string? LoraTrainableModules { get; init; } = "all-linear";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
