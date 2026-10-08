using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Error response with a message field returned by the fine-tuning API layer.
/// </summary>
public record FineTunePreviewMessageErrorError
{
    /// <summary>
    /// Human-readable error message.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
