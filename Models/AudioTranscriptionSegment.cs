using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record AudioTranscriptionSegment
{
    /// <summary>
    /// Unique identifier for the segment
    /// </summary>
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    /// <summary>
    /// Start time of the segment in seconds
    /// </summary>
    [JsonPropertyName("start")]
    public required double Start { get; init; }

    /// <summary>
    /// End time of the segment in seconds
    /// </summary>
    [JsonPropertyName("end")]
    public required double End { get; init; }

    /// <summary>
    /// The text content of the segment
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
