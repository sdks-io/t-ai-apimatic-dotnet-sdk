using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record RlModelResourcesEstimateCostResponse
{
    /// <summary>
    /// Estimated on-demand price per hour in the currency's major unit.
    /// </summary>
    [JsonPropertyName("price_per_hour")]
    public required double PricePerHour { get; init; }

    /// <summary>
    /// ISO 4217 currency code.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
