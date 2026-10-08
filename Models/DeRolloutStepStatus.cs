using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Collapsed execution state for one rollout step.
/// </summary>
public record DeRolloutStepStatus
{
    /// <summary>
    /// Index of this step in the rollout progression. Step 0 serializes explicitly.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stepIndex")]
    public int? StepIndex { get; init; }

    /// <summary>
    /// Target traffic percentage configured for this step. Always serializes for recorded steps.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetTrafficPercent")]
    public int? TargetTrafficPercent { get; init; }

    /// <summary>
    /// Outcome of this step. Finished steps are PASSED, the live step mirrors the rollout state, skipped-over steps are SKIPPED, and unreached steps are PENDING.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public State4? State { get; init; }

    /// <summary>
    /// Metric gate results for this step, enriched with criteria and verdict. Unmeasured rules appear as synthesized rows with verdict METRIC_VERDICT_UNAVAILABLE and no measured values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metrics")]
    public IReadOnlyList<DeMetricResult>? Metrics { get; init; }

    /// <summary>
    /// Timestamp when this step's first sub-step ran. Unset for steps no sub-step reached.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startedAt")]
    public DateTimeOffset? StartedAt { get; init; }

    /// <summary>
    /// Timestamp when this step finished, was skipped over, or the rollout ended on it. Unset while in progress.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completedAt")]
    public DateTimeOffset? CompletedAt { get; init; }

    /// <summary>
    /// Failure reason set only when this step failed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
