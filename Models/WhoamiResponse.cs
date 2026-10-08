using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record WhoamiResponse
{
    /// <summary>
    /// The ID of the API key that authenticated the request.
    /// </summary>
    [JsonPropertyName("api_key_id")]
    public required string ApiKeyId { get; init; }

    /// <summary>
    /// The ID of the project the API key is scoped to.
    /// </summary>
    [JsonPropertyName("project_id")]
    public required string ProjectId { get; init; }

    /// <summary>
    /// Human-readable name of the project.
    /// </summary>
    [JsonPropertyName("project_name")]
    public required string ProjectName { get; init; }

    /// <summary>
    /// DNS-friendly project identifier. Used with an endpoint slug as <c>&lt;project_slug&gt;/&lt;endpoint_slug&gt;</c> to form the <c>model</c> value in dedicated endpoint inference calls.
    /// </summary>
    [JsonPropertyName("project_slug")]
    public required string ProjectSlug { get; init; }

    /// <summary>
    /// The ID of the organization that owns the project.
    /// </summary>
    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; init; }

    /// <summary>
    /// Human-readable name of the organization.
    /// </summary>
    [JsonPropertyName("organization_name")]
    public required string OrganizationName { get; init; }

    /// <summary>
    /// The ID of the authenticated user, if available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
