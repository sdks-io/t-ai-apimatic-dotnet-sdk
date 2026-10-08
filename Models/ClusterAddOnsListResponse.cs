using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ClusterAddOnsListResponse
{
    [JsonPropertyName("add_ons")]
    public required IReadOnlyList<AddOnInfo> AddOns { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
