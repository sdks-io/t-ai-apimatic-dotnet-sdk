using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record RlDroLossParams
{
    /// <summary>
    /// Coefficient on the quadratic log-ratio penalty. Required; there is no default.
    /// </summary>
    [JsonPropertyName("beta")]
    public required double Beta { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
