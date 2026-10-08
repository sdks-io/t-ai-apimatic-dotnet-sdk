using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// LoRA adapter configuration. Present only for sessions running on a LoRA-enabled model resource.
/// </summary>
public record RlLoraConfig1
{
    /// <summary>
    /// Rank of the LoRA adapter
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rank")]
    public int? Rank { get; init; } = 32;

    /// <summary>
    /// Alpha of the LoRA adapter
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alpha")]
    public int? Alpha { get; init; } = 64;

    /// <summary>
    /// Dropout of the LoRA adapter
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dropout")]
    public double? Dropout { get; init; } = 0d;

    /// <summary>
    /// Random seed for initializing LoRA adapter weights. Ignored when LoRA is disabled or the session resumes from a checkpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seed")]
    public Seed1? Seed { get; init; }

    /// <summary>
    /// Whether to also train a LoRA adapter on the output head. Defaults to true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("train_unembed")]
    public bool? TrainUnembed { get; init; } = true;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
