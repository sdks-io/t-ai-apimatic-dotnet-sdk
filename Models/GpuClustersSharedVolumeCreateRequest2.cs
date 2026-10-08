using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Inline configuration to create a shared volume with the cluster creation.
/// </summary>
public record GpuClustersSharedVolumeCreateRequest2
{
    /// <summary>
    /// User provided name of the volume.
    /// </summary>
    [JsonPropertyName("volume_name")]
    public required string VolumeName { get; init; }

    /// <summary>
    /// Volume size in whole tebibytes (TiB).
    /// </summary>
    [JsonPropertyName("size_tib")]
    public required int SizeTib { get; init; }

    /// <summary>
    /// Region name. Usable regions can be found from <c>clusters.list_regions()</c>
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; init; }

    /// <summary>
    /// When true, the shared volume is not deleted when the cluster is decommissioned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_lifecycle_independent")]
    public bool? IsLifecycleIndependent { get; init; }

    /// <summary>
    /// Project ID that will own the volume. When omitted, the caller's default project is used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("project_id")]
    public string? ProjectId { get; init; }

    /// <summary>
    /// Cluster ID to pin the volume to the same substrate as that GPU cluster.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instance_cluster_id")]
    public string? InstanceClusterId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
