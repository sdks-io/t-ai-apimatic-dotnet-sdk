using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ImageLora
{
    /// <summary>
    /// The URL of the LoRA to apply (e.g. https://huggingface.co/strangerzonehf/Flux-Midjourney-Mix2-LoRA).
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; init; }

    /// <summary>
    /// The strength of the LoRA's influence. Most LoRA's recommend a value of 1.
    /// </summary>
    [JsonPropertyName("scale")]
    public required double Scale { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
