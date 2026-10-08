using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record AudioTranscriptionSpeakerSegment
{
    /// <summary>
    /// The speaker identifier
    /// </summary>
    [JsonPropertyName("speaker_id")]
    public required string SpeakerId { get; init; }

    /// <summary>
    /// Start time of the speaker segment in seconds
    /// </summary>
    [JsonPropertyName("start")]
    public required double Start { get; init; }

    /// <summary>
    /// End time of the speaker segment in seconds
    /// </summary>
    [JsonPropertyName("end")]
    public required double End { get; init; }

    /// <summary>
    /// Array of words spoken by this speaker in this segment
    /// </summary>
    [JsonPropertyName("words")]
    public required IReadOnlyList<AudioTranscriptionWord> Words { get; init; }

    /// <summary>
    /// The full text spoken by this speaker in this segment
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    /// <summary>
    /// Unique identifier for the speaker segment
    /// </summary>
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
