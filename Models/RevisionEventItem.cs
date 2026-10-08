using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// One entry in a deployment's revision history.
/// </summary>
public record RevisionEventItem
{
    /// <summary>
    /// The object type, which is always <c>revision_event</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "revision_event";

    /// <summary>
    /// Monotonic event number in the deployment's revision history.
    /// </summary>
    [JsonPropertyName("event_number")]
    public required int EventNumber { get; init; }

    /// <summary>
    /// Revision ID activated by this event.
    /// </summary>
    [JsonPropertyName("revision_id")]
    public required string RevisionId { get; init; }

    /// <summary>
    /// Human-readable per-deployment revision counter.
    /// </summary>
    [JsonPropertyName("revision_number")]
    public required int RevisionNumber { get; init; }

    /// <summary>
    /// Container image of the revision activated by this event.
    /// </summary>
    [JsonPropertyName("image")]
    public required string Image { get; init; }

    /// <summary>
    /// How this revision became active.
    /// </summary>
    [JsonPropertyName("action")]
    public required ActionEnum Action { get; init; }

    /// <summary>
    /// Time when this revision became active.
    /// </summary>
    [JsonPropertyName("activated_at")]
    public required DateTimeOffset ActivatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
