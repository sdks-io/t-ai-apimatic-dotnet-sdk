using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Request parameters for creating an endpoint.
/// </summary>
public record DeCreateEndpointRequest
{
    /// <summary>
    /// Inference-addressable endpoint name to create.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Who can discover the endpoint. <c>VISIBILITY_PRIVATE</c> restricts it to the project; <c>VISIBILITY_INTERNAL</c> shares it with the organization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visibility")]
    public Visibility? Visibility { get; init; } = Visibility.VisibilityPrivate;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
