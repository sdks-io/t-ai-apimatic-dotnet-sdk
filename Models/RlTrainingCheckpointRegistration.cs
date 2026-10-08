using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Together model registry details for a training checkpoint
/// </summary>
public record RlTrainingCheckpointRegistration
{
    /// <summary>
    /// Together model registry object ID for the training checkpoint artifact (e.g. <c>ml_...</c>)
    /// </summary>
    [JsonPropertyName("object_id")]
    public required string ObjectId { get; init; }

    /// <summary>
    /// Together model registry revision ID for the training checkpoint artifact (e.g. <c>rv_...</c>), empty when the upload reported no revision
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_revision_id")]
    public string? ObjectRevisionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
