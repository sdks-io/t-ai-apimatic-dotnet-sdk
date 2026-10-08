using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record AudioSpeechStreamChunk
{
    /// <summary>
    /// The object type, which is always <c>audio.tts.chunk</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "audio.tts.chunk";

    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// base64 encoded audio stream
    /// </summary>
    [JsonPropertyName("b64")]
    public required string B64 { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
