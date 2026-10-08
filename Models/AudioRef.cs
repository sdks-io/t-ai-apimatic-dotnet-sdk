using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record AudioRef
{
    /// <summary>
    /// URL of the audio.
    /// </summary>
    [JsonPropertyName("audio")]
    public required string Audio { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
