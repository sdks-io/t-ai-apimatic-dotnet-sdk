using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Mutable metadata for a custom model resource.
/// </summary>
public record DeUpdateModelRequest
{
    /// <summary>
    /// Updated inference-addressable model name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Updated user-facing model description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Who can discover the model. <c>VISIBILITY_PRIVATE</c> restricts it to the project; <c>VISIBILITY_INTERNAL</c> shares it with the organization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visibility")]
    public Visibility3? Visibility { get; init; } = Visibility3.VisibilityPrivate;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
