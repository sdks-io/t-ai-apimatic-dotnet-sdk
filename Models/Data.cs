using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record Data
{
    [JsonPropertyName("job_id")]
    public required string JobId { get; init; }

    [JsonPropertyName("model_name")]
    public required string ModelName { get; init; }

    [JsonPropertyName("model_id")]
    public required string ModelId { get; init; }

    [JsonPropertyName("model_source")]
    public required string ModelSource { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
