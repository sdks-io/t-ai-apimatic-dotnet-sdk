using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Usage and performance analytics for one deployment under an endpoint.
/// </summary>
public record DeDeploymentAnalyticsData
{
    /// <summary>
    /// ID of the deployment summarized by these analytics.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deploymentId")]
    public string? DeploymentId { get; init; }

    /// <summary>
    /// ID of the deployment's parent endpoint.
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
    /// Aggregate operational metrics for the deployment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metrics")]
    public DeDeploymentMetrics1? Metrics { get; init; }

    /// <summary>
    /// Per-bucket metric samples for the deployment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeSeries")]
    public IReadOnlyList<DeTimeSeriesDataPoint>? TimeSeries { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
