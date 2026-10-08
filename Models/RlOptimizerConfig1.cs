using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Optimizer configuration for this resource.
/// </summary>
public record RlOptimizerConfig1
{
    /// <summary>
    /// Use the Adam optimizer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adam")]
    public object? Adam { get; init; }

    /// <summary>
    /// Use the Muon optimizer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("muon")]
    public RlMuonConfig2? Muon { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
