using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Project, API key, or organization allowed to call an endpoint.
/// </summary>
public record DeAccessEntry
{
    /// <summary>
    /// Principal type. Supported values are <c>project</c>, <c>api_key</c>, and <c>organization</c>.
    /// </summary>
    [JsonPropertyName("principalType")]
    public required string PrincipalType { get; init; }

    /// <summary>
    /// Identifier of the principal.
    /// </summary>
    [JsonPropertyName("principalId")]
    public required string PrincipalId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
