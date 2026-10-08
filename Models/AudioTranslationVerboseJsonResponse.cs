using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record AudioTranslationVerboseJsonResponse
{
    /// <summary>
    /// The target language of the translation
    /// </summary>
    [JsonPropertyName("language")]
    public required string Language { get; init; }

    /// <summary>
    /// The duration of the audio in seconds
    /// </summary>
    [JsonPropertyName("duration")]
    public required double Duration { get; init; }

    /// <summary>
    /// The translated text
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    /// <summary>
    /// Array of translation segments
    /// </summary>
    [JsonPropertyName("segments")]
    public required IReadOnlyList<AudioTranscriptionSegment> Segments { get; init; }

    /// <summary>
    /// Array of translation words (only when timestamp_granularities includes 'word')
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("words")]
    public IReadOnlyList<AudioTranscriptionWord>? Words { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
