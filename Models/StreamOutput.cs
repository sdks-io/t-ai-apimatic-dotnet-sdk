using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Outputs that were printed to stdout or stderr
/// </summary>
public record StreamOutput
{
    [JsonPropertyName("data")]
    public required string Data { get; init; }

    [JsonPropertyName("type")]
    public required Type9 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
