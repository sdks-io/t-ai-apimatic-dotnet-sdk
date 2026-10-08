using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Details for a DmesgXidError passive health check alert.
/// </summary>
public record XidDetail
{
    /// <summary>
    /// Xid events observed during the alert window.
    /// </summary>
    [JsonPropertyName("events")]
    public required IReadOnlyList<XidEvent> Events { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
