using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Pause metadata returned while a rollout is paused.
/// </summary>
public record DePauseInfo
{
    /// <summary>
    /// Human-readable reason recorded when the rollout was paused.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// Timestamp when the rollout was paused.
    /// </summary>
    [JsonPropertyName("pausedAt")]
    public required DateTimeOffset PausedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
