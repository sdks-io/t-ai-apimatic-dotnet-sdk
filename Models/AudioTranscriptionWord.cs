using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record AudioTranscriptionWord
{
    /// <summary>
    /// The word
    /// </summary>
    [JsonPropertyName("word")]
    public required string Word { get; init; }

    /// <summary>
    /// Start time of the word in seconds
    /// </summary>
    [JsonPropertyName("start")]
    public required double Start { get; init; }

    /// <summary>
    /// End time of the word in seconds
    /// </summary>
    [JsonPropertyName("end")]
    public required double End { get; init; }

    /// <summary>
    /// The speaker id for the word (only when diarize is enabled)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("speaker_id")]
    public string? SpeakerId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
