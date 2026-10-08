using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// Result of a weights-sync operation
/// </summary>
public record RlWeightsSyncResult
{
    /// <summary>
    /// Policy version now available for sampling, or queued to become available for deferred sync modes. Comparable to <c>policy_segments[].version</c> on sample results.
    /// </summary>
    [JsonPropertyName("weights_version")]
    public required WeightsVersion WeightsVersion { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
