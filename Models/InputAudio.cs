using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record InputAudio
{
    [JsonPropertyName("type")]
    public string Type { get; } = "input_audio";

    [JsonPropertyName("input_audio")]
    public required InputAudio1 InputAudioValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
