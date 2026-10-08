using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record Voice
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Voice name to be used for audio inference.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
