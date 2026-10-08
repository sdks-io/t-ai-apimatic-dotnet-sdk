using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Validation.Attributes;

namespace TogetherApIs.Models;

/// <summary>
/// Parameters for DPPO loss. Both probability-change limits must be in [0, 1] and default to 0.15.
/// </summary>
public record RlDppoLossParams
{
    /// <summary>
    /// Probability-change limit for tokens with negative advantage. Measured in probability space, not log-probability space. Must be in [0, 1]. Defaults to 0.15.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delta_low")]
    [Minimum(0.0)]
    [Maximum(1.0)]
    public double? DeltaLow { get; init; } = 0.15d;

    /// <summary>
    /// Probability-change limit for tokens with positive advantage. Measured in probability space, not log-probability space. Must be in [0, 1]. Defaults to 0.15.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delta_high")]
    [Minimum(0.0)]
    [Maximum(1.0)]
    public double? DeltaHigh { get; init; } = 0.15d;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
