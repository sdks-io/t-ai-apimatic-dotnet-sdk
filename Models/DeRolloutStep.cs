using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// One stage of a canary rollout progression.
/// </summary>
public record DeRolloutStep
{
    /// <summary>
    /// Required percentage of traffic on the target deployment for this step.
    /// </summary>
    [JsonPropertyName("traffic")]
    public required int Traffic { get; init; }

    /// <summary>
    /// Optional explicit target replica count for this step.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicas")]
    public int? Replicas { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
