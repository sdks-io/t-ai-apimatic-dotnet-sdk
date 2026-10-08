using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Default response format. Used to generate text responses.
/// </summary>
public record Text
{
    /// <summary>
    /// The type of response format being defined. Always <c>text</c>.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "text";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
