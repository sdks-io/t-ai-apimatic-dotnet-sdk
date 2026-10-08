using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Structured reason a rollout stopped progressing.
/// </summary>
public record DeRolloutCondition
{
    /// <summary>
    /// Category that classifies why the rollout stopped.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public Category? Category { get; init; }

    /// <summary>
    /// Human-readable explanation for the condition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// Step index where the condition arose. Step 0 serializes explicitly.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("atStep")]
    public int? AtStep { get; init; }

    /// <summary>
    /// Timestamp when the condition was observed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("observedAt")]
    public DateTimeOffset? ObservedAt { get; init; }

    /// <summary>
    /// Metrics observed at the failing gate, enriched with their criteria. Unmeasured rules appear as synthesized rows with verdict METRIC_VERDICT_UNAVAILABLE and no measured values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metrics")]
    public IReadOnlyList<DeMetricResult>? Metrics { get; init; }

    /// <summary>
    /// Informational condition type. <c>CapacityLimited</c> means the current step advanced partially because full capacity was not placeable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type2? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
