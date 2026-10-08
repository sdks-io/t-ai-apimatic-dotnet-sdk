using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Region where an instance type is offered.
/// </summary>
public record DeRegion
{
    /// <summary>
    /// Region name where an instance type is offered.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Best-effort replica headroom across every cluster in this region, attested or not. Read <c>compliance</c> for compliance-scoped headroom. Omitted when unavailable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headroom")]
    public DeHeadroom? Headroom { get; init; }

    /// <summary>
    /// Compliance regimes certified in this region with best-effort headroom for each policy. Entries can overlap; read the entry matching the deployment policy instead of summing entries.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("compliance")]
    public IReadOnlyList<DeComplianceAvailability>? Compliance { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
