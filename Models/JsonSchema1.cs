using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

/// <summary>
/// Structured Outputs configuration options, including a JSON Schema.
/// </summary>
public record JsonSchema1
{
    /// <summary>
    /// A description of what the response format is for, used by the model to
    /// determine how to respond in the format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The name of the response format. Must be a-z, A-Z, 0-9, or contain
    /// underscores and dashes, with a maximum length of 64.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The schema for the response format, described as a JSON Schema object.
    /// Learn how to build JSON schemas <see href="https://json-schema.org/">here</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schema")]
    public object? Schema { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("strict")]
    public Strict? Strict { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
