using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Deployment configuration captured for one retained revision.
/// </summary>
public record RevisionDetailResponse
{
    /// <summary>
    /// The object type, which is always <c>revision</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "revision";

    /// <summary>
    /// Unique revision identifier.
    /// </summary>
    [JsonPropertyName("revision_id")]
    public required string RevisionId { get; init; }

    /// <summary>
    /// Container image used by this revision.
    /// </summary>
    [JsonPropertyName("image")]
    public required string Image { get; init; }

    /// <summary>
    /// Minimum number of replicas configured for this revision.
    /// </summary>
    [JsonPropertyName("min_replicas")]
    public required int MinReplicas { get; init; }

    /// <summary>
    /// Maximum number of replicas configured for this revision.
    /// </summary>
    [JsonPropertyName("max_replicas")]
    public required int MaxReplicas { get; init; }

    /// <summary>
    /// Container port exposed by this revision.
    /// </summary>
    [JsonPropertyName("port")]
    public required int Port { get; init; }

    /// <summary>
    /// Network protocol served by the deployment revision.
    /// </summary>
    [JsonPropertyName("protocol")]
    public required string Protocol { get; init; }

    /// <summary>
    /// Capacity behavior for replicas above reserved capacity.
    /// </summary>
    [JsonPropertyName("capacity_type")]
    public required CapacityType2 CapacityType { get; init; }

    /// <summary>
    /// Entrypoint command run by the container.
    /// </summary>
    [JsonPropertyName("command")]
    public required IReadOnlyList<string> Command { get; init; }

    /// <summary>
    /// Arguments passed to the container command.
    /// </summary>
    [JsonPropertyName("args")]
    public required IReadOnlyList<string> Args { get; init; }

    /// <summary>
    /// Environment variables configured on this revision.
    /// </summary>
    [JsonPropertyName("environment_variables")]
    public required IReadOnlyList<EnvironmentVariable> EnvironmentVariables { get; init; }

    /// <summary>
    /// Volume mounts attached to this revision.
    /// </summary>
    [JsonPropertyName("volumes")]
    public required IReadOnlyList<VolumeMount> Volumes { get; init; }

    /// <summary>
    /// GPU hardware type configured for this revision.
    /// </summary>
    [JsonPropertyName("gpu_type")]
    public required string GpuType { get; init; }

    /// <summary>
    /// Number of GPUs allocated to each replica.
    /// </summary>
    [JsonPropertyName("gpu_count")]
    public required int GpuCount { get; init; }

    /// <summary>
    /// CPU cores allocated to each replica.
    /// </summary>
    [JsonPropertyName("cpu")]
    public required double Cpu { get; init; }

    /// <summary>
    /// Memory allocated to each replica in GiB.
    /// </summary>
    [JsonPropertyName("memory")]
    public required double Memory { get; init; }

    /// <summary>
    /// Ephemeral storage allocated to each replica.
    /// </summary>
    [JsonPropertyName("storage")]
    public required int Storage { get; init; }

    /// <summary>
    /// HTTP path used for health checks.
    /// </summary>
    [JsonPropertyName("health_check_path")]
    public required string HealthCheckPath { get; init; }

    /// <summary>
    /// Autoscaling configuration captured for this revision.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoscaling")]
    public Autoscaling32? Autoscaling { get; init; }

    /// <summary>
    /// Seconds to wait for graceful shutdown before forcefully terminating a replica.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("termination_grace_period_seconds")]
    public int? TerminationGracePeriodSeconds { get; init; }

    /// <summary>
    /// Time when this revision was created.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
