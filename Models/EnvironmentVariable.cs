using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record EnvironmentVariable
{
    /// <summary>
    /// Name is the environment variable name (e.g., "DATABASE_URL"). Must start with a letter or underscore, followed by letters, numbers, or underscores
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Value is the plain text value for the environment variable. Use this for non-sensitive values. Either Value or ValueFromSecret must be set, but not both
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public string? Value { get; init; }

    /// <summary>
    /// ValueFromSecret references a secret by name or ID to use as the value. Use this for sensitive values like API keys or passwords. Either Value or ValueFromSecret must be set, but not both
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value_from_secret")]
    public string? ValueFromSecret { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
