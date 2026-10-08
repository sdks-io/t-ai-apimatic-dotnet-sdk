using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record CreateSecretRequest
{
    /// <summary>
    /// Description is an optional human-readable description of the secret's purpose (max 500 characters)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(500)]
    public string? Description { get; init; }

    /// <summary>
    /// Name is the unique identifier for the secret. Can contain alphanumeric characters, underscores, hyphens, forward slashes, and periods (1-100 characters)
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(100, MinimumLength = 1)]
    public required string Name { get; init; }

    /// <summary>
    /// ProjectID is ignored - the project is automatically determined from your authentication
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("project_id")]
    public string? ProjectId { get; init; }

    /// <summary>
    /// Value is the sensitive data to store securely (e.g., API keys, passwords, tokens). Encrypted at rest.
    /// </summary>
    [JsonPropertyName("value")]
    [MinLength(1)]
    public required string Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
