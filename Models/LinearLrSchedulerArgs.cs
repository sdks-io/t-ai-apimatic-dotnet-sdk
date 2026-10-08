using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record LinearLrSchedulerArgs
{
    /// <summary>
    /// The ratio of the final learning rate to the peak learning rate
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_lr_ratio")]
    public double? MinLrRatio { get; init; } = 0d;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
