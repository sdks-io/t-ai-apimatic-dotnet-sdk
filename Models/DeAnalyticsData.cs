using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Endpoint-wide usage and performance analytics with optional time-series and per-deployment breakdowns.
/// </summary>
public record DeAnalyticsData
{
    /// <summary>
    /// ID of the endpoint summarized by these analytics.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endpointId")]
    public string? EndpointId { get; init; }

    /// <summary>
    /// Closed-open time range covered by the analytics.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeRange")]
    public DeMetricsTimeRange3? TimeRange { get; init; }

    /// <summary>
    /// Aggregated metrics over the time range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metrics")]
    public DeEndpointMetrics? Metrics { get; init; }

    /// <summary>
    /// Per-bucket metric samples, included only when <c>includeTimeSeries</c> is true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeSeries")]
    public IReadOnlyList<DeTimeSeriesDataPoint>? TimeSeries { get; init; }

    /// <summary>
    /// Per-deployment analytics.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deploymentAnalytics")]
    public IReadOnlyList<DeDeploymentAnalyticsData>? DeploymentAnalytics { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
