using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Revision history events for a deployment, newest first.
/// </summary>
public record RevisionEventListResponse
{
    /// <summary>
    /// Revision events, newest first.
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<RevisionEventItem> Data { get; init; }

    /// <summary>
    /// The object type, which is always <c>list</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "list";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
