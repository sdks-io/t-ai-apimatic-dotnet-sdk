using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Compliance regimes required by a deployment placement policy.
/// </summary>
public record DeCompliancePolicy
{
    /// <summary>
    /// Restrict placement to HIPAA-attested clusters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hipaa")]
    public bool? Hipaa { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
