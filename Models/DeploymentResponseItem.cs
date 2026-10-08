using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record DeploymentResponseItem
{
    /// <summary>
    /// Args are the arguments passed to the container's command
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("args")]
    public IReadOnlyList<string>? Args { get; init; }

    /// <summary>
    /// Autoscaling contains autoscaling configuration parameters for this deployment. Omitted when autoscaling is disabled (nil)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoscaling")]
    public Autoscaling311? Autoscaling { get; init; }

    /// <summary>
    /// Controls how replicas above reserved capacity behave. <c>stable</c> replicas stay running after scale-up; <c>preemptible</c> replicas may be evicted during capacity contention.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capacity_type")]
    public CapacityType? CapacityType { get; init; }

    /// <summary>
    /// Command is the entrypoint command run in the container
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("command")]
    public IReadOnlyList<string>? Command { get; init; }

    /// <summary>
    /// CPU is the amount of CPU resource allocated to each replica in cores (fractional value is allowed)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cpu")]
    public double? Cpu { get; init; }

    /// <summary>
    /// CreatedAt is the ISO8601 timestamp when this deployment was created
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// Description provides a human-readable explanation of the deployment's purpose or content
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// DesiredReplicas is the number of replicas that the orchestrator is targeting
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("desired_replicas")]
    public int? DesiredReplicas { get; init; }

    /// <summary>
    /// EnvironmentVariables is a list of environment variables set in the container
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("environment_variables")]
    public IReadOnlyList<EnvironmentVariable>? EnvironmentVariables { get; init; }

    /// <summary>
    /// GPUCount is the number of GPUs allocated to each replica in this deployment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpu_count")]
    public int? GpuCount { get; init; }

    /// <summary>
    /// GPUType specifies the type of GPU requested (if any) for this deployment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpu_type")]
    public GpuType6? GpuType { get; init; }

    /// <summary>
    /// HealthCheckPath is the HTTP path used for health checks of the application
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("health_check_path")]
    public string? HealthCheckPath { get; init; }

    /// <summary>
    /// ID is the unique identifier of the deployment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Image specifies the container image used for this deployment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image")]
    public string? Image { get; init; }

    /// <summary>
    /// MaxReplicas is the maximum number of replicas to run for this deployment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_replicas")]
    public int? MaxReplicas { get; init; }

    /// <summary>
    /// Memory is the amount of memory allocated to each replica in GiB (fractional value is allowed)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("memory")]
    public double? Memory { get; init; }

    /// <summary>
    /// MinReplicas is the minimum number of replicas to run for this deployment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_replicas")]
    public int? MinReplicas { get; init; }

    /// <summary>
    /// Model weights mounted into this deployment, including the pinned revisions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_mounts")]
    public IReadOnlyList<ModelMount>? ModelMounts { get; init; }

    /// <summary>
    /// Name is the name of the deployment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The object type, which is always <c>deployment</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public Object3? Object { get; init; }

    /// <summary>
    /// Port is the container port that the deployment exposes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("port")]
    public int? Port { get; init; }

    /// <summary>
    /// ReadyReplicas is the current number of replicas that are in the Ready state
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ready_replicas")]
    public int? ReadyReplicas { get; init; }

    /// <summary>
    /// ReplicaEvents is a mapping of replica names or IDs to their status events
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replica_events")]
    public IReadOnlyDictionary<string, ReplicaEvent>? ReplicaEvents { get; init; }

    /// <summary>
    /// Status represents the overall status of the deployment (e.g., Updating, Scaling, Ready, Failed)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public DeploymentStatus? Status { get; init; }

    /// <summary>
    /// Storage is the amount of storage (in MB or units as defined by the platform) allocated to each replica
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storage")]
    public int? Storage { get; init; }

    /// <summary>
    /// TerminationGracePeriodSeconds is the time in seconds to wait for graceful shutdown before forcefully terminating the replica
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("termination_grace_period_seconds")]
    public int? TerminationGracePeriodSeconds { get; init; }

    /// <summary>
    /// UpdatedAt is the ISO8601 timestamp when this deployment was last updated
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; init; }

    /// <summary>
    /// Volumes is a list of volume mounts for this deployment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volumes")]
    public IReadOnlyList<VolumeMount>? Volumes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
