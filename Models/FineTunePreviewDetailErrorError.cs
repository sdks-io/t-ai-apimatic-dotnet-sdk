using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Error response with a detail field returned by the preview tokenization service.
/// </summary>
public record FineTunePreviewDetailErrorError
{
    /// <summary>
    /// Human-readable error detail.
    /// </summary>
    [JsonPropertyName("detail")]
    public required string Detail { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
