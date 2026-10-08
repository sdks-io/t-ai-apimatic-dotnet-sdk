using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Response containing a list of models and their available voices.
/// </summary>
public record ListVoicesResponse
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<ModelVoices> Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
