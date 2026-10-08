using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// A single chunk of model input content.
/// </summary>
public record RlModelInputChunk
{
    /// <summary>
    /// Pre-tokenized text content for this input chunk.
    /// </summary>
    [JsonPropertyName("encoded_text")]
    public required RlEncodedTextChunk2 EncodedText { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
