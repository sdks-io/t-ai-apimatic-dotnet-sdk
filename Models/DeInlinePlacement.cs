using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Inline placement parameters expanded into scheduling rules by the server.
/// </summary>
public record DeInlinePlacement
{
    /// <summary>
    /// Regions where the deployment is allowed to run. Multiple regions allow best-effort replica spreading.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("regions")]
    public IReadOnlyList<string>? Regions { get; init; }

    /// <summary>
    /// How strictly the regions list is enforced.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("constraint")]
    public Constraint? Constraint { get; init; }

    /// <summary>
    /// Compliance regimes required for clusters that run the deployment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("compliancePolicy")]
    public DeCompliancePolicy? CompliancePolicy { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
