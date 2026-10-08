using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Remediation represents a node remediation request for an instance.
/// An instance can have multiple remediations over time (e.g., failed attempts followed by retries).
/// </summary>
public record Remediation
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("cluster_id")]
    public required string ClusterId { get; init; }

    [JsonPropertyName("instance_id")]
    public required string InstanceId { get; init; }

    /// <summary>
    /// Remediation mode specifies how the remediation should be performed.
    /// <list type="bullet">
    ///   <item><description><c>REMEDIATION_MODE_VM_ONLY</c>: Deletes the VM and provisions a new one on any available host.</description></item>
    ///   <item><description><c>REMEDIATION_MODE_HOST_AWARE</c>: Cordons the host, deletes the VM, and provisions a new one on a different host.</description></item>
    ///   <item><description><c>REMEDIATION_MODE_EVICT_WITHOUT_REPLACEMENT</c>: Evicts the VM without provisioning a replacement.</description></item>
    ///   <item><description><c>REMEDIATION_MODE_REBOOT_VM</c>: Reboots the VM in place.</description></item>
    ///   <item><description><c>REMEDIATION_MODE_HOST_POWER_CYCLE</c>: Cordons and power-cycles the bare-metal host while preserving host and node identity.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("mode")]
    public required Mode Mode { get; init; }

    /// <summary>
    /// RemediationTrigger specifies how the remediation was triggered.
    /// <list type="bullet">
    ///   <item><description><c>REMEDIATION_TRIGGER_MANUAL</c>: A user-initiated remediation (either via web UI or API call).</description></item>
    ///   <item><description><c>REMEDIATION_TRIGGER_AUTOMATED</c>: A system-initiated remediation that requires approval.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("trigger")]
    public required Trigger Trigger { get; init; }

    /// <summary>
    /// RemediationState represents the lifecycle state of a remediation.
    /// <list type="bullet">
    ///   <item><description><c>PENDING_APPROVAL</c>: Awaiting approval before processing can begin.</description></item>
    ///   <item><description><c>PENDING</c>: Approved and queued for processing.</description></item>
    ///   <item><description><c>RUNNING</c>: Actively being processed.</description></item>
    ///   <item><description><c>SUCCEEDED</c>: Successfully completed.</description></item>
    ///   <item><description><c>FAILED</c>: Failed with an error.</description></item>
    ///   <item><description><c>CANCELLED</c>: Cancelled by user or system.</description></item>
    ///   <item><description><c>AUTO_RESOLVED</c>: The underlying issue was automatically resolved before processing.</description></item>
    ///   <item><description><c>QUARANTINING</c>: Cordoning or preparing the host before remediation.</description></item>
    ///   <item><description><c>QUARANTINED</c>: Host has been cordoned or isolated for remediation.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("state")]
    public required State6 State { get; init; }

    /// <summary>
    /// User-provided reason for the remediation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// Active health check run ID (UUID) that triggered this remediation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active_health_check_run_id")]
    public string? ActiveHealthCheckRunId { get; init; }

    /// <summary>
    /// Passive health check event ID that triggered this remediation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passive_health_check_event_id")]
    public string? PassiveHealthCheckEventId { get; init; }

    /// <summary>
    /// Who requested the remediation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requested_by")]
    public string? RequestedBy { get; init; }

    /// <summary>
    /// When the remediation was created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("create_time")]
    public DateTimeOffset? CreateTime { get; init; }

    /// <summary>
    /// Who reviewed the remediation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reviewed_by")]
    public string? ReviewedBy { get; init; }

    /// <summary>
    /// When the remediation was reviewed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("review_time")]
    public DateTimeOffset? ReviewTime { get; init; }

    /// <summary>
    /// Review comment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("review_comment")]
    public string? ReviewComment { get; init; }

    /// <summary>
    /// When processing started.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_time")]
    public DateTimeOffset? StartTime { get; init; }

    /// <summary>
    /// When the remediation completed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_time")]
    public DateTimeOffset? EndTime { get; init; }

    /// <summary>
    /// Error message if the remediation failed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; init; }

    /// <summary>
    /// When the remediation was last updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("update_time")]
    public DateTimeOffset? UpdateTime { get; init; }

    /// <summary>
    /// Display name of the targeted instance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instance_name")]
    public string? InstanceName { get; init; }

    /// <summary>
    /// Passive health check alerts linked to this remediation, including resolved alerts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("linked_alerts")]
    public IReadOnlyList<PassiveHealthCheckAlert>? LinkedAlerts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
