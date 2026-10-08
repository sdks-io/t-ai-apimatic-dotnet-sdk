using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Best-effort estimate of how many additional replicas currently fit in a region.
/// </summary>
public record DeHeadroom
{
    /// <summary>
    /// Capped count of replicas that currently fit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public int? Value { get; init; }

    /// <summary>
    /// Whether the value is exact or a lower bound.
    /// </summary>
    [JsonPropertyName("relation")]
    public required Relation Relation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
