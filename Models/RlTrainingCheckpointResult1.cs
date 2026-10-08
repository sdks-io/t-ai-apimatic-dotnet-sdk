using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Result on success
/// </summary>
public record RlTrainingCheckpointResult1
{
    /// <summary>
    /// ID of the saved training checkpoint (use for resume via Start)
    /// </summary>
    [JsonPropertyName("checkpoint_id")]
    public required string CheckpointId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
