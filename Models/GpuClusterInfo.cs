using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record GpuClusterInfo
{
    [JsonPropertyName("cluster_id")]
    public required string ClusterId { get; init; }

    /// <summary>
    /// Type of cluster.
    /// </summary>
    [JsonPropertyName("cluster_type")]
    public required ClusterType1 ClusterType { get; init; }

    [JsonPropertyName("region")]
    public required string Region { get; init; }

    [JsonPropertyName("gpu_type")]
    public required GpuType4 GpuType { get; init; }

    [JsonPropertyName("cluster_name")]
    public required string ClusterName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration_hours")]
    public int? DurationHours { get; init; }

    [JsonPropertyName("volumes")]
    public required IReadOnlyList<GpuClusterVolume> Volumes { get; init; }

    /// <summary>
    /// Current status of the GPU cluster.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status2 Status { get; init; }

    [JsonPropertyName("control_plane_nodes")]
    public required IReadOnlyList<GpuClusterControlPlaneNode> ControlPlaneNodes { get; init; }

    [JsonPropertyName("gpu_worker_nodes")]
    public required IReadOnlyList<GpuClusterGpuWorkerNode> GpuWorkerNodes { get; init; }

    [JsonPropertyName("kube_config")]
    public required string KubeConfig { get; init; }

    [JsonPropertyName("num_gpus")]
    public required int NumGpus { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("slurm_shm_size_gib")]
    public int? SlurmShmSizeGib { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capacity_pool_id")]
    public string? CapacityPoolId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reservation_start_time")]
    public DateTimeOffset? ReservationStartTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reservation_end_time")]
    public DateTimeOffset? ReservationEndTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("install_traefik")]
    public bool? InstallTraefik { get; init; }

    [JsonPropertyName("cuda_version")]
    public required string CudaVersion { get; init; }

    [JsonPropertyName("nvidia_driver_version")]
    public required string NvidiaDriverVersion { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oidc_config")]
    public OidcConfig? OidcConfig { get; init; }

    [JsonPropertyName("project_id")]
    public required string ProjectId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cluster_config")]
    public InstanceClusterConfig? ClusterConfig { get; init; }

    /// <summary>
    /// Number of CPU-only worker nodes in the cluster.
    /// </summary>
    [JsonPropertyName("num_cpu_workers")]
    public required int NumCpuWorkers { get; init; }

    /// <summary>
    /// Cluster-level phase transition history.
    /// </summary>
    [JsonPropertyName("phase_transitions")]
    public required IReadOnlyList<ClusterPhaseTransition> PhaseTransitions { get; init; }

    /// <summary>
    /// Customer's requested number of preemptible GPUs. Set on cluster create or update; persists until changed.
    /// </summary>
    [JsonPropertyName("desired_preemptible_gpus")]
    public required int DesiredPreemptibleGpus { get; init; }

    /// <summary>
    /// Actual number of preemptible GPUs currently allocated to the cluster. Updated asynchronously by the fulfillment and reclamation workers; may be less than desired_preemptible_gpus when capacity is constrained.
    /// </summary>
    [JsonPropertyName("allocated_preemptible_gpus")]
    public required int AllocatedPreemptibleGpus { get; init; }

    /// <summary>
    /// Billing type for the cluster (RESERVED, ON_DEMAND, or SCHEDULED_CAPACITY).
    /// </summary>
    [JsonPropertyName("billing_type")]
    public required BillingType1 BillingType { get; init; }

    /// <summary>
    /// Enabled add-ons on this cluster. Only add-ons with enabled=true in their config are returned.
    /// </summary>
    [JsonPropertyName("add_ons")]
    public required IReadOnlyList<AddOnInfo> AddOns { get; init; }

    /// <summary>
    /// ID of the machine cluster backing this GPU cluster.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("machine_cluster_id")]
    public string? MachineClusterId { get; init; }

    /// <summary>
    /// Timestamp when the cluster first reached the Ready phase.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("first_ready_at")]
    public DateTimeOffset? FirstReadyAt { get; init; }

    /// <summary>
    /// Whether the cluster is managed inside a substrate environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_in_substrate")]
    public bool? IsInSubstrate { get; init; }

    /// <summary>
    /// Whether the control plane is currently ready.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("control_plane_ready")]
    public bool? ControlPlaneReady { get; init; }

    /// <summary>
    /// UMS project ID associated with this cluster.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ums_project_id")]
    public string? UmsProjectId { get; init; }

    /// <summary>
    /// UMS organization ID associated with this cluster.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ums_org_id")]
    public string? UmsOrgId { get; init; }

    /// <summary>
    /// Data-volume image name for GPU worker nodes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("os_image")]
    public string? OsImage { get; init; }

    /// <summary>
    /// Internal NVIDIA version ID for this cluster's driver and CUDA combination.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nvidia_driver_version_id")]
    public string? NvidiaDriverVersionId { get; init; }

    /// <summary>
    /// Number of GPUs to draw from a capacity pool. A component of the overall num_gpus, alongside num_reserved_gpus.
    /// </summary>
    [JsonPropertyName("num_capacity_pool_gpus")]
    public required int NumCapacityPoolGpus { get; init; }

    /// <summary>
    /// Number of prepaid reserved GPUs for this cluster. A component of the overall num_gpus, alongside num_capacity_pool_gpus.
    /// </summary>
    [JsonPropertyName("num_reserved_gpus")]
    public required int NumReservedGpus { get; init; }

    /// <summary>
    /// GPU worker nodes retained after they left the live data plane. These are separate from gpu_worker_nodes and must not be counted as live capacity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deleted_gpu_worker_nodes")]
    public IReadOnlyList<GpuClusterGpuWorkerNode>? DeletedGpuWorkerNodes { get; init; }

    /// <summary>
    /// Recent node lifecycle events such as scale-up, scale-down, and preemption. Combine these with live and deleted node lists to render the cluster timeline.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("node_lifecycle_events")]
    public IReadOnlyList<GpuClusterNodeLifecycleEvent>? NodeLifecycleEvents { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
