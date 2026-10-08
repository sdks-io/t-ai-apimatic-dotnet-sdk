using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record InputAudio1
{
    /// <summary>
    /// The base64 encoded audio data
    /// </summary>
    [JsonPropertyName("data")]
    public required string Data { get; init; }

    /// <summary>
    /// The format of the audio data
    /// </summary>
    [JsonPropertyName("format")]
    public string Format { get; } = "wav";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
