using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Principal whose permission to call the endpoint should be revoked.
/// </summary>
public record DeRevokeEndpointAccessRequest
{
    /// <summary>
    /// Type of principal to revoke. Supported values are <c>project</c>, <c>api_key</c>, and <c>organization</c>.
    /// </summary>
    [JsonPropertyName("principalType")]
    public required string PrincipalType { get; init; }

    /// <summary>
    /// Identifier of the principal whose access is being revoked.
    /// </summary>
    [JsonPropertyName("principalId")]
    public required string PrincipalId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
