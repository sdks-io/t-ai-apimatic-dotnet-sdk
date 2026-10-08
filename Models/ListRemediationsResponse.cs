using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// ListRemediationsResponse is the response for ListRemediations.
/// </summary>
public record ListRemediationsResponse
{
    /// <summary>
    /// The list of remediations.
    /// </summary>
    [JsonPropertyName("remediations")]
    public required IReadOnlyList<Remediation> Remediations { get; init; }

    /// <summary>
    /// Token for the next page.
    /// </summary>
    [JsonPropertyName("next_page_token")]
    public required string NextPageToken { get; init; }

    /// <summary>
    /// Indicates if there are more results available.
    /// </summary>
    [JsonPropertyName("has_next")]
    public required bool HasNext { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
