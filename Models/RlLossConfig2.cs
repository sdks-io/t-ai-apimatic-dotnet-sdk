using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Loss function configuration
/// </summary>
public record RlLossConfig2
{
    /// <summary>
    /// Type of loss function to use
    /// </summary>
    [JsonPropertyName("type")]
    public RlLossType2 Type { get; init; } = RlLossType2.LossTypeUnspecified;

    /// <summary>
    /// Cross-entropy loss parameters (currently empty).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cross_entropy_params")]
    public object? CrossEntropyParams { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("grpo_params")]
    public RlGrpoLossParams? GrpoParams { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ppo_params")]
    public RlPpoLossParams? PpoParams { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cispo_params")]
    public RlCispoLossParams? CispoParams { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dro_params")]
    public RlDroLossParams? DroParams { get; init; }

    /// <summary>
    /// Parameters for DPPO loss. Only valid when <c>type</c> is <c>LOSS_TYPE_DPPO</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dppo_params")]
    public RlDppoLossParams2? DppoParams { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
