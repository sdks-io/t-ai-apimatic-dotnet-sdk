using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Capacity weight assigned to one deployment in an endpoint's live traffic split.
/// </summary>
public record DeTrafficSplitEntry
{
    /// <summary>
    /// ID of a deployment under the endpoint that can receive live traffic.
    /// </summary>
    [JsonPropertyName("deploymentId")]
    public required string DeploymentId { get; init; }

    /// <summary>
    /// Non-negative, finite weight applied to each ready replica. A deployment's
    /// effective routing capacity is <c>weight * readyReplicas</c>, and requests are
    /// distributed in proportion to that capacity. Set to <c>0</c> to remove the
    /// deployment from the live traffic split.
    /// </summary>
    [JsonPropertyName("weight")]
    public required double Weight { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
