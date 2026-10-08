using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record UpdateSecretRequest
{
    /// <summary>
    /// Description is an optional human-readable description of the secret's purpose (max 500 characters)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(500)]
    public string? Description { get; init; }

    /// <summary>
    /// Name is the new unique identifier for the secret. Can contain alphanumeric characters, underscores, hyphens, forward slashes, and periods (1-100 characters)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [StringLength(100, MinimumLength = 1)]
    public string? Name { get; init; }

    /// <summary>
    /// ProjectID is ignored - the project is automatically determined from your authentication
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("project_id")]
    public string? ProjectId { get; init; }

    /// <summary>
    /// Value is the new sensitive data to store securely. Updating this replaces the existing secret value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    [MinLength(1)]
    public string? Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
