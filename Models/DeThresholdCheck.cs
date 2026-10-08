using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Threshold criteria that fail when the target metric violates the configured bound.
/// </summary>
public record DeThresholdCheck
{
    /// <summary>
    /// Finite threshold value. Interpreted in the metric's unit:
    /// router_error_rate is a ratio in [0, 1], router_latency is
    /// milliseconds, and inflight_requests is in-flight requests per ready
    /// replica averaged over the rule window. Thresholds that no
    /// achievable value could pass, or that every achievable value passes,
    /// are rejected at create.
    /// <para>
    /// Omitting this value is read as 0. Set 0 explicitly for the strictest
    /// threshold: nothing at all is tolerated.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public double? Value { get; init; }

    /// <summary>
    /// Required comparison operator applied to the target metric value.
    /// </summary>
    [JsonPropertyName("operator")]
    public required Operator1 Operator { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
