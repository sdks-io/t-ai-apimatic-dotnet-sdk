using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Structured detail for the training session's current error. Set when the session is in an error state.
/// </summary>
public record RlTrainingSessionError1
{
    /// <summary>
    /// Finite machine-readable reason code for UI branching
    /// </summary>
    [JsonPropertyName("code")]
    public required RlTrainingSessionErrorCode2 Code { get; init; }

    /// <summary>
    /// User-safe human-readable detail for the current status
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }

    /// <summary>
    /// Timestamp when this error was reported
    /// </summary>
    [JsonPropertyName("occurred_at")]
    public required DateTimeOffset OccurredAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
