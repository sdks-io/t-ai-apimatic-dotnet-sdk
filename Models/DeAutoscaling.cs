using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Autoscaling configuration for a deployment.
/// </summary>
public record DeAutoscaling
{
    /// <summary>
    /// Minimum number of replicas. Omit on update to preserve the current value. Set both <c>minReplicas</c> and <c>maxReplicas</c> to <c>0</c> to stop the deployment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minReplicas")]
    public int? MinReplicas { get; init; }

    /// <summary>
    /// Maximum number of replicas. Defaults to <c>minReplicas</c>; omitting it on update preserves the current value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxReplicas")]
    public int? MaxReplicas { get; init; }

    /// <summary>
    /// Time a lower replica recommendation must remain stable before scaling down. Defaults to <c>5m</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaleDownWindow")]
    [RegularExpression("^-?(?:0|[1-9][0-9]{0,11})(?:\\.[0-9]{1,9})?s$")]
    public string? ScaleDownWindow { get; init; }

    /// <summary>
    /// Stabilization window before scaling up.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaleUpWindow")]
    [RegularExpression("^-?(?:0|[1-9][0-9]{0,11})(?:\\.[0-9]{1,9})?s$")]
    public string? ScaleUpWindow { get; init; }

    /// <summary>
    /// Idle period after which the deployment automatically stops and releases its replicas.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaleToZeroWindow")]
    [RegularExpression("^-?(?:0|[1-9][0-9]{0,11})(?:\\.[0-9]{1,9})?s$")]
    public string? ScaleToZeroWindow { get; init; }

    /// <summary>
    /// Metrics and targets that drive replica recommendations. When omitted, the platform uses concurrent in-flight requests per replica.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scalingMetrics")]
    public IReadOnlyList<DeScalingMetric>? ScalingMetrics { get; init; }

    /// <summary>
    /// Rate limits applied when scaling up. Stabilization remains controlled by <c>scaleUpWindow</c>.
    /// Omitted fields are preserved on update; a non-empty policy list replaces the previous list.
    /// To clear policies or reset the selector, explicitly mask that leaf field. Empty lists in
    /// parent-only updates are treated as omitted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaleUp")]
    public DeScalingRules? ScaleUp { get; init; }

    /// <summary>
    /// Rate limits applied when scaling down. Stabilization remains controlled by <c>scaleDownWindow</c>.
    /// Omitted fields are preserved on update; a non-empty policy list replaces the previous list.
    /// To clear policies or reset the selector, explicitly mask that leaf field. Empty lists in
    /// parent-only updates are treated as omitted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaleDown")]
    public DeScalingRules? ScaleDown { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
