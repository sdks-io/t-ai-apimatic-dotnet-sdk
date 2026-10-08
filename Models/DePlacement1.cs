using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record DePlacement1
{
    /// <summary>
    /// UID of a saved placement profile.
    /// </summary>
    [JsonPropertyName("profile")]
    public required string Profile { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
