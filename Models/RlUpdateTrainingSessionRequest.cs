using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Fields to update on a training session
/// </summary>
public record RlUpdateTrainingSessionRequest
{
    /// <summary>
    /// Display name to update. An empty string clears the existing display name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_name")]
    [MaxLength(128)]
    public string? DisplayName { get; init; }

    /// <summary>
    /// Metadata fields to update. Omitted fields remain unchanged, and empty strings clear existing values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public RlTrainingSessionMetadata1? Metadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
