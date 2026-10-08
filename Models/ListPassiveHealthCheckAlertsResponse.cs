using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Response returned when listing passive health check alerts.
/// </summary>
public record ListPassiveHealthCheckAlertsResponse
{
    /// <summary>
    /// Alerts on the current page, ordered by the request sort order.
    /// </summary>
    [JsonPropertyName("alerts")]
    public required IReadOnlyList<PassiveHealthCheckAlert> Alerts { get; init; }

    /// <summary>
    /// Opaque token for the next page. Empty means there are no more pages.
    /// </summary>
    [JsonPropertyName("next_page_token")]
    public required string NextPageToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
