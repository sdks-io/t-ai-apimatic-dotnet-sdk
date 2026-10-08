using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record CompletionToken
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonPropertyName("logprob")]
    public required double Logprob { get; init; }

    [JsonPropertyName("special")]
    public required bool Special { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
