using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Request for registering a custom model or adapter in a project.
/// </summary>
public record DeCreateModelRequest
{
    /// <summary>
    /// Name for the custom model. May be bare or qualified as <c>&lt;project_slug&gt;/&lt;model_name&gt;</c>; a supplied project slug must match the project in the request path.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Volume type to create. Use <c>model</c> or <c>adapter</c>; plural <c>models</c> and <c>adapters</c> are also accepted.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Human-readable description of the model and its intended use.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// ID of the supported base model from which this model was derived.
    /// </summary>
    [JsonPropertyName("baseModelId")]
    public required string BaseModelId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
