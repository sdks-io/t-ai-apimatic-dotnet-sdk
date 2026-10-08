using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Adaptive sticky-key sampling that throttles toward a target QPS.
/// </summary>
public record DeShadowExperimentAdaptiveKeyBasedSampling
{
    /// <summary>
    /// Required per-gateway-replica target QPS for adaptive sampling.
    /// </summary>
    [JsonPropertyName("targetQps")]
    public required double TargetQps { get; init; }

    /// <summary>
    /// Required request-body field used as the sticky sampling key.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    /// <summary>
    /// Optional sliding window for QPS observation. Defaults to 60s and must not be negative.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("window")]
    [RegularExpression("^-?(?:0|[1-9][0-9]{0,11})(?:\\.[0-9]{1,9})?s$")]
    public string? Window { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
