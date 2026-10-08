using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Advanced configuration for the Muon optimizer.
/// </summary>
public record RlMuonConfig
{
    /// <summary>
    /// Scaling strategy for the Muon optimizer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaling_strategy")]
    public RlMuonScalingStrategy2? ScalingStrategy { get; init; } = RlMuonScalingStrategy2.MuonScalingStrategyUnspecified;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
