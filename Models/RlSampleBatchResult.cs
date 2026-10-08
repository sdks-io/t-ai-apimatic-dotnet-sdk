using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Batched result of a sample operation
/// </summary>
public record RlSampleBatchResult
{
    /// <summary>
    /// One result per model input
    /// </summary>
    [JsonPropertyName("results")]
    public required IReadOnlyList<RlSampleResult> Results { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
