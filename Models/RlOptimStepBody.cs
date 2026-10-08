using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Request body for an optimizer step.
/// </summary>
public record RlOptimStepBody
{
    /// <summary>
    /// Adam optimizer overrides for this step.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adam_params")]
    public RlAdamParams3? AdamParams { get; init; }

    /// <summary>
    /// Muon optimizer overrides for this step.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("muon_params")]
    public RlMuonParams2? MuonParams { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
