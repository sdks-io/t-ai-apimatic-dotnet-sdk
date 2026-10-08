using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Compliance-specific regional availability for one instance type policy.
/// </summary>
public record DeComplianceAvailability
{
    /// <summary>
    /// Compliance regimes certified by the clusters counted in this entry.
    /// </summary>
    [JsonPropertyName("policy")]
    public required DeCompliancePolicy Policy { get; init; }

    /// <summary>
    /// Best-effort replica headroom on clusters certified for at least this policy.
    /// </summary>
    [JsonPropertyName("headroom")]
    public required DeHeadroom Headroom { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
