using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Custom or derived model registered in a project and backed by versioned weight files.
/// </summary>
public record DeModel
{
    /// <summary>
    /// Unique model identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// ID of the project that owns the model.
    /// </summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    /// <summary>
    /// ID of the organization that owns the model's project.
    /// </summary>
    [JsonPropertyName("organizationId")]
    public required string OrganizationId { get; init; }

    /// <summary>
    /// Project-qualified model name in the form <c>&lt;project_slug&gt;/&lt;model_name&gt;</c>. Create and update requests may use the bare or qualified form.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Human-readable description of the model and its intended use.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Architecture, size, precision, and speculative-decoding metadata derived from the model files.
    /// </summary>
    [JsonPropertyName("weights")]
    public required DeModelWeights2 Weights { get; init; }

    /// <summary>
    /// ID of the supported or custom base model from which this model was derived.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("baseModelId")]
    public string? BaseModelId { get; init; }

    /// <summary>
    /// Resource name of the base model, using <c>projects/{baseProject}/models/{baseModelId}</c>; empty when the model has no base.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("baseModel")]
    public string? BaseModel { get; init; }

    /// <summary>
    /// Who can discover the model. <c>VISIBILITY_PRIVATE</c> restricts it to the project; <c>VISIBILITY_INTERNAL</c> shares it with the organization.
    /// </summary>
    [JsonPropertyName("visibility")]
    public Visibility3 Visibility { get; init; } = Visibility3.VisibilityPrivate;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
