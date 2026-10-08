using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Response containing publicly discoverable endpoints and pagination metadata.
/// </summary>
public record DeListPublicEndpointsResponse
{
    /// <summary>
    /// Endpoints visible through the public catalog.
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<DePublicEndpoint> Data { get; init; }

    /// <summary>
    /// Cursor for the next page. Null if there are no more results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next_cursor")]
    public string? NextCursor { get; init; }

    /// <summary>
    /// Object type. Always <c>list</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "list";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
