using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Result of an inference checkpoint operation
/// </summary>
public record RlInferenceCheckpointResult
{
    /// <summary>
    /// Registered model name for downloading the checkpoint
    /// </summary>
    [JsonPropertyName("model_name")]
    public required string ModelName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
