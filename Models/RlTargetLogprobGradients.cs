using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Per-token gradients of the loss with respect to target log-probabilities
/// </summary>
public record RlTargetLogprobGradients
{
    /// <summary>
    /// Float array of per-token gradients (d loss / d log p)
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<double> Data { get; init; }

    /// <summary>
    /// Data type of the float array
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dtype")]
    public RlDType1? Dtype { get; init; } = RlDType1.DTypeUnspecified;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
