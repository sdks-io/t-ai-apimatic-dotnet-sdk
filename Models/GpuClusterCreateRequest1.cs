using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record GpuClusterCreateRequest1
{
    /// <summary>
    /// Type of cluster to create.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cluster_type")]
    public ClusterType? ClusterType { get; init; }

    /// <summary>
    /// Region to create the GPU cluster in. Usable regions can be found from <c>client.clusters.list_regions()</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("region")]
    public string? Region { get; init; }

    /// <summary>
    /// Type of GPU to use in the cluster
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpu_type")]
    public GpuType3? GpuType { get; init; }

    /// <summary>
    /// Number of GPUs to allocate in the cluster. This must be multiple of 8. For example, 8, 16 or 24
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_gpus")]
    public int? NumGpus { get; init; }

    /// <summary>
    /// Name of the GPU cluster.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cluster_name")]
    public string? ClusterName { get; init; }

    /// <summary>
    /// Duration in days to keep the cluster running.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration_days")]
    public int? DurationDays { get; init; }

    /// <summary>
    /// Inline configuration to create a shared volume with the cluster creation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shared_volume")]
    public GpuClustersSharedVolumeCreateRequest2? SharedVolume { get; init; }

    /// <summary>
    /// ID of an existing volume to use with the cluster creation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volume_id")]
    public string? VolumeId { get; init; }

    /// <summary>
    /// RESERVED billing types allow you to specify the duration of the cluster reservation via the duration_days field.
    /// ON_DEMAND billing types will give you ownership of the cluster until you delete it.
    /// SCHEDULED_CAPACITY billing types allow you to reserve capacity for a scheduled time window. You must specify the reservation_start_time and reservation_end_time with this request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billing_type")]
    public BillingType? BillingType { get; init; }

    /// <summary>
    /// Whether GPU cluster should be auto-scaled based on the workload. By default, it is not auto-scaled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_scaled")]
    public bool? AutoScaled { get; init; } = false;

    /// <summary>
    /// Maximum number of GPUs to which the cluster can be auto-scaled up. This field is required if auto_scaled is true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_scale_max_gpus")]
    public int? AutoScaleMaxGpus { get; init; }

    /// <summary>
    /// Shared memory size in GiB for Slurm cluster. This field is required if cluster_type is SLURM.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("slurm_shm_size_gib")]
    public int? SlurmShmSizeGib { get; init; }

    /// <summary>
    /// ID of the capacity pool to use for the cluster. This field is optional and only applicable if the cluster is created from a capacity pool.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capacity_pool_id")]
    public string? CapacityPoolId { get; init; }

    /// <summary>
    /// Reservation start time of the cluster. This field is required for SCHEDULED billing to specify the reservation start time for the cluster. If not provided, the cluster provisions immediately.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reservation_start_time")]
    public DateTimeOffset? ReservationStartTime { get; init; }

    /// <summary>
    /// Reservation end time of the cluster. This field is required for SCHEDULED billing to specify the reservation end time for the cluster.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reservation_end_time")]
    public DateTimeOffset? ReservationEndTime { get; init; }

    /// <summary>
    /// Whether to install Traefik ingress controller in the cluster. This field is only applicable for Kubernetes clusters and is false by default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("install_traefik")]
    public bool? InstallTraefik { get; init; } = false;

    /// <summary>
    /// Legacy CUDA selector for this cluster. Bare semantic values such as 12.5 select ubuntu-22.04; existing OS-suffixed values remain accepted for compatibility. Must be paired with nvidia_driver_version. Prefer nvidia_version_id for new integrations.
    /// </summary>
    [JsonPropertyName("cuda_version")]
    public required string CudaVersion { get; init; }

    /// <summary>
    /// Legacy NVIDIA driver selector for this cluster. For example, 550. Must be paired with cuda_version. Prefer nvidia_version_id for new integrations.
    /// </summary>
    [JsonPropertyName("nvidia_driver_version")]
    public required string NvidiaDriverVersion { get; init; }

    /// <summary>
    /// Canonical region-specific NVIDIA version ID. If cuda_version and nvidia_driver_version are also set, they must resolve to the same catalog entry.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nvidia_version_id")]
    public string? NvidiaVersionId { get; init; }

    /// <summary>
    /// Custom Slurm image for Slurm clusters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("slurm_image")]
    public string? SlurmImage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oidc_config")]
    public OidcConfig? OidcConfig { get; init; }

    /// <summary>
    /// Project ID for the cluster. If not set, the project from the request context is used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("project_id")]
    public string? ProjectId { get; init; }

    /// <summary>
    /// AcceptanceTestsParams groups all GPU acceptance test options when enabled is true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acceptance_tests_params")]
    public AcceptanceTestsParams? AcceptanceTestsParams { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cluster_config")]
    public InstanceClusterConfig? ClusterConfig { get; init; }

    /// <summary>
    /// Number of GPUs to allocate from the capacity pool. Must be a multiple of 8 and not exceed num_gpus.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_capacity_pool_gpus")]
    public int? NumCapacityPoolGpus { get; init; }

    /// <summary>
    /// Whether to enable auto-scaling for the cluster. If true, the cluster will automatically scale the number of GPU worker nodes between num_gpus and auto_scale_max_gpus based on the workload.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_scale")]
    public bool? AutoScale { get; init; }

    /// <summary>
    /// Number of preemptible GPUs to request alongside on-demand capacity. Must be a multiple of 8. Preemptible nodes are cheaper but may be reclaimed when on-demand capacity is needed elsewhere; the system fulfills this asynchronously and surfaces the actual count in allocated_preemptible_gpus.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_preemptible_gpus")]
    public int? NumPreemptibleGpus { get; init; }

    /// <summary>
    /// Number of prepaid (PLG) reserved GPUs for this cluster. When omitted for RESERVED billing on create, the server defaults this to num_gpus.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_reserved_gpus")]
    public int? NumReservedGpus { get; init; }

    /// <summary>
    /// Add-ons to enable on the cluster at creation time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("add_ons")]
    public IReadOnlyList<AddOnCreateRequest>? AddOns { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
