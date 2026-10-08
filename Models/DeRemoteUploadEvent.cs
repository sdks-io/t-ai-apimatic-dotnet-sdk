using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Progress or diagnostic event emitted while importing remote model files.
/// </summary>
public record DeRemoteUploadEvent
{
    /// <summary>
    /// Unique event identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Time when the event was recorded.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Severity of the event.
    /// </summary>
    [JsonPropertyName("level")]
    public required Level Level { get; init; }

    /// <summary>
    /// Stable event type emitted by the importer, such as <c>download.started</c>.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Human-readable progress or diagnostic message.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
