using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record AudioTranscriptionVerboseJsonResponse
{
    /// <summary>
    /// The language of the audio
    /// </summary>
    [JsonPropertyName("language")]
    public required string Language { get; init; }

    /// <summary>
    /// The duration of the audio in seconds
    /// </summary>
    [JsonPropertyName("duration")]
    public required double Duration { get; init; }

    /// <summary>
    /// The transcribed text
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    /// <summary>
    /// Array of transcription segments
    /// </summary>
    [JsonPropertyName("segments")]
    public required IReadOnlyList<AudioTranscriptionSegment> Segments { get; init; }

    /// <summary>
    /// Array of transcription words (only when timestamp_granularities includes 'word')
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("words")]
    public IReadOnlyList<AudioTranscriptionWord>? Words { get; init; }

    /// <summary>
    /// Array of transcription speaker segments (only when diarize is enabled)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("speaker_segments")]
    public IReadOnlyList<AudioTranscriptionSpeakerSegment>? SpeakerSegments { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
