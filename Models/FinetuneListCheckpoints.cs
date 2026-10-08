using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record FinetuneListCheckpoints
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<FineTuneCheckpoint> Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
