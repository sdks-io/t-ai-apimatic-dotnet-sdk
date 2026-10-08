using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Auxiliary metadata associated with a training session
/// </summary>
public record RlTrainingSessionMetadata
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
