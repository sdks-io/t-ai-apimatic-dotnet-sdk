using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Derived runtime progress for a rollout.
/// </summary>
public record DeRolloutStatus
{
    /// <summary>
    /// Total number of steps in the rollout progression. Always serializes when status is present.
    /// </summary>
    [JsonPropertyName("totalSteps")]
    public required int TotalSteps { get; init; }

    /// <summary>
    /// Failure detail set when the rollout pauses, system-pauses, or aborts; carries the human-readable reason and structured detail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("condition")]
    public DeRolloutCondition? Condition { get; init; }

    /// <summary>
    /// Per-step rollout execution summaries.
    /// </summary>
    [JsonPropertyName("steps")]
    public required IReadOnlyList<DeRolloutStepStatus> Steps { get; init; }

    /// <summary>
    /// Timestamp of the most recent progress update.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? UpdatedAt { get; init; }

    /// <summary>
    /// Informational conditions that describe the rollout's current state. Omitted when empty; clients should treat an absent key as an empty list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("conditions")]
    public IReadOnlyList<DeRolloutCondition>? Conditions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
