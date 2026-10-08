using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Mutable description and traffic allocation for an A/B experiment.
/// </summary>
public record DeUpdateAbExperimentRequest
{
    /// <summary>
    /// Updated free-form description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Complete replacement member set. Requires two to 20 deployments, exactly one control, and percentages that add up to 100.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("members")]
    public IReadOnlyList<DeAbExperimentMember>? Members { get; init; }

    /// <summary>
    /// Opaque version tag from a prior read for optimistic concurrency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("etag")]
    public string? Etag { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
