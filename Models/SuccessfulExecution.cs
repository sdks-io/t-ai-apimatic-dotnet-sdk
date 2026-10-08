using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record SuccessfulExecution
{
    [JsonPropertyName("errors")]
    public required string? Errors { get; init; }

    [JsonPropertyName("data")]
    public required Data2 Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
