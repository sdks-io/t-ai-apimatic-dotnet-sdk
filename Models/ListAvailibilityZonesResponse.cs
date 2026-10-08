using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// List of unique availability zones
/// </summary>
public record ListAvailibilityZonesResponse
{
    [JsonPropertyName("avzones")]
    public required IReadOnlyList<string> Avzones { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
