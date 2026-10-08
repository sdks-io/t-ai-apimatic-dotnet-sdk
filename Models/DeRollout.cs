using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Public view of a rollout resource, including runtime progress and any pause or abort reason.
/// </summary>
public record DeRollout
{
    /// <summary>
    /// Output only. Unique rollout identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Output only. Endpoint this rollout belongs to.
    /// </summary>
    [JsonPropertyName("endpointId")]
    public required string EndpointId { get; init; }

    /// <summary>
    /// Output only. Deployment that traffic is shifting away from.
    /// </summary>
    [JsonPropertyName("sourceDeploymentId")]
    public required string SourceDeploymentId { get; init; }

    /// <summary>
    /// Output only. Deployment that traffic is shifting toward.
    /// </summary>
    [JsonPropertyName("targetDeploymentId")]
    public required string TargetDeploymentId { get; init; }

    /// <summary>
    /// Output only. Rollout strategy selected at creation.
    /// </summary>
    [JsonPropertyName("strategy")]
    public required Strategy Strategy { get; init; }

    /// <summary>
    /// Output only. High-level rollout lifecycle state.
    /// </summary>
    [JsonPropertyName("state")]
    public required State3 State { get; init; }

    /// <summary>
    /// Output only. Zero-based index of the current step. Unset while PENDING; step 0 is reported explicitly after start.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currentStep")]
    public int? CurrentStep { get; init; }

    /// <summary>
    /// Output only. Applied percentage of traffic on the target deployment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currentTrafficPercent")]
    public int? CurrentTrafficPercent { get; init; }

    /// <summary>
    /// Output only. Timestamp when the rollout was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Output only. Timestamp when the rollout started running.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startedAt")]
    public DateTimeOffset? StartedAt { get; init; }

    /// <summary>
    /// Output only. Timestamp when the rollout reached a terminal state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completedAt")]
    public DateTimeOffset? CompletedAt { get; init; }

    /// <summary>
    /// Output only. Opaque version tag for optimistic concurrency control.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("etag")]
    public string? Etag { get; init; }

    /// <summary>
    /// Output only. Derived runtime progress, step summary, and pause or abort failure details.
    /// </summary>
    [JsonPropertyName("status")]
    public required DeRolloutStatus Status { get; init; }

    /// <summary>
    /// Output only. Why and when the rollout was paused. Set while a pause is pending or effective (PAUSING, PAUSED, or SYSTEM_PAUSED) and cleared after resume or abort; while PAUSING, pausedAt records when the pause was requested.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pauseInfo")]
    public DePauseInfo? PauseInfo { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
