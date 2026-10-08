using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Result of a save training checkpoint operation
/// </summary>
public record RlTrainingCheckpointResult
{
    /// <summary>
    /// ID of the saved training checkpoint (use for resume via Start)
    /// </summary>
    [JsonPropertyName("checkpoint_id")]
    public required string CheckpointId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
