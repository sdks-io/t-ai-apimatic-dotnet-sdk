using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Passive health check alert returned by the health check API.
/// </summary>
public record PassiveHealthCheckAlert
{
    /// <summary>
    /// Primary key UUID for the passive health check alert.
    /// </summary>
    [JsonPropertyName("passive_health_check_alert_id")]
    public required string PassiveHealthCheckAlertId { get; init; }

    /// <summary>
    /// Resolved instance UUID. Empty until the alert is joined to an instance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instance_id")]
    public string? InstanceId { get; init; }

    /// <summary>
    /// Cluster UUID the alert was raised against.
    /// </summary>
    [JsonPropertyName("cluster_id")]
    public required string ClusterId { get; init; }

    /// <summary>
    /// VM name extracted from the Alertmanager labels.
    /// </summary>
    [JsonPropertyName("target_vm")]
    public required string TargetVm { get; init; }

    /// <summary>
    /// Alertmanager alert name.
    /// </summary>
    [JsonPropertyName("alert_name")]
    public required string AlertName { get; init; }

    /// <summary>
    /// Canonical severity tier for the alert.
    /// </summary>
    [JsonPropertyName("severity")]
    public required Severity Severity { get; init; }

    /// <summary>
    /// Legacy Alertmanager annotations as key-value strings.
    /// </summary>
    [JsonPropertyName("annotations")]
    public required IReadOnlyDictionary<string, string> Annotations { get; init; }

    /// <summary>
    /// Time when the underlying alert first fired.
    /// </summary>
    [JsonPropertyName("started_at")]
    public required DateTimeOffset StartedAt { get; init; }

    /// <summary>
    /// Time when the underlying alert resolved. Empty while the alert is firing.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resolved_at")]
    public DateTimeOffset? ResolvedAt { get; init; }

    /// <summary>
    /// Remediation intent UUID attached to this alert, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("node_remediation_intent_id")]
    public string? NodeRemediationIntentId { get; init; }

    /// <summary>
    /// Typed annotation content parsed from the legacy annotations bag.
    /// </summary>
    [JsonPropertyName("annotation")]
    public required PhcAnnotation Annotation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
