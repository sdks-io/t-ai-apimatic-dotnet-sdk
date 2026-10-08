using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// Pre-tokenized text content for this input chunk.
/// </summary>
public record RlEncodedTextChunk2
{
    /// <summary>
    /// Pre-tokenized text input
    /// </summary>
    [JsonPropertyName("tokens")]
    public required IReadOnlyList<Token> Tokens { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
