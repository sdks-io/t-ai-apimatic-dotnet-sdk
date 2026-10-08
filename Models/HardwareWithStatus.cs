using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Hardware configuration details with optional availability status
/// </summary>
public record HardwareWithStatus
{
    /// <summary>
    /// The object type, which is always <c>hardware</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "hardware";

    /// <summary>
    /// Unique identifier for the hardware configuration
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Pricing details for using an endpoint
    /// </summary>
    [JsonPropertyName("pricing")]
    public required EndpointPricing Pricing { get; init; }

    /// <summary>
    /// Detailed specifications of a hardware configuration
    /// </summary>
    [JsonPropertyName("specs")]
    public required HardwareSpec Specs { get; init; }

    /// <summary>
    /// Indicates the current availability status of a hardware configuration
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("availability")]
    public HardwareAvailability? Availability { get; init; }

    /// <summary>
    /// Timestamp of when the hardware status was last updated
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required DateTimeOffset UpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
