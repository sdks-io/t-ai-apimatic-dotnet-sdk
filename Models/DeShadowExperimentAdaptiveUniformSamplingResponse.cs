using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Adaptive random sampling returned by the API.
/// </summary>
public record DeShadowExperimentAdaptiveUniformSamplingResponse
{
    /// <summary>
    /// Per-gateway-replica target QPS.
    /// </summary>
    [JsonPropertyName("targetQps")]
    public required double TargetQps { get; init; }

    /// <summary>
    /// Sliding window for QPS observation when explicitly configured.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("window")]
    [RegularExpression("^-?(?:0|[1-9][0-9]{0,11})(?:\\.[0-9]{1,9})?s$")]
    public string? Window { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
