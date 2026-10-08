using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record FullTrainingType
{
    [JsonPropertyName("type")]
    public string Type { get; } = "Full";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
