using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record RlPpoLossParams
{
    /// <summary>
    /// Lower absolute bound for the importance ratio in the clipped surrogate. Must be &lt;= 1.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clip_low_threshold")]
    public double? ClipLowThreshold { get; init; } = 0.8d;

    /// <summary>
    /// Upper absolute bound for the importance ratio in the clipped surrogate. Must be &gt;= 1.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clip_high_threshold")]
    public double? ClipHighThreshold { get; init; } = 1.2d;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
