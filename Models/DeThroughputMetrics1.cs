using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Token, request, and batching throughput.
/// </summary>
public record DeThroughputMetrics1
{
    /// <summary>
    /// Average generated tokens per second.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokensPerSecond")]
    public double? TokensPerSecond { get; init; }

    /// <summary>
    /// Average completed requests per second.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestsPerSecond")]
    public double? RequestsPerSecond { get; init; }

    /// <summary>
    /// Average number of requests processed in each runtime batch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avgBatchSize")]
    public double? AvgBatchSize { get; init; }

    /// <summary>
    /// Average number of batches queued or in flight in the serving engine.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avgBatchDepth")]
    public double? AvgBatchDepth { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
