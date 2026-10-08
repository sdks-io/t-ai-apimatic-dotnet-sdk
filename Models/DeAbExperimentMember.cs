using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Deployment participating in an A/B experiment.
/// </summary>
public record DeAbExperimentMember
{
    /// <summary>
    /// Deployment under the parent endpoint.
    /// </summary>
    [JsonPropertyName("deploymentId")]
    public required string DeploymentId { get; init; }

    /// <summary>
    /// Role of this deployment within the A/B experiment.
    /// </summary>
    [JsonPropertyName("role")]
    public required Role Role { get; init; }

    /// <summary>
    /// Integer traffic percent in [1, 100]. Percentages across all members must sum to 100.
    /// </summary>
    [JsonPropertyName("percent")]
    public required int Percent { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
