using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Total parameter count and breakdown by numerical data type.
/// </summary>
public record DeModelParameters2
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
