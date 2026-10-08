using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Metadata fields to update. Omitted fields remain unchanged, and empty strings clear existing values.
/// </summary>
public record RlTrainingSessionMetadata1
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
