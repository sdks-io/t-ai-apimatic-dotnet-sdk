using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record RlCispoLossParams
{
    /// <summary>
    /// Lower bound for clipping the importance-sampling ratio.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clip_low_threshold")]
    public double? ClipLowThreshold { get; init; } = 0d;

    /// <summary>
    /// Upper bound for clipping the importance-sampling ratio.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clip_high_threshold")]
    public double? ClipHighThreshold { get; init; } = 4d;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
