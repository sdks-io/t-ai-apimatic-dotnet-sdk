using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Aggregate operational metrics for the deployment.
/// </summary>
public record DeDeploymentMetrics1
{
    /// <summary>
    /// ID of the deployment summarized by these metrics.
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
    /// Closed-open time range covered by the metrics.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeRange")]
    public DeMetricsTimeRange2? TimeRange { get; init; }

    /// <summary>
    /// Request counts and rates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestMetrics")]
    public DeRequestMetrics1? RequestMetrics { get; init; }

    /// <summary>
    /// Time-to-first-token, end-to-end, and inter-token latency percentiles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latencyMetrics")]
    public DeLatencyMetrics1? LatencyMetrics { get; init; }

    /// <summary>
    /// Token, request, and batching throughput.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("throughputMetrics")]
    public DeThroughputMetrics1? ThroughputMetrics { get; init; }

    /// <summary>
    /// Error rate and counts by error type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorMetrics")]
    public DeErrorMetrics1? ErrorMetrics { get; init; }

    /// <summary>
    /// Average CPU, GPU, memory, and network utilization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resourceUtilization")]
    public DeResourceUtilization1? ResourceUtilization { get; init; }

    /// <summary>
    /// Input and output token totals and averages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenMetrics")]
    public DeTokenMetrics1? TokenMetrics { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
