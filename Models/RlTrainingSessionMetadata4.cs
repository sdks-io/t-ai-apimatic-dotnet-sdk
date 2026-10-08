using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Optional auxiliary metadata to associate with the training session
/// </summary>
public record RlTrainingSessionMetadata4
{
    /// <summary>
    /// Weights &amp; Biases details associated with the training session
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wandb")]
    public RlWandbMetadata2? Wandb { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
