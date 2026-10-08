using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record GpuClusterUpdateRequest
{
    /// <summary>
    /// Type of cluster to update.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cluster_type")]
    public ClusterType2? ClusterType { get; init; }

    /// <summary>
    /// Target GPU count for the cluster. When omitted, the server keeps the current GPU count from cluster metadata (use for config-only or decommission-time-only updates).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_gpus")]
    public int? NumGpus { get; init; }

    /// <summary>
    /// Timestamp at which the cluster should be decommissioned. Only accepted for prepaid clusters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reservation_end_time")]
    public DateTimeOffset? ReservationEndTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cluster_config")]
    public InstanceClusterConfig? ClusterConfig { get; init; }

    /// <summary>
    /// Number of reserved GPUs to update to. This field is only applicable for clusters with RESERVED billing type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_reserved_gpus")]
    public int? NumReservedGpus { get; init; }

    /// <summary>
    /// Updated desired number of preemptible GPUs for the cluster. When omitted, the current value is preserved. Must be a multiple of 8.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_preemptible_gpus")]
    public int? NumPreemptibleGpus { get; init; }

    /// <summary>
    /// Number of GPUs to draw from the cluster's capacity pool. Only valid for clusters created with a capacity_pool_id. Must be a multiple of 8 and not exceed num_gpus. When omitted, the current value is preserved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_capacity_pool_gpus")]
    public int? NumCapacityPoolGpus { get; init; }

    /// <summary>
    /// Add-ons to update on the cluster. Each entry identifies an existing add-on by name and provides the new external config to merge.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("add_ons")]
    public IReadOnlyList<AddOnUpdateRequest>? AddOns { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
