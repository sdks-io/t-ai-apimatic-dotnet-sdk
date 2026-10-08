using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record OidcConfig
{
    /// <summary>
    /// OIDC issuer URL for authentication. For example, https://accounts.google.com
    /// </summary>
    [JsonPropertyName("issuer_url")]
    public required string IssuerUrl { get; init; }

    /// <summary>
    /// OIDC client ID for authentication.
    /// </summary>
    [JsonPropertyName("client_id")]
    public required string ClientId { get; init; }

    /// <summary>
    /// JWT claim to use as the username. For example, 'sub' or 'email'
    /// </summary>
    [JsonPropertyName("username_claim")]
    public required string UsernameClaim { get; init; }

    /// <summary>
    /// Prefix to add to the username claim to form the final username. For example, 'oidc:'
    /// </summary>
    [JsonPropertyName("username_prefix")]
    public required string UsernamePrefix { get; init; }

    /// <summary>
    /// JWT claim to use for user groups. For example, 'groups'
    /// </summary>
    [JsonPropertyName("group_claim")]
    public required string GroupClaim { get; init; }

    /// <summary>
    /// Prefix to add to the group claim to form the final group name. For example, 'oidc:'
    /// </summary>
    [JsonPropertyName("group_prefix")]
    public required string GroupPrefix { get; init; }

    /// <summary>
    /// CA certificate in PEM format to validate the OIDC issuer's TLS certificate. This field is optional but recommended if the issuer uses a private CA or self-signed certificate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ca_cert")]
    public string? CaCert { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
