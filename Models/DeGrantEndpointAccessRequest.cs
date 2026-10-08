using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Principal that should be allowed to send inference requests to the endpoint.
/// </summary>
public record DeGrantEndpointAccessRequest
{
    /// <summary>
    /// Type of principal to grant. Supported values are <c>project</c>, <c>api_key</c>, and <c>organization</c>.
    /// </summary>
    [JsonPropertyName("principalType")]
    public required string PrincipalType { get; init; }

    /// <summary>
    /// Identifier of the principal to grant access to.
    /// </summary>
    [JsonPropertyName("principalId")]
    public required string PrincipalId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
