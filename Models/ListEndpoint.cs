using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Details about an endpoint when listed via the list endpoint
/// </summary>
public record ListEndpoint
{
    /// <summary>
    /// The object type, which is always <c>endpoint</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "endpoint";

    /// <summary>
    /// Unique identifier for the endpoint
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// System name for the endpoint
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The model deployed on this endpoint
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// The type of endpoint
    /// </summary>
    [JsonPropertyName("type")]
    public required Type7 Type { get; init; }

    /// <summary>
    /// The owner of this endpoint
    /// </summary>
    [JsonPropertyName("owner")]
    public required string Owner { get; init; }

    /// <summary>
    /// Current state of the endpoint
    /// </summary>
    [JsonPropertyName("state")]
    public required State8 State { get; init; }

    /// <summary>
    /// Timestamp when the endpoint was created
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
