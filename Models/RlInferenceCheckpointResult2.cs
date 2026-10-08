using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Result on success
/// </summary>
public record RlInferenceCheckpointResult2
{
    /// <summary>
    /// Registered model name for downloading the checkpoint
    /// </summary>
    [JsonPropertyName("model_name")]
    public required string ModelName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
