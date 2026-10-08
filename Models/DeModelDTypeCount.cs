using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Number of model parameters stored in one numerical data type.
/// </summary>
public record DeModelDTypeCount
{
    /// <summary>
    /// Numerical data type, such as <c>float16</c>, <c>bfloat16</c>, or <c>int8</c>.
    /// </summary>
    [JsonPropertyName("dtype")]
    public required string Dtype { get; init; }

    /// <summary>
    /// Number of model parameters stored with this data type.
    /// </summary>
    [JsonPropertyName("count")]
    public required string Count { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
