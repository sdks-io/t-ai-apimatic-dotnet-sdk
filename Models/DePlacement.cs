using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record DePlacement
{
    /// <summary>
    /// Inline placement parameters evaluated at deploy time.
    /// </summary>
    [JsonPropertyName("inline")]
    public required DeInlinePlacement Inline { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
