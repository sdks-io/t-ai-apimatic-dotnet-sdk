using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Model parameter count and precision breakdown.
/// </summary>
public record DeModelParameters
{
    /// <summary>
    /// Total number of parameters in the model weights.
    /// </summary>
    [JsonPropertyName("total")]
    public required string Total { get; init; }

    /// <summary>
    /// Parameter counts grouped by numerical data type.
    /// </summary>
    [JsonPropertyName("byDtype")]
    public required IReadOnlyList<DeModelDTypeCount> ByDtype { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
