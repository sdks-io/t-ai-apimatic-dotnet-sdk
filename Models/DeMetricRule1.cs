using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record DeMetricRule1
{
    /// <summary>
    /// Required catalogue key for the metric to gate on. <c>serving_latency</c> is retired.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public Name1? Name { get; init; }

    /// <summary>
    /// Aggregation used for the metric. Optional for router_error_rate and inflight_requests; omitted values default to METRIC_STAT_TYPE_AVG. Required for router_latency, where AVG or PERCENTILE may be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stat")]
    public Stat1? Stat { get; init; }

    /// <summary>
    /// Percentile value, such as 99. Set only when stat is METRIC_STAT_TYPE_PERCENTILE.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentile")]
    public int? Percentile { get; init; }

    /// <summary>
    /// Threshold evaluation criteria. Mutually exclusive with regressionCheck.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thresholdCheck")]
    public DeThresholdCheck? ThresholdCheck { get; init; }

    /// <summary>
    /// Regression evaluation criteria. Mutually exclusive with thresholdCheck.
    /// </summary>
    [JsonPropertyName("regressionCheck")]
    public required DeRegressionCheck RegressionCheck { get; init; }

    /// <summary>
    /// Optional query window for the metric. Defaults to the step soak duration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("window")]
    [RegularExpression("^-?(?:0|[1-9][0-9]{0,11})(?:\\.[0-9]{1,9})?s$")]
    public string? Window { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
