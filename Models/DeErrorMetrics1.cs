using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Error rate and counts by error type.
/// </summary>
public record DeErrorMetrics1
{
    /// <summary>
    /// Percentage in [0, 100].
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorRate")]
    public double? ErrorRate { get; init; }

    /// <summary>
    /// Counts of errors keyed by error type (e.g. HTTP status code or error kind).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errorsByType")]
    public IReadOnlyDictionary<string, string>? ErrorsByType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
