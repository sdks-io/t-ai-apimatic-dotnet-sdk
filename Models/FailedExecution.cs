using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

public record FailedExecution
{
    [JsonPropertyName("data")]
    public required string? Data { get; init; }

    [JsonPropertyName("errors")]
    public required IReadOnlyList<Error11> Errors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
