using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Operational metrics aggregated across all deployments receiving traffic for an endpoint.
/// </summary>
public record DeEndpointMetrics
{
    /// <summary>
    /// The endpoint these metrics describe.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endpointId")]
    public string? EndpointId { get; init; }

    /// <summary>
    /// Time range covered by the metrics.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeRange")]
    public DeMetricsTimeRange? TimeRange { get; init; }

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

    /// <summary>
    /// Per-deployment breakdown, if the endpoint has multiple deployments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deploymentMetrics")]
    public IReadOnlyList<DeDeploymentMetrics>? DeploymentMetrics { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
