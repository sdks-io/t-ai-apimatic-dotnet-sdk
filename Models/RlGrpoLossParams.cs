using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record RlGrpoLossParams
{
    /// <summary>
    /// Lower clip threshold for the importance-sampling ratio. The ratio is clamped to this bound; tighter clipping makes policy updates more conservative. Must be &lt;= 1.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clip_low_threshold")]
    public double? ClipLowThreshold { get; init; } = 0.8d;

    /// <summary>
    /// Upper clip threshold for the importance-sampling ratio. The ratio is clamped to this bound; tighter clipping makes policy updates more conservative. Must be &gt;= 1.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clip_high_threshold")]
    public double? ClipHighThreshold { get; init; } = 1.2d;

    /// <summary>
    /// KL penalty coefficient
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("beta")]
    public double? Beta { get; init; } = 0d;

    /// <summary>
    /// Aggregation type for loss computation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("agg_type")]
    public RlGrpoLossAggregationType2? AggType { get; init; } = RlGrpoLossAggregationType2.GrpoLossAggregationTypeUnspecified;

    /// <summary>
    /// Controls how the importance-sampling ratio is computed in GRPO loss. Defaults to token-level ratios, which is the standard GRPO behavior. Use sequence-level ratios to enable GSPO-style loss calculation instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ratio_type")]
    public RlGrpoLossRatioType2? RatioType { get; init; } = RlGrpoLossRatioType2.GrpoLossRatioTypeToken;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
