using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Request to clear pending jobs for a model.
/// </summary>
public record QueueClearRequest
{
    /// <summary>
    /// Model identifier whose pending jobs should be canceled
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
