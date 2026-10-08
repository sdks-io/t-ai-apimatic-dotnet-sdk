using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ChatCompletionUserMessageContentMultimodal
{
    [JsonPropertyName("type")]
    public string Type { get; } = "text";

    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
