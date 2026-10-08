using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record BillingUsageLineItem
{
    /// <summary>
    /// Metronome product name (e.g. 'Serverless Inference - Input Tokens').
    /// </summary>
    [JsonPropertyName("product_name")]
    public required string ProductName { get; init; }

    /// <summary>
    /// Total usage for the window in the product's native unit (GPU-hours, tokens, ...) as a decimal string.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required string Quantity { get; init; }

    /// <summary>
    /// Per-unit price in USD as a decimal string.
    /// </summary>
    [JsonPropertyName("unit_price")]
    public required string UnitPrice { get; init; }

    /// <summary>
    /// Total cost for this line item in USD as a decimal string.
    /// </summary>
    [JsonPropertyName("cost")]
    public required string Cost { get; init; }

    /// <summary>
    /// Rate-determining dimensions (varies by product). Passthrough from Metronome pricing group values.
    /// </summary>
    [JsonPropertyName("pricing_dimensions")]
    public required IReadOnlyDictionary<string, string> PricingDimensions { get; init; }

    /// <summary>
    /// Resource identifiers for attribution, varying by product.
    /// </summary>
    [JsonPropertyName("attributes")]
    public required IReadOnlyDictionary<string, string> Attributes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
