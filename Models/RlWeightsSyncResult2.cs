using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// Result on success
/// </summary>
public record RlWeightsSyncResult2
{
    /// <summary>
    /// Policy version now available for sampling, or queued to become available for deferred sync modes. Comparable to <c>policy_segments[].version</c> on sample results.
    /// </summary>
    [JsonPropertyName("weights_version")]
    public required WeightsVersion WeightsVersion { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
