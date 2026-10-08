using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Validation.Attributes;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record CreateDeploymentRequest
{
    /// <summary>
    /// Args overrides the container's CMD. Provide as an array of arguments (e.g., ["python", "app.py"])
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("args")]
    public IReadOnlyList<string>? Args { get; init; }

    /// <summary>
    /// Autoscaling configuration. Example: {"metric": "QueueBacklogPerWorker", "target": 1.01} to scale based on queue backlog. Omit or set to null to disable autoscaling
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoscaling")]
    public Autoscaling31? Autoscaling { get; init; }

    /// <summary>
    /// Controls how replicas above reserved capacity behave. <c>stable</c> replicas stay running after scale-up; <c>preemptible</c> replicas may be evicted during capacity contention.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capacity_type")]
    public CapacityType? CapacityType { get; init; }

    /// <summary>
    /// Command overrides the container's ENTRYPOINT. Provide as an array (e.g., ["/bin/sh", "-c"])
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("command")]
    public IReadOnlyList<string>? Command { get; init; }

    /// <summary>
    /// CPU is the number of CPU cores to allocate per container instance (e.g., 0.1 = 100 milli cores)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cpu")]
    [Minimum(0.1)]
    public double? Cpu { get; init; }

    /// <summary>
    /// Description is an optional human-readable description of your deployment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// EnvironmentVariables is a list of environment variables to set in the container. Each must have a name and either a value or value_from_secret
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("environment_variables")]
    public IReadOnlyList<EnvironmentVariable>? EnvironmentVariables { get; init; }

    /// <summary>
    /// GPUCount is the number of GPUs to allocate per container instance. Defaults to 0 if not specified
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpu_count")]
    public int? GpuCount { get; init; }

    /// <summary>
    /// GPUType specifies the GPU hardware to use (e.g., "h100-80gb").
    /// </summary>
    [JsonPropertyName("gpu_type")]
    public required GpuType5 GpuType { get; init; }

    /// <summary>
    /// HealthCheckPath is the HTTP path for health checks (e.g., "/health"). If set, the platform checks this endpoint to determine container health.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("health_check_path")]
    public string? HealthCheckPath { get; init; }

    /// <summary>
    /// Image is the container image to deploy from registry.together.ai.
    /// </summary>
    [JsonPropertyName("image")]
    public required string Image { get; init; }

    /// <summary>
    /// MaxReplicas is the maximum number of container instances. Defaults to MinReplicas if not set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_replicas")]
    public int? MaxReplicas { get; init; }

    /// <summary>
    /// Memory is the amount of RAM to allocate per container instance in GiB (e.g., 0.5 = 512MiB)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("memory")]
    [Maximum(1000.0)]
    public double? Memory { get; init; }

    /// <summary>
    /// MinReplicas is the minimum number of container instances to run. Defaults to 1 if not specified
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_replicas")]
    public int? MinReplicas { get; init; }

    /// <summary>
    /// Model weights to preload from Together's model registry into the container. At most one mount is supported, and it cannot be used with volumes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_mounts")]
    public IReadOnlyList<ModelMount>? ModelMounts { get; init; }

    /// <summary>
    /// Name is the unique identifier for your deployment. Must contain lowercase letters, numbers, or hyphens, start with a lowercase letter or number, and be 4-63 characters. It cannot be changed.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(63, MinimumLength = 4)]
    public required string Name { get; init; }

    /// <summary>
    /// Port is the container port your application listens on (e.g., 8080 for web servers). Required if your application serves traffic
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("port")]
    [Minimum(1)]
    [Maximum(65535)]
    public int? Port { get; init; }

    /// <summary>
    /// Storage is the amount of ephemeral disk storage to allocate per container instance (e.g., 10 = 10GiB)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storage")]
    [Maximum(400)]
    public int? Storage { get; init; }

    /// <summary>
    /// TerminationGracePeriodSeconds is the time in seconds to wait for graceful shutdown before forcefully terminating the replica
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("termination_grace_period_seconds")]
    public int? TerminationGracePeriodSeconds { get; init; }

    /// <summary>
    /// Volumes is a list of volume mounts to attach to the container. Each mount must reference an existing volume by name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volumes")]
    public IReadOnlyList<VolumeMount>? Volumes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
