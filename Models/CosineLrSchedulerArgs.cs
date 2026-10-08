using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record CosineLrSchedulerArgs
{
    /// <summary>
    /// The ratio of the final learning rate to the peak learning rate
    /// </summary>
    [JsonPropertyName("min_lr_ratio")]
    public double MinLrRatio { get; init; } = 0d;

    /// <summary>
    /// Number or fraction of cycles for the cosine learning rate scheduler
    /// </summary>
    [JsonPropertyName("num_cycles")]
    public double NumCycles { get; init; } = 0.5d;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
