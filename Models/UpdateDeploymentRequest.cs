using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Core.Validation.Attributes;
using TogetherApIs.Models.AnyOf;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record UpdateDeploymentRequest
{
    /// <summary>
    /// Args overrides the container's CMD. Provide as an array of arguments (e.g., ["python", "app.py"])
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("args")]
    public IReadOnlyList<string>? Args { get; init; }

    /// <summary>
    /// Autoscaling configuration for the deployment. Set to {} to disable autoscaling
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoscaling")]
    public Autoscaling33? Autoscaling { get; init; }

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
    /// EnvironmentVariables is a list of environment variables to set in the container. Replaces all existing environment variables.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("environment_variables")]
    public IReadOnlyList<EnvironmentVariable>? EnvironmentVariables { get; init; }

    /// <summary>
    /// GPUCount is the number of GPUs to allocate per container instance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpu_count")]
    public int? GpuCount { get; init; }

    /// <summary>
    /// GPUType specifies the GPU hardware to use (e.g., "h100-80gb")
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpu_type")]
    public GpuType7? GpuType { get; init; }

    /// <summary>
    /// HealthCheckPath is the HTTP path for health checks (e.g., "/health"). Set to empty string to disable health checks
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("health_check_path")]
    public string? HealthCheckPath { get; init; }

    /// <summary>
    /// Image is the container image to deploy from registry.together.ai.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image")]
    public string? Image { get; init; }

    /// <summary>
    /// MaxReplicas is the maximum number of replicas that can be scaled up to.
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
    /// MinReplicas is the minimum number of replicas to run
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_replicas")]
    public int? MinReplicas { get; init; }

    /// <summary>
    /// Replacement model weights to mount into the deployment. At most one mount is supported, and it cannot be used with volumes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model_mounts")]
    public IReadOnlyList<ModelMount>? ModelMounts { get; init; }

    /// <summary>
    /// Name is the new unique identifier for your deployment. Must contain only alphanumeric characters, underscores, or hyphens (1-100 characters)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [StringLength(100, MinimumLength = 1)]
    public string? Name { get; init; }

    /// <summary>
    /// Port is the container port your application listens on (e.g., 8080 for web servers)
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
    /// Volumes is a list of volume mounts to attach to the container. Replaces all existing volumes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volumes")]
    public IReadOnlyList<VolumeMount>? Volumes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
