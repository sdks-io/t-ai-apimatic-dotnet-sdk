using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Observed metric result enriched with rollout rule criteria and the rule's recorded verdict. Unmeasured rules are synthesized with verdict METRIC_VERDICT_UNAVAILABLE and no source or target value.
/// </summary>
public record DeMetricResult
{
    /// <summary>
    /// Metric name as exported to the observability backend.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Aggregation used for the metric.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stat")]
    public Stat? Stat { get; init; }

    /// <summary>
    /// Percentile value, such as 99. Set only when stat is METRIC_STAT_TYPE_PERCENTILE.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentile")]
    public int? Percentile { get; init; }

    /// <summary>
    /// Evaluation form used by the metric rule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("check")]
    public Check? Check { get; init; }

    /// <summary>
    /// Observed source baseline. Set only for regression checks with a recorded observation; a 0 reading serializes explicitly.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceValue")]
    public double? SourceValue { get; init; }

    /// <summary>
    /// Observed target value. Set when the gate recorded an observation; absent on synthesized unavailable results. A 0 reading serializes explicitly.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; init; }

    /// <summary>
    /// Threshold criteria used when check is METRIC_CHECK_TYPE_THRESHOLD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threshold")]
    public double? Threshold { get; init; }

    /// <summary>
    /// Threshold comparison operator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("operator")]
    public Operator? Operator { get; init; }

    /// <summary>
    /// Regression percentage limit used when check is METRIC_CHECK_TYPE_REGRESSION.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxRegressionPercent")]
    public double? MaxRegressionPercent { get; init; }

    /// <summary>
    /// Direction that indicates whether higher or lower values are worse.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("direction")]
    public Direction? Direction { get; init; }

    /// <summary>
    /// Rule decision recorded by the metric gate. Absent when no decision was recorded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verdict")]
    public Verdict? Verdict { get; init; }

    /// <summary>
    /// Rule-specific failure text. Set only when verdict is METRIC_VERDICT_BREACHED and the gate recorded one.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
