using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Validation.Attributes;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Replica rate-limit policy applied over a trailing window.
/// </summary>
public record DeScalingPolicy
{
    /// <summary>
    /// Whether <c>value</c> is a replica count or a percentage of the replica count at the start
    /// of the trailing period. Scaling events within that period count against the allowance;
    /// percentages are rounded to whole replicas.
    /// </summary>
    [JsonPropertyName("type")]
    public required Type1 Type { get; init; }

    /// <summary>
    /// Positive replica count or percentage used as the rate-limit amount.
    /// </summary>
    [JsonPropertyName("value")]
    [Minimum(1)]
    [Maximum(2147483647)]
    public required int Value { get; init; }

    /// <summary>
    /// Trailing rate-limit window in seconds, from 1 to 1800.
    /// </summary>
    [JsonPropertyName("periodSeconds")]
    [Minimum(1)]
    [Maximum(1800)]
    public required int PeriodSeconds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
