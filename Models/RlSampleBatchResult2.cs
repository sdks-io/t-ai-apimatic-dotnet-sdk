using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Result on success
/// </summary>
public record RlSampleBatchResult2
{
    /// <summary>
    /// One result per model input
    /// </summary>
    [JsonPropertyName("results")]
    public required IReadOnlyList<RlSampleResult> Results { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
