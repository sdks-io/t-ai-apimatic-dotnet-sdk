using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record FinetuneTruncatedList
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<FinetuneResponseTruncated> Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
