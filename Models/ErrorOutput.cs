using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Errors and exceptions that occurred. If this output type is present, your code did not execute successfully.
/// </summary>
public record ErrorOutput
{
    [JsonPropertyName("data")]
    public required string Data { get; init; }

    [JsonPropertyName("type")]
    public string Type { get; } = "error";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
