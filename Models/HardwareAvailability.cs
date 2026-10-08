using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Indicates the current availability status of a hardware configuration
/// </summary>
public record HardwareAvailability
{
    /// <summary>
    /// The availability status of the hardware configuration
    /// </summary>
    [JsonPropertyName("status")]
    public required Status5 Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
