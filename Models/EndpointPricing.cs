using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Pricing details for using an endpoint
/// </summary>
public record EndpointPricing
{
    /// <summary>
    /// Cost per minute of endpoint uptime in cents
    /// </summary>
    [JsonPropertyName("cents_per_minute")]
    public required double CentsPerMinute { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
