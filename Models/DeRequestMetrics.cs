using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Request counts, rate, and status-code distribution over a time range.
/// </summary>
public record DeRequestMetrics
{
    /// <summary>
    /// Total requests received during the time range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalRequests")]
    public string? TotalRequests { get; init; }

    /// <summary>
    /// Requests completed successfully during the time range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("successfulRequests")]
    public string? SuccessfulRequests { get; init; }

    /// <summary>
    /// Requests that failed during the time range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failedRequests")]
    public string? FailedRequests { get; init; }

    /// <summary>
    /// Average requests per second over the time range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestsPerSecond")]
    public double? RequestsPerSecond { get; init; }

    /// <summary>
    /// Request counts keyed by HTTP status code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestsByStatusCode")]
    public IReadOnlyDictionary<string, string>? RequestsByStatusCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
