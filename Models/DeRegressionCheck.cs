using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Regression criteria that fail when the target regresses against the source beyond a limit.
/// </summary>
public record DeRegressionCheck
{
    /// <summary>
    /// Finite maximum allowed regression percentage, greater than or equal to 0. Omitting this value is read as 0. A value of 0 is the strictest budget; any regression fails, and exactly-at-budget passes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxRegressionPercent")]
    public double? MaxRegressionPercent { get; init; }

    /// <summary>
    /// Required direction that indicates whether higher or lower metric values are worse.
    /// </summary>
    [JsonPropertyName("direction")]
    public required Direction1 Direction { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
