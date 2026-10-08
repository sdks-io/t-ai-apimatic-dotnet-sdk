using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Per-step Muon optimizer overrides
/// </summary>
public record RlMuonParams
{
    /// <summary>
    /// Learning rate for this Muon optimizer step.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("learning_rate")]
    public double? LearningRate { get; init; }

    /// <summary>
    /// Momentum coefficient
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("momentum")]
    public double? Momentum { get; init; } = 0.95d;

    /// <summary>
    /// Number of Newton-Schulz iterations
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("newton_schulz_steps")]
    public int? NewtonSchulzSteps { get; init; } = 5;

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

    /// <summary>
    /// Per-step Adam optimizer overrides for the Adam-tuned parameters in a Muon-tuned optimizer session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adam")]
    public RlAdamParams1? Adam { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
