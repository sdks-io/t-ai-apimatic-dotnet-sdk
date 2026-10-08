using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record JobsInfoSuccessResponse
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<JobInfoSuccessResponse> Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
