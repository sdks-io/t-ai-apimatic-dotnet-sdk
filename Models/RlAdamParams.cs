using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Per-step Adam optimizer overrides.
/// </summary>
public record RlAdamParams
{
    /// <summary>
    /// Learning rate for the Adam-tuned parameters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("learning_rate")]
    public double? LearningRate { get; init; }

    /// <summary>
    /// Exponential decay rate for the first-moment estimate
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("beta1")]
    public double? Beta1 { get; init; } = 0.9d;

    /// <summary>
    /// Exponential decay rate for the second-moment estimate
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("beta2")]
    public double? Beta2 { get; init; } = 0.95d;

    /// <summary>
    /// Epsilon for numerical stability
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eps")]
    public double? Eps { get; init; } = 1E-08d;

    /// <summary>
    /// Weight decay coefficient
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weight_decay")]
    public double? WeightDecay { get; init; } = 0d;

    /// <summary>
    /// Maximum gradient norm for this step, gradients across all model parameters are clipped to this value. Set to 0 to disable gradient clipping. When unset, gradients are clipped to the session default (1.0).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("grad_clip_norm")]
    public double? GradClipNorm { get; init; } = 1d;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
