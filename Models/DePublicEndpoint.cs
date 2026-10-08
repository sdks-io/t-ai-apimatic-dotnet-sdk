using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Endpoint metadata exposed through the public endpoint catalog.
/// </summary>
public record DePublicEndpoint
{
    /// <summary>
    /// Unique endpoint identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// ID of the project that owns the endpoint.
    /// </summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    /// <summary>
    /// Endpoint string in the form <c>&lt;project_slug&gt;/&lt;endpoint_name&gt;</c>, passed as the <c>model</c> parameter when calling inference.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Timestamp when the endpoint was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Timestamp when the endpoint was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// Public visibility of the endpoint.
    /// </summary>
    [JsonPropertyName("visibility")]
    public string Visibility { get; } = "VISIBILITY_PUBLIC";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
