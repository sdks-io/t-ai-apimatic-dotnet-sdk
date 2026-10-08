using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Represents a model with its available voices.
/// </summary>
public record ModelVoices
{
    /// <summary>
    /// Model name.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// List of available voices for the model.
    /// </summary>
    [JsonPropertyName("voices")]
    public required IReadOnlyList<Voice> Voices { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
