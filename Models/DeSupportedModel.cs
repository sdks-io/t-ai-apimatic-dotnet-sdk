using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Curated catalog entry for a platform-supported model.
/// </summary>
public record DeSupportedModel
{
    /// <summary>
    /// Unique ID of the deployable Together-hosted base model.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Catalog-controlled HF model ID used for inference.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Catalog-controlled human-readable model name.
    /// </summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; init; }

    /// <summary>
    /// Human-readable model description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Input modalities supported by the model.
    /// </summary>
    [JsonPropertyName("inputModalities")]
    public required IReadOnlyList<InputModality> InputModalities { get; init; }

    /// <summary>
    /// Output modalities produced by the model.
    /// </summary>
    [JsonPropertyName("outputModalities")]
    public required IReadOnlyList<OutputModality> OutputModalities { get; init; }

    /// <summary>
    /// Product surfaces where the model is offered.
    /// </summary>
    [JsonPropertyName("products")]
    public required IReadOnlyList<Product> Products { get; init; }

    /// <summary>
    /// Advanced features exposed by the model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("features")]
    public IReadOnlyList<Feature>? Features { get; init; }

    /// <summary>
    /// High-level tasks the model supports.
    /// </summary>
    [JsonPropertyName("capabilities")]
    public required IReadOnlyList<Capability> Capabilities { get; init; }

    /// <summary>
    /// Model architecture from the underlying weights metadata.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("architecture")]
    public string? Architecture { get; init; }

    /// <summary>
    /// Maximum context length from the underlying weights metadata.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contextLength")]
    public string? ContextLength { get; init; }

    /// <summary>
    /// Organization or publisher associated with the model.
    /// </summary>
    [JsonPropertyName("publisher")]
    public required string Publisher { get; init; }

    /// <summary>
    /// Catalog recommendation status for the model.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status1 Status { get; init; }

    /// <summary>
    /// Searchable catalog tags for the model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    public IReadOnlyList<string>? Tags { get; init; }

    /// <summary>
    /// Preferred input format for the model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; init; }

    /// <summary>
    /// Preferred output format for the model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; init; }

    /// <summary>
    /// Serverless endpoint name for inference, if available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serverlessEndpoint")]
    public string? ServerlessEndpoint { get; init; }

    /// <summary>
    /// Serverless pricing in USD per one million tokens, if available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricing")]
    public DeSupportedModelPricing2? Pricing { get; init; }

    /// <summary>
    /// Model family identifier for related catalog entries.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("familyId")]
    public string? FamilyId { get; init; }

    /// <summary>
    /// UI-facing model type badge, such as chat, language, code, image, embedding, rerank, moderation, audio, video, or transcribe.
    /// </summary>
    [JsonPropertyName("displayType")]
    public required string DisplayType { get; init; }

    /// <summary>
    /// Bare model ID for the architecture's base model; empty when no base model is linked.
    /// </summary>
    [JsonPropertyName("baseModelId")]
    public required string BaseModelId { get; init; }

    /// <summary>
    /// Resource name for the base model as <c>projects/{projectId}/models/{modelId}</c>; empty when unresolved.
    /// </summary>
    [JsonPropertyName("baseModel")]
    public required string BaseModel { get; init; }

    /// <summary>
    /// Certified deployment profiles available for the model.
    /// </summary>
    [JsonPropertyName("deploymentProfiles")]
    public required IReadOnlyList<DeSupportedModelDeploymentProfile> DeploymentProfiles { get; init; }

    /// <summary>
    /// Timestamp when the catalog entry was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Timestamp when the catalog entry was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTimeOffset UpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
